
import json
import os
import subprocess
import re
import sys
import time

API_JSON = "d:/Bannerlord_Mods/api_scan_results.json"
LIBS_DIR = "d:/Bannerlord_Mods/libs"
DECOMPILER = "d:/Bannerlord_Mods/Initialization/bin/ilspy.cmd"

# Priority DLLs to search
DLL_ORDER = [
    "TaleWorlds.CampaignSystem.dll",
    "TaleWorlds.Core.dll",
    "TaleWorlds.MountAndBlade.dll",
    "TaleWorlds.Library.dll",
    "TaleWorlds.Localization.dll",
    "TaleWorlds.ObjectSystem.dll",
    "TaleWorlds.Engine.dll",
    "TaleWorlds.ScreenSystem.dll",
    "TaleWorlds.SaveSystem.dll",
    "StoryMode.dll",
    "SandBox.dll"
]

NAMESPACES_TO_WATCH = [
    "TaleWorlds.CampaignSystem", 
    "TaleWorlds.CampaignSystem.Settlements", 
    "TaleWorlds.CampaignSystem.Party", 
    "TaleWorlds.CampaignSystem.Actions", 
    "TaleWorlds.CampaignSystem.MapEvents", 
    "TaleWorlds.CampaignSystem.Roster",
    "TaleWorlds.CampaignSystem.CharacterDevelopment",
    "TaleWorlds.Core", 
    "TaleWorlds.MountAndBlade", 
    "TaleWorlds.Library", 
    "TaleWorlds.Localization",
    "TaleWorlds.ObjectSystem",
    "TaleWorlds.SaveSystem",
    "TaleWorlds.ScreenSystem",
    "TaleWorlds.Engine",
    "StoryMode",
    "SandBox"
]

def log(msg):
    print(msg)
    sys.stdout.flush()

def decompile_type(dll_name, type_name):
    decomp_abs = os.path.abspath(DECOMPILER)
    dll_path = os.path.abspath(os.path.join(LIBS_DIR, dll_name))
    
    cmd = [decomp_abs, dll_path, "-t", type_name]
    
    try:
        # Added timeout to prevent hanging
        result = subprocess.run(cmd, capture_output=True, text=True, shell=True, encoding='utf-8', timeout=20)
        if result.returncode != 0:
            return "" 
        return result.stdout
    except subprocess.TimeoutExpired:
        log(f"  [WARN] Timeout decompiling {type_name} in {dll_name}")
        return ""
    except Exception as e:
        log(f"  [ERR] Exception during decomp: {e}")
        return ""

def verify_apis():
    log("Starting API Verification Process...")
    
    with open(API_JSON, 'r') as f:
        data = json.load(f)

    tasks = {} 
    
    for key in data.keys():
        cls = ""
        member = ""
        
        if key.startswith("Inherits "):
            cls = key.replace("Inherits ", "").strip()
            member = "CLASS_DEFINITION" 
        elif "." in key:
            parts = key.split(".")
            potential_ns = ".".join(parts)
            if potential_ns in NAMESPACES_TO_WATCH or potential_ns == "TaleWorlds.CampaignSystem":
                continue
                
            cls = ".".join(parts[:-1])
            member = parts[-1]
        else:
            continue

        if cls in ["TaleWorlds", "System", "Math"]: continue
        
        if cls not in tasks:
            tasks[cls] = { "members": set(), "found_in_dll": None, "source": "" }
        if member:
            tasks[cls]["members"].add(member)

    log(f"Identified {len(tasks)} unique types to verify.")

    count = 0
    total = len(tasks)
    
    for type_name in tasks:
        count += 1
        log(f"[{count}/{total}] Processing type: {type_name}")
        
        candidates = []
        if "." in type_name:
            candidates.append(type_name)
        
        for ns in NAMESPACES_TO_WATCH:
            candidates.append(f"{ns}.{type_name}")
            
        found = False
        for candidate in candidates:
            if found: break
            for dll in DLL_ORDER:
                src = decompile_type(dll, candidate)
                if ("public class" in src or "public struct" in src or "public static class" in src or "public abstract class" in src or "public enum" in src or "public sealed class" in src):
                    tasks[type_name]["source"] = src
                    tasks[type_name]["found_in_dll"] = dll
                    tasks[type_name]["full_name"] = candidate
                    log(f"  [OK] Found {candidate} in {dll}")
                    found = True
                    break
        
        if not found:
            log(f"  [FAIL] Could not locate {type_name}")

    log("Analyzing Sources...")
    verification_results = {}
    
    for type_name, info in tasks.items():
        src = info["source"]
        
        for member in info["members"]:
            full_key = f"{type_name}.{member}"
            if member == "CLASS_DEFINITION":
                full_key = f"Inherits {type_name}"
            
            if not src:
                verification_results[full_key] = { "status": "MISSING_TYPE", "signature": "Type not found in DLLs" }
                continue
            
            if member == "CLASS_DEFINITION":
                match = re.search(r'public.*class\s+\w+.*', src)
                sig = match.group(0).strip() if match else "Class found but signature parse failed"
                verification_results[full_key] = { "status": "VERIFIED", "signature": sig }
                continue
                
            lines = src.split('\n')
            found_sig = None
            
            for line in lines:
                if member in line:
                    stripped = line.strip()
                    if re.match(r'.*(public|protected|internal|event).*'+ re.escape(member) + r'.*', stripped):
                         found_sig = stripped
                         break
            
            if found_sig:
                 verification_results[full_key] = { "status": "VERIFIED", "signature": found_sig }
            else:
                 verification_results[full_key] = { "status": "MISSING_MEMBER", "signature": f"Member '{member}' not found in {type_name}" }

    with open("d:/Bannerlord_Mods/API_VERIFICATION_REPORT.json", "w") as f:
        json.dump(verification_results, f, indent=2)

    with open("d:/Bannerlord_Mods/API_VERIFICATION_REPORT.md", "w") as f:
        f.write("# API Verification Report\n\n")
        f.write("Validation of scanned APIs against actual Game DLLs using ILSpy.\n\n")
        f.write("| API | Status | Verified Signature / Error |\n")
        f.write("|---|---|---|\n")
        
        sorted_keys = sorted(verification_results.keys())
        for key in sorted_keys:
            res = verification_results[key]
            icon = "✅" if res["status"] == "VERIFIED" else "❌"
            sig = res["signature"].replace("|", "\\|").replace("\n", " ").replace("<", "&lt;").replace(">", "&gt;")
            if len(sig) > 120: sig = sig[:117] + "..."
            f.write(f"| `{key}` | {icon} {res['status']} | `{sig}` |\n")
            
    log("Verification Complete.")

if __name__ == "__main__":
    verify_apis()

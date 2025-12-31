
import os
import subprocess
import sys

# Constants
DECOMPILER = "d:/Bannerlord_Mods/Initialization/bin/ilspy.cmd"
TARGET_DLL = "d:/Bannerlord_Mods/Tools/PlayerSettlement/bin/Win64_Shipping_Client/PlayerSettlement.dll"
OUTPUT_FILE = "d:/Bannerlord_Mods/PlayerSettlement_Analysis.cs"

# Types to Reverse Engineer
TYPES_TO_ANALYZE = [
    "BannerlordPlayerSettlement.Behaviours.PlayerSettlementBehaviour",
    "BannerlordPlayerSettlement.Main"
]

def log(msg):
    print(msg)
    sys.stdout.flush()

def decompile_type(type_name):
    decomp_abs = os.path.abspath(DECOMPILER)
    dll_path = os.path.abspath(TARGET_DLL)
    
    cmd = [decomp_abs, dll_path, "-t", type_name]
    
    try:
        log(f"Decompiling {type_name}...")
        result = subprocess.run(cmd, capture_output=True, text=True, shell=True, encoding='utf-8', timeout=30)
        if result.returncode != 0:
            log(f"  [ERR] Failed to decompile {type_name}")
            return "" 
        return result.stdout
    except Exception as e:
        log(f"  [ERR] Exception during decomp: {e}")
        return ""

def analyze():
    log("Starting PlayerSettlement Reverse Engineering...")
    
    full_source = ""
    
    for type_name in TYPES_TO_ANALYZE:
        src = decompile_type(type_name)
        full_source += f"\n// ==========================================\n"
        full_source += f"// TYPE: {type_name}\n"
        full_source += f"// ==========================================\n"
        full_source += src
        full_source += "\n"
        
    with open(OUTPUT_FILE, "w", encoding='utf-8') as f:
        f.write(full_source)
        
    log(f"Analysis complete. Logic saved to {OUTPUT_FILE}")

if __name__ == "__main__":
    analyze()

import os
import subprocess
import sys

LIBS_DIR = "e:/Bannerlord_Mods/libs"
DECOMPILER = "e:/Bannerlord_Mods/Initialization/bin/ilspy.cmd"

def log(msg):
    print(msg)
    sys.stdout.flush()

def decompile_type(dll_name, type_name):
    decomp_abs = os.path.abspath(DECOMPILER)
    dll_path = os.path.abspath(os.path.join(LIBS_DIR, dll_name))
    cmd = [decomp_abs, dll_path, "-t", type_name]
    try:
        result = subprocess.run(cmd, capture_output=True, text=True, shell=True, encoding='utf-8', timeout=20)
        return result.stdout
    except:
        return ""

def main():
    dlls = ["TaleWorlds.Core.dll", "TaleWorlds.Library.dll", "TaleWorlds.ViewModelCollection.dll"]
    type_name = "TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty"
    
    for dll in dlls:
        log(f"Checking {dll} for {type_name}...")
        src = decompile_type(dll, type_name)
        if src and "public class TooltipProperty" in src:
            log(f"FOUND in {dll}!")
            return

    # Try simpler namespace
    type_name = "TaleWorlds.Core.ViewModelCollection.TooltipProperty"
    for dll in dlls:
        log(f"Checking {dll} for {type_name}...")
        src = decompile_type(dll, type_name)
        if src and "public class TooltipProperty" in src:
             log(f"FOUND in {dll}!")
             return

    # Try root namespace
    type_name = "TaleWorlds.Core.TooltipProperty"
    for dll in dlls:
        log(f"Checking {dll} for {type_name}...")
        src = decompile_type(dll, type_name)
        if src and "public class TooltipProperty" in src:
             log(f"FOUND in {dll}!")
             return

if __name__ == "__main__":
    main()

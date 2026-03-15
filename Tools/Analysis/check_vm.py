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
    except Exception as e:
        log(f"Error: {e}")
        return ""

def main():
    log("Checking TownManagementVM...")
    dll = "TaleWorlds.CampaignSystem.ViewModelCollection.dll"
    type_name = "TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM"
    
    src = decompile_type(dll, type_name)
    
    if not src:
        log("Failed to decompile TownManagementVM. Trying simpler namespace...")
        type_name = "TaleWorlds.CampaignSystem.ViewModelCollection.TownManagement.TownManagementVM"
        src = decompile_type(dll, type_name)

    if not src:
        log("Trying to find the class in the DLL...")
        # fallback to just searching string in dll? No, ILSpy requires type name.
        # Let's try CampaignUIHelper
        log("Checking CampaignUIHelper...")
        type_name = "TaleWorlds.CampaignSystem.ViewModelCollection.CampaignUIHelper"
        src = decompile_type(dll, type_name)

    if src:
        log("Source found. Searching for 'GarrisonChange'...")
        for line in src.split('\n'):
            if "Garrison" in line and "Tooltip" in line:
                log(f"MATCH: {line.strip()}")
            if "GetTownGarrisonChangeTooltip" in line:
                log(f"HELPER MATCH: {line.strip()}")

if __name__ == "__main__":
    main()

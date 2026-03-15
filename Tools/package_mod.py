import os
import sys
import zipfile
import shutil
import glob
import argparse
from datetime import datetime

# Configuration
WORKSPACE_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
MODULES_DIR = os.path.join(WORKSPACE_ROOT, "Modules")
DEFAULT_RELEASE_DIR = os.path.join(WORKSPACE_ROOT, "_Release")

# Whitelist-based inclusion
ALLOWED_FOLDERS = ["bin", "ModuleData", "GUI", "Textures", "Sounds", "Music", "Videos", "Prefabs", "Illustrations", "Atmospheres"]
ALLOWED_ROOT_FILES = ["SubModule.xml"]

# Strict Exclusions
EXCLUDED_EXTENSIONS = [".csproj", ".user", ".pdb", ".toon"]
EXCLUDED_FILES = [".gitattributes", ".gitignore", "GEMINI.md", "audit_settings.py", "last_build.txt"]

def package_mod(mod_name, output_path=None):
    mod_path = os.path.join(MODULES_DIR, mod_name)
    
    if not os.path.exists(mod_path):
        print(f"Error: Mod {mod_name} not found at {mod_path}")
        return False

    if output_path:
        zip_path = output_path
        # Ensure directory exists
        os.makedirs(os.path.dirname(zip_path), exist_ok=True)
    else:
        if not os.path.exists(DEFAULT_RELEASE_DIR):
            os.makedirs(DEFAULT_RELEASE_DIR)
        timestamp = datetime.now().strftime("%Y%m%d_%H%M")
        zip_filename = f"{mod_name}_{timestamp}.zip"
        zip_path = os.path.join(DEFAULT_RELEASE_DIR, zip_filename)
    
    print(f"Packaging {mod_name} into {zip_path}...")
    
    try:
        with zipfile.ZipFile(zip_path, 'w', zipfile.ZIP_DEFLATED) as zipf:
            for root, dirs, files in os.walk(mod_path):
                # Calculate relative path from mod root
                rel_root = os.path.relpath(root, mod_path)
                
                # Logic for Root Directory
                if rel_root == ".":
                    # Only include specifically allowed root files
                    for file in files:
                        if file in ALLOWED_ROOT_FILES:
                            file_path = os.path.join(root, file)
                            arc_name = os.path.join(mod_name, file)
                            print(f"  Adding (Root): {arc_name}")
                            zipf.write(file_path, arc_name)
                    
                    # Remove non-whitelisted directories from top-level walk
                    dirs[:] = [d for d in dirs if d in ALLOWED_FOLDERS]
                    continue

                # Logic for Subdirectories (already whitelisted by the 'dirs[:]' update in root)
                for file in files:
                    file_path = os.path.join(root, file)
                    arc_name = os.path.join(mod_name, rel_root, file)
                    
                    _, ext = os.path.splitext(file)
                    ext_lower = ext.lower()
                    file_lower = file.lower()
                    
                    # Filter by blocked extensions/files
                    if ext_lower in EXCLUDED_EXTENSIONS or file in EXCLUDED_FILES:
                        continue
                    
                    # Filter junk
                    if file_lower in ["thumbs.db", ".ds_store"] or \
                       (file_lower.startswith("crashreport") and file_lower.endswith(".html")) or \
                       file_lower.endswith(".py"):
                        continue

                    # DLL Logic: Exclude game/system assemblies AND mod dependencies
                    if ext_lower == ".dll":
                         # Exclude:
                         # 1. Game/System libs (TaleWorlds, System, Microsoft, Newtonsoft)
                         # 2. Dependencies provided by other mods (0Harmony, Serilog - via ButterLib)
                         if any(file.startswith(prefix) for prefix in ["TaleWorlds.", "System.", "Microsoft.", "Newtonsoft.", "0Harmony", "Serilog"]):
                             continue
                             
                    print(f"  Adding: {arc_name}")
                    zipf.write(file_path, arc_name)
                    
        print(f"Success! Package created at: {zip_path}")
        return True
    except Exception as e:
        print(f"Failed to zip: {e}")
        return False

if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="Package a Bannerlord mod into a release zip.")
    parser.add_argument("mod_name", help="Name of the module directory to package")
    parser.add_argument("-o", "--output", help="Full path for the output zip file")
    
    args = parser.parse_args()
    
    package_mod(args.mod_name, args.output)

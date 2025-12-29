import os
import sys
import subprocess
import shutil
import glob
import datetime
import platform

# Configuration
# ----------------
WORKSPACE_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
TOOLS_DIR = os.path.join(WORKSPACE_ROOT, "Tools")
MODULES_DIR = os.path.join(WORKSPACE_ROOT, "Modules")
DOTNET_PATH = os.path.join(TOOLS_DIR, "dotnet", "dotnet.exe")
GAME_PATH_CONFIG = os.path.join(TOOLS_DIR, "game_path_config.txt")
ALL_MODS = [
    "Bannerlord.Harmony",
    "Bannerlord.ButterLib",
    "Bannerlord.UIExtenderEx",
    "Bannerlord.MBOptionScreen",
    "BetterGov", 
    "Brigands", 
    "CoastalLife", 
    "HappyParty", 
    "HonestWork", 
    "Landlord", 
    "FieldSquire", 
    "LivingLegend", 
    "NewClans",
    "NavalDLC",
    "Ascension"
]


def get_game_modules_path():
    """Reads the game path config and determines the Modules directory."""
    
    # Check for machine-specific config first
    hostname = platform.node()
    config_file = os.path.join(TOOLS_DIR, f"game_path_config_{hostname}.txt")
    
    if not os.path.exists(config_file):
        # Fallback to default
        config_file = GAME_PATH_CONFIG
        
    if not os.path.exists(config_file):
        print(f"Error: Game path configuration not found. Checked:\n - {os.path.join(TOOLS_DIR, 'game_path_config_' + hostname + '.txt')}\n - {GAME_PATH_CONFIG}")
        return None
    
    print(f"Using Game Path Config: {config_file}")
    
    with open(config_file, 'r') as f:
        exe_path = f.read().strip().strip('"').strip("'")
    
    if not os.path.exists(exe_path):
        print(f"Error: Game executable not found at {exe_path}")
        return None

    # Exe is usually .../bin/Win64_Shipping_Client/Bannerlord.exe => Go up 3 levels
    game_root = os.path.dirname(os.path.dirname(os.path.dirname(exe_path)))
    modules_path = os.path.join(game_root, "Modules")
    
    return modules_path

def build_mod(mod_name):
    """Builds a specific mod using dotnet."""
    project_path = os.path.join(MODULES_DIR, mod_name, f"{mod_name}.csproj")
    if not os.path.exists(project_path):
        print(f"Info: Project for {mod_name} not found. Skipping build (Binary Mod?).")
        return True

    print(f"Building {mod_name}...")
    
    # Run dotnet build
    try:
        # Use shell=True might help with some path issues but usually not needed.
        # Capture stdout and stderr
        result = subprocess.run(
            [DOTNET_PATH, "build", project_path, "-c", "Debug"],
            capture_output=True,
            text=True,
            check=False,
            encoding='utf-8', 
            errors='replace' # Prevent UnicodeDecodeError crashing the script
        )
        
        # Always save full log for inspection
        log_file = "last_build.log"
        # Use 'a' to append so we keep logs for all mods in one run
        with open(log_file, "a", encoding="utf-8") as f:
            f.write(f"\n{'='*40}\nBUILD LOG: {mod_name}\n{'='*40}\n")
            f.write(result.stdout)
            if result.stderr:
                f.write("\n=== STDERR ===\n")
                f.write(result.stderr)
        
        if result.returncode == 0:
            print(f"[{mod_name}] Build SUCCESS")
            return True
        else:
            print(f"[{mod_name}] Build FAILED. See last_build.log")
            # Print Errors to Console for Visibility
            lines = result.stdout.splitlines()
            for line in lines:
                if "error" in line.lower() or "warning" in line.lower():
                    print(f" > {line.strip()}")
                
            print("-------------------------------")
            return False
            
    except Exception as e:
        print(f"Exception during build: {e}")
        return False

def deploy_mod(mod_name, game_modules_path):
    """Deploys the mod files to the game directory."""
    source_mod_dir = os.path.join(MODULES_DIR, mod_name)
    target_mod_dir = os.path.join(game_modules_path, mod_name)
    
    # SAFETY CHECK: Source must exist
    if not os.path.exists(source_mod_dir):
        print(f"[{mod_name}] Deployment SOURCE missing at {source_mod_dir}. Skipping deployment (Game directory preserved).")
        return True

    print(f"Deploying {mod_name}...")
    
    try:
        # Clean target
        if os.path.exists(target_mod_dir):
            shutil.rmtree(target_mod_dir)
        
        # Copy new
        # ignore bin/obj and source files? Usually we deploy everything in Modules because Bannerlord mods are self-contained?
        # Actually, we should probably stick to what deploy_mods.ps1 did, which was copy everything.
        # But technically we only need SubModule.xml and bin/. 
        # For safety/simplicity mirroring existing behavior, we copy tree.
        
        # Helper to ignore source files if we wanted, but let's copy full for now.
        shutil.copytree(source_mod_dir, target_mod_dir)
        print(f"[{mod_name}] Deployed successfully.")
        return True
    except Exception as e:
        print(f"[{mod_name}] Deployment FAILED: {e}")
        return False

def main():
    # 1. Parse Arguments
    args = sys.argv[1:]
    targets = []
    mode_build = True
    mode_deploy = True
    
    # Flags parsing
    clean_args = []
    for arg in args:
        lower_arg = arg.lower()
        if lower_arg == "--deploy-only":
            mode_build = False
        elif lower_arg in ["--build-only", "--no-deploy", "--verify"]:
            mode_deploy = False
        else:
            clean_args.append(arg)
            
    # Target parsing
    if clean_args:
        for arg in clean_args:
            # Case insensitive check
            match = next((m for m in ALL_MODS if m.lower() == arg.lower()), None)
            if match:
                if match not in targets:
                    targets.append(match)
            else:
                print(f"Warning: '{arg}' is not a known mod name. Ignoring.")
    else:
        targets = ALL_MODS

    if not targets:
        print("No valid mods to process.")
        sys.exit(1)

    # 2. Setup
    game_modules_path = None
    if mode_deploy:
        game_modules_path = get_game_modules_path()
        if not game_modules_path:
            print("Deployment requested but Game Modules path could not be resolved. Aborting.")
            sys.exit(1)
        print(f"Targeting Game Modules at: {game_modules_path}")
    
    action_str = []
    if mode_build: action_str.append("BUILD")
    if mode_deploy: action_str.append("DEPLOY")
    
    print(f"Action: {' & '.join(action_str)}")
    print(f"Processing: {', '.join(targets)}\n")

    # Clear log file
    if mode_build:
        with open("last_build.log", "w") as f:
            f.write(f"Build Run: {datetime.datetime.now()}\n")
            
    # 3. Execution Loop
    failed_ops = []
    
    for mod in targets:
        success = True
        
        # Build Step
        if mode_build:
            if not build_mod(mod):
                success = False
                failed_ops.append(f"{mod} (Build)")
        
        # Deploy Step (only if build passed or was skipped)
        if mode_deploy and success:
            if not deploy_mod(mod, game_modules_path):
                success = False
                failed_ops.append(f"{mod} (Deploy)")
                
    # 4. Final Summary
    print("\nXXX SUMMARY XXX")
    if failed_ops:
        print(f"FAILED: {', '.join(failed_ops)}")
        sys.exit(1)
    else:
        print("ALL ACTIONS COMPLETED SUCCESSFULLY.")
        sys.exit(0)

if __name__ == "__main__":
    main()

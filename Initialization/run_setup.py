import os
import sys
import platform
import subprocess

def main():
    """
    Agent Initialization Script
    ---------------------------
    1. Verify/Set Game Path Configuration based on Hostname.
    2. Launch Workspace Environment (AHK, IDE Hook, Portable .NET).
    
    Usage:
      python run_setup.py [Optional_New_Game_Path]
    """
    
    workspace_root = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
    tools_dir = os.path.join(workspace_root, "Tools")
    init_dir = os.path.join(workspace_root, "Initialization")
    hostname = platform.node()
    
    print(f"--- Agent Initialization Setup ---")
    print(f"Hostname: {hostname}")

    # 1. Game Path Configuration
    config_filename = f"game_path_config_{hostname}.txt"
    config_path = os.path.join(tools_dir, config_filename)
    
    game_path = None
    
    # Priority 1: Check existing host config
    if os.path.exists(config_path):
        print(f"[OK] Configuration found for host: {config_filename}")
        with open(config_path, 'r') as f:
            game_path = f.read().strip()
            
    # Priority 2: Check for new path argument
    elif len(sys.argv) > 1:
         # Combine args in case of spaces (though usually handled by shell quotes)
         raw_arg = " ".join(sys.argv[1:]).strip('"').strip("'")
         print(f"[INFO] New game path provided: {raw_arg}")
         
         if "Bannerlord.BLSE.Standalone.exe" not in raw_arg:
             print("[WARNING] The provided path does not seem to point to 'Bannerlord.BLSE.Standalone.exe'. Proceeding anyway.")
             
         with open(config_path, 'w') as f:
             f.write(raw_arg)
         print(f"[SUCCESS] Created configuration: {config_filename}")
         game_path = raw_arg

    # Priority 3: Fallback logic (Manual intervention required if fails)
    else:
        print(f"[INFO] No specific configuration for {hostname}.")
        
        # Check generic fallback just in case
        generic_path = os.path.join(tools_dir, "game_path_config.txt")
        if os.path.exists(generic_path):
             with open(generic_path, 'r') as f:
                 test_path = f.read().strip()
             # Verify if this generic path actually exists on this disk
             if os.path.exists(test_path):
                 print(f"[OK] Generic path in 'game_path_config.txt' is valid. Using that.")
                 game_path = test_path
             else:
                 print(f"[FAIL] Generic path points to non-existent location: {test_path}")

    if not game_path:
        print("\n[ERROR] SETUP FAILED: Missing Game Path.")
        print("INSTRUCTIONS: Please run this script with the full path to 'Bannerlord.BLSE.Standalone.exe'.")
        print("Example: python run_setup.py \"C:\\Path\\To\\Bannerlord.BLSE.Standalone.exe\"")
        sys.exit(1)

    print(f"[VERIFIED] Game Path: {game_path}")
    
    # 2. Launch Environment (IDE Hook / AHK)
    print("\n[INFO] Launching Workspace Environment (AHK & IDE Hook)...")
    launch_script = os.path.join(init_dir, "launch_workspace.bat")
    
    # Execute launch_workspace.bat
    # This sets up DotNet, Launches AHK, and Hooks the IDE
    try:
        subprocess.run([launch_script], cwd=init_dir, shell=True, check=True)
        print("[SUCCESS] Environment Initialized.")
    except subprocess.CalledProcessError as e:
        print(f"[ERROR] Failed to launch workspace: {e}")
        sys.exit(1)

if __name__ == "__main__":
    main()

import os
import sys
import subprocess
import time
import psutil
import pyautogui
import glob
import datetime
import ctypes

def bring_window_to_front(pid):
    try:
        def callback(hwnd, hwnds):
            if ctypes.windll.user32.IsWindowVisible(hwnd):
                _, found_pid = ctypes.windll.user32.GetWindowThreadProcessId(hwnd, ctypes.byref(ctypes.c_ulong()))
                if found_pid == pid:
                    hwnds.append(hwnd)
            return True
            
        hwnds = []
        ENUM_WINDOWS_FUNC = ctypes.WINFUNCTYPE(ctypes.c_bool, ctypes.c_void_p, ctypes.c_void_p)
        ctypes.windll.user32.EnumWindows(ENUM_WINDOWS_FUNC(callback), ctypes.cast(ctypes.py_object(hwnds), ctypes.c_void_p))
        
        if hwnds:
            target_hwnd = hwnds[0]
            if ctypes.windll.user32.IsIconic(target_hwnd):
                 ctypes.windll.user32.ShowWindow(target_hwnd, 9)
            ctypes.windll.user32.SetForegroundWindow(target_hwnd)
            time.sleep(0.5)
            return True
    except Exception as e:
        print(f"Focus Error: {e}")
    return False

# --- Configuration ---
# Standard Bannerlord modules load order
# 1. Platform/Loader Mods (Harmony, ButterLib, UIExtender, MCM)
# 2. Native/Base Mods (Native, SandBoxCore, SandBox, StoryMode, etc)
# 3. User Mods (Alphabetical or specific order)

# Priority list enforces the load order for known modules. 
# Anything found in the directory NOT in this list will be appended after.
PRIORITY_LOAD_ORDER = [
    "Bannerlord.Harmony",
    "Bannerlord.ButterLib",
    "Bannerlord.UIExtenderEx",
    "Bannerlord.MBOptionScreen",
    "Native",
    "SandBoxCore",
    "SandBox",
    "CustomBattle",
    "StoryMode",
    "BirthAndDeath",
    "NavalDLC" 
]

# Modules to strictly ignore
IGNORE_PATTERNS = [
    "bin", 
    "Shaders", 
    "Backup", 
    ".", 
    "Multiplayer" # Often causes issues in SP if forced, usually totally fine to skip for SP tests
]

LOG_DIR = r"C:\ProgramData\Mount and Blade II Bannerlord\logs"
GAME_EXE_RELATIVE_PATH = r"Win64_Shipping_Client\Bannerlord.BLSE.Standalone.exe"

def find_game_executable():
    """
    Reads the game executable path from game_path_config.txt if it exists.
    Otherwise, attempts to find relative paths.
    """
    script_dir = os.path.dirname(os.path.abspath(__file__))
    
    # Gather candidate config files
    candidates = [os.path.join(script_dir, "game_path_config.txt")]
    
    # Add hostname specific if possible
    import socket
    try:
        hostname = socket.gethostname()
        candidates.insert(0, os.path.join(script_dir, f"game_path_config_{hostname}.txt"))
    except:
        pass

    # Add any other config files found
    candidates.extend(glob.glob(os.path.join(script_dir, "game_path_config_*.txt")))
    
    for config_file in candidates:
        if os.path.exists(config_file):
            try:
                print(f"Reading config from: {config_file}")
                with open(config_file, 'r') as f:
                    path = f.read().strip()
                    # Remove quotes if user added them
                    path = path.replace('"', '').replace("'", "")
                    if os.path.exists(path):
                        return path
                    else:
                        print(f"Warning: Path in {os.path.basename(config_file)} does not exist: {path}")
            except Exception as e:
                print(f"Error reading {os.path.basename(config_file)}: {e}")

    # Check relative path first
    candidate = os.path.join(script_dir, GAME_EXE_RELATIVE_PATH)
    if os.path.exists(candidate):
        return candidate
        
    # Check if we are in the parent directory of Win64_Shipping_Client
    candidate_check_2 = os.path.join(script_dir, "Win64_Shipping_Client", "Bannerlord.BLSE.Standalone.exe")
    if os.path.exists(candidate_check_2):
        return candidate_check_2

    print(f"Error: Could not find game executable. Please Create/Edit 'game_path_config.txt' with the full path to Bannerlord.BLSE.Standalone.exe")
    return None

def get_latest_log_file(log_dir, pattern="rgl_log_*.txt"):
    try:
        files = glob.glob(os.path.join(log_dir, pattern))
        if not files:
            return None
        return max(files, key=os.path.getctime)
    except Exception as e:
        print(f"Error searching logs: {e}")
        return None


def main():
    print("--- Bannerlord Stability Verification Script ---")
    
    # --- AUTO-WIPE LOGS ---
    script_dir = os.path.dirname(os.path.abspath(__file__))
    log_dir = os.path.join(os.path.dirname(script_dir), "logs")
    print(f"Clearing old logs in: {log_dir}")
    try:
        files = glob.glob(os.path.join(log_dir, "*.log"))
        for f in files:
            try:
                os.remove(f)
                # print(f"Deleted {f}") # Verbose
            except Exception as e:
                print(f"Failed to delete {f}: {e}")
    except Exception as e:
        print(f"Error accessing log directory: {e}")
    # ----------------------
    
    game_exe = find_game_executable()
    if not game_exe:
        print("CRITICAL: Game executable not found. Please edit the script to set the correct path.")
        sys.exit(1)
        
    print(f"Target Executable: {game_exe}")
    
    # --- Dynamic Module Discovery ---
    # Usually: .../bin/Win64_Shipping_Client/Bannerlord.BLSE.Standalone.exe
    # Modules should be at .../Modules
    game_root = os.path.dirname(os.path.dirname(os.path.dirname(game_exe)))
    modules_dir = os.path.join(game_root, "Modules")
    
    if not os.path.exists(modules_dir):
        # Fallback for weird structures
        game_root = os.path.dirname(os.path.dirname(game_exe))
        modules_dir = os.path.join(game_root, "Modules")
    
    print(f"Scanning Modules in: {modules_dir}")
    
    if not os.path.exists(modules_dir):
         print(f"CRITICAL: Could not locate Modules directory at {modules_dir}")
         sys.exit(1)

    found_modules = []
    for item in os.listdir(modules_dir):
        item_path = os.path.join(modules_dir, item)
        if os.path.isdir(item_path):
            # Check exclusions
            skip = False
            for pattern in IGNORE_PATTERNS:
                if pattern in item or item.startswith("."): # Basic substring check for "Backup" etc
                    skip = True
                    break
            
            if not skip:
                found_modules.append(item)

    # Build the final ordered list
    final_module_list = []
    
    # 1. Add Priority Modules in order 
    # CRITICAL FIX: If these are missing from 'found_modules' (e.g. scan failed), 
    # we MUST include them anyway if we want them to load (unless they truly don't exist on disk, in which case game crashes anyway).
    # But for safety, we'll trust the scan BUT fallback if criticals are missing.
    
    critical_platform_mods = ["Bannerlord.Harmony", "Bannerlord.ButterLib", "Bannerlord.UIExtenderEx", "Bannerlord.MBOptionScreen"]
    
    for pm in PRIORITY_LOAD_ORDER:
        if pm in found_modules:
            final_module_list.append(pm)
            found_modules.remove(pm)
        elif pm in critical_platform_mods:
             print(f"WARNING: Critical Module '{pm}' not found in scan! Forcing it into load order.")
             final_module_list.append(pm)
            
    # 2. Add remaining modules (User mods) sorted alphabetically
    found_modules.sort()
    for m in found_modules:
        final_module_list.append(m)
        print(f" + Found User Module: {m}")

    print(f"Final Load Order: {final_module_list}")

    MODULE_ARG = "*".join(final_module_list)
    LAUNCH_ARGS = f"/singleplayer _MODULES_*{MODULE_ARG}*_MODULES_"
    # -------------------------------

    print(f"Launch Arguments: {LAUNCH_ARGS}")
    
    # Launch the game
    print("\nLaunching Game...")
    try:
        # Determine CWD to ensure game finds dlls/resources
        game_cwd = os.path.dirname(game_exe)
        print(f"Working Directory: {game_cwd}")

        proc = subprocess.Popen(f'"{game_exe}" {LAUNCH_ARGS}', shell=False, cwd=game_cwd)
        
    except Exception as e:
        print(f"Failed to launch game: {e}")
        sys.exit(1)
        
    pid = proc.pid
    print(f"Game launched. PID: {pid}")
    
    # 1. Start Sequence
    print("Handling startup sequence...")
    time.sleep(5) 
    bring_window_to_front(pid) # Focus for Safe Mode
    
    # Safe Mode
    print("  > Pressing 'N' (Safe Mode - No)")
    pyautogui.press('n')
    
    # 2. Intro Videos
    time.sleep(15)
    bring_window_to_front(pid) # Focus for Intro
    print("  > Pressing 'Esc' (Skip Intro 1)")
    pyautogui.press('esc')
    time.sleep(1.5)
    print("  > Pressing 'Esc' (Skip Intro 2)")
    pyautogui.press('esc')

    # 3. Main Menu Load (Wait 25s)
    print("  > Waiting for Main Menu (25s)...")
    time.sleep(25)
    
    # Ensure focus
    width, height = pyautogui.size()
    print(f"  > Screen Size: {width}x{height}")
    
    bring_window_to_front(pid) # Focus for Main Menu
    
    # Target "Continue Campaign" (Relative to screen size based on user screenshot)
    # X ~ 13% (Left side)
    # Y ~ 35% (Moved up from 38% based on user feedback)
    target_x = width * 0.13
    target_y = height * 0.35
    
    print(f"  > Targeting 'Continue Campaign' at ({int(target_x)}, {int(target_y)})...")
    
    # Click sequence with robustness
    pyautogui.moveTo(target_x, target_y)
    time.sleep(0.5)
    pyautogui.click()
    time.sleep(0.5)
    pyautogui.click() # Double click
    
    # Fallback: Press Enter in case correct element is highlighted
    time.sleep(1)
    pyautogui.press('enter') 
    

    print("\n[LAUNCHER] Game Launched. Monitoring for Session Start...")

    
    # Locate log file: ../logs/NewClans.log relative to script
    script_dir = os.path.dirname(os.path.abspath(__file__))
    log_file = os.path.join(os.path.dirname(script_dir), "logs", "NewClans.log")
    
    click_time = datetime.datetime.now()
    timeout = 120
    
    import re
    # Regex for timestamp [HH:MM:SS.FFF]
    ts_pattern = re.compile(r"\[(\d{2}:\d{2}:\d{2}\.\d{3})\]")
    
    # Attempt to find the main game process
    process = None
    try:
        if psutil.pid_exists(pid):
            p = psutil.Process(pid)
            if p.status() != psutil.STATUS_ZOMBIE:
                process = p
        
        if not process:
            target_names = ["Bannerlord.Native.exe", "TaleWorlds.MountAndBlade.Launcher.exe", "Bannerlord.BLSE.Standalone.exe"]
            for p in psutil.process_iter(['pid', 'name']):
                if p.info['name'] in target_names:
                    process = psutil.Process(p.info['pid'])
                    break
    except:
        pass

    while (datetime.datetime.now() - click_time).total_seconds() < timeout:
        # 1. Check Process Health
        if process and (not process.is_running() or process.status() == psutil.STATUS_ZOMBIE):
             print("CRASH DETECTED: Game process died.")
             # Dump logs (same logic as before, could refuse to duplicate strictly for brevity unless requested)
             sys.exit(1)
             
        # 2. Check Log File
        if os.path.exists(log_file):
            try:
                with open(log_file, 'r', encoding='utf-8', errors='ignore') as f:
                    # Read all lines? Or seek? for simplicity read all (files are small usually)
                    lines = f.readlines()
                    
                    found = False
                    for line in reversed(lines):
                        if "OnSessionLaunched" in line:
                            # Verify timestamp
                            match = ts_pattern.search(line)
                            if match:
                                ts_str = match.group(1)
                                # Parse to time object
                                # We assume log date is today
                                log_time = datetime.datetime.strptime(ts_str, "%H:%M:%S.%f").time()
                                log_dt = datetime.datetime.combine(click_time.date(), log_time)
                                
                                # Handle midnight rollover edge case? assume unlikely for now.
                                
                                # Check delta
                                # If log_dt is > click_time (or within small margin before like 1s due to clock skew?)
                                # Actually, log should appear AFTER click.
                                if log_dt > click_time - datetime.timedelta(seconds=5):
                                    print(f"Event Found: {line.strip()}")
                                    found = True
                                    break
                    
                    if found:
                        print("Session Launch Confirmed!")
                        
                        # Perform Actions
                        print("Performing In-Game Inputs (Waiting 45s)...")
                        time.sleep(45)
                        
                        bring_window_to_front(pid) # Focus for Game Controls
                        
                        # Click Fast Forward (Double Arrow)
                        # Coordinates: X ~ 57.2%, Y ~ 98%
                        ff_x = width * 0.572
                        ff_y = height * 0.98
                        
                        print(f"  > Clicking Fast Forward at ({int(ff_x)}, {int(ff_y)})")
                        pyautogui.moveTo(ff_x, ff_y)
                        time.sleep(0.5)
                        pyautogui.click()
                        time.sleep(0.2)
                        pyautogui.click() # Double click just in case
                        
                        print("\nSUCCESS: Game loaded and Fast Forward clicked.")
                        sys.exit(0)
                        
            except Exception as e:
                print(f"Error reading log: {e}")
        
        time.sleep(2)
        sys.stdout.write(f"\rWaiting... {int((datetime.datetime.now() - click_time).total_seconds())}/{timeout}s")
        sys.stdout.flush()

    print("\nTIMEOUT: 'OnSessionLaunched' not found within 2 minutes.")
    sys.exit(1)


if __name__ == "__main__":
    main()

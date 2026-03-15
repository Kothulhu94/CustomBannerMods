import os

# Root game path
GAME_ROOT = r"C:\Users\RHoskins.evvcr\.gemini\antigravity\scratch\Steam\steamapps\common\Mount & Blade II Bannerlord"

def clean_ghosts():
    print(f"Scanning {GAME_ROOT} for LivingWorld.dll...")
    ghost_found = False
    
    for root, dirs, files in os.walk(GAME_ROOT):
        for file in files:
            if file.lower() == "livingworld.dll":
                full_path = os.path.join(root, file)
                print(f"FOUND: {full_path}")
                
                # Identify if it is the GHOST
                if "bin\\Win64_Shipping_Client" in full_path and "Modules" not in full_path:
                    print(f"!!! GHOST DETECTED in root bin !!! -> {full_path}")
                    try:
                        os.remove(full_path)
                        print("SUCCESS: Ghost file DELETED.")
                        ghost_found = True
                    except Exception as e:
                        print(f"FAILURE: Could not delete file. Error: {e}")
                
                elif "Modules\\LivingWorld\\bin" in full_path:
                    print("clean: Valid Module DLL.")
                else:
                    print(f"WARNING: Unknown location. Keeping for now.")

    if not ghost_found:
        print("No ghost file found in root bin.")

if __name__ == "__main__":
    clean_ghosts()

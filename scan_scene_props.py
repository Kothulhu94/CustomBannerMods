import os
import sys

def scan_scenes(base_path, needles):
    print(f"Scanning for {needles} in {base_path}...")
    
    # Map of needle -> list of scenes found in
    results = {n: [] for n in needles}
    all_scenes = []
    
    for root, dirs, files in os.walk(base_path):
        if "SceneObj" in root:
            for file in files:
                if file == "scene.scn":
                    filepath = os.path.join(root, file)
                    scene_name = os.path.basename(root)
                    all_scenes.append(scene_name)
                    try:
                        with open(filepath, 'rb') as f:
                            content = f.read()
                            for needle in needles:
                                if needle.encode('utf-8') in content or needle.encode('utf-16le') in content:
                                    results[needle].append(scene_name)
                    except Exception as e:
                        print(f"Error reading {filepath}: {e}")
    
    print("\n--- SCAN RESULTS ---")
    village_scenes = [s for s in all_scenes if "village" in s.lower()]
    print(f"Total Scenes Scanned: {len(all_scenes)}")
    print(f"Total Village Scenes: {len(village_scenes)}")
    
    for needle, found_scenes in results.items():
        v_found = [s for s in found_scenes if "village" in s.lower()]
        print(f"\nAsset: '{needle}'")
        print(f"Found in {len(found_scenes)} total scenes")
        print(f"Found in {len(v_found)} village scenes")
        if len(v_found) < 30: # Only list if manageable
             print(f"Villages: {v_found}")

if __name__ == "__main__":
    game_base = r"C:\Users\RHoskins.evvcr\.gemini\antigravity\scratch\Steam\steamapps\common\Mount & Blade II Bannerlord\Modules"
    assets = ["well", "loom_a", "loom_b", "anvil", "smithy"]
    scan_scenes(game_base, assets)

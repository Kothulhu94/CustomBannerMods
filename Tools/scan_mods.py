
import os
import re
import json

ROOT_DIR = "d:/Bannerlord_Mods/Modules"
SKIP_DIRS = ["Bannerlord.ButterLib", "Bannerlord.Harmony", "Bannerlord.MBOptionScreen", "Bannerlord.UIExtenderEx", "bin", "obj", "Properties"]
OUTPUT_FILE = "d:/Bannerlord_Mods/api_scan_results.json"

game_namespaces = [
    "TaleWorlds", "SandBox", "StoryMode", "System", "HarmonyLib", "Bannerlord"
]

# Common Bannerlord classes to help identification (incomplete list but helpful)
known_classes = {
    "MobileParty", "PartyBase", "Hero", "Clan", "Settlement", "Town", "Village", "Kingdom",
    "Campaign", "CampaignGameStarter", "CampaignEvents", "MBObjectBase", "Game",
    "InformationManager", "TextObject", "Vec3", "Mat3", "MatrixFrame",
    "Agent", "Mission", "MissionApi", "SubModule", "MBSubModuleBase",
    "CampaignBehaviorBase", "SaveableTypeDefiner", "GameMenuOption", "GameMenus",
    "KillCharacterAction", "AddCompanionAction", "AddHeroToPartyAction", "EndCaptivityAction",
    "ChangeRelationAction", "GiveGoldAction", "ApplyHeal", "HealPartyModel",
    "TroopRoster", "ItemObject", "ItemModifier", "CultureObject", "CharacterObject"
}

api_usage = {}

def is_api_call(token, method):
    if token in known_classes:
        return True
    if token.startswith("TaleWorlds"):
        return True
    return False

def scan_file(file_path, mod_name):
    try:
        with open(file_path, 'r', encoding='utf-8') as f:
            content = f.read()
    except Exception as e:
        print(f"Error reading {file_path}: {e}")
        return

    # Regex for Class.Member usage
    # Matches: Identifier.Identifier
    matches = re.finditer(r'\b([A-Z][a-zA-Z0-9_]*)\.([A-Z][a-zA-Z0-9_]*)', content)
    
    for m in matches:
        cls = m.group(1)
        member = m.group(2)
        
        # Filter commonly used unrelated tokens or keywords if they start with caps (rare in C# kws but possible in vars)
        if cls in ["System", "Math", "Console", "Debug"]:
            continue # Skip standard system stuff if we strictly want Game API, but user said "All API"
            
        full_signature = f"{cls}.{member}"
        
        # Check if it looks like an API
        if is_api_call(cls, member) or cls in known_classes:
            if full_signature not in api_usage:
                api_usage[full_signature] = {"count": 0, "locations": [], "type": "Static/Property"}
            api_usage[full_signature]["count"] += 1
            if len(api_usage[full_signature]["locations"]) < 5: # Limit locations stored
                api_usage[full_signature]["locations"].append(f"{mod_name}: {os.path.basename(file_path)}")

    # Regex for inheritance
    inheritance_matches = re.finditer(r'class\s+\w+\s*:\s*([A-Z][a-zA-Z0-9_]*)', content)
    for m in inheritance_matches:
        base_class = m.group(1)
        if base_class in known_classes or base_class.startswith("MB") or "Behavior" in base_class:
            sig = f"Inherits {base_class}"
            if sig not in api_usage:
                 api_usage[sig] = {"count": 0, "locations": [], "type": "Inheritance"}
            api_usage[sig]["count"] += 1
            api_usage[sig]["locations"].append(f"{mod_name}: {os.path.basename(file_path)}")

def main():
    print("Scanning modules...")
    for item in os.listdir(ROOT_DIR):
        if item in SKIP_DIRS:
            continue
        
        mod_dir = os.path.join(ROOT_DIR, item)
        if not os.path.isdir(mod_dir):
            continue
            
        print(f"Scanning {item}...")
        for root, dirs, files in os.walk(mod_dir):
            # Skip bin/obj if they exist inside
            if "bin" in dirs: dirs.remove("bin")
            if "obj" in dirs: dirs.remove("obj")
            
            for file in files:
                if file.endswith(".cs"):
                    scan_file(os.path.join(root, file), item)

    print(f"Found {len(api_usage)} API usages.")
    
    with open(OUTPUT_FILE, 'w') as f:
        json.dump(api_usage, f, indent=2)

if __name__ == "__main__":
    main()

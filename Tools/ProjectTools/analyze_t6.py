import os
import glob
import xml.etree.ElementTree as ET

def analyze_t6(module_path):
    print(f"Scanning {module_path}")
    troop_levels = {}
    xml_files = glob.glob(os.path.join(module_path, "ModuleData", "*.xml"))
    
    # Pass 1: Levels
    for xml_file in xml_files:
        try:
            tree = ET.parse(xml_file)
            root = tree.getroot()
            if root.tag != 'NPCCharacters': continue
            for npc in root.findall('NPCCharacter'):
                troop_levels[npc.get('id')] = int(npc.get('level', 0))
        except: pass

    # Pass 2: Upgrades
    for xml_file in xml_files:
        try:
            tree = ET.parse(xml_file)
            root = tree.getroot()
            if root.tag != 'NPCCharacters': continue
            for npc in root.findall('NPCCharacter'):
                s_id = npc.get('id')
                s_level = troop_levels.get(s_id, 0)
                
                if s_level >= 31:
                    upgrades = npc.find('upgrade_targets')
                    if upgrades is not None and len(upgrades.findall('upgrade_target')) > 0:
                        print(f"DTOUND: {s_id} (Lvl {s_level}) has upgrades:")
                        for t in upgrades.findall('upgrade_target'):
                            ex_id = t.get('id').replace('NPCCharacter.', '')
                            ex_lvl = troop_levels.get(ex_id, 'UNKNOWN')
                            print(f"  -> {ex_id} (Lvl {ex_lvl})")
        except: pass

if __name__ == "__main__":
    analyze_t6("e:/Bannerlord_Mods/Modules/Ascension")

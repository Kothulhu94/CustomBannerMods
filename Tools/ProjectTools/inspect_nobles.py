import os
import glob
import xml.etree.ElementTree as ET

def inspect_nobles():
    path = "e:/Bannerlord_Mods/Modules/Ascension/ModuleData"
    targets = [
        "battanian_highborn_youth_asc_1",
        "battanian_highborn_warrior_asc_1",
        "battanian_hero_asc_1",
        "battanian_fian_asc_1",
        "battanian_fian_champion_asc_1"
    ]
    
    xml_files = glob.glob(os.path.join(path, "*.xml"))
    
    for xml_file in xml_files:
        try:
            tree = ET.parse(xml_file)
            root = tree.getroot()
            for npc in root.findall('NPCCharacter'):
                id = npc.get('id')
                if id in targets:
                    print(f"FOUND {id} in {os.path.basename(xml_file)}")
                    print(f"  Level: {npc.get('level')}")
                    upgrades = npc.find('upgrade_targets')
                    if upgrades is not None:
                        for t in upgrades.findall('upgrade_target'):
                            print(f"  -> Upgrade: {t.get('id')}")
        except Exception as e:
            print(f"Error reading {xml_file}: {e}")

if __name__ == "__main__":
    inspect_nobles()

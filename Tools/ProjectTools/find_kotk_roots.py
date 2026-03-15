import xml.etree.ElementTree as ET
import glob
import os

kotk_dir = "d:/Bannerlord_Mods/NexusMods/kult_of_the_kallipygos_2_MAIN_MOD/ModuleData/"
xml_files = glob.glob(os.path.join(kotk_dir, "*.xml"))

all_troops = set()
all_upgrades = set()

for xml_file in xml_files:
    try:
        tree = ET.parse(xml_file)
        root = tree.getroot()
        if root.tag != 'NPCCharacters':
            continue
            
        for npc in root.findall('NPCCharacter'):
            tid = npc.get('id')
            if tid:
                all_troops.add(tid)
                
            upgrades = npc.find('upgrade_targets')
            if upgrades is not None:
                for u in upgrades.findall('upgrade_target'):
                    uid = u.get('id').replace('NPCCharacter.', '')
                    all_upgrades.add(uid)
    except Exception as e:
        print(f"Error reading {xml_file}: {e}")

roots = all_troops - all_upgrades
print(f"Found {len(roots)} roots.")
print(sorted(list(roots)))

import os
import glob
import xml.etree.ElementTree as ET

def find_high_tier_upgraders():
    path = "e:/Bannerlord_Mods/Modules/Ascension/ModuleData"
    xml_files = glob.glob(os.path.join(path, "*.xml"))
    
    count = 0
    for xml_file in xml_files:
        try:
            tree = ET.parse(xml_file)
            root = tree.getroot()
            for npc in root.findall('NPCCharacter'):
                lvl_str = npc.get('level', '0')
                try:
                    lvl = int(lvl_str)
                except:
                    continue
                
                # Check if it has upgrade targets
                upgrades = npc.find('upgrade_targets')
                has_upgrades = False
                if upgrades is not None:
                    if len(upgrades.findall('upgrade_target')) > 0:
                        has_upgrades = True
                
                # Tier 6 starts at Level 31
                if lvl >= 31 and has_upgrades:
                    # Confirm it's not Level 31 upgrading to Level 31 (DivideByZero check covers this)
                    # We are looking for Valid Upgrades that might be blocked by Tier Cap
                    print(f"TIER 6+ UPGRADER: {npc.get('id')} (Lvl {lvl}) -> has upgrades")
                    count += 1
                    
        except Exception as e:
            pass
            
    print(f"Total Tier 6+ units with upgrades: {count}")

if __name__ == "__main__":
    find_high_tier_upgraders()

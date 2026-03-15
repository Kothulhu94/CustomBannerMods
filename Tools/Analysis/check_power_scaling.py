import xml.etree.ElementTree as ET

def check_power_scaling():
    xml_path = "e:/Bannerlord_Mods/Modules/Ascension/ModuleData/AscendedTroops_battania.xml"
    try:
        tree = ET.parse(xml_path)
        root = tree.getroot()
        
        # Troops to compare
        troops = [
            'battanian_fian_champion',       # Base Vanilla
            'battanian_fian_champion_asc_1', # Ascended Rank 1
            'battanian_fian_champion_asc_5', # Ascended Rank 5
            'battanian_fian_champion_asc_10' # Ascended Rank 10
        ]
        
        print("Checking Skill Scaling for Battanian Fian Champion Line:")
        print("-" * 50)
        
        for tid in troops:
            node = root.find(f".//NPCCharacter[@id='{tid}']")
            if node is None:
                # Vanilla units are not in this file, skip or note
                print(f"{tid}: Not found in this XML (likely Vanilla)")
                continue
                
            lvl = node.get('level')
            
            skills = node.find('skills')
            bow = 0
            if skills is not None:
                for s in skills.findall('skill'):
                    if s.get('id') == 'Bow':
                        bow = s.get('value')
                        break
            
            print(f"ID: {tid:<30} | Level: {lvl:<3} | Bow Skill: {bow}")
            
    except Exception as e:
        print(f"Error: {e}")

if __name__ == "__main__":
    check_power_scaling()

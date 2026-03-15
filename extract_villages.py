import xml.etree.ElementTree as ET
import os

def extract_villages():
    files = [
        'd:/Bannerlord_Mods/Tools/XML_Def/SandBox/settlements.xml',
        'd:/Bannerlord_Mods/Tools/XML_Def/NavalDLC/settlements.xml'
    ]
    
    all_villages = []
    
    for f_path in files:
        if not os.path.exists(f_path):
            continue
        try:
            tree = ET.parse(f_path)
            root = tree.getroot()
            for settlement in root.findall('Settlement'):
                s_id = settlement.get('id')
                s_name = settlement.get('name')
                components = settlement.find('Components')
                if components is not None:
                    village = components.find('Village')
                    if village is not None:
                        v_type = village.get('village_type')
                        all_villages.append(f"{s_id} | {s_name} | {v_type}")
        except Exception as e:
            print(f"Error parsing {f_path}: {e}")
            
    # Print distinct types first
    types = set([v.split(' | ')[2] for v in all_villages if len(v.split(' | ')) > 2])
    print("--- DISTINCT VILLAGE TYPES ---")
    for t in sorted(list(types)):
        print(t)
        
    print("\n--- ALL VILLAGES ---")
    for v in all_villages:
        print(v)

if __name__ == "__main__":
    extract_villages()

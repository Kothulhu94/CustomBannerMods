import os
import glob
import xml.etree.ElementTree as ET

def analyze_naval_redundancy():
    module_path = "e:/Bannerlord_Mods/Modules/Ascension/ModuleData"
    naval_files = glob.glob(os.path.join(module_path, "*_Naval.xml"))
    
    print(f"Scanning {len(naval_files)} Naval files for redundancy...")
    
    total_unique = 0
    total_dupes = 0
    
    for naval_path in naval_files:
        basename = os.path.basename(naval_path)
        # Assuming format AscendedTroops_battania_Naval.xml -> AscendedTroops_battania.xml
        main_name = basename.replace("_Naval.xml", ".xml")
        main_path = os.path.join(module_path, main_name)
        
        if not os.path.exists(main_path):
            print(f"CRITICAL: Main file {main_name} NOT FOUND for {basename}. All {basename} contents are UNIQUE.")
            continue
            
        # Load Main IDs
        try:
            main_tree = ET.parse(main_path)
            main_ids = set([n.get('id') for n in main_tree.getroot().findall('NPCCharacter')])
        except Exception as e:
            print(f"Error reading main file {main_name}: {e}")
            continue

        # Check Naval IDs
        try:
            naval_tree = ET.parse(naval_path)
            naval_root = naval_tree.getroot()
            
            unique_in_naval = []
            
            for n in naval_root.findall('NPCCharacter'):
                tid = n.get('id')
                if tid not in main_ids:
                    unique_in_naval.append(tid)
                else:
                    total_dupes += 1
            
            print(f"FILE: {basename}")
            print(f"   - Standard Units (Duplicates): {len(naval_root.findall('NPCCharacter')) - len(unique_in_naval)}")
            
            if unique_in_naval:
                print(f"   - UNIQUE UNITS (Need Merge): {len(unique_in_naval)}")
                for u in unique_in_naval:
                    print(f"       + {u}")
                total_unique += len(unique_in_naval)
            else:
                print("   - Fully Redundant: YES")

        except Exception as e:
            print(f"Error reading naval file {basename}: {e}")

    print("-" * 30)
    print(f"TOTAL DUPLICATES: {total_dupes}")
    print(f"TOTAL UNIQUE (to be merged): {total_unique}")

if __name__ == "__main__":
    analyze_naval_redundancy()

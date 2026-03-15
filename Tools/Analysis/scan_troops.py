
import os
import glob
import xml.etree.ElementTree as ET

def scan_xmls(root_dir):
    print(f"Scanning {root_dir}...")
    xml_files = glob.glob(os.path.join(root_dir, "**", "*.xml"), recursive=True)
    
    issues_found = []

    for xml_file in xml_files:
        if "native" in xml_file.lower() or "bin" in xml_file.lower():
            continue
            
        try:
            tree = ET.parse(xml_file)
            root = tree.getroot()
            
            # recursive search for NPCCharacter
            # Note: iter() finds all elements in subtree
            for elem in root.iter('NPCCharacter'):
                char_id = elem.get('id')
                culture = elem.get('culture')
                
                if not culture:
                    issues_found.append(f"MISSING CULTURE: ID='{char_id}' in {xml_file}")
                
        except ET.ParseError:
            # print(f"Skipping malformed XML: {xml_file}")
            pass
        except Exception as e:
            print(f"Error reading {xml_file}: {e}")

    if issues_found:
        print("\n!!! ISSUES FOUND !!!")
        for issue in issues_found:
            print(issue)
    else:
        print("\nNo Missing Cultures found in scanned XMLs.")

if __name__ == "__main__":
    scan_xmls("d:/Bannerlord_Mods/Modules")

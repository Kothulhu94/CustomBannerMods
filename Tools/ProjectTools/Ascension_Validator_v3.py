import os
import glob
import xml.etree.ElementTree as ET

def validate_xmls(module_path):
    log_file = open("e:/Bannerlord_Mods/Ascension_Validation_Report.txt", "w", encoding="utf-8")
    
    def log(msg):
        print(msg)
        log_file.write(msg + "\n")

    # Map id -> level
    troop_levels = {}
    troop_files = {} # id -> filename
    
    xml_files = glob.glob(os.path.join(module_path, "ModuleData", "*.xml"))
    
    log(f"Scanning {len(xml_files)} XML files in {module_path}/ModuleData")

    # Pass 1: Gather Levels
    for xml_file in xml_files:
        try:
            tree = ET.parse(xml_file)
            root = tree.getroot()
            if root.tag != 'NPCCharacters':
                continue
            
            for npc in root.findall('NPCCharacter'):
                t_id = npc.get('id')
                t_level_str = npc.get('level', '0')
                try:
                    t_level = int(t_level_str)
                except:
                    log(f"ERROR: Invalid level '{t_level_str}' for {t_id}")
                    t_level = 0
                
                if t_id in troop_levels:
                    log(f"WARNING: Duplicate ID {t_id} found in {xml_file} (Previous: {troop_files[t_id]})")
                    pass
                
                troop_levels[t_id] = t_level
                troop_files[t_id] = os.path.basename(xml_file)
                
        except Exception as e:
            log(f"Error parsing {xml_file}: {e}")

    log(f"Database built: {len(troop_levels)} troops.")

    # Pass 2: Check Upgrades
    issues_found = []
    
    for xml_file in xml_files:
        try:
            tree = ET.parse(xml_file)
            root = tree.getroot()
            if root.tag != 'NPCCharacters':
                continue
            
            for npc in root.findall('NPCCharacter'):
                s_id = npc.get('id')
                s_level = troop_levels.get(s_id, 0)
                
                upgrades = npc.find('upgrade_targets')
                if upgrades is not None:
                    for target in upgrades.findall('upgrade_target'):
                        raw_t_id = target.get('id')
                        # Handle prefix
                        if raw_t_id.startswith('NPCCharacter.'):
                            clean_t_id = raw_t_id.replace('NPCCharacter.', '')
                        else:
                            clean_t_id = raw_t_id

                        if clean_t_id not in troop_levels:
                            # External Ref
                            log(f"EXTERNAL UPGRADE: {s_id} (Lvl {s_level}) -> {raw_t_id}")
                            continue
                            
                        t_level = troop_levels[clean_t_id]
                        
                        if t_level <= s_level:
                            issues_found.append(f"CRITICAL: {s_id} (Lvl {s_level}) -> {raw_t_id} (Lvl {t_level}) in {os.path.basename(xml_file)}")
                            
        except Exception as e:
            log(f"Error checking {xml_file}: {e}")

    if issues_found:
        log("\n--- ZERO XP ISSUES FOUND ---")
        for issue in issues_found:
            log(issue)
    else:
        log("\nNo internal Zero-XP upgrade issues found.")
        
    log_file.close()

if __name__ == "__main__":
    validate_xmls("e:/Bannerlord_Mods/Modules/Ascension")

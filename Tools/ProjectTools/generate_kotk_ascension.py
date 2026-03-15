import xml.etree.ElementTree as ET
import os
import glob
import copy

# Configuration
KOTK_DIR = "d:/Bannerlord_Mods/NexusMods/kult_of_the_kallipygos_2_MAIN_MOD/ModuleData/"
OUTPUT_DIR = "d:/Bannerlord_Mods/Modules/KotK_Patch/ModuleData/"
RANKS = 20

# Ensure Output Dir Exists
if not os.path.exists(OUTPUT_DIR):
    os.makedirs(OUTPUT_DIR)

def load_kotk_troops():
    troops = {}
    xml_files = glob.glob(os.path.join(KOTK_DIR, "*.xml"))
    
    for xml_file in xml_files:
        try:
            tree = ET.parse(xml_file)
            root = tree.getroot()
            if root.tag != 'NPCCharacters':
                continue
            
            for npc in root.findall('NPCCharacter'):
                tid = npc.get('id')
                if tid:
                    troops[tid] = npc
        except Exception as e:
            print(f"Skipping {xml_file}: {e}")
            
    return troops

def generate_ascended_troops(all_troops):
    # Group by Culture for valid XMLs
    troops_by_culture = {}
    
    for tid, node in all_troops.items():
        # Clean Culture ID (e.g. "Culture.empire" -> "empire")
        cult_raw = node.get('culture', 'Culture.neutral')
        culture = cult_raw.replace('Culture.', '')
        
        if culture not in troops_by_culture:
            troops_by_culture[culture] = []
        troops_by_culture[culture].append(tid)
        
    for culture, tids in troops_by_culture.items():
        print(f"Generating Ascended Troops for Culture: {culture} ({len(tids)} units)...")
        
        output_root = ET.Element("NPCCharacters")
        
        for rank in range(1, RANKS + 1):
            comment = ET.Comment(f" ================= RANK {rank} ================= ")
            output_root.append(comment)
            
            for vid in tids:
                original_node = all_troops[vid]
                asc_node = copy.deepcopy(original_node)
                
                # 1. Update ID
                asc_id = f"{vid}_asc_{rank}"
                asc_node.set('id', asc_id)
                
                # 2. Update Name
                v_name = original_node.get('name', 'Troop').strip("{}")
                if "}" in v_name:
                    parts = v_name.split("}", 1)
                    loc_key = parts[0][2:] # Remove {=
                    name_text = parts[1]
                    new_key = f"Asc_KotK_{loc_key}_{rank}"
                    new_name = f"{{={new_key}}}{name_text} (Rank {rank})"
                else:
                    new_name = f"{v_name} (Rank {rank})"
                asc_node.set('name', new_name)
                
                # 3. Update Stats
                base_level = int(original_node.get('level', 1))
                new_level = base_level + (5 * rank)
                asc_node.set('level', str(new_level))
                
                skills_node = asc_node.find('skills')
                if skills_node is not None:
                    for skill in skills_node.findall('skill'):
                        base_val = int(skill.get('value', 0))
                        new_val = base_val + (20 * rank)
                        skill.set('value', str(new_val))

                # 4. Update Upgrade Targets
                # We blindly assume that any target we see SHOULD exist in an Ascended form
                # either in this mod (if it's KotK) or the main Ascension mod (if it's Vanilla).
                upgrades_node = asc_node.find('upgrade_targets')
                if upgrades_node is not None:
                    # Clear current
                    for t in list(upgrades_node):
                        upgrades_node.remove(t)
                        
                    # Rebuild
                    original_upgrades = original_node.find('upgrade_targets')
                    if original_upgrades is not None:
                        for vt in original_upgrades.findall('upgrade_target'):
                            raw_target_id = vt.get('id', '')
                            # Strip NPCCharacter. prefix if present
                            target_id = raw_target_id.replace('NPCCharacter.', '')
                            
                            # Construct Ascended ID
                            target_asc_id = f"{target_id}_asc_{rank}"
                            
                            new_target = ET.SubElement(upgrades_node, 'upgrade_target')
                            new_target.set('id', f"NPCCharacter.{target_asc_id}")

                output_root.append(asc_node)

        # Write file
        ET.indent(output_root, space="  ", level=0)
        out_filename = f"AscendedTroops_KotK_{culture}.xml"
        tree = ET.ElementTree(output_root)
        tree.write(os.path.join(OUTPUT_DIR, out_filename), encoding="utf-8", xml_declaration=True)
        print(f"Saved {out_filename}")

if __name__ == "__main__":
    kotk_troops = load_kotk_troops()
    print(f"Loaded {len(kotk_troops)} KotK troops.")
    generate_ascended_troops(kotk_troops)

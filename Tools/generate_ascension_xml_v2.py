import xml.etree.ElementTree as ET
import sys
import copy
import os

# Configuration
VANILLA_XML = "d:/Bannerlord_Mods/tools/XML_Def/SandBoxCore/spnpccharacters.xml"
NAVAL_XML = "d:/Bannerlord_Mods/tools/XML_Def/NavalDLC/naval_characters.xml"
OUTPUT_DIR = "d:/Bannerlord_Mods/Modules/Ascension/ModuleData/"

CULTURES = {
    "aserai": ["aserai_recruit", "aserai_youth"],
    "battania": ["battanian_volunteer", "battanian_highborn_youth"],
    "empire": ["imperial_recruit", "imperial_vigla_recruit"],
    "khuzait": ["khuzait_nomad", "khuzait_noble_son"],
    "sturgia": ["sturgian_recruit", "sturgian_warrior_son", "nord_youngling"],
    "vlandia": ["vlandian_recruit", "vlandian_squire"]
}

def load_and_merge_troops():
    troops = {}
    
    # 1. Load Vanilla
    print(f"Loading Vanilla: {VANILLA_XML}")
    tree = ET.parse(VANILLA_XML)
    for npc in tree.getroot().findall('NPCCharacter'):
        tid = npc.get('id')
        if tid:
            troops[tid] = npc
            
    # 2. Load Naval (and Merge)
    if os.path.exists(NAVAL_XML):
        print(f"Loading Naval: {NAVAL_XML}")
        tree_nav = ET.parse(NAVAL_XML)
        for npc in tree_nav.getroot().findall('NPCCharacter'):
            tid = npc.get('id')
            
            if tid in troops:
                # Merge Upgrade Targets
                existing = troops[tid]
                nav_upgrades = npc.find('upgrade_targets')
                
                if nav_upgrades is not None:
                    ex_upgrades = existing.find('upgrade_targets')
                    if ex_upgrades is None:
                        ex_upgrades = ET.SubElement(existing, 'upgrade_targets')
                    
                    # Deduplicate
                    existing_ids = [u.get('id') for u in ex_upgrades.findall('upgrade_target')]
                    
                    for u in nav_upgrades.findall('upgrade_target'):
                        if u.get('id') not in existing_ids:
                            ex_upgrades.append(u)
                            # print(f"  [Merge] Added upgrade {u.get('id')} to {tid}")
            else:
                # New Naval Troop
                troops[tid] = npc
    else:
        print("Warning: Naval XML not found. Skipping merge.")
        
    return troops

def generate_culture(culture_id, root_ids, all_troops, ranks=1):
    target_tree_ids = []
    
    def traverse_tree(current_id):
        if current_id not in all_troops:
            return
        if current_id not in target_tree_ids:
            target_tree_ids.append(current_id)
        
        node = all_troops[current_id]
        upgrades = node.find('upgrade_targets')
        if upgrades is not None:
            for target in upgrades.findall('upgrade_target'):
                tid = target.get('id').replace('NPCCharacter.', '')
                traverse_tree(tid)

    for root in root_ids:
        print(f"[{culture_id}] Tracing root: {root}")
        traverse_tree(root)
        
    print(f"[{culture_id}] Total unique troops: {len(target_tree_ids)}")
    
    # Generate XML
    output_root = ET.Element("NPCCharacters")
    
    for rank in range(1, ranks + 1):
        comment = ET.Comment(f" ================= RANK {rank} ================= ")
        output_root.append(comment)
        
        for vid in target_tree_ids:
            vanilla_node = all_troops[vid]
            asc_node = copy.deepcopy(vanilla_node)
            
            # ID
            asc_id = f"{vid}_asc_{rank}"
            asc_node.set('id', asc_id)
            
            # Name
            v_name = vanilla_node.get('name', 'Troop').strip("{}")
            if "}" in v_name:
                v_name_text = v_name.split("}")[1]
                loc_key = v_name.split("}")[0][2:]
                new_key = f"Asc_{loc_key}_{rank}"
                new_name = f"{{={new_key}}}{v_name_text} (Rank {rank})"
            else:
                new_name = f"{v_name} (Rank {rank})"
            asc_node.set('name', new_name)
            
            # Level: Vanilla + 5*Rank
            base_level = int(vanilla_node.get('level', 1))
            new_level = base_level + (5 * rank)
            asc_node.set('level', str(new_level))
            
            # Skills: Vanilla + 20*Rank
            skills_node = asc_node.find('skills')
            if skills_node is not None:
                for skill in skills_node.findall('skill'):
                    base_val = int(skill.get('value', 0))
                    new_val = base_val + (20 * rank)
                    skill.set('value', str(new_val))
            
            # Upgrades
            upgrades_node = asc_node.find('upgrade_targets')
            if upgrades_node is not None:
                for t in list(upgrades_node):
                    upgrades_node.remove(t)
                
                # Use merged dictionary to find targets!
                # IMPORTANT: Use the 'all_troops' version which has merged upgrades!
                # (vanilla_node IS from all_troops, so it has them)
                v_upgrades = vanilla_node.find('upgrade_targets')
                
                if v_upgrades is not None:
                    for vt in v_upgrades.findall('upgrade_target'):
                        vt_id = vt.get('id').replace('NPCCharacter.', '')
                        if vt_id in target_tree_ids:
                            new_target_id = f"NPCCharacter.{vt_id}_asc_{rank}"
                            new_target = ET.SubElement(upgrades_node, 'upgrade_target')
                            new_target.set('id', new_target_id)
                            
            output_root.append(asc_node)
            
    # Save
    ET.indent(output_root, space="  ", level=0)
    filename = f"AscendedTroops_{culture_id}.xml"
    out_path = OUTPUT_DIR + filename
    tree = ET.ElementTree(output_root)
    tree.write(out_path, encoding="utf-8", xml_declaration=True)
    print(f"Generated {out_path}")

if __name__ == "__main__":
    print("Initializing Troop Database...")
    ALL_TROOPS = load_and_merge_troops()
    
    for culture, roots in CULTURES.items():
        generate_culture(culture, roots, ALL_TROOPS, ranks=20)

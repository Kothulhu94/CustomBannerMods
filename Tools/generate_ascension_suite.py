import xml.etree.ElementTree as ET
import sys
import copy
import os
import json

# Configuration
VANILLA_XML = "d:/Bannerlord_Mods/tools/XML_Def/SandBoxCore/spnpccharacters.xml"
NAVAL_XML = "d:/Bannerlord_Mods/tools/XML_Def/NavalDLC/naval_characters.xml"
OUTPUT_DIR = "d:/Bannerlord_Mods/Modules/Ascension/ModuleData/"

CULTURES = {
    "aserai": ["aserai_recruit", "aserai_youth"],
    "battania": ["battanian_volunteer", "battanian_highborn_youth"],
    "empire": ["imperial_recruit", "imperial_vigla_recruit"],
    "khuzait": ["khuzait_nomad", "khuzait_noble_son"],
    "sturgia": ["sturgian_recruit", "sturgian_warrior_son"],
    "vlandia": ["vlandian_recruit", "vlandian_squire"],
    "nord": ["nord_youngling"],
}

def load_and_merge_troops():
    troops = {}
    vanilla_ids = set()
    naval_ids = set()
    
    # 1. Load Vanilla
    print(f"Loading Vanilla: {VANILLA_XML}")
    tree = ET.parse(VANILLA_XML)
    for npc in tree.getroot().findall('NPCCharacter'):
        tid = npc.get('id')
        if tid:
            troops[tid] = npc
            vanilla_ids.add(tid)
            
    # 2. Load Naval (and Merge Upgrade Targets only)
    if os.path.exists(NAVAL_XML):
        print(f"Loading Naval: {NAVAL_XML}")
        tree_nav = ET.parse(NAVAL_XML)
        for npc in tree_nav.getroot().findall('NPCCharacter'):
            tid = npc.get('id')
            
            # If unit exists in Vanilla, it's a PATCH.
            # If not, it's a NEW NAVAL UNIT.
            
            if tid in troops:
                # Merge Targets
                existing = troops[tid]
                nav_upgrades = npc.find('upgrade_targets')
                
                if nav_upgrades is not None:
                    ex_upgrades = existing.find('upgrade_targets')
                    if ex_upgrades is None:
                        ex_upgrades = ET.SubElement(existing, 'upgrade_targets')
                    
                    existing_ids = [u.get('id') for u in ex_upgrades.findall('upgrade_target')]
                    
                    for u in nav_upgrades.findall('upgrade_target'):
                        if u.get('id') not in existing_ids:
                            ex_upgrades.append(u)
            else:
                # New Naval Troop
                troops[tid] = npc
                naval_ids.add(tid)
    else:
        print("Warning: Naval XML not found. Skipping merge.")
        
    return troops, vanilla_ids, naval_ids

def generate_culture(culture_id, root_ids, all_troops, vanilla_ids, naval_ids, ranks=1):
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
    
    # ================= GENERATE COMBINED XML =================
    output_root = ET.Element("NPCCharacters")
    
    for rank in range(1, ranks + 1):
        comment = ET.Comment(f" ================= RANK {rank} ================= ")
        output_root.append(comment)
        
        # Process ALL troops in trace
        for vid in target_tree_ids:
            vanilla_node = all_troops[vid]
            asc_node = copy.deepcopy(vanilla_node)
            
            # Attribute Modification
            asc_id = f"{vid}_asc_{rank}"
            asc_node.set('id', asc_id)
            
            v_name = vanilla_node.get('name', 'Troop').strip("{}")
            if "}" in v_name:
                v_name_text = v_name.split("}")[1]
                loc_key = v_name.split("}")[0][2:]
                new_key = f"Asc_{loc_key}_{rank}"
                new_name = f"{{={new_key}}}{v_name_text} (Rank {rank})"
            else:
                new_name = f"{v_name} (Rank {rank})"
            asc_node.set('name', new_name)
            
            base_level = int(vanilla_node.get('level', 1))
            new_level = base_level + (5 * rank)
            asc_node.set('level', str(new_level))
            
            skills_node = asc_node.find('skills')
            if skills_node is not None:
                for skill in skills_node.findall('skill'):
                    base_val = int(skill.get('value', 0))
                    new_val = base_val + (20 * rank)
                    skill.set('value', str(new_val))
            
            # Linkage Logic - INCLUDE ALL TARGETS
            upgrades_node = asc_node.find('upgrade_targets')
            if upgrades_node is not None:
                # Clear existing
                for t in list(upgrades_node):
                    upgrades_node.remove(t)
                
                # Check ALL targets
                v_upgrades = vanilla_node.find('upgrade_targets')
                if v_upgrades is not None:
                    for vt in v_upgrades.findall('upgrade_target'):
                        vt_id = vt.get('id').replace('NPCCharacter.', '')
                        
                        if vt_id in target_tree_ids:
                            target_asc_id = f"{vt_id}_asc_{rank}"
                            # Always add to XML
                            new_target = ET.SubElement(upgrades_node, 'upgrade_target')
                            new_target.set('id', f"NPCCharacter.{target_asc_id}")

            output_root.append(asc_node)

    ET.indent(output_root, space="  ", level=0)
    filename = f"AscendedTroops_{culture_id}.xml"
    tree = ET.ElementTree(output_root)
    tree.write(OUTPUT_DIR + filename, encoding="utf-8", xml_declaration=True)
    print(f"Generated Combined XML: {filename}")

if __name__ == "__main__":
    print("Initializing Troop Database...")
    if not os.path.exists(OUTPUT_DIR):
        os.makedirs(OUTPUT_DIR)
        
    ALL_TROOPS, VANILLA_IDS, NAVAL_IDS = load_and_merge_troops()
    
    for culture, roots in CULTURES.items():
        generate_culture(culture, roots, ALL_TROOPS, VANILLA_IDS, NAVAL_IDS, ranks=20)

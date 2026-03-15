import os
import re
import argparse

# Common tags to look for attributes in
TARGET_TAGS = ['Item', 'CraftedItem', 'Settlement', 'Workshop', 'Mesh', 'Prefab', 'SceneObject', 'FloraKind', 'Culture', 'Character']
ATTRS_TO_GET = ['id', 'name', 'mesh', 'text']

def get_tag_info(content, match_pos):
    # Find the nearest start tag '<' before match_pos
    # We search backwards for a '<' that is followed by a letter (tag name)
    # and doesn't have a '/' after it.
    
    # Try to find all tag starts in the vicinity
    # A simple but effective way: find the start of the current or parent tag
    potential_starts = list(re.finditer(r'<([a-zA-Z0-9_]+)', content[:match_pos]))
    if not potential_starts:
        return None
    
    # Check from the last one backwards to find the one that actually contains our match
    for tag_match in reversed(potential_starts):
        tag_start_pos = tag_match.start()
        tag_name = tag_match.group(1)
        
        # Find the end of this tag's definition header
        # Caution: it might be a self-closing tag /> or a regular tag >
        tag_header_end = re.search(r'/?\s*>', content[tag_start_pos:])
        if not tag_header_end:
            continue
            
        header_end_pos = tag_start_pos + tag_header_end.end()
        
        # If the match is within the header (attributes) OR 
        # let's assume if it's after the header but before the next tag, it belongs here
        # (For simple item searches, matches are usually in attributes or text content)
        
        tag_header_content = content[tag_start_pos:header_end_pos]
        
        info = {'tag': tag_name}
        found_any = False
        for attr in ATTRS_TO_GET:
            # Match attribute="value" or attribute='value', handle optional spaces
            attr_regex = fr'{attr}\s*=\s*["\']([^"\']*)["\']'
            attr_match = re.search(attr_regex, tag_header_content, re.IGNORECASE)
            if attr_match:
                info[attr] = attr_match.group(1)
                found_any = True
        
        if found_any or tag_name in TARGET_TAGS:
            return info
            
    return None

def search_xml(search_dirs, pattern, extensions=['.xml']):
    search_regex = re.compile(pattern, re.IGNORECASE)
    
    for search_dir in search_dirs:
        if not os.path.exists(search_dir):
            continue
            
        for root, _, files in os.walk(search_dir):
            for file in files:
                if any(file.endswith(ext) for ext in extensions):
                    filepath = os.path.join(root, file)
                    rel_path = os.path.relpath(filepath, os.getcwd())
                    try:
                        with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
                            content = f.read()
                            
                        matches = list(search_regex.finditer(content))
                        if not matches:
                            continue
                            
                        found_tags = set()
                        
                        for m in matches:
                            line_no = content.count('\n', 0, m.start()) + 1
                            info = get_tag_info(content, m.start())
                            
                            if info:
                                # Create a unique key for the tag in this file
                                tag_id = info.get('id') or info.get('name') or info.get('mesh') or "unknown"
                                tag_key = (filepath, tag_id, info.get('tag'))
                                
                                if tag_key not in found_tags:
                                    found_tags.add(tag_key)
                                    attrs = [f'{k}="{v}"' for k, v in info.items() if k != 'tag']
                                    attr_str = " ".join(attrs)
                                    print(f"[{rel_path}:{line_no}] <{info['tag']} {attr_str}>")
                                    
                    except Exception as e:
                        print(f"Error reading {filepath}: {e}")

if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="Find items/objects in Bannerlord XMLs.")
    parser.add_argument("query", help="Partial name or ID to search for")
    parser.add_argument("--dirs", nargs="+", default=["Tools/XML_Def", "Modules"], help="Directories to search (relative to root)")
    
    args = parser.parse_args()
    
    root_dir = os.getcwd()
    search_paths = [os.path.join(root_dir, d) for d in args.dirs]
    
    print(f"Searching for '{args.query}'...")
    search_xml(search_paths, args.query)

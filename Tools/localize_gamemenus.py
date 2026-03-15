import os
import re

MODULES_DIR = r"d:\Bannerlord_Mods\Modules\LivingWorld\Source"

def replace_gamemenu(match):
    before = match.group(1) # campaignStarter.AddGameMenu("menu_id", 
    string_literal = match.group(2) # "Text"
    after = match.group(3) # , ...
    
    if "{=" in string_literal:
        return match.group(0)
    
    # Just prefix {=id} to the string.
    # We will generate a short text based id
    text_alpha = re.sub(r'[^a-zA-Z0-9]', '', string_literal).lower()[:15]
    loc_id = f"lw_{text_alpha}"
    
    return f'{before}"{{={loc_id}}}{string_literal}"{after}'

def process_file(path):
    with open(path, 'r', encoding='utf-8') as f:
        content = f.read()

    # match AddGameMenu("id", "text", ...)
    content = re.sub(r'(AddGameMenu\s*\(\s*[^,]+,\s*(?:\$)?)"([^"]+)"([^,]*)', replace_gamemenu, content)
    
    # match AddGameMenuOption("id", "opt_id", "text", ...)
    content = re.sub(r'(AddGameMenuOption\s*\(\s*[^,]+,\s*[^,]+,\s*(?:\$)?)"([^"]+)"([^,]*)', replace_gamemenu, content)
    
    with open(path, 'w', encoding='utf-8') as f:
        f.write(content)

for root, _, files in os.walk(MODULES_DIR):
    for f in files:
        if f.endswith(".cs"):
            process_file(os.path.join(root, f))

print("Localization added to GameMenus.")

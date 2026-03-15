import os
import re

MODULES_DIR = r"d:\Bannerlord_Mods\Modules\LivingWorld\Source"

def add_localization(match):
    prefix = match.group(1)
    string_literal = match.group(2)
    # Check if already localized
    if "{=" in string_literal:
        return match.group(0)
    
    # Generate an ID from the string logic or just a hash/simplified text
    text_alpha = re.sub(r'[^a-zA-Z0-9]', '', string_literal).lower()[:15]
    loc_id = f"lw_{text_alpha}"
    
    # InformationMessage takes string, but we usually wrap with TextObject().ToString() or just TextObject if overloaded
    # However we will prepend {=...} to the string.
    # It might be safer to wrap in new TextObject("{=ID}Text").ToString() for InformationMessage
    return f'{prefix}new TaleWorlds.Localization.TextObject("{{={loc_id}}}{string_literal}").ToString()'

def process_file(path):
    with open(path, 'r', encoding='utf-8') as f:
        content = f.read()

    # InformationMessage("text") -> InformationMessage(new TextObject("{=id}text").ToString())
    content = re.sub(r'(InformationMessage\s*\(\s*[\$]?)"([^"]+)"', add_localization, content)
    
    with open(path, 'w', encoding='utf-8') as f:
        f.write(content)

for root, _, files in os.walk(MODULES_DIR):
    for f in files:
        if f.endswith(".cs"):
            process_file(os.path.join(root, f))

print("Localization added to InformationMessages.")

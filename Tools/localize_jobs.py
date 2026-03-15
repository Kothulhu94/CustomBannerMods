import os
import re

MODULES_DIR = r"d:\Bannerlord_Mods\Modules\LivingWorld\Source"

def replace_job_string(match):
    prop = match.group(1) # Name = or Description = 
    string_literal = match.group(2) # "Text"
    
    if "{=" in string_literal:
        return match.group(0)
    
    text_alpha = re.sub(r'[^a-zA-Z0-9]', '', string_literal).lower()[:15]
    loc_id = f"lw_job_{text_alpha}"
    
    return f'{prop}"{{={loc_id}}}{string_literal}"'

def process_file(path):
    with open(path, 'r', encoding='utf-8') as f:
        content = f.read()

    # match Name = "...", Description = "..."
    content = re.sub(r'(Name\s*=\s*(?:\$)?)"([^"]+)"', replace_job_string, content)
    content = re.sub(r'(Description\s*=\s*(?:\$)?)"([^"]+)"', replace_job_string, content)
    
    with open(path, 'w', encoding='utf-8') as f:
        f.write(content)

for root, _, files in os.walk(MODULES_DIR):
    for f in files:
        if f.endswith("Behavior.cs") or f.endswith("Model.cs") or f.endswith("VM.cs"):
            process_file(os.path.join(root, f))

print("Localization added to Job names and descriptions.")

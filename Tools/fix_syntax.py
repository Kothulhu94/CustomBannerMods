import os
import re

MODULES_DIR = r"d:\Bannerlord_Mods\Modules\LivingWorld\Source"

def process_file(path):
    with open(path, 'r', encoding='utf-8') as f:
        content = f.read()

    # Fix: $new TaleWorlds.Localization.TextObject(" -> new TaleWorlds.Localization.TextObject($"
    content = content.replace('$new TaleWorlds.Localization.TextObject("', 'new TaleWorlds.Localization.TextObject($"')
    
    with open(path, 'w', encoding='utf-8') as f:
        f.write(content)

for root, _, files in os.walk(MODULES_DIR):
    for f in files:
        if f.endswith(".cs"):
            process_file(os.path.join(root, f))

print("Syntax fixed.")

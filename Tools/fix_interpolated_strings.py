import os
import re

MODULES_DIR = r"d:\Bannerlord_Mods\Modules\LivingWorld\Source"

def process_file(path):
    with open(path, 'r', encoding='utf-8') as f:
        content = f.read()

    # Find: $"(maybe some spaces){=id}
    # Replace with: $"{{=id}}
    content = re.sub(r'\$"\s*\{=([^}]+)\}', r'$"{{=\1}}', content)
    
    with open(path, 'w', encoding='utf-8') as f:
        f.write(content)

for root, _, files in os.walk(MODULES_DIR):
    for f in files:
        if f.endswith(".cs"):
            process_file(os.path.join(root, f))

print("Interpolated strings fixed.")

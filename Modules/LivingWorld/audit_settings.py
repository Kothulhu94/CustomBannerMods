import re
import os
import glob

settings_file = r"e:\Bannerlord_Mods\Modules\LivingWorld\Source\LivingWorldSettings.cs"
source_dir = r"e:\Bannerlord_Mods\Modules\LivingWorld\Source"

def get_settings():
    settings = []
    with open(settings_file, 'r', encoding='utf-8') as f:
        for line in f:
            match = re.search(r'public .* (HonestWork_[A-Za-z0-9_]+) \{', line)
            if match:
                settings.append(match.group(1))
    return settings

def count_occurrences(setting, root_dir):
    count = 0
    # recursively walk
    for root, dirs, files in os.walk(root_dir):
        for file in files:
            if file.endswith(".cs"):
                path = os.path.join(root, file)
                try:
                    with open(path, 'r', encoding='utf-8') as f:
                        content = f.read()
                        # simple count
                        count += content.count(setting)
                except:
                    pass
    return count

print("Scanning for unhooked HonestWork settings...")
settings = get_settings()
unhooked = []

for s in settings:
    # We expect at least 1 usage (definition in settings file)
    # So if count <= 1, it's effectively unused
    count = count_occurrences(s, source_dir)
    # print(f"{s}: {count}")
    if count <= 1:
        unhooked.append(s)

if not unhooked:
    print("All HonestWork settings appear to be hooked!")
else:
    print(f"Found {len(unhooked)} potentially unhooked settings:")
    for s in unhooked:
        print(f" - {s}")

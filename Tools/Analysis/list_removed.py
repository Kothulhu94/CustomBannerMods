import os
import zipfile

def get_files(path):
    if not os.path.exists(path): return set()
    with zipfile.ZipFile(path, 'r') as zF:
        return set(zF.namelist())

s14 = get_files(r"e:\Bannerlord_Mods\_Release\LivingWorld_v1.4.zip")
s15 = get_files(r"e:\Bannerlord_Mods\_Release\LivingWorld_v1.5.zip")

removed = s14 - s15
print(f"Removed {len(removed)} files:")
for f in removed:
    print(f"- {f}")
print(f"Total files in v1.5: {len(s15)}")

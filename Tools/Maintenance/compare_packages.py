import os
import zipfile

def analyze_zip(path, label):
    print(f"\n--- Analyzing {label}: {path} ---")
    if not os.path.exists(path):
        print("File not found.")
        return set(), 0
        
    files = set()
    total_size = 0
    try:
        with zipfile.ZipFile(path, 'r') as zF:
            for info in zF.infolist():
                files.add(info.filename)
                total_size += info.file_size
    except Exception as e:
        print(f"Error: {e}")
        return set(), 0
    
    print(f"Total Files: {len(files)}")
    print(f"Total Uncompressed Size: {total_size} bytes")
    return files, total_size

files_14, size_14 = analyze_zip(r"e:\Bannerlord_Mods\_Release\LivingWorld_v1.4.zip", "v1.4")
files_15, size_15 = analyze_zip(r"e:\Bannerlord_Mods\_Release\LivingWorld_v1.5.zip", "v1.5")

print("\n--- COMPARISON ---")
only_in_14 = files_14 - files_15
only_in_15 = files_15 - files_14

print(f"Files only in v1.4 ({len(only_in_14)}):")
for f in sorted(list(only_in_14))[:10]:
    print(f"  - {f}")
if len(only_in_14) > 10: print("  ... and more")

print(f"Files only in v1.5 ({len(only_in_15)}):")
for f in sorted(list(only_in_15))[:10]:
    print(f"  - {f}")

# Critical Check
dll_path = "LivingWorld/bin/Win64_Shipping_Client/LivingWorld.dll"
# Note: Path separators in zip might be forward slashes.
# Check if any file ends with LivingWorld.dll
dll_found_15 = any(f.endswith("LivingWorld.dll") for f in files_15)
print(f"\nCRITICAL: LivingWorld.dll in v1.5? {dll_found_15}")

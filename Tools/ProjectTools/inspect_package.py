import os
import zipfile

def list_dir(path):
    print(f"\n--- Directory: {path} ---")
    if not os.path.exists(path):
        print("Path does not exist.")
        return
    for root, dirs, files in os.walk(path):
        for file in files:
            fp = os.path.join(root, file)
            print(f"{os.path.getsize(fp):8d} bytes - {os.path.relpath(fp, path)}")

def list_zip(path):
    print(f"\n--- Zip: {path} ---")
    if not os.path.exists(path):
        try:
            # Maybe it's without extension in the arg, but user screenshot implies extension or type.
            # Let's try adding .zip just in case, though the input was explicit.
            if os.path.exists(path + ".zip"):
                path += ".zip"
            else:
                print("File does not exist.")
                return
        except:
            print("File does not exist.")
            return
            
    try:
        with zipfile.ZipFile(path, 'r') as zF:
            for info in zF.infolist():
                print(f"{info.file_size:8d} bytes - {info.filename}")
    except Exception as e:
        print(f"Error reading zip: {e}")

print("INSPECTING SOURCE:")
list_dir(r"e:\Bannerlord_Mods\Modules\LivingWorld")

print("\nINSPECTING PACKAGES:")
list_zip(r"e:\Bannerlord_Mods\_Release\LivingWorld_v1.4.zip")
list_zip(r"e:\Bannerlord_Mods\_Release\LivingWorld_v1.5.zip")

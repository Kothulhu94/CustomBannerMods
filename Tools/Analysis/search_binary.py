import sys
import os

def search_in_file(filepath, needle):
    if not os.path.exists(filepath):
        print(f"File not found: {filepath}")
        return False
        
    with open(filepath, 'rb') as f:
        content = f.read()
        
        # Search UTF-8
        if needle.encode('utf-8') in content:
            print(f"[FOUND-UTF8] '{needle}' in {filepath}")
            return True
            
        # Search UTF-16LE (Windows .NET default)
        if needle.encode('utf-16le') in content:
            print(f"[FOUND-UTF16] '{needle}' in {filepath}")
            return True
            
        print(f"[CLEAN] '{needle}' NOT found in {filepath}")
        return False

if __name__ == "__main__":
    needle = "deciderHero"
    
    # 1. Build Output
    path1 = r"E:\Bannerlord_Mods\Modules\LivingWorld\bin\Win64_Shipping_Client\LivingWorld.dll"
    search_in_file(path1, needle)
    
    # 2. Deployed Game Path
    path2 = r"C:\Users\RHoskins.evvcr\.gemini\antigravity\scratch\Steam\steamapps\common\Mount & Blade II Bannerlord\Modules\LivingWorld\bin\Win64_Shipping_Client\LivingWorld.dll"
    search_in_file(path2, needle)

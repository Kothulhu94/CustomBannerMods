import sys
import re

def dump_strings(filepath):
    with open(filepath, 'rb') as f:
        data = f.read()
        
    # Search for UTF-16LE strings (common in .NET metadata)
    # 2 bytes per char. ASCII chars look like: c \x00
    # Look for sequences of at least 4 chars.
    pattern = re.compile(b'(?:[\x20-\x7E]\x00){4,}')
    
    found = False
    for match in pattern.finditer(data):
        try:
            s = match.group().decode('utf-16le')
            if "decider" in s.lower():
                print(f"MATCH: {s}")
                found = True
        except:
            pass
            
    if not found:
        print("No matches for 'decider' found.")

if __name__ == "__main__":
    path = r"C:\Users\RHoskins.evvcr\.gemini\antigravity\scratch\Steam\steamapps\common\Mount & Blade II Bannerlord\Modules\LivingWorld\bin\Win64_Shipping_Client\LivingWorld.dll"
    print(f"Scanning: {path}")
    dump_strings(path)

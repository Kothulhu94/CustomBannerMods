import os
import re

MODULES_DIR = r"d:\Bannerlord_Mods\Modules\LivingWorld\Source"
OUTPUT_DIR = r"d:\Bannerlord_Mods\Modules\LivingWorld\ModuleData\Languages\EN"
OUTPUT_FILE = os.path.join(OUTPUT_DIR, "strings.xml")

def generate_xml():
    os.makedirs(OUTPUT_DIR, exist_ok=True)
    
    entries = {}
    
    # Match {=id}text
    # sometimes text includes interpolations like {HERO_NAME} or {string.Join(...)}
    # We will match {=id} and then everything up to the closing quote "
    # wait, if there are quotes inside due to string.Join, it's harder, but we can do our best.
    
    regex = re.compile(r'\{=([a-zA-Z0-9_]+)\}(([^"\\]|\\.)*)')
    
    for root, _, files in os.walk(MODULES_DIR):
        for f in files:
            if f.endswith(".cs") or f.endswith(".xml"):
                with open(os.path.join(root, f), 'r', encoding='utf-8') as infile:
                    content = infile.read()
                    matches = regex.findall(content)
                    for m in matches:
                        loc_id = m[0]
                        text = m[1].strip()
                        # Clean up text (remove trailing escapes or quotes if caught)
                        if text.endswith('").ToString()'):
                            text = text[:-13]
                        if text.endswith('")}'):
                            text = text[:-3]
                        if text.endswith(')"'):
                            text = text[:-2]
                        
                        # Just a rough extraction since English is default fallback anyway
                        entries[loc_id] = text

    with open(OUTPUT_FILE, 'w', encoding='utf-8') as outfile:
        outfile.write('<?xml version="1.0" encoding="utf-8"?>\n')
        outfile.write('<base xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" type="string">\n')
        outfile.write('  <tags>\n')
        outfile.write('    <tag language="English" />\n')
        outfile.write('  </tags>\n')
        outfile.write('  <strings>\n')
        for loc_id, text in entries.items():
            # escape xml specials
            safe_text = text.replace('&', '&amp;').replace('<', '&lt;').replace('>', '&gt;')
            outfile.write(f'    <string id="{loc_id}" text="{safe_text}" />\n')
        outfile.write('  </strings>\n')
        outfile.write('</base>\n')

    print(f"Generated XML with {len(entries)} strings at {OUTPUT_FILE}")

if __name__ == "__main__":
    generate_xml()

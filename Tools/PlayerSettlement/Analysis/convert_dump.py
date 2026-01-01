import sys
import codecs

source_path = r"d:\Bannerlord_Mods\temp_ps_dump.cs"
dest_path = r"d:\Bannerlord_Mods\temp_ps_dump_utf8.cs"

try:
    with codecs.open(source_path, 'r', 'utf-16') as source_file:
        content = source_file.read()
    
    with codecs.open(dest_path, 'w', 'utf-8') as dest_file:
        dest_file.write(content)
        
    print(f"Converted {source_path} to UTF-8 at {dest_path}")
except Exception as e:
    print(f"Error: {e}")

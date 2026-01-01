
import codecs
import os

source_path = r'd:\Bannerlord_Mods\PlayerSettlement_FullSource.cs'
dest_path = r'd:\Bannerlord_Mods\PlayerSettlement_FullSource_utf8.cs'

print(f"Converting {source_path} to {dest_path}")

try:
    with codecs.open(source_path, 'r', 'utf-16') as source_file:
        content = source_file.read()
    
    with codecs.open(dest_path, 'w', 'utf-8') as dest_file:
        dest_file.write(content)
        
    print("Conversion complete.")
except Exception as e:
    print(f"Error: {e}")

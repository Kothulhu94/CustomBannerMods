
filename = r"d:\Bannerlord_Mods\temp_ps_dump_utf8.cs"
search_term = "void Tick"

with open(filename, 'r', encoding='utf-8') as f:
    for i, line in enumerate(f):
        if search_term in line:
            print(f"Found '{search_term}' at line {i+1}")


filename = r"d:\Bannerlord_Mods\temp_ps_dump_utf8.cs"
search_terms = ["UpdateSettlementVisualEntity", "RegisterEvents", "OnApplicationTick"]

with open(filename, 'r', encoding='utf-8') as f:
    for i, line in enumerate(f):
        for term in search_terms:
            if term in line:
                print(f"Found '{term}' at line {i+1}")

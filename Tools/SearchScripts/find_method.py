
with open("d:/Bannerlord_Mods/PlayerSettlement_FullSource_UTF8.cs", "r", encoding="utf-8", errors="ignore") as f:
    for i, line in enumerate(f):
        if "void OnBeforeTick(" in line:
            print(f"Found OnBeforeTick at line {i+1}")

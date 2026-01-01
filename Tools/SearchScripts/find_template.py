
with open("d:/Bannerlord_Mods/PlayerSettlement_FullSource_UTF8.cs", "r", encoding="utf-8", errors="ignore") as f:
    for i, line in enumerate(f):
        if "List<PlayerSettlementItemTemplate>" in line:
            print(f"Found declaration at line {i+1}: {line.strip()}")
        if "new List<PlayerSettlementItemTemplate>" in line:
            print(f"Found instantiation at line {i+1}: {line.strip()}")

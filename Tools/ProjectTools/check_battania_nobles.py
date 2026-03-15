import xml.etree.ElementTree as ET

def check_battania():
    xml_path = 'e:/Bannerlord_Mods/Modules/Ascension/ModuleData/AscendedTroops_battania.xml'
    f = open('e:/Bannerlord_Mods/battania_report.txt', 'w')
    def log(s):
        print(s)
        f.write(s + "\n")
        
    tree = ET.parse(xml_path)
    root = tree.getroot()
    
    troops = {}
    for npc in root.findall('NPCCharacter'):
        troops[npc.get('id')] = npc
        
    for t_id, npc in troops.items():
        if 'fian' in t_id.lower() or 'champion' in t_id.lower() or 'highborn' in t_id.lower():
            lvl = npc.get('level')
            try:
                ilvl = int(lvl)
                if ilvl < 20 or ilvl > 50: continue
            except: continue

            log(f"Troop: {t_id} (Level {lvl})")
            upgrades = npc.find('upgrade_targets')
            if upgrades is not None:
                for t in upgrades.findall('upgrade_target'):
                    target_id = t.get('id').replace('NPCCharacter.', '')
                    target_lvl = "UNKNOWN"
                    if target_id in troops:
                        target_lvl = troops[target_id].get('level')
                    
                    log(f"  -> {target_id} (Level {target_lvl})")
                    
                    try:
                        if int(target_lvl) <= int(lvl):
                            log(f"  CRITICAL ERROR: Target level {target_lvl} <= Source level {lvl}")
                    except:
                        pass
            log("-" * 20)
            
    f.close()

if __name__ == "__main__":
    check_battania()

import xml.etree.ElementTree as ET

path = 'd:/Bannerlord_Mods/tools/XML_Def/NavalDLC/naval_characters.xml'
tree = ET.parse(path)
root = tree.getroot()

print("--- Naval Basic Troops ---")
for npc in root.findall('NPCCharacter'):
    if npc.get('is_basic_troop') == 'true':
        print(npc.get('id'))

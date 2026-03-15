import os
import glob
import xml.etree.ElementTree as ET

MODULE_DIR = "d:/Bannerlord_Mods/Modules/KotK_Patch/"
DATA_DIR = os.path.join(MODULE_DIR, "ModuleData")
SUBMODULE_PATH = os.path.join(MODULE_DIR, "SubModule.xml")

def generate_submodule():
    # Find all generated XMLs
    xml_files = glob.glob(os.path.join(DATA_DIR, "AscendedTroops_KotK_*.xml"))
    xml_names = [os.path.basename(f).replace('.xml', '') for f in xml_files]
    
    root = ET.Element("Module")
    
    ET.SubElement(root, "Name", value="KotK Ascension Patch")
    ET.SubElement(root, "Id", value="KotK_Patch")
    ET.SubElement(root, "Version", value="v1.0.0")
    ET.SubElement(root, "SingleplayerModule", value="true")
    ET.SubElement(root, "MultiplayerModule", value="false")
    
    deps = ET.SubElement(root, "DependedModules")
    ET.SubElement(deps, "DependedModule", Id="Native")
    ET.SubElement(deps, "DependedModule", Id="SandBoxCore")
    ET.SubElement(deps, "DependedModule", Id="Sandbox")
    ET.SubElement(deps, "DependedModule", Id="StoryMode")
    ET.SubElement(deps, "DependedModule", Id="CustomBattle")
    ET.SubElement(deps, "DependedModule", Id="kult_of_the_kallipygos_2_MAIN_MOD")
    ET.SubElement(deps, "DependedModule", Id="Ascension") # Ensure load order
    
    ET.SubElement(root, "SubModules")
    
    xmls = ET.SubElement(root, "Xmls")
    
    for xml_name in xml_names:
        node = ET.SubElement(xmls, "XmlNode")
        ET.SubElement(node, "XmlName", id="NPCCharacters", path=xml_name)
        included = ET.SubElement(node, "IncludedGameTypes")
        ET.SubElement(included, "GameType", value="Campaign")
        ET.SubElement(included, "GameType", value="CampaignStoryMode")
        ET.SubElement(included, "GameType", value="CustomGame")
        ET.SubElement(included, "GameType", value="EditorGame")
        
    ET.indent(root, space="  ", level=0)
    tree = ET.ElementTree(root)
    tree.write(SUBMODULE_PATH, encoding="utf-8", xml_declaration=True)
    print(f"Generated SubModule.xml with {len(xml_names)} XML entries.")

if __name__ == "__main__":
    generate_submodule()

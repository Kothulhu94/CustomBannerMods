import clr
import sys
import os

libs = r"d:\Bannerlord_Mods\libs"
dlls = ["TaleWorlds.Library.dll", "TaleWorlds.Core.dll", "TaleWorlds.CampaignSystem.dll"]

for dll in dlls:
    path = os.path.join(libs, dll)
    try:
        clr.AddReference(path)
    except Exception as e:
        print(f"Failed to load {dll}: {e}")

from TaleWorlds.Library import *
from TaleWorlds.CampaignSystem import *
from TaleWorlds.CampaignSystem.Party import *
from TaleWorlds.CampaignSystem.Settlements import *

def dump_type_members(type_obj):
    print(f"\n==== {type_obj.FullName} ====")
    print("PROPERTIES:")
    for prop in type_obj.GetProperties():
        print(f"  P: {prop.Name} ({prop.PropertyType.Name})")
    
    print("METHODS:")
    for method in type_obj.GetMethods():
        params = [f"{p.ParameterType.Name} {p.Name}" for p in method.GetParameters()]
        print(f"  M: {method.ReturnType.Name} {method.Name}({', '.join(params)})")

# Scan TaleWorlds.Library for CampaignVec2 explicitly if not imported
import System
campaign_vec2 = None
for assembly in System.AppDomain.CurrentDomain.GetAssemblies():
    t = assembly.GetType("TaleWorlds.Library.CampaignVec2")
    if t:
        campaign_vec2 = t
        break

if campaign_vec2:
    dump_type_members(campaign_vec2)
else:
    print("CampaignVec2 NOT FOUND in any loaded assembly")

dump_type_members(clr.GetClrType(MobileParty))
dump_type_members(clr.GetClrType(Settlement))
dump_type_members(clr.GetClrType(PartyBase))
dump_type_members(clr.GetClrType(Village))

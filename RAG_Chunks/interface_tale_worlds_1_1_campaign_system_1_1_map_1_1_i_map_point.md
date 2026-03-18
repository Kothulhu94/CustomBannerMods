--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html ---

TaleWorlds.CampaignSystem.Map.IMapPoint Interface ReferenceInherited by [TaleWorlds.CampaignSystem.Party.MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), and [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetPositionAsVec3](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#ae172008491c85da53167da47d59ee6d2) () |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a9fb1af1ef552ebd3d10304da752defa7) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [Position](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a4b2b24b574807e41e0c1b4afe629adb1) `[get]` |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | [CurrentNavigationFace](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#aafc1ce3465c81b843115c55e18f63da1) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a779a86170e3020b297abca9923ff4f47) `[get]` |
| bool | [IsInspected](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a52a27327b9546405aca825138d341bd9) `[get]` |
| bool | [IsVisible](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a3a703415b6c660034bba2b73841d0005) `[get]` |
| bool | [IsActive](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a9a94a3139781933fc6095d4a190ed447) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#ae172008491c85da53167da47d59ee6d2)GetPositionAsVec3()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.CampaignSystem.Map.IMapPoint.GetPositionAsVec3 | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Party.MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a31ba82b670225e785eb9ff39aaa5f5a1), and [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ac2791fdb24b3783a1dac4388be9ab06a).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a9fb1af1ef552ebd3d10304da752defa7)Name
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Map.IMapPoint.Name | | get |

Implemented in [TaleWorlds.CampaignSystem.Party.MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aac1d15fc82dc1ae9c68f228fe55d504d), and [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a89d2eeaa0144d1289211d5366e238f96).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a4b2b24b574807e41e0c1b4afe629adb1)Position
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Map.IMapPoint.Position | | get |

Implemented in [TaleWorlds.CampaignSystem.Party.MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2b734fcbd8a03fceed0cec8eeef27450), and [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a2f9f0256ff1109297d9fa48d74ba932c).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#aafc1ce3465c81b843115c55e18f63da1)CurrentNavigationFace
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) TaleWorlds.CampaignSystem.Map.IMapPoint.CurrentNavigationFace | | get |

Implemented in [TaleWorlds.CampaignSystem.Party.MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6de4c68214e697ef5d6d0e12dd7516b2), and [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aca6fe4bd030cae3d3bf23be92ca5539e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a779a86170e3020b297abca9923ff4f47)MapFaction
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Map.IMapPoint.MapFaction | | get |

Implemented in [TaleWorlds.CampaignSystem.Party.MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9980ede3f4bfe0b42faab2e1a1768a9e), and [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aa5fbaaee56f205969a2ddab2b0990549).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a52a27327b9546405aca825138d341bd9)IsInspected
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Map.IMapPoint.IsInspected | | get |

Implemented in [TaleWorlds.CampaignSystem.Party.MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aea963275aee38aff6ae562e13f7ff193), and [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a160294c9b6ff0faee224b8712a42f07f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a3a703415b6c660034bba2b73841d0005)IsVisible
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Map.IMapPoint.IsVisible | | get |

Implemented in [TaleWorlds.CampaignSystem.Party.MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a01d920f01a3fbb6d914e9837fb033c4b), and [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1070e0990dd6467f8559df4dba5e400d).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a9a94a3139781933fc6095d4a190ed447)IsActive
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Map.IMapPoint.IsActive | | getset |

Implemented in [TaleWorlds.CampaignSystem.Party.MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae9e22f46bd3278277f9e477deb2a9b1f), and [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1a38bad728cf80965ce1df725f208ee8).


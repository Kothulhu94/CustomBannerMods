--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html ---

TaleWorlds.MountAndBlade.IReadOnlyPerkObject Interface ReferenceInherited by [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetExtraTroopCount](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a9880940607167704d305f0fb5759bd5f) (bool isWarmup) |
| List<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> | [GetAlternativeEquipments](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a081e58c27dc14774201de63cd67c04e4) (bool isWarmup, bool isPlayer, List<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> alternativeEquipments, bool getAllEquipments=false) |
| float | [GetDrivenPropertyBonusOnSpawn](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a9e2bb44b66407149a818bbd13cccf6ab) (bool isWarmup, bool isPlayer, [DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) drivenProperty, float baseValue) |
| float | [GetHitpoints](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a91694b7f608ab970776fb49a66d318dc) (bool isWarmup, bool isPlayer) |
| [MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html) | [Clone](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a590d9716158e98cb6929bde5fc018b0c) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a8b4b2de1c3b53b758591eae30b4e1fd4) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Description](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a67eb5edd1c5d423903b012577095872a) `[get]` |
| List< string > | [GameModes](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a865d428c239d09bcf0115cd32ffdf71f) `[get]` |
| int | [PerkListIndex](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a7f59ba6fbdadfa56b2d4290301e9f6ba) `[get]` |
| string | [IconId](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a4d101cf82f7115898b723484737dcbd4) `[get]` |
| string | [HeroIdleAnimOverride](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#ad2c43774f4147a525cb6e5c9e61cab3d) `[get]` |
| string | [HeroMountIdleAnimOverride](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a8b6be5f1bb222440689443f123861f63) `[get]` |
| string | [TroopIdleAnimOverride](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a8d187eb9de1fc3fb9b0c6e76d17c5f13) `[get]` |
| string | [TroopMountIdleAnimOverride](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a23dc610b6c7681f68c9a04a5df5ed86f) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a9880940607167704d305f0fb5759bd5f)GetExtraTroopCount()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.IReadOnlyPerkObject.GetExtraTroopCount | ( | bool | *isWarmup* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ac4aa3c1383ebcd8564bae2acaa26eee5).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a081e58c27dc14774201de63cd67c04e4)GetAlternativeEquipments()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> TaleWorlds.MountAndBlade.IReadOnlyPerkObject.GetAlternativeEquipments | ( | bool | *isWarmup*, |
|  |  | bool | *isPlayer*, |
|  |  | List<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> | *alternativeEquipments*, |
|  |  | bool | *getAllEquipments* = false ) |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a2c6b09ac4de921c129750f8d9f3d686f).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a9e2bb44b66407149a818bbd13cccf6ab)GetDrivenPropertyBonusOnSpawn()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IReadOnlyPerkObject.GetDrivenPropertyBonusOnSpawn | ( | bool | *isWarmup*, |
|  |  | bool | *isPlayer*, |
|  |  | [DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) | *drivenProperty*, |
|  |  | float | *baseValue* ) |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#acec2b853234b5cd582017f5716a17ee3).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a91694b7f608ab970776fb49a66d318dc)GetHitpoints()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IReadOnlyPerkObject.GetHitpoints | ( | bool | *isWarmup*, |
|  |  | bool | *isPlayer* ) |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#acecad2a3bfdcc9c10ae7bee1e4801ea7).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a590d9716158e98cb6929bde5fc018b0c)Clone()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html) TaleWorlds.MountAndBlade.IReadOnlyPerkObject.Clone | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ad9cabb4a700515e4a780c35818464b3d).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a8b4b2de1c3b53b758591eae30b4e1fd4)Name
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.IReadOnlyPerkObject.Name | | get |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a87db9347a8c8d3be10a8c45b3912f8d0).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a67eb5edd1c5d423903b012577095872a)Description
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.IReadOnlyPerkObject.Description | | get |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a1d12259de789a5613bf4de1999a2634a).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a865d428c239d09bcf0115cd32ffdf71f)GameModes
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<string> TaleWorlds.MountAndBlade.IReadOnlyPerkObject.GameModes | | get |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a7b09f615429e92c269646d1cfbeb1dbe).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a7f59ba6fbdadfa56b2d4290301e9f6ba)PerkListIndex
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.IReadOnlyPerkObject.PerkListIndex | | get |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#afb257b28481b951dac42734bf1a58f8b).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a4d101cf82f7115898b723484737dcbd4)IconId
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.IReadOnlyPerkObject.IconId | | get |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a908f4e261ab19f37528b7a656afb4603).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#ad2c43774f4147a525cb6e5c9e61cab3d)HeroIdleAnimOverride
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.IReadOnlyPerkObject.HeroIdleAnimOverride | | get |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ae76e21cd6e6831d29ae7f2589a63f957).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a8b6be5f1bb222440689443f123861f63)HeroMountIdleAnimOverride
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.IReadOnlyPerkObject.HeroMountIdleAnimOverride | | get |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ab9e0e001f2e22d63f62abb9f734ee63b).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a8d187eb9de1fc3fb9b0c6e76d17c5f13)TroopIdleAnimOverride
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.IReadOnlyPerkObject.TroopIdleAnimOverride | | get |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a383ab014b4461b54af41098519e7ad54).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a23dc610b6c7681f68c9a04a5df5ed86f)TroopMountIdleAnimOverride
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.IReadOnlyPerkObject.TroopMountIdleAnimOverride | | get |

Implemented in [TaleWorlds.MountAndBlade.MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a9be4720e7d4b9836553cab1bec3a5aa5).


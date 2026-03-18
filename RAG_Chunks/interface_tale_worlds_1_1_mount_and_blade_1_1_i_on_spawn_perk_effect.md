--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_on_spawn_perk_effect.html ---

TaleWorlds.MountAndBlade.IOnSpawnPerkEffect Interface ReferenceInherited by [TaleWorlds.MountAndBlade.MPOnSpawnPerkEffectBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_on_spawn_perk_effect_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetExtraTroopCount](interface_tale_worlds_1_1_mount_and_blade_1_1_i_on_spawn_perk_effect.html#a250b094c89fc636afa5406c69cf3f978) () |
| List<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> | [GetAlternativeEquipments](interface_tale_worlds_1_1_mount_and_blade_1_1_i_on_spawn_perk_effect.html#a7b43e6b7cae88367b39be7bac82f2da4) (bool isPlayer, List<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> alternativeEquipments, bool getAll=false) |
| float | [GetDrivenPropertyBonusOnSpawn](interface_tale_worlds_1_1_mount_and_blade_1_1_i_on_spawn_perk_effect.html#ae665b5d4fddb6a21b014e7178a6772a4) (bool isPlayer, [DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) drivenProperty, float baseValue) |
| float | [GetHitpoints](interface_tale_worlds_1_1_mount_and_blade_1_1_i_on_spawn_perk_effect.html#a5c65d62e1843765854ef3b1e253acf7f) (bool isPlayer) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_on_spawn_perk_effect.html#a250b094c89fc636afa5406c69cf3f978)GetExtraTroopCount()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.IOnSpawnPerkEffect.GetExtraTroopCount | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.MPOnSpawnPerkEffectBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_on_spawn_perk_effect_base.html#ac7d79a736cc22db694fd64e5d8da70a9).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_on_spawn_perk_effect.html#a7b43e6b7cae88367b39be7bac82f2da4)GetAlternativeEquipments()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> TaleWorlds.MountAndBlade.IOnSpawnPerkEffect.GetAlternativeEquipments | ( | bool | *isPlayer*, |
|  |  | List<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> | *alternativeEquipments*, |
|  |  | bool | *getAll* = false ) |

Implemented in [TaleWorlds.MountAndBlade.MPOnSpawnPerkEffectBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_on_spawn_perk_effect_base.html#a481db21ccfcdfbe50ac48a1e98e4249a).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_on_spawn_perk_effect.html#ae665b5d4fddb6a21b014e7178a6772a4)GetDrivenPropertyBonusOnSpawn()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IOnSpawnPerkEffect.GetDrivenPropertyBonusOnSpawn | ( | bool | *isPlayer*, |
|  |  | [DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) | *drivenProperty*, |
|  |  | float | *baseValue* ) |

Implemented in [TaleWorlds.MountAndBlade.MPOnSpawnPerkEffectBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_on_spawn_perk_effect_base.html#a31f3728570eaadd38bf2925c9143ce6b).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_on_spawn_perk_effect.html#a5c65d62e1843765854ef3b1e253acf7f)GetHitpoints()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IOnSpawnPerkEffect.GetHitpoints | ( | bool | *isPlayer* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.MPOnSpawnPerkEffectBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_on_spawn_perk_effect_base.html#a8b7d550f87622aa7810656a288d5f077).


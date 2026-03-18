--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html ---

TaleWorlds.MountAndBlade.MPPerkObject.MPOnSpawnPerkHandler Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetExtraTroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#a2b6ebc0034a36c20f0ed815851b73adf) () |
| IEnumerable< ValueTuple< [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) > > | [GetAlternativeEquipments](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#ae123abd289a44d11b26512e54c3fd137) (bool isPlayer) |
| float | [GetDrivenPropertyBonusOnSpawn](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#a4d0cb0d43b1dae15cbfad9df64909ae4) (bool isPlayer, [DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) drivenProperty, float baseValue) |
| float | [GetHitpoints](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#a60c7560c415d48b6f698e1fd431020ec) (bool isPlayer) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [MPOnSpawnPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#a5ce4789d069ab83e0fa7a6c1fa0b5e35) (IEnumerable< [IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html) > perks) |
|  | [MPOnSpawnPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#a36a63695ebbe5e719692c02b8dd66aca) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsWarmup](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#a11fd9dfb04ed7742ac375b72b1e36321) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#a5ce4789d069ab83e0fa7a6c1fa0b5e35)MPOnSpawnPerkHandler() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.MPPerkObject.MPOnSpawnPerkHandler.MPOnSpawnPerkHandler | ( | IEnumerable< [IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html) > | *perks* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#a36a63695ebbe5e719692c02b8dd66aca)MPOnSpawnPerkHandler() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.MPPerkObject.MPOnSpawnPerkHandler.MPOnSpawnPerkHandler | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#a2b6ebc0034a36c20f0ed815851b73adf)GetExtraTroopCount()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPOnSpawnPerkHandler.GetExtraTroopCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#ae123abd289a44d11b26512e54c3fd137)GetAlternativeEquipments()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< ValueTuple< [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) > > TaleWorlds.MountAndBlade.MPPerkObject.MPOnSpawnPerkHandler.GetAlternativeEquipments | ( | bool | *isPlayer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#a4d0cb0d43b1dae15cbfad9df64909ae4)GetDrivenPropertyBonusOnSpawn()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPOnSpawnPerkHandler.GetDrivenPropertyBonusOnSpawn | ( | bool | *isPlayer*, |
|  |  | [DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) | *drivenProperty*, |
|  |  | float | *baseValue* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#a60c7560c415d48b6f698e1fd431020ec)GetHitpoints()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPOnSpawnPerkHandler.GetHitpoints | ( | bool | *isPlayer* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html#a11fd9dfb04ed7742ac375b72b1e36321)IsWarmup
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MPPerkObject.MPOnSpawnPerkHandler.IsWarmup | | get |


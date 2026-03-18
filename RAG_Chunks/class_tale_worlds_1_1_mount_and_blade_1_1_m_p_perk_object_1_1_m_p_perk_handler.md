--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html ---

TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnEvent](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#aa7ab1c429322afc37f9cdb62f28edae4) ([MPPerkCondition.PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) flags) |
| void | [OnEvent](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a4abc803d8fb897f2df0a775c0c389e30) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [MPPerkCondition.PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) flags) |
| void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#aaf5362f21e4f641a7b534a153baf9b5b) (int tickCount) |
| float | [GetDrivenPropertyBonus](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#abb8b2f672e49e0e97f5590d75d15dc22) ([DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) drivenProperty, float baseValue) |
| float | [GetRangedAccuracy](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#ab3793f08a6e235ca44b14239d2900c41) () |
| float | [GetThrowingWeaponSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a71e0c0240a4bffba283b08d283dd242a) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon) |
| float | [GetDamageInterruptionThreshold](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a699a621c2698fef1c6cd84bf9f507051) () |
| float | [GetMountManeuver](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a0fc3120ba2562608a28b9bb71431a33e) () |
| float | [GetMountSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a7710eb6548ee5f3f38dcefe66998671f) () |
| int | [GetGoldOnKill](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#ace1f83b87382ed3332d22c438f5798eb) (float attackerValue, float victimValue) |
| int | [GetGoldOnAssist](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#ac31e259dde31720a397079134ae34623) () |
| int | [GetRewardedGoldOnAssist](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a06726abd2070f9c836893c9d97a8a26c) () |
| bool | [GetIsTeamRewardedOnDeath](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a6470a8b5542db435eda5ad1e59652616) () |
| IEnumerable< ValueTuple< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html), int > > | [GetTeamGoldRewardsOnDeath](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#afda946061684f360d787d20a81bfcfb0) () |
| float | [GetEncumbrance](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a0cd2a236e974cf89971915773f8719bd) (bool isOnBody) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [MPPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a29a4967c94c8c82cbbf4e3682f981174) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
|  | [MPPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#ac1c796adbad3dca0006f587d8d509839) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsWarmup](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#aa03b136f54e929a32682a0783493ec89) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a29a4967c94c8c82cbbf4e3682f981174)MPPerkHandler() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.MPPerkHandler | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#ac1c796adbad3dca0006f587d8d509839)MPPerkHandler() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.MPPerkHandler | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#aa7ab1c429322afc37f9cdb62f28edae4)OnEvent() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.OnEvent | ( | [MPPerkCondition.PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) | *flags* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a4abc803d8fb897f2df0a775c0c389e30)OnEvent() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.OnEvent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [MPPerkCondition.PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) | *flags* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#aaf5362f21e4f641a7b534a153baf9b5b)OnTick()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.OnTick | ( | int | *tickCount* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#abb8b2f672e49e0e97f5590d75d15dc22)GetDrivenPropertyBonus()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.GetDrivenPropertyBonus | ( | [DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) | *drivenProperty*, |
|  |  | float | *baseValue* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#ab3793f08a6e235ca44b14239d2900c41)GetRangedAccuracy()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.GetRangedAccuracy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a71e0c0240a4bffba283b08d283dd242a)GetThrowingWeaponSpeed()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.GetThrowingWeaponSpeed | ( | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a699a621c2698fef1c6cd84bf9f507051)GetDamageInterruptionThreshold()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.GetDamageInterruptionThreshold | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a0fc3120ba2562608a28b9bb71431a33e)GetMountManeuver()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.GetMountManeuver | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a7710eb6548ee5f3f38dcefe66998671f)GetMountSpeed()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.GetMountSpeed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#ace1f83b87382ed3332d22c438f5798eb)GetGoldOnKill()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.GetGoldOnKill | ( | float | *attackerValue*, |
|  |  | float | *victimValue* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#ac31e259dde31720a397079134ae34623)GetGoldOnAssist()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.GetGoldOnAssist | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a06726abd2070f9c836893c9d97a8a26c)GetRewardedGoldOnAssist()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.GetRewardedGoldOnAssist | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a6470a8b5542db435eda5ad1e59652616)GetIsTeamRewardedOnDeath()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.GetIsTeamRewardedOnDeath | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#afda946061684f360d787d20a81bfcfb0)GetTeamGoldRewardsOnDeath()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< ValueTuple< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html), int > > TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.GetTeamGoldRewardsOnDeath | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#a0cd2a236e974cf89971915773f8719bd)GetEncumbrance()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.GetEncumbrance | ( | bool | *isOnBody* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html#aa03b136f54e929a32682a0783493ec89)IsWarmup
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MPPerkObject.MPPerkHandler.IsWarmup | | get |


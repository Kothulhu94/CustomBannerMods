--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html ---

TaleWorlds.MountAndBlade.CombatLogData Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
| List< ValueTuple< string, uint > > | [GetLogString](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a4bf0c48a46f8bce88877a5dc5fe0b773) () |
|  | [CombatLogData](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a8f6c5a838b62215e62541d0d68a30924) (bool isVictimAgentSameAsAttackerAgent, bool isAttackerAgentHuman, bool isAttackerAgentMine, bool doesAttackerAgentHaveRiderAgent, bool isAttackerAgentRiderAgentMine, bool isAttackerAgentMount, bool isVictimAgentHuman, bool isVictimAgentMine, bool isVictimAgentDead, bool doesVictimAgentHaveRiderAgent, bool isVictimAgentRiderAgentIsMine, bool isVictimAgentMount, [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) missionObjectHit, bool isVictimRiderAgentSameAsAttackerAgent, bool crushedThrough, bool chamber, float distance) |
| void | [SetVictimAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a100fc30e066511f3cd12607b8e416a4f) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly bool | [IsVictimAgentSameAsAttackerAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a099aa756b57746138f704878cd5ae08f) |
| readonly bool | [IsVictimRiderAgentSameAsAttackerAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a56ef3f1ea20d1cdfde6f922b2141d6b6) |
| readonly bool | [IsAttackerAgentHuman](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a6c16c9e92d29fb1b6ac263339c19bc50) |
| readonly bool | [IsAttackerAgentMine](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a8574efa7718c7b504fd0e89c973dc9cb) |
| readonly bool | [DoesAttackerAgentHaveRiderAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#adef8e40ce6cb91702a228cfa73ea1e60) |
| readonly bool | [IsAttackerAgentRiderAgentMine](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a4714d1a4ed906f8c1ae352d133c72835) |
| readonly bool | [IsAttackerAgentMount](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a388558ef0fa6b39e67b178a5ef7e4c44) |
| readonly bool | [IsVictimAgentHuman](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#afdd826e602b657ac266e3bb6828e574a) |
| readonly bool | [IsVictimAgentMine](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a2ed994ac0ea08fa0935acf3c2031908d) |
| readonly bool | [DoesVictimAgentHaveRiderAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a0cd4378bb337cd78476a29929782a5bb) |
| readonly bool | [IsVictimAgentRiderAgentMine](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#ab926006860404bb9a9c192e1c2f13c60) |
| readonly bool | [IsVictimAgentMount](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a242794d0b2631d69ffc1785866da4357) |
| [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | [MissionObjectHit](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#ac002f558b62699a8d3496e8073d8662d) |
| [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | [DamageType](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#ab084f202121df45b66db1b4a5da64656) |
| bool | [CrushedThrough](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a196a6b99ac7427e4ed427d3df0cfd9cc) |
| bool | [Chamber](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#aa5fca891a2f6c1dc4abd3a985202222a) |
| bool | [IsRangedAttack](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a2305506be561b9f8bf3b50b8f1ca9b8a) |
| bool | [IsFriendlyFire](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a50f0198bf2ae46add386653ea279e4fa) |
| bool | [IsFatalDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a494b1f3ef3c3173ddc6f8455861ceec0) |
| bool | [IsSpecialDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#abc069a71abdb3527a29cbfbb2e7964dd) |
| bool | [IsEntityToEntityCollisionDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a7f5b5c10bedbc1ad74beb9bab2eade16) |
| bool | [IsSneakAttack](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a54b9b11472b8b5789fb481392f7c38ac) |
| [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) | [BodyPartHit](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a6a5e0606c40049bb114b609f4a3f48aa) |
| string | [VictimAgentName](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a1564fc89d9cc18f3d4cea7bd2dc75e0e) |
| float | [HitSpeed](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a146fdfd3421a5b015366ee2a438ab1ef) |
| int | [InflictedDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#ab9aa26bfc52882b73e528924034b6630) |
| int | [AbsorbedDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a12a83eba1b9abddf9d9e0442b65fba24) |
| int | [ModifiedDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#ae9188e3570b7a44667d3ae40a3d7d6ad) |
| int | [ReflectedDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a02a3e73944809ee2cd58fea700b87236) |
| float | [Distance](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a3b8a274efc5177fadca666879edfda24) |

|  |  |
| --- | --- |
| Properties | |
| int | [TotalDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#ae77a328152eba2b261e8b581ad5f89a0) `[get]` |
| float | [AttackProgress](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a1818d486ebff6fc4e4546e878c575dd0) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a8f6c5a838b62215e62541d0d68a30924)CombatLogData()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.CombatLogData.CombatLogData | ( | bool | *isVictimAgentSameAsAttackerAgent*, |
|  |  | bool | *isAttackerAgentHuman*, |
|  |  | bool | *isAttackerAgentMine*, |
|  |  | bool | *doesAttackerAgentHaveRiderAgent*, |
|  |  | bool | *isAttackerAgentRiderAgentMine*, |
|  |  | bool | *isAttackerAgentMount*, |
|  |  | bool | *isVictimAgentHuman*, |
|  |  | bool | *isVictimAgentMine*, |
|  |  | bool | *isVictimAgentDead*, |
|  |  | bool | *doesVictimAgentHaveRiderAgent*, |
|  |  | bool | *isVictimAgentRiderAgentIsMine*, |
|  |  | bool | *isVictimAgentMount*, |
|  |  | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | *missionObjectHit*, |
|  |  | bool | *isVictimRiderAgentSameAsAttackerAgent*, |
|  |  | bool | *crushedThrough*, |
|  |  | bool | *chamber*, |
|  |  | float | *distance* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a4bf0c48a46f8bce88877a5dc5fe0b773)GetLogString()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< ValueTuple< string, uint > > TaleWorlds.MountAndBlade.CombatLogData.GetLogString | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a100fc30e066511f3cd12607b8e416a4f)SetVictimAgent()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CombatLogData.SetVictimAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent* | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a099aa756b57746138f704878cd5ae08f)IsVictimAgentSameAsAttackerAgent
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.CombatLogData.IsVictimAgentSameAsAttackerAgent |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a56ef3f1ea20d1cdfde6f922b2141d6b6)IsVictimRiderAgentSameAsAttackerAgent
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.CombatLogData.IsVictimRiderAgentSameAsAttackerAgent |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a6c16c9e92d29fb1b6ac263339c19bc50)IsAttackerAgentHuman
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.CombatLogData.IsAttackerAgentHuman |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a8574efa7718c7b504fd0e89c973dc9cb)IsAttackerAgentMine
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.CombatLogData.IsAttackerAgentMine |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#adef8e40ce6cb91702a228cfa73ea1e60)DoesAttackerAgentHaveRiderAgent
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.CombatLogData.DoesAttackerAgentHaveRiderAgent |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a4714d1a4ed906f8c1ae352d133c72835)IsAttackerAgentRiderAgentMine
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.CombatLogData.IsAttackerAgentRiderAgentMine |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a388558ef0fa6b39e67b178a5ef7e4c44)IsAttackerAgentMount
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.CombatLogData.IsAttackerAgentMount |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#afdd826e602b657ac266e3bb6828e574a)IsVictimAgentHuman
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.CombatLogData.IsVictimAgentHuman |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a2ed994ac0ea08fa0935acf3c2031908d)IsVictimAgentMine
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.CombatLogData.IsVictimAgentMine |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a0cd4378bb337cd78476a29929782a5bb)DoesVictimAgentHaveRiderAgent
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.CombatLogData.DoesVictimAgentHaveRiderAgent |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#ab926006860404bb9a9c192e1c2f13c60)IsVictimAgentRiderAgentMine
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.CombatLogData.IsVictimAgentRiderAgentMine |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a242794d0b2631d69ffc1785866da4357)IsVictimAgentMount
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.CombatLogData.IsVictimAgentMount |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#ac002f558b62699a8d3496e8073d8662d)MissionObjectHit
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) TaleWorlds.MountAndBlade.CombatLogData.MissionObjectHit |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#ab084f202121df45b66db1b4a5da64656)DamageType
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) TaleWorlds.MountAndBlade.CombatLogData.DamageType |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a196a6b99ac7427e4ed427d3df0cfd9cc)CrushedThrough
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.CombatLogData.CrushedThrough |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#aa5fca891a2f6c1dc4abd3a985202222a)Chamber
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.CombatLogData.Chamber |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a2305506be561b9f8bf3b50b8f1ca9b8a)IsRangedAttack
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.CombatLogData.IsRangedAttack |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a50f0198bf2ae46add386653ea279e4fa)IsFriendlyFire
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.CombatLogData.IsFriendlyFire |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a494b1f3ef3c3173ddc6f8455861ceec0)IsFatalDamage
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.CombatLogData.IsFatalDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#abc069a71abdb3527a29cbfbb2e7964dd)IsSpecialDamage
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.CombatLogData.IsSpecialDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a7f5b5c10bedbc1ad74beb9bab2eade16)IsEntityToEntityCollisionDamage
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.CombatLogData.IsEntityToEntityCollisionDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a54b9b11472b8b5789fb481392f7c38ac)IsSneakAttack
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.CombatLogData.IsSneakAttack |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a6a5e0606c40049bb114b609f4a3f48aa)BodyPartHit
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) TaleWorlds.MountAndBlade.CombatLogData.BodyPartHit |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a1564fc89d9cc18f3d4cea7bd2dc75e0e)VictimAgentName
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.CombatLogData.VictimAgentName |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a146fdfd3421a5b015366ee2a438ab1ef)HitSpeed
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.CombatLogData.HitSpeed |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#ab9aa26bfc52882b73e528924034b6630)InflictedDamage
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.CombatLogData.InflictedDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a12a83eba1b9abddf9d9e0442b65fba24)AbsorbedDamage
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.CombatLogData.AbsorbedDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#ae9188e3570b7a44667d3ae40a3d7d6ad)ModifiedDamage
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.CombatLogData.ModifiedDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a02a3e73944809ee2cd58fea700b87236)ReflectedDamage
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.CombatLogData.ReflectedDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a3b8a274efc5177fadca666879edfda24)Distance
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.CombatLogData.Distance |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#ae77a328152eba2b261e8b581ad5f89a0)TotalDamage
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.CombatLogData.TotalDamage | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_combat_log_data.html#a1818d486ebff6fc4e4546e878c575dd0)AttackProgress
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.CombatLogData.AttackProgress | | get |


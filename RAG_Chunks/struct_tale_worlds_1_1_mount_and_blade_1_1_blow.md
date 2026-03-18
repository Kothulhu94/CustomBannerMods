--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html ---

TaleWorlds.MountAndBlade.Blow Struct ReferenceNever ever use default constructor of this structure, because ownerid needs to be initialized.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#af43848b2bc0ab9696e336cbb2d586d3d) (int ownerId) |
|  | Never ever use default constructor of this structure, because ownerid needs to be initialized. |
| bool | [IsBlowCrit](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#aaf517cd8f0c0f42d7f5c9064177a2e47) (int maxHitPointsOfVictim) |
| bool | [IsBlowLow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a39b0e8de23ee715f157b7ea8f9ee25a5) (int maxHitPointsOfVictim) |
| bool | [IsHeadShot](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a9e512673ce8b3bfb4461d88eb8e17d83) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [BlowWeaponRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html) | [WeaponRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a6fd98fb8e4df1de553d4be5cbccbba7a) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GlobalPosition](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#afee95988e250e36280b67a80ee2db1d5) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Direction](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#abfd976e093ba5118d14988058a3aa34c) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [SwingDirection](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a56b00877e2d9f0931a805fc0e2e573ab) |
| int | [InflictedDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a5f8b38fc02dd8c5c9cae1ce20a1fc2c2) |
| int | [SelfInflictedDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a569ea090852879e2aa8cc48b881fcb98) |
| float | [BaseMagnitude](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#adea2be6aeea8ae5ca1843f2707bcae9f) |
| float | [DefenderStunPeriod](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a6ede250144257766e578f9437ec407c4) |
| float | [AttackerStunPeriod](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a4a80e6b218e1f774905dcb175dfba0d9) |
| float | [AbsorbedByArmor](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a259dad3d1b515c7f193073e44951d2e1) |
| float | [MovementSpeedDamageModifier](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a53e575146fc6badc542e9a537059b47e) |
| [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) | [StrikeType](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a9ea6b82d0b3459ba074a9b7a7ba55a72) |
| [AgentAttackType](namespace_tale_worlds_1_1_core.html#a38b124473f5d2f7d9190f338db49e8bd) | [AttackType](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a3a4b3c4684d061b8400838a1990912d1) |
| [BlowFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a388a34aef20d7434868d4d5fa46e6098) | [BlowFlag](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#ac6c6d5b8097bb10f92d4bb45cb6e0c9c) |
| int | [OwnerId](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a738d3e47ec8ece93760018c6e402a5e8) |
| sbyte | [BoneIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#ada887b93da404fcef598c6233736cfba) |
| [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) | [VictimBodyPart](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a529f50afabe2a4a2173eada9581ad0bc) |
| [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | [DamageType](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#afa3a322c9e003e39ce97f7174ac62a79) |
| bool | [NoIgnore](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a5cb0c600e694906aceb7c8632ca20994) |
| bool | [DamageCalculated](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#abba083e7c9c748d08d7ce17846fad51f) |
| bool | [IsFallDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#abb7839a5672200129468042b8b924e86) |
| float | [DamagedPercentage](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a2a2100181e3e5f19f4ae3bd260e8bf96) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsMissile](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#ac7a3ddfe6bb99cbee3e83942031c464d) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#af43848b2bc0ab9696e336cbb2d586d3d)Blow()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Blow.Blow | ( | int | *ownerId* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | ownerId |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#aaf517cd8f0c0f42d7f5c9064177a2e47)IsBlowCrit()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Blow.IsBlowCrit | ( | int | *maxHitPointsOfVictim* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a39b0e8de23ee715f157b7ea8f9ee25a5)IsBlowLow()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Blow.IsBlowLow | ( | int | *maxHitPointsOfVictim* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a9e512673ce8b3bfb4461d88eb8e17d83)IsHeadShot()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Blow.IsHeadShot | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a6fd98fb8e4df1de553d4be5cbccbba7a)WeaponRecord
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BlowWeaponRecord](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html) TaleWorlds.MountAndBlade.Blow.WeaponRecord |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#afee95988e250e36280b67a80ee2db1d5)GlobalPosition
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Blow.GlobalPosition |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#abfd976e093ba5118d14988058a3aa34c)Direction
----------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Blow.Direction |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a56b00877e2d9f0931a805fc0e2e573ab)SwingDirection
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Blow.SwingDirection |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a5f8b38fc02dd8c5c9cae1ce20a1fc2c2)InflictedDamage
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Blow.InflictedDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a569ea090852879e2aa8cc48b881fcb98)SelfInflictedDamage
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Blow.SelfInflictedDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#adea2be6aeea8ae5ca1843f2707bcae9f)BaseMagnitude
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Blow.BaseMagnitude |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a6ede250144257766e578f9437ec407c4)DefenderStunPeriod
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Blow.DefenderStunPeriod |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a4a80e6b218e1f774905dcb175dfba0d9)AttackerStunPeriod
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Blow.AttackerStunPeriod |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a259dad3d1b515c7f193073e44951d2e1)AbsorbedByArmor
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Blow.AbsorbedByArmor |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a53e575146fc6badc542e9a537059b47e)MovementSpeedDamageModifier
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Blow.MovementSpeedDamageModifier |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a9ea6b82d0b3459ba074a9b7a7ba55a72)StrikeType
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835) TaleWorlds.MountAndBlade.Blow.StrikeType |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a3a4b3c4684d061b8400838a1990912d1)AttackType
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| [AgentAttackType](namespace_tale_worlds_1_1_core.html#a38b124473f5d2f7d9190f338db49e8bd) TaleWorlds.MountAndBlade.Blow.AttackType |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#ac6c6d5b8097bb10f92d4bb45cb6e0c9c)BlowFlag
---------------------------------------------------------------------------------------------------

|  |
| --- |
| [BlowFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a388a34aef20d7434868d4d5fa46e6098) TaleWorlds.MountAndBlade.Blow.BlowFlag |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a738d3e47ec8ece93760018c6e402a5e8)OwnerId
--------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.Blow.OwnerId |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#ada887b93da404fcef598c6233736cfba)BoneIndex
----------------------------------------------------------------------------------------------------

|  |
| --- |
| sbyte TaleWorlds.MountAndBlade.Blow.BoneIndex |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a529f50afabe2a4a2173eada9581ad0bc)VictimBodyPart
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) TaleWorlds.MountAndBlade.Blow.VictimBodyPart |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#afa3a322c9e003e39ce97f7174ac62a79)DamageType
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) TaleWorlds.MountAndBlade.Blow.DamageType |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a5cb0c600e694906aceb7c8632ca20994)NoIgnore
---------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Blow.NoIgnore |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#abba083e7c9c748d08d7ce17846fad51f)DamageCalculated
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Blow.DamageCalculated |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#abb7839a5672200129468042b8b924e86)IsFallDamage
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.Blow.IsFallDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#a2a2100181e3e5f19f4ae3bd260e8bf96)DamagedPercentage
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.Blow.DamagedPercentage |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html#ac7a3ddfe6bb99cbee3e83942031c464d)IsMissile
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Blow.IsMissile | | get |


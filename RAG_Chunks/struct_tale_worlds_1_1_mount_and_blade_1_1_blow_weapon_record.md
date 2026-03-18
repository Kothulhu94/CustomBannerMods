--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html ---

TaleWorlds.MountAndBlade.BlowWeaponRecord Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [FillAsMeleeBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a21b3a2241862b1f4f797106be7fbc00a) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weaponComponentData, int affectorWeaponSlot, sbyte weaponAttachBoneIndex) |
| void | [FillAsMissileBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a442c3a04c315706bb86dcc08ff31f89a) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weaponComponentData, int missileIndex, sbyte weaponAttachBoneIndex, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) startingPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) currentPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) velocity) |
| bool | [HasWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a1312fdc90054942e36a0e5229f039300) () |
| int | [GetHitSound](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a15db64b963f16a8c23c4fd9ac1e8c5a2) (bool isOwnerHumanoid, bool isCriticalBlow, bool isLowBlow, bool isNonTipThrust, [AgentAttackType](namespace_tale_worlds_1_1_core.html#a38b124473f5d2f7d9190f338db49e8bd) attackType, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [StartingPosition](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a76aeb02e710719ec46e967eadf931dd2) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CurrentPosition](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a224b059d06afc4b0d97688cfc1d6879c) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Velocity](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a4ed2c885f698751548329ce152e3a651) |
| [ItemFlags](namespace_tale_worlds_1_1_core.html#a15c85da8a745978ee9af9c5677c007c1) | [ItemFlags](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#ac4b8dfbb3351b3c013c46e2949d139e6) |
| [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | [WeaponFlags](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a83165d151966d539a2c89e06234bcdd6) |
| [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | [WeaponClass](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a607a4aa261cdad3f1a468cad95d84078) |
| sbyte | [BoneNoToAttach](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#abb881dfe04f352c47000f6e7506dccb6) |
| int | [AffectorWeaponSlotOrMissileIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a42b85d2e7bb807a413d319020a481c8c) |
| float | [Weight](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a51d8babde89c18aa98ca4d2f95a73793) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsMissile](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#af04c611771fa294893a9b9523c126cd0) `[get]` |
| bool | [IsShield](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#aaa69f6528e464823d2ed4d50876611d0) `[get]` |
| bool | [IsRanged](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#ae23e1cadb8c88dd3ba4571f15c23b0ab) `[get]` |
| bool | [IsAmmo](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a112d525e9b38de6ae7910775afc951f3) `[get]` |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a21b3a2241862b1f4f797106be7fbc00a)FillAsMeleeBlow()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.BlowWeaponRecord.FillAsMeleeBlow | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weaponComponentData*, |
|  |  | int | *affectorWeaponSlot*, |
|  |  | sbyte | *weaponAttachBoneIndex* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a442c3a04c315706bb86dcc08ff31f89a)FillAsMissileBlow()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.BlowWeaponRecord.FillAsMissileBlow | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weaponComponentData*, |
|  |  | int | *missileIndex*, |
|  |  | sbyte | *weaponAttachBoneIndex*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *startingPosition*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *currentPosition*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *velocity* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a1312fdc90054942e36a0e5229f039300)HasWeapon()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.BlowWeaponRecord.HasWeapon | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a15db64b963f16a8c23c4fd9ac1e8c5a2)GetHitSound()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.BlowWeaponRecord.GetHitSound | ( | bool | *isOwnerHumanoid*, |
|  |  | bool | *isCriticalBlow*, |
|  |  | bool | *isLowBlow*, |
|  |  | bool | *isNonTipThrust*, |
|  |  | [AgentAttackType](namespace_tale_worlds_1_1_core.html#a38b124473f5d2f7d9190f338db49e8bd) | *attackType*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *damageType* ) |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a76aeb02e710719ec46e967eadf931dd2)StartingPosition
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.BlowWeaponRecord.StartingPosition |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a224b059d06afc4b0d97688cfc1d6879c)CurrentPosition
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.BlowWeaponRecord.CurrentPosition |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a4ed2c885f698751548329ce152e3a651)Velocity
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.BlowWeaponRecord.Velocity |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#ac4b8dfbb3351b3c013c46e2949d139e6)ItemFlags
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ItemFlags](namespace_tale_worlds_1_1_core.html#a15c85da8a745978ee9af9c5677c007c1) TaleWorlds.MountAndBlade.BlowWeaponRecord.ItemFlags |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a83165d151966d539a2c89e06234bcdd6)WeaponFlags
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) TaleWorlds.MountAndBlade.BlowWeaponRecord.WeaponFlags |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a607a4aa261cdad3f1a468cad95d84078)WeaponClass
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) TaleWorlds.MountAndBlade.BlowWeaponRecord.WeaponClass |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#abb881dfe04f352c47000f6e7506dccb6)BoneNoToAttach
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| sbyte TaleWorlds.MountAndBlade.BlowWeaponRecord.BoneNoToAttach |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a42b85d2e7bb807a413d319020a481c8c)AffectorWeaponSlotOrMissileIndex
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.BlowWeaponRecord.AffectorWeaponSlotOrMissileIndex |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a51d8babde89c18aa98ca4d2f95a73793)Weight
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.BlowWeaponRecord.Weight |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#af04c611771fa294893a9b9523c126cd0)IsMissile
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.BlowWeaponRecord.IsMissile | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#aaa69f6528e464823d2ed4d50876611d0)IsShield
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.BlowWeaponRecord.IsShield | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#ae23e1cadb8c88dd3ba4571f15c23b0ab)IsRanged
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.BlowWeaponRecord.IsRanged | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_blow_weapon_record.html#a112d525e9b38de6ae7910775afc951f3)IsAmmo
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.BlowWeaponRecord.IsAmmo | | get |


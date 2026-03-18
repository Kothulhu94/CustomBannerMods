--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html ---

TaleWorlds.MountAndBlade.AttackCollisionData Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetCollisionBoneIndexForAreaDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a82fa834474dc14a4aadeb3aebf911d1a) (sbyte boneIndex) |
| void | [UpdateCollisionPositionAndBoneForReflect](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ac8400b122daa7bf764e2cbec77b33036) (int inflictedDamage, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, sbyte boneIndex) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static AttackCollisionData | [GetAttackCollisionDataForDebugPurpose](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aed97e7c8adf1d85b9ee1ba27e6034728) (bool \_attackBlockedWithShield, bool \_correctSideShieldBlock, bool \_isAlternativeAttack, bool \_isColliderAgent, bool \_collidedWithShieldOnBack, bool \_isMissile, bool \_isMissileBlockedWithWeapon, bool \_missileHasPhysics, bool \_entityExists, bool \_thrustTipHit, bool \_missileGoneUnderWater, bool \_missileGoneOutOfBorder, [CombatCollisionResult](namespace_tale_worlds_1_1_mount_and_blade.html#a69ccd75a0d558392b56af494b23edcfc) collisionResult, int affectorWeaponSlotOrMissileIndex, int [StrikeType](namespace_tale_worlds_1_1_core.html#a2adc9126cb9a9e45bc133ebc57833835), int [DamageType](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#afb5159f443472ed749b471a32d629ad6), sbyte [CollisionBoneIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a24d1fa3724580c94677c4d9575ffba95), [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) [VictimHitBodyPart](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ad5726a43a0bbb040561761ead0056d96), sbyte [AttackBoneIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ad8f9156c61e354df161818014719b76e), [Agent.UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) [AttackDirection](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a735b1ab0d60940ad4b241866606c9e11), int [PhysicsMaterialIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a2df4fa403e2d58c93ca3d1a474ec402a), [CombatHitResultFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a0c1829a4b129e6419bb66155399773f7) [CollisionHitResultFlags](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a3d57184065a3285196fbf6e8476da431), float [AttackProgress](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a6b4ad63766b12e4c15c067f946016d19), float [CollisionDistanceOnWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aa95c525be8e8103474c24d8937dc78e4), float [AttackerStunPeriod](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a74e06de828b097dad1b04497df9044ea), float [DefenderStunPeriod](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#af22c16ade008b8e6ee3508e59d2fa07a), float [MissileTotalDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aad593aa14a8b287fe57497949cd7467c), float MissileInitialSpeed, float [ChargeVelocity](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a10533b2f5e6aba5a92f89260f217da68), float [FallSpeed](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ab81c1dddc4bc14db4edfe96a12d1750e), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) [WeaponRotUp](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a876b71e79534137282c9989916f77ce4), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) \_weaponBlowDir, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) [CollisionGlobalPosition](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aa7a52fa7f617dbe25c627acf9f4a62a5), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) [MissileVelocity](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a7d2d7106672621be9a5fc1a6462e240f), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) [MissileStartingPosition](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a6a75bf2e5074003fd4872a337dd4a41c), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) [VictimAgentCurVelocity](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a7fa9c9b378426151b1c3497afdc7c2fb), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) GroundNormal) |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [BaseMagnitude](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a6aad2f78087fcd1a6961f0927300fd12) |
| float | [MovementSpeedDamageModifier](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a2661d62e3b57c0100ea003d04e305ce8) |
| int | [AbsorbedByArmor](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a0a8958d3aa76b3c8965b08eadc6839ed) |
| int | [InflictedDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a0529338199a3f546b3c748f7228c5dd9) |
| int | [SelfInflictedDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a4910fd35a209a1941f7bc9e7c561bce6) |
| bool | [IsShieldBroken](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#adbe8320eff845a163c4ff7380244d07e) |
| bool | [IsSneakAttack](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ab5af97968b24f654e5b4272f21851306) |

|  |  |
| --- | --- |
| Properties | |
| bool | [AttackBlockedWithShield](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a53ec04130e4a697f42a1779536be6d8c) `[get]` |
| bool | [CorrectSideShieldBlock](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#abfc62fa8a68fd5f57ab9ab01797de9cd) `[get]` |
| bool | [IsAlternativeAttack](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ab027af98ec7a515b3bfc421fe0872821) `[get]` |
| bool | [IsColliderAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a6d468259d2a66a8797b8db5b7551b7e2) `[get]` |
| bool | [CollidedWithShieldOnBack](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a9c52c7ba5b9c02325734c4859d6c39aa) `[get]` |
| bool | [IsMissile](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a4fd6617e56f2570969ba719e0bacdcf9) `[get]` |
| bool | [MissileBlockedWithWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a1e3e18c4cac0b315c88ae514190c0e36) `[get]` |
| bool | [MissileHasPhysics](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a3753aeb522a42e612db936bd528b5574) `[get]` |
| bool | [EntityExists](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a2cc579d17b575e43bcf89ced4169349d) `[get]` |
| bool | [ThrustTipHit](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a9e358462cb7bf842584f736d7d3375a9) `[get]` |
| bool | [MissileGoneUnderWater](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a0058213f7e6577ce4b8f9ac5e89b844d) `[get]` |
| bool | [MissileGoneOutOfBorder](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#acc27abefd66fa699eb493044d97d2989) `[get]` |
| bool | [CollidedWithLastBoneSegment](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a98a62c8fd5a11ff4da954bd6a7ea8712) `[get]` |
| bool | [IsHorseCharge](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a1d7638e4049abd43f0d1b50d79786193) `[get]` |
| bool | [IsFallDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ae778388986a7b88fcdce74eb5864aa35) `[get]` |
| [CombatCollisionResult](namespace_tale_worlds_1_1_mount_and_blade.html#a69ccd75a0d558392b56af494b23edcfc) | [CollisionResult](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a2f32dca567190e35969aa9e8843ba54d) `[get]` |
| int | [AffectorWeaponSlotOrMissileIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a0e76cc5204eed37c166289faa58c1c85) `[get]` |
| int | [StrikeType](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aa367057903dfa94e1551951ad678cc49) `[get]` |
| int | [DamageType](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#afb5159f443472ed749b471a32d629ad6) `[get]` |
| sbyte | [CollisionBoneIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a24d1fa3724580c94677c4d9575ffba95) `[get]` |
| [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) | [VictimHitBodyPart](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ad5726a43a0bbb040561761ead0056d96) `[get]` |
| sbyte | [AttackBoneIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ad8f9156c61e354df161818014719b76e) `[get]` |
| [Agent.UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | [AttackDirection](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a735b1ab0d60940ad4b241866606c9e11) `[get]` |
| int | [PhysicsMaterialIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a2df4fa403e2d58c93ca3d1a474ec402a) `[get]` |
| [CombatHitResultFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a0c1829a4b129e6419bb66155399773f7) | [CollisionHitResultFlags](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a3d57184065a3285196fbf6e8476da431) `[get]` |
| float | [AttackProgress](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a6b4ad63766b12e4c15c067f946016d19) `[get]` |
| float | [CollisionDistanceOnWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aa95c525be8e8103474c24d8937dc78e4) `[get]` |
| float | [AttackerStunPeriod](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a74e06de828b097dad1b04497df9044ea) `[get, set]` |
| float | [DefenderStunPeriod](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#af22c16ade008b8e6ee3508e59d2fa07a) `[get, set]` |
| float | [MissileTotalDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aad593aa14a8b287fe57497949cd7467c) `[get]` |
| float | [MissileStartingBaseSpeed](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aa29d373d5be7d30d972df075231f9258) `[get]` |
| float | [ChargeVelocity](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a10533b2f5e6aba5a92f89260f217da68) `[get]` |
| float | [FallSpeed](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ab81c1dddc4bc14db4edfe96a12d1750e) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [WeaponRotUp](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a876b71e79534137282c9989916f77ce4) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [WeaponBlowDir](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ab55811a491e8ee653ba48cc7132b3620) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CollisionGlobalPosition](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aa7a52fa7f617dbe25c627acf9f4a62a5) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [MissileVelocity](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a7d2d7106672621be9a5fc1a6462e240f) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [MissileStartingPosition](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a6a75bf2e5074003fd4872a337dd4a41c) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [VictimAgentCurVelocity](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a7fa9c9b378426151b1c3497afdc7c2fb) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CollisionGlobalNormal](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a3a68b489ded01099c9fce3b4978e3027) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [LastBoneSegmentRotUp](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ad734e56c98b0ffdf88c604d2f7d55855) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [LastBoneSegmentSwingDir](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a2e6af2c06ffffce6d4fd9762c6c0dff4) `[get]` |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a82fa834474dc14a4aadeb3aebf911d1a)SetCollisionBoneIndexForAreaDamage()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AttackCollisionData.SetCollisionBoneIndexForAreaDamage | ( | sbyte | *boneIndex* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ac8400b122daa7bf764e2cbec77b33036)UpdateCollisionPositionAndBoneForReflect()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AttackCollisionData.UpdateCollisionPositionAndBoneForReflect | ( | int | *inflictedDamage*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | sbyte | *boneIndex* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aed97e7c8adf1d85b9ee1ba27e6034728)GetAttackCollisionDataForDebugPurpose()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | AttackCollisionData TaleWorlds.MountAndBlade.AttackCollisionData.GetAttackCollisionDataForDebugPurpose | ( | bool | *\_attackBlockedWithShield*, | |  |  | bool | *\_correctSideShieldBlock*, | |  |  | bool | *\_isAlternativeAttack*, | |  |  | bool | *\_isColliderAgent*, | |  |  | bool | *\_collidedWithShieldOnBack*, | |  |  | bool | *\_isMissile*, | |  |  | bool | *\_isMissileBlockedWithWeapon*, | |  |  | bool | *\_missileHasPhysics*, | |  |  | bool | *\_entityExists*, | |  |  | bool | *\_thrustTipHit*, | |  |  | bool | *\_missileGoneUnderWater*, | |  |  | bool | *\_missileGoneOutOfBorder*, | |  |  | [CombatCollisionResult](namespace_tale_worlds_1_1_mount_and_blade.html#a69ccd75a0d558392b56af494b23edcfc) | *collisionResult*, | |  |  | int | *affectorWeaponSlotOrMissileIndex*, | |  |  | int | *StrikeType*, | |  |  | int | *DamageType*, | |  |  | sbyte | *CollisionBoneIndex*, | |  |  | [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) | *VictimHitBodyPart*, | |  |  | sbyte | *AttackBoneIndex*, | |  |  | [Agent.UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | *AttackDirection*, | |  |  | int | *PhysicsMaterialIndex*, | |  |  | [CombatHitResultFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a0c1829a4b129e6419bb66155399773f7) | *CollisionHitResultFlags*, | |  |  | float | *AttackProgress*, | |  |  | float | *CollisionDistanceOnWeapon*, | |  |  | float | *AttackerStunPeriod*, | |  |  | float | *DefenderStunPeriod*, | |  |  | float | *MissileTotalDamage*, | |  |  | float | *MissileInitialSpeed*, | |  |  | float | *ChargeVelocity*, | |  |  | float | *FallSpeed*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *WeaponRotUp*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *\_weaponBlowDir*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *CollisionGlobalPosition*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *MissileVelocity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *MissileStartingPosition*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *VictimAgentCurVelocity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *GroundNormal* ) | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a6aad2f78087fcd1a6961f0927300fd12)BaseMagnitude
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackCollisionData.BaseMagnitude |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a2661d62e3b57c0100ea003d04e305ce8)MovementSpeedDamageModifier
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackCollisionData.MovementSpeedDamageModifier |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a0a8958d3aa76b3c8965b08eadc6839ed)AbsorbedByArmor
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.AttackCollisionData.AbsorbedByArmor |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a0529338199a3f546b3c748f7228c5dd9)InflictedDamage
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.AttackCollisionData.InflictedDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a4910fd35a209a1941f7bc9e7c561bce6)SelfInflictedDamage
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.AttackCollisionData.SelfInflictedDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#adbe8320eff845a163c4ff7380244d07e)IsShieldBroken
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackCollisionData.IsShieldBroken |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ab5af97968b24f654e5b4272f21851306)IsSneakAttack
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackCollisionData.IsSneakAttack |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a53ec04130e4a697f42a1779536be6d8c)AttackBlockedWithShield
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.AttackBlockedWithShield | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#abfc62fa8a68fd5f57ab9ab01797de9cd)CorrectSideShieldBlock
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.CorrectSideShieldBlock | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ab027af98ec7a515b3bfc421fe0872821)IsAlternativeAttack
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.IsAlternativeAttack | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a6d468259d2a66a8797b8db5b7551b7e2)IsColliderAgent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.IsColliderAgent | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a9c52c7ba5b9c02325734c4859d6c39aa)CollidedWithShieldOnBack
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.CollidedWithShieldOnBack | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a4fd6617e56f2570969ba719e0bacdcf9)IsMissile
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.IsMissile | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a1e3e18c4cac0b315c88ae514190c0e36)MissileBlockedWithWeapon
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.MissileBlockedWithWeapon | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a3753aeb522a42e612db936bd528b5574)MissileHasPhysics
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.MissileHasPhysics | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a2cc579d17b575e43bcf89ced4169349d)EntityExists
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.EntityExists | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a9e358462cb7bf842584f736d7d3375a9)ThrustTipHit
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.ThrustTipHit | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a0058213f7e6577ce4b8f9ac5e89b844d)MissileGoneUnderWater
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.MissileGoneUnderWater | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#acc27abefd66fa699eb493044d97d2989)MissileGoneOutOfBorder
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.MissileGoneOutOfBorder | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a98a62c8fd5a11ff4da954bd6a7ea8712)CollidedWithLastBoneSegment
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.CollidedWithLastBoneSegment | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a1d7638e4049abd43f0d1b50d79786193)IsHorseCharge
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.IsHorseCharge | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ae778388986a7b88fcdce74eb5864aa35)IsFallDamage
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.AttackCollisionData.IsFallDamage | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a2f32dca567190e35969aa9e8843ba54d)CollisionResult
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CombatCollisionResult](namespace_tale_worlds_1_1_mount_and_blade.html#a69ccd75a0d558392b56af494b23edcfc) TaleWorlds.MountAndBlade.AttackCollisionData.CollisionResult | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a0e76cc5204eed37c166289faa58c1c85)AffectorWeaponSlotOrMissileIndex
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.AttackCollisionData.AffectorWeaponSlotOrMissileIndex | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aa367057903dfa94e1551951ad678cc49)StrikeType
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.AttackCollisionData.StrikeType | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#afb5159f443472ed749b471a32d629ad6)DamageType
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.AttackCollisionData.DamageType | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a24d1fa3724580c94677c4d9575ffba95)CollisionBoneIndex
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.MountAndBlade.AttackCollisionData.CollisionBoneIndex | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ad5726a43a0bbb040561761ead0056d96)VictimHitBodyPart
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) TaleWorlds.MountAndBlade.AttackCollisionData.VictimHitBodyPart | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ad8f9156c61e354df161818014719b76e)AttackBoneIndex
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.MountAndBlade.AttackCollisionData.AttackBoneIndex | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a735b1ab0d60940ad4b241866606c9e11)AttackDirection
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent.UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) TaleWorlds.MountAndBlade.AttackCollisionData.AttackDirection | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a2df4fa403e2d58c93ca3d1a474ec402a)PhysicsMaterialIndex
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.AttackCollisionData.PhysicsMaterialIndex | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a3d57184065a3285196fbf6e8476da431)CollisionHitResultFlags
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CombatHitResultFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a0c1829a4b129e6419bb66155399773f7) TaleWorlds.MountAndBlade.AttackCollisionData.CollisionHitResultFlags | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a6b4ad63766b12e4c15c067f946016d19)AttackProgress
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.AttackCollisionData.AttackProgress | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aa95c525be8e8103474c24d8937dc78e4)CollisionDistanceOnWeapon
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.AttackCollisionData.CollisionDistanceOnWeapon | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a74e06de828b097dad1b04497df9044ea)AttackerStunPeriod
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.AttackCollisionData.AttackerStunPeriod | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#af22c16ade008b8e6ee3508e59d2fa07a)DefenderStunPeriod
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.AttackCollisionData.DefenderStunPeriod | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aad593aa14a8b287fe57497949cd7467c)MissileTotalDamage
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.AttackCollisionData.MissileTotalDamage | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aa29d373d5be7d30d972df075231f9258)MissileStartingBaseSpeed
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.AttackCollisionData.MissileStartingBaseSpeed | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a10533b2f5e6aba5a92f89260f217da68)ChargeVelocity
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.AttackCollisionData.ChargeVelocity | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ab81c1dddc4bc14db4edfe96a12d1750e)FallSpeed
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.AttackCollisionData.FallSpeed | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a876b71e79534137282c9989916f77ce4)WeaponRotUp
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackCollisionData.WeaponRotUp | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ab55811a491e8ee653ba48cc7132b3620)WeaponBlowDir
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackCollisionData.WeaponBlowDir | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#aa7a52fa7f617dbe25c627acf9f4a62a5)CollisionGlobalPosition
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackCollisionData.CollisionGlobalPosition | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a7d2d7106672621be9a5fc1a6462e240f)MissileVelocity
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackCollisionData.MissileVelocity | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a6a75bf2e5074003fd4872a337dd4a41c)MissileStartingPosition
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackCollisionData.MissileStartingPosition | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a7fa9c9b378426151b1c3497afdc7c2fb)VictimAgentCurVelocity
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackCollisionData.VictimAgentCurVelocity | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a3a68b489ded01099c9fce3b4978e3027)CollisionGlobalNormal
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackCollisionData.CollisionGlobalNormal | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#ad734e56c98b0ffdf88c604d2f7d55855)LastBoneSegmentRotUp
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackCollisionData.LastBoneSegmentRotUp | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html#a2e6af2c06ffffce6d4fd9762c6c0dff4)LastBoneSegmentSwingDir
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackCollisionData.LastBoneSegmentSwingDir | | get |


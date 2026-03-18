--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_default_damage_particle_model.html ---

TaleWorlds.MountAndBlade.DefaultDamageParticleModel Class ReferenceInherits [TaleWorlds.MountAndBlade.DamageParticleModel](class_tale_worlds_1_1_mount_and_blade_1_1_damage_particle_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DefaultDamageParticleModel](class_tale_worlds_1_1_mount_and_blade_1_1_default_damage_particle_model.html#a2cb39fb6bd50b0f2effbb3631577b0f6) () |
| override void | [GetMeleeAttackBloodParticles](class_tale_worlds_1_1_mount_and_blade_1_1_default_damage_particle_model.html#af022bcf4cdbbc442472ef1ced5cd4ccb) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, out [HitParticleResultData](struct_tale_worlds_1_1_mount_and_blade_1_1_hit_particle_result_data.html) particleResultData) |
| override void | [GetMeleeAttackSweatParticles](class_tale_worlds_1_1_mount_and_blade_1_1_default_damage_particle_model.html#a2a3aee3a2206af265b60d9da5a2aa681) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, out [HitParticleResultData](struct_tale_worlds_1_1_mount_and_blade_1_1_hit_particle_result_data.html) particleResultData) |
| override int | [GetMissileAttackParticle](class_tale_worlds_1_1_mount_and_blade_1_1_default_damage_particle_model.html#aff5a0d6bce89b97cb7c0fc716a453152) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.DamageParticleModel](class_tale_worlds_1_1_mount_and_blade_1_1_damage_particle_model.html) | |
| void | [GetMeleeAttackBloodParticles](class_tale_worlds_1_1_mount_and_blade_1_1_damage_particle_model.html#a923bc24a1c7f9ff75239adee2a2142e4) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, out [HitParticleResultData](struct_tale_worlds_1_1_mount_and_blade_1_1_hit_particle_result_data.html) particleResultData) |
|  | Called for Weapons without "WeaponFlags.NoBlood" flag. |
| void | [GetMeleeAttackSweatParticles](class_tale_worlds_1_1_mount_and_blade_1_1_damage_particle_model.html#a7da12f425eb1628076bb614947fb6485) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, out [HitParticleResultData](struct_tale_worlds_1_1_mount_and_blade_1_1_hit_particle_result_data.html) particleResultData) |
|  | Called for fist, kick and bash or Weapons with "WeaponFlags.NoBlood" flag. |
| int | [GetMissileAttackParticle](class_tale_worlds_1_1_mount_and_blade_1_1_damage_particle_model.html#a017308696ebb3c9db6a67b739cea2d36) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victim, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_damage_particle_model.html#a2cb39fb6bd50b0f2effbb3631577b0f6)DefaultDamageParticleModel()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.DefaultDamageParticleModel.DefaultDamageParticleModel | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_damage_particle_model.html#af022bcf4cdbbc442472ef1ced5cd4ccb)GetMeleeAttackBloodParticles()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.DefaultDamageParticleModel.GetMeleeAttackBloodParticles | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victim*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | out [HitParticleResultData](struct_tale_worlds_1_1_mount_and_blade_1_1_hit_particle_result_data.html) | *particleResultData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_damage_particle_model.html#a2a3aee3a2206af265b60d9da5a2aa681)GetMeleeAttackSweatParticles()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.DefaultDamageParticleModel.GetMeleeAttackSweatParticles | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victim*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | out [HitParticleResultData](struct_tale_worlds_1_1_mount_and_blade_1_1_hit_particle_result_data.html) | *particleResultData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_damage_particle_model.html#aff5a0d6bce89b97cb7c0fc716a453152)GetMissileAttackParticle()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.MountAndBlade.DefaultDamageParticleModel.GetMissileAttackParticle | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victim*, |
|  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |


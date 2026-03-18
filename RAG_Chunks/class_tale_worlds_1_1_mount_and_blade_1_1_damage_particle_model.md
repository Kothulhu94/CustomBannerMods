--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_damage_particle_model.html ---

TaleWorlds.MountAndBlade.DamageParticleModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.MountAndBlade.DefaultDamageParticleModel](class_tale_worlds_1_1_mount_and_blade_1_1_default_damage_particle_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_damage_particle_model.html#a923bc24a1c7f9ff75239adee2a2142e4)GetMeleeAttackBloodParticles()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.DamageParticleModel.GetMeleeAttackBloodParticles | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victim*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | out [HitParticleResultData](struct_tale_worlds_1_1_mount_and_blade_1_1_hit_particle_result_data.html) | *particleResultData* ) | | abstract |

Parameters
:   |  |  |
    | --- | --- |
    | particleResultData | Need to be filled with three particle systems. Start, Continue and End. |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_damage_particle_model.html#a7da12f425eb1628076bb614947fb6485)GetMeleeAttackSweatParticles()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.DamageParticleModel.GetMeleeAttackSweatParticles | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victim*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, | |  |  | out [HitParticleResultData](struct_tale_worlds_1_1_mount_and_blade_1_1_hit_particle_result_data.html) | *particleResultData* ) | | abstract |

Parameters
:   |  |  |
    | --- | --- |
    | particleResultData | Need to be filled with three particle systems. Start, Continue and End. |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_damage_particle_model.html#a017308696ebb3c9db6a67b739cea2d36)GetMissileAttackParticle()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.DamageParticleModel.GetMissileAttackParticle | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victim*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) | | abstract |


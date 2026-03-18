--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html ---

TaleWorlds.MountAndBlade.Mission.Missile Class ReferenceInherits [TaleWorlds.MountAndBlade.MBMissile](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_missile.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Missile](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#ad353ffb4b702e1c8585c7fe55fcbfa42) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adfc400efb4da1f8dfb2cffaa4fbb4758) mission, int index, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) shooterAgent, [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) missionObjectToIgnore) |
| void | [CalculatePassbySoundParametersMT](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#acfa1ef3e9fc338477e6ac714afaca95e) (ref [SoundEventParameter](struct_tale_worlds_1_1_engine_1_1_sound_event_parameter.html) soundEventParameter) |
| void | [CalculateBounceBackVelocity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#af4a878ef9592788f1cc3730f335f1b18) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rotationSpeed, [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) velocity, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) angularVelocity) |
| void | [PassThroughEntity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#a9dceb3fe852607c182296836b1a86326) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MBMissile](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_missile.html) | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetPosition](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_missile.html#a8047c69ea94042346998e33e9bce2743) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetOldPosition](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_missile.html#a97fbba815f547b7debd02d4db2c306bf) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVelocity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_missile.html#ae00dd5606b6d1c9cc63d12486935225e) () |
| void | [SetVelocity](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_missile.html#a9fe7dc6d4cb2698d5337eecf150f4d65) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) velocity) |
| bool | [GetHasRigidBody](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_missile.html#a718917a8d41df240a82f16fa93aeaacf) () |

|  |  |
| --- | --- |
| Properties | |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [Entity](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#afa5447cf8301b92a1aefa55cbd676cb1) `[get]` |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | [Weapon](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#acf5b7610802d8cb1b277c63afb542775) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [ShooterAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#a099df2bd5155ca4d91f124b80de295bd) `[get]` |
| [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | [MissionObjectToIgnore](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#afb0581455bc1c6fe2dbf8184b4341d66) `[get]` |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [AlreadyHitEntityToIgnore](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#aa3349ca4450d2f3bf07d5da3325ea38b) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MBMissile](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_missile.html) | |
| int | [Index](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_missile.html#a6883e539930bc9ea89064541843bcec8) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MBMissile](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_missile.html) | |
|  | [MBMissile](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_missile.html#a33597620990fd658c5889ba19a6645f9) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#ad353ffb4b702e1c8585c7fe55fcbfa42)Missile()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Mission.Missile.Missile | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adfc400efb4da1f8dfb2cffaa4fbb4758) | *mission*, |
|  |  | int | *index*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *shooterAgent*, |
|  |  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | *missionObjectToIgnore* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#acfa1ef3e9fc338477e6ac714afaca95e)CalculatePassbySoundParametersMT()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.Missile.CalculatePassbySoundParametersMT | ( | ref [SoundEventParameter](struct_tale_worlds_1_1_engine_1_1_sound_event_parameter.html) | *soundEventParameter* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#af4a878ef9592788f1cc3730f335f1b18)CalculateBounceBackVelocity()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.Missile.CalculateBounceBackVelocity | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rotationSpeed*, |
|  |  | [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *velocity*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *angularVelocity* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#a9dceb3fe852607c182296836b1a86326)PassThroughEntity()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.Missile.PassThroughEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#afa5447cf8301b92a1aefa55cbd676cb1)Entity
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.Mission.Missile.Entity | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#acf5b7610802d8cb1b277c63afb542775)Weapon
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) TaleWorlds.MountAndBlade.Mission.Missile.Weapon | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#a099df2bd5155ca4d91f124b80de295bd)ShooterAgent
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Mission.Missile.ShooterAgent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#afb0581455bc1c6fe2dbf8184b4341d66)MissionObjectToIgnore
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) TaleWorlds.MountAndBlade.Mission.Missile.MissionObjectToIgnore | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_missile.html#aa3349ca4450d2f3bf07d5da3325ea38b)AlreadyHitEntityToIgnore
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.Mission.Missile.AlreadyHitEntityToIgnore | | get |


--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html ---

TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent Class ReferenceInherits [TaleWorlds.MountAndBlade.UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [HighlightPath](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a53647da026ea4cb13be0242ba5ea944f) () |
| void | [SetupGhostEntity](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#aa7de3a30b63e821885a8bf18b44c021e) () |
| void | [SetGhostVisibility](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a6098b26113ed3c3d93dd3ef88a7b6dfe) (bool isVisible) |
| void | [OnEditorInit](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#aaa54ef03437ae5cd54ecb8c2c0bc4602) () |
| void | [SetDistanceTraveledAsClient](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a1ffa81330fee9850182549a9f14c3575) (float distance) |
| override bool | [IsOnTickRequired](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a03a0f74b17341cb09857a681d5a02e57) () |
| void | [TickParallelManually](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#aa8b7ce0861b9c187d787f05d3ff4c88d) (float dt) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetInitialFrame](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a91631343488f2a9f2e9381ad1c33bd5c) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetTargetFrame](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#abaaad6b44097fedbdfacdc9b00256c23) () |
| void | [SetDestinationNavMeshIdState](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#ab0b960c770e17a2c7f407a06feb52122) (bool enabled) |
| void | [MoveToTargetAsClient](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a60e87ff6423f7b5f86a6cd85fa446e01) () |
| float | [GetTotalDistanceTraveledForPathTracker](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#ad888d574ec7189a8c674f6520731456e) () |
| void | [SetTotalDistanceTraveledForPathTracker](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#ae850ef1e278de2299a0783aba5673deb) (float distanceTraveled) |
| void | [SetTargetFrameForPathTracker](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#ade729b7f9be9c7d9ad1b16e2655e1f97) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [FindGroundFrameForWheelsStatic](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a062c06fcc635f1c98e6bbf129ce666ad) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, float axleLength, float wheelDiameter, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > wheels, [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [AxleLength](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a11196b1723fbdae7cbf4a6af9f839624) = 2.45f |
| int | [NavMeshIdToDisableOnDestination](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#ad451b8d716698d5eedf8141e950e1b0d) = -1 |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [GhostObjectTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#aeca0a6fd7ae2aed88c26d186f7e9130d) = "ghost\_object" |
| const string | [MoveStandingPointTag](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a742498e4c658b1e2d6d6e424bbcc3463) = "move" |

|  |  |
| --- | --- |
| Properties | |
| bool | [HasApproachedTarget](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a01b5f5492b3e93d2d04b49d0ee38fc4d) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Velocity](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#aea10e72bc5515f68525e2be079c446eb) `[get]` |
| bool | [HasArrivedAtTarget](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#aed774653ce015e193890178b0d4e8061) `[get]` |
| float | [CurrentSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a4b20a86d8dfb413e1647e3461f5c0d70) `[get]` |
| int | [MovementSoundCodeID](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#ab6cd0b15e41614c1476122f95ca934ad) `[get, set]` |
| float | [MinSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a2a55a8e082e232ff53c115e008e96769) `[get, set]` |
| float | [MaxSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a19e925342a9ed557aca4f0f111da7d90) `[get, set]` |
| string | [PathEntityName](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a19c5291d0fc1492459d7e780a0856751) `[get, set]` |
| float | [GhostEntitySpeedMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#af8e7226ff425720852e7bbcf579c0a5e) `[get, set]` |
| float | [WheelDiameter](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a911fb6ff8358ef1415c38953bf319bd3) `[set]` |
| [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) | [MainObject](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a25b89cc80f2dc58e28f19c6c82c2e31b) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a53647da026ea4cb13be0242ba5ea944f)HighlightPath()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.HighlightPath | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#aa7de3a30b63e821885a8bf18b44c021e)SetupGhostEntity()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.SetupGhostEntity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a6098b26113ed3c3d93dd3ef88a7b6dfe)SetGhostVisibility()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.SetGhostVisibility | ( | bool | *isVisible* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#aaa54ef03437ae5cd54ecb8c2c0bc4602)OnEditorInit()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.OnEditorInit | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a1ffa81330fee9850182549a9f14c3575)SetDistanceTraveledAsClient()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.SetDistanceTraveledAsClient | ( | float | *distance* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a03a0f74b17341cb09857a681d5a02e57)IsOnTickRequired()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.IsOnTickRequired | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html#ad80280b8807678ee7ea71a287636f3a6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#aa8b7ce0861b9c187d787f05d3ff4c88d)TickParallelManually()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.TickParallelManually | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a91631343488f2a9f2e9381ad1c33bd5c)GetInitialFrame()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.GetInitialFrame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#abaaad6b44097fedbdfacdc9b00256c23)GetTargetFrame()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.GetTargetFrame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#ab0b960c770e17a2c7f407a06feb52122)SetDestinationNavMeshIdState()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.SetDestinationNavMeshIdState | ( | bool | *enabled* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a60e87ff6423f7b5f86a6cd85fa446e01)MoveToTargetAsClient()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.MoveToTargetAsClient | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#ad888d574ec7189a8c674f6520731456e)GetTotalDistanceTraveledForPathTracker()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.GetTotalDistanceTraveledForPathTracker | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#ae850ef1e278de2299a0783aba5673deb)SetTotalDistanceTraveledForPathTracker()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.SetTotalDistanceTraveledForPathTracker | ( | float | *distanceTraveled* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#ade729b7f9be9c7d9ad1b16e2655e1f97)SetTargetFrameForPathTracker()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.SetTargetFrameForPathTracker | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a062c06fcc635f1c98e6bbf129ce666ad)FindGroundFrameForWheelsStatic()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.FindGroundFrameForWheelsStatic | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, | |  |  | float | *axleLength*, | |  |  | float | *wheelDiameter*, | |  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *wheels*, | |  |  | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#aeca0a6fd7ae2aed88c26d186f7e9130d)GhostObjectTag
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.GhostObjectTag = "ghost\_object" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a742498e4c658b1e2d6d6e424bbcc3463)MoveStandingPointTag
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.MoveStandingPointTag = "move" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a11196b1723fbdae7cbf4a6af9f839624)AxleLength
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.AxleLength = 2.45f |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#ad451b8d716698d5eedf8141e950e1b0d)NavMeshIdToDisableOnDestination
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.NavMeshIdToDisableOnDestination = -1 |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a01b5f5492b3e93d2d04b49d0ee38fc4d)HasApproachedTarget
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.HasApproachedTarget | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#aea10e72bc5515f68525e2be079c446eb)Velocity
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.Velocity | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#aed774653ce015e193890178b0d4e8061)HasArrivedAtTarget
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.HasArrivedAtTarget | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a4b20a86d8dfb413e1647e3461f5c0d70)CurrentSpeed
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.CurrentSpeed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#ab6cd0b15e41614c1476122f95ca934ad)MovementSoundCodeID
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.MovementSoundCodeID | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a2a55a8e082e232ff53c115e008e96769)MinSpeed
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.MinSpeed | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a19e925342a9ed557aca4f0f111da7d90)MaxSpeed
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.MaxSpeed | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a19c5291d0fc1492459d7e780a0856751)PathEntityName
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.PathEntityName | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#af8e7226ff425720852e7bbcf579c0a5e)GhostEntitySpeedMultiplier
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.GhostEntitySpeedMultiplier | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a911fb6ff8358ef1415c38953bf319bd3)WheelDiameter
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.WheelDiameter | | set |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon_movement_component.html#a25b89cc80f2dc58e28f19c6c82c2e31b)MainObject
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SynchedMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_synched_mission_object.html) TaleWorlds.MountAndBlade.SiegeWeaponMovementComponent.MainObject | | getset |


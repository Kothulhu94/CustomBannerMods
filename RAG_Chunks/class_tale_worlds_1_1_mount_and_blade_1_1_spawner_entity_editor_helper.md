--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html ---

TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper Class Reference|  |  |
| --- | --- |
| Classes | |
| struct | [Permission](struct_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper_1_1_permission.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [Axis](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a157af584e1dd2a870bc6260502445bf8) {     [x](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a157af584e1dd2a870bc6260502445bf8a9dd4e461268c8034f5c8564e155c67a6) ,     [y](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a157af584e1dd2a870bc6260502445bf8a415290769594460e2e485922904f345d) ,     [z](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a157af584e1dd2a870bc6260502445bf8afbade9e36a3f36d3d676c1b808451dd7)   } |
| enum | [PermissionType](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a6f71140c5280878e45aa3bb9dac1e95c) {     [scale](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a6f71140c5280878e45aa3bb9dac1e95ca0cb47aeb6e5f9323f0969e628c4e59f5) ,     [rotation](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a6f71140c5280878e45aa3bb9dac1e95caa5c02a3b57a78ef78fbca4f650029323)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SpawnerEntityEditorHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a8ba8e8667acceb7444253e18b1466c9c) ([ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) spawner) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetGhostEntityOrChild](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a5e0ada8ab4a4677fb76618ca42bc7f01) (string name) |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a5819bfc55a2bbca581a0ad1139ec70d0) (float dt) |
| void | [GivePermission](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a626b0b88715c1a98721f7a92c7d10234) (string childName, [Permission](struct_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper_1_1_permission.html) permission, Action< float > onChangeFunction) |
|  | Gives a permission to a specific child for allowing it to be rotated along specified axis or to be scaled in specified axis. |
| void | [ChangeStableChildMatrixFrameAndApply](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#ab59b463c015e6e7d5cf7c372de5532a3) (string childName, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) matrixFrame, bool updateTriad=true) |
| string | [GetPrefabName](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#ad90252bba65dac8d09558efc64c5df89) () |
| void | [SetupGhostMovement](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#aa0e2251a1d97517004da8c51cbd3d90e) (string pathName) |
| void | [SetEnableAutoGhostMovement](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a83e64dacc2b8906ce2a99399b603f3de) (bool enableAutoGhostMovement) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [LockGhostParent](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a8b551dad1087095cf6308bf82c36820c) = true |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a04447028ab07e53155ff10e90b32aa4a) `[get]` |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [SpawnedGhostEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#aa24e1276365f118b557fb9dc082383e4) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a157af584e1dd2a870bc6260502445bf8)Axis
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.Axis](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a157af584e1dd2a870bc6260502445bf8) |

| Enumerator | |
| --- | --- |
| x |  |
| y |  |
| z |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a6f71140c5280878e45aa3bb9dac1e95c)PermissionType
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.PermissionType](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a6f71140c5280878e45aa3bb9dac1e95c) |

| Enumerator | |
| --- | --- |
| scale |  |
| rotation |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a8ba8e8667acceb7444253e18b1466c9c)SpawnerEntityEditorHelper()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.SpawnerEntityEditorHelper | ( | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | *spawner* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a5e0ada8ab4a4677fb76618ca42bc7f01)GetGhostEntityOrChild()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.GetGhostEntityOrChild | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a5819bfc55a2bbca581a0ad1139ec70d0)Tick()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a626b0b88715c1a98721f7a92c7d10234)GivePermission()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.GivePermission | ( | string | *childName*, |
|  |  | [Permission](struct_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper_1_1_permission.html) | *permission*, |
|  |  | Action< float > | *onChangeFunction* ) |

Parameters
:   |  |  |
    | --- | --- |
    | childName |  |
    | permission |  |
    | onChangeFunction | This function will be called when permitted action happened, input of this function will be euler angle for rotation and axis length for scale. |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#ab59b463c015e6e7d5cf7c372de5532a3)ChangeStableChildMatrixFrameAndApply()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.ChangeStableChildMatrixFrameAndApply | ( | string | *childName*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *matrixFrame*, |
|  |  | bool | *updateTriad* = true ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#ad90252bba65dac8d09558efc64c5df89)GetPrefabName()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.GetPrefabName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#aa0e2251a1d97517004da8c51cbd3d90e)SetupGhostMovement()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.SetupGhostMovement | ( | string | *pathName* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a83e64dacc2b8906ce2a99399b603f3de)SetEnableAutoGhostMovement()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.SetEnableAutoGhostMovement | ( | bool | *enableAutoGhostMovement* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a8b551dad1087095cf6308bf82c36820c)LockGhostParent
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.LockGhostParent = true |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#a04447028ab07e53155ff10e90b32aa4a)IsValid
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.IsValid | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html#aa24e1276365f118b557fb9dc082383e4)SpawnedGhostEntity
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.SpawnerEntityEditorHelper.SpawnedGhostEntity | | get |


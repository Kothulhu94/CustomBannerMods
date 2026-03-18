--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html ---

TaleWorlds.MountAndBlade.GameEntityExtensions Class Reference[Game](class_tale_worlds_1_1_core_1_1_game.html) Entity class.

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [Instantiate](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#ab2efc73eaf8cff15fa6b8fb94536fb2e) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, bool showHolsterWithWeapon, bool needBatchedVersion) |
| static void | [CreateSimpleSkeleton](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#ab1ea045090cc55d41a9b563fc7bd7153) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, string skeletonName) |
| static void | [CreateSimpleSkeleton](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a7a0dc4ea232a08e9689b7bcc960fa152) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, string skeletonName) |
| static void | [CreateAgentSkeleton](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a4ce98009bf3ab9b42cea8d6d3fba2a4a) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, string skeletonName, bool isHumanoid, [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) actionSet, string monsterUsageSetName, [Monster](class_tale_worlds_1_1_core_1_1_monster.html) monster) |
| static void | [CreateAgentSkeleton](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a4485f3157f720836fe087f86068f41e6) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, string skeletonName, bool isHumanoid, [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) actionSet, string monsterUsageSetName, [Monster](class_tale_worlds_1_1_core_1_1_monster.html) monster) |
| static void | [CreateSkeletonWithActionSet](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#ae2179e826e7c2f191b124936718a5ad1) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, ref [AnimationSystemData](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html) animationSystemData) |
| static void | [CreateSkeletonWithActionSet](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a5f5c1d5a19df1ee9dfb00d9ae2e38838) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, ref [AnimationSystemData](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html) animationSystemData) |
| static void | [FadeOut](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a40bd0893794138c1eb2ee769c9e3fc54) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, float interval, bool isRemovingFromScene) |
| static void | [FadeIn](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a465b4d01e06c26f173dc269d7c613541) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, bool resetAlpha=true) |
| static void | [HideIfNotFadingOut](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a0755613c16c82e31905eb19ac89ded54) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#ab2efc73eaf8cff15fa6b8fb94536fb2e)Instantiate()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.GameEntityExtensions.Instantiate | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, | |  |  | bool | *showHolsterWithWeapon*, | |  |  | bool | *needBatchedVersion* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#ab1ea045090cc55d41a9b563fc7bd7153)CreateSimpleSkeleton() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameEntityExtensions.CreateSimpleSkeleton | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | string | *skeletonName* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a7a0dc4ea232a08e9689b7bcc960fa152)CreateSimpleSkeleton() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameEntityExtensions.CreateSimpleSkeleton | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | string | *skeletonName* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a4ce98009bf3ab9b42cea8d6d3fba2a4a)CreateAgentSkeleton() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameEntityExtensions.CreateAgentSkeleton | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | string | *skeletonName*, | |  |  | bool | *isHumanoid*, | |  |  | [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) | *actionSet*, | |  |  | string | *monsterUsageSetName*, | |  |  | [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | *monster* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a4485f3157f720836fe087f86068f41e6)CreateAgentSkeleton() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameEntityExtensions.CreateAgentSkeleton | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | string | *skeletonName*, | |  |  | bool | *isHumanoid*, | |  |  | [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) | *actionSet*, | |  |  | string | *monsterUsageSetName*, | |  |  | [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | *monster* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#ae2179e826e7c2f191b124936718a5ad1)CreateSkeletonWithActionSet() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameEntityExtensions.CreateSkeletonWithActionSet | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | ref [AnimationSystemData](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html) | *animationSystemData* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a5f5c1d5a19df1ee9dfb00d9ae2e38838)CreateSkeletonWithActionSet() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameEntityExtensions.CreateSkeletonWithActionSet | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | ref [AnimationSystemData](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html) | *animationSystemData* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a40bd0893794138c1eb2ee769c9e3fc54)FadeOut()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameEntityExtensions.FadeOut | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | float | *interval*, | |  |  | bool | *isRemovingFromScene* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a465b4d01e06c26f173dc269d7c613541)FadeIn()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameEntityExtensions.FadeIn | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | bool | *resetAlpha* = true ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_entity_extensions.html#a0755613c16c82e31905eb19ac89ded54)HideIfNotFadingOut()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameEntityExtensions.HideIfNotFadingOut | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |


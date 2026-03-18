--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html ---

TaleWorlds.MountAndBlade.MBExtensions Class ReferenceExtension methods for common usage.

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetGlobalOrganicDirection](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a1e52eeb77ceedf3ccfb95cc8b9a28cb1) (this [ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html) columnFormation) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetGlobalHeadDirection](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#ae029ce84796af85fe77a56e44cfecea5) (this [ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html) columnFormation) |
| static IEnumerable< T > | [FindAllWithType< T >](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a172317c1d4fbdc82213157a9ec91afc1) (this IEnumerable< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > entities) |
|  | Returns all script components with the specified type. |
| static IEnumerable< T > | [FindAllWithType< T >](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a59a1a086ca486d53fbb3ebb8a5139248) (this IEnumerable< [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) > missionObjects) |
| static List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | [FindAllWithCompatibleType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a716893ec2b3e4ae3c1022131523f1865) (this IEnumerable< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > sceneProps, params Type[] types) |
|  | Returns all game entities which are compatible with the specified types. |
| static List< [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) > | [FindAllWithCompatibleType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a0c3e5502adf4d77083bd82cfc1dfe8fb) (this IEnumerable< [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) > missionObjects, params Type[] types) |
| static MBList< T > | [CollectScriptComponentsIncludingChildrenRecursive< T >](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#aef782a93da53c7550995e0646e23982e) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity) |
|  | Collects all objects with type from scripted components of this entity and its children. |
| static MBList< T > | [CollectScriptComponentsIncludingChildrenRecursive< T >](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a42dde4ed5ba5d86ca4a66f7289d7c356) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity) |
| static List< T > | [CollectScriptComponentsWithTagIncludingChildrenRecursive< T >](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#ae168b0f83a2c71904a3bc35e8483ac87) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, string tag) |
|  | Collects all objects with type from scripted components of this entity with the given tag. |
| static List< T > | [CollectScriptComponentsWithTagIncludingChildrenRecursive< T >](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a2db5605b14e74a752ecf87de66917e5b) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity, string tag) |
| static List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | [CollectChildrenEntitiesWithTag](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#abf2b59305883db5f99d505a5c46715d8) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, string tag) |
| static List< [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) > | [CollectChildrenEntitiesWithTag](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a0b441adbfd8baa4a9b7e7b9879653833) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity, string tag) |
| static [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetFirstChildEntityWithName](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#adf2e3110d92ab19f241af475fcd6d240) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity, string name) |
| static T | [GetFirstScriptInFamilyDescending< T >](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a1109b79b9d3d6aaa742042c9c8c3e2db) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity) |
| static T | [GetFirstScriptInFamilyDescending< T >](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#af6ba6b384e491f9521caf2e6158f16f8) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity) |
| static bool | [HasParentOfType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a55546dd787aec6c9a198baf992c4d939) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) e, Type t) |
| static bool | [HasParentOfType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a01e3de5bdb954c87abc63e5d9f590354) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) e, Type t) |
| static TSource | [ElementAtOrValue< TSource >](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#ae2acf34b3b51bf7caa8a221c94ca5082) (this IEnumerable< TSource > source, int index, TSource value) |
| static bool | [IsOpponentOf](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#ab3f12e594d1e417f3e0ef2fd233e4922) (this [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) s, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a1e52eeb77ceedf3ccfb95cc8b9a28cb1)GetGlobalOrganicDirection()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.MBExtensions.GetGlobalOrganicDirection | ( | this [ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html) | *columnFormation* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#ae029ce84796af85fe77a56e44cfecea5)GetGlobalHeadDirection()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.MBExtensions.GetGlobalHeadDirection | ( | this [ColumnFormation](class_tale_worlds_1_1_mount_and_blade_1_1_column_formation.html) | *columnFormation* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a172317c1d4fbdc82213157a9ec91afc1)FindAllWithType< T >() [1/2]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< T > TaleWorlds.MountAndBlade.MBExtensions.FindAllWithType< T > | ( | this IEnumerable< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *entities* | ) |  | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | T | Type of the requested script components. |

Parameters
:   |  |  |
    | --- | --- |
    | entities |  |

Returns
:   List of script components with specified type.

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *ScriptComponentBehavior* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a59a1a086ca486d53fbb3ebb8a5139248)FindAllWithType< T >() [2/2]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< T > TaleWorlds.MountAndBlade.MBExtensions.FindAllWithType< T > | ( | this IEnumerable< [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) > | *missionObjects* | ) |  | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a716893ec2b3e4ae3c1022131523f1865)FindAllWithCompatibleType() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > TaleWorlds.MountAndBlade.MBExtensions.FindAllWithCompatibleType | ( | this IEnumerable< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *sceneProps*, | |  |  | params Type[] | *types* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | sceneProps |  |
    | types | Compatible types of the requested scene props. |

Returns
:   List of scene props which are compatible with the specified types.

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a0c3e5502adf4d77083bd82cfc1dfe8fb)FindAllWithCompatibleType() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) > TaleWorlds.MountAndBlade.MBExtensions.FindAllWithCompatibleType | ( | this IEnumerable< [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) > | *missionObjects*, | |  |  | params Type[] | *types* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#aef782a93da53c7550995e0646e23982e)CollectScriptComponentsIncludingChildrenRecursive< T >() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBList< T > TaleWorlds.MountAndBlade.MBExtensions.CollectScriptComponentsIncludingChildrenRecursive< T > | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity* | ) |  | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | T | The type of objects to be collected. |

Parameters
:   |  |  |
    | --- | --- |
    | entity | The root entity from which the objects will be collected from. |

Returns
:   Returns collected objects.

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *ScriptComponentBehavior* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a42dde4ed5ba5d86ca4a66f7289d7c356)CollectScriptComponentsIncludingChildrenRecursive< T >() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBList< T > TaleWorlds.MountAndBlade.MBExtensions.CollectScriptComponentsIncludingChildrenRecursive< T > | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity* | ) |  | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *ScriptComponentBehavior* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#ae168b0f83a2c71904a3bc35e8483ac87)CollectScriptComponentsWithTagIncludingChildrenRecursive< T >() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< T > TaleWorlds.MountAndBlade.MBExtensions.CollectScriptComponentsWithTagIncludingChildrenRecursive< T > | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, | |  |  | string | *tag* ) | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | T | The type of objects to be collected. |

Parameters
:   |  |  |
    | --- | --- |
    | entity | The root entity from which the objects will be collected from. |
    | tag | Tag that is required on the child. |

Returns
:   Returns collected objects.

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *ScriptComponentBehavior* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a2db5605b14e74a752ecf87de66917e5b)CollectScriptComponentsWithTagIncludingChildrenRecursive< T >() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< T > TaleWorlds.MountAndBlade.MBExtensions.CollectScriptComponentsWithTagIncludingChildrenRecursive< T > | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity*, | |  |  | string | *tag* ) | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *ScriptComponentBehavior* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#abf2b59305883db5f99d505a5c46715d8)CollectChildrenEntitiesWithTag() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > TaleWorlds.MountAndBlade.MBExtensions.CollectChildrenEntitiesWithTag | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, | |  |  | string | *tag* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a0b441adbfd8baa4a9b7e7b9879653833)CollectChildrenEntitiesWithTag() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) > TaleWorlds.MountAndBlade.MBExtensions.CollectChildrenEntitiesWithTag | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity*, | |  |  | string | *tag* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#adf2e3110d92ab19f241af475fcd6d240)GetFirstChildEntityWithName()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.MountAndBlade.MBExtensions.GetFirstChildEntityWithName | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity*, | |  |  | string | *name* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a1109b79b9d3d6aaa742042c9c8c3e2db)GetFirstScriptInFamilyDescending< T >() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T TaleWorlds.MountAndBlade.MBExtensions.GetFirstScriptInFamilyDescending< T > | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity* | ) |  | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *ScriptComponentBehavior* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#af6ba6b384e491f9521caf2e6158f16f8)GetFirstScriptInFamilyDescending< T >() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T TaleWorlds.MountAndBlade.MBExtensions.GetFirstScriptInFamilyDescending< T > | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity* | ) |  | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *ScriptComponentBehavior* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a55546dd787aec6c9a198baf992c4d939)HasParentOfType() [1/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBExtensions.HasParentOfType | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *e*, | |  |  | Type | *t* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#a01e3de5bdb954c87abc63e5d9f590354)HasParentOfType() [2/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBExtensions.HasParentOfType | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *e*, | |  |  | Type | *t* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#ae2acf34b3b51bf7caa8a221c94ca5082)ElementAtOrValue< TSource >()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TSource TaleWorlds.MountAndBlade.MBExtensions.ElementAtOrValue< TSource > | ( | this IEnumerable< TSource > | *source*, | |  |  | int | *index*, | |  |  | TSource | *value* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_extensions.html#ab3f12e594d1e417f3e0ef2fd233e4922)IsOpponentOf()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBExtensions.IsOpponentOf | ( | this [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *s*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) | | static |


--- SOURCE: class_tale_worlds_1_1_core_1_1_entity_system-1-g.html ---

TaleWorlds.Core.EntitySystem< T > Class Template Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [EntitySystem](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#ac76c9dc5f59977db0019c01be84ce753) () |
| TComponent | [AddComponent< TComponent >](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a12a347f5101fdf5badc9aaff1cab92fa) () |
| T | [AddComponent](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#afa309cd7168c3888ef84674c8ab23339) (Type componentType) |
| TComponent | [GetComponent< TComponent >](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#aa94df5e630dee860c4cdb4d032edf508) () |
| T | [GetComponent](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a6ee7030593181dfb695c2e34c99892a0) (Type componentType) |
| List< TComponent > | [GetComponents< TComponent >](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#afad6da322d4d10ae70e775d51c00baac) () |
| MBList< T > | [GetComponents](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a0e2f2d6a09a3faa8dbc6d0804c869634) () |
| void | [Finalize](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a08f0dfa8ef35ff9acf1088fd342655e3) (T component) |
| void | [RemoveComponent](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a5e80d36a7911aa8a62505f13c05adc0e) (T component) |
| void | [RemoveComponent< TComponent >](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#ad077a8449b18291cdc079c5117e003ae) () |
| void | [SortComponents< TComponent >](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a89cf6d2b708cb087295eefce1bb0e34b) (Comparison< T > comparison) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< T > | [Components](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a9c16e19b536ff546f2540c572d9f8869) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#ac76c9dc5f59977db0019c01be84ce753)EntitySystem()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.EntitySystem< T >.EntitySystem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a12a347f5101fdf5badc9aaff1cab92fa)AddComponent< TComponent >()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TComponent TaleWorlds.Core.EntitySystem< T >.[AddComponent](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#afa309cd7168c3888ef84674c8ab23339)< TComponent > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TComponent* | : | *class* |  |
    | *TComponent* | : | *T* |  |
    | *TComponent* | : | *new()* |  |

[◆](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#afa309cd7168c3888ef84674c8ab23339)AddComponent()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.Core.EntitySystem< T >.AddComponent | ( | Type | *componentType* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#aa94df5e630dee860c4cdb4d032edf508)GetComponent< TComponent >()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TComponent TaleWorlds.Core.EntitySystem< T >.[GetComponent](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a6ee7030593181dfb695c2e34c99892a0)< TComponent > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TComponent* | : | *class* |  |
    | *TComponent* | : | *T* |  |

[◆](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a6ee7030593181dfb695c2e34c99892a0)GetComponent()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.Core.EntitySystem< T >.GetComponent | ( | Type | *componentType* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#afad6da322d4d10ae70e775d51c00baac)GetComponents< TComponent >()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< TComponent > TaleWorlds.Core.EntitySystem< T >.[GetComponents](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a0e2f2d6a09a3faa8dbc6d0804c869634)< TComponent > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TComponent* | : | *T* |  |

[◆](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a0e2f2d6a09a3faa8dbc6d0804c869634)GetComponents()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBList< T > TaleWorlds.Core.EntitySystem< T >.GetComponents | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a08f0dfa8ef35ff9acf1088fd342655e3)Finalize()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.EntitySystem< T >.Finalize | ( | T | *component* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a5e80d36a7911aa8a62505f13c05adc0e)RemoveComponent()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.EntitySystem< T >.RemoveComponent | ( | T | *component* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#ad077a8449b18291cdc079c5117e003ae)RemoveComponent< TComponent >()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.EntitySystem< T >.[RemoveComponent](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a5e80d36a7911aa8a62505f13c05adc0e)< TComponent > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TComponent* | : | *class* |  |
    | *TComponent* | : | *T* |  |

[◆](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a89cf6d2b708cb087295eefce1bb0e34b)SortComponents< TComponent >()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.EntitySystem< T >.SortComponents< TComponent > | ( | Comparison< T > | *comparison* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TComponent* | : | *class* |  |
    | *TComponent* | : | *T* |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_entity_system-1-g.html#a9c16e19b536ff546f2540c572d9f8869)Components
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<T> TaleWorlds.Core.EntitySystem< T >.Components | | get |


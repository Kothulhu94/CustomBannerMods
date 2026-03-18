--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html ---

TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection Class ReferenceInherits IDictionary, and INotifyCollectionChanged.

|  |  |
| --- | --- |
| Public Member Functions | |
| IEnumerator< KeyValuePair< string, ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > > | [GetEnumerator](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a2d7bbeff64961c79c43575f1a75ff9b4) () |
| float | [GetBoundaryRadius](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#ab61a5b50fe56f3f2492821036ee4973e) (string name) |
| void | [GetOrientedBoundariesBox](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#af2c31764a929ba97411f820924be11f5) (out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) boxMinimum, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) boxMaximum, float rotationInRadians=0f) |
| void | [Add](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#af649492eab86f3bf54b27fad9c756822) (KeyValuePair< string, ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > item) |
| void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#ae515dbedf0c7287c666e11d87383f2d5) () |
| bool | [Contains](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a32148865b176b4aeadae8962a2d4d81b) (KeyValuePair< string, ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > item) |
| void | [CopyTo](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#afcc4270405a3245e8f5b0369e3401ee5) (KeyValuePair< string, ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > >[] array, int arrayIndex) |
| bool | [Remove](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a7ed010a7954203e8cce87d82773fc463) (KeyValuePair< string, ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > item) |
| void | [Add](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#afa3952635cf3f509ed1015ff6fbecce3) (string name, ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > points) |
| void | [Add](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a4063adbc7e661a826fd5597052be01ac) (string name, ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > points, bool isAllowanceInside) |
| bool | [ContainsKey](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#af469c488582fe260ed5ef317850b991a) (string name) |
| bool | [Remove](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a66826b48907622b58a963ecbc1d386fb) (string name) |
| bool | [TryGetValue](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#af47e65c172c10f63a7141c8ed4db22fb) (string name, out ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > points) |

|  |  |
| --- | --- |
| Properties | |
| int | [Count](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a579dd3cf6e7b7c216788d125a9a804f9) `[get]` |
| bool | [IsReadOnly](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a4570f9c5eac3b21adacf67174f5ae6a5) `[get]` |
| ICollection< string > | [Keys](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a9d4b97e34a9d746483a4fd23d2b3f3dd) `[get]` |
| ICollection< ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > | [Values](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#afc6a5d7a0bdc140e0c34913c43947ca1) `[get]` |
| ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | [this[string name]](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#aa06bc8da36a065d1297af98b789b1bca) `[get, set]` |

|  |  |
| --- | --- |
| Events | |
| NotifyCollectionChangedEventHandler | [CollectionChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a54e50946a1f2bce6ffcfa66360e62826) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a2d7bbeff64961c79c43575f1a75ff9b4)GetEnumerator()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerator< KeyValuePair< string, ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > > TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.GetEnumerator | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#ab61a5b50fe56f3f2492821036ee4973e)GetBoundaryRadius()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.GetBoundaryRadius | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#af2c31764a929ba97411f820924be11f5)GetOrientedBoundariesBox()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.GetOrientedBoundariesBox | ( | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *boxMinimum*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *boxMaximum*, |
|  |  | float | *rotationInRadians* = 0f ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#af649492eab86f3bf54b27fad9c756822)Add() [1/3]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.Add | ( | KeyValuePair< string, ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > | *item* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#ae515dbedf0c7287c666e11d87383f2d5)Clear()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a32148865b176b4aeadae8962a2d4d81b)Contains()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.Contains | ( | KeyValuePair< string, ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > | *item* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#afcc4270405a3245e8f5b0369e3401ee5)CopyTo()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.CopyTo | ( | KeyValuePair< string, ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > >[] | *array*, |
|  |  | int | *arrayIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a7ed010a7954203e8cce87d82773fc463)Remove() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.Remove | ( | KeyValuePair< string, ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > | *item* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#afa3952635cf3f509ed1015ff6fbecce3)Add() [2/3]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.Add | ( | string | *name*, |
|  |  | ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *points* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a4063adbc7e661a826fd5597052be01ac)Add() [3/3]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.Add | ( | string | *name*, |
|  |  | ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *points*, |
|  |  | bool | *isAllowanceInside* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#af469c488582fe260ed5ef317850b991a)ContainsKey()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.ContainsKey | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a66826b48907622b58a963ecbc1d386fb)Remove() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.Remove | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#af47e65c172c10f63a7141c8ed4db22fb)TryGetValue()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.TryGetValue | ( | string | *name*, |
|  |  | out ICollection< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *points* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a579dd3cf6e7b7c216788d125a9a804f9)Count
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.Count | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a4570f9c5eac3b21adacf67174f5ae6a5)IsReadOnly
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.IsReadOnly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a9d4b97e34a9d746483a4fd23d2b3f3dd)Keys
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ICollection<string> TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.Keys | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#afc6a5d7a0bdc140e0c34913c43947ca1)Values
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ICollection<ICollection<[Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)> > TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.Values | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#aa06bc8da36a065d1297af98b789b1bca)this[string name]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ICollection<[Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)> TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.this[string name] | | getset |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_m_b_boundary_collection.html#a54e50946a1f2bce6ffcfa66360e62826)CollectionChanged
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| NotifyCollectionChangedEventHandler TaleWorlds.MountAndBlade.Mission.MBBoundaryCollection.CollectionChanged |


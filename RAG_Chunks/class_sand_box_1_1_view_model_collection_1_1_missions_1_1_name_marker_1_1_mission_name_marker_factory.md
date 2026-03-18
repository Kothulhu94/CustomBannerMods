--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html ---

SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerFactory Class Reference|  |  |
| --- | --- |
| Classes | |
| interface | [INameMarkerProviderContext](interface_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marke641a17efd39acf1613441f8f4d85f157.html) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [INameMarkerProviderContext](interface_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marke641a17efd39acf1613441f8f4d85f157.html) | [PushContext](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#a7109f4c128db7830c1f2b1395b0b286a) (string name, bool addDefaultProviders) |
| static void | [PopContext](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#ab38424b39a980fd78ef93f857be17968) (string contextId) |
| static void | [PopContext](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#acca03110198f1d121857f855ba479b93) ([INameMarkerProviderContext](interface_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marke641a17efd39acf1613441f8f4d85f157.html) context) |
| static List< [MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html) > | [CollectProviders](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#ae0c9a7bf26ee99f6be5e027411db1054) () |
| static void | [UpdateProviders](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#ae26887026308a72ab096c157e7f30784) ([MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html)[] existingProviders, out List< [MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html) > addedProviders, out List< [MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html) > removedProviders) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly [INameMarkerProviderContext](interface_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marke641a17efd39acf1613441f8f4d85f157.html) | [DefaultContext](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#aa279367116659ab2a032ccc5c4fb13e5) = new NameMarkerProviderContext(true, "DefaultNameMarkerContext", FireProvidersChangedEvent) |

|  |  |
| --- | --- |
| Events | |
| static Action | [OnProvidersChanged](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#adeec5f1b3086c34a10eb18470f8cb268) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#a7109f4c128db7830c1f2b1395b0b286a)PushContext()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [INameMarkerProviderContext](interface_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marke641a17efd39acf1613441f8f4d85f157.html) SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerFactory.PushContext | ( | string | *name*, | |  |  | bool | *addDefaultProviders* ) | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#ab38424b39a980fd78ef93f857be17968)PopContext() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerFactory.PopContext | ( | string | *contextId* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#acca03110198f1d121857f855ba479b93)PopContext() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerFactory.PopContext | ( | [INameMarkerProviderContext](interface_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marke641a17efd39acf1613441f8f4d85f157.html) | *context* | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#ae0c9a7bf26ee99f6be5e027411db1054)CollectProviders()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | List< [MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html) > SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerFactory.CollectProviders | ( |  | ) |  | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#ae26887026308a72ab096c157e7f30784)UpdateProviders()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerFactory.UpdateProviders | ( | [MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html)[] | *existingProviders*, | |  |  | out List< [MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html) > | *addedProviders*, | |  |  | out List< [MissionNameMarkerProvider](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_provider.html) > | *removedProviders* ) | | static |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#aa279367116659ab2a032ccc5c4fb13e5)DefaultContext
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [INameMarkerProviderContext](interface_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marke641a17efd39acf1613441f8f4d85f157.html) SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerFactory.DefaultContext = new NameMarkerProviderContext(true, "DefaultNameMarkerContext", FireProvidersChangedEvent) | | static |

Event Documentation
-------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_missions_1_1_name_marker_1_1_mission_name_marker_factory.html#adeec5f1b3086c34a10eb18470f8cb268)OnProvidersChanged
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action SandBox.ViewModelCollection.Missions.NameMarker.MissionNameMarkerFactory.OnProvidersChanged | | static |


--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html ---

TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [WidgetFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#ac4ab2400ccd333b90d9468e6db7986a7) ([ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) resourceDepot, string resourceFolder) |
| void | [Initialize](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a48740300396e07047252c9ae1cf0af53) (List< string > assemblyOrder=null) |
| void | [AddCustomType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a26a681533096c83a29b16d7e96a7129a) (string name, string path) |
| IEnumerable< string > | [GetPrefabNames](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#ac4f2d6b8a35fa233d8d28e5e8a9e7963) () |
| IEnumerable< string > | [GetWidgetTypes](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a5bbf8edcbeb49aecf3f0558638ee340e) () |
| bool | [IsBuiltinType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#af61f68e5284698e2b7852d1969768a5e) (string name) |
| Type | [GetBuiltinType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#ab334eb2d506a2363967c574e9681495f) (string name) |
| bool | [IsCustomType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#ae4e63fb45c9625dcb0a77c9d87ac9232) (string typeName) |
| string | [GetCustomTypePath](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#ac3b0f33049bb0f9e5edf5abb45a55da7) (string name) |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [CreateBuiltinWidget](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#aca3ee2875bab193457f2334e7ea251c0) ([UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) context, string typeName) |
| [WidgetPrefab](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html) | [GetCustomType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a0211635245becf7200e6fd4237035003) (string typeName) |
| void | [OnUnload](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a7400831e839aad8304b1eee56f1264d5) (string typeName) |
| void | [CheckForUpdates](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a8a0f8cf24c3b22f405f14d137bdcf7d0) () |

|  |  |
| --- | --- |
| Properties | |
| PrefabExtensionContext | [PrefabExtensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a7dd1d0c36ee4d0928cbccf60d5192878) `[get]` |
| WidgetAttributeContext | [WidgetAttributeContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a35df3629e1921c74cecb768ea960d081) `[get]` |
| GeneratedPrefabContext | [GeneratedPrefabContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#ab6ab8dfc682e6b1d6ec0bd5d0a94fa5b) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action | [PrefabChange](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a94783d3d6d65d61ef982e099eb11f88c) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#ac4ab2400ccd333b90d9468e6db7986a7)WidgetFactory()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.WidgetFactory | ( | [ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html) | *resourceDepot*, |
|  |  | string | *resourceFolder* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a48740300396e07047252c9ae1cf0af53)Initialize()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.Initialize | ( | List< string > | *assemblyOrder* = null | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a26a681533096c83a29b16d7e96a7129a)AddCustomType()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.AddCustomType | ( | string | *name*, |
|  |  | string | *path* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#ac4f2d6b8a35fa233d8d28e5e8a9e7963)GetPrefabNames()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< string > TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.GetPrefabNames | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a5bbf8edcbeb49aecf3f0558638ee340e)GetWidgetTypes()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< string > TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.GetWidgetTypes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#af61f68e5284698e2b7852d1969768a5e)IsBuiltinType()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.IsBuiltinType | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#ab334eb2d506a2363967c574e9681495f)GetBuiltinType()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| Type TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.GetBuiltinType | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#ae4e63fb45c9625dcb0a77c9d87ac9232)IsCustomType()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.IsCustomType | ( | string | *typeName* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#ac3b0f33049bb0f9e5edf5abb45a55da7)GetCustomTypePath()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.GetCustomTypePath | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#aca3ee2875bab193457f2334e7ea251c0)CreateBuiltinWidget()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.CreateBuiltinWidget | ( | [UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) | *context*, |
|  |  | string | *typeName* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a0211635245becf7200e6fd4237035003)GetCustomType()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WidgetPrefab](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html) TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.GetCustomType | ( | string | *typeName* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a7400831e839aad8304b1eee56f1264d5)OnUnload()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.OnUnload | ( | string | *typeName* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a8a0f8cf24c3b22f405f14d137bdcf7d0)CheckForUpdates()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.CheckForUpdates | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a7dd1d0c36ee4d0928cbccf60d5192878)PrefabExtensionContext
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | PrefabExtensionContext TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.PrefabExtensionContext | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a35df3629e1921c74cecb768ea960d081)WidgetAttributeContext
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | WidgetAttributeContext TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.WidgetAttributeContext | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#ab6ab8dfc682e6b1d6ec0bd5d0a94fa5b)GeneratedPrefabContext
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | GeneratedPrefabContext TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.GeneratedPrefabContext | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html#a94783d3d6d65d61ef982e099eb11f88c)PrefabChange
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.GauntletUI.PrefabSystem.WidgetFactory.PrefabChange |


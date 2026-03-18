--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html ---

TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData Class ReferenceHolds Parent of the new widget, Context to create it in, [WidgetFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_factory.html) to create it from, [BrushFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_factory.html) to use Brushes from, SpriteData to use Sprites from, Extensions to impose on the created widget.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [WidgetCreationData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a82fa61e72f635fffeb1b53caa2b17417) ([UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) context, [WidgetFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#af92d0b55f9397ddef6bb98535092ad1e) widgetFactory, [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) parent) |
|  | [WidgetCreationData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#aee4282aedd83c9be418411ebf2e93e19) ([UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) context, [WidgetFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#af92d0b55f9397ddef6bb98535092ad1e) widgetFactory) |
|  | [WidgetCreationData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a3a8b9434bfc482a789641c4bcb21f0bd) (WidgetCreationData widgetCreationData, [WidgetInstantiationResult](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_instantiation_result.html) parentResult) |
| void | [AddExtensionData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a1f376466e6d39ec4dde6e872377027b5) (string name, object data) |
| T | [GetExtensionData< T >](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a9ecf4777a45dcfd3b4a7fc43c7e640a1) (string name) |
| void | [AddExtensionData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a60721e2fbe05c6b3fba4a7a7f04ff1fd) (object data) |
| T | [GetExtensionData< T >](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a00d478845f445688390f02ae339a944b) () |

|  |  |
| --- | --- |
| Properties | |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [Parent](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#acf57ffd28e883b1b2647a2db50fa3b17) `[get]` |
| [UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) | [Context](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a47636ee53d4d107fc03de0e9e9bd333c) `[get]` |
| WidgetFactory | [WidgetFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#af92d0b55f9397ddef6bb98535092ad1e) `[get]` |
| BrushFactory | [BrushFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#aa7331418bd0b423837b81dd2d42219d6) `[get]` |
| SpriteData | [SpriteData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a27a03b8cf465bba0b0c80e0e1895be67) `[get]` |
| PrefabExtensionContext | [PrefabExtensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#aff6942ba7227b23f1fe63c9332c3a0e5) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a82fa61e72f635fffeb1b53caa2b17417)WidgetCreationData() [1/3]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.WidgetCreationData | ( | [UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) | *context*, |
|  |  | [WidgetFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#af92d0b55f9397ddef6bb98535092ad1e) | *widgetFactory*, |
|  |  | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *parent* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#aee4282aedd83c9be418411ebf2e93e19)WidgetCreationData() [2/3]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.WidgetCreationData | ( | [UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) | *context*, |
|  |  | [WidgetFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#af92d0b55f9397ddef6bb98535092ad1e) | *widgetFactory* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a3a8b9434bfc482a789641c4bcb21f0bd)WidgetCreationData() [3/3]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.WidgetCreationData | ( | WidgetCreationData | *widgetCreationData*, |
|  |  | [WidgetInstantiationResult](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_instantiation_result.html) | *parentResult* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a1f376466e6d39ec4dde6e872377027b5)AddExtensionData() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.AddExtensionData | ( | string | *name*, |
|  |  | object | *data* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a9ecf4777a45dcfd3b4a7fc43c7e640a1)GetExtensionData< T >() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.GetExtensionData< T > | ( | string | *name* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *class* |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a60721e2fbe05c6b3fba4a7a7f04ff1fd)AddExtensionData() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.AddExtensionData | ( | object | *data* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a00d478845f445688390f02ae339a944b)GetExtensionData< T >() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.GetExtensionData< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *class* |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#acf57ffd28e883b1b2647a2db50fa3b17)Parent
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.Parent | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a47636ee53d4d107fc03de0e9e9bd333c)Context
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.Context | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#af92d0b55f9397ddef6bb98535092ad1e)WidgetFactory
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | WidgetFactory TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.WidgetFactory | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#aa7331418bd0b423837b81dd2d42219d6)BrushFactory
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | BrushFactory TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.BrushFactory | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#a27a03b8cf465bba0b0c80e0e1895be67)SpriteData
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SpriteData TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.SpriteData | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html#aff6942ba7227b23f1fe63c9332c3a0e5)PrefabExtensionContext
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | PrefabExtensionContext TaleWorlds.GauntletUI.PrefabSystem.WidgetCreationData.PrefabExtensionContext | | get |


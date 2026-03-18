--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html ---

TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [WidgetPrefab](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a4bd2d303bc7e8efd6b636ef25c387627) () |
| XmlDocument | [Save](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a200d992006fd1eb333e04bcac8289362) ([PrefabExtensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_prefab_extension_context.html) prefabExtensionContext) |
| [WidgetInstantiationResult](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_instantiation_result.html) | [Instantiate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a383dbb4f241bd0b80542e8dbc5daa84d) ([WidgetCreationData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html) widgetCreationData) |
| [WidgetInstantiationResult](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_instantiation_result.html) | [Instantiate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#af2222aeba5c8b4f8ab783bcf521018fe) ([WidgetCreationData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html) widgetCreationData, Dictionary< string, [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > parameters) |
| void | [OnRelease](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#acc9d09714fa24a31174df07e267f9d71) () |
| [ConstantDefinition](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_constant_definition.html) | [GetConstantValue](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#ae1f73bb6ea738c23a24686e3c813ffc2) (string name) |
| string | [GetParameterDefaultValue](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a5e3e1e837875c4f9503a4af4dcd96fce) (string name) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [WidgetPrefab](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a4bd2d303bc7e8efd6b636ef25c387627) | [LoadFrom](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a8388f7ce3d8602ede6fa29791a805a50) ([PrefabExtensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_prefab_extension_context.html) prefabExtensionContext, [WidgetAttributeContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_context.html) widgetAttributeContext, string path) |

|  |  |
| --- | --- |
| Properties | |
| Dictionary< string, [VisualDefinitionTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html) > | [VisualDefinitionTemplates](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a892d4c8c7378813c0ee9e15e4078d23a) `[get, set]` |
| Dictionary< string, [ConstantDefinition](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_constant_definition.html) > | [Constants](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a8a9c376a1acff8ceae96931f3395c39a) `[get, set]` |
| Dictionary< string, string > | [Parameters](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#ae927a481ea9b4fb9ec676738f5512661) `[get, set]` |
| Dictionary< string, XmlElement > | [CustomElements](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a6f37d7ddcebe2de5e2398c7dbf38dfc8) `[get, set]` |
| [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html) | [RootTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a33aed547a3baa2e26667b9a6306553c1) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a4bd2d303bc7e8efd6b636ef25c387627)WidgetPrefab()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.WidgetPrefab | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a8388f7ce3d8602ede6fa29791a805a50)LoadFrom()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [WidgetPrefab](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a4bd2d303bc7e8efd6b636ef25c387627) TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.LoadFrom | ( | [PrefabExtensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_prefab_extension_context.html) | *prefabExtensionContext*, | |  |  | [WidgetAttributeContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_context.html) | *widgetAttributeContext*, | |  |  | string | *path* ) | | static |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a200d992006fd1eb333e04bcac8289362)Save()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| XmlDocument TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.Save | ( | [PrefabExtensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_prefab_extension_context.html) | *prefabExtensionContext* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a383dbb4f241bd0b80542e8dbc5daa84d)Instantiate() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WidgetInstantiationResult](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_instantiation_result.html) TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.Instantiate | ( | [WidgetCreationData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html) | *widgetCreationData* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#af2222aeba5c8b4f8ab783bcf521018fe)Instantiate() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [WidgetInstantiationResult](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_instantiation_result.html) TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.Instantiate | ( | [WidgetCreationData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html) | *widgetCreationData*, |
|  |  | Dictionary< string, [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > | *parameters* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#acc9d09714fa24a31174df07e267f9d71)OnRelease()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.OnRelease | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#ae1f73bb6ea738c23a24686e3c813ffc2)GetConstantValue()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ConstantDefinition](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_constant_definition.html) TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.GetConstantValue | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a5e3e1e837875c4f9503a4af4dcd96fce)GetParameterDefaultValue()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.GetParameterDefaultValue | ( | string | *name* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a892d4c8c7378813c0ee9e15e4078d23a)VisualDefinitionTemplates
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [VisualDefinitionTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html)> TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.VisualDefinitionTemplates | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a8a9c376a1acff8ceae96931f3395c39a)Constants
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [ConstantDefinition](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_constant_definition.html)> TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.Constants | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#ae927a481ea9b4fb9ec676738f5512661)Parameters
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, string> TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.Parameters | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a6f37d7ddcebe2de5e2398c7dbf38dfc8)CustomElements
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, XmlElement> TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.CustomElements | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html#a33aed547a3baa2e26667b9a6306553c1)RootTemplate
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html) TaleWorlds.GauntletUI.PrefabSystem.WidgetPrefab.RootTemplate | | get |


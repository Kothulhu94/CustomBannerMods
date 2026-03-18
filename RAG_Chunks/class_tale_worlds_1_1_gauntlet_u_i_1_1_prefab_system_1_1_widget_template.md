--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html ---

TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) (string type) |
| void | [AddExtensionData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#aef6215b12a1a5dad8419fe9e96b89ae7) (string name, object data) |
| T | [GetExtensionData< T >](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a0857fc7344b1447c099e397a981b6161) (string name) |
| void | [RemoveExtensionData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a86f6e28bd9e40f05c20a37696d2ddbf0) (string name) |
| void | [AddExtensionData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ae3093c225dc7e24dbb2a5579fb24b307) (object data) |
| T | [GetExtensionData< T >](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a92f571ae90c747dc8f573972f8f7a3b6) () |
| void | [RemoveExtensionData< T >](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#aab02276723a3744ae0a819cb1c3ca1e5) () |
| IEnumerable< [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > | [GetAttributesOf< T >](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a57f2541c8b1f235e6ef3c2d7cedbf67a) () |
| IEnumerable< [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > | [GetAttributesOf< TKey, TValue >](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a32778367ed15e60de6c4a61aa2ef85bf) () |
| [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) | [GetFirstAttributeIfExist< T >](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a95a8242a19be382e523896df43dee5dc) () |
| void | [SetAttribute](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab547c9dd315186d98dbe097efc2d891b) ([WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) attribute) |
| [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) | [GetChildAt](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a6352214913d92c966f1d0ba46dfa49b3) (int i) |
| void | [AddChild](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a386142643e933117cd1c2510ceb4b0f7) ([WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) child) |
| void | [RemoveChild](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a9f3c8694b4abc412045225b5662c3ea4) ([WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) child) |
| void | [SwapChildren](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a9b81351f9ba4a30c6cb41fa64e089f5a) ([WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) child1, [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) child2) |
| [WidgetInstantiationResult](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_instantiation_result.html) | [Instantiate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a4e21cce032c3c85f59da237c1d00e627) ([WidgetCreationData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html) widgetCreationData, Dictionary< string, [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > parameters) |
| void | [OnRelease](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a8cb8afadb146ebfde75517ef1a71e2ef) () |
| void | [SetRootTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a69532f6b1a3a73da24272050bf99c49e) ([WidgetPrefab](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html) prefab) |
| void | [AddAttributeTo](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a2e1c1b3f147efb08c405f1ce2ae91b5c) ([WidgetAttributeContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_context.html) widgetAttributeContext, string name, string value) |
| void | [RemoveAttributeFrom](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ac368fc7e9cf101047d13ac35a2fb494f) ([WidgetAttributeContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_context.html) widgetAttributeContext, string fullName) |
| void | [RemoveAttributeFrom< T >](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a7ffcf940b50ad8e5e1ebbd7cf6708af0) (string name) |
| void | [RemoveAttributeFrom](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ad97cb63f59ad7bc5a159d61e2d6f57de) ([WidgetAttributeKeyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_key_type.html) keyType, string name) |
| void | [Save](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a42e0bda57cee28a64fbce29646d643ca) ([PrefabExtensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_prefab_extension_context.html) prefabExtensionContext, XmlNode parentNode) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) | [LoadFrom](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a2c8c806cdda1ff5c12c6d6a5f85d57ff) ([PrefabExtensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_prefab_extension_context.html) prefabExtensionContext, [WidgetAttributeContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_context.html) widgetAttributeContext, XmlNode node) |

|  |  |
| --- | --- |
| Properties | |
| bool | [LogicalChildrenLocation](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a6302588ba7b9c257099e21b810867345) `[get]` |
| string | [Id](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#af45d18222147e6ba4387b0132acee5de) `[get]` |
| string | [Type](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a57661b069d0446788ea4c057c2a43d62) `[get]` |
| int | [ChildCount](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a982d5449af119dba184f115293318a03) `[get]` |
| Dictionary< string, [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > | [GivenParameters](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a690a6388947ed9c6bc38d366a96a4eb4) `[get]` |
| [WidgetPrefab](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html) | [Prefab](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#aa8cec47fc6a680f7ad9a26de1578beef) `[get]` |
| [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) | [RootTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ad3a76551121fbcef8b179f4e76b9045d) `[get]` |
| Dictionary< [Type](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a57661b069d0446788ea4c057c2a43d62), Dictionary< string, [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > > | [Attributes](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a1be27109fb0fd652b9c77b854d8162ed) `[get]` |
| object | [Tag](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#abf60579a82b3b8f179111e225511a6cf) `[get, set]` |
| IEnumerable< [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > | [AllAttributes](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a3fdd0b52577853250498885726bfa770) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1)WidgetTemplate()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.WidgetTemplate | ( | string | *type* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#aef6215b12a1a5dad8419fe9e96b89ae7)AddExtensionData() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.AddExtensionData | ( | string | *name*, |
|  |  | object | *data* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a0857fc7344b1447c099e397a981b6161)GetExtensionData< T >() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.GetExtensionData< T > | ( | string | *name* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *class* |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a86f6e28bd9e40f05c20a37696d2ddbf0)RemoveExtensionData()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.RemoveExtensionData | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ae3093c225dc7e24dbb2a5579fb24b307)AddExtensionData() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.AddExtensionData | ( | object | *data* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a92f571ae90c747dc8f573972f8f7a3b6)GetExtensionData< T >() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.GetExtensionData< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *class* |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#aab02276723a3744ae0a819cb1c3ca1e5)RemoveExtensionData< T >()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void [TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.RemoveExtensionData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a86f6e28bd9e40f05c20a37696d2ddbf0)< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *class* |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a57f2541c8b1f235e6ef3c2d7cedbf67a)GetAttributesOf< T >()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.GetAttributesOf< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[WidgetAttributeKeyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_key_type.html)* |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a32778367ed15e60de6c4a61aa2ef85bf)GetAttributesOf< TKey, TValue >()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.GetAttributesOf< TKey, TValue > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TKey* | : | *[WidgetAttributeKeyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_key_type.html)* |  |
    | *TValue* | : | *[WidgetAttributeValueType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_value_type.html)* |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a95a8242a19be382e523896df43dee5dc)GetFirstAttributeIfExist< T >()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.GetFirstAttributeIfExist< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[WidgetAttributeKeyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_key_type.html)* |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab547c9dd315186d98dbe097efc2d891b)SetAttribute()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.SetAttribute | ( | [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) | *attribute* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a6352214913d92c966f1d0ba46dfa49b3)GetChildAt()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.GetChildAt | ( | int | *i* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a386142643e933117cd1c2510ceb4b0f7)AddChild()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.AddChild | ( | [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) | *child* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a9f3c8694b4abc412045225b5662c3ea4)RemoveChild()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.RemoveChild | ( | [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) | *child* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a9b81351f9ba4a30c6cb41fa64e089f5a)SwapChildren()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.SwapChildren | ( | [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) | *child1*, |
|  |  | [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) | *child2* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a4e21cce032c3c85f59da237c1d00e627)Instantiate()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [WidgetInstantiationResult](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_instantiation_result.html) TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.Instantiate | ( | [WidgetCreationData](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_creation_data.html) | *widgetCreationData*, |
|  |  | Dictionary< string, [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > | *parameters* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a8cb8afadb146ebfde75517ef1a71e2ef)OnRelease()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.OnRelease | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a2c8c806cdda1ff5c12c6d6a5f85d57ff)LoadFrom()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.LoadFrom | ( | [PrefabExtensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_prefab_extension_context.html) | *prefabExtensionContext*, | |  |  | [WidgetAttributeContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_context.html) | *widgetAttributeContext*, | |  |  | XmlNode | *node* ) | | static |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a69532f6b1a3a73da24272050bf99c49e)SetRootTemplate()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.SetRootTemplate | ( | [WidgetPrefab](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html) | *prefab* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a2e1c1b3f147efb08c405f1ce2ae91b5c)AddAttributeTo()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.AddAttributeTo | ( | [WidgetAttributeContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_context.html) | *widgetAttributeContext*, |
|  |  | string | *name*, |
|  |  | string | *value* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ac368fc7e9cf101047d13ac35a2fb494f)RemoveAttributeFrom() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.RemoveAttributeFrom | ( | [WidgetAttributeContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_context.html) | *widgetAttributeContext*, |
|  |  | string | *fullName* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a7ffcf940b50ad8e5e1ebbd7cf6708af0)RemoveAttributeFrom< T >()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void [TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.RemoveAttributeFrom](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ac368fc7e9cf101047d13ac35a2fb494f)< T > | ( | string | *name* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[WidgetAttributeKeyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_key_type.html)* |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ad97cb63f59ad7bc5a159d61e2d6f57de)RemoveAttributeFrom() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.RemoveAttributeFrom | ( | [WidgetAttributeKeyType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_key_type.html) | *keyType*, |
|  |  | string | *name* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a42e0bda57cee28a64fbce29646d643ca)Save()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.Save | ( | [PrefabExtensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_prefab_extension_context.html) | *prefabExtensionContext*, |
|  |  | XmlNode | *parentNode* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a6302588ba7b9c257099e21b810867345)LogicalChildrenLocation
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.LogicalChildrenLocation | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#af45d18222147e6ba4387b0132acee5de)Id
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.Id | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a57661b069d0446788ea4c057c2a43d62)Type
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.Type | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a982d5449af119dba184f115293318a03)ChildCount
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.ChildCount | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a690a6388947ed9c6bc38d366a96a4eb4)GivenParameters
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html)> TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.GivenParameters | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#aa8cec47fc6a680f7ad9a26de1578beef)Prefab
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WidgetPrefab](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_prefab.html) TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.Prefab | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ad3a76551121fbcef8b179f4e76b9045d)RootTemplate
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WidgetTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#ab73fe99f980ce81177f3eb44c26460c1) TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.RootTemplate | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a1be27109fb0fd652b9c77b854d8162ed)Attributes
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<[Type](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a57661b069d0446788ea4c057c2a43d62), Dictionary<string, [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html)> > TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.Attributes | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#abf60579a82b3b8f179111e225511a6cf)Tag
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.Tag | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_template.html#a3fdd0b52577853250498885726bfa770)AllAttributes
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html)> TaleWorlds.GauntletUI.PrefabSystem.WidgetTemplate.AllAttributes | | get |


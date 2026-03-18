--- SOURCE: class_tale_worlds_1_1_core_1_1_m_b_body_property.html ---

TaleWorlds.Core.MBBodyProperty Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MBBodyProperty](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#afcacc2511885d2d8e289d1e1c63bb5f9) (string stringId) |
|  | [MBBodyProperty](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#a277c508322e9ef4e69990d2e07d7ec99) () |
| void | [Init](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#a55860e46be980dd14fb310fbe9257030) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyPropertyMin, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyPropertyMax) |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#a77b6c52f04fde9f3d3306a8e08eb67ad) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MBBodyProperty](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#afcacc2511885d2d8e289d1e1c63bb5f9) | [CreateFrom](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#ae5572b751ad85898c319235c136a1a28) ([MBBodyProperty](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#afcacc2511885d2d8e289d1e1c63bb5f9) bodyProperty) |

|  |  |
| --- | --- |
| Properties | |
| string | [HairTags](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#a59a2a56055e2a3b3549bcd190bd24e24) = "" `[get, set]` |
| string | [BeardTags](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#a617c168ddf214c0254a060cc7a4a3084) = "" `[get, set]` |
| string | [TattooTags](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#a24a7ca6dc1c3c7c03c198371cf165498) = "" `[get, set]` |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [BodyPropertyMin](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#ab1d09a071b6d25b3f67d91d9c850f906) `[get]` |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [BodyPropertyMax](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#ae1d5ae03476b69c3a3abd685fe3931cc) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#afcacc2511885d2d8e289d1e1c63bb5f9)MBBodyProperty() [1/2]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.MBBodyProperty.MBBodyProperty | ( | string | *stringId* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#a277c508322e9ef4e69990d2e07d7ec99)MBBodyProperty() [2/2]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.MBBodyProperty.MBBodyProperty | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#ae5572b751ad85898c319235c136a1a28)CreateFrom()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MBBodyProperty](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#afcacc2511885d2d8e289d1e1c63bb5f9) TaleWorlds.Core.MBBodyProperty.CreateFrom | ( | [MBBodyProperty](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#afcacc2511885d2d8e289d1e1c63bb5f9) | *bodyProperty* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#a55860e46be980dd14fb310fbe9257030)Init()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.MBBodyProperty.Init | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyPropertyMin*, |
|  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyPropertyMax* ) |

[◆](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#a77b6c52f04fde9f3d3306a8e08eb67ad)Deserialize()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.MBBodyProperty.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#a59a2a56055e2a3b3549bcd190bd24e24)HairTags
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.MBBodyProperty.HairTags = "" | | getset |

[◆](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#a617c168ddf214c0254a060cc7a4a3084)BeardTags
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.MBBodyProperty.BeardTags = "" | | getset |

[◆](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#a24a7ca6dc1c3c7c03c198371cf165498)TattooTags
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.MBBodyProperty.TattooTags = "" | | getset |

[◆](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#ab1d09a071b6d25b3f67d91d9c850f906)BodyPropertyMin
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.Core.MBBodyProperty.BodyPropertyMin | | get |

[◆](class_tale_worlds_1_1_core_1_1_m_b_body_property.html#ae1d5ae03476b69c3a3abd685fe3931cc)BodyPropertyMax
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.Core.MBBodyProperty.BodyPropertyMax | | get |


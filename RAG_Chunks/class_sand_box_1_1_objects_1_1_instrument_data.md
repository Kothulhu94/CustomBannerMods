--- SOURCE: class_sand_box_1_1_objects_1_1_instrument_data.html ---

SandBox.Objects.InstrumentData Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [InstrumentData](class_sand_box_1_1_objects_1_1_instrument_data.html#a04621d38731da497ce78965d4bac4eda) () |
|  | [InstrumentData](class_sand_box_1_1_objects_1_1_instrument_data.html#a64912de8b08c3858750a77a97cc3ccbd) (string stringId) |
| void | [InitializeInstrumentData](class_sand_box_1_1_objects_1_1_instrument_data.html#a47baa8bc7099f1acb3f7fce761bf8344) (string sittingAction, string standingAction, bool isDataWithoutInstrument) |
| override void | [Deserialize](class_sand_box_1_1_objects_1_1_instrument_data.html#ae8c8cd90097643bfc0d51406b0854ba8) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
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
| Properties | |
| MBReadOnlyList<([HumanBone](namespace_tale_worlds_1_1_core.html#a47efca28876c843963d0ab7136b2bfb0), string)> | [InstrumentEntities](class_sand_box_1_1_objects_1_1_instrument_data.html#af8de1cd2ce6dee2185c5fa1268c064b4) `[get]` |
| string | [SittingAction](class_sand_box_1_1_objects_1_1_instrument_data.html#a7045640563ae588911944a1f9a8354f7) `[get]` |
| string | [StandingAction](class_sand_box_1_1_objects_1_1_instrument_data.html#ac0d704d78e38b656b72e94b1c3cf1f78) `[get]` |
| string | [Tag](class_sand_box_1_1_objects_1_1_instrument_data.html#a7037b220a89ef955df6d3f5c87e8c680) `[get]` |
| bool | [IsDataWithoutInstrument](class_sand_box_1_1_objects_1_1_instrument_data.html#a28db1c39fc31f106076547d60b320508) `[get]` |
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

[◆](class_sand_box_1_1_objects_1_1_instrument_data.html#a04621d38731da497ce78965d4bac4eda)InstrumentData() [1/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.Objects.InstrumentData.InstrumentData | ( |  | ) |  |

[◆](class_sand_box_1_1_objects_1_1_instrument_data.html#a64912de8b08c3858750a77a97cc3ccbd)InstrumentData() [2/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.Objects.InstrumentData.InstrumentData | ( | string | *stringId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_objects_1_1_instrument_data.html#a47baa8bc7099f1acb3f7fce761bf8344)InitializeInstrumentData()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Objects.InstrumentData.InitializeInstrumentData | ( | string | *sittingAction*, |
|  |  | string | *standingAction*, |
|  |  | bool | *isDataWithoutInstrument* ) |

[◆](class_sand_box_1_1_objects_1_1_instrument_data.html#ae8c8cd90097643bfc0d51406b0854ba8)Deserialize()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Objects.InstrumentData.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Property Documentation
----------------------

[◆](class_sand_box_1_1_objects_1_1_instrument_data.html#af8de1cd2ce6dee2185c5fa1268c064b4)InstrumentEntities
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<([HumanBone](namespace_tale_worlds_1_1_core.html#a47efca28876c843963d0ab7136b2bfb0), string)> SandBox.Objects.InstrumentData.InstrumentEntities | | get |

[◆](class_sand_box_1_1_objects_1_1_instrument_data.html#a7045640563ae588911944a1f9a8354f7)SittingAction
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.Objects.InstrumentData.SittingAction | | get |

[◆](class_sand_box_1_1_objects_1_1_instrument_data.html#ac0d704d78e38b656b72e94b1c3cf1f78)StandingAction
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.Objects.InstrumentData.StandingAction | | get |

[◆](class_sand_box_1_1_objects_1_1_instrument_data.html#a7037b220a89ef955df6d3f5c87e8c680)Tag
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.Objects.InstrumentData.Tag | | get |

[◆](class_sand_box_1_1_objects_1_1_instrument_data.html#a28db1c39fc31f106076547d60b320508)IsDataWithoutInstrument
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Objects.InstrumentData.IsDataWithoutInstrument | | get |


--- SOURCE: class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html ---

TaleWorlds.Core.MBEquipmentRoster Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [HasEquipmentFlags](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a9909c87b79dd6df688179cc6d17ef620) ([EquipmentFlags](namespace_tale_worlds_1_1_core.html#a0616df7bb1bc9858acba3a9782c43812) flags) |
| bool | [IsEquipmentTemplate](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a6b346f7454f532c2249271e2331121ef) () |
| void | [Init](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#ae8e86e344917fb2f2de83524256d26ce) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a50b200b457df50c4c46bf7958ce95452) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| void | [AddEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a27868ed60b5cc23000b041a36eb866f6) ([MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) equipmentRoster, EquipmentType equipmentType) |
| void | [AddOverridenEquipments](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a927b3df9ebdf5f8ba08c884193cb0f8b) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, List< XmlNode > overridenEquipmentSlots) |
| void | [OrderEquipments](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#af99d25a86f5928c50a92489dba51ebc2) () |
| void | [InitializeDefaultEquipment](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a03f4fac6d997d41b50dd0fdbedfe585b) (string equipmentName) |
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
| Public Attributes | |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [EquipmentCulture](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a8f2dbf6229cdaa6b897875208eb8308c) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [EmptyEquipment](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a6845be3a72ba04be3bf71998292d313c) = new [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html)([Equipment.EquipmentType.Civilian](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cbaa4f288ef90a7b9b5283ecf39574f010d0)) |

|  |  |
| --- | --- |
| Properties | |
| [EquipmentFlags](namespace_tale_worlds_1_1_core.html#a0616df7bb1bc9858acba3a9782c43812) | [EquipmentFlags](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a2d533f0e20e1cd3d000e1ce7b0b7b702) = [EquipmentFlags.None](namespace_tale_worlds_1_1_core.html#a0616df7bb1bc9858acba3a9782c43812a6adf97f83acf6453d4a6a4b1070f3754) `[get]` |
| MBReadOnlyList< [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) > | [AllEquipments](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a44b0a38216cb0adcd84c07fe823793ee) `[get]` |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [DefaultEquipment](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a2b3f2fa5b7f00d444a5ceb46be880136) `[get]` |
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

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a9909c87b79dd6df688179cc6d17ef620)HasEquipmentFlags()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.MBEquipmentRoster.HasEquipmentFlags | ( | [EquipmentFlags](namespace_tale_worlds_1_1_core.html#a0616df7bb1bc9858acba3a9782c43812) | *flags* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a6b346f7454f532c2249271e2331121ef)IsEquipmentTemplate()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.MBEquipmentRoster.IsEquipmentTemplate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#ae8e86e344917fb2f2de83524256d26ce)Init()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.MBEquipmentRoster.Init | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, |
|  |  | XmlNode | *node* ) |

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a50b200b457df50c4c46bf7958ce95452)Deserialize()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.MBEquipmentRoster.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a27868ed60b5cc23000b041a36eb866f6)AddEquipmentRoster()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.MBEquipmentRoster.AddEquipmentRoster | ( | [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) | *equipmentRoster*, |
|  |  | EquipmentType | *equipmentType* ) |

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a927b3df9ebdf5f8ba08c884193cb0f8b)AddOverridenEquipments()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.MBEquipmentRoster.AddOverridenEquipments | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, |
|  |  | List< XmlNode > | *overridenEquipmentSlots* ) |

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#af99d25a86f5928c50a92489dba51ebc2)OrderEquipments()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.MBEquipmentRoster.OrderEquipments | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a03f4fac6d997d41b50dd0fdbedfe585b)InitializeDefaultEquipment()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.MBEquipmentRoster.InitializeDefaultEquipment | ( | string | *equipmentName* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a6845be3a72ba04be3bf71998292d313c)EmptyEquipment
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.Core.MBEquipmentRoster.EmptyEquipment = new [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html)([Equipment.EquipmentType.Civilian](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cbaa4f288ef90a7b9b5283ecf39574f010d0)) | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a8f2dbf6229cdaa6b897875208eb8308c)EquipmentCulture
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.Core.MBEquipmentRoster.EquipmentCulture |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a2d533f0e20e1cd3d000e1ce7b0b7b702)EquipmentFlags
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EquipmentFlags](namespace_tale_worlds_1_1_core.html#a0616df7bb1bc9858acba3a9782c43812) TaleWorlds.Core.MBEquipmentRoster.EquipmentFlags = [EquipmentFlags.None](namespace_tale_worlds_1_1_core.html#a0616df7bb1bc9858acba3a9782c43812a6adf97f83acf6453d4a6a4b1070f3754) | | get |

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a44b0a38216cb0adcd84c07fe823793ee)AllEquipments
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Equipment](class_tale_worlds_1_1_core_1_1_equipment.html)> TaleWorlds.Core.MBEquipmentRoster.AllEquipments | | get |

[◆](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html#a2b3f2fa5b7f00d444a5ceb46be880136)DefaultEquipment
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.Core.MBEquipmentRoster.DefaultEquipment | | get |


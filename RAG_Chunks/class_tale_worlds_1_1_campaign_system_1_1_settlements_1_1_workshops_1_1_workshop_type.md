--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html ---

TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType Class ReferencesealedStores the [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) related data.

Inherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [Production](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type_1_1_production.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#af1bc23250525f773b78f1cb81ab34441) () |
|  | [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ac352004b1fe8702c670b38555d1ce423) () |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a3685ccabc2a94fc1bf4f9885de01d68a) () |
| override void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a35e8edf15f51be2f9df7e5c70d1bb620) () |
| override void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#afed6802d6fdea94157bbb616738307b3) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ac352004b1fe8702c670b38555d1ce423) | [Find](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a086915cfa64bc08eb230d29148ba9fbb) (string idString) |
| static [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ac352004b1fe8702c670b38555d1ce423) | [FindFirst](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#af07b0f7eb623e8a7329b6e427d614a25) (Func< [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ac352004b1fe8702c670b38555d1ce423), bool > predicate) |

|  |  |
| --- | --- |
| Properties | |
| int | [EquipmentCost](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ab3c915b76635a391c7264fcf53b353d9) `[get]` |
| int | [Frequency](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a8a793f779f3e60977cb714e8640dd1ba) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#af846d753579646e0ac4facda33c87b05) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [JobName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a124e573f45d278f83f90e885431f32ef) `[get]` |
| bool | [IsHidden](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a54b3ae390d83577ede859282445cebc5) `[get]` |
| string | [SignMeshName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a1f98a99b00babac1181b9e198eb0960b) `[get]` |
| string | [PropMeshName1](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#afadeb77c668245ffc8b8ffc7f19f7aa8) `[get]` |
| string | [PropMeshName2](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a9df904363c003193efe3283a50c22576) `[get]` |
| List< string > | [PropMeshName3List](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a1b01b93634d8a998b012dd290c1c7198) `[get]` |
| string | [PropMeshName4](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a4ca859e6dd27d7ecc104a7df4fab7bf5) `[get]` |
| string | [PropMeshName5](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a4cacd4a508c61a7642a711c33ebb493f) `[get]` |
| string | [PropMeshName6](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a714314577314fbf82f67b398313c8528) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Description](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ae5ad7a497ccb8566c6a18dd36452e267) `[get]` |
| MBReadOnlyList< [Production](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type_1_1_production.html) > | [Productions](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ad88749748a373d27ee205c8df66baf8b) `[get]` |
| static MBReadOnlyList< [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ac352004b1fe8702c670b38555d1ce423) > | [All](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a68e8c9450d7948a56299c07a1acd3b09) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ac352004b1fe8702c670b38555d1ce423)WorkshopType()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.WorkshopType | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#af1bc23250525f773b78f1cb81ab34441)GetName()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a3685ccabc2a94fc1bf4f9885de01d68a)ToString()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a35e8edf15f51be2f9df7e5c70d1bb620)Initialize()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.Initialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#afed6802d6fdea94157bbb616738307b3)Deserialize()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a086915cfa64bc08eb230d29148ba9fbb)Find()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ac352004b1fe8702c670b38555d1ce423) TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.Find | ( | string | *idString* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#af07b0f7eb623e8a7329b6e427d614a25)FindFirst()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ac352004b1fe8702c670b38555d1ce423) TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.FindFirst | ( | Func< [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ac352004b1fe8702c670b38555d1ce423), bool > | *predicate* | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ab3c915b76635a391c7264fcf53b353d9)EquipmentCost
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.EquipmentCost | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a8a793f779f3e60977cb714e8640dd1ba)Frequency
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.Frequency | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#af846d753579646e0ac4facda33c87b05)Name
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a124e573f45d278f83f90e885431f32ef)JobName
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.JobName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a54b3ae390d83577ede859282445cebc5)IsHidden
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.IsHidden | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a1f98a99b00babac1181b9e198eb0960b)SignMeshName
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.SignMeshName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#afadeb77c668245ffc8b8ffc7f19f7aa8)PropMeshName1
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.PropMeshName1 | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a9df904363c003193efe3283a50c22576)PropMeshName2
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.PropMeshName2 | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a1b01b93634d8a998b012dd290c1c7198)PropMeshName3List
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<string> TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.PropMeshName3List | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a4ca859e6dd27d7ecc104a7df4fab7bf5)PropMeshName4
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.PropMeshName4 | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a4cacd4a508c61a7642a711c33ebb493f)PropMeshName5
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.PropMeshName5 | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a714314577314fbf82f67b398313c8528)PropMeshName6
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.PropMeshName6 | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ae5ad7a497ccb8566c6a18dd36452e267)Description
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.Description | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ad88749748a373d27ee205c8df66baf8b)Productions
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Production](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type_1_1_production.html)> TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.Productions | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#a68e8c9450d7948a56299c07a1acd3b09)All
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html#ac352004b1fe8702c670b38555d1ce423)> TaleWorlds.CampaignSystem.Settlements.Workshops.WorkshopType.All | | staticget |


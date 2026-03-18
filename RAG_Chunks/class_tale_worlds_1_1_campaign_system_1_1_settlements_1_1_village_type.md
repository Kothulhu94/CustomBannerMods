--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html ---

TaleWorlds.CampaignSystem.Settlements.VillageType Class ReferencesealedInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [VillageType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a121625f84fa029509fa90bbcea03ca03) (string stringId) |
| [VillageType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a121625f84fa029509fa90bbcea03ca03) | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#aa7bc6461971aac12abc9c704bb86bb78) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) shortName, string meshName, string meshNameUnderConstruction, string meshNameBurned, ValueTuple< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), float >[] productions) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a9672410af14ca646713875b70164dc8c) () |
| void | [AddProductions](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a91662bdfb1de8688e712411d41e825e7) (IEnumerable< ValueTuple< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), float > > productions) |
| float | [GetProductionPerDay](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#ab214ba31c8d8843fd27859939e8090da) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| float | [GetProductionPerDay](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a9e4cc6b7234d38e0dc163db1b8daf921) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory) |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| virtual void | [Deserialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [ShortName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#acb8a7174ec8ff181fc4d41d33d8ca7a1) |
| string | [MeshName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a7723da7d78979d61b562130dc83e870d) |
| string | [MeshNameUnderConstruction](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#ad9ab1b5127be391a7d72bb6c97eb1cad) |
| string | [MeshNameBurned](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#afb845dab95b53119fb3165033e5bcaf4) |

|  |  |
| --- | --- |
| Properties | |
| static MBReadOnlyList< [VillageType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a121625f84fa029509fa90bbcea03ca03) > | [All](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a318a2bd65fe9a48c077838e3683dcaa5) `[get]` |
| MBReadOnlyList< ValueTuple< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), float > > | [Productions](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a071a13e9075de69bb82f73867ad176d6) `[get]` |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [PrimaryProduction](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#af52ad85a13a6c5ff60eae490d421d5b0) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a121625f84fa029509fa90bbcea03ca03)VillageType()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.VillageType.VillageType | ( | string | *stringId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#aa7bc6461971aac12abc9c704bb86bb78)Initialize()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [VillageType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a121625f84fa029509fa90bbcea03ca03) TaleWorlds.CampaignSystem.Settlements.VillageType.Initialize | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *shortName*, |
|  |  | string | *meshName*, |
|  |  | string | *meshNameUnderConstruction*, |
|  |  | string | *meshNameBurned*, |
|  |  | ValueTuple< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), float >[] | *productions* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a9672410af14ca646713875b70164dc8c)ToString()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Settlements.VillageType.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a91662bdfb1de8688e712411d41e825e7)AddProductions()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.VillageType.AddProductions | ( | IEnumerable< ValueTuple< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), float > > | *productions* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#ab214ba31c8d8843fd27859939e8090da)GetProductionPerDay() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Settlements.VillageType.GetProductionPerDay | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a9e4cc6b7234d38e0dc163db1b8daf921)GetProductionPerDay() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Settlements.VillageType.GetProductionPerDay | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#acb8a7174ec8ff181fc4d41d33d8ca7a1)ShortName
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.VillageType.ShortName |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a7723da7d78979d61b562130dc83e870d)MeshName
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.CampaignSystem.Settlements.VillageType.MeshName |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#ad9ab1b5127be391a7d72bb6c97eb1cad)MeshNameUnderConstruction
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.CampaignSystem.Settlements.VillageType.MeshNameUnderConstruction |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#afb845dab95b53119fb3165033e5bcaf4)MeshNameBurned
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.CampaignSystem.Settlements.VillageType.MeshNameBurned |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a318a2bd65fe9a48c077838e3683dcaa5)All
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[VillageType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a121625f84fa029509fa90bbcea03ca03)> TaleWorlds.CampaignSystem.Settlements.VillageType.All | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#a071a13e9075de69bb82f73867ad176d6)Productions
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<ValueTuple<[ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), float> > TaleWorlds.CampaignSystem.Settlements.VillageType.Productions | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village_type.html#af52ad85a13a6c5ff60eae490d421d5b0)PrimaryProduction
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.Settlements.VillageType.PrimaryProduction | | get |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html ---

TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType Class ReferencesealedInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [EffectInfo](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type_1_1_effect_info.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BuildingType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#acf280512ff361b89f60cd45f9b8d8ea3) (string stringId) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#ab5ac068a7b937104cf4331948fd59690) () |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#ad24ae913218c66bf2c5c300bac6f6dda) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation, int[] productionCosts, Tuple< [BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7), [BuildingEffectIncrementType](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#acd708cf73115217790a9ac440e09c7bd), float, float, float >[] effects, bool isMilitaryProject, float varianceChance, int startLevel=0) |
| void | [InitializeDailyProject](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a586db6c5dfbb6205efea346b99e66bbe) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation, Tuple< [BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7), [BuildingEffectIncrementType](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#acd708cf73115217790a9ac440e09c7bd), float, float, float >[] effects) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#aedc6bda53a5c4203e72b2b29e93381a5) () |
| int | [GetProductionCost](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a04ac40ed7229d50247515da710620880) (int level) |
| float | [GetBaseBuildingEffectAmount](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#af06041947553b02fb42e91011913b2df) ([BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7) effect, int level) |
| bool | [HasEffect](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a96cec8d77892f0c0105a9a8a8a7e97e8) ([BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7) effect) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetExplanationAtLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a776b9a0e3d07e417089affcb60f8b7f4) (int level) |
| [BuildingEffectIncrementType](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#acd708cf73115217790a9ac440e09c7bd) | [GetBuildingEffectType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a113fbd4925805497457d2d1f418a18dc) ([BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7) effect) |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| virtual void | [Deserialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [IsDailyProject](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#aabfa81e2a7e4da1732abd381e1dede6a) |
| bool | [IsMilitaryProject](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a4fcb6d84b0a5a7e9481bfcac04e91aa5) |
| int | [StartLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a4640ad3f206db4d5c1624d59cf6abf19) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MaxLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#ac5c5ad2222e9e7d166d29b85b1ea75e9) = 3 |

|  |  |
| --- | --- |
| Properties | |
| static MBReadOnlyList< [BuildingType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#acf280512ff361b89f60cd45f9b8d8ea3) > | [All](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a660ea9d3ec65096c5dca516e59519ab7) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#af8890b841f7cca557f0c05e8be10c963) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Explanation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a4e2dc03b82002a65da882226c1fa31e4) `[get]` |
| float | [VarianceChance](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a4bdc306e3ef29001864b02bac43a773b) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#acf280512ff361b89f60cd45f9b8d8ea3)BuildingType()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.BuildingType | ( | string | *stringId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#ab5ac068a7b937104cf4331948fd59690)GetName()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#ad24ae913218c66bf2c5c300bac6f6dda)Initialize()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.Initialize | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation*, |
|  |  | int[] | *productionCosts*, |
|  |  | Tuple< [BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7), [BuildingEffectIncrementType](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#acd708cf73115217790a9ac440e09c7bd), float, float, float >[] | *effects*, |
|  |  | bool | *isMilitaryProject*, |
|  |  | float | *varianceChance*, |
|  |  | int | *startLevel* = 0 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a586db6c5dfbb6205efea346b99e66bbe)InitializeDailyProject()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.InitializeDailyProject | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation*, |
|  |  | Tuple< [BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7), [BuildingEffectIncrementType](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#acd708cf73115217790a9ac440e09c7bd), float, float, float >[] | *effects* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#aedc6bda53a5c4203e72b2b29e93381a5)ToString()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a04ac40ed7229d50247515da710620880)GetProductionCost()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.GetProductionCost | ( | int | *level* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#af06041947553b02fb42e91011913b2df)GetBaseBuildingEffectAmount()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.GetBaseBuildingEffectAmount | ( | [BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7) | *effect*, |
|  |  | int | *level* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a96cec8d77892f0c0105a9a8a8a7e97e8)HasEffect()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.HasEffect | ( | [BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7) | *effect* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a776b9a0e3d07e417089affcb60f8b7f4)GetExplanationAtLevel()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.GetExplanationAtLevel | ( | int | *level* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a113fbd4925805497457d2d1f418a18dc)GetBuildingEffectType()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BuildingEffectIncrementType](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#acd708cf73115217790a9ac440e09c7bd) TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.GetBuildingEffectType | ( | [BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7) | *effect* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#ac5c5ad2222e9e7d166d29b85b1ea75e9)MaxLevel
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.MaxLevel = 3 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#aabfa81e2a7e4da1732abd381e1dede6a)IsDailyProject
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.IsDailyProject |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a4fcb6d84b0a5a7e9481bfcac04e91aa5)IsMilitaryProject
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.IsMilitaryProject |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a4640ad3f206db4d5c1624d59cf6abf19)StartLevel
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.StartLevel |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a660ea9d3ec65096c5dca516e59519ab7)All
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[BuildingType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#acf280512ff361b89f60cd45f9b8d8ea3)> TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.All | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#af8890b841f7cca557f0c05e8be10c963)Name
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a4e2dc03b82002a65da882226c1fa31e4)Explanation
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.Explanation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building_type.html#a4bdc306e3ef29001864b02bac43a773b)VarianceChance
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Buildings.BuildingType.VarianceChance | | get |


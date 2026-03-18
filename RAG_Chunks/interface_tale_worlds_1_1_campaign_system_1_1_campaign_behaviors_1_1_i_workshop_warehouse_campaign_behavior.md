--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.IWorkshopWarehouseCampaignBehavior Interface ReferenceInherited by [TaleWorlds.CampaignSystem.CampaignBehaviors.WorkshopsCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_workshops_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [IsGettingInputsFromWarehouse](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a510004a2b5c282bc127c364f5b4dfe3c) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| void | [SetIsGettingInputsFromWarehouse](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#ab99d81e9f06ee6f4008919a7cfa0e23b) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, bool isActive) |
| float | [GetStockProductionInWarehouseRatio](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a592c2490395acc9c4fd5b58eccdec096) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| void | [SetStockProductionInWarehouseRatio](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#aa2255883f914631ae995a52a67026d91) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, float percentage) |
| float | [GetWarehouseItemRosterWeight](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a1b8f3c4978f43163f0ad969b1f5fa189) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| bool | [IsRawMaterialsSufficientInTownMarket](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a4fd7870fdaae02ea1270ac7e552a5893) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| int | [GetInputCount](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a2c8a26e5123ff213297c61253ddca914) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| int | [GetOutputCount](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a4ef9e4344a758055add3a0cb568c89a7) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetInputDailyChange](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a8f223756ed42c61510dbfe614f5a8b9a) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetOutputDailyChange](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a011aecf6fc8145b11ebc0feabbc4048e) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a510004a2b5c282bc127c364f5b4dfe3c)IsGettingInputsFromWarehouse()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.IWorkshopWarehouseCampaignBehavior.IsGettingInputsFromWarehouse | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#ab99d81e9f06ee6f4008919a7cfa0e23b)SetIsGettingInputsFromWarehouse()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IWorkshopWarehouseCampaignBehavior.SetIsGettingInputsFromWarehouse | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, |
|  |  | bool | *isActive* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a592c2490395acc9c4fd5b58eccdec096)GetStockProductionInWarehouseRatio()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.CampaignBehaviors.IWorkshopWarehouseCampaignBehavior.GetStockProductionInWarehouseRatio | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#aa2255883f914631ae995a52a67026d91)SetStockProductionInWarehouseRatio()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IWorkshopWarehouseCampaignBehavior.SetStockProductionInWarehouseRatio | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, |
|  |  | float | *percentage* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a1b8f3c4978f43163f0ad969b1f5fa189)GetWarehouseItemRosterWeight()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.CampaignBehaviors.IWorkshopWarehouseCampaignBehavior.GetWarehouseItemRosterWeight | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.WorkshopsCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_workshops_campaign_behavior.html#a32286e32895eac470f6fe74bd6c684da).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a4fd7870fdaae02ea1270ac7e552a5893)IsRawMaterialsSufficientInTownMarket()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.IWorkshopWarehouseCampaignBehavior.IsRawMaterialsSufficientInTownMarket | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a2c8a26e5123ff213297c61253ddca914)GetInputCount()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.IWorkshopWarehouseCampaignBehavior.GetInputCount | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a4ef9e4344a758055add3a0cb568c89a7)GetOutputCount()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.IWorkshopWarehouseCampaignBehavior.GetOutputCount | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a8f223756ed42c61510dbfe614f5a8b9a)GetInputDailyChange()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.CampaignBehaviors.IWorkshopWarehouseCampaignBehavior.GetInputDailyChange | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_workshop_warehouse_campaign_behavior.html#a011aecf6fc8145b11ebc0feabbc4048e)GetOutputDailyChange()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.CampaignBehaviors.IWorkshopWarehouseCampaignBehavior.GetOutputDailyChange | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |


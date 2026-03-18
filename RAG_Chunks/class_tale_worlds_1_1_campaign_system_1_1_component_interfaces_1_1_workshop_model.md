--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetMaxWorkshopCountForClanTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a0a99c9ace3f1ac75f96dc1f776a6361d) (int tier) |
| int | [GetCostForPlayer](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a3058995424d859183b0b40d8fc53968f) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| int | [GetCostForNotable](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#ab12f37b597c94fb3cf27afbe26b8cdcf) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetNotableOwnerForWorkshop](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#adf80ead1a22178fe98b3c3261605f0e8) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetEffectiveConversionSpeedOfProduction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a0c47680535d9f0e6548dc82ff4b572d6) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, float speed, bool includeDescriptions) |
| int | [GetConvertProductionCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a392c8fce3186624d415b0f21b444e715) ([WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html) workshopType) |
| bool | [CanPlayerSellWorkshop](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a51af09a176c2343cc0903d48e678de43) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| float | [GetTradeXpPerWarehouseProduction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#abd3c36487475f5515ed3feb1afff4f15) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) production) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [DaysForPlayerSaveWorkshopFromBankruptcy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a84a8d612b02f2100943949be3b59573e) `[get]` |
| int | [CapitalLowLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a6eabd4bcc84bb90d0533cbb16e3ea02a) `[get]` |
| int | [InitialCapital](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#ad4f33eb95fdef1b754a393415fba1718) `[get]` |
| int | [DailyExpense](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a7fe9d27000feb1119ef98ccf43138bb5) `[get]` |
| int | [WarehouseCapacity](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a17b9e32817d9a64559b7b557fa03557c) `[get]` |
| int | [DefaultWorkshopCountInSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#aa714a824ecb5a170c8039d91df67452e) `[get]` |
| int | [MaximumWorkshopsPlayerCanHave](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#adb133497327c26d2d6a2d04f462842a7) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a0a99c9ace3f1ac75f96dc1f776a6361d)GetMaxWorkshopCountForClanTier()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.GetMaxWorkshopCountForClanTier | ( | int | *tier* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a3058995424d859183b0b40d8fc53968f)GetCostForPlayer()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.GetCostForPlayer | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#ab12f37b597c94fb3cf27afbe26b8cdcf)GetCostForNotable()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.GetCostForNotable | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#adf80ead1a22178fe98b3c3261605f0e8)GetNotableOwnerForWorkshop()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.GetNotableOwnerForWorkshop | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a0c47680535d9f0e6548dc82ff4b572d6)GetEffectiveConversionSpeedOfProduction()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.GetEffectiveConversionSpeedOfProduction | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, | |  |  | float | *speed*, | |  |  | bool | *includeDescriptions* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a392c8fce3186624d415b0f21b444e715)GetConvertProductionCost()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.GetConvertProductionCost | ( | [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html) | *workshopType* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a51af09a176c2343cc0903d48e678de43)CanPlayerSellWorkshop()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.CanPlayerSellWorkshop | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#abd3c36487475f5515ed3feb1afff4f15)GetTradeXpPerWarehouseProduction()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.GetTradeXpPerWarehouseProduction | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *production* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a84a8d612b02f2100943949be3b59573e)DaysForPlayerSaveWorkshopFromBankruptcy
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.DaysForPlayerSaveWorkshopFromBankruptcy | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a6eabd4bcc84bb90d0533cbb16e3ea02a)CapitalLowLimit
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.CapitalLowLimit | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#ad4f33eb95fdef1b754a393415fba1718)InitialCapital
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.InitialCapital | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a7fe9d27000feb1119ef98ccf43138bb5)DailyExpense
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.DailyExpense | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#a17b9e32817d9a64559b7b557fa03557c)WarehouseCapacity
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.WarehouseCapacity | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#aa714a824ecb5a170c8039d91df67452e)DefaultWorkshopCountInSettlement
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.DefaultWorkshopCountInSettlement | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html#adb133497327c26d2d6a2d04f462842a7)MaximumWorkshopsPlayerCanHave
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel.MaximumWorkshopsPlayerCanHave | | getabstract |


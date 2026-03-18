--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetEffectiveConversionSpeedOfProduction](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#abc403cc23b8d0c864b2937535ef89be6) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, float speed, bool includeDescription) |
| override int | [GetMaxWorkshopCountForClanTier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#ae2e7254e28ed7c83f6e6f6064e1289dd) (int tier) |
| override int | [GetCostForPlayer](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a8b0c688ad8d551054628b5feaf4e5ba7) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| override int | [GetCostForNotable](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a9e244091c7884d32f1f8b33837350c46) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetNotableOwnerForWorkshop](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a741f0f2f6f3ec48dab634d2a162c467e) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| override int | [GetConvertProductionCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a715f9a1d2927073d4b8dabdc31526281) ([WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html) workshopType) |
| override bool | [CanPlayerSellWorkshop](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a80d5018e51de616882045c4f9387c021) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| override float | [GetTradeXpPerWarehouseProduction](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a38d2c43ebc660aef745fbdd8fe56cec1) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) production) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html) | |
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
| override int | [WarehouseCapacity](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a202707544be650da624536c3a727d6b2) `[get]` |
| override int | [DaysForPlayerSaveWorkshopFromBankruptcy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#ad608dac7ad49063a11f0281e745d1825) `[get]` |
| override int | [CapitalLowLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a71a6f8e31904f2aff4b5b94816ebcfc9) `[get]` |
| override int | [InitialCapital](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a8d29c3f178612b169bb1e4dfa2e2dce2) `[get]` |
| override int | [DailyExpense](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#aafd24d731844bb2b61513080911fa407) `[get]` |
| override int | [DefaultWorkshopCountInSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a3184eddbfef0ca5fec948cea7fc0ad83) `[get]` |
| override int | [MaximumWorkshopsPlayerCanHave](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a00db337e476f674dc1972cefbeba0c2b) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.WorkshopModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_workshop_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#abc403cc23b8d0c864b2937535ef89be6)GetEffectiveConversionSpeedOfProduction()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.GetEffectiveConversionSpeedOfProduction | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, |
|  |  | float | *speed*, |
|  |  | bool | *includeDescription* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#ae2e7254e28ed7c83f6e6f6064e1289dd)GetMaxWorkshopCountForClanTier()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.GetMaxWorkshopCountForClanTier | ( | int | *tier* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a8b0c688ad8d551054628b5feaf4e5ba7)GetCostForPlayer()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.GetCostForPlayer | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a9e244091c7884d32f1f8b33837350c46)GetCostForNotable()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.GetCostForNotable | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a741f0f2f6f3ec48dab634d2a162c467e)GetNotableOwnerForWorkshop()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.GetNotableOwnerForWorkshop | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a715f9a1d2927073d4b8dabdc31526281)GetConvertProductionCost()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.GetConvertProductionCost | ( | [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html) | *workshopType* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a80d5018e51de616882045c4f9387c021)CanPlayerSellWorkshop()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.CanPlayerSellWorkshop | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a38d2c43ebc660aef745fbdd8fe56cec1)GetTradeXpPerWarehouseProduction()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.GetTradeXpPerWarehouseProduction | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *production* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a202707544be650da624536c3a727d6b2)WarehouseCapacity
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.WarehouseCapacity | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#ad608dac7ad49063a11f0281e745d1825)DaysForPlayerSaveWorkshopFromBankruptcy
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.DaysForPlayerSaveWorkshopFromBankruptcy | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a71a6f8e31904f2aff4b5b94816ebcfc9)CapitalLowLimit
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.CapitalLowLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a8d29c3f178612b169bb1e4dfa2e2dce2)InitialCapital
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.InitialCapital | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#aafd24d731844bb2b61513080911fa407)DailyExpense
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.DailyExpense | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a3184eddbfef0ca5fec948cea7fc0ad83)DefaultWorkshopCountInSettlement
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.DefaultWorkshopCountInSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_workshop_model.html#a00db337e476f674dc1972cefbeba0c2b)MaximumWorkshopsPlayerCanHave
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultWorkshopModel.MaximumWorkshopsPlayerCanHave | | get |


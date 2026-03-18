--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.INonReadyObjectHandler](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_non_ready_object_handler.html).

|  |  |
| --- | --- |
| Classes | |
| class | [CraftingCampaignBehaviorTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior_1_1_640fefbab2de9f2b0a4a9429ce77c2bc.html) |
| class | [CraftingOrderSlots](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior_1_1_crafting_order_slots.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a69219c299c6a80a352372feabc5c7c8c) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a3b4e0ea5fb050d4a0de062e3cf6c9e75) () |
| bool | [IsOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a94dd624d1fd2da8931eaeda0232fe23c) ([CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) craftingPiece, [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) craftingTemplate) |
| int | [GetCraftingDifficulty](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#ac6297dfa915d0c10479ba134e1edd382) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign) |
| void | [OnSessionLaunched](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a7ed46bf24c8bd349bc818348d5e48b51) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| int | [GetHeroCraftingStamina](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#af821ff389555ee1d1029fb3969b148ca) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [SetHeroCraftingStamina](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a97f8447facd828e2dfc24a1fcfaaeff9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int value) |
| void | [SetCraftedWeaponName](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a4b7fc249b6390ef42ae29a56e1b98048) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedWeaponItem, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name) |
| int | [GetMaxHeroCraftingStamina](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#aefea41b8c90309ac441bebbad2e71d60) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [DoRefinement](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a2c882175f2e6724942ab124942bd648b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, Crafting.RefiningFormula refineFormula) |
| void | [DoSmelting](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a33de5035022d022a1e5f930446cb00e8) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) currentCraftingHero, [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) equipmentElement) |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [CreateCraftedWeaponInFreeBuildMode](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a37df55b07bd96bca5510dacd55d3cf0c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign, [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) weaponModifier=null) |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [CreateCraftedWeaponInCraftingOrderMode](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a7ab1e278661c8353cd078c49f2a1c8e3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) crafterHero, [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) craftingOrder, [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetActiveCraftingHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#acc487921619a9ed7598312a58edc3d93) () |
| void | [SetActiveCraftingHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a398e2dea906ee498d17e8bd9f765addc) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [CreateTownOrder](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#af9d6e135b66af8a36f8a583f7289c3ba) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) orderOwner, int orderSlot) |
| [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | [CreateCustomOrderForHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a12d8aaf5d20041063d76a53fea03ab75) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) orderOwner, float orderDifficulty=-1.0f, [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign=null, [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) craftingTemplate=null) |
| void | [GetOrderResult](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a5609bff78a3bdf119335bbea57aa6c4f) ([CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) craftingOrder, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedItem, out bool isSucceed, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) orderRemark, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) orderResult, out int finalReward) |
| void | [CompleteOrder](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#aa2dea1566f6477e6ab22a2ca11d23dd7) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) craftingOrder, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedItem, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) completerHero) |
| [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | [GetCurrentItemModifier](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a4ef39e59ff3246eb85fd91e7da9ecea7) () |
| void | [SetCurrentItemModifier](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#ae08926362234165ee0f477bd1f91f8a0) ([ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) modifier) |
| void | [CancelCustomOrder](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a87b827d41898359c33d2039bbdb8a4d1) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) craftingOrder) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Properties | |
| IReadOnlyDictionary< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [CraftingOrderSlots](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior_1_1_crafting_order_slots.html) > | [CraftingOrders](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#af10d71a6a4797c7190a88c5e63ba3fc3) `[get]` |
| IReadOnlyCollection< [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) > | [CraftingHistory](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a7a3dd0dd79aa22a915f53967e6422574) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a69219c299c6a80a352372feabc5c7c8c)SyncData()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a3b4e0ea5fb050d4a0de062e3cf6c9e75)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a94dd624d1fd2da8931eaeda0232fe23c)IsOpened()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.IsOpened | ( | [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) | *craftingPiece*, |
|  |  | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | *craftingTemplate* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#af507bc2c9470392b346012be59e8d1be).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#ac6297dfa915d0c10479ba134e1edd382)GetCraftingDifficulty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.GetCraftingDifficulty | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a450b41a67e73498ec5dae3a9d405b52a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a7ed46bf24c8bd349bc818348d5e48b51)OnSessionLaunched()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.OnSessionLaunched | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#af821ff389555ee1d1029fb3969b148ca)GetHeroCraftingStamina()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.GetHeroCraftingStamina | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#ac64e55e9896e0375e18d22c10d1a9541).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a97f8447facd828e2dfc24a1fcfaaeff9)SetHeroCraftingStamina()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.SetHeroCraftingStamina | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | int | *value* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a23db4c4dc915038384e8a7ce66027a32).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a4b7fc249b6390ef42ae29a56e1b98048)SetCraftedWeaponName()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.SetCraftedWeaponName | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedWeaponItem*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a420c11a18933219c3b3d7905c56fed2f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#aefea41b8c90309ac441bebbad2e71d60)GetMaxHeroCraftingStamina()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.GetMaxHeroCraftingStamina | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a6902a3a9a21d73529a76c450cab9e886).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a2c882175f2e6724942ab124942bd648b)DoRefinement()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.DoRefinement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | Crafting.RefiningFormula | *refineFormula* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#abbcb9be8cac3e94c0971f2d64e5f92a3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a33de5035022d022a1e5f930446cb00e8)DoSmelting()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.DoSmelting | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *currentCraftingHero*, |
|  |  | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *equipmentElement* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a8a543c5d6e78fafc31b5fe2e257cbdb0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a37df55b07bd96bca5510dacd55d3cf0c)CreateCraftedWeaponInFreeBuildMode()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.CreateCraftedWeaponInFreeBuildMode | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign*, |
|  |  | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *weaponModifier* = null ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a6a08ed9c539f34f8865f72209f46b2be).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a7ab1e278661c8353cd078c49f2a1c8e3)CreateCraftedWeaponInCraftingOrderMode()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.CreateCraftedWeaponInCraftingOrderMode | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *crafterHero*, |
|  |  | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | *craftingOrder*, |
|  |  | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a2f8affebd8777f594743fb2f2c30eb18).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#acc487921619a9ed7598312a58edc3d93)GetActiveCraftingHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.GetActiveCraftingHero | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a1c612c696ec6eb8d8ea71fb164768005).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a398e2dea906ee498d17e8bd9f765addc)SetActiveCraftingHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.SetActiveCraftingHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#ab46658aaf7bc913daef447e73c885919).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#af9d6e135b66af8a36f8a583f7289c3ba)CreateTownOrder()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.CreateTownOrder | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *orderOwner*, |
|  |  | int | *orderSlot* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a12d8aaf5d20041063d76a53fea03ab75)CreateCustomOrderForHero()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.CreateCustomOrderForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *orderOwner*, |
|  |  | float | *orderDifficulty* = -1::0f, |
|  |  | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign* = null, |
|  |  | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | *craftingTemplate* = null ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a1a71f52a3b696ce7d3226c5f8a5d6462).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a5609bff78a3bdf119335bbea57aa6c4f)GetOrderResult()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.GetOrderResult | ( | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | *craftingOrder*, |
|  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedItem*, |
|  |  | out bool | *isSucceed*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *orderRemark*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *orderResult*, |
|  |  | out int | *finalReward* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a8481875a721cb21bc5c1c7ff48f196b3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#aa2dea1566f6477e6ab22a2ca11d23dd7)CompleteOrder()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.CompleteOrder | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | *craftingOrder*, |
|  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedItem*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *completerHero* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#aea794f31ab47f056fe0588f96b73906a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a4ef39e59ff3246eb85fd91e7da9ecea7)GetCurrentItemModifier()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.GetCurrentItemModifier | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#aff768ad85d4058dc6c840fd31039ea81).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#ae08926362234165ee0f477bd1f91f8a0)SetCurrentItemModifier()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.SetCurrentItemModifier | ( | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *modifier* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a8e2af7c88d7f467c2799c07595c819d0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a87b827d41898359c33d2039bbdb8a4d1)CancelCustomOrder()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.CancelCustomOrder | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | *craftingOrder* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#afd88a4335a99930ab842913f3b32035e).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#af10d71a6a4797c7190a88c5e63ba3fc3)CraftingOrders
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyDictionary<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [CraftingOrderSlots](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior_1_1_crafting_order_slots.html)> TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.CraftingOrders | | get |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a13550b0ac04f5bfd5f43cd7ab19372a9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a7a3dd0dd79aa22a915f53967e6422574)CraftingHistory
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyCollection<[WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html)> TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior.CraftingHistory | | get |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#acdf9769eebe24717b924ec181a7cca90).


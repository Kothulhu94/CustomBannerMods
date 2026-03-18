--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior Interface ReferenceInherits [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html).

Inherited by [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [CompleteOrder](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#aea794f31ab47f056fe0588f96b73906a) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) craftingOrder, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedItem, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) completerHero) |
| [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | [GetCurrentItemModifier](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#aff768ad85d4058dc6c840fd31039ea81) () |
| void | [SetCurrentItemModifier](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a8e2af7c88d7f467c2799c07595c819d0) ([ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) modifier) |
| void | [SetCraftedWeaponName](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a420c11a18933219c3b3d7905c56fed2f) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedWeaponItem, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name) |
| void | [GetOrderResult](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a8481875a721cb21bc5c1c7ff48f196b3) ([CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) craftingOrder, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedItem, out bool isSucceed, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) orderRemark, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) orderResult, out int finalPrice) |
| int | [GetCraftingDifficulty](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a450b41a67e73498ec5dae3a9d405b52a) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign) |
| int | [GetHeroCraftingStamina](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#ac64e55e9896e0375e18d22c10d1a9541) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [SetHeroCraftingStamina](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a23db4c4dc915038384e8a7ce66027a32) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int value) |
| int | [GetMaxHeroCraftingStamina](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a6902a3a9a21d73529a76c450cab9e886) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [DoRefinement](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#abbcb9be8cac3e94c0971f2d64e5f92a3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, Crafting.RefiningFormula refineFormula) |
| void | [DoSmelting](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a8a543c5d6e78fafc31b5fe2e257cbdb0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) currentCraftingHero, [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) equipmentElement) |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [CreateCraftedWeaponInFreeBuildMode](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a6a08ed9c539f34f8865f72209f46b2be) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign, [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) weaponModifier=null) |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [CreateCraftedWeaponInCraftingOrderMode](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a2f8affebd8777f594743fb2f2c30eb18) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) crafterHero, [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) craftingOrder, [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign) |
| bool | [IsOpened](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#af507bc2c9470392b346012be59e8d1be) ([CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) craftingPiece, [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) craftingTemplate) |
| [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | [CreateCustomOrderForHero](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a1a71f52a3b696ce7d3226c5f8a5d6462) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) orderOwner, float orderDifficulty=-1.0f, [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign=null, [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) craftingTemplate=null) |
| void | [CancelCustomOrder](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#afd88a4335a99930ab842913f3b32035e) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) craftingOrder) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetActiveCraftingHero](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a1c612c696ec6eb8d8ea71fb164768005) () |
| void | [SetActiveCraftingHero](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#ab46658aaf7bc913daef447e73c885919) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html) | |
| void | [RegisterEvents](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522) () |

|  |  |
| --- | --- |
| Properties | |
| IReadOnlyDictionary< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [CraftingCampaignBehavior.CraftingOrderSlots](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior_1_1_crafting_order_slots.html) > | [CraftingOrders](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a13550b0ac04f5bfd5f43cd7ab19372a9) `[get]` |
| IReadOnlyCollection< [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) > | [CraftingHistory](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#acdf9769eebe24717b924ec181a7cca90) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#aea794f31ab47f056fe0588f96b73906a)CompleteOrder()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.CompleteOrder | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | *craftingOrder*, |
|  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedItem*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *completerHero* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#aa2dea1566f6477e6ab22a2ca11d23dd7).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#aff768ad85d4058dc6c840fd31039ea81)GetCurrentItemModifier()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.GetCurrentItemModifier | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a4ef39e59ff3246eb85fd91e7da9ecea7).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a8e2af7c88d7f467c2799c07595c819d0)SetCurrentItemModifier()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.SetCurrentItemModifier | ( | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *modifier* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#ae08926362234165ee0f477bd1f91f8a0).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a420c11a18933219c3b3d7905c56fed2f)SetCraftedWeaponName()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.SetCraftedWeaponName | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedWeaponItem*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a4b7fc249b6390ef42ae29a56e1b98048).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a8481875a721cb21bc5c1c7ff48f196b3)GetOrderResult()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.GetOrderResult | ( | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | *craftingOrder*, |
|  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedItem*, |
|  |  | out bool | *isSucceed*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *orderRemark*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *orderResult*, |
|  |  | out int | *finalPrice* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a5609bff78a3bdf119335bbea57aa6c4f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a450b41a67e73498ec5dae3a9d405b52a)GetCraftingDifficulty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.GetCraftingDifficulty | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#ac6297dfa915d0c10479ba134e1edd382).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#ac64e55e9896e0375e18d22c10d1a9541)GetHeroCraftingStamina()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.GetHeroCraftingStamina | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#af821ff389555ee1d1029fb3969b148ca).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a23db4c4dc915038384e8a7ce66027a32)SetHeroCraftingStamina()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.SetHeroCraftingStamina | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | int | *value* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a97f8447facd828e2dfc24a1fcfaaeff9).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a6902a3a9a21d73529a76c450cab9e886)GetMaxHeroCraftingStamina()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.GetMaxHeroCraftingStamina | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#aefea41b8c90309ac441bebbad2e71d60).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#abbcb9be8cac3e94c0971f2d64e5f92a3)DoRefinement()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.DoRefinement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | Crafting.RefiningFormula | *refineFormula* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a2c882175f2e6724942ab124942bd648b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a8a543c5d6e78fafc31b5fe2e257cbdb0)DoSmelting()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.DoSmelting | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *currentCraftingHero*, |
|  |  | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *equipmentElement* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a33de5035022d022a1e5f930446cb00e8).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a6a08ed9c539f34f8865f72209f46b2be)CreateCraftedWeaponInFreeBuildMode()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.CreateCraftedWeaponInFreeBuildMode | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign*, |
|  |  | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *weaponModifier* = null ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a37df55b07bd96bca5510dacd55d3cf0c).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a2f8affebd8777f594743fb2f2c30eb18)CreateCraftedWeaponInCraftingOrderMode()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.CreateCraftedWeaponInCraftingOrderMode | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *crafterHero*, |
|  |  | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | *craftingOrder*, |
|  |  | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a7ab1e278661c8353cd078c49f2a1c8e3).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#af507bc2c9470392b346012be59e8d1be)IsOpened()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.IsOpened | ( | [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) | *craftingPiece*, |
|  |  | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | *craftingTemplate* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a94dd624d1fd2da8931eaeda0232fe23c).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a1a71f52a3b696ce7d3226c5f8a5d6462)CreateCustomOrderForHero()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.CreateCustomOrderForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *orderOwner*, |
|  |  | float | *orderDifficulty* = -1.0f, |
|  |  | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign* = null, |
|  |  | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | *craftingTemplate* = null ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a12d8aaf5d20041063d76a53fea03ab75).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#afd88a4335a99930ab842913f3b32035e)CancelCustomOrder()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.CancelCustomOrder | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | *craftingOrder* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a87b827d41898359c33d2039bbdb8a4d1).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a1c612c696ec6eb8d8ea71fb164768005)GetActiveCraftingHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.GetActiveCraftingHero | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#acc487921619a9ed7598312a58edc3d93).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#ab46658aaf7bc913daef447e73c885919)SetActiveCraftingHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.SetActiveCraftingHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a398e2dea906ee498d17e8bd9f765addc).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#a13550b0ac04f5bfd5f43cd7ab19372a9)CraftingOrders
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyDictionary<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [CraftingCampaignBehavior.CraftingOrderSlots](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior_1_1_crafting_order_slots.html)> TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.CraftingOrders | | get |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#af10d71a6a4797c7190a88c5e63ba3fc3).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html#acdf9769eebe24717b924ec181a7cca90)CraftingHistory
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyCollection<[WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html)> TaleWorlds.CampaignSystem.CampaignBehaviors.ICraftingCampaignBehavior.CraftingHistory | | get |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CraftingCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crafting_campaign_behavior.html#a7a3dd0dd79aa22a915f53967e6422574).


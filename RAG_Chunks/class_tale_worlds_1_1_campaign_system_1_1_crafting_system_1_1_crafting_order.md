--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html ---

TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder Class ReferenceInherits [TaleWorlds.CampaignSystem.ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#afb03d9e83e8e67809bb6c1924f5d18fc) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) orderOwner, float orderDifficulty, [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesignTemplate, [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) template, int difficultyLevel=-1, string customId=null) |
| void | [InitializeCraftingOrderOnLoad](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a74afb4d4d93bc84c82fa6acee2e3e25f) () |
| bool | [IsPreCraftedWeaponDesignValid](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a2f1698ebdf1cd582724489ca008354f1) () |
| [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | [GetStatWeapon](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#ab46c0468ffe4cd98926e1b47e05ac8e9) () |
| bool | [IsOrderAvailableForHero](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a7528dd6bae9df0ab20d4310baa8be5c0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| bool | [CanHeroCompleteOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a3f9a11f2d39b12f58e12e80f7718672f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftDesignItem) |
| float | [GetOrderExperience](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a2f6541a8043283c3809ea587a1bf16ab) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedItem, [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) itemModifier) |
| void | [CheckForBonusesAndPenalties](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#ac2066aa958ecdf7a6b76aadae1b67bf3) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedItem, [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) itemModifier, out float craftedStatsSum, out float requiredStatsSum, out bool thrustDamageCheck, out bool swingDamageCheck) |
| List< [CraftingStatData](struct_tale_worlds_1_1_core_1_1_crafting_stat_data.html) > | [GetStatDataForItem](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#ad79c9ba89edcb0343c3c864c52fdfff3) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, out [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly int | [BaseGoldReward](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a04f0a37b02e26f042dfe7e12e9a8ac2d) |
| readonly float | [OrderDifficulty](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a175d69560c609556c858c738103de431) |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [PreCraftedWeaponDesignItem](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a01216e2dcbcf1e37d2f49009f4a8eab4) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [OrderOwner](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a1bc0ca9b39ffcc672cb08c73b72dbea0) |
| readonly int | [DifficultyLevel](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a99ae39ac0792f1e3f44201404f1aee04) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsLordOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a8dc12a975cc8cb0a11fd6de8e191d7e0) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a1540fb1e920dc9c8caac3bd7b0ca3fee) `[get]` |
| [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | [WeaponDesignTemplate](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#abc844b46b06ca8e1b32390b755304870) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#afb03d9e83e8e67809bb6c1924f5d18fc)CraftingOrder()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.CraftingOrder | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *orderOwner*, |
|  |  | float | *orderDifficulty*, |
|  |  | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesignTemplate*, |
|  |  | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | *template*, |
|  |  | int | *difficultyLevel* = -1, |
|  |  | string | *customId* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a74afb4d4d93bc84c82fa6acee2e3e25f)InitializeCraftingOrderOnLoad()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.InitializeCraftingOrderOnLoad | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a2f1698ebdf1cd582724489ca008354f1)IsPreCraftedWeaponDesignValid()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.IsPreCraftedWeaponDesignValid | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#ab46c0468ffe4cd98926e1b47e05ac8e9)GetStatWeapon()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.GetStatWeapon | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a7528dd6bae9df0ab20d4310baa8be5c0)IsOrderAvailableForHero()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.IsOrderAvailableForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a3f9a11f2d39b12f58e12e80f7718672f)CanHeroCompleteOrder()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.CanHeroCompleteOrder | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftDesignItem* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a2f6541a8043283c3809ea587a1bf16ab)GetOrderExperience()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.GetOrderExperience | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedItem*, |
|  |  | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *itemModifier* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#ac2066aa958ecdf7a6b76aadae1b67bf3)CheckForBonusesAndPenalties()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.CheckForBonusesAndPenalties | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedItem*, |
|  |  | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *itemModifier*, |
|  |  | out float | *craftedStatsSum*, |
|  |  | out float | *requiredStatsSum*, |
|  |  | out bool | *thrustDamageCheck*, |
|  |  | out bool | *swingDamageCheck* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#ad79c9ba89edcb0343c3c864c52fdfff3)GetStatDataForItem()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [CraftingStatData](struct_tale_worlds_1_1_core_1_1_crafting_stat_data.html) > TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.GetStatDataForItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, |
|  |  | out [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a04f0a37b02e26f042dfe7e12e9a8ac2d)BaseGoldReward
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.BaseGoldReward |

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a175d69560c609556c858c738103de431)OrderDifficulty
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.OrderDifficulty |

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a01216e2dcbcf1e37d2f49009f4a8eab4)PreCraftedWeaponDesignItem
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.PreCraftedWeaponDesignItem |

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a1bc0ca9b39ffcc672cb08c73b72dbea0)OrderOwner
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.OrderOwner |

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a99ae39ac0792f1e3f44201404f1aee04)DifficultyLevel
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.DifficultyLevel |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a8dc12a975cc8cb0a11fd6de8e191d7e0)IsLordOrder
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.IsLordOrder | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#a1540fb1e920dc9c8caac3bd7b0ca3fee)IsReady
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.IsReady | | get |

Implements [TaleWorlds.CampaignSystem.ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html#a69166dbcedc127fea26c01d2428d01d7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html#abc844b46b06ca8e1b32390b755304870)WeaponDesignTemplate
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) TaleWorlds.CampaignSystem.CraftingSystem.CraftingOrder.WeaponDesignTemplate | | get |


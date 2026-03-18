--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetCraftingPartDifficulty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#af37c09e944827f0cc619ec8007032d8c) ([CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) craftingPiece) |
| int | [CalculateWeaponDesignDifficulty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#afcf61a2a5cf6cd4a9be78200df08e819) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign) |
| [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | [GetCraftedWeaponModifier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a09ea5be528de8be5a9dab04c2820dfc4) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) weaponsmith) |
| IEnumerable< Crafting.RefiningFormula > | [GetRefiningFormulas](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#aab348f485733451e1ead8df3b38176ff) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) weaponsmith) |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetCraftingMaterialItem](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a731b31c12e4f402b5f69d5155f035ac0) ([CraftingMaterials](namespace_tale_worlds_1_1_core.html#ac393a05bb383e95156b22888e4e23795) craftingMaterial) |
| int[] | [GetSmeltingOutputForItem](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a406eac7c85c02cd5cfff80d9cacab211) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| int | [GetSkillXpForRefining](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a82e8587c493f747689d4bf39dfbc79aa) (ref Crafting.RefiningFormula refineFormula) |
| int | [GetSkillXpForSmelting](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#acd2932337892b0b5a089974494f62187) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| int | [GetSkillXpForSmithingInFreeBuildMode](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a666798f9e55e84ac9fea02b7bb79e1e5) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| int | [GetSkillXpForSmithingInCraftingOrderMode](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#ae8ed4b2d55671590317f9c9d3967330d) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| int[] | [GetSmithingCostsForWeaponDesign](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a0d3bd78236426ca4a5c330da9d03754d) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign) |
| int | [GetEnergyCostForRefining](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#aba8887156fd87dc9c2a399e750d8b3ed) (ref Crafting.RefiningFormula refineFormula, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| int | [GetEnergyCostForSmithing](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a7cbe5527b84bee7c0f0fc017feac7cfe) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| int | [GetEnergyCostForSmelting](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#aa8117cf1c3c75786dce7fc15ed837963) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| float | [ResearchPointsNeedForNewPart](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#af504bab05d4102c195db85554ae837ef) (int totalPartCount, int openedPartCount) |
| int | [GetPartResearchGainForSmeltingItem](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#abe87df6728a3313d15bc8e6dc41fa1aa) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| int | [GetPartResearchGainForSmithingItem](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#ad61feb6491d9573670a7449db6d74f67) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool isFreeBuildMode) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#af37c09e944827f0cc619ec8007032d8c)GetCraftingPartDifficulty()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetCraftingPartDifficulty | ( | [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) | *craftingPiece* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#afcf61a2a5cf6cd4a9be78200df08e819)CalculateWeaponDesignDifficulty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.CalculateWeaponDesignDifficulty | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a09ea5be528de8be5a9dab04c2820dfc4)GetCraftedWeaponModifier()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetCraftedWeaponModifier | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *weaponsmith* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#aab348f485733451e1ead8df3b38176ff)GetRefiningFormulas()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< Crafting.RefiningFormula > TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetRefiningFormulas | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *weaponsmith* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a731b31c12e4f402b5f69d5155f035ac0)GetCraftingMaterialItem()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetCraftingMaterialItem | ( | [CraftingMaterials](namespace_tale_worlds_1_1_core.html#ac393a05bb383e95156b22888e4e23795) | *craftingMaterial* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a406eac7c85c02cd5cfff80d9cacab211)GetSmeltingOutputForItem()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int[] TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetSmeltingOutputForItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a82e8587c493f747689d4bf39dfbc79aa)GetSkillXpForRefining()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetSkillXpForRefining | ( | ref Crafting.RefiningFormula | *refineFormula* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#acd2932337892b0b5a089974494f62187)GetSkillXpForSmelting()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetSkillXpForSmelting | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a666798f9e55e84ac9fea02b7bb79e1e5)GetSkillXpForSmithingInFreeBuildMode()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetSkillXpForSmithingInFreeBuildMode | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#ae8ed4b2d55671590317f9c9d3967330d)GetSkillXpForSmithingInCraftingOrderMode()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetSkillXpForSmithingInCraftingOrderMode | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a0d3bd78236426ca4a5c330da9d03754d)GetSmithingCostsForWeaponDesign()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int[] TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetSmithingCostsForWeaponDesign | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#aba8887156fd87dc9c2a399e750d8b3ed)GetEnergyCostForRefining()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetEnergyCostForRefining | ( | ref Crafting.RefiningFormula | *refineFormula*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#a7cbe5527b84bee7c0f0fc017feac7cfe)GetEnergyCostForSmithing()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetEnergyCostForSmithing | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#aa8117cf1c3c75786dce7fc15ed837963)GetEnergyCostForSmelting()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetEnergyCostForSmelting | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#af504bab05d4102c195db85554ae837ef)ResearchPointsNeedForNewPart()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.ResearchPointsNeedForNewPart | ( | int | *totalPartCount*, | |  |  | int | *openedPartCount* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#abe87df6728a3313d15bc8e6dc41fa1aa)GetPartResearchGainForSmeltingItem()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetPartResearchGainForSmeltingItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html#ad61feb6491d9573670a7449db6d74f67)GetPartResearchGainForSmithingItem()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel.GetPartResearchGainForSmithingItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *isFreeBuildMode* ) | | abstract |


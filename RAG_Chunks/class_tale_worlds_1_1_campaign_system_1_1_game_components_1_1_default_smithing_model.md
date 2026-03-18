--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetCraftingPartDifficulty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a49653c0cdd01d18aba428bfc74327da1) ([CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) craftingPiece) |
| override int | [CalculateWeaponDesignDifficulty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#ab6bc3adcd9738e683c96fcc61ff6cc7f) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign) |
| override [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | [GetCraftedWeaponModifier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a1acc072bf9edd345ff981e582fbe3f4a) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override IEnumerable< Crafting.RefiningFormula > | [GetRefiningFormulas](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#abf36f1cffd912c40ef46fa66b2e9b7eb) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) weaponsmith) |
| override int | [GetSkillXpForRefining](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a4b42482b5412aa6af687b61b700ab4be) (ref Crafting.RefiningFormula refineFormula) |
| override int | [GetSkillXpForSmelting](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a4ca4fc57944ede058f09287aecb7f928) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| override int | [GetSkillXpForSmithingInFreeBuildMode](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a5f76de6d861b25a353bb854265bf0a48) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| override int | [GetSkillXpForSmithingInCraftingOrderMode](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a7fdb96c2bc4efe7b09618b3969992029) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| override int | [GetEnergyCostForRefining](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a2dd59ef8f8c5e26b88bbf11b60337132) (ref Crafting.RefiningFormula refineFormula, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetEnergyCostForSmithing](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#af6db7ea0d1459752926ec622f6e8f0fa) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetEnergyCostForSmelting](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a43c101e92ffa89058393f2b8d4c7435b) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetCraftingMaterialItem](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#af1fd81aa09b4c497379f5f97c5a7a081) ([CraftingMaterials](namespace_tale_worlds_1_1_core.html#ac393a05bb383e95156b22888e4e23795) craftingMaterial) |
| override int[] | [GetSmeltingOutputForItem](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a05aad504b60e24ed1ba9cca6a069cd9b) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| override int[] | [GetSmithingCostsForWeaponDesign](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a83438248e556e2adcb4738e5075e0cee) ([WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) weaponDesign) |
| override float | [ResearchPointsNeedForNewPart](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#ae809545ba85c70dc2c0d362c71d79bc5) (int totalPartCount, int openedPartCount) |
| override int | [GetPartResearchGainForSmeltingItem](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#ad2cc51104753eb672681d264ae39049a) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetPartResearchGainForSmithingItem](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a153672fbfe29bf627211858dfe213271) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool isFreeBuild) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SmithingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_smithing_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a49653c0cdd01d18aba428bfc74327da1)GetCraftingPartDifficulty()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetCraftingPartDifficulty | ( | [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) | *craftingPiece* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#ab6bc3adcd9738e683c96fcc61ff6cc7f)CalculateWeaponDesignDifficulty()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.CalculateWeaponDesignDifficulty | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a1acc072bf9edd345ff981e582fbe3f4a)GetCraftedWeaponModifier()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetCraftedWeaponModifier | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#abf36f1cffd912c40ef46fa66b2e9b7eb)GetRefiningFormulas()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override IEnumerable< Crafting.RefiningFormula > TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetRefiningFormulas | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *weaponsmith* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a4b42482b5412aa6af687b61b700ab4be)GetSkillXpForRefining()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetSkillXpForRefining | ( | ref Crafting.RefiningFormula | *refineFormula* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a4ca4fc57944ede058f09287aecb7f928)GetSkillXpForSmelting()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetSkillXpForSmelting | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a5f76de6d861b25a353bb854265bf0a48)GetSkillXpForSmithingInFreeBuildMode()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetSkillXpForSmithingInFreeBuildMode | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a7fdb96c2bc4efe7b09618b3969992029)GetSkillXpForSmithingInCraftingOrderMode()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetSkillXpForSmithingInCraftingOrderMode | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a2dd59ef8f8c5e26b88bbf11b60337132)GetEnergyCostForRefining()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetEnergyCostForRefining | ( | ref Crafting.RefiningFormula | *refineFormula*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#af6db7ea0d1459752926ec622f6e8f0fa)GetEnergyCostForSmithing()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetEnergyCostForSmithing | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a43c101e92ffa89058393f2b8d4c7435b)GetEnergyCostForSmelting()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetEnergyCostForSmelting | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#af1fd81aa09b4c497379f5f97c5a7a081)GetCraftingMaterialItem()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetCraftingMaterialItem | ( | [CraftingMaterials](namespace_tale_worlds_1_1_core.html#ac393a05bb383e95156b22888e4e23795) | *craftingMaterial* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a05aad504b60e24ed1ba9cca6a069cd9b)GetSmeltingOutputForItem()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int[] TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetSmeltingOutputForItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a83438248e556e2adcb4738e5075e0cee)GetSmithingCostsForWeaponDesign()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int[] TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetSmithingCostsForWeaponDesign | ( | [WeaponDesign](class_tale_worlds_1_1_core_1_1_weapon_design.html) | *weaponDesign* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#ae809545ba85c70dc2c0d362c71d79bc5)ResearchPointsNeedForNewPart()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.ResearchPointsNeedForNewPart | ( | int | *totalPartCount*, |
|  |  | int | *openedPartCount* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#ad2cc51104753eb672681d264ae39049a)GetPartResearchGainForSmeltingItem()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetPartResearchGainForSmeltingItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_smithing_model.html#a153672fbfe29bf627211858dfe213271)GetPartResearchGainForSmithingItem()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSmithingModel.GetPartResearchGainForSmithingItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | bool | *isFreeBuild* ) |


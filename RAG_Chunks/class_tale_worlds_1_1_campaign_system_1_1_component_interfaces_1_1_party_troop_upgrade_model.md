--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTroopUpgradeModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultPartyTroopUpgradeModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_troop_upgrade_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [CanPartyUpgradeTroopToTarget](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#a327ec2e1008525af704a84dc17001cce) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) target) |
| bool | [IsTroopUpgradeable](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#a0d971f2fa9a5332722882c86bea344d7) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| bool | [DoesPartyHaveRequiredItemsForUpgrade](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#a79e49a500dda7bb340b6589bea80113a) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) upgradeTarget) |
| bool | [DoesPartyHaveRequiredPerksForUpgrade](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#a6fc60f1a8b5e21e3fe13370d5af3d442) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) upgradeTarget, out [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) requiredPerk) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetGoldCostForUpgrade](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#a7b9ab27a9cc38ce3499b2bf15d68066a) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) characterObject, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) upgradeTarget) |
| int | [GetXpCostForUpgrade](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#a8972b2e65cc1cd4d90d05f04783cb8f3) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) characterObject, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) upgradeTarget) |
| int | [GetSkillXpFromUpgradingTroops](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#aa36f64a297c104c1bf58b92f970d532e) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int numberOfTroops) |
| float | [GetUpgradeChanceForTroopUpgrade](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#ad7276a19d737da8424e19dc980ce05b8) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int upgradeTargetIndex) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#a327ec2e1008525af704a84dc17001cce)CanPartyUpgradeTroopToTarget()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTroopUpgradeModel.CanPartyUpgradeTroopToTarget | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *target* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#a0d971f2fa9a5332722882c86bea344d7)IsTroopUpgradeable()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTroopUpgradeModel.IsTroopUpgradeable | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#a79e49a500dda7bb340b6589bea80113a)DoesPartyHaveRequiredItemsForUpgrade()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTroopUpgradeModel.DoesPartyHaveRequiredItemsForUpgrade | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *upgradeTarget* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#a6fc60f1a8b5e21e3fe13370d5af3d442)DoesPartyHaveRequiredPerksForUpgrade()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTroopUpgradeModel.DoesPartyHaveRequiredPerksForUpgrade | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *upgradeTarget*, | |  |  | out [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *requiredPerk* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#a7b9ab27a9cc38ce3499b2bf15d68066a)GetGoldCostForUpgrade()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTroopUpgradeModel.GetGoldCostForUpgrade | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *characterObject*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *upgradeTarget* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#a8972b2e65cc1cd4d90d05f04783cb8f3)GetXpCostForUpgrade()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTroopUpgradeModel.GetXpCostForUpgrade | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *characterObject*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *upgradeTarget* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#aa36f64a297c104c1bf58b92f970d532e)GetSkillXpFromUpgradingTroops()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTroopUpgradeModel.GetSkillXpFromUpgradingTroops | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, | |  |  | int | *numberOfTroops* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_troop_upgrade_model.html#ad7276a19d737da8424e19dc980ce05b8)GetUpgradeChanceForTroopUpgrade()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTroopUpgradeModel.GetUpgradeChanceForTroopUpgrade | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, | |  |  | int | *upgradeTargetIndex* ) | | abstract |


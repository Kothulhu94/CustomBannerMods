--- SOURCE: class_helpers_1_1_party_base_helper.html ---

Helpers.PartyBaseHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SortRoster](class_helpers_1_1_party_base_helper.html#ac5710ce2f3da0255246cdda073ee73fd) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetPartySizeText](class_helpers_1_1_party_base_helper.html#a2e73a654e56fb69a72ae95e60fb5180d) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetPartySizeText](class_helpers_1_1_party_base_helper.html#a9d2a37f35fac4b20f377d9b51d2162da) (int healtyNumber, int woundedNumber, bool isInspected) |
| static string | [GetShipSizeText](class_helpers_1_1_party_base_helper.html#a82d4fca40f63c6706a7008c42a46f57a) (int shipCount, bool isInspected) |
| static float | [FindPartySizeNormalLimit](class_helpers_1_1_party_base_helper.html#a324d8cfbe2ce951b4aa5201bdf37e919) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetCaptainOfTroop](class_helpers_1_1_party_base_helper.html#a9a526f6c829847cbfd09fb7ff8b2f17f) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) affectorParty, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) affectorCharacter) |
| static string | [PrintRosterContents](class_helpers_1_1_party_base_helper.html#a88a0b9a999dd03dfdee76f824e598b89) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) roster) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [PrintSummarisedItemRoster](class_helpers_1_1_party_base_helper.html#aef6f0b32e840b509e2a535a1d1e103f7) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) items) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [PrintRegularTroopCategories](class_helpers_1_1_party_base_helper.html#aff74c86a2b9722dde4fb8218fa2f52a4) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) roster) |
| static [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GetVisualPartyLeader](class_helpers_1_1_party_base_helper.html#a01c84bbea9edf059e73f9d76a5d86d65) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| static int | [GetSpeedLimitation](class_helpers_1_1_party_base_helper.html#a8cbd63454bfe6ebfde63f9137ea223da) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) partyItemRoster, out [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) speedLimitationItem) |
| static bool | [HasFeat](class_helpers_1_1_party_base_helper.html#ae24bb0ad5459e14f0590948586ee4330) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html) feat) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_party_base_helper.html#ac5710ce2f3da0255246cdda073ee73fd)SortRoster()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.PartyBaseHelper.SortRoster | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | static |

[◆](class_helpers_1_1_party_base_helper.html#a2e73a654e56fb69a72ae95e60fb5180d)GetPartySizeText() [1/2]
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.PartyBaseHelper.GetPartySizeText | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | static |

[◆](class_helpers_1_1_party_base_helper.html#a9d2a37f35fac4b20f377d9b51d2162da)GetPartySizeText() [2/2]
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.PartyBaseHelper.GetPartySizeText | ( | int | *healtyNumber*, | |  |  | int | *woundedNumber*, | |  |  | bool | *isInspected* ) | | static |

[◆](class_helpers_1_1_party_base_helper.html#a82d4fca40f63c6706a7008c42a46f57a)GetShipSizeText()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string Helpers.PartyBaseHelper.GetShipSizeText | ( | int | *shipCount*, | |  |  | bool | *isInspected* ) | | static |

[◆](class_helpers_1_1_party_base_helper.html#a324d8cfbe2ce951b4aa5201bdf37e919)FindPartySizeNormalLimit()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float Helpers.PartyBaseHelper.FindPartySizeNormalLimit | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | static |

[◆](class_helpers_1_1_party_base_helper.html#a9a526f6c829847cbfd09fb7ff8b2f17f)GetCaptainOfTroop()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) Helpers.PartyBaseHelper.GetCaptainOfTroop | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *affectorParty*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *affectorCharacter* ) | | static |

[◆](class_helpers_1_1_party_base_helper.html#a88a0b9a999dd03dfdee76f824e598b89)PrintRosterContents()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string Helpers.PartyBaseHelper.PrintRosterContents | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *roster* | ) |  | | static |

[◆](class_helpers_1_1_party_base_helper.html#aef6f0b32e840b509e2a535a1d1e103f7)PrintSummarisedItemRoster()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.PartyBaseHelper.PrintSummarisedItemRoster | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *items* | ) |  | | static |

[◆](class_helpers_1_1_party_base_helper.html#aff74c86a2b9722dde4fb8218fa2f52a4)PrintRegularTroopCategories()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.PartyBaseHelper.PrintRegularTroopCategories | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *roster* | ) |  | | static |

[◆](class_helpers_1_1_party_base_helper.html#a01c84bbea9edf059e73f9d76a5d86d65)GetVisualPartyLeader()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) Helpers.PartyBaseHelper.GetVisualPartyLeader | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | static |

[◆](class_helpers_1_1_party_base_helper.html#a8cbd63454bfe6ebfde63f9137ea223da)GetSpeedLimitation()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int Helpers.PartyBaseHelper.GetSpeedLimitation | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *partyItemRoster*, | |  |  | out [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *speedLimitationItem* ) | | static |

[◆](class_helpers_1_1_party_base_helper.html#ae24bb0ad5459e14f0590948586ee4330)HasFeat()
----------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.PartyBaseHelper.HasFeat | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html) | *feat* ) | | static |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html ---

TaleWorlds.CampaignSystem.Actions.TeleportHeroAction Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [TeleportationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90) {     [ImmediateTeleportToSettlement](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90a48b60b53c28b5d152b642aaecb640995) ,     [ImmediateTeleportToParty](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90af021706f6d117f846a5f2501b7d52bd7) ,     [ImmediateTeleportToPartyAsPartyLeader](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90a5ef98efc0f324e1d86c49b4705f229b8) ,     [DelayedTeleportToSettlement](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90a7f211de1fb66414bee52c39d6e851e22) ,     [DelayedTeleportToParty](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90ae948fa8c55a05696d924c21fda4c1953) ,     [DelayedTeleportToSettlementAsGovernor](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90aa030fd7e468fc90a979d3b1b2a03af27) ,     [DelayedTeleportToPartyAsPartyLeader](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90aae4b6a928e2e27bd2d04cf9537b9300b)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [ApplyImmediateTeleportToSettlement](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#a37a497f6e3cdd7e44001879fcbfd2171) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) heroToBeMoved, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement) |
| static void | [ApplyImmediateTeleportToParty](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#af65ad6ba669ab507676db01d4c33b10b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) heroToBeMoved, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| static void | [ApplyImmediateTeleportToPartyAsPartyLeader](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#a761ceb029d9a818f1e4d08dd9ad5f1c8) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) heroToBeMoved, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| static void | [ApplyDelayedTeleportToSettlement](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#a391b136257294a1ec30003ea14d32545) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) heroToBeMoved, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement) |
| static void | [ApplyDelayedTeleportToParty](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#a855355871aa9358369f3e768fc7dc64e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) heroToBeMoved, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| static void | [ApplyDelayedTeleportToSettlementAsGovernor](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#a293b95a85f22e0a2252771f9fb116d62) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) heroToBeMoved, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement) |
| static void | [ApplyDelayedTeleportToPartyAsPartyLeader](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#a3493505123f49f6fac16bc576221df79) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) heroToBeMoved, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90)TeleportationDetail
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Actions.TeleportHeroAction.TeleportationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90) |

| Enumerator | |
| --- | --- |
| ImmediateTeleportToSettlement |  |
| ImmediateTeleportToParty |  |
| ImmediateTeleportToPartyAsPartyLeader |  |
| DelayedTeleportToSettlement |  |
| DelayedTeleportToParty |  |
| DelayedTeleportToSettlementAsGovernor |  |
| DelayedTeleportToPartyAsPartyLeader |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#a37a497f6e3cdd7e44001879fcbfd2171)ApplyImmediateTeleportToSettlement()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.TeleportHeroAction.ApplyImmediateTeleportToSettlement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *heroToBeMoved*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#af65ad6ba669ab507676db01d4c33b10b)ApplyImmediateTeleportToParty()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.TeleportHeroAction.ApplyImmediateTeleportToParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *heroToBeMoved*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#a761ceb029d9a818f1e4d08dd9ad5f1c8)ApplyImmediateTeleportToPartyAsPartyLeader()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.TeleportHeroAction.ApplyImmediateTeleportToPartyAsPartyLeader | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *heroToBeMoved*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#a391b136257294a1ec30003ea14d32545)ApplyDelayedTeleportToSettlement()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.TeleportHeroAction.ApplyDelayedTeleportToSettlement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *heroToBeMoved*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#a855355871aa9358369f3e768fc7dc64e)ApplyDelayedTeleportToParty()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.TeleportHeroAction.ApplyDelayedTeleportToParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *heroToBeMoved*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#a293b95a85f22e0a2252771f9fb116d62)ApplyDelayedTeleportToSettlementAsGovernor()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.TeleportHeroAction.ApplyDelayedTeleportToSettlementAsGovernor | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *heroToBeMoved*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#a3493505123f49f6fac16bc576221df79)ApplyDelayedTeleportToPartyAsPartyLeader()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.TeleportHeroAction.ApplyDelayedTeleportToPartyAsPartyLeader | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *heroToBeMoved*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) | | static |


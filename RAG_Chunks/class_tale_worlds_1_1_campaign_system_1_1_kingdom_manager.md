--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html ---

TaleWorlds.CampaignSystem.KingdomManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnSessionStart](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a6957fa79ac827e6b1d84d90b27437d84) () |
| void | [CreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a670339251c9f6b0f9ac7f8683186e1be) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) kingdomName, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) informalName, [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) founderClan, MBReadOnlyList< [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) > initialPolicies=null, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) encyclopediaText=null, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) encyclopediaTitle=null, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) encyclopediaRulerTitle=null) |
| void | [AbdicateTheThrone](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a98f1dcea0c095c9cea27407c6c0896cf) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
|  | Demotes ruler clan to vassal or if no other clan exists removes clan from kingdom and destroys the kingdom. |
| void | [RaidCompleted](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a724e214259fcf9de96a94a892b985f51) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html) raidEvent) |
| void | [SiegeCompleted](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a0957bd815917879ebf56db3b737fe236) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) capturerParty, bool isWin, BattleTypes battleType) |
| void | [RelinquishSettlementOwnership](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a2a480ac1d5fb73a3ed7c680cd7e8d114) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
|  | Starts a claimant decision for the settlement excluding current owner(relinquishing clan) as an option. |
| void | [GiftSettlementOwnership](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a0eae205524ae3fd9d99b74f1472944be) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) receiverClan) |
|  | Transfers ownership of settlement to receiverClan and applies a relationship bonus. Intended to be called for settlements owned by the faction leader. |
| IEnumerable< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > | [GetEligibleClansForSettlementOwnershipGift](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a65ee3b1b7b6de1c51d8b85a8be135ffe) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| int | [GetMercenaryWageAmount](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a808fe48173f63aa37f55e262446d8cb5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [PlayerMercenaryServiceNextRenewalDay](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a27ee78ddf46bfa23c5ad0a79f048f48e) = -1.0f |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [PrisonerLordRansomOffered](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a68d504099105c63cec009483d442279c) |
| [MBCampaignEvent](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html) | [QuarterHourlyTickEvent](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#aa228a1b3faed0a22abae10770e25e3fb) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a6957fa79ac827e6b1d84d90b27437d84)OnSessionStart()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.KingdomManager.OnSessionStart | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a670339251c9f6b0f9ac7f8683186e1be)CreateKingdom()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.KingdomManager.CreateKingdom | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *kingdomName*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *informalName*, |
|  |  | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *founderClan*, |
|  |  | MBReadOnlyList< [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) > | *initialPolicies* = null, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *encyclopediaText* = null, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *encyclopediaTitle* = null, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *encyclopediaRulerTitle* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a98f1dcea0c095c9cea27407c6c0896cf)AbdicateTheThrone()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.KingdomManager.AbdicateTheThrone | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a724e214259fcf9de96a94a892b985f51)RaidCompleted()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.KingdomManager.RaidCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, |
|  |  | [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html) | *raidEvent* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a0957bd815917879ebf56db3b737fe236)SiegeCompleted()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.KingdomManager.SiegeCompleted | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *capturerParty*, |
|  |  | bool | *isWin*, |
|  |  | BattleTypes | *battleType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a2a480ac1d5fb73a3ed7c680cd7e8d114)RelinquishSettlementOwnership()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.KingdomManager.RelinquishSettlementOwnership | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a0eae205524ae3fd9d99b74f1472944be)GiftSettlementOwnership()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.KingdomManager.GiftSettlementOwnership | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *receiverClan* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a65ee3b1b7b6de1c51d8b85a8be135ffe)GetEligibleClansForSettlementOwnershipGift()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > TaleWorlds.CampaignSystem.KingdomManager.GetEligibleClansForSettlementOwnershipGift | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a808fe48173f63aa37f55e262446d8cb5)GetMercenaryWageAmount()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.KingdomManager.GetMercenaryWageAmount | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a27ee78ddf46bfa23c5ad0a79f048f48e)PlayerMercenaryServiceNextRenewalDay
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.KingdomManager.PlayerMercenaryServiceNextRenewalDay = -1.0f |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#a68d504099105c63cec009483d442279c)PrisonerLordRansomOffered
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.KingdomManager.PrisonerLordRansomOffered |

[◆](class_tale_worlds_1_1_campaign_system_1_1_kingdom_manager.html#aa228a1b3faed0a22abae10770e25e3fb)QuarterHourlyTickEvent
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MBCampaignEvent](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html) TaleWorlds.CampaignSystem.KingdomManager.QuarterHourlyTickEvent |


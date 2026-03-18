--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [CalculateInitialRenown](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a0c750af2e5ba17e0dc8aefa7fe535596) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| int | [CalculateInitialInfluence](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#af928ebd367d5a827f661f8e376210e11) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| int | [CalculateTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a56876b389327f4da0f7885a79a958909) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| bool | [HasUpcomingTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a64f97f3839106162bcff9248d7cf4487) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) extraExplanation, bool includeDescriptions=false) |
| int | [GetRequiredRenownForTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#af96f3e392dc67cd17167383d2455f66a) (int tier) |
| int | [GetPartyLimitForTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#aac32f5dd66edbe73c42328068ecdd770) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, int clanTierToCheck) |
| int | [GetCompanionLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a614d93d013408f625a370f82d7fb6a4e) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Public Attributes | |
|  | [ExplainedNumber](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a81fd2d4fc1314741d4ffdc3d9b6ead09) |

|  |  |
| --- | --- |
| Properties | |
| int | [MinClanTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a50e09f2bf8c00810bea14e551aa6852d) `[get]` |
| int | [MaxClanTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a7bb59bd538e7f8dd7940635e7dad9d78) `[get]` |
| int | [MercenaryEligibleTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a7b0e86397108213fa0cd1dff9999730c) `[get]` |
| int | [VassalEligibleTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#aaebd6d49ddbb955048620da73556d0ef) `[get]` |
| int | [BannerEligibleTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a9f83bf0fba1fb41e0f21e8701b187544) `[get]` |
| int | [RebelClanStartingTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a7797a57df469b63e59c681f76edf8d5c) `[get]` |
| int | [CompanionToLordClanStartingTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a4ed87f608452ea207928fe3a95b4f39d) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a0c750af2e5ba17e0dc8aefa7fe535596)CalculateInitialRenown()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.CalculateInitialRenown | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#af928ebd367d5a827f661f8e376210e11)CalculateInitialInfluence()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.CalculateInitialInfluence | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a56876b389327f4da0f7885a79a958909)CalculateTier()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.CalculateTier | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a64f97f3839106162bcff9248d7cf4487)HasUpcomingTier()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.HasUpcomingTier | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *extraExplanation*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#af96f3e392dc67cd17167383d2455f66a)GetRequiredRenownForTier()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.GetRequiredRenownForTier | ( | int | *tier* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#aac32f5dd66edbe73c42328068ecdd770)GetPartyLimitForTier()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.GetPartyLimitForTier | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | int | *clanTierToCheck* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a614d93d013408f625a370f82d7fb6a4e)GetCompanionLimit()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.GetCompanionLimit | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | abstract |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a81fd2d4fc1314741d4ffdc3d9b6ead09)ExplainedNumber
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.ExplainedNumber | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a50e09f2bf8c00810bea14e551aa6852d)MinClanTier
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.MinClanTier | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a7bb59bd538e7f8dd7940635e7dad9d78)MaxClanTier
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.MaxClanTier | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a7b0e86397108213fa0cd1dff9999730c)MercenaryEligibleTier
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.MercenaryEligibleTier | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#aaebd6d49ddbb955048620da73556d0ef)VassalEligibleTier
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.VassalEligibleTier | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a9f83bf0fba1fb41e0f21e8701b187544)BannerEligibleTier
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.BannerEligibleTier | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a7797a57df469b63e59c681f76edf8d5c)RebelClanStartingTier
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.RebelClanStartingTier | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a4ed87f608452ea207928fe3a95b4f39d)CompanionToLordClanStartingTier
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel.CompanionToLordClanStartingTier | | getabstract |


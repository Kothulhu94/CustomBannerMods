--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int | [CalculateInitialRenown](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#acea66ef23eb17a0eabc1946c710f424b) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int | [CalculateInitialInfluence](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc9be03ba63fb6bcec7ca5312d245706) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int | [CalculateTier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#a475f562b146db674187e6fd2c50dcaab) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
|  | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) ([ExplainedNumber](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a81fd2d4fc1314741d4ffdc3d9b6ead09), bool) [HasUpcomingTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a64f97f3839106162bcff9248d7cf4487)([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html) | |
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
| Properties | |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int | [MinClanTier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#ac192ab903e1bbf6235a4dcc1f1e9301a) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int | [MaxClanTier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#a952fc24256e2d3c4b23010111a91eae1) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int | [MercenaryEligibleTier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#a2790dd9534958da873f0bc9155246bc2) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int | [VassalEligibleTier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#a9d2b599de08dd0d79a62f99ec3151b39) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int | [BannerEligibleTier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#a3b37db7f33f231c7dc6a6a06c9f186cb) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int | [RebelClanStartingTier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#ac326f64af05556cd79b13e7a395fe8fa) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int | [CompanionToLordClanStartingTier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adf61e117cccb7d3155e133e4369cddf7) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html) | |
| int | [MinClanTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a50e09f2bf8c00810bea14e551aa6852d) `[get]` |
| int | [MaxClanTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a7bb59bd538e7f8dd7940635e7dad9d78) `[get]` |
| int | [MercenaryEligibleTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a7b0e86397108213fa0cd1dff9999730c) `[get]` |
| int | [VassalEligibleTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#aaebd6d49ddbb955048620da73556d0ef) `[get]` |
| int | [BannerEligibleTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a9f83bf0fba1fb41e0f21e8701b187544) `[get]` |
| int | [RebelClanStartingTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a7797a57df469b63e59c681f76edf8d5c) `[get]` |
| int | [CompanionToLordClanStartingTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a4ed87f608452ea207928fe3a95b4f39d) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.ClanTierModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html) | |
|  | [ExplainedNumber](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a81fd2d4fc1314741d4ffdc3d9b6ead09) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#acea66ef23eb17a0eabc1946c710f424b)CalculateInitialRenown()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel.CalculateInitialRenown | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc9be03ba63fb6bcec7ca5312d245706)CalculateInitialInfluence()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel.CalculateInitialInfluence | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#a475f562b146db674187e6fd2c50dcaab)CalculateTier()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel.CalculateTier | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9)override()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel.override | ( | [ExplainedNumber](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_clan_tier_model.html#a81fd2d4fc1314741d4ffdc3d9b6ead09) | , |
|  |  | bool | ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#ac192ab903e1bbf6235a4dcc1f1e9301a)MinClanTier
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel.MinClanTier | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#a952fc24256e2d3c4b23010111a91eae1)MaxClanTier
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel.MaxClanTier | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#a2790dd9534958da873f0bc9155246bc2)MercenaryEligibleTier
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel.MercenaryEligibleTier | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#a9d2b599de08dd0d79a62f99ec3151b39)VassalEligibleTier
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel.VassalEligibleTier | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#a3b37db7f33f231c7dc6a6a06c9f186cb)BannerEligibleTier
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel.BannerEligibleTier | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#ac326f64af05556cd79b13e7a395fe8fa)RebelClanStartingTier
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel.RebelClanStartingTier | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adf61e117cccb7d3155e133e4369cddf7)CompanionToLordClanStartingTier
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_tier_model.html#adc070fad783f8e6ff3c35045325f88e9) int TaleWorlds.CampaignSystem.GameComponents.DefaultClanTierModel.CompanionToLordClanStartingTier | | get |


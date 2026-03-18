--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.CrimeModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultCrimeModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_crime_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [PaymentMethod](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a7105e869b243780361f71f936cf2cbdb) : UInt32 {     [ExMachina](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a7105e869b243780361f71f936cf2cbdbad29151c08ab5082ff97724d480415407) = 0x1000 ,     [Gold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a7105e869b243780361f71f936cf2cbdba9768feb3fdb1f267b06093bc572952dd) = 0x0001 ,     [Influence](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a7105e869b243780361f71f936cf2cbdbad35a98028cca23c2a745a0bba43a90ff) = 0x0002 ,     [Punishment](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a7105e869b243780361f71f936cf2cbdba41c35d18284ada22dab797c410a118b8) = 0x0004 ,     [Execution](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a7105e869b243780361f71f936cf2cbdba8f44785c8c19412c5b6611db30984514) = 0x0008   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetMaxCrimeRating](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a336561b21e8d1f0dc36ab5a03e22b608) () |
| float | [GetMinAcceptableCrimeRating](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a33f15f3ae7de05a38c607f3308c1b5e6) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| float | [GetCrimeRatingAfterPunishment](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a71aa11d9f8d22688bc874aaff2a3e95e) () |
| bool | [DoesPlayerHaveAnyCrimeRating](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a95f2b1f00aa9fc1b4d4b17d13e73559b) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| bool | [IsPlayerCrimeRatingSevere](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a37831262a70c0587e886870ca4505260) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| bool | [IsPlayerCrimeRatingModerate](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a317a47a4cd1f2ea5648dd3b5ec6e6ff0) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| bool | [IsPlayerCrimeRatingMild](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a87563fd023f496691bb64309b4451aa0) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| float | [GetCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a6b05c7702cb0107faedf184686ffdf59) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, [PaymentMethod](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a7105e869b243780361f71f936cf2cbdb) paymentMethod, float minimumCrimeRating) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetDailyCrimeRatingChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a6b139aef9528e7b536bfe1075a73d8d9) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, bool includeDescriptions=false) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| float | [DeclareWarCrimeRatingThreshold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a1853716243327a9f68bad957943f85a7) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a7105e869b243780361f71f936cf2cbdb)PaymentMethod
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ComponentInterfaces.CrimeModel.PaymentMethod](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a7105e869b243780361f71f936cf2cbdb) : UInt32 |

| Enumerator | |
| --- | --- |
| ExMachina |  |
| Gold |  |
| Influence |  |
| Punishment |  |
| Execution |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a336561b21e8d1f0dc36ab5a03e22b608)GetMaxCrimeRating()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.CrimeModel.GetMaxCrimeRating | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a33f15f3ae7de05a38c607f3308c1b5e6)GetMinAcceptableCrimeRating()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.CrimeModel.GetMinAcceptableCrimeRating | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a71aa11d9f8d22688bc874aaff2a3e95e)GetCrimeRatingAfterPunishment()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.CrimeModel.GetCrimeRatingAfterPunishment | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a95f2b1f00aa9fc1b4d4b17d13e73559b)DoesPlayerHaveAnyCrimeRating()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.CrimeModel.DoesPlayerHaveAnyCrimeRating | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a37831262a70c0587e886870ca4505260)IsPlayerCrimeRatingSevere()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.CrimeModel.IsPlayerCrimeRatingSevere | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a317a47a4cd1f2ea5648dd3b5ec6e6ff0)IsPlayerCrimeRatingModerate()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.CrimeModel.IsPlayerCrimeRatingModerate | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a87563fd023f496691bb64309b4451aa0)IsPlayerCrimeRatingMild()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.CrimeModel.IsPlayerCrimeRatingMild | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a6b05c7702cb0107faedf184686ffdf59)GetCost()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.CrimeModel.GetCost | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, | |  |  | [PaymentMethod](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a7105e869b243780361f71f936cf2cbdb) | *paymentMethod*, | |  |  | float | *minimumCrimeRating* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a6b139aef9528e7b536bfe1075a73d8d9)GetDailyCrimeRatingChange()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.CrimeModel.GetDailyCrimeRatingChange | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_crime_model.html#a1853716243327a9f68bad957943f85a7)DeclareWarCrimeRatingThreshold
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.CrimeModel.DeclareWarCrimeRatingThreshold | | getabstract |


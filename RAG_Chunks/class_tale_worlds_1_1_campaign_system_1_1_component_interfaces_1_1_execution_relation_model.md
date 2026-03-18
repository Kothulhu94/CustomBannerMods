--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.ExecutionRelationModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultExecutionRelationModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_execution_relation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetRelationChangeForExecutingHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#a22f0ca9f29eae1aeb64921d2eb94a3c1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, out bool showQuickNotification) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [HeroKillingHeroClanRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#adfabfe258b377c9ac1597bcfc4d72f1f) `[get]` |
| int | [HeroKillingHeroFriendRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#acb06fa30e7c5d93763d8531f3a5e9eb5) `[get]` |
| int | [PlayerExecutingHeroFactionRelationPenaltyDishonorable](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#a4d3c11b7f268266597eaa254faf54b9d) `[get]` |
| int | [PlayerExecutingHeroClanRelationPenaltyDishonorable](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#a252182ec683ee2fb0bfd4f6208a898d8) `[get]` |
| int | [PlayerExecutingHeroFriendRelationPenaltyDishonorable](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#a4350d56b472185dd51fb26780e06a2f8) `[get]` |
| int | [PlayerExecutingHeroHonorPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#ad0968ba5d0061b466dc136f3617e035c) `[get]` |
| int | [PlayerExecutingHeroFactionRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#ad0fa9c393ba54b46c2bda44b99bacd9f) `[get]` |
| int | [PlayerExecutingHeroHonorableNobleRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#ae244adc2ba489830941c324ebfbebe5e) `[get]` |
| int | [PlayerExecutingHeroClanRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#a71f8ffc34774ae61ccbe83639b633a6b) `[get]` |
| int | [PlayerExecutingHeroFriendRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#a2d7e6a3e2015453c6cc3170cffc7e867) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#a22f0ca9f29eae1aeb64921d2eb94a3c1)GetRelationChangeForExecutingHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ExecutionRelationModel.GetRelationChangeForExecutingHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | out bool | *showQuickNotification* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#adfabfe258b377c9ac1597bcfc4d72f1f)HeroKillingHeroClanRelationPenalty
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ExecutionRelationModel.HeroKillingHeroClanRelationPenalty | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#acb06fa30e7c5d93763d8531f3a5e9eb5)HeroKillingHeroFriendRelationPenalty
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ExecutionRelationModel.HeroKillingHeroFriendRelationPenalty | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#a4d3c11b7f268266597eaa254faf54b9d)PlayerExecutingHeroFactionRelationPenaltyDishonorable
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ExecutionRelationModel.PlayerExecutingHeroFactionRelationPenaltyDishonorable | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#a252182ec683ee2fb0bfd4f6208a898d8)PlayerExecutingHeroClanRelationPenaltyDishonorable
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ExecutionRelationModel.PlayerExecutingHeroClanRelationPenaltyDishonorable | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#a4350d56b472185dd51fb26780e06a2f8)PlayerExecutingHeroFriendRelationPenaltyDishonorable
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ExecutionRelationModel.PlayerExecutingHeroFriendRelationPenaltyDishonorable | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#ad0968ba5d0061b466dc136f3617e035c)PlayerExecutingHeroHonorPenalty
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ExecutionRelationModel.PlayerExecutingHeroHonorPenalty | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#ad0fa9c393ba54b46c2bda44b99bacd9f)PlayerExecutingHeroFactionRelationPenalty
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ExecutionRelationModel.PlayerExecutingHeroFactionRelationPenalty | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#ae244adc2ba489830941c324ebfbebe5e)PlayerExecutingHeroHonorableNobleRelationPenalty
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ExecutionRelationModel.PlayerExecutingHeroHonorableNobleRelationPenalty | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#a71f8ffc34774ae61ccbe83639b633a6b)PlayerExecutingHeroClanRelationPenalty
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ExecutionRelationModel.PlayerExecutingHeroClanRelationPenalty | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_execution_relation_model.html#a2d7e6a3e2015453c6cc3170cffc7e867)PlayerExecutingHeroFriendRelationPenalty
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ExecutionRelationModel.PlayerExecutingHeroFriendRelationPenalty | | getabstract |


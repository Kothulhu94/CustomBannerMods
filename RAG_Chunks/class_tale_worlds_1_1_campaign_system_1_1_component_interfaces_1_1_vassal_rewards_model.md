--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_vassal_rewards_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.VassalRewardsModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultVassalRewardsModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_vassal_rewards_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [GetTroopRewardsForJoiningKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_vassal_rewards_model.html#a1768bd08abc78537938abb1d2fc374a3) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | [GetEquipmentRewardsForJoiningKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_vassal_rewards_model.html#a714674af8775012f8055660674e2a413) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| float | [InfluenceReward](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_vassal_rewards_model.html#ad4763e6c58019e281fb48ce282d9f9da) `[get]` |
| int | [RelationRewardWithLeader](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_vassal_rewards_model.html#a658b861895451f28a3b973b653464864) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_vassal_rewards_model.html#a1768bd08abc78537938abb1d2fc374a3)GetTroopRewardsForJoiningKingdom()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.ComponentInterfaces.VassalRewardsModel.GetTroopRewardsForJoiningKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_vassal_rewards_model.html#a714674af8775012f8055660674e2a413)GetEquipmentRewardsForJoiningKingdom()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) TaleWorlds.CampaignSystem.ComponentInterfaces.VassalRewardsModel.GetEquipmentRewardsForJoiningKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_vassal_rewards_model.html#ad4763e6c58019e281fb48ce282d9f9da)InfluenceReward
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.VassalRewardsModel.InfluenceReward | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_vassal_rewards_model.html#a658b861895451f28a3b973b653464864)RelationRewardWithLeader
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.VassalRewardsModel.RelationRewardWithLeader | | getabstract |


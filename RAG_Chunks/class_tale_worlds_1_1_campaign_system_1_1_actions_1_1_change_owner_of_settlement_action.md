--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html ---

TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfSettlementAction Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [ChangeOwnerOfSettlementDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a193cf304dd7d1be8ca6d1af4009bc622) {     [Default](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a193cf304dd7d1be8ca6d1af4009bc622a7a1920d61156abc05a60135aefe8bc67) ,     [BySiege](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a193cf304dd7d1be8ca6d1af4009bc622a3ecd087a1f02330604e7140dfcc192de) ,     [ByBarter](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a193cf304dd7d1be8ca6d1af4009bc622a900a25d4506e3d0bf5ffbc236af0e50a) ,     [ByLeaveFaction](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a193cf304dd7d1be8ca6d1af4009bc622ad1079fd5c1af914d6ae193d1d2bd6367) ,     [ByKingDecision](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a193cf304dd7d1be8ca6d1af4009bc622ae5200ad852445e2ade5f8ebbfecc4fe5) ,     [ByGift](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a193cf304dd7d1be8ca6d1af4009bc622a37ffc43ed9daedd0af149e5ebc2906f2) ,     [ByRebellion](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a193cf304dd7d1be8ca6d1af4009bc622a698a2480118147e519033e96426e9989) ,     [ByClanDestruction](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a193cf304dd7d1be8ca6d1af4009bc622a894528c469a9c72ee3e9c2a2c01a24e7)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [ApplyByDefault](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#ad82bb207261eff75e6129ddde912110b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| static void | [ApplyByKingDecision](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#ab1381e9707f950d52468b430b960046b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| static void | [ApplyBySiege](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a548c3424bb781ad920ed2652a4c7b38b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) capturerHero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| static void | [ApplyByLeaveFaction](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a5084dd30c142d00281e4bf7193ffd55f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| static void | [ApplyByBarter](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a2702f8c09f6b862f9f84e67c436cd136) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| static void | [ApplyByRebellion](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a7c099d01a9cace6d8f8cbd1e93e66e93) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| static void | [ApplyByDestroyClan](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#af91fa856914719d08ed7b6a0e07a961c) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner) |
| static void | [ApplyByGift](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a29ba2f7944c0e3fcb4b99b48d418be9e) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a193cf304dd7d1be8ca6d1af4009bc622)ChangeOwnerOfSettlementDetail
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a193cf304dd7d1be8ca6d1af4009bc622) |

| Enumerator | |
| --- | --- |
| Default |  |
| BySiege |  |
| ByBarter |  |
| ByLeaveFaction |  |
| ByKingDecision |  |
| ByGift |  |
| ByRebellion |  |
| ByClanDestruction |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#ad82bb207261eff75e6129ddde912110b)ApplyByDefault()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfSettlementAction.ApplyByDefault | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#ab1381e9707f950d52468b430b960046b)ApplyByKingDecision()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfSettlementAction.ApplyByKingDecision | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a548c3424bb781ad920ed2652a4c7b38b)ApplyBySiege()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfSettlementAction.ApplyBySiege | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *capturerHero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a5084dd30c142d00281e4bf7193ffd55f)ApplyByLeaveFaction()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfSettlementAction.ApplyByLeaveFaction | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a2702f8c09f6b862f9f84e67c436cd136)ApplyByBarter()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfSettlementAction.ApplyByBarter | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a7c099d01a9cace6d8f8cbd1e93e66e93)ApplyByRebellion()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfSettlementAction.ApplyByRebellion | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#af91fa856914719d08ed7b6a0e07a961c)ApplyByDestroyClan()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfSettlementAction.ApplyByDestroyClan | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_settlement_action.html#a29ba2f7944c0e3fcb4b99b48d418be9e)ApplyByGift()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfSettlementAction.ApplyByGift | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner* ) | | static |


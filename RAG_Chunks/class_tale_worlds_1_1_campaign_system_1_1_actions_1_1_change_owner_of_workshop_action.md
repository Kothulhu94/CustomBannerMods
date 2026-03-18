--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_workshop_action.html ---

TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfWorkshopAction Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [ApplyByBankruptcy](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_workshop_action.html#a569b3e194625d5294f5bfa4844629293) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html) workshopType, int cost) |
| static void | [ApplyByPlayerBuying](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_workshop_action.html#a35964c9b18daa4ed4c62d772b5ca84a8) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| static void | [ApplyByPlayerSelling](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_workshop_action.html#a29e35f9336434b5cc8f6fa68ed227a3d) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html) workshopType) |
| static void | [ApplyByDeath](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_workshop_action.html#aaf48e8b0034decbd2f5ef79074a62c91) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner) |
| static void | [ApplyByWar](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_workshop_action.html#af69b5bfb55abee772ba5213be32a67fa) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html) workshopType) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_workshop_action.html#a569b3e194625d5294f5bfa4844629293)ApplyByBankruptcy()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfWorkshopAction.ApplyByBankruptcy | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, | |  |  | [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html) | *workshopType*, | |  |  | int | *cost* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_workshop_action.html#a35964c9b18daa4ed4c62d772b5ca84a8)ApplyByPlayerBuying()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfWorkshopAction.ApplyByPlayerBuying | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_workshop_action.html#a29e35f9336434b5cc8f6fa68ed227a3d)ApplyByPlayerSelling()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfWorkshopAction.ApplyByPlayerSelling | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, | |  |  | [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html) | *workshopType* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_workshop_action.html#aaf48e8b0034decbd2f5ef79074a62c91)ApplyByDeath()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfWorkshopAction.ApplyByDeath | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_owner_of_workshop_action.html#af69b5bfb55abee772ba5213be32a67fa)ApplyByWar()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfWorkshopAction.ApplyByWar | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, | |  |  | [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop_type.html) | *workshopType* ) | | static |


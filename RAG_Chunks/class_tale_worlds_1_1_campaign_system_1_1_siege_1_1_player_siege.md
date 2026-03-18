--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html ---

TaleWorlds.CampaignSystem.Siege.PlayerSiege Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [StartSiegePreparation](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#a1812c11e777464f359d858d501374697) () |
| static void | [OnSiegeEventFinalized](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#a3955fe12474ce225856c05318e8d2997) (bool besiegerPartyDefeated) |
| static void | [StartPlayerSiege](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#ac393027957b1acf6b1b66bf01b78ef4b) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) playerSide, bool isSimulation=false, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement=null) |
| static void | [FinalizePlayerSiege](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#aca6e9b1487e2018bae805af0a9b78d44) () |
| static void | [StartSiegeMission](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#ab1b17431f2c521ff17e2fd947ac565c3) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement=null) |

|  |  |
| --- | --- |
| Properties | |
| static [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | [PlayerSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#a80498dd97b12599cdf530e1464beb964) `[get]` |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [BesiegedSettlement](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#a2e5ef6312bafc7cadc9ceaa7d9d821b0) `[get]` |
| static [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [PlayerSide](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#a2bc24fae61f8ef2991f1854832fd1dea) `[get]` |
| static bool | [IsRebellion](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#ab8026d470bc3874029867dcc113685cd) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#a1812c11e777464f359d858d501374697)StartSiegePreparation()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Siege.PlayerSiege.StartSiegePreparation | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#a3955fe12474ce225856c05318e8d2997)OnSiegeEventFinalized()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Siege.PlayerSiege.OnSiegeEventFinalized | ( | bool | *besiegerPartyDefeated* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#ac393027957b1acf6b1b66bf01b78ef4b)StartPlayerSiege()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Siege.PlayerSiege.StartPlayerSiege | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *playerSide*, | |  |  | bool | *isSimulation* = false, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* = null ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#aca6e9b1487e2018bae805af0a9b78d44)FinalizePlayerSiege()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Siege.PlayerSiege.FinalizePlayerSiege | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#ab1b17431f2c521ff17e2fd947ac565c3)StartSiegeMission()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Siege.PlayerSiege.StartSiegeMission | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* = null | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#a80498dd97b12599cdf530e1464beb964)PlayerSiegeEvent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) TaleWorlds.CampaignSystem.Siege.PlayerSiege.PlayerSiegeEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#a2e5ef6312bafc7cadc9ceaa7d9d821b0)BesiegedSettlement
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Siege.PlayerSiege.BesiegedSettlement | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#a2bc24fae61f8ef2991f1854832fd1dea)PlayerSide
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.Siege.PlayerSiege.PlayerSide | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_player_siege.html#ab8026d470bc3874029867dcc113685cd)IsRebellion
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Siege.PlayerSiege.IsRebellion | | staticget |


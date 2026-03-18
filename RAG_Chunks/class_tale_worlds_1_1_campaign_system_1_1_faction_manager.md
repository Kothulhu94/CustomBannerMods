--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html ---

TaleWorlds.CampaignSystem.FactionManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FactionManager](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#a66c51caea3cb5c4327307a61be7316d2) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [DeclareWar](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#a599d0ea87de4073ac14b4b09ff0450ac) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| static void | [SetNeutral](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#acfaa8b255b42fa240b6daf7573c0e35a) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| static bool | [IsAtWarAgainstFaction](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#a2f0e9b75b726d8072eab5cba8f2cf354) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| static bool | [IsAtConstantWarAgainstFaction](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#acd008796c7b35b55291a0ed9de11e494) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| static bool | [IsNeutralWithFaction](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#a045518bfc3a7234461ee8def315c0787) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| static int | [GetRelationBetweenClans](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#ab4abb1f5e589c1749ec85d0eb3d82e75) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan1, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan2) |

|  |  |
| --- | --- |
| Properties | |
| static [FactionManager](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#a66c51caea3cb5c4327307a61be7316d2) | [Instance](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#ab80ef4e24adef9834ae91e282e4a1d43) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#a66c51caea3cb5c4327307a61be7316d2)FactionManager()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.FactionManager.FactionManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#a599d0ea87de4073ac14b4b09ff0450ac)DeclareWar()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.FactionManager.DeclareWar | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#acfaa8b255b42fa240b6daf7573c0e35a)SetNeutral()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.FactionManager.SetNeutral | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#a2f0e9b75b726d8072eab5cba8f2cf354)IsAtWarAgainstFaction()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.FactionManager.IsAtWarAgainstFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#acd008796c7b35b55291a0ed9de11e494)IsAtConstantWarAgainstFaction()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.FactionManager.IsAtConstantWarAgainstFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#a045518bfc3a7234461ee8def315c0787)IsNeutralWithFaction()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.FactionManager.IsNeutralWithFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#ab4abb1f5e589c1749ec85d0eb3d82e75)GetRelationBetweenClans()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.FactionManager.GetRelationBetweenClans | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan1*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan2* ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#ab80ef4e24adef9834ae91e282e4a1d43)Instance
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FactionManager](class_tale_worlds_1_1_campaign_system_1_1_faction_manager.html#a66c51caea3cb5c4327307a61be7316d2) TaleWorlds.CampaignSystem.FactionManager.Instance | | staticget |


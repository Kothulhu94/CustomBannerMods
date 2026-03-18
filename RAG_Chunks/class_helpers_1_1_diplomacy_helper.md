--- SOURCE: class_helpers_1_1_diplomacy_helper.html ---

Helpers.DiplomacyHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [IsWarCausedByPlayer](class_helpers_1_1_diplomacy_helper.html#a7bd10cd3983da4fa806f7232ca31d811) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2, [DeclareWarAction.DeclareWarDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_declare_war_action.html#ae14e6aaf7e6ab22a1bd112b413124ce4) declareWarDetail) |
| static bool | [IsSameFactionAndNotEliminated](class_helpers_1_1_diplomacy_helper.html#a07692b847b944ea4a15cfb1782f9beb4) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| static List<([LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html), [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html))> | [GetLogsForWar](class_helpers_1_1_diplomacy_helper.html#a5ee557a854caa55d8ea046b4ae9d7fca) ([StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) stance) |
| static List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [GetPrisonersOfWarTakenByFaction](class_helpers_1_1_diplomacy_helper.html#a7ce2ba82e6924817c0ab3e1fbc1b0e1d) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) capturerFaction, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) prisonerFaction) |
| static bool | [DidMainHeroSwornNotToAttackFaction](class_helpers_1_1_diplomacy_helper.html#af3dbcec058c8a25037f9ccec8392c61a) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_diplomacy_helper.html#a7bd10cd3983da4fa806f7232ca31d811)IsWarCausedByPlayer()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.DiplomacyHelper.IsWarCausedByPlayer | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2*, | |  |  | [DeclareWarAction.DeclareWarDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_declare_war_action.html#ae14e6aaf7e6ab22a1bd112b413124ce4) | *declareWarDetail* ) | | static |

[◆](class_helpers_1_1_diplomacy_helper.html#a07692b847b944ea4a15cfb1782f9beb4)IsSameFactionAndNotEliminated()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.DiplomacyHelper.IsSameFactionAndNotEliminated | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) | | static |

[◆](class_helpers_1_1_diplomacy_helper.html#a5ee557a854caa55d8ea046b4ae9d7fca)GetLogsForWar()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List<([LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html), [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html))> Helpers.DiplomacyHelper.GetLogsForWar | ( | [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) | *stance* | ) |  | | static |

[◆](class_helpers_1_1_diplomacy_helper.html#a7ce2ba82e6924817c0ab3e1fbc1b0e1d)GetPrisonersOfWarTakenByFaction()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > Helpers.DiplomacyHelper.GetPrisonersOfWarTakenByFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *capturerFaction*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *prisonerFaction* ) | | static |

[◆](class_helpers_1_1_diplomacy_helper.html#af3dbcec058c8a25037f9ccec8392c61a)DidMainHeroSwornNotToAttackFaction()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.DiplomacyHelper.DidMainHeroSwornNotToAttackFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) | | static |


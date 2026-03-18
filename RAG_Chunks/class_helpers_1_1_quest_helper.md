--- SOURCE: class_helpers_1_1_quest_helper.html ---

Helpers.QuestHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [AddMapArrowFromPointToTarget](class_helpers_1_1_quest_helper.html#a1bd749b164489cbd91e59edf8a629f99) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) sourcePosition, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) targetPosition, float life, float error) |
| static bool | [CheckGoldForAlternativeSolution](class_helpers_1_1_quest_helper.html#a975928526f0e0a08448c4b3db94b9930) (int requiredGold, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| static List< [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) > | [GetAlternativeSolutionMeleeSkills](class_helpers_1_1_quest_helper.html#a4f3eb5e93736a9abb357c3dded7640b7) () |
| static bool | [CheckRosterForAlternativeSolution](class_helpers_1_1_quest_helper.html#ab3d36e0fbb660fef28befc2b34c7d59b) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troopRoster, int requiredTroopCount, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation, int minimumTier=0, bool mountedRequired=false) |
| static List< [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) > | [GetAlternativeSolutionRangedSkills](class_helpers_1_1_quest_helper.html#aaf6d2e67c26a130679895e9207d25eeb) () |
| static bool | [CheckMinorMajorCoercion](class_helpers_1_1_quest_helper.html#a95fb7d1342c6985766252ddbb753d653) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) questToCheck, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty) |
| static void | [ApplyGenericMinorMajorCoercionConsequences](class_helpers_1_1_quest_helper.html#aa7d58b6c10bb82479cdaab06abc5f99f) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| static int | [GetAveragePriceOfItemInTheWorld](class_helpers_1_1_quest_helper.html#aab11578a453f054e8aa9c9d82942c730) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| static void | [CheckWarDeclarationAndFailOrCancelTheQuest](class_helpers_1_1_quest_helper.html#a88ab3f5fa9610477d9a29ecfdb79348a) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) questToCheck, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2, [DeclareWarAction.DeclareWarDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_declare_war_action.html#ae14e6aaf7e6ab22a1bd112b413124ce4) detail, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) failLog, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) cancelLog, bool forceCancel=false) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_quest_helper.html#a1bd749b164489cbd91e59edf8a629f99)AddMapArrowFromPointToTarget()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.QuestHelper.AddMapArrowFromPointToTarget | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, | |  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *sourcePosition*, | |  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *targetPosition*, | |  |  | float | *life*, | |  |  | float | *error* ) | | static |

[◆](class_helpers_1_1_quest_helper.html#a975928526f0e0a08448c4b3db94b9930)CheckGoldForAlternativeSolution()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.QuestHelper.CheckGoldForAlternativeSolution | ( | int | *requiredGold*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) | | static |

[◆](class_helpers_1_1_quest_helper.html#a4f3eb5e93736a9abb357c3dded7640b7)GetAlternativeSolutionMeleeSkills()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | List< [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) > Helpers.QuestHelper.GetAlternativeSolutionMeleeSkills | ( |  | ) |  | | static |

[◆](class_helpers_1_1_quest_helper.html#ab3d36e0fbb660fef28befc2b34c7d59b)CheckRosterForAlternativeSolution()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.QuestHelper.CheckRosterForAlternativeSolution | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troopRoster*, | |  |  | int | *requiredTroopCount*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation*, | |  |  | int | *minimumTier* = 0, | |  |  | bool | *mountedRequired* = false ) | | static |

[◆](class_helpers_1_1_quest_helper.html#aaf6d2e67c26a130679895e9207d25eeb)GetAlternativeSolutionRangedSkills()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | List< [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) > Helpers.QuestHelper.GetAlternativeSolutionRangedSkills | ( |  | ) |  | | static |

[◆](class_helpers_1_1_quest_helper.html#a95fb7d1342c6985766252ddbb753d653)CheckMinorMajorCoercion()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.QuestHelper.CheckMinorMajorCoercion | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *questToCheck*, | |  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty* ) | | static |

[◆](class_helpers_1_1_quest_helper.html#aa7d58b6c10bb82479cdaab06abc5f99f)ApplyGenericMinorMajorCoercionConsequences()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.QuestHelper.ApplyGenericMinorMajorCoercionConsequences | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest*, | |  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* ) | | static |

[◆](class_helpers_1_1_quest_helper.html#aab11578a453f054e8aa9c9d82942c730)GetAveragePriceOfItemInTheWorld()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int Helpers.QuestHelper.GetAveragePriceOfItemInTheWorld | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  | | static |

[◆](class_helpers_1_1_quest_helper.html#a88ab3f5fa9610477d9a29ecfdb79348a)CheckWarDeclarationAndFailOrCancelTheQuest()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.QuestHelper.CheckWarDeclarationAndFailOrCancelTheQuest | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *questToCheck*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2*, | |  |  | [DeclareWarAction.DeclareWarDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_declare_war_action.html#ae14e6aaf7e6ab22a1bd112b413124ce4) | *detail*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *failLog*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *cancelLog*, | |  |  | bool | *forceCancel* = false ) | | static |


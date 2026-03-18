--- SOURCE: class_story_mode_1_1_game_components_1_1_story_mode_encounter_game_menu_model.html ---

StoryMode.GameComponents.StoryModeEncounterGameMenuModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterGameMenuModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override string | [GetEncounterMenu](class_story_mode_1_1_game_components_1_1_story_mode_encounter_game_menu_model.html#a03fbbcefe8c11c4423400a9f4d07bd40) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty, out bool startBattle, out bool joinBattle) |
| override string | [GetGenericStateMenu](class_story_mode_1_1_game_components_1_1_story_mode_encounter_game_menu_model.html#a3b18e4e76c6d9d674c03d2b6007ae8d7) () |
| override string | [GetNewPartyJoinMenu](class_story_mode_1_1_game_components_1_1_story_mode_encounter_game_menu_model.html#afb9aa193dd863b8db6364d6db8faa4ee) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) newParty) |
| override string | [GetRaidCompleteMenu](class_story_mode_1_1_game_components_1_1_story_mode_encounter_game_menu_model.html#a68aa1fc687439727cba08d68d8f9149f) () |
| override bool | [IsPlunderMenu](class_story_mode_1_1_game_components_1_1_story_mode_encounter_game_menu_model.html#a9d00d1462a9c26dc509452eba6c081c0) (string menuId) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterGameMenuModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html) | |
| string | [GetEncounterMenu](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html#a5de0762aa0b60154a5f4f86c6002288b) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty, out bool startBattle, out bool joinBattle) |
| string | [GetRaidCompleteMenu](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html#acf6f70bde154cf317b69d854f1f18926) () |
| string | [GetNewPartyJoinMenu](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html#aad8e6c72c94a4b784fcf3b9dc6bf02bb) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) newParty) |
| string | [GetGenericStateMenu](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html#ad76fe4447adc4d24568c4fe9b1eef787) () |
| bool | [IsPlunderMenu](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html#afacfacbd2e928c84206bd27137177d9c) (string menuId) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_game_components_1_1_story_mode_encounter_game_menu_model.html#a03fbbcefe8c11c4423400a9f4d07bd40)GetEncounterMenu()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override string StoryMode.GameComponents.StoryModeEncounterGameMenuModel.GetEncounterMenu | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty*, |
|  |  | out bool | *startBattle*, |
|  |  | out bool | *joinBattle* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_encounter_game_menu_model.html#a3b18e4e76c6d9d674c03d2b6007ae8d7)GetGenericStateMenu()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string StoryMode.GameComponents.StoryModeEncounterGameMenuModel.GetGenericStateMenu | ( |  | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_encounter_game_menu_model.html#afb9aa193dd863b8db6364d6db8faa4ee)GetNewPartyJoinMenu()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override string StoryMode.GameComponents.StoryModeEncounterGameMenuModel.GetNewPartyJoinMenu | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *newParty* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_encounter_game_menu_model.html#a68aa1fc687439727cba08d68d8f9149f)GetRaidCompleteMenu()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string StoryMode.GameComponents.StoryModeEncounterGameMenuModel.GetRaidCompleteMenu | ( |  | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_encounter_game_menu_model.html#a9d00d1462a9c26dc509452eba6c081c0)IsPlunderMenu()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool StoryMode.GameComponents.StoryModeEncounterGameMenuModel.IsPlunderMenu | ( | string | *menuId* | ) |  |


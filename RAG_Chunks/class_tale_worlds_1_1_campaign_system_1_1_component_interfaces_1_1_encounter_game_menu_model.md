--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterGameMenuModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [StoryMode.GameComponents.StoryModeEncounterGameMenuModel](class_story_mode_1_1_game_components_1_1_story_mode_encounter_game_menu_model.html), and [TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterGameMenuModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_game_menu_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html#a5de0762aa0b60154a5f4f86c6002288b)GetEncounterMenu()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterGameMenuModel.GetEncounterMenu | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty*, | |  |  | out bool | *startBattle*, | |  |  | out bool | *joinBattle* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html#acf6f70bde154cf317b69d854f1f18926)GetRaidCompleteMenu()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterGameMenuModel.GetRaidCompleteMenu | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html#aad8e6c72c94a4b784fcf3b9dc6bf02bb)GetNewPartyJoinMenu()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterGameMenuModel.GetNewPartyJoinMenu | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *newParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html#ad76fe4447adc4d24568c4fe9b1eef787)GetGenericStateMenu()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterGameMenuModel.GetGenericStateMenu | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html#afacfacbd2e928c84206bd27137177d9c)IsPlunderMenu()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterGameMenuModel.IsPlunderMenu | ( | string | *menuId* | ) |  | | abstract |


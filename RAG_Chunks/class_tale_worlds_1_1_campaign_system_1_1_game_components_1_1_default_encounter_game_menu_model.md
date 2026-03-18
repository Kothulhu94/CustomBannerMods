--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_game_menu_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterGameMenuModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterGameMenuModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_game_menu_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override string | [GetEncounterMenu](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_game_menu_model.html#a632f10bc012055a8507dc17d4240c67e) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty, out bool startBattle, out bool joinBattle) |
| override string | [GetRaidCompleteMenu](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_game_menu_model.html#a2419348c306e5d12a9f39dc6f505913d) () |
| override string | [GetNewPartyJoinMenu](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_game_menu_model.html#a56ba98b50c7a912748fd4c6e2521a0de) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) newParty) |
| override string | [GetGenericStateMenu](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_game_menu_model.html#a3e32151b7989db26cd9fe8e05b8a35ea) () |
| override bool | [IsPlunderMenu](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_game_menu_model.html#ac8d74f13bc3a07bdfc22b38751acda4a) (string gameMenuId) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_game_menu_model.html#a632f10bc012055a8507dc17d4240c67e)GetEncounterMenu()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterGameMenuModel.GetEncounterMenu | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty*, |
|  |  | out bool | *startBattle*, |
|  |  | out bool | *joinBattle* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_game_menu_model.html#a2419348c306e5d12a9f39dc6f505913d)GetRaidCompleteMenu()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterGameMenuModel.GetRaidCompleteMenu | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_game_menu_model.html#a56ba98b50c7a912748fd4c6e2521a0de)GetNewPartyJoinMenu()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterGameMenuModel.GetNewPartyJoinMenu | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *newParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_game_menu_model.html#a3e32151b7989db26cd9fe8e05b8a35ea)GetGenericStateMenu()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterGameMenuModel.GetGenericStateMenu | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_game_menu_model.html#ac8d74f13bc3a07bdfc22b38751acda4a)IsPlunderMenu()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterGameMenuModel.IsPlunderMenu | ( | string | *gameMenuId* | ) |  |


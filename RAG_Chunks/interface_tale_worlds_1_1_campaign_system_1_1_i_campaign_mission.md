--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html ---

TaleWorlds.CampaignSystem.ICampaignMission Interface ReferenceInherited by [SandBox.Missions.MissionLogics.CampaignMissionComponent](class_sand_box_1_1_missions_1_1_mission_logics_1_1_campaign_mission_component.html), and [SandBox.View.Map.MapConversationView.MapConversationMission](class_sand_box_1_1_view_1_1_map_1_1_map_conversation_view_1_1_map_conversation_mission.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetMissionMode](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#ab105a34655a24a247068e8785132fe7a) ([MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) newMode, bool atStart) |
| void | [OnCloseEncounterMenu](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a8aaca0fff331c8e52a455c159549a147) () |
| bool | [AgentLookingAtAgent](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a7ba9c54a0fb5a19a9682796a385ab0e7) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent1, [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent2) |
| void | [OnCharacterLocationChanged](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a1f7ebd7a5cc15196b926434f51f67f2e) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [Location](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a9c924bbb226cf3056c355ffcfc4fe9e3) fromLocation, [Location](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a9c924bbb226cf3056c355ffcfc4fe9e3) toLocation) |
| void | [OnProcessSentence](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a6f8ad7b645dd5d402cb9a577e8c97197) () |
| void | [OnConversationContinue](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#ae43a06177c535af96e48b568ea3b71f6) () |
| bool | [CheckIfAgentCanFollow](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a04b98356e61603090c5f6e686dcd4e6a) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| void | [AddAgentFollowing](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a203a2383294b4ce58c994739971499cc) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| bool | [CheckIfAgentCanUnFollow](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a1f44a9402aa29ddedae1bd6bb49c0eb0) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| void | [RemoveAgentFollowing](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a705de30bf7285e83fb0907a02a6fd5e5) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| void | [OnConversationPlay](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a3296913d3c7c04e47a70214e31d014fc) (string idleActionId, string idleFaceAnimId, string reactionId, string reactionFaceAnimId, string soundPath) |
| void | [OnConversationStart](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#aabcaabf24947d303554efa2afd58f686) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent, bool setActionsInstantly) |
| void | [OnConversationEnd](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a12fd3221ea46d88386fc6881f09b0dc5) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| void | [EndMission](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a945c417e64a488eee3d491d59249cc2d) () |
| void | [FadeOutCharacter](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#ac657aca1c0eeede4544d5e51ecbfd497) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) characterObject) |
| void | [OnGameStateChanged](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#ad46cd0d60c51b6774631f68e90734301) () |

|  |  |
| --- | --- |
| Properties | |
| [Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | [State](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a4b9ebf2b54708335fc0cf9b63057a221) `[get]` |
| [IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html) | [AgentSupplier](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a60761a217d7d6f220a38b251ceee216d) `[get]` |
| Location | [Location](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a9c924bbb226cf3056c355ffcfc4fe9e3) `[get, set]` |
| [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | [LastVisitedAlley](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a84ed356a3279b4b5d35d423225e97de1) `[get, set]` |
| [MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) | [Mode](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a03bee2e6331e46a09e05af08395b4a73) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#ab105a34655a24a247068e8785132fe7a)SetMissionMode()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.SetMissionMode | ( | [MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) | *newMode*, |
|  |  | bool | *atStart* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a8aaca0fff331c8e52a455c159549a147)OnCloseEncounterMenu()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.OnCloseEncounterMenu | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a7ba9c54a0fb5a19a9682796a385ab0e7)AgentLookingAtAgent()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ICampaignMission.AgentLookingAtAgent | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent1*, |
|  |  | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent2* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a1f7ebd7a5cc15196b926434f51f67f2e)OnCharacterLocationChanged()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.OnCharacterLocationChanged | ( | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | *locationCharacter*, |
|  |  | [Location](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a9c924bbb226cf3056c355ffcfc4fe9e3) | *fromLocation*, |
|  |  | [Location](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a9c924bbb226cf3056c355ffcfc4fe9e3) | *toLocation* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a6f8ad7b645dd5d402cb9a577e8c97197)OnProcessSentence()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.OnProcessSentence | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#ae43a06177c535af96e48b568ea3b71f6)OnConversationContinue()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.OnConversationContinue | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a04b98356e61603090c5f6e686dcd4e6a)CheckIfAgentCanFollow()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ICampaignMission.CheckIfAgentCanFollow | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a203a2383294b4ce58c994739971499cc)AddAgentFollowing()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.AddAgentFollowing | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a1f44a9402aa29ddedae1bd6bb49c0eb0)CheckIfAgentCanUnFollow()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ICampaignMission.CheckIfAgentCanUnFollow | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a705de30bf7285e83fb0907a02a6fd5e5)RemoveAgentFollowing()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.RemoveAgentFollowing | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a3296913d3c7c04e47a70214e31d014fc)OnConversationPlay()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.OnConversationPlay | ( | string | *idleActionId*, |
|  |  | string | *idleFaceAnimId*, |
|  |  | string | *reactionId*, |
|  |  | string | *reactionFaceAnimId*, |
|  |  | string | *soundPath* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#aabcaabf24947d303554efa2afd58f686)OnConversationStart()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.OnConversationStart | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent*, |
|  |  | bool | *setActionsInstantly* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a12fd3221ea46d88386fc6881f09b0dc5)OnConversationEnd()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.OnConversationEnd | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a945c417e64a488eee3d491d59249cc2d)EndMission()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.EndMission | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#ac657aca1c0eeede4544d5e51ecbfd497)FadeOutCharacter()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.FadeOutCharacter | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *characterObject* | ) |  |

Implemented in [SandBox.Missions.MissionLogics.CampaignMissionComponent](class_sand_box_1_1_missions_1_1_mission_logics_1_1_campaign_mission_component.html#a3559b115a05f6ce526e6ff075809fd57).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#ad46cd0d60c51b6774631f68e90734301)OnGameStateChanged()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignMission.OnGameStateChanged | ( |  | ) |  |

Implemented in [SandBox.Missions.MissionLogics.CampaignMissionComponent](class_sand_box_1_1_missions_1_1_mission_logics_1_1_campaign_mission_component.html#a6067e4b2e88d64b3696b1d120b0b8f41).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a4b9ebf2b54708335fc0cf9b63057a221)State
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Core.GameState](class_tale_worlds_1_1_core_1_1_game_state.html) TaleWorlds.CampaignSystem.ICampaignMission.State | | get |

Implemented in [SandBox.Missions.MissionLogics.CampaignMissionComponent](class_sand_box_1_1_missions_1_1_mission_logics_1_1_campaign_mission_component.html#a2914d514a45cf5bcec56bfb97eaa5e06).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a60761a217d7d6f220a38b251ceee216d)AgentSupplier
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMissionTroopSupplier](interface_tale_worlds_1_1_core_1_1_i_mission_troop_supplier.html) TaleWorlds.CampaignSystem.ICampaignMission.AgentSupplier | | get |

Implemented in [SandBox.Missions.MissionLogics.CampaignMissionComponent](class_sand_box_1_1_missions_1_1_mission_logics_1_1_campaign_mission_component.html#a8a394907c8add137c6a5317613b2242f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a9c924bbb226cf3056c355ffcfc4fe9e3)Location
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Location TaleWorlds.CampaignSystem.ICampaignMission.Location | | getset |

Implemented in [SandBox.Missions.MissionLogics.CampaignMissionComponent](class_sand_box_1_1_missions_1_1_mission_logics_1_1_campaign_mission_component.html#a6a659d2873c6a0d3f443b90fb08ee90b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a84ed356a3279b4b5d35d423225e97de1)LastVisitedAlley
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) TaleWorlds.CampaignSystem.ICampaignMission.LastVisitedAlley | | getset |

Implemented in [SandBox.Missions.MissionLogics.CampaignMissionComponent](class_sand_box_1_1_missions_1_1_mission_logics_1_1_campaign_mission_component.html#aba4fa6a58b9f471befaa87bb8ea6f4a9).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html#a03bee2e6331e46a09e05af08395b4a73)Mode
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) TaleWorlds.CampaignSystem.ICampaignMission.Mode | | get |


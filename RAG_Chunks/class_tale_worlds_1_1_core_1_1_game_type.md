--- SOURCE: class_tale_worlds_1_1_core_1_1_game_type.html ---

TaleWorlds.Core.GameType Class ReferenceabstractInherited by [TaleWorlds.CampaignSystem.Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html), and [TaleWorlds.MountAndBlade.EditorGame](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GameType](class_tale_worlds_1_1_core_1_1_game_type.html#a1672ec9ec9bcf5f37ad0f3a1d7abed74) () |
| void | [OnStateChanged](class_tale_worlds_1_1_core_1_1_game_type.html#a0f97febd2cd7948e5a1c5c1f9718be2f) ([GameState](class_tale_worlds_1_1_core_1_1_game_state.html) oldState) |
| bool | [DoLoadingForGameType](class_tale_worlds_1_1_core_1_1_game_type.html#ae363131cec92ccb6b0bfef161301f9b1) () |
| void | [OnDestroy](class_tale_worlds_1_1_core_1_1_game_type.html#aafaef391218a6cfe3f9fb98f2f9a638e) () |
| virtual void | [OnMissionIsStarting](class_tale_worlds_1_1_core_1_1_game_type.html#ab5e13351789e52d9d0c9cde9077e8b30) (string missionName, [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec) |
| virtual void | [InitializeParameters](class_tale_worlds_1_1_core_1_1_game_type.html#a6ca18af6205630ff59c0b623c9a2a26b) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [DoLoadingForGameType](class_tale_worlds_1_1_core_1_1_game_type.html#ab2ed65bb4555655d8f3b4a5afe1530f7) ([GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) gameTypeLoadingState, out [GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) nextState) |

|  |  |
| --- | --- |
| Properties | |
| virtual bool | [SupportsSaving](class_tale_worlds_1_1_core_1_1_game_type.html#ab73062dfcd7f1ccfc2d3e6ca43e2c182) `[get]` |
| [Game](class_tale_worlds_1_1_core_1_1_game.html) | [CurrentGame](class_tale_worlds_1_1_core_1_1_game_type.html#a419314df916e46484ef1af7c3a3c22d0) `[get]` |
| [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | [ObjectManager](class_tale_worlds_1_1_core_1_1_game_type.html#a1572f7b5db1d31f8addf326966bf77aa) `[get]` |
| [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) | [GameManager](class_tale_worlds_1_1_core_1_1_game_type.html#a72bf450c38b7a45f35f17c4b776e116d) `[get]` |
| virtual bool | [IsInventoryAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#a18d1dba029ee637b3662851a9d269547) `[get]` |
| virtual bool | [IsQuestScreenAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#a621d8736007143f0322110b724fd08c5) `[get]` |
| virtual bool | [IsCharacterWindowAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#a956ec31fee5e29528bf3546dbcd8f890) `[get]` |
| virtual bool | [IsPartyWindowAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#a5a4a147ea5fe579d3a0ea8200ea3198c) `[get]` |
| virtual bool | [IsKingdomWindowAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#af74a1c6f8c31334f693f629ad87ae714) `[get]` |
| virtual bool | [IsClanWindowAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#adf4205d80eb103ddf0cbf7b29ac1d7c4) `[get]` |
| virtual bool | [IsEncyclopediaWindowAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#a5a39a1b9bb0fb0f435c74c6430aa4b87) `[get]` |
| virtual bool | [IsBannerWindowAccessibleAtMission](class_tale_worlds_1_1_core_1_1_game_type.html#af489363161afe3b6a9a438fdac6a815c) `[get]` |
| virtual bool | [IsDevelopment](class_tale_worlds_1_1_core_1_1_game_type.html#a6410ea27467258f51150641c3e86b227) `[get]` |
| virtual bool | [IsCoreOnlyGameMode](class_tale_worlds_1_1_core_1_1_game_type.html#ac83d81edf86ea3492876cb01d00e9992) `[get]` |
| virtual bool | [RequiresTutorial](class_tale_worlds_1_1_core_1_1_game_type.html#a02e1689f8ee71bbb4e9d1bf0821e8a4a) `[get]` |
| virtual string | [GameTypeStringId](class_tale_worlds_1_1_core_1_1_game_type.html#a5a4d23c085eeb77de969d80d4f146fb0) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a1672ec9ec9bcf5f37ad0f3a1d7abed74)GameType()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.GameType.GameType | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a0f97febd2cd7948e5a1c5c1f9718be2f)OnStateChanged()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.GameType.OnStateChanged | ( | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | *oldState* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#ab2ed65bb4555655d8f3b4a5afe1530f7)DoLoadingForGameType() [1/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.GameType.DoLoadingForGameType | ( | [GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) | *gameTypeLoadingState*, | |  |  | out [GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) | *nextState* ) | | abstractprotected |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#ae363131cec92ccb6b0bfef161301f9b1)DoLoadingForGameType() [2/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.GameType.DoLoadingForGameType | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#aafaef391218a6cfe3f9fb98f2f9a638e)OnDestroy()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.GameType.OnDestroy | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#ab5e13351789e52d9d0c9cde9077e8b30)OnMissionIsStarting()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.Core.GameType.OnMissionIsStarting | ( | string | *missionName*, | |  |  | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#ab3698e6d810d91ac02e6d68bca491554).

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a6ca18af6205630ff59c0b623c9a2a26b)InitializeParameters()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Core.GameType.InitializeParameters | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html#a24b88f764a51cc91846bffda6d627d58).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#ab73062dfcd7f1ccfc2d3e6ca43e2c182)SupportsSaving
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameType.SupportsSaving | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a419314df916e46484ef1af7c3a3c22d0)CurrentGame
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Game](class_tale_worlds_1_1_core_1_1_game.html) TaleWorlds.Core.GameType.CurrentGame | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a1572f7b5db1d31f8addf326966bf77aa)ObjectManager
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) TaleWorlds.Core.GameType.ObjectManager | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a72bf450c38b7a45f35f17c4b776e116d)GameManager
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) TaleWorlds.Core.GameType.GameManager | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a18d1dba029ee637b3662851a9d269547)IsInventoryAccessibleAtMission
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameType.IsInventoryAccessibleAtMission | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a621d8736007143f0322110b724fd08c5)IsQuestScreenAccessibleAtMission
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameType.IsQuestScreenAccessibleAtMission | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a956ec31fee5e29528bf3546dbcd8f890)IsCharacterWindowAccessibleAtMission
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameType.IsCharacterWindowAccessibleAtMission | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a5a4a147ea5fe579d3a0ea8200ea3198c)IsPartyWindowAccessibleAtMission
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameType.IsPartyWindowAccessibleAtMission | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#af74a1c6f8c31334f693f629ad87ae714)IsKingdomWindowAccessibleAtMission
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameType.IsKingdomWindowAccessibleAtMission | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#adf4205d80eb103ddf0cbf7b29ac1d7c4)IsClanWindowAccessibleAtMission
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameType.IsClanWindowAccessibleAtMission | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a5a39a1b9bb0fb0f435c74c6430aa4b87)IsEncyclopediaWindowAccessibleAtMission
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameType.IsEncyclopediaWindowAccessibleAtMission | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#af489363161afe3b6a9a438fdac6a815c)IsBannerWindowAccessibleAtMission
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameType.IsBannerWindowAccessibleAtMission | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a6410ea27467258f51150641c3e86b227)IsDevelopment
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameType.IsDevelopment | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#ac83d81edf86ea3492876cb01d00e9992)IsCoreOnlyGameMode
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameType.IsCoreOnlyGameMode | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a02e1689f8ee71bbb4e9d1bf0821e8a4a)RequiresTutorial
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.GameType.RequiresTutorial | | get |

[◆](class_tale_worlds_1_1_core_1_1_game_type.html#a5a4d23c085eeb77de969d80d4f146fb0)GameTypeStringId
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual string TaleWorlds.Core.GameType.GameTypeStringId | | get |


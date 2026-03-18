--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html ---

TaleWorlds.MountAndBlade.EditorGame Class ReferenceInherits [TaleWorlds.Core.GameType](class_tale_worlds_1_1_core_1_1_game_type.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [EditorGame](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#aa0c5fd353db1a7e8b46ad42a4166932e) () |
| override void | [OnDestroy](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#a5c1cf7d44fde64cefa201c01cb700f86) () |
| override void | [OnStateChanged](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#a8183e914460119fa7eed31152b68109a) ([GameState](class_tale_worlds_1_1_core_1_1_game_state.html) oldState) |
| Public Member Functions inherited from [TaleWorlds.Core.GameType](class_tale_worlds_1_1_core_1_1_game_type.html) | |
|  | [GameType](class_tale_worlds_1_1_core_1_1_game_type.html#a1672ec9ec9bcf5f37ad0f3a1d7abed74) () |
| void | [OnStateChanged](class_tale_worlds_1_1_core_1_1_game_type.html#a0f97febd2cd7948e5a1c5c1f9718be2f) ([GameState](class_tale_worlds_1_1_core_1_1_game_state.html) oldState) |
| bool | [DoLoadingForGameType](class_tale_worlds_1_1_core_1_1_game_type.html#ae363131cec92ccb6b0bfef161301f9b1) () |
| void | [OnDestroy](class_tale_worlds_1_1_core_1_1_game_type.html#aafaef391218a6cfe3f9fb98f2f9a638e) () |
| virtual void | [OnMissionIsStarting](class_tale_worlds_1_1_core_1_1_game_type.html#ab5e13351789e52d9d0c9cde9077e8b30) (string missionName, [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec) |
| virtual void | [InitializeParameters](class_tale_worlds_1_1_core_1_1_game_type.html#a6ca18af6205630ff59c0b623c9a2a26b) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#a4e8aa180dc29783de0c0e32300ab6e74) () |
| override void | [BeforeRegisterTypes](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#ab87f523a016805571f6a89dc045180c5) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager) |
| override void | [OnRegisterTypes](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#abd679f5c816592531b96e6e5dc0d8e41) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager) |
| override void | [DoLoadingForGameType](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#ada399620612b49d37beb113f6c6e9c0f) ([GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) gameTypeLoadingState, out [GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) nextState) |
| Protected Member Functions inherited from [TaleWorlds.Core.GameType](class_tale_worlds_1_1_core_1_1_game_type.html) | |
| void | [DoLoadingForGameType](class_tale_worlds_1_1_core_1_1_game_type.html#ab2ed65bb4555655d8f3b4a5afe1530f7) ([GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) gameTypeLoadingState, out [GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) nextState) |

|  |  |
| --- | --- |
| Properties | |
| static [EditorGame](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#aa0c5fd353db1a7e8b46ad42a4166932e) | [Current](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#a18d3ccc9e259219334004daa67e50582) `[get]` |
| Properties inherited from [TaleWorlds.Core.GameType](class_tale_worlds_1_1_core_1_1_game_type.html) | |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#aa0c5fd353db1a7e8b46ad42a4166932e)EditorGame()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.EditorGame.EditorGame | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#a4e8aa180dc29783de0c0e32300ab6e74)OnInitialize()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.EditorGame.OnInitialize | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#ab87f523a016805571f6a89dc045180c5)BeforeRegisterTypes()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.EditorGame.BeforeRegisterTypes | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#abd679f5c816592531b96e6e5dc0d8e41)OnRegisterTypes()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.EditorGame.OnRegisterTypes | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#ada399620612b49d37beb113f6c6e9c0f)DoLoadingForGameType()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.EditorGame.DoLoadingForGameType | ( | [GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) | *gameTypeLoadingState*, | |  |  | out [GameTypeLoadingStates](namespace_tale_worlds_1_1_core.html#aa5c6ef1ec27a8a2faeb27e9349c49a1b) | *nextState* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#a5c1cf7d44fde64cefa201c01cb700f86)OnDestroy()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.EditorGame.OnDestroy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#a8183e914460119fa7eed31152b68109a)OnStateChanged()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.EditorGame.OnStateChanged | ( | [GameState](class_tale_worlds_1_1_core_1_1_game_state.html) | *oldState* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#a18d3ccc9e259219334004daa67e50582)Current
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EditorGame](class_tale_worlds_1_1_mount_and_blade_1_1_editor_game.html#aa0c5fd353db1a7e8b46ad42a4166932e) TaleWorlds.MountAndBlade.EditorGame.Current | | staticget |


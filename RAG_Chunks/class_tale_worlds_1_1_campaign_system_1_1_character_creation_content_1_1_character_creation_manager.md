--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html ---

TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a6e142d9494513374f447a0acc7fdc5a9) ([CharacterCreationState](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html) state) |
| void | [RegisterCharacterCreationContentHandler](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a6a8b570f7c207598609997cac87538a3) ([ICharacterCreationContentHandler](interface_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_i_character_creation_content_handler.html) characterCreationContentHandler, int priority) |
| void | [AddStage](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#ace3067a031c528dbabececa49025f9fb) ([CharacterCreationStageBase](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_stage_base.html) stage) |
| bool | [RemoveStage< T >](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a651c7459d422c7dbab748e4f2b2d833b) () |
| T | [GetStage< T >](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#aeec057dd29d5845d6ff4bdc40a36429d) () |
| void | [NextStage](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a9be80d8b75cd794eafea6e95114d939e) () |
| void | [PreviousStage](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#afa93990902c7b50a911584e7dc8946ed) () |
| void | [GoToStage](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a6540b7d3111f7011f4a8ef26c21418c4) (int stageIndex) |
| int | [GetIndexOfCurrentStage](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#abffb5aeb1dd4e4c55a8b620ff95d9949) () |
| int | [GetTotalStagesCount](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#aa32b4b20fd1da2611c9c27ef91c0ace7) () |
| int | [GetFurthestIndex](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#af8db3203669a69f10a3fabab12c4f6a4) () |
|  | Max index player has gone to. |
| void | [AddNewMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a1b4a77a88de870c20b866877f3db0920) ([NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html) menu) |
| [NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html) | [GetCurrentMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#abdda876625a2c8c1a2d24ef570f161ad) (int index) |
| IEnumerable< [NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html) > | [GetCurrentMenuOptions](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#aa41b688f0a1575adda2eaebf8820406e) (int index) |
| [NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html) | [GetNarrativeMenuWithId](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a77898a4c6c6cb65d1f8b20e9c4fcd354) (string stringId) |
| void | [DeleteNarrativeMenuWithId](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#ae62c952a1d97d86b16fbc5e0ec890801) (string stringId) |
| void | [ResetNarrativeMenus](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#abdef4ee8b6a93b7cd9336111ba7b584c) () |
| void | [ResetMenuOptions](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a9f8942e0e3f9b1719b1e8b77a80d103a) () |
| void | [StartNarrativeStage](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#af15d3286243d6fe872a951924812d5f0) () |
| bool | [TrySwitchToNextMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a8b57e0053d66b224937cb976954b6eea) () |
| bool | [TrySwitchToPreviousMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#aa725dce9f45a923b212083070c87ffca) () |
| void | [OnNarrativeMenuOptionSelected](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a1829c103233adb40afc64762298c4007) ([NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html) option) |
| IEnumerable< [NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html) > | [GetSuitableNarrativeMenuOptions](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a4de4c8f7849aef61f82fa829c85ea99e) () |
| void | [ApplyFinalEffects](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a837c5634ad4b38b481975c5ea9259e31) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Dictionary< [NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html), [NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html) > | [SelectedOptions](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a6ced8e8e145e5946109e85a77011f1fe) |
| readonly FaceGenHistory | [FaceGenHistory](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a12529716796bb3517e8c24ab2f3365b4) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html) > | [NarrativeMenus](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#af03caa42a05c182325b00d3ac8379975) `[get]` |
| CharacterCreationContent | [CharacterCreationContent](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a3b767ab4ab6f7049e1bd3cf5a5e550ae) `[get]` |
| [NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html) | [CurrentMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a2405a709179caf5add02b446f15c8b50) `[get]` |
| int | [CharacterCreationMenuCount](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#ad9bb33613e6ae6a810a911f0b74a3aae) `[get]` |
| [CharacterCreationStageBase](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_stage_base.html) | [CurrentStage](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a2ab3d26841a26d06d5ca1c3f5baec63e) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a6e142d9494513374f447a0acc7fdc5a9)CharacterCreationManager()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.CharacterCreationManager | ( | [CharacterCreationState](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_state.html) | *state* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a6a8b570f7c207598609997cac87538a3)RegisterCharacterCreationContentHandler()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.RegisterCharacterCreationContentHandler | ( | [ICharacterCreationContentHandler](interface_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_i_character_creation_content_handler.html) | *characterCreationContentHandler*, |
|  |  | int | *priority* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#ace3067a031c528dbabececa49025f9fb)AddStage()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.AddStage | ( | [CharacterCreationStageBase](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_stage_base.html) | *stage* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a651c7459d422c7dbab748e4f2b2d833b)RemoveStage< T >()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.RemoveStage< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[CharacterCreationStageBase](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_stage_base.html)* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#aeec057dd29d5845d6ff4bdc40a36429d)GetStage< T >()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.GetStage< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[CharacterCreationStageBase](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_stage_base.html)* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a9be80d8b75cd794eafea6e95114d939e)NextStage()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.NextStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#afa93990902c7b50a911584e7dc8946ed)PreviousStage()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.PreviousStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a6540b7d3111f7011f4a8ef26c21418c4)GoToStage()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.GoToStage | ( | int | *stageIndex* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#abffb5aeb1dd4e4c55a8b620ff95d9949)GetIndexOfCurrentStage()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.GetIndexOfCurrentStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#aa32b4b20fd1da2611c9c27ef91c0ace7)GetTotalStagesCount()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.GetTotalStagesCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#af8db3203669a69f10a3fabab12c4f6a4)GetFurthestIndex()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.GetFurthestIndex | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a1b4a77a88de870c20b866877f3db0920)AddNewMenu()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.AddNewMenu | ( | [NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html) | *menu* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#abdda876625a2c8c1a2d24ef570f161ad)GetCurrentMenu()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html) TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.GetCurrentMenu | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#aa41b688f0a1575adda2eaebf8820406e)GetCurrentMenuOptions()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html) > TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.GetCurrentMenuOptions | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a77898a4c6c6cb65d1f8b20e9c4fcd354)GetNarrativeMenuWithId()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html) TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.GetNarrativeMenuWithId | ( | string | *stringId* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#ae62c952a1d97d86b16fbc5e0ec890801)DeleteNarrativeMenuWithId()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.DeleteNarrativeMenuWithId | ( | string | *stringId* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#abdef4ee8b6a93b7cd9336111ba7b584c)ResetNarrativeMenus()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.ResetNarrativeMenus | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a9f8942e0e3f9b1719b1e8b77a80d103a)ResetMenuOptions()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.ResetMenuOptions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#af15d3286243d6fe872a951924812d5f0)StartNarrativeStage()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.StartNarrativeStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a8b57e0053d66b224937cb976954b6eea)TrySwitchToNextMenu()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.TrySwitchToNextMenu | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#aa725dce9f45a923b212083070c87ffca)TrySwitchToPreviousMenu()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.TrySwitchToPreviousMenu | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a1829c103233adb40afc64762298c4007)OnNarrativeMenuOptionSelected()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.OnNarrativeMenuOptionSelected | ( | [NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html) | *option* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a4de4c8f7849aef61f82fa829c85ea99e)GetSuitableNarrativeMenuOptions()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html) > TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.GetSuitableNarrativeMenuOptions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a837c5634ad4b38b481975c5ea9259e31)ApplyFinalEffects()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.ApplyFinalEffects | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a6ced8e8e145e5946109e85a77011f1fe)SelectedOptions
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Dictionary<[NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html), [NarrativeMenuOption](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu_option.html)> TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.SelectedOptions |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a12529716796bb3517e8c24ab2f3365b4)FaceGenHistory
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly FaceGenHistory TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.FaceGenHistory |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#af03caa42a05c182325b00d3ac8379975)NarrativeMenus
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html)> TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.NarrativeMenus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a3b767ab4ab6f7049e1bd3cf5a5e550ae)CharacterCreationContent
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CharacterCreationContent TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.CharacterCreationContent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a2405a709179caf5add02b446f15c8b50)CurrentMenu
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [NarrativeMenu](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_narrative_menu.html) TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.CurrentMenu | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#ad9bb33613e6ae6a810a911f0b74a3aae)CharacterCreationMenuCount
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.CharacterCreationMenuCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html#a2ab3d26841a26d06d5ca1c3f5baec63e)CurrentStage
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterCreationStageBase](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_stage_base.html) TaleWorlds.CampaignSystem.CharacterCreationContent.CharacterCreationManager.CurrentStage | | get |


--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html ---

SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView Class ReferenceInherits [SandBox.View.CharacterCreation.CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CharacterCreationCultureStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a7cdeed564e31cc1641cf769695f1eb52) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager, [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) affirmativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) affirmativeActionText, [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) negativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) negativeActionText, [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) onRefresh, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getCurrentStageIndexAction, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getTotalStageCountAction, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getFurthestIndexAction, [ControlCharacterCreationStageWithInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#a4f8f1fb1c62a9074508b5c7faaacd519) goToIndexAction) |
| override void | [Tick](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a94803e0d36517102cb9106dde8e5ab34) (float dt) |
| override void | [NextStage](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#ab3c45693e513a3546cd990dcdceb5bee) () |
| override void | [PreviousStage](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a2806190c6dc8e21393e8a5ae19ed6362) () |
| override int | [GetVirtualStageCount](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#acbdb7c9bf79ed6112774a4bd23df30eb) () |
| override IEnumerable< ScreenLayer > | [GetLayers](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a5eff8fd34504bbf8479cfa92e2f7b69f) () |
| override void | [LoadEscapeMenuMovie](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#ac25180a6d0a4e5320bee34f449384e9a) () |
| override void | [ReleaseEscapeMenuMovie](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a1edabf3f2bddca8b45aa794550973ebf) () |
| Public Member Functions inherited from [SandBox.View.CharacterCreation.CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html) | |
| virtual void | [SetGenericScene](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#afd798cdb3f4539fcb6b0c57917ba3feb) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
|  | Sets the generic scene used in some of the creation stages. |
| IEnumerable< ScreenLayer > | [GetLayers](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a27d50b1653f00dcc244027e82b6aaf4d) () |
| void | [NextStage](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a51c12a7ba984a34e4c9044175e08c476) () |
| void | [PreviousStage](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#abf89ae1bacdb44b3e89a506bfa8609d0) () |
| int | [GetVirtualStageCount](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a33eeda63cb98c65e442e8306a4bfec9e) () |
| virtual void | [GoToIndex](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a6048ca265656dd1cb391db2f3f4ce39f) (int index) |
| void | [LoadEscapeMenuMovie](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#aeed07ee7233f13bf7d63aedca5315716) () |
| void | [ReleaseEscapeMenuMovie](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a932a376fd211c032cc6fb788b3134cbb) () |
| void | [HandleEscapeMenu](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#ad0037bdd4644d69699dc769c06e701ab) ([CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a0b7a6bd00d6f0b59be3167f31557bebb) view, ScreenLayer screenLayer) |
| List< [EscapeMenuItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_escape_menu_1_1_escape_menu_item_v_m.html) > | [GetEscapeMenuItems](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a714e7bde45f93969282f7bf56804c312) ([CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a0b7a6bd00d6f0b59be3167f31557bebb) view) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a5f3073bcd19ec3146b7a8134972369f0) () |
| Protected Member Functions inherited from [SandBox.View.CharacterCreation.CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html) | |
|  | [CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a0b7a6bd00d6f0b59be3167f31557bebb) ([ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) affirmativeAction, [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) negativeAction, [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) refreshAction, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getCurrentStageIndexAction, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getTotalStageCountAction, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getFurthestIndexAction, [ControlCharacterCreationStageWithInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#a4f8f1fb1c62a9074508b5c7faaacd519) goToIndexAction) |
| virtual void | [OnRefresh](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#aef26b861ef6c0768544d396afc99540a) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Attributes inherited from [SandBox.View.CharacterCreation.CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html) | |
| readonly [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | [\_affirmativeAction](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#aa5330a20c4eb0bcced19453964e03b11) |
| readonly [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | [\_negativeAction](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a6cd2f742c0638427f34eb8ef2efaf2f1) |
| readonly [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | [\_refreshAction](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a94b8d457f08bc54cda0d64948fd86765) |
| readonly [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | [\_getTotalStageCountAction](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a937f7d936bfaed0b13c305175835f5fe) |
| readonly [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | [\_getCurrentStageIndexAction](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a7da573c8a8b9545985aebb93746858b9) |
| readonly [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | [\_getFurthestIndexAction](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a547eb687388d540dce75af5e21acd2eb) |
| readonly [ControlCharacterCreationStageWithInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#a4f8f1fb1c62a9074508b5c7faaacd519) | [\_goToIndexAction](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a77dff1e0512312baf2ee23db13ca69b8) |
| readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [\_cameraPosition](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a79153de8ec87d4963fca7cb9b5a40908) = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)(6.45f, 4.35f, 1.6f) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a7cdeed564e31cc1641cf769695f1eb52)CharacterCreationCultureStageView()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView.CharacterCreationCultureStageView | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager*, |
|  |  | [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | *affirmativeAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *affirmativeActionText*, |
|  |  | [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | *negativeAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *negativeActionText*, |
|  |  | [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | *onRefresh*, |
|  |  | [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | *getCurrentStageIndexAction*, |
|  |  | [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | *getTotalStageCountAction*, |
|  |  | [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | *getFurthestIndexAction*, |
|  |  | [ControlCharacterCreationStageWithInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#a4f8f1fb1c62a9074508b5c7faaacd519) | *goToIndexAction* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a5f3073bcd19ec3146b7a8134972369f0)OnFinalize()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.CharacterCreation.CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a05d31eed965c92fcbf5f6797e4ee179e).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a94803e0d36517102cb9106dde8e5ab34)Tick()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [SandBox.View.CharacterCreation.CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a4c43884798083de3a75863c3d02a2f84).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#ab3c45693e513a3546cd990dcdceb5bee)NextStage()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView.NextStage | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a2806190c6dc8e21393e8a5ae19ed6362)PreviousStage()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView.PreviousStage | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#acbdb7c9bf79ed6112774a4bd23df30eb)GetVirtualStageCount()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView.GetVirtualStageCount | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a5eff8fd34504bbf8479cfa92e2f7b69f)GetLayers()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override IEnumerable< ScreenLayer > SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView.GetLayers | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#ac25180a6d0a4e5320bee34f449384e9a)LoadEscapeMenuMovie()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView.LoadEscapeMenuMovie | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a1edabf3f2bddca8b45aa794550973ebf)ReleaseEscapeMenuMovie()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView.ReleaseEscapeMenuMovie | ( |  | ) |  |


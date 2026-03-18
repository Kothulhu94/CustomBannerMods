--- SOURCE: class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html ---

SandBox.View.CharacterCreation.CharacterCreationStageViewBase Class ReferenceabstractInherits [TaleWorlds.CampaignSystem.CharacterCreationContent.ICharacterCreationStageListener](interface_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_i_character_creation_stage_listener.html).

Inherited by [SandBox.GauntletUI.CharacterCreation.CharacterCreationBannerEditorView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_banner_editor_view.html), [SandBox.GauntletUI.CharacterCreation.CharacterCreationClanNamingStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_clan_naming_stage_view.html), [SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html), [SandBox.GauntletUI.CharacterCreation.CharacterCreationFaceGeneratorView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_face_generator_view.html), [SandBox.GauntletUI.CharacterCreation.CharacterCreationNarrativeStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_narrative_stage_view.html), [SandBox.GauntletUI.CharacterCreation.CharacterCreationOptionsStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_options_stage_view.html), and [SandBox.GauntletUI.CharacterCreation.CharacterCreationReviewStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_review_stage_view.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [SetGenericScene](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#afd798cdb3f4539fcb6b0c57917ba3feb) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
|  | Sets the generic scene used in some of the creation stages. |
| IEnumerable< ScreenLayer > | [GetLayers](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a27d50b1653f00dcc244027e82b6aaf4d) () |
| void | [NextStage](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a51c12a7ba984a34e4c9044175e08c476) () |
| void | [PreviousStage](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#abf89ae1bacdb44b3e89a506bfa8609d0) () |
| virtual void | [Tick](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a4c43884798083de3a75863c3d02a2f84) (float dt) |
| int | [GetVirtualStageCount](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a33eeda63cb98c65e442e8306a4bfec9e) () |
| virtual void | [GoToIndex](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a6048ca265656dd1cb391db2f3f4ce39f) (int index) |
| void | [LoadEscapeMenuMovie](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#aeed07ee7233f13bf7d63aedca5315716) () |
| void | [ReleaseEscapeMenuMovie](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a932a376fd211c032cc6fb788b3134cbb) () |
| void | [HandleEscapeMenu](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#ad0037bdd4644d69699dc769c06e701ab) ([CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a0b7a6bd00d6f0b59be3167f31557bebb) view, ScreenLayer screenLayer) |
| List< [EscapeMenuItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_escape_menu_1_1_escape_menu_item_v_m.html) > | [GetEscapeMenuItems](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a714e7bde45f93969282f7bf56804c312) ([CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a0b7a6bd00d6f0b59be3167f31557bebb) view) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a0b7a6bd00d6f0b59be3167f31557bebb) ([ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) affirmativeAction, [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) negativeAction, [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) refreshAction, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getCurrentStageIndexAction, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getTotalStageCountAction, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getFurthestIndexAction, [ControlCharacterCreationStageWithInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#a4f8f1fb1c62a9074508b5c7faaacd519) goToIndexAction) |
| virtual void | [OnRefresh](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#aef26b861ef6c0768544d396afc99540a) () |
| virtual void | [OnFinalize](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a05d31eed965c92fcbf5f6797e4ee179e) () |

|  |  |
| --- | --- |
| Protected Attributes | |
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

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a0b7a6bd00d6f0b59be3167f31557bebb)CharacterCreationStageViewBase()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | SandBox.View.CharacterCreation.CharacterCreationStageViewBase.CharacterCreationStageViewBase | ( | [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | *affirmativeAction*, | |  |  | [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | *negativeAction*, | |  |  | [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | *refreshAction*, | |  |  | [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | *getCurrentStageIndexAction*, | |  |  | [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | *getTotalStageCountAction*, | |  |  | [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | *getFurthestIndexAction*, | |  |  | [ControlCharacterCreationStageWithInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#a4f8f1fb1c62a9074508b5c7faaacd519) | *goToIndexAction* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#afd798cdb3f4539fcb6b0c57917ba3feb)SetGenericScene()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.View.CharacterCreation.CharacterCreationStageViewBase.SetGenericScene | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* | ) |  | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | scene |  |

Reimplemented in [SandBox.GauntletUI.CharacterCreation.CharacterCreationNarrativeStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_narrative_stage_view.html#ad932ba264f05b365a0685760931557f1), [SandBox.GauntletUI.CharacterCreation.CharacterCreationOptionsStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_options_stage_view.html#aac4e7e58de4dcd3bdbe40aa2fa174201), and [SandBox.GauntletUI.CharacterCreation.CharacterCreationReviewStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_review_stage_view.html#a1288eec8f66ab4695e45b093fab21e12).

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#aef26b861ef6c0768544d396afc99540a)OnRefresh()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.CharacterCreation.CharacterCreationStageViewBase.OnRefresh | ( |  | ) |  | | protectedvirtual |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a27d50b1653f00dcc244027e82b6aaf4d)GetLayers()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | IEnumerable< ScreenLayer > SandBox.View.CharacterCreation.CharacterCreationStageViewBase.GetLayers | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a51c12a7ba984a34e4c9044175e08c476)NextStage()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.View.CharacterCreation.CharacterCreationStageViewBase.NextStage | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#abf89ae1bacdb44b3e89a506bfa8609d0)PreviousStage()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.View.CharacterCreation.CharacterCreationStageViewBase.PreviousStage | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a05d31eed965c92fcbf5f6797e4ee179e)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.CharacterCreation.CharacterCreationStageViewBase.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.GauntletUI.CharacterCreation.CharacterCreationBannerEditorView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_banner_editor_view.html#ae35c15ff450925f5930f17edebb19a1a), [SandBox.GauntletUI.CharacterCreation.CharacterCreationClanNamingStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_clan_naming_stage_view.html#a137447baf7ef1901bbd55aff4a2abc30), [SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a5f3073bcd19ec3146b7a8134972369f0), [SandBox.GauntletUI.CharacterCreation.CharacterCreationFaceGeneratorView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_face_generator_view.html#ad60e7b85419e68243919ae219aa82866), [SandBox.GauntletUI.CharacterCreation.CharacterCreationNarrativeStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_narrative_stage_view.html#ac5a22d9e2218fd996895a0cbba2e8c7b), [SandBox.GauntletUI.CharacterCreation.CharacterCreationOptionsStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_options_stage_view.html#a44869d9b03759fa081af53f990d98d54), and [SandBox.GauntletUI.CharacterCreation.CharacterCreationReviewStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_review_stage_view.html#ab6729bc9a783a39a412bc75114ff58de).

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a4c43884798083de3a75863c3d02a2f84)Tick()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.View.CharacterCreation.CharacterCreationStageViewBase.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented in [SandBox.GauntletUI.CharacterCreation.CharacterCreationBannerEditorView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_banner_editor_view.html#afe39b077e94442bc235cff104e61006b), [SandBox.GauntletUI.CharacterCreation.CharacterCreationClanNamingStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_clan_naming_stage_view.html#ad021c7ce1038b46cbedc4cbb3c2f2d19), [SandBox.GauntletUI.CharacterCreation.CharacterCreationCultureStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_culture_stage_view.html#a94803e0d36517102cb9106dde8e5ab34), [SandBox.GauntletUI.CharacterCreation.CharacterCreationFaceGeneratorView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_face_generator_view.html#a1dc6fcf224c7f18fa2f663d1c8755525), [SandBox.GauntletUI.CharacterCreation.CharacterCreationNarrativeStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_narrative_stage_view.html#a5e5b16dce793a08062c9401fd15047eb), [SandBox.GauntletUI.CharacterCreation.CharacterCreationOptionsStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_options_stage_view.html#aec43cd9414033b072151a42a09deda51), and [SandBox.GauntletUI.CharacterCreation.CharacterCreationReviewStageView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_review_stage_view.html#ac5906994ac21fb60e35590ecad6c0a48).

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a33eeda63cb98c65e442e8306a4bfec9e)GetVirtualStageCount()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int SandBox.View.CharacterCreation.CharacterCreationStageViewBase.GetVirtualStageCount | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a6048ca265656dd1cb391db2f3f4ce39f)GoToIndex()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.View.CharacterCreation.CharacterCreationStageViewBase.GoToIndex | ( | int | *index* | ) |  | | virtual |

Reimplemented in [SandBox.GauntletUI.CharacterCreation.CharacterCreationBannerEditorView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_banner_editor_view.html#a93a3d842a82759ed108bd4499b408b74), and [SandBox.GauntletUI.CharacterCreation.CharacterCreationFaceGeneratorView](class_sand_box_1_1_gauntlet_u_i_1_1_character_creation_1_1_character_creation_face_generator_view.html#ae0490d9566e9eafffb4309ffe4149692).

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#aeed07ee7233f13bf7d63aedca5315716)LoadEscapeMenuMovie()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.View.CharacterCreation.CharacterCreationStageViewBase.LoadEscapeMenuMovie | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a932a376fd211c032cc6fb788b3134cbb)ReleaseEscapeMenuMovie()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.View.CharacterCreation.CharacterCreationStageViewBase.ReleaseEscapeMenuMovie | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#ad0037bdd4644d69699dc769c06e701ab)HandleEscapeMenu()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.View.CharacterCreation.CharacterCreationStageViewBase.HandleEscapeMenu | ( | [CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a0b7a6bd00d6f0b59be3167f31557bebb) | *view*, |
|  |  | ScreenLayer | *screenLayer* ) |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a714e7bde45f93969282f7bf56804c312)GetEscapeMenuItems()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [EscapeMenuItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_escape_menu_1_1_escape_menu_item_v_m.html) > SandBox.View.CharacterCreation.CharacterCreationStageViewBase.GetEscapeMenuItems | ( | [CharacterCreationStageViewBase](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a0b7a6bd00d6f0b59be3167f31557bebb) | *view* | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#aa5330a20c4eb0bcced19453964e03b11)\_affirmativeAction
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) SandBox.View.CharacterCreation.CharacterCreationStageViewBase.\_affirmativeAction | | protected |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a6cd2f742c0638427f34eb8ef2efaf2f1)\_negativeAction
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) SandBox.View.CharacterCreation.CharacterCreationStageViewBase.\_negativeAction | | protected |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a94b8d457f08bc54cda0d64948fd86765)\_refreshAction
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) SandBox.View.CharacterCreation.CharacterCreationStageViewBase.\_refreshAction | | protected |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a937f7d936bfaed0b13c305175835f5fe)\_getTotalStageCountAction
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) SandBox.View.CharacterCreation.CharacterCreationStageViewBase.\_getTotalStageCountAction | | protected |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a7da573c8a8b9545985aebb93746858b9)\_getCurrentStageIndexAction
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) SandBox.View.CharacterCreation.CharacterCreationStageViewBase.\_getCurrentStageIndexAction | | protected |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a547eb687388d540dce75af5e21acd2eb)\_getFurthestIndexAction
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) SandBox.View.CharacterCreation.CharacterCreationStageViewBase.\_getFurthestIndexAction | | protected |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a77dff1e0512312baf2ee23db13ca69b8)\_goToIndexAction
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ControlCharacterCreationStageWithInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#a4f8f1fb1c62a9074508b5c7faaacd519) SandBox.View.CharacterCreation.CharacterCreationStageViewBase.\_goToIndexAction | | protected |

[◆](class_sand_box_1_1_view_1_1_character_creation_1_1_character_creation_stage_view_base.html#a79153de8ec87d4963fca7cb9b5a40908)\_cameraPosition
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.View.CharacterCreation.CharacterCreationStageViewBase.\_cameraPosition = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)(6.45f, 4.35f, 1.6f) | | protected |


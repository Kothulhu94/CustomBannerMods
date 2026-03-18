--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html ---

SandBox.GauntletUI.BannerEditor.BannerEditorView Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BannerEditorView](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#aeaab121df282cb40ceddf8c85c9a4d69) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, [Banner](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a61cfccd2059c6d06c0ce3f20a48f40c7) banner, [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) affirmativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) affirmativeActionText, [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) negativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) negativeActionText, [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) onRefresh=null, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getCurrentStageIndexAction=null, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getTotalStageCountAction=null, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getFurthestIndexAction=null, [ControlCharacterCreationStageWithInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#a4f8f1fb1c62a9074508b5c7faaacd519) goToIndexAction=null) |
| void | [OnTick](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a813e84aeddb9724a816801ecbc47bdc7) (float dt) |
| void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#af1ae23554e36a75887558dde057f2237) () |
| void | [Exit](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a1a8dd7d78091623d8ca991001162df31) (bool isCancel) |
| void | [OnDeactivate](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a07905b7c722e455a18661b07a0bbc70c) () |
| void | [GoToIndex](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#add7df67e19558bd455d52d52ae9b7b8f) (int index) |

|  |  |
| --- | --- |
| Properties | |
| GauntletLayer | [GauntletLayer](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#ae6395ca108fc0a8a64cb62a4c5cd0420) `[get]` |
| [BannerEditorVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html) | [DataSource](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a71f6985fdada494369dc3f2f5943e3f1) `[get]` |
| Banner | [Banner](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a61cfccd2059c6d06c0ce3f20a48f40c7) `[get]` |
| SceneLayer | [SceneLayer](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a5e6e78dc2f901150c8fd638713d373b5) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#aeaab121df282cb40ceddf8c85c9a4d69)BannerEditorView()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.GauntletUI.BannerEditor.BannerEditorView.BannerEditorView | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, |
|  |  | [Banner](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a61cfccd2059c6d06c0ce3f20a48f40c7) | *banner*, |
|  |  | [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | *affirmativeAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *affirmativeActionText*, |
|  |  | [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | *negativeAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *negativeActionText*, |
|  |  | [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | *onRefresh* = null, |
|  |  | [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | *getCurrentStageIndexAction* = null, |
|  |  | [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | *getTotalStageCountAction* = null, |
|  |  | [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | *getFurthestIndexAction* = null, |
|  |  | [ControlCharacterCreationStageWithInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#a4f8f1fb1c62a9074508b5c7faaacd519) | *goToIndexAction* = null ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a813e84aeddb9724a816801ecbc47bdc7)OnTick()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.BannerEditor.BannerEditorView.OnTick | ( | float | *dt* | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#af1ae23554e36a75887558dde057f2237)OnFinalize()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.BannerEditor.BannerEditorView.OnFinalize | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a1a8dd7d78091623d8ca991001162df31)Exit()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.BannerEditor.BannerEditorView.Exit | ( | bool | *isCancel* | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a07905b7c722e455a18661b07a0bbc70c)OnDeactivate()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.BannerEditor.BannerEditorView.OnDeactivate | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#add7df67e19558bd455d52d52ae9b7b8f)GoToIndex()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.BannerEditor.BannerEditorView.GoToIndex | ( | int | *index* | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#ae6395ca108fc0a8a64cb62a4c5cd0420)GauntletLayer
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | GauntletLayer SandBox.GauntletUI.BannerEditor.BannerEditorView.GauntletLayer | | get |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a71f6985fdada494369dc3f2f5943e3f1)DataSource
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerEditorVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html) SandBox.GauntletUI.BannerEditor.BannerEditorView.DataSource | | get |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a61cfccd2059c6d06c0ce3f20a48f40c7)Banner
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner SandBox.GauntletUI.BannerEditor.BannerEditorView.Banner | | get |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_banner_editor_1_1_banner_editor_view.html#a5e6e78dc2f901150c8fd638713d373b5)SceneLayer
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SceneLayer SandBox.GauntletUI.BannerEditor.BannerEditorView.SceneLayer | | get |


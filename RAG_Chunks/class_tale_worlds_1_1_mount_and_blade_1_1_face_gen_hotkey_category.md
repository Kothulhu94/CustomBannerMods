--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html ---

TaleWorlds.MountAndBlade.FaceGenHotkeyCategory Class ReferencesealedInherits [TaleWorlds.InputSystem.GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FaceGenHotkeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#ac8ad24c84b119f0a4f5288c43ce6caee) () |
| Public Member Functions inherited from [TaleWorlds.InputSystem.GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) | |
| [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | [GetHotKey](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a5f9b6b468e6fb3743a1b23a88ba81a7e) (string hotKeyId) |
| [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | [GetGameKey](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a5194bc2e4bba063e78bbe6eb6a17de63) (int gameKeyId) |
| string | [GetHotKeyId](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#ac62a543460d12e58f6d2b12a19dbfb64) (string hotKeyId) |
| string | [GetHotKeyId](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a71eddd906845edef80ebbf8cc240aa4b) (int gameKeyId) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [CategoryId](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#af359bf943fbc23d0547cb5d301d641f1) = "FaceGenHotkeyCategory" |
| const string | [Zoom](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a0f20d4333328821868d4e4b5f7dd6fc0) = "Zoom" |
| const string | [Rotate](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a5782b0727599a2e2f5c5c4d7196aa67f) = "Rotate" |
| const string | [Ascend](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a08c562cb1a89dfcbc329c7352996f158) = "Ascend" |
| const string | [ControllerRotationAxis](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a19ef9ac3717397a841adbc84060052b2) = [GenericGameKeyContext.CameraAxisX](class_tale_worlds_1_1_mount_and_blade_1_1_generic_game_key_context.html#aa40d1b33d1d79506b6f2daf963e37fa4) |
| const string | [ControllerCameraUpDownAxis](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#aeed153721a926c551482da24f8a7f8b4) = [GenericGameKeyContext.CameraAxisY](class_tale_worlds_1_1_mount_and_blade_1_1_generic_game_key_context.html#ac24b1951cbd790ffc5f1abf4e65a63c2) |
| const string | [Copy](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a05b208878fa3be80bd9eae727f4fec5f) = "Copy" |
| const string | [Paste](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a7dc2d152d0eeba75e7437b15d7b5a0f3) = "Paste" |
| const int | [ControllerZoomIn](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a6dc7da21b39b72195edf467307c84dc9) = (int)[GameKeyDefinition.MapZoomIn](namespace_tale_worlds_1_1_mount_and_blade.html#aa9dabb3423d7d803e110f562f5792933a2847764df0fac6c64009b4bba5a2f89b) |
| const int | [ControllerZoomOut](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a52b82dff9eaaff0fec1d50100d662195) = (int)[GameKeyDefinition.MapZoomOut](namespace_tale_worlds_1_1_mount_and_blade.html#aa9dabb3423d7d803e110f562f5792933a3215eae98c0bb38107776148f3547a67) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.InputSystem.GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) | |
| enum | [GameKeyContextType](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82) {     [Default](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82a7a1920d61156abc05a60135aefe8bc67) ,     [AuxiliaryNotSerialized](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82affd7faf79e401bc9913c78a3590394ee) ,     [AuxiliarySerialized](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82ad222905473ec52d1d195ba98639a2f99) ,     [AuxiliarySerializedAndShownInOptions](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82a6890f0eb714d6ea923c4dcc5c2218776)   } |
| Protected Member Functions inherited from [TaleWorlds.InputSystem.GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) | |
|  | [GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a8435d435469d0b335dc84636efdbb2c7) (string id, int gameKeysCount, [GameKeyContextType](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82) type=[GameKeyContextType.Default](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82a7a1920d61156abc05a60135aefe8bc67)) |
| Properties inherited from [TaleWorlds.InputSystem.GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) | |
| string | [GameKeyCategoryId](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a54e9c345bb4dc9b1142f556174f85d4d) `[get]` |
| [GameKeyContextType](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82) | [Type](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#ac8fd8644925e643f8e87da7a54a3ba9a) `[get]` |
| MBReadOnlyList< [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) > | [RegisteredGameKeys](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0b26a920402598cb79fc3f600513536f) `[get]` |
| Dictionary< string, [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) >.ValueCollection | [RegisteredHotKeys](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#aed3334a958b4cb60a5a00a77b4b0e0a2) `[get]` |
| Dictionary< string, [GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) >.ValueCollection | [RegisteredGameAxisKeys](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#ad358faa8d6f73271cbb782c7afe7d8c9) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#ac8ad24c84b119f0a4f5288c43ce6caee)FaceGenHotkeyCategory()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.FaceGenHotkeyCategory.FaceGenHotkeyCategory | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#af359bf943fbc23d0547cb5d301d641f1)CategoryId
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.FaceGenHotkeyCategory.CategoryId = "FaceGenHotkeyCategory" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a0f20d4333328821868d4e4b5f7dd6fc0)Zoom
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.FaceGenHotkeyCategory.Zoom = "Zoom" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a5782b0727599a2e2f5c5c4d7196aa67f)Rotate
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.FaceGenHotkeyCategory.Rotate = "Rotate" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a08c562cb1a89dfcbc329c7352996f158)Ascend
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.FaceGenHotkeyCategory.Ascend = "Ascend" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a19ef9ac3717397a841adbc84060052b2)ControllerRotationAxis
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.FaceGenHotkeyCategory.ControllerRotationAxis = [GenericGameKeyContext.CameraAxisX](class_tale_worlds_1_1_mount_and_blade_1_1_generic_game_key_context.html#aa40d1b33d1d79506b6f2daf963e37fa4) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#aeed153721a926c551482da24f8a7f8b4)ControllerCameraUpDownAxis
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.FaceGenHotkeyCategory.ControllerCameraUpDownAxis = [GenericGameKeyContext.CameraAxisY](class_tale_worlds_1_1_mount_and_blade_1_1_generic_game_key_context.html#ac24b1951cbd790ffc5f1abf4e65a63c2) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a05b208878fa3be80bd9eae727f4fec5f)Copy
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.FaceGenHotkeyCategory.Copy = "Copy" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a7dc2d152d0eeba75e7437b15d7b5a0f3)Paste
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.FaceGenHotkeyCategory.Paste = "Paste" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a6dc7da21b39b72195edf467307c84dc9)ControllerZoomIn
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.FaceGenHotkeyCategory.ControllerZoomIn = (int)[GameKeyDefinition.MapZoomIn](namespace_tale_worlds_1_1_mount_and_blade.html#aa9dabb3423d7d803e110f562f5792933a2847764df0fac6c64009b4bba5a2f89b) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html#a52b82dff9eaaff0fec1d50100d662195)ControllerZoomOut
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.FaceGenHotkeyCategory.ControllerZoomOut = (int)[GameKeyDefinition.MapZoomOut](namespace_tale_worlds_1_1_mount_and_blade.html#aa9dabb3423d7d803e110f562f5792933a3215eae98c0bb38107776148f3547a67) | | static |


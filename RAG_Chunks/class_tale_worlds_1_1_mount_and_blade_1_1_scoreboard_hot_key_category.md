--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html ---

TaleWorlds.MountAndBlade.ScoreboardHotKeyCategory Class ReferencesealedInherits [TaleWorlds.InputSystem.GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ScoreboardHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#ae9d2048953f70de907bf34ef758e734f) () |
| Public Member Functions inherited from [TaleWorlds.InputSystem.GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) | |
| [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | [GetHotKey](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a5f9b6b468e6fb3743a1b23a88ba81a7e) (string hotKeyId) |
| [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | [GetGameKey](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a5194bc2e4bba063e78bbe6eb6a17de63) (int gameKeyId) |
| string | [GetHotKeyId](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#ac62a543460d12e58f6d2b12a19dbfb64) (string hotKeyId) |
| string | [GetHotKeyId](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a71eddd906845edef80ebbf8cc240aa4b) (int gameKeyId) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [CategoryId](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#a6bfff2a86b49700c83f532d1fc83c3fd) = "ScoreboardHotKeyCategory" |
| const int | [ShowMouse](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#a9a655e62b9ccf079ddda38159efe9e00) = (int)[GameKeyDefinition.ShowMouse](namespace_tale_worlds_1_1_mount_and_blade.html#aa9dabb3423d7d803e110f562f5792933a26a6834f8c8d9d065541b36816f8190f) |
| const string | [HoldShow](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#a948b64a8454124a1e12b718c940c0c82) = "HoldShow" |
| const string | [ToggleFastForward](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#a9eec311cb4298906cedf35d1d9392588) = "ToggleFastForward" |
| const string | [TogglePause](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#ab7d5e4fcf289951e1659a20f28f2ed7e) = "TogglePause" |
| const string | [MenuShowContextMenu](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#add6c6551fb0260b078ddddafa52f5c3f) = "MenuShowContextMenu" |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#ae9d2048953f70de907bf34ef758e734f)ScoreboardHotKeyCategory()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ScoreboardHotKeyCategory.ScoreboardHotKeyCategory | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#a6bfff2a86b49700c83f532d1fc83c3fd)CategoryId
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ScoreboardHotKeyCategory.CategoryId = "ScoreboardHotKeyCategory" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#a9a655e62b9ccf079ddda38159efe9e00)ShowMouse
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.ScoreboardHotKeyCategory.ShowMouse = (int)[GameKeyDefinition.ShowMouse](namespace_tale_worlds_1_1_mount_and_blade.html#aa9dabb3423d7d803e110f562f5792933a26a6834f8c8d9d065541b36816f8190f) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#a948b64a8454124a1e12b718c940c0c82)HoldShow
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ScoreboardHotKeyCategory.HoldShow = "HoldShow" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#a9eec311cb4298906cedf35d1d9392588)ToggleFastForward
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ScoreboardHotKeyCategory.ToggleFastForward = "ToggleFastForward" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#ab7d5e4fcf289951e1659a20f28f2ed7e)TogglePause
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ScoreboardHotKeyCategory.TogglePause = "TogglePause" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html#add6c6551fb0260b078ddddafa52f5c3f)MenuShowContextMenu
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ScoreboardHotKeyCategory.MenuShowContextMenu = "MenuShowContextMenu" | | static |


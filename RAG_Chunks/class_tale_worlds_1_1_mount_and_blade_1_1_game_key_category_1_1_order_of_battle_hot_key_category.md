--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_order_of_battle_hot_key_category.html ---

TaleWorlds.MountAndBlade.GameKeyCategory.OrderOfBattleHotKeyCategory Class ReferenceInherits [TaleWorlds.InputSystem.GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [OrderOfBattleHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_order_of_battle_hot_key_category.html#a9631e4494f939e5ed23042e56d60f7ca) () |
| Public Member Functions inherited from [TaleWorlds.InputSystem.GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) | |
| [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | [GetHotKey](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a5f9b6b468e6fb3743a1b23a88ba81a7e) (string hotKeyId) |
| [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | [GetGameKey](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a5194bc2e4bba063e78bbe6eb6a17de63) (int gameKeyId) |
| string | [GetHotKeyId](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#ac62a543460d12e58f6d2b12a19dbfb64) (string hotKeyId) |
| string | [GetHotKeyId](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a71eddd906845edef80ebbf8cc240aa4b) (int gameKeyId) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [CategoryId](class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_order_of_battle_hot_key_category.html#acac7967fb05a15639ca98815a9c35b1c) = "OrderOfBattleHotKeyCategory" |
| const string | [Confirm](class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_order_of_battle_hot_key_category.html#a65a8ab890ee3a79bc4caaa603428372a) = "Confirm" |
| const string | [Exit](class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_order_of_battle_hot_key_category.html#a7badf87f06cf27c1777a0105d7379067) = "Exit" |
| const string | [AutoDeploy](class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_order_of_battle_hot_key_category.html#a6718183cf0991322575cbbff14f7b038) = "AutoDeploy" |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_order_of_battle_hot_key_category.html#a9631e4494f939e5ed23042e56d60f7ca)OrderOfBattleHotKeyCategory()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GameKeyCategory.OrderOfBattleHotKeyCategory.OrderOfBattleHotKeyCategory | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_order_of_battle_hot_key_category.html#acac7967fb05a15639ca98815a9c35b1c)CategoryId
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.GameKeyCategory.OrderOfBattleHotKeyCategory.CategoryId = "OrderOfBattleHotKeyCategory" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_order_of_battle_hot_key_category.html#a65a8ab890ee3a79bc4caaa603428372a)Confirm
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.GameKeyCategory.OrderOfBattleHotKeyCategory.Confirm = "Confirm" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_order_of_battle_hot_key_category.html#a7badf87f06cf27c1777a0105d7379067)Exit
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.GameKeyCategory.OrderOfBattleHotKeyCategory.Exit = "Exit" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_order_of_battle_hot_key_category.html#a6718183cf0991322575cbbff14f7b038)AutoDeploy
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.GameKeyCategory.OrderOfBattleHotKeyCategory.AutoDeploy = "AutoDeploy" | | static |


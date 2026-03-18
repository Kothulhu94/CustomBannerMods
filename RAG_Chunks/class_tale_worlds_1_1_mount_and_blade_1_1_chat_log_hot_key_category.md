--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html ---

TaleWorlds.MountAndBlade.ChatLogHotKeyCategory Class ReferencesealedInherits [TaleWorlds.InputSystem.GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ChatLogHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#ad74b49407227e89b4ac280502ebabf56) () |
| Public Member Functions inherited from [TaleWorlds.InputSystem.GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) | |
| [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | [GetHotKey](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a5f9b6b468e6fb3743a1b23a88ba81a7e) (string hotKeyId) |
| [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | [GetGameKey](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a5194bc2e4bba063e78bbe6eb6a17de63) (int gameKeyId) |
| string | [GetHotKeyId](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#ac62a543460d12e58f6d2b12a19dbfb64) (string hotKeyId) |
| string | [GetHotKeyId](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a71eddd906845edef80ebbf8cc240aa4b) (int gameKeyId) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [CategoryId](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#aa61812ac209d6161b7d92c1735c7de68) = "ChatLogHotKeyCategory" |
| const int | [InitiateAllChat](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#afda8cb18e681159681cf114ae044dbbc) = (int)[GameKeyDefinition.InitiateAllChat](namespace_tale_worlds_1_1_mount_and_blade.html#aa9dabb3423d7d803e110f562f5792933a45cc399cf992b68f2070e8505eb0d7a0) |
| const int | [InitiateTeamChat](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#a5c0f08d1d97001f825639b2ec264c54e) = (int)[GameKeyDefinition.InitiateTeamChat](namespace_tale_worlds_1_1_mount_and_blade.html#aa9dabb3423d7d803e110f562f5792933a0cd0aaa60d6802eff0ae87f840bc11ff) |
| const int | [FinalizeChat](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#ae73ee693a4b0a27b5f05facb0fd01afe) = (int)[GameKeyDefinition.FinalizeChat](namespace_tale_worlds_1_1_mount_and_blade.html#aa9dabb3423d7d803e110f562f5792933a67726c7b81171edee6b9a994d48c3bab) |
| const string | [CycleChatTypes](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#a4189e130607ca5d7272cb1160fa91f21) = "CycleChatTypes" |
| const string | [FinalizeChatAlternative](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#afd3ec36de1091756cbe455c222e7663e) = "FinalizeChatAlternative" |
| const string | [SendMessage](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#a013247b61c721480808a77cca1bd30c9) = "SendMessage" |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#ad74b49407227e89b4ac280502ebabf56)ChatLogHotKeyCategory()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ChatLogHotKeyCategory.ChatLogHotKeyCategory | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#aa61812ac209d6161b7d92c1735c7de68)CategoryId
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ChatLogHotKeyCategory.CategoryId = "ChatLogHotKeyCategory" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#afda8cb18e681159681cf114ae044dbbc)InitiateAllChat
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.ChatLogHotKeyCategory.InitiateAllChat = (int)[GameKeyDefinition.InitiateAllChat](namespace_tale_worlds_1_1_mount_and_blade.html#aa9dabb3423d7d803e110f562f5792933a45cc399cf992b68f2070e8505eb0d7a0) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#a5c0f08d1d97001f825639b2ec264c54e)InitiateTeamChat
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.ChatLogHotKeyCategory.InitiateTeamChat = (int)[GameKeyDefinition.InitiateTeamChat](namespace_tale_worlds_1_1_mount_and_blade.html#aa9dabb3423d7d803e110f562f5792933a0cd0aaa60d6802eff0ae87f840bc11ff) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#ae73ee693a4b0a27b5f05facb0fd01afe)FinalizeChat
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.ChatLogHotKeyCategory.FinalizeChat = (int)[GameKeyDefinition.FinalizeChat](namespace_tale_worlds_1_1_mount_and_blade.html#aa9dabb3423d7d803e110f562f5792933a67726c7b81171edee6b9a994d48c3bab) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#a4189e130607ca5d7272cb1160fa91f21)CycleChatTypes
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ChatLogHotKeyCategory.CycleChatTypes = "CycleChatTypes" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#afd3ec36de1091756cbe455c222e7663e)FinalizeChatAlternative
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ChatLogHotKeyCategory.FinalizeChatAlternative = "FinalizeChatAlternative" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html#a013247b61c721480808a77cca1bd30c9)SendMessage
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ChatLogHotKeyCategory.SendMessage = "SendMessage" | | static |


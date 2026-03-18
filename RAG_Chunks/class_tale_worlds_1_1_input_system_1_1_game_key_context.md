--- SOURCE: class_tale_worlds_1_1_input_system_1_1_game_key_context.html ---

TaleWorlds.InputSystem.GameKeyContext Class ReferenceabstractInherited by [TaleWorlds.Engine.InputSystem.CheatsHotKeyCategory](class_tale_worlds_1_1_engine_1_1_input_system_1_1_cheats_hot_key_category.html), [TaleWorlds.Engine.InputSystem.DebugHotKeyCategory](class_tale_worlds_1_1_engine_1_1_input_system_1_1_debug_hot_key_category.html), [TaleWorlds.MountAndBlade.ArmyManagementHotkeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_army_management_hotkey_category.html), [TaleWorlds.MountAndBlade.BoardGameHotkeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_board_game_hotkey_category.html), [TaleWorlds.MountAndBlade.ChatLogHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_chat_log_hot_key_category.html), [TaleWorlds.MountAndBlade.CombatHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_combat_hot_key_category.html), [TaleWorlds.MountAndBlade.ConversationHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_conversation_hot_key_category.html), [TaleWorlds.MountAndBlade.CraftingHotkeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_crafting_hotkey_category.html), [TaleWorlds.MountAndBlade.FaceGenHotkeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen_hotkey_category.html), [TaleWorlds.MountAndBlade.GameKeyCategory.OrderOfBattleHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_order_of_battle_hot_key_category.html), [TaleWorlds.MountAndBlade.GameKeyCategory.PhotoModeHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_game_key_category_1_1_photo_mode_hot_key_category.html), [TaleWorlds.MountAndBlade.GenericCampaignPanelsGameKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_generic_campaign_panels_game_key_category.html), [TaleWorlds.MountAndBlade.GenericGameKeyContext](class_tale_worlds_1_1_mount_and_blade_1_1_generic_game_key_context.html), [TaleWorlds.MountAndBlade.GenericPanelGameKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_generic_panel_game_key_category.html), [TaleWorlds.MountAndBlade.InventoryHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_inventory_hot_key_category.html), [TaleWorlds.MountAndBlade.MapHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_map_hot_key_category.html), [TaleWorlds.MountAndBlade.MapNotificationHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_map_notification_hot_key_category.html), [TaleWorlds.MountAndBlade.MissionOrderHotkeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_mission_order_hotkey_category.html), [TaleWorlds.MountAndBlade.MultiplayerHotkeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_hotkey_category.html), [TaleWorlds.MountAndBlade.PartyHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_party_hot_key_category.html), [TaleWorlds.MountAndBlade.PollHotkeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_poll_hotkey_category.html), and [TaleWorlds.MountAndBlade.ScoreboardHotKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_scoreboard_hot_key_category.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [GameKeyContextType](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82) {     [Default](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82a7a1920d61156abc05a60135aefe8bc67) ,     [AuxiliaryNotSerialized](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82affd7faf79e401bc9913c78a3590394ee) ,     [AuxiliarySerialized](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82ad222905473ec52d1d195ba98639a2f99) ,     [AuxiliarySerializedAndShownInOptions](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82a6890f0eb714d6ea923c4dcc5c2218776)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | [GetHotKey](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a5f9b6b468e6fb3743a1b23a88ba81a7e) (string hotKeyId) |
| [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | [GetGameKey](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a5194bc2e4bba063e78bbe6eb6a17de63) (int gameKeyId) |
| string | [GetHotKeyId](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#ac62a543460d12e58f6d2b12a19dbfb64) (string hotKeyId) |
| string | [GetHotKeyId](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a71eddd906845edef80ebbf8cc240aa4b) (int gameKeyId) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a8435d435469d0b335dc84636efdbb2c7) (string id, int gameKeysCount, [GameKeyContextType](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82) type=[GameKeyContextType.Default](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82a7a1920d61156abc05a60135aefe8bc67)) |

|  |  |
| --- | --- |
| Properties | |
| string | [GameKeyCategoryId](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a54e9c345bb4dc9b1142f556174f85d4d) `[get]` |
| [GameKeyContextType](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82) | [Type](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#ac8fd8644925e643f8e87da7a54a3ba9a) `[get]` |
| MBReadOnlyList< [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) > | [RegisteredGameKeys](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0b26a920402598cb79fc3f600513536f) `[get]` |
| Dictionary< string, [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) >.ValueCollection | [RegisteredHotKeys](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#aed3334a958b4cb60a5a00a77b4b0e0a2) `[get]` |
| Dictionary< string, [GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) >.ValueCollection | [RegisteredGameAxisKeys](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#ad358faa8d6f73271cbb782c7afe7d8c9) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82)GameKeyContextType
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.InputSystem.GameKeyContext.GameKeyContextType](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82) |

| Enumerator | |
| --- | --- |
| Default |  |
| AuxiliaryNotSerialized |  |
| AuxiliarySerialized |  |
| AuxiliarySerializedAndShownInOptions |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a8435d435469d0b335dc84636efdbb2c7)GameKeyContext()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.InputSystem.GameKeyContext.GameKeyContext | ( | string | *id*, | |  |  | int | *gameKeysCount*, | |  |  | [GameKeyContextType](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82) | *type* = [GameKeyContextType::Default](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82a7a1920d61156abc05a60135aefe8bc67) ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a5f9b6b468e6fb3743a1b23a88ba81a7e)GetHotKey()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) TaleWorlds.InputSystem.GameKeyContext.GetHotKey | ( | string | *hotKeyId* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a5194bc2e4bba063e78bbe6eb6a17de63)GetGameKey()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) TaleWorlds.InputSystem.GameKeyContext.GetGameKey | ( | int | *gameKeyId* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#ac62a543460d12e58f6d2b12a19dbfb64)GetHotKeyId() [1/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.InputSystem.GameKeyContext.GetHotKeyId | ( | string | *hotKeyId* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a71eddd906845edef80ebbf8cc240aa4b)GetHotKeyId() [2/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.InputSystem.GameKeyContext.GetHotKeyId | ( | int | *gameKeyId* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a54e9c345bb4dc9b1142f556174f85d4d)GameKeyCategoryId
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.InputSystem.GameKeyContext.GameKeyCategoryId | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#ac8fd8644925e643f8e87da7a54a3ba9a)Type
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameKeyContextType](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0042744a657fb489111d7ad235281e82) TaleWorlds.InputSystem.GameKeyContext.Type | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#a0b26a920402598cb79fc3f600513536f)RegisteredGameKeys
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html)> TaleWorlds.InputSystem.GameKeyContext.RegisteredGameKeys | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#aed3334a958b4cb60a5a00a77b4b0e0a2)RegisteredHotKeys
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html)>.ValueCollection TaleWorlds.InputSystem.GameKeyContext.RegisteredHotKeys | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key_context.html#ad358faa8d6f73271cbb782c7afe7d8c9)RegisteredGameAxisKeys
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html)>.ValueCollection TaleWorlds.InputSystem.GameKeyContext.RegisteredGameAxisKeys | | get |


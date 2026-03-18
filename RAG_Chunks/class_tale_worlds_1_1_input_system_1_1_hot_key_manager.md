--- SOURCE: class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html ---

TaleWorlds.InputSystem.HotKeyManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnKeybindsChangedEvent](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a153ee279907adb96d11c101c25bfa101) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [GetHotKeyId](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#ac3d02e32726d43c0d263f9378734bbd5) (string categoryName, string hotKeyId) |
| static string | [GetHotKeyId](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a5c21ebc74c493d363b3335b1bf613ac6) (string categoryName, int hotKeyId) |
| static [GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) | [GetCategory](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a1e642f4116b3bbf40ea252f18850bc60) (string categoryName) |
| static Dictionary< string, [GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) >.ValueCollection | [GetAllCategories](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a056c0d095d44fbe345896c01b7b2538e) () |
| static void | [Tick](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a12fcb5faa98a95f0a370ea6f5a106dcd) (float dt) |
| static void | [Initialize](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a93cb4bf814557315875cefc455a75fec) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) savePath, bool isRDownSwappedWithRRight) |
| static void | [RegisterInitialContexts](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a2a443271a248b559b00ee9b8241e654c) (IEnumerable< [GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) > contexts, bool loadKeys) |
| static void | [RegisterContext](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a0c32a7fd86098e92fd224d9353aacdac) ([GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) context, bool ignoreSerialize=false, bool loadKeys=false) |
| static bool | [ShouldNotifyDocumentVersionDifferent](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a24838e156a608b4833cbc2d245cbce9d) () |
|  | Returns if notify about document version being different from the expected version. |
| static void | [Reset](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#af7545531dacebc91137cad320636fc0c) () |
| static async void | [LoadAsync](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a012897adb4336b8fa32e124530e2e99e) () |
| static async void | [SaveAsync](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a707e1bddb61c780be506ae5fc6e19b96) (bool throwEvent) |

|  |  |
| --- | --- |
| Events | |
| static [OnKeybindsChangedEvent](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a153ee279907adb96d11c101c25bfa101) | [OnKeybindsChanged](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a0bbea7c079456c0abc06d4f706e4bd6e) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a153ee279907adb96d11c101c25bfa101)OnKeybindsChangedEvent()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void TaleWorlds.InputSystem.HotKeyManager.OnKeybindsChangedEvent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#ac3d02e32726d43c0d263f9378734bbd5)GetHotKeyId() [1/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.InputSystem.HotKeyManager.GetHotKeyId | ( | string | *categoryName*, | |  |  | string | *hotKeyId* ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a5c21ebc74c493d363b3335b1bf613ac6)GetHotKeyId() [2/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.InputSystem.HotKeyManager.GetHotKeyId | ( | string | *categoryName*, | |  |  | int | *hotKeyId* ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a1e642f4116b3bbf40ea252f18850bc60)GetCategory()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) TaleWorlds.InputSystem.HotKeyManager.GetCategory | ( | string | *categoryName* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a056c0d095d44fbe345896c01b7b2538e)GetAllCategories()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | Dictionary< string, [GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) >.ValueCollection TaleWorlds.InputSystem.HotKeyManager.GetAllCategories | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a12fcb5faa98a95f0a370ea6f5a106dcd)Tick()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.InputSystem.HotKeyManager.Tick | ( | float | *dt* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a93cb4bf814557315875cefc455a75fec)Initialize()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.InputSystem.HotKeyManager.Initialize | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *savePath*, | |  |  | bool | *isRDownSwappedWithRRight* ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a2a443271a248b559b00ee9b8241e654c)RegisterInitialContexts()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.InputSystem.HotKeyManager.RegisterInitialContexts | ( | IEnumerable< [GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) > | *contexts*, | |  |  | bool | *loadKeys* ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a0c32a7fd86098e92fd224d9353aacdac)RegisterContext()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.InputSystem.HotKeyManager.RegisterContext | ( | [GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) | *context*, | |  |  | bool | *ignoreSerialize* = false, | |  |  | bool | *loadKeys* = false ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a24838e156a608b4833cbc2d245cbce9d)ShouldNotifyDocumentVersionDifferent()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.HotKeyManager.ShouldNotifyDocumentVersionDifferent | ( |  | ) |  | | static |

Returns

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#af7545531dacebc91137cad320636fc0c)Reset()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.InputSystem.HotKeyManager.Reset | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a012897adb4336b8fa32e124530e2e99e)LoadAsync()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | async void TaleWorlds.InputSystem.HotKeyManager.LoadAsync | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a707e1bddb61c780be506ae5fc6e19b96)SaveAsync()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | async void TaleWorlds.InputSystem.HotKeyManager.SaveAsync | ( | bool | *throwEvent* | ) |  | | static |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a0bbea7c079456c0abc06d4f706e4bd6e)OnKeybindsChanged
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnKeybindsChangedEvent](class_tale_worlds_1_1_input_system_1_1_hot_key_manager.html#a153ee279907adb96d11c101c25bfa101) TaleWorlds.InputSystem.HotKeyManager.OnKeybindsChanged | | static |


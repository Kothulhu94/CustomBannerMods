--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html ---

TaleWorlds.MountAndBlade.ChatBox Class ReferenceInherits [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnBeforeSave](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a16125e6eee7986836d4a55a7f57640d2) () |
| override void | [OnAfterSave](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a14be55071ef0aaa0424cfa1f305e07b8) () |
| void | [SendMessageToAll](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a8c7d26ca5681f13f783ef83b8900c2a4) (string message) |
| void | [SendMessageToAll](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a9e56d7262884926f8cb8e70ce80b30dc) (string message, List< [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) > receiverList) |
| void | [SendMessageToTeam](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a3a626cc7964e2ab0b5657b8927826023) (string message) |
| void | [SendMessageToTeam](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a2df37a27dfe292ea5a911b8c4a00fe3c) (string message, List< [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) > receiverList) |
| void | [SendMessageToWhisperTarget](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a8e90d9afa7ac05a76e022aa4dcb4fcca) (string message, string platformName, string whisperTarget) |
| void | [ResetMuteList](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ad286a68ec6968362047c15af1657d827) () |
| void | [SetPlayerMuted](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a89fc177c2a902b934b31ab3d6631d810) (PlayerId playerID, bool isMuted) |
| void | [SetPlayerMutedFromPlatform](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a80ecff8b41b0961185c9d0fe81f60b76) (PlayerId playerID, bool isMuted) |
| bool | [IsPlayerMuted](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ad41da74924fab97a96a24f40fcbbdbbc) (PlayerId player) |
|  | Returns if given player is muted from the game or platform. |
| bool | [IsPlayerMutedFromPlatform](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ae440feb53ec3d4da36ae119b5d50a8b4) (PlayerId player) |
| bool | [IsPlayerMutedFromGame](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a058b01d2fa7137d392c88aae596a89f2) (PlayerId player) |
| void | [SetChatFilterLists](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ad61545757b0559d5cdfad83f9d0d1376) (string[] profanityList, string[] allowList) |
| void | [InitializeForMultiplayer](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a4fea475005c08e7a3e2d4238eb6f5d7b) () |
| void | [InitializeForSinglePlayer](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a89bd430c08bfefcb3766774a08f4a395) () |
| void | [OnLogin](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ab0f460c9b1cc275811486624461cbddf) () |
| Public Member Functions inherited from [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html) | |
| void | [OnBeforeSave](class_tale_worlds_1_1_core_1_1_game_handler.html#aa870791b625cc2ccd8dfa82303fa3c55) () |
| void | [OnAfterSave](class_tale_worlds_1_1_core_1_1_game_handler.html#a314d506531637f8f16076c1a24ed3bfb) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [ServerSendServerMessageToEveryone](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a066988ad59d6cbb80935be28a8015903) (string message) |
| static void | [AddWhisperMessage](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ac810fdd296890bc167eada31bb2a5868) (string fromUserName, string messageBody) |
| static void | [AddErrorWhisperMessage](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a2bbfae4be3d086f679b754dcab041504) (string toUserName) |

|  |  |
| --- | --- |
| Public Attributes | |
| Action< [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html), string > | [OnMessageReceivedAtDedicatedServer](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#aa6b693a25c9f70f6e2b8b1200883b051) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [AdminMessageSoundEvent](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#aa5cbdc4cd6a0c24b5ea9827b1250cfaf) = "event:/ui/notification/alert" |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnGameStart](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a8a627a0313199c6f50977666458dbc12) () |
| override void | [OnGameEnd](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a70baa399d8c121a736be85ca43c45b6a) () |
| override void | [OnGameNetworkBegin](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a07e92e576fe76393f838b7fd09106ed4) () |
| override void | [OnGameNetworkEnd](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#aed218e359636246b8673f54af45dddf2) () |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a68d335a8542cf7112ae96207186d16d7) (float dt) |
| Protected Member Functions inherited from [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html) | |
| virtual void | [OnInitialize](class_tale_worlds_1_1_core_1_1_game_handler.html#a748ff17ecab120adae549cb72d6c0560) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_core_1_1_game_handler.html#acc5cd06df93b85f63268875deddc18c2) () |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsContentRestricted](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ab742c85899761a7c09c7c95818f3a0e7) = false `[get]` |
| bool | [NetworkReady](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a2a6455b336c10c8af5267c99695f88da) `[get]` |

|  |  |
| --- | --- |
| Events | |
| [PlayerMessageReceivedDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#a489a217477db7c4bfca1c58d8f9915f4) | [PlayerMessageReceived](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a4e3f7bece197070fa80ab9c2acd6f601) |
| [WhisperMessageSentDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#aeeefffa3608fc9d3fb30e0ee8f984b89) | [WhisperMessageSent](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a870a213c1d0541bc92e78c55c012340c) |
| [WhisperMessageReceivedDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#a3c6ab3e1db534000ac35ff476bcb622a) | [WhisperMessageReceived](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a8af825e51f466cf265e9327615a37dd8) |
| [ErrorWhisperMessageReceivedDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#a198ab97ed30b551cac0b275707bfc739) | [ErrorWhisperMessageReceived](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a6615a0911f57bf1d13ba90dc1a7e3600) |
| [ServerMessageDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#a0970d91b8202afe822cbe7556dff8da5) | [ServerMessage](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a8ea610e4efb21212b855f38cc108b42f) |
| [ServerAdminMessageDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#aad6322dd8ce01b3484dafb97729ea67e) | [ServerAdminMessage](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a061cc78c001a983f33916d2fffa251bd) |
| [PlayerMutedDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#ab5c2be44d28d410caa396fa47bfec125) | [OnPlayerMuteChanged](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a8ac0dd50b53971416488bf255e8c5190) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a8a627a0313199c6f50977666458dbc12)OnGameStart()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ChatBox.OnGameStart | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a16125e6eee7986836d4a55a7f57640d2)OnBeforeSave()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.ChatBox.OnBeforeSave | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a14be55071ef0aaa0424cfa1f305e07b8)OnAfterSave()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.ChatBox.OnAfterSave | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a70baa399d8c121a736be85ca43c45b6a)OnGameEnd()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ChatBox.OnGameEnd | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a8c7d26ca5681f13f783ef83b8900c2a4)SendMessageToAll() [1/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ChatBox.SendMessageToAll | ( | string | *message* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a9e56d7262884926f8cb8e70ce80b30dc)SendMessageToAll() [2/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ChatBox.SendMessageToAll | ( | string | *message*, |
|  |  | List< [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) > | *receiverList* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a3a626cc7964e2ab0b5657b8927826023)SendMessageToTeam() [1/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ChatBox.SendMessageToTeam | ( | string | *message* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a2df37a27dfe292ea5a911b8c4a00fe3c)SendMessageToTeam() [2/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ChatBox.SendMessageToTeam | ( | string | *message*, |
|  |  | List< [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) > | *receiverList* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a8e90d9afa7ac05a76e022aa4dcb4fcca)SendMessageToWhisperTarget()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ChatBox.SendMessageToWhisperTarget | ( | string | *message*, |
|  |  | string | *platformName*, |
|  |  | string | *whisperTarget* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a07e92e576fe76393f838b7fd09106ed4)OnGameNetworkBegin()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ChatBox.OnGameNetworkBegin | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#aed218e359636246b8673f54af45dddf2)OnGameNetworkEnd()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ChatBox.OnGameNetworkEnd | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a066988ad59d6cbb80935be28a8015903)ServerSendServerMessageToEveryone()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ChatBox.ServerSendServerMessageToEveryone | ( | string | *message* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ad286a68ec6968362047c15af1657d827)ResetMuteList()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ChatBox.ResetMuteList | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ac810fdd296890bc167eada31bb2a5868)AddWhisperMessage()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ChatBox.AddWhisperMessage | ( | string | *fromUserName*, | |  |  | string | *messageBody* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a2bbfae4be3d086f679b754dcab041504)AddErrorWhisperMessage()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ChatBox.AddErrorWhisperMessage | ( | string | *toUserName* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a89fc177c2a902b934b31ab3d6631d810)SetPlayerMuted()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ChatBox.SetPlayerMuted | ( | PlayerId | *playerID*, |
|  |  | bool | *isMuted* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a80ecff8b41b0961185c9d0fe81f60b76)SetPlayerMutedFromPlatform()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ChatBox.SetPlayerMutedFromPlatform | ( | PlayerId | *playerID*, |
|  |  | bool | *isMuted* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ad41da74924fab97a96a24f40fcbbdbbc)IsPlayerMuted()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ChatBox.IsPlayerMuted | ( | PlayerId | *player* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | player | Queried player's ID |

Returns
:   If the player is muted from either the [Platform](namespace_tale_worlds_1_1_library.html#aab3fe05d1610830a919823c10105cc1c)(PS / Xbox social menus) or Game(scoreboard, report).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ae440feb53ec3d4da36ae119b5d50a8b4)IsPlayerMutedFromPlatform()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ChatBox.IsPlayerMutedFromPlatform | ( | PlayerId | *player* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a058b01d2fa7137d392c88aae596a89f2)IsPlayerMutedFromGame()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ChatBox.IsPlayerMutedFromGame | ( | PlayerId | *player* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ad61545757b0559d5cdfad83f9d0d1376)SetChatFilterLists()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ChatBox.SetChatFilterLists | ( | string[] | *profanityList*, |
|  |  | string[] | *allowList* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a4fea475005c08e7a3e2d4238eb6f5d7b)InitializeForMultiplayer()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ChatBox.InitializeForMultiplayer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a89bd430c08bfefcb3766774a08f4a395)InitializeForSinglePlayer()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ChatBox.InitializeForSinglePlayer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ab0f460c9b1cc275811486624461cbddf)OnLogin()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ChatBox.OnLogin | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a68d335a8542cf7112ae96207186d16d7)OnTick()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ChatBox.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#aa5cbdc4cd6a0c24b5ea9827b1250cfaf)AdminMessageSoundEvent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ChatBox.AdminMessageSoundEvent = "event:/ui/notification/alert" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#aa6b693a25c9f70f6e2b8b1200883b051)OnMessageReceivedAtDedicatedServer
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html), string> TaleWorlds.MountAndBlade.ChatBox.OnMessageReceivedAtDedicatedServer |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#ab742c85899761a7c09c7c95818f3a0e7)IsContentRestricted
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ChatBox.IsContentRestricted = false | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a2a6455b336c10c8af5267c99695f88da)NetworkReady
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ChatBox.NetworkReady | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a4e3f7bece197070fa80ab9c2acd6f601)PlayerMessageReceived
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PlayerMessageReceivedDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#a489a217477db7c4bfca1c58d8f9915f4) TaleWorlds.MountAndBlade.ChatBox.PlayerMessageReceived |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a870a213c1d0541bc92e78c55c012340c)WhisperMessageSent
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WhisperMessageSentDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#aeeefffa3608fc9d3fb30e0ee8f984b89) TaleWorlds.MountAndBlade.ChatBox.WhisperMessageSent |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a8af825e51f466cf265e9327615a37dd8)WhisperMessageReceived
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WhisperMessageReceivedDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#a3c6ab3e1db534000ac35ff476bcb622a) TaleWorlds.MountAndBlade.ChatBox.WhisperMessageReceived |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a6615a0911f57bf1d13ba90dc1a7e3600)ErrorWhisperMessageReceived
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ErrorWhisperMessageReceivedDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#a198ab97ed30b551cac0b275707bfc739) TaleWorlds.MountAndBlade.ChatBox.ErrorWhisperMessageReceived |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a8ea610e4efb21212b855f38cc108b42f)ServerMessage
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ServerMessageDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#a0970d91b8202afe822cbe7556dff8da5) TaleWorlds.MountAndBlade.ChatBox.ServerMessage |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a061cc78c001a983f33916d2fffa251bd)ServerAdminMessage
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ServerAdminMessageDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#aad6322dd8ce01b3484dafb97729ea67e) TaleWorlds.MountAndBlade.ChatBox.ServerAdminMessage |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_chat_box.html#a8ac0dd50b53971416488bf255e8c5190)OnPlayerMuteChanged
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PlayerMutedDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#ab5c2be44d28d410caa396fa47bfec125) TaleWorlds.MountAndBlade.ChatBox.OnPlayerMuteChanged |


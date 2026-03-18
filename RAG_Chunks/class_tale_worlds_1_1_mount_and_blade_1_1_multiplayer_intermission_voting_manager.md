--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html ---

TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [MapItemAddedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a01619f5db27ebea8fe062efc74a2ea46) (string mapId) |
| delegate void | [CultureItemAddedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a5d762ef0de8f849df9e157db7976c5d5) (string cultureId) |
| delegate void | [MapItemVoteCountChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ae257ae90783990d3d2db66a1524377ca) (int mapItemIndex, int voteCount) |
| delegate void | [CultureItemVoteCountChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a5d793d80b5fa140030c8ffc08b2126b2) (int cultureItemIndex, int voteCount) |
|  | [MultiplayerIntermissionVotingManager](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a7c6cf6743c1f59046cfe42f6b4d5f8b1) () |
| void | [AddMapItem](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ac7ac4bc3ce648bdb220b85bd954cf0be) (string mapID) |
| void | [AddUsableMap](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a69b3113ad209ca9c06dedd565a353f97) ([CustomGameUsableMap](class_tale_worlds_1_1_mount_and_blade_1_1_custom_game_usable_map.html) usableMap) |
| List< string > | [GetUsableMaps](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a199786d9bf9de7b7dbcddb1144e4eec7) (string gameType) |
| void | [AddCultureItem](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a1f3e4eab7bb4b454660f289b753da9a5) (string cultureID) |
| void | [AddVote](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a437041d9c07b69b2debed79031d70ca4) (PlayerId voterID, string itemID, int voteCount) |
| void | [SetVotesOfMap](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a8c9a5d42b5beeb6692a28f4d964ceb10) (int mapItemIndex, int voteCount) |
| void | [SetVotesOfCulture](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a1b4f9fe59ec8a4ecdf3b5830a1e83495) (int cultureItemIndex, int voteCount) |
| void | [ClearVotes](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#acc0e2871b021961c4b61f0f308ec9e59) () |
| void | [ClearItems](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ad33cc71a1bc4f178a41ee4ccb2367ae0) () |
| bool | [IsCultureItem](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#acb651f18a3d94cb420d94fb355098ec7) (string itemID) |
| bool | [IsMapItem](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a47e7a566d28891ea6d0046c081d4827f) (string itemID) |
| void | [HandlePlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a93110ffaf733b7304d5967f20d09ba17) (PlayerId playerID) |
| void | [SelectRandomCultures](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a0cf9f66d4a1dcc748d952943b7148643) ([MultiplayerOptions.MultiplayerOptionsAccessMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574) accessMode) |
| bool | [IsPeerVotedForItem](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ac00e32e55084997716443be048d69b62) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) peer, string itemID) |
| void | [SortVotesAndPickBest](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a985665a10eae9b1f3389e34a2c0b330a) () |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [IsAutomatedBattleSwitchingEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#afb563497960b4ef22620ca7954e66fae) |
| bool | [IsMapVoteEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ab2f5f6e91f6baeb8c2ec7684ecba8d87) |
| bool | [IsCultureVoteEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a843246daae8661fe50bc13bef0ecc0d1) |
| bool | [IsDisableMapVoteOverride](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#aafb40364f1909247bf9787ad4dee4a39) |
| bool | [IsDisableCultureVoteOverride](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a3a0980d2649436509e01dc1bd48b2c68) |
| bool | [IsMapSelectedByAdmin](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#aa72822e31e08db4de62ffac15f3f7880) |
| string | [InitialGameType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ae9f86e4fba17ee0f22fdef6117081bb1) = null |
| [MultiplayerIntermissionState](namespace_tale_worlds_1_1_mount_and_blade.html#a2bfb5cd35ce7c8036a28d0e0c8b4d793) | [CurrentVoteState](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a8038b857f244889423c9c3e97bc7b8e1) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MaxAllowedMapCount](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a7bf5ed726f47999e4bc54c945ccdd3e7) = 100 |

|  |  |
| --- | --- |
| Properties | |
| static [MultiplayerIntermissionVotingManager](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a7c6cf6743c1f59046cfe42f6b4d5f8b1) | [Instance](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a6286c2a75872059f6426da7ad4a7e96b) `[get]` |
| List< [IntermissionVoteItem](class_tale_worlds_1_1_mount_and_blade_1_1_intermission_vote_item.html) > | [MapVoteItems](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ac15d2a0a6f12b8d7b23ce70a25d78d54) `[get]` |
| List< [IntermissionVoteItem](class_tale_worlds_1_1_mount_and_blade_1_1_intermission_vote_item.html) > | [CultureVoteItems](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#aec373f91ce3c0ea17502ced58855c19f) `[get]` |
| List< [CustomGameUsableMap](class_tale_worlds_1_1_mount_and_blade_1_1_custom_game_usable_map.html) > | [UsableMaps](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#af225b165f245a4d1567bf9bdf8e5761e) `[get]` |

|  |  |
| --- | --- |
| Events | |
| [MapItemAddedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a01619f5db27ebea8fe062efc74a2ea46) | [OnMapItemAdded](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a7db95d2501528e1f9f64652a4270ee51) |
| [CultureItemAddedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a5d762ef0de8f849df9e157db7976c5d5) | [OnCultureItemAdded](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a73088ba8999e3b7fd7f1b5a21b27998d) |
| [MapItemVoteCountChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ae257ae90783990d3d2db66a1524377ca) | [OnMapItemVoteCountChanged](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#adfcc7e9afcf3f1471b573721ce99848f) |
| [CultureItemVoteCountChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a5d793d80b5fa140030c8ffc08b2126b2) | [OnCultureItemVoteCountChanged](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a9bfc309f2f84652739acba658a963027) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a7c6cf6743c1f59046cfe42f6b4d5f8b1)MultiplayerIntermissionVotingManager()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.MultiplayerIntermissionVotingManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a01619f5db27ebea8fe062efc74a2ea46)MapItemAddedDelegate()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.MapItemAddedDelegate | ( | string | *mapId* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a5d762ef0de8f849df9e157db7976c5d5)CultureItemAddedDelegate()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.CultureItemAddedDelegate | ( | string | *cultureId* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ae257ae90783990d3d2db66a1524377ca)MapItemVoteCountChangedDelegate()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.MapItemVoteCountChangedDelegate | ( | int | *mapItemIndex*, |
|  |  | int | *voteCount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a5d793d80b5fa140030c8ffc08b2126b2)CultureItemVoteCountChangedDelegate()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.CultureItemVoteCountChangedDelegate | ( | int | *cultureItemIndex*, |
|  |  | int | *voteCount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ac7ac4bc3ce648bdb220b85bd954cf0be)AddMapItem()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.AddMapItem | ( | string | *mapID* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a69b3113ad209ca9c06dedd565a353f97)AddUsableMap()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.AddUsableMap | ( | [CustomGameUsableMap](class_tale_worlds_1_1_mount_and_blade_1_1_custom_game_usable_map.html) | *usableMap* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a199786d9bf9de7b7dbcddb1144e4eec7)GetUsableMaps()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< string > TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.GetUsableMaps | ( | string | *gameType* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a1f3e4eab7bb4b454660f289b753da9a5)AddCultureItem()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.AddCultureItem | ( | string | *cultureID* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a437041d9c07b69b2debed79031d70ca4)AddVote()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.AddVote | ( | PlayerId | *voterID*, |
|  |  | string | *itemID*, |
|  |  | int | *voteCount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a8c9a5d42b5beeb6692a28f4d964ceb10)SetVotesOfMap()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.SetVotesOfMap | ( | int | *mapItemIndex*, |
|  |  | int | *voteCount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a1b4f9fe59ec8a4ecdf3b5830a1e83495)SetVotesOfCulture()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.SetVotesOfCulture | ( | int | *cultureItemIndex*, |
|  |  | int | *voteCount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#acc0e2871b021961c4b61f0f308ec9e59)ClearVotes()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.ClearVotes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ad33cc71a1bc4f178a41ee4ccb2367ae0)ClearItems()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.ClearItems | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#acb651f18a3d94cb420d94fb355098ec7)IsCultureItem()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.IsCultureItem | ( | string | *itemID* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a47e7a566d28891ea6d0046c081d4827f)IsMapItem()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.IsMapItem | ( | string | *itemID* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a93110ffaf733b7304d5967f20d09ba17)HandlePlayerDisconnect()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.HandlePlayerDisconnect | ( | PlayerId | *playerID* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a0cf9f66d4a1dcc748d952943b7148643)SelectRandomCultures()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.SelectRandomCultures | ( | [MultiplayerOptions.MultiplayerOptionsAccessMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574) | *accessMode* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ac00e32e55084997716443be048d69b62)IsPeerVotedForItem()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.IsPeerVotedForItem | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *peer*, |
|  |  | string | *itemID* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a985665a10eae9b1f3389e34a2c0b330a)SortVotesAndPickBest()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.SortVotesAndPickBest | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a7bf5ed726f47999e4bc54c945ccdd3e7)MaxAllowedMapCount
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.MaxAllowedMapCount = 100 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#afb563497960b4ef22620ca7954e66fae)IsAutomatedBattleSwitchingEnabled
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.IsAutomatedBattleSwitchingEnabled |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ab2f5f6e91f6baeb8c2ec7684ecba8d87)IsMapVoteEnabled
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.IsMapVoteEnabled |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a843246daae8661fe50bc13bef0ecc0d1)IsCultureVoteEnabled
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.IsCultureVoteEnabled |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#aafb40364f1909247bf9787ad4dee4a39)IsDisableMapVoteOverride
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.IsDisableMapVoteOverride |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a3a0980d2649436509e01dc1bd48b2c68)IsDisableCultureVoteOverride
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.IsDisableCultureVoteOverride |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#aa72822e31e08db4de62ffac15f3f7880)IsMapSelectedByAdmin
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.IsMapSelectedByAdmin |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ae9f86e4fba17ee0f22fdef6117081bb1)InitialGameType
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.InitialGameType = null |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a8038b857f244889423c9c3e97bc7b8e1)CurrentVoteState
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MultiplayerIntermissionState](namespace_tale_worlds_1_1_mount_and_blade.html#a2bfb5cd35ce7c8036a28d0e0c8b4d793) TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.CurrentVoteState |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a6286c2a75872059f6426da7ad4a7e96b)Instance
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MultiplayerIntermissionVotingManager](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a7c6cf6743c1f59046cfe42f6b4d5f8b1) TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.Instance | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ac15d2a0a6f12b8d7b23ce70a25d78d54)MapVoteItems
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[IntermissionVoteItem](class_tale_worlds_1_1_mount_and_blade_1_1_intermission_vote_item.html)> TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.MapVoteItems | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#aec373f91ce3c0ea17502ced58855c19f)CultureVoteItems
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[IntermissionVoteItem](class_tale_worlds_1_1_mount_and_blade_1_1_intermission_vote_item.html)> TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.CultureVoteItems | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#af225b165f245a4d1567bf9bdf8e5761e)UsableMaps
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[CustomGameUsableMap](class_tale_worlds_1_1_mount_and_blade_1_1_custom_game_usable_map.html)> TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.UsableMaps | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a7db95d2501528e1f9f64652a4270ee51)OnMapItemAdded
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MapItemAddedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a01619f5db27ebea8fe062efc74a2ea46) TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.OnMapItemAdded |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a73088ba8999e3b7fd7f1b5a21b27998d)OnCultureItemAdded
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CultureItemAddedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a5d762ef0de8f849df9e157db7976c5d5) TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.OnCultureItemAdded |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#adfcc7e9afcf3f1471b573721ce99848f)OnMapItemVoteCountChanged
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MapItemVoteCountChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#ae257ae90783990d3d2db66a1524377ca) TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.OnMapItemVoteCountChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a9bfc309f2f84652739acba658a963027)OnCultureItemVoteCountChanged
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CultureItemVoteCountChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_intermission_voting_manager.html#a5d793d80b5fa140030c8ffc08b2126b2) TaleWorlds.MountAndBlade.MultiplayerIntermissionVotingManager.OnCultureItemVoteCountChanged |


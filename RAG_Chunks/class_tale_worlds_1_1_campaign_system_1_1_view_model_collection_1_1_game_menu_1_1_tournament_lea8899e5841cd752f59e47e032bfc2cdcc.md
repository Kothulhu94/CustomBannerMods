--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Classes | |
| class | [ItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea33c97dda0b32f8bed58a9977b8ab0d5c.html) |
| class | [ItemNameComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lead68bf9336dbb55845abb05c67c066144.html) |
| class | [ItemPrizeComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_leae58ea2d6da20b647ad60905ada8192f2.html) |
| class | [ItemPlacementComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lead1ab79be63dc569d37266d03ec93ac5d.html) |
| class | [ItemVictoriesComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea64fccc95d3e288511611f7a53ca6962c.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TournamentLeaderboardSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a2a49c3c6389ba71cdfcb3f16b11e736a) (ref MBBindingList< [TournamentLeaderboardEntryItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea0458dfc9400c15bfbe9e93e62e77406a.html) > listToControl) |
| void | [ExecuteSortByName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a83d0d10f49404a05cce576730076e439) () |
| void | [ExecuteSortByPrize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#acfa1b783d2db288cdff2d8311f05d300) () |
| void | [ExecuteSortByPlacement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#af7bc3c635de87e6372c4322bc1aa0cee) () |
| void | [ExecuteSortByVictories](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#ac7cc6558222d67a2b43a9260296e0c89) () |
| Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| void | [OnPropertyChanged](class_tale_worlds_1_1_library_1_1_view_model.html#a1a9dee9bab5986a33083d31a689dc7fe) ([CallerMemberName] string propertyName=null) |
|  | Method for notifying binded views about the changes in a property. Uses reflection to get the value of the property. If reflection is not needed or updated value of the property is already known, use [OnPropertyChangedWithValue()](class_tale_worlds_1_1_library_1_1_view_model.html#a0d6928eeec2b43ac9ae089830783bd7f) instead. |
| void | [OnPropertyChangedWithValue< T >](class_tale_worlds_1_1_library_1_1_view_model.html#ae5000d209ee6d4e7baec2fa8e8803c7e) (T value, [CallerMemberName]string propertyName=null) |
|  | Faster method for notifying binded views about the changes in a property. To avoid reflection, caller can pass changed value to this method. If caller does not have access rights to the value, use [OnPropertyChanged()](class_tale_worlds_1_1_library_1_1_view_model.html#a1a9dee9bab5986a33083d31a689dc7fe "Method for notifying binded views about the changes in a property. Uses reflection to get the value o...") instead. |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a0d6928eeec2b43ac9ae089830783bd7f) (bool value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#abf208d3c50803f5d1f70fa658c21dc96) (int value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a991eb5001ba6210a9fefb4a69f8883c2) (float value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#ac54722f74e27aa6143d62a9dc589fb95) (uint value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a62ff1ab710820c9583a4b6ee66bb05e8) ([Color](struct_tale_worlds_1_1_library_1_1_color.html) value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#adb40c37120d9480a9c61934104b3b0ee) (double value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3298a1b9a60a7057cac4df839915f49d) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) value, [CallerMemberName] string propertyName=null) |
| object | [GetViewModelAtPath](class_tale_worlds_1_1_library_1_1_view_model.html#adab1a5fac562c67766ef900113c2fd48) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) path, bool isList) |
| object | [GetViewModelAtPath](class_tale_worlds_1_1_library_1_1_view_model.html#a58ad0a333f63aeb396cf0282a65b3b73) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) path) |
| object | [GetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#a870f5daf5e6f307138260ee84406bd4e) (string name, [PropertyTypeFeeder](namespace_tale_worlds_1_1_library.html#a74850bfe0b5488f44574810b7462b0f7) propertyTypeFeeder) |
| object | [GetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#a6c761a8baf9a75c1d8fd65dbaed24055) (string name) |
| Type | [GetPropertyType](class_tale_worlds_1_1_library_1_1_view_model.html#ade14a4f33f7022fa0b20393db6e5f1b1) (string name) |
| void | [SetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#ad53397f315ef866a738a5e65556043df) (string name, object value) |
| virtual void | [OnFinalize](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc) () |
| void | [ExecuteCommand](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb) (string commandName, object[] parameters) |
| virtual void | [RefreshValues](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd) () |
|  | Used for updating localized texts. |

|  |  |
| --- | --- |
| Properties | |
| int | [NameState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a665adecf2d3077b1b12fa083f332f6ea) `[get, set]` |
| int | [VictoriesState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a922a2fcb802f1996ec0b40e6e43ec63f) `[get, set]` |
| int | [PrizeState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a3da4e5ab18fdbd077236e95ddfb020ae) `[get, set]` |
| int | [PlacementState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#ac8dcd6b695ccf5b4ade8abd39bb0e525) `[get, set]` |
| bool | [IsNameSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a22600fb0ba6a843859b3df04d57b3a32) `[get, set]` |
| bool | [IsPrizeSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#ab0596ed1f376e0b472b530b71f5849db) `[get, set]` |
| bool | [IsPlacementSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#ae26ae99a23f32fc990791e5b5e25ba7f) `[get, set]` |
| bool | [IsVictoriesSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a068f6be94449dffababfd5d3e6955a7a) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |
| Events inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| PropertyChangedEventHandler | [PropertyChanged](class_tale_worlds_1_1_library_1_1_view_model.html#a7f8d83700f17f8092632c1eaa406d665) `[add, remove]` |
| [PropertyChangedWithValueEventHandler](namespace_tale_worlds_1_1_library.html#aa511552e184232616e64f386cf1146b5) | [PropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#acad8d628c31163e3022bea1e04675de6) `[add, remove]` |
| [PropertyChangedWithBoolValueEventHandler](namespace_tale_worlds_1_1_library.html#a6b0d7e614739868a8f81c53a64f081bd) | [PropertyChangedWithBoolValue](class_tale_worlds_1_1_library_1_1_view_model.html#a4d3b2d6f05fc919dca9e764b9e36af5d) `[add, remove]` |
| [PropertyChangedWithIntValueEventHandler](namespace_tale_worlds_1_1_library.html#a91bc6d8c78c447d9acf86771f3b3e932) | [PropertyChangedWithIntValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3b31df15300b9652b9b5f664e03a5af9) `[add, remove]` |
| [PropertyChangedWithFloatValueEventHandler](namespace_tale_worlds_1_1_library.html#aa44f77d2af0c3adb609a79640e080914) | [PropertyChangedWithFloatValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3cb9bd971256835c5f6169cb58d67470) `[add, remove]` |
| [PropertyChangedWithUIntValueEventHandler](namespace_tale_worlds_1_1_library.html#aec7149fde7f195f3c4b4f10c4ce23cb8) | [PropertyChangedWithUIntValue](class_tale_worlds_1_1_library_1_1_view_model.html#a197c48c4f8ba00372fc86a548ccb86f7) `[add, remove]` |
| [PropertyChangedWithColorValueEventHandler](namespace_tale_worlds_1_1_library.html#a90de79687e9792b5065a8a4e9c30eeac) | [PropertyChangedWithColorValue](class_tale_worlds_1_1_library_1_1_view_model.html#aea6e76a6562fbdf20688565257699162) `[add, remove]` |
| [PropertyChangedWithDoubleValueEventHandler](namespace_tale_worlds_1_1_library.html#a8ce8e1aa20a71b9da4d1655fe04b089b) | [PropertyChangedWithDoubleValue](class_tale_worlds_1_1_library_1_1_view_model.html#a7d6e829c2ae2ef0147ca5f05e554dfc4) `[add, remove]` |
| [PropertyChangedWithVec2ValueEventHandler](namespace_tale_worlds_1_1_library.html#aa3ec79ffa85e522745c02340a7a41f2e) | [PropertyChangedWithVec2Value](class_tale_worlds_1_1_library_1_1_view_model.html#a8d1fb5f70c9230599a24b5d89a9a18f4) `[add, remove]` |
| Events inherited from [TaleWorlds.Library.IViewModel](interface_tale_worlds_1_1_library_1_1_i_view_model.html) | |
| [PropertyChangedWithValueEventHandler](namespace_tale_worlds_1_1_library.html#aa511552e184232616e64f386cf1146b5) | [PropertyChangedWithValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a19415fe20feafa29a4e6d8d61dd95834) |
| [PropertyChangedWithBoolValueEventHandler](namespace_tale_worlds_1_1_library.html#a6b0d7e614739868a8f81c53a64f081bd) | [PropertyChangedWithBoolValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ae0ed3e57e466612e46fcf77b394b9ba6) |
| [PropertyChangedWithIntValueEventHandler](namespace_tale_worlds_1_1_library.html#a91bc6d8c78c447d9acf86771f3b3e932) | [PropertyChangedWithIntValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ad33c6216fef22f2e150e0c0673c3c6ef) |
| [PropertyChangedWithFloatValueEventHandler](namespace_tale_worlds_1_1_library.html#aa44f77d2af0c3adb609a79640e080914) | [PropertyChangedWithFloatValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#acef7bf697f161b4c0d742215107b0b8b) |
| [PropertyChangedWithUIntValueEventHandler](namespace_tale_worlds_1_1_library.html#aec7149fde7f195f3c4b4f10c4ce23cb8) | [PropertyChangedWithUIntValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#afd24d3b78a5e7fab669c340045b8533f) |
| [PropertyChangedWithColorValueEventHandler](namespace_tale_worlds_1_1_library.html#a90de79687e9792b5065a8a4e9c30eeac) | [PropertyChangedWithColorValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a3bc123550acc0a47f8c061c5a8300fa1) |
| [PropertyChangedWithDoubleValueEventHandler](namespace_tale_worlds_1_1_library.html#a8ce8e1aa20a71b9da4d1655fe04b089b) | [PropertyChangedWithDoubleValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a4b1a715b622570235d8224ecef32dc13) |
| [PropertyChangedWithVec2ValueEventHandler](namespace_tale_worlds_1_1_library.html#aa3ec79ffa85e522745c02340a7a41f2e) | [PropertyChangedWithVec2Value](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a5b8667b3ad8595517ada80e2928bd6ab) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a2a49c3c6389ba71cdfcb3f16b11e736a)TournamentLeaderboardSortControllerVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.TournamentLeaderboardSortControllerVM | ( | ref MBBindingList< [TournamentLeaderboardEntryItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea0458dfc9400c15bfbe9e93e62e77406a.html) > | *listToControl* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a83d0d10f49404a05cce576730076e439)ExecuteSortByName()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.ExecuteSortByName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#acfa1b783d2db288cdff2d8311f05d300)ExecuteSortByPrize()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.ExecuteSortByPrize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#af7bc3c635de87e6372c4322bc1aa0cee)ExecuteSortByPlacement()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.ExecuteSortByPlacement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#ac7cc6558222d67a2b43a9260296e0c89)ExecuteSortByVictories()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.ExecuteSortByVictories | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a665adecf2d3077b1b12fa083f332f6ea)NameState
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.NameState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a922a2fcb802f1996ec0b40e6e43ec63f)VictoriesState
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.VictoriesState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a3da4e5ab18fdbd077236e95ddfb020ae)PrizeState
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.PrizeState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#ac8dcd6b695ccf5b4ade8abd39bb0e525)PlacementState
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.PlacementState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a22600fb0ba6a843859b3df04d57b3a32)IsNameSelected
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.IsNameSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#ab0596ed1f376e0b472b530b71f5849db)IsPrizeSelected
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.IsPrizeSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#ae26ae99a23f32fc990791e5b5e25ba7f)IsPlacementSelected
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.IsPlacementSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_tournament_lea8899e5841cd752f59e47e032bfc2cdcc.html#a068f6be94449dffababfd5d3e6955a7a)IsVictoriesSelected
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TournamentLeaderboard.TournamentLeaderboardSortControllerVM.IsVictoriesSelected | | getset |


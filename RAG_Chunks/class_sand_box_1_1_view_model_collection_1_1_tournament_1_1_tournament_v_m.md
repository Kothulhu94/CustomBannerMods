--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html ---

SandBox.ViewModelCollection.Tournament.TournamentVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TournamentVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aa8da880fc7bded60040722794e946617) (Action disableUI, [TournamentBehavior](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html) tournamentBehavior) |
| override void | [RefreshValues](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a456c8b5361e19760ee924c5e98ac7475) () |
|  | Used for updating localized texts. |
| void | [ExecuteBet](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ad2e07e24d824467507f4f57ff033e33d) () |
| void | [ExecuteJoinTournament](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ab41eb4beb161fb8d9b25d3f870b3e30d) () |
| void | [ExecuteSkipRound](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aafccba282a886d0c00412440c37081b3) () |
| void | [ExecuteSkipAllRounds](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a4418b4775c0c908362c8ff1b9280f20e) () |
| void | [ExecuteWatchRound](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#af1642752ccf2cb61f7bb6e6a1909d60e) () |
| void | [ExecuteLeave](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a17d09a14df4a49efd8b5d2c5b6c9ac7a) () |
| void | [Refresh](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9634ce045881dc76e66d13fa7b80f42f) () |
| void | [OnAgentRemoved](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a544c389e308357d3dbc059d23de0253d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [ExecuteShowPrizeItemTooltip](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a2f8a6acd3d008bcf9317560a158de8af) () |
| void | [ExecuteHidePrizeItemTooltip](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#affaa43a829c49db4cf82e3e814b3c55f) () |
| override void | [OnFinalize](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a827c3c99aee50fa86c72f12fbce542ed) () |
| void | [SetDoneInputKey](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a251db71cf7180f8b733562449e632024) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetCancelInputKey](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a2e4938774f3699be251c0d715ffc7a18) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| void | [ExecuteCommand](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb) (string commandName, object[] parameters) |

|  |  |
| --- | --- |
| Properties | |
| Action | [DisableUI](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a3aec3440efc4a44e00e5644910f5e136) `[get]` |
| [TournamentBehavior](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html) | [Tournament](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a857dd95dd35cc57bf36db7b3f8367358) `[get]` |
| [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a82b5bcd9e567f6311f1ad081f7d02e38) `[get, set]` |
| [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a6829cf8e7a1354870b0d4a850815a1eb) `[get, set]` |
| string | [TournamentWinnerTitle](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ae9caaf34ee6b005ca95097409809b1a7) `[get, set]` |
| [TournamentParticipantVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_participant_v_m.html) | [TournamentWinner](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9d3453de5ecba2ecc3d1ea99a699e74a) `[get, set]` |
| int | [MaximumBetValue](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aea2d9da44582832b9d4744ae2a4b8dde) `[get, set]` |
| bool | [IsBetButtonEnabled](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9e3819752cf020bf508eb56deaefd73b) `[get]` |
| string | [BetText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#afe1ed467da4eb40b932bff998fff4bde) `[get, set]` |
| string | [BetTitleText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a22729a38b172b8cc9d54a7692ad81e9a) `[get, set]` |
| string | [CurrentWagerText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ad34737021140bae41ce198b9f2b08916) `[get, set]` |
| string | [BetDescriptionText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aefdf17dfdbec8921a3621958a3fa2bf5) `[get, set]` |
| [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) | [PrizeVisual](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a3a6b955d26b26ef3576b793e43f0575e) `[get, set]` |
| string | [PrizeItemName](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a8daafb08b567596b0dd4426c7ce4e228) `[get, set]` |
| string | [TournamentPrizeText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9ec24d33dd1c1af9805f57d027e806dc) `[get, set]` |
| int | [WageredDenars](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a3374eed82dd94502f16bdae6492904b9) `[get, set]` |
| int | [ExpectedBetDenars](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a2cf7e8287592ee15a95b882c545e200b) `[get, set]` |
| string | [BetOddsText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ae4a75293fb44e81b4ad1fa4c9758bbe0) `[get, set]` |
| string | [BettedDenarsText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a4ecc0be736b20f17c9c769a26b0985c0) `[get, set]` |
| string | [OverallExpectedDenarsText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9232344d9476c276ba70086f6526cfc9) `[get, set]` |
| string | [CurrentExpectedDenarsText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ad24d83880800e65832d2045704d639f8) `[get, set]` |
| string | [TotalDenarsText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a999a1f703b1df84abc9d7fb9f031b3d5) `[get, set]` |
| string | [AcceptText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ab082e8799c4b1d1e3ccaf9bf01b34c5d) `[get, set]` |
| string | [CancelText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a6c07741b8d1c4de31874d63f0957bcda) `[get, set]` |
| bool | [IsCurrentMatchActive](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aa2109e01a61f67154c831ddb153bcc66) `[get, set]` |
| [TournamentMatchVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_match_v_m.html) | [CurrentMatch](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a8cb2e3d83e838b32035f4f90571953fd) `[get, set]` |
| bool | [IsTournamentIncomplete](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9e4f5c5f78bb9f21df99abfb785cd04f) `[get, set]` |
| int | [ActiveRoundIndex](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aa066085280d3a11b3663474bfd5c1ab6) `[get, set]` |
| bool | [CanPlayerJoin](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a0037277b5af1954def8f5c675b5f257b) `[get, set]` |
| bool | [HasPrizeItem](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ac5f63eb1f4d5dba52094e6c3043c16e8) `[get, set]` |
| string | [JoinTournamentText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a74f397e69edd32226460598dac1a15bd) `[get, set]` |
| string | [SkipRoundText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ac1dcb5300515336e63637c9fd637fbeb) `[get, set]` |
| string | [WatchRoundText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a51cb7f3e98f36dd7226c65fd6049486a) `[get, set]` |
| string | [LeaveText](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a815e9739d180eb3f107cd68b9f3fd2b1) `[get, set]` |
| [TournamentRoundVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_round_v_m.html) | [Round1](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a1cfda89134157b6ca417e0d0aa76b9b4) `[get, set]` |
| [TournamentRoundVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_round_v_m.html) | [Round2](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aa90bdc3c5490a6df62ae9ab170e8718f) `[get, set]` |
| [TournamentRoundVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_round_v_m.html) | [Round3](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a0adcc41642b19a7937b1e920ab1fa737) `[get, set]` |
| [TournamentRoundVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_round_v_m.html) | [Round4](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9086a69e73875c4c9fdd259bf7df67e8) `[get, set]` |
| bool | [InitializationOver](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a89f2e2d4cc97e5dce2ca2b41f18d1c0b) `[get]` |
| string | [TournamentTitle](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#acc996affc666f3d3e09d7387da04d52f) `[get, set]` |
| bool | [IsOver](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a42349465640420b3a4aeef69c830f055) `[get, set]` |
| string | [WinnerIntro](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ac60a8270fc7e161a70898b6b94b9f52f) `[get, set]` |
| MBBindingList< [TournamentRewardVM](class_sand_box_1_1_view_model_collection_1_1_tournament_reward_v_m.html) > | [BattleRewards](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#af89f52e19f47aadfb7f644a82eddac12) `[get, set]` |
| bool | [IsWinnerHero](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9e439eb275a5a5a4fde5c525f6ed7245) `[get, set]` |
| bool | [IsBetWindowEnabled](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#acae55b7749cb65d431273f3790f58f18) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [WinnerBanner](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ac68d885555fcbde5a0f8cce8004a894d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [SkipAllRoundsHint](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a1c6ceadd211371199679edcafaa6f76c) `[get, set]` |

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

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aa8da880fc7bded60040722794e946617)TournamentVM()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.ViewModelCollection.Tournament.TournamentVM.TournamentVM | ( | Action | *disableUI*, |
|  |  | [TournamentBehavior](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html) | *tournamentBehavior* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a456c8b5361e19760ee924c5e98ac7475)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Tournament.TournamentVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ad2e07e24d824467507f4f57ff033e33d)ExecuteBet()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tournament.TournamentVM.ExecuteBet | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ab41eb4beb161fb8d9b25d3f870b3e30d)ExecuteJoinTournament()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tournament.TournamentVM.ExecuteJoinTournament | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aafccba282a886d0c00412440c37081b3)ExecuteSkipRound()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tournament.TournamentVM.ExecuteSkipRound | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a4418b4775c0c908362c8ff1b9280f20e)ExecuteSkipAllRounds()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tournament.TournamentVM.ExecuteSkipAllRounds | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#af1642752ccf2cb61f7bb6e6a1909d60e)ExecuteWatchRound()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tournament.TournamentVM.ExecuteWatchRound | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a17d09a14df4a49efd8b5d2c5b6c9ac7a)ExecuteLeave()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tournament.TournamentVM.ExecuteLeave | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9634ce045881dc76e66d13fa7b80f42f)Refresh()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tournament.TournamentVM.Refresh | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a544c389e308357d3dbc059d23de0253d)OnAgentRemoved()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tournament.TournamentVM.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a2f8a6acd3d008bcf9317560a158de8af)ExecuteShowPrizeItemTooltip()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tournament.TournamentVM.ExecuteShowPrizeItemTooltip | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#affaa43a829c49db4cf82e3e814b3c55f)ExecuteHidePrizeItemTooltip()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tournament.TournamentVM.ExecuteHidePrizeItemTooltip | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a827c3c99aee50fa86c72f12fbce542ed)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Tournament.TournamentVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a251db71cf7180f8b733562449e632024)SetDoneInputKey()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tournament.TournamentVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a2e4938774f3699be251c0d715ffc7a18)SetCancelInputKey()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tournament.TournamentVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a3aec3440efc4a44e00e5644910f5e136)DisableUI
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action SandBox.ViewModelCollection.Tournament.TournamentVM.DisableUI | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a857dd95dd35cc57bf36db7b3f8367358)Tournament
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentBehavior](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_behavior.html) SandBox.ViewModelCollection.Tournament.TournamentVM.Tournament | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a82b5bcd9e567f6311f1ad081f7d02e38)DoneInputKey
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) SandBox.ViewModelCollection.Tournament.TournamentVM.DoneInputKey | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a6829cf8e7a1354870b0d4a850815a1eb)CancelInputKey
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) SandBox.ViewModelCollection.Tournament.TournamentVM.CancelInputKey | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ae9caaf34ee6b005ca95097409809b1a7)TournamentWinnerTitle
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.TournamentWinnerTitle | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9d3453de5ecba2ecc3d1ea99a699e74a)TournamentWinner
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentParticipantVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_participant_v_m.html) SandBox.ViewModelCollection.Tournament.TournamentVM.TournamentWinner | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aea2d9da44582832b9d4744ae2a4b8dde)MaximumBetValue
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.Tournament.TournamentVM.MaximumBetValue | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9e3819752cf020bf508eb56deaefd73b)IsBetButtonEnabled
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Tournament.TournamentVM.IsBetButtonEnabled | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#afe1ed467da4eb40b932bff998fff4bde)BetText
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.BetText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a22729a38b172b8cc9d54a7692ad81e9a)BetTitleText
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.BetTitleText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ad34737021140bae41ce198b9f2b08916)CurrentWagerText
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.CurrentWagerText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aefdf17dfdbec8921a3621958a3fa2bf5)BetDescriptionText
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.BetDescriptionText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a3a6b955d26b26ef3576b793e43f0575e)PrizeVisual
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) SandBox.ViewModelCollection.Tournament.TournamentVM.PrizeVisual | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a8daafb08b567596b0dd4426c7ce4e228)PrizeItemName
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.PrizeItemName | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9ec24d33dd1c1af9805f57d027e806dc)TournamentPrizeText
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.TournamentPrizeText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a3374eed82dd94502f16bdae6492904b9)WageredDenars
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.Tournament.TournamentVM.WageredDenars | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a2cf7e8287592ee15a95b882c545e200b)ExpectedBetDenars
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.Tournament.TournamentVM.ExpectedBetDenars | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ae4a75293fb44e81b4ad1fa4c9758bbe0)BetOddsText
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.BetOddsText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a4ecc0be736b20f17c9c769a26b0985c0)BettedDenarsText
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.BettedDenarsText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9232344d9476c276ba70086f6526cfc9)OverallExpectedDenarsText
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.OverallExpectedDenarsText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ad24d83880800e65832d2045704d639f8)CurrentExpectedDenarsText
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.CurrentExpectedDenarsText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a999a1f703b1df84abc9d7fb9f031b3d5)TotalDenarsText
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.TotalDenarsText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ab082e8799c4b1d1e3ccaf9bf01b34c5d)AcceptText
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.AcceptText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a6c07741b8d1c4de31874d63f0957bcda)CancelText
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.CancelText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aa2109e01a61f67154c831ddb153bcc66)IsCurrentMatchActive
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Tournament.TournamentVM.IsCurrentMatchActive | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a8cb2e3d83e838b32035f4f90571953fd)CurrentMatch
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentMatchVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_match_v_m.html) SandBox.ViewModelCollection.Tournament.TournamentVM.CurrentMatch | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9e4f5c5f78bb9f21df99abfb785cd04f)IsTournamentIncomplete
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Tournament.TournamentVM.IsTournamentIncomplete | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aa066085280d3a11b3663474bfd5c1ab6)ActiveRoundIndex
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.Tournament.TournamentVM.ActiveRoundIndex | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a0037277b5af1954def8f5c675b5f257b)CanPlayerJoin
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Tournament.TournamentVM.CanPlayerJoin | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ac5f63eb1f4d5dba52094e6c3043c16e8)HasPrizeItem
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Tournament.TournamentVM.HasPrizeItem | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a74f397e69edd32226460598dac1a15bd)JoinTournamentText
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.JoinTournamentText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ac1dcb5300515336e63637c9fd637fbeb)SkipRoundText
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.SkipRoundText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a51cb7f3e98f36dd7226c65fd6049486a)WatchRoundText
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.WatchRoundText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a815e9739d180eb3f107cd68b9f3fd2b1)LeaveText
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.LeaveText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a1cfda89134157b6ca417e0d0aa76b9b4)Round1
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentRoundVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_round_v_m.html) SandBox.ViewModelCollection.Tournament.TournamentVM.Round1 | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#aa90bdc3c5490a6df62ae9ab170e8718f)Round2
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentRoundVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_round_v_m.html) SandBox.ViewModelCollection.Tournament.TournamentVM.Round2 | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a0adcc41642b19a7937b1e920ab1fa737)Round3
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentRoundVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_round_v_m.html) SandBox.ViewModelCollection.Tournament.TournamentVM.Round3 | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9086a69e73875c4c9fdd259bf7df67e8)Round4
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentRoundVM](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_round_v_m.html) SandBox.ViewModelCollection.Tournament.TournamentVM.Round4 | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a89f2e2d4cc97e5dce2ca2b41f18d1c0b)InitializationOver
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Tournament.TournamentVM.InitializationOver | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#acc996affc666f3d3e09d7387da04d52f)TournamentTitle
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.TournamentTitle | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a42349465640420b3a4aeef69c830f055)IsOver
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Tournament.TournamentVM.IsOver | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ac60a8270fc7e161a70898b6b94b9f52f)WinnerIntro
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tournament.TournamentVM.WinnerIntro | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#af89f52e19f47aadfb7f644a82eddac12)BattleRewards
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[TournamentRewardVM](class_sand_box_1_1_view_model_collection_1_1_tournament_reward_v_m.html)> SandBox.ViewModelCollection.Tournament.TournamentVM.BattleRewards | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a9e439eb275a5a5a4fde5c525f6ed7245)IsWinnerHero
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Tournament.TournamentVM.IsWinnerHero | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#acae55b7749cb65d431273f3790f58f18)IsBetWindowEnabled
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Tournament.TournamentVM.IsBetWindowEnabled | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#ac68d885555fcbde5a0f8cce8004a894d)WinnerBanner
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) SandBox.ViewModelCollection.Tournament.TournamentVM.WinnerBanner | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tournament_1_1_tournament_v_m.html#a1c6ceadd211371199679edcafaa6f76c)SkipAllRoundsHint
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) SandBox.ViewModelCollection.Tournament.TournamentVM.SkipAllRoundsHint | | getset |


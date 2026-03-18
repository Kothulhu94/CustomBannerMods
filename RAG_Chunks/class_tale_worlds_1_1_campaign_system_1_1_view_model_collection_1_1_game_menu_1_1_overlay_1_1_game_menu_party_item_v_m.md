--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#aa99917f43e4c67ab8e5aafb0d9b24179) () |
|  | [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a14487c4be5e8100e1212928f81557804) (Action< GameMenuPartyItemVM > onSetAsContextMenuActiveItem, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#afb26e5984303cdc182e88ee930d05623) settlement) |
|  | [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ae6bb2f2c1b8cdbff0b544effbbf03860) (Action< GameMenuPartyItemVM > onSetAsContextMenuActiveItem, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) item, bool canShowQuest) |
|  | [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a626be01017857cb795e93d686ecbbaee) (Action< GameMenuPartyItemVM > onSetAsContextMenuActiveItem, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, bool useCivilianEquipment) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a319efa8baa4ea00cbb25b259795baa50) () |
|  | Used for updating localized texts. |
| void | [ExecuteSetAsContextMenuItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a540edff1af1376e79a105486aec55333) () |
| void | [ExecuteOpenEncyclopedia](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a568e1138da71b93b3936cbbdec47400b) () |
| void | [ExecuteCloseTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a1f95012f7a8fd1e6586ce32f2025af2d) () |
| void | [ExecuteOpenTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ad6e0cd6383f17b9b71ad6fd9a2f14a08) () |
| void | [RefreshProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#aa40778635f8de0b74d8cb9efa9c39ee4) () |
| void | [RefreshQuestStatus](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a6ad84a4f4b3b018330d0cd7c84cd3f48) () |
| void | [RefreshVisual](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a932b6b87a8d2bba234ace3e761aa51da) () |
| void | [RefreshCounts](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a7fa46cfd3bb418554f11c408ec9bde74) () |
| string | [GetPartyDescriptionTextFromValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a9600fadaadfbb59e2b770c5506991db0) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a9f2110037554c1ae6d32c6883d822251) () |
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
| Public Attributes | |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Character](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#aeab58d775df14ad7cfd909a9ba0a6333) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [Party](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ab13522e2075c7e58c5c730fdcc482ebc) = null |
| Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#afb26e5984303cdc182e88ee930d05623) = null |

|  |  |
| --- | --- |
| Properties | |
| int | [Relation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a64ebb4506163319e31b33b8fdaaec6ca) `[get, set]` |
| MBBindingList< [QuestMarkerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_marker_v_m.html) > | [Quests](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a252cb7541c3862b5aa6b2e44d6497db8) `[get, set]` |
| bool | [IsHighlightEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a1ef53b06c8ff81aa5048de94d45f1faf) `[get, set]` |
| bool | [IsCharacterInPrison](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ac7b0f67c31077c7e9102c686f02e0373) `[get, set]` |
| bool | [HasShips](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a463a6093374320903b3553e8d3b445d4) `[get, set]` |
| bool | [IsIdle](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#af686b19c2d8e8e523bc051c660f6ae00) `[get, set]` |
| bool | [IsPlayer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ac2a5e38854a4bab5dfda337c0aaa89f9) `[get, set]` |
| bool | [IsEnemy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#aebbbf34a38c2cc80b09a823140c9df9e) `[get, set]` |
| bool | [IsAlly](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ad85b5428f4ed388a498d307f000a46bf) `[get, set]` |
| bool | [IsNeutral](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ada4d039df6228d30ef3bb4da060a7d45) `[get, set]` |
| bool | [IsMergedWithArmy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a7c1064084ef47fc32285c79f5b7d2800) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a7ed62b7a7f71caac1a799ebaf81c9650) `[get, set]` |
| string | [SettlementPath](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ae71a88205cd90faae00b34230e01c777) `[get, set]` |
| string | [LocationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ae4c5bd799a0613672ce58dda97b4030c) `[get, set]` |
| string | [PowerText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ae193c8f7285fabc2c258d7459af10b39) `[get, set]` |
| string | [DescriptionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a4e6c2d736708e611921fcbb84383783d) `[get, set]` |
| string | [ProfessionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a99ef419383496f4e7bacee73f669a98b) `[get, set]` |
| string | [EncyclopediaCursorEffect](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a8007fa7ada156accad6165b8af8b2a27) `[get, set]` |
| [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) | [Visual](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#adae267b2ee1a60c5083d3583fb76d206) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [Banner\_9](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a3bb22f3901fd0f160c5baa0d4cf6337c) `[get, set]` |
| int | [PartySize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a10db3fe26843a6cb74462e98d44f2f1b) `[get, set]` |
| int | [PartyWoundedSize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a65675a3dc4c11a6f2b449c7edf9943a9) `[get, set]` |
| int | [ShipCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a5f54f1317f3f1ef721ddde0f4b8c13b1) `[get, set]` |
| string | [PartySizeLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a94d81cd948b9a5263db7e530c1a11593) `[get, set]` |
| bool | [IsLeader](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a534e75c2b5e4b9de3bca49380f666624) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#aa99917f43e4c67ab8e5aafb0d9b24179)GameMenuPartyItemVM() [1/4]
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.GameMenuPartyItemVM | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a14487c4be5e8100e1212928f81557804)GameMenuPartyItemVM() [2/4]
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.GameMenuPartyItemVM | ( | Action< GameMenuPartyItemVM > | *onSetAsContextMenuActiveItem*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#afb26e5984303cdc182e88ee930d05623) | *settlement* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ae6bb2f2c1b8cdbff0b544effbbf03860)GameMenuPartyItemVM() [3/4]
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.GameMenuPartyItemVM | ( | Action< GameMenuPartyItemVM > | *onSetAsContextMenuActiveItem*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *item*, |
|  |  | bool | *canShowQuest* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a626be01017857cb795e93d686ecbbaee)GameMenuPartyItemVM() [4/4]
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.GameMenuPartyItemVM | ( | Action< GameMenuPartyItemVM > | *onSetAsContextMenuActiveItem*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | bool | *useCivilianEquipment* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a319efa8baa4ea00cbb25b259795baa50)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a540edff1af1376e79a105486aec55333)ExecuteSetAsContextMenuItem()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.ExecuteSetAsContextMenuItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a568e1138da71b93b3936cbbdec47400b)ExecuteOpenEncyclopedia()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.ExecuteOpenEncyclopedia | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a1f95012f7a8fd1e6586ce32f2025af2d)ExecuteCloseTooltip()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.ExecuteCloseTooltip | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ad6e0cd6383f17b9b71ad6fd9a2f14a08)ExecuteOpenTooltip()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.ExecuteOpenTooltip | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#aa40778635f8de0b74d8cb9efa9c39ee4)RefreshProperties()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.RefreshProperties | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a6ad84a4f4b3b018330d0cd7c84cd3f48)RefreshQuestStatus()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.RefreshQuestStatus | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a932b6b87a8d2bba234ace3e761aa51da)RefreshVisual()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.RefreshVisual | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a7fa46cfd3bb418554f11c408ec9bde74)RefreshCounts()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.RefreshCounts | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a9600fadaadfbb59e2b770c5506991db0)GetPartyDescriptionTextFromValues()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.GetPartyDescriptionTextFromValues | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a9f2110037554c1ae6d32c6883d822251)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#aeab58d775df14ad7cfd909a9ba0a6333)Character
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.Character |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ab13522e2075c7e58c5c730fdcc482ebc)Party
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.Party = null |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#afb26e5984303cdc182e88ee930d05623)Settlement
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Settlement TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.Settlement = null |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a64ebb4506163319e31b33b8fdaaec6ca)Relation
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.Relation | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a252cb7541c3862b5aa6b2e44d6497db8)Quests
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[QuestMarkerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_marker_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.Quests | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a1ef53b06c8ff81aa5048de94d45f1faf)IsHighlightEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.IsHighlightEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ac7b0f67c31077c7e9102c686f02e0373)IsCharacterInPrison
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.IsCharacterInPrison | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a463a6093374320903b3553e8d3b445d4)HasShips
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.HasShips | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#af686b19c2d8e8e523bc051c660f6ae00)IsIdle
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.IsIdle | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ac2a5e38854a4bab5dfda337c0aaa89f9)IsPlayer
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.IsPlayer | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#aebbbf34a38c2cc80b09a823140c9df9e)IsEnemy
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.IsEnemy | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ad85b5428f4ed388a498d307f000a46bf)IsAlly
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.IsAlly | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ada4d039df6228d30ef3bb4da060a7d45)IsNeutral
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.IsNeutral | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a7c1064084ef47fc32285c79f5b7d2800)IsMergedWithArmy
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.IsMergedWithArmy | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a7ed62b7a7f71caac1a799ebaf81c9650)NameText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ae71a88205cd90faae00b34230e01c777)SettlementPath
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.SettlementPath | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ae4c5bd799a0613672ce58dda97b4030c)LocationText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.LocationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#ae193c8f7285fabc2c258d7459af10b39)PowerText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.PowerText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a4e6c2d736708e611921fcbb84383783d)DescriptionText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.DescriptionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a99ef419383496f4e7bacee73f669a98b)ProfessionText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.ProfessionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a8007fa7ada156accad6165b8af8b2a27)EncyclopediaCursorEffect
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.EncyclopediaCursorEffect | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#adae267b2ee1a60c5083d3583fb76d206)Visual
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.Visual | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a3bb22f3901fd0f160c5baa0d4cf6337c)Banner\_9
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.Banner\_9 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a10db3fe26843a6cb74462e98d44f2f1b)PartySize
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.PartySize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a65675a3dc4c11a6f2b449c7edf9943a9)PartyWoundedSize
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.PartyWoundedSize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a5f54f1317f3f1ef721ddde0f4b8c13b1)ShipCount
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.ShipCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a94d81cd948b9a5263db7e530c1a11593)PartySizeLbl
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.PartySizeLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html#a534e75c2b5e4b9de3bca49380f666624)IsLeader
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuPartyItemVM.IsLeader | | getset |


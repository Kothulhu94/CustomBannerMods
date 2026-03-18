--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionConversationVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a92fbb9305aa0c3395cb89850e6b3300c) (Func< string > getContinueInputText, bool isLinksDisabled=false) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a4a078fe80568e7dd89f4ea9240b0530f) () |
|  | Used for updating localized texts. |
| void | [Tick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a940ac0b04cd4b59166759e1b3d8ac6c6) (float dt) |
| void | [OnConversationContinue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a064e01ce1e149110be11de90fa8eb2b2) () |
| void | [ExecuteLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a18d951502e24fb20df8eac3b6554214e) (string link) |
| void | [ExecuteConversedHeroLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#ad3463c2080734876abda3665246812bb) () |
| void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a90d473dd1428d7c2d7ba0eb6a3806fd8) () |
| void | [ExecuteCloseTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#aa7a0ca8c9bc88eb65130621fa55cfa74) () |
| void | [ExecuteHeroTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#af0695f8247b4d19003315811d8f78b3c) () |
| void | [ExecuteFinalizeSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a8dc55c2d535891af0472ed8d399c98f3) () |
| void | [ExecuteContinue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a898f0e0838fe0c0634f40f5b65e98628) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a779264e8fc373717982fc8066c3292a9) () |
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
| bool | [SelectedAnOptionOrLinkThisFrame](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#ab2e8ceae4327fb00c26a6ef475b248bb) `[get, set]` |
| [PersuasionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_persuasion_v_m.html) | [Persuasion](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#ad3b8adc91bb8dba27037db4041774ad3) `[get, set]` |
| [PowerLevelComparer](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_power_level_comparer.html) | [PowerComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#aeda5ac04674740685332b0f5ee0b61c3) `[get, set]` |
| int | [Relation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a10b7a6e386434adbde06508421b71220) `[get, set]` |
| int | [MinRelation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a74eb1b1a73f118342a64eddc289c8a38) `[get, set]` |
| int | [MaxRelation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#aff61a73177bafc9dbd5265a0e1d67d63) `[get, set]` |
| [ConversationAggressivePartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_conversation_aggressive_party_item_v_m.html) | [DefenderLeader](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a3f537c1dcbdf519a8b11fe964c936e84) `[get, set]` |
| [ConversationAggressivePartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_conversation_aggressive_party_item_v_m.html) | [AttackerLeader](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#ab32e276e000dfd76d03b45a4b690db2d) `[get, set]` |
| MBBindingList< [ConversationAggressivePartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_conversation_aggressive_party_item_v_m.html) > | [AttackerParties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#afe203877bc80e3fe31fa38c341e26c3f) `[get, set]` |
| MBBindingList< [ConversationAggressivePartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_conversation_aggressive_party_item_v_m.html) > | [DefenderParties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a71ccf14c5f813a09a1984073d9f0d1b4) `[get, set]` |
| string | [MoreOptionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a4d558c753ef26146f131fda141feadd8) `[get, set]` |
| string | [GoldText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#af520e22fe51b233df310a4d179fbb4e0) `[get, set]` |
| string | [PersuasionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#aa52c8913646db8748771ed892dbe4c1b) `[get, set]` |
| bool | [IsCurrentCharacterValidInEncyclopedia](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a9522faec04825077ed3211009966cac8) `[get, set]` |
| bool | [IsLoadingOver](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a9a95216743fa403ef998d98ed547d131) `[get, set]` |
| bool | [IsPersuading](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#acdbb83654f9c46b2aaf34a09f2bc0b6f) `[get, set]` |
| string | [ContinueText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a0d7fd37689c81fa7ed0db16423f33d79) `[get, set]` |
| string | [CurrentCharacterNameLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#ac641b27f2342b5cbf91c5ce14cf64557) `[get, set]` |
| MBBindingList< [ConversationItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_conversation_item_v_m.html) > | [AnswerList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a3c5fa1e50c369a38dc11870a86f63400) `[get, set]` |
| string | [DialogText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a35375b33f7097f6f4c54cdc198fcefe1) `[get, set]` |
| bool | [IsAggressive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a1d3587f47652a49d0e74afe6dfbec20a) `[get, set]` |
| int | [SelectedSide](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a10eef93e9f35db0d4428b66294b2b259) `[get, set]` |
| string | [RelationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a56cb651e1de88736d7f18cc0aba874d3) `[get, set]` |
| bool | [IsRelationEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a4dafee82f6bf5a342644b9f97c1c9610) `[get, set]` |
| bool | [IsBannerEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a107a0a978f60d6164342408e188efd5f) `[get, set]` |
| [ConversationItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_conversation_item_v_m.html) | [CurrentSelectedAnswer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a1f0a9053cc470e4cd3ad0f06c787aa0c) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [ConversedHeroBanner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#ad77da08213e4103e8a21c9dc8b4c7b48) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RelationHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a4609f0188b4b64193860ee4e719d85b6) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [FactionHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a88e1e12793ada3897497d5070f488ea6) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [GoldHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a1f278d6076dea3136d3d5146758b4840) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a92fbb9305aa0c3395cb89850e6b3300c)MissionConversationVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.MissionConversationVM | ( | Func< string > | *getContinueInputText*, |
|  |  | bool | *isLinksDisabled* = false ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a4a078fe80568e7dd89f4ea9240b0530f)RefreshValues()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a940ac0b04cd4b59166759e1b3d8ac6c6)Tick()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a064e01ce1e149110be11de90fa8eb2b2)OnConversationContinue()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.OnConversationContinue | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a18d951502e24fb20df8eac3b6554214e)ExecuteLink()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.ExecuteLink | ( | string | *link* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#ad3463c2080734876abda3665246812bb)ExecuteConversedHeroLink()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.ExecuteConversedHeroLink | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a90d473dd1428d7c2d7ba0eb6a3806fd8)Refresh()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.Refresh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#aa7a0ca8c9bc88eb65130621fa55cfa74)ExecuteCloseTooltip()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.ExecuteCloseTooltip | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#af0695f8247b4d19003315811d8f78b3c)ExecuteHeroTooltip()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.ExecuteHeroTooltip | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a8dc55c2d535891af0472ed8d399c98f3)ExecuteFinalizeSelection()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.ExecuteFinalizeSelection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a898f0e0838fe0c0634f40f5b65e98628)ExecuteContinue()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.ExecuteContinue | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a779264e8fc373717982fc8066c3292a9)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#ab2e8ceae4327fb00c26a6ef475b248bb)SelectedAnOptionOrLinkThisFrame
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.SelectedAnOptionOrLinkThisFrame | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#ad3b8adc91bb8dba27037db4041774ad3)Persuasion
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PersuasionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_persuasion_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.Persuasion | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#aeda5ac04674740685332b0f5ee0b61c3)PowerComparer
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PowerLevelComparer](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_power_level_comparer.html) TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.PowerComparer | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a10b7a6e386434adbde06508421b71220)Relation
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.Relation | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a74eb1b1a73f118342a64eddc289c8a38)MinRelation
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.MinRelation | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#aff61a73177bafc9dbd5265a0e1d67d63)MaxRelation
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.MaxRelation | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a3f537c1dcbdf519a8b11fe964c936e84)DefenderLeader
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ConversationAggressivePartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_conversation_aggressive_party_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.DefenderLeader | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#ab32e276e000dfd76d03b45a4b690db2d)AttackerLeader
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ConversationAggressivePartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_conversation_aggressive_party_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.AttackerLeader | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#afe203877bc80e3fe31fa38c341e26c3f)AttackerParties
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ConversationAggressivePartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_conversation_aggressive_party_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.AttackerParties | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a71ccf14c5f813a09a1984073d9f0d1b4)DefenderParties
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ConversationAggressivePartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_conversation_aggressive_party_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.DefenderParties | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a4d558c753ef26146f131fda141feadd8)MoreOptionText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.MoreOptionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#af520e22fe51b233df310a4d179fbb4e0)GoldText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.GoldText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#aa52c8913646db8748771ed892dbe4c1b)PersuasionText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.PersuasionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a9522faec04825077ed3211009966cac8)IsCurrentCharacterValidInEncyclopedia
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.IsCurrentCharacterValidInEncyclopedia | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a9a95216743fa403ef998d98ed547d131)IsLoadingOver
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.IsLoadingOver | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#acdbb83654f9c46b2aaf34a09f2bc0b6f)IsPersuading
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.IsPersuading | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a0d7fd37689c81fa7ed0db16423f33d79)ContinueText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.ContinueText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#ac641b27f2342b5cbf91c5ce14cf64557)CurrentCharacterNameLbl
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.CurrentCharacterNameLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a3c5fa1e50c369a38dc11870a86f63400)AnswerList
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ConversationItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_conversation_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.AnswerList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a35375b33f7097f6f4c54cdc198fcefe1)DialogText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.DialogText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a1d3587f47652a49d0e74afe6dfbec20a)IsAggressive
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.IsAggressive | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a10eef93e9f35db0d4428b66294b2b259)SelectedSide
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.SelectedSide | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a56cb651e1de88736d7f18cc0aba874d3)RelationText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.RelationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a4dafee82f6bf5a342644b9f97c1c9610)IsRelationEnabled
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.IsRelationEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a107a0a978f60d6164342408e188efd5f)IsBannerEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.IsBannerEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a1f0a9053cc470e4cd3ad0f06c787aa0c)CurrentSelectedAnswer
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ConversationItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_conversation_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.CurrentSelectedAnswer | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#ad77da08213e4103e8a21c9dc8b4c7b48)ConversedHeroBanner
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.ConversedHeroBanner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a4609f0188b4b64193860ee4e719d85b6)RelationHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.RelationHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a88e1e12793ada3897497d5070f488ea6)FactionHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.FactionHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_conversation_1_1_mission_conversation_v_m.html#a1f278d6076dea3136d3d5146758b4840)GoldHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Conversation.MissionConversationVM.GoldHint | | getset |


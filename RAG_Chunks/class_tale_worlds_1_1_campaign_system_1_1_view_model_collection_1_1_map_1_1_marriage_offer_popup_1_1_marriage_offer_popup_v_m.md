--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MarriageOfferPopupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a7a5f9aa4cce1f012a680c4070ce44fe5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) suitor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maiden, Action onClose) |
| void | [Update](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#afa445c553de1276c111f4ece1a7f8b25) () |
| void | [ExecuteAcceptOffer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a879d43283c812281a01567d7b2e44e9b) () |
| void | [ExecuteDeclineOffer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a22b472757071f2c44774c205fb4b3ddb) () |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a7cb846a324d9b0a9573d418b10122458) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#aa97f5a78cd6a1e4b7e816c449e6a2f1b) () |
| void | [ExecuteLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a53e2b3fca20b862bb8b6bec51af56d20) (string link) |
| void | [SetCancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a2fa3389ba4c23818ea701bb38763e9fc) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a936a3d029ef3a8e7c81b4e69fa6e1295) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| string | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#af836c5e072bd0df6b2f01a52d62761d2) `[get, set]` |
| string | [ClanText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#ac4c75a81ea1146a93f4b574524a75b62) `[get, set]` |
| string | [AgeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a4a04bda1dd90ef51281c2caf7bcc20a1) `[get, set]` |
| string | [OccupationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#acf15113e125ab4a650c89a8ecab21a88) `[get, set]` |
| string | [RelationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a301ca3bb2b1eda9f9c1d80017c377f52) `[get, set]` |
| string | [ConsequencesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#ae5f1ad953439143f23f18c59c23b50ee) `[get, set]` |
| MBBindingList< [BindingListStringItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_binding_list_string_item.html) > | [ConsequencesList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a29f7f9aeff1f932df30471a059fa44ac) `[get, set]` |
| string | [ButtonOkLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a67dc0da21ebecc404398f0fd85d73a95) `[get, set]` |
| string | [ButtonCancelLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a8707a0d387147185283c438019312ac2) `[get, set]` |
| bool | [IsEncyclopediaOpen](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a6386ed4e21bd3759c150c4a4c8fa2234) `[get, set]` |
| [MarriageOfferPopupHeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html) | [OffereeClanMember](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#aad9791843d9e3f69bed393af0106ea93) `[get, set]` |
| [MarriageOfferPopupHeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html) | [OffererClanMember](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a8a55f86bb4d6a9b8b529c759a0990e2a) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a547298f5bc295bb28efa5c24567d7b60) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a0090d11fb8327675d730f69304cb5b13) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a7a5f9aa4cce1f012a680c4070ce44fe5)MarriageOfferPopupVM()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.MarriageOfferPopupVM | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *suitor*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maiden*, |
|  |  | Action | *onClose* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#afa445c553de1276c111f4ece1a7f8b25)Update()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.Update | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a879d43283c812281a01567d7b2e44e9b)ExecuteAcceptOffer()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.ExecuteAcceptOffer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a22b472757071f2c44774c205fb4b3ddb)ExecuteDeclineOffer()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.ExecuteDeclineOffer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a7cb846a324d9b0a9573d418b10122458)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#aa97f5a78cd6a1e4b7e816c449e6a2f1b)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a53e2b3fca20b862bb8b6bec51af56d20)ExecuteLink()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.ExecuteLink | ( | string | *link* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a2fa3389ba4c23818ea701bb38763e9fc)SetCancelInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a936a3d029ef3a8e7c81b4e69fa6e1295)SetDoneInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#af836c5e072bd0df6b2f01a52d62761d2)TitleText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.TitleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#ac4c75a81ea1146a93f4b574524a75b62)ClanText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.ClanText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a4a04bda1dd90ef51281c2caf7bcc20a1)AgeText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.AgeText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#acf15113e125ab4a650c89a8ecab21a88)OccupationText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.OccupationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a301ca3bb2b1eda9f9c1d80017c377f52)RelationText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.RelationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#ae5f1ad953439143f23f18c59c23b50ee)ConsequencesText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.ConsequencesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a29f7f9aeff1f932df30471a059fa44ac)ConsequencesList
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[BindingListStringItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_binding_list_string_item.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.ConsequencesList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a67dc0da21ebecc404398f0fd85d73a95)ButtonOkLabel
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.ButtonOkLabel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a8707a0d387147185283c438019312ac2)ButtonCancelLabel
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.ButtonCancelLabel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a6386ed4e21bd3759c150c4a4c8fa2234)IsEncyclopediaOpen
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.IsEncyclopediaOpen | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#aad9791843d9e3f69bed393af0106ea93)OffereeClanMember
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MarriageOfferPopupHeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.OffereeClanMember | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a8a55f86bb4d6a9b8b529c759a0990e2a)OffererClanMember
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MarriageOfferPopupHeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.OffererClanMember | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a547298f5bc295bb28efa5c24567d7b60)CancelInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup_1_1_marriage_offer_popup_v_m.html#a0090d11fb8327675d730f69304cb5b13)DoneInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupVM.DoneInputKey | | getset |


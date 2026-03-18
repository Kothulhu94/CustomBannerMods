--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.EncyclopediaLinkVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_encyclopedia_link_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [BarterTransferEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a6bcb9c6009e338bb7ee22b261992dc73) ([BarterItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a2f46729eae4eb34496efb917c2707d29) itemVM, bool transferAll) |
|  | [BarterItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a2f46729eae4eb34496efb917c2707d29) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#ae16f04b4a0cde6225d8378e925f3cd04) barterable, [BarterTransferEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a6bcb9c6009e338bb7ee22b261992dc73) OnTransfer, Action onAmountChange, bool isFixed=false) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a5aa91a15535aeff873326f51a116c9c4) () |
|  | Used for updating localized texts. |
| void | [RefreshCompabilityWithItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#ac415459718b230fa959186cac1771a2a) ([BarterItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a2f46729eae4eb34496efb917c2707d29) item, bool isItemGotOffered) |
| void | [ExecuteAddOffered](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a8a10e41f647f0328665d4f96b074ace8) () |
| void | [ExecuteRemoveOffered](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a34cd6e871a2a94a757d0c6cc08d4d9e8) () |
| void | [ExecuteAction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a32d8c82a5cf452b411669da6cd8efe57) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.EncyclopediaLinkVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_encyclopedia_link_v_m.html) | |
| void | [ExecuteActiveLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_encyclopedia_link_v_m.html#a5e1a55e3f77a9e7c9060e1a3271c81ab) () |
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

|  |  |
| --- | --- |
| Public Attributes | |
| Barterable | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#ae16f04b4a0cde6225d8378e925f3cd04) |
| bool | [\_isOffered](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a7c32324f0cac1d5aa3e551d206a6d399) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static bool | [IsEntireStackModifierActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#ac6944c125584b31e968a8200aa9eb0a5) |
| static bool | [IsFiveStackModifierActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a7724262b8a66221cc8f5e7acc8055e28) |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |

|  |  |
| --- | --- |
| Properties | |
| int | [TotalItemCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#af4c0a530d8aab63b347457e814f1df30) `[get, set]` |
| string | [TotalItemCountText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a1830242bc1c39f43092ce0d95e29bde1) `[get, set]` |
| int | [CurrentOfferedAmount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#aa700d52349ce781dbcd7124573dfec79) `[get, set]` |
| string | [CurrentOfferedAmountText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a0eadfc52dbbfd6e4a21e063ddf9cca38) `[get, set]` |
| string | [BarterableType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a94a8a8ddc4c29c3d3ceaf741ccd61945) `[get, set]` |
| bool | [HasVisualIdentifier](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a3a8039b0c847cb91b154b9016a5998f7) `[get, set]` |
| bool | [IsMultiple](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#afa4a5fdd308afa95fa967deeae8ea1d8) `[get, set]` |
| bool | [IsSelectorActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#adfca201f13c5f872c5c577ac9efcb13d) `[get, set]` |
| [ImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_image_identifier_v_m.html) | [VisualIdentifier](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a99c0d9fd8224b0004df2a437f6f110c2) `[get, set]` |
| string | [ItemLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a9c8a20f91374caa8b1d4c91b1ba4e62f) `[get, set]` |
| string | [FiefFileName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a4d7245f5c4336e4cf60403e7658ece82) `[get, set]` |
| bool | [IsItemTransferrable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a122558abee72ef8c71dc9393e710f4a8) `[get, set]` |
| bool | [IsOffered](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a6eae85f26458ff39e9727bcf970280a2) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.EncyclopediaLinkVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_encyclopedia_link_v_m.html) | |
| string | [ActiveLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_encyclopedia_link_v_m.html#ad086d91c7e68ef8eda28e27d970377ea) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a2f46729eae4eb34496efb917c2707d29)BarterItemVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.BarterItemVM | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#ae16f04b4a0cde6225d8378e925f3cd04) | *barterable*, |
|  |  | [BarterTransferEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a6bcb9c6009e338bb7ee22b261992dc73) | *OnTransfer*, |
|  |  | Action | *onAmountChange*, |
|  |  | bool | *isFixed* = false ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a6bcb9c6009e338bb7ee22b261992dc73)BarterTransferEventDelegate()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.BarterTransferEventDelegate | ( | [BarterItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a2f46729eae4eb34496efb917c2707d29) | *itemVM*, |
|  |  | bool | *transferAll* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a5aa91a15535aeff873326f51a116c9c4)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#ac415459718b230fa959186cac1771a2a)RefreshCompabilityWithItem()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.RefreshCompabilityWithItem | ( | [BarterItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a2f46729eae4eb34496efb917c2707d29) | *item*, |
|  |  | bool | *isItemGotOffered* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a8a10e41f647f0328665d4f96b074ace8)ExecuteAddOffered()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.ExecuteAddOffered | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a34cd6e871a2a94a757d0c6cc08d4d9e8)ExecuteRemoveOffered()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.ExecuteRemoveOffered | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a32d8c82a5cf452b411669da6cd8efe57)ExecuteAction()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.ExecuteAction | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#ac6944c125584b31e968a8200aa9eb0a5)IsEntireStackModifierActive
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.IsEntireStackModifierActive | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a7724262b8a66221cc8f5e7acc8055e28)IsFiveStackModifierActive
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.IsFiveStackModifierActive | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#ae16f04b4a0cde6225d8378e925f3cd04)Barterable
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Barterable TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.Barterable |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a7c32324f0cac1d5aa3e551d206a6d399)\_isOffered
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.\_isOffered |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#af4c0a530d8aab63b347457e814f1df30)TotalItemCount
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.TotalItemCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a1830242bc1c39f43092ce0d95e29bde1)TotalItemCountText
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.TotalItemCountText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#aa700d52349ce781dbcd7124573dfec79)CurrentOfferedAmount
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.CurrentOfferedAmount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a0eadfc52dbbfd6e4a21e063ddf9cca38)CurrentOfferedAmountText
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.CurrentOfferedAmountText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a94a8a8ddc4c29c3d3ceaf741ccd61945)BarterableType
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.BarterableType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a3a8039b0c847cb91b154b9016a5998f7)HasVisualIdentifier
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.HasVisualIdentifier | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#afa4a5fdd308afa95fa967deeae8ea1d8)IsMultiple
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.IsMultiple | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#adfca201f13c5f872c5c577ac9efcb13d)IsSelectorActive
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.IsSelectorActive | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a99c0d9fd8224b0004df2a437f6f110c2)VisualIdentifier
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.VisualIdentifier | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a9c8a20f91374caa8b1d4c91b1ba4e62f)ItemLbl
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.ItemLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a4d7245f5c4336e4cf60403e7658ece82)FiefFileName
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.FiefFileName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a122558abee72ef8c71dc9393e710f4a8)IsItemTransferrable
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.IsItemTransferrable | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_barter_1_1_barter_item_v_m.html#a6eae85f26458ff39e9727bcf970280a2)IsOffered
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Barter.BarterItemVM.IsOffered | | getset |


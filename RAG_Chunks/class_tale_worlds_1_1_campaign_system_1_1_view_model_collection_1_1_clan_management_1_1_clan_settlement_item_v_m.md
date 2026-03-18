--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ClanSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a6933d78a42b9bf20954dbad855d1d125) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a1a72133cce8beb3ac9ab6805a98f38f1) settlement, Action< ClanSettlementItemVM > onSelection, Action onShowSendMembers, [ITeleportationCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html) teleportationBehavior) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#adba069d0abe8fe681b9dc8ce20494466) () |
|  | Used for updating localized texts. |
| void | [OnSettlementSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#acdf5e920385235fad2fc5248da62a726) () |
| void | [ExecuteLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a76350044d3e231ca9125daeb726fadf8) () |
| void | [ExecuteCloseTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#ab3e23f06d0233e649a48cb06099d8438) () |
| void | [ExecuteOpenTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a0b52fa4cdb2aab843df069c2f3ebf8a0) () |
| void | [ExecuteSendMembers](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#acdfdbada0232be16277c855b08d8de51) () |
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
| readonly Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a1a72133cce8beb3ac9ab6805a98f38f1) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual [ClanSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a6933d78a42b9bf20954dbad855d1d125) | [CreateSettlementItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#ae2a29906201218bd7b6ca6a5675ce58c) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a1a72133cce8beb3ac9ab6805a98f38f1) settlement, Action< [ClanSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a6933d78a42b9bf20954dbad855d1d125) > onSelection, Action onShowSendMembers, [ITeleportationCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html) teleportationBehavior) |
| virtual void | [UpdateProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a0d8ba4d7a1f9f5a049e6dff639c42b9f) () |
| virtual void | [UpdateProfitProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#ac2e88e5627fc338f878a26889889b3c8) () |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Properties | |
| [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) | [Governor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a5e22eb6558b1f33e6f0cfee555284575) `[get, set]` |
| MBBindingList< [SelectableFiefItemPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_selectable_fief_item_property_v_m.html) > | [ItemProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#ae39531819fcba1dba19a30b179a38316) `[get, set]` |
| MBBindingList< [ProfitItemPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html) > | [ProfitItemProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a0fbf77dc2a642bfe6b12ca20a01b51e9) `[get, set]` |
| [ProfitItemPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html) | [TotalProfit](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#aa982301877080ec19ddf42c2083762e5) `[get, set]` |
| string | [FileName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#afce280c1f45aad422fc1c3451d554c5f) `[get, set]` |
| string | [ImageName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#abb48bcc6dcd7c235428721d526eb4bb4) `[get, set]` |
| string | [VillagesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a6e2a25da9a714d316cf8afb96276a011) `[get, set]` |
| string | [NotablesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#aebe8a7e244c199e3102d909f5cb32995) `[get, set]` |
| string | [MembersText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a0aa8c603141950c6e621fb5a70cfeb89) `[get, set]` |
| bool | [IsFortification](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#ae5e16291c2735c6a3774952042dcd3ed) `[get, set]` |
| bool | [HasGovernor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a69cb2dc0767f77ffc216fe343804c031) `[get, set]` |
| bool | [HasNotables](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a604067ae3bee18908976f3f740a376dc) `[get, set]` |
| bool | [IsSendMembersEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a23f41c0fcd86070917fb3706eefd6b25) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#aad809026bc31eff550e5eb99f60cb972) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a0cd549d9024da1fd71a6dece3a9851d0) `[get, set]` |
| MBBindingList< [ClanSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a6933d78a42b9bf20954dbad855d1d125) > | [VillagesOwned](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a5427578eb6146afbd5bcdb794706bb49) `[get, set]` |
| MBBindingList< [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) > | [Notables](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a03486a1d1024e91d71928b74485a5369) `[get, set]` |
| MBBindingList< [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) > | [Members](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a48c21d48636dbe221958061d997f0ecc) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [SendMembersHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#adf520ddfd51e58dc180f27bc688f032a) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a6933d78a42b9bf20954dbad855d1d125)ClanSettlementItemVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.ClanSettlementItemVM | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a1a72133cce8beb3ac9ab6805a98f38f1) | *settlement*, |
|  |  | Action< ClanSettlementItemVM > | *onSelection*, |
|  |  | Action | *onShowSendMembers*, |
|  |  | [ITeleportationCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html) | *teleportationBehavior* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#adba069d0abe8fe681b9dc8ce20494466)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#ae2a29906201218bd7b6ca6a5675ce58c)CreateSettlementItem()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual [ClanSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a6933d78a42b9bf20954dbad855d1d125) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.CreateSettlementItem | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a1a72133cce8beb3ac9ab6805a98f38f1) | *settlement*, | |  |  | Action< [ClanSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a6933d78a42b9bf20954dbad855d1d125) > | *onSelection*, | |  |  | Action | *onShowSendMembers*, | |  |  | [ITeleportationCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html) | *teleportationBehavior* ) | | protectedvirtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#acdf5e920385235fad2fc5248da62a726)OnSettlementSelection()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.OnSettlementSelection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a76350044d3e231ca9125daeb726fadf8)ExecuteLink()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.ExecuteLink | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#ab3e23f06d0233e649a48cb06099d8438)ExecuteCloseTooltip()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.ExecuteCloseTooltip | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a0b52fa4cdb2aab843df069c2f3ebf8a0)ExecuteOpenTooltip()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.ExecuteOpenTooltip | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#acdfdbada0232be16277c855b08d8de51)ExecuteSendMembers()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.ExecuteSendMembers | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a0d8ba4d7a1f9f5a049e6dff639c42b9f)UpdateProperties()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.UpdateProperties | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#ac2e88e5627fc338f878a26889889b3c8)UpdateProfitProperties()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.UpdateProfitProperties | ( |  | ) |  | | protectedvirtual |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a1a72133cce8beb3ac9ab6805a98f38f1)Settlement
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Settlement TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.Settlement |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a5e22eb6558b1f33e6f0cfee555284575)Governor
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.Governor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#ae39531819fcba1dba19a30b179a38316)ItemProperties
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[SelectableFiefItemPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_selectable_fief_item_property_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.ItemProperties | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a0fbf77dc2a642bfe6b12ca20a01b51e9)ProfitItemProperties
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ProfitItemPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.ProfitItemProperties | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#aa982301877080ec19ddf42c2083762e5)TotalProfit
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ProfitItemPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.TotalProfit | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#afce280c1f45aad422fc1c3451d554c5f)FileName
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.FileName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#abb48bcc6dcd7c235428721d526eb4bb4)ImageName
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.ImageName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a6e2a25da9a714d316cf8afb96276a011)VillagesText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.VillagesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#aebe8a7e244c199e3102d909f5cb32995)NotablesText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.NotablesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a0aa8c603141950c6e621fb5a70cfeb89)MembersText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.MembersText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#ae5e16291c2735c6a3774952042dcd3ed)IsFortification
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.IsFortification | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a69cb2dc0767f77ffc216fe343804c031)HasGovernor
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.HasGovernor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a604067ae3bee18908976f3f740a376dc)HasNotables
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.HasNotables | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a23f41c0fcd86070917fb3706eefd6b25)IsSendMembersEnabled
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.IsSendMembersEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#aad809026bc31eff550e5eb99f60cb972)IsSelected
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a0cd549d9024da1fd71a6dece3a9851d0)Name
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.Name | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a5427578eb6146afbd5bcdb794706bb49)VillagesOwned
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ClanSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a6933d78a42b9bf20954dbad855d1d125)> TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.VillagesOwned | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a03486a1d1024e91d71928b74485a5369)Notables
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.Notables | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#a48c21d48636dbe221958061d997f0ecc)Members
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.Members | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_settlement_item_v_m.html#adf520ddfd51e58dc180f27bc688f032a)SendMembersHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanSettlementItemVM.SendMembersHint | | getset |


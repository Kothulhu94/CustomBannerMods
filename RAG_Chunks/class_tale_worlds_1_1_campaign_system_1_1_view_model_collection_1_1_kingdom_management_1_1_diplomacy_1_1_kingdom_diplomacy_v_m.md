--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomCategoryVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [KingdomDiplomacyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#afc3d6b86b4ed75316561a34282f112db) (Action< [Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) > forceDecision) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a0f22150b7630d6bc26457d97d0607590) () |
|  | Used for updating localized texts. |
| void | [RefreshDiplomacyList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a0fa48999e750eacd3d99e35ab2bc840c) () |
| void | [SelectKingdom](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#ad6f6a813c4c34e076d7201af44c373cd) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
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
| Properties | |
| MBBindingList< [KingdomWarItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_war_item_v_m.html) > | [PlayerWars](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a2d8721183a4fe3eb87b24d72ecd9bda8) `[get, set]` |
| bool | [IsDisplayingWarLogs](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a4a7a14aabd396b537d4e0ecab3e62573) `[get, set]` |
| bool | [IsDisplayingStatComparisons](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a5d6c5cc7bf9d317e6bf47a6508daa492) `[get, set]` |
| bool | [IsWar](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#ae995b9c7d06e3780f6610f7041fce064) `[get, set]` |
| string | [BehaviorSelectionTitle](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a995d9ab720eeae4289d28d03e44e17d0) `[get, set]` |
| MBBindingList< [KingdomTruceItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_truce_item_v_m.html) > | [PlayerTruces](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#aefaba921706a91d4525f67b07bc49418) `[get, set]` |
| [KingdomDiplomacyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplo345faef97f6b822a90e733a5eb8d8563.html) | [CurrentSelectedDiplomacyItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a1b3e90be228f0b9c0fa47741fb2eead9) `[get, set]` |
| [KingdomWarSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplo0692be2e62e818b816307a45c9f0fe7a.html) | [WarsSortController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#ac3e6b6456b19a2ad131c5ec40cbf33ef) `[get, set]` |
| string | [PlayerWarsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a77dad4e7749c7d3ad1564eee082d4a02) `[get, set]` |
| string | [WarsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#aae503c9cedcdc9c3a4e9ed6de82108cb) `[get, set]` |
| string | [NumOfPlayerWarsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#adeda371b5c5f4e78367a09ec4eff73a8) `[get, set]` |
| string | [PlayerTrucesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a5fa1a160f10e322d9a017460914e412c) `[get, set]` |
| string | [NumOfPlayerTrucesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#acc45379fd411f7a45b8520cad486ef2b) `[get, set]` |
| SelectorVM< [SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html) > | [BehaviorSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#afd6ae1ec41bdef73c7c12a58635144c6) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ShowStatBarsHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a76ef4228d61516416723e9237ef81f8d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ShowWarLogsHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a408d9d0c51e4edfad0a5b89f05eba3be) `[get, set]` |
| MBBindingList< [KingdomDiplomacyProposalActionItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplof130967aa662b22fce008d03dad6a19a.html) > | [Actions](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#aa483d0f6208f7a96ec91eef093b92b82) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomCategoryVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html) | |
| string | [CategoryNameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html#a39ebbe6e4aa358f72380bc6242b66ee7) `[get, set]` |
| string | [NoItemSelectedText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html#a07caab2d24921773e2671b0b62ff05e7) `[get, set]` |
| bool | [IsAcceptableItemSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html#ad356c7c5dde14c373e0f9a7496841aed) `[get, set]` |
| int | [NotificationCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html#acbb69f1cce2a1eda032628ac2a09cd18) `[get, set]` |
| bool | [Show](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html#a88680ce85dd8c95901bed6bf9c6877f8) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#afc3d6b86b4ed75316561a34282f112db)KingdomDiplomacyVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.KingdomDiplomacyVM | ( | Action< [Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) > | *forceDecision* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a0f22150b7630d6bc26457d97d0607590)RefreshValues()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a0fa48999e750eacd3d99e35ab2bc840c)RefreshDiplomacyList()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.RefreshDiplomacyList | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#ad6f6a813c4c34e076d7201af44c373cd)SelectKingdom()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.SelectKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a2d8721183a4fe3eb87b24d72ecd9bda8)PlayerWars
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[KingdomWarItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_war_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.PlayerWars | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a4a7a14aabd396b537d4e0ecab3e62573)IsDisplayingWarLogs
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.IsDisplayingWarLogs | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a5d6c5cc7bf9d317e6bf47a6508daa492)IsDisplayingStatComparisons
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.IsDisplayingStatComparisons | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#ae995b9c7d06e3780f6610f7041fce064)IsWar
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.IsWar | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a995d9ab720eeae4289d28d03e44e17d0)BehaviorSelectionTitle
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.BehaviorSelectionTitle | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#aefaba921706a91d4525f67b07bc49418)PlayerTruces
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[KingdomTruceItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_truce_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.PlayerTruces | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a1b3e90be228f0b9c0fa47741fb2eead9)CurrentSelectedDiplomacyItem
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [KingdomDiplomacyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplo345faef97f6b822a90e733a5eb8d8563.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.CurrentSelectedDiplomacyItem | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#ac3e6b6456b19a2ad131c5ec40cbf33ef)WarsSortController
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [KingdomWarSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplo0692be2e62e818b816307a45c9f0fe7a.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.WarsSortController | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a77dad4e7749c7d3ad1564eee082d4a02)PlayerWarsText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.PlayerWarsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#aae503c9cedcdc9c3a4e9ed6de82108cb)WarsText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.WarsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#adeda371b5c5f4e78367a09ec4eff73a8)NumOfPlayerWarsText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.NumOfPlayerWarsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a5fa1a160f10e322d9a017460914e412c)PlayerTrucesText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.PlayerTrucesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#acc45379fd411f7a45b8520cad486ef2b)NumOfPlayerTrucesText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.NumOfPlayerTrucesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#afd6ae1ec41bdef73c7c12a58635144c6)BehaviorSelection
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.BehaviorSelection | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a76ef4228d61516416723e9237ef81f8d)ShowStatBarsHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.ShowStatBarsHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#a408d9d0c51e4edfad0a5b89f05eba3be)ShowWarLogsHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.ShowWarLogsHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplomacy_1_1_kingdom_diplomacy_v_m.html#aa483d0f6208f7a96ec91eef093b92b82)Actions
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[KingdomDiplomacyProposalActionItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_diplof130967aa662b22fce008d03dad6a19a.html)> TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Diplomacy.KingdomDiplomacyVM.Actions | | getset |


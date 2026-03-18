--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [PerkStates](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a5eb53e4b20a0321143cdf2e48de60794) {     [None](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a5eb53e4b20a0321143cdf2e48de60794a6adf97f83acf6453d4a6a4b1070f3754) = -1 ,     [NotEarned](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a5eb53e4b20a0321143cdf2e48de60794ab27bebc8a587e1a6d30f4265e2424fc6) = 0 ,     [EarnedButNotSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a5eb53e4b20a0321143cdf2e48de60794a268c8b3d39a7898374ba9e8cf05c14b9) ,     [InSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a5eb53e4b20a0321143cdf2e48de60794a30f8b8f2b41cb5faee17beb226b8d84f) ,     [EarnedAndActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a5eb53e4b20a0321143cdf2e48de60794a36b8b24cc6fbfd2fbff5ddead0dca269) ,     [EarnedAndNotActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a5eb53e4b20a0321143cdf2e48de60794a5b1f342f119652360897ea99627bdf0e) ,     [EarnedPreviousPerkNotSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a5eb53e4b20a0321143cdf2e48de60794a93d87198400fa95b18b41fa161f99a84)   } |
| enum | [PerkAlternativeType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a7440d221c2446a97857a288d37a27472) {     [NoAlternative](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a7440d221c2446a97857a288d37a27472a917ab4f85d0fea2a8b1881a09a7f53c3) ,     [FirstAlternative](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a7440d221c2446a97857a288d37a27472a9e8ce2f3da48dab6d0e1490590c99f85) ,     [SecondAlternative](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a7440d221c2446a97857a288d37a27472a8e914b941fc80de165aef11574571924)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PerkVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#aabe62702569164129d7b796d0598a83e) ([PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk, bool isAvailable, [PerkAlternativeType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a7440d221c2446a97857a288d37a27472) alternativeType, Action< PerkVM > onStartSelection, Action< PerkVM > onSelectionOver, Func< [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html), bool > getIsPerkSelected, Func< [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html), bool > getIsPreviousPerkSelected) |
| void | [RefreshState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a2fab54bafd8b4b341b2fca3f621bc620) () |
| void | [ExecuteShowPerkConcept](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a62baa1cc355bb9e904543750f89fd91e) () |
| void | [ExecuteStartSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a3952362cc9dd800fdbd2fb588715de23) () |
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
| Public Attributes | |
| readonly [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | [Perk](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a6370eece588a5c6c6ccc6a819824133d) |

|  |  |
| --- | --- |
| Properties | |
| [PerkStates](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a5eb53e4b20a0321143cdf2e48de60794) | [CurrentState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#af39b1b1f382a598fb0791aaf50151614) `[get]` |
| bool | [IsInSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a282f3d0e825f2c5f77ad5a3e3544128b) `[set]` |
| bool | [IsTutorialHighlightEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a33114a6458674543c65b6ebabf2f07d0) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [Hint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#acda13b9f11ab570fc32524c0d7920abb) `[get, set]` |
| int | [Level](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a20f0bfaf41bce38d22ceee287f78a74b) `[get, set]` |
| int | [PerkState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#aae35afbbf51e4e49bec17a5b74bd1ffb) `[get, set]` |
| int | [AlternativeType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a70ad5e9607c06dba590a79657a3a27d7) `[get, set]` |
| string | [LevelText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a69d375d7ef65c5e0c2791484083f4ab8) `[get, set]` |
| string | [BackgroundImage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#ad6eeb5b2a613a371edd14266a707cb3a) `[get, set]` |
| string | [PerkId](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#af8bd6660f340ce8e7f2fced30e296a1e) `[get, set]` |

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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a5eb53e4b20a0321143cdf2e48de60794)PerkStates
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.PerkStates](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a5eb53e4b20a0321143cdf2e48de60794) |

| Enumerator | |
| --- | --- |
| None |  |
| NotEarned |  |
| EarnedButNotSelected |  |
| InSelection |  |
| EarnedAndActive |  |
| EarnedAndNotActive |  |
| EarnedPreviousPerkNotSelected |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a7440d221c2446a97857a288d37a27472)PerkAlternativeType
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.PerkAlternativeType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a7440d221c2446a97857a288d37a27472) |

| Enumerator | |
| --- | --- |
| NoAlternative |  |
| FirstAlternative |  |
| SecondAlternative |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#aabe62702569164129d7b796d0598a83e)PerkVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.PerkVM | ( | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk*, |
|  |  | bool | *isAvailable*, |
|  |  | [PerkAlternativeType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a7440d221c2446a97857a288d37a27472) | *alternativeType*, |
|  |  | Action< PerkVM > | *onStartSelection*, |
|  |  | Action< PerkVM > | *onSelectionOver*, |
|  |  | Func< [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html), bool > | *getIsPerkSelected*, |
|  |  | Func< [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html), bool > | *getIsPreviousPerkSelected* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a2fab54bafd8b4b341b2fca3f621bc620)RefreshState()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.RefreshState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a62baa1cc355bb9e904543750f89fd91e)ExecuteShowPerkConcept()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.ExecuteShowPerkConcept | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a3952362cc9dd800fdbd2fb588715de23)ExecuteStartSelection()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.ExecuteStartSelection | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a6370eece588a5c6c6ccc6a819824133d)Perk
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.Perk |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#af39b1b1f382a598fb0791aaf50151614)CurrentState
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PerkStates](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a5eb53e4b20a0321143cdf2e48de60794) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.CurrentState | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a282f3d0e825f2c5f77ad5a3e3544128b)IsInSelection
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.IsInSelection | | set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a33114a6458674543c65b6ebabf2f07d0)IsTutorialHighlightEnabled
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.IsTutorialHighlightEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#acda13b9f11ab570fc32524c0d7920abb)Hint
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.Hint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a20f0bfaf41bce38d22ceee287f78a74b)Level
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.Level | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#aae35afbbf51e4e49bec17a5b74bd1ffb)PerkState
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.PerkState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a70ad5e9607c06dba590a79657a3a27d7)AlternativeType
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.AlternativeType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#a69d375d7ef65c5e0c2791484083f4ab8)LevelText
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.LevelText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#ad6eeb5b2a613a371edd14266a707cb3a)BackgroundImage
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.BackgroundImage | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html#af8bd6660f340ce8e7f2fced30e296a1e)PerkId
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.PerkVM.PerkId | | getset |


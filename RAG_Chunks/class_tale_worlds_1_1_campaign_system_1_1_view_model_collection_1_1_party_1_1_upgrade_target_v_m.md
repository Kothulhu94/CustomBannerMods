--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [UpgradeTargetVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a74d5362b9c58256bf29a7285178eaf66) (int upgradeIndex, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [CharacterCode](class_tale_worlds_1_1_core_1_1_character_code.html) upgradeCharacterCode, Action< int, int > onUpgraded, Action< UpgradeTargetVM > onFocused) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#ae4065180e2d6e380cf66abf0e3e464ba) () |
|  | Used for updating localized texts. |
| void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a6b56d1a3b520bcfb1048e3e232745425) (int upgradableAmount, bool isAvailable, bool isInsufficient, bool itemRequirementsMet, bool perkRequirementsMet, string hintString, bool isMarinerTroop) |
| void | [ExecuteUpgradeEncyclopediaLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a4d82bb7bf1a581d12a10777df2c32b8d) () |
| void | [ExecuteUpgrade](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a141077d09c9c181c224819498f109bc0) () |
| void | [ExecuteSetFocused](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a3ea37e8bfb4212f75b276ac35da2aae1) () |
| void | [ExecuteSetUnfocused](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#ace267b0d8d4ecd1c62ab132886752106) () |
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
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [PrimaryActionInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a3f7cc0591810b4a40d0bdf038bdf12ec) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [SecondaryActionInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#ab6929950ac7da5e12ae5899cb9dc6276) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [TertiaryActionInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#afe67ab8263785014b21a005f6af77cb2) `[get, set]` |
| [UpgradeRequirementsVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_requirements_v_m.html) | [Requirements](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a584eabcae930f58c75ab132933b53437) `[get, set]` |
| [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) | [TroopImage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#afd2b2473c3e5da904be0a0c8b2429c74) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [Hint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#aa84f32314b1cdd4c66f0c745ed851f17) `[get, set]` |
| int | [AvailableUpgrades](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#af7be94a161c18bc9edfea3cd5a2514b5) `[get, set]` |
| bool | [IsAvailable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#ad83baf0aa71ac512e98807fc9c54f5fa) `[get, set]` |
| bool | [IsInsufficient](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#ada80961cf26f4f5ea0dee35acef9a667) `[get, set]` |
| bool | [IsHighlighted](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#aeb1043c89ebc21d3585bb9689a26b6b7) `[get, set]` |
| bool | [IsMarinerTroop](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#ab79105358b226e0c21fa648da160a8e8) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a74d5362b9c58256bf29a7285178eaf66)UpgradeTargetVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.UpgradeTargetVM | ( | int | *upgradeIndex*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | [CharacterCode](class_tale_worlds_1_1_core_1_1_character_code.html) | *upgradeCharacterCode*, |
|  |  | Action< int, int > | *onUpgraded*, |
|  |  | Action< UpgradeTargetVM > | *onFocused* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#ae4065180e2d6e380cf66abf0e3e464ba)RefreshValues()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a6b56d1a3b520bcfb1048e3e232745425)Refresh()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.Refresh | ( | int | *upgradableAmount*, |
|  |  | bool | *isAvailable*, |
|  |  | bool | *isInsufficient*, |
|  |  | bool | *itemRequirementsMet*, |
|  |  | bool | *perkRequirementsMet*, |
|  |  | string | *hintString*, |
|  |  | bool | *isMarinerTroop* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a4d82bb7bf1a581d12a10777df2c32b8d)ExecuteUpgradeEncyclopediaLink()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.ExecuteUpgradeEncyclopediaLink | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a141077d09c9c181c224819498f109bc0)ExecuteUpgrade()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.ExecuteUpgrade | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a3ea37e8bfb4212f75b276ac35da2aae1)ExecuteSetFocused()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.ExecuteSetFocused | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#ace267b0d8d4ecd1c62ab132886752106)ExecuteSetUnfocused()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.ExecuteSetUnfocused | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a3f7cc0591810b4a40d0bdf038bdf12ec)PrimaryActionInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.PrimaryActionInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#ab6929950ac7da5e12ae5899cb9dc6276)SecondaryActionInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.SecondaryActionInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#afe67ab8263785014b21a005f6af77cb2)TertiaryActionInputKey
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.TertiaryActionInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#a584eabcae930f58c75ab132933b53437)Requirements
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UpgradeRequirementsVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_requirements_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.Requirements | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#afd2b2473c3e5da904be0a0c8b2429c74)TroopImage
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.TroopImage | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#aa84f32314b1cdd4c66f0c745ed851f17)Hint
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.Hint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#af7be94a161c18bc9edfea3cd5a2514b5)AvailableUpgrades
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.AvailableUpgrades | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#ad83baf0aa71ac512e98807fc9c54f5fa)IsAvailable
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.IsAvailable | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#ada80961cf26f4f5ea0dee35acef9a667)IsInsufficient
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.IsInsufficient | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#aeb1043c89ebc21d3585bb9689a26b6b7)IsHighlighted
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.IsHighlighted | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html#ab79105358b226e0c21fa648da160a8e8)IsMarinerTroop
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.UpgradeTargetVM.IsMarinerTroop | | getset |


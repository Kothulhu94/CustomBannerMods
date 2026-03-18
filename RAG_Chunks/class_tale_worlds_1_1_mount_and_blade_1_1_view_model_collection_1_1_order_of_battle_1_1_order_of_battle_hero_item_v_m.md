--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a73df77a4294e1e41ff629b2a0996e9cd) () |
|  | [OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ab3dae466f2c4247e9004c33ebf98b298) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ad9de198302579561475e2512c875bfd7) agent) |
| void | [SetInitialFormation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a91200644b087e24eb5f3f3900bb7b880) ([OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html) formation) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a189563bf5b76403176f91c0c42b782b5) () |
|  | Used for updating localized texts. |
| void | [OnAssignmentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#aea7a91be30f502c3edcf4a247c72f098) () |
| void | [RefreshInformation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ad9395a959c72b58b43a41b6e0507a221) () |
| void | [RefreshAssignmentInfo](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a69c6a9bf98d0528f19ddb9f2a33bb525) () |
| void | [SetIsPreAssigned](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#aafa3627ad2adcefd07e8ecf84aa44fae) (bool isPreAssigned) |
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
| readonly Agent | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ad9de198302579561475e2512c875bfd7) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static Action< [OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a73df77a4294e1e41ff629b2a0996e9cd) > | [OnHeroSelection](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a6455971b90d634a01fd36f680466bc92) |
| static Action< [OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a73df77a4294e1e41ff629b2a0996e9cd) > | [OnHeroAssignedFormationChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#aaf39621d156faab906e660fcc2645e45) |
| static Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ad9de198302579561475e2512c875bfd7), List< [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html) > > | [GetAgentTooltip](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ae0ecd6fa75d0b9331e16f5c96a450cfc) |
| static Action< [OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a73df77a4294e1e41ff629b2a0996e9cd) > | [OnHeroAssignmentBegin](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a1c7a9559ca29a809082acfe0a3236735) |
| static Action< [OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a73df77a4294e1e41ff629b2a0996e9cd) > | [OnHeroAssignmentEnd](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a23781e4f924aaff44c98224398787c71) |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |

|  |  |
| --- | --- |
| Properties | |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [BannerOfHero](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a13a3db3ee5a38b5998d03ab5a2521a61) `[get]` |
| bool | [IsAssignedBeforePlayer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a17e1436dc5a5fd1037924233d641f656) `[get]` |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [InitialFormation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a7d20f010ad2727adf8b4afa7dcf3c66b) `[get]` |
| [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html) | [InitialFormationItem](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a8a7ac3d3eab5dde6795447f5939bdb87) `[get]` |
| [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html) | [CurrentAssignedFormationItem](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a957be8995441819ae06dc622c07a294f) `[get, set]` |
| string | [MismatchedAssignmentDescriptionText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#acaa2c6f21fe7a44a08b388d5fa849cc4) `[get, set]` |
| bool | [IsAssignedToAFormation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a3ebf8a202e0a63d6c9b249a6ca7d55b3) `[get, set]` |
| bool | [IsLeadingAFormation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#af1936b5e3e8e3578fc054fcd37273966) `[get, set]` |
| bool | [HasMismatchedAssignment](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#acf651e8c95337211c8ca8ec8e887e0d8) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a21dad0271df9edeafcf241f955f4990e) `[get, set]` |
| bool | [IsDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ad1c39710f318d6ca7cb912ddad10016c) `[get, set]` |
| bool | [IsShown](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a2503c044924ad0de56acb7d31d73e01f) `[get, set]` |
| bool | [IsMainHero](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ada2a042dc93e40837cba811aa4fd5e99) `[get, set]` |
| [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) | [ImageIdentifier](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ac8acb30f4e5b2f2856a70fa5a80bac05) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [Tooltip](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a476ebfe23cbb2c97ba8715e79c1a8f53) `[get, set]` |
| bool | [IsHighlightActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a126b707b9b2b6daf06c0457b47ab7f44) `[get, set]` |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a73df77a4294e1e41ff629b2a0996e9cd)OrderOfBattleHeroItemVM() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.OrderOfBattleHeroItemVM | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ab3dae466f2c4247e9004c33ebf98b298)OrderOfBattleHeroItemVM() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.OrderOfBattleHeroItemVM | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ad9de198302579561475e2512c875bfd7) | *agent* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a91200644b087e24eb5f3f3900bb7b880)SetInitialFormation()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.SetInitialFormation | ( | [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a189563bf5b76403176f91c0c42b782b5)RefreshValues()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#aea7a91be30f502c3edcf4a247c72f098)OnAssignmentRemoved()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.OnAssignmentRemoved | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ad9395a959c72b58b43a41b6e0507a221)RefreshInformation()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.RefreshInformation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a69c6a9bf98d0528f19ddb9f2a33bb525)RefreshAssignmentInfo()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.RefreshAssignmentInfo | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#aafa3627ad2adcefd07e8ecf84aa44fae)SetIsPreAssigned()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.SetIsPreAssigned | ( | bool | *isPreAssigned* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a6455971b90d634a01fd36f680466bc92)OnHeroSelection
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a73df77a4294e1e41ff629b2a0996e9cd)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.OnHeroSelection | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#aaf39621d156faab906e660fcc2645e45)OnHeroAssignedFormationChanged
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a73df77a4294e1e41ff629b2a0996e9cd)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.OnHeroAssignedFormationChanged | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ae0ecd6fa75d0b9331e16f5c96a450cfc)GetAgentTooltip
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ad9de198302579561475e2512c875bfd7), List<[TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html)> > TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.GetAgentTooltip | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a1c7a9559ca29a809082acfe0a3236735)OnHeroAssignmentBegin
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a73df77a4294e1e41ff629b2a0996e9cd)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.OnHeroAssignmentBegin | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a23781e4f924aaff44c98224398787c71)OnHeroAssignmentEnd
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a73df77a4294e1e41ff629b2a0996e9cd)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.OnHeroAssignmentEnd | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ad9de198302579561475e2512c875bfd7)Agent
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Agent TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.Agent |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a13a3db3ee5a38b5998d03ab5a2521a61)BannerOfHero
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.BannerOfHero | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a17e1436dc5a5fd1037924233d641f656)IsAssignedBeforePlayer
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.IsAssignedBeforePlayer | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a7d20f010ad2727adf8b4afa7dcf3c66b)InitialFormation
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.InitialFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a8a7ac3d3eab5dde6795447f5939bdb87)InitialFormationItem
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.InitialFormationItem | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a957be8995441819ae06dc622c07a294f)CurrentAssignedFormationItem
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.CurrentAssignedFormationItem | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#acaa2c6f21fe7a44a08b388d5fa849cc4)MismatchedAssignmentDescriptionText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.MismatchedAssignmentDescriptionText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a3ebf8a202e0a63d6c9b249a6ca7d55b3)IsAssignedToAFormation
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.IsAssignedToAFormation | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#af1936b5e3e8e3578fc054fcd37273966)IsLeadingAFormation
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.IsLeadingAFormation | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#acf651e8c95337211c8ca8ec8e887e0d8)HasMismatchedAssignment
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.HasMismatchedAssignment | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a21dad0271df9edeafcf241f955f4990e)IsSelected
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ad1c39710f318d6ca7cb912ddad10016c)IsDisabled
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.IsDisabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a2503c044924ad0de56acb7d31d73e01f)IsShown
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.IsShown | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ada2a042dc93e40837cba811aa4fd5e99)IsMainHero
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.IsMainHero | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#ac8acb30f4e5b2f2856a70fa5a80bac05)ImageIdentifier
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.ImageIdentifier | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a476ebfe23cbb2c97ba8715e79c1a8f53)Tooltip
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.Tooltip | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html#a126b707b9b2b6daf06c0457b47ab7f44)IsHighlightActive
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleHeroItemVM.IsHighlightActive | | getset |


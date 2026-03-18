--- SOURCE: class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html ---

TaleWorlds.Core.ViewModelCollection.CharacterViewModel Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html), and [TaleWorlds.Core.ViewModelCollection.CharacterWithActionViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_with_action_view_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [StanceTypes](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ab1386b15327caca260820a2bb6736e9c) {     [None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ab1386b15327caca260820a2bb6736e9ca6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [EmphasizeFace](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ab1386b15327caca260820a2bb6736e9ca3385796b1de18b0f67ac3b5f97c208c7) ,     [SideView](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ab1386b15327caca260820a2bb6736e9ca9b0d3fcb35e341ff846c81699bb3e1ae) ,     [CelebrateVictory](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ab1386b15327caca260820a2bb6736e9ca2d379f2d77cfff6b2354e70a45bb2cb2) ,     [OnMount](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ab1386b15327caca260820a2bb6736e9ca6c44232ee982ae7654971cbb98f9ae9b)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CharacterViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a5836cb8f2dc9e9f3d4ec61c14406facb) () |
|  | [CharacterViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a8506cc6637bbdda8ed639f218f4b363f) ([StanceTypes](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ab1386b15327caca260820a2bb6736e9c) stance=[StanceTypes.None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ab1386b15327caca260820a2bb6736e9ca6adf97f83acf6453d4a6a4b1070f3754)) |
| void | [SetEquipment](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#acc3f1713846b3fd1eb10fffbd1f59542) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) index, [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) item) |
| virtual void | [SetEquipment](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ad199d3dc05f8ca41fa26fe19dc21391e) ([Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) equipment) |
| void | [FillFrom](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a16b291e9d6a2b9d159e3e34e837e2aa9) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, int seed=-1, string bannerCode=null) |
| void | [FillFrom](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ae72a88b45b7966cacb2a88ba21726e0c) ([CharacterViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a5836cb8f2dc9e9f3d4ec61c14406facb) characterViewModel, int seed=-1) |
| void | [ExecuteEquipWeaponAtIndex](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#acc58104e73f8e7237e58c9d32642cb23) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) index, bool isLeftHand) |
| void | [ExecuteStartCustomAnimation](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#af2cf98fd6ec34395c46a6530d7cbab08) (string animation, bool loop=false, float loopInterval=0f) |
| void | [ExecuteStopCustomAnimation](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a9ddc87717477410783e431a801b96650) () |
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
| Static Public Attributes | |
| static Action< [CharacterViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a5836cb8f2dc9e9f3d4ec61c14406facb) > | [OnCustomAnimationFinished](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a994192dde7ab518ee6f43b316369ee54) |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |

|  |  |
| --- | --- |
| Protected Attributes | |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [\_equipment](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#afdfc7e9f4c08414b521f15f9fec0199e) |
| string | [\_bannerCode](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#af882b300dac52dbf5758210ef220fc5a) |

|  |  |
| --- | --- |
| Properties | |
| string | [BannerCodeText](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ade04a44cfcfb043ae7367f7ae7702b46) `[get, set]` |
| string | [BodyProperties](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a1864622984816acfa804eda699906cd6) `[get, set]` |
| string | [MountCreationKey](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a7744987f2eee6c37955dd93df050b465) `[get, set]` |
| string | [CharStringId](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a4d6857ef6ea1ccd524ec557df1709750) `[get, set]` |
| string | [CustomAnimation](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a32eff17911fc8239b83b8e49a092a4f5) `[get, set]` |
| int | [StanceIndex](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a4c638f44549e98db9e776039f4fc8d4c) `[get]` |
| bool | [IsFemale](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a3b81f3d46d236f7064f601b1406956a7) `[get, set]` |
| bool | [IsHidden](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a1d9d01035a330671cc243aea87240ae3) `[get, set]` |
| bool | [IsPlayingCustomAnimations](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a7f2f6f9dfe410ac8097e2c51b4b7bf45) `[get, set]` |
| bool | [ShouldLoopCustomAnimation](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a1fa14f694fa19fd75f0db35740d58208) `[get, set]` |
| float | [CustomAnimationProgressRatio](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a277c82e7be851bc8cf2602b49c692bc8) `[get, set]` |
| float | [CustomAnimationWaitDuration](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a5ff4e221c4c4adb4bd6c251dc232cfca) `[get, set]` |
| int | [Race](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a3ae336af78058316ac53e892b88db122) `[get, set]` |
| bool | [HasMount](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ac52355ce44d95f54f62c0927c4e4fba1) `[get, set]` |
| string | [EquipmentCode](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a5c2a220fa47dc07166bc93c8998979b3) `[get, set]` |
| string | [IdleAction](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a00b3a112a71db0bd32da62e3dc770902) `[get, set]` |
| string | [IdleFaceAnim](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#aab79b7a7055bafa151dbead37a06228c) `[get, set]` |
| uint | [ArmorColor1](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a996f2215d1c795d094119f5a0ea0e31d) `[get, set]` |
| uint | [ArmorColor2](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a17ddbe1656883450bc446266763a56b5) `[get, set]` |
| int | [LeftHandWieldedEquipmentIndex](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a127b2bb5cb89026bbd80477262178159) `[get, set]` |
| int | [RightHandWieldedEquipmentIndex](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a6cb243e53c8d181d5be712f185662d4f) `[get, set]` |

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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ab1386b15327caca260820a2bb6736e9c)StanceTypes
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ViewModelCollection.CharacterViewModel.StanceTypes](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ab1386b15327caca260820a2bb6736e9c) |

| Enumerator | |
| --- | --- |
| None |  |
| EmphasizeFace |  |
| SideView |  |
| CelebrateVictory |  |
| OnMount |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a5836cb8f2dc9e9f3d4ec61c14406facb)CharacterViewModel() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.CharacterViewModel.CharacterViewModel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a8506cc6637bbdda8ed639f218f4b363f)CharacterViewModel() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.CharacterViewModel.CharacterViewModel | ( | [StanceTypes](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ab1386b15327caca260820a2bb6736e9c) | *stance* = [StanceTypes::None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ab1386b15327caca260820a2bb6736e9ca6adf97f83acf6453d4a6a4b1070f3754) | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#acc3f1713846b3fd1eb10fffbd1f59542)SetEquipment() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.CharacterViewModel.SetEquipment | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *index*, |
|  |  | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *item* ) |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ad199d3dc05f8ca41fa26fe19dc21391e)SetEquipment() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Core.ViewModelCollection.CharacterViewModel.SetEquipment | ( | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *equipment* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html#a89291781392379aec060e8dca102d199).

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a16b291e9d6a2b9d159e3e34e837e2aa9)FillFrom() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.CharacterViewModel.FillFrom | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, |
|  |  | int | *seed* = -1, |
|  |  | string | *bannerCode* = null ) |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ae72a88b45b7966cacb2a88ba21726e0c)FillFrom() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.CharacterViewModel.FillFrom | ( | [CharacterViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a5836cb8f2dc9e9f3d4ec61c14406facb) | *characterViewModel*, |
|  |  | int | *seed* = -1 ) |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#acc58104e73f8e7237e58c9d32642cb23)ExecuteEquipWeaponAtIndex()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.CharacterViewModel.ExecuteEquipWeaponAtIndex | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *index*, |
|  |  | bool | *isLeftHand* ) |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#af2cf98fd6ec34395c46a6530d7cbab08)ExecuteStartCustomAnimation()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.CharacterViewModel.ExecuteStartCustomAnimation | ( | string | *animation*, |
|  |  | bool | *loop* = false, |
|  |  | float | *loopInterval* = 0f ) |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a9ddc87717477410783e431a801b96650)ExecuteStopCustomAnimation()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.CharacterViewModel.ExecuteStopCustomAnimation | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a994192dde7ab518ee6f43b316369ee54)OnCustomAnimationFinished
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[CharacterViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a5836cb8f2dc9e9f3d4ec61c14406facb)> TaleWorlds.Core.ViewModelCollection.CharacterViewModel.OnCustomAnimationFinished | | static |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#afdfc7e9f4c08414b521f15f9fec0199e)\_equipment
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.Core.ViewModelCollection.CharacterViewModel.\_equipment | | protected |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#af882b300dac52dbf5758210ef220fc5a)\_bannerCode
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.CharacterViewModel.\_bannerCode | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ade04a44cfcfb043ae7367f7ae7702b46)BannerCodeText
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.CharacterViewModel.BannerCodeText | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a1864622984816acfa804eda699906cd6)BodyProperties
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.CharacterViewModel.BodyProperties | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a7744987f2eee6c37955dd93df050b465)MountCreationKey
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.CharacterViewModel.MountCreationKey | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a4d6857ef6ea1ccd524ec557df1709750)CharStringId
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.CharacterViewModel.CharStringId | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a32eff17911fc8239b83b8e49a092a4f5)CustomAnimation
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.CharacterViewModel.CustomAnimation | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a4c638f44549e98db9e776039f4fc8d4c)StanceIndex
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ViewModelCollection.CharacterViewModel.StanceIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a3b81f3d46d236f7064f601b1406956a7)IsFemale
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ViewModelCollection.CharacterViewModel.IsFemale | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a1d9d01035a330671cc243aea87240ae3)IsHidden
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ViewModelCollection.CharacterViewModel.IsHidden | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a7f2f6f9dfe410ac8097e2c51b4b7bf45)IsPlayingCustomAnimations
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ViewModelCollection.CharacterViewModel.IsPlayingCustomAnimations | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a1fa14f694fa19fd75f0db35740d58208)ShouldLoopCustomAnimation
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ViewModelCollection.CharacterViewModel.ShouldLoopCustomAnimation | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a277c82e7be851bc8cf2602b49c692bc8)CustomAnimationProgressRatio
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ViewModelCollection.CharacterViewModel.CustomAnimationProgressRatio | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a5ff4e221c4c4adb4bd6c251dc232cfca)CustomAnimationWaitDuration
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ViewModelCollection.CharacterViewModel.CustomAnimationWaitDuration | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a3ae336af78058316ac53e892b88db122)Race
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ViewModelCollection.CharacterViewModel.Race | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#ac52355ce44d95f54f62c0927c4e4fba1)HasMount
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ViewModelCollection.CharacterViewModel.HasMount | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a5c2a220fa47dc07166bc93c8998979b3)EquipmentCode
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.CharacterViewModel.EquipmentCode | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a00b3a112a71db0bd32da62e3dc770902)IdleAction
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.CharacterViewModel.IdleAction | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#aab79b7a7055bafa151dbead37a06228c)IdleFaceAnim
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.CharacterViewModel.IdleFaceAnim | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a996f2215d1c795d094119f5a0ea0e31d)ArmorColor1
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.ViewModelCollection.CharacterViewModel.ArmorColor1 | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a17ddbe1656883450bc446266763a56b5)ArmorColor2
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.ViewModelCollection.CharacterViewModel.ArmorColor2 | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a127b2bb5cb89026bbd80477262178159)LeftHandWieldedEquipmentIndex
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ViewModelCollection.CharacterViewModel.LeftHandWieldedEquipmentIndex | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html#a6cb243e53c8d181d5be712f185662d4f)RightHandWieldedEquipmentIndex
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ViewModelCollection.CharacterViewModel.RightHandWieldedEquipmentIndex | | getset |


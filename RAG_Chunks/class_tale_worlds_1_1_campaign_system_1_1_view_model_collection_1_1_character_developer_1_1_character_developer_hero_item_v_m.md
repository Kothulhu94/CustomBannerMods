--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CharacterDeveloperHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a07d587f83957864af8fce3b6324e2a34) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a97ed003e84680be09b649e4c8365ba40) hero, Action onPerkSelection) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a0c3e7c44ee7863b1d6f1d88b1b623ee8) () |
|  | Used for updating localized texts. |
| void | [ExecuteStopInspectingCurrentAttribute](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a9553482cac752b742e0d4d017cc201b0) () |
| void | [RefreshCharacterValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#aa92edb9404e717472a58c63b71ab0888) () |
| void | [RefreshPerksOfSkill](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a24b98fd0aa308d7319769cc974b69cdf) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| void | [ResetChanges](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a14ddaa566b60c5bc38a338c9161f284f) (bool isCancel) |
| void | [ApplyChanges](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a653fb0dce4fa4032fb83bce112b1334c) () |
| void | [SetCurrentSkill](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ac369dbb4e02cf9c49edac29a24094cbf) ([SkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html) skill) |
| bool | [IsThereAnyChanges](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a00b09fde80837e61b10ada1444904762) () |
| int | [GetRequiredFocusPointsToAddFocusWithCurrentFocus](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a9016db1bed771262b73f7ad4d658da24) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| bool | [CanAddFocusToSkillWithFocusAmount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a983fca6e2b9d9984b4449c24b5278f8f) (int currentFocusAmount) |
| bool | [IsSkillMaxAmongOtherSkills](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#abc832eb1596cbca2cb4cc81bad4822d1) ([SkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html) skill) |
| string | [GetNameWithNumOfUnopenedPerks](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a32e056ec6ed7abf570cd07b922a7d580) () |
| int | [GetNumberOfUnselectedPerks](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a6557fcf5ab90dd73b8b555c80e91ea74) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ae9ffcf3210b7731f3cdf382fac7b21c3) () |
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
| HeroDeveloper | [HeroDeveloper](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ac1c60f71355bad2792516a4f7be7b78b) `[get]` |
| Hero | [Hero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a97ed003e84680be09b649e4c8365ba40) `[get]` |
| int | [OrgUnspentFocusPoints](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ae94d7282de149882033d826d66a39153) `[get]` |
| int | [OrgUnspentAttributePoints](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a01fa46efc26986a8ef78473e03fadf72) `[get]` |
| IReadOnlyPropertyOwner< [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) > | [CharacterAttributes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ae6a37911ca85ac2a2f10c5097d385440) `[get]` |
| MBBindingList< [SkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html) > | [Skills](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#aa063be3c0fceca50e917eef8b0a27920) `[get, set]` |
| MBBindingList< [StringPairItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_pair_item_v_m.html) > | [CharacterStats](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#aad4c28bd37e7799be0e879f56339f23d) `[get, set]` |
| MBBindingList< [CharacterAttributeItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_attribute_item_v_m.html) > | [Attributes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#aeb1fe224133ab627bb5226873912b5b4) `[get, set]` |
| MBBindingList< [EncyclopediaTraitItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_trait_item_v_m.html) > | [Traits](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a11bf370c07f64a78e488f8dbe39de9c6) `[get, set]` |
| [PerkSelectionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk12c9ce2038534655a888d90ca2f24c19.html) | [PerkSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#abc4aeb3b327713e5daf595df24da674b) `[get, set]` |
| [SkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html) | [CurrentSkill](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a412a7da18f7713533d3ee44c13f62d47) `[get, set]` |
| [CharacterAttributeItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_attribute_item_v_m.html) | [CurrentInspectedAttribute](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ac1d263c2d8a5fa1ddeb8a0262144539a) `[get, set]` |
| string | [FocusPointsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a1216660278d6273554b472469be0acfd) `[get, set]` |
| string | [LevelProgressText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a1da0cb512fe7c9d967f5ffd351c0c3a4) `[get, set]` |
| [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) | [HeroCharacter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#aa7016efff926e08320a04ee2d438e0b1) `[get, set]` |
| bool | [IsInspectingAnAttribute](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a2e163f9425fc5775b30567dd3db100fe) `[get, set]` |
| int | [LevelProgressPercentage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ade0523b116ba4ce89b0c4b183f96a8b1) `[get, set]` |
| int | [CurrentTotalSkill](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a1d00f2603e1d2574eefc47f3f18b674b) `[get, set]` |
| int | [SkillPointsRequiredForCurrentLevel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ab5b9bb59beed5cf766a6e9afd78c1290) `[get, set]` |
| int | [SkillPointsRequiredForNextLevel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a0f65e500573de5302d7e9f647044feec) `[get, set]` |
| int | [UnspentCharacterPoints](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a6af0a6a2922968c251aa345a1b924da8) `[get, set]` |
| int | [UnspentAttributePoints](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a79a478409280989f742ab25ce6a3f6c9) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [LevelHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a0c53568432d6ad7d2216242292f6f515) `[get, set]` |
| string | [HeroNameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a9ab696f1129701cf90a93964fcf8275f) `[get, set]` |
| string | [HeroInfoText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ad0c7616b3c714cf5a94c669a458b8d88) `[get, set]` |
| string | [HeroLevelText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#aefba56be8935fb196e7d38b0a9d69ee3) `[get, set]` |
| bool | [HasExtraSkills](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a1526622b6010dd324b2d3c1248bb4328) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a07d587f83957864af8fce3b6324e2a34)CharacterDeveloperHeroItemVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.CharacterDeveloperHeroItemVM | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a97ed003e84680be09b649e4c8365ba40) | *hero*, |
|  |  | Action | *onPerkSelection* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a0c3e7c44ee7863b1d6f1d88b1b623ee8)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a9553482cac752b742e0d4d017cc201b0)ExecuteStopInspectingCurrentAttribute()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.ExecuteStopInspectingCurrentAttribute | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#aa92edb9404e717472a58c63b71ab0888)RefreshCharacterValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.RefreshCharacterValues | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a24b98fd0aa308d7319769cc974b69cdf)RefreshPerksOfSkill()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.RefreshPerksOfSkill | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a14ddaa566b60c5bc38a338c9161f284f)ResetChanges()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.ResetChanges | ( | bool | *isCancel* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a653fb0dce4fa4032fb83bce112b1334c)ApplyChanges()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.ApplyChanges | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ac369dbb4e02cf9c49edac29a24094cbf)SetCurrentSkill()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.SetCurrentSkill | ( | [SkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html) | *skill* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a00b09fde80837e61b10ada1444904762)IsThereAnyChanges()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.IsThereAnyChanges | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a9016db1bed771262b73f7ad4d658da24)GetRequiredFocusPointsToAddFocusWithCurrentFocus()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.GetRequiredFocusPointsToAddFocusWithCurrentFocus | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a983fca6e2b9d9984b4449c24b5278f8f)CanAddFocusToSkillWithFocusAmount()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.CanAddFocusToSkillWithFocusAmount | ( | int | *currentFocusAmount* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#abc832eb1596cbca2cb4cc81bad4822d1)IsSkillMaxAmongOtherSkills()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.IsSkillMaxAmongOtherSkills | ( | [SkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html) | *skill* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a32e056ec6ed7abf570cd07b922a7d580)GetNameWithNumOfUnopenedPerks()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.GetNameWithNumOfUnopenedPerks | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a6557fcf5ab90dd73b8b555c80e91ea74)GetNumberOfUnselectedPerks()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.GetNumberOfUnselectedPerks | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ae9ffcf3210b7731f3cdf382fac7b21c3)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ac1c60f71355bad2792516a4f7be7b78b)HeroDeveloper
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | HeroDeveloper TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.HeroDeveloper | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a97ed003e84680be09b649e4c8365ba40)Hero
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Hero TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.Hero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ae94d7282de149882033d826d66a39153)OrgUnspentFocusPoints
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.OrgUnspentFocusPoints | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a01fa46efc26986a8ef78473e03fadf72)OrgUnspentAttributePoints
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.OrgUnspentAttributePoints | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ae6a37911ca85ac2a2f10c5097d385440)CharacterAttributes
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyPropertyOwner<[CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.CharacterAttributes | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#aa063be3c0fceca50e917eef8b0a27920)Skills
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[SkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.Skills | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#aad4c28bd37e7799be0e879f56339f23d)CharacterStats
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[StringPairItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_pair_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.CharacterStats | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#aeb1fe224133ab627bb5226873912b5b4)Attributes
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[CharacterAttributeItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_attribute_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.Attributes | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a11bf370c07f64a78e488f8dbe39de9c6)Traits
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaTraitItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_trait_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.Traits | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#abc4aeb3b327713e5daf595df24da674b)PerkSelection
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PerkSelectionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk12c9ce2038534655a888d90ca2f24c19.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.PerkSelection | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a412a7da18f7713533d3ee44c13f62d47)CurrentSkill
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.CurrentSkill | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ac1d263c2d8a5fa1ddeb8a0262144539a)CurrentInspectedAttribute
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterAttributeItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_attribute_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.CurrentInspectedAttribute | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a1216660278d6273554b472469be0acfd)FocusPointsText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.FocusPointsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a1da0cb512fe7c9d967f5ffd351c0c3a4)LevelProgressText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.LevelProgressText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#aa7016efff926e08320a04ee2d438e0b1)HeroCharacter
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.HeroCharacter | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a2e163f9425fc5775b30567dd3db100fe)IsInspectingAnAttribute
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.IsInspectingAnAttribute | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ade0523b116ba4ce89b0c4b183f96a8b1)LevelProgressPercentage
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.LevelProgressPercentage | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a1d00f2603e1d2574eefc47f3f18b674b)CurrentTotalSkill
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.CurrentTotalSkill | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ab5b9bb59beed5cf766a6e9afd78c1290)SkillPointsRequiredForCurrentLevel
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.SkillPointsRequiredForCurrentLevel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a0f65e500573de5302d7e9f647044feec)SkillPointsRequiredForNextLevel
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.SkillPointsRequiredForNextLevel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a6af0a6a2922968c251aa345a1b924da8)UnspentCharacterPoints
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.UnspentCharacterPoints | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a79a478409280989f742ab25ce6a3f6c9)UnspentAttributePoints
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.UnspentAttributePoints | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a0c53568432d6ad7d2216242292f6f515)LevelHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.LevelHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a9ab696f1129701cf90a93964fcf8275f)HeroNameText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.HeroNameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#ad0c7616b3c714cf5a94c669a458b8d88)HeroInfoText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.HeroInfoText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#aefba56be8935fb196e7d38b0a9d69ee3)HeroLevelText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.HeroLevelText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html#a1526622b6010dd324b2d3c1248bb4328)HasExtraSkills
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperHeroItemVM.HasExtraSkills | | getset |


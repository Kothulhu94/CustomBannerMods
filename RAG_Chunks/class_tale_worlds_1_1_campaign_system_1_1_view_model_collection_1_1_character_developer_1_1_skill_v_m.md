--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a5a41d442f24af004843bc6b4d17f5eeb) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, [CharacterDeveloperHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html) heroItem, Action< [PerkVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html) > onStartPerkSelection) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#adb834d9025f89f0c10c4ae9ad5a88062) () |
|  | Used for updating localized texts. |
| void | [InitializeValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ad60de02319d948ac9e35c43882accb34) () |
| void | [RefreshWithCurrentValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a7345725dad16faf94044cc11fed39691) () |
| void | [CreateLists](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#aeaf1ad1fb66a5d844d43602057a21f33) () |
| void | [RefreshLists](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a12d6014e8358c50099aff66fcf30f2aa) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill=null) |
| void | [RefreshCanAddFocus](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ad99696dd3ededdadbc14ebddeffeebb2) () |
| void | [ExecuteAddFocus](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a5bd940c12726d298dc3ca62d8824e0b8) () |
| void | [ExecuteShowFocusConcept](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#af87c70f0492ad62cbe676eb368e216ec) () |
| void | [ExecuteShowSkillConcept](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a8f4f3a7d51d6731482136cef8ba73626) () |
| void | [ExecuteInspect](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ad3e9de9d5061f944a0da3f8493765b98) () |
| void | [ResetChanges](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a795b18324d0f804b4ffcb0502558345b) () |
| bool | [IsThereAnyChanges](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ad036794d70d8d155b9ff7903eab1290b) () |
| void | [ApplyChanges](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a92a9bd47c6304acfbd958618adfc1dbe) () |
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
| readonly [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [Skill](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#acbbb2bf7c9e63017160a1b1b50f9296d) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MAX\_SKILL\_LEVEL](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ab4c7b49bd0a63c90a60635e64ba8eae8) = 300 |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |

|  |  |
| --- | --- |
| Properties | |
| string | [DescriptionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ad185bed2f77a8a836a686a0f6cd01ffd) `[get, set]` |
| string | [HowToLearnText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a4a8ea8b9701aff3c898452f4a0e0cc17) `[get, set]` |
| string | [HowToLearnTitle](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a49315ae1b64064459887fededc077f2c) `[get, set]` |
| bool | [CanAddFocus](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a61f7ed478ff92b515e05bc5113b2228b) `[get, set]` |
| bool | [CanLearnSkill](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a3836e4648973a6aa9f7c72431be4567e) `[get, set]` |
| string | [NextLevelLearningRateText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#aa5bcc5400269da0881ef7e00bf370686) `[get, set]` |
| string | [NextLevelCostText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a905a00404e8ccb8e991eba422a0abd29) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [ProgressHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ab8940102ae3fc6ec263991f93f162b4e) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [SkillXPHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ae8ae9eed4ccbe297f753ef62072d9cb2) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [AddFocusHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ac11fbdf659ebfbb624da0d4c9c8c78d0) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [LearningLimitTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a9f9d358e4ad5d5fec913078f1d5ecd9d) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [LearningRateTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a169fa8a906fb9abd55f1d07cec80a3a7) `[get, set]` |
| double | [ProgressPercentage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#afdfc37c6b154fb5c7acd51cf40c97c44) `[get, set]` |
| float | [LearningRate](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#aaf68bdf7d136176e7e1d3267c3100565) `[get, set]` |
| int | [CurrentSkillXP](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a018dfcd191ac357a417820c59cba24a0) `[get, set]` |
| int | [NextLevel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a7c33df86c28d881a32ae5d57e2329ecc) `[get, set]` |
| int | [FullLearningRateLevel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a901581793289c0ad205e6c8a383cc845) `[get, set]` |
| int | [XpRequiredForNextLevel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#aa982627be077fd7f31eb8d2aa358063f) `[get, set]` |
| int | [NumOfUnopenedPerks](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a912fab0e23b61836378b47a70c59a3df) `[get, set]` |
| string | [ProgressText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a98b5e018e4cbaa17b28d34e3fd027cac) `[get, set]` |
| string | [FocusCostText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a9383a339e362a19b9eebea76af2a5f19) `[get, set]` |
| MBBindingList< [PerkVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html) > | [Perks](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a62f422b4538de092cbb0ac2f3d1066e8) `[get, set]` |
| MBBindingList< [BindingListStringItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_binding_list_string_item.html) > | [SkillEffects](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a44667ba1c56dfaff268359c559c1b6e7) `[get, set]` |
| int | [MaxLevel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a7c4ed98929d62b593d534f948cedb542) `[get, set]` |
| string | [CurrentLearningRateText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a190e4c171eceb27bb93307c6ed0d2eaa) `[get, set]` |
| int | [CurrentFocusLevel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a65f5b90c13c6208c2e317220c58a6bc3) `[get, set]` |
| string | [AddFocusText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a2fbab2fb4b41ba17efa812804d46d159) `[get, set]` |
| string | [SkillId](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a56d7b3542e95d29b100defa29994d2fe) `[get, set]` |
| bool | [IsInspected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#aacae55757193d0610a3e10e723e64672) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a4e129a3f85a8cf855254e55b1bb5cd58) `[get, set]` |
| int | [Level](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a385f3907370c19ade3c980bc31a85257) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a5a41d442f24af004843bc6b4d17f5eeb)SkillVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.SkillVM | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | [CharacterDeveloperHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html) | *heroItem*, |
|  |  | Action< [PerkVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html) > | *onStartPerkSelection* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#adb834d9025f89f0c10c4ae9ad5a88062)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ad60de02319d948ac9e35c43882accb34)InitializeValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.InitializeValues | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a7345725dad16faf94044cc11fed39691)RefreshWithCurrentValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.RefreshWithCurrentValues | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#aeaf1ad1fb66a5d844d43602057a21f33)CreateLists()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.CreateLists | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a12d6014e8358c50099aff66fcf30f2aa)RefreshLists()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.RefreshLists | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* = null | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ad99696dd3ededdadbc14ebddeffeebb2)RefreshCanAddFocus()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.RefreshCanAddFocus | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a5bd940c12726d298dc3ca62d8824e0b8)ExecuteAddFocus()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.ExecuteAddFocus | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#af87c70f0492ad62cbe676eb368e216ec)ExecuteShowFocusConcept()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.ExecuteShowFocusConcept | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a8f4f3a7d51d6731482136cef8ba73626)ExecuteShowSkillConcept()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.ExecuteShowSkillConcept | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ad3e9de9d5061f944a0da3f8493765b98)ExecuteInspect()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.ExecuteInspect | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a795b18324d0f804b4ffcb0502558345b)ResetChanges()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.ResetChanges | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ad036794d70d8d155b9ff7903eab1290b)IsThereAnyChanges()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.IsThereAnyChanges | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a92a9bd47c6304acfbd958618adfc1dbe)ApplyChanges()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.ApplyChanges | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ab4c7b49bd0a63c90a60635e64ba8eae8)MAX\_SKILL\_LEVEL
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.MAX\_SKILL\_LEVEL = 300 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#acbbb2bf7c9e63017160a1b1b50f9296d)Skill
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.Skill |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ad185bed2f77a8a836a686a0f6cd01ffd)DescriptionText
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.DescriptionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a4a8ea8b9701aff3c898452f4a0e0cc17)HowToLearnText
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.HowToLearnText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a49315ae1b64064459887fededc077f2c)HowToLearnTitle
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.HowToLearnTitle | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a61f7ed478ff92b515e05bc5113b2228b)CanAddFocus
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.CanAddFocus | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a3836e4648973a6aa9f7c72431be4567e)CanLearnSkill
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.CanLearnSkill | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#aa5bcc5400269da0881ef7e00bf370686)NextLevelLearningRateText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.NextLevelLearningRateText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a905a00404e8ccb8e991eba422a0abd29)NextLevelCostText
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.NextLevelCostText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ab8940102ae3fc6ec263991f93f162b4e)ProgressHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.ProgressHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ae8ae9eed4ccbe297f753ef62072d9cb2)SkillXPHint
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.SkillXPHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#ac11fbdf659ebfbb624da0d4c9c8c78d0)AddFocusHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.AddFocusHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a9f9d358e4ad5d5fec913078f1d5ecd9d)LearningLimitTooltip
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.LearningLimitTooltip | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a169fa8a906fb9abd55f1d07cec80a3a7)LearningRateTooltip
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.LearningRateTooltip | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#afdfc37c6b154fb5c7acd51cf40c97c44)ProgressPercentage
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.ProgressPercentage | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#aaf68bdf7d136176e7e1d3267c3100565)LearningRate
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.LearningRate | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a018dfcd191ac357a417820c59cba24a0)CurrentSkillXP
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.CurrentSkillXP | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a7c33df86c28d881a32ae5d57e2329ecc)NextLevel
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.NextLevel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a901581793289c0ad205e6c8a383cc845)FullLearningRateLevel
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.FullLearningRateLevel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#aa982627be077fd7f31eb8d2aa358063f)XpRequiredForNextLevel
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.XpRequiredForNextLevel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a912fab0e23b61836378b47a70c59a3df)NumOfUnopenedPerks
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.NumOfUnopenedPerks | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a98b5e018e4cbaa17b28d34e3fd027cac)ProgressText
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.ProgressText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a9383a339e362a19b9eebea76af2a5f19)FocusCostText
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.FocusCostText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a62f422b4538de092cbb0ac2f3d1066e8)Perks
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[PerkVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_perk_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.Perks | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a44667ba1c56dfaff268359c559c1b6e7)SkillEffects
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[BindingListStringItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_binding_list_string_item.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.SkillEffects | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a7c4ed98929d62b593d534f948cedb542)MaxLevel
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.MaxLevel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a190e4c171eceb27bb93307c6ed0d2eaa)CurrentLearningRateText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.CurrentLearningRateText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a65f5b90c13c6208c2e317220c58a6bc3)CurrentFocusLevel
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.CurrentFocusLevel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a2fbab2fb4b41ba17efa812804d46d159)AddFocusText
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.AddFocusText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a56d7b3542e95d29b100defa29994d2fe)SkillId
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.SkillId | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#aacae55757193d0610a3e10e723e64672)IsInspected
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.IsInspected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a4e129a3f85a8cf855254e55b1bb5cd58)NameText
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_skill_v_m.html#a385f3907370c19ade3c980bc31a85257)Level
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.SkillVM.Level | | getset |


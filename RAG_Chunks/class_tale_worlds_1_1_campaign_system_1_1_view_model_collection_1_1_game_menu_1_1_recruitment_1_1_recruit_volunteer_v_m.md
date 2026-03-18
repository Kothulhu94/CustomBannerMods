--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [RecruitVolunteerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#ac349e0efee9911478c3f5e327c8fea3e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, List< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > troops, Action< RecruitVolunteerVM, [RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) > onRecruit, Action< RecruitVolunteerVM, [RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) > onRemoveFromCart) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a0960016ce1c732ddd6d616ef9b40d688) () |
|  | Used for updating localized texts. |
| void | [ExecuteRecruit](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a8b0e448020cadaebd978fdeb6fb85dba) ([RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) troop) |
| void | [ExecuteRemoveFromCart](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a2817d5e23b588a8150942154a3b3ff83) ([RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) troop) |
| void | [OnRecruitMoveToCart](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#ac19a12712000268e96cc762686edd71d) ([RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) troop) |
| void | [OnRecruitRemovedFromCart](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a8d9f3b67511fc2a47e32e815498211ab) ([RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) troop) |
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
| int | [RecruitableNumber](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a7e69ca806ebc41afe15e4f7e324eccbd) |

|  |  |
| --- | --- |
| Properties | |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [OwnerHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#adb7676e53f3b095eb10bd7d8023566af) `[get]` |
| List< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [VolunteerTroops](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a3afeeef4129090ab7dc5c11386e5c772) `[get]` |
| int | [GoldCost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#aa54a05de36a766a57cf3f15375a0b2fd) `[get]` |
| MBBindingList< [RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) > | [Troops](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#ad1f81596b634ba908b9375cce8cf8a9c) `[get, set]` |
| [RecruitVolunteerOwnerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_owner_v_m.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a0935e3e531081f1245fd000e1fd0d483) `[get, set]` |
| bool | [CanRecruit](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a779b541889f12f60d102ac71c4bc6223) `[get, set]` |
| bool | [ButtonIsVisible](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#ad4b63555e5c5533a3a307dca72b04249) `[get, set]` |
| string | [QuantityText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a87a9d09b1c727adc95d7dcc1fdbe2861) `[get, set]` |
| string | [RecruitText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#aecca6d1bf3c5035956291f0e1088de61) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RecruitHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#ae23bc88168b0f0b9e58830e0de05b49d) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#ac349e0efee9911478c3f5e327c8fea3e)RecruitVolunteerVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.RecruitVolunteerVM | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, |
|  |  | List< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *troops*, |
|  |  | Action< RecruitVolunteerVM, [RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) > | *onRecruit*, |
|  |  | Action< RecruitVolunteerVM, [RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) > | *onRemoveFromCart* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a0960016ce1c732ddd6d616ef9b40d688)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a8b0e448020cadaebd978fdeb6fb85dba)ExecuteRecruit()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.ExecuteRecruit | ( | [RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) | *troop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a2817d5e23b588a8150942154a3b3ff83)ExecuteRemoveFromCart()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.ExecuteRemoveFromCart | ( | [RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) | *troop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#ac19a12712000268e96cc762686edd71d)OnRecruitMoveToCart()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.OnRecruitMoveToCart | ( | [RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) | *troop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a8d9f3b67511fc2a47e32e815498211ab)OnRecruitRemovedFromCart()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.OnRecruitRemovedFromCart | ( | [RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html) | *troop* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a7e69ca806ebc41afe15e4f7e324eccbd)RecruitableNumber
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.RecruitableNumber |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#adb7676e53f3b095eb10bd7d8023566af)OwnerHero
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.OwnerHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a3afeeef4129090ab7dc5c11386e5c772)VolunteerTroops
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.VolunteerTroops | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#aa54a05de36a766a57cf3f15375a0b2fd)GoldCost
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.GoldCost | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#ad1f81596b634ba908b9375cce8cf8a9c)Troops
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[RecruitVolunteerTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_troop_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.Troops | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a0935e3e531081f1245fd000e1fd0d483)Owner
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [RecruitVolunteerOwnerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_owner_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.Owner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a779b541889f12f60d102ac71c4bc6223)CanRecruit
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.CanRecruit | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#ad4b63555e5c5533a3a307dca72b04249)ButtonIsVisible
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.ButtonIsVisible | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#a87a9d09b1c727adc95d7dcc1fdbe2861)QuantityText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.QuantityText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#aecca6d1bf3c5035956291f0e1088de61)RecruitText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.RecruitText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_recruitment_1_1_recruit_volunteer_v_m.html#ae23bc88168b0f0b9e58830e0de05b49d)RecruitHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Recruitment.RecruitVolunteerVM.RecruitHint | | getset |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [QuestItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a443ba49d29ac9bdc8ef36aae1f635f42) ([JournalLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html) questLogEntry, Action< QuestItemVM > onSelection, [QuestsVM.QuestCompletionType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a04858789df69f892035af07445bdce12) completion) |
|  | [QuestItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a0bea29ea5b3eebadce0cca40dd538db9) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest, Action< QuestItemVM > onSelection) |
|  | [QuestItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a9785d5f2aaf806f50b1c5177128ec122) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue, Action< QuestItemVM > onSelection) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a370c9cd4eda4e82ea8dfa1a4c32ed5a6) () |
|  | Used for updating localized texts. |
| void | [UpdateIsUpdated](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#ac8d207ed53a110f77e6aa6a693315b5a) () |
| void | [ExecuteSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a057a3ee9d510bcc2355e33943d5513d7) () |
| void | [ExecuteToggleQuestTrack](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a72a3a035e486952bc1e7c105a3f5bbce) () |
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
| [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | [Quest](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a7704224f229bc26a6ca9d308b5282f94) `[get]` |
| [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | [Issue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#aef73a3453d422e5620b67ad251b9ecc6) `[get]` |
| [JournalLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html) | [QuestLogEntry](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a87c8f1c779fceee44452c11b28d66e12) `[get]` |
| string | [Name](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a5ba1524f7269bf1fe350f2c67e3b464d) `[get, set]` |
| int | [CompletionTypeAsInt](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a36fa18924b026e22305d513dc702ad0f) `[get, set]` |
| bool | [IsMainQuest](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a14daed833fe469ebdf512f8ca92a8652) `[get, set]` |
| bool | [IsNavalQuest](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a2de6e1b4d4f78f2d91ba2e8d1bf831ff) `[get, set]` |
| bool | [IsCompletedSuccessfully](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a997f4d19be7cfbe722daae14a1a0c76e) `[get, set]` |
| bool | [IsCompleted](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a17fd327aa2ab112f7fa51e05493e8334) `[get, set]` |
| bool | [IsUpdated](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a9e563835edc3bd2ef22cd62ca716e1e1) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a79f23f7813dcccaf73f3b5a71f21924a) `[get, set]` |
| bool | [IsRemainingDaysHidden](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a184fd685948d9b3f709c39a97f7ef59e) `[get, set]` |
| bool | [IsTracked](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#ad4dc558d088d43046019cb2cbdd08716) `[get, set]` |
| bool | [IsTrackable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#aa5586e5479b367b1753a46f89450487d) `[get, set]` |
| string | [RemainingDaysText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a6978adf1232020a5ac3656cb62531e05) `[get, set]` |
| string | [RemainingDaysTextCombined](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a93edf8f7f5306d096e79adb882955d4b) `[get, set]` |
| int | [RemainingDays](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#ab9c58d9ba15cff24e8f0cb037a9ca3ef) `[get, set]` |
| [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) | [QuestGiverHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#af9cc80f78bc41e12cfe53bc1802cba52) `[get, set]` |
| bool | [IsQuestGiverHeroHidden](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a3ee633e7fa7c57e2979c3f4b1cc33460) `[get, set]` |
| MBBindingList< [QuestStageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_stage_v_m.html) > | [Stages](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a1c37920df2f97f76a3215bda6f6c0bbf) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a443ba49d29ac9bdc8ef36aae1f635f42)QuestItemVM() [1/3]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.QuestItemVM | ( | [JournalLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html) | *questLogEntry*, |
|  |  | Action< QuestItemVM > | *onSelection*, |
|  |  | [QuestsVM.QuestCompletionType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a04858789df69f892035af07445bdce12) | *completion* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a0bea29ea5b3eebadce0cca40dd538db9)QuestItemVM() [2/3]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.QuestItemVM | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest*, |
|  |  | Action< QuestItemVM > | *onSelection* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a9785d5f2aaf806f50b1c5177128ec122)QuestItemVM() [3/3]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.QuestItemVM | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue*, |
|  |  | Action< QuestItemVM > | *onSelection* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a370c9cd4eda4e82ea8dfa1a4c32ed5a6)RefreshValues()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#ac8d207ed53a110f77e6aa6a693315b5a)UpdateIsUpdated()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.UpdateIsUpdated | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a057a3ee9d510bcc2355e33943d5513d7)ExecuteSelection()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.ExecuteSelection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a72a3a035e486952bc1e7c105a3f5bbce)ExecuteToggleQuestTrack()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.ExecuteToggleQuestTrack | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a7704224f229bc26a6ca9d308b5282f94)Quest
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.Quest | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#aef73a3453d422e5620b67ad251b9ecc6)Issue
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.Issue | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a87c8f1c779fceee44452c11b28d66e12)QuestLogEntry
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [JournalLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html) TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.QuestLogEntry | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a5ba1524f7269bf1fe350f2c67e3b464d)Name
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.Name | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a36fa18924b026e22305d513dc702ad0f)CompletionTypeAsInt
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.CompletionTypeAsInt | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a14daed833fe469ebdf512f8ca92a8652)IsMainQuest
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.IsMainQuest | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a2de6e1b4d4f78f2d91ba2e8d1bf831ff)IsNavalQuest
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.IsNavalQuest | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a997f4d19be7cfbe722daae14a1a0c76e)IsCompletedSuccessfully
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.IsCompletedSuccessfully | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a17fd327aa2ab112f7fa51e05493e8334)IsCompleted
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.IsCompleted | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a9e563835edc3bd2ef22cd62ca716e1e1)IsUpdated
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.IsUpdated | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a79f23f7813dcccaf73f3b5a71f21924a)IsSelected
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a184fd685948d9b3f709c39a97f7ef59e)IsRemainingDaysHidden
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.IsRemainingDaysHidden | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#ad4dc558d088d43046019cb2cbdd08716)IsTracked
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.IsTracked | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#aa5586e5479b367b1753a46f89450487d)IsTrackable
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.IsTrackable | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a6978adf1232020a5ac3656cb62531e05)RemainingDaysText
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.RemainingDaysText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a93edf8f7f5306d096e79adb882955d4b)RemainingDaysTextCombined
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.RemainingDaysTextCombined | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#ab9c58d9ba15cff24e8f0cb037a9ca3ef)RemainingDays
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.RemainingDays | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#af9cc80f78bc41e12cfe53bc1802cba52)QuestGiverHero
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.QuestGiverHero | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a3ee633e7fa7c57e2979c3f4b1cc33460)IsQuestGiverHeroHidden
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.IsQuestGiverHeroHidden | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html#a1c37920df2f97f76a3215bda6f6c0bbf)Stages
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[QuestStageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_stage_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestItemVM.Stages | | getset |


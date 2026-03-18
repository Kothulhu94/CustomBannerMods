--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [QuestCompletionType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a04858789df69f892035af07445bdce12) {     [Active](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a04858789df69f892035af07445bdce12a4d3d769b812b6faa6b76e1a8abaece2d) ,     [Successful](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a04858789df69f892035af07445bdce12a30ae8fff8898dc197acd49d9c0797d20) ,     [UnSuccessful](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a04858789df69f892035af07445bdce12ab1c7391265355e510a130830062ee490)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [QuestsVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a48bfd8a196eb18d04b4c2355e2663cd7) (Action closeQuestsScreen) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a6b36b003ef76a290ae34771e886fe6cb) () |
|  | Used for updating localized texts. |
| void | [ExecuteOpenQuestGiverEncyclopedia](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#ae2c013c0c05682ea3f308e2e6313c063) () |
| void | [ExecuteClose](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a3fbaac2158e74a05a13785523f0072a1) () |
| void | [SetSelectedIssue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#ac7e1aac388e625f8908d5137217d310d) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
| void | [SetSelectedQuest](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a5745ffe0f12142723536925ced98a808) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest) |
| void | [SetSelectedLog](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a9fb066951ffad71d82c1568841aedc69) ([JournalLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html) log) |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a192c68764f4e27b7ba30be0e03ad5e37) () |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a6d86e84f10938d382279a70f9d9ee0b9) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#af3e249e2b5611861fd41d955a5e6265b) `[get, set]` |
| [QuestItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html) | [SelectedQuest](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#afe5765c3019c2d360bbead3d0b7d319d) `[get, set]` |
| MBBindingList< [QuestItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html) > | [ActiveQuestsList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#abc3d23e8a12c23aa8904e7d7ee06a8b6) `[get, set]` |
| MBBindingList< [QuestItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html) > | [OldQuestsList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a87e4d0be6176243b41253302fa300317) `[get, set]` |
| [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) | [CurrentQuestGiverHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#ab7183b903760e8168ec19065e1b0ba4e) `[get, set]` |
| string | [TimeRemainingLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#abb0e54b60f8738e481d1cc9739a19a68) `[get, set]` |
| bool | [IsThereAnyQuest](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#af577329e8b3c9ce8451bbe2a4b7bb9bb) `[get, set]` |
| string | [NoActiveQuestText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a312351c75e236a4f319b6f1b0e7ad90b) `[get, set]` |
| string | [SortQuestsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a7deb833b495d71366944c9511c69521a) `[get, set]` |
| string | [QuestGiverText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a1d8e942c24c5dd254dfd67e6c026df7f) `[get, set]` |
| string | [QuestTitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#abbf950c382f70e77d2a249cf2a306654) `[get, set]` |
| string | [OldQuestsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a5ad35fbc1ca619d912cfca9f92668d5f) `[get, set]` |
| string | [ActiveQuestsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a583d1c58e83e01df2d6fe5225b1bf229) `[get, set]` |
| string | [DoneLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#ab8eb9f1ca9761a6b31d706dc34074090) `[get, set]` |
| string | [CurrentQuestTitle](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a4ba61ad2a1ff79576f2b83a3f066d4c4) `[get, set]` |
| bool | [IsCurrentQuestGiverHeroHidden](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a055a6986dc6a9479d76185a1dcb1e93f) `[get, set]` |
| MBBindingList< [QuestStageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_stage_v_m.html) > | [CurrentQuestStages](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a4c29789398d93ec9ceb18f12315fd39e) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [TimeRemainingHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a6bc45957f845f200ce0d0b9674f9fc31) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [OldQuestsHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#aec4bf91b93f2286fc0015cce2bfb7c8a) `[get, set]` |
| [QuestItemSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_sort_controller_v_m.html) | [ActiveQuestsSortController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a173d1831d2b8387e688c803ecde4a085) `[get, set]` |
| [QuestItemSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_sort_controller_v_m.html) | [OldQuestsSortController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a6c69f24cd471fdcef81d47d5e4f9b383) `[get, set]` |
| SelectorVM< [SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html) > | [SortSelector](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a9a7ee2d116f9061d4c765b6556a3ab30) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a04858789df69f892035af07445bdce12)QuestCompletionType
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.QuestCompletionType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a04858789df69f892035af07445bdce12) |

| Enumerator | |
| --- | --- |
| Active |  |
| Successful |  |
| UnSuccessful |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a48bfd8a196eb18d04b4c2355e2663cd7)QuestsVM()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.QuestsVM | ( | Action | *closeQuestsScreen* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a6b36b003ef76a290ae34771e886fe6cb)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#ae2c013c0c05682ea3f308e2e6313c063)ExecuteOpenQuestGiverEncyclopedia()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.ExecuteOpenQuestGiverEncyclopedia | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a3fbaac2158e74a05a13785523f0072a1)ExecuteClose()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.ExecuteClose | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#ac7e1aac388e625f8908d5137217d310d)SetSelectedIssue()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.SetSelectedIssue | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a5745ffe0f12142723536925ced98a808)SetSelectedQuest()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.SetSelectedQuest | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a9fb066951ffad71d82c1568841aedc69)SetSelectedLog()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.SetSelectedLog | ( | [JournalLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_journal_log_entry.html) | *log* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a192c68764f4e27b7ba30be0e03ad5e37)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a6d86e84f10938d382279a70f9d9ee0b9)SetDoneInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#af3e249e2b5611861fd41d955a5e6265b)DoneInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#afe5765c3019c2d360bbead3d0b7d319d)SelectedQuest
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [QuestItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.SelectedQuest | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#abc3d23e8a12c23aa8904e7d7ee06a8b6)ActiveQuestsList
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[QuestItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.ActiveQuestsList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a87e4d0be6176243b41253302fa300317)OldQuestsList
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[QuestItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.OldQuestsList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#ab7183b903760e8168ec19065e1b0ba4e)CurrentQuestGiverHero
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.CurrentQuestGiverHero | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#abb0e54b60f8738e481d1cc9739a19a68)TimeRemainingLbl
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.TimeRemainingLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#af577329e8b3c9ce8451bbe2a4b7bb9bb)IsThereAnyQuest
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.IsThereAnyQuest | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a312351c75e236a4f319b6f1b0e7ad90b)NoActiveQuestText
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.NoActiveQuestText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a7deb833b495d71366944c9511c69521a)SortQuestsText
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.SortQuestsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a1d8e942c24c5dd254dfd67e6c026df7f)QuestGiverText
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.QuestGiverText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#abbf950c382f70e77d2a249cf2a306654)QuestTitleText
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.QuestTitleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a5ad35fbc1ca619d912cfca9f92668d5f)OldQuestsText
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.OldQuestsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a583d1c58e83e01df2d6fe5225b1bf229)ActiveQuestsText
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.ActiveQuestsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#ab8eb9f1ca9761a6b31d706dc34074090)DoneLbl
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.DoneLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a4ba61ad2a1ff79576f2b83a3f066d4c4)CurrentQuestTitle
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.CurrentQuestTitle | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a055a6986dc6a9479d76185a1dcb1e93f)IsCurrentQuestGiverHeroHidden
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.IsCurrentQuestGiverHeroHidden | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a4c29789398d93ec9ceb18f12315fd39e)CurrentQuestStages
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[QuestStageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_stage_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.CurrentQuestStages | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a6bc45957f845f200ce0d0b9674f9fc31)TimeRemainingHint
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.TimeRemainingHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#aec4bf91b93f2286fc0015cce2bfb7c8a)OldQuestsHint
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.OldQuestsHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a173d1831d2b8387e688c803ecde4a085)ActiveQuestsSortController
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [QuestItemSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_sort_controller_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.ActiveQuestsSortController | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a6c69f24cd471fdcef81d47d5e4f9b383)OldQuestsSortController
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [QuestItemSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_item_sort_controller_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.OldQuestsSortController | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quests_v_m.html#a9a7ee2d116f9061d4c765b6556a3ab30)SortSelector
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Quests.QuestsVM.SortSelector | | getset |


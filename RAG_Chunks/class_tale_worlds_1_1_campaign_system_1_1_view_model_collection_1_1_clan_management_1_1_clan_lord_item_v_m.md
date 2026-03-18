--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ClanLordItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a686c5cc6137fc298991adefef8a823aa) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [ITeleportationCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html) teleportationBehavior, Action< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > showHeroOnMap, Action< ClanLordItemVM > onCharacterSelect, Action onRecall, Action onTalk) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a4fab8d1a65f169b7018dd53d820b9bd8) () |
|  | Used for updating localized texts. |
| void | [ExecuteLocationLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a56ccc7f1eeb67ec8df2eb32736472b7f) (string link) |
| void | [UpdateProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#aac1dd9f053f6c90c2f2b075931b91be3) () |
| void | [ExecuteLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a59f0b9ef7761fe59e35511d467b9145e) () |
| void | [OnCharacterSelect](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ae61feb8b71163b5322243a3ab14780c4) () |
| virtual void | [ExecuteBeginHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a9fd182d3c840f986dbc7941ce57a14a1) () |
| virtual void | [ExecuteEndHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a6dab5c84e88dd986866a8cf6b54ee65a) () |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ac30a6bb190beac125cfc050e1f07e265) () |
| void | [ExecuteRename](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a4f3736546c115f9c3a2f186e1aea17bc) () |
| void | [ExecuteShowOnMap](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ac4159179706e90b644319acc45958a51) () |
| void | [ExecuteRecall](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ae2139af22113f6ee3ba26fe568b1e3e5) () |
| void | [ExecuteTalk](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a2412541a5c766192758b95eb3565a82d) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a4df9ca4c94b5b6b64e33056f664b3117) () |
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
| MBBindingList< [EncyclopediaSkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_skill_v_m.html) > | [Skills](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#abf504a0462a6f97c751d70ba0589e0e4) `[get, set]` |
| MBBindingList< [EncyclopediaTraitItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_trait_item_v_m.html) > | [Traits](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a43db81faeaccb0d2fbba5f0f945ef95e) `[get, set]` |
| [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) | [HeroModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a8d4e97e392b99330a2c5d1493e0fba0d) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a7d8bcb15acea48f4de95026034983b77) `[get, set]` |
| bool | [IsChild](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ac6c88b6e47001a891ee258dc702e36fd) `[get, set]` |
| bool | [IsTeleporting](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a7af4b416804e0ff9ac1b06b6926d639c) `[get, set]` |
| bool | [IsRecallVisible](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a31efd946419248ef1d3f38bd62e71bee) `[get, set]` |
| bool | [IsRecallEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#aa841f11b050b821d282ab095fd881db4) `[get, set]` |
| bool | [IsTalkVisible](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a70dddccdca1ff9f19a4f2e7391c271db) `[get, set]` |
| bool | [IsTalkEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ab6ed05c534cab66e838bd9cf556b4b1c) `[get, set]` |
| bool | [CanShowLocationOfHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#abb47471aa9fdc55770c91845175eee77) `[get, set]` |
| bool | [IsMainHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a41f1528ae4c7b720d9d8b459216853bc) `[get, set]` |
| bool | [IsFamilyMember](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a55d04471ebdb818fa8ce47546a21dc61) `[get, set]` |
| bool | [IsPregnant](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a7661023a5eba3bcfca247f805169eeba) `[get, set]` |
| [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) | [Visual](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ad5e252d1456f9efe4428179101fc8336) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [Banner\_9](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a85c13e2d036ba5c15a28a59ec7505bd2) `[get, set]` |
| string | [LocationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a51213da421fefa28dadd85774278e426) `[get, set]` |
| string | [CurrentActionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a5ed66b719d62dd13937126c17ec07f50) `[get, set]` |
| string | [RelationToMainHeroText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#abea786d5b1246b55bb5e5f13466b0afe) `[get, set]` |
| string | [GovernorOfText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a835a86c4c85a6786467f8cee9cd07e16) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a99581b6993774820321114fe32ae62b9) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [PregnantHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a208bb25a891bb5a558a9b5fbc2b8302b) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ShowOnMapHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#aa1f5d8572b3f4ff5de7fe2f07003a91d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RecallHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a6c9d3fa570500b656576dc8a75d0ff0e) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [TalkHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a21f6fbfe0ea81ad92659caaf2ae78791) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a686c5cc6137fc298991adefef8a823aa)ClanLordItemVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.ClanLordItemVM | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [ITeleportationCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_teleportation_campaign_behavior.html) | *teleportationBehavior*, |
|  |  | Action< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | *showHeroOnMap*, |
|  |  | Action< ClanLordItemVM > | *onCharacterSelect*, |
|  |  | Action | *onRecall*, |
|  |  | Action | *onTalk* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a4fab8d1a65f169b7018dd53d820b9bd8)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a56ccc7f1eeb67ec8df2eb32736472b7f)ExecuteLocationLink()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.ExecuteLocationLink | ( | string | *link* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#aac1dd9f053f6c90c2f2b075931b91be3)UpdateProperties()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.UpdateProperties | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a59f0b9ef7761fe59e35511d467b9145e)ExecuteLink()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.ExecuteLink | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ae61feb8b71163b5322243a3ab14780c4)OnCharacterSelect()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.OnCharacterSelect | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a9fd182d3c840f986dbc7941ce57a14a1)ExecuteBeginHint()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.ExecuteBeginHint | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a6dab5c84e88dd986866a8cf6b54ee65a)ExecuteEndHint()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.ExecuteEndHint | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ac30a6bb190beac125cfc050e1f07e265)GetHero()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.GetHero | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a4f3736546c115f9c3a2f186e1aea17bc)ExecuteRename()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.ExecuteRename | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ac4159179706e90b644319acc45958a51)ExecuteShowOnMap()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.ExecuteShowOnMap | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ae2139af22113f6ee3ba26fe568b1e3e5)ExecuteRecall()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.ExecuteRecall | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a2412541a5c766192758b95eb3565a82d)ExecuteTalk()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.ExecuteTalk | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a4df9ca4c94b5b6b64e33056f664b3117)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#abf504a0462a6f97c751d70ba0589e0e4)Skills
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaSkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_skill_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.Skills | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a43db81faeaccb0d2fbba5f0f945ef95e)Traits
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaTraitItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_trait_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.Traits | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a8d4e97e392b99330a2c5d1493e0fba0d)HeroModel
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.HeroModel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a7d8bcb15acea48f4de95026034983b77)IsSelected
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ac6c88b6e47001a891ee258dc702e36fd)IsChild
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.IsChild | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a7af4b416804e0ff9ac1b06b6926d639c)IsTeleporting
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.IsTeleporting | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a31efd946419248ef1d3f38bd62e71bee)IsRecallVisible
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.IsRecallVisible | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#aa841f11b050b821d282ab095fd881db4)IsRecallEnabled
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.IsRecallEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a70dddccdca1ff9f19a4f2e7391c271db)IsTalkVisible
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.IsTalkVisible | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ab6ed05c534cab66e838bd9cf556b4b1c)IsTalkEnabled
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.IsTalkEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#abb47471aa9fdc55770c91845175eee77)CanShowLocationOfHero
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.CanShowLocationOfHero | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a41f1528ae4c7b720d9d8b459216853bc)IsMainHero
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.IsMainHero | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a55d04471ebdb818fa8ce47546a21dc61)IsFamilyMember
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.IsFamilyMember | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a7661023a5eba3bcfca247f805169eeba)IsPregnant
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.IsPregnant | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#ad5e252d1456f9efe4428179101fc8336)Visual
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.Visual | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a85c13e2d036ba5c15a28a59ec7505bd2)Banner\_9
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.Banner\_9 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a51213da421fefa28dadd85774278e426)LocationText
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.LocationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a5ed66b719d62dd13937126c17ec07f50)CurrentActionText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.CurrentActionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#abea786d5b1246b55bb5e5f13466b0afe)RelationToMainHeroText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.RelationToMainHeroText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a835a86c4c85a6786467f8cee9cd07e16)GovernorOfText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.GovernorOfText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a99581b6993774820321114fe32ae62b9)Name
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.Name | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a208bb25a891bb5a558a9b5fbc2b8302b)PregnantHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.PregnantHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#aa1f5d8572b3f4ff5de7fe2f07003a91d)ShowOnMapHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.ShowOnMapHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a6c9d3fa570500b656576dc8a75d0ff0e)RecallHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.RecallHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html#a21f6fbfe0ea81ad92659caaf2ae78791)TalkHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanLordItemVM.TalkHint | | getset |


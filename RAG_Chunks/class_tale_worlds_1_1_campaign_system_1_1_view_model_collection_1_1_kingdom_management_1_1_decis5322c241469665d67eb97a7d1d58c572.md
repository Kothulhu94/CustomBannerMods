--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.DecisionItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [KingSelectionDecisionItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#ae11c44a06523d9348624f14d1206a689) ([Election.KingSelectionKingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_king_selection_kingdom_decision.html) decision, Action onDecisionOver) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.DecisionItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html) | |
|  | [DecisionItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a3530d037c2c56eb2ae2d779e7b2ad840) ([Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision, Action onDecisionOver) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aae58f5c15fd8b421595c9a1c2e0b75f6) () |
|  | Used for updating localized texts. |
| void | [ExecuteFinalSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a37b5d469a4d2d0a02ccce79131bb0d98) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a3b4e60616a673d47307cef44aad26d42) () |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#ad952cc56ef22e08750ac227375a9d762) ([InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) inputKeyItemVM) |
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
| Protected Member Functions | |
| override void | [InitValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#afbf21debcf99915ecb375232834989a6) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.DecisionItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html) | |
| void | [ExecuteLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#ad7a4f8cac5ce895a8ab309ab5d192bb7) (string link) |
| void | [ExecuteShowStageTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a91ea972fc9e6113232c9f5b0614662f9) () |
| void | [ExecuteHideStageTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a9f761932d5c03d1507aa052f399fe79d) () |
| void | [ExecuteDone](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a2e02e3e951bebb1763c88af7c961cc2b) () |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Properties | |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [TargetFaction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a3cebfe36bbcd48d9b46c6ea1947f29df) `[get]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a629789eed774fb454daffa64dc1c5647) `[get, set]` |
| string | [FactionName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a6bf2ea22d8e0b891954695b833b73dab) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [FactionBanner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a482f477f1a3a846a3a09582179aa48f3) `[get, set]` |
| string | [SettlementsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#add5c1b00ac69ffc39e640dcca0da4e89) `[get, set]` |
| string | [SettlementsListText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a720a1bfd0070d4a2978f07fd50ab20f3) `[get, set]` |
| string | [CastlesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#aaa8cbab1e55a803941b5b0e452bebbf0) `[get, set]` |
| string | [CastlesListText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a20303d6331498273d2551fa89dbd16de) `[get, set]` |
| string | [TotalStrengthText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a1b209ec35222bf00090201091157b080) `[get, set]` |
| int | [TotalStrength](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a60ad50a94f06fe4c4457f399c3a40634) `[get, set]` |
| string | [ActivePoliciesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a1a52c040881dfc7a5a36a33c0bcc2850) `[get, set]` |
| string | [ActivePoliciesListText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a35b363ebfac991ef31a20b042e7ede7a) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.DecisionItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html) | |
| [KingdomElection](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_election.html) | [KingdomDecisionMaker](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a180f643269efdc1bddb7ccf7336f3789) `[get]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a614cc06e56035c0ce8c71b0b838a7fa6) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EndDecisionHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa2efeca0ef7a653821e50a13f3692f94) `[get, set]` |
| int | [DecisionType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#acf3e82b38041a69d620ca5b8a80bcbeb) `[get, set]` |
| string | [TotalInfluenceText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#af6739d2f7fa481b7cca413be354d530c) `[get, set]` |
| bool | [IsActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#ad0cb05fa73af3a28a552e39ba1814196) `[get, set]` |
| int | [CurrentStageIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a5078e91cddd5e2289e7dd7158fd253f9) `[get, set]` |
| bool | [IsPlayerSupporter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a4cae0652747cca565d1e689e35cae037) `[get, set]` |
| bool | [CanEndDecision](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#afde1a8c19fddcdef243b84c3b650c4fd) `[get, set]` |
| bool | [IsKingsDecisionOver](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a5b9a4231d745973a23aca0bd95fcb2c3) `[get, set]` |
| string | [RelationChangeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a52b723d5600fadd2988ff5b975c481c4) `[get, set]` |
| string | [DescriptionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a557d2729189e1faa974ee3a700c73b2c) `[get, set]` |
| string | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a282ebca82c38c061025a409ab43eae35) `[get, set]` |
| string | [DoneText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a8e6c61f17bd1961a5ec07155de901638) `[get, set]` |
| string | [InfluenceCostText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a2eea4262634484afe5b4a3eb3008f16e) `[get, set]` |
| MBBindingList< [DecisionOptionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisions_1_1_decision_option_v_m.html) > | [DecisionOptionsList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a7be49248e4b1e633aec77d070b6b8f2b) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Protected Types inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.DecisionItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html) | |
| enum | [DecisionTypes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa9cc92d1afa7f16ae1d37c0c5ab05e25) {     [Default](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa9cc92d1afa7f16ae1d37c0c5ab05e25a7a1920d61156abc05a60135aefe8bc67) = 0 ,     [Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa9cc92d1afa7f16ae1d37c0c5ab05e25a1610f44571feba48aa8a30a8112a06fe) ,     [ExpelClan](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa9cc92d1afa7f16ae1d37c0c5ab05e25a2625d43ce3b59456f71d6040d41832f9) ,     [Policy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa9cc92d1afa7f16ae1d37c0c5ab05e25a51359e8b51c63b87d50cb1bab73380e2) ,     [DeclareWar](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa9cc92d1afa7f16ae1d37c0c5ab05e25afe1ce9b0ff1767c84a94268dc6d294a9) ,     [MakePeace](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa9cc92d1afa7f16ae1d37c0c5ab05e25af21f529e62e4ea906156d189dbf35f1e) ,     [KingSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa9cc92d1afa7f16ae1d37c0c5ab05e25ac2eaec691b2cffcac28b23dde50cffb1) ,     [StartAlliance](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa9cc92d1afa7f16ae1d37c0c5ab05e25a7462e38fe294166bcd9b50f80e25583e) ,     [AcceptCallToWarAgreement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa9cc92d1afa7f16ae1d37c0c5ab05e25aaacaefc495400ab8ed899e42e396bd5b) ,     [ProposeCallToWarAgreement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa9cc92d1afa7f16ae1d37c0c5ab05e25addd006ddfc31e399df1a1881a3529829) ,     [Trade](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#aa9cc92d1afa7f16ae1d37c0c5ab05e25a5f390d80b20daad8f5d2f483fb0ae9d8)   } |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.DecisionItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html) | |
| readonly [Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | [\_decision](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#a2a2e9c91bbbb415b039e31d609441318) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#ae11c44a06523d9348624f14d1206a689)KingSelectionDecisionItemVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.KingSelectionDecisionItemVM | ( | [Election.KingSelectionKingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_king_selection_kingdom_decision.html) | *decision*, |
|  |  | Action | *onDecisionOver* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#afbf21debcf99915ecb375232834989a6)InitValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.InitValues | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.DecisionItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#afa3f5fde9b58dd36833e322431e0fe8f).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a3cebfe36bbcd48d9b46c6ea1947f29df)TargetFaction
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.TargetFaction | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a629789eed774fb454daffa64dc1c5647)NameText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a6bf2ea22d8e0b891954695b833b73dab)FactionName
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.FactionName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a482f477f1a3a846a3a09582179aa48f3)FactionBanner
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.FactionBanner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#add5c1b00ac69ffc39e640dcca0da4e89)SettlementsText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.SettlementsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a720a1bfd0070d4a2978f07fd50ab20f3)SettlementsListText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.SettlementsListText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#aaa8cbab1e55a803941b5b0e452bebbf0)CastlesText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.CastlesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a20303d6331498273d2551fa89dbd16de)CastlesListText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.CastlesListText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a1b209ec35222bf00090201091157b080)TotalStrengthText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.TotalStrengthText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a60ad50a94f06fe4c4457f399c3a40634)TotalStrength
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.TotalStrength | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a1a52c040881dfc7a5a36a33c0bcc2850)ActivePoliciesText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.ActivePoliciesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decis5322c241469665d67eb97a7d1d58c572.html#a35b363ebfac991ef31a20b042e7ede7a)ActivePoliciesListText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.KingSelectionDecisionItemVM.ActivePoliciesListText | | getset |


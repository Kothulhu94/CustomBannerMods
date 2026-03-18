--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.DecisionItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SettlementDecisionItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#ab7172510347004b1597b97748bfc48c9) ([CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision, Action onDecisionOver) |
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
| override void | [InitValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#ae9d4bfa1561b1d04d8d9aadef7df03de) () |
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
| [CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a29ba15c312048d34b494496784f6f26f) `[get]` |
| bool | [HasBoundSettlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a14ffb68384ba368e7269bf87cf6014a4) `[get, set]` |
| double | [SettlementCropPosition](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a9f9514d3f0ee54b27b96338eb38e2de5) `[get, set]` |
| string | [BoundSettlementText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a07c698faab56bf95a7f0b57bc5522c42) `[get, set]` |
| string | [DetailsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a49ac905502629bb7a79d8c0f88e0a538) `[get, set]` |
| string | [SettlementPath](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a9016b781ed1f36ffe0d94708daa03109) `[get, set]` |
| string | [SettlementName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a8982c16b4cc7b5328c531028140a77a2) `[get, set]` |
| string | [InformationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a6d4ca14aba15995105ec809961a14f61) `[get, set]` |
| [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a01b6a1bac80c6a8703ba5ff7885c4099) `[get, set]` |
| string | [VillagesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a5c5ac73d7a702f5262d86a3a33cc1fbc) `[get, set]` |
| string | [SettlementImageID](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a32989ca287de79f8330b391530a44ec6) `[get, set]` |
| string | [NotableCharactersText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a7c8acbbfee3040775ce1ca1c7ad5e070) `[get, set]` |
| MBBindingList< [EncyclopediaSettlementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_settlement_v_m.html) > | [BoundVillages](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a9abd8d75459948ca5e8d2faf08db7788) `[get, set]` |
| MBBindingList< [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) > | [NotableCharacters](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#ac154dde2dceecc3e94467fbdc62d3d3e) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [MilitasHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a3b6a99b59b0015eeebe92ac114e454de) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [FoodHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#af1a05430768d0a697c2c436431b1c96c) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [GarrisonHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#ad9c24b041472fe8c7d2cea78306b23ee) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [ProsperityHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#acb1cfbbf108ae72b081bb28df851c787) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [LoyaltyHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#aee0c06e8c2e41b2c64e46b29221ae592) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [SecurityHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a7ac7829be5e0e104e981ab10643f3295) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [WallsHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a0f40041275c3fcd137e3b03648a973d1) `[get, set]` |
| string | [MilitasText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#af085c10f860133863c8fb2f49c5c52e6) `[get, set]` |
| string | [ProsperityText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a25bc243027c2d677524264fcd6dae5a8) `[get, set]` |
| string | [LoyaltyText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a75d927b5c09555f4268670ba1cea2d39) `[get, set]` |
| string | [SecurityText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a67d7f41ccdf6c15864f1836c465203bb) `[get, set]` |
| string | [WallsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a81d6d86deb12690089ee5bbd6bba25ea) `[get, set]` |
| string | [FoodText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#afe03bcb4865f94aa3b364e25e2551ce7) `[get, set]` |
| string | [GarrisonText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#ae63fb120c9a6136d5096ea5e366c9c36) `[get, set]` |
| string | [DescriptorText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#aa2c3ce1bfada77bc1cd756a1e762a9cb) `[get, set]` |
| string | [OwnerText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#ac2dc40b7264b56390dcaea01fd249c31) `[get, set]` |
| [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) | [Governor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a0a75fec5a4230fbd11fdb7c13fb86387) `[get, set]` |
| bool | [HasNotables](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a20e5566e208e78f1e153ddb3a0c13cfd) `[get, set]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#ab7172510347004b1597b97748bfc48c9)SettlementDecisionItemVM()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.SettlementDecisionItemVM | ( | [CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision*, |
|  |  | Action | *onDecisionOver* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#ae9d4bfa1561b1d04d8d9aadef7df03de)InitValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.InitValues | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.DecisionItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisb9bcbeb4351811d78dbb42fde4da0f93.html#afa3f5fde9b58dd36833e322431e0fe8f).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a29ba15c312048d34b494496784f6f26f)Settlement
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.Settlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a14ffb68384ba368e7269bf87cf6014a4)HasBoundSettlement
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.HasBoundSettlement | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a9f9514d3f0ee54b27b96338eb38e2de5)SettlementCropPosition
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.SettlementCropPosition | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a07c698faab56bf95a7f0b57bc5522c42)BoundSettlementText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.BoundSettlementText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a49ac905502629bb7a79d8c0f88e0a538)DetailsText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.DetailsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a9016b781ed1f36ffe0d94708daa03109)SettlementPath
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.SettlementPath | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a8982c16b4cc7b5328c531028140a77a2)SettlementName
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.SettlementName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a6d4ca14aba15995105ec809961a14f61)InformationText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.InformationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a01b6a1bac80c6a8703ba5ff7885c4099)Owner
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.Owner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a5c5ac73d7a702f5262d86a3a33cc1fbc)VillagesText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.VillagesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a32989ca287de79f8330b391530a44ec6)SettlementImageID
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.SettlementImageID | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a7c8acbbfee3040775ce1ca1c7ad5e070)NotableCharactersText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.NotableCharactersText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a9abd8d75459948ca5e8d2faf08db7788)BoundVillages
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaSettlementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_settlement_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.BoundVillages | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#ac154dde2dceecc3e94467fbdc62d3d3e)NotableCharacters
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.NotableCharacters | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a3b6a99b59b0015eeebe92ac114e454de)MilitasHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.MilitasHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#af1a05430768d0a697c2c436431b1c96c)FoodHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.FoodHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#ad9c24b041472fe8c7d2cea78306b23ee)GarrisonHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.GarrisonHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#acb1cfbbf108ae72b081bb28df851c787)ProsperityHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.ProsperityHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#aee0c06e8c2e41b2c64e46b29221ae592)LoyaltyHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.LoyaltyHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a7ac7829be5e0e104e981ab10643f3295)SecurityHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.SecurityHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a0f40041275c3fcd137e3b03648a973d1)WallsHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.WallsHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#af085c10f860133863c8fb2f49c5c52e6)MilitasText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.MilitasText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a25bc243027c2d677524264fcd6dae5a8)ProsperityText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.ProsperityText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a75d927b5c09555f4268670ba1cea2d39)LoyaltyText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.LoyaltyText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a67d7f41ccdf6c15864f1836c465203bb)SecurityText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.SecurityText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a81d6d86deb12690089ee5bbd6bba25ea)WallsText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.WallsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#afe03bcb4865f94aa3b364e25e2551ce7)FoodText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.FoodText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#ae63fb120c9a6136d5096ea5e366c9c36)GarrisonText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.GarrisonText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#aa2c3ce1bfada77bc1cd756a1e762a9cb)DescriptorText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.DescriptorText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#ac2dc40b7264b56390dcaea01fd249c31)OwnerText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.OwnerText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a0a75fec5a4230fbd11fdb7c13fb86387)Governor
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.Governor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_decisfe5f16f6fca9919a63c644debf56ac5e.html#a20e5566e208e78f1e153ddb3a0c13cfd)HasNotables
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Decisions.ItemTypes.SettlementDecisionItemVM.HasNotables | | getset |


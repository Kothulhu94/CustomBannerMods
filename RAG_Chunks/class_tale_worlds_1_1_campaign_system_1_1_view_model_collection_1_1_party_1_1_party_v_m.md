--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PartyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a47d720a78ea1a51eb053bd4d084f93eb) ([PartyScreenLogic](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a7b18ef96f50d282e484a339218419901) partyScreenLogic) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a969816a2861e243bea1de33827f8c7db) () |
|  | Used for updating localized texts. |
| void | [SetSelectedCharacter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a36d1b7992fc0b983013d141d44202378) ([PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) troop) |
| void | [ExecuteSelectCharacterTuple](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a07e60c5c3e8f9ba59a3f8779cfd2c625) ([PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) troop) |
| void | [ExecuteClearSelectedCharacterTuple](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a72d18418ecc485cfc7ec52ea10c5be08) () |
| void | [ExecuteTransferWithParameters](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a707fc41e1ab129bb0bfd39f507b2bad0) ([PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) party, int index, string targetTag) |
| void | [OnUpgradePopUpClosed](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#abd45210dba36b6ca046bfc5f83e503bd) (bool isCancelled) |
| void | [OnRecruitPopUpClosed](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ade98a0066c03bcfb480c71ed01b50392) (bool isCancelled) |
| void | [ExecuteTransferAllMainTroops](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ad8869fa6e679ae442d373a381dfc6410) () |
| void | [ExecuteTransferAllOtherTroops](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a96a7852d7d08e837fe6a5941d55ba391) () |
| void | [ExecuteTransferAllMainPrisoners](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ab04ab16bc45292a26bf66e217e9e7c60) () |
| void | [ExecuteTransferAllOtherPrisoners](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a4bc8a1c8b623e286f51060ad6d4ae09c) () |
| void | [ExecuteOpenUpgradePopUp](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5940a3803b5968bb66b5d9fe19bd2b75) () |
| void | [ExecuteOpenRecruitPopUp](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ab459beb7bed72d9430941a2068090efd) () |
| void | [ExecuteUpgrade](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a222e1c68f8f592722adfb4dfe99230b0) ([PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) troop, int upgradeTargetType, int maxUpgradeCount) |
| void | [ExecuteRecruit](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aa5e24034f42a0946151870d26a7fff21) ([PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) character, bool recruitAll=false) |
| void | [ExecuteExecution](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#af9466255767a62b6b68cea13c347815a) () |
| void | [ExecuteRemoveZeroCounts](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a58017d02f9deeb80063da0c5e901d556) () |
| void | [ExecuteTalk](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a149ba648549b07f247c6a9ae4357480e) () |
| void | [ExecuteDone](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5e7c6854642c2cf121b7387c0788f368) () |
| void | [ExecuteReset](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a81b0d4cd2c58288b2db58d43a76b6ed0) () |
| void | [ExecuteResetAndCancel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a32bd167f8b3aa494eefa69ef357c5940) () |
| void | [ExecuteCancel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6724463f4d8b62ca206debdf4d1b089b) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aba46f2f940ae1cf465b9963faf41ac45) () |
| void | [SetResetInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a7489f550b86c17f6d82463c732ff0444) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
| void | [SetCancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a95b61926b3188240d3fffbde4143acbf) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a116c9f8fb5e155e13a064e8426bffb1d) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetTakeAllTroopsInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1576bf176de0a25d963a9449d98e5863) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDismissAllTroopsInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1ef32435b8ff66a5cc94d302f64b257d) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetTakeAllPrisonersInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a8caa40db3566ccbbbeea3100e915e4f1) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDismissAllPrisonersInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6fb3d75b7c31f1bb1b096cba123a06c1) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetOpenUpgradePanelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5eccc0d4a7fc7dbdb113dac2f0110c33) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetOpenRecruitPanelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a3411e77bb773dbc0405d82d4228006dd) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetGetKeyTextFromKeyIDFunc](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a7e5047e22f2463ceb32f2038196bb469) (Func< string, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > getKeyTextFromKeyId) |
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
| Public Attributes | |
| bool | [IsFiveStackModifierActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ad650e15bade94ccd84c80d143ef5cf1f) |
| bool | [IsEntireStackModifierActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6b810a1d4ce88dd705d6e8741f84368d) |
| bool | [IsInConversation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a810e6e9410db47c73993baa471ac9354) = false |

|  |  |
| --- | --- |
| Properties | |
| PartyScreenLogic | [PartyScreenLogic](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a7b18ef96f50d282e484a339218419901) `[get]` |
| bool | [CanRightPartyTakeMoreTroops](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#af9fdf6fa656f13dbb9aa2fe7d3691401) `[get]` |
| bool | [CanRightPartyTakeMorePrisoners](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a371e25c83a3ab4d0deca98980f7b327c) `[get]` |
| [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) | [CurrentCharacter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aa44b00825bbcb097b0fc8a1549776c2e) `[get, set]` |
| [PartySortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_sort_controller_v_m.html) | [OtherPartySortController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1f8f285d0d3446ed84e2e86a5babb4f4) `[get, set]` |
| [PartySortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_sort_controller_v_m.html) | [MainPartySortController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a17d25c2af861d61dfc1f9a7f21537ca7) `[get, set]` |
| [PartyCompositionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_composition_v_m.html) | [OtherPartyComposition](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#afd2e506458767a5f84b6053ccbb66756) `[get, set]` |
| [PartyCompositionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_composition_v_m.html) | [MainPartyComposition](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a481ae83eb374fe6e6cdc2505326034e5) `[get, set]` |
| [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) | [CurrentFocusedCharacter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a0f3946163a9f9163032c47b579ff87db) `[get, set]` |
| [UpgradeTargetVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html) | [CurrentFocusedUpgrade](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aa261072c2f16a932307219a830a67826) `[get, set]` |
| string | [HeaderLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5a3dec9d288fb4d6ee8d106bbaddb003) `[get, set]` |
| string | [OtherPartyNameLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a89245ef9de239a2f801e0d399a4dde6d) `[get, set]` |
| MBBindingList< [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) > | [OtherPartyTroops](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aedd85b1b4074120ec2341097a8f381e4) `[get, set]` |
| MBBindingList< [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) > | [OtherPartyPrisoners](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a51385589cb64d7a7e2d4dc1ac129066e) `[get, set]` |
| MBBindingList< [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) > | [MainPartyTroops](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a0bef054949bdd5a90d8212b9589283e0) `[get, set]` |
| MBBindingList< [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) > | [MainPartyPrisoners](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a08f9485e2ecac9d014dd6a0bad465dd7) `[get, set]` |
| [PartyUpgradeTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_troop_manage8d7b37e00987f9ea3cc26ccb86b0a365.html) | [UpgradePopUp](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a79bba2eb3dfd8fb49436c48521f962db) `[get, set]` |
| [PartyRecruitTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_troop_managec83b9611952724ce18a73ab1ab958366.html) | [RecruitPopUp](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#af0600a0f0e9f22820fc6f7b67d80bcbf) `[get, set]` |
| [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) | [SelectedCharacter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a71d6fc84d6158508262fe0f5801fa950) `[get, set]` |
| string | [CurrentCharacterLevelLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a853392f4ddc852535edb6e7d108b2c16) `[get, set]` |
| string | [CurrentCharacterWageLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a973e08d491fe9672311c1d841f5ae505) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [TransferAllOtherTroopsHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a96a4ab21361937dd57a73a22b54ad6c1) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [TransferAllOtherPrisonersHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a2315cbfc86de47ee4b80a52ec8e47442) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [TransferAllMainTroopsHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a763983371f8a2f217d3f4859f6a42d51) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [TransferAllMainPrisonersHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#af909c8de3ba9c6ec116f1f7a6528ae6e) `[get, set]` |
| [StringItemWithHintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_item_with_hint_v_m.html) | [CurrentCharacterTier](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a55e2a6119395ace4be8625d2389eecbe) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ResetHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a35bb8cd467ff7a7985e6dfc9fef44cda) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DoneHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ab145121bb3f29bb65294774235c4aa95) `[get, set]` |
| string | [OtherPartyAccompanyingLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aa0956eb11d4e12484f482a801a0291f4) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [MoraleHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a12cf2bc4178189d20590026cb496c368) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [TotalWageHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a26684afec99dca7345b47f425154cea8) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [SpeedHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a02e4496c8868e029e63b700c5b8f25bb) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [MainPartyTroopSizeLimitHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6e7521453db42760b67dd60cfb5d7ffa) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [MainPartyPrisonerSizeLimitHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aed6cad005d1ef7fa72dc13841c7d372a) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [OtherPartyTroopSizeLimitHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a945edb675a681d759b7fdcfea8084159) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [OtherPartyPrisonerSizeLimitHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ad6243c4818e4fc5303af39eb0ba0e47b) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [UsedHorsesHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a45f2ba2edcab42a668dc2d24f9175484) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DenarHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ac16d2773e0ebed09ff1ae3983a9f79ba) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [LevelHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5ebfe43742c7a53aa0c3441953909e97) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [WageHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a0603201243d003aa71d66011ee35a667) `[get, set]` |
| string | [TitleLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a2b7dd0cf1af729affbef0be32ec5a979) `[get, set]` |
| string | [MainPartyNameLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a75b7236845f0722de0086917648d2ba3) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [FormationHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a76d63ffbd7f6c96be6e71a49b7b87141) `[get, set]` |
| string | [TalkLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a57fe73c8d4d7f40b61ae94242c469be4) `[get, set]` |
| string | [InfoLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a22e431565ba31131da274eacfd3fb84d) `[get, set]` |
| string | [CancelLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ad854cda7d4f4aaf4246cfe853364f56e) `[get, set]` |
| string | [DoneLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a4265fd864f1f79dec947af2a62b7b1b1) `[get, set]` |
| string | [TroopsLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a4f28d85f0e927c9b2895303a0cc755eb) `[get, set]` |
| string | [PrisonersLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a06a211bd6b9ddca6b0bc19cd62479aab) `[get, set]` |
| string | [MainPartyTotalGoldLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a70229587421fee0fc119e7155697a073) `[get, set]` |
| string | [MainPartyTotalMoraleLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1d1fb70b2c4f14fef4980d94f9a77670) `[get, set]` |
| string | [MainPartyTotalSpeedLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a42f5af18160a3ba267e958338ec9bd1e) `[get, set]` |
| string | [MainPartyTotalWeeklyCostLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a973fc0619e4ee6173e5405f92d857a50) `[get, set]` |
| bool | [IsCurrentCharacterFormationEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a02c844409eda640c96cc4c1725414587) `[get, set]` |
| bool | [IsCurrentCharacterWageEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aad3db10d7b0f9ce0d5d96dac2d4b84aa) `[get, set]` |
| bool | [CanChooseRoles](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a18a403f2fd1cbd8bb42f003660d8bdc4) `[get, set]` |
| string | [OtherPartyTroopsLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a609075031249df1f705031a2a703df2a) `[get, set]` |
| string | [OtherPartyPrisonersLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a3b34d3dd6bebde092f38b58dab3b2db1) `[get, set]` |
| string | [MainPartyTroopsLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#adda7dc3b32754c767b7fc3d3513fbad8) `[get, set]` |
| string | [MainPartyPrisonersLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a34ad5f1af9652c4b3af508e33ec78658) `[get, set]` |
| bool | [ShowQuestProgress](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#af73d26e13ec2f35adf91f54feea9a269) `[get, set]` |
| int | [QuestProgressRequiredCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ab8ec2a5664aa82d580457c3172a0e271) `[get, set]` |
| int | [QuestProgressCurrentCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5765df81ad866a69353dfd14edc9f866) `[get, set]` |
| int | [UpgradableTroopCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1f6fd0a61972889fb0c6f34337620564) `[get, set]` |
| int | [RecruitableTroopCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a8319f2b0598c6d364ab749bf6df4162d) `[get, set]` |
| bool | [IsDoneDisabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a8353e783a4cfc4b9c672f2d9f10b1fad) `[get, set]` |
| bool | [IsUpgradePopUpDisabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a9ccf67ab73f1b77512fe70047d297ab3) `[get, set]` |
| bool | [IsRecruitPopUpDisabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a2c4759cb30da5382ef78eaf7a566fac7) `[get, set]` |
| bool | [IsMainPrisonersLimitWarningEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aeffa528459bc4524fd96c46f6670b2c4) `[get, set]` |
| bool | [IsMainTroopsLimitWarningEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6bce9b746884d05b5dacf98106df73d0) `[get, set]` |
| bool | [IsOtherPrisonersLimitWarningEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5c9acaca133244904c2ab4764cf219c8) `[get, set]` |
| bool | [IsUpgradePopupButtonHighlightEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6bf67850b32f8066df3a5b07e59d7eb2) `[get, set]` |
| bool | [IsOtherTroopsLimitWarningEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a19e1879bbcd560ed5e23a0537fd6377d) `[get, set]` |
| bool | [IsMainTroopsHaveTransferableTroops](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a338ca2f4044b6c95d850737206749aae) `[get, set]` |
| bool | [IsMainPrisonersHaveTransferableTroops](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a0ef47d6eac9d4f5ff08113eaf1c6f41a) `[get, set]` |
| bool | [IsOtherTroopsHaveTransferableTroops](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a2c1243498205e766cb0221665756e7d5) `[get, set]` |
| bool | [IsOtherPrisonersHaveTransferableTroops](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aa788331f6c2b9424071109cbed9fc46c) `[get, set]` |
| bool | [IsCancelDisabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ae7ebc8062b0b8e5fb2747198f427e22e) `[get, set]` |
| bool | [AreMembersRelevantOnCurrentMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a16e274826ac737c4a8d5e7354e0ffa3d) `[get, set]` |
| bool | [ArePrisonersRelevantOnCurrentMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a4431f3968b1c52fb162b5086065244b4) `[get, set]` |
| string | [GoldChangeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#abef820417335e27f74aad759c1c27422) `[get, set]` |
| string | [MoraleChangeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a405b598a843f28986c2089564d247d34) `[get, set]` |
| string | [HorseChangeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ac8014bdf5a34ba3b839e6537babc7d24) `[get, set]` |
| string | [InfluenceChangeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1e93243b6c5e16602010e6b2fa196c56) `[get, set]` |
| bool | [IsAnyPopUpOpen](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a0734ae6b96a482f9554702860dcf3e0b) `[get, set]` |
| bool | [ScrollToCharacter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1f2579cb3e4dbac3ce57c01429e3ab18) `[get, set]` |
| bool | [IsScrollTargetPrisoner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a8579239cf7ee410f7aca7981d3c33ca0) `[get, set]` |
| string | [ScrollCharacterId](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ac4e470a48ac5eb7192bcc55449071672) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ResetInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6671400ab3e7f118c006546a585b6743) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a57a4b772df5567e05a174b9e0b6dc3fd) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a25c6e31a5a8d470ea17d3c89b2f99ab9) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [TakeAllTroopsInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a0989f3dd43e06d85f57948c08bab80b5) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DismissAllTroopsInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ab9fc40feb8fbeb374aee0f24cd30fc8f) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [TakeAllPrisonersInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ae02506b743d2836f1a75697365426cb1) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DismissAllPrisonersInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a431dc9cb4fdc38689903391d5df3eefc) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [OpenUpgradePanelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6f6194546694b9cb00a8beed93074f4f) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [OpenRecruitPanelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a24fa794829fdaff1bdbac5b963597bac) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a47d720a78ea1a51eb053bd4d084f93eb)PartyVM()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.PartyVM | ( | [PartyScreenLogic](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a7b18ef96f50d282e484a339218419901) | *partyScreenLogic* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a969816a2861e243bea1de33827f8c7db)RefreshValues()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a36d1b7992fc0b983013d141d44202378)SetSelectedCharacter()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SetSelectedCharacter | ( | [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) | *troop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a07e60c5c3e8f9ba59a3f8779cfd2c625)ExecuteSelectCharacterTuple()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteSelectCharacterTuple | ( | [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) | *troop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a72d18418ecc485cfc7ec52ea10c5be08)ExecuteClearSelectedCharacterTuple()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteClearSelectedCharacterTuple | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a707fc41e1ab129bb0bfd39f507b2bad0)ExecuteTransferWithParameters()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteTransferWithParameters | ( | [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) | *party*, |
|  |  | int | *index*, |
|  |  | string | *targetTag* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#abd45210dba36b6ca046bfc5f83e503bd)OnUpgradePopUpClosed()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OnUpgradePopUpClosed | ( | bool | *isCancelled* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ade98a0066c03bcfb480c71ed01b50392)OnRecruitPopUpClosed()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OnRecruitPopUpClosed | ( | bool | *isCancelled* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ad8869fa6e679ae442d373a381dfc6410)ExecuteTransferAllMainTroops()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteTransferAllMainTroops | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a96a7852d7d08e837fe6a5941d55ba391)ExecuteTransferAllOtherTroops()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteTransferAllOtherTroops | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ab04ab16bc45292a26bf66e217e9e7c60)ExecuteTransferAllMainPrisoners()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteTransferAllMainPrisoners | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a4bc8a1c8b623e286f51060ad6d4ae09c)ExecuteTransferAllOtherPrisoners()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteTransferAllOtherPrisoners | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5940a3803b5968bb66b5d9fe19bd2b75)ExecuteOpenUpgradePopUp()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteOpenUpgradePopUp | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ab459beb7bed72d9430941a2068090efd)ExecuteOpenRecruitPopUp()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteOpenRecruitPopUp | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a222e1c68f8f592722adfb4dfe99230b0)ExecuteUpgrade()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteUpgrade | ( | [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) | *troop*, |
|  |  | int | *upgradeTargetType*, |
|  |  | int | *maxUpgradeCount* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aa5e24034f42a0946151870d26a7fff21)ExecuteRecruit()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteRecruit | ( | [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) | *character*, |
|  |  | bool | *recruitAll* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#af9466255767a62b6b68cea13c347815a)ExecuteExecution()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteExecution | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a58017d02f9deeb80063da0c5e901d556)ExecuteRemoveZeroCounts()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteRemoveZeroCounts | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a149ba648549b07f247c6a9ae4357480e)ExecuteTalk()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteTalk | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5e7c6854642c2cf121b7387c0788f368)ExecuteDone()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteDone | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a81b0d4cd2c58288b2db58d43a76b6ed0)ExecuteReset()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteReset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a32bd167f8b3aa494eefa69ef357c5940)ExecuteResetAndCancel()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteResetAndCancel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6724463f4d8b62ca206debdf4d1b089b)ExecuteCancel()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ExecuteCancel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aba46f2f940ae1cf465b9963faf41ac45)OnFinalize()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a7489f550b86c17f6d82463c732ff0444)SetResetInputKey()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SetResetInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a95b61926b3188240d3fffbde4143acbf)SetCancelInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a116c9f8fb5e155e13a064e8426bffb1d)SetDoneInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1576bf176de0a25d963a9449d98e5863)SetTakeAllTroopsInputKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SetTakeAllTroopsInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1ef32435b8ff66a5cc94d302f64b257d)SetDismissAllTroopsInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SetDismissAllTroopsInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a8caa40db3566ccbbbeea3100e915e4f1)SetTakeAllPrisonersInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SetTakeAllPrisonersInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6fb3d75b7c31f1bb1b096cba123a06c1)SetDismissAllPrisonersInputKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SetDismissAllPrisonersInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5eccc0d4a7fc7dbdb113dac2f0110c33)SetOpenUpgradePanelInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SetOpenUpgradePanelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a3411e77bb773dbc0405d82d4228006dd)SetOpenRecruitPanelInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SetOpenRecruitPanelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a7e5047e22f2463ceb32f2038196bb469)SetGetKeyTextFromKeyIDFunc()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SetGetKeyTextFromKeyIDFunc | ( | Func< string, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *getKeyTextFromKeyId* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ad650e15bade94ccd84c80d143ef5cf1f)IsFiveStackModifierActive
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsFiveStackModifierActive |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6b810a1d4ce88dd705d6e8741f84368d)IsEntireStackModifierActive
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsEntireStackModifierActive |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a810e6e9410db47c73993baa471ac9354)IsInConversation
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsInConversation = false |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a7b18ef96f50d282e484a339218419901)PartyScreenLogic
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | PartyScreenLogic TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.PartyScreenLogic | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#af9fdf6fa656f13dbb9aa2fe7d3691401)CanRightPartyTakeMoreTroops
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.CanRightPartyTakeMoreTroops | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a371e25c83a3ab4d0deca98980f7b327c)CanRightPartyTakeMorePrisoners
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.CanRightPartyTakeMorePrisoners | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aa44b00825bbcb097b0fc8a1549776c2e)CurrentCharacter
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.CurrentCharacter | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1f8f285d0d3446ed84e2e86a5babb4f4)OtherPartySortController
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartySortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_sort_controller_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OtherPartySortController | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a17d25c2af861d61dfc1f9a7f21537ca7)MainPartySortController
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartySortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_sort_controller_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartySortController | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#afd2e506458767a5f84b6053ccbb66756)OtherPartyComposition
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyCompositionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_composition_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OtherPartyComposition | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a481ae83eb374fe6e6cdc2505326034e5)MainPartyComposition
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyCompositionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_composition_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartyComposition | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a0f3946163a9f9163032c47b579ff87db)CurrentFocusedCharacter
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.CurrentFocusedCharacter | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aa261072c2f16a932307219a830a67826)CurrentFocusedUpgrade
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UpgradeTargetVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_upgrade_target_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.CurrentFocusedUpgrade | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5a3dec9d288fb4d6ee8d106bbaddb003)HeaderLbl
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.HeaderLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a89245ef9de239a2f801e0d399a4dde6d)OtherPartyNameLbl
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OtherPartyNameLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aedd85b1b4074120ec2341097a8f381e4)OtherPartyTroops
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OtherPartyTroops | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a51385589cb64d7a7e2d4dc1ac129066e)OtherPartyPrisoners
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OtherPartyPrisoners | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a0bef054949bdd5a90d8212b9589283e0)MainPartyTroops
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartyTroops | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a08f9485e2ecac9d014dd6a0bad465dd7)MainPartyPrisoners
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[PartyCharacterVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_character_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartyPrisoners | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a79bba2eb3dfd8fb49436c48521f962db)UpgradePopUp
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyUpgradeTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_troop_manage8d7b37e00987f9ea3cc26ccb86b0a365.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.UpgradePopUp | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#af0600a0f0e9f22820fc6f7b67d80bcbf)RecruitPopUp
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyRecruitTroopVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_troop_managec83b9611952724ce18a73ab1ab958366.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.RecruitPopUp | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a71d6fc84d6158508262fe0f5801fa950)SelectedCharacter
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SelectedCharacter | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a853392f4ddc852535edb6e7d108b2c16)CurrentCharacterLevelLbl
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.CurrentCharacterLevelLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a973e08d491fe9672311c1d841f5ae505)CurrentCharacterWageLbl
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.CurrentCharacterWageLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a96a4ab21361937dd57a73a22b54ad6c1)TransferAllOtherTroopsHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.TransferAllOtherTroopsHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a2315cbfc86de47ee4b80a52ec8e47442)TransferAllOtherPrisonersHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.TransferAllOtherPrisonersHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a763983371f8a2f217d3f4859f6a42d51)TransferAllMainTroopsHint
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.TransferAllMainTroopsHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#af909c8de3ba9c6ec116f1f7a6528ae6e)TransferAllMainPrisonersHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.TransferAllMainPrisonersHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a55e2a6119395ace4be8625d2389eecbe)CurrentCharacterTier
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [StringItemWithHintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_item_with_hint_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.CurrentCharacterTier | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a35bb8cd467ff7a7985e6dfc9fef44cda)ResetHint
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ResetHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ab145121bb3f29bb65294774235c4aa95)DoneHint
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.DoneHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aa0956eb11d4e12484f482a801a0291f4)OtherPartyAccompanyingLbl
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OtherPartyAccompanyingLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a12cf2bc4178189d20590026cb496c368)MoraleHint
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MoraleHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a26684afec99dca7345b47f425154cea8)TotalWageHint
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.TotalWageHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a02e4496c8868e029e63b700c5b8f25bb)SpeedHint
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.SpeedHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6e7521453db42760b67dd60cfb5d7ffa)MainPartyTroopSizeLimitHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartyTroopSizeLimitHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aed6cad005d1ef7fa72dc13841c7d372a)MainPartyPrisonerSizeLimitHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartyPrisonerSizeLimitHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a945edb675a681d759b7fdcfea8084159)OtherPartyTroopSizeLimitHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OtherPartyTroopSizeLimitHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ad6243c4818e4fc5303af39eb0ba0e47b)OtherPartyPrisonerSizeLimitHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OtherPartyPrisonerSizeLimitHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a45f2ba2edcab42a668dc2d24f9175484)UsedHorsesHint
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.UsedHorsesHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ac16d2773e0ebed09ff1ae3983a9f79ba)DenarHint
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.DenarHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5ebfe43742c7a53aa0c3441953909e97)LevelHint
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.LevelHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a0603201243d003aa71d66011ee35a667)WageHint
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.WageHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a2b7dd0cf1af729affbef0be32ec5a979)TitleLbl
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.TitleLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a75b7236845f0722de0086917648d2ba3)MainPartyNameLbl
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartyNameLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a76d63ffbd7f6c96be6e71a49b7b87141)FormationHint
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.FormationHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a57fe73c8d4d7f40b61ae94242c469be4)TalkLbl
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.TalkLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a22e431565ba31131da274eacfd3fb84d)InfoLbl
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.InfoLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ad854cda7d4f4aaf4246cfe853364f56e)CancelLbl
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.CancelLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a4265fd864f1f79dec947af2a62b7b1b1)DoneLbl
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.DoneLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a4f28d85f0e927c9b2895303a0cc755eb)TroopsLabel
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.TroopsLabel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a06a211bd6b9ddca6b0bc19cd62479aab)PrisonersLabel
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.PrisonersLabel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a70229587421fee0fc119e7155697a073)MainPartyTotalGoldLbl
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartyTotalGoldLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1d1fb70b2c4f14fef4980d94f9a77670)MainPartyTotalMoraleLbl
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartyTotalMoraleLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a42f5af18160a3ba267e958338ec9bd1e)MainPartyTotalSpeedLbl
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartyTotalSpeedLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a973fc0619e4ee6173e5405f92d857a50)MainPartyTotalWeeklyCostLbl
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartyTotalWeeklyCostLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a02c844409eda640c96cc4c1725414587)IsCurrentCharacterFormationEnabled
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsCurrentCharacterFormationEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aad3db10d7b0f9ce0d5d96dac2d4b84aa)IsCurrentCharacterWageEnabled
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsCurrentCharacterWageEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a18a403f2fd1cbd8bb42f003660d8bdc4)CanChooseRoles
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.CanChooseRoles | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a609075031249df1f705031a2a703df2a)OtherPartyTroopsLbl
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OtherPartyTroopsLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a3b34d3dd6bebde092f38b58dab3b2db1)OtherPartyPrisonersLbl
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OtherPartyPrisonersLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#adda7dc3b32754c767b7fc3d3513fbad8)MainPartyTroopsLbl
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartyTroopsLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a34ad5f1af9652c4b3af508e33ec78658)MainPartyPrisonersLbl
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MainPartyPrisonersLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#af73d26e13ec2f35adf91f54feea9a269)ShowQuestProgress
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ShowQuestProgress | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ab8ec2a5664aa82d580457c3172a0e271)QuestProgressRequiredCount
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.QuestProgressRequiredCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5765df81ad866a69353dfd14edc9f866)QuestProgressCurrentCount
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.QuestProgressCurrentCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1f6fd0a61972889fb0c6f34337620564)UpgradableTroopCount
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.UpgradableTroopCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a8319f2b0598c6d364ab749bf6df4162d)RecruitableTroopCount
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.RecruitableTroopCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a8353e783a4cfc4b9c672f2d9f10b1fad)IsDoneDisabled
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsDoneDisabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a9ccf67ab73f1b77512fe70047d297ab3)IsUpgradePopUpDisabled
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsUpgradePopUpDisabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a2c4759cb30da5382ef78eaf7a566fac7)IsRecruitPopUpDisabled
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsRecruitPopUpDisabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aeffa528459bc4524fd96c46f6670b2c4)IsMainPrisonersLimitWarningEnabled
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsMainPrisonersLimitWarningEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6bce9b746884d05b5dacf98106df73d0)IsMainTroopsLimitWarningEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsMainTroopsLimitWarningEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a5c9acaca133244904c2ab4764cf219c8)IsOtherPrisonersLimitWarningEnabled
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsOtherPrisonersLimitWarningEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6bf67850b32f8066df3a5b07e59d7eb2)IsUpgradePopupButtonHighlightEnabled
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsUpgradePopupButtonHighlightEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a19e1879bbcd560ed5e23a0537fd6377d)IsOtherTroopsLimitWarningEnabled
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsOtherTroopsLimitWarningEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a338ca2f4044b6c95d850737206749aae)IsMainTroopsHaveTransferableTroops
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsMainTroopsHaveTransferableTroops | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a0ef47d6eac9d4f5ff08113eaf1c6f41a)IsMainPrisonersHaveTransferableTroops
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsMainPrisonersHaveTransferableTroops | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a2c1243498205e766cb0221665756e7d5)IsOtherTroopsHaveTransferableTroops
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsOtherTroopsHaveTransferableTroops | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#aa788331f6c2b9424071109cbed9fc46c)IsOtherPrisonersHaveTransferableTroops
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsOtherPrisonersHaveTransferableTroops | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ae7ebc8062b0b8e5fb2747198f427e22e)IsCancelDisabled
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsCancelDisabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a16e274826ac737c4a8d5e7354e0ffa3d)AreMembersRelevantOnCurrentMode
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.AreMembersRelevantOnCurrentMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a4431f3968b1c52fb162b5086065244b4)ArePrisonersRelevantOnCurrentMode
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ArePrisonersRelevantOnCurrentMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#abef820417335e27f74aad759c1c27422)GoldChangeText
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.GoldChangeText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a405b598a843f28986c2089564d247d34)MoraleChangeText
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.MoraleChangeText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ac8014bdf5a34ba3b839e6537babc7d24)HorseChangeText
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.HorseChangeText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1e93243b6c5e16602010e6b2fa196c56)InfluenceChangeText
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.InfluenceChangeText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a0734ae6b96a482f9554702860dcf3e0b)IsAnyPopUpOpen
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsAnyPopUpOpen | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a1f2579cb3e4dbac3ce57c01429e3ab18)ScrollToCharacter
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ScrollToCharacter | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a8579239cf7ee410f7aca7981d3c33ca0)IsScrollTargetPrisoner
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.IsScrollTargetPrisoner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ac4e470a48ac5eb7192bcc55449071672)ScrollCharacterId
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ScrollCharacterId | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6671400ab3e7f118c006546a585b6743)ResetInputKey
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.ResetInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a57a4b772df5567e05a174b9e0b6dc3fd)CancelInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a25c6e31a5a8d470ea17d3c89b2f99ab9)DoneInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a0989f3dd43e06d85f57948c08bab80b5)TakeAllTroopsInputKey
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.TakeAllTroopsInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ab9fc40feb8fbeb374aee0f24cd30fc8f)DismissAllTroopsInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.DismissAllTroopsInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#ae02506b743d2836f1a75697365426cb1)TakeAllPrisonersInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.TakeAllPrisonersInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a431dc9cb4fdc38689903391d5df3eefc)DismissAllPrisonersInputKey
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.DismissAllPrisonersInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a6f6194546694b9cb00a8beed93074f4f)OpenUpgradePanelInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OpenUpgradePanelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_party_1_1_party_v_m.html#a24fa794829fdaff1bdbac5b963597bac)OpenRecruitPanelInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Party.PartyVM.OpenRecruitPanelInputKey | | getset |


--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html ---

SandBox.ViewModelCollection.Nameplate.PartyNameplateVM Class ReferenceInherits [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html).

Inherited by [SandBox.ViewModelCollection.Nameplate.PartyPlayerNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_player_nameplate_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PartyNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a20afc2f6dcc6256436e20cc29051d71e) () |
| void | [InitializeWith](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#af593877b884a6c896e2428044ecfa7a6) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) mapCamera) |
| virtual void | [Clear](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#afab04953516f561a5a0a80d76d06cccc) () |
| override void | [RefreshValues](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a07180b7e81cb1de1ab4b915f3f103bc2) () |
|  | Used for updating localized texts. |
| void | [RegisterEvents](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a68c94050f1ae20b1428e0ff23c804dc5) () |
| void | [UnregisterEvents](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ab9f9c3594fbe052eaa85cac983fc65d6) () |
| override void | [RefreshDynamicProperties](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a349c6667c2a065521176e6158087af65) (bool forceUpdate) |
| override void | [RefreshPosition](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aaa9a34a28364c3c933c90abb98c4a6ca) () |
| override void | [RefreshTutorialStatus](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ab26cf13dea711dd40221cbd8784fb8cf) (string newTutorialHighlightElementID) |
| void | [DetermineIsVisibleOnMap](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a901c552d306b444128168ab232294399) () |
| virtual void | [RefreshBinding](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#abebc76c60df6af984e6fc3ffb3fe395b) () |
| Public Member Functions inherited from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html) | |
|  | [NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a555aed693caf5a959be646f772d860b1) () |
| virtual void | [RefreshRelationStatus](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a5196fa11609dd40be7f0358de69498ee) () |
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
| Static Public Attributes | |
| static string | [PositiveIndicator](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aadb23e0315fe257011d82d0afa64b4bc) = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFF71D644).ToString() |
| static string | [PositiveArmyIndicator](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a1b27dc06811ab60d54055920090a3043) = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFFa1f77b).ToString() |
| static string | [NegativeIndicator](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a5b1dcd524df5eda1602bceaa54087d4d) = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0xFFD64646).ToString() |
| static string | [NegativeArmyIndicator](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a59277a2574af2b7587d14e6e08da583e) = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFFFF7575).ToString() |
| static string | [NeutralIndicator](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a6351e06e072b9497e64766d9dfb5d27f) = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFFD0D8E8).ToString() |
| static string | [NeutralArmyIndicator](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a9a890be7b74f79a70b95a9121332e23d) = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFFF9FBFF).ToString() |
| static string | [MainPartyIndicator](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a441a241c0c2b6163ca04983678183765) = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFF8CDBC4).ToString() |
| static string | [MainPartyArmyIndicator](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a6e8d2bab07d66aeb31fcbbc5543cd596) = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFFADFFE5).ToString() |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |

|  |  |
| --- | --- |
| Protected Attributes | |
| float | [\_latestX](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a3394380f06166064224a5d5d41083706) |
| float | [\_latestY](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a32c0f79b14ee19fef5859a51e6dc86c0) |
| float | [\_latestW](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a7dc4b058e096e87577cb0e8476c14bd1) |
| float | [\_cachedSpeed](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ab984d63dcec1a2d23e688e75d378fff1) |
| [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | [\_mapCamera](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a69e808198c7e2d9d4b3b57d3cd7e1c55) |
| int | [\_latestPrisonerAmount](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a309dcf0e12f8c95ee6a7a087a782f5ac) = -1 |
| int | [\_latestWoundedAmount](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#af0e233f8d23ab00886cea7b5f69ad668) = -1 |
| int | [\_latestTotalCount](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aef03da7d4ffa035d1f9835dc29a822d1) = -1 |
| bool | [\_isPartyBannerDirty](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ac2788a5b46b077414ea59b032c69df98) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [\_latestNameTextObject](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a8722fb12be6d4fdaff69d84d654867db) |
| CampaignUIHelper.IssueQuestFlags | [\_previousQuestsBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ac3633aa9ff8d1000f41c78d2c2ffad9c) |
| CampaignUIHelper.IssueQuestFlags | [\_questsBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a723bcd53c3684f9af5cf5c0ea1f890a7) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [\_partyPositionBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a8d80425dc4fbad22b246b9c2ba4f86f8) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [\_headPositionBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a1591da621b290f81861d06aacee84a63) |
| bool | [\_isHighBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a34e7e2ae052bdfc839b4c7181db3cc84) |
| bool | [\_isBehindBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ab6c7c876df697e1e2717ad61b3a692ae) |
| bool | [\_isInArmyBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ae05a2779b4626d0108b586608533ede7) |
| bool | [\_isInSettlementBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a79082d687155968229785b05c06348e3) |
| bool | [\_isVisibleOnMapBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a4d1aae9fd8aeea03bb4c54bde84cb3bc) |
| bool | [\_isArmyBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ab3ec93c0633aeaf64d674bdb58256ff1) |
| bool | [\_isDisorganizedBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a83905ef5be42529c678892e13944e861) |
| bool | [\_isCurrentlyAtSeaBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a412006f350f93789c410d90fd8294055) |
| string | [\_factionColorBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a3fbe3d351ff123bddf490fcf6043877f) |
| string | [\_countBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ad1cdb92c83f377e3f7f4a13b0689b309) |
| string | [\_woundedBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a1f00d5089d427038ba4725e69bb4b1c7) |
| string | [\_prisonerBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a989912dd07625235e2d7c842af3294d8) |
| string | [\_extraInfoTextBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aca4c2fdbc1cd19d65b6443eba8c88438) |
| string | [\_fullNameBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aa1008e317d9ba04807250054b03cc975) |
| string | [\_movementSpeedTextBind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#abcd666d1e5d546aeaf9f3b4eee5140f7) |
| Protected Attributes inherited from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html) | |
| bool | [\_bindIsTargetedByTutorial](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a2a5d76eadfcef4d4c8fe4a87442a4368) |

|  |  |
| --- | --- |
| Properties | |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [Party](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a2e21ddd75c7b0bdd3a5bd95956b57e60) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [HeadPosition](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aad00666149aa3c268ddd5d3aa46f9e87) `[get, set]` |
| string | [Count](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a9b0788804fa51a2f75105c0f86503520) `[get, set]` |
| string | [Prisoner](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a6b1f4237fc4c53ecff580056e8f94484) `[get, set]` |
| MBBindingList< [QuestMarkerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_marker_v_m.html) > | [Quests](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ad6edd6fe489e4b3b444ad1bb75f5183c) `[get, set]` |
| string | [Wounded](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aa56508011d7f700748aa28134b6f6800) `[get, set]` |
| string | [ExtraInfoText](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aff6fa1cf31a202aff825a133e9e097dc) `[get, set]` |
| string | [MovementSpeedText](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ac54524cf428ae90d0b489bf67d731c54) `[get, set]` |
| string | [FullName](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a761e1d0ad9070fbdb9b42370b646e337) `[get, set]` |
| bool | [IsInArmy](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a62e9cd196367033eb356863bf9232bd9) `[get, set]` |
| bool | [IsInSettlement](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a7567ae58804325e8b55231e400adae1b) `[get, set]` |
| bool | [IsDisorganized](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aa39311d42e1156b8366a30d1e79c7be2) `[get, set]` |
| bool | [IsCurrentlyAtSea](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a2e42f1ce5377844f545c991bc42fe316) `[get, set]` |
| bool | [IsArmy](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aae67bec4348fdb6ec9677b3485f3db88) `[get, set]` |
| bool | [IsBehind](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a5981a3c0bc7ccc286bc81d725a2d8ee9) `[get, set]` |
| bool | [IsHigh](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a17a1ba9c566000c91d76cc5f151a461c) `[get, set]` |
| bool | [ShouldShowFullName](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a674fcec24d818b63b06dc0e88d370519) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [PartyBanner](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a4cf458108bf601e241452de030bf02c4) `[get, set]` |
| Properties inherited from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html) | |
| double | [Scale](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a5d3dc2225dd7b164c5c5e2df769c239f) `[get, set]` |
| int | [NameplateOrder](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#ad54345e32e89e14af5fa5fbf429496ee) `[get, set]` |
| string | [FactionColor](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#accaefa9664bfd1218bdbb48cfd904b80) `[get, set]` |
| float | [DistanceToCamera](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a52779c8f617c46333429959a24017ba3) `[get, set]` |
| bool | [IsVisibleOnMap](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#abcda4f4f0b3b5c57d3aff2df3247b501) `[get, set]` |
| bool | [IsTargetedByTutorial](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a5bdf373585f449704cc3835ca1c4a915) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Position](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#af3d7e1f26eda35561c09398af08e1dec) `[get, set]` |
| bool | [CanParley](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#af176d6782bf1eac58f369e9fa91a67a7) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Protected Types inherited from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html) | |
| enum | [NameplateSize](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851) {     [Small](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851a2660064e68655415da2628c2ae2f7592) = 0 ,     [Normal](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851a960b44c579bc2f6818d2daaf9e4c16f0) ,     [Big](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851ad491538da818a2ba11a3195ba035cfd3)   } |
| Protected Member Functions inherited from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html) | |
| void | [OnTutorialNotificationElementChanged](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a89978d373bd37016107518fcd6ccc7ed) ([TutorialNotificationElementChangeEvent](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_notification_element_change_event.html) obj) |
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

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a20afc2f6dcc6256436e20cc29051d71e)PartyNameplateVM()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.PartyNameplateVM | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#af593877b884a6c896e2428044ecfa7a6)InitializeWith()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.InitializeWith | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *mapCamera* ) |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#afab04953516f561a5a0a80d76d06cccc)Clear()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.Clear | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.ViewModelCollection.Nameplate.PartyPlayerNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_player_nameplate_v_m.html#a2960fd374b8c1e193f3188f3dee0c04d).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a07180b7e81cb1de1ab4b915f3f103bc2)RefreshValues()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a68c94050f1ae20b1428e0ff23c804dc5)RegisterEvents()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.RegisterEvents | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ab9f9c3594fbe052eaa85cac983fc65d6)UnregisterEvents()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.UnregisterEvents | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a349c6667c2a065521176e6158087af65)RefreshDynamicProperties()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.RefreshDynamicProperties | ( | bool | *forceUpdate* | ) |  | | virtual |

Reimplemented from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a847688a81bfee28ed3f2d6717b162458).

Reimplemented in [SandBox.ViewModelCollection.Nameplate.PartyPlayerNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_player_nameplate_v_m.html#ae00b0231b5728b31750ee397e53051c9).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aaa9a34a28364c3c933c90abb98c4a6ca)RefreshPosition()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.RefreshPosition | ( |  | ) |  | | virtual |

Reimplemented from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a92ea64508163ebed07cdddea2fe8aed6).

Reimplemented in [SandBox.ViewModelCollection.Nameplate.PartyPlayerNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_player_nameplate_v_m.html#ad0f8861ae9a8921a479dd68835e5e499).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ab26cf13dea711dd40221cbd8784fb8cf)RefreshTutorialStatus()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.RefreshTutorialStatus | ( | string | *newTutorialHighlightElementID* | ) |  | | virtual |

Reimplemented from [SandBox.ViewModelCollection.Nameplate.NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a15f901a0f8e2736045932aaf23cf0919).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a901c552d306b444128168ab232294399)DetermineIsVisibleOnMap()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.DetermineIsVisibleOnMap | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#abebc76c60df6af984e6fc3ffb3fe395b)RefreshBinding()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.RefreshBinding | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.ViewModelCollection.Nameplate.PartyPlayerNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_player_nameplate_v_m.html#a4278d62d22bcaa7ea0336a824a3edd81).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aadb23e0315fe257011d82d0afa64b4bc)PositiveIndicator
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.PositiveIndicator = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFF71D644).ToString() | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a1b27dc06811ab60d54055920090a3043)PositiveArmyIndicator
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.PositiveArmyIndicator = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFFa1f77b).ToString() | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a5b1dcd524df5eda1602bceaa54087d4d)NegativeIndicator
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.NegativeIndicator = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0xFFD64646).ToString() | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a59277a2574af2b7587d14e6e08da583e)NegativeArmyIndicator
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.NegativeArmyIndicator = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFFFF7575).ToString() | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a6351e06e072b9497e64766d9dfb5d27f)NeutralIndicator
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.NeutralIndicator = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFFD0D8E8).ToString() | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a9a890be7b74f79a70b95a9121332e23d)NeutralArmyIndicator
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.NeutralArmyIndicator = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFFF9FBFF).ToString() | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a441a241c0c2b6163ca04983678183765)MainPartyIndicator
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.MainPartyIndicator = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFF8CDBC4).ToString() | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a6e8d2bab07d66aeb31fcbbc5543cd596)MainPartyArmyIndicator
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.MainPartyArmyIndicator = [Color.FromUint](struct_tale_worlds_1_1_library_1_1_color.html#a45c82cfd68fd9fc3e6da10dd069782c5)(0XFFADFFE5).ToString() | | static |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a3394380f06166064224a5d5d41083706)\_latestX
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_latestX | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a32c0f79b14ee19fef5859a51e6dc86c0)\_latestY
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_latestY | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a7dc4b058e096e87577cb0e8476c14bd1)\_latestW
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_latestW | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ab984d63dcec1a2d23e688e75d378fff1)\_cachedSpeed
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_cachedSpeed | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a69e808198c7e2d9d4b3b57d3cd7e1c55)\_mapCamera
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_mapCamera | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a309dcf0e12f8c95ee6a7a087a782f5ac)\_latestPrisonerAmount
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_latestPrisonerAmount = -1 | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#af0e233f8d23ab00886cea7b5f69ad668)\_latestWoundedAmount
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_latestWoundedAmount = -1 | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aef03da7d4ffa035d1f9835dc29a822d1)\_latestTotalCount
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_latestTotalCount = -1 | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ac2788a5b46b077414ea59b032c69df98)\_isPartyBannerDirty
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_isPartyBannerDirty | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a8722fb12be6d4fdaff69d84d654867db)\_latestNameTextObject
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_latestNameTextObject | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ac3633aa9ff8d1000f41c78d2c2ffad9c)\_previousQuestsBind
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CampaignUIHelper.IssueQuestFlags SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_previousQuestsBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a723bcd53c3684f9af5cf5c0ea1f890a7)\_questsBind
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CampaignUIHelper.IssueQuestFlags SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_questsBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a8d80425dc4fbad22b246b9c2ba4f86f8)\_partyPositionBind
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_partyPositionBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a1591da621b290f81861d06aacee84a63)\_headPositionBind
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_headPositionBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a34e7e2ae052bdfc839b4c7181db3cc84)\_isHighBind
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_isHighBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ab6c7c876df697e1e2717ad61b3a692ae)\_isBehindBind
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_isBehindBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ae05a2779b4626d0108b586608533ede7)\_isInArmyBind
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_isInArmyBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a79082d687155968229785b05c06348e3)\_isInSettlementBind
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_isInSettlementBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a4d1aae9fd8aeea03bb4c54bde84cb3bc)\_isVisibleOnMapBind
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_isVisibleOnMapBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ab3ec93c0633aeaf64d674bdb58256ff1)\_isArmyBind
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_isArmyBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a83905ef5be42529c678892e13944e861)\_isDisorganizedBind
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_isDisorganizedBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a412006f350f93789c410d90fd8294055)\_isCurrentlyAtSeaBind
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_isCurrentlyAtSeaBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a3fbe3d351ff123bddf490fcf6043877f)\_factionColorBind
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_factionColorBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ad1cdb92c83f377e3f7f4a13b0689b309)\_countBind
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_countBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a1f00d5089d427038ba4725e69bb4b1c7)\_woundedBind
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_woundedBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a989912dd07625235e2d7c842af3294d8)\_prisonerBind
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_prisonerBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aca4c2fdbc1cd19d65b6443eba8c88438)\_extraInfoTextBind
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_extraInfoTextBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aa1008e317d9ba04807250054b03cc975)\_fullNameBind
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_fullNameBind | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#abcd666d1e5d546aeaf9f3b4eee5140f7)\_movementSpeedTextBind
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.\_movementSpeedTextBind | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a2e21ddd75c7b0bdd3a5bd95956b57e60)Party
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.Party | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aad00666149aa3c268ddd5d3aa46f9e87)HeadPosition
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.HeadPosition | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a9b0788804fa51a2f75105c0f86503520)Count
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.Count | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a6b1f4237fc4c53ecff580056e8f94484)Prisoner
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.Prisoner | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ad6edd6fe489e4b3b444ad1bb75f5183c)Quests
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[QuestMarkerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_marker_v_m.html)> SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.Quests | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aa56508011d7f700748aa28134b6f6800)Wounded
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.Wounded | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aff6fa1cf31a202aff825a133e9e097dc)ExtraInfoText
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.ExtraInfoText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ac54524cf428ae90d0b489bf67d731c54)MovementSpeedText
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.MovementSpeedText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a761e1d0ad9070fbdb9b42370b646e337)FullName
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.FullName | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a62e9cd196367033eb356863bf9232bd9)IsInArmy
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.IsInArmy | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a7567ae58804325e8b55231e400adae1b)IsInSettlement
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.IsInSettlement | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aa39311d42e1156b8366a30d1e79c7be2)IsDisorganized
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.IsDisorganized | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a2e42f1ce5377844f545c991bc42fe316)IsCurrentlyAtSea
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.IsCurrentlyAtSea | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aae67bec4348fdb6ec9677b3485f3db88)IsArmy
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.IsArmy | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a5981a3c0bc7ccc286bc81d725a2d8ee9)IsBehind
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.IsBehind | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a17a1ba9c566000c91d76cc5f151a461c)IsHigh
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.IsHigh | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a674fcec24d818b63b06dc0e88d370519)ShouldShowFullName
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.ShouldShowFullName | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a4cf458108bf601e241452de030bf02c4)PartyBanner
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) SandBox.ViewModelCollection.Nameplate.PartyNameplateVM.PartyBanner | | getset |


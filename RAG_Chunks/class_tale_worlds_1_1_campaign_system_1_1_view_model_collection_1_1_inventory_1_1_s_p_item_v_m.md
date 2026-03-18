--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM Class ReferenceInherits [TaleWorlds.Core.ViewModelCollection.ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [ProfitTypes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac84e492a95ab5459ce60c709e00169dd) {     [HighLoss](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac84e492a95ab5459ce60c709e00169dda4447203a710121673003546c25e82fb5) = -2 ,     [Loss](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac84e492a95ab5459ce60c709e00169dda14781ee5e859104d453ad3eb28b441e5) = -1 ,     [Default](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac84e492a95ab5459ce60c709e00169dda7a1920d61156abc05a60135aefe8bc67) = 0 ,     [Profit](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac84e492a95ab5459ce60c709e00169dda182875b6c36a761f1e459624c1d93638) = 1 ,     [HighProfit](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac84e492a95ab5459ce60c709e00169dda296f55ef995414f1ddc596fead62deb5) = 2   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542) () |
|  | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ad67218aabd16224957b875ea55e54ea1) ([InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html) inventoryLogic, bool isHeroFemale, bool canCharacterUseItem, [InventoryScreenHelper.InventoryMode](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5) usageType, [ItemRosterElement](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#abe03d6533296e9f39414046fe6f955b3) newItem, InventoryLogic.InventorySide inventorySide, int itemCost=0, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61)? itemType=EquipmentIndex.None) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#af292455224f3879546d86696e30535cd) () |
|  | Used for updating localized texts. |
| void | [RefreshWith](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a9bea923b42bfe590f4bc0495e459b36e) ([SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542) itemVM, InventoryLogic.InventorySide inventorySide) |
| void | [ExecuteBuySingle](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a93e88d51e3d16f57b06ed2b377aad427) () |
| void | [ExecuteBuy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#affba076d949f1183ea8775f4c29d8243) (int amount) |
| void | [ExecuteSellSingle](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ab25b7fa12e52fdcc429448542f4de60b) () |
| void | [ExecuteSell](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a2859879ff5dfc05d5ff3fc44b2143604) (int amount) |
| void | [ExecuteSellItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ab21292c620418c0a09b6648fa578b6ef) () |
| void | [ExecuteConcept](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#adac6289674fceffedd1a4a65216914f9) () |
| void | [ExecuteResetTrade](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a3ab6cd02c9d3b42193737e51aee0a491) () |
| void | [UpdateTradeData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ae24402094d92f498a8268ee80cf2a13a) (bool forceUpdateAmounts) |
| void | [ExecuteSlaughterItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aaef1e9e29b1276ea3feee80d2b64d1a0) () |
| void | [ExecuteDonateItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a3b6e8ccb5b05badd7a5ede3a188bb316) () |
| void | [ExecuteSetFocused](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#af689928b417a25d5f2c796b62be9a028) () |
| void | [ExecuteSetUnfocused](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#abda0947870e7174654ba729e69093c8c) () |
| void | [UpdateCanBeSlaughtered](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a7d8f48ec2c0a78fb8b2ad49bc6a5ca23) () |
| void | [UpdateHintTexts](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a3c4195ec93b81e7b23cb7338227733a2) () |
| Public Member Functions inherited from [TaleWorlds.Core.ViewModelCollection.ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html) | |
|  | [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a) () |
| void | [ExecutePreviewItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a9326b5708f320cadf1afc55d55366259) () |
| void | [ExecuteUnequipItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a0025d05d9ac0383d0ac68a727c8b709b) () |
| void | [ExecuteEquipItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a172e92e4c337fa04f8b414fb5309d464) () |
| void | [ExecuteRefreshTooltip](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#aeb3974afee6d70819c0b9cb717eae365) () |
| void | [ExecuteCancelTooltip](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ac34005578ba90191dd685e59b7d44ffc) () |
| void | [ExecuteBuyItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a3867d27714c8ac7f7edfafb759aae031) () |
| void | [ExecuteSelectItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#aea17d747055b0121accf3f07c2c131d3) () |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | [GetItemTypeWithItemObject](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#af6dcc52d149b4b53bd9ee2bc0e80824e) () |
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
| Static Public Member Functions | |
| static [ProfitTypes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac84e492a95ab5459ce60c709e00169dd) | [GetProfitTypeFromDiff](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac32090ef1ddf33e4b6d57500c59ea23d) (float averageValue, float currentValue) |
| Static Public Member Functions inherited from [TaleWorlds.Core.ViewModelCollection.ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html) | |
| static void | [ReleaseStaticContent](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a89cb0605b82753cc7d2eb71aa1a72add) () |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static Action< [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542) > | [OnFocus](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ad028e0768fe160a9b64d43a5c84edb4f) |
| static Action< [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542), bool > | [ProcessSellItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a86a57e345314e8def8149ae948255e2a) |
| static Action< [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542) > | [ProcessItemSlaughter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a663c7b7470dab3ce21a3a969445b0a3b) |
| static Action< [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542) > | [ProcessItemDonate](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#acfba1d07e1edbee4b0a6363ebf21fc2e) |
| static Action< [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542), bool > | [ProcessLockItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aa86ee0e699ca20d16baf0f2f1e6fb45c) |
| Static Public Attributes inherited from [TaleWorlds.Core.ViewModelCollection.ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html) | |
| static Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a) > | [ProcessEquipItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a830db0c6df7a7c96655bc1bed054a019) |
| static Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a) > | [ProcessPreviewItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a755f953bc9d2488997337b2b49431348) |
| static Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a) > | [ProcessUnequipItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ab26b0066f53147e2a0ddce191c301c69) |
| static Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a), bool > | [ProcessBuyItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a331fb4411d3a4b400fe10175d69fedc0) |
| static Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a) > | [ProcessItemSelect](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a44b7dc1679c3cfa586a3e5d69a425110) |
| static Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a) > | [ProcessItemTooltip](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#aa1341ce1f6197150d5355c02984edef4) |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |

|  |  |
| --- | --- |
| Properties | |
| InventoryLogic.InventorySide | [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aa4c3a3afbfc68ea681451bccb2758860) `[get]` |
| bool | [IsFocused](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a95e3643a320fd1a1fef6e9993b5d2884) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aab86483aadb1ad46524030dce54dfe31) `[get, set]` |
| bool | [IsArtifact](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a99b827fddc678ea6a8d54f6e04e6272e) `[get, set]` |
| bool | [IsTransferable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a18d08207e5806a9ec721af7f51776bf7) `[get, set]` |
| bool | [IsTransferButtonHighlighted](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ab42cca6049ae1adb46175c138c9b59bc) `[get, set]` |
| bool | [IsItemHighlightEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#af08bbf7dd8d745944192b7b9dc612bed) `[get, set]` |
| bool | [IsCivilianItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a1260543775eb6ca888093c3d35fa4900) `[get, set]` |
| bool | [IsStealthItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a0a616d5779b4dbbbcd4727f5e3cbf9b9) `[get, set]` |
| bool | [IsNew](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a9ddd609ebc1391232a7e8b23bc63616d) `[get, set]` |
| bool | [IsGenderDifferent](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a92b8dab9e1cbfc00138d3593be348a58) `[get, set]` |
| bool | [CanBeSlaughtered](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a0dc5e80bb7823f7e91ae8fe925501c45) `[get, set]` |
| bool | [CanBeDonated](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a306e69623d9c6afb8dae593c704541e3) `[get, set]` |
| bool | [IsEquipableItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a678e82025f5df2fbc8369286e4bbf304) `[get, set]` |
| bool | [CanCharacterUseItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a05ec38736a8c064fe6a73725e48fbdd3) `[get, set]` |
| bool | [IsLocked](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aada1ee69410ce3a86f4b02d0a90a5ad2) `[get, set]` |
| int | [ItemCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a8557f79a4a7ca3598174dd8e13289bc8) `[get, set]` |
| int | [ItemLevel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a8d1ea952cfb3f8b8b2f5660ba2c7f561) `[get, set]` |
| int | [ProfitType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac4b825f6a0fca0587bf8c34fb7e5205e) `[get, set]` |
| int | [TransactionCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a3307cd1ffad685440ad7e613e6e230a9) `[get, set]` |
| int | [TotalCost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ae1fa5f31e5c17c4cabdfdf5b71b2f646) `[get, set]` |
| [InventoryTradeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html) | [TradeData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aabd6caeca1e1aafb7dafca283056d4f1) `[get, set]` |
| Properties inherited from [TaleWorlds.Core.ViewModelCollection.ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html) | |
| int | [TypeId](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a3b421c2b214c6079ef7bb916afe17d2c) `[get]` |
| int | [Version](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a90c24cab7cf5caf31fd858b2b54a9d95) `[get, protected set]` |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | [ItemType](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#aea8232d32a9d0238a90899517f733006) `[get]` |
| [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) | [ImageIdentifier](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a8b109d09e86f93e34c8721ba9524c2b8) `[get, set]` |
| string | [StringId](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a551620072c89a9e437d53bd5c9e9581f) `[get, set]` |
| string | [ItemDescription](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a6856d4b5a569c3530cd609feec3e8956) `[get, set]` |
| bool | [IsFiltered](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a6f89e0513da613928e39d9f41f801afd) `[get, set]` |
| int | [ItemCost](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ad80704703dab982a740f594dfbda9c4b) `[get, set]` |
| string | [TypeName](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a6e276951f161958cbeb8937b5e06c4d8) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [PreviewHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a08a9f247938d7a5e4fded0f72b148b70) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EquipHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ad549d241a4f2b680fd04aa9f15d68fc1) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [UnequipHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#acf547a6c2c540b17fd107d3187dd9fdc) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [SlaughterHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ab6b50e1545a8b1c361268211d1aeab28) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [DonateHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a40a641e39025bd109ef0a36002c3c3df) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [BuyAndEquipHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a5b2ec53217d29f3ab2110ecfc88bddac) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [SellHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a70116ceb38fe45f1aad4380cf9e83455) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [BuyHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ab880e3c08f88bfa4e674ffc2c672a31a) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [LockHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#abfa0bb33af082b2cdaa55fa658b42d74) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.Core.ViewModelCollection.ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html) | |
| ItemRosterElement | [ItemRosterElement](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#abe03d6533296e9f39414046fe6f955b3) |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | [\_itemType](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ab10a3556d7798c11db0791e6498e37c0) = [EquipmentIndex.None](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61a6adf97f83acf6453d4a6a4b1070f3754) |
| Protected Member Functions inherited from [TaleWorlds.Core.ViewModelCollection.ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html) | |
| void | [OnItemTypeUpdated](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#af6058c2d39c52adb891c598b8933e3a6) () |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac84e492a95ab5459ce60c709e00169dd)ProfitTypes
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ProfitTypes |

| Enumerator | |
| --- | --- |
| HighLoss |  |
| Loss |  |
| Default |  |
| Profit |  |
| HighProfit |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542)SPItemVM() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.SPItemVM | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ad67218aabd16224957b875ea55e54ea1)SPItemVM() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.SPItemVM | ( | [InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html) | *inventoryLogic*, |
|  |  | bool | *isHeroFemale*, |
|  |  | bool | *canCharacterUseItem*, |
|  |  | [InventoryScreenHelper.InventoryMode](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5) | *usageType*, |
|  |  | [ItemRosterElement](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#abe03d6533296e9f39414046fe6f955b3) | *newItem*, |
|  |  | InventoryLogic.InventorySide | *inventorySide*, |
|  |  | int | *itemCost* = 0, |
|  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61)? | *itemType* = EquipmentIndex::None ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#af292455224f3879546d86696e30535cd)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.ViewModelCollection.ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a30db0f1bfa83b936a0118e94f2072b16).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a9bea923b42bfe590f4bc0495e459b36e)RefreshWith()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.RefreshWith | ( | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542) | *itemVM*, |
|  |  | InventoryLogic.InventorySide | *inventorySide* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a93e88d51e3d16f57b06ed2b377aad427)ExecuteBuySingle()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ExecuteBuySingle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#affba076d949f1183ea8775f4c29d8243)ExecuteBuy()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ExecuteBuy | ( | int | *amount* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ab25b7fa12e52fdcc429448542f4de60b)ExecuteSellSingle()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ExecuteSellSingle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a2859879ff5dfc05d5ff3fc44b2143604)ExecuteSell()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ExecuteSell | ( | int | *amount* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ab21292c620418c0a09b6648fa578b6ef)ExecuteSellItem()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ExecuteSellItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#adac6289674fceffedd1a4a65216914f9)ExecuteConcept()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ExecuteConcept | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a3ab6cd02c9d3b42193737e51aee0a491)ExecuteResetTrade()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ExecuteResetTrade | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ae24402094d92f498a8268ee80cf2a13a)UpdateTradeData()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.UpdateTradeData | ( | bool | *forceUpdateAmounts* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aaef1e9e29b1276ea3feee80d2b64d1a0)ExecuteSlaughterItem()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ExecuteSlaughterItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a3b6e8ccb5b05badd7a5ede3a188bb316)ExecuteDonateItem()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ExecuteDonateItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#af689928b417a25d5f2c796b62be9a028)ExecuteSetFocused()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ExecuteSetFocused | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#abda0947870e7174654ba729e69093c8c)ExecuteSetUnfocused()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ExecuteSetUnfocused | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a7d8f48ec2c0a78fb8b2ad49bc6a5ca23)UpdateCanBeSlaughtered()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.UpdateCanBeSlaughtered | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a3c4195ec93b81e7b23cb7338227733a2)UpdateHintTexts()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.UpdateHintTexts | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac32090ef1ddf33e4b6d57500c59ea23d)GetProfitTypeFromDiff()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ProfitTypes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac84e492a95ab5459ce60c709e00169dd) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.GetProfitTypeFromDiff | ( | float | *averageValue*, | |  |  | float | *currentValue* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ad028e0768fe160a9b64d43a5c84edb4f)OnFocus
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542)> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.OnFocus | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a86a57e345314e8def8149ae948255e2a)ProcessSellItem
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542), bool> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ProcessSellItem | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a663c7b7470dab3ce21a3a969445b0a3b)ProcessItemSlaughter
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542)> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ProcessItemSlaughter | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#acfba1d07e1edbee4b0a6363ebf21fc2e)ProcessItemDonate
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542)> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ProcessItemDonate | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aa86ee0e699ca20d16baf0f2f1e6fb45c)ProcessLockItem
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aca157ad04098811a2a69cadf2cbda542), bool> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ProcessLockItem | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aa4c3a3afbfc68ea681451bccb2758860)InventorySide
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | InventoryLogic.InventorySide TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.InventorySide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a95e3643a320fd1a1fef6e9993b5d2884)IsFocused
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.IsFocused | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aab86483aadb1ad46524030dce54dfe31)IsSelected
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a99b827fddc678ea6a8d54f6e04e6272e)IsArtifact
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.IsArtifact | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a18d08207e5806a9ec721af7f51776bf7)IsTransferable
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.IsTransferable | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ab42cca6049ae1adb46175c138c9b59bc)IsTransferButtonHighlighted
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.IsTransferButtonHighlighted | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#af08bbf7dd8d745944192b7b9dc612bed)IsItemHighlightEnabled
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.IsItemHighlightEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a1260543775eb6ca888093c3d35fa4900)IsCivilianItem
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.IsCivilianItem | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a0a616d5779b4dbbbcd4727f5e3cbf9b9)IsStealthItem
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.IsStealthItem | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a9ddd609ebc1391232a7e8b23bc63616d)IsNew
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.IsNew | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a92b8dab9e1cbfc00138d3593be348a58)IsGenderDifferent
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.IsGenderDifferent | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a0dc5e80bb7823f7e91ae8fe925501c45)CanBeSlaughtered
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.CanBeSlaughtered | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a306e69623d9c6afb8dae593c704541e3)CanBeDonated
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.CanBeDonated | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a678e82025f5df2fbc8369286e4bbf304)IsEquipableItem
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.IsEquipableItem | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a05ec38736a8c064fe6a73725e48fbdd3)CanCharacterUseItem
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.CanCharacterUseItem | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aada1ee69410ce3a86f4b02d0a90a5ad2)IsLocked
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.IsLocked | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a8557f79a4a7ca3598174dd8e13289bc8)ItemCount
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ItemCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a8d1ea952cfb3f8b8b2f5660ba2c7f561)ItemLevel
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ItemLevel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ac4b825f6a0fca0587bf8c34fb7e5205e)ProfitType
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.ProfitType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#a3307cd1ffad685440ad7e613e6e230a9)TransactionCount
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.TransactionCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#ae1fa5f31e5c17c4cabdfdf5b71b2f646)TotalCost
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.TotalCost | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#aabd6caeca1e1aafb7dafca283056d4f1)TradeData
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InventoryTradeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM.TradeData | | getset |


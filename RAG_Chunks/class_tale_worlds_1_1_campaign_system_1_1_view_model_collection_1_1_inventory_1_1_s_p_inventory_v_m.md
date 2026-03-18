--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [EquipmentModes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab6069d8c09c68141511709d460a8669e) {     [Civilian](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab6069d8c09c68141511709d460a8669ea4f288ef90a7b9b5283ecf39574f010d0) ,     [Battle](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab6069d8c09c68141511709d460a8669ea747d99f92ee9c080ba26108ac5d26488) ,     [Stealth](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab6069d8c09c68141511709d460a8669ea899db408cba5858a0f1701a2caef2628)   } |
| enum | [Filters](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8dd79dcf804fa45874f9788d92b3b1a5) : int {     [All](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8dd79dcf804fa45874f9788d92b3b1a5ab1c94ca2fbc3e78fc30069c8d0f01680) ,     [Weapons](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8dd79dcf804fa45874f9788d92b3b1a5a8a90c0eea4a6a26a919d1936e06b4920) ,     [ShieldsAndRanged](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8dd79dcf804fa45874f9788d92b3b1a5a336e80cda925a3343954fc8d0eda2656) ,     [Armors](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8dd79dcf804fa45874f9788d92b3b1a5a975eacacebe9dc402dffa3eae65936c1) ,     [Mounts](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8dd79dcf804fa45874f9788d92b3b1a5a19068a7dcdd98d1c5c07b3dbdd6f82ee) ,     [Miscellaneous](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8dd79dcf804fa45874f9788d92b3b1a5a387baf0199e7c9cc944fae94e96448fa)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SPInventoryVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2f1cfc5e41553418499cb64ff5b669cc) ([InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html) inventoryLogic, bool isInCivilianModeByDefault, Func< [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html), [ItemObject.ItemUsageSetFlags](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22) > getItemUsageSetFlags) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a4a8c9c544d328dfc0f4b69fb0704d61a) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af8228fbd81543514882dcfc55619f3d8) () |
| void | [RefreshCallbacks](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abdd09fe24bef479f160823c2eaeaa015) () |
| void | [ExecuteShowRecap](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1004f2abf8c67b8c9ce1d59cd1cb81cb) () |
| void | [ExecuteCancelRecap](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1b90af122a90c198f6a386bd89a4dedb) () |
| void | [ExecuteRemoveZeroCounts](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab045bcc4119eb13101146568206f9a9a) () |
| void | [ClosePreview](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ae753ec748c62f8a0d0719bf2a7cdc178) () |
| void | [ProcessItemTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad92faf7ed3069d35930ec74a0a6aa6c6) ([ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html) item) |
| void | [ResetSelectedItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a479b6aac00e38738892eef77b6dd1098) () |
| void | [RefreshComparedItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8467593dd4cad9e29bbd863d2d31c347) () |
| bool | [IsItemEquipmentPossible](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a064160bef7bcf2420cdbc8efae305d3f) ([SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) itemVM) |
| void | [CompareNextItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a676ec6386661845848dac1a261cf689e) () |
| void | [ExecuteSelectItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a6e6be99eb93eac6536eede69c3d9b5f6) ([ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html) item) |
| void | [ExecuteClearSelectedItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aa888a7ae46f703edb68afdb82876a252) () |
| bool | [IsAnyEquippedItemSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a6d687902e98dc7e9d5f94e3bb13e0ae4) () |
| void | [ExecuteSelectStealthOutfit](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a57e542e07bfc25519c1e363cf5b52795) () |
| void | [ExecuteSelectBattleOutfit](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac4e790dd20d64e44f6b8928140eed185) () |
| void | [ExecuteSelectCivilianOutfit](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad5eda1ce812a0f5bb275382106f72b5a) () |
| void | [ExecuteBuyAllItems](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a23f8d72be101ebf05f0ac64818869d93) () |
| void | [ExecuteSellAllItems](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a90406dc800f4d74cb2266d7bba3c17e9) () |
| void | [ExecuteBuyItemTest](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0206be8e89a48abbad70535bb1c6c7b7) () |
| void | [ExecuteResetTranstactions](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0472eb00d6c73eb07e62399b1780b827) () |
| void | [ExecuteResetAndCompleteTranstactions](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac2e204fc329d5f9d814cba84d2f0b02e) () |
| void | [ExecuteCompleteTranstactions](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a27b9a2772dde74f3aa59a146ae5dbc29) () |
| void | [ExecuteTransferWithParameters](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a994fcc5f95f8c41282a27856e4996f6c) ([SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) item, int index, string targetTag) |
| void | [ExecuteFilterNone](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abc25d2f2b498eb5e1fe034385e4a718a) () |
| void | [ExecuteFilterWeapons](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a45a4668ec0cc110e5935b67093bda09c) () |
| void | [ExecuteFilterArmors](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aa5fa1cd881164a3bc4b83ba5e994e5c0) () |
| void | [ExecuteFilterShieldsAndRanged](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aef575bc47a899bfbe076166729b3227f) () |
| void | [ExecuteFilterMounts](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abb9e86ffd49e222cc6bf6efab2c7d68b) () |
| void | [ExecuteFilterMisc](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aebcbb772ae61d05d83e237f9d90c26f9) () |
| void | [CycleBetweenWeaponSlots](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a7a67de289a1b7f7592658ea8fc2c6b72) () |
| void | [SetResetInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a87b9207f0a56c0b2a5346197eb29e040) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
| void | [SetCancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac9c4e0811b9145f36a87867f72ac4ba4) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) gameKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aedcbe895060b8e83cd8d3dc7caabc9b4) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetPreviousCharacterInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac8eabe883c5f0c24922c6819d3b25e0c) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetNextCharacterInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a119e854f2f272d5efb3c9ac25be22489) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetBuyAllInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a7e633d59a044dbc1c932ca875209bfeb) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetSellAllInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3e47f2753403099fb3bd3d124f7e3b4d) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetGetKeyTextFromKeyIDFunc](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5634e1bf24afc64ff6f0a4dfd7fc15ac) (Func< string, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > getKeyTextFromKeyId) |
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
| bool | [DoNotSync](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a60bb617b734c8445a2a7607815f54c5d) |
| bool | [IsFiveStackModifierActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a7fb80ad8a6219b21cff44f721b4a776a) |
| bool | [IsEntireStackModifierActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2d436e26c6f2af6f13913452cf44bd37) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [RefreshEquipment](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a31914af2c19f41c05f0d91d58530733d) ([SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) itemVM, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) itemType) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Properties | |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ResetHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab2760b26d378c1f97054a9d864dc955e) `[get, set]` |
| string | [LeftInventoryLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a4774afaf0d5af53d11c4593bee772721) `[get, set]` |
| string | [RightInventoryLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0b2bd13727c573aecae1de554d3fe8a8) `[get, set]` |
| string | [DoneLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a6d50d1d972ee9ee8458fd7842dcc0187) `[get, set]` |
| bool | [IsDoneDisabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a979a5f254e278bf72802559eea106b49) `[get, set]` |
| bool | [OtherSideHasCapacity](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a23087e7ec1fe4f9ca17c73fea4edd5e2) `[get, set]` |
| bool | [IsSearchAvailable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a15428b9e94572fa2c84380af68e7a813) `[get, set]` |
| bool | [IsOtherInventoryGoldRelevant](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2f8c315390b84f1af8b1f502e49e1a9b) `[get, set]` |
| string | [CancelLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac7f7dee2cbdb73c9f83205027f8533f8) `[get, set]` |
| string | [ResetLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad63b99df3fd65799c5d682dfdc33c858) `[get, set]` |
| string | [TypeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3b7eb460c2f60c63906b38ccc0317131) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af6657538f8c314b3bfc8543e23542591) `[get, set]` |
| string | [QuantityText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad41b73e0fbe3130267ca9f4d91ca9dea) `[get, set]` |
| string | [CostText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a03d08afc109facf2826e1d28d5ea446b) `[get, set]` |
| string | [SearchPlaceholderText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aa5e26efe6f87d3c438b02358b6c3dd05) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [ProductionTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af7922bc6c7865cec86f821233c0add02) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [InventoryCapacityHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3feab633b94adf6a01d92c4c38688ce9) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [LandCapacityHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abbfddf155587e87ff0383108e5c8dbaf) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [SeaCapacityHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a48b5087db5521ad9b7c8d3390f4a31ce) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [TotalWeightCarriedHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af98f6f4436fab7adc8e483cbba0e9970) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [LandWeightHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8e8a3fe68c5b99162dde147c17bc1fe3) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [SeaWeightHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1f77b9184bce875006e0f2cbd4adef52) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [CurrentCharacterSkillsTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aacf8eb8733abdf6e19ebb4e70cde3f04) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [NoSaddleHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab785a310a159c98818c0fdd4a7740e1e) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DonationLblHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2db9893115fbf2a0fd197dc73c0c2994) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ArmArmorHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a101660ad8ca13e06a15007850fde57f8) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [BodyArmorHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad981a7888e513d8ae35e44953464d769) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [HeadArmorHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aa11a92058bf5b8aa1239b96ca98dd8d5) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [LegArmorHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#adcbd284d15c70441d952ec6d4e0025f2) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [HorseArmorHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad1314eb2c666b1b489f0a4820f920312) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [FilterAllHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a44c2d4ff8014f34f7705ac4438bcf26d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [FilterWeaponHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a4c0d911ef56ea4368f8e95543fcf1439) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [FilterArmorHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abb87565946a68741b9a292bd85dd4761) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [FilterShieldAndRangedHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a84ab70d57818747b21f6142675066d45) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [FilterMountAndHarnessHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0027fade232270488c21e229a37f8ace) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [FilterMiscHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ae9a2e988026e68ef87969af862b6ba9a) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [StealthOutfitHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8100a5f051ef40826e6ee6e73d6c1eab) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [CivilianOutfitHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#add6e632af411da9def6b6f35aa7353b8) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [BattleOutfitHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a65ac55c1270ea20701d948bafc7cb5ac) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EquipmentHelmSlotHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a9f9b72b365e6089aa80317ca5401ef1f) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EquipmentArmorSlotHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af468e9853f80b7173bd352261e6b4ca7) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EquipmentBootSlotHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8fe94c2fbf12aa9d9b190c77b964e911) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EquipmentCloakSlotHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a6bac0b71d33673198a0538e8c3280752) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EquipmentGloveSlotHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af9bbdf5355e8316fcc9f86619805c78c) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EquipmentHarnessSlotHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a79f21ce2b2bd38b6c62dc1afc1f70849) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EquipmentMountSlotHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a37cfa7286d476e1791ea315c0f0512da) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EquipmentWeaponSlotHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aec70cf0cbf9faffc828604189022043d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EquipmentBannerSlotHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a277b1d454c4b5d2bd0588905fd16fff4) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [BuyAllHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a7bc2c06b244c517bad3476953f10f664) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [SellAllHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a88b69c19b387e75edd51fb36f68985db) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [PreviousCharacterHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a04b76541b62bd4ad58746cdf57503e07) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [NextCharacterHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a72e1c985369127e70f95b6d03d94d82c) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [WeightHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aeb2bf9048c1b36542a6038b20bb9ea34) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [PreviewHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a066b642b22bf931a5dfbf6386d0e076b) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EquipHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#acfb32f53ec5e99116b42b969408f6c9d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [UnequipHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a47122b52b7de230bb4b36207f7fb3095) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [SellHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a6d44778f168a2e63f74dacd68954a91b) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [PlayerSideCapacityExceededHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a624b64452923aacfa75172daeb9df763) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [MainPartyLandCapacityExceededHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3eed02357f1999df17625f4010d88d47) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [MainPartySeaCapacityExceededHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2da873e8833cbbc32ea4c1631a913c50) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [OtherSideCapacityExceededHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a75bbdb989899f4781c90f765b0480c2d) `[get, set]` |
| SelectorVM< [InventoryCharacterSelectorItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_character_selector_item_v_m.html) > | [CharacterList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0b18b1eb77392390c2ee62347cee392b) `[get, set]` |
| [SPInventorySortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html) | [PlayerInventorySortController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2fa9fab6446f1a103506f6c933091b81) `[get, set]` |
| [SPInventorySortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html) | [OtherInventorySortController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3cebbba2a396ea7323030ea93180ef33) `[get, set]` |
| [ItemPreviewVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_preview_v_m.html) | [ItemPreview](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aae938d786c81f2ec7e98e34ede84b4f9) `[get, set]` |
| int | [ActiveFilterIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a67b7679f691a87def981a280e8f8fe4b) `[get, set]` |
| bool | [CompanionExists](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab40e1cdbc01ef51e73ed764890c1b019) `[get, set]` |
| bool | [IsTradingWithSettlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a7a39de0363e5dfbbc0b4c92f1d3b2830) `[get, set]` |
| int | [EquipmentMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5d335cfb66a4f89ac95ed7098b1b0e56) `[get, set]` |
| bool | [IsMicsFilterHighlightEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a03336d96181d6b5b40f3832e8e27087b) `[get, set]` |
| bool | [IsEquipmentSetFiltersHighlighted](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a88f9d1cd51a09b21926f596c3b2fba45) `[get, set]` |
| [ItemMenuVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html) | [ItemMenu](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad76944b0c46e155440cc8dbb19328bef) `[get, set]` |
| string | [PlayerSideCapacityExceededText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a141407179de5ca5e4c11e3553b4e6d45) `[get, set]` |
| string | [MainPartyLandCapacityExceededText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a599ce6b445e0d733eb8a437e1d13a9bd) `[get, set]` |
| string | [MainPartySeaCapacityExceededText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1be761286fd00399d623fcb7b69ba244) `[get, set]` |
| string | [SeparatorText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aeb7cc45079aac299dec32c04da0dbf4d) `[get, set]` |
| string | [OtherSideCapacityExceededText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8cd77f28d6c67790d72b2c9b60ea9291) `[get, set]` |
| string | [LeftSearchText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8960483b50030df4ecb2a2e7f1aafe37) `[get, set]` |
| string | [RightSearchText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abed442ff3a8873431f6388c3e338ec70) `[get, set]` |
| bool | [HasGainedExperience](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab04371d61ce6cd7356f028ea51e5723e) `[get, set]` |
| bool | [IsDonationXpGainExceedsMax](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af55227e0a93064ce09e540633e743824) `[get, set]` |
| bool | [NoSaddleWarned](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af9827d664c13f649cf02fe3a6a71c473) `[get, set]` |
| bool | [ShowMainPartyLandCapacityTexts](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a197ced497b41713f6eb21f228afdf9b6) `[get, set]` |
| bool | [ShowMainPartySeaCapacityTexts](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a6ee2a8b6c65d4e1ed03b98ed43b046e6) `[get, set]` |
| bool | [PlayerEquipmentCountWarned](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aa1ebc6018259001971f509e9e4141461) `[get, set]` |
| bool | [IsMainPartyLandCapacityWarned](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af6865d70739556f6d61b777355b07d38) `[get, set]` |
| bool | [IsMainPartySeaCapacityWarned](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af4dcb12aa15465ab6cc162cdb3af912b) `[get, set]` |
| bool | [ShowMainPartyLandCapacityWarning](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2f8007afb0ad3124b62a9d849adafb33) `[get, set]` |
| bool | [ShowMainPartySeaCapacityWarning](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af2c59319b5eb99454742596b4a7d20ee) `[get, set]` |
| bool | [OtherEquipmentCountWarned](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#acbec55ebe6843fb22273d2a2a5d2b437) `[get, set]` |
| bool | [OtherEquipmentCapacityExceededWarning](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab493e346a6da90dda98e05aeb258b2c7) `[get, set]` |
| string | [OtherEquipmentCountText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af9a0986ae4915c4ad5adce47863ff9bc) `[get, set]` |
| string | [MainPartyTotalWeightCarriedText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2aee337b5698946a91af0d77ccf6c657) `[get, set]` |
| string | [MainPartyLandWeightText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a4cdee443bd11f78aeabedd563a449791) `[get, set]` |
| string | [MainPartySeaWeightText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a54cbfd50e87e02c13aa61bbf4a4dabb2) `[get, set]` |
| string | [MainPartyInventoryCapacityText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a31ede5c048d66f4b5d619eedc833544b) `[get, set]` |
| string | [MainPartyLandCapacityText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0db7d792c054f470d90ca2db316f0323) `[get, set]` |
| string | [MainPartySeaCapacityText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#adac61f4ed8a455d96999095f56c55e74) `[get, set]` |
| string | [NoSaddleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac48274eef8b1738c5509ae8b6d3bb687) `[get, set]` |
| int | [TargetEquipmentIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a4549c4b8f0ebd24679dd84505f2ba728) `[get, set]` |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | [TargetEquipmentType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a85a39b6e89cb625e56c7e907df394955) `[get, set]` |
| int | [TransactionCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aaa400f2b9209ffa591154e505d2228e8) `[get, set]` |
| bool | [IsTrading](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a951b60a4546ad82b2259a88e2431a837) `[get, set]` |
| bool | [EquipAfterBuy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a19e8527f031dd99cd91040ae13051fe4) `[get, set]` |
| string | [TradeLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2db5ae4c9dea65b60a6b24882481689c) `[get, set]` |
| string | [ExperienceLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aaa12ccb00cbc4cc461cadb0754ad56e7) `[get, set]` |
| string | [CurrentCharacterName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a28a93f61ca5a97d5fe9b7957cc2effa1) `[get, set]` |
| string | [RightInventoryOwnerName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1f61f467f144978e54224276d1e196af) `[get, set]` |
| string | [LeftInventoryOwnerName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aea93ff3ee5f17e86a9be9a74987fcb36) `[get, set]` |
| int | [RightInventoryOwnerGold](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#adeefc9aad44abbc482e7ddf5879187b4) `[get, set]` |
| int | [LeftInventoryOwnerGold](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a07c59f5621f1cfae96379d7cd41fa06b) `[get, set]` |
| int | [ItemCountToBuy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a58cdfe4a4e32f4c6ced6b4d25631ee36) `[get, set]` |
| string | [CurrentCharacterTotalEncumbrance](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0bd51fbc315a9c87adeeb3a922c384f7) `[get, set]` |
| float | [CurrentCharacterLegArmor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aeff3307d0d4bc2e9d8859d9c7f7a4894) `[get, set]` |
| float | [CurrentCharacterHeadArmor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#adf5d445dcd00ec85bebce21f11e21890) `[get, set]` |
| float | [CurrentCharacterBodyArmor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#add17b518011ed5b06b5c510c36a79de3) `[get, set]` |
| float | [CurrentCharacterArmArmor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a81c25d7dc82d5ab80fbe31da761d5737) `[get, set]` |
| float | [CurrentCharacterHorseArmor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5f75b0839d69deb3a6528fc791b881d2) `[get, set]` |
| bool | [IsRefreshed](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3b8e04a0e0e38e0a2961ec32585a5655) `[get, set]` |
| bool | [IsExtendedEquipmentControlsEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad00e0800f520e29ee1d0ea1d8045e3a9) `[get, set]` |
| bool | [IsFocusedOnItemList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a975ba642b4c29614603dee5b40324b91) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CurrentFocusedItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aeda658be1266c0792de0201f1951a43d) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CharacterHelmSlot](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a39874810a1a8c69f58982ffa40c2f31f) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CharacterCloakSlot](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3e4b4cfe3fba85b4cf26e43523e737b1) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CharacterTorsoSlot](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aba1b3c4857f954f684a024c3b0d23dfa) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CharacterGloveSlot](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5d4cad68a7ee5ad2d80ec6f996184a3e) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CharacterBootSlot](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5c6d9f748f15fd85b5641bd1d4015321) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CharacterMountSlot](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1d63e77845b9fdce86a09dd2fe1a0ec7) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CharacterMountArmorSlot](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#afa8d7b67d8d16b01cd54cc0c7cd97ed2) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CharacterWeapon1Slot](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a727f0a781b55813ced45b7d11bbf2448) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CharacterWeapon2Slot](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af019031d4c8bcc91560cabcfd12ecdbb) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CharacterWeapon3Slot](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5a64e86dc15fae839bd79ecc1a2928fd) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CharacterWeapon4Slot](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aa7f7940bcb1aaaba91b9ebb0a543fe2c) `[get, set]` |
| [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | [CharacterBannerSlot](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a34e2c705c1062e89c0c2fad5210763b6) `[get, set]` |
| [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) | [MainCharacter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab52928ba8c527dec52e0cb72f7794ae3) `[get, set]` |
| MBBindingList< [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) > | [RightItemListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0e9a02f42503643730ea483f7db419b4) `[get, set]` |
| MBBindingList< [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) > | [LeftItemListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aad4287b7a41b05b27995c30f4077e5d1) `[get, set]` |
| bool | [IsBannerItemsHighlightApplied](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1434319029f09daee987f1f6d33a2d3d) `[get, set]` |
| string | [BannerTypeName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a53c7f3df1cec5c2b8cdb41cc576cee51) `[get, set]` |
| bool | [ScrollToItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a64736fdbe0d30cf456cb4c29f8d858bb) `[get, set]` |
| string | [ScrollItemId](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a4a579df8e6b21daf7ed048de92791921) `[get, set]` |
| bool | [IsCivilianMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac73e9e30b021699c175a8dd91b6b9967) `[get, set]` |
| bool | [IsBattleMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3d70a29c3d39d9a1cd7e1aa0c24e8c68) `[get, set]` |
| bool | [IsStealthMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5bb77fd9c22480b7be83ab0fee29b981) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ResetInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab1ced1a2d53ebded336a336b1f963813) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab9baad46523493ff8b920aa092fed5eb) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#afc50de61544af93ce22d2bdcf8d9f670) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [PreviousCharacterInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af9d7ffd86344a064484a3a3211230429) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [NextCharacterInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a7a41739c67082e26344445c05f6a8d41) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [BuyAllInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac287c822b4afd247976608f8b9886daa) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [SellAllInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abec15402e247855c5c1294058127b82e) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab6069d8c09c68141511709d460a8669e)EquipmentModes
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipmentModes |

| Enumerator | |
| --- | --- |
| Civilian |  |
| Battle |  |
| Stealth |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8dd79dcf804fa45874f9788d92b3b1a5)Filters
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.Filters : int |

| Enumerator | |
| --- | --- |
| All |  |
| Weapons |  |
| ShieldsAndRanged |  |
| Armors |  |
| Mounts |  |
| Miscellaneous |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2f1cfc5e41553418499cb64ff5b669cc)SPInventoryVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SPInventoryVM | ( | [InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html) | *inventoryLogic*, |
|  |  | bool | *isInCivilianModeByDefault*, |
|  |  | Func< [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html), [ItemObject.ItemUsageSetFlags](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22) > | *getItemUsageSetFlags* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a4a8c9c544d328dfc0f4b69fb0704d61a)RefreshValues()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af8228fbd81543514882dcfc55619f3d8)OnFinalize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abdd09fe24bef479f160823c2eaeaa015)RefreshCallbacks()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.RefreshCallbacks | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1004f2abf8c67b8c9ce1d59cd1cb81cb)ExecuteShowRecap()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteShowRecap | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1b90af122a90c198f6a386bd89a4dedb)ExecuteCancelRecap()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteCancelRecap | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab045bcc4119eb13101146568206f9a9a)ExecuteRemoveZeroCounts()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteRemoveZeroCounts | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ae753ec748c62f8a0d0719bf2a7cdc178)ClosePreview()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ClosePreview | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad92faf7ed3069d35930ec74a0a6aa6c6)ProcessItemTooltip()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ProcessItemTooltip | ( | [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a479b6aac00e38738892eef77b6dd1098)ResetSelectedItem()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ResetSelectedItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8467593dd4cad9e29bbd863d2d31c347)RefreshComparedItem()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.RefreshComparedItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a064160bef7bcf2420cdbc8efae305d3f)IsItemEquipmentPossible()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsItemEquipmentPossible | ( | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | *itemVM* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a31914af2c19f41c05f0d91d58530733d)RefreshEquipment()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.RefreshEquipment | ( | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | *itemVM*, | |  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *itemType* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a676ec6386661845848dac1a261cf689e)CompareNextItem()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CompareNextItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a6e6be99eb93eac6536eede69c3d9b5f6)ExecuteSelectItem()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteSelectItem | ( | [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aa888a7ae46f703edb68afdb82876a252)ExecuteClearSelectedItem()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteClearSelectedItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a6d687902e98dc7e9d5f94e3bb13e0ae4)IsAnyEquippedItemSelected()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsAnyEquippedItemSelected | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a57e542e07bfc25519c1e363cf5b52795)ExecuteSelectStealthOutfit()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteSelectStealthOutfit | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac4e790dd20d64e44f6b8928140eed185)ExecuteSelectBattleOutfit()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteSelectBattleOutfit | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad5eda1ce812a0f5bb275382106f72b5a)ExecuteSelectCivilianOutfit()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteSelectCivilianOutfit | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a23f8d72be101ebf05f0ac64818869d93)ExecuteBuyAllItems()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteBuyAllItems | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a90406dc800f4d74cb2266d7bba3c17e9)ExecuteSellAllItems()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteSellAllItems | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0206be8e89a48abbad70535bb1c6c7b7)ExecuteBuyItemTest()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteBuyItemTest | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0472eb00d6c73eb07e62399b1780b827)ExecuteResetTranstactions()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteResetTranstactions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac2e204fc329d5f9d814cba84d2f0b02e)ExecuteResetAndCompleteTranstactions()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteResetAndCompleteTranstactions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a27b9a2772dde74f3aa59a146ae5dbc29)ExecuteCompleteTranstactions()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteCompleteTranstactions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a994fcc5f95f8c41282a27856e4996f6c)ExecuteTransferWithParameters()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteTransferWithParameters | ( | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | *item*, |
|  |  | int | *index*, |
|  |  | string | *targetTag* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abc25d2f2b498eb5e1fe034385e4a718a)ExecuteFilterNone()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteFilterNone | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a45a4668ec0cc110e5935b67093bda09c)ExecuteFilterWeapons()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteFilterWeapons | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aa5fa1cd881164a3bc4b83ba5e994e5c0)ExecuteFilterArmors()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteFilterArmors | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aef575bc47a899bfbe076166729b3227f)ExecuteFilterShieldsAndRanged()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteFilterShieldsAndRanged | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abb9e86ffd49e222cc6bf6efab2c7d68b)ExecuteFilterMounts()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteFilterMounts | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aebcbb772ae61d05d83e237f9d90c26f9)ExecuteFilterMisc()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExecuteFilterMisc | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a7a67de289a1b7f7592658ea8fc2c6b72)CycleBetweenWeaponSlots()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CycleBetweenWeaponSlots | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a87b9207f0a56c0b2a5346197eb29e040)SetResetInputKey()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SetResetInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac9c4e0811b9145f36a87867f72ac4ba4)SetCancelInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *gameKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aedcbe895060b8e83cd8d3dc7caabc9b4)SetDoneInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac8eabe883c5f0c24922c6819d3b25e0c)SetPreviousCharacterInputKey()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SetPreviousCharacterInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a119e854f2f272d5efb3c9ac25be22489)SetNextCharacterInputKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SetNextCharacterInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a7e633d59a044dbc1c932ca875209bfeb)SetBuyAllInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SetBuyAllInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3e47f2753403099fb3bd3d124f7e3b4d)SetSellAllInputKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SetSellAllInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5634e1bf24afc64ff6f0a4dfd7fc15ac)SetGetKeyTextFromKeyIDFunc()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SetGetKeyTextFromKeyIDFunc | ( | Func< string, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *getKeyTextFromKeyId* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a60bb617b734c8445a2a7607815f54c5d)DoNotSync
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.DoNotSync |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a7fb80ad8a6219b21cff44f721b4a776a)IsFiveStackModifierActive
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsFiveStackModifierActive |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2d436e26c6f2af6f13913452cf44bd37)IsEntireStackModifierActive
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsEntireStackModifierActive |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab2760b26d378c1f97054a9d864dc955e)ResetHint
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ResetHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a4774afaf0d5af53d11c4593bee772721)LeftInventoryLabel
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.LeftInventoryLabel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0b2bd13727c573aecae1de554d3fe8a8)RightInventoryLabel
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.RightInventoryLabel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a6d50d1d972ee9ee8458fd7842dcc0187)DoneLbl
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.DoneLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a979a5f254e278bf72802559eea106b49)IsDoneDisabled
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsDoneDisabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a23087e7ec1fe4f9ca17c73fea4edd5e2)OtherSideHasCapacity
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.OtherSideHasCapacity | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a15428b9e94572fa2c84380af68e7a813)IsSearchAvailable
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsSearchAvailable | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2f8c315390b84f1af8b1f502e49e1a9b)IsOtherInventoryGoldRelevant
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsOtherInventoryGoldRelevant | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac7f7dee2cbdb73c9f83205027f8533f8)CancelLbl
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CancelLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad63b99df3fd65799c5d682dfdc33c858)ResetLbl
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ResetLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3b7eb460c2f60c63906b38ccc0317131)TypeText
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.TypeText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af6657538f8c314b3bfc8543e23542591)NameText
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad41b73e0fbe3130267ca9f4d91ca9dea)QuantityText
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.QuantityText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a03d08afc109facf2826e1d28d5ea446b)CostText
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CostText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aa5e26efe6f87d3c438b02358b6c3dd05)SearchPlaceholderText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SearchPlaceholderText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af7922bc6c7865cec86f821233c0add02)ProductionTooltip
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ProductionTooltip | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3feab633b94adf6a01d92c4c38688ce9)InventoryCapacityHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.InventoryCapacityHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abbfddf155587e87ff0383108e5c8dbaf)LandCapacityHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.LandCapacityHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a48b5087db5521ad9b7c8d3390f4a31ce)SeaCapacityHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SeaCapacityHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af98f6f4436fab7adc8e483cbba0e9970)TotalWeightCarriedHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.TotalWeightCarriedHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8e8a3fe68c5b99162dde147c17bc1fe3)LandWeightHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.LandWeightHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1f77b9184bce875006e0f2cbd4adef52)SeaWeightHint
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SeaWeightHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aacf8eb8733abdf6e19ebb4e70cde3f04)CurrentCharacterSkillsTooltip
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CurrentCharacterSkillsTooltip | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab785a310a159c98818c0fdd4a7740e1e)NoSaddleHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.NoSaddleHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2db9893115fbf2a0fd197dc73c0c2994)DonationLblHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.DonationLblHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a101660ad8ca13e06a15007850fde57f8)ArmArmorHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ArmArmorHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad981a7888e513d8ae35e44953464d769)BodyArmorHint
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.BodyArmorHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aa11a92058bf5b8aa1239b96ca98dd8d5)HeadArmorHint
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.HeadArmorHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#adcbd284d15c70441d952ec6d4e0025f2)LegArmorHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.LegArmorHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad1314eb2c666b1b489f0a4820f920312)HorseArmorHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.HorseArmorHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a44c2d4ff8014f34f7705ac4438bcf26d)FilterAllHint
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.FilterAllHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a4c0d911ef56ea4368f8e95543fcf1439)FilterWeaponHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.FilterWeaponHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abb87565946a68741b9a292bd85dd4761)FilterArmorHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.FilterArmorHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a84ab70d57818747b21f6142675066d45)FilterShieldAndRangedHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.FilterShieldAndRangedHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0027fade232270488c21e229a37f8ace)FilterMountAndHarnessHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.FilterMountAndHarnessHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ae9a2e988026e68ef87969af862b6ba9a)FilterMiscHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.FilterMiscHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8100a5f051ef40826e6ee6e73d6c1eab)StealthOutfitHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.StealthOutfitHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#add6e632af411da9def6b6f35aa7353b8)CivilianOutfitHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CivilianOutfitHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a65ac55c1270ea20701d948bafc7cb5ac)BattleOutfitHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.BattleOutfitHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a9f9b72b365e6089aa80317ca5401ef1f)EquipmentHelmSlotHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipmentHelmSlotHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af468e9853f80b7173bd352261e6b4ca7)EquipmentArmorSlotHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipmentArmorSlotHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8fe94c2fbf12aa9d9b190c77b964e911)EquipmentBootSlotHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipmentBootSlotHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a6bac0b71d33673198a0538e8c3280752)EquipmentCloakSlotHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipmentCloakSlotHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af9bbdf5355e8316fcc9f86619805c78c)EquipmentGloveSlotHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipmentGloveSlotHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a79f21ce2b2bd38b6c62dc1afc1f70849)EquipmentHarnessSlotHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipmentHarnessSlotHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a37cfa7286d476e1791ea315c0f0512da)EquipmentMountSlotHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipmentMountSlotHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aec70cf0cbf9faffc828604189022043d)EquipmentWeaponSlotHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipmentWeaponSlotHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a277b1d454c4b5d2bd0588905fd16fff4)EquipmentBannerSlotHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipmentBannerSlotHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a7bc2c06b244c517bad3476953f10f664)BuyAllHint
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.BuyAllHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a88b69c19b387e75edd51fb36f68985db)SellAllHint
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SellAllHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a04b76541b62bd4ad58746cdf57503e07)PreviousCharacterHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.PreviousCharacterHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a72e1c985369127e70f95b6d03d94d82c)NextCharacterHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.NextCharacterHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aeb2bf9048c1b36542a6038b20bb9ea34)WeightHint
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.WeightHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a066b642b22bf931a5dfbf6386d0e076b)PreviewHint
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.PreviewHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#acfb32f53ec5e99116b42b969408f6c9d)EquipHint
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a47122b52b7de230bb4b36207f7fb3095)UnequipHint
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.UnequipHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a6d44778f168a2e63f74dacd68954a91b)SellHint
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SellHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a624b64452923aacfa75172daeb9df763)PlayerSideCapacityExceededHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.PlayerSideCapacityExceededHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3eed02357f1999df17625f4010d88d47)MainPartyLandCapacityExceededHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.MainPartyLandCapacityExceededHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2da873e8833cbbc32ea4c1631a913c50)MainPartySeaCapacityExceededHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.MainPartySeaCapacityExceededHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a75bbdb989899f4781c90f765b0480c2d)OtherSideCapacityExceededHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.OtherSideCapacityExceededHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0b18b1eb77392390c2ee62347cee392b)CharacterList
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[InventoryCharacterSelectorItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_character_selector_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2fa9fab6446f1a103506f6c933091b81)PlayerInventorySortController
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPInventorySortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.PlayerInventorySortController | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3cebbba2a396ea7323030ea93180ef33)OtherInventorySortController
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPInventorySortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.OtherInventorySortController | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aae938d786c81f2ec7e98e34ede84b4f9)ItemPreview
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemPreviewVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_preview_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ItemPreview | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a67b7679f691a87def981a280e8f8fe4b)ActiveFilterIndex
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ActiveFilterIndex | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab40e1cdbc01ef51e73ed764890c1b019)CompanionExists
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CompanionExists | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a7a39de0363e5dfbbc0b4c92f1d3b2830)IsTradingWithSettlement
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsTradingWithSettlement | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5d335cfb66a4f89ac95ed7098b1b0e56)EquipmentMode
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipmentMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a03336d96181d6b5b40f3832e8e27087b)IsMicsFilterHighlightEnabled
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsMicsFilterHighlightEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a88f9d1cd51a09b21926f596c3b2fba45)IsEquipmentSetFiltersHighlighted
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsEquipmentSetFiltersHighlighted | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad76944b0c46e155440cc8dbb19328bef)ItemMenu
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemMenuVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ItemMenu | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a141407179de5ca5e4c11e3553b4e6d45)PlayerSideCapacityExceededText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.PlayerSideCapacityExceededText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a599ce6b445e0d733eb8a437e1d13a9bd)MainPartyLandCapacityExceededText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.MainPartyLandCapacityExceededText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1be761286fd00399d623fcb7b69ba244)MainPartySeaCapacityExceededText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.MainPartySeaCapacityExceededText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aeb7cc45079aac299dec32c04da0dbf4d)SeparatorText
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SeparatorText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8cd77f28d6c67790d72b2c9b60ea9291)OtherSideCapacityExceededText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.OtherSideCapacityExceededText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a8960483b50030df4ecb2a2e7f1aafe37)LeftSearchText
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.LeftSearchText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abed442ff3a8873431f6388c3e338ec70)RightSearchText
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.RightSearchText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab04371d61ce6cd7356f028ea51e5723e)HasGainedExperience
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.HasGainedExperience | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af55227e0a93064ce09e540633e743824)IsDonationXpGainExceedsMax
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsDonationXpGainExceedsMax | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af9827d664c13f649cf02fe3a6a71c473)NoSaddleWarned
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.NoSaddleWarned | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a197ced497b41713f6eb21f228afdf9b6)ShowMainPartyLandCapacityTexts
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ShowMainPartyLandCapacityTexts | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a6ee2a8b6c65d4e1ed03b98ed43b046e6)ShowMainPartySeaCapacityTexts
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ShowMainPartySeaCapacityTexts | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aa1ebc6018259001971f509e9e4141461)PlayerEquipmentCountWarned
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.PlayerEquipmentCountWarned | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af6865d70739556f6d61b777355b07d38)IsMainPartyLandCapacityWarned
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsMainPartyLandCapacityWarned | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af4dcb12aa15465ab6cc162cdb3af912b)IsMainPartySeaCapacityWarned
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsMainPartySeaCapacityWarned | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2f8007afb0ad3124b62a9d849adafb33)ShowMainPartyLandCapacityWarning
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ShowMainPartyLandCapacityWarning | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af2c59319b5eb99454742596b4a7d20ee)ShowMainPartySeaCapacityWarning
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ShowMainPartySeaCapacityWarning | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#acbec55ebe6843fb22273d2a2a5d2b437)OtherEquipmentCountWarned
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.OtherEquipmentCountWarned | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab493e346a6da90dda98e05aeb258b2c7)OtherEquipmentCapacityExceededWarning
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.OtherEquipmentCapacityExceededWarning | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af9a0986ae4915c4ad5adce47863ff9bc)OtherEquipmentCountText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.OtherEquipmentCountText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2aee337b5698946a91af0d77ccf6c657)MainPartyTotalWeightCarriedText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.MainPartyTotalWeightCarriedText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a4cdee443bd11f78aeabedd563a449791)MainPartyLandWeightText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.MainPartyLandWeightText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a54cbfd50e87e02c13aa61bbf4a4dabb2)MainPartySeaWeightText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.MainPartySeaWeightText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a31ede5c048d66f4b5d619eedc833544b)MainPartyInventoryCapacityText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.MainPartyInventoryCapacityText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0db7d792c054f470d90ca2db316f0323)MainPartyLandCapacityText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.MainPartyLandCapacityText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#adac61f4ed8a455d96999095f56c55e74)MainPartySeaCapacityText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.MainPartySeaCapacityText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac48274eef8b1738c5509ae8b6d3bb687)NoSaddleText
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.NoSaddleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a4549c4b8f0ebd24679dd84505f2ba728)TargetEquipmentIndex
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.TargetEquipmentIndex | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a85a39b6e89cb625e56c7e907df394955)TargetEquipmentType
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.TargetEquipmentType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aaa400f2b9209ffa591154e505d2228e8)TransactionCount
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.TransactionCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a951b60a4546ad82b2259a88e2431a837)IsTrading
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsTrading | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a19e8527f031dd99cd91040ae13051fe4)EquipAfterBuy
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.EquipAfterBuy | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a2db5ae4c9dea65b60a6b24882481689c)TradeLbl
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.TradeLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aaa12ccb00cbc4cc461cadb0754ad56e7)ExperienceLbl
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ExperienceLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a28a93f61ca5a97d5fe9b7957cc2effa1)CurrentCharacterName
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CurrentCharacterName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1f61f467f144978e54224276d1e196af)RightInventoryOwnerName
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.RightInventoryOwnerName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aea93ff3ee5f17e86a9be9a74987fcb36)LeftInventoryOwnerName
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.LeftInventoryOwnerName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#adeefc9aad44abbc482e7ddf5879187b4)RightInventoryOwnerGold
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.RightInventoryOwnerGold | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a07c59f5621f1cfae96379d7cd41fa06b)LeftInventoryOwnerGold
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.LeftInventoryOwnerGold | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a58cdfe4a4e32f4c6ced6b4d25631ee36)ItemCountToBuy
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ItemCountToBuy | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0bd51fbc315a9c87adeeb3a922c384f7)CurrentCharacterTotalEncumbrance
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CurrentCharacterTotalEncumbrance | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aeff3307d0d4bc2e9d8859d9c7f7a4894)CurrentCharacterLegArmor
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CurrentCharacterLegArmor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#adf5d445dcd00ec85bebce21f11e21890)CurrentCharacterHeadArmor
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CurrentCharacterHeadArmor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#add17b518011ed5b06b5c510c36a79de3)CurrentCharacterBodyArmor
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CurrentCharacterBodyArmor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a81c25d7dc82d5ab80fbe31da761d5737)CurrentCharacterArmArmor
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CurrentCharacterArmArmor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5f75b0839d69deb3a6528fc791b881d2)CurrentCharacterHorseArmor
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CurrentCharacterHorseArmor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3b8e04a0e0e38e0a2961ec32585a5655)IsRefreshed
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsRefreshed | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ad00e0800f520e29ee1d0ea1d8045e3a9)IsExtendedEquipmentControlsEnabled
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsExtendedEquipmentControlsEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a975ba642b4c29614603dee5b40324b91)IsFocusedOnItemList
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsFocusedOnItemList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aeda658be1266c0792de0201f1951a43d)CurrentFocusedItem
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CurrentFocusedItem | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a39874810a1a8c69f58982ffa40c2f31f)CharacterHelmSlot
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterHelmSlot | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3e4b4cfe3fba85b4cf26e43523e737b1)CharacterCloakSlot
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterCloakSlot | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aba1b3c4857f954f684a024c3b0d23dfa)CharacterTorsoSlot
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterTorsoSlot | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5d4cad68a7ee5ad2d80ec6f996184a3e)CharacterGloveSlot
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterGloveSlot | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5c6d9f748f15fd85b5641bd1d4015321)CharacterBootSlot
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterBootSlot | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1d63e77845b9fdce86a09dd2fe1a0ec7)CharacterMountSlot
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterMountSlot | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#afa8d7b67d8d16b01cd54cc0c7cd97ed2)CharacterMountArmorSlot
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterMountArmorSlot | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a727f0a781b55813ced45b7d11bbf2448)CharacterWeapon1Slot
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterWeapon1Slot | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af019031d4c8bcc91560cabcfd12ecdbb)CharacterWeapon2Slot
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterWeapon2Slot | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5a64e86dc15fae839bd79ecc1a2928fd)CharacterWeapon3Slot
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterWeapon3Slot | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aa7f7940bcb1aaaba91b9ebb0a543fe2c)CharacterWeapon4Slot
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterWeapon4Slot | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a34e2c705c1062e89c0c2fad5210763b6)CharacterBannerSlot
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CharacterBannerSlot | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab52928ba8c527dec52e0cb72f7794ae3)MainCharacter
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.MainCharacter | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a0e9a02f42503643730ea483f7db419b4)RightItemListVM
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.RightItemListVM | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#aad4287b7a41b05b27995c30f4077e5d1)LeftItemListVM
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.LeftItemListVM | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a1434319029f09daee987f1f6d33a2d3d)IsBannerItemsHighlightApplied
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsBannerItemsHighlightApplied | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a53c7f3df1cec5c2b8cdb41cc576cee51)BannerTypeName
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.BannerTypeName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a64736fdbe0d30cf456cb4c29f8d858bb)ScrollToItem
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ScrollToItem | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a4a579df8e6b21daf7ed048de92791921)ScrollItemId
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ScrollItemId | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac73e9e30b021699c175a8dd91b6b9967)IsCivilianMode
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsCivilianMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a3d70a29c3d39d9a1cd7e1aa0c24e8c68)IsBattleMode
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsBattleMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a5bb77fd9c22480b7be83ab0fee29b981)IsStealthMode
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.IsStealthMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab1ced1a2d53ebded336a336b1f963813)ResetInputKey
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.ResetInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ab9baad46523493ff8b920aa092fed5eb)CancelInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#afc50de61544af93ce22d2bdcf8d9f670)DoneInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#af9d7ffd86344a064484a3a3211230429)PreviousCharacterInputKey
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.PreviousCharacterInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#a7a41739c67082e26344445c05f6a8d41)NextCharacterInputKey
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.NextCharacterInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#ac287c822b4afd247976608f8b9886daa)BuyAllInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.BuyAllInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_v_m.html#abec15402e247855c5c1294058127b82e)SellAllInputKey
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventoryVM.SellAllInputKey | | getset |


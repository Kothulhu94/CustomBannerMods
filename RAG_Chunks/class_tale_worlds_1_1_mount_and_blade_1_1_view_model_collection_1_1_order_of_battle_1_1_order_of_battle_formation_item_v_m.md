--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) missionCamera) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a0332b11c896bbf4842694796e798543d) () |
|  | Used for updating localized texts. |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a64730491b0cb035ff2d0ce6508f98794) () |
| void | [RefreshFormation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a6236bd1b6e8974184240810be7e1a95b) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ae171443990f0fcbfb6d4b80ef6570014) formation, [DeploymentFormationClass](namespace_tale_worlds_1_1_core.html#a6268398d190769e1f22e3bdaded92652) overriddenClass=DeploymentFormationClass.Unset, bool mustExist=false) |
| void | [MakeMarkerWorldPositionDirty](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a6617815d43d19dcaf44bd4cec538a49f) () |
| void | [OnSizeChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ac6bb7012195b9c19eb4439a54e8828d2) () |
| [DeploymentFormationClass](namespace_tale_worlds_1_1_core.html#a6268398d190769e1f22e3bdaded92652) | [GetOrderOfBattleClass](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a6af5cfce683d1fcf48720d085a20f3cc) () |
| void | [UpdateAdjustable](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a3ca1b42dc3a9c305c6f613c92a128a36) () |
| bool | [HasFilter](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a4721fbea2b6777c8b114a629575d7a35) ([FormationFilterType](namespace_tale_worlds_1_1_core.html#a18e2f46c2749a54afdee287077060ae9) filter) |
| bool | [HasOnlyOneClass](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a595f17f91eded77d33a886b1a1f73032) () |
| bool | [HasClass](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ac0d4829d2857fc9a7db01e77d601bd94) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass) |
| bool | [HasClasses](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a38834912bf2bf1980e2b8d78bc1e9276) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90)[] formationClasses) |
| void | [UnassignCaptain](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#af5beeeb334ff0f5123827b64dcd8f83e) () |
| void | [ExecuteAcceptCaptain](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a3c24c000c96c7c2e7b7a3064d6f26125) () |
| void | [ExecuteAcceptHeroTroops](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#adb58f0af3a247c1fa7e690d4442ee737) () |
| void | [OnHeroSelectionUpdated](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a1e104d51f0d3731afedde3b0d75e671c) (int selectedHeroCount, bool hasOwnHeroTroopInSelection) |
| void | [AddHeroTroop](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a56075b76c114c581be1290bc3a8153a9) ([OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html) heroItem) |
| void | [RemoveHeroTroop](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ae6d030546839d21f5180ea18662bac03) ([OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html) heroItem) |
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
| static Action | [OnHeroesChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#aa76d7be6f2671bcf691e633d72c055c4) |
| static Action< [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c) > | [OnClassSelectionToggled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a597fdb8fbbac43bb4ae21cd8afe7903e) |
| static Action< [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c) > | [OnFilterUseToggled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a145713f84ef33c089ad79f84153d3371) |
| static Action< [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c) > | [OnSelection](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a4bc62378378594d57721b45195c63f2a) |
| static Action< [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c) > | [OnDeselection](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a0456e26c46eee0e9e63d8c6b90c897ed) |
| static Func< [DeploymentFormationClass](namespace_tale_worlds_1_1_core.html#a6268398d190769e1f22e3bdaded92652), [FormationFilterType](namespace_tale_worlds_1_1_core.html#a18e2f46c2749a54afdee287077060ae9), int > | [GetTotalTroopCountWithFilter](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ad30850a5c8cb3ac51246c8a7a8742a20) |
| static Func< Func< [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c), bool >, IEnumerable< [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c) > > | [GetFormationWithCondition](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a876778e66ec85aaddd557baac3941c15) |
| static Func< [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90), bool > | [HasAnyTroopWithClass](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#aa099789e9f045410fdbc878adbe47856) |
| static Action< [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c) > | [OnAcceptCaptain](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a75b14d542219cc6bc56f5ed1161570e5) |
| static Action< [OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c) > | [OnAcceptHeroTroops](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ada84c78bea57350536173f148b33d062) |
| static Action | [OnFormationClassChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a0348521a2c2a842eede3d39259002ea4) |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |

|  |  |
| --- | --- |
| Properties | |
| Formation | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ae171443990f0fcbfb6d4b80ef6570014) `[get]` |
| bool | [IsSelected](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a845b4895e70d3dcd422d605fe2e69b60) `[get, set]` |
| bool | [HasFormation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#af8c5590f810fb03298936b2a630b0781) `[get, set]` |
| bool | [HasCaptain](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a90d837625432e2e6d4be093902974128) `[get, set]` |
| bool | [HasHeroTroops](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a12b9969bf37136e2a6182444f8c5ed90) `[get, set]` |
| bool | [IsControlledByPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a1a5e6c9dd707aa522836c0942f7d9b65) `[get, set]` |
| bool | [IsSelectable](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a7c3a71c28c02e208ca6a2e409b4b73a2) `[get, set]` |
| bool | [IsAdjustable](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#abb0ec591a7c9df5e46607fa41c3a64ce) `[get, set]` |
| bool | [IsMarkerShown](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ae72347fde7d1b6422314214c7da780fc) `[get, set]` |
| bool | [IsBeingFocused](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a1933ad8b00549067afc3b9e44d087bd3) `[get, set]` |
| bool | [IsAcceptingCaptain](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ad99147d91a366fd7b5657de3772c50b1) `[get, set]` |
| bool | [IsAcceptingHeroTroops](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#acb3728721f18845b3c9c7e01cf065a18) `[get, set]` |
| bool | [IsHeroTroopsOverflowing](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a7514d9d382c1c9ee70b5235da56b1788) `[get, set]` |
| bool | [IsClassSelectionActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ada78a31caeb13cd5fab6154e2488f11c) `[get, set]` |
| string | [TitleText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a3f6f11325d24944fdd89c9ceedbd5fa0) `[get, set]` |
| string | [FormationIsEmptyText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a59527b274374de661a95ba2eb12e6dc0) `[get, set]` |
| string | [OverflowHeroTroopCountText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a4c0f99c18ca6056f3b2e7d7414247767) `[get, set]` |
| int | [TroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#af9d1ca3ac815410b339d7c037365bb58) `[get, set]` |
| int | [BannerBearerCount](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#afe6bcfb928e7ff7aee942f55d0729ba0) `[get, set]` |
| int | [OrderOfBattleFormationClassInt](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a6d70abe12c57fb837bfa78a9badeafd9) `[get, set]` |
| int | [WSign](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ab0f93c367b9d1e36d7b1f05f73dc7a0c) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [ScreenPosition](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a1c04805df4a067fe4e8ccade7727e245) `[get, set]` |
| [OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html) | [Captain](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a7769568a0f8217173e8e2d46b4420e33) `[get, set]` |
| MBBindingList< [OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html) > | [HeroTroops](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ad60309c318fed075f476f6068e294815) `[get, set]` |
| MBBindingList< [OrderOfBattleFormationClassVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_class_v_m.html) > | [Classes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ada7c9b2e15a11015a1237fc48fa52bf7) `[get, set]` |
| SelectorVM< [OrderOfBattleFormationClassSelectorItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of8467a81d358898b677c24a60578bf136.html) > | [FormationClassSelector](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a26e7eb4c570c84fdbc2ca3239425735b) `[get, set]` |
| MBBindingList< [OrderOfBattleFormationFilterSelectorItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of8ef3a51edefbafb9bb879c2b1f6490a5.html) > | [FilterItems](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ad2b6ed0cb30617afb467aed2f097d0bd) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [Tooltip](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a8f6729369fef39820a11ab7ac33a9f95) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [BannerBearerTooltip](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a6f4c8fdf4bf7dd647e1ef0a416f9fd80) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [CantAdjustHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a3ea6b8517e97d0e2ccf99289e7b201ae) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [CaptainSlotHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ae47f4f66a6f04a9ae53d4bbe54c95a0e) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [HeroTroopSlotHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a79a27d963812af53ba03f2459371a95e) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [AssignCaptainHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#acb3195968766e82b7beebfe9bf9d4197) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [AssignHeroTroopHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#aa07fdf27ed4e05ca4278863d349a5f5e) `[get, set]` |
| bool | [IsCaptainSlotHighlightActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#af5f51d629a85662a6d4211671c7f6fe8) `[get, set]` |
| bool | [IsTypeSelectionHighlightActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#adab2357f6a871c0c82cb3ed843a42799) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c)OrderOfBattleFormationItemVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OrderOfBattleFormationItemVM | ( | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *missionCamera* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a0332b11c896bbf4842694796e798543d)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a64730491b0cb035ff2d0ce6508f98794)Tick()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.Tick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a6236bd1b6e8974184240810be7e1a95b)RefreshFormation()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.RefreshFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ae171443990f0fcbfb6d4b80ef6570014) | *formation*, |
|  |  | [DeploymentFormationClass](namespace_tale_worlds_1_1_core.html#a6268398d190769e1f22e3bdaded92652) | *overriddenClass* = DeploymentFormationClass::Unset, |
|  |  | bool | *mustExist* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a6617815d43d19dcaf44bd4cec538a49f)MakeMarkerWorldPositionDirty()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.MakeMarkerWorldPositionDirty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ac6bb7012195b9c19eb4439a54e8828d2)OnSizeChanged()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OnSizeChanged | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a6af5cfce683d1fcf48720d085a20f3cc)GetOrderOfBattleClass()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [DeploymentFormationClass](namespace_tale_worlds_1_1_core.html#a6268398d190769e1f22e3bdaded92652) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.GetOrderOfBattleClass | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a3ca1b42dc3a9c305c6f613c92a128a36)UpdateAdjustable()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.UpdateAdjustable | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a4721fbea2b6777c8b114a629575d7a35)HasFilter()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.HasFilter | ( | [FormationFilterType](namespace_tale_worlds_1_1_core.html#a18e2f46c2749a54afdee287077060ae9) | *filter* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a595f17f91eded77d33a886b1a1f73032)HasOnlyOneClass()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.HasOnlyOneClass | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ac0d4829d2857fc9a7db01e77d601bd94)HasClass()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.HasClass | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a38834912bf2bf1980e2b8d78bc1e9276)HasClasses()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.HasClasses | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90)[] | *formationClasses* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#af5beeeb334ff0f5123827b64dcd8f83e)UnassignCaptain()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.UnassignCaptain | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a3c24c000c96c7c2e7b7a3064d6f26125)ExecuteAcceptCaptain()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.ExecuteAcceptCaptain | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#adb58f0af3a247c1fa7e690d4442ee737)ExecuteAcceptHeroTroops()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.ExecuteAcceptHeroTroops | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a1e104d51f0d3731afedde3b0d75e671c)OnHeroSelectionUpdated()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OnHeroSelectionUpdated | ( | int | *selectedHeroCount*, |
|  |  | bool | *hasOwnHeroTroopInSelection* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a56075b76c114c581be1290bc3a8153a9)AddHeroTroop()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.AddHeroTroop | ( | [OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html) | *heroItem* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ae6d030546839d21f5180ea18662bac03)RemoveHeroTroop()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.RemoveHeroTroop | ( | [OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html) | *heroItem* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#aa76d7be6f2671bcf691e633d72c055c4)OnHeroesChanged
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OnHeroesChanged | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a597fdb8fbbac43bb4ae21cd8afe7903e)OnClassSelectionToggled
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OnClassSelectionToggled | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a145713f84ef33c089ad79f84153d3371)OnFilterUseToggled
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OnFilterUseToggled | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a4bc62378378594d57721b45195c63f2a)OnSelection
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OnSelection | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a0456e26c46eee0e9e63d8c6b90c897ed)OnDeselection
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OnDeselection | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ad30850a5c8cb3ac51246c8a7a8742a20)GetTotalTroopCountWithFilter
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<[DeploymentFormationClass](namespace_tale_worlds_1_1_core.html#a6268398d190769e1f22e3bdaded92652), [FormationFilterType](namespace_tale_worlds_1_1_core.html#a18e2f46c2749a54afdee287077060ae9), int> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.GetTotalTroopCountWithFilter | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a876778e66ec85aaddd557baac3941c15)GetFormationWithCondition
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<Func<[OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c), bool>, IEnumerable<[OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c)> > TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.GetFormationWithCondition | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#aa099789e9f045410fdbc878adbe47856)HasAnyTroopWithClass
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<[FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90), bool> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.HasAnyTroopWithClass | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a75b14d542219cc6bc56f5ed1161570e5)OnAcceptCaptain
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OnAcceptCaptain | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ada84c78bea57350536173f148b33d062)OnAcceptHeroTroops
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[OrderOfBattleFormationItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a5f71256b4c66dbf010d5dd2009eb0d2c)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OnAcceptHeroTroops | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a0348521a2c2a842eede3d39259002ea4)OnFormationClassChanged
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OnFormationClassChanged | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ae171443990f0fcbfb6d4b80ef6570014)Formation
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Formation TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.Formation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a845b4895e70d3dcd422d605fe2e69b60)IsSelected
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#af8c5590f810fb03298936b2a630b0781)HasFormation
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.HasFormation | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a90d837625432e2e6d4be093902974128)HasCaptain
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.HasCaptain | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a12b9969bf37136e2a6182444f8c5ed90)HasHeroTroops
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.HasHeroTroops | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a1a5e6c9dd707aa522836c0942f7d9b65)IsControlledByPlayer
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.IsControlledByPlayer | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a7c3a71c28c02e208ca6a2e409b4b73a2)IsSelectable
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.IsSelectable | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#abb0ec591a7c9df5e46607fa41c3a64ce)IsAdjustable
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.IsAdjustable | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ae72347fde7d1b6422314214c7da780fc)IsMarkerShown
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.IsMarkerShown | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a1933ad8b00549067afc3b9e44d087bd3)IsBeingFocused
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.IsBeingFocused | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ad99147d91a366fd7b5657de3772c50b1)IsAcceptingCaptain
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.IsAcceptingCaptain | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#acb3728721f18845b3c9c7e01cf065a18)IsAcceptingHeroTroops
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.IsAcceptingHeroTroops | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a7514d9d382c1c9ee70b5235da56b1788)IsHeroTroopsOverflowing
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.IsHeroTroopsOverflowing | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ada78a31caeb13cd5fab6154e2488f11c)IsClassSelectionActive
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.IsClassSelectionActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a3f6f11325d24944fdd89c9ceedbd5fa0)TitleText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.TitleText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a59527b274374de661a95ba2eb12e6dc0)FormationIsEmptyText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.FormationIsEmptyText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a4c0f99c18ca6056f3b2e7d7414247767)OverflowHeroTroopCountText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OverflowHeroTroopCountText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#af9d1ca3ac815410b339d7c037365bb58)TroopCount
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.TroopCount | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#afe6bcfb928e7ff7aee942f55d0729ba0)BannerBearerCount
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.BannerBearerCount | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a6d70abe12c57fb837bfa78a9badeafd9)OrderOfBattleFormationClassInt
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.OrderOfBattleFormationClassInt | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ab0f93c367b9d1e36d7b1f05f73dc7a0c)WSign
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.WSign | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a1c04805df4a067fe4e8ccade7727e245)ScreenPosition
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.ScreenPosition | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a7769568a0f8217173e8e2d46b4420e33)Captain
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.Captain | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ad60309c318fed075f476f6068e294815)HeroTroops
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[OrderOfBattleHeroItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_hero_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.HeroTroops | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ada7c9b2e15a11015a1237fc48fa52bf7)Classes
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[OrderOfBattleFormationClassVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_class_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.Classes | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a26e7eb4c570c84fdbc2ca3239425735b)FormationClassSelector
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[OrderOfBattleFormationClassSelectorItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of8467a81d358898b677c24a60578bf136.html)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.FormationClassSelector | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ad2b6ed0cb30617afb467aed2f097d0bd)FilterItems
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[OrderOfBattleFormationFilterSelectorItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of8ef3a51edefbafb9bb879c2b1f6490a5.html)> TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.FilterItems | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a8f6729369fef39820a11ab7ac33a9f95)Tooltip
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.Tooltip | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a6f4c8fdf4bf7dd647e1ef0a416f9fd80)BannerBearerTooltip
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.BannerBearerTooltip | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a3ea6b8517e97d0e2ccf99289e7b201ae)CantAdjustHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.CantAdjustHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#ae47f4f66a6f04a9ae53d4bbe54c95a0e)CaptainSlotHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.CaptainSlotHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#a79a27d963812af53ba03f2459371a95e)HeroTroopSlotHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.HeroTroopSlotHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#acb3195968766e82b7beebfe9bf9d4197)AssignCaptainHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.AssignCaptainHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#aa07fdf27ed4e05ca4278863d349a5f5e)AssignHeroTroopHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.AssignHeroTroopHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#af5f51d629a85662a6d4211671c7f6fe8)IsCaptainSlotHighlightActive
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.IsCaptainSlotHighlightActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_of_battle_1_1_order_of_battle_formation_item_v_m.html#adab2357f6a871c0c82cb3ed843a42799)IsTypeSelectionHighlightActive
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.OrderOfBattle.OrderOfBattleFormationItemVM.IsTypeSelectionHighlightActive | | getset |


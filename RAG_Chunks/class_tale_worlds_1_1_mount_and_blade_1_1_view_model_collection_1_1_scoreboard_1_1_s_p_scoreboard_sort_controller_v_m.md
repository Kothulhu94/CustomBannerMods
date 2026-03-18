--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Classes | |
| class | [ScoreboardUnitItemComparerBase](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboar265e72083ac1fcc853456154b202c96e.html) |
| class | [ItemRemainingComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboar9d24fd49aa7126f8e08909c2b910e402.html) |
| class | [ItemKillComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboar2538db4f2306f52c61af8d9e81d32fa4.html) |
| class | [ItemUpgradeComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboar7aec525772b2c35e77e886e16fa76023.html) |
| class | [ItemDeadComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboar044282b4957f56c8b6adcaa791e367ea.html) |
| class | [ItemWoundedComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboar8057b61031e8ec0a4415d2c5dbec90d4.html) |
| class | [ItemRoutedComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboare8debd1713de2f02e827cf92f0126587.html) |
| class | [ItemMemberComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboar7ef3ad64ec3cc1a2c60ec8c3fdbb2fdc.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SPScoreboardSortControllerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#ac22ea810aa44ae6cca8c1310818ad6d7) (ref MBBindingList< [SPScoreboardPartyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_party_v_m.html) > listToControl) |
| void | [ExecuteSortByRemaining](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a9987cf0e06a41f22853be8c79c2f88c0) () |
| void | [ExecuteSortByKill](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a093cf2e927bd6333e25400e30cfc6243) () |
| void | [ExecuteSortByUpgrade](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a65b97138ce159a598d28d231db3be9e1) () |
| void | [ExecuteSortByDead](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a9abdba6b883b5d5daf9b0a236424f902) () |
| void | [ExecuteSortByWounded](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#ae78bc9ee926ea8873f8f7f2e16578047) () |
| void | [ExecuteSortByRouted](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a5364fe1082c90a6fb495f31c0d8195bc) () |
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
| virtual void | [RefreshValues](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd) () |
|  | Used for updating localized texts. |

|  |  |
| --- | --- |
| Properties | |
| int | [RemainingState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a23ece62ccbf83b4969758fb3c7ae1463) `[get, set]` |
| bool | [IsRemainingSelected](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#af30da369a3379c4f9293c0848ef459da) `[get, set]` |
| int | [KillState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a067eaca87fe0c48b250d751994803f4f) `[get, set]` |
| bool | [IsKillSelected](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#ab6abcd1c82b54a33921ac6642b9bfb42) `[get, set]` |
| int | [UpgradeState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a516bebaeb873045a205978a1d2b91534) `[get, set]` |
| bool | [IsUpgradeSelected](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a977b53c41ca490db33d3698ddb13528e) `[get, set]` |
| int | [DeadState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#ab8b862271cfdf8105932fab28853fd8e) `[get, set]` |
| bool | [IsDeadSelected](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a308608967ee0a7211651e4b8229c4d25) `[get, set]` |
| int | [WoundedState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a4d59e59160961fc66e6e3de279b58580) `[get, set]` |
| bool | [IsWoundedSelected](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a247ac69f040cab35c0304c3e2fb64c7d) `[get, set]` |
| int | [RoutedState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a38a04ca2fce9ecea0a9fbd09bb3a147d) `[get, set]` |
| bool | [IsRoutedSelected](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#aa9a9074925214d42569f46eb0d67a177) `[get, set]` |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#ac22ea810aa44ae6cca8c1310818ad6d7)SPScoreboardSortControllerVM()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.SPScoreboardSortControllerVM | ( | ref MBBindingList< [SPScoreboardPartyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_party_v_m.html) > | *listToControl* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a9987cf0e06a41f22853be8c79c2f88c0)ExecuteSortByRemaining()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.ExecuteSortByRemaining | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a093cf2e927bd6333e25400e30cfc6243)ExecuteSortByKill()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.ExecuteSortByKill | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a65b97138ce159a598d28d231db3be9e1)ExecuteSortByUpgrade()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.ExecuteSortByUpgrade | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a9abdba6b883b5d5daf9b0a236424f902)ExecuteSortByDead()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.ExecuteSortByDead | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#ae78bc9ee926ea8873f8f7f2e16578047)ExecuteSortByWounded()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.ExecuteSortByWounded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a5364fe1082c90a6fb495f31c0d8195bc)ExecuteSortByRouted()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.ExecuteSortByRouted | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a23ece62ccbf83b4969758fb3c7ae1463)RemainingState
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.RemainingState | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#af30da369a3379c4f9293c0848ef459da)IsRemainingSelected
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.IsRemainingSelected | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a067eaca87fe0c48b250d751994803f4f)KillState
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.KillState | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#ab6abcd1c82b54a33921ac6642b9bfb42)IsKillSelected
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.IsKillSelected | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a516bebaeb873045a205978a1d2b91534)UpgradeState
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.UpgradeState | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a977b53c41ca490db33d3698ddb13528e)IsUpgradeSelected
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.IsUpgradeSelected | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#ab8b862271cfdf8105932fab28853fd8e)DeadState
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.DeadState | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a308608967ee0a7211651e4b8229c4d25)IsDeadSelected
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.IsDeadSelected | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a4d59e59160961fc66e6e3de279b58580)WoundedState
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.WoundedState | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a247ac69f040cab35c0304c3e2fb64c7d)IsWoundedSelected
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.IsWoundedSelected | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#a38a04ca2fce9ecea0a9fbd09bb3a147d)RoutedState
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.RoutedState | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_sort_controller_v_m.html#aa9a9074925214d42569f46eb0d67a177)IsRoutedSelected
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.SPScoreboardSortControllerVM.IsRoutedSelected | | getset |


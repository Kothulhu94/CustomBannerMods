--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionSpectatorControlVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a496d7a0b37943ee90c8ae3bacf6b73c8) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a4c246854cdf7fdd13902a2a22d1b6c1d) () |
|  | Used for updating localized texts. |
| void | [OnSpectatedAgentFocusIn](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a4c1d25b95440b68cf232ef635b2180dc) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) followedAgent) |
| void | [OnSpectatedAgentFocusOut](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a75189ee398d61ba36c90add6e847d370) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) followedAgent) |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#ae14c5444511dd00770a0c3b260d417d2) () |
| void | [SetMainAgentStatus](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a99da8a5ee1cf99f87e48c4e9c5a500b4) (bool isDead) |
| void | [SetPrevCharacterInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#ab1fdb26eab59ade5ce23bc75aea8b01a) ([GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) gameKey) |
| void | [SetNextCharacterInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a3571d86c76908f288e09ede5cef86e21) ([GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) gameKey) |
| void | [SetTakeControlInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a247a1f15598e68d62efb67ea92f5df04) ([GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) gameKey) |
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
| bool | [IsEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a60c267e1153a378e9a73cf3f8dc49c9c) `[get, set]` |
| string | [PrevCharacterText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#ae1dc0f48f53263736dbe58943a7c9fca) `[get, set]` |
| string | [NextCharacterText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a013b55557a189e1098aa23bf0cc356b6) `[get, set]` |
| string | [TakeControlText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a459d32575130087f5755c562585a0fb3) `[get, set]` |
| string | [StatusText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a3c9126f666356320ccd16b267fcbf394) `[get, set]` |
| bool | [IsTakeControlRelevant](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a660f6730a31729c0c0f8fc18ba141618) `[get, set]` |
| bool | [IsTakeControlEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a87c6ea4a7fc8d86562de2441f1555593) `[get, set]` |
| string | [SpectatedAgentName](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a10b2473ba3598ede2c807eb49c2ffb2b) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [PrevCharacterKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a6d2f307da517c8b2d364acfddfcb74bd) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [NextCharacterKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a357936616c51c44b16b211868b51f223) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [TakeControlKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#ab352e5ea92f2d23adba39a0da09f5209) `[get, set]` |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a496d7a0b37943ee90c8ae3bacf6b73c8)MissionSpectatorControlVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.MissionSpectatorControlVM | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a4c246854cdf7fdd13902a2a22d1b6c1d)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a4c1d25b95440b68cf232ef635b2180dc)OnSpectatedAgentFocusIn()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.OnSpectatedAgentFocusIn | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *followedAgent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a75189ee398d61ba36c90add6e847d370)OnSpectatedAgentFocusOut()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.OnSpectatedAgentFocusOut | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *followedAgent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#ae14c5444511dd00770a0c3b260d417d2)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a99da8a5ee1cf99f87e48c4e9c5a500b4)SetMainAgentStatus()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.SetMainAgentStatus | ( | bool | *isDead* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#ab1fdb26eab59ade5ce23bc75aea8b01a)SetPrevCharacterInputKey()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.SetPrevCharacterInputKey | ( | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *gameKey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a3571d86c76908f288e09ede5cef86e21)SetNextCharacterInputKey()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.SetNextCharacterInputKey | ( | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *gameKey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a247a1f15598e68d62efb67ea92f5df04)SetTakeControlInputKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.SetTakeControlInputKey | ( | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *gameKey* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a60c267e1153a378e9a73cf3f8dc49c9c)IsEnabled
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.IsEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#ae1dc0f48f53263736dbe58943a7c9fca)PrevCharacterText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.PrevCharacterText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a013b55557a189e1098aa23bf0cc356b6)NextCharacterText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.NextCharacterText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a459d32575130087f5755c562585a0fb3)TakeControlText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.TakeControlText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a3c9126f666356320ccd16b267fcbf394)StatusText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.StatusText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a660f6730a31729c0c0f8fc18ba141618)IsTakeControlRelevant
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.IsTakeControlRelevant | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a87c6ea4a7fc8d86562de2441f1555593)IsTakeControlEnabled
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.IsTakeControlEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a10b2473ba3598ede2c807eb49c2ffb2b)SpectatedAgentName
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.SpectatedAgentName | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a6d2f307da517c8b2d364acfddfcb74bd)PrevCharacterKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.PrevCharacterKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#a357936616c51c44b16b211868b51f223)NextCharacterKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.NextCharacterKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_spectator_control_v_m.html#ab352e5ea92f2d23adba39a0da09f5209)TakeControlKey
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionSpectatorControlVM.TakeControlKey | | getset |


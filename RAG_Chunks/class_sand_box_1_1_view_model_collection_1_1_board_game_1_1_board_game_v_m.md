--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html ---

SandBox.ViewModelCollection.BoardGame.BoardGameVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BoardGameVM](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a9343e543c19df2ffda0a034ac85154ad) () |
| override void | [RefreshValues](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#af2407635ff3c9bf610d7e9413128285e) () |
|  | Used for updating localized texts. |
| void | [Activate](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a73d3f86dc0914c27631ef48014bfd3a1) () |
| void | [DiceRoll](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a234e535d505ad44977fab23332ea8dbc) (int roll) |
| void | [SwitchTurns](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a0f0b437df5552a6c8c40ff14f2cc1ae8) () |
| void | [ExecuteRoll](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#ab1e98edd558896b8eb2976bda03cf898) () |
| void | [ExecuteForfeit](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a9887b1b273283db97bef7255087f2854) () |
| override void | [OnFinalize](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#aee23285ee682410c387041dfb2050060) () |
| void | [SetRollDiceKey](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#ae2b639026bb5f9af9d2d9d43dfb4769e) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) key) |
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
| [BoardGameInstructionsVM](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_instructions_v_m.html) | [Instructions](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a6c9d8334c67d456a4240f7af0c9a85d4) `[get, set]` |
| bool | [CanRoll](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a7ca5bbd9bb5f0df07ef0a8709722f1d5) `[get, set]` |
| bool | [IsPlayersTurn](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#af7fef79eae3c5fe6bad5085c28f62adf) `[get, set]` |
| bool | [IsGameUsingDice](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a4faa4412f3884001beef50a0afc49821) `[get, set]` |
| string | [DiceResult](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a8b212eece643b2b2a67c39025473231e) `[get, set]` |
| string | [RollDiceText](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a54c458d8adcb98a2f8d8338a52fa751b) `[get, set]` |
| string | [TurnOwnerText](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#ad0168db40fea0204a5b718cb64ed5f96) `[get, set]` |
| string | [BoardGameType](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a4135ef73b62abd2704c1aabcbfee84b3) `[get, set]` |
| string | [CloseText](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a83cc0c299d204bc5e65d5bd7442ac738) `[get, set]` |
| string | [ForfeitText](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a2960bb85b7f85197cdc48731eaa7265d) `[get, set]` |
| [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [RollDiceKey](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a46b1df9f29e84089c81b7c8358d8b49e) `[get, set]` |

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

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a9343e543c19df2ffda0a034ac85154ad)BoardGameVM()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.ViewModelCollection.BoardGame.BoardGameVM.BoardGameVM | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#af2407635ff3c9bf610d7e9413128285e)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.BoardGame.BoardGameVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a73d3f86dc0914c27631ef48014bfd3a1)Activate()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.BoardGame.BoardGameVM.Activate | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a234e535d505ad44977fab23332ea8dbc)DiceRoll()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.BoardGame.BoardGameVM.DiceRoll | ( | int | *roll* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a0f0b437df5552a6c8c40ff14f2cc1ae8)SwitchTurns()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.BoardGame.BoardGameVM.SwitchTurns | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#ab1e98edd558896b8eb2976bda03cf898)ExecuteRoll()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.BoardGame.BoardGameVM.ExecuteRoll | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a9887b1b273283db97bef7255087f2854)ExecuteForfeit()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.BoardGame.BoardGameVM.ExecuteForfeit | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#aee23285ee682410c387041dfb2050060)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.BoardGame.BoardGameVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#ae2b639026bb5f9af9d2d9d43dfb4769e)SetRollDiceKey()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.BoardGame.BoardGameVM.SetRollDiceKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *key* | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a6c9d8334c67d456a4240f7af0c9a85d4)Instructions
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BoardGameInstructionsVM](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_instructions_v_m.html) SandBox.ViewModelCollection.BoardGame.BoardGameVM.Instructions | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a7ca5bbd9bb5f0df07ef0a8709722f1d5)CanRoll
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.BoardGame.BoardGameVM.CanRoll | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#af7fef79eae3c5fe6bad5085c28f62adf)IsPlayersTurn
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.BoardGame.BoardGameVM.IsPlayersTurn | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a4faa4412f3884001beef50a0afc49821)IsGameUsingDice
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.BoardGame.BoardGameVM.IsGameUsingDice | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a8b212eece643b2b2a67c39025473231e)DiceResult
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.BoardGame.BoardGameVM.DiceResult | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a54c458d8adcb98a2f8d8338a52fa751b)RollDiceText
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.BoardGame.BoardGameVM.RollDiceText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#ad0168db40fea0204a5b718cb64ed5f96)TurnOwnerText
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.BoardGame.BoardGameVM.TurnOwnerText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a4135ef73b62abd2704c1aabcbfee84b3)BoardGameType
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.BoardGame.BoardGameVM.BoardGameType | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a83cc0c299d204bc5e65d5bd7442ac738)CloseText
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.BoardGame.BoardGameVM.CloseText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a2960bb85b7f85197cdc48731eaa7265d)ForfeitText
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.BoardGame.BoardGameVM.ForfeitText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_board_game_1_1_board_game_v_m.html#a46b1df9f29e84089c81b7c8358d8b49e)RollDiceKey
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) SandBox.ViewModelCollection.BoardGame.BoardGameVM.RollDiceKey | | getset |


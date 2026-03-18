--- SOURCE: class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html ---

TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html), and [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html).

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuTooltipPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_tooltip_property_v_m.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) {     [None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [MultiLine](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4ad16a748b5543974384bc43d392f1e566) = 1 ,     [BattleMode](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4ac475c43d7a43c34d04d376d88015156d) = 2 ,     [BattleModeOver](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a082c8c604a13ac78a5dddabcbd6c30b1) = 4 ,     [WarFirstEnemy](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a9e5a004cf5f49b1695846aa885e53e31) = 8 ,     [WarFirstAlly](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4aca810c6f222bb31060c8cf3997cfaefd) = 16 ,     [WarFirstNeutral](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4ad53b60786e1c9aa3044fc8e4e15573fb) = 32 ,     [WarSecondEnemy](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a969580dfca250d4e453310f90a1b45c8) = 64 ,     [WarSecondAlly](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4ab9abf9001b152891c1ebe6cfe9f50e68) = 128 ,     [WarSecondNeutral](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a45c469f0ee19bd051162f0a4ab97615c) = 256 ,     [RundownSeperator](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a83e28dcc905d4c1a9d4695e3859db8f5) = 512 ,     [DefaultSeperator](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a01ef527573815ad9ba1184c7d8c0fe7b) = 1024 ,     [Cost](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a20b4f77bd00b4f63a49ec8e08f3bf6a6) = 2048 ,     [Title](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4ab78a3223503896721cca1303f776159b) = 4096 ,     [RundownResult](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a8e8d9ad6d843a6a40232a6e3180f4163) = 8192   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a57d162ba5c5f738ed61232cc9adab7d7) () |
| void | [RefreshValue](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a2589e1c918910ae8307032f6019086bb) () |
| void | [RefreshDefinition](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a555983802156445157164fac8c67ce72) () |
|  | [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#ad2cd560387fef2500b2dc0040428db16) (string definition, string value, int textHeight, bool onlyShowWhenExtended=false, [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) modifier=[TooltipPropertyFlags.None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754)) |
|  | [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#ac109acd308d33b0082015da7e78d7e57) (string definition, Func< string > \_valueFunc, int textHeight, bool onlyShowWhenExtended=false, [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) modifier=[TooltipPropertyFlags.None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754)) |
|  | [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a558e9376cbe4d5856431fd7d43791661) (Func< string > \_definitionFunc, Func< string > \_valueFunc, int textHeight, bool onlyShowWhenExtended=false, [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) modifier=[TooltipPropertyFlags.None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754)) |
|  | [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#ad72d108a670e369a721453f83cb56702) (Func< string > \_definitionFunc, Func< string > \_valueFunc, object[] valueArgs, int textHeight, bool onlyShowWhenExtended=false, [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) modifier=[TooltipPropertyFlags.None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754)) |
|  | [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a58feee22dfc61b56c56c607f7ef1b28e) (string definition, string value, int textHeight, [Color](struct_tale_worlds_1_1_library_1_1_color.html) color, bool onlyShowWhenExtended=false, [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) modifier=[TooltipPropertyFlags.None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754)) |
|  | [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a82e957004cfe0aedba02ffe660f91417) (string definition, Func< string > \_valueFunc, int textHeight, [Color](struct_tale_worlds_1_1_library_1_1_color.html) color, bool onlyShowWhenExtended=false, [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) modifier=[TooltipPropertyFlags.None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754)) |
|  | [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#ac7cbe2fd26d8f56d10f27f3c7f407402) (Func< string > \_definitionFunc, Func< string > \_valueFunc, int textHeight, [Color](struct_tale_worlds_1_1_library_1_1_color.html) color, bool onlyShowWhenExtended=false, [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) modifier=[TooltipPropertyFlags.None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754)) |
|  | [TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a4bbb7dd5ca9f371804ac1835e9c3ac4d) (TooltipProperty property) |
| void | [DeserializeFrom](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a128b5366a2a10a739cc5be09cc451632) ([IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) reader) |
| void | [SerializeTo](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a3b9c20747f0ce59139df567e94b0ccf4) ([IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) writer) |
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
| bool | [OnlyShowWhenExtended](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a5d61aa75689f6fd4b21e5dc9d5fee7cf) = false `[get, set]` |
|  | This is for using Alt(Extend) behavior for Custom Tooltips. Should not be used for anything else. |
| bool | [OnlyShowWhenNotExtended](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a853a8fa359cd2838829b8cb3d0cb5a7e) = false `[get, set]` |
|  | This is for using Alt(Extend) behavior for Custom Tooltips. Should not be used for anything else. |
| int | [TextHeight](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa9b217655d28ebe08ef93ef2a18a2e9a) `[get, set]` |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [TextColor](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a400d62425e12ba02a32f4db60cf769df) `[get, set]` |
| string | [DefinitionLabel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#af63aabfc48ce0e05b1ac71d0b56ddea9) `[get, set]` |
| string | [ValueLabel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a37fd879414cbd7aceeac7f9d6cfb8b51) `[get, set]` |
| int | [PropertyModifier](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#af4837cdec2d453f0eebe7eb0da87ca7c) `[get, set]` |

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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4)TooltipPropertyFlags
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) |

| Enumerator | |
| --- | --- |
| None |  |
| MultiLine |  |
| BattleMode |  |
| BattleModeOver |  |
| WarFirstEnemy |  |
| WarFirstAlly |  |
| WarFirstNeutral |  |
| WarSecondEnemy |  |
| WarSecondAlly |  |
| WarSecondNeutral |  |
| RundownSeperator |  |
| DefaultSeperator |  |
| Cost |  |
| Title |  |
| RundownResult |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a57d162ba5c5f738ed61232cc9adab7d7)TooltipProperty() [1/9]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.TooltipProperty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#ad2cd560387fef2500b2dc0040428db16)TooltipProperty() [2/9]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.TooltipProperty | ( | string | *definition*, |
|  |  | string | *value*, |
|  |  | int | *textHeight*, |
|  |  | bool | *onlyShowWhenExtended* = false, |
|  |  | [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) | *modifier* = [TooltipPropertyFlags::None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754) ) |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#ac109acd308d33b0082015da7e78d7e57)TooltipProperty() [3/9]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.TooltipProperty | ( | string | *definition*, |
|  |  | Func< string > | *\_valueFunc*, |
|  |  | int | *textHeight*, |
|  |  | bool | *onlyShowWhenExtended* = false, |
|  |  | [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) | *modifier* = [TooltipPropertyFlags::None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754) ) |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a558e9376cbe4d5856431fd7d43791661)TooltipProperty() [4/9]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.TooltipProperty | ( | Func< string > | *\_definitionFunc*, |
|  |  | Func< string > | *\_valueFunc*, |
|  |  | int | *textHeight*, |
|  |  | bool | *onlyShowWhenExtended* = false, |
|  |  | [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) | *modifier* = [TooltipPropertyFlags::None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754) ) |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#ad72d108a670e369a721453f83cb56702)TooltipProperty() [5/9]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.TooltipProperty | ( | Func< string > | *\_definitionFunc*, |
|  |  | Func< string > | *\_valueFunc*, |
|  |  | object[] | *valueArgs*, |
|  |  | int | *textHeight*, |
|  |  | bool | *onlyShowWhenExtended* = false, |
|  |  | [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) | *modifier* = [TooltipPropertyFlags::None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754) ) |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a58feee22dfc61b56c56c607f7ef1b28e)TooltipProperty() [6/9]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.TooltipProperty | ( | string | *definition*, |
|  |  | string | *value*, |
|  |  | int | *textHeight*, |
|  |  | [Color](struct_tale_worlds_1_1_library_1_1_color.html) | *color*, |
|  |  | bool | *onlyShowWhenExtended* = false, |
|  |  | [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) | *modifier* = [TooltipPropertyFlags::None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754) ) |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a82e957004cfe0aedba02ffe660f91417)TooltipProperty() [7/9]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.TooltipProperty | ( | string | *definition*, |
|  |  | Func< string > | *\_valueFunc*, |
|  |  | int | *textHeight*, |
|  |  | [Color](struct_tale_worlds_1_1_library_1_1_color.html) | *color*, |
|  |  | bool | *onlyShowWhenExtended* = false, |
|  |  | [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) | *modifier* = [TooltipPropertyFlags::None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754) ) |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#ac7cbe2fd26d8f56d10f27f3c7f407402)TooltipProperty() [8/9]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.TooltipProperty | ( | Func< string > | *\_definitionFunc*, |
|  |  | Func< string > | *\_valueFunc*, |
|  |  | int | *textHeight*, |
|  |  | [Color](struct_tale_worlds_1_1_library_1_1_color.html) | *color*, |
|  |  | bool | *onlyShowWhenExtended* = false, |
|  |  | [TooltipPropertyFlags](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4) | *modifier* = [TooltipPropertyFlags::None](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa8ce6345e9346dbb34bea7b6cc66c9c4a6adf97f83acf6453d4a6a4b1070f3754) ) |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a4bbb7dd5ca9f371804ac1835e9c3ac4d)TooltipProperty() [9/9]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.TooltipProperty | ( | TooltipProperty | *property* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a2589e1c918910ae8307032f6019086bb)RefreshValue()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.RefreshValue | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a555983802156445157164fac8c67ce72)RefreshDefinition()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.RefreshDefinition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a128b5366a2a10a739cc5be09cc451632)DeserializeFrom()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.DeserializeFrom | ( | [IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) | *reader* | ) |  |

Implements [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aaaf5181fea51c7c2d4e365efe82bc703).

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a3b9c20747f0ce59139df567e94b0ccf4)SerializeTo()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.SerializeTo | ( | [IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) | *writer* | ) |  |

Implements [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aac913af86c2a4128993048fc2023b4de).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a5d61aa75689f6fd4b21e5dc9d5fee7cf)OnlyShowWhenExtended
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.OnlyShowWhenExtended = false | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a853a8fa359cd2838829b8cb3d0cb5a7e)OnlyShowWhenNotExtended
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.OnlyShowWhenNotExtended = false | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#aa9b217655d28ebe08ef93ef2a18a2e9a)TextHeight
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.TextHeight | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a400d62425e12ba02a32f4db60cf769df)TextColor
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.TextColor | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#af63aabfc48ce0e05b1ac71d0b56ddea9)DefinitionLabel
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.DefinitionLabel | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a37fd879414cbd7aceeac7f9d6cfb8b51)ValueLabel
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.ValueLabel | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#af4837cdec2d453f0eebe7eb0da87ca7c)PropertyModifier
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty.PropertyModifier | | getset |


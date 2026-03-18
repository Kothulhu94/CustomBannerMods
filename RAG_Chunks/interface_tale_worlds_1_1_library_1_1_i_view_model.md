--- SOURCE: interface_tale_worlds_1_1_library_1_1_i_view_model.html ---

TaleWorlds.Library.IViewModel Interface ReferenceInherits INotifyPropertyChanged.

Inherited by [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| object | [GetViewModelAtPath](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ab434fefac00af7681a2d57d1ab4cf01e) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) path) |
| object | [GetViewModelAtPath](interface_tale_worlds_1_1_library_1_1_i_view_model.html#af655c7a786420b88b81670118f40b707) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) path, bool isList) |
| object | [GetPropertyValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#adb1d894a6f455dbfc4d41e127f4cec60) (string name) |
| object | [GetPropertyValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a63c2a57f3432062408141f83434d1caf) (string name, [PropertyTypeFeeder](namespace_tale_worlds_1_1_library.html#a74850bfe0b5488f44574810b7462b0f7) propertyTypeFeeder) |
| void | [SetPropertyValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a6f78904802a96070e57a1bcb9ac58019) (string name, object value) |
| void | [ExecuteCommand](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ae97e969ca39195be8974d74163410ba2) (string commandName, object[] parameters) |

|  |  |
| --- | --- |
| Events | |
| [PropertyChangedWithValueEventHandler](namespace_tale_worlds_1_1_library.html#aa511552e184232616e64f386cf1146b5) | [PropertyChangedWithValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a19415fe20feafa29a4e6d8d61dd95834) |
| [PropertyChangedWithBoolValueEventHandler](namespace_tale_worlds_1_1_library.html#a6b0d7e614739868a8f81c53a64f081bd) | [PropertyChangedWithBoolValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ae0ed3e57e466612e46fcf77b394b9ba6) |
| [PropertyChangedWithIntValueEventHandler](namespace_tale_worlds_1_1_library.html#a91bc6d8c78c447d9acf86771f3b3e932) | [PropertyChangedWithIntValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ad33c6216fef22f2e150e0c0673c3c6ef) |
| [PropertyChangedWithFloatValueEventHandler](namespace_tale_worlds_1_1_library.html#aa44f77d2af0c3adb609a79640e080914) | [PropertyChangedWithFloatValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#acef7bf697f161b4c0d742215107b0b8b) |
| [PropertyChangedWithUIntValueEventHandler](namespace_tale_worlds_1_1_library.html#aec7149fde7f195f3c4b4f10c4ce23cb8) | [PropertyChangedWithUIntValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#afd24d3b78a5e7fab669c340045b8533f) |
| [PropertyChangedWithColorValueEventHandler](namespace_tale_worlds_1_1_library.html#a90de79687e9792b5065a8a4e9c30eeac) | [PropertyChangedWithColorValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a3bc123550acc0a47f8c061c5a8300fa1) |
| [PropertyChangedWithDoubleValueEventHandler](namespace_tale_worlds_1_1_library.html#a8ce8e1aa20a71b9da4d1655fe04b089b) | [PropertyChangedWithDoubleValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a4b1a715b622570235d8224ecef32dc13) |
| [PropertyChangedWithVec2ValueEventHandler](namespace_tale_worlds_1_1_library.html#aa3ec79ffa85e522745c02340a7a41f2e) | [PropertyChangedWithVec2Value](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a5b8667b3ad8595517ada80e2928bd6ab) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ab434fefac00af7681a2d57d1ab4cf01e)GetViewModelAtPath() [1/2]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| object TaleWorlds.Library.IViewModel.GetViewModelAtPath | ( | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) | *path* | ) |  |

Implemented in [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#a58ad0a333f63aeb396cf0282a65b3b73).

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#af655c7a786420b88b81670118f40b707)GetViewModelAtPath() [2/2]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| object TaleWorlds.Library.IViewModel.GetViewModelAtPath | ( | [BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) | *path*, |
|  |  | bool | *isList* ) |

Implemented in [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adab1a5fac562c67766ef900113c2fd48).

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#adb1d894a6f455dbfc4d41e127f4cec60)GetPropertyValue() [1/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| object TaleWorlds.Library.IViewModel.GetPropertyValue | ( | string | *name* | ) |  |

Implemented in [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#a6c761a8baf9a75c1d8fd65dbaed24055).

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a63c2a57f3432062408141f83434d1caf)GetPropertyValue() [2/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| object TaleWorlds.Library.IViewModel.GetPropertyValue | ( | string | *name*, |
|  |  | [PropertyTypeFeeder](namespace_tale_worlds_1_1_library.html#a74850bfe0b5488f44574810b7462b0f7) | *propertyTypeFeeder* ) |

Implemented in [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#a870f5daf5e6f307138260ee84406bd4e).

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a6f78904802a96070e57a1bcb9ac58019)SetPropertyValue()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IViewModel.SetPropertyValue | ( | string | *name*, |
|  |  | object | *value* ) |

Implemented in [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#ad53397f315ef866a738a5e65556043df).

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ae97e969ca39195be8974d74163410ba2)ExecuteCommand()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IViewModel.ExecuteCommand | ( | string | *commandName*, |
|  |  | object[] | *parameters* ) |

Implemented in [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb).

Event Documentation
-------------------

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a19415fe20feafa29a4e6d8d61dd95834)PropertyChangedWithValue
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PropertyChangedWithValueEventHandler](namespace_tale_worlds_1_1_library.html#aa511552e184232616e64f386cf1146b5) TaleWorlds.Library.IViewModel.PropertyChangedWithValue |

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ae0ed3e57e466612e46fcf77b394b9ba6)PropertyChangedWithBoolValue
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PropertyChangedWithBoolValueEventHandler](namespace_tale_worlds_1_1_library.html#a6b0d7e614739868a8f81c53a64f081bd) TaleWorlds.Library.IViewModel.PropertyChangedWithBoolValue |

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ad33c6216fef22f2e150e0c0673c3c6ef)PropertyChangedWithIntValue
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PropertyChangedWithIntValueEventHandler](namespace_tale_worlds_1_1_library.html#a91bc6d8c78c447d9acf86771f3b3e932) TaleWorlds.Library.IViewModel.PropertyChangedWithIntValue |

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#acef7bf697f161b4c0d742215107b0b8b)PropertyChangedWithFloatValue
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PropertyChangedWithFloatValueEventHandler](namespace_tale_worlds_1_1_library.html#aa44f77d2af0c3adb609a79640e080914) TaleWorlds.Library.IViewModel.PropertyChangedWithFloatValue |

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#afd24d3b78a5e7fab669c340045b8533f)PropertyChangedWithUIntValue
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PropertyChangedWithUIntValueEventHandler](namespace_tale_worlds_1_1_library.html#aec7149fde7f195f3c4b4f10c4ce23cb8) TaleWorlds.Library.IViewModel.PropertyChangedWithUIntValue |

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a3bc123550acc0a47f8c061c5a8300fa1)PropertyChangedWithColorValue
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PropertyChangedWithColorValueEventHandler](namespace_tale_worlds_1_1_library.html#a90de79687e9792b5065a8a4e9c30eeac) TaleWorlds.Library.IViewModel.PropertyChangedWithColorValue |

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a4b1a715b622570235d8224ecef32dc13)PropertyChangedWithDoubleValue
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PropertyChangedWithDoubleValueEventHandler](namespace_tale_worlds_1_1_library.html#a8ce8e1aa20a71b9da4d1655fe04b089b) TaleWorlds.Library.IViewModel.PropertyChangedWithDoubleValue |

[◆](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a5b8667b3ad8595517ada80e2928bd6ab)PropertyChangedWithVec2Value
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PropertyChangedWithVec2ValueEventHandler](namespace_tale_worlds_1_1_library.html#aa3ec79ffa85e522745c02340a7a41f2e) TaleWorlds.Library.IViewModel.PropertyChangedWithVec2Value |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData Class ReferenceabstractInherits [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html).

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.ActionCampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_action_campaign_option_data.html), [TaleWorlds.CampaignSystem.ViewModelCollection.BooleanCampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_boolean_campaign_option_data.html), [TaleWorlds.CampaignSystem.ViewModelCollection.NumericCampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html), and [TaleWorlds.CampaignSystem.ViewModelCollection.SelectionCampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_selection_campaign_option_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a52a48253e4f02be83e6ab4332a1daf08) (string identifier, int priorityIndex, [CampaignOptionEnableState](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aede830579d3e798144e23b839ea6f5a5) enableState, Func< float > getValue, Action< float > setValue, Func< [CampaignOptionDisableStatus](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_disable_status.html) > getIsDisabledWithReason=null, bool isRelatedToDifficultyPreset=false, Func< float, [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2) > onGetDifficultyPresetFromValue=null, Func< [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2), float > onGetValueFromDifficultyPreset=null) |
| int | [GetPriorityIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a1154a294230310e8068cf5af914fce10) () |
| [CampaignOptionDataType](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aacc8ee80e49a829045b43d3f68dfba64) | [GetDataType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a11c87f44bbf56300aa51331f9fc4e49c) () |
| bool | [IsRelatedToDifficultyPreset](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#aa63d7dcc06838ec3ef9942b4405001d3) () |
| float | [GetValueFromDifficultyPreset](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a3e16cb4b92d1eb42653f49c52b427fd2) ([CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2) preset) |
| [CampaignOptionDisableStatus](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_disable_status.html) | [GetIsDisabledWithReason](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a0bd4170db91e7e70eb33d89dc1322649) () |
| string | [GetIdentifier](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#ab6c4a4888edfb4cbb31685909d35c3d6) () |
| [CampaignOptionEnableState](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aede830579d3e798144e23b839ea6f5a5) | [GetEnableState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a454dfe0a732e07448b3bb365277036d5) () |
| string | [GetName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#ad8175a78543036cf2422f15182c41b42) () |
| string | [GetDescription](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#aaa43d1c9c680722aa2fa529cd74f1e64) () |
| float | [GetValue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a6262e34a436b1c7f83dc87361dba353e) () |
| void | [SetValue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a716d74a83bbfda28a32bf8a37f1103dd) (float value) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetNameOfOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#accb4706b4b5c6a201b4628bc7afdf915) (string optionIdentifier) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionOfOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a55644fc2e01134cd3b3ef74b52b1b981) (string optionIdentifier) |

|  |  |
| --- | --- |
| Protected Attributes | |
| Func< float > | [\_getValue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a9f8212f833debc236e25bab36eb5495a) |
| Action< float > | [\_setValue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#ae6d90914cb15e131d3344440ba541e4a) |
| Func< float, [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2) > | [\_onGetDifficultyPresetFromValue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#ac27f5a15d3fcfc3fb4fb2946c4c6528b) |
| Func< [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2), float > | [\_onGetValueFromDifficultyPreset](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a7061ab02fa633d519484ed4d9aa547b9) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a52a48253e4f02be83e6ab4332a1daf08)CampaignOptionData()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.CampaignOptionData | ( | string | *identifier*, |
|  |  | int | *priorityIndex*, |
|  |  | [CampaignOptionEnableState](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aede830579d3e798144e23b839ea6f5a5) | *enableState*, |
|  |  | Func< float > | *getValue*, |
|  |  | Action< float > | *setValue*, |
|  |  | Func< [CampaignOptionDisableStatus](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_disable_status.html) > | *getIsDisabledWithReason* = null, |
|  |  | bool | *isRelatedToDifficultyPreset* = false, |
|  |  | Func< float, [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2) > | *onGetDifficultyPresetFromValue* = null, |
|  |  | Func< [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2), float > | *onGetValueFromDifficultyPreset* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#accb4706b4b5c6a201b4628bc7afdf915)GetNameOfOption()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.GetNameOfOption | ( | string | *optionIdentifier* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a55644fc2e01134cd3b3ef74b52b1b981)GetDescriptionOfOption()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.GetDescriptionOfOption | ( | string | *optionIdentifier* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a1154a294230310e8068cf5af914fce10)GetPriorityIndex()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.GetPriorityIndex | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#afb8710182b735331826b8512c2aefcba).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a11c87f44bbf56300aa51331f9fc4e49c)GetDataType()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [CampaignOptionDataType](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aacc8ee80e49a829045b43d3f68dfba64) TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.GetDataType | ( |  | ) |  | | abstract |

Implements [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a5aa2975211cb4a170d77052a8cce995e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#aa63d7dcc06838ec3ef9942b4405001d3)IsRelatedToDifficultyPreset()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.IsRelatedToDifficultyPreset | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#ab79f236c4385b88c208a419c7ecdd577).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a3e16cb4b92d1eb42653f49c52b427fd2)GetValueFromDifficultyPreset()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.GetValueFromDifficultyPreset | ( | [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2) | *preset* | ) |  |

Implements [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a41edc8e9237e049bdc605e835197ceac).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a0bd4170db91e7e70eb33d89dc1322649)GetIsDisabledWithReason()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [CampaignOptionDisableStatus](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_disable_status.html) TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.GetIsDisabledWithReason | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#ab77e4d1f2a47be302aeec6b12e2e814d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#ab6c4a4888edfb4cbb31685909d35c3d6)GetIdentifier()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.GetIdentifier | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a6f439f7893506b5d16b81eef345100fb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a454dfe0a732e07448b3bb365277036d5)GetEnableState()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [CampaignOptionEnableState](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aede830579d3e798144e23b839ea6f5a5) TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.GetEnableState | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a526f06bb752e33decffa18a77fd0f361).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#ad8175a78543036cf2422f15182c41b42)GetName()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.GetName | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a93d2e034967c82a1f54e15788f850a4f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#aaa43d1c9c680722aa2fa529cd74f1e64)GetDescription()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.GetDescription | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a5d34aa14201f48a6ffa61290d70dca36).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a6262e34a436b1c7f83dc87361dba353e)GetValue()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.GetValue | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a475ce222f37ac3ac9d9eb19f19ec3c1d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a716d74a83bbfda28a32bf8a37f1103dd)SetValue()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.SetValue | ( | float | *value* | ) |  |

Implements [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a5db3e80fadd0f1a9b6f1adabd4878524).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a9f8212f833debc236e25bab36eb5495a)\_getValue
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<float> TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.\_getValue | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#ae6d90914cb15e131d3344440ba541e4a)\_setValue
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<float> TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.\_setValue | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#ac27f5a15d3fcfc3fb4fb2946c4c6528b)\_onGetDifficultyPresetFromValue
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<float, [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2)> TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.\_onGetDifficultyPresetFromValue | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a7061ab02fa633d519484ed4d9aa547b9)\_onGetValueFromDifficultyPreset
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<[CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2), float> TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData.\_onGetValueFromDifficultyPreset | | protected |


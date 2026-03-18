--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.NumericCampaignOptionData Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NumericCampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html#a0b7c3283b8f82a41493e4ed0674011f3) (string identifier, int priorityIndex, [CampaignOptionEnableState](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aede830579d3e798144e23b839ea6f5a5) enableState, Func< float > getValue, Action< float > setValue, float minValue, float maxValue, bool isDiscrete, Func< [CampaignOptionDisableStatus](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_disable_status.html) > getIsDisabledWithReason=null, bool isRelatedToDifficultyPreset=false, Func< float, [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2) > onGetDifficultyPresetFromValue=null, Func< [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2), float > onGetValueFromDifficultyPreset=null) |
| override [CampaignOptionDataType](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aacc8ee80e49a829045b43d3f68dfba64) | [GetDataType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html#a8f0ab8d716bceec4bb06f6fdaca0a82d) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html) | |
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
| Properties | |
| float | [MinValue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html#ac28deea47f6745024157bb499a210790) `[get]` |
| float | [MaxValue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html#a027fceb9eb11ddceacd5e2bbccfca015) `[get]` |
| bool | [IsDiscrete](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html#afb17b7168f5c8d33832672d43f1568e6) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html) | |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetNameOfOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#accb4706b4b5c6a201b4628bc7afdf915) (string optionIdentifier) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionOfOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a55644fc2e01134cd3b3ef74b52b1b981) (string optionIdentifier) |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html) | |
| Func< float > | [\_getValue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a9f8212f833debc236e25bab36eb5495a) |
| Action< float > | [\_setValue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#ae6d90914cb15e131d3344440ba541e4a) |
| Func< float, [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2) > | [\_onGetDifficultyPresetFromValue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#ac27f5a15d3fcfc3fb4fb2946c4c6528b) |
| Func< [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2), float > | [\_onGetValueFromDifficultyPreset](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a7061ab02fa633d519484ed4d9aa547b9) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html#a0b7c3283b8f82a41493e4ed0674011f3)NumericCampaignOptionData()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.NumericCampaignOptionData.NumericCampaignOptionData | ( | string | *identifier*, |
|  |  | int | *priorityIndex*, |
|  |  | [CampaignOptionEnableState](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aede830579d3e798144e23b839ea6f5a5) | *enableState*, |
|  |  | Func< float > | *getValue*, |
|  |  | Action< float > | *setValue*, |
|  |  | float | *minValue*, |
|  |  | float | *maxValue*, |
|  |  | bool | *isDiscrete*, |
|  |  | Func< [CampaignOptionDisableStatus](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_disable_status.html) > | *getIsDisabledWithReason* = null, |
|  |  | bool | *isRelatedToDifficultyPreset* = false, |
|  |  | Func< float, [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2) > | *onGetDifficultyPresetFromValue* = null, |
|  |  | Func< [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2), float > | *onGetValueFromDifficultyPreset* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html#a8f0ab8d716bceec4bb06f6fdaca0a82d)GetDataType()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [CampaignOptionDataType](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aacc8ee80e49a829045b43d3f68dfba64) TaleWorlds.CampaignSystem.ViewModelCollection.NumericCampaignOptionData.GetDataType | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a5aa2975211cb4a170d77052a8cce995e).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html#ac28deea47f6745024157bb499a210790)MinValue
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.NumericCampaignOptionData.MinValue | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html#a027fceb9eb11ddceacd5e2bbccfca015)MaxValue
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ViewModelCollection.NumericCampaignOptionData.MaxValue | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html#afb17b7168f5c8d33832672d43f1568e6)IsDiscrete
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.NumericCampaignOptionData.IsDiscrete | | get |


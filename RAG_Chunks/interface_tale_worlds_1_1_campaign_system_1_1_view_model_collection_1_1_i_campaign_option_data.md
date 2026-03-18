--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData Interface ReferenceInherited by [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [CampaignOptionDataType](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aacc8ee80e49a829045b43d3f68dfba64) | [GetDataType](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a5aa2975211cb4a170d77052a8cce995e) () |
| int | [GetPriorityIndex](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#afb8710182b735331826b8512c2aefcba) () |
| bool | [IsRelatedToDifficultyPreset](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#ab79f236c4385b88c208a419c7ecdd577) () |
| float | [GetValueFromDifficultyPreset](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a41edc8e9237e049bdc605e835197ceac) ([CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2) preset) |
| string | [GetIdentifier](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a6f439f7893506b5d16b81eef345100fb) () |
| [CampaignOptionEnableState](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aede830579d3e798144e23b839ea6f5a5) | [GetEnableState](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a526f06bb752e33decffa18a77fd0f361) () |
| string | [GetName](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a93d2e034967c82a1f54e15788f850a4f) () |
| string | [GetDescription](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a5d34aa14201f48a6ffa61290d70dca36) () |
| float | [GetValue](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a475ce222f37ac3ac9d9eb19f19ec3c1d) () |
| void | [SetValue](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a5db3e80fadd0f1a9b6f1adabd4878524) (float value) |
| [CampaignOptionDisableStatus](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_disable_status.html) | [GetIsDisabledWithReason](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#ab77e4d1f2a47be302aeec6b12e2e814d) () |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a5aa2975211cb4a170d77052a8cce995e)GetDataType()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [CampaignOptionDataType](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aacc8ee80e49a829045b43d3f68dfba64) TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData.GetDataType | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.ViewModelCollection.ActionCampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_action_campaign_option_data.html#aaebc3f51be94d99119da011e00fe3c9b), [TaleWorlds.CampaignSystem.ViewModelCollection.BooleanCampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_boolean_campaign_option_data.html#a0f9d744066cf3c42bf0b8554e2285cf9), [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a11c87f44bbf56300aa51331f9fc4e49c), [TaleWorlds.CampaignSystem.ViewModelCollection.NumericCampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_numeric_campaign_option_data.html#a8f0ab8d716bceec4bb06f6fdaca0a82d), and [TaleWorlds.CampaignSystem.ViewModelCollection.SelectionCampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_selection_campaign_option_data.html#ac8159fb092059d20cb64aba4fef56d2c).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#afb8710182b735331826b8512c2aefcba)GetPriorityIndex()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData.GetPriorityIndex | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a1154a294230310e8068cf5af914fce10).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#ab79f236c4385b88c208a419c7ecdd577)IsRelatedToDifficultyPreset()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData.IsRelatedToDifficultyPreset | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#aa63d7dcc06838ec3ef9942b4405001d3).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a41edc8e9237e049bdc605e835197ceac)GetValueFromDifficultyPreset()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData.GetValueFromDifficultyPreset | ( | [CampaignOptionsDifficultyPresets](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#a44f0fa9e126f77458fb07ba4844605c2) | *preset* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a3e16cb4b92d1eb42653f49c52b427fd2).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a6f439f7893506b5d16b81eef345100fb)GetIdentifier()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData.GetIdentifier | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#ab6c4a4888edfb4cbb31685909d35c3d6).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a526f06bb752e33decffa18a77fd0f361)GetEnableState()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [CampaignOptionEnableState](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection.html#aede830579d3e798144e23b839ea6f5a5) TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData.GetEnableState | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a454dfe0a732e07448b3bb365277036d5).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a93d2e034967c82a1f54e15788f850a4f)GetName()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData.GetName | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#ad8175a78543036cf2422f15182c41b42).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a5d34aa14201f48a6ffa61290d70dca36)GetDescription()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData.GetDescription | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#aaa43d1c9c680722aa2fa529cd74f1e64).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a475ce222f37ac3ac9d9eb19f19ec3c1d)GetValue()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData.GetValue | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a6262e34a436b1c7f83dc87361dba353e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#a5db3e80fadd0f1a9b6f1adabd4878524)SetValue()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData.SetValue | ( | float | *value* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a716d74a83bbfda28a32bf8a37f1103dd).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_i_campaign_option_data.html#ab77e4d1f2a47be302aeec6b12e2e814d)GetIsDisabledWithReason()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [CampaignOptionDisableStatus](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_disable_status.html) TaleWorlds.CampaignSystem.ViewModelCollection.ICampaignOptionData.GetIsDisabledWithReason | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.ViewModelCollection.CampaignOptionData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_option_data.html#a0bd4170db91e7e70eb33d89dc1322649).


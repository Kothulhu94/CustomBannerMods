--- SOURCE: struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html ---

TaleWorlds.CampaignSystem.ExplainedNumber Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a4fb5a141754a4f1a2402ceb622db0a85) (float baseNumber=0f, bool includeDescriptions=false, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) baseText=null) |
| string | [GetExplanations](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#aca340d924cf1ea7453f4fa7695347bd1) () |
| List<(string name, float number)> | [GetLines](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a0f5ac8d689936f8011d01ac423f47f35) () |
| void | [AddFromExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#aaf99ab5b3ecced44ed75327af9e1108d) ([ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a4fb5a141754a4f1a2402ceb622db0a85) explainedNumber, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) baseText) |
| void | [SubtractFromExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#afc0dba3bf2190c82020d57668b993c33) ([ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a4fb5a141754a4f1a2402ceb622db0a85) explainedNumber, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) baseText) |
| void | [Add](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a9f9f97cd22675ee8e801e575a344b6d7) (float value, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description=null, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) variable=null) |
| void | [AddFactor](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a3f6e56d74e3b10b32fd62f3e30f8142e) (float value, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description=null) |
| void | [LimitMin](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a4562932a013f24c2807cb73598ef6138) (float minValue) |
| void | [LimitMax](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a1959d2346a0c3fe503c1d8314211bbde) (float maxValue, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description=null) |
| void | [Clamp](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a77f43c6a0ba9b09f4a990a3d94ac4c24) (float minValue, float maxValue) |

|  |  |
| --- | --- |
| Properties | |
| float | [ResultNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#afd8329e81bae2ecbeda61a16d1a4fb23) `[get]` |
| int | [RoundedResultNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#ad4f2421b74a5a82a0030e29c8efe56b7) `[get]` |
| float | [BaseNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#ab597a9cf54cb138133175636fa8c00e7) `[get]` |
| bool | [IncludeDescriptions](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a0e6156aeb85966b753dcbf6d7dfcb3f6) `[get]` |
| float | [LimitMinValue](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a3b71f90b6aa8a91592e0694af3bd997c) `[get]` |
| float | [LimitMaxValue](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#ace71e5d9321f0952131bbf490279ce57) `[get]` |
| float | [SumOfFactors](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a64a6092950ecc35259974402f8590929) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a4fb5a141754a4f1a2402ceb622db0a85)ExplainedNumber()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ExplainedNumber.ExplainedNumber | ( | float | *baseNumber* = 0f, |
|  |  | bool | *includeDescriptions* = false, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *baseText* = null ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#aca340d924cf1ea7453f4fa7695347bd1)GetExplanations()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.ExplainedNumber.GetExplanations | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a0f5ac8d689936f8011d01ac423f47f35)GetLines()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List<(string name, float number)> TaleWorlds.CampaignSystem.ExplainedNumber.GetLines | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#aaf99ab5b3ecced44ed75327af9e1108d)AddFromExplainedNumber()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ExplainedNumber.AddFromExplainedNumber | ( | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a4fb5a141754a4f1a2402ceb622db0a85) | *explainedNumber*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *baseText* ) |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#afc0dba3bf2190c82020d57668b993c33)SubtractFromExplainedNumber()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ExplainedNumber.SubtractFromExplainedNumber | ( | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a4fb5a141754a4f1a2402ceb622db0a85) | *explainedNumber*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *baseText* ) |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a9f9f97cd22675ee8e801e575a344b6d7)Add()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ExplainedNumber.Add | ( | float | *value*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description* = null, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *variable* = null ) |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a3f6e56d74e3b10b32fd62f3e30f8142e)AddFactor()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ExplainedNumber.AddFactor | ( | float | *value*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description* = null ) |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a4562932a013f24c2807cb73598ef6138)LimitMin()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ExplainedNumber.LimitMin | ( | float | *minValue* | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a1959d2346a0c3fe503c1d8314211bbde)LimitMax()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ExplainedNumber.LimitMax | ( | float | *maxValue*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description* = null ) |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a77f43c6a0ba9b09f4a990a3d94ac4c24)Clamp()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ExplainedNumber.Clamp | ( | float | *minValue*, |
|  |  | float | *maxValue* ) |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#afd8329e81bae2ecbeda61a16d1a4fb23)ResultNumber
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ExplainedNumber.ResultNumber | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#ad4f2421b74a5a82a0030e29c8efe56b7)RoundedResultNumber
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ExplainedNumber.RoundedResultNumber | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#ab597a9cf54cb138133175636fa8c00e7)BaseNumber
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ExplainedNumber.BaseNumber | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a0e6156aeb85966b753dcbf6d7dfcb3f6)IncludeDescriptions
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ExplainedNumber.IncludeDescriptions | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a3b71f90b6aa8a91592e0694af3bd997c)LimitMinValue
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ExplainedNumber.LimitMinValue | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#ace71e5d9321f0952131bbf490279ce57)LimitMaxValue
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ExplainedNumber.LimitMaxValue | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html#a64a6092950ecc35259974402f8590929)SumOfFactors
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ExplainedNumber.SumOfFactors | | get |


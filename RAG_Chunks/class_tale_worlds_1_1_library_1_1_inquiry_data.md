--- SOURCE: class_tale_worlds_1_1_library_1_1_inquiry_data.html ---

TaleWorlds.Library.InquiryData Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html#ac7bf90f2887e97db501bec791886ddbb) (string titleText, string text, bool isAffirmativeOptionShown, bool isNegativeOptionShown, string affirmativeText, string negativeText, Action affirmativeAction, Action negativeAction, string soundEventPath="", float expireTime=0f, Action timeoutAction=null, Func<(bool, string)> isAffirmativeOptionEnabled=null, Func<(bool, string)> isNegativeOptionEnabled=null) |
|  | Parameter structure of the inquiry. |
| void | [SetText](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a31b56e173e0bb5152a5edff852cf0b2b) (string text) |
| void | [SetTitleText](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a24ea9fd9507c59571de1ceac0fdc6594) (string titleText) |
| bool | [HasSameContentWith](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a68a7300fe2281bd7e6b58dbab20cf7d7) (object other) |

|  |  |
| --- | --- |
| Public Attributes | |
| string | [TitleText](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a51deb4b79835abfac78b04c717c78d8f) |
| string | [Text](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a2cff09cd84d940ef2171b0e881e4353a) |
| readonly float | [ExpireTime](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a5a3f78e186a90d5bb71879b46d298cfd) |
| readonly bool | [IsAffirmativeOptionShown](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a08053b57ca1d881f6de9816f951c098c) |
| readonly bool | [IsNegativeOptionShown](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a6b23049c792641146d99969069571883) |
| readonly string | [AffirmativeText](class_tale_worlds_1_1_library_1_1_inquiry_data.html#afe48d6ba739b0a8f99aed68394545377) |
| readonly string | [NegativeText](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a3d255bdf61393ec74cfbfd9c77695be7) |
| readonly string | [SoundEventPath](class_tale_worlds_1_1_library_1_1_inquiry_data.html#aafa59ab9cd853d9f54b071f246750746) |
| readonly Action | [AffirmativeAction](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a5bcb628ecf710cbc01b996e392913e92) |
| readonly Action | [NegativeAction](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a195369776a1cd01170ad3a11358da709) |
| readonly Action | [TimeoutAction](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a5dda9c0c46289592b389569748f14132) |
| readonly Func<(bool, string)> | [GetIsAffirmativeOptionEnabled](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a2a33f1cb481a41723294c7579e1509ac) |
| readonly Func<(bool, string)> | [GetIsNegativeOptionEnabled](class_tale_worlds_1_1_library_1_1_inquiry_data.html#ae287a80d3b56345dec4f42195fe68d80) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#ac7bf90f2887e97db501bec791886ddbb)InquiryData()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.InquiryData.InquiryData | ( | string | *titleText*, |
|  |  | string | *text*, |
|  |  | bool | *isAffirmativeOptionShown*, |
|  |  | bool | *isNegativeOptionShown*, |
|  |  | string | *affirmativeText*, |
|  |  | string | *negativeText*, |
|  |  | Action | *affirmativeAction*, |
|  |  | Action | *negativeAction*, |
|  |  | string | *soundEventPath* = "", |
|  |  | float | *expireTime* = 0f, |
|  |  | Action | *timeoutAction* = null, |
|  |  | Func<(bool, string)> | *isAffirmativeOptionEnabled* = null, |
|  |  | Func<(bool, string)> | *isNegativeOptionEnabled* = null ) |

Parameters
:   |  |  |
    | --- | --- |
    | titleText | Title of the inquiry. |
    | text | Inner text of the inquiry. |
    | expireTime | Expiration time of the inquiry. |
    | isAffirmativeOptionShown | Determines if the positive action is shown. |
    | isNegativeOptionShown | Determines if the negative action is shown. |
    | affirmativeText | Determines the text content of the positive action. |
    | negativeText | Determines the text content of the negative action. |
    | affirmativeAction | Action that happens when positive action is selected. |
    | negativeAction | Action that happens when negative action is selected. |
    | timeoutAction | Action that happens when inquiry is expired. |
    | soundEventPath | Path of a sound file in the project. Plays at the start of the inquiry. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a31b56e173e0bb5152a5edff852cf0b2b)SetText()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.InquiryData.SetText | ( | string | *text* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a24ea9fd9507c59571de1ceac0fdc6594)SetTitleText()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.InquiryData.SetTitleText | ( | string | *titleText* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a68a7300fe2281bd7e6b58dbab20cf7d7)HasSameContentWith()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.InquiryData.HasSameContentWith | ( | object | *other* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a51deb4b79835abfac78b04c717c78d8f)TitleText
---------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.Library.InquiryData.TitleText |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a2cff09cd84d940ef2171b0e881e4353a)Text
----------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.Library.InquiryData.Text |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a5a3f78e186a90d5bb71879b46d298cfd)ExpireTime
----------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.Library.InquiryData.ExpireTime |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a08053b57ca1d881f6de9816f951c098c)IsAffirmativeOptionShown
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.Library.InquiryData.IsAffirmativeOptionShown |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a6b23049c792641146d99969069571883)IsNegativeOptionShown
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.Library.InquiryData.IsNegativeOptionShown |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#afe48d6ba739b0a8f99aed68394545377)AffirmativeText
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.Library.InquiryData.AffirmativeText |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a3d255bdf61393ec74cfbfd9c77695be7)NegativeText
------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.Library.InquiryData.NegativeText |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#aafa59ab9cd853d9f54b071f246750746)SoundEventPath
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.Library.InquiryData.SoundEventPath |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a5bcb628ecf710cbc01b996e392913e92)AffirmativeAction
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Action TaleWorlds.Library.InquiryData.AffirmativeAction |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a195369776a1cd01170ad3a11358da709)NegativeAction
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Action TaleWorlds.Library.InquiryData.NegativeAction |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a5dda9c0c46289592b389569748f14132)TimeoutAction
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Action TaleWorlds.Library.InquiryData.TimeoutAction |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#a2a33f1cb481a41723294c7579e1509ac)GetIsAffirmativeOptionEnabled
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Func<(bool, string)> TaleWorlds.Library.InquiryData.GetIsAffirmativeOptionEnabled |

[◆](class_tale_worlds_1_1_library_1_1_inquiry_data.html#ae287a80d3b56345dec4f42195fe68d80)GetIsNegativeOptionEnabled
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Func<(bool, string)> TaleWorlds.Library.InquiryData.GetIsNegativeOptionEnabled |


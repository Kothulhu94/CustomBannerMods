--- SOURCE: class_tale_worlds_1_1_library_1_1_text_inquiry_data.html ---

TaleWorlds.Library.TextInquiryData Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TextInquiryData](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a79cb0b945aeb2ab36eeaa581e8028556) (string titleText, string text, bool isAffirmativeOptionShown, bool isNegativeOptionShown, string affirmativeText, string negativeText, Action< string > affirmativeAction, Action negativeAction, bool shouldInputBeObfuscated=false, Func< string, Tuple< bool, string > > textCondition=null, string soundEventPath="", string defaultInputText="") |
|  | Parameter structure of the inquiry. |
| bool | [HasSameContentWith](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a94cf1feb2a035fad1d0d9edaa8abe48a) (object other) |

|  |  |
| --- | --- |
| Public Attributes | |
| string | [TitleText](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a385e1a6c9de9ed1b87d5ee66fc8100f3) |
| string | [Text](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a8515ab9cf69f58b7d86ffc67d4599c4c) = "" |
| readonly bool | [IsAffirmativeOptionShown](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#ac528170340b97336e5595f9fecea716d) |
| readonly bool | [IsNegativeOptionShown](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a0fd0071f4d70a15aa604764fa79e878a) |
| readonly bool | [IsInputObfuscated](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a8bc20179c63ef4c29ce8d29394c2ea7c) |
| readonly string | [AffirmativeText](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a7e1d22ef2d3d7b7e0049ec2e19fa75b6) |
| readonly string | [NegativeText](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a120a9af326d6d1d3c44b57cdfcfdf690) |
| readonly string | [SoundEventPath](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a473263ae40e72b8edbc185a18548709e) |
| readonly string | [DefaultInputText](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#aee02e5fd57e767fa19c108ef26bc4536) |
| readonly Action< string > | [AffirmativeAction](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a579464808dfe86269ff8bef3075064f3) |
| readonly Action | [NegativeAction](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a2c2b6f8a88f67d056f683527d80e41a2) |
| readonly Func< string, Tuple< bool, string > > | [TextCondition](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a381c7e5c53d2ba4622069063c366394d) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a79cb0b945aeb2ab36eeaa581e8028556)TextInquiryData()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.TextInquiryData.TextInquiryData | ( | string | *titleText*, |
|  |  | string | *text*, |
|  |  | bool | *isAffirmativeOptionShown*, |
|  |  | bool | *isNegativeOptionShown*, |
|  |  | string | *affirmativeText*, |
|  |  | string | *negativeText*, |
|  |  | Action< string > | *affirmativeAction*, |
|  |  | Action | *negativeAction*, |
|  |  | bool | *shouldInputBeObfuscated* = false, |
|  |  | Func< string, Tuple< bool, string > > | *textCondition* = null, |
|  |  | string | *soundEventPath* = "", |
|  |  | string | *defaultInputText* = "" ) |

Parameters
:   |  |  |
    | --- | --- |
    | titleText | Title of the inquiry. |
    | text | Inner text of the inquiry. |
    | isAffirmativeOptionShown | Determines if the positive action is shown. |
    | isNegativeOptionShown | Determines if the negative action is shown. |
    | affirmativeText | Determines the text content of the positive action. |
    | negativeText | Determines the text content of the negative action. |
    | affirmativeAction | Action that happens when positive action is selected. Returns input text. |
    | negativeAction | Action that happens when negative action is selected. |
    | shouldInputBeObfuscated | Determines if the text is obfuscated while input |
    | textCondition | Func that asks if the current input text is permitted or not. Returns result and reason hint as a string. Null by default. |
    | soundEventPath | Path of a sound file in the project. Plays at the start of the inquiry. |
    | defaultInputText | Determines the default text the popup will open with |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a94cf1feb2a035fad1d0d9edaa8abe48a)HasSameContentWith()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.TextInquiryData.HasSameContentWith | ( | object | *other* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a385e1a6c9de9ed1b87d5ee66fc8100f3)TitleText
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.Library.TextInquiryData.TitleText |

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a8515ab9cf69f58b7d86ffc67d4599c4c)Text
---------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.Library.TextInquiryData.Text = "" |

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#ac528170340b97336e5595f9fecea716d)IsAffirmativeOptionShown
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.Library.TextInquiryData.IsAffirmativeOptionShown |

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a0fd0071f4d70a15aa604764fa79e878a)IsNegativeOptionShown
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.Library.TextInquiryData.IsNegativeOptionShown |

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a8bc20179c63ef4c29ce8d29394c2ea7c)IsInputObfuscated
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.Library.TextInquiryData.IsInputObfuscated |

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a7e1d22ef2d3d7b7e0049ec2e19fa75b6)AffirmativeText
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.Library.TextInquiryData.AffirmativeText |

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a120a9af326d6d1d3c44b57cdfcfdf690)NegativeText
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.Library.TextInquiryData.NegativeText |

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a473263ae40e72b8edbc185a18548709e)SoundEventPath
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.Library.TextInquiryData.SoundEventPath |

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#aee02e5fd57e767fa19c108ef26bc4536)DefaultInputText
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.Library.TextInquiryData.DefaultInputText |

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a579464808dfe86269ff8bef3075064f3)AffirmativeAction
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Action<string> TaleWorlds.Library.TextInquiryData.AffirmativeAction |

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a2c2b6f8a88f67d056f683527d80e41a2)NegativeAction
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Action TaleWorlds.Library.TextInquiryData.NegativeAction |

[◆](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html#a381c7e5c53d2ba4622069063c366394d)TextCondition
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Func<string, Tuple<bool,string> > TaleWorlds.Library.TextInquiryData.TextCondition |


--- SOURCE: class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html ---

TaleWorlds.Core.MultiSelectionInquiryData Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MultiSelectionInquiryData](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#aeb9bd75f1248f46168c72a43f95e9aff) (string titleText, string descriptionText, List< [InquiryElement](class_tale_worlds_1_1_core_1_1_inquiry_element.html) > inquiryElements, bool isExitShown, int minSelectableOptionCount, int maxSelectableOptionCount, string affirmativeText, string negativeText, Action< List< [InquiryElement](class_tale_worlds_1_1_core_1_1_inquiry_element.html) > > affirmativeAction, Action< List< [InquiryElement](class_tale_worlds_1_1_core_1_1_inquiry_element.html) > > negativeAction, string soundEventPath="", bool isSeachAvailable=false) |
|  | Parameter structure of the multi selection inquiry. |
| bool | [HasSameContentWith](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a1b3e764024e681f6c1da2ecb7de4a929) (object other) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly string | [TitleText](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a6f3db65fad8d73a97f2974d86457bb1d) |
| readonly string | [DescriptionText](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a5a70aee7daace6191a134d93df34f155) |
| readonly List< [InquiryElement](class_tale_worlds_1_1_core_1_1_inquiry_element.html) > | [InquiryElements](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#acf88a3cf98b26c3234d541fd405d8a9b) |
| readonly bool | [IsExitShown](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a5f2c27737867f85d4765fa2d304f558a) |
| readonly int | [MaxSelectableOptionCount](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#acb7743716b4b17cf3fba4b6bc3ab26b8) |
| readonly int | [MinSelectableOptionCount](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a0721c84267f7ab51bd6a6f085e36b37c) |
| readonly string | [SoundEventPath](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#affc6b9734bef87109209b494c92cbdda) |
| readonly string | [AffirmativeText](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a483fb403c1cdfc4888c58f6b3390e9c0) |
| readonly string | [NegativeText](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#ae26b09130d0cca5410e27a8b663862df) |
| readonly Action< List< [InquiryElement](class_tale_worlds_1_1_core_1_1_inquiry_element.html) > > | [AffirmativeAction](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a2d8a790d786130ecd07998f2f798b541) |
| readonly Action< List< [InquiryElement](class_tale_worlds_1_1_core_1_1_inquiry_element.html) > > | [NegativeAction](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#ad6775ea90025ad96ee82fdaad9e9b923) |
| readonly bool | [IsSeachAvailable](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a994f4e183f4c3187e453c5d9693a1a21) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#aeb9bd75f1248f46168c72a43f95e9aff)MultiSelectionInquiryData()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.MultiSelectionInquiryData.MultiSelectionInquiryData | ( | string | *titleText*, |
|  |  | string | *descriptionText*, |
|  |  | List< [InquiryElement](class_tale_worlds_1_1_core_1_1_inquiry_element.html) > | *inquiryElements*, |
|  |  | bool | *isExitShown*, |
|  |  | int | *minSelectableOptionCount*, |
|  |  | int | *maxSelectableOptionCount*, |
|  |  | string | *affirmativeText*, |
|  |  | string | *negativeText*, |
|  |  | Action< List< [InquiryElement](class_tale_worlds_1_1_core_1_1_inquiry_element.html) > > | *affirmativeAction*, |
|  |  | Action< List< [InquiryElement](class_tale_worlds_1_1_core_1_1_inquiry_element.html) > > | *negativeAction*, |
|  |  | string | *soundEventPath* = "", |
|  |  | bool | *isSeachAvailable* = false ) |

Parameters
:   |  |  |
    | --- | --- |
    | titleText | Title of the inquiry. |
    | descriptionText | Description of the inquiry. |
    | inquiryElements | List of selection elements to show and select from. |
    | isExitShown | Determines of the exit action is shown. Forces user the make a selection to end the inquiry. |
    | minSelectableOptionCount | Determines the minimum number of selections the user can make. 0 means no minimum. |
    | maxSelectableOptionCount | Determines the number of selections the user can make. 0 means no maximum. |
    | affirmativeText | Determines the text content of the positive action. |
    | negativeText | Determines the text content of the negative action |
    | affirmativeAction | Action that happens when positive action is selected. Passes the selection as a list. |
    | negativeAction | Action that happens when negative action is selected. Passes the selection as a list. |
    | soundEventPath | Path of a sound file in the project. Plays at the start of the inquiry. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a1b3e764024e681f6c1da2ecb7de4a929)HasSameContentWith()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.MultiSelectionInquiryData.HasSameContentWith | ( | object | *other* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a6f3db65fad8d73a97f2974d86457bb1d)TitleText
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.Core.MultiSelectionInquiryData.TitleText |

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a5a70aee7daace6191a134d93df34f155)DescriptionText
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.Core.MultiSelectionInquiryData.DescriptionText |

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#acf88a3cf98b26c3234d541fd405d8a9b)InquiryElements
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly List<[InquiryElement](class_tale_worlds_1_1_core_1_1_inquiry_element.html)> TaleWorlds.Core.MultiSelectionInquiryData.InquiryElements |

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a5f2c27737867f85d4765fa2d304f558a)IsExitShown
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.Core.MultiSelectionInquiryData.IsExitShown |

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#acb7743716b4b17cf3fba4b6bc3ab26b8)MaxSelectableOptionCount
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.Core.MultiSelectionInquiryData.MaxSelectableOptionCount |

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a0721c84267f7ab51bd6a6f085e36b37c)MinSelectableOptionCount
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.Core.MultiSelectionInquiryData.MinSelectableOptionCount |

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#affc6b9734bef87109209b494c92cbdda)SoundEventPath
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.Core.MultiSelectionInquiryData.SoundEventPath |

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a483fb403c1cdfc4888c58f6b3390e9c0)AffirmativeText
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.Core.MultiSelectionInquiryData.AffirmativeText |

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#ae26b09130d0cca5410e27a8b663862df)NegativeText
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.Core.MultiSelectionInquiryData.NegativeText |

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a2d8a790d786130ecd07998f2f798b541)AffirmativeAction
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Action<List<[InquiryElement](class_tale_worlds_1_1_core_1_1_inquiry_element.html)> > TaleWorlds.Core.MultiSelectionInquiryData.AffirmativeAction |

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#ad6775ea90025ad96ee82fdaad9e9b923)NegativeAction
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Action<List<[InquiryElement](class_tale_worlds_1_1_core_1_1_inquiry_element.html)> > TaleWorlds.Core.MultiSelectionInquiryData.NegativeAction |

[◆](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html#a994f4e183f4c3187e453c5d9693a1a21)IsSeachAvailable
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.Core.MultiSelectionInquiryData.IsSeachAvailable |


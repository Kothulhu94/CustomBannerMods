--- SOURCE: class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html ---

TaleWorlds.Localization.MBTextManager Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [LanguageExistsInCurrentConfiguration](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#ae5b861bb9f457204548c326c973725c1) (string language, bool developmentMode) |
| static bool | [ChangeLanguage](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a7ef7a86ef2757b266d4654f4f3dc541a) (string language) |
| static int | [GetActiveTextLanguageIndex](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#ac52d86f67e8863f231ae28da031ba023) () |
| static bool | [TryChangeVoiceLanguage](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a2202005ff672d8687724ba750165ae75) (string language) |
| static void | [ClearAll](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a0262dc76f479238b8d7a780e4e12b02f) () |
| static void | [SetTextVariable](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a8649ad89304de71eb7a47cccac829b11) (string variableName, string text, bool sendClients=false) |
| static void | [SetTextVariable](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#abc1584b30322f070bf27cbcc92cea7f1) (string variableName, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text, bool sendClients=false) |
| static void | [SetTextVariable](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a5290ecc0b2fb45808cfb0266c720769f) (string variableName, int content) |
| static void | [SetTextVariable](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a1afeb5f843a6a159bfb8f9780197e5aa) (string variableName, float content, int decimalDigits=2) |
| static void | [SetTextVariable](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a12350da109bd072b994589638c377ce6) (string variableName, object content) |
| static void | [SetTextVariable](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a9ea7c1cd6a8a40e2d63743159d85f8f6) (string variableName, int arrayIndex, object content) |
| static void | [SetFunction](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a0e4a99c0c27d19396b0fa843a8f7cac2) (string funcName, string functionBody) |
| static void | [ResetFunctions](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#ab2bdfa2ff180117a217774c8660e4e2d) () |
| static void | [ThrowLocalizationError](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#afa0e7d846992758fe015771bc58d6ed7) (string message) |
| static string | [DiscardAnimationTagsAndCheckAnimationTagPositions](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a450e3c7dfeb5689e1bedaf6356873fad) (string text) |
| static string | [DiscardAnimationTags](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a5bc897257126dfc47e78671bec6077b1) (string text) |
| static string[] | [GetConversationAnimations](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a3f13e62c50a380966c81116051fcfb10) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) to) |
| static bool | [TryGetVoiceObject](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a000e15d631a0bc61d82678821f8b47f0) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) to, out [VoiceObject](class_tale_worlds_1_1_localization_1_1_voice_object.html) vo, out string vocalizationId) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [LinkAttribute](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#ab9ceb0ebdf3d498312ae6954e1330483) = "LINK" |

|  |  |
| --- | --- |
| Properties | |
| static string | [ActiveTextLanguage](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a88966c862ab2a77af9a193234ff94002) `[get]` |
| static bool | [LocalizationDebugMode](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#addb53404a6ed3db307b354f5a6bb7684) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#ae5b861bb9f457204548c326c973725c1)LanguageExistsInCurrentConfiguration()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Localization.MBTextManager.LanguageExistsInCurrentConfiguration | ( | string | *language*, | |  |  | bool | *developmentMode* ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a7ef7a86ef2757b266d4654f4f3dc541a)ChangeLanguage()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Localization.MBTextManager.ChangeLanguage | ( | string | *language* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#ac52d86f67e8863f231ae28da031ba023)GetActiveTextLanguageIndex()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Localization.MBTextManager.GetActiveTextLanguageIndex | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a2202005ff672d8687724ba750165ae75)TryChangeVoiceLanguage()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Localization.MBTextManager.TryChangeVoiceLanguage | ( | string | *language* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a0262dc76f479238b8d7a780e4e12b02f)ClearAll()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Localization.MBTextManager.ClearAll | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a8649ad89304de71eb7a47cccac829b11)SetTextVariable() [1/6]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Localization.MBTextManager.SetTextVariable | ( | string | *variableName*, | |  |  | string | *text*, | |  |  | bool | *sendClients* = false ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#abc1584b30322f070bf27cbcc92cea7f1)SetTextVariable() [2/6]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Localization.MBTextManager.SetTextVariable | ( | string | *variableName*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text*, | |  |  | bool | *sendClients* = false ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a5290ecc0b2fb45808cfb0266c720769f)SetTextVariable() [3/6]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Localization.MBTextManager.SetTextVariable | ( | string | *variableName*, | |  |  | int | *content* ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a1afeb5f843a6a159bfb8f9780197e5aa)SetTextVariable() [4/6]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Localization.MBTextManager.SetTextVariable | ( | string | *variableName*, | |  |  | float | *content*, | |  |  | int | *decimalDigits* = 2 ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a12350da109bd072b994589638c377ce6)SetTextVariable() [5/6]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Localization.MBTextManager.SetTextVariable | ( | string | *variableName*, | |  |  | object | *content* ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a9ea7c1cd6a8a40e2d63743159d85f8f6)SetTextVariable() [6/6]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Localization.MBTextManager.SetTextVariable | ( | string | *variableName*, | |  |  | int | *arrayIndex*, | |  |  | object | *content* ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a0e4a99c0c27d19396b0fa843a8f7cac2)SetFunction()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Localization.MBTextManager.SetFunction | ( | string | *funcName*, | |  |  | string | *functionBody* ) | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#ab2bdfa2ff180117a217774c8660e4e2d)ResetFunctions()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Localization.MBTextManager.ResetFunctions | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#afa0e7d846992758fe015771bc58d6ed7)ThrowLocalizationError()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Localization.MBTextManager.ThrowLocalizationError | ( | string | *message* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a450e3c7dfeb5689e1bedaf6356873fad)DiscardAnimationTagsAndCheckAnimationTagPositions()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Localization.MBTextManager.DiscardAnimationTagsAndCheckAnimationTagPositions | ( | string | *text* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a5bc897257126dfc47e78671bec6077b1)DiscardAnimationTags()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Localization.MBTextManager.DiscardAnimationTags | ( | string | *text* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a3f13e62c50a380966c81116051fcfb10)GetConversationAnimations()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string[] TaleWorlds.Localization.MBTextManager.GetConversationAnimations | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *to* | ) |  | | static |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a000e15d631a0bc61d82678821f8b47f0)TryGetVoiceObject()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Localization.MBTextManager.TryGetVoiceObject | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *to*, | |  |  | out [VoiceObject](class_tale_worlds_1_1_localization_1_1_voice_object.html) | *vo*, | |  |  | out string | *vocalizationId* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#ab9ceb0ebdf3d498312ae6954e1330483)LinkAttribute
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.Localization.MBTextManager.LinkAttribute = "LINK" | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#a88966c862ab2a77af9a193234ff94002)ActiveTextLanguage
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Localization.MBTextManager.ActiveTextLanguage | | staticget |

[◆](class_tale_worlds_1_1_localization_1_1_m_b_text_manager.html#addb53404a6ed3db307b354f5a6bb7684)LocalizationDebugMode
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Localization.MBTextManager.LocalizationDebugMode | | staticgetset |


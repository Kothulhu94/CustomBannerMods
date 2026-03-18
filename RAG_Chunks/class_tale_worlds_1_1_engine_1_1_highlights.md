--- SOURCE: class_tale_worlds_1_1_engine_1_1_highlights.html ---

TaleWorlds.Engine.Highlights Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [Significance](class_tale_worlds_1_1_engine_1_1_highlights.html#abf3c342010bdd1d0ed3513cc6041e33a) {     [None](class_tale_worlds_1_1_engine_1_1_highlights.html#abf3c342010bdd1d0ed3513cc6041e33aa6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [ExtremelyBad](class_tale_worlds_1_1_engine_1_1_highlights.html#abf3c342010bdd1d0ed3513cc6041e33aa1faee8e11768b92103b45009d9d300e9) = 0x00000001 ,     [VeryBad](class_tale_worlds_1_1_engine_1_1_highlights.html#abf3c342010bdd1d0ed3513cc6041e33aaf4334d73e8557f03093b75f8d2345ac3) = 0x00000002 ,     [Bad](class_tale_worlds_1_1_engine_1_1_highlights.html#abf3c342010bdd1d0ed3513cc6041e33aa7ff3e75ce6aca348bc513ed3d5882946) = 0x00000004 ,     [Neutral](class_tale_worlds_1_1_engine_1_1_highlights.html#abf3c342010bdd1d0ed3513cc6041e33aae9bb5320b3890b6747c91b5a71ae5a01) = 0x00000010 ,     [Good](class_tale_worlds_1_1_engine_1_1_highlights.html#abf3c342010bdd1d0ed3513cc6041e33aa0c6ad70beb3a7e76c3fc7adab7c46acc) = 0x00000100 ,     [VeryGood](class_tale_worlds_1_1_engine_1_1_highlights.html#abf3c342010bdd1d0ed3513cc6041e33aa2a1cf4164d0f021e171be092187c12e0) = 0x00000200 ,     [ExtremelyGoods](class_tale_worlds_1_1_engine_1_1_highlights.html#abf3c342010bdd1d0ed3513cc6041e33aac19ab83bdaaa4e8643021e30bb120cb2) = 0x00000400 ,     [Max](class_tale_worlds_1_1_engine_1_1_highlights.html#abf3c342010bdd1d0ed3513cc6041e33aa6a061313d22e51e0f25b7cd4dc065233) = 0x00000800   } |
| enum | [Type](class_tale_worlds_1_1_engine_1_1_highlights.html#ab77601119cd1137ba35d65aeda0047e7) {     [None](class_tale_worlds_1_1_engine_1_1_highlights.html#ab77601119cd1137ba35d65aeda0047e7a6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [Milestone](class_tale_worlds_1_1_engine_1_1_highlights.html#ab77601119cd1137ba35d65aeda0047e7ae9c626b8a8b62de7562dfbf51a576ae5) = 0x00000001 ,     [Achievement](class_tale_worlds_1_1_engine_1_1_highlights.html#ab77601119cd1137ba35d65aeda0047e7ae29be78e8cf65f9f1a934917f9e0903e) = 0x00000002 ,     [Incident](class_tale_worlds_1_1_engine_1_1_highlights.html#ab77601119cd1137ba35d65aeda0047e7a124617f0ad4a4ecb40ac0b9dcad97ed9) = 0x00000004 ,     [StateChange](class_tale_worlds_1_1_engine_1_1_highlights.html#ab77601119cd1137ba35d65aeda0047e7a2739cce740bc50af9f1b9ddfe1379fb7) = 0x00000008 ,     [Unannounced](class_tale_worlds_1_1_engine_1_1_highlights.html#ab77601119cd1137ba35d65aeda0047e7ab3512398a1cbf598187a05b0297ff5cc) = 0x00000010 ,     [Max](class_tale_worlds_1_1_engine_1_1_highlights.html#ab77601119cd1137ba35d65aeda0047e7a6a061313d22e51e0f25b7cd4dc065233) = 0x00000020   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [Initialize](class_tale_worlds_1_1_engine_1_1_highlights.html#a2126ea0aad43ecf372d000eb8ce00998) () |
| static void | [OpenGroup](class_tale_worlds_1_1_engine_1_1_highlights.html#a3dd935803d73a841a2a73df08485fdde) (string id) |
| static void | [CloseGroup](class_tale_worlds_1_1_engine_1_1_highlights.html#ac236c6b4d71f60b69b569d6001bb1e80) (string id, bool destroy=false) |
| static void | [SaveScreenshot](class_tale_worlds_1_1_engine_1_1_highlights.html#a9973c48046ee076624d0b4ff3f090a8b) (string highlightId, string groupId) |
| static void | [SaveVideo](class_tale_worlds_1_1_engine_1_1_highlights.html#af80768acc3549054d1dfdf40e32e6bd8) (string highlightId, string groupId, int startDelta, int endDelta) |
| static void | [OpenSummary](class_tale_worlds_1_1_engine_1_1_highlights.html#a67e173218315d52298be18e27cc05cff) (List< string > groups) |
| static void | [AddHighlight](class_tale_worlds_1_1_engine_1_1_highlights.html#abb9b477b422143d85b57168bad1186ba) (string id, string name) |
| static void | [RemoveHighlight](class_tale_worlds_1_1_engine_1_1_highlights.html#afeae357ec15dbfd4c5c4a63f97c91ec9) (string id) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_highlights.html#abf3c342010bdd1d0ed3513cc6041e33a)Significance
---------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Engine.Highlights.Significance](class_tale_worlds_1_1_engine_1_1_highlights.html#abf3c342010bdd1d0ed3513cc6041e33a) |

| Enumerator | |
| --- | --- |
| None |  |
| ExtremelyBad |  |
| VeryBad |  |
| Bad |  |
| Neutral |  |
| Good |  |
| VeryGood |  |
| ExtremelyGoods |  |
| Max |  |

[◆](class_tale_worlds_1_1_engine_1_1_highlights.html#ab77601119cd1137ba35d65aeda0047e7)Type
-------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Engine.Highlights.Type](class_tale_worlds_1_1_engine_1_1_highlights.html#ab77601119cd1137ba35d65aeda0047e7) |

| Enumerator | |
| --- | --- |
| None |  |
| Milestone |  |
| Achievement |  |
| Incident |  |
| StateChange |  |
| Unannounced |  |
| Max |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_highlights.html#a2126ea0aad43ecf372d000eb8ce00998)Initialize()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Highlights.Initialize | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_highlights.html#a3dd935803d73a841a2a73df08485fdde)OpenGroup()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Highlights.OpenGroup | ( | string | *id* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_highlights.html#ac236c6b4d71f60b69b569d6001bb1e80)CloseGroup()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Highlights.CloseGroup | ( | string | *id*, | |  |  | bool | *destroy* = false ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_highlights.html#a9973c48046ee076624d0b4ff3f090a8b)SaveScreenshot()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Highlights.SaveScreenshot | ( | string | *highlightId*, | |  |  | string | *groupId* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_highlights.html#af80768acc3549054d1dfdf40e32e6bd8)SaveVideo()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Highlights.SaveVideo | ( | string | *highlightId*, | |  |  | string | *groupId*, | |  |  | int | *startDelta*, | |  |  | int | *endDelta* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_highlights.html#a67e173218315d52298be18e27cc05cff)OpenSummary()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Highlights.OpenSummary | ( | List< string > | *groups* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_highlights.html#abb9b477b422143d85b57168bad1186ba)AddHighlight()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Highlights.AddHighlight | ( | string | *id*, | |  |  | string | *name* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_highlights.html#afeae357ec15dbfd4c5c4a63f97c91ec9)RemoveHighlight()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Highlights.RemoveHighlight | ( | string | *id* | ) |  | | static |


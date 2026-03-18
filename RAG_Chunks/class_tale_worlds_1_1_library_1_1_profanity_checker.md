--- SOURCE: class_tale_worlds_1_1_library_1_1_profanity_checker.html ---

TaleWorlds.Library.ProfanityChecker Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [ProfanityChechkerType](class_tale_worlds_1_1_library_1_1_profanity_checker.html#a1b9315d8abc0c966420cc02ee87d8f91) {     [FalsePositive](class_tale_worlds_1_1_library_1_1_profanity_checker.html#a1b9315d8abc0c966420cc02ee87d8f91a0dbf743880ba77b91ee8bf265b2eb3c4) ,     [FalseNegative](class_tale_worlds_1_1_library_1_1_profanity_checker.html#a1b9315d8abc0c966420cc02ee87d8f91a705cba8081b030d54d12237a5034a5c7)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ProfanityChecker](class_tale_worlds_1_1_library_1_1_profanity_checker.html#a305375ffc631369b71ebc3e30307617d) (string[] profanityList, string[] allowList) |
| bool | [IsProfane](class_tale_worlds_1_1_library_1_1_profanity_checker.html#a68c068538a7007f3672200d4c307b08e) (string word) |
| bool | [ContainsProfanity](class_tale_worlds_1_1_library_1_1_profanity_checker.html#aa7e7ee60e2e6977e3a99af5e9f02cb31) (string text, [ProfanityChechkerType](class_tale_worlds_1_1_library_1_1_profanity_checker.html#a1b9315d8abc0c966420cc02ee87d8f91) checkType) |
| string | [CensorText](class_tale_worlds_1_1_library_1_1_profanity_checker.html#ac6cfe82f39da34e1ae70ea9d05cfeb36) (string text) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_library_1_1_profanity_checker.html#a1b9315d8abc0c966420cc02ee87d8f91)ProfanityChechkerType
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Library.ProfanityChecker.ProfanityChechkerType](class_tale_worlds_1_1_library_1_1_profanity_checker.html#a1b9315d8abc0c966420cc02ee87d8f91) |

| Enumerator | |
| --- | --- |
| FalsePositive |  |
| FalseNegative |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_profanity_checker.html#a305375ffc631369b71ebc3e30307617d)ProfanityChecker()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.ProfanityChecker.ProfanityChecker | ( | string[] | *profanityList*, |
|  |  | string[] | *allowList* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_profanity_checker.html#a68c068538a7007f3672200d4c307b08e)IsProfane()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.ProfanityChecker.IsProfane | ( | string | *word* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_profanity_checker.html#aa7e7ee60e2e6977e3a99af5e9f02cb31)ContainsProfanity()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.ProfanityChecker.ContainsProfanity | ( | string | *text*, |
|  |  | [ProfanityChechkerType](class_tale_worlds_1_1_library_1_1_profanity_checker.html#a1b9315d8abc0c966420cc02ee87d8f91) | *checkType* ) |

[◆](class_tale_worlds_1_1_library_1_1_profanity_checker.html#ac6cfe82f39da34e1ae70ea9d05cfeb36)CensorText()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Library.ProfanityChecker.CensorText | ( | string | *text* | ) |  |


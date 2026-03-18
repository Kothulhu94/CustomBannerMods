--- SOURCE: class_tale_worlds_1_1_core_1_1_game_text_manager.html ---

TaleWorlds.Core.GameTextManager Class Reference|  |  |
| --- | --- |
| Classes | |
| struct | [ChoiceTag](struct_tale_worlds_1_1_core_1_1_game_text_manager_1_1_choice_tag.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GameTextManager](class_tale_worlds_1_1_core_1_1_game_text_manager.html#aff1a03d008425ad22476fc48624cc205) () |
| [GameText](class_tale_worlds_1_1_core_1_1_game_text.html) | [GetGameText](class_tale_worlds_1_1_core_1_1_game_text_manager.html#addbfbc0c1c549313219c512527525c69) (string id) |
| [GameText](class_tale_worlds_1_1_core_1_1_game_text.html) | [AddGameText](class_tale_worlds_1_1_core_1_1_game_text_manager.html#aa3d9a18ae97f6402e632fe21da14337b) (string id) |
| bool | [TryGetText](class_tale_worlds_1_1_core_1_1_game_text_manager.html#a9e5802d11101964e70be1e233fbb5de2) (string id, string variation, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [FindText](class_tale_worlds_1_1_core_1_1_game_text_manager.html#a50954eefe8d6fa1e3e9f912b88eabc55) (string id, string variation=null) |
| IEnumerable< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [FindAllTextVariations](class_tale_worlds_1_1_core_1_1_game_text_manager.html#a050b34e7a1ddbe500f2fac761a1e875d) (string id) |
| void | [LoadGameTexts](class_tale_worlds_1_1_core_1_1_game_text_manager.html#af51efaeb6a256e8f3b637ae7fb888bc4) () |
| void | [LoadDefaultTexts](class_tale_worlds_1_1_core_1_1_game_text_manager.html#a9b72f26e9103ff45a539287db18acff9) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_text_manager.html#aff1a03d008425ad22476fc48624cc205)GameTextManager()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.GameTextManager.GameTextManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_game_text_manager.html#addbfbc0c1c549313219c512527525c69)GetGameText()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameText](class_tale_worlds_1_1_core_1_1_game_text.html) TaleWorlds.Core.GameTextManager.GetGameText | ( | string | *id* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_text_manager.html#aa3d9a18ae97f6402e632fe21da14337b)AddGameText()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameText](class_tale_worlds_1_1_core_1_1_game_text.html) TaleWorlds.Core.GameTextManager.AddGameText | ( | string | *id* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_text_manager.html#a9e5802d11101964e70be1e233fbb5de2)TryGetText()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Core.GameTextManager.TryGetText | ( | string | *id*, |
|  |  | string | *variation*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text* ) |

[◆](class_tale_worlds_1_1_core_1_1_game_text_manager.html#a50954eefe8d6fa1e3e9f912b88eabc55)FindText()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.GameTextManager.FindText | ( | string | *id*, |
|  |  | string | *variation* = null ) |

[◆](class_tale_worlds_1_1_core_1_1_game_text_manager.html#a050b34e7a1ddbe500f2fac761a1e875d)FindAllTextVariations()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > TaleWorlds.Core.GameTextManager.FindAllTextVariations | ( | string | *id* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_text_manager.html#af51efaeb6a256e8f3b637ae7fb888bc4)LoadGameTexts()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameTextManager.LoadGameTexts | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_game_text_manager.html#a9b72f26e9103ff45a539287db18acff9)LoadDefaultTexts()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.GameTextManager.LoadDefaultTexts | ( |  | ) |  |


--- SOURCE: class_tale_worlds_1_1_core_1_1_character_code.html ---

TaleWorlds.Core.CharacterCode Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [CalculateEquipment](class_tale_worlds_1_1_core_1_1_character_code.html#a31ec8d27515d1fe3a83062e5be5ceba7) () |
| string | [CreateNewCodeString](class_tale_worlds_1_1_core_1_1_character_code.html#a2a71f9e98bef8f0c0e9572f63d0b6de1) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static CharacterCode | [CreateFrom](class_tale_worlds_1_1_core_1_1_character_code.html#aad19a270904eff9c359a914ab646f3ff) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character) |
| static CharacterCode | [CreateFrom](class_tale_worlds_1_1_core_1_1_character_code.html#a6169bfb4578665e359e5403d1db0bb35) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) equipment) |
| static CharacterCode | [CreateFrom](class_tale_worlds_1_1_core_1_1_character_code.html#a22389f1ad4ee567705a2ae6df14e4a9a) (string equipmentCode, [BodyProperties](class_tale_worlds_1_1_core_1_1_character_code.html#a02504e1f499ecb6fb11c5e0e56a50c9a) bodyProperties, bool isFemale, bool isHero, uint color1, uint color2, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass, int race) |
| static CharacterCode | [CreateEmpty](class_tale_worlds_1_1_core_1_1_character_code.html#a8a21f71f03a78b2138034b4864725ee2) () |
| static CharacterCode | [CreateFrom](class_tale_worlds_1_1_core_1_1_character_code.html#ac458f34660be6483770254498bce0853) (string code) |

|  |  |
| --- | --- |
| Public Attributes | |
| BodyProperties | [BodyProperties](class_tale_worlds_1_1_core_1_1_character_code.html#a02504e1f499ecb6fb11c5e0e56a50c9a) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [SpecialCodeSeparator](class_tale_worlds_1_1_core_1_1_character_code.html#a1e6b9b57e4970cd0cbbf25e520c078e7) = "@---@" |
| const int | [SpecialCodeSeparatorLength](class_tale_worlds_1_1_core_1_1_character_code.html#aeed412e498c7dbd2a4f6ed2829ee9dda) = 5 |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsEmpty](class_tale_worlds_1_1_core_1_1_character_code.html#ac6a8f0b8bc29084f73d25532426fd802) `[get]` |
| string | [EquipmentCode](class_tale_worlds_1_1_core_1_1_character_code.html#a2e98f1e1d7e1bd1afd3c9661de593e8f) `[get]` |
| string | [Code](class_tale_worlds_1_1_core_1_1_character_code.html#af731380448d954959ba49e52a92d95b5) `[get]` |
| bool | [IsFemale](class_tale_worlds_1_1_core_1_1_character_code.html#ad1ee6bd990013f356e5acfb08cede213) `[get]` |
| bool | [IsHero](class_tale_worlds_1_1_core_1_1_character_code.html#abc87ec46d63af2877c8865d93cfdbe59) `[get]` |
| float | [FaceDirtAmount](class_tale_worlds_1_1_core_1_1_character_code.html#ad824eb0f46d67b33c5e6873a3c6b287a) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_core_1_1_character_code.html#a56e7ef48a331298836f9f8be63cd25f5) `[get]` |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [FormationClass](class_tale_worlds_1_1_core_1_1_character_code.html#a8e5eb8212a181931562ba2d67b3e0417) `[get, set]` |
| uint | [Color1](class_tale_worlds_1_1_core_1_1_character_code.html#a32a35fc3f755747a6633c4d20a4c6789) = Color.White.ToUnsignedInteger() `[get, set]` |
| uint | [Color2](class_tale_worlds_1_1_core_1_1_character_code.html#a4160047a4f141cc47fc918ef62c0127c) = Color.White.ToUnsignedInteger() `[get, set]` |
| int | [Race](class_tale_worlds_1_1_core_1_1_character_code.html#ac81bc1421fada1a2171ad0eb47780bb5) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#a31ec8d27515d1fe3a83062e5be5ceba7)CalculateEquipment()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.Core.CharacterCode.CalculateEquipment | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#aad19a270904eff9c359a914ab646f3ff)CreateFrom() [1/4]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CharacterCode TaleWorlds.Core.CharacterCode.CreateFrom | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#a6169bfb4578665e359e5403d1db0bb35)CreateFrom() [2/4]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | CharacterCode TaleWorlds.Core.CharacterCode.CreateFrom | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, | |  |  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *equipment* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#a22389f1ad4ee567705a2ae6df14e4a9a)CreateFrom() [3/4]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | CharacterCode TaleWorlds.Core.CharacterCode.CreateFrom | ( | string | *equipmentCode*, | |  |  | [BodyProperties](class_tale_worlds_1_1_core_1_1_character_code.html#a02504e1f499ecb6fb11c5e0e56a50c9a) | *bodyProperties*, | |  |  | bool | *isFemale*, | |  |  | bool | *isHero*, | |  |  | uint | *color1*, | |  |  | uint | *color2*, | |  |  | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass*, | |  |  | int | *race* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#a2a71f9e98bef8f0c0e9572f63d0b6de1)CreateNewCodeString()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Core.CharacterCode.CreateNewCodeString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#a8a21f71f03a78b2138034b4864725ee2)CreateEmpty()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | CharacterCode TaleWorlds.Core.CharacterCode.CreateEmpty | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#ac458f34660be6483770254498bce0853)CreateFrom() [4/4]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CharacterCode TaleWorlds.Core.CharacterCode.CreateFrom | ( | string | *code* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#a1e6b9b57e4970cd0cbbf25e520c078e7)SpecialCodeSeparator
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.Core.CharacterCode.SpecialCodeSeparator = "@---@" | | static |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#aeed412e498c7dbd2a4f6ed2829ee9dda)SpecialCodeSeparatorLength
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.CharacterCode.SpecialCodeSeparatorLength = 5 | | static |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#a02504e1f499ecb6fb11c5e0e56a50c9a)BodyProperties
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| BodyProperties TaleWorlds.Core.CharacterCode.BodyProperties |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#ac6a8f0b8bc29084f73d25532426fd802)IsEmpty
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.CharacterCode.IsEmpty | | get |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#a2e98f1e1d7e1bd1afd3c9661de593e8f)EquipmentCode
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.CharacterCode.EquipmentCode | | get |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#af731380448d954959ba49e52a92d95b5)Code
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.CharacterCode.Code | | get |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#ad1ee6bd990013f356e5acfb08cede213)IsFemale
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.CharacterCode.IsFemale | | get |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#abc87ec46d63af2877c8865d93cfdbe59)IsHero
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.CharacterCode.IsHero | | get |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#ad824eb0f46d67b33c5e6873a3c6b287a)FaceDirtAmount
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.CharacterCode.FaceDirtAmount | | get |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#a56e7ef48a331298836f9f8be63cd25f5)Banner
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.Core.CharacterCode.Banner | | get |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#a8e5eb8212a181931562ba2d67b3e0417)FormationClass
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.Core.CharacterCode.FormationClass | | getset |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#a32a35fc3f755747a6633c4d20a4c6789)Color1
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.CharacterCode.Color1 = Color.White.ToUnsignedInteger() | | getset |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#a4160047a4f141cc47fc918ef62c0127c)Color2
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.CharacterCode.Color2 = Color.White.ToUnsignedInteger() | | getset |

[◆](class_tale_worlds_1_1_core_1_1_character_code.html#ac81bc1421fada1a2171ad0eb47780bb5)Race
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.CharacterCode.Race | | get |


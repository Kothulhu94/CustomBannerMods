--- SOURCE: class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html ---

TaleWorlds.Core.MBHaltonColorGenerator Class ReferenceGenerates unique colors using halton sequence...

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MBHaltonColorGenerator](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a892c46e4e95e4e68e2661343c617e365) () |
| void | [SetBase](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#aab1f6e12c7473a1634f7006ccc0ee3c1) () |
| void | [SetBase](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a1772dfbd5a8ade7235a07e50fc333b00) (int baseValue) |
|  | Sets bases for the halton generator. Ideally these should be prime numbers. |
| void | [SetOffset](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a1477a231f26f955624e83a2f76150df5) (float offset) |
|  | Sets starting offset for individual colors. Must be in range [0,1]. |
| void | [SetRandomOffset](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#ae85c0a0efcf982e8c6a82c356f88a070) () |
|  | Initializes random offset for color channels in range [0,1) per channel. |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [GetColor](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a8a3d070b68442d8cd94b552c73ed9e65) (int index, int maxIndex) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [DefaultBase](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a62b25ca6dde7f9a1eea3959ff3e35aec) = 2 |

|  |  |
| --- | --- |
| Properties | |
| int | [Base](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a5ef438d5dfc939e5c7bc0edac4bee1f1) `[get]` |
| float | [Offset](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a406be709ac4d819127aef995d24122ab) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a892c46e4e95e4e68e2661343c617e365)MBHaltonColorGenerator()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.MBHaltonColorGenerator.MBHaltonColorGenerator | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#aab1f6e12c7473a1634f7006ccc0ee3c1)SetBase() [1/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.MBHaltonColorGenerator.SetBase | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a1772dfbd5a8ade7235a07e50fc333b00)SetBase() [2/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.MBHaltonColorGenerator.SetBase | ( | int | *baseValue* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a1477a231f26f955624e83a2f76150df5)SetOffset()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.MBHaltonColorGenerator.SetOffset | ( | float | *offset* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#ae85c0a0efcf982e8c6a82c356f88a070)SetRandomOffset()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.MBHaltonColorGenerator.SetRandomOffset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a8a3d070b68442d8cd94b552c73ed9e65)GetColor()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.Core.MBHaltonColorGenerator.GetColor | ( | int | *index*, |
|  |  | int | *maxIndex* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a62b25ca6dde7f9a1eea3959ff3e35aec)DefaultBase
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.MBHaltonColorGenerator.DefaultBase = 2 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a5ef438d5dfc939e5c7bc0edac4bee1f1)Base
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.MBHaltonColorGenerator.Base | | get |

[◆](class_tale_worlds_1_1_core_1_1_m_b_halton_color_generator.html#a406be709ac4d819127aef995d24122ab)Offset
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MBHaltonColorGenerator.Offset | | get |


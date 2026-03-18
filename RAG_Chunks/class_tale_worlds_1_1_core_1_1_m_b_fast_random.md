--- SOURCE: class_tale_worlds_1_1_core_1_1_m_b_fast_random.html ---

TaleWorlds.Core.MBFastRandom Class ReferenceFaster pseudo-random generator based on xor-shift having the same interface as System.Random Adapted from "A fast equivalent for System.Random" by colgreen. Link: <https://www.codeproject.com/Articles/9187/A-fast-equivalent-for-System-Random> Based on a simple and fast xor-shift pseudo random number generator specified in: Marsaglia, George. (2003). Xorshift RNGs. <http://www.jstatsoft.org/v08/i14/xorshift.pdf> REMARK\_ATES: This version is simplified and a bit improved for performance. Also added random float computation.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MBFastRandom](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#aee5725b73ad9798964eca442378589d8) () |
|  | Initialises a new fast random generator using environment tick count as seed. |
|  | [MBFastRandom](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#aad02da433ce67516510eec1552bdb7bb) (uint seed) |
|  | Initialises a new fast random generator using an int value as seed. |
| void | [SetSeed](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#a580370cec43c7665114b7e8a4cbaf2c7) (uint seed, uint seed2) |
| int | [Next](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#af9393c5c63b94d5532fd8a46f676f49c) () |
|  | Returns a non-negative random integer. |
| int | [Next](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#a0fe5d913ffb3759dc049144e2e36c0ce) (int maxValue) |
|  | Returns a non-negative random integer that is less than the specified maximum. |
| int | [Next](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#abe8bcd283dac1e87ff2f4cf04a078ebb) (int minValue, int maxValue) |
|  | Returns a random integer that is within a specified range. |
| double | [NextDouble](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#a8a82f88ea4d2d51b783df82a80cba8b0) () |
|  | Returns a random double that is greater than or equal to 0.0, and less than 1.0. |
| float | [NextFloat](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#a8d4cc8d19d88279c956c7264f187813b) () |
|  | Returns a random float that is greater than or equal to 0.0, and less than 1.0. |
| float | [NextFloatRanged](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#aa33c6b152ccd4e109af0bb54a424d84d) (float minVal, float maxVal) |
| void | [NextBytes](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#a638cd513e7f7d1214cea3b218998cd9c) (byte[] buffer) |
|  | Fills the elements of a specified array of bytes with random numbers. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#aee5725b73ad9798964eca442378589d8)MBFastRandom() [1/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.MBFastRandom.MBFastRandom | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#aad02da433ce67516510eec1552bdb7bb)MBFastRandom() [2/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.MBFastRandom.MBFastRandom | ( | uint | *seed* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#a580370cec43c7665114b7e8a4cbaf2c7)SetSeed()
---------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.MBFastRandom.SetSeed | ( | uint | *seed*, |
|  |  | uint | *seed2* ) |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#af9393c5c63b94d5532fd8a46f676f49c)Next() [1/3]
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Core.MBFastRandom.Next | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#a0fe5d913ffb3759dc049144e2e36c0ce)Next() [2/3]
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.MBFastRandom.Next | ( | int | *maxValue* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | maxValue | The exclusive upper bound of the random number to be generated. maxValue must be greater than or equal to 0. |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#abe8bcd283dac1e87ff2f4cf04a078ebb)Next() [3/3]
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Core.MBFastRandom.Next | ( | int | *minValue*, |
|  |  | int | *maxValue* ) |

Parameters
:   |  |  |
    | --- | --- |
    | minValue | The inclusive lower bound of the random number returned. |
    | maxValue | The exclusive upper bound of the random number returned. maxValue must be greater than or equal to minValue. |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#a8a82f88ea4d2d51b783df82a80cba8b0)NextDouble()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| double TaleWorlds.Core.MBFastRandom.NextDouble | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#a8d4cc8d19d88279c956c7264f187813b)NextFloat()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Core.MBFastRandom.NextFloat | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#aa33c6b152ccd4e109af0bb54a424d84d)NextFloatRanged()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.Core.MBFastRandom.NextFloatRanged | ( | float | *minVal*, |
|  |  | float | *maxVal* ) |

[◆](class_tale_worlds_1_1_core_1_1_m_b_fast_random.html#a638cd513e7f7d1214cea3b218998cd9c)NextBytes()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.MBFastRandom.NextBytes | ( | byte[] | *buffer* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | buffer | The array to be filled with random numbers. |


--- SOURCE: class_tale_worlds_1_1_core_1_1_m_b_random.html ---

TaleWorlds.Core.MBRandom Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static float | [RandomFloatRanged](class_tale_worlds_1_1_core_1_1_m_b_random.html#aef2c90a64a6646a99cb32fb5419aaee9) (float maxVal) |
| static float | [RandomFloatRanged](class_tale_worlds_1_1_core_1_1_m_b_random.html#a5ea078799f2c1f4f3f841c8213df0ac1) (float minVal, float maxVal) |
| static int | [RandomInt](class_tale_worlds_1_1_core_1_1_m_b_random.html#a7d276a08934ed0203f18e814b5584619) () |
| static int | [RandomInt](class_tale_worlds_1_1_core_1_1_m_b_random.html#ab5d7a299141b4fd1e04e914a848f1dd6) (int maxValue) |
|  | Returns a non-negative random integer that is less than the specified maximum. |
| static int | [RandomInt](class_tale_worlds_1_1_core_1_1_m_b_random.html#af554f2182bdadf02e21df5128aaf3e5a) (int minValue, int maxValue) |
| static int | [RoundRandomized](class_tale_worlds_1_1_core_1_1_m_b_random.html#a0caddafc82d6da56cd64a2340f4a2d98) (float f) |
| static T | [ChooseWeighted< T >](class_tale_worlds_1_1_core_1_1_m_b_random.html#a5cef515b8f8cbd524aed789d58c604f4) (IReadOnlyList< ValueTuple< T, float > > weightList) |
|  | This function only works if w is bigger than 0. |
| static T | [ChooseWeighted< T >](class_tale_worlds_1_1_core_1_1_m_b_random.html#acc5aabf12262bb212c88496ce980bb05) (IReadOnlyList< ValueTuple< T, float > > weightList, out int chosenIndex) |
| static float | [RandomFloatGaussian](class_tale_worlds_1_1_core_1_1_m_b_random.html#a9f6443f67b7325fedaabd85dda11c2e9) (float center, float spread, float min, float max) |
| static void | [SetSeed](class_tale_worlds_1_1_core_1_1_m_b_random.html#a3d9f929ca8f608d975c6670d2a795254) (uint seed, uint seed2) |
| static int | [RandomIntWithSeed](class_tale_worlds_1_1_core_1_1_m_b_random.html#abc0610349ca1c3287682d17b1158ba67) (uint seed, uint seed2) |
|  | Returns a non-negative random integer with seed. |
| static float | [RandomFloatWithSeed](class_tale_worlds_1_1_core_1_1_m_b_random.html#a258afa76c2602e97b3f642e869fb3fde) (uint seed, uint seed2) |
|  | Returns a random float with seed that is greater than or equal to 0.0, and less than 1.0 with Seed. |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MaxSeed](class_tale_worlds_1_1_core_1_1_m_b_random.html#a0ebff9d70f30283312a3f7109542f60e) = 2000 |

|  |  |
| --- | --- |
| Properties | |
| static float | [RandomFloat](class_tale_worlds_1_1_core_1_1_m_b_random.html#ad97b69983e86c2874afb962ef6cd8a86) `[get]` |
|  | Returns a random number between 0.0 and 1.0 (exclusive). |
| static float | [RandomFloatNormal](class_tale_worlds_1_1_core_1_1_m_b_random.html#ade6b3c11412ff700b106ccfc750bab92) `[get]` |
|  | Returns a random number with normal distribution between -1.0 and 1.0. |
| static float | [NondeterministicRandomFloat](class_tale_worlds_1_1_core_1_1_m_b_random.html#a99a45d6a5494966016a69bd4423398a0) `[get]` |
|  | Returns Nondeterministic a random number between 0.0 and 1.0 (exclusive). |
| static int | [NondeterministicRandomInt](class_tale_worlds_1_1_core_1_1_m_b_random.html#a91531cb7aa91a64d1947259fe5fd5a7f) `[get]` |
|  | Returns Nondeterministic a random number between 0 and int.max. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#aef2c90a64a6646a99cb32fb5419aaee9)RandomFloatRanged() [1/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Core.MBRandom.RandomFloatRanged | ( | float | *maxVal* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#a5ea078799f2c1f4f3f841c8213df0ac1)RandomFloatRanged() [2/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Core.MBRandom.RandomFloatRanged | ( | float | *minVal*, | |  |  | float | *maxVal* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#a7d276a08934ed0203f18e814b5584619)RandomInt() [1/3]
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Core.MBRandom.RandomInt | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#ab5d7a299141b4fd1e04e914a848f1dd6)RandomInt() [2/3]
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Core.MBRandom.RandomInt | ( | int | *maxValue* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#af554f2182bdadf02e21df5128aaf3e5a)RandomInt() [3/3]
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Core.MBRandom.RandomInt | ( | int | *minValue*, | |  |  | int | *maxValue* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#a0caddafc82d6da56cd64a2340f4a2d98)RoundRandomized()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Core.MBRandom.RoundRandomized | ( | float | *f* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#a5cef515b8f8cbd524aed789d58c604f4)ChooseWeighted< T >() [1/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T TaleWorlds.Core.MBRandom.ChooseWeighted< T > | ( | IReadOnlyList< ValueTuple< T, float > > | *weightList* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#acc5aabf12262bb212c88496ce980bb05)ChooseWeighted< T >() [2/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | T TaleWorlds.Core.MBRandom.ChooseWeighted< T > | ( | IReadOnlyList< ValueTuple< T, float > > | *weightList*, | |  |  | out int | *chosenIndex* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#a9f6443f67b7325fedaabd85dda11c2e9)RandomFloatGaussian()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Core.MBRandom.RandomFloatGaussian | ( | float | *center*, | |  |  | float | *spread*, | |  |  | float | *min*, | |  |  | float | *max* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#a3d9f929ca8f608d975c6670d2a795254)SetSeed()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.MBRandom.SetSeed | ( | uint | *seed*, | |  |  | uint | *seed2* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#abc0610349ca1c3287682d17b1158ba67)RandomIntWithSeed()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Core.MBRandom.RandomIntWithSeed | ( | uint | *seed*, | |  |  | uint | *seed2* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#a258afa76c2602e97b3f642e869fb3fde)RandomFloatWithSeed()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Core.MBRandom.RandomFloatWithSeed | ( | uint | *seed*, | |  |  | uint | *seed2* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#a0ebff9d70f30283312a3f7109542f60e)MaxSeed
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.MBRandom.MaxSeed = 2000 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#ad97b69983e86c2874afb962ef6cd8a86)RandomFloat
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MBRandom.RandomFloat | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#ade6b3c11412ff700b106ccfc750bab92)RandomFloatNormal
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MBRandom.RandomFloatNormal | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#a99a45d6a5494966016a69bd4423398a0)NondeterministicRandomFloat
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MBRandom.NondeterministicRandomFloat | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_m_b_random.html#a91531cb7aa91a64d1947259fe5fd5a7f)NondeterministicRandomInt
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.MBRandom.NondeterministicRandomInt | | staticget |


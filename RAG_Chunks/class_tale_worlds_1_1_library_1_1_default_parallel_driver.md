--- SOURCE: class_tale_worlds_1_1_library_1_1_default_parallel_driver.html ---

TaleWorlds.Library.DefaultParallelDriver Class ReferencesealedInherits [TaleWorlds.Library.IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [For](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#a79bef9264709ae9360ece9554a9f45d9) (int fromInclusive, int toExclusive, [TWParallel.ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) body, int grainSize) |
| void | [ForWithoutRenderThread](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#a08db0fb6ea9a18c8894d829d36e72e85) (int fromInclusive, int toExclusive, [TWParallel.ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) body, int grainSize) |
| void | [For](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#afa70425a82f3c69104257f6921e0b80a) (int fromInclusive, int toExclusive, float deltaTime, [TWParallel.ParallelForWithDtAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a0b53efb684a00886c72b154ddf96443b) body, int grainSize) |
| ulong | [GetMainThreadId](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#abc3d90765389b6838d63ca3c6cf929dc) () |
| ulong | [GetCurrentThreadId](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#a1675ce0c096a6a12fe6caf3a3f850060) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#a79bef9264709ae9360ece9554a9f45d9)For() [1/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.DefaultParallelDriver.For | ( | int | *fromInclusive*, |
|  |  | int | *toExclusive*, |
|  |  | [TWParallel.ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) | *body*, |
|  |  | int | *grainSize* ) |

Implements [TaleWorlds.Library.IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#a6ca4a54e1f11038317efcad8c0d0a3a7).

[◆](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#a08db0fb6ea9a18c8894d829d36e72e85)ForWithoutRenderThread()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.DefaultParallelDriver.ForWithoutRenderThread | ( | int | *fromInclusive*, |
|  |  | int | *toExclusive*, |
|  |  | [TWParallel.ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) | *body*, |
|  |  | int | *grainSize* ) |

Implements [TaleWorlds.Library.IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#ab60654f898951e13a2d4df30723c9a0f).

[◆](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#afa70425a82f3c69104257f6921e0b80a)For() [2/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.DefaultParallelDriver.For | ( | int | *fromInclusive*, |
|  |  | int | *toExclusive*, |
|  |  | float | *deltaTime*, |
|  |  | [TWParallel.ParallelForWithDtAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a0b53efb684a00886c72b154ddf96443b) | *body*, |
|  |  | int | *grainSize* ) |

Implements [TaleWorlds.Library.IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#ab69958cca835c4c871f699bdec009713).

[◆](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#abc3d90765389b6838d63ca3c6cf929dc)GetMainThreadId()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| ulong TaleWorlds.Library.DefaultParallelDriver.GetMainThreadId | ( |  | ) |  |

Implements [TaleWorlds.Library.IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#a18190a45286d8e4a3f3f4810b19d0008).

[◆](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#a1675ce0c096a6a12fe6caf3a3f850060)GetCurrentThreadId()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| ulong TaleWorlds.Library.DefaultParallelDriver.GetCurrentThreadId | ( |  | ) |  |

Implements [TaleWorlds.Library.IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#a8196de7fafd53cd41c5f305be43b4b0f).


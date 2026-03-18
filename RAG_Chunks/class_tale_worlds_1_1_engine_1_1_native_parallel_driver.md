--- SOURCE: class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html ---

TaleWorlds.Engine.NativeParallelDriver Class ReferencesealedInherits [TaleWorlds.Library.IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [For](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#afcd795bec9bd161c725c381c65134b4a) (int fromInclusive, int toExclusive, [TWParallel.ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) loopBody, int grainSize) |
| void | [ForWithoutRenderThread](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#a0e28f66c8d95774de6083338ff57412c) (int fromInclusive, int toExclusive, [TWParallel.ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) loopBody, int grainSize) |
| void | [For](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#ae46e14ecc8388abb2fc95410d3b0368e) (int fromInclusive, int toExclusive, float deltaTime, [TWParallel.ParallelForWithDtAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a0b53efb684a00886c72b154ddf96443b) loopBody, int grainSize) |
| ulong | [GetMainThreadId](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#a5302d3d4016c93d214d8a27e17d02891) () |
| ulong | [GetCurrentThreadId](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#a2fa8ed510182fa5952e3c1e19084fff0) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#afcd795bec9bd161c725c381c65134b4a)For() [1/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.NativeParallelDriver.For | ( | int | *fromInclusive*, |
|  |  | int | *toExclusive*, |
|  |  | [TWParallel.ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) | *loopBody*, |
|  |  | int | *grainSize* ) |

Implements [TaleWorlds.Library.IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#a6ca4a54e1f11038317efcad8c0d0a3a7).

[◆](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#a0e28f66c8d95774de6083338ff57412c)ForWithoutRenderThread()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.NativeParallelDriver.ForWithoutRenderThread | ( | int | *fromInclusive*, |
|  |  | int | *toExclusive*, |
|  |  | [TWParallel.ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) | *loopBody*, |
|  |  | int | *grainSize* ) |

Implements [TaleWorlds.Library.IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#ab60654f898951e13a2d4df30723c9a0f).

[◆](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#ae46e14ecc8388abb2fc95410d3b0368e)For() [2/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.NativeParallelDriver.For | ( | int | *fromInclusive*, |
|  |  | int | *toExclusive*, |
|  |  | float | *deltaTime*, |
|  |  | [TWParallel.ParallelForWithDtAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a0b53efb684a00886c72b154ddf96443b) | *loopBody*, |
|  |  | int | *grainSize* ) |

Implements [TaleWorlds.Library.IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#ab69958cca835c4c871f699bdec009713).

[◆](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#a5302d3d4016c93d214d8a27e17d02891)GetMainThreadId()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| ulong TaleWorlds.Engine.NativeParallelDriver.GetMainThreadId | ( |  | ) |  |

Implements [TaleWorlds.Library.IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#a18190a45286d8e4a3f3f4810b19d0008).

[◆](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#a2fa8ed510182fa5952e3c1e19084fff0)GetCurrentThreadId()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| ulong TaleWorlds.Engine.NativeParallelDriver.GetCurrentThreadId | ( |  | ) |  |

Implements [TaleWorlds.Library.IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#a8196de7fafd53cd41c5f305be43b4b0f).


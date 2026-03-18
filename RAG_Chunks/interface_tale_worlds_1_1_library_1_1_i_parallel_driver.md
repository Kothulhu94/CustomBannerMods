--- SOURCE: interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html ---

TaleWorlds.Library.IParallelDriver Interface ReferenceInherited by [TaleWorlds.Engine.NativeParallelDriver](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html), and [TaleWorlds.Library.DefaultParallelDriver](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [For](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#a6ca4a54e1f11038317efcad8c0d0a3a7) (int fromInclusive, int toExclusive, [TWParallel.ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) body, int grainSize) |
| void | [ForWithoutRenderThread](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#ab60654f898951e13a2d4df30723c9a0f) (int fromInclusive, int toExclusive, [TWParallel.ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) body, int grainSize) |
| void | [For](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#ab69958cca835c4c871f699bdec009713) (int fromInclusive, int toExclusive, float deltaTime, [TWParallel.ParallelForWithDtAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a0b53efb684a00886c72b154ddf96443b) body, int grainSize) |
| ulong | [GetMainThreadId](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#a18190a45286d8e4a3f3f4810b19d0008) () |
| ulong | [GetCurrentThreadId](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#a8196de7fafd53cd41c5f305be43b4b0f) () |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#a6ca4a54e1f11038317efcad8c0d0a3a7)For() [1/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IParallelDriver.For | ( | int | *fromInclusive*, |
|  |  | int | *toExclusive*, |
|  |  | [TWParallel.ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) | *body*, |
|  |  | int | *grainSize* ) |

Implemented in [TaleWorlds.Engine.NativeParallelDriver](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#afcd795bec9bd161c725c381c65134b4a), and [TaleWorlds.Library.DefaultParallelDriver](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#a79bef9264709ae9360ece9554a9f45d9).

[◆](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#ab60654f898951e13a2d4df30723c9a0f)ForWithoutRenderThread()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IParallelDriver.ForWithoutRenderThread | ( | int | *fromInclusive*, |
|  |  | int | *toExclusive*, |
|  |  | [TWParallel.ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) | *body*, |
|  |  | int | *grainSize* ) |

Implemented in [TaleWorlds.Engine.NativeParallelDriver](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#a0e28f66c8d95774de6083338ff57412c), and [TaleWorlds.Library.DefaultParallelDriver](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#a08db0fb6ea9a18c8894d829d36e72e85).

[◆](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#ab69958cca835c4c871f699bdec009713)For() [2/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.IParallelDriver.For | ( | int | *fromInclusive*, |
|  |  | int | *toExclusive*, |
|  |  | float | *deltaTime*, |
|  |  | [TWParallel.ParallelForWithDtAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a0b53efb684a00886c72b154ddf96443b) | *body*, |
|  |  | int | *grainSize* ) |

Implemented in [TaleWorlds.Engine.NativeParallelDriver](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#ae46e14ecc8388abb2fc95410d3b0368e), and [TaleWorlds.Library.DefaultParallelDriver](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#afa70425a82f3c69104257f6921e0b80a).

[◆](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#a18190a45286d8e4a3f3f4810b19d0008)GetMainThreadId()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| ulong TaleWorlds.Library.IParallelDriver.GetMainThreadId | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.NativeParallelDriver](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#a5302d3d4016c93d214d8a27e17d02891), and [TaleWorlds.Library.DefaultParallelDriver](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#abc3d90765389b6838d63ca3c6cf929dc).

[◆](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html#a8196de7fafd53cd41c5f305be43b4b0f)GetCurrentThreadId()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| ulong TaleWorlds.Library.IParallelDriver.GetCurrentThreadId | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.NativeParallelDriver](class_tale_worlds_1_1_engine_1_1_native_parallel_driver.html#a2fa8ed510182fa5952e3c1e19084fff0), and [TaleWorlds.Library.DefaultParallelDriver](class_tale_worlds_1_1_library_1_1_default_parallel_driver.html#a1675ce0c096a6a12fe6caf3a3f850060).


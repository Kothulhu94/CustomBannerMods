--- SOURCE: class_tale_worlds_1_1_library_1_1_t_w_parallel.html ---

TaleWorlds.Library.TWParallel Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) (int localStartIndex, int localEndIndex) |
| delegate void | [ParallelForWithDtAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a0b53efb684a00886c72b154ddf96443b) (int localStartIndex, int localEndIndex, float dt) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [InitializeAndSetImplementation](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a95a38dd906a08911eed45797c4519536) ([IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html) parallelDriver) |
| static ParallelLoopResult | [ForEach< TSource >](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#ae58a1572bed20c10b197a5e19776019c) (IEnumerable< TSource > source, Action< TSource > body) |
| static void | [ForEach< TSource >](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#ac79961171adaee9550b8f8d246a89f8d) (IList< TSource > source, Action< TSource > body) |
| static void | [For](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#aaa751350ff8e121999450316b5dbd3b7) (int fromInclusive, int toExclusive, [ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) body, int grainSize=16) |
| static void | [ForWithoutRenderThread](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a407efeccfe7dca36a26c488a1bff86c6) (int fromInclusive, int toExclusive, [ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) body, int grainSize=16) |
| static void | [For](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a5d4ce5a445d20d4cf030030488aa2d5d) (int fromInclusive, int toExclusive, float deltaTime, [ParallelForWithDtAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a0b53efb684a00886c72b154ddf96443b) body, int grainSize=16) |
| static void | [AssertIsMainThread](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a201ca8f32796926320b13686f51246bb) () |
| static bool | [IsMainThread](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#adad211130fc885ee17a1ab5904f3ae07) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958)ParallelForAuxPredicate()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.Library.TWParallel.ParallelForAuxPredicate | ( | int | *localStartIndex*, |
|  |  | int | *localEndIndex* ) |

[◆](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a0b53efb684a00886c72b154ddf96443b)ParallelForWithDtAuxPredicate()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.Library.TWParallel.ParallelForWithDtAuxPredicate | ( | int | *localStartIndex*, |
|  |  | int | *localEndIndex*, |
|  |  | float | *dt* ) |

[◆](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a95a38dd906a08911eed45797c4519536)InitializeAndSetImplementation()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.TWParallel.InitializeAndSetImplementation | ( | [IParallelDriver](interface_tale_worlds_1_1_library_1_1_i_parallel_driver.html) | *parallelDriver* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#ae58a1572bed20c10b197a5e19776019c)ForEach< TSource >() [1/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ParallelLoopResult TaleWorlds.Library.TWParallel.ForEach< TSource > | ( | IEnumerable< TSource > | *source*, | |  |  | Action< TSource > | *body* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#ac79961171adaee9550b8f8d246a89f8d)ForEach< TSource >() [2/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.TWParallel.ForEach< TSource > | ( | IList< TSource > | *source*, | |  |  | Action< TSource > | *body* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#aaa751350ff8e121999450316b5dbd3b7)For() [1/2]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.TWParallel.For | ( | int | *fromInclusive*, | |  |  | int | *toExclusive*, | |  |  | [ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) | *body*, | |  |  | int | *grainSize* = 16 ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a407efeccfe7dca36a26c488a1bff86c6)ForWithoutRenderThread()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.TWParallel.ForWithoutRenderThread | ( | int | *fromInclusive*, | |  |  | int | *toExclusive*, | |  |  | [ParallelForAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a389587a3f44ccd61baccdf8ed5f01958) | *body*, | |  |  | int | *grainSize* = 16 ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a5d4ce5a445d20d4cf030030488aa2d5d)For() [2/2]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.TWParallel.For | ( | int | *fromInclusive*, | |  |  | int | *toExclusive*, | |  |  | float | *deltaTime*, | |  |  | [ParallelForWithDtAuxPredicate](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a0b53efb684a00886c72b154ddf96443b) | *body*, | |  |  | int | *grainSize* = 16 ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#a201ca8f32796926320b13686f51246bb)AssertIsMainThread()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Library.TWParallel.AssertIsMainThread | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_t_w_parallel.html#adad211130fc885ee17a1ab5904f3ae07)IsMainThread()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Library.TWParallel.IsMainThread | ( |  | ) |  | | static |


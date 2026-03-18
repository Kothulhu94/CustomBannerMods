--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html ---

TaleWorlds.GauntletUI.Data.GauntletMovie Class ReferenceInherits [TaleWorlds.GauntletUI.Data.IGauntletMovie](interface_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_i_gauntlet_movie.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [RefreshDataSource](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a764377bdf83f7d2d3fd47e890fab10ff) ([IViewModel](interface_tale_worlds_1_1_library_1_1_i_view_model.html) dataSourve) |
| void | [Release](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#ad165df977a87337a410a748f4f15c97a) () |
| void | [Update](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#ab83ca68ed69a3e0f2fcd3f3756a3f76d) () |
| void | [RefreshBindingWithChildren](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a0d430c70f64ba2899bc8b2d194e536e3) () |
| [GauntletView](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_view.html) | [FindViewOf](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a57e6c297fb5a96311ea3e57edf481b08) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [IGauntletMovie](interface_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_i_gauntlet_movie.html) | [Load](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a749ee35a8068bc355fb900c2aec18217) ([UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) context, [WidgetFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a57303bf78201c757f732b82e87f1b341) widgetFactory, string movieName, [IViewModel](interface_tale_worlds_1_1_library_1_1_i_view_model.html) datasource, bool doNotUseGeneratedPrefabs, bool hotReloadEnabled) |

|  |  |
| --- | --- |
| Properties | |
| WidgetFactory | [WidgetFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a57303bf78201c757f732b82e87f1b341) `[get]` |
| BrushFactory | [BrushFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a4c3f78e171782813080b17583dbabceb) `[get]` |
| [UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) | [Context](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a8a76c6ce8c366f9540dbc2678e81f55c) `[get]` |
| [IViewModel](interface_tale_worlds_1_1_library_1_1_i_view_model.html) | [ViewModel](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a0a62fcd0b43af4bd420a46c6deb20ba5) `[get]` |
| string | [MovieName](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a0e7b85824d46692660feb75053eda75d) `[get]` |
| [GauntletView](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_view.html) | [RootView](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#adf02e8199c6228d0c998c7f34af50367) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [RootWidget](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a5b08a40fbe0ed101fadbd68dd333e80c) `[get]` |
| bool | [IsLoaded](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#aafe88843cea8cb53a3715f943e44c7ed) `[get]` |
| bool | [IsReleased](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#afba60022afa752db39dfb7541c19f43a) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a764377bdf83f7d2d3fd47e890fab10ff)RefreshDataSource()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Data.GauntletMovie.RefreshDataSource | ( | [IViewModel](interface_tale_worlds_1_1_library_1_1_i_view_model.html) | *dataSourve* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#ad165df977a87337a410a748f4f15c97a)Release()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Data.GauntletMovie.Release | ( |  | ) |  |

Implements [TaleWorlds.GauntletUI.Data.IGauntletMovie](interface_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_i_gauntlet_movie.html#aac56677bcf7cb0b2f655af4bc8b3fbaa).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#ab83ca68ed69a3e0f2fcd3f3756a3f76d)Update()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Data.GauntletMovie.Update | ( |  | ) |  |

Implements [TaleWorlds.GauntletUI.Data.IGauntletMovie](interface_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_i_gauntlet_movie.html#a1b992e6fb49cfbb8b842ba3cacb4fd1e).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a749ee35a8068bc355fb900c2aec18217)Load()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IGauntletMovie](interface_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_i_gauntlet_movie.html) TaleWorlds.GauntletUI.Data.GauntletMovie.Load | ( | [UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) | *context*, | |  |  | [WidgetFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a57303bf78201c757f732b82e87f1b341) | *widgetFactory*, | |  |  | string | *movieName*, | |  |  | [IViewModel](interface_tale_worlds_1_1_library_1_1_i_view_model.html) | *datasource*, | |  |  | bool | *doNotUseGeneratedPrefabs*, | |  |  | bool | *hotReloadEnabled* ) | | static |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a0d430c70f64ba2899bc8b2d194e536e3)RefreshBindingWithChildren()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Data.GauntletMovie.RefreshBindingWithChildren | ( |  | ) |  |

Implements [TaleWorlds.GauntletUI.Data.IGauntletMovie](interface_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_i_gauntlet_movie.html#a724bc555f6615ff413bdcfe8fc38dbe5).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a57e6c297fb5a96311ea3e57edf481b08)FindViewOf()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GauntletView](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_view.html) TaleWorlds.GauntletUI.Data.GauntletMovie.FindViewOf | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a57303bf78201c757f732b82e87f1b341)WidgetFactory
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | WidgetFactory TaleWorlds.GauntletUI.Data.GauntletMovie.WidgetFactory | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a4c3f78e171782813080b17583dbabceb)BrushFactory
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | BrushFactory TaleWorlds.GauntletUI.Data.GauntletMovie.BrushFactory | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a8a76c6ce8c366f9540dbc2678e81f55c)Context
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) TaleWorlds.GauntletUI.Data.GauntletMovie.Context | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a0a62fcd0b43af4bd420a46c6deb20ba5)ViewModel
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IViewModel](interface_tale_worlds_1_1_library_1_1_i_view_model.html) TaleWorlds.GauntletUI.Data.GauntletMovie.ViewModel | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a0e7b85824d46692660feb75053eda75d)MovieName
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.Data.GauntletMovie.MovieName | | get |

Implements [TaleWorlds.GauntletUI.Data.IGauntletMovie](interface_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_i_gauntlet_movie.html#a64aaff0a7f4f3ceeac074202c1ee3d01).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#adf02e8199c6228d0c998c7f34af50367)RootView
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GauntletView](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_view.html) TaleWorlds.GauntletUI.Data.GauntletMovie.RootView | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#a5b08a40fbe0ed101fadbd68dd333e80c)RootWidget
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.Data.GauntletMovie.RootWidget | | get |

Implements [TaleWorlds.GauntletUI.Data.IGauntletMovie](interface_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_i_gauntlet_movie.html#a538f77fb50922f0ac168ff5b8820ffd3).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#aafe88843cea8cb53a3715f943e44c7ed)IsLoaded
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.Data.GauntletMovie.IsLoaded | | get |

Implements [TaleWorlds.GauntletUI.Data.IGauntletMovie](interface_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_i_gauntlet_movie.html#af6c10b4006b1e983a1f8fcf9c9165fb6).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_gauntlet_movie.html#afba60022afa752db39dfb7541c19f43a)IsReleased
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.Data.GauntletMovie.IsReleased | | get |

Implements [TaleWorlds.GauntletUI.Data.IGauntletMovie](interface_tale_worlds_1_1_gauntlet_u_i_1_1_data_1_1_i_gauntlet_movie.html#ae1d8ad75de9f7e4933a8fab5729bc080).


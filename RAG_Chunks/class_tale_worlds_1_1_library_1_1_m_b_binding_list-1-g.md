--- SOURCE: class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html ---

TaleWorlds.Library.MBBindingList< T > Class Template ReferenceInherits Collection, and [TaleWorlds.Library.IMBBindingList](interface_tale_worlds_1_1_library_1_1_i_m_b_binding_list.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MBBindingList](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a492bdd6804046803f6dc237183645ebb) () |
| void | [Sort](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a8d4fdbf9cc16266641c725781d0c458f) () |
| void | [Sort](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a1ce6633eed97e3ec99ffd1abcecd8617) (IComparer< T > comparer) |
| bool | [IsOrdered](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#ad7de8d38641df0186c0869b047414ca0) (IComparer< T > comparer) |
| void | [ApplyActionOnAllItems](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a1e77ebbf4705acd074f1b1600fb8e702) (Action< T > action) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [ClearItems](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a47fec0a54fde2a7b4784319796683639) () |
| override void | [InsertItem](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a90cf40ca92fdf259ab1f171eaa84c3e6) (int index, T item) |
| override void | [RemoveItem](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#acb51cf55ed38318c85f2750481b1959f) (int index) |
| override void | [SetItem](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a0df10082af221729131575d304400fa0) (int index, T item) |
| virtual void | [OnListChanged](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#adc8da3bdf390165a48feccda7c551c87) ([ListChangedEventArgs](class_tale_worlds_1_1_library_1_1_list_changed_event_args.html) e) |

|  |  |
| --- | --- |
| Events | |
| [ListChangedEventHandler](namespace_tale_worlds_1_1_library.html#a44b4e000f9c909af4275635382e24462) | [ListChanged](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a9f0eb4655b57d4e0aa943d98ba1060cc) `[add, remove]` |
| Events inherited from [TaleWorlds.Library.IMBBindingList](interface_tale_worlds_1_1_library_1_1_i_m_b_binding_list.html) | |
| [ListChangedEventHandler](namespace_tale_worlds_1_1_library.html#a44b4e000f9c909af4275635382e24462) | [ListChanged](interface_tale_worlds_1_1_library_1_1_i_m_b_binding_list.html#a00d9e190411fd9c064d228565a6f0485) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a492bdd6804046803f6dc237183645ebb)MBBindingList()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Library.MBBindingList< T >.MBBindingList | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a47fec0a54fde2a7b4784319796683639)ClearItems()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Library.MBBindingList< T >.ClearItems | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a90cf40ca92fdf259ab1f171eaa84c3e6)InsertItem()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Library.MBBindingList< T >.InsertItem | ( | int | *index*, | |  |  | T | *item* ) | | protected |

[◆](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#acb51cf55ed38318c85f2750481b1959f)RemoveItem()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.Library.MBBindingList< T >.RemoveItem | ( | int | *index* | ) |  | | protected |

[◆](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a0df10082af221729131575d304400fa0)SetItem()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Library.MBBindingList< T >.SetItem | ( | int | *index*, | |  |  | T | *item* ) | | protected |

[◆](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#adc8da3bdf390165a48feccda7c551c87)OnListChanged()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Library.MBBindingList< T >.OnListChanged | ( | [ListChangedEventArgs](class_tale_worlds_1_1_library_1_1_list_changed_event_args.html) | *e* | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a8d4fdbf9cc16266641c725781d0c458f)Sort() [1/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBBindingList< T >.Sort | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a1ce6633eed97e3ec99ffd1abcecd8617)Sort() [2/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBBindingList< T >.Sort | ( | IComparer< T > | *comparer* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#ad7de8d38641df0186c0869b047414ca0)IsOrdered()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.MBBindingList< T >.IsOrdered | ( | IComparer< T > | *comparer* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a1e77ebbf4705acd074f1b1600fb8e702)ApplyActionOnAllItems()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MBBindingList< T >.ApplyActionOnAllItems | ( | Action< T > | *action* | ) |  |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_library_1_1_m_b_binding_list-1-g.html#a9f0eb4655b57d4e0aa943d98ba1060cc)ListChanged
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ListChangedEventHandler](namespace_tale_worlds_1_1_library.html#a44b4e000f9c909af4275635382e24462) TaleWorlds.Library.MBBindingList< T >.ListChanged | | addremove |


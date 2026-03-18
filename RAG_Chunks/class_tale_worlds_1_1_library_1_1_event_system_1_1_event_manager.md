--- SOURCE: class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html ---

TaleWorlds.Library.EventSystem.EventManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [EventManager](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html#a97349ecf0edab1ad8e4a167eef533bb8) () |
| void | [RegisterEvent< T >](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html#af9b13f59e5d04d3d4a2e724443287d32) (Action< T > eventObjType) |
|  | Register a new callback with type. |
| void | [UnregisterEvent< T >](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html#a5f65e7387bc84aa524f3e8a2e7472cff) (Action< T > eventObjType) |
|  | Unregister/Removes a callback with type. |
| void | [TriggerEvent< T >](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html#a3b0ca49965d94d6567ce5e4cf0c8cc51) (T eventObj) |
|  | Trigger an event of type with the instance of that type. |
| void | [Clear](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html#aa316867808ed236169ba4024cea29e47) () |
|  | Clears resources of the [EventSystem](namespace_tale_worlds_1_1_library_1_1_event_system.html). |
| IDictionary< Type, object > | [GetCloneOfEventDictionary](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html#a168291c6a306a795a3b8fa83a0b7b851) () |
|  | Clones the event dictionary for Trace and [Debug](class_tale_worlds_1_1_library_1_1_debug.html) purposes. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html#a97349ecf0edab1ad8e4a167eef533bb8)EventManager()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Library.EventSystem.EventManager.EventManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html#af9b13f59e5d04d3d4a2e724443287d32)RegisterEvent< T >()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.EventSystem.EventManager.RegisterEvent< T > | ( | Action< T > | *eventObjType* | ) |  |

Template Parameters
:   |  |  |
    | --- | --- |
    | T | Type indentifier of the event. Has to derive from EventSystemBase |

Parameters
:   |  |  |
    | --- | --- |
    | eventObjType | Instance of the callback |

[◆](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html#a5f65e7387bc84aa524f3e8a2e7472cff)UnregisterEvent< T >()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.EventSystem.EventManager.UnregisterEvent< T > | ( | Action< T > | *eventObjType* | ) |  |

Template Parameters
:   |  |  |
    | --- | --- |
    | T | Type indentifier of the event. Has to derive from EventSystemBase |

Parameters
:   |  |  |
    | --- | --- |
    | eventObjType | Instance of the callback |

[◆](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html#a3b0ca49965d94d6567ce5e4cf0c8cc51)TriggerEvent< T >()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.EventSystem.EventManager.TriggerEvent< T > | ( | T | *eventObj* | ) |  |

Template Parameters
:   |  |  |
    | --- | --- |
    | T | Type of the event |

Parameters
:   |  |  |
    | --- | --- |
    | eventObj | Object instance of the event type |

[◆](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html#aa316867808ed236169ba4024cea29e47)Clear()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.EventSystem.EventManager.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html#a168291c6a306a795a3b8fa83a0b7b851)GetCloneOfEventDictionary()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IDictionary< Type, object > TaleWorlds.Library.EventSystem.EventManager.GetCloneOfEventDictionary | ( |  | ) |  |

Returns


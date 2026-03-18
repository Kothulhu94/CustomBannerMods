--- SOURCE: class_tale_worlds_1_1_library_1_1_information_manager.html ---

TaleWorlds.Library.InformationManager Class Reference|  |  |
| --- | --- |
| Classes | |
| struct | [TooltipRegistry](struct_tale_worlds_1_1_library_1_1_information_manager_1_1_tooltip_registry.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [IsAnyTooltipActiveDelegate](class_tale_worlds_1_1_library_1_1_information_manager.html#a7bd2b8f5c57971c1a2b3385fda273330) (out bool isAnyTooltipActive, out bool isAnyTooltipExtended) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [IsAnyInquiryActive](class_tale_worlds_1_1_library_1_1_information_manager.html#a821974550b1e23eb429a7856cbc7af2d) () |
| static void | [DisplayMessage](class_tale_worlds_1_1_library_1_1_information_manager.html#a3e64fd4a75362843600f0d5846388e1d) ([InformationMessage](class_tale_worlds_1_1_library_1_1_information_message.html) message) |
|  | Adds a new message line to the chatlog. |
| static void | [HideAllMessages](class_tale_worlds_1_1_library_1_1_information_manager.html#af2f9bedf78257cf4e091414c3a97e15e) () |
|  | Hides all lines in the chatlog, but does not clear them. |
| static void | [ClearAllMessages](class_tale_worlds_1_1_library_1_1_information_manager.html#a870a965cc8ed9f2173c33db76852306e) () |
|  | Clears all lines in the chatlog. |
| static void | [AddSystemNotification](class_tale_worlds_1_1_library_1_1_information_manager.html#a968a2610395c33afd7c6ff6a26dc7f2a) (string message) |
|  | Displays text on the top of the screen, notifying the player. Used for system/backend notifications. Not Used in Singleplayer. |
| static void | [ShowTooltip](class_tale_worlds_1_1_library_1_1_information_manager.html#a9aff8451795ce149dba0aac4eb266a28) (Type type, params object[] args) |
|  | Shows the tooltip that is associated to the given type. |
| static void | [HideTooltip](class_tale_worlds_1_1_library_1_1_information_manager.html#a0c205a08c28f09645d112c7aa23a85ed) () |
|  | Hides currently active tooltips. |
| static void | [ShowInquiry](class_tale_worlds_1_1_library_1_1_information_manager.html#aab3da25cc1d5d8cb96cc3ad326261eb7) ([InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html) data, bool pauseGameActiveState=false, bool prioritize=false) |
|  | Shows an inquiry panel with OK-Cancel options depending on Data. |
| static void | [ShowTextInquiry](class_tale_worlds_1_1_library_1_1_information_manager.html#adf59f25f3303887331cfd5bf923fb021) ([TextInquiryData](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html) textData, bool pauseGameActiveState=false, bool prioritize=false) |
|  | Shows an inquiry panel with OK-Cancel options and text input area depending on Data. |
| static void | [HideInquiry](class_tale_worlds_1_1_library_1_1_information_manager.html#ada07207eee7e3535c60ce89503ffb0e2) () |
|  | Removes on-screen inquiry if there is one. |
| static bool | [GetIsAnyTooltipActive](class_tale_worlds_1_1_library_1_1_information_manager.html#af1bde2452616aae3a4ac600183b0b30f) () |
|  | Returns true if any tooltip is currently active. |
| static bool | [GetIsAnyTooltipActiveAndExtended](class_tale_worlds_1_1_library_1_1_information_manager.html#a5edd589053ce5e5e51614933c898544a) () |
|  | Returns true if any tooltip is currently active and extended. |
| static void | [RegisterTooltip< TRegistered, TTooltip >](class_tale_worlds_1_1_library_1_1_information_manager.html#ac9c9c17c91348eb0738dad174a802877) (Action< TTooltip, object[]> onRefreshData, string movieName) |
|  | Register a given type to a tooltip type. When the given type is used with the ShowTooltip method, an object of the tooltip type will be instantiated and used as a datasource to the movie with the given movieName. |
| static void | [UnregisterTooltip< TRegistered >](class_tale_worlds_1_1_library_1_1_information_manager.html#a67994bd564004b834bded72a0182e729) () |
|  | Unregister a previously registered tooltip. |
| static void | [Clear](class_tale_worlds_1_1_library_1_1_information_manager.html#a027065058e82862e0b62ce0a1eb83b46) () |
|  | Clears event registries of all information events. |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static Func< bool > | [IsAnyInquiryActiveInternal](class_tale_worlds_1_1_library_1_1_information_manager.html#a5d8906aa5085cabb11ebc9830babf5e7) |
|  | Returns if any inquiry is currently active. The system that implements ShowInquiry events, should also respond to this call. |
| static [IsAnyTooltipActiveDelegate](class_tale_worlds_1_1_library_1_1_information_manager.html#a7bd2b8f5c57971c1a2b3385fda273330) | [IsAnyTooltipActiveInternal](class_tale_worlds_1_1_library_1_1_information_manager.html#a78cefb2f379b94d2958b6e54ac22853b) |

|  |  |
| --- | --- |
| Properties | |
| static IReadOnlyDictionary< Type, [TooltipRegistry](struct_tale_worlds_1_1_library_1_1_information_manager_1_1_tooltip_registry.html) > | [RegisteredTypes](class_tale_worlds_1_1_library_1_1_information_manager.html#acdbb028a7f8e179e70e0265d68e471a3) `[get]` |

|  |  |
| --- | --- |
| Events | |
| static Action< [InformationMessage](class_tale_worlds_1_1_library_1_1_information_message.html) > | [DisplayMessageInternal](class_tale_worlds_1_1_library_1_1_information_manager.html#ae1cb6ccda5d8a574b110fb63b33e2bab) |
| static Action | [ClearAllMessagesInternal](class_tale_worlds_1_1_library_1_1_information_manager.html#a77e44f7a6879a037759d07b4397b32ce) |
| static Action | [HideAllMessagesInternal](class_tale_worlds_1_1_library_1_1_information_manager.html#ab77c84e16dbc0997e7d13174e89ebb7d) |
| static Action< string > | [OnAddSystemNotification](class_tale_worlds_1_1_library_1_1_information_manager.html#a90f9f0b50fc51a8ba49ffb8eb9e4659e) |
| static Action< Type, object[]> | [OnShowTooltip](class_tale_worlds_1_1_library_1_1_information_manager.html#a6feb825a0bf720edd4ced236c37c6708) |
| static Action | [OnHideTooltip](class_tale_worlds_1_1_library_1_1_information_manager.html#aed97230f02ee20b1b9a1861db2288769) |
| static Action< [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html), bool, bool > | [OnShowInquiry](class_tale_worlds_1_1_library_1_1_information_manager.html#ad7981a88fa72d2d154eb5b0f9baa9094) |
| static Action< [TextInquiryData](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html), bool, bool > | [OnShowTextInquiry](class_tale_worlds_1_1_library_1_1_information_manager.html#ab8300e7cac9f68689460538e940e1c45) |
| static Action | [OnHideInquiry](class_tale_worlds_1_1_library_1_1_information_manager.html#a061f7e771cc4a7a46494bcdae3b59bdd) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a7bd2b8f5c57971c1a2b3385fda273330)IsAnyTooltipActiveDelegate()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.Library.InformationManager.IsAnyTooltipActiveDelegate | ( | out bool | *isAnyTooltipActive*, |
|  |  | out bool | *isAnyTooltipExtended* ) |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a821974550b1e23eb429a7856cbc7af2d)IsAnyInquiryActive()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Library.InformationManager.IsAnyInquiryActive | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a3e64fd4a75362843600f0d5846388e1d)DisplayMessage()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.InformationManager.DisplayMessage | ( | [InformationMessage](class_tale_worlds_1_1_library_1_1_information_message.html) | *message* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | message | Parameters of the message. |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#af2f9bedf78257cf4e091414c3a97e15e)HideAllMessages()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Library.InformationManager.HideAllMessages | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a870a965cc8ed9f2173c33db76852306e)ClearAllMessages()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Library.InformationManager.ClearAllMessages | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a968a2610395c33afd7c6ff6a26dc7f2a)AddSystemNotification()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.InformationManager.AddSystemNotification | ( | string | *message* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | message | Main message/text of the system notification. |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a9aff8451795ce149dba0aac4eb266a28)ShowTooltip()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.InformationManager.ShowTooltip | ( | Type | *type*, | |  |  | params object[] | *args* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | type | Type that is associated with a tooltip. |
    | args | Arguments that will be used by the tooltip. |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a0c205a08c28f09645d112c7aa23a85ed)HideTooltip()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Library.InformationManager.HideTooltip | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#aab3da25cc1d5d8cb96cc3ad326261eb7)ShowInquiry()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.InformationManager.ShowInquiry | ( | [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html) | *data*, | |  |  | bool | *pauseGameActiveState* = false, | |  |  | bool | *prioritize* = false ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | data | Parameters of the inquiry. |
    | pauseGameActiveState | Pauses the game's current active state while the inquiry is active. |
    | prioritize | Determines if the new query should be shown immediately if another query is active. |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#adf59f25f3303887331cfd5bf923fb021)ShowTextInquiry()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.InformationManager.ShowTextInquiry | ( | [TextInquiryData](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html) | *textData*, | |  |  | bool | *pauseGameActiveState* = false, | |  |  | bool | *prioritize* = false ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | textData | Parameters of the inquiry. |
    | pauseGameActiveState | Pauses the game's current active state while the inquiry is active. |
    | prioritize | Determines if the new query should be shown immediately if another query is active. |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#ada07207eee7e3535c60ce89503ffb0e2)HideInquiry()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Library.InformationManager.HideInquiry | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#af1bde2452616aae3a4ac600183b0b30f)GetIsAnyTooltipActive()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Library.InformationManager.GetIsAnyTooltipActive | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a5edd589053ce5e5e51614933c898544a)GetIsAnyTooltipActiveAndExtended()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Library.InformationManager.GetIsAnyTooltipActiveAndExtended | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#ac9c9c17c91348eb0738dad174a802877)RegisterTooltip< TRegistered, TTooltip >()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.InformationManager.RegisterTooltip< TRegistered, TTooltip > | ( | Action< TTooltip, object[]> | *onRefreshData*, | |  |  | string | *movieName* ) | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | TRegistered | Registered type |
    | TTooltip | Tooltip type |

Parameters
:   |  |  |
    | --- | --- |
    | onRefreshData | A method that is used to refresh the tooltip data |
    | movieName | Name of the movie to be used with the given tooltip type |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *TTooltip* | : | *[TooltipBaseVM](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html)* |  |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a67994bd564004b834bded72a0182e729)UnregisterTooltip< TRegistered >()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Library.InformationManager.UnregisterTooltip< TRegistered > | ( |  | ) |  | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | TRegistered | Registered type |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a027065058e82862e0b62ce0a1eb83b46)Clear()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Library.InformationManager.Clear | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a5d8906aa5085cabb11ebc9830babf5e7)IsAnyInquiryActiveInternal
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<bool> TaleWorlds.Library.InformationManager.IsAnyInquiryActiveInternal | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a78cefb2f379b94d2958b6e54ac22853b)IsAnyTooltipActiveInternal
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IsAnyTooltipActiveDelegate](class_tale_worlds_1_1_library_1_1_information_manager.html#a7bd2b8f5c57971c1a2b3385fda273330) TaleWorlds.Library.InformationManager.IsAnyTooltipActiveInternal | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#acdbb028a7f8e179e70e0265d68e471a3)RegisteredTypes
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyDictionary<Type, [TooltipRegistry](struct_tale_worlds_1_1_library_1_1_information_manager_1_1_tooltip_registry.html)> TaleWorlds.Library.InformationManager.RegisteredTypes | | staticget |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#ae1cb6ccda5d8a574b110fb63b33e2bab)DisplayMessageInternal
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[InformationMessage](class_tale_worlds_1_1_library_1_1_information_message.html)> TaleWorlds.Library.InformationManager.DisplayMessageInternal | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a77e44f7a6879a037759d07b4397b32ce)ClearAllMessagesInternal
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.Library.InformationManager.ClearAllMessagesInternal | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#ab77c84e16dbc0997e7d13174e89ebb7d)HideAllMessagesInternal
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.Library.InformationManager.HideAllMessagesInternal | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a90f9f0b50fc51a8ba49ffb8eb9e4659e)OnAddSystemNotification
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<string> TaleWorlds.Library.InformationManager.OnAddSystemNotification | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a6feb825a0bf720edd4ced236c37c6708)OnShowTooltip
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<Type, object[]> TaleWorlds.Library.InformationManager.OnShowTooltip | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#aed97230f02ee20b1b9a1861db2288769)OnHideTooltip
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.Library.InformationManager.OnHideTooltip | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#ad7981a88fa72d2d154eb5b0f9baa9094)OnShowInquiry
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html), bool, bool> TaleWorlds.Library.InformationManager.OnShowInquiry | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#ab8300e7cac9f68689460538e940e1c45)OnShowTextInquiry
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[TextInquiryData](class_tale_worlds_1_1_library_1_1_text_inquiry_data.html), bool, bool> TaleWorlds.Library.InformationManager.OnShowTextInquiry | | static |

[◆](class_tale_worlds_1_1_library_1_1_information_manager.html#a061f7e771cc4a7a46494bcdae3b59bdd)OnHideInquiry
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.Library.InformationManager.OnHideInquiry | | static |


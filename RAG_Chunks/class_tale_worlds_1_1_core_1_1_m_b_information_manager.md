--- SOURCE: class_tale_worlds_1_1_core_1_1_m_b_information_manager.html ---

TaleWorlds.Core.MBInformationManager Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [DialogNotificationHandle](class_tale_worlds_1_1_core_1_1_m_b_information_manager_1_1_dialog_notification_handle.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [NotificationPriority](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#ab8331fe16f0543bb4c33e679edc92cb3) {     [Lowest](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#ab8331fe16f0543bb4c33e679edc92cb3ab5b8e20937205384be7b9e0c29a28fdb) ,     [Low](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#ab8331fe16f0543bb4c33e679edc92cb3a28d0edd045e05cf5af64e35ae0c4c6ef) ,     [Medium](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#ab8331fe16f0543bb4c33e679edc92cb3a87f8a6ab85c9ced3702b4ea641ad4bb5) ,     [High](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#ab8331fe16f0543bb4c33e679edc92cb3a655d20c1ca69519ca647684edbb2db35) ,     [Highest](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#ab8331fe16f0543bb4c33e679edc92cb3a582996407922dab08d5cf2b3d2a7c1c9)   } |
| enum | [NotificationStatus](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a25586ef4cd3545ef41c1225c11d40689) {     [Inactive](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a25586ef4cd3545ef41c1225c11d40689a3cab03c00dbd11bc3569afa0748013f0) ,     [CurrentlyActive](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a25586ef4cd3545ef41c1225c11d40689a0bf6fd76e09f988f36e28809302e6752) ,     [InQueue](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a25586ef4cd3545ef41c1225c11d40689a06f2ccffa11581850ec3adc056e723bf)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [AddQuickInformation](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#aed2e46f0667ee56a67e2ad7c59e1e7e6) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) message, int extraTimeInMs=0, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) announcerCharacter=null, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) equipment=null, string soundEventPath="") |
|  | Shows a header-banner-notification in Campaign and Multiplayer. |
| static void | [ClearQuickInformations](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#aea243f0c746051cac8564e1d74ecaecf) () |
|  | Clears all quick informations, including the one that is being displayed. |
| static void | [ShowMultiSelectionInquiry](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#acf8a7484b819e7d43fd01c67a8319039) ([MultiSelectionInquiryData](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html) data, bool pauseGameActiveState=false, bool prioritize=false) |
|  | Shows an inquiry panel with multiple elements to choose from. |
| static void | [AddNotice](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a5edb3b51c659fd8027bfb03d3ac38cdb) ([InformationData](class_tale_worlds_1_1_core_1_1_information_data.html) data) |
|  | Adds a new map notification in Campaign and not used in Multiplayer. |
| static void | [MapNoticeRemoved](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#aef51b495fcc4c845bcfc1648eaa2b8c3) ([InformationData](class_tale_worlds_1_1_core_1_1_information_data.html) data) |
| static void | [ShowHint](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#ad75054b0d2186d4a2a9060458a170668) (string hint) |
|  | Shows a hint that contains the given string. |
| static void | [HideInformations](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a8564fc09b13e68cd6fb762962182d92d) () |
|  | Hides currently active hints and tooltips. |
| static void | [ShowSceneNotification](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#aadd28dd01c87e5b3c8c40017a89f1f45) ([SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) data) |
|  | Shows a panel with a scene panel inside. |
| static void | [HideSceneNotification](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a9e4db917176cd28317dce5f7b1b35a47) () |
|  | Hide the panel with a scene panel inside if there is one visible. |
| static ? bool | [GetIsAnySceneNotificationActive](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#abf02e52538dcefa380339cd5ed74dd1c) () |
|  | Returns if any scene notification is currently active. Returns null if no scene notification manager is registered. |
| static void | [Clear](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#aa6f9260b27ee724f4f97d31adf0f2deb) () |

|  |  |
| --- | --- |
| Events | |
| static Action< string, int, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html), [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html), string > | [FiringQuickInformation](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a1d503157a419210432f177f777af5e41) |
| static Action | [ClearingQuickInformations](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a9397cb33305bc7e423415f7e78cd4ad6) |
| static Action< [MultiSelectionInquiryData](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html), bool, bool > | [OnShowMultiSelectionInquiry](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a1d535c6db5ca682a32187f7c2cc94372) |
| static Action< [InformationData](class_tale_worlds_1_1_core_1_1_information_data.html) > | [OnAddMapNotice](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a462bf9d7302c31727eac675174cc6c5f) |
| static Action< [InformationData](class_tale_worlds_1_1_core_1_1_information_data.html) > | [OnRemoveMapNotice](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a17c841d035f9e7586bbe6139c041965e) |
| static Action< [SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) > | [OnShowSceneNotification](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#ae325c0bccd56af5b402304bc6688e750) |
| static Action | [OnHideSceneNotification](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a61ac3d1244018e9535045511b42a6d2d) |
| static Func< bool > | [IsAnySceneNotificationActive](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a9a53ec49358d01b7ba804b88514f6427) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#ab8331fe16f0543bb4c33e679edc92cb3)NotificationPriority
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.MBInformationManager.NotificationPriority](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#ab8331fe16f0543bb4c33e679edc92cb3) |

| Enumerator | |
| --- | --- |
| Lowest |  |
| Low |  |
| Medium |  |
| High |  |
| Highest |  |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a25586ef4cd3545ef41c1225c11d40689)NotificationStatus
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.MBInformationManager.NotificationStatus](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a25586ef4cd3545ef41c1225c11d40689) |

| Enumerator | |
| --- | --- |
| Inactive |  |
| CurrentlyActive |  |
| InQueue |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#aed2e46f0667ee56a67e2ad7c59e1e7e6)AddQuickInformation()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.MBInformationManager.AddQuickInformation | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *message*, | |  |  | int | *extraTimeInMs* = 0, | |  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *announcerCharacter* = null, | |  |  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *equipment* = null, | |  |  | string | *soundEventPath* = "" ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | message | Main message/text of the information. |
    | extraTimeInMs | The amount of time in milliseconds that the message additionally stays on screen. |
    | announcerCharacter | Portrait of the announcer. |
    | soundEventPath | Path of a sound file. |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#aea243f0c746051cac8564e1d74ecaecf)ClearQuickInformations()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBInformationManager.ClearQuickInformations | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#acf8a7484b819e7d43fd01c67a8319039)ShowMultiSelectionInquiry()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.MBInformationManager.ShowMultiSelectionInquiry | ( | [MultiSelectionInquiryData](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html) | *data*, | |  |  | bool | *pauseGameActiveState* = false, | |  |  | bool | *prioritize* = false ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | data | Parameters of the multiselection inquiry. |
    | pauseGameActiveState | Pauses the game's current active state while the inquiry is active. |
    | prioritize | Determines if the new query should be shown immediately if another query is active. |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a5edb3b51c659fd8027bfb03d3ac38cdb)AddNotice()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBInformationManager.AddNotice | ( | [InformationData](class_tale_worlds_1_1_core_1_1_information_data.html) | *data* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | data | Parameters of the message. |
    | pauseGameActiveState | Pauses the game's current active state while the information is active. |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#aef51b495fcc4c845bcfc1648eaa2b8c3)MapNoticeRemoved()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBInformationManager.MapNoticeRemoved | ( | [InformationData](class_tale_worlds_1_1_core_1_1_information_data.html) | *data* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#ad75054b0d2186d4a2a9060458a170668)ShowHint()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBInformationManager.ShowHint | ( | string | *hint* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | hint | Content of the hint. |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a8564fc09b13e68cd6fb762962182d92d)HideInformations()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBInformationManager.HideInformations | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#aadd28dd01c87e5b3c8c40017a89f1f45)ShowSceneNotification()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBInformationManager.ShowSceneNotification | ( | [SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) | *data* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | data | Parameters of the Scene Nofication. |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a9e4db917176cd28317dce5f7b1b35a47)HideSceneNotification()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBInformationManager.HideSceneNotification | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#abf02e52538dcefa380339cd5ed74dd1c)GetIsAnySceneNotificationActive()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | ? bool TaleWorlds.Core.MBInformationManager.GetIsAnySceneNotificationActive | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#aa6f9260b27ee724f4f97d31adf0f2deb)Clear()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.MBInformationManager.Clear | ( |  | ) |  | | static |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a1d503157a419210432f177f777af5e41)FiringQuickInformation
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<string, int, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html), [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html), string> TaleWorlds.Core.MBInformationManager.FiringQuickInformation | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a9397cb33305bc7e423415f7e78cd4ad6)ClearingQuickInformations
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.Core.MBInformationManager.ClearingQuickInformations | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a1d535c6db5ca682a32187f7c2cc94372)OnShowMultiSelectionInquiry
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[MultiSelectionInquiryData](class_tale_worlds_1_1_core_1_1_multi_selection_inquiry_data.html), bool, bool> TaleWorlds.Core.MBInformationManager.OnShowMultiSelectionInquiry | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a462bf9d7302c31727eac675174cc6c5f)OnAddMapNotice
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[InformationData](class_tale_worlds_1_1_core_1_1_information_data.html)> TaleWorlds.Core.MBInformationManager.OnAddMapNotice | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a17c841d035f9e7586bbe6139c041965e)OnRemoveMapNotice
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[InformationData](class_tale_worlds_1_1_core_1_1_information_data.html)> TaleWorlds.Core.MBInformationManager.OnRemoveMapNotice | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#ae325c0bccd56af5b402304bc6688e750)OnShowSceneNotification
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html)> TaleWorlds.Core.MBInformationManager.OnShowSceneNotification | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a61ac3d1244018e9535045511b42a6d2d)OnHideSceneNotification
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.Core.MBInformationManager.OnHideSceneNotification | | static |

[◆](class_tale_worlds_1_1_core_1_1_m_b_information_manager.html#a9a53ec49358d01b7ba804b88514f6427)IsAnySceneNotificationActive
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<bool> TaleWorlds.Core.MBInformationManager.IsAnySceneNotificationActive | | static |


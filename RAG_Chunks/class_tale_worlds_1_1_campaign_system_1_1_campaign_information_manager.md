--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html ---

TaleWorlds.CampaignSystem.CampaignInformationManager Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [NoticeType](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a23d6be8fc7bbb69db82f8fb75559ca00) {     [None](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a23d6be8fc7bbb69db82f8fb75559ca00a6adf97f83acf6453d4a6a4b1070f3754) ,     [WarAnnouncement](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a23d6be8fc7bbb69db82f8fb75559ca00a350c712b00a8a90481e909e49bbf0898) ,     [PeaceAnnouncement](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a23d6be8fc7bbb69db82f8fb75559ca00ad63fc7f34c7d8c4b5fb61f2ade7143cf) ,     [ChangeSettlementOwner](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a23d6be8fc7bbb69db82f8fb75559ca00a0f17dd36089f4fa7bd07d3b61a9dc344) ,     [FortificationIsCaptured](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a23d6be8fc7bbb69db82f8fb75559ca00a4ab8e43f2679b646fb5fd3532a67b37b) ,     [HeroChangedFaction](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a23d6be8fc7bbb69db82f8fb75559ca00a5f9cc7c4978baeb3233067a012bed520) ,     [BarterAnnouncement](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a23d6be8fc7bbb69db82f8fb75559ca00a339b5976fcdb53a2144fa80e81ec86d5)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CampaignInformationManager](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a4bd8e465ccebccdac17608efd0551528) () |
| void | [OnGameLoaded](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a90b356a4c437adae733dbaca9347ec1f) () |
| void | [NewMapNoticeAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#ac63ce2be9b8c170ce289299d2b82c39f) ([InformationData](class_tale_worlds_1_1_core_1_1_information_data.html) informationData) |
| bool | [InformationDataExists< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a79edc89945dd901993aeaee919404afb) (System.Func< T, bool > predicate) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static DialogNotificationHandle | [AddDialogLine](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#aa9862bb29ab2c7995a6858027d574766) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) speakerCharacter, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) equipment=null, int extraTimeInMs=0, NotificationPriority priority=NotificationPriority.Medium) |
|  | Uses the banner notification system to display a voiced dialog line. Timeout when the sound event ends. |
| static NotificationStatus | [GetStatusOfDialogNotification](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#ac7312a0840ad021172463642f5a6cee3) (DialogNotificationHandle handle) |
|  | Returns the status of the dialog notification with the given handle. |
| static void | [ClearDialogNotification](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a1af5b2c71b9b4300e0cf6e319fe1f19a) (DialogNotificationHandle handle, bool fadeOut=true) |
|  | Clears the dialog notification with the given handle. Parameters  |  |  | | --- | --- | | handle | The handle of the dialog notification. | | fadeOut | Whether the current dialog notification should fade out or skip immediately. |  . |
| static bool | [GetIsAnyDialogNotificationActiveOrQueued](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a288008420be584648c8fb5ca3c1efb74) () |
|  | Returns if any dialog notification is currently active or in the queue. |
| static void | [ClearAllDialogNotifications](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a73d02c1dc6e04f2e89277a98e8f862c7) (bool fadeOut) |
|  | Clears all (current+queued) dialog notifications. Parameters  |  |  | | --- | --- | | fadeOut | Whether the current dialog notification should fade out or skip immediately. |  . |

|  |  |
| --- | --- |
| Events | |
| static Func< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html), int, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html), [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html), NotificationPriority, string, DialogNotificationHandle > | [OnDisplayDialog](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a7820ba850ff59c8e91400cd62789d351) |
| static Func< DialogNotificationHandle, NotificationStatus > | [OnGetStatusOfDialogNotification](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a66121b9423413417302cd7ff2e732bb4) |
| static Action< DialogNotificationHandle, bool > | [OnClearDialogNotification](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a6bc741fb34fc29bf73706599e5f52f71) |
| static Func< bool > | [IsAnyDialogNotificationActiveOrQueued](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a95cf36e99a0ec22b190cc89a7a315c63) |
| static Action< bool > | [OnClearAllDialogNotifications](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#aaa57e817670a5d10e8e13fff0ce35c1b) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a23d6be8fc7bbb69db82f8fb75559ca00)NoticeType
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.CampaignInformationManager.NoticeType](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a23d6be8fc7bbb69db82f8fb75559ca00) |

| Enumerator | |
| --- | --- |
| None |  |
| WarAnnouncement |  |
| PeaceAnnouncement |  |
| ChangeSettlementOwner |  |
| FortificationIsCaptured |  |
| HeroChangedFaction |  |
| BarterAnnouncement |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a4bd8e465ccebccdac17608efd0551528)CampaignInformationManager()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CampaignInformationManager.CampaignInformationManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a90b356a4c437adae733dbaca9347ec1f)OnGameLoaded()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignInformationManager.OnGameLoaded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#ac63ce2be9b8c170ce289299d2b82c39f)NewMapNoticeAdded()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignInformationManager.NewMapNoticeAdded | ( | [InformationData](class_tale_worlds_1_1_core_1_1_information_data.html) | *informationData* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a79edc89945dd901993aeaee919404afb)InformationDataExists< T >()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignInformationManager.InformationDataExists< T > | ( | System.Func< T, bool > | *predicate* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *InformationData* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#aa9862bb29ab2c7995a6858027d574766)AddDialogLine()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | DialogNotificationHandle TaleWorlds.CampaignSystem.CampaignInformationManager.AddDialogLine | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *speakerCharacter*, | |  |  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *equipment* = null, | |  |  | int | *extraTimeInMs* = 0, | |  |  | NotificationPriority | *priority* = NotificationPriority::Medium ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | text | Main message/text of the information. |
    | extraTimeInMs | The amount of time in milliseconds that the message additionally stays on screen. |
    | speakerCharacter | Portrait of the announcer. |
    | priority | Dialog priority. Overrides the current notification/dialog if priority is higher. Regular banner notifications use lowest priority |

Returns
:   The handle of the line, so that its status may be queried later. null if no dialog was displayed.

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#ac7312a0840ad021172463642f5a6cee3)GetStatusOfDialogNotification()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | NotificationStatus TaleWorlds.CampaignSystem.CampaignInformationManager.GetStatusOfDialogNotification | ( | DialogNotificationHandle | *handle* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a1af5b2c71b9b4300e0cf6e319fe1f19a)ClearDialogNotification()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignInformationManager.ClearDialogNotification | ( | DialogNotificationHandle | *handle*, | |  |  | bool | *fadeOut* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a288008420be584648c8fb5ca3c1efb74)GetIsAnyDialogNotificationActiveOrQueued()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignInformationManager.GetIsAnyDialogNotificationActiveOrQueued | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a73d02c1dc6e04f2e89277a98e8f862c7)ClearAllDialogNotifications()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignInformationManager.ClearAllDialogNotifications | ( | bool | *fadeOut* | ) |  | | static |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a7820ba850ff59c8e91400cd62789d351)OnDisplayDialog
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<[TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html), int, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html), [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html), NotificationPriority, string, DialogNotificationHandle> TaleWorlds.CampaignSystem.CampaignInformationManager.OnDisplayDialog | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a66121b9423413417302cd7ff2e732bb4)OnGetStatusOfDialogNotification
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<DialogNotificationHandle, NotificationStatus> TaleWorlds.CampaignSystem.CampaignInformationManager.OnGetStatusOfDialogNotification | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a6bc741fb34fc29bf73706599e5f52f71)OnClearDialogNotification
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<DialogNotificationHandle, bool> TaleWorlds.CampaignSystem.CampaignInformationManager.OnClearDialogNotification | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#a95cf36e99a0ec22b190cc89a7a315c63)IsAnyDialogNotificationActiveOrQueued
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<bool> TaleWorlds.CampaignSystem.CampaignInformationManager.IsAnyDialogNotificationActiveOrQueued | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_information_manager.html#aaa57e817670a5d10e8e13fff0ce35c1b)OnClearAllDialogNotifications
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<bool> TaleWorlds.CampaignSystem.CampaignInformationManager.OnClearAllDialogNotifications | | static |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html ---

TaleWorlds.CampaignSystem.MapNotificationTypes.AllianceOfferMapNotification Class ReferenceInherits [TaleWorlds.Core.InformationData](class_tale_worlds_1_1_core_1_1_information_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [AllianceOfferMapNotification](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#add5705722326f930227045565135cbe3) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) offeringKingdom, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) descriptionText) |
|  | [AllianceOfferMapNotification](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#a224bb368723deda5966e695d916d34bb) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description) |
| override bool | [IsValid](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#adcc174ccb523606dd2a683881bf3c536) () |

|  |  |
| --- | --- |
| Properties | |
| [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | [OfferingKingdom](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#a63c4307b2915a3a5a304e362623071c3) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [TriggerTime](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#a8edbf4ca7aa228b87b1e96fe3ab2f19c) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#ae75e51efb78cac410d045c879463db56) `[get]` |
| override string | [SoundEventPath](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#a08e3ae061d4c3640a06de6036c568d86) `[get]` |
| Properties inherited from [TaleWorlds.Core.InformationData](class_tale_worlds_1_1_core_1_1_information_data.html) | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TitleText](class_tale_worlds_1_1_core_1_1_information_data.html#ade9cde2e6da558b1ea091c2efb667d24) `[get]` |
| string | [SoundEventPath](class_tale_worlds_1_1_core_1_1_information_data.html#a444ee8504d8d8f94af2e793cf83cefed) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.Core.InformationData](class_tale_worlds_1_1_core_1_1_information_data.html) | |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [DescriptionText](class_tale_worlds_1_1_core_1_1_information_data.html#ae962ad3d1ba541218a1e31a44b93df35) |
| Protected Member Functions inherited from [TaleWorlds.Core.InformationData](class_tale_worlds_1_1_core_1_1_information_data.html) | |
|  | [InformationData](class_tale_worlds_1_1_core_1_1_information_data.html#a4d286d51f89d65682de678b4ab383b7c) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description) |
|  | Parameters of the information. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#add5705722326f930227045565135cbe3)AllianceOfferMapNotification() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.MapNotificationTypes.AllianceOfferMapNotification.AllianceOfferMapNotification | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *offeringKingdom*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *descriptionText* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#a224bb368723deda5966e695d916d34bb)AllianceOfferMapNotification() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.MapNotificationTypes.AllianceOfferMapNotification.AllianceOfferMapNotification | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#adcc174ccb523606dd2a683881bf3c536)IsValid()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.MapNotificationTypes.AllianceOfferMapNotification.IsValid | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.InformationData](class_tale_worlds_1_1_core_1_1_information_data.html#a3c4291c67503a048450f974566285e14).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#a63c4307b2915a3a5a304e362623071c3)OfferingKingdom
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) TaleWorlds.CampaignSystem.MapNotificationTypes.AllianceOfferMapNotification.OfferingKingdom | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#a8edbf4ca7aa228b87b1e96fe3ab2f19c)TriggerTime
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.MapNotificationTypes.AllianceOfferMapNotification.TriggerTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#ae75e51efb78cac410d045c879463db56)TitleText
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.MapNotificationTypes.AllianceOfferMapNotification.TitleText | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_alliance_offer_map_notification.html#a08e3ae061d4c3640a06de6036c568d86)SoundEventPath
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.CampaignSystem.MapNotificationTypes.AllianceOfferMapNotification.SoundEventPath | | get |


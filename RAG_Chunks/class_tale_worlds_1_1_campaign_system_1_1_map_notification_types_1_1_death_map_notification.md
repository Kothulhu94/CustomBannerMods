--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html ---

TaleWorlds.CampaignSystem.MapNotificationTypes.DeathMapNotification Class ReferenceInherits [TaleWorlds.Core.InformationData](class_tale_worlds_1_1_core_1_1_information_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DeathMapNotification](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a8c2dda7db98af8085cce9fa123c9597b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victimHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killerHero, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) descriptionText, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) creationTime) |
| Public Member Functions inherited from [TaleWorlds.Core.InformationData](class_tale_worlds_1_1_core_1_1_information_data.html) | |
| virtual bool | [IsValid](class_tale_worlds_1_1_core_1_1_information_data.html#a3c4291c67503a048450f974566285e14) () |

|  |  |
| --- | --- |
| Properties | |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a10870bd52543b8487e08802cee38c96b) `[get]` |
| override string | [SoundEventPath](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a73578bb15dcda980dba1e2c1631b96bb) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [VictimHero](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a357a873b9bfb0a4862b90cb78ac2dab0) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [KillerHero](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a2da2d2a7318871000c89cf9ac7e9c1df) `[get]` |
| [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | [KillDetail](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a4439a415648d592246d25f82e041bcb0) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [CreationTime](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a87871c882947c35c46f42f6715309f44) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a8c2dda7db98af8085cce9fa123c9597b)DeathMapNotification()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.MapNotificationTypes.DeathMapNotification.DeathMapNotification | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victimHero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killerHero*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *descriptionText*, |
|  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *detail*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *creationTime* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a10870bd52543b8487e08802cee38c96b)TitleText
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.MapNotificationTypes.DeathMapNotification.TitleText | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a73578bb15dcda980dba1e2c1631b96bb)SoundEventPath
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.CampaignSystem.MapNotificationTypes.DeathMapNotification.SoundEventPath | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a357a873b9bfb0a4862b90cb78ac2dab0)VictimHero
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.MapNotificationTypes.DeathMapNotification.VictimHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a2da2d2a7318871000c89cf9ac7e9c1df)KillerHero
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.MapNotificationTypes.DeathMapNotification.KillerHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a4439a415648d592246d25f82e041bcb0)KillDetail
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) TaleWorlds.CampaignSystem.MapNotificationTypes.DeathMapNotification.KillDetail | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_death_map_notification.html#a87871c882947c35c46f42f6715309f44)CreationTime
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.MapNotificationTypes.DeathMapNotification.CreationTime | | get |


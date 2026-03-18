--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_pro_empire_conspirac291e2c1101cc41226c42061bdcc529e3.html ---

TaleWorlds.CampaignSystem.SceneInformationPopupTypes.ProEmpireConspiracyBeginsSceneNotificationItem Class ReferenceInherits [TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracySupportsSceneNotificationItemBase](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_sufefa5be2708b68187ecc9e8a67529e04.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ProEmpireConspiracyBeginsSceneNotificationItem](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_pro_empire_conspirac291e2c1101cc41226c42061bdcc529e3.html#a4219316a4d7cc424fdd8a4fb82f43357) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) kingHero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracySupportsSceneNotificationItemBase](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_sufefa5be2708b68187ecc9e8a67529e04.html) | |
| override [Banner](class_tale_worlds_1_1_core_1_1_banner.html)[] | [GetBanners](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_sufefa5be2708b68187ecc9e8a67529e04.html#a5bdcbc064e010723e2e87295f2eb0bba) () |
| override [SceneNotificationCharacter](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_character.html)[] | [GetSceneNotificationCharacters](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_sufefa5be2708b68187ecc9e8a67529e04.html#a2dcb6878e36c3817c84e2d0ff7e4c4b8) () |
| Public Member Functions inherited from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) | |
| virtual void | [OnAffirmativeAction](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a8810821b923c41417fbce0c3257142d5) () |
|  | Action that gets executed when player chooses the positive action. Won't get called if IsAffirmativeOptionShown == false. |
| virtual void | [OnNegativeAction](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a0f425f84b6f519b2064b562ca3d5d2e2) () |
|  | Action that gets executed when player chooses the negative action. Won't get called if IsNegativeOptionShown == false. |
| virtual void | [OnCloseAction](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a52576cd93bfdea06392585837343e462) () |
|  | Action that gets called when the player closes the notification. Gets called every time. |
| virtual [SceneNotificationShip](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_ship.html)[] | [GetShips](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#ac0668e4261e18b0a43537edf26be14bd) () |

|  |  |
| --- | --- |
| Properties | |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_pro_empire_conspirac291e2c1101cc41226c42061bdcc529e3.html#a5a2f489d22f2f955dcc7d411193c8412) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracySupportsSceneNotificationItemBase](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_sufefa5be2708b68187ecc9e8a67529e04.html) | |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [King](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_sufefa5be2708b68187ecc9e8a67529e04.html#a5cd42a5d2f2d21e6f280ac41c91baf10) `[get]` |
| override string | [SceneID](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_sufefa5be2708b68187ecc9e8a67529e04.html#a8a8c41ac58e55e990fb051a1d396b27e) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AffirmativeText](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_sufefa5be2708b68187ecc9e8a67529e04.html#a1459910f016866bcbe8843c10e3d73f5) `[get]` |
| Properties inherited from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) | |
| virtual string | [SceneID](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a3593c7ac1e58a764687d886792127517) `[get]` |
| virtual string | [SoundEventPath](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a0c0e35744708ebe85c508f2c76488dfd) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TitleText](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a736a5eaa39a0f438c7f494ce30e80906) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AffirmativeDescriptionText](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a3a6bd2d6c95fb137679e16fe2a8e535f) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [NegativeDescriptionText](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a22ad222cf457f5424b7389f330232d6d) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AffirmativeHintText](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#ae26981aa8d72008d2fad693c0db36b13) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AffirmativeHintTextExtended](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a2354a9303aa9c8cb21c0c7b921fe1f14) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AffirmativeTitleText](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#ab9674567a2a74618a2d0be18ede1eea5) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [NegativeTitleText](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a90613a9f8190b3502234cad7762b17e2) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AffirmativeText](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a13bd5c0c9a33e76dca477d5cb00e1476) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [NegativeText](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a3c0062d36d893e5d32abd83c027b7681) `[get]` |
| virtual bool | [IsAffirmativeOptionShown](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a1315e85b6bcb88afd2e42e925ac9efc2) `[get]` |
| virtual bool | [IsNegativeOptionShown](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a54bbc547dc62c70bdf7ce7f14771bbf0) `[get]` |
| virtual bool | [PauseActiveState](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#ad3442f8ab784766988e37eea42a836cb) = true `[get]` |
| virtual [RelevantContextType](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fad) | [RelevantContext](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#abf05a016bf8fc2f2465cd8732f838afd) `[get]` |
| virtual [NotificationSceneProperties](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_notification_scene_properties.html) | [SceneProperties](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#adde895e21b9491167287be42e02269a6) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) | |
| enum | [RelevantContextType](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fad) {     [Any](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fadaed36a1ef76a59ee3f15180e0441188ad) ,     [MPLobby](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fada451fb4bb5556782379c548399d90fd0f) ,     [CustomBattle](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fada634c98354639085633b0761f9cc7b8e6) ,     [Mission](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fada70d529695c253d17e992cb9265abc57f) ,     [Map](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fada46f3ea056caa3126b91f3f70beea068c)   } |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracySupportsSceneNotificationItemBase](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_sufefa5be2708b68187ecc9e8a67529e04.html) | |
|  | [EmpireConspiracySupportsSceneNotificationItemBase](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_sufefa5be2708b68187ecc9e8a67529e04.html#a784eee56d9c8d5e187e347408c7e6d21) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) kingHero) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_pro_empire_conspirac291e2c1101cc41226c42061bdcc529e3.html#a4219316a4d7cc424fdd8a4fb82f43357)ProEmpireConspiracyBeginsSceneNotificationItem()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.SceneInformationPopupTypes.ProEmpireConspiracyBeginsSceneNotificationItem.ProEmpireConspiracyBeginsSceneNotificationItem | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *kingHero* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_pro_empire_conspirac291e2c1101cc41226c42061bdcc529e3.html#a5a2f489d22f2f955dcc7d411193c8412)TitleText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.ProEmpireConspiracyBeginsSceneNotificationItem.TitleText | | get |


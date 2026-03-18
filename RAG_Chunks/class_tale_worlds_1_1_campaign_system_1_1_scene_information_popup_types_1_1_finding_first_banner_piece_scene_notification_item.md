--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_finding_first_banner_piece_scene_notification_item.html ---

TaleWorlds.CampaignSystem.SceneInformationPopupTypes.FindingFirstBannerPieceSceneNotificationItem Class ReferenceInherits [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnCloseAction](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_finding_first_banner_piece_scene_notification_item.html#a2a55d292a84a267251b29d6cf4761395) () |
|  | Action that gets called when the player closes the notification. Gets called every time. |
|  | [FindingFirstBannerPieceSceneNotificationItem](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_finding_first_banner_piece_scene_notification_item.html#a6ea95b73aa6df2a0aa2cf5883d9aee0a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) playerHero, Action onCloseAction=null) |
| Public Member Functions inherited from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) | |
| virtual void | [OnAffirmativeAction](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a8810821b923c41417fbce0c3257142d5) () |
|  | Action that gets executed when player chooses the positive action. Won't get called if IsAffirmativeOptionShown == false. |
| virtual void | [OnNegativeAction](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a0f425f84b6f519b2064b562ca3d5d2e2) () |
|  | Action that gets executed when player chooses the negative action. Won't get called if IsNegativeOptionShown == false. |
| virtual [Banner](class_tale_worlds_1_1_core_1_1_banner.html)[] | [GetBanners](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a2c44bde5b0ef5debab1f533271243b01) () |
| virtual [SceneNotificationCharacter](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_character.html)[] | [GetSceneNotificationCharacters](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a7f216ae4b4a1c0a93c5ebf5c49a1e490) () |
| virtual [SceneNotificationShip](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_ship.html)[] | [GetShips](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#ac0668e4261e18b0a43537edf26be14bd) () |

|  |  |
| --- | --- |
| Properties | |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [PlayerHero](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_finding_first_banner_piece_scene_notification_item.html#a07ae4b861b8dfd0eb1008aa850750f83) `[get]` |
| override string | [SceneID](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_finding_first_banner_piece_scene_notification_item.html#ab766be8f193c3172356b0b2629c71c63) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_finding_first_banner_piece_scene_notification_item.html#a943c2a0164c3e5c8f5f5604b520ed44b) `[get]` |
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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_finding_first_banner_piece_scene_notification_item.html#a6ea95b73aa6df2a0aa2cf5883d9aee0a)FindingFirstBannerPieceSceneNotificationItem()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.SceneInformationPopupTypes.FindingFirstBannerPieceSceneNotificationItem.FindingFirstBannerPieceSceneNotificationItem | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *playerHero*, |
|  |  | Action | *onCloseAction* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_finding_first_banner_piece_scene_notification_item.html#a2a55d292a84a267251b29d6cf4761395)OnCloseAction()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.SceneInformationPopupTypes.FindingFirstBannerPieceSceneNotificationItem.OnCloseAction | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a52576cd93bfdea06392585837343e462).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_finding_first_banner_piece_scene_notification_item.html#a07ae4b861b8dfd0eb1008aa850750f83)PlayerHero
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.FindingFirstBannerPieceSceneNotificationItem.PlayerHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_finding_first_banner_piece_scene_notification_item.html#ab766be8f193c3172356b0b2629c71c63)SceneID
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.CampaignSystem.SceneInformationPopupTypes.FindingFirstBannerPieceSceneNotificationItem.SceneID | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_finding_first_banner_piece_scene_notification_item.html#a943c2a0164c3e5c8f5f5604b520ed44b)TitleText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.FindingFirstBannerPieceSceneNotificationItem.TitleText | | get |


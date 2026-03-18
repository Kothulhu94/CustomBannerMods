--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html ---

TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracyBeginsSceneNotificationItem Class ReferenceInherits [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [Banner](class_tale_worlds_1_1_core_1_1_banner.html)[] | [GetBanners](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a6a46bc5466ad42b5236485ce2381d8a4) () |
| override [SceneNotificationCharacter](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_character.html)[] | [GetSceneNotificationCharacters](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a0d785528583b2ccc94f592113e8933df) () |
|  | [EmpireConspiracyBeginsSceneNotificationItem](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a98fb10487a59e604d44ef2d20a3d10b0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) playerHero, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) empire, bool isConspiracyAgainstEmpire) |
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
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [PlayerHero](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a1ad59dfd57ad6fd7f125714d0b2ea992) `[get]` |
| [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | [Empire](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a1949fb493fbfcfa863d3e77d7ecd03cd) `[get]` |
| bool | [IsConspiracyAgainstEmpire](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a97b2bd15840ff0ea2c9e44f67a3d1668) `[get]` |
| override string | [SceneID](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a8f7b0c760570188de7b7f4ea95798d4f) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#ac6ec38c54971dd87a54750df742c4ca0) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a98fb10487a59e604d44ef2d20a3d10b0)EmpireConspiracyBeginsSceneNotificationItem()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracyBeginsSceneNotificationItem.EmpireConspiracyBeginsSceneNotificationItem | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *playerHero*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *empire*, |
|  |  | bool | *isConspiracyAgainstEmpire* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a6a46bc5466ad42b5236485ce2381d8a4)GetBanners()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [Banner](class_tale_worlds_1_1_core_1_1_banner.html)[] TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracyBeginsSceneNotificationItem.GetBanners | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a2c44bde5b0ef5debab1f533271243b01).

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a0d785528583b2ccc94f592113e8933df)GetSceneNotificationCharacters()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [SceneNotificationCharacter](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_character.html)[] TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracyBeginsSceneNotificationItem.GetSceneNotificationCharacters | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a7f216ae4b4a1c0a93c5ebf5c49a1e490).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a1ad59dfd57ad6fd7f125714d0b2ea992)PlayerHero
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracyBeginsSceneNotificationItem.PlayerHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a1949fb493fbfcfa863d3e77d7ecd03cd)Empire
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracyBeginsSceneNotificationItem.Empire | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a97b2bd15840ff0ea2c9e44f67a3d1668)IsConspiracyAgainstEmpire
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracyBeginsSceneNotificationItem.IsConspiracyAgainstEmpire | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#a8f7b0c760570188de7b7f4ea95798d4f)SceneID
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracyBeginsSceneNotificationItem.SceneID | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_empire_conspiracy_begins_scene_notification_item.html#ac6ec38c54971dd87a54750df742c4ca0)TitleText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.EmpireConspiracyBeginsSceneNotificationItem.TitleText | | get |


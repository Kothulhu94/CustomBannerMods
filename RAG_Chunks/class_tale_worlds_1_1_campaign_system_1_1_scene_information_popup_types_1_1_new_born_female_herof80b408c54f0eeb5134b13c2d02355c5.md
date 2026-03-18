--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html ---

TaleWorlds.CampaignSystem.SceneInformationPopupTypes.NewBornFemaleHeroSceneAlternateNotificationItem Class ReferenceInherits [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [SceneNotificationCharacter](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_character.html)[] | [GetSceneNotificationCharacters](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html#aed62245639563b34575ecf7db18fb758) () |
|  | [NewBornFemaleHeroSceneAlternateNotificationItem](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html#a54489e2f5c82775f32c60206d5662552) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maleHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) femaleHero, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) creationTime) |
| Public Member Functions inherited from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) | |
| virtual void | [OnAffirmativeAction](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a8810821b923c41417fbce0c3257142d5) () |
|  | Action that gets executed when player chooses the positive action. Won't get called if IsAffirmativeOptionShown == false. |
| virtual void | [OnNegativeAction](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a0f425f84b6f519b2064b562ca3d5d2e2) () |
|  | Action that gets executed when player chooses the negative action. Won't get called if IsNegativeOptionShown == false. |
| virtual void | [OnCloseAction](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a52576cd93bfdea06392585837343e462) () |
|  | Action that gets called when the player closes the notification. Gets called every time. |
| virtual [Banner](class_tale_worlds_1_1_core_1_1_banner.html)[] | [GetBanners](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a2c44bde5b0ef5debab1f533271243b01) () |
| virtual [SceneNotificationShip](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_ship.html)[] | [GetShips](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#ac0668e4261e18b0a43537edf26be14bd) () |

|  |  |
| --- | --- |
| Properties | |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [MaleHero](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html#ad2ad7e05020de0408a478ccbf46d6b30) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [FemaleHero](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html#a8689d9035989c2b5f091df82a5188b1e) `[get]` |
| override string | [SceneID](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html#ac180780180a1586145840569bedcb1e9) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html#a09e9919a211f40f52b1fe92c880538f5) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html#a54489e2f5c82775f32c60206d5662552)NewBornFemaleHeroSceneAlternateNotificationItem()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.SceneInformationPopupTypes.NewBornFemaleHeroSceneAlternateNotificationItem.NewBornFemaleHeroSceneAlternateNotificationItem | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maleHero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *femaleHero*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *creationTime* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html#aed62245639563b34575ecf7db18fb758)GetSceneNotificationCharacters()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [SceneNotificationCharacter](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_character.html)[] TaleWorlds.CampaignSystem.SceneInformationPopupTypes.NewBornFemaleHeroSceneAlternateNotificationItem.GetSceneNotificationCharacters | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a7f216ae4b4a1c0a93c5ebf5c49a1e490).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html#ad2ad7e05020de0408a478ccbf46d6b30)MaleHero
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.NewBornFemaleHeroSceneAlternateNotificationItem.MaleHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html#a8689d9035989c2b5f091df82a5188b1e)FemaleHero
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.NewBornFemaleHeroSceneAlternateNotificationItem.FemaleHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html#ac180780180a1586145840569bedcb1e9)SceneID
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.CampaignSystem.SceneInformationPopupTypes.NewBornFemaleHeroSceneAlternateNotificationItem.SceneID | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_new_born_female_herof80b408c54f0eeb5134b13c2d02355c5.html#a09e9919a211f40f52b1fe92c880538f5)TitleText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.NewBornFemaleHeroSceneAlternateNotificationItem.TitleText | | get |


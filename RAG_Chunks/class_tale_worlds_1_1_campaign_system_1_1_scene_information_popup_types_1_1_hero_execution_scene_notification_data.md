--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html ---

TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData Class ReferenceInherits [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [SceneNotificationCharacter](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_character.html)[] | [GetSceneNotificationCharacters](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#ad450be6e582c599ecd9e1d755bab818e) () |
| override void | [OnCloseAction](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a1fdb74ae0eb17ed772b3a031454d0ab9) () |
|  | Action that gets called when the player closes the notification. Gets called every time. |
| override void | [OnAffirmativeAction](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a76db2e8c75b94c17b43a060db130ad19) () |
|  | Action that gets executed when player chooses the positive action. Won't get called if IsAffirmativeOptionShown == false. |
| Public Member Functions inherited from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) | |
| virtual void | [OnNegativeAction](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a0f425f84b6f519b2064b562ca3d5d2e2) () |
|  | Action that gets executed when player chooses the negative action. Won't get called if IsNegativeOptionShown == false. |
| virtual [Banner](class_tale_worlds_1_1_core_1_1_banner.html)[] | [GetBanners](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a2c44bde5b0ef5debab1f533271243b01) () |
| virtual [SceneNotificationShip](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_ship.html)[] | [GetShips](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#ac0668e4261e18b0a43537edf26be14bd) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static HeroExecutionSceneNotificationData | [CreateForPlayerExecutingHero](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#aa292e119dae61e5b5b9ad194848f88c3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) dyingHero, Action onAffirmativeAction, [RelevantContextType](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fad) relevantContextType=[RelevantContextType.Any](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fadaed36a1ef76a59ee3f15180e0441188ad), bool showNegativeOption=true) |
| static HeroExecutionSceneNotificationData | [CreateForInformingPlayer](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#aceb235122a2051a211a897758247cf27) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) executingHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) dyingHero, [RelevantContextType](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fad) relevantContextType=[RelevantContextType.Any](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fadaed36a1ef76a59ee3f15180e0441188ad)) |

|  |  |
| --- | --- |
| Static Protected Attributes | |
| static int | [MaxShownRelationChanges](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a1913565ecd8aa84e0e67c99c6b2bf24f) = 8 |

|  |  |
| --- | --- |
| Properties | |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Executer](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a445b8fef3992632e449f8b0602825ec8) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Victim](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a469bc5b0fa3e47fa3e6b78bbe7560dec) `[get]` |
| override bool | [IsNegativeOptionShown](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a602e8b6ec5ee743371ef4c4b04c9fb38) `[get]` |
| override string | [SceneID](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a4e0b6399e925a161daa456b09926cf13) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [NegativeText](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#ab0796ef95205440ae1f82750f3bfc308) `[get]` |
| override bool | [IsAffirmativeOptionShown](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a5ed98c2422e7fd7da3e377a620803678) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#abae641fd845ef272b11e51096b9d493e) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AffirmativeText](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a4710cdee17258d4788c4fb5cf0f74d1a) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AffirmativeTitleText](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#acc240e5f573b1a32c32122c9cca8f7b4) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AffirmativeHintText](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a3b33b265a1500056cac4ece064e1c54e) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AffirmativeHintTextExtended](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a127279c9e2b082942a1723af2345bfee) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AffirmativeDescriptionText](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#add75606793b10f46e68fa233763dc0a9) `[get]` |
| override [RelevantContextType](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fad) | [RelevantContext](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#ad9e5fc934063ebd748d34c4eb7c329fa) `[get]` |
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

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#ad450be6e582c599ecd9e1d755bab818e)GetSceneNotificationCharacters()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [SceneNotificationCharacter](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_character.html)[] TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.GetSceneNotificationCharacters | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a7f216ae4b4a1c0a93c5ebf5c49a1e490).

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a1fdb74ae0eb17ed772b3a031454d0ab9)OnCloseAction()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.OnCloseAction | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a52576cd93bfdea06392585837343e462).

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a76db2e8c75b94c17b43a060db130ad19)OnAffirmativeAction()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.OnAffirmativeAction | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#a8810821b923c41417fbce0c3257142d5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#aa292e119dae61e5b5b9ad194848f88c3)CreateForPlayerExecutingHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | HeroExecutionSceneNotificationData TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.CreateForPlayerExecutingHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *dyingHero*, | |  |  | Action | *onAffirmativeAction*, | |  |  | [RelevantContextType](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fad) | *relevantContextType* = [RelevantContextType::Any](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fadaed36a1ef76a59ee3f15180e0441188ad), | |  |  | bool | *showNegativeOption* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#aceb235122a2051a211a897758247cf27)CreateForInformingPlayer()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | HeroExecutionSceneNotificationData TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.CreateForInformingPlayer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *executingHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *dyingHero*, | |  |  | [RelevantContextType](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fad) | *relevantContextType* = [RelevantContextType::Any](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fadaed36a1ef76a59ee3f15180e0441188ad) ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a1913565ecd8aa84e0e67c99c6b2bf24f)MaxShownRelationChanges
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.MaxShownRelationChanges = 8 | | staticprotected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a445b8fef3992632e449f8b0602825ec8)Executer
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.Executer | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a469bc5b0fa3e47fa3e6b78bbe7560dec)Victim
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.Victim | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a602e8b6ec5ee743371ef4c4b04c9fb38)IsNegativeOptionShown
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.IsNegativeOptionShown | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a4e0b6399e925a161daa456b09926cf13)SceneID
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.SceneID | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#ab0796ef95205440ae1f82750f3bfc308)NegativeText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.NegativeText | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a5ed98c2422e7fd7da3e377a620803678)IsAffirmativeOptionShown
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.IsAffirmativeOptionShown | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#abae641fd845ef272b11e51096b9d493e)TitleText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.TitleText | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a4710cdee17258d4788c4fb5cf0f74d1a)AffirmativeText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.AffirmativeText | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#acc240e5f573b1a32c32122c9cca8f7b4)AffirmativeTitleText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.AffirmativeTitleText | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a3b33b265a1500056cac4ece064e1c54e)AffirmativeHintText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.AffirmativeHintText | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#a127279c9e2b082942a1723af2345bfee)AffirmativeHintTextExtended
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.AffirmativeHintTextExtended | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#add75606793b10f46e68fa233763dc0a9)AffirmativeDescriptionText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.AffirmativeDescriptionText | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_hero_execution_scene_notification_data.html#ad9e5fc934063ebd748d34c4eb7c329fa)RelevantContext
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [RelevantContextType](class_tale_worlds_1_1_core_1_1_scene_notification_data.html#af8e737e2e18e86e26353861b970a9fad) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.HeroExecutionSceneNotificationData.RelevantContext | | get |


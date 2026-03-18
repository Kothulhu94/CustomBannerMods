--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html ---

TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [SceneNotificationData.SceneNotificationCharacter](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_character.html) | [GetBodyguardOfCulture](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#afe42da9242635a2c10f425b03eb2fc91) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture) |
| static void | [RemoveWeaponsFromEquipment](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#adafc97ee317f12866e4f4424ce13dac2) (ref [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) equipment, bool removeHelmet=false, bool removeShoulder=false) |
| static string | [GetChildStageEquipmentIDFromCulture](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#a35444b45f3f3f2e89c77bc9ed362ba05) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) childCulture) |
| static [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GetRandomTroopForCulture](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#afbd61f7915ccd1485fa2e7eb33391701) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture) |
| static IEnumerable< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [GetMilitaryAudienceForHero](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#a95adfa278d8de4c7eff5be6de2cf82f3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool includeClanLeader=true, bool onlyClanMembers=false) |
|  | Returns miliary heroes related to hero. Prioritizing clan members etc. |
| static IEnumerable< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [GetMilitaryAudienceForKingdom](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#a5a160bfe9c2204784b5c8542974d6cb7) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, bool includeKingdomLeader=true) |
|  | Returns military heroes related from [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html). Leader first then vassals ordered by their influence. |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetFormalDayAndSeasonText](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#a96cb279f709a483d4ea438390765c325) ([CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) time) |
|  | Returns "the {DAY\_ORDINAL} day of {SEASON\_NAME}" e.g "the eighteenth day of Autumn". |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetFormalNameForKingdom](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#a9feffd9110de4cd85ad064e81a048b40) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
|  | Returns the formal name of kingdom from xml. |
| static [SceneNotificationData.SceneNotificationCharacter](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_character.html) | [CreateNotificationCharacterFromHero](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#afb68ee82b4010a8381fc4607b1a75bf8) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) overridenEquipment=default, bool useCivilian=false, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) overriddenBodyProperties=default, uint overriddenColor1=uint.MaxValue, uint overriddenColor2=uint.MaxValue, bool useHorse=false) |
| static [SceneNotificationData.SceneNotificationShip](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_ship.html) | [CreateNotificationShipFromShip](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#aa79731a13ec2302b2ed77211bd46da4b) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| static [SceneNotificationData.SceneNotificationShip](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_ship.html) | [CreateNotificationShipFromShip](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#adb4516d98061f98b66554d755e10346d) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, float hitPointRatio) |
| static [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetDefaultHorseItem](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#a8d08ed8bd5d05c3c3524d1c491c56bc6) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#afe42da9242635a2c10f425b03eb2fc91)GetBodyguardOfCulture()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [SceneNotificationData.SceneNotificationCharacter](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_character.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper.GetBodyguardOfCulture | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#adafc97ee317f12866e4f4424ce13dac2)RemoveWeaponsFromEquipment()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper.RemoveWeaponsFromEquipment | ( | ref [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *equipment*, | |  |  | bool | *removeHelmet* = false, | |  |  | bool | *removeShoulder* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#a35444b45f3f3f2e89c77bc9ed362ba05)GetChildStageEquipmentIDFromCulture()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper.GetChildStageEquipmentIDFromCulture | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *childCulture* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#afbd61f7915ccd1485fa2e7eb33391701)GetRandomTroopForCulture()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper.GetRandomTroopForCulture | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#a95adfa278d8de4c7eff5be6de2cf82f3)GetMilitaryAudienceForHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper.GetMilitaryAudienceForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *includeClanLeader* = true, | |  |  | bool | *onlyClanMembers* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#a5a160bfe9c2204784b5c8542974d6cb7)GetMilitaryAudienceForKingdom()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper.GetMilitaryAudienceForKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | bool | *includeKingdomLeader* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#a96cb279f709a483d4ea438390765c325)GetFormalDayAndSeasonText()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper.GetFormalDayAndSeasonText | ( | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *time* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#a9feffd9110de4cd85ad064e81a048b40)GetFormalNameForKingdom()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper.GetFormalNameForKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#afb68ee82b4010a8381fc4607b1a75bf8)CreateNotificationCharacterFromHero()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [SceneNotificationData.SceneNotificationCharacter](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_character.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper.CreateNotificationCharacterFromHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *overridenEquipment* = default, | |  |  | bool | *useCivilian* = false, | |  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *overriddenBodyProperties* = default, | |  |  | uint | *overriddenColor1* = uint::MaxValue, | |  |  | uint | *overriddenColor2* = uint::MaxValue, | |  |  | bool | *useHorse* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#aa79731a13ec2302b2ed77211bd46da4b)CreateNotificationShipFromShip() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [SceneNotificationData.SceneNotificationShip](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_ship.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper.CreateNotificationShipFromShip | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#adb4516d98061f98b66554d755e10346d)CreateNotificationShipFromShip() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [SceneNotificationData.SceneNotificationShip](struct_tale_worlds_1_1_core_1_1_scene_notification_data_1_1_scene_notification_ship.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper.CreateNotificationShipFromShip | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | float | *hitPointRatio* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_scene_information_popup_types_1_1_campaign_scene_notification_helper.html#a8d08ed8bd5d05c3c3524d1c491c56bc6)GetDefaultHorseItem()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.SceneInformationPopupTypes.CampaignSceneNotificationHelper.GetDefaultHorseItem | ( |  | ) |  | | static |


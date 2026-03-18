--- SOURCE: class_helpers_1_1_menu_helper.html ---

Helpers.MenuHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [SetOptionProperties](class_helpers_1_1_menu_helper.html#a63dc75f78eac97678b5448dba4b69d6e) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args, bool canPlayerDo, bool shouldBeDisabled, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) disabledText) |
| static void | [SetIssueAndQuestDataForHero](class_helpers_1_1_menu_helper.html#af0acb76b56c1be4c827569df09e3dc81) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| static void | [SetIssueAndQuestDataForLocations](class_helpers_1_1_menu_helper.html#a3b9cbfbaa1a507a578a55ed5b22a7f3c) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args, List< [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) > locations) |
| static bool | [CheckAndOpenNextLocation](class_helpers_1_1_menu_helper.html#a3eed847be4c0f4db323b07c4deb50039) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [DecideMenuState](class_helpers_1_1_menu_helper.html#a7e364d13706673c6b07be5770416727a) () |
| static bool | [EncounterAttackCondition](class_helpers_1_1_menu_helper.html#a627179d0f74d25279a5fdc04292bd911) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static bool | [EncounterCaptureEnemyCondition](class_helpers_1_1_menu_helper.html#a0461accc42ee9b2a39234f4e80211926) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [EncounterAttackConsequence](class_helpers_1_1_menu_helper.html#a3c5cd554be526696216b0f6b09895c36) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [CheckEnemyAttackableHonorably](class_helpers_1_1_menu_helper.html#a9c94039ee22f1e0debaad5781b28fdfd) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static bool | [EncounterOrderAttackCondition](class_helpers_1_1_menu_helper.html#a5352be255480e3402283dec908c7899d) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [EncounterOrderAttackConsequence](class_helpers_1_1_menu_helper.html#a8b600deecfea1a9aadc724a00c85244f) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [EncounterCaptureTheEnemyOnConsequence](class_helpers_1_1_menu_helper.html#a4f34803dbd5fc147f34bd8a976506fd4) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [EncounterLeaveConsequence](class_helpers_1_1_menu_helper.html#a9b1dc350b60f1f6ae97762cdf4f36708) () |
| static string | [GetEncounterCultureBackgroundMesh](class_helpers_1_1_menu_helper.html#a3ed34f18193057b426a8eac82be4a42a) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) encounterCulture) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_menu_helper.html#a63dc75f78eac97678b5448dba4b69d6e)SetOptionProperties()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.MenuHelper.SetOptionProperties | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args*, | |  |  | bool | *canPlayerDo*, | |  |  | bool | *shouldBeDisabled*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *disabledText* ) | | static |

[◆](class_helpers_1_1_menu_helper.html#af0acb76b56c1be4c827569df09e3dc81)SetIssueAndQuestDataForHero()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.MenuHelper.SetIssueAndQuestDataForHero | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | static |

[◆](class_helpers_1_1_menu_helper.html#a3b9cbfbaa1a507a578a55ed5b22a7f3c)SetIssueAndQuestDataForLocations()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.MenuHelper.SetIssueAndQuestDataForLocations | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args*, | |  |  | List< [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) > | *locations* ) | | static |

[◆](class_helpers_1_1_menu_helper.html#a3eed847be4c0f4db323b07c4deb50039)CheckAndOpenNextLocation()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool Helpers.MenuHelper.CheckAndOpenNextLocation | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_helpers_1_1_menu_helper.html#a7e364d13706673c6b07be5770416727a)DecideMenuState()
------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void Helpers.MenuHelper.DecideMenuState | ( |  | ) |  | | static |

[◆](class_helpers_1_1_menu_helper.html#a627179d0f74d25279a5fdc04292bd911)EncounterAttackCondition()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool Helpers.MenuHelper.EncounterAttackCondition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_helpers_1_1_menu_helper.html#a0461accc42ee9b2a39234f4e80211926)EncounterCaptureEnemyCondition()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool Helpers.MenuHelper.EncounterCaptureEnemyCondition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_helpers_1_1_menu_helper.html#a3c5cd554be526696216b0f6b09895c36)EncounterAttackConsequence()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.MenuHelper.EncounterAttackConsequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_helpers_1_1_menu_helper.html#a9c94039ee22f1e0debaad5781b28fdfd)CheckEnemyAttackableHonorably()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.MenuHelper.CheckEnemyAttackableHonorably | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_helpers_1_1_menu_helper.html#a5352be255480e3402283dec908c7899d)EncounterOrderAttackCondition()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool Helpers.MenuHelper.EncounterOrderAttackCondition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_helpers_1_1_menu_helper.html#a8b600deecfea1a9aadc724a00c85244f)EncounterOrderAttackConsequence()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.MenuHelper.EncounterOrderAttackConsequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_helpers_1_1_menu_helper.html#a4f34803dbd5fc147f34bd8a976506fd4)EncounterCaptureTheEnemyOnConsequence()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.MenuHelper.EncounterCaptureTheEnemyOnConsequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_helpers_1_1_menu_helper.html#a9b1dc350b60f1f6ae97762cdf4f36708)EncounterLeaveConsequence()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void Helpers.MenuHelper.EncounterLeaveConsequence | ( |  | ) |  | | static |

[◆](class_helpers_1_1_menu_helper.html#a3ed34f18193057b426a8eac82be4a42a)GetEncounterCultureBackgroundMesh()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string Helpers.MenuHelper.GetEncounterCultureBackgroundMesh | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *encounterCulture* | ) |  | | static |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.VillagerCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Classes | |
| class | [VillagerCampaignBehaviorTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior_1_1_283733afbb0e8cd69ef79723f3e37630.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a86bdbbdccaae2e6fd01759f7d1edccc1) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#aa0ad10254ccd876029da4e798ae93190) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [DailyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a17992fc3e362b5c1796e46f8e4d683c3) () |
| void | [OnSessionLaunched](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a5726e04b75deae447d73828056584d77) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| bool | [taking\_food\_from\_villagers\_wait\_on\_condition](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a6179b0f0f80d92adb8e46edab9ca830d) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| bool | [press\_into\_service\_confirm\_on\_condition](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a0771d30666dfd8f31c1a9d68e5b0e81d) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| void | [taking\_food\_from\_villagers\_wait\_on\_consequence](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a389a1a0d57c3efaa5202db6ed74416d2) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [AddDialogs](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a5eea73b4c106709746039a80cbca342b) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameSystemStarter) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a86bdbbdccaae2e6fd01759f7d1edccc1)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.VillagerCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#aa0ad10254ccd876029da4e798ae93190)SyncData()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.VillagerCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a17992fc3e362b5c1796e46f8e4d683c3)DailyTick()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.VillagerCampaignBehavior.DailyTick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a5726e04b75deae447d73828056584d77)OnSessionLaunched()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.VillagerCampaignBehavior.OnSessionLaunched | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a5eea73b4c106709746039a80cbca342b)AddDialogs()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.VillagerCampaignBehavior.AddDialogs | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameSystemStarter* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a6179b0f0f80d92adb8e46edab9ca830d)taking\_food\_from\_villagers\_wait\_on\_condition()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.VillagerCampaignBehavior.taking\_food\_from\_villagers\_wait\_on\_condition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a0771d30666dfd8f31c1a9d68e5b0e81d)press\_into\_service\_confirm\_on\_condition()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.VillagerCampaignBehavior.press\_into\_service\_confirm\_on\_condition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_villager_campaign_behavior.html#a389a1a0d57c3efaa5202db6ed74416d2)taking\_food\_from\_villagers\_wait\_on\_consequence()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.VillagerCampaignBehavior.taking\_food\_from\_villagers\_wait\_on\_consequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.HideoutCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.IHideoutCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_hideout_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#ade6de20dc9f55b13829946708a16e860) () |
| void | [OnNewGameCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#a26b88484a38fb0d7ac826ea5e35c8560) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| void | [OnGameLoaded](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#af4d09eba3c31c4a5d965ae4172ae4bbd) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| void | [HourlyTickSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#aa3d5507b44e8f58a27e524d0f761ef61) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#a2c48daeb949c857ea89bcf697438de8b) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| int | [GetInitialHideoutPopulation](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#aca23210eb6d586316ecb12bb05a123be) () |
| bool | [hideout\_wait\_menu\_on\_condition](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#a68ea6bbd9a52c58fefef6845e1d173b0) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| void | [hideout\_wait\_menu\_on\_tick](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#ae032f20797bc079d570d60fb29cf1072) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) campaignTime) |
| void | [hideout\_wait\_menu\_on\_consequence](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#a6d9e732f5d25f01ca085fb22326fc21a) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [AddGameMenus](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#aff591511a2354fbd8fd4bf666e6e9c11) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#ade6de20dc9f55b13829946708a16e860)RegisterEvents()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.HideoutCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#a26b88484a38fb0d7ac826ea5e35c8560)OnNewGameCreated()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.HideoutCampaignBehavior.OnNewGameCreated | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#af4d09eba3c31c4a5d965ae4172ae4bbd)OnGameLoaded()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.HideoutCampaignBehavior.OnGameLoaded | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#aa3d5507b44e8f58a27e524d0f761ef61)HourlyTickSettlement()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.HideoutCampaignBehavior.HourlyTickSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#a2c48daeb949c857ea89bcf697438de8b)SyncData()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.HideoutCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#aff591511a2354fbd8fd4bf666e6e9c11)AddGameMenus()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.HideoutCampaignBehavior.AddGameMenus | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#aca23210eb6d586316ecb12bb05a123be)GetInitialHideoutPopulation()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.HideoutCampaignBehavior.GetInitialHideoutPopulation | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IHideoutCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_hideout_campaign_behavior.html#aa89479ca6f1bbce04b7836a12c52c02b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#a68ea6bbd9a52c58fefef6845e1d173b0)hideout\_wait\_menu\_on\_condition()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.HideoutCampaignBehavior.hideout\_wait\_menu\_on\_condition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#ae032f20797bc079d570d60fb29cf1072)hideout\_wait\_menu\_on\_tick()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.HideoutCampaignBehavior.hideout\_wait\_menu\_on\_tick | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *campaignTime* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_hideout_campaign_behavior.html#a6d9e732f5d25f01ca085fb22326fc21a)hideout\_wait\_menu\_on\_consequence()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.HideoutCampaignBehavior.hideout\_wait\_menu\_on\_consequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  |


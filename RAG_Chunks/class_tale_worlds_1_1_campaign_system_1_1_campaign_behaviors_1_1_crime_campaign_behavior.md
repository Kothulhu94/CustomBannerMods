--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#aebe7fe13ec9ea0e9cdef4faf46faa28d) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#ae1432b1e25b16942b825470cc1e64e25) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [game\_menu\_town\_criminal\_on\_init](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a6eee8f80244c19c9d0dedcf6d2dfec13) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [town\_inside\_criminal\_on\_init](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a30a947a7eadffda31acbeb90f004e88c) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [town\_discuss\_criminal\_surrender\_on\_init](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a037ed9148f64390d1f4dab70b47ef3fa) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static bool | [criminal\_inside\_menu\_pay\_by\_punishment\_on\_condition](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#af55c288596a3861f8e4170d0795256b5) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [criminal\_inside\_menu\_pay\_by\_punishment\_on\_consequence](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a4c2bb3b7154597cea96d24bc77c9e109) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static bool | [criminal\_inside\_menu\_give\_money\_on\_condition](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a831fcc7f8622a6c4d54fe2f1a361c81f) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [criminal\_inside\_menu\_give\_money\_on\_consequence](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a86695171dde7e8f50fa91d84bc3b59c3) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static bool | [criminal\_inside\_menu\_give\_influence\_on\_condition](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a5de1facb0e783d598887ba86e3c905b0) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [criminal\_inside\_menu\_give\_influence\_on\_consequence](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#adff32c78d6d29a3ab7a814f4cabca57b) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static bool | [criminal\_inside\_menu\_give\_punishment\_and\_money\_on\_condition](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a8f31582b932bbb16f4cab051f6e77fd0) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [criminal\_inside\_menu\_give\_punishment\_and\_money\_on\_consequence](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#aa4a2afd95d142e1c477da50b4e793ff7) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static bool | [criminal\_inside\_menu\_give\_your\_life\_on\_condition](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#afa81820d1708118b0a1adce98bb313cb) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [criminal\_inside\_menu\_give\_your\_life\_on\_consequence](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#af2ffaef30e905c51c925b401b2ff2ebc) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static bool | [criminal\_inside\_menu\_ignore\_charges\_on\_condition](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a5fdc1a251f0e3edf6ff7ed72daca6bc8) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [criminal\_inside\_menu\_ignore\_charges\_on\_consequence](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a67ee58b10edff0db5288a244090494bb) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static void | [town\_discuss\_criminal\_surrender\_back\_on\_consequence](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a518dbe77ae1b776ba471da3f5fc6e077) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| static bool | [town\_discuss\_criminal\_surrender\_on\_condition](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a1552cc25bd31237b0d95179bc7b5c137) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#aebe7fe13ec9ea0e9cdef4faf46faa28d)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#ae1432b1e25b16942b825470cc1e64e25)SyncData()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a6eee8f80244c19c9d0dedcf6d2dfec13)game\_menu\_town\_criminal\_on\_init()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.game\_menu\_town\_criminal\_on\_init | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a30a947a7eadffda31acbeb90f004e88c)town\_inside\_criminal\_on\_init()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.town\_inside\_criminal\_on\_init | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a037ed9148f64390d1f4dab70b47ef3fa)town\_discuss\_criminal\_surrender\_on\_init()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.town\_discuss\_criminal\_surrender\_on\_init | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#af55c288596a3861f8e4170d0795256b5)criminal\_inside\_menu\_pay\_by\_punishment\_on\_condition()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.criminal\_inside\_menu\_pay\_by\_punishment\_on\_condition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a4c2bb3b7154597cea96d24bc77c9e109)criminal\_inside\_menu\_pay\_by\_punishment\_on\_consequence()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.criminal\_inside\_menu\_pay\_by\_punishment\_on\_consequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a831fcc7f8622a6c4d54fe2f1a361c81f)criminal\_inside\_menu\_give\_money\_on\_condition()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.criminal\_inside\_menu\_give\_money\_on\_condition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a86695171dde7e8f50fa91d84bc3b59c3)criminal\_inside\_menu\_give\_money\_on\_consequence()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.criminal\_inside\_menu\_give\_money\_on\_consequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a5de1facb0e783d598887ba86e3c905b0)criminal\_inside\_menu\_give\_influence\_on\_condition()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.criminal\_inside\_menu\_give\_influence\_on\_condition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#adff32c78d6d29a3ab7a814f4cabca57b)criminal\_inside\_menu\_give\_influence\_on\_consequence()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.criminal\_inside\_menu\_give\_influence\_on\_consequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a8f31582b932bbb16f4cab051f6e77fd0)criminal\_inside\_menu\_give\_punishment\_and\_money\_on\_condition()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.criminal\_inside\_menu\_give\_punishment\_and\_money\_on\_condition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#aa4a2afd95d142e1c477da50b4e793ff7)criminal\_inside\_menu\_give\_punishment\_and\_money\_on\_consequence()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.criminal\_inside\_menu\_give\_punishment\_and\_money\_on\_consequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#afa81820d1708118b0a1adce98bb313cb)criminal\_inside\_menu\_give\_your\_life\_on\_condition()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.criminal\_inside\_menu\_give\_your\_life\_on\_condition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#af2ffaef30e905c51c925b401b2ff2ebc)criminal\_inside\_menu\_give\_your\_life\_on\_consequence()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.criminal\_inside\_menu\_give\_your\_life\_on\_consequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a5fdc1a251f0e3edf6ff7ed72daca6bc8)criminal\_inside\_menu\_ignore\_charges\_on\_condition()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.criminal\_inside\_menu\_ignore\_charges\_on\_condition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a67ee58b10edff0db5288a244090494bb)criminal\_inside\_menu\_ignore\_charges\_on\_consequence()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.criminal\_inside\_menu\_ignore\_charges\_on\_consequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a518dbe77ae1b776ba471da3f5fc6e077)town\_discuss\_criminal\_surrender\_back\_on\_consequence()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.town\_discuss\_criminal\_surrender\_back\_on\_consequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_crime_campaign_behavior.html#a1552cc25bd31237b0d95179bc7b5c137)town\_discuss\_criminal\_surrender\_on\_condition()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignBehaviors.CrimeCampaignBehavior.town\_discuss\_criminal\_surrender\_on\_condition | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |


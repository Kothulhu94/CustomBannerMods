--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.RomanceCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [RomanticPreference](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a8a397241f1598ab3941f872ee48edcfa) {     [Conventional](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a8a397241f1598ab3941f872ee48edcfaae593276964d46c43e5b707325fb12b6b) = 0 ,     [Moralist](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a8a397241f1598ab3941f872ee48edcfaa9faedce63ac64909729e03e134086b82) = 1 ,     [AttractedToBravery](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a8a397241f1598ab3941f872ee48edcfaa164edd6a63ea4f72b6031a98bedfd4fa) = 2 ,     [Macchiavellian](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a8a397241f1598ab3941f872ee48edcfaa3a6c77b2af2105280e42397f90b2ca82) = 3 ,     [Romantic](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a8a397241f1598ab3941f872ee48edcfaa6584107d0031ab3005f450f383b9f30d) = 4 ,     [Companionship](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a8a397241f1598ab3941f872ee48edcfaa5de039d3adf1641393f9702183433745) = 5 ,     [MadAndBad](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a8a397241f1598ab3941f872ee48edcfaa8e604b021861c35b02e08479bf7dd0b8) = 6 ,     [Security](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a8a397241f1598ab3941f872ee48edcfaa2fae32629d4ef4fc6341f1751b405e45) = 7 ,     [PreferencesEnd](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a8a397241f1598ab3941f872ee48edcfaa64e55348f3b31263f37378b641f97cb3) = 8   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [RomanceCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#ae5a4b3d16ca68516f89057058d0d183f) () |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#aa7a224155117ca782ec708a461181695) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a52f0ea05179d9ce925453b3290a6b0c1) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnSessionLaunched](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#af35dc919d8cc9a7a336a56dbd75348fd) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [AddDialogs](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#abb32d51631e27c14c6630b447c6371c4) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) starter) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a8a397241f1598ab3941f872ee48edcfa)RomanticPreference
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.CampaignBehaviors.RomanceCampaignBehavior.RomanticPreference](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a8a397241f1598ab3941f872ee48edcfa) |

| Enumerator | |
| --- | --- |
| Conventional |  |
| Moralist |  |
| AttractedToBravery |  |
| Macchiavellian |  |
| Romantic |  |
| Companionship |  |
| MadAndBad |  |
| Security |  |
| PreferencesEnd |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#ae5a4b3d16ca68516f89057058d0d183f)RomanceCampaignBehavior()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CampaignBehaviors.RomanceCampaignBehavior.RomanceCampaignBehavior | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#aa7a224155117ca782ec708a461181695)RegisterEvents()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.RomanceCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#a52f0ea05179d9ce925453b3290a6b0c1)SyncData()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.RomanceCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#af35dc919d8cc9a7a336a56dbd75348fd)OnSessionLaunched()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.RomanceCampaignBehavior.OnSessionLaunched | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_romance_campaign_behavior.html#abb32d51631e27c14c6630b447c6371c4)AddDialogs()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.RomanceCampaignBehavior.AddDialogs | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *starter* | ) |  | | protected |


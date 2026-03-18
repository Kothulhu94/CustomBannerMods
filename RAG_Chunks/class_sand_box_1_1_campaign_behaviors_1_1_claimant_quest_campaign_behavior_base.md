--- SOURCE: class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html ---

SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase Class ReferenceabstractInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

Inherited by [SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [SyncData](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#aee01dcccbfbffa333ef616335705af77) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| override void | [RegisterEvents](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#aedf264e6ef705e4625ed78c905b92807) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [OnSyncData](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a1128f78035210f09f627d400bb19b152) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnRegisterEvents](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a5a1f5b5b1eb99d72391f7b9a23ae7735) () |
| bool | [IsQuestSameAs](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#ac44324bec0fe34462da6df3eab060a25) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) questBase) |
| bool | [IsTalkingToClaimantPreQuest](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a1fea6a4c9579f6262596121ffdd06971) () |
| bool | [IsTalkingToClaimantMetPreQuest](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a553368a84471099b7a08419b27e30e18) () |
| bool | [IsTalkingToClaimantUnmetPreQuest](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a14346918f747500243989afabc8d4515) () |
| bool | [HasActiveClaimantQuest](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a52db8ff7209dbbabb2389402e9a733d7) () |
| bool | [CanTakeQuestClickableCondition](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a27310c48a90e3a21e74eaa1c64d5df27) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [CreateClaimantHero](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a6a540362a5000753176415b2bb4188dd) () |
| bool | [IsTargetKingdomWeak](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#aa1913c25c23ffd0baf7fd56ce54b5137) () |
| bool | [IsThereACivilWar](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a267fbed3e96beccb0acfac0860b1a65a) () |
| void | [StartQuest](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#ac2e2004507c980473019a750a059a2af) () |
| virtual void | [OnBehaviorActivated](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#af9cf4221f0f5c501efb286e9d3aa201b) () |
| virtual void | [OnBehaviorDeactivated](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a255e10c04f6832fddddb378119432e79) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [\_nextCampaignTimeToTeleport](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#aa9e0fb1aa065a2e0e1f6e8574d55525b) |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [\_activationTime](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#ab52306f9f3d148fe8014b922cdf71460) = CampaignTime.Never |
| bool | [\_initializedBehavior](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#af664d9d55a1c0e48150f4fe021cc4070) = false |
| bool | [\_questInvalidated](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#ab8d5b1be77e2ed67cf83cb22ee35d22e) = false |

|  |  |
| --- | --- |
| Properties | |
| string | [KingdomTag](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a921a115f2ec201f4548f085df12b317d) `[get]` |
| int | [PlayerClanTierRequiredForQuestActivation](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a882b068527fa23b385c57cb04cb245d4) `[get]` |
| int | [DialogPriority](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a803e86d19d23ad5de1c553ab019d1d48) `[get]` |
| bool | [IsTimeout](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#aa1648ad47c387c43cff8ce7f1d0e64a8) `[get]` |
| [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | [TargetKingdom](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a00878306308f23d83bc2ad5ae148df59) `[get]` |
| string | [ClaimantStringId](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#abcf6a0c67743ce09728cc07465d2ccbd) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Claimant](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a3dcf0d69fdc067e84f629887b0982b65) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Incumbent](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a59b7f02a9331815cb0c982427e488e12) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#aee01dcccbfbffa333ef616335705af77)SyncData()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  | | sealed |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a1128f78035210f09f627d400bb19b152)OnSyncData()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.OnSyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  | | abstractprotected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#aedf264e6ef705e4625ed78c905b92807)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.RegisterEvents | ( |  | ) |  | | sealed |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a5a1f5b5b1eb99d72391f7b9a23ae7735)OnRegisterEvents()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.OnRegisterEvents | ( |  | ) |  | | abstractprotected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#ac44324bec0fe34462da6df3eab060a25)IsQuestSameAs()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.IsQuestSameAs | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *questBase* | ) |  | | abstractprotected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a1fea6a4c9579f6262596121ffdd06971)IsTalkingToClaimantPreQuest()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.IsTalkingToClaimantPreQuest | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a553368a84471099b7a08419b27e30e18)IsTalkingToClaimantMetPreQuest()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.IsTalkingToClaimantMetPreQuest | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a14346918f747500243989afabc8d4515)IsTalkingToClaimantUnmetPreQuest()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.IsTalkingToClaimantUnmetPreQuest | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a52db8ff7209dbbabb2389402e9a733d7)HasActiveClaimantQuest()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.HasActiveClaimantQuest | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a27310c48a90e3a21e74eaa1c64d5df27)CanTakeQuestClickableCondition()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.CanTakeQuestClickableCondition | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a6a540362a5000753176415b2bb4188dd)CreateClaimantHero()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.CreateClaimantHero | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#aa1913c25c23ffd0baf7fd56ce54b5137)IsTargetKingdomWeak()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.IsTargetKingdomWeak | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a267fbed3e96beccb0acfac0860b1a65a)IsThereACivilWar()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.IsThereACivilWar | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#ac2e2004507c980473019a750a059a2af)StartQuest()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.StartQuest | ( |  | ) |  | | abstractprotected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#af9cf4221f0f5c501efb286e9d3aa201b)OnBehaviorActivated()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.OnBehaviorActivated | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior.html#ad819431216c98b052ad06dfb49c1958f).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a255e10c04f6832fddddb378119432e79)OnBehaviorDeactivated()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.OnBehaviorDeactivated | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior.html#a3d413253b52739a430313536fb0f1e50).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#aa9e0fb1aa065a2e0e1f6e8574d55525b)\_nextCampaignTimeToTeleport
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.\_nextCampaignTimeToTeleport | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#ab52306f9f3d148fe8014b922cdf71460)\_activationTime
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.\_activationTime = CampaignTime.Never | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#af664d9d55a1c0e48150f4fe021cc4070)\_initializedBehavior
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.\_initializedBehavior = false | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#ab8d5b1be77e2ed67cf83cb22ee35d22e)\_questInvalidated
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.\_questInvalidated = false | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a921a115f2ec201f4548f085df12b317d)KingdomTag
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.KingdomTag | | getabstractprotected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a882b068527fa23b385c57cb04cb245d4)PlayerClanTierRequiredForQuestActivation
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.PlayerClanTierRequiredForQuestActivation | | getprotected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a803e86d19d23ad5de1c553ab019d1d48)DialogPriority
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.DialogPriority | | getprotected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#aa1648ad47c387c43cff8ce7f1d0e64a8)IsTimeout
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.IsTimeout | | getprotected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a00878306308f23d83bc2ad5ae148df59)TargetKingdom
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.TargetKingdom | | getprotected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#abcf6a0c67743ce09728cc07465d2ccbd)ClaimantStringId
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.ClaimantStringId | | getprotected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a3dcf0d69fdc067e84f629887b0982b65)Claimant
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.Claimant | | getprotected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_claimant_quest_campaign_behavior_base.html#a59b7f02a9331815cb0c982427e488e12)Incumbent
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) SandBox.CampaignBehaviors.ClaimantQuestCampaignBehaviorBase.Incumbent | | getprotected |


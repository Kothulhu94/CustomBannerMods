--- SOURCE: class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html ---

SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest Class ReferenceInherits [SandBox.ClaimantQuests.ClaimantQuestBase](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [QuestPhase](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781) {     [Beginning](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781a0558dcc45dad1cfe3d4e55ca16bfbb12) ,     [OutsideForest](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781a5ffb8bcb2d00d565582774074fd481e3) ,     [Lair](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781a82632a14c255ff6091e7ff80582d1670) ,     [Sneak](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781a539e1aa5d142613942c6a35860fc47fb) ,     [Duel](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781a0679ba9276b2173b33d169d0502857ba) ,     [PostDuel](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781a290677f11d5adfbc3a8ff2a5f2fa5a3d) ,     [PreAssault](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781ad9da045de11276ea025fc860bc49f8cc) ,     [PreSallyOut](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781afbf6f1f600a0a9471fc301db3138e148) ,     [AmbushCamp](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781a60a30fadf222b06144e93c7820ed890d) ,     [Assault](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781a636065b2f2a8255a8dc4ff43e54cb286) ,     [PostBattle](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781aea627fdd599df21f58f2bc1d9365d866) ,     [Epilogue](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781a6c4127030e1989824edc2521c809a09f) ,     [CivilWar](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781aa622fa2dadbb5d60bd56d364bfba0809)   } |
| enum | [QuestStatus](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cf) : int {     [None](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfa6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [SpokeWithIncumbent](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfa95bdf4b3e695586e99c398d2c5179ccd) = 1 ,     [UnlockedHiddenTrail](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfa6a2e364c49a1c42d2be3bfe6f1112d30) = 2 ,     [WonFistFight](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfaa4d553408222892109144ce741ad1475) = 4 ,     [MetWithLugemus](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfa30ee2f562782de53ec65850997859e85) = 8 ,     [MetWithRefyll](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfaf938686557a7cbc6e2b7a36509f521f8) = 16 ,     [TalkedToLugemusPreAssault](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfa658ae91f549235407295bcf1134a0c18) = 32 ,     [WonWolfskinSupport](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfa29919da0ff23fb701dab063dab87e7b7) = 64 ,     [WonBattanianSupport](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfa183225bc4c87fcf97f160cc4106a02d0) = 128 ,     [TalkedToSentries](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfac57d57337c5ab8125cbbed2a3201d5f1) = 256 ,     [CaugthInStealthZone](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfa324482c8b310d89c22d4f6c49e97ffda) = 512 ,     [HasAerilsItem](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfa91ef25374774d5a4268b5f69804d1eed) = 1024 ,     [WonFinalDuelWithFinach](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfadb4c827ca60680d97fa2fc27a0f8bfdf) = 2048 ,     [ReadyToEnd](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfa5babbe7e37bd8afbd49a7b8853b009bf) = 4096 ,     [SneakedIntoLair](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfa77acb3662a4b694790b0196f01f2bec6) = 8192 ,     [Betrayed](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cfa1e060fdd84e5b1480f1de23d158e5bd2) = 16384   } |
| Public Types inherited from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | |
| enum | [QuestCompleteDetails](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398) {     [Invalid](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398a4bbb8f967da6d1a610596d7257179c2b) ,     [Success](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398a505a83f220c02df2f85c3810cd9ceb38) ,     [Cancel](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398aea4788705e6873b424c65e91c2846b19) ,     [Fail](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398aceaa0734f0b3c738120c67344d8f3ec1) ,     [Timeout](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398ac85a251cc457840f1e032f1b733e9398) ,     [FailWithBetrayal](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398accab16e25a64129901af8c4b0b5782be)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BattaniaClaimantQuest](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#ae91607a749264df46452a75d5ba5f2fe) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) targetKingdom, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) hideout, int questDurationInDays) |
| void | [CalculateAmbushWaitTime](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a3282169ba200a64a59c7a9c6dc40db6b) () |
| void | [OpenLairMission](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#aff6662ffac98109b41b8801ade53c186) (string playerSpawnPoint, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkTo=null, bool forceDisactivateCastleGate=false, bool openScoutConversation=false) |
| Public Member Functions inherited from [SandBox.ClaimantQuests.ClaimantQuestBase](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html) | |
| override void | [OnFailed](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a3d2bcc3b4d171d74671a6269841d31d0) () |
| override void | [OnCanceled](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a6bf44b6e9a5d186ce7ccb0b741cc729f) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | |
| void | [StartQuest](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ae6683acaddbc0016431f01ab020db7af) () |
| void | [CompleteQuestWithSuccess](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a8cdc42ab9110a7771a37ec431db2356a) () |
| void | [CompleteQuestWithTimeOut](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ae56cc2af9fe4ae8431c02fd94869c1bb) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) timeOutLog=null) |
| void | [CompleteQuestWithFail](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a6bf1b79d67116ae4f6b5ef4dddffbd54) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) cancelLog=null) |
| void | [CompleteQuestWithBetrayal](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a75e70cad019fc9a219ab21dad77056ff) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) betrayLog=null) |
| void | [CompleteQuestWithCancel](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#aa84a904a1ce4ef4e4ddd2f1a9e7c6183) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) cancelLog=null) |
| void | [InitializeQuestOnLoadWithQuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ae7f524cad53d4c979316aecf4d970fc4) () |
| [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) | [AddLog](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#aa156256d128a360bb78042ef2d81871e) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text, bool hideInformation=false) |
| [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) | [AddDiscreteLog](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a07a8fd1454037745e958c3c16cd55ad6) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) taskName, int currentProgress, int targetProgress, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) shortText=null, bool hideInformation=false) |
| [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) | [AddTwoWayContinuousLog](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a41c0bda77cfc7c805bda3df299eafd56) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) taskName, int currentProgress, int range, bool hideInformation=false) |
| virtual [GameMenus.GameMenuOption.IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510) | [IsLocationTrackedByQuest](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a6df937251e4a592ed50733bf52a80687) ([Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |
| virtual int | [GetCurrentProgress](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ae5dcf08bb4939472d80a21a648e3dc8b) () |
| virtual int | [GetMaxProgress](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a53506d482257e6695d8751f897b3312b) () |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ac430d7351e04df73135dd04349cc08e0) () |
| virtual string | [GetPrefabName](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ad003cd898ad19491f62d40986fc7b4ed) () |
| void | [AddTrackedObject](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a24f6855b3c098ee15f7c79d06bcbc409) ([ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) trackedObject) |
| void | [RemoveTrackedObject](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ad6cbd8d293b84035fdbcdae06ccb841a) ([ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) trackedObject) |
| bool | [IsTracked](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a514142da82a8bbcb3068a924c644be29) ([ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) o) |
| void | [ToggleTrackedObjects](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ae43859b771f187d8f98d6ae6d97e9090) () |
| void | [AddGameMenu](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#af0d3914a68bf7a20ed6d650a651c6822) (string menuId, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) menuText, [OnInitDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#ae01fba5e92213046937417cfab6b6ef5) initDelegate, [GameMenu.MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) overlay=[GameMenu.MenuOverlayType.None](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78a6adf97f83acf6453d4a6a4b1070f3754), [GameMenu.MenuFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a78b3f2b8cfeb21997df13c3389587b3d) menuFlags=[GameMenu.MenuFlags.None](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a78b3f2b8cfeb21997df13c3389587b3da6adf97f83acf6453d4a6a4b1070f3754)) |
| void | [AddGameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ada75c30412d6f914dde22e4af2c9aff8) (string menuId, string optionId, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) optionText, [GameMenuOption.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a67f0448f025b739bc2f931a7eee24b66) condition, [GameMenuOption.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#afae542885d132e26e2aaae06a63371b3) consequence, bool Isleave=false, int index=-1) |
| void | [ChangeQuestDueTime](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a93f22cb2df2958ca26ccdd11681e0701) ([CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) questDueTime) |
| virtual bool | [QuestPreconditions](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a4af664b0ab01276de3eb01b858c84ec5) () |
| virtual void | [OnHeroCanHaveCampaignIssuesInfoIsRequested](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#aeece4ef3eab563451de1ac2a3fffa0ca) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [OnHeroCanMarryInfoIsRequested](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a5f76467f38222aebf66fa39b82453446) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [OnHeroCanLeadPartyInfoIsRequested](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a3b217c13fb708d6520fe73fefea51b03) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [OnHeroCanHavePartyRoleOrBeGovernorInfoIsRequested](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a8866f826c1eaf73535106a90bbbd1609) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [OnHeroCanDieInfoIsRequested](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a3752cc21762c6e4465493d7d8e0ff0cf) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) causeOfDeath, ref bool result) |
| virtual void | [OnHeroCanBecomePrisonerInfoIsRequested](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#aee2a3fe049025cd095011e6c643c4177) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [OnHeroCanBeSelectedInInventoryInfoIsRequested](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ac9cb7932a1a81d358cfa8d8e0394ce2e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [OnHeroCanMoveToSettlementInfoIsRequested](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a1b904df011a0538318fd013c975935c4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| virtual void | [Deserialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [PlayerCampSpawnPoint](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#ad90503b30fbdc82486d5f328c5c3327e) = "sp\_player\_camp" |
| const string | [PlayerAmbushSpawnPoint](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2b91488a63473ab887cb023d3bdec4d6) = "sp\_player\_ambush" |
| const string | [CampTag](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a599a140e85dd3c3dfb71c0bb71daffd7) = "battania\_camp" |
| const string | [LairTag](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a68b4337d9447fa9e9a7274690523dbf2) = "wolfskin\_lair" |
| const string | [BattanianMajorClanId](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a6a1adcef1100c2530dca2d0ec38275e7) = "clan\_battania\_2" |
| const string | [WolfskinsId](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#ad02a3f42cff5780923628df3a87ca716) = "wolfskins" |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnFailedInternal](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a5e23224d7845400e7584e12784b4e6db) () |
| override void | [OnCanceledInternal](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#adc4fa2e955fa51382d7a790243a9513d) () |
| override void | [OnFinalizeInternal](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a31d4427dc724989fd38562d952815c2c) () |
| override void | [OnTimedOutInternal](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#aec23adbefd6bacdb5a185316e765edbe) () |
| override void | [OnStartQuestInternal](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a6a8e8116afa0764dd6890d4b4affd84b) () |
| override void | [InitializeQuestOnGameLoadInternal](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a7d4efce62ac8a2aaaf38ee68e2bbca01) () |
| override void | [OnSuccessInternal](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a3abec00e3362b75fb3c05311d457a349) () |
| override void | [OnRegisterEvents](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a10d56f509fff9f736ceac7fc5e2cb1e0) () |
| override void | [SetDialogs](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a218a4f9fa5c942f7090d689401766ff9) () |
| override void | [OnClanChangedKingdomInternal](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a31e21276d7e1d4af9156810001f4e67c) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) oldKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom, [ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035) detail, bool showNotification) |
| override void | [HourlyTick](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a383ed724d111840a42b09d46a78f6e83) () |
| Protected Member Functions inherited from [SandBox.ClaimantQuests.ClaimantQuestBase](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html) | |
|  | [ClaimantQuestBase](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a9486e5823d8aba8cc50b2875e974c146) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) claimant, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) targetKingdom, int questDurationInDays) |
| override void | [OnTimedOut](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a0f15d769f058ee41297c5227fa0ccf34) () |
| override void | [OnFinalize](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a93878fce1a13cef3bff93448b2d25697) () |
| override void | [OnCompleteWithSuccess](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#acdf5f89358083f27134ea34c32d020d4) () |
| void | [OnFailedInternal](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a6ed83702ff893c5a3f02aafafbf1c55b) () |
| void | [OnSuccessInternal](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a1459fcf31e621d9eaebd20c2ca115a71) () |
| void | [OnCanceledInternal](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a59d93150528c273a551246486b8a609d) () |
| void | [OnTimedOutInternal](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a8248356380634bc6dfd9c5d66cb0d720) () |
| void | [OnFinalizeInternal](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#aaa67545b2831011fe967da2ca8df1cba) () |
| override void | [RegisterEvents](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#aa68d0d1b2fd7c86889fd3a1e2179f396) () |
| void | [OnRegisterEvents](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a5342bfea6b03c3a93d71e533b85424b1) () |
| virtual void | [CanHaveQuestsOrIssuesInternal](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#ad9bffd9b9f87dd74a9544f2a51cd0b32) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [OnStartQuest](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a4088878bb490e24f8f3fc3345489170a) () |
| void | [OnStartQuestInternal](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a6d45c9cd4be74b94a928c1b27adc8b8b) () |
| override void | [InitializeQuestOnGameLoad](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#ae148b48b41bc18c916ac526dfb011803) () |
| void | [InitializeQuestOnGameLoadInternal](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#aa62171142809c75d83b5028db0ff322f) () |
| virtual bool | [CivilWarPreConditions](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#adce76014b6d985aae3c38129b4351f72) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) response) |
| virtual void | [OnHeroKilled](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a82b0f81d5906b1f76c50c3a1995fac0c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail, bool notify) |
| bool | [IsTalkingIncumbent](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#aa591d5158159f3b299a6a9cd9389a7cb) () |
| bool | [IsTalkingToClaimant](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a9b14d09b42c9047b7ffb6bf9995af69b) () |
| bool | [SetPlayerProperties](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a342d153980db2211843ca1a4d11fac33) () |
| void | [DisableClaimant](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#ad0162812f345963af5a860abd090860a) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | |
| void | [SetDialogs](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#abdcefff1b3889f90e86ccefd3a4cc7d0) () |
|  | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ad2ca354b840c7cfb576f98a3eb01a811) (string questId, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) questGiver, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) duration, int rewardGold) |
| void | [InitializeQuestOnCreation](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a0679a2673ff9e7fe692f8a5bcf3babb2) () |
| void | [AddTask](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a6f4019862936df1f2353d13b9f4ecb95) ([QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html) task) |
| void | [RemoveLog](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a8f4a4758e94bdbec6c8a7c81ed328591) ([JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) logToRemove) |
| void | [UpdateQuestTaskStage](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#aa80b2e7560c7bdb8c45881492338abc7) ([JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) questLog, int currentProgress) |
| void | [InitializeQuestOnGameLoad](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a587de8566ffa596727ab6297ae61c427) () |
| virtual void | [HourlyTickParty](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ac1d8f36be22f9f2d98941920b1bb66a9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [DailyTick](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#aa6b6a6cca65b08e732caac34ac63b0e8) () |
| virtual void | [WeeklyTick](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ae23eac0a41a0f2e08bf99bb525efaf02) () |
| virtual void | [OnBeforeTimedOut](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a3131e11acfc792bfab37350e638445c5) (ref bool completeWithSuccess, ref bool doNotResolveTheQuest) |
| virtual void | [OnBetrayal](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a9ff49c6216fdf02524620c9512580c42) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

|  |  |
| --- | --- |
| Properties | |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [Hideout](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a18a3884c1d41e73048a75a27529b964e) `[get]` |
| [QuestPhase](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781) | [CurrentQuestPhase](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#acd8f7ada930cef28d409123edae1f12d) `[get]` |
| [QuestStatus](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cf) | [CurrentQuestStatus](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#ae3622f1e8575b1d64d312868c0a6d4cb) `[get]` |
| float | [AmbushWaitTargetHours](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a74bc2a1fcf17a6c482991b105c72886f) `[get]` |
| float | [AmbushWaitProgressHours](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#aec50ed2a50b802e19fdef7af16fe55d5) `[get, set]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [ClaimantAgent](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a80a66cdcebb7d15a4788aad17c2f8d0a) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [LugemusAgent](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a91bf2b96d2ffcbf1023db0e18fe41149) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [RefyllAgent](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a266743b670a69a5c8d9ae7f3f4c9c185) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [HuntsmanAgent](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a9413215f28f476d52ee4ab12ba1431fb) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [WolfskinCommander](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a3df2956490086a2065f7c4a7fdeb413e) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [WolfskinScout](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a7075be0425ea635acb8b85f3fd0f38a0) `[get]` |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [Wolfskins](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a85ae6bd9bcd3db7d2bda7fd60b1cb8d5) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Title](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#abe7e4aedc9e31c753bc0b7c8f7a7b968) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [QuestStartLog](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#ae5d9e3caf2db6597b2090e2113b7b4b6) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [QuestSuccessLog](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a7967dda2ff8784ede16d4268e047b524) `[get]` |
| Properties inherited from [SandBox.ClaimantQuests.ClaimantQuestBase](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html) | |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [ClaimantHero](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a6a9974112f7e472080f7aded447170a6) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [IncumbentHero](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a36d7cbb5afb430df5148ac815e2c660c) `[get]` |
| [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | [TargetKingdom](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#ab6f9949e783f6a67b6c0e86e6c08ae97) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)?????? | [QuestStartLog](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a232b2dc7d7ebe6438ec3b0cf2d7af429) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [QuestSuccessLog](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a3b1e9c28a0b381b76dbd91e3fa5afef7) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [QuestCancelLog](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#adb4a25c9505aa7d9f249080e5267a5d0) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Title](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a6ec669b847b5f07381eafeeab9a6c8ea) `[get]` |
| override string | [SpecialQuestType](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#ab6d636e5b19834d4bad5251677c0146f) `[get]` |
| override bool | [IsRemainingTimeHidden](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#aa79f5ee866750482ffe75f318a13aabb) `[get]` |
| int | [DialogPriority](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#afd8c32f634c41e0283d9bce777b042fc) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [QuestDueTime](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a701d9fc649c2bcdb1833de25acaa7f3c) `[get, protected set]` |
| MBReadOnlyList< [QuestTaskBase](class_tale_worlds_1_1_campaign_system_1_1_quest_task_base.html) > | [TaskList](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#abf1f65fcf6d9d7c17b7235b7d5d99db8) `[get]` |
| MBReadOnlyList< [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) > | [JournalEntries](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#acbae16b92e037262fe07f81084c3d5ad) `[get]` |
| bool | [IsTrackEnabled](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a825c5fa14f5dca1d6447929139f3fd0a) `[get]` |
| bool | [IsOngoing](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ac2fc4e604d23e93f9a9d902affc110c9) `[get]` |
| bool | [IsFinalized](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ab7ea22610dee743a3828f3346a6bbad1) `[get]` |
| bool | [IsThereDiscussDialogFlow](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a7e5f300b0f999e4df63dbf0070dcf9af) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [QuestGiver](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a20595652f40cd6fe25f619ae9869c6f2) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Title](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a043c7782486e6236df9e2b218e9beeb2) `[get]` |
| bool | [IsRemainingTimeHidden](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#af508d8586881a31c029f380453041696) `[get]` |
| virtual int | [RelationshipChangeWithQuestGiver](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#aa177fe5ffd102df083e499a0031de02c) = 0 `[get, protected set]` |
| bool | [IsSpecialQuest](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#af12b45f3bab610c1d0cd98972d3fd2b7) `[get]` |
| virtual string | [SpecialQuestType](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a6fa738b0e44038e53fa4068c74f9346b) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TargetHeroDisappearedLogText](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a268ca5b818e98374aca7f3eac7c44049) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TargetHeroDiedLogText](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a2b782965e4c7a088865f1578061899bf) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | |
| readonly int | [RewardGold](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a9057552b49bef1e0a4e3660093b96763) |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | |
| [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | [OfferDialogFlow](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a2034f3d2ef63e5d300a2745197e81ca9) |
| [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | [DiscussDialogFlow](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a1e45cfb2d062f245b442c39c12173186) |
| [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | [QuestCharacterDialogFlow](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ac4cc1c7750d86831ae1b7b0d0ad4fb45) |

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781)QuestPhase
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.QuestPhase](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781) |

| Enumerator | |
| --- | --- |
| Beginning |  |
| OutsideForest |  |
| Lair |  |
| Sneak |  |
| Duel |  |
| PostDuel |  |
| PreAssault |  |
| PreSallyOut |  |
| AmbushCamp |  |
| Assault |  |
| PostBattle |  |
| Epilogue |  |
| CivilWar |  |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cf)QuestStatus
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.QuestStatus](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cf) : int |

| Enumerator | |
| --- | --- |
| None |  |
| SpokeWithIncumbent |  |
| UnlockedHiddenTrail |  |
| WonFistFight |  |
| MetWithLugemus |  |
| MetWithRefyll |  |
| TalkedToLugemusPreAssault |  |
| WonWolfskinSupport |  |
| WonBattanianSupport |  |
| TalkedToSentries |  |
| CaugthInStealthZone |  |
| HasAerilsItem |  |
| WonFinalDuelWithFinach |  |
| ReadyToEnd |  |
| SneakedIntoLair |  |
| Betrayed |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#ae91607a749264df46452a75d5ba5f2fe)BattaniaClaimantQuest()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.BattaniaClaimantQuest | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *targetKingdom*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *hideout*, |
|  |  | int | *questDurationInDays* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a5e23224d7845400e7584e12784b4e6db)OnFailedInternal()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.OnFailedInternal | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#adc4fa2e955fa51382d7a790243a9513d)OnCanceledInternal()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.OnCanceledInternal | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a31d4427dc724989fd38562d952815c2c)OnFinalizeInternal()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.OnFinalizeInternal | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#aec23adbefd6bacdb5a185316e765edbe)OnTimedOutInternal()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.OnTimedOutInternal | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a6a8e8116afa0764dd6890d4b4affd84b)OnStartQuestInternal()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.OnStartQuestInternal | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a7d4efce62ac8a2aaaf38ee68e2bbca01)InitializeQuestOnGameLoadInternal()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.InitializeQuestOnGameLoadInternal | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a3abec00e3362b75fb3c05311d457a349)OnSuccessInternal()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.OnSuccessInternal | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a10d56f509fff9f736ceac7fc5e2cb1e0)OnRegisterEvents()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.OnRegisterEvents | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a218a4f9fa5c942f7090d689401766ff9)SetDialogs()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.SetDialogs | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a31e21276d7e1d4af9156810001f4e67c)OnClanChangedKingdomInternal()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.OnClanChangedKingdomInternal | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *oldKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom*, | |  |  | [ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035) | *detail*, | |  |  | bool | *showNotification* ) | | protectedvirtual |

Reimplemented from [SandBox.ClaimantQuests.ClaimantQuestBase](class_sand_box_1_1_claimant_quests_1_1_claimant_quest_base.html#a7287e4c06ad6abea82c835ace9b96467).

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a383ed724d111840a42b09d46a78f6e83)HourlyTick()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.HourlyTick | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a7327ef8984429284da693b0872eeda9e).

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a3282169ba200a64a59c7a9c6dc40db6b)CalculateAmbushWaitTime()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.CalculateAmbushWaitTime | ( |  | ) |  |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#aff6662ffac98109b41b8801ade53c186)OpenLairMission()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.OpenLairMission | ( | string | *playerSpawnPoint*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkTo* = null, |
|  |  | bool | *forceDisactivateCastleGate* = false, |
|  |  | bool | *openScoutConversation* = false ) |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#ad90503b30fbdc82486d5f328c5c3327e)PlayerCampSpawnPoint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.PlayerCampSpawnPoint = "sp\_player\_camp" | | static |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2b91488a63473ab887cb023d3bdec4d6)PlayerAmbushSpawnPoint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.PlayerAmbushSpawnPoint = "sp\_player\_ambush" | | static |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a599a140e85dd3c3dfb71c0bb71daffd7)CampTag
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.CampTag = "battania\_camp" | | static |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a68b4337d9447fa9e9a7274690523dbf2)LairTag
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.LairTag = "wolfskin\_lair" | | static |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a6a1adcef1100c2530dca2d0ec38275e7)BattanianMajorClanId
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.BattanianMajorClanId = "clan\_battania\_2" | | static |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#ad02a3f42cff5780923628df3a87ca716)WolfskinsId
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.WolfskinsId = "wolfskins" | | static |

Property Documentation
----------------------

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a18a3884c1d41e73048a75a27529b964e)Hideout
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.Hideout | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#acd8f7ada930cef28d409123edae1f12d)CurrentQuestPhase
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [QuestPhase](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a329532ad4dd21e33c0ea050035a73781) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.CurrentQuestPhase | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#ae3622f1e8575b1d64d312868c0a6d4cb)CurrentQuestStatus
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [QuestStatus](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a2332f231dab9a18541634112ac74f6cf) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.CurrentQuestStatus | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a74bc2a1fcf17a6c482991b105c72886f)AmbushWaitTargetHours
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.AmbushWaitTargetHours | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#aec50ed2a50b802e19fdef7af16fe55d5)AmbushWaitProgressHours
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.AmbushWaitProgressHours | | getset |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a80a66cdcebb7d15a4788aad17c2f8d0a)ClaimantAgent
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.ClaimantAgent | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a91bf2b96d2ffcbf1023db0e18fe41149)LugemusAgent
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.LugemusAgent | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a266743b670a69a5c8d9ae7f3f4c9c185)RefyllAgent
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.RefyllAgent | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a9413215f28f476d52ee4ab12ba1431fb)HuntsmanAgent
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.HuntsmanAgent | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a3df2956490086a2065f7c4a7fdeb413e)WolfskinCommander
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.WolfskinCommander | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a7075be0425ea635acb8b85f3fd0f38a0)WolfskinScout
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.WolfskinScout | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a85ae6bd9bcd3db7d2bda7fd60b1cb8d5)Wolfskins
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.Wolfskins | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#abe7e4aedc9e31c753bc0b7c8f7a7b968)Title
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.Title | | get |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#ae5d9e3caf2db6597b2090e2113b7b4b6)QuestStartLog
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.QuestStartLog | | getprotected |

[◆](class_sand_box_1_1_claimant_quests_1_1_battania_claimant_quest_behavior_1_1_battania_claimant_quest.html#a7967dda2ff8784ede16d4268e047b524)QuestSuccessLog
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.ClaimantQuests.BattaniaClaimantQuestBehavior.BattaniaClaimantQuest.QuestSuccessLog | | getprotected |


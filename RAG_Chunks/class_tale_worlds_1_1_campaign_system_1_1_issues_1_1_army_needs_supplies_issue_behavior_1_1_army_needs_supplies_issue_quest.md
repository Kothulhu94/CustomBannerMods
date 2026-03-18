--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html ---

TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.ArmyNeedsSuppliesIssueQuest Class ReferenceInherits [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ArmyNeedsSuppliesIssueQuest](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a489cb79e4ba0a8a46a3c40f2d98ccc4c) (string questId, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) questGiver, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) duration, int rewardGold, int grainAmount, int liveStockAmount, int wineAmount) |
| override void | [OnFailed](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a0e4834ea4a7c10988bac9ea9769bd0e1) () |
| override void | [OnCanceled](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a002a207ae74c16abaae87b63f4609a58) () |
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
| Protected Member Functions | |
| override void | [InitializeQuestOnGameLoad](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a042a0e31c3a95b43d68f4f0d72dcbffa) () |
| override void | [HourlyTick](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a51665ebca79e9a3026cc198fadf9b7f3) () |
| override void | [SetDialogs](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#ae0d6647ea4f3da82c1174d4415c39481) () |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#afee6c83237bf36f04ed24a51aacf3beb) () |
| override void | [OnCompleteWithSuccess](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a806c549e67daded29e7bde842da767c7) () |
| override void | [OnTimedOut](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a78dbd6cd7c99901092fa2e231de0c9ae) () |
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
| virtual void | [OnStartQuest](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ae5071a93de47a6bf79a61af6c5908d1e) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a77be1650e0ffdd53f6770fc8d46b9c1c) () |
| virtual void | [OnBeforeTimedOut](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a3131e11acfc792bfab37350e638445c5) (ref bool completeWithSuccess, ref bool doNotResolveTheQuest) |
| virtual void | [OnBetrayal](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a9ff49c6216fdf02524620c9512580c42) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

|  |  |
| --- | --- |
| Properties | |
| override bool | [IsRemainingTimeHidden](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#ad42f46f179ef46a7d1abca267e3a616e) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Title](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a5b958ce0b022f20977a9793d56af5e9a) `[get]` |
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
| Public Types inherited from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | |
| enum | [QuestCompleteDetails](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398) {     [Invalid](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398a4bbb8f967da6d1a610596d7257179c2b) ,     [Success](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398a505a83f220c02df2f85c3810cd9ceb38) ,     [Cancel](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398aea4788705e6873b424c65e91c2846b19) ,     [Fail](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398aceaa0734f0b3c738120c67344d8f3ec1) ,     [Timeout](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398ac85a251cc457840f1e032f1b733e9398) ,     [FailWithBetrayal](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398accab16e25a64129901af8c4b0b5782be)   } |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | |
| readonly int | [RewardGold](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a9057552b49bef1e0a4e3660093b96763) |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | |
| [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | [OfferDialogFlow](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a2034f3d2ef63e5d300a2745197e81ca9) |
| [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | [DiscussDialogFlow](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a1e45cfb2d062f245b442c39c12173186) |
| [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | [QuestCharacterDialogFlow](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ac4cc1c7750d86831ae1b7b0d0ad4fb45) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a489cb79e4ba0a8a46a3c40f2d98ccc4c)ArmyNeedsSuppliesIssueQuest()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.ArmyNeedsSuppliesIssueQuest.ArmyNeedsSuppliesIssueQuest | ( | string | *questId*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *questGiver*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *duration*, |
|  |  | int | *rewardGold*, |
|  |  | int | *grainAmount*, |
|  |  | int | *liveStockAmount*, |
|  |  | int | *wineAmount* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a042a0e31c3a95b43d68f4f0d72dcbffa)InitializeQuestOnGameLoad()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.ArmyNeedsSuppliesIssueQuest.InitializeQuestOnGameLoad | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a51665ebca79e9a3026cc198fadf9b7f3)HourlyTick()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.ArmyNeedsSuppliesIssueQuest.HourlyTick | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a7327ef8984429284da693b0872eeda9e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#ae0d6647ea4f3da82c1174d4415c39481)SetDialogs()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.ArmyNeedsSuppliesIssueQuest.SetDialogs | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#afee6c83237bf36f04ed24a51aacf3beb)RegisterEvents()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.ArmyNeedsSuppliesIssueQuest.RegisterEvents | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#ae0239d94d9de615d84eb283a42db0097).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a0e4834ea4a7c10988bac9ea9769bd0e1)OnFailed()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.ArmyNeedsSuppliesIssueQuest.OnFailed | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a0bcfeef804a4cc43745ef1ccd80db30e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a806c549e67daded29e7bde842da767c7)OnCompleteWithSuccess()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.ArmyNeedsSuppliesIssueQuest.OnCompleteWithSuccess | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a2eb7aff314d8ec66bcef55863afa092d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a78dbd6cd7c99901092fa2e231de0c9ae)OnTimedOut()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.ArmyNeedsSuppliesIssueQuest.OnTimedOut | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a19e57448be6e41adbda41a930f0f8ed9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a002a207ae74c16abaae87b63f4609a58)OnCanceled()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.ArmyNeedsSuppliesIssueQuest.OnCanceled | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a11a0ade252e33be3952c17df1f735126).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#ad42f46f179ef46a7d1abca267e3a616e)IsRemainingTimeHidden
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.ArmyNeedsSuppliesIssueQuest.IsRemainingTimeHidden | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html#a5b958ce0b022f20977a9793d56af5e9a)Title
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.ArmyNeedsSuppliesIssueQuest.Title | | get |


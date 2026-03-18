--- SOURCE: class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html ---

SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue Class ReferenceInherits [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [RuralNotableInnAndOutIssue](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ae547d176a1d0743f0ddba9f2f86f98c0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) issueOwner) |
|  | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int) GetAlternativeSolutionSkill([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool | [AlternativeSolutionCondition](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a9b0a677b622390b4e7f7d4982fa02ebf) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool | [DoTroopsSatisfyAlternativeSolution](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a78fdcd934692ba03ecde335f4aa536dd) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troopRoster, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) | [GetFrequency](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a682376cf506ef0d9f48bd24c0ee81fb9) () |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool | [IssueStayAliveConditions](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ac1ae346d56e28036dc08bb309bf893ce) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | |
| int | [GetTotalAlternativeSolutionNeededMenCount](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a67ea625fa632ba09a5a67f6f5666d554) () |
| int | [GetTotalAlternativeSolutionDurationInDays](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a8cbfc5f92097db44f556327b650e74cc) () |
| int | [GetBaseAlternativeSolutionDurationInDays](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a625081bf9d9b585b51bbdf616980e2ef) () |
| virtual void | [AlternativeSolutionStartConsequence](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#aa6356a2b88edaedbd1304e5d05bf152f) () |
| virtual bool | [IsTroopTypeNeededByAlternativeSolution](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#ae1a78441f9ee3467ba3a19b0a7769208) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| virtual bool | [LordSolutionCondition](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a85af69c139a45a64d741cbf7a120d32b) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
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
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) float | [GetIssueEffectAmountInternal](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a9460f0a16c999adddf8afd9f1e7c4c4f) ([IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) issueEffect) |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) void | [AlternativeSolutionEndWithSuccessConsequence](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a2e4d77215c24224d2ec03be0f6bce0ae) () |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) void | [AlternativeSolutionEndWithFailureConsequence](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aa962553351a1d42e854f710b8657f8f0) () |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) void | [CompleteIssueWithTimedOutConsequences](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a06ad917e664719670c06ead2a6756945) () |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) void | [OnGameLoad](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a56843d0190956b9a8d8de099ec253cfe) () |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) void | [HourlyTick](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ad1605cf1bd770f8100e280ddbe4d8a75) () |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | [GenerateIssueQuest](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a3c13e4bba6a15e45de6e990d1124d86f) (string questId) |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool | [CanPlayerTakeQuestConditions](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ac8b977f3f5610aa78b47ecc7ae2c15a2) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) issueGiver, out [PreconditionFlags](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741) flag, out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) relationHero, out [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | |
| virtual void | [LordSolutionConsequence](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a3c30967350fb1b6ce469f99eecf93ecf) () |
| virtual void | [LordSolutionConsequenceWithRefuseCounterOffer](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a2a834e76e3c1a843c32a5f5bfd4ffee5) () |
| virtual void | [LordSolutionConsequenceWithAcceptCounterOffer](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5ed323aa7fbfb0a032618217ac6fb7e9) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

|  |  |
| --- | --- |
| Properties | |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [AlternativeSolutionScaleFlag](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#acd4757d79d281ea4c7190e448860a7a2) | [AlternativeSolutionScaleFlags](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ae1decc05ab331955e420a9d4b4d3fa29) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool | [IssueQuestCanBeDuplicated](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a2c7ced8a69be6ac2bb891f8e32d6b14a) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) int | [AlternativeSolutionBaseNeededMenCount](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a254b9ba50dcfa84ad85c8eab1cdd9a3a) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) int | [AlternativeSolutionBaseDurationInDaysInternal](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a349e406f290614bb87f1a9c9f6bc3f29) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) int | [RewardGold](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a7c6bf44444b972519e8ed7db095f7cda) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Title](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aff2dca31baeb87ffa3f5653fe7ba2e1f) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Description](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ad1917698eeda2ab17aaf933c60627569) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueBriefByIssueGiver](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a534d6781dcf0e390bbc878eb679fa603) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAcceptByPlayer](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a6ad962963b01783641f42470aebc1c6c) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueQuestSolutionExplanationByIssueGiver](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a50ccfb05b48e2f35e02393bd2d2f2a40) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAlternativeSolutionExplanationByIssueGiver](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a6a3c47a695946b5e81ab52fd13882ca7) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueQuestSolutionAcceptByPlayer](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a0cdf0d73faffa84d153770679956cfc2) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAlternativeSolutionAcceptByPlayer](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aafa3a22dced606bb4bde4a6bd3b1bd27) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueDiscussAlternativeSolution](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ae6218d48fb7f92dfebd293d4ea070c9e) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAlternativeSolutionResponseByIssueGiver](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a0a7412d49286fac78390c350e38589ae) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool | [IsThereAlternativeSolution](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a5214c6c77d9f95d5e872fe1025db6354) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool | [IsThereLordSolution](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a56a43f37b7d493e3e9d9848f30f7b6cb) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AlternativeSolutionStartLog](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a8d24b5d065b90ad7b2e616b0f7d93f75) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) int | [CompanionSkillRewardXP](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ab5752ae86d123ad43b60221a4d8e156d) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | |
| virtual bool | [IssueQuestCanBeDuplicated](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#ae5d88769787cb384b79d23aba51bd477) `[get]` |
| virtual int | [RelationshipChangeWithIssueOwner](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a8229805ee129ec847fdab6678949f5ee) = 0 `[get, protected set]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueBriefByIssueGiver](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a083c564c6ba7df2779923727567b4879) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAcceptByPlayer](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4eba607939b5b9c98a91ef5e64b65814) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssuePlayerResponseAfterLordExplanation](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#adc9f92da5fd2a5014e20c40700b084d1) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssuePlayerResponseAfterAlternativeExplanation](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a11b88e2298a752e2dc744cf83887eb58) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueQuestSolutionExplanationByIssueGiver](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#abff54dc346a3bba6fa5b73a11ac039d9) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAlternativeSolutionExplanationByIssueGiver](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a6521a2e9489666ac463ade7f743258be) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueLordSolutionExplanationByIssueGiver](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a54446e0360191e01f06aba7135f78ce9) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueQuestSolutionAcceptByPlayer](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#ac122d5ae8dc2bc3c386c278971514711) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAlternativeSolutionAcceptByPlayer](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#adf3a07353c2a811c217c129829f69f38) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAlternativeSolutionResponseByIssueGiver](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5c843be2fd44266f96020bf2eb9d04cd) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueLordSolutionAcceptByPlayer](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#af86e6f07b62b66fc0b9b2208c4caaf36) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueLordSolutionResponseByIssueGiver](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a943c2b554824b3189db50ed9409b4bb8) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueLordSolutionCounterOfferBriefByOtherNpc](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a3b4ad7136b6098215377e4908ae8ca93) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueLordSolutionCounterOfferExplanationByOtherNpc](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a811e775aa4747970efea9d9a021ab349) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueLordSolutionCounterOfferAcceptByPlayer](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a92cfaa0d66b57f8a1a57c9cc732d1b47) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueLordSolutionCounterOfferDeclineByPlayer](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a98d915f5bc532d9d5ed4950dec55eb7c) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueLordSolutionCounterOfferAcceptResponseByOtherNpc](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#aba1f7e9fa44e3734df7f6ee958f0b553) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueLordSolutionCounterOfferDeclineResponseByOtherNpc](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a758e8a213a4642965ae90f296b601349) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAsRumorInSettlement](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#af7737b2d5b1d2d6ba6a77f4eaae635b8) `[get]` |
| virtual int | [AlternativeSolutionBaseNeededMenCount](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a95e2a86a7a4ce32a3ddf26bd6d8040e5) `[get]` |
| virtual int | [AlternativeSolutionBaseDurationInDaysInternal](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a91ff3e7ee0d228e77b53144e1c7ec596) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [AlternativeSolutionReturnTimeForTroops](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a89fa0ca56e9a464d34ab4fce3066afa6) `[get]` |
| bool | [IsThereAlternativeSolution](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a6a7cf301683ab2e1b2bca51d4a0ba7be) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AlternativeSolutionStartLog](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#adfd90ffd4b00eced87ec6919915ced16) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AlternativeSolutionEndLogDefault](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a2fa8863b4a75e285792dca1317ba5303) `[get]` |
| bool | [IsThereDiscussDialogFlow](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a9370d66113921e05c43950e98542003e) `[get]` |
| virtual int | [CompanionSkillRewardXP](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a7686ce06008c94a2e37a0a3073584405) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [AlternativeSolutionIssueEffectClearTime](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a048ce3f7d4bd5000e42c0d1c353ce99e) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [AlternativeSolutionHero](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#abf935acb376e498c0b6604457fd7680c) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueDiscussAlternativeSolution](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a302c072e6790120b7002060b44328d64) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAlternativeSolutionSuccessLog](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a643bec3500e8f478abee563dacd2d960) = null `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAlternativeSolutionFailLog](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#ac08cc74b9b826ab201836dbbd6aba406) = null `[get]` |
| bool | [IsThereLordSolution](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a1112f3a9b0e60b49bfbe4de3d730fcb2) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [LordSolutionStartLog](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a0999c4118661d7fdcb33d4cc0456d94f) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [LordSolutionCounterOfferAcceptLog](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#aa751cf148cd957987c1091a6ab7665f5) `[get]` |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [LordSolutionCounterOfferRefuseLog](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a808cde55b7686f0c933697afa33e4072) `[get]` |
| virtual int | [NeededInfluenceForLordSolution](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#aa152f3096be3e94966a894dfb7a8ad9a) `[get]` |
| virtual [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [CounterOfferHero](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#ae9ed8d0797234761e9f19ce74fe0daf5) `[get, protected set]` |
| MBReadOnlyList< [JournalLog](class_tale_worlds_1_1_campaign_system_1_1_journal_log.html) > | [JournalEntries](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#ad112f49d5028eede13aa9d38297011da) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | |
| enum | [AlternativeSolutionScaleFlag](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#acd4757d79d281ea4c7190e448860a7a2) : UInt32 {     [None](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#acd4757d79d281ea4c7190e448860a7a2a6adf97f83acf6453d4a6a4b1070f3754) = 0x0000 ,     [Duration](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#acd4757d79d281ea4c7190e448860a7a2ae02d2ae03de9d493df2b6b2d2813d302) = 0x0001 ,     [RequiredTroops](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#acd4757d79d281ea4c7190e448860a7a2a8a9caa8ef58ce577cf7af27331a69882) = 0x0002 ,     [Casualties](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#acd4757d79d281ea4c7190e448860a7a2ac30ccafe6b394e042faa05b477b13d78) = 0x0004 ,     [FailureRisk](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#acd4757d79d281ea4c7190e448860a7a2a75f0c2f1890b40f978e0a281ccf249ea) = 0x0008   } |
| enum | [IssueUpdateDetails](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41b) {     [None](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41ba6adf97f83acf6453d4a6a4b1070f3754) ,     [PlayerStartedIssueQuestClassicSolution](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41ba30fcd673c9627c66bad6b1de08cb85df) ,     [PlayerSentTroopsToQuest](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41baef645ed89338be1c6738475b9ecbd7bf) ,     [SentTroopsFinishedQuest](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41bab1ca04c20e27f913ce92f4dc30298626) ,     [SentTroopsFailedQuest](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41baa362e9798a1b8731efb4248008b0d474) ,     [IssueFinishedWithSuccess](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41babf8b60817c07088ed5b320d7adedb879) ,     [IssueFinishedWithBetrayal](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41ba36ff66f2e353342c6c6ac3abf5f4a94d) ,     [IssueFinishedByAILord](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41bacd45fac808d84bd62fc7f632a00b5c11) ,     [IssueFail](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41ba3f0fb321745dab22d33e33b474da3117) ,     [IssueCancel](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41babbf59119d536598f0c5382d903463858) ,     [IssueTimedOut](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41ba207684bed76dae5edb3b5f0fab74964f)   } |
| enum | [IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) {     [VeryCommon](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449aac1e90f0fea786974a6fe5de1fa56276c) ,     [Common](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449aad13bc5b68b2bd9e18f29777db17cc563) ,     [Rare](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449aaa2cc588f2ab07ad61b05400f593eeb0a)   } |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | |
| readonly [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [AlternativeSolutionSentTroops](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a1f4a7ff8c05a724942ba625822359d66) |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [IssueDueTime](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a8fdee7938e79dca2704529065c4ab5b0) |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [IssueCreationTime](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a0c7a3592ef53d6cc2e06fe1c1b913fe3) |
| Static Public Attributes inherited from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | |
| const int | [IssueRelatedConversationPriority](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a958d4a19c783b3e5e14b9cad971d1896) = 125 |
| Protected Types inherited from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | |
| enum | [PreconditionFlags](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741) : UInt32 {     [None](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741a6adf97f83acf6453d4a6a4b1070f3754) = 0x0000 ,     [Relation](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741a671dec8fc4e3dc847c1b0d7b67b4e6e1) = 0x0001 ,     [Skill](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741a88bb766f0cc321759ed2eeb0bc06be5d) = 0x0002 ,     [Money](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741aa93312829ec4c71aac461cec296faa0e) = 0x0004 ,     [Renown](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741aa7aaa03948b6d08706a41c70a8a153cb) = 0x0008 ,     [Influence](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741ad35a98028cca23c2a745a0bba43a90ff) = 0x0010 ,     [Wounded](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741a0a1c125c786f629ed204ec67ebbc3a00) = 0x0020 ,     [AtWar](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741a984983a44dad81fb358d06143ddc251f) = 0x0040 ,     [ClanTier](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741ac1e6b014543c5e05f24c3974096e574f) = 0x0080 ,     [NotEnoughTroops](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741a7d658d6b688ee94160d769d07b828886) = 0x0100 ,     [NotInSameFaction](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741a555dfa221fdb7d987aedf8224da2bb6f) = 0x0200 ,     [PartySizeLimit](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741a85e64b935cab2d9680ed4cf70b603a91) = 0x0400 ,     [ClanIsMercenary](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741a6ced79b285d607f58f183514d0d80cf8) = 0x0800 ,     [MainHeroIsKingdomLeader](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741a463d7d21ca429e5ab9d300e9d9806609) = 0x4000 ,     [PlayerIsOwnerOfSettlement](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741a1f8186749561020ead1feb10d7199038) = 0x8000 ,     [CompanionLimitReached](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741ab91b88ec4290565bf9f11314cc13dbe0) = 0x10000   } |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ae547d176a1d0743f0ddba9f2f86f98c0)RuralNotableInnAndOutIssue()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.RuralNotableInnAndOutIssue | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *issueOwner* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a9460f0a16c999adddf8afd9f1e7c4c4f)GetIssueEffectAmountInternal()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) float SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.GetIssueEffectAmountInternal | ( | [IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) | *issueEffect* | ) |  | | protected |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb)override()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.override | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | , |
|  |  | int | ) |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a9b0a677b622390b4e7f7d4982fa02ebf)AlternativeSolutionCondition()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.AlternativeSolutionCondition | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a62ee2c401704ad7f5b7bb27c13084f8a).

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a2e4d77215c24224d2ec03be0f6bce0ae)AlternativeSolutionEndWithSuccessConsequence()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) void SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.AlternativeSolutionEndWithSuccessConsequence | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#aca41154e2c46b0a93649c2708ff98865).

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aa962553351a1d42e854f710b8657f8f0)AlternativeSolutionEndWithFailureConsequence()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) void SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.AlternativeSolutionEndWithFailureConsequence | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a74e69de0403a993f4a13f66bb2474d50).

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a78fdcd934692ba03ecde335f4aa536dd)DoTroopsSatisfyAlternativeSolution()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.DoTroopsSatisfyAlternativeSolution | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troopRoster*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a9f57b11c623794798a21360ab22941fd).

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a682376cf506ef0d9f48bd24c0ee81fb9)GetFrequency()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.GetFrequency | ( |  | ) |  |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ac1ae346d56e28036dc08bb309bf893ce)IssueStayAliveConditions()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.IssueStayAliveConditions | ( |  | ) |  |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a06ad917e664719670c06ead2a6756945)CompleteIssueWithTimedOutConsequences()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) void SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.CompleteIssueWithTimedOutConsequences | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a56843d0190956b9a8d8de099ec253cfe)OnGameLoad()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) void SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.OnGameLoad | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ad1605cf1bd770f8100e280ddbe4d8a75)HourlyTick()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) void SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.HourlyTick | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a3c13e4bba6a15e45de6e990d1124d86f)GenerateIssueQuest()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.GenerateIssueQuest | ( | string | *questId* | ) |  | | protected |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ac8b977f3f5610aa78b47ecc7ae2c15a2)CanPlayerTakeQuestConditions()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.CanPlayerTakeQuestConditions | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *issueGiver*, | |  |  | out [PreconditionFlags](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741) | *flag*, | |  |  | out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *relationHero*, | |  |  | out [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* ) | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ae1decc05ab331955e420a9d4b4d3fa29)AlternativeSolutionScaleFlags
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [AlternativeSolutionScaleFlag](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#acd4757d79d281ea4c7190e448860a7a2) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.AlternativeSolutionScaleFlags | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a2c7ced8a69be6ac2bb891f8e32d6b14a)IssueQuestCanBeDuplicated
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.IssueQuestCanBeDuplicated | | getprotected |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a254b9ba50dcfa84ad85c8eab1cdd9a3a)AlternativeSolutionBaseNeededMenCount
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) int SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.AlternativeSolutionBaseNeededMenCount | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a349e406f290614bb87f1a9c9f6bc3f29)AlternativeSolutionBaseDurationInDaysInternal
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) int SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.AlternativeSolutionBaseDurationInDaysInternal | | getprotected |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a7c6bf44444b972519e8ed7db095f7cda)RewardGold
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) int SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.RewardGold | | getprotected |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aff2dca31baeb87ffa3f5653fe7ba2e1f)Title
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.Title | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ad1917698eeda2ab17aaf933c60627569)Description
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.Description | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a534d6781dcf0e390bbc878eb679fa603)IssueBriefByIssueGiver
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.IssueBriefByIssueGiver | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a6ad962963b01783641f42470aebc1c6c)IssueAcceptByPlayer
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.IssueAcceptByPlayer | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a50ccfb05b48e2f35e02393bd2d2f2a40)IssueQuestSolutionExplanationByIssueGiver
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.IssueQuestSolutionExplanationByIssueGiver | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a6a3c47a695946b5e81ab52fd13882ca7)IssueAlternativeSolutionExplanationByIssueGiver
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.IssueAlternativeSolutionExplanationByIssueGiver | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a0cdf0d73faffa84d153770679956cfc2)IssueQuestSolutionAcceptByPlayer
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.IssueQuestSolutionAcceptByPlayer | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aafa3a22dced606bb4bde4a6bd3b1bd27)IssueAlternativeSolutionAcceptByPlayer
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.IssueAlternativeSolutionAcceptByPlayer | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ae6218d48fb7f92dfebd293d4ea070c9e)IssueDiscussAlternativeSolution
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.IssueDiscussAlternativeSolution | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a0a7412d49286fac78390c350e38589ae)IssueAlternativeSolutionResponseByIssueGiver
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.IssueAlternativeSolutionResponseByIssueGiver | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a5214c6c77d9f95d5e872fe1025db6354)IsThereAlternativeSolution
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.IsThereAlternativeSolution | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a56a43f37b7d493e3e9d9848f30f7b6cb)IsThereLordSolution
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) bool SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.IsThereLordSolution | | get |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#a8d24b5d065b90ad7b2e616b0f7d93f75)AlternativeSolutionStartLog
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.AlternativeSolutionStartLog | | getprotected |

[◆](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#ab5752ae86d123ad43b60221a4d8e156d)CompanionSkillRewardXP
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_rural_notable_inn_and_out_issue_behavior_1_1_rural_notable_inn_and_out_issue.html#aed40b6828579e56491acc312b8c02adb) int SandBox.Issues.RuralNotableInnAndOutIssueBehavior.RuralNotableInnAndOutIssue.CompanionSkillRewardXP | | getprotected |


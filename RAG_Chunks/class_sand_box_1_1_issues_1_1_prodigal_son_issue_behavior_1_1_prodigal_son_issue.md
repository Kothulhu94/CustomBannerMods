--- SOURCE: class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html ---

SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue Class ReferenceInherits [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ProdigalSonIssue](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a00b7aa78ecab81bb0e897057fec5ad90) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) issueOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prodigalSon, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) targetGangHero) |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void | [OnHeroCanHaveCampaignIssuesInfoIsRequested](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a710ff1085448df7543fa170e986b0720) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
|  | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int) GetAlternativeSolutionSkill([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) | [GetFrequency](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a9dc3e86cd8708e1684664654caba8bfe) () |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool | [IssueStayAliveConditions](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ae5341d56aa40083ad9ddf066adaf57d4) () |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool | [DoTroopsSatisfyAlternativeSolution](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#adce6529ed6857f0d60a18c8080d196aa) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troopRoster, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool | [IsTroopTypeNeededByAlternativeSolution](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a4bf7f980e9b9698e43b95ce64cd7077e) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool | [AlternativeSolutionCondition](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a2767a48aa12d6ee7eb0f36c84427167f) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | |
| int | [GetTotalAlternativeSolutionNeededMenCount](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a67ea625fa632ba09a5a67f6f5666d554) () |
| int | [GetTotalAlternativeSolutionDurationInDays](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a8cbfc5f92097db44f556327b650e74cc) () |
| int | [GetBaseAlternativeSolutionDurationInDays](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a625081bf9d9b585b51bbdf616980e2ef) () |
| virtual void | [AlternativeSolutionStartConsequence](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#aa6356a2b88edaedbd1304e5d05bf152f) () |
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
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) float | [GetIssueEffectAmountInternal](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#af7fc3c69806cdfefb03733d6c04d3384) ([IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) issueEffect) |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void | [OnGameLoad](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a716843a679564e0d289be6422112f2f0) () |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void | [HourlyTick](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a30a12c321bc16a5bd3ed183e41637ffc) () |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | [GenerateIssueQuest](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ae0cc2b678540e555fd1bc6abe3ae7104) (string questId) |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool | [CanPlayerTakeQuestConditions](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#aa94dfcbba1fcad1f0b63b7209d729e95) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) issueGiver, out [PreconditionFlags](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741) flag, out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) relationHero, out [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void | [CompleteIssueWithTimedOutConsequences](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#aeecbb1a20046ad875d76f817ed3a8f93) () |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void | [AlternativeSolutionEndWithSuccessConsequence](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a395970f85b7b62d23cde13c466496b99) () |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void | [AlternativeSolutionEndWithFailureConsequence](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a1edab1eb4b9c15d42fcf89b23f38ead0) () |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void | [OnIssueFinalized](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad17b8b145f1dbdc48e22896ce9090cd5) () |
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
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [AlternativeSolutionScaleFlag](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#acd4757d79d281ea4c7190e448860a7a2) | [AlternativeSolutionScaleFlags](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#af357ef1e61dd1d514d61dcee232b0e34) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) int | [RewardGold](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a531c76efe74515c0c20f42db240ecab7) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueBriefByIssueGiver](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a850e36cb2f6579a9722adabd8049ce04) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAcceptByPlayer](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#af95b9c109356c758f25cf0e8e049e7cb) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueQuestSolutionExplanationByIssueGiver](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ab62b88566c49ad0c22dfc535b2b766e2) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssuePlayerResponseAfterAlternativeExplanation](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a3981f584af24cd60df44f5fc4c0256b8) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAlternativeSolutionExplanationByIssueGiver](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a55e3bc409ee0e4e1dbf51d811be02e59) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueQuestSolutionAcceptByPlayer](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ae79e97a990ebb6a7c520d1e04b896631) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAlternativeSolutionAcceptByPlayer](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a1b977177336f98ad9e5c27c68498c811) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueDiscussAlternativeSolution](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a331d6bfde75e33ca0922f31e3c2e1caa) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueAlternativeSolutionResponseByIssueGiver](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ae7ba7377957240db1fd4e0463adec4dd) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)???????????? | [AlternativeSolutionStartLog](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a21cd196c8adcd2dd0ffb867aa50cb31d) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)?????? | [IssueAlternativeSolutionSuccessLog](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ab5d7202e97e3bbc97d2f5a050d3c2827) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool | [IsThereAlternativeSolution](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a1e96103fb1fd7fa29c22fb65bcb3cb83) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) int | [AlternativeSolutionBaseNeededMenCount](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a8135e721b2958d745087ed9bd72dc2f6) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) int | [AlternativeSolutionBaseDurationInDaysInternal](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#afb89196c79f762823a90f092b2ead74e) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) int | [CompanionSkillRewardXP](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a9bc384f2ba933449c6d14f5b4d7f75ff) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool | [IsThereLordSolution](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a8ec31fbe715358cf9cff0638258686d6) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Title](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#aac04512616d5b2b9c585e8afe62920c3) `[get]` |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Description](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ab4d81dbacef066b14460b186e3fa256e) `[get]` |
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

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a00b7aa78ecab81bb0e897057fec5ad90)ProdigalSonIssue()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.ProdigalSonIssue | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *issueOwner*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prodigalSon*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *targetGangHero* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a710ff1085448df7543fa170e986b0720)OnHeroCanHaveCampaignIssuesInfoIsRequested()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.OnHeroCanHaveCampaignIssuesInfoIsRequested | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | ref bool | *result* ) |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#af7fc3c69806cdfefb03733d6c04d3384)GetIssueEffectAmountInternal()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) float SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.GetIssueEffectAmountInternal | ( | [IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) | *issueEffect* | ) |  | | protected |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7)override()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.override | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | , |
|  |  | int | ) |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a716843a679564e0d289be6422112f2f0)OnGameLoad()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.OnGameLoad | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a30a12c321bc16a5bd3ed183e41637ffc)HourlyTick()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.HourlyTick | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ae0cc2b678540e555fd1bc6abe3ae7104)GenerateIssueQuest()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.GenerateIssueQuest | ( | string | *questId* | ) |  | | protected |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a9dc3e86cd8708e1684664654caba8bfe)GetFrequency()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.GetFrequency | ( |  | ) |  |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#aa94dfcbba1fcad1f0b63b7209d729e95)CanPlayerTakeQuestConditions()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.CanPlayerTakeQuestConditions | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *issueGiver*, | |  |  | out [PreconditionFlags](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741) | *flag*, | |  |  | out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *relationHero*, | |  |  | out [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* ) | | protected |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ae5341d56aa40083ad9ddf066adaf57d4)IssueStayAliveConditions()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IssueStayAliveConditions | ( |  | ) |  |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#aeecbb1a20046ad875d76f817ed3a8f93)CompleteIssueWithTimedOutConsequences()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.CompleteIssueWithTimedOutConsequences | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#adce6529ed6857f0d60a18c8080d196aa)DoTroopsSatisfyAlternativeSolution()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.DoTroopsSatisfyAlternativeSolution | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troopRoster*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a9f57b11c623794798a21360ab22941fd).

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a4bf7f980e9b9698e43b95ce64cd7077e)IsTroopTypeNeededByAlternativeSolution()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IsTroopTypeNeededByAlternativeSolution | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#ae1a78441f9ee3467ba3a19b0a7769208).

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a2767a48aa12d6ee7eb0f36c84427167f)AlternativeSolutionCondition()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.AlternativeSolutionCondition | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a62ee2c401704ad7f5b7bb27c13084f8a).

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a395970f85b7b62d23cde13c466496b99)AlternativeSolutionEndWithSuccessConsequence()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.AlternativeSolutionEndWithSuccessConsequence | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#aca41154e2c46b0a93649c2708ff98865).

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a1edab1eb4b9c15d42fcf89b23f38ead0)AlternativeSolutionEndWithFailureConsequence()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.AlternativeSolutionEndWithFailureConsequence | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a74e69de0403a993f4a13f66bb2474d50).

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad17b8b145f1dbdc48e22896ce9090cd5)OnIssueFinalized()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) void SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.OnIssueFinalized | ( |  | ) |  | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#af357ef1e61dd1d514d61dcee232b0e34)AlternativeSolutionScaleFlags
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [AlternativeSolutionScaleFlag](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#acd4757d79d281ea4c7190e448860a7a2) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.AlternativeSolutionScaleFlags | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a531c76efe74515c0c20f42db240ecab7)RewardGold
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) int SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.RewardGold | | getprotected |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a850e36cb2f6579a9722adabd8049ce04)IssueBriefByIssueGiver
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IssueBriefByIssueGiver | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#af95b9c109356c758f25cf0e8e049e7cb)IssueAcceptByPlayer
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IssueAcceptByPlayer | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ab62b88566c49ad0c22dfc535b2b766e2)IssueQuestSolutionExplanationByIssueGiver
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IssueQuestSolutionExplanationByIssueGiver | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a3981f584af24cd60df44f5fc4c0256b8)IssuePlayerResponseAfterAlternativeExplanation
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IssuePlayerResponseAfterAlternativeExplanation | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a55e3bc409ee0e4e1dbf51d811be02e59)IssueAlternativeSolutionExplanationByIssueGiver
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IssueAlternativeSolutionExplanationByIssueGiver | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ae79e97a990ebb6a7c520d1e04b896631)IssueQuestSolutionAcceptByPlayer
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IssueQuestSolutionAcceptByPlayer | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a1b977177336f98ad9e5c27c68498c811)IssueAlternativeSolutionAcceptByPlayer
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IssueAlternativeSolutionAcceptByPlayer | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a331d6bfde75e33ca0922f31e3c2e1caa)IssueDiscussAlternativeSolution
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IssueDiscussAlternativeSolution | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ae7ba7377957240db1fd4e0463adec4dd)IssueAlternativeSolutionResponseByIssueGiver
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IssueAlternativeSolutionResponseByIssueGiver | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a21cd196c8adcd2dd0ffb867aa50cb31d)AlternativeSolutionStartLog
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)???????????? SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.AlternativeSolutionStartLog | | getprotected |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ab5d7202e97e3bbc97d2f5a050d3c2827)IssueAlternativeSolutionSuccessLog
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)?????? SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IssueAlternativeSolutionSuccessLog | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a1e96103fb1fd7fa29c22fb65bcb3cb83)IsThereAlternativeSolution
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IsThereAlternativeSolution | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a8135e721b2958d745087ed9bd72dc2f6)AlternativeSolutionBaseNeededMenCount
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) int SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.AlternativeSolutionBaseNeededMenCount | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#afb89196c79f762823a90f092b2ead74e)AlternativeSolutionBaseDurationInDaysInternal
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) int SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.AlternativeSolutionBaseDurationInDaysInternal | | getprotected |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a9bc384f2ba933449c6d14f5b4d7f75ff)CompanionSkillRewardXP
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) int SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.CompanionSkillRewardXP | | getprotected |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#a8ec31fbe715358cf9cff0638258686d6)IsThereLordSolution
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) bool SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.IsThereLordSolution | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#aac04512616d5b2b9c585e8afe62920c3)Title
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.Title | | get |

[◆](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ab4d81dbacef066b14460b186e3fa256e)Description
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_sand_box_1_1_issues_1_1_prodigal_son_issue_behavior_1_1_prodigal_son_issue.html#ad48922c1f457e0690a7bb29cec0099c7) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Issues.ProdigalSonIssueBehavior.ProdigalSonIssue.Description | | get |


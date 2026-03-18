--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html ---

TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue Class ReferenceInherits [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool | [DoTroopsSatisfyAlternativeSolution](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ad32a44b1f42ab7ee0f3f42152b7cfbd0) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troopRoster, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool | [IsTroopTypeNeededByAlternativeSolution](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a1a532d9b7c59e117e2f8d07a83be3aa1) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool | [AlternativeSolutionCondition](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#afcd292d7fd7149fe61d233b5185319c5) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) void | [AlternativeSolutionStartConsequence](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a4c0accee6cb108794ea01780d4720a02) () |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) | [GetFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a778e8fa11761fdeaaf1a82452601dd29) () |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool | [IssueStayAliveConditions](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a7bec1e23e01dd7d32cd3a3090e651e73) () |
|  | [LordNeedsHorsesIssue](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ad07ad53266df0b8d717306234f6051a1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) issueOwner) |
|  | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int) GetAlternativeSolutionSkill([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | |
| int | [GetTotalAlternativeSolutionNeededMenCount](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a67ea625fa632ba09a5a67f6f5666d554) () |
| int | [GetTotalAlternativeSolutionDurationInDays](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a8cbfc5f92097db44f556327b650e74cc) () |
| int | [GetBaseAlternativeSolutionDurationInDays](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a625081bf9d9b585b51bbdf616980e2ef) () |
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
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) void | [AlternativeSolutionEndWithSuccessConsequence](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a3caa92c5af860a060200062f7ed7ffa1) () |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) void | [AlternativeSolutionEndWithFailureConsequence](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a71ce7e031714d4295bfb6051ab977cb6) () |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) void | [OnGameLoad](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a9a7325d58db94ad4fdf920f4ddb4d6ba) () |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) void | [HourlyTick](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a91a4ca935b17f38fb49add970b2a1a9f) () |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | [GenerateIssueQuest](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a713a7f0bbeeb26b2e922dacce6cb2b54) (string questId) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool | [CanPlayerTakeQuestConditions](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a847b33a6f05b261169ae89f64afb5bba) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) issueGiver, out [PreconditionFlags](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741) flag, out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) relationHero, out [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) void | [CompleteIssueWithTimedOutConsequences](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a7163f6c76ce8444ce23cd9a7f1b2d1f5) () |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) float | [GetIssueEffectAmountInternal](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ac19f9e9995bbf1123d9dda4de6991488) ([IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) issueEffect) |
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
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) int | [AlternativeSolutionBaseDurationInDaysInternal](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#abbea7ceb6dff3476aa95c8a1d7d03cf9) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [AlternativeSolutionScaleFlag](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#acd4757d79d281ea4c7190e448860a7a2) | [AlternativeSolutionScaleFlags](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a8949d93938c2ff5affbbd8c40de3dd1e) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) int | [RewardGold](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a49c0160ed96479e4a1d8da34f4eff655) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) int | [AlternativeSolutionBaseNeededMenCount](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ae19540a222722ab215369bebf544576b) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) int | [CompanionSkillRewardXP](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a309d32a2b1c95231ca71a47842adf340) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? | [IssueBriefByIssueGiver](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a51d0dbfac3c6e96ddfee414edee36e55) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)???? | [IssueAcceptByPlayer](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a4c1d80eb19ed9cd2c21e7e77fdc79471) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? | [IssueQuestSolutionExplanationByIssueGiver](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a767c666f98d9aab76a10cdad0df10119) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? | [IssueQuestSolutionAcceptByPlayer](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a2af340f85fa3158ff0f0e990e693ff52) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool | [IsThereAlternativeSolution](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a744aacac6ac517f9d6afc9902a71e85f) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)?????? | [IssueAlternativeSolutionExplanationByIssueGiver](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a6bb53d295f99565312a4a170ffb785f2) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? | [IssueAlternativeSolutionAcceptByPlayer](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ae3d185daf70d08ea6569e626279aae33) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [IssueDiscussAlternativeSolution](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a2467f59a047770f1dec9426a8bcbc6b2) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? | [IssueAlternativeSolutionResponseByIssueGiver](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a0c2958ed6e8666e06b0c9703badd9753) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)???????????? | [AlternativeSolutionStartLog](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a808fd4b55195a52f14c30f5bc28ab1ce) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? | [IssueAlternativeSolutionSuccessLog](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ad7a0b4d4c8648147c4af85d0786493c2) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool | [IsThereLordSolution](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#aa8cc7e9d9d86bd33edd6f4d4616eaccc) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? | [Title](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ab3835a3b08c6c3e59e3392a4ca637c1d) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)?????? | [Description](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a3e16dbc3c248de64fd652f14f72f7e36) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ad07ad53266df0b8d717306234f6051a1)LordNeedsHorsesIssue()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.LordNeedsHorsesIssue | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *issueOwner* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ad32a44b1f42ab7ee0f3f42152b7cfbd0)DoTroopsSatisfyAlternativeSolution()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.DoTroopsSatisfyAlternativeSolution | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troopRoster*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a9f57b11c623794798a21360ab22941fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a1a532d9b7c59e117e2f8d07a83be3aa1)IsTroopTypeNeededByAlternativeSolution()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IsTroopTypeNeededByAlternativeSolution | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#ae1a78441f9ee3467ba3a19b0a7769208).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#afcd292d7fd7149fe61d233b5185319c5)AlternativeSolutionCondition()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.AlternativeSolutionCondition | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a62ee2c401704ad7f5b7bb27c13084f8a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a4c0accee6cb108794ea01780d4720a02)AlternativeSolutionStartConsequence()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) void TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.AlternativeSolutionStartConsequence | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#aa6356a2b88edaedbd1304e5d05bf152f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a3caa92c5af860a060200062f7ed7ffa1)AlternativeSolutionEndWithSuccessConsequence()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) void TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.AlternativeSolutionEndWithSuccessConsequence | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#aca41154e2c46b0a93649c2708ff98865).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a71ce7e031714d4295bfb6051ab977cb6)AlternativeSolutionEndWithFailureConsequence()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) void TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.AlternativeSolutionEndWithFailureConsequence | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Issues.IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a74e69de0403a993f4a13f66bb2474d50).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a9a7325d58db94ad4fdf920f4ddb4d6ba)OnGameLoad()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) void TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.OnGameLoad | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a91a4ca935b17f38fb49add970b2a1a9f)HourlyTick()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) void TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.HourlyTick | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a713a7f0bbeeb26b2e922dacce6cb2b54)GenerateIssueQuest()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.GenerateIssueQuest | ( | string | *questId* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a778e8fa11761fdeaaf1a82452601dd29)GetFrequency()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.GetFrequency | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a847b33a6f05b261169ae89f64afb5bba)CanPlayerTakeQuestConditions()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.CanPlayerTakeQuestConditions | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *issueGiver*, | |  |  | out [PreconditionFlags](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a729d70ff6b39caa5002618d798237741) | *flag*, | |  |  | out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *relationHero*, | |  |  | out [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a7163f6c76ce8444ce23cd9a7f1b2d1f5)CompleteIssueWithTimedOutConsequences()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) void TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.CompleteIssueWithTimedOutConsequences | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a7bec1e23e01dd7d32cd3a3090e651e73)IssueStayAliveConditions()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IssueStayAliveConditions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ac19f9e9995bbf1123d9dda4de6991488)GetIssueEffectAmountInternal()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) float TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.GetIssueEffectAmountInternal | ( | [IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) | *issueEffect* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f)override()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.override | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | , |
|  |  | int | ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#abbea7ceb6dff3476aa95c8a1d7d03cf9)AlternativeSolutionBaseDurationInDaysInternal
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) int TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.AlternativeSolutionBaseDurationInDaysInternal | | getprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a8949d93938c2ff5affbbd8c40de3dd1e)AlternativeSolutionScaleFlags
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [AlternativeSolutionScaleFlag](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#acd4757d79d281ea4c7190e448860a7a2) TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.AlternativeSolutionScaleFlags | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a49c0160ed96479e4a1d8da34f4eff655)RewardGold
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) int TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.RewardGold | | getprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ae19540a222722ab215369bebf544576b)AlternativeSolutionBaseNeededMenCount
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) int TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.AlternativeSolutionBaseNeededMenCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a309d32a2b1c95231ca71a47842adf340)CompanionSkillRewardXP
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) int TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.CompanionSkillRewardXP | | getprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a51d0dbfac3c6e96ddfee414edee36e55)IssueBriefByIssueGiver
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IssueBriefByIssueGiver | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a4c1d80eb19ed9cd2c21e7e77fdc79471)IssueAcceptByPlayer
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)???? TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IssueAcceptByPlayer | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a767c666f98d9aab76a10cdad0df10119)IssueQuestSolutionExplanationByIssueGiver
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IssueQuestSolutionExplanationByIssueGiver | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a2af340f85fa3158ff0f0e990e693ff52)IssueQuestSolutionAcceptByPlayer
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IssueQuestSolutionAcceptByPlayer | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a744aacac6ac517f9d6afc9902a71e85f)IsThereAlternativeSolution
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IsThereAlternativeSolution | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a6bb53d295f99565312a4a170ffb785f2)IssueAlternativeSolutionExplanationByIssueGiver
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)?????? TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IssueAlternativeSolutionExplanationByIssueGiver | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ae3d185daf70d08ea6569e626279aae33)IssueAlternativeSolutionAcceptByPlayer
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IssueAlternativeSolutionAcceptByPlayer | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a2467f59a047770f1dec9426a8bcbc6b2)IssueDiscussAlternativeSolution
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IssueDiscussAlternativeSolution | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a0c2958ed6e8666e06b0c9703badd9753)IssueAlternativeSolutionResponseByIssueGiver
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IssueAlternativeSolutionResponseByIssueGiver | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a808fd4b55195a52f14c30f5bc28ab1ce)AlternativeSolutionStartLog
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)???????????? TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.AlternativeSolutionStartLog | | getprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ad7a0b4d4c8648147c4af85d0786493c2)IssueAlternativeSolutionSuccessLog
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IssueAlternativeSolutionSuccessLog | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#aa8cc7e9d9d86bd33edd6f4d4616eaccc)IsThereLordSolution
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) bool TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.IsThereLordSolution | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#ab3835a3b08c6c3e59e3392a4ca637c1d)Title
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.Title | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a3e16dbc3c248de64fd652f14f72f7e36)Description
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html#a579d941ddf200a7f774dd579aad5183f) [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)?????? TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.LordNeedsHorsesIssue.Description | | get |


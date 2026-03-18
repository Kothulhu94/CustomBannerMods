--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) float | [GetIssueDifficultyMultiplier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#aa8bb76bea235138865e90c42f4333410) () |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) void | [GetIssueEffectsOfSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#aa0e5d66ae4120c992f0b79b8aed2a4cf) ([IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) issueEffect, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) void | [GetIssueEffectOfHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a4d152976787a8a022990acdd8df862ea) ([IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) issueEffect, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) void | [GetIssueEffectOfClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a90d06dfff22ccbc0cd101a90b15284cb) ([IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) issueEffect, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
|  | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) ([int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a), [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a)) [GetCausalityForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a1a2e8ac9b4100f2aea36d65bfd962ff4)([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) alternativeSolutionHero |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) float | [GetFailureRiskForHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a311b87a91489d778d20188f906f58cbc) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) alternativeSolutionHero, [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetDurationOfResolutionForHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a607658bb96abc55d909daa68123d49ee) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) alternativeSolutionHero, [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) | [GetTroopsRequiredForHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a2496ad034f2fe6483c9b5d3897db522f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) alternativeSolutionHero, [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
|  | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a48ec87552cd10b7b382a82566b9a989b) ([SkillObject](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a43260cf240738215ef57031e36b1fcff), [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a)) [GetIssueAlternativeSolutionSkill](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a2f6c2afc99ea7e76c7cf1046893bc0d6)([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) bool | [CanTroopsReturnFromAlternativeSolution](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a4ab8817fb506c019f0cae06d7f2a7b5c) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html) | |
| float | [GetIssueDifficultyMultiplier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a502041197c34f482b0ae392a90a2e217) () |
| void | [GetIssueEffectsOfSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a2578c27a53fb7af4b92d19b5eea9c426) ([IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) issueEffect, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| void | [GetIssueEffectOfHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a9413af73d79069fdac9bec4cff10c926) ([IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) issueEffect, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| void | [GetIssueEffectOfClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#acfa40857272ab225443919ff87433e70) ([IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) issueEffect, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) | [GetCausalityForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a1a2e8ac9b4100f2aea36d65bfd962ff4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) alternativeSolutionHero, [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
| float | [GetFailureRiskForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a0e1dc16d64f9df88dc8214791fb47fec) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) alternativeSolutionHero, [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetDurationOfResolutionForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a82205e5ff16c51bf8d87e8e4645c1853) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) alternativeSolutionHero, [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
| [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) | [GetTroopsRequiredForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a05e1dffe34feb60c9f676ab65fdf8c45) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) alternativeSolutionHero, [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
| bool | [CanTroopsReturnFromAlternativeSolution](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a7f4d5161a0004dc31ffd78bfe1575a4e) () |
| [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) | [GetIssueAlternativeSolutionSkill](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a2f6c2afc99ea7e76c7cf1046893bc0d6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) | [IssueOwnerCoolDownInDays](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#ac6cfcc5512a2fe00cb78a9678fe2b80d) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html) | |
| [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) | [IssueOwnerCoolDownInDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a823dd6b3cecfa96230ce4bffe5fa36cf) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html) | |
|  | [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) |
|  | [SkillObject](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a43260cf240738215ef57031e36b1fcff) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#aa8bb76bea235138865e90c42f4333410)GetIssueDifficultyMultiplier()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) float TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel.GetIssueDifficultyMultiplier | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#aa0e5d66ae4120c992f0b79b8aed2a4cf)GetIssueEffectsOfSettlement()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) void TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel.GetIssueEffectsOfSettlement | ( | [IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) | *issueEffect*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a4d152976787a8a022990acdd8df862ea)GetIssueEffectOfHero()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) void TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel.GetIssueEffectOfHero | ( | [IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) | *issueEffect*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a90d06dfff22ccbc0cd101a90b15284cb)GetIssueEffectOfClan()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) void TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel.GetIssueEffectOfClan | ( | [IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) | *issueEffect*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15)override() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel.override | ( | [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) | , |
|  |  | [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) | ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a311b87a91489d778d20188f906f58cbc)GetFailureRiskForHero()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) float TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel.GetFailureRiskForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *alternativeSolutionHero*, |
|  |  | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a607658bb96abc55d909daa68123d49ee)GetDurationOfResolutionForHero()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel.GetDurationOfResolutionForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *alternativeSolutionHero*, |
|  |  | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a2496ad034f2fe6483c9b5d3897db522f)GetTroopsRequiredForHero()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel.GetTroopsRequiredForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *alternativeSolutionHero*, |
|  |  | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a48ec87552cd10b7b382a82566b9a989b)override() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel.override | ( | [SkillObject](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a43260cf240738215ef57031e36b1fcff) | , |
|  |  | [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) | ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a4ab8817fb506c019f0cae06d7f2a7b5c)CanTroopsReturnFromAlternativeSolution()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) bool TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel.CanTroopsReturnFromAlternativeSolution | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#ac6cfcc5512a2fe00cb78a9678fe2b80d)IssueOwnerCoolDownInDays
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html#a3dc1235cd6bbf43fca908a01df30da15) [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel.IssueOwnerCoolDownInDays | | get |


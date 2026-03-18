--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultIssueModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_issue_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| Public Attributes | |
|  | [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) |
|  | [SkillObject](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a43260cf240738215ef57031e36b1fcff) |

|  |  |
| --- | --- |
| Properties | |
| [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) | [IssueOwnerCoolDownInDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a823dd6b3cecfa96230ce4bffe5fa36cf) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a502041197c34f482b0ae392a90a2e217)GetIssueDifficultyMultiplier()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.GetIssueDifficultyMultiplier | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a2578c27a53fb7af4b92d19b5eea9c426)GetIssueEffectsOfSettlement()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.GetIssueEffectsOfSettlement | ( | [IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) | *issueEffect*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a9413af73d79069fdac9bec4cff10c926)GetIssueEffectOfHero()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.GetIssueEffectOfHero | ( | [IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) | *issueEffect*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#acfa40857272ab225443919ff87433e70)GetIssueEffectOfClan()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.GetIssueEffectOfClan | ( | [IssueEffect](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_effect.html) | *issueEffect*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a1a2e8ac9b4100f2aea36d65bfd962ff4)GetCausalityForHero()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.GetCausalityForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *alternativeSolutionHero*, |
|  |  | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a0e1dc16d64f9df88dc8214791fb47fec)GetFailureRiskForHero()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.GetFailureRiskForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *alternativeSolutionHero*, | |  |  | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a82205e5ff16c51bf8d87e8e4645c1853)GetDurationOfResolutionForHero()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.GetDurationOfResolutionForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *alternativeSolutionHero*, | |  |  | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a05e1dffe34feb60c9f676ab65fdf8c45)GetTroopsRequiredForHero()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.GetTroopsRequiredForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *alternativeSolutionHero*, | |  |  | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a7f4d5161a0004dc31ffd78bfe1575a4e)CanTroopsReturnFromAlternativeSolution()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.CanTroopsReturnFromAlternativeSolution | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a2f6c2afc99ea7e76c7cf1046893bc0d6)GetIssueAlternativeSolutionSkill()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.GetIssueAlternativeSolutionSkill | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a)int
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.int | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a43260cf240738215ef57031e36b1fcff)SkillObject
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.SkillObject | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#a823dd6b3cecfa96230ce4bffe5fa36cf)IssueOwnerCoolDownInDays
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [int](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_issue_model.html#aeb08547831ef33c2707b5a7511d8e38a) TaleWorlds.CampaignSystem.ComponentInterfaces.IssueModel.IssueOwnerCoolDownInDays | | getabstract |


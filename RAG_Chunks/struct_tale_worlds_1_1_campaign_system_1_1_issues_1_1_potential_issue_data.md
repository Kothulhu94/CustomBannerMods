--- SOURCE: struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html ---

TaleWorlds.CampaignSystem.Issues.PotentialIssueData Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | [StartIssueDelegate](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a73edd805dfc1d4ae21a880aa3a89832b) (in [PotentialIssueData](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a3724441256637f68e9f382653d84870b) pid, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) issueOwner) |
|  | [PotentialIssueData](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a3724441256637f68e9f382653d84870b) ([StartIssueDelegate](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a73edd805dfc1d4ae21a880aa3a89832b) onStartIssue, Type issueType, [IssueBase.IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) frequency, object relatedObject=null) |
|  | [PotentialIssueData](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a1d01b77be8098572ce8504cd9901a2a4) (Type issueType, [IssueBase.IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) frequency) |

|  |  |
| --- | --- |
| Properties | |
| [StartIssueDelegate](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a73edd805dfc1d4ae21a880aa3a89832b) | [OnStartIssue](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a06587472be179902d477e755e47dbe4e) `[get]` |
| string | [IssueId](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#ab8d4a016f658f17f18178a7101806391) `[get]` |
| Type | [IssueType](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#ac025041ef289ad9d83f2ba9a760dbe50) `[get]` |
| [IssueBase.IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) | [Frequency](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a281b98762b059990c7ba11728e1b4146) `[get]` |
| object | [RelatedObject](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a2d90ec680fe9747991355cb7498b971d) `[get]` |
| bool | [IsValid](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a83d25bf6cdfb2c2048e394305126e1d8) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a3724441256637f68e9f382653d84870b)PotentialIssueData() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Issues.PotentialIssueData.PotentialIssueData | ( | [StartIssueDelegate](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a73edd805dfc1d4ae21a880aa3a89832b) | *onStartIssue*, |
|  |  | Type | *issueType*, |
|  |  | [IssueBase.IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) | *frequency*, |
|  |  | object | *relatedObject* = null ) |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a1d01b77be8098572ce8504cd9901a2a4)PotentialIssueData() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Issues.PotentialIssueData.PotentialIssueData | ( | Type | *issueType*, |
|  |  | [IssueBase.IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) | *frequency* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a73edd805dfc1d4ae21a880aa3a89832b)StartIssueDelegate()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) TaleWorlds.CampaignSystem.Issues.PotentialIssueData.StartIssueDelegate | ( | in [PotentialIssueData](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a3724441256637f68e9f382653d84870b) | *pid*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *issueOwner* ) |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a06587472be179902d477e755e47dbe4e)OnStartIssue
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [StartIssueDelegate](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a73edd805dfc1d4ae21a880aa3a89832b) TaleWorlds.CampaignSystem.Issues.PotentialIssueData.OnStartIssue | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#ab8d4a016f658f17f18178a7101806391)IssueId
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Issues.PotentialIssueData.IssueId | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#ac025041ef289ad9d83f2ba9a760dbe50)IssueType
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Type TaleWorlds.CampaignSystem.Issues.PotentialIssueData.IssueType | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a281b98762b059990c7ba11728e1b4146)Frequency
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IssueBase.IssueFrequency](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a4a4c45cb1f6fa045ff6c276585e0449a) TaleWorlds.CampaignSystem.Issues.PotentialIssueData.Frequency | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a2d90ec680fe9747991355cb7498b971d)RelatedObject
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.CampaignSystem.Issues.PotentialIssueData.RelatedObject | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_potential_issue_data.html#a83d25bf6cdfb2c2048e394305126e1d8)IsValid
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Issues.PotentialIssueData.IsValid | | get |


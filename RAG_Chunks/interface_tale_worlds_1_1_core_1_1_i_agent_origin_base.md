--- SOURCE: interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html ---

TaleWorlds.Core.IAgentOriginBase Interface ReferenceInherited by [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html), [TaleWorlds.MountAndBlade.BasicBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_basic_battle_agent_origin.html), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetWounded](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab167100d19f31a0eb94a863aa8a154c6) () |
| void | [SetKilled](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a438891fdc394bfd6993824f8827343f1) () |
| void | [SetRouted](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a4d0a73e7aaeb8df3ffaf3239bc39e212) (bool isOrderRetreat) |
| void | [OnAgentRemoved](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a72051987ed67f5c1425e7f5bf1c47479) (float agentHealth) |
| void | [OnScoreHit](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a7f0d7a73bb70c0dc8539c38ab316aa69) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) victim, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) formationCaptain, int damage, bool isFatal, bool isTeamKill, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon) |
| void | [SetBanner](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aa411d63117f2804949cc66b9fb8b762c) ([Banner](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab5cfbab0ba6a53da4965d6a4f7425d3b) banner) |
| [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) | [GetTraitsMask](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a1b108c7b458e1df696914319e4b87478) () |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsUnderPlayersCommand](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aedb89daad1f6f8b34f0568395fa7f789) `[get]` |
| uint | [FactionColor](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a10a63fd7006739b4d6d4ae154a5c0b2c) `[get]` |
| uint | [FactionColor2](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a2e1c8f930df2af3fb33231f312d64237) `[get]` |
| [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | [BattleCombatant](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aea5c6171e34c5c5d3a1af2d5e9f60c44) `[get]` |
| int | [UniqueSeed](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a95d4c2d79eeee3dab9ba814a6943eb69) `[get]` |
| int | [Seed](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a89eb1c68b129baa62cee10f30e862c0e) `[get]` |
| Banner | [Banner](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab5cfbab0ba6a53da4965d6a4f7425d3b) `[get]` |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [Troop](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a0d06f9cb48e698deeaea198032641071) `[get]` |
| bool | [HasThrownWeapon](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a2838813b37128827d8a4c50e4ce59394) `[get]` |
| bool | [HasHeavyArmor](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#af51b00cdc5c0aae9b607c87026b2d674) `[get]` |
| bool | [HasShield](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aae6a0a5bc3012b62739f371c89a67d00) `[get]` |
| bool | [HasSpear](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a20c9adbf6521c3eab0a443c4646f4916) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab167100d19f31a0eb94a863aa8a154c6)SetWounded()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.IAgentOriginBase.SetWounded | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a0f4c09be206a83210b2844d43d9404ab), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a49910a98bf74750c1f00ece66b87cd02), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a8ae1382801d9acf220f37087587883f5), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a1dd39900667a4d959b63e811332ee2b3).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a438891fdc394bfd6993824f8827343f1)SetKilled()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.IAgentOriginBase.SetKilled | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a15788429fd30d88aa23d82c93d65e50c), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#aaea3eacf25cfb941c2e01f5428d7e5e7), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a6a7872d1c6f344df01682b6f3d2c0a28), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a91514832362b13fd231dede583ae94ef).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a4d0a73e7aaeb8df3ffaf3239bc39e212)SetRouted()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.IAgentOriginBase.SetRouted | ( | bool | *isOrderRetreat* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a6f4c1927aa8ca95ed2f5cb7a8f6d5b2e), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a86d285e12b6bffe357356da1e61be6df), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a5e35c0c894483fa925be69611d801a37), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a24c1b80d4636b35e0cc5a9da461ce35a).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a72051987ed67f5c1425e7f5bf1c47479)OnAgentRemoved()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.IAgentOriginBase.OnAgentRemoved | ( | float | *agentHealth* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#ab046c5c4224b1419a30a8d861bb643a4), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#adcce4efce21a93d17b30552dfe2a357e), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a00870dc2ca92c16405c51c0259a6321f), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#aa6a9e8030aa673843ae0073d377e8820).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a7f0d7a73bb70c0dc8539c38ab316aa69)OnScoreHit()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.IAgentOriginBase.OnScoreHit | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *victim*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *formationCaptain*, |
|  |  | int | *damage*, |
|  |  | bool | *isFatal*, |
|  |  | bool | *isTeamKill*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon* ) |

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aa411d63117f2804949cc66b9fb8b762c)SetBanner()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.IAgentOriginBase.SetBanner | ( | [Banner](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab5cfbab0ba6a53da4965d6a4f7425d3b) | *banner* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a188e75914e1d9b65a741c359fa3b1dea), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#adfbd3211a4ca69ce0d67e42f98213b32), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a3d8085def7d7b452d8f44e07115bd089), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a329e9da3b1b78503a7c6724758611770).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a1b108c7b458e1df696914319e4b87478)GetTraitsMask()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) TaleWorlds.Core.IAgentOriginBase.GetTraitsMask | ( |  | ) |  |

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aedb89daad1f6f8b34f0568395fa7f789)IsUnderPlayersCommand
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.IAgentOriginBase.IsUnderPlayersCommand | | get |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a5ec9b0063bf1fd0440b2cb9bc9adba1b), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#add158112003b1d5bcc4890745140f1b4), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a6731d5271ea77a0c91dd4a41db68bb44), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a9f7c4b230bc3dc058913699164aaa67a).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a10a63fd7006739b4d6d4ae154a5c0b2c)FactionColor
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.IAgentOriginBase.FactionColor | | get |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#ab6050691c9fc81e31c71c6c19b2d3863), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#ae30cf1132c4cfc26373df0d8ad99a842), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#ac8596fcb3c5ed38118cdf830137cee95), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a59b4d88b37fd762a79ea92080acfa2b1).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a2e1c8f930df2af3fb33231f312d64237)FactionColor2
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.IAgentOriginBase.FactionColor2 | | get |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a307eef3505a96b9c1dfb9615a88aa24f), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a11a265a0fe83651e96d2d0994f14c204), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a9d85f368aca292b6ccdb9398785a4acd), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a401200a838b1fd2c164db002f33d23b1).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aea5c6171e34c5c5d3a1af2d5e9f60c44)BattleCombatant
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) TaleWorlds.Core.IAgentOriginBase.BattleCombatant | | get |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#afe4e456358414068d2cf1a5cc56af2e7), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#ae68f15f5f6305f0b81be587cd1c58eee), and [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a16f4d831cfc91c6a0f9bb94b9e0c8904).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a95d4c2d79eeee3dab9ba814a6943eb69)UniqueSeed
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.IAgentOriginBase.UniqueSeed | | get |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a3f1c523a2c48883d83c384fcd7127a3c), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a3f654222080c8f7a9fc7d5b73ba500e6), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#aa907cb166595e71fe66a6e440fc990ee), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a48e9db1e295e60ed963a3cd286cefd26).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a89eb1c68b129baa62cee10f30e862c0e)Seed
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.IAgentOriginBase.Seed | | get |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#af234d224e0b89d5ea566d94b13b5bc35), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a2cbdb80a7b62a915da709ecdc47e12fa), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#af033f2fd9ace18d2cb56b4acc7774ef2), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#ab8402e937a40d93aed770800cec15494).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab5cfbab0ba6a53da4965d6a4f7425d3b)Banner
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.Core.IAgentOriginBase.Banner | | get |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a02b1a8a0eaa3e30951ee422560ade16f), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a450c66115511e1ea56a189c6128abe3e), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#ae1b33db78dabf48df7623690464531d3), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a86aad1bbcb2a22790ff8c506f1fe5806).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a0d06f9cb48e698deeaea198032641071)Troop
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.Core.IAgentOriginBase.Troop | | get |

Implemented in [TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a149a846ea7eae96950fa2cc11dba3c1e), [TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a9ccbe19a2b5cd694b05dab2dfce8c6b5), [TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a8339ec6eb6135482a29d98ee52c72902), and [TaleWorlds.MountAndBlade.CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a6cd471e06cfb3c2189ec36819afb56ba).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a2838813b37128827d8a4c50e4ce59394)HasThrownWeapon
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.IAgentOriginBase.HasThrownWeapon | | get |

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#af51b00cdc5c0aae9b607c87026b2d674)HasHeavyArmor
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.IAgentOriginBase.HasHeavyArmor | | get |

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aae6a0a5bc3012b62739f371c89a67d00)HasShield
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.IAgentOriginBase.HasShield | | get |

[◆](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a20c9adbf6521c3eab0a443c4646f4916)HasSpear
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.IAgentOriginBase.HasSpear | | get |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html ---

TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin Class ReferenceInherits [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetWounded](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a49910a98bf74750c1f00ece66b87cd02) () |
| void | [SetKilled](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#aaea3eacf25cfb941c2e01f5428d7e5e7) () |
| void | [SetRouted](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a86d285e12b6bffe357356da1e61be6df) (bool isOrderRetreat) |
| void | [OnAgentRemoved](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#adcce4efce21a93d17b30552dfe2a357e) (float agentHealth) |
| void | [SetBanner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#adfbd3211a4ca69ce0d67e42f98213b32) ([Banner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a450c66115511e1ea56a189c6128abe3e) banner) |

|  |  |
| --- | --- |
| Properties | |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [Party](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a32768f8c0d6146e7a395c25675dd9344) `[get]` |
| [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | [BattleCombatant](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#ae68f15f5f6305f0b81be587cd1c58eee) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a450c66115511e1ea56a189c6128abe3e) `[get]` |
| int | [UniqueSeed](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a3f654222080c8f7a9fc7d5b73ba500e6) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Troop](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a9ccbe19a2b5cd694b05dab2dfce8c6b5) `[get]` |
| [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | [TroopDesc](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a1287b9df86464524bffa336dff2aabc5) `[get]` |
| int | [Rank](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a79273d6741d328d13257e4e38deb5a9d) `[get]` |
| bool | [IsUnderPlayersCommand](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#add158112003b1d5bcc4890745140f1b4) `[get]` |
| uint | [FactionColor](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#ae30cf1132c4cfc26373df0d8ad99a842) `[get]` |
| uint | [FactionColor2](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a11a265a0fe83651e96d2d0994f14c204) `[get]` |
| int | [Seed](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a2cbdb80a7b62a915da709ecdc47e12fa) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a49910a98bf74750c1f00ece66b87cd02)SetWounded()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.SetWounded | ( |  | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab167100d19f31a0eb94a863aa8a154c6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#aaea3eacf25cfb941c2e01f5428d7e5e7)SetKilled()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.SetKilled | ( |  | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a438891fdc394bfd6993824f8827343f1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a86d285e12b6bffe357356da1e61be6df)SetRouted()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.SetRouted | ( | bool | *isOrderRetreat* | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a4d0a73e7aaeb8df3ffaf3239bc39e212).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#adcce4efce21a93d17b30552dfe2a357e)OnAgentRemoved()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.OnAgentRemoved | ( | float | *agentHealth* | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a72051987ed67f5c1425e7f5bf1c47479).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#adfbd3211a4ca69ce0d67e42f98213b32)SetBanner()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.SetBanner | ( | [Banner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a450c66115511e1ea56a189c6128abe3e) | *banner* | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aa411d63117f2804949cc66b9fb8b762c).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a32768f8c0d6146e7a395c25675dd9344)Party
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.Party | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#ae68f15f5f6305f0b81be587cd1c58eee)BattleCombatant
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.BattleCombatant | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aea5c6171e34c5c5d3a1af2d5e9f60c44).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a450c66115511e1ea56a189c6128abe3e)Banner
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.Banner | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab5cfbab0ba6a53da4965d6a4f7425d3b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a3f654222080c8f7a9fc7d5b73ba500e6)UniqueSeed
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.UniqueSeed | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a95d4c2d79eeee3dab9ba814a6943eb69).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a9ccbe19a2b5cd694b05dab2dfce8c6b5)Troop
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.Troop | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a0d06f9cb48e698deeaea198032641071).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a1287b9df86464524bffa336dff2aabc5)TroopDesc
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.TroopDesc | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a79273d6741d328d13257e4e38deb5a9d)Rank
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.Rank | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#add158112003b1d5bcc4890745140f1b4)IsUnderPlayersCommand
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.IsUnderPlayersCommand | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aedb89daad1f6f8b34f0568395fa7f789).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#ae30cf1132c4cfc26373df0d8ad99a842)FactionColor
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.FactionColor | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a10a63fd7006739b4d6d4ae154a5c0b2c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a11a265a0fe83651e96d2d0994f14c204)FactionColor2
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.FactionColor2 | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a2e1c8f930df2af3fb33231f312d64237).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_group_agent_origin.html#a2cbdb80a7b62a915da709ecdc47e12fa)Seed
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.AgentOrigins.PartyGroupAgentOrigin.Seed | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a89eb1c68b129baa62cee10f30e862c0e).


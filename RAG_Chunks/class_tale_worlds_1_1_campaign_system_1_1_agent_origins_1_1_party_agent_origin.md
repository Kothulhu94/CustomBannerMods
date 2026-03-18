--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html ---

TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin Class ReferenceInherits [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PartyAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#ae7fc90c6402173dc434b83e9dfd28d16) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) characterObject, int rank=-1, [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) uniqueNo=default([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html)), bool alwaysWounded=false, bool isInvincible=false) |
| void | [SetWounded](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a0f4c09be206a83210b2844d43d9404ab) () |
| void | [SetKilled](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a15788429fd30d88aa23d82c93d65e50c) () |
| void | [SetRouted](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a6f4c1927aa8ca95ed2f5cb7a8f6d5b2e) (bool isOrderRetreat) |
| void | [OnAgentRemoved](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#ab046c5c4224b1419a30a8d861bb643a4) (float agentHealth) |
| void | [SetBanner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a188e75914e1d9b65a741c359fa3b1dea) ([Banner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a02b1a8a0eaa3e30951ee422560ade16f) banner) |

|  |  |
| --- | --- |
| Properties | |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [Party](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#aba96ad393ab56ada87e1b8e4a64d10bd) `[get, set]` |
| [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | [BattleCombatant](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#afe4e456358414068d2cf1a5cc56af2e7) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a02b1a8a0eaa3e30951ee422560ade16f) `[get]` |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [Troop](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a149a846ea7eae96950fa2cc11dba3c1e) `[get]` |
| int | [Rank](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a31d897fcf2d64a9b6a0e4a769d142bd2) `[get]` |
| bool | [IsUnderPlayersCommand](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a5ec9b0063bf1fd0440b2cb9bc9adba1b) `[get]` |
| uint | [FactionColor](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#ab6050691c9fc81e31c71c6c19b2d3863) `[get]` |
| uint | [FactionColor2](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a307eef3505a96b9c1dfb9615a88aa24f) `[get]` |
| int | [Seed](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#af234d224e0b89d5ea566d94b13b5bc35) `[get]` |
| int | [UniqueSeed](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a3f1c523a2c48883d83c384fcd7127a3c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#ae7fc90c6402173dc434b83e9dfd28d16)PartyAgentOrigin()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.PartyAgentOrigin | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *partyBase*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *characterObject*, |
|  |  | int | *rank* = -1, |
|  |  | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *uniqueNo* = default([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html)), |
|  |  | bool | *alwaysWounded* = false, |
|  |  | bool | *isInvincible* = false ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a0f4c09be206a83210b2844d43d9404ab)SetWounded()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.SetWounded | ( |  | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab167100d19f31a0eb94a863aa8a154c6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a15788429fd30d88aa23d82c93d65e50c)SetKilled()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.SetKilled | ( |  | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a438891fdc394bfd6993824f8827343f1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a6f4c1927aa8ca95ed2f5cb7a8f6d5b2e)SetRouted()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.SetRouted | ( | bool | *isOrderRetreat* | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a4d0a73e7aaeb8df3ffaf3239bc39e212).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#ab046c5c4224b1419a30a8d861bb643a4)OnAgentRemoved()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.OnAgentRemoved | ( | float | *agentHealth* | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a72051987ed67f5c1425e7f5bf1c47479).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a188e75914e1d9b65a741c359fa3b1dea)SetBanner()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.SetBanner | ( | [Banner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a02b1a8a0eaa3e30951ee422560ade16f) | *banner* | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aa411d63117f2804949cc66b9fb8b762c).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#aba96ad393ab56ada87e1b8e4a64d10bd)Party
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.Party | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#afe4e456358414068d2cf1a5cc56af2e7)BattleCombatant
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.BattleCombatant | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aea5c6171e34c5c5d3a1af2d5e9f60c44).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a02b1a8a0eaa3e30951ee422560ade16f)Banner
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.Banner | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab5cfbab0ba6a53da4965d6a4f7425d3b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a149a846ea7eae96950fa2cc11dba3c1e)Troop
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.Troop | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a0d06f9cb48e698deeaea198032641071).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a31d897fcf2d64a9b6a0e4a769d142bd2)Rank
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.Rank | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a5ec9b0063bf1fd0440b2cb9bc9adba1b)IsUnderPlayersCommand
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.IsUnderPlayersCommand | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aedb89daad1f6f8b34f0568395fa7f789).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#ab6050691c9fc81e31c71c6c19b2d3863)FactionColor
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.FactionColor | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a10a63fd7006739b4d6d4ae154a5c0b2c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a307eef3505a96b9c1dfb9615a88aa24f)FactionColor2
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.FactionColor2 | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a2e1c8f930df2af3fb33231f312d64237).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#af234d224e0b89d5ea566d94b13b5bc35)Seed
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.Seed | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a89eb1c68b129baa62cee10f30e862c0e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_party_agent_origin.html#a3f1c523a2c48883d83c384fcd7127a3c)UniqueSeed
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.AgentOrigins.PartyAgentOrigin.UniqueSeed | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a95d4c2d79eeee3dab9ba814a6943eb69).


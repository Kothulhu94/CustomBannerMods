--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html ---

TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin Class ReferenceInherits [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SimpleAgentOrigin](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a3efc0e779690821305ea0def845e3458) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) troop, int rank=-1, [Banner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#ae1b33db78dabf48df7623690464531d3) banner=null, [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) descriptor=default([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html))) |
| void | [SetWounded](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a8ae1382801d9acf220f37087587883f5) () |
| void | [SetKilled](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a6a7872d1c6f344df01682b6f3d2c0a28) () |
| void | [SetRouted](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a5e35c0c894483fa925be69611d801a37) (bool isOrderRetreat) |
| void | [OnAgentRemoved](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a00870dc2ca92c16405c51c0259a6321f) (float agentHealth) |
| void | [SetBanner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a3d8085def7d7b452d8f44e07115bd089) ([Banner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#ae1b33db78dabf48df7623690464531d3) banner) |

|  |  |
| --- | --- |
| Properties | |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [Troop](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a8339ec6eb6135482a29d98ee52c72902) `[get]` |
| bool | [IsUnderPlayersCommand](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a6731d5271ea77a0c91dd4a41db68bb44) `[get]` |
| uint | [FactionColor](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#ac8596fcb3c5ed38118cdf830137cee95) `[get]` |
| uint | [FactionColor2](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a9d85f368aca292b6ccdb9398785a4acd) `[get]` |
| int | [Seed](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#af033f2fd9ace18d2cb56b4acc7774ef2) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [Party](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a13d492e78c66817f5a848c41c845289a) `[get]` |
| [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | [BattleCombatant](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a16f4d831cfc91c6a0f9bb94b9e0c8904) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#ae1b33db78dabf48df7623690464531d3) `[get]` |
| int | [Rank](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#ab12d8628006a519f2ded0e557d8a8ebb) `[get]` |
| int | [UniqueSeed](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#aa907cb166595e71fe66a6e440fc990ee) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a3efc0e779690821305ea0def845e3458)SimpleAgentOrigin()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.SimpleAgentOrigin | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *troop*, |
|  |  | int | *rank* = -1, |
|  |  | [Banner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#ae1b33db78dabf48df7623690464531d3) | *banner* = null, |
|  |  | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *descriptor* = default([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html)) ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a8ae1382801d9acf220f37087587883f5)SetWounded()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.SetWounded | ( |  | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab167100d19f31a0eb94a863aa8a154c6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a6a7872d1c6f344df01682b6f3d2c0a28)SetKilled()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.SetKilled | ( |  | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a438891fdc394bfd6993824f8827343f1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a5e35c0c894483fa925be69611d801a37)SetRouted()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.SetRouted | ( | bool | *isOrderRetreat* | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a4d0a73e7aaeb8df3ffaf3239bc39e212).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a00870dc2ca92c16405c51c0259a6321f)OnAgentRemoved()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.OnAgentRemoved | ( | float | *agentHealth* | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a72051987ed67f5c1425e7f5bf1c47479).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a3d8085def7d7b452d8f44e07115bd089)SetBanner()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.SetBanner | ( | [Banner](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#ae1b33db78dabf48df7623690464531d3) | *banner* | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aa411d63117f2804949cc66b9fb8b762c).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a8339ec6eb6135482a29d98ee52c72902)Troop
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.Troop | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a0d06f9cb48e698deeaea198032641071).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a6731d5271ea77a0c91dd4a41db68bb44)IsUnderPlayersCommand
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.IsUnderPlayersCommand | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aedb89daad1f6f8b34f0568395fa7f789).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#ac8596fcb3c5ed38118cdf830137cee95)FactionColor
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.FactionColor | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a10a63fd7006739b4d6d4ae154a5c0b2c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a9d85f368aca292b6ccdb9398785a4acd)FactionColor2
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.FactionColor2 | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a2e1c8f930df2af3fb33231f312d64237).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#af033f2fd9ace18d2cb56b4acc7774ef2)Seed
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.Seed | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a89eb1c68b129baa62cee10f30e862c0e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a13d492e78c66817f5a848c41c845289a)Party
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.Party | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#a16f4d831cfc91c6a0f9bb94b9e0c8904)BattleCombatant
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.BattleCombatant | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aea5c6171e34c5c5d3a1af2d5e9f60c44).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#ae1b33db78dabf48df7623690464531d3)Banner
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.Banner | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab5cfbab0ba6a53da4965d6a4f7425d3b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#ab12d8628006a519f2ded0e557d8a8ebb)Rank
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.Rank | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_agent_origins_1_1_simple_agent_origin.html#aa907cb166595e71fe66a6e440fc990ee)UniqueSeed
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.AgentOrigins.SimpleAgentOrigin.UniqueSeed | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a95d4c2d79eeee3dab9ba814a6943eb69).


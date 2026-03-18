--- SOURCE: interface_tale_worlds_1_1_core_1_1_i_agent.html ---

TaleWorlds.Core.IAgent Interface ReferenceInherited by [TaleWorlds.CampaignSystem.Conversation.MapConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html), and [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [IsEnemyOf](interface_tale_worlds_1_1_core_1_1_i_agent.html#aa4dd4522cf933e18f0b22d29d15eea0e) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| bool | [IsFriendOf](interface_tale_worlds_1_1_core_1_1_i_agent.html#a74591f4fc9b8aec25754f01327a740f0) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| bool | [IsActive](interface_tale_worlds_1_1_core_1_1_i_agent.html#ab7e7d141dcc687fa0a57cc0ac50117f2) () |
| void | [SetAsConversationAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#adf3ee61583e75029964d8aae20e968e3) (bool set) |

|  |  |
| --- | --- |
| Properties | |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [Character](interface_tale_worlds_1_1_core_1_1_i_agent.html#aea11c094cb4a894cca1ee485511957e6) `[get]` |
| [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) | [State](interface_tale_worlds_1_1_core_1_1_i_agent.html#a9e6b6905ecbc75b93f005b91cb8019b3) `[get]` |
| [IMissionTeam](interface_tale_worlds_1_1_core_1_1_i_mission_team.html) | [Team](interface_tale_worlds_1_1_core_1_1_i_agent.html#ad85ae269484b67435d3ac23c44462ab5) `[get]` |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | [Origin](interface_tale_worlds_1_1_core_1_1_i_agent.html#ac4f6b65d20f8a2207d6d82cd0e3fbe9a) `[get]` |
| float | [Age](interface_tale_worlds_1_1_core_1_1_i_agent.html#ae4af4dbcc3481ab6e4c0b19b1127368c) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_agent.html#aa4dd4522cf933e18f0b22d29d15eea0e)IsEnemyOf()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.IAgent.IsEnemyOf | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Conversation.MapConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a2a86f1234657725bec6612d72908a241).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent.html#a74591f4fc9b8aec25754f01327a740f0)IsFriendOf()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.IAgent.IsFriendOf | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Conversation.MapConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#adfdc06a0b819b10886530d561c311b64).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent.html#ab7e7d141dcc687fa0a57cc0ac50117f2)IsActive()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.IAgent.IsActive | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Conversation.MapConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#aaf2c4870698c05645ba0557780334128), and [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6f06d53678f3f4c2127133c265a854a0).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent.html#adf3ee61583e75029964d8aae20e968e3)SetAsConversationAgent()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.IAgent.SetAsConversationAgent | ( | bool | *set* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Conversation.MapConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#aa623e2010cf68e29a4efa56edf63aad4), and [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71023a9b0e08bf05349b67ec1287c464).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_agent.html#aea11c094cb4a894cca1ee485511957e6)Character
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.Core.IAgent.Character | | get |

Implemented in [TaleWorlds.CampaignSystem.Conversation.MapConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a3141f68b4ac3433870ddea87bb0ef201), and [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a39180c08aabe8810af4a4566769ab38a).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent.html#a9e6b6905ecbc75b93f005b91cb8019b3)State
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) TaleWorlds.Core.IAgent.State | | get |

Implemented in [TaleWorlds.CampaignSystem.Conversation.MapConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a9c97838f4eebe2f4e459965085ddcdf0), and [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a26f71b29a39c47dc17220a32f945d0cb).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent.html#ad85ae269484b67435d3ac23c44462ab5)Team
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMissionTeam](interface_tale_worlds_1_1_core_1_1_i_mission_team.html) TaleWorlds.Core.IAgent.Team | | get |

Implemented in [TaleWorlds.CampaignSystem.Conversation.MapConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#af114e04b986bf98e9bc72785489f61f0), and [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a13bb441adc4062eddd4b9548e43b5db5).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent.html#ac4f6b65d20f8a2207d6d82cd0e3fbe9a)Origin
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) TaleWorlds.Core.IAgent.Origin | | get |

Implemented in [TaleWorlds.CampaignSystem.Conversation.MapConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a153dfff8b02dd56b07f0558021d09891), and [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0c684662d1d7a44b6f83d5af579f12c4).

[◆](interface_tale_worlds_1_1_core_1_1_i_agent.html#ae4af4dbcc3481ab6e4c0b19b1127368c)Age
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IAgent.Age | | get |

Implemented in [TaleWorlds.CampaignSystem.Conversation.MapConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a861a5bcd2046e9f6927ffbcaff6a1dcd), and [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1a6299648a0e4d11e799e6436350d7b8).


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html ---

TaleWorlds.CampaignSystem.Conversation.MapConversationAgent Class ReferenceInherits [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#ad20677c5dc750a90dda13a363659d3ed) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) characterObject) |
| bool | [IsEnemyOf](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a2a86f1234657725bec6612d72908a241) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| bool | [IsFriendOf](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#adfdc06a0b819b10886530d561c311b64) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| bool | [IsActive](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#aaf2c4870698c05645ba0557780334128) () |
| void | [SetAsConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#aa623e2010cf68e29a4efa56edf63aad4) (bool set) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [DeliveredLine](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#ad6d0c2df9200e7df17ec4baebae85631) |

|  |  |
| --- | --- |
| Properties | |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [Character](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a3141f68b4ac3433870ddea87bb0ef201) `[get]` |
| [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) | [State](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a9c97838f4eebe2f4e459965085ddcdf0) `[get]` |
| [IMissionTeam](interface_tale_worlds_1_1_core_1_1_i_mission_team.html) | [Team](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#af114e04b986bf98e9bc72785489f61f0) `[get]` |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | [Origin](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a153dfff8b02dd56b07f0558021d09891) `[get]` |
| float | [Age](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a861a5bcd2046e9f6927ffbcaff6a1dcd) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#ad20677c5dc750a90dda13a363659d3ed)MapConversationAgent()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Conversation.MapConversationAgent.MapConversationAgent | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *characterObject* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a2a86f1234657725bec6612d72908a241)IsEnemyOf()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Conversation.MapConversationAgent.IsEnemyOf | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#aa4dd4522cf933e18f0b22d29d15eea0e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#adfdc06a0b819b10886530d561c311b64)IsFriendOf()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Conversation.MapConversationAgent.IsFriendOf | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#a74591f4fc9b8aec25754f01327a740f0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#aaf2c4870698c05645ba0557780334128)IsActive()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Conversation.MapConversationAgent.IsActive | ( |  | ) |  |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#ab7e7d141dcc687fa0a57cc0ac50117f2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#aa623e2010cf68e29a4efa56edf63aad4)SetAsConversationAgent()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.MapConversationAgent.SetAsConversationAgent | ( | bool | *set* | ) |  |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#adf3ee61583e75029964d8aae20e968e3).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#ad6d0c2df9200e7df17ec4baebae85631)DeliveredLine
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Conversation.MapConversationAgent.DeliveredLine |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a3141f68b4ac3433870ddea87bb0ef201)Character
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.CampaignSystem.Conversation.MapConversationAgent.Character | | get |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#aea11c094cb4a894cca1ee485511957e6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a9c97838f4eebe2f4e459965085ddcdf0)State
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) TaleWorlds.CampaignSystem.Conversation.MapConversationAgent.State | | get |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#a9e6b6905ecbc75b93f005b91cb8019b3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#af114e04b986bf98e9bc72785489f61f0)Team
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMissionTeam](interface_tale_worlds_1_1_core_1_1_i_mission_team.html) TaleWorlds.CampaignSystem.Conversation.MapConversationAgent.Team | | get |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#ad85ae269484b67435d3ac23c44462ab5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a153dfff8b02dd56b07f0558021d09891)Origin
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) TaleWorlds.CampaignSystem.Conversation.MapConversationAgent.Origin | | get |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#ac4f6b65d20f8a2207d6d82cd0e3fbe9a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_map_conversation_agent.html#a861a5bcd2046e9f6927ffbcaff6a1dcd)Age
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Conversation.MapConversationAgent.Age | | get |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#ae4af4dbcc3481ab6e4c0b19b1127368c).


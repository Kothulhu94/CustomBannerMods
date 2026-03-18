--- SOURCE: struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html ---

TaleWorlds.CampaignSystem.AIBehaviorData Struct ReferenceInherits IEquatable.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) ([IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) party, [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) aiBehavior, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType, bool willGatherArmy, bool isFromPort, bool isTargetingPort) |
|  | [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a3483e133f3fa46cf877bac7f7159b39f) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) aiBehavior, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType, bool willGatherArmy, bool isFromPort, bool isTargetingPort) |
| override bool | [Equals](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a9e2dd442e341bd5fa2f8d82b436ca0e3) (object obj) |
| bool | [Equals](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#ad1170df0d78bb8a9acf90a2be3de3de5) ([AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) other) |
| override int | [GetHashCode](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a3d41c650681633794f41fc9bd4c5e868) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [operator==](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#ab0a3b464422d41f14d0b426b3e28b12b) ([AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) a, [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) b) |
| static bool | [operator!=](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#ab33f419953dc87da9dbb8ad37dfb887a) ([AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) a, [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) b) |

|  |  |
| --- | --- |
| Public Attributes | |
| [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) | [Party](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a499eae441fec08c2a96801120a90f00c) |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [Position](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a7254ababe23b459b0a54bc2246837fef) |
| [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) | [AiBehavior](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a1b0e530a5d0527878d9634049c701e26) |
| bool | [WillGatherArmy](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a74abfe8ab9fed07fbbcf113d06bf3da5) |
| bool | [IsFromPort](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a224311192b02b151f85b2a5b25dee7ba) |
| bool | [IsTargetingPort](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a424fd6c84ade1798e8567f6f4882f456) |
| [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | [NavigationType](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a2f49721b1247edf89ae36b3cdee3daaf) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) | [Invalid](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#af65fa5a3f70092d4103ccb20d944b267) = new [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692)(null, AiBehavior.None, NavigationType.None, false, false, false) |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692)AIBehaviorData() [1/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.AIBehaviorData.AIBehaviorData | ( | [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) | *party*, |
|  |  | [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) | *aiBehavior*, |
|  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType*, |
|  |  | bool | *willGatherArmy*, |
|  |  | bool | *isFromPort*, |
|  |  | bool | *isTargetingPort* ) |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a3483e133f3fa46cf877bac7f7159b39f)AIBehaviorData() [2/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.AIBehaviorData.AIBehaviorData | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, |
|  |  | [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) | *aiBehavior*, |
|  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType*, |
|  |  | bool | *willGatherArmy*, |
|  |  | bool | *isFromPort*, |
|  |  | bool | *isTargetingPort* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a9e2dd442e341bd5fa2f8d82b436ca0e3)Equals() [1/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.AIBehaviorData.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#ad1170df0d78bb8a9acf90a2be3de3de5)Equals() [2/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.AIBehaviorData.Equals | ( | [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) | *other* | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a3d41c650681633794f41fc9bd4c5e868)GetHashCode()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.AIBehaviorData.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#ab0a3b464422d41f14d0b426b3e28b12b)operator==()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.AIBehaviorData.operator== | ( | [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) | *a*, | |  |  | [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#ab33f419953dc87da9dbb8ad37dfb887a)operator!=()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.AIBehaviorData.operator!= | ( | [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) | *a*, | |  |  | [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) | *b* ) | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#af65fa5a3f70092d4103ccb20d944b267)Invalid
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692) TaleWorlds.CampaignSystem.AIBehaviorData.Invalid = new [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a19d84b288061f4dbc8975f93e447d692)(null, AiBehavior.None, NavigationType.None, false, false, false) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a499eae441fec08c2a96801120a90f00c)Party
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) TaleWorlds.CampaignSystem.AIBehaviorData.Party |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a7254ababe23b459b0a54bc2246837fef)Position
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.AIBehaviorData.Position |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a1b0e530a5d0527878d9634049c701e26)AiBehavior
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) TaleWorlds.CampaignSystem.AIBehaviorData.AiBehavior |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a74abfe8ab9fed07fbbcf113d06bf3da5)WillGatherArmy
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.AIBehaviorData.WillGatherArmy |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a224311192b02b151f85b2a5b25dee7ba)IsFromPort
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.AIBehaviorData.IsFromPort |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a424fd6c84ade1798e8567f6f4882f456)IsTargetingPort
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.AIBehaviorData.IsTargetingPort |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html#a2f49721b1247edf89ae36b3cdee3daaf)NavigationType
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) TaleWorlds.CampaignSystem.AIBehaviorData.NavigationType |


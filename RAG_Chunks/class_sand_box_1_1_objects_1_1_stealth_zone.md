--- SOURCE: class_sand_box_1_1_objects_1_1_stealth_zone.html ---

SandBox.Objects.StealthZone Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [StealthZoneEvent](class_sand_box_1_1_objects_1_1_stealth_zone.html#a6b57ecb763f70dc278462d82d1c2ff77) () |
|  | [StealthZone](class_sand_box_1_1_objects_1_1_stealth_zone.html#a9d4906950b67c71572a4ca6d2b2fae44) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent, bool useVolumeBox) |
| void | [SetStealthAgents](class_sand_box_1_1_objects_1_1_stealth_zone.html#a3370508bd3889a85a295a762da66da6d) (List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents) |
| void | [Tick](class_sand_box_1_1_objects_1_1_stealth_zone.html#acad74f73a4a772f812a017ae501b416e) () |
| void | [OnAgentRemoved](class_sand_box_1_1_objects_1_1_stealth_zone.html#a21a716c935e2b3e52361fa1ec24f7c65) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent) |
| bool | [IsAgentInside](class_sand_box_1_1_objects_1_1_stealth_zone.html#ab21c4c65c2f624a5a2c317e044f9b604) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [OnPlayerFlees](class_sand_box_1_1_objects_1_1_stealth_zone.html#a29cd4de6093d361a568ebe8c5d1683ee) () |
| void | [ResetEvents](class_sand_box_1_1_objects_1_1_stealth_zone.html#aff9c3edcc2d47bee8c7afb23c0899d6a) () |
| void | [DisableAll](class_sand_box_1_1_objects_1_1_stealth_zone.html#aee8ac51a32089e405e78b2d7dd3c446e) () |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [IsZoneUsable](class_sand_box_1_1_objects_1_1_stealth_zone.html#af4c892e27b04c4ecd1012359e72ac006) = false |
| [StealthZoneEvent](class_sand_box_1_1_objects_1_1_stealth_zone.html#a6b57ecb763f70dc278462d82d1c2ff77) | [OnTargetFlees](class_sand_box_1_1_objects_1_1_stealth_zone.html#a8609dcba8f26d974036464a2834db7bc) |
| [StealthZoneEvent](class_sand_box_1_1_objects_1_1_stealth_zone.html#a6b57ecb763f70dc278462d82d1c2ff77) | [OnTargetEliminated](class_sand_box_1_1_objects_1_1_stealth_zone.html#aa9ad4f5f2216c720a1a91c9500a8c1d0) |
| [StealthZoneEvent](class_sand_box_1_1_objects_1_1_stealth_zone.html#a6b57ecb763f70dc278462d82d1c2ff77) | [OnTargetInZone](class_sand_box_1_1_objects_1_1_stealth_zone.html#a62fdb9247d9766c66a9da3b65570aa2a) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [TargetAgent](class_sand_box_1_1_objects_1_1_stealth_zone.html#a913e0045674592c96e197a925763e751) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [VolumeBoxId](class_sand_box_1_1_objects_1_1_stealth_zone.html#a6f486b4ccae99ae69cf9ce1b640060b1) = "stealth\_zone\_volume" |

|  |  |
| --- | --- |
| Properties | |
| bool | [AreAgentsActive](class_sand_box_1_1_objects_1_1_stealth_zone.html#ad5cbad9f529256a3310c4d90c986b1ef) `[get]` |
| bool | [UseVolumeBox](class_sand_box_1_1_objects_1_1_stealth_zone.html#a296b8258d67fb5d55a55815873e8c9ff) `[get]` |
| int | [EliminatedAgents](class_sand_box_1_1_objects_1_1_stealth_zone.html#aa875e43b0949680688f70a855b121a44) `[get]` |
| List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [Agents](class_sand_box_1_1_objects_1_1_stealth_zone.html#ab8a148039dd65aef77d3e14dfc251412) `[get]` |
| VolumeBox | [VolumeBox](class_sand_box_1_1_objects_1_1_stealth_zone.html#a78827ab4642b6934b0b7122cbed0203c) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action | [OnActivated](class_sand_box_1_1_objects_1_1_stealth_zone.html#a93e55f251bff77dcaf2be546085d0ffe) |
| Action | [OnDisactivated](class_sand_box_1_1_objects_1_1_stealth_zone.html#a5f444596ae550757372f384f54394a6b) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a9d4906950b67c71572a4ca6d2b2fae44)StealthZone()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Objects.StealthZone.StealthZone | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent*, |
|  |  | bool | *useVolumeBox* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a6b57ecb763f70dc278462d82d1c2ff77)StealthZoneEvent()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void SandBox.Objects.StealthZone.StealthZoneEvent | ( |  | ) |  |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a3370508bd3889a85a295a762da66da6d)SetStealthAgents()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Objects.StealthZone.SetStealthAgents | ( | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *agents* | ) |  |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#acad74f73a4a772f812a017ae501b416e)Tick()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Objects.StealthZone.Tick | ( |  | ) |  |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a21a716c935e2b3e52361fa1ec24f7c65)OnAgentRemoved()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Objects.StealthZone.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent* ) |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#ab21c4c65c2f624a5a2c317e044f9b604)IsAgentInside()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.Objects.StealthZone.IsAgentInside | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a29cd4de6093d361a568ebe8c5d1683ee)OnPlayerFlees()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Objects.StealthZone.OnPlayerFlees | ( |  | ) |  |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#aff9c3edcc2d47bee8c7afb23c0899d6a)ResetEvents()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Objects.StealthZone.ResetEvents | ( |  | ) |  |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#aee8ac51a32089e405e78b2d7dd3c446e)DisableAll()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Objects.StealthZone.DisableAll | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a6f486b4ccae99ae69cf9ce1b640060b1)VolumeBoxId
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string SandBox.Objects.StealthZone.VolumeBoxId = "stealth\_zone\_volume" | | static |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#af4c892e27b04c4ecd1012359e72ac006)IsZoneUsable
---------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.Objects.StealthZone.IsZoneUsable = false |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a8609dcba8f26d974036464a2834db7bc)OnTargetFlees
----------------------------------------------------------------------------------------------------

|  |
| --- |
| [StealthZoneEvent](class_sand_box_1_1_objects_1_1_stealth_zone.html#a6b57ecb763f70dc278462d82d1c2ff77) SandBox.Objects.StealthZone.OnTargetFlees |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#aa9ad4f5f2216c720a1a91c9500a8c1d0)OnTargetEliminated
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| [StealthZoneEvent](class_sand_box_1_1_objects_1_1_stealth_zone.html#a6b57ecb763f70dc278462d82d1c2ff77) SandBox.Objects.StealthZone.OnTargetEliminated |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a62fdb9247d9766c66a9da3b65570aa2a)OnTargetInZone
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| [StealthZoneEvent](class_sand_box_1_1_objects_1_1_stealth_zone.html#a6b57ecb763f70dc278462d82d1c2ff77) SandBox.Objects.StealthZone.OnTargetInZone |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a913e0045674592c96e197a925763e751)TargetAgent
--------------------------------------------------------------------------------------------------

|  |
| --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.Objects.StealthZone.TargetAgent |

Property Documentation
----------------------

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#ad5cbad9f529256a3310c4d90c986b1ef)AreAgentsActive
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Objects.StealthZone.AreAgentsActive | | get |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a296b8258d67fb5d55a55815873e8c9ff)UseVolumeBox
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Objects.StealthZone.UseVolumeBox | | get |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#aa875e43b0949680688f70a855b121a44)EliminatedAgents
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.Objects.StealthZone.EliminatedAgents | | get |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#ab8a148039dd65aef77d3e14dfc251412)Agents
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> SandBox.Objects.StealthZone.Agents | | get |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a78827ab4642b6934b0b7122cbed0203c)VolumeBox
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | VolumeBox SandBox.Objects.StealthZone.VolumeBox | | get |

Event Documentation
-------------------

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a93e55f251bff77dcaf2be546085d0ffe)OnActivated
--------------------------------------------------------------------------------------------------

|  |
| --- |
| Action SandBox.Objects.StealthZone.OnActivated |

[◆](class_sand_box_1_1_objects_1_1_stealth_zone.html#a5f444596ae550757372f384f54394a6b)OnDisactivated
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| Action SandBox.Objects.StealthZone.OnDisactivated |


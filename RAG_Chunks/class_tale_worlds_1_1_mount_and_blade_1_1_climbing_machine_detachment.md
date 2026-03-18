--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html ---

TaleWorlds.MountAndBlade.ClimbingMachineDetachment Class ReferenceInherits [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a05b343c4081c1d10f4ed5ae3973d9c49) (in MBList< [ClimbingMachine](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_climbing_machine.html) > climbingMachines) |
| void | [Deactivate](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a9e604f2f4e5886d5c817bc3e64de49c2) () |
| void | [AddAgent](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#ae8c4862957af0ea3f27d8135e4c72769) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int slotIndex, [Agent.AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) customFlags=[Agent.AIScriptedFrameFlags.None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a6adf97f83acf6453d4a6a4b1070f3754)) |
| void | [AddAgentAtSlotIndex](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a4622d0ae22d08eb51984c400cccb9c67) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int slotIndex) |
| bool | [IsUsedByFormation](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#aca30d2e7b93392e7f166a3da9df91306) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| bool | [IsStandingPointAvailableForAgent](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a48e0ef2a21c10155cc9d41dbc56ff83d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| List< float > | [GetTemplateCostsOfAgent](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#adaf90ecb88d0f80f211f5ebca1dd1a9b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) candidate, List< float > oldValue) |
| float | [GetTemplateWeightOfAgent](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#acbc3ae42a12799ae58728de510cc3c77) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) candidate) |
| float? | [GetWeightOfAgentAtNextSlot](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#ae75d74a5885d435ba65f5b7e12c0d991) (List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > newAgents, out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) match) |
| float? | [GetWeightOfAgentAtNextSlot](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a878f302ad99589a58d9b469aee54ce8c) (List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > agentTemplateScores, out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) match) |
| float? | [GetWeightOfAgentAtOccupiedSlot](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a013a8b5292c3651bdc8e6530400963cb) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) detachedAgent, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > newAgents, out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) match) |
| void | [RemoveAgent](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#af365fcd9b24007545f2c1feca121c066) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| int | [GetNumberOfUsableSlots](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#ad423f04911a166062755f24591387f2d) () |
| [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html)? | [GetAgentFrame](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a998bc6f231358ef57bcd62f3fc29dddc) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
|  | Returns null for siege weapons and other detachments that sets scripted frame for the agent. Returns a frame otherwise. |
| float? | [GetWeightOfNextSlot](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a46822910ae1d98b18c986c8928549c8d) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
|  | Null if there is no vacancy left. Otherwise it is a positive number. |
| float | [GetWeightOfOccupiedSlot](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a9142ad7f3343f18ac33e5c043080265a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [TickClimbingMachines](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#af68c437969144d268c4f003112785c61) () |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [UserFormations](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a90e6a1241dcfce313c10affb10a1f6b0) `[get]` |
| bool | [IsLoose](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#aa5acebb836ef8501b33ee5ba9c9904c9) `[get]` |
| bool | [IsActive](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a2c2fc567b0f0d609727606c900fb1bed) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a05b343c4081c1d10f4ed5ae3973d9c49)ClimbingMachineDetachment()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ClimbingMachineDetachment.ClimbingMachineDetachment | ( | in MBList< [ClimbingMachine](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_climbing_machine.html) > | *climbingMachines* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a9e604f2f4e5886d5c817bc3e64de49c2)Deactivate()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ClimbingMachineDetachment.Deactivate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#ae8c4862957af0ea3f27d8135e4c72769)AddAgent()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ClimbingMachineDetachment.AddAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | int | *slotIndex*, |
|  |  | [Agent.AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) | *customFlags* = [Agent::AIScriptedFrameFlags::None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a6adf97f83acf6453d4a6a4b1070f3754) ) |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a115a1d2c2312337b687d8245bee20b94).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a4622d0ae22d08eb51984c400cccb9c67)AddAgentAtSlotIndex()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ClimbingMachineDetachment.AddAgentAtSlotIndex | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | int | *slotIndex* ) |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a5b8eedf6fd897637fa9941a1452bed11).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#aca30d2e7b93392e7f166a3da9df91306)IsUsedByFormation()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ClimbingMachineDetachment.IsUsedByFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a301b5d910555ebe58458ff114557fa7a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a48e0ef2a21c10155cc9d41dbc56ff83d)IsStandingPointAvailableForAgent()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ClimbingMachineDetachment.IsStandingPointAvailableForAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#aa7011006963db3f87d4857714c5f5f88).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#adaf90ecb88d0f80f211f5ebca1dd1a9b)GetTemplateCostsOfAgent()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< float > TaleWorlds.MountAndBlade.ClimbingMachineDetachment.GetTemplateCostsOfAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *candidate*, |
|  |  | List< float > | *oldValue* ) |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#aeba86a1b94544e8136177f7880ab4db2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#acbc3ae42a12799ae58728de510cc3c77)GetTemplateWeightOfAgent()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.ClimbingMachineDetachment.GetTemplateWeightOfAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *candidate* | ) |  |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#abe5ae1eb424a9665cffe329ea60a95a2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#ae75d74a5885d435ba65f5b7e12c0d991)GetWeightOfAgentAtNextSlot() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float? TaleWorlds.MountAndBlade.ClimbingMachineDetachment.GetWeightOfAgentAtNextSlot | ( | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *newAgents*, |
|  |  | out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *match* ) |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a345165a29b4a8309bf8bb48bc0c671f9).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a878f302ad99589a58d9b469aee54ce8c)GetWeightOfAgentAtNextSlot() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float? TaleWorlds.MountAndBlade.ClimbingMachineDetachment.GetWeightOfAgentAtNextSlot | ( | List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > | *agentTemplateScores*, |
|  |  | out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *match* ) |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ad1e6215c72c45713ef0a48a7007587db).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a013a8b5292c3651bdc8e6530400963cb)GetWeightOfAgentAtOccupiedSlot()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float? TaleWorlds.MountAndBlade.ClimbingMachineDetachment.GetWeightOfAgentAtOccupiedSlot | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *detachedAgent*, |
|  |  | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *newAgents*, |
|  |  | out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *match* ) |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#af2d0d31d5aab707f6b5723d9eccedda5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#af365fcd9b24007545f2c1feca121c066)RemoveAgent()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ClimbingMachineDetachment.RemoveAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a78c23ae8475f7c67b33a4beb26aae5aa).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#ad423f04911a166062755f24591387f2d)GetNumberOfUsableSlots()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.ClimbingMachineDetachment.GetNumberOfUsableSlots | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ad075e3a8acd6a1a28a74d183ea79760c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a998bc6f231358ef57bcd62f3fc29dddc)GetAgentFrame()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html)? TaleWorlds.MountAndBlade.ClimbingMachineDetachment.GetAgentFrame | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *detachedAgent* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | detachedAgent |  |

Returns

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ac0bd160b8ea796c68327ac3c76fca199).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a46822910ae1d98b18c986c8928549c8d)GetWeightOfNextSlot()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float? TaleWorlds.MountAndBlade.ClimbingMachineDetachment.GetWeightOfNextSlot | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#af367cc78e48ba8ca791032d7483fdb97).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a9142ad7f3343f18ac33e5c043080265a)GetWeightOfOccupiedSlot()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.ClimbingMachineDetachment.GetWeightOfOccupiedSlot | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ac9723e1dd8704d3fc33a2fdb8cdba8a5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#af68c437969144d268c4f003112785c61)TickClimbingMachines()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ClimbingMachineDetachment.TickClimbingMachines | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a90e6a1241dcfce313c10affb10a1f6b0)UserFormations
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.ClimbingMachineDetachment.UserFormations | | get |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a42ddcfd10b9ead1eb8da56ee1397c317).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#aa5acebb836ef8501b33ee5ba9c9904c9)IsLoose
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ClimbingMachineDetachment.IsLoose | | get |

Implements [TaleWorlds.MountAndBlade.IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ab8aa0c3047a6963ac8a641c31b3adb57).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a2c2fc567b0f0d609727606c900fb1bed)IsActive
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ClimbingMachineDetachment.IsActive | | get |


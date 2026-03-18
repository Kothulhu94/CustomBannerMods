--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html ---

TaleWorlds.MountAndBlade.IDetachment Interface ReferenceInherited by [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html), [TaleWorlds.MountAndBlade.StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html), [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html), and [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [IsAgentUsingOrInterested](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a19ad7a673b53d05b387c38e49dc49550) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| float? | [GetWeightOfNextSlot](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#af367cc78e48ba8ca791032d7483fdb97) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
|  | Null if there is no vacancy left. Otherwise it is a positive number. |
| float | [GetDetachmentWeight](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#abd9930d3e04e22d58bed75949410e843) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| float | [ComputeAndCacheDetachmentWeight](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a5e319baeb38faeadfcefddcabc7886d8) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| float | [GetDetachmentWeightFromCache](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#aae7b168a5739fd0c76e63bc3b37bcf0a) () |
| void | [GetSlotIndexWeightTuples](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a62d68742030895834742897ee4df2a72) (List< ValueTuple< int, float > > slotIndexWeightTuples) |
| bool | [IsSlotAtIndexAvailableForAgent](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a2995107276121406583cbbd3d5aa012b) (int slotIndex, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| bool | [IsAgentEligible](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a11cf3096c5d0cf57d450f94669429585) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [AddAgentAtSlotIndex](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a5b8eedf6fd897637fa9941a1452bed11) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int slotIndex) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetMovingAgentAtSlotIndex](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a8f2b1019fb258bc2fe1118586d1515e5) (int slotIndex) |
| void | [MarkSlotAtIndex](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#adbaf775a536f86367f4f51e3eafed0d5) (int slotIndex) |
| bool | [IsDetachmentRecentlyEvaluated](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a05a346562274450740539ac248415efa) () |
| void | [UnmarkDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a200c1d077c286c362c27f4b47d2c92e0) () |
| float? | [GetWeightOfAgentAtNextSlot](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a345165a29b4a8309bf8bb48bc0c671f9) (List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > candidates, out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) match) |
| float? | [GetWeightOfAgentAtNextSlot](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ad1e6215c72c45713ef0a48a7007587db) (List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > agentTemplateScores, out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) match) |
| float | [GetTemplateWeightOfAgent](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#abe5ae1eb424a9665cffe329ea60a95a2) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) candidate) |
| List< float > | [GetTemplateCostsOfAgent](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#aeba86a1b94544e8136177f7880ab4db2) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) candidate, List< float > oldValue) |
| float | [GetExactCostOfAgentAtSlot](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a0cceb84dcdf9653b87f61e733822fa06) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) candidate, int slotIndex) |
| float | [GetWeightOfOccupiedSlot](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ac9723e1dd8704d3fc33a2fdb8cdba8a5) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) detachedAgent) |
| float? | [GetWeightOfAgentAtOccupiedSlot](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#af2d0d31d5aab707f6b5723d9eccedda5) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) detachedAgent, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > candidates, out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) match) |
| bool | [IsStandingPointAvailableForAgent](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#aa7011006963db3f87d4857714c5f5f88) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [AddAgent](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a115a1d2c2312337b687d8245bee20b94) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int slotIndex=-1, [Agent.AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) customFlags=[Agent.AIScriptedFrameFlags.None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a6adf97f83acf6453d4a6a4b1070f3754)) |
| void | [RemoveAgent](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a78c23ae8475f7c67b33a4beb26aae5aa) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) detachedAgent) |
| int | [GetNumberOfUsableSlots](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ad075e3a8acd6a1a28a74d183ea79760c) () |
| void | [FormationStartUsing](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a269a5eac2c45999dc317fec8425b2102) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [FormationStopUsing](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a5cc081ce9e122d0b42332b35f3e7f624) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| bool | [IsUsedByFormation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a301b5d910555ebe58458ff114557fa7a) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html)? | [GetAgentFrame](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ac0bd160b8ea796c68327ac3c76fca199) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) detachedAgent) |
|  | Returns null for siege weapons and other detachments that sets scripted frame for the agent. Returns a frame otherwise. |
| void | [ResetEvaluation](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a2fc0a36b9a5543fe0836feb65d7dbb3e) () |
| bool | [IsEvaluated](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a04e8445ae5204b20502e4316db1bb6a8) () |
| void | [SetAsEvaluated](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#aea1c6a944c686edd7e766f853e42b6c1) () |
| void | [OnFormationLeave](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#acd9dc752c4ab6475203e1b5eec56f3c4) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [UserFormations](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a42ddcfd10b9ead1eb8da56ee1397c317) `[get]` |
| bool | [IsLoose](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ab8aa0c3047a6963ac8a641c31b3adb57) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a19ad7a673b53d05b387c38e49dc49550)IsAgentUsingOrInterested()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IDetachment.IsAgentUsingOrInterested | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#af367cc78e48ba8ca791032d7483fdb97)GetWeightOfNextSlot()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float? TaleWorlds.MountAndBlade.IDetachment.GetWeightOfNextSlot | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a46822910ae1d98b18c986c8928549c8d), and [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a51b1d85d4c56e9fa6989c2e99d7b8932).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#abd9930d3e04e22d58bed75949410e843)GetDetachmentWeight()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IDetachment.GetDetachmentWeight | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a5e319baeb38faeadfcefddcabc7886d8)ComputeAndCacheDetachmentWeight()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IDetachment.ComputeAndCacheDetachmentWeight | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#aae7b168a5739fd0c76e63bc3b37bcf0a)GetDetachmentWeightFromCache()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IDetachment.GetDetachmentWeightFromCache | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a62d68742030895834742897ee4df2a72)GetSlotIndexWeightTuples()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IDetachment.GetSlotIndexWeightTuples | ( | List< ValueTuple< int, float > > | *slotIndexWeightTuples* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a2995107276121406583cbbd3d5aa012b)IsSlotAtIndexAvailableForAgent()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IDetachment.IsSlotAtIndexAvailableForAgent | ( | int | *slotIndex*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a11cf3096c5d0cf57d450f94669429585)IsAgentEligible()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IDetachment.IsAgentEligible | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a2296eee3dd122885d604c4643387ad4f).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a5b8eedf6fd897637fa9941a1452bed11)AddAgentAtSlotIndex()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IDetachment.AddAgentAtSlotIndex | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | int | *slotIndex* ) |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a4622d0ae22d08eb51984c400cccb9c67), [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#ad5f14f818ce750c6139bc7f6fe151c9a), and [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa83078c6c4b23b1f40bf3f895548c3e8).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a8f2b1019fb258bc2fe1118586d1515e5)GetMovingAgentAtSlotIndex()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.IDetachment.GetMovingAgentAtSlotIndex | ( | int | *slotIndex* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#adbaf775a536f86367f4f51e3eafed0d5)MarkSlotAtIndex()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IDetachment.MarkSlotAtIndex | ( | int | *slotIndex* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a05a346562274450740539ac248415efa)IsDetachmentRecentlyEvaluated()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IDetachment.IsDetachmentRecentlyEvaluated | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a200c1d077c286c362c27f4b47d2c92e0)UnmarkDetachment()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IDetachment.UnmarkDetachment | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a345165a29b4a8309bf8bb48bc0c671f9)GetWeightOfAgentAtNextSlot() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float? TaleWorlds.MountAndBlade.IDetachment.GetWeightOfAgentAtNextSlot | ( | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *candidates*, |
|  |  | out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *match* ) |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#ae75d74a5885d435ba65f5b7e12c0d991), and [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#ac6dcd76f5e7d92898883ecf54dd36966).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ad1e6215c72c45713ef0a48a7007587db)GetWeightOfAgentAtNextSlot() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float? TaleWorlds.MountAndBlade.IDetachment.GetWeightOfAgentAtNextSlot | ( | List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > | *agentTemplateScores*, |
|  |  | out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *match* ) |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a878f302ad99589a58d9b469aee54ce8c), and [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#aa1fb341a219cbbc72fdd0044dec51916).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#abe5ae1eb424a9665cffe329ea60a95a2)GetTemplateWeightOfAgent()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IDetachment.GetTemplateWeightOfAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *candidate* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#acbc3ae42a12799ae58728de510cc3c77), and [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#ace29e5e89260ad31640f7ca1f971fcdb).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#aeba86a1b94544e8136177f7880ab4db2)GetTemplateCostsOfAgent()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< float > TaleWorlds.MountAndBlade.IDetachment.GetTemplateCostsOfAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *candidate*, |
|  |  | List< float > | *oldValue* ) |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#adaf90ecb88d0f80f211f5ebca1dd1a9b), and [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a3a0e31bb055d6c8dad780f65dc6318c9).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a0cceb84dcdf9653b87f61e733822fa06)GetExactCostOfAgentAtSlot()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IDetachment.GetExactCostOfAgentAtSlot | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *candidate*, |
|  |  | int | *slotIndex* ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ac9723e1dd8704d3fc33a2fdb8cdba8a5)GetWeightOfOccupiedSlot()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IDetachment.GetWeightOfOccupiedSlot | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *detachedAgent* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a9142ad7f3343f18ac33e5c043080265a), and [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a3d15ae218edb16f3d771cdcaa173a1ea).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#af2d0d31d5aab707f6b5723d9eccedda5)GetWeightOfAgentAtOccupiedSlot()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float? TaleWorlds.MountAndBlade.IDetachment.GetWeightOfAgentAtOccupiedSlot | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *detachedAgent*, |
|  |  | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *candidates*, |
|  |  | out [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *match* ) |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a013a8b5292c3651bdc8e6530400963cb), and [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#aba9931030e1ea615346843c74cbdc55a).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#aa7011006963db3f87d4857714c5f5f88)IsStandingPointAvailableForAgent()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IDetachment.IsStandingPointAvailableForAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a48e0ef2a21c10155cc9d41dbc56ff83d), [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a43e3576948e878ee1d4f4a9e9429d228), and [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a235d97c77e03d34ac7433b15c4644c0d).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a115a1d2c2312337b687d8245bee20b94)AddAgent()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IDetachment.AddAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | int | *slotIndex* = -1, |
|  |  | [Agent.AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) | *customFlags* = [Agent.AIScriptedFrameFlags.None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a6adf97f83acf6453d4a6a4b1070f3754) ) |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#ae8c4862957af0ea3f27d8135e4c72769), and [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a512f622827e51068395e0828ec82f531).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a78c23ae8475f7c67b33a4beb26aae5aa)RemoveAgent()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IDetachment.RemoveAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *detachedAgent* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#af365fcd9b24007545f2c1feca121c066), and [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a637f398035ef83f01a8b57b00f41b674).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ad075e3a8acd6a1a28a74d183ea79760c)GetNumberOfUsableSlots()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.IDetachment.GetNumberOfUsableSlots | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#ad423f04911a166062755f24591387f2d), [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a93e54188b22a43528b99fd4f079f0c70), and [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a85932ec1160bbaba72eaedc8c7f30ff1).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a269a5eac2c45999dc317fec8425b2102)FormationStartUsing()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IDetachment.FormationStartUsing | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a5cc081ce9e122d0b42332b35f3e7f624)FormationStopUsing()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IDetachment.FormationStopUsing | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a301b5d910555ebe58458ff114557fa7a)IsUsedByFormation()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IDetachment.IsUsedByFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#aca30d2e7b93392e7f166a3da9df91306), [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a988057a634c2cb763214c3b7df32e271), and [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aa9ac0e4cdff26c48683b1189964162f3).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ac0bd160b8ea796c68327ac3c76fca199)GetAgentFrame()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html)? TaleWorlds.MountAndBlade.IDetachment.GetAgentFrame | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *detachedAgent* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | detachedAgent |  |

Returns

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a998bc6f231358ef57bcd62f3fc29dddc), and [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a721f853c5cc90bc0dc1c2984c5d46be1).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a2fc0a36b9a5543fe0836feb65d7dbb3e)ResetEvaluation()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IDetachment.ResetEvaluation | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a04e8445ae5204b20502e4316db1bb6a8)IsEvaluated()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IDetachment.IsEvaluated | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#aea1c6a944c686edd7e766f853e42b6c1)SetAsEvaluated()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IDetachment.SetAsEvaluated | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#acd9dc752c4ab6475203e1b5eec56f3c4)OnFormationLeave()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IDetachment.OnFormationLeave | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#a42ddcfd10b9ead1eb8da56ee1397c317)UserFormations
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.IDetachment.UserFormations | | get |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#a90e6a1241dcfce313c10affb10a1f6b0), [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a6516891c18bdf1541c8515cda46a63aa), and [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a063bc1ab0685f631a3d6c4c587a91e4b).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html#ab8aa0c3047a6963ac8a641c31b3adb57)IsLoose
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.IDetachment.IsLoose | | get |

Implemented in [TaleWorlds.MountAndBlade.ClimbingMachineDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_climbing_machine_detachment.html#aa5acebb836ef8501b33ee5ba9c9904c9), [TaleWorlds.MountAndBlade.StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html#a312ca0efa3baf996807d6b1edc9df2ee), and [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aca1e3b6c22ea4ce05497c4b435d51eb6).


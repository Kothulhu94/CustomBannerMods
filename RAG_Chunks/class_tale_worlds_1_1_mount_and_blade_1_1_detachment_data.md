--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html ---

TaleWorlds.MountAndBlade.DetachmentData Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [IsPrecalculated](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#aac25dcc2d3f52605d23d67116b956550) () |
|  | [DetachmentData](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#a977185486da1301b1f94062649e198c3) () |
| void | [RemoveScoreOfAgent](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#a18938476c999db876ee7edd05a6d02d7) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |

|  |  |
| --- | --- |
| Public Attributes | |
| List< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [joinedFormations](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#aca8e1eb5e81fe1b229ac41e447515302) = new List<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)>() |
| List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), List< float > > > | [agentScores](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#af92c1dd74ddd37402d5ab1437efbbcf2) = new List<ValueTuple<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), List<float>>>() |
| int | [MovingAgentCount](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#a9fba91fae48b15b1079c292ce1f9dad2) |
| int | [DefendingAgentCount](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#a06068c46107c5d1bfd878386aa88f107) |
| float | [firstTime](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#afcba80e9912d2179af3d04772c8c6d38) |

|  |  |
| --- | --- |
| Properties | |
| int | [AgentCount](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#a4d328078cf7c8c90016fc64b416c3a77) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#a977185486da1301b1f94062649e198c3)DetachmentData()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.DetachmentData.DetachmentData | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#aac25dcc2d3f52605d23d67116b956550)IsPrecalculated()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DetachmentData.IsPrecalculated | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#a18938476c999db876ee7edd05a6d02d7)RemoveScoreOfAgent()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentData.RemoveScoreOfAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#aca8e1eb5e81fe1b229ac41e447515302)joinedFormations
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.DetachmentData.joinedFormations = new List<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)>() |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#af92c1dd74ddd37402d5ab1437efbbcf2)agentScores
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<ValueTuple<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), List<float> > > TaleWorlds.MountAndBlade.DetachmentData.agentScores = new List<ValueTuple<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), List<float>>>() |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#a9fba91fae48b15b1079c292ce1f9dad2)MovingAgentCount
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.DetachmentData.MovingAgentCount |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#a06068c46107c5d1bfd878386aa88f107)DefendingAgentCount
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.DetachmentData.DefendingAgentCount |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#afcba80e9912d2179af3d04772c8c6d38)firstTime
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.DetachmentData.firstTime |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html#a4d328078cf7c8c90016fc64b416c3a77)AgentCount
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.DetachmentData.AgentCount | | get |


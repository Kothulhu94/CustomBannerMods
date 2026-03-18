--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html ---

TaleWorlds.MountAndBlade.DetachmentManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DetachmentManager](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a610f0ddcec47418a9fcad8709446ef2f) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a09d01039467b49e52a8a2ce5b426421a) () |
| bool | [ContainsDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a5ef8d049d9982a72edf2d22b261cb51c) ([IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| void | [MakeDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a15623e7a725caa4c89f30377fed7f349) ([IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| void | [DestroyDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a00588db804eb682208146499376ef717) ([IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) destroyedDetachment) |
| void | [OnFormationJoinDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a360a9c0a69df328738dd360a0aa2b3ff) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) joinedDetachment) |
| void | [OnFormationLeaveDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a95a2b09070b7b214c8940205cba58fe7) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) leftDetachment) |
| void | [TickDetachments](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#ae7b1be9c7e3746336a285fd62ada86d1) () |
| void | [TickAgent](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a072de673b00cefed01c649600402c953) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#ac42c8cf9d40210ce8d6e50d44241d76d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [RemoveScoresOfAgentFromDetachments](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a981ae134a311e4d96675cf8003c8bb8c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [RemoveScoresOfAgentFromDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a7897974d24890a4c4fb98634bd8fbe75) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachmentToBeRemovedFrom) |
| void | [AddAgentAsMovingToDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a02727a0e6804272d77cd988ab261956d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| void | [RemoveAgentAsMovingToDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a666c71a19510ae80f5907924e5584e43) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [AddAgentAsDefendingToDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a5723aa0dd69ed2ea95fa656b9ecf3d29) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |
| void | [RemoveAgentAsDefendingToDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#aaedd9ffcd9e46de1bfc73a06e386d313) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [AssertDetachment](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a4ebc0a459fd71c05c97799bab2ca0055) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) detachment) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< ValueTuple< [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html), [DetachmentData](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html) > > | [Detachments](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a333e6f9fc793a0acdfe2bd4a3776d0f4) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a610f0ddcec47418a9fcad8709446ef2f)DetachmentManager()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.DetachmentManager.DetachmentManager | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a09d01039467b49e52a8a2ce5b426421a)Clear()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a5ef8d049d9982a72edf2d22b261cb51c)ContainsDetachment()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DetachmentManager.ContainsDetachment | ( | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachment* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a15623e7a725caa4c89f30377fed7f349)MakeDetachment()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.MakeDetachment | ( | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachment* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a00588db804eb682208146499376ef717)DestroyDetachment()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.DestroyDetachment | ( | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *destroyedDetachment* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a360a9c0a69df328738dd360a0aa2b3ff)OnFormationJoinDetachment()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.OnFormationJoinDetachment | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, |
|  |  | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *joinedDetachment* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a95a2b09070b7b214c8940205cba58fe7)OnFormationLeaveDetachment()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.OnFormationLeaveDetachment | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, |
|  |  | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *leftDetachment* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#ae7b1be9c7e3746336a285fd62ada86d1)TickDetachments()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.TickDetachments | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a072de673b00cefed01c649600402c953)TickAgent()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.TickAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#ac42c8cf9d40210ce8d6e50d44241d76d)OnAgentRemoved()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a981ae134a311e4d96675cf8003c8bb8c)RemoveScoresOfAgentFromDetachments()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.RemoveScoresOfAgentFromDetachments | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a7897974d24890a4c4fb98634bd8fbe75)RemoveScoresOfAgentFromDetachment()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.RemoveScoresOfAgentFromDetachment | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachmentToBeRemovedFrom* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a02727a0e6804272d77cd988ab261956d)AddAgentAsMovingToDetachment()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.AddAgentAsMovingToDetachment | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachment* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a666c71a19510ae80f5907924e5584e43)RemoveAgentAsMovingToDetachment()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.RemoveAgentAsMovingToDetachment | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a5723aa0dd69ed2ea95fa656b9ecf3d29)AddAgentAsDefendingToDetachment()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.AddAgentAsDefendingToDetachment | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachment* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#aaedd9ffcd9e46de1bfc73a06e386d313)RemoveAgentAsDefendingToDetachment()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.RemoveAgentAsDefendingToDetachment | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a4ebc0a459fd71c05c97799bab2ca0055)AssertDetachment()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DetachmentManager.AssertDetachment | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | *detachment* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_manager.html#a333e6f9fc793a0acdfe2bd4a3776d0f4)Detachments
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<ValueTuple<[IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html), [DetachmentData](class_tale_worlds_1_1_mount_and_blade_1_1_detachment_data.html)> > TaleWorlds.MountAndBlade.DetachmentManager.Detachments | | get |


--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html ---

TaleWorlds.MountAndBlade.AnimationSystemData Struct Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [AnimationSystemData](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html) | [GetHardcodedAnimationSystemDataForHumanSkeleton](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a7052c68af5022bbbba88b32d23c8849e) () |
|  | Avoid using this function if you can. Consider calling Game.Current.DefaultMonster.FillAnimationSystemData() first. |

|  |  |
| --- | --- |
| Public Attributes | |
| [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) | [ActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#ac6c3f2263fbe2c819858d903a222625c) |
| int | [NumPaces](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a5505301e94dde96f5d35af60b6f50dbb) |
| int | [MonsterUsageSetIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#adb183158439fcdc332a410dc549b5236) |
| float | [WalkingSpeedLimit](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a5c316888f6b0b12ef4794ba7b6c580f7) |
| float | [CrouchWalkingSpeedLimit](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a400bb77ddfe0392947eaca39fb500ef1) |
| float | [StepSize](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a12468c0a57017fbaa29a5172f0384064) |
| bool | [HasClippingPlane](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#ae2e1e507dda34fe37c40b3c1b60d13b5) |
| [AnimationSystemBoneData](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_bone_data.html) | [Bones](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a731b4dd694ab391e03f447e5e2c85d58) |
| [AnimationSystemBoneDataBiped](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_bone_data_biped.html) | [Biped](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a33ef4f221d16bba33937379d5febfd45) |
| [AnimationSystemDataQuadruped](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data_quadruped.html) | [Quadruped](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#ab7f695d57a4a18a116ca211bbd4c3628) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const sbyte | [InvalidBoneIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a88956b43fe11b06417be18eae86a9459) = -1 |
| const sbyte | [NumBonesForIkMaxCount](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a0617783a95bc2f9be3c0bd4853f58d25) = 8 |
| const sbyte | [MaxCountOfRagdollBonesToCheckForCorpses](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a8327e2ef9b43e3a85954bd4453fdb6a3) = 11 |
| const sbyte | [RagdollFallSoundBoneIndexMaxCount](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a0e27a15f6b7886cccd9c2199b551b517) = 4 |
| const sbyte | [RagdollStationaryCheckBoneMaxCount](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a1eee105a0f940eb234fd7d2800432197) = 8 |
| const sbyte | [MoveAdderBoneMaxCount](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#aca695b456fa7f4aaa487d46ffb7fc5b3) = 7 |
| const sbyte | [SplashDecalBoneMaxCount](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a31bfa59058247953e56640ddb124bf29) = 6 |
| const sbyte | [BloodBurstBoneMaxCount](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a6c535752d29664ed34031dd272a512d8) = 8 |
| const sbyte | [BoneIndicesToModifyOnSlopingGroundMaxCount](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a86e3b0e738dfa59e31ceec774258823d) = 7 |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a7052c68af5022bbbba88b32d23c8849e)GetHardcodedAnimationSystemDataForHumanSkeleton()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [AnimationSystemData](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html) TaleWorlds.MountAndBlade.AnimationSystemData.GetHardcodedAnimationSystemDataForHumanSkeleton | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a88956b43fe11b06417be18eae86a9459)InvalidBoneIndex
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const sbyte TaleWorlds.MountAndBlade.AnimationSystemData.InvalidBoneIndex = -1 | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a0617783a95bc2f9be3c0bd4853f58d25)NumBonesForIkMaxCount
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const sbyte TaleWorlds.MountAndBlade.AnimationSystemData.NumBonesForIkMaxCount = 8 | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a8327e2ef9b43e3a85954bd4453fdb6a3)MaxCountOfRagdollBonesToCheckForCorpses
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const sbyte TaleWorlds.MountAndBlade.AnimationSystemData.MaxCountOfRagdollBonesToCheckForCorpses = 11 | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a0e27a15f6b7886cccd9c2199b551b517)RagdollFallSoundBoneIndexMaxCount
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const sbyte TaleWorlds.MountAndBlade.AnimationSystemData.RagdollFallSoundBoneIndexMaxCount = 4 | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a1eee105a0f940eb234fd7d2800432197)RagdollStationaryCheckBoneMaxCount
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const sbyte TaleWorlds.MountAndBlade.AnimationSystemData.RagdollStationaryCheckBoneMaxCount = 8 | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#aca695b456fa7f4aaa487d46ffb7fc5b3)MoveAdderBoneMaxCount
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const sbyte TaleWorlds.MountAndBlade.AnimationSystemData.MoveAdderBoneMaxCount = 7 | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a31bfa59058247953e56640ddb124bf29)SplashDecalBoneMaxCount
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const sbyte TaleWorlds.MountAndBlade.AnimationSystemData.SplashDecalBoneMaxCount = 6 | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a6c535752d29664ed34031dd272a512d8)BloodBurstBoneMaxCount
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const sbyte TaleWorlds.MountAndBlade.AnimationSystemData.BloodBurstBoneMaxCount = 8 | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a86e3b0e738dfa59e31ceec774258823d)BoneIndicesToModifyOnSlopingGroundMaxCount
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const sbyte TaleWorlds.MountAndBlade.AnimationSystemData.BoneIndicesToModifyOnSlopingGroundMaxCount = 7 | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#ac6c3f2263fbe2c819858d903a222625c)ActionSet
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) TaleWorlds.MountAndBlade.AnimationSystemData.ActionSet |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a5505301e94dde96f5d35af60b6f50dbb)NumPaces
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.AnimationSystemData.NumPaces |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#adb183158439fcdc332a410dc549b5236)MonsterUsageSetIndex
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.AnimationSystemData.MonsterUsageSetIndex |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a5c316888f6b0b12ef4794ba7b6c580f7)WalkingSpeedLimit
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AnimationSystemData.WalkingSpeedLimit |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a400bb77ddfe0392947eaca39fb500ef1)CrouchWalkingSpeedLimit
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AnimationSystemData.CrouchWalkingSpeedLimit |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a12468c0a57017fbaa29a5172f0384064)StepSize
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AnimationSystemData.StepSize |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#ae2e1e507dda34fe37c40b3c1b60d13b5)HasClippingPlane
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AnimationSystemData.HasClippingPlane |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a731b4dd694ab391e03f447e5e2c85d58)Bones
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [AnimationSystemBoneData](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_bone_data.html) TaleWorlds.MountAndBlade.AnimationSystemData.Bones |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#a33ef4f221d16bba33937379d5febfd45)Biped
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [AnimationSystemBoneDataBiped](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_bone_data_biped.html) TaleWorlds.MountAndBlade.AnimationSystemData.Biped |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html#ab7f695d57a4a18a116ca211bbd4c3628)Quadruped
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [AnimationSystemDataQuadruped](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data_quadruped.html) TaleWorlds.MountAndBlade.AnimationSystemData.Quadruped |


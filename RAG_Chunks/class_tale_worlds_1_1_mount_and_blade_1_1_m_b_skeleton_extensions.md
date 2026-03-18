--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html ---

TaleWorlds.MountAndBlade.MBSkeletonExtensions Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | [CreateWithActionSet](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#aae8407fa107de0d3d3714b4be2373699) (ref [AnimationSystemData](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html) animationSystemData) |
| static float | [GetSkeletonFaceAnimationTime](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a73f7a767fed799f932b85d3de727f3e3) ([Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton) |
| static void | [SetSkeletonFaceAnimationTime](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#ab28f63d177b5cb0670bf058ada012d4b) ([Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton, float time) |
| static string | [GetSkeletonFaceAnimationName](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#ad593903489b0c1bff8f15a364f0f943f) ([Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialFrameAtAnimationProgress](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a36e02979f65a26371a10b4acf2965949) (this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton, sbyte boneIndex, int animationIndex, float progress) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialFrame](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#ab2ddf82fde6b734f3f015504ddf0d07e) (this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton, sbyte boneNumber, bool forceToUpdate=false) |
| static void | [SetFacialAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a70c67c71effc20aba1b610bec7256114) (this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton, [Agent.FacialAnimChannel](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5262a134add2c2f514741a32df8efc52) channel, string faceAnimation, bool playSound, bool loop) |
| static void | [SetAgentActionChannel](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a0475587dc6ae4bbd932a9749b6835a8a) (this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton, int actionChannelNo, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndex, float channelParameter=0.0f, float blendPeriodOverride=-0.2f, bool forceFaceMorphRestart=true, float blendWithNextActionFactor=0.0f) |
| static bool | [DoesActionContinueWithCurrentActionAtChannel](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a62f49179660709bef713722b89288b2d) (this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton, int actionChannelNo, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndex) |
| static void | [TickActionChannels](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a2aeb9e67b97b366fa1f127b071160d10) (this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton) |
| static void | [SetAnimationAtChannel](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a7ac41a0f3e508fd38efe7b110a081601) (this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton, string animationName, int channelNo, float animationSpeedMultiplier=1.0f, float blendInPeriod=-1.0f, float startProgress=0.0f) |
|  | Sets the animation at the specific channel. |
| static void | [SetAnimationAtChannel](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a79f812f55f13db5de6db41ab4892715e) (this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton, int animationIndex, int channelNo, float animationSpeedMultiplier=1.0f, float blendInPeriod=-1.0f, float startProgress=0.0f) |
| static [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | [GetActionAtChannel](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#abf8f8bd10d01576b6446592fec9291e6) (this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton, int channelNo) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#aae8407fa107de0d3d3714b4be2373699)CreateWithActionSet()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) TaleWorlds.MountAndBlade.MBSkeletonExtensions.CreateWithActionSet | ( | ref [AnimationSystemData](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html) | *animationSystemData* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a73f7a767fed799f932b85d3de727f3e3)GetSkeletonFaceAnimationTime()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBSkeletonExtensions.GetSkeletonFaceAnimationTime | ( | [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#ab28f63d177b5cb0670bf058ada012d4b)SetSkeletonFaceAnimationTime()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBSkeletonExtensions.SetSkeletonFaceAnimationTime | ( | [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton*, | |  |  | float | *time* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#ad593903489b0c1bff8f15a364f0f943f)GetSkeletonFaceAnimationName()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MBSkeletonExtensions.GetSkeletonFaceAnimationName | ( | [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a36e02979f65a26371a10b4acf2965949)GetBoneEntitialFrameAtAnimationProgress()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.MBSkeletonExtensions.GetBoneEntitialFrameAtAnimationProgress | ( | this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton*, | |  |  | sbyte | *boneIndex*, | |  |  | int | *animationIndex*, | |  |  | float | *progress* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#ab2ddf82fde6b734f3f015504ddf0d07e)GetBoneEntitialFrame()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.MBSkeletonExtensions.GetBoneEntitialFrame | ( | this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton*, | |  |  | sbyte | *boneNumber*, | |  |  | bool | *forceToUpdate* = false ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a70c67c71effc20aba1b610bec7256114)SetFacialAnimation()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBSkeletonExtensions.SetFacialAnimation | ( | this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton*, | |  |  | [Agent.FacialAnimChannel](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5262a134add2c2f514741a32df8efc52) | *channel*, | |  |  | string | *faceAnimation*, | |  |  | bool | *playSound*, | |  |  | bool | *loop* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a0475587dc6ae4bbd932a9749b6835a8a)SetAgentActionChannel()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBSkeletonExtensions.SetAgentActionChannel | ( | this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton*, | |  |  | int | *actionChannelNo*, | |  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndex*, | |  |  | float | *channelParameter* = 0::0f, | |  |  | float | *blendPeriodOverride* = -0::2f, | |  |  | bool | *forceFaceMorphRestart* = true, | |  |  | float | *blendWithNextActionFactor* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a62f49179660709bef713722b89288b2d)DoesActionContinueWithCurrentActionAtChannel()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBSkeletonExtensions.DoesActionContinueWithCurrentActionAtChannel | ( | this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton*, | |  |  | int | *actionChannelNo*, | |  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndex* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a2aeb9e67b97b366fa1f127b071160d10)TickActionChannels()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBSkeletonExtensions.TickActionChannels | ( | this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a7ac41a0f3e508fd38efe7b110a081601)SetAnimationAtChannel() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBSkeletonExtensions.SetAnimationAtChannel | ( | this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton*, | |  |  | string | *animationName*, | |  |  | int | *channelNo*, | |  |  | float | *animationSpeedMultiplier* = 1::0f, | |  |  | float | *blendInPeriod* = -1::0f, | |  |  | float | *startProgress* = 0::0f ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | skeleton |  |
    | animationName | Name of the animation. |
    | channelNo | Index of the channel. |
    | animationSpeedMultiplier | Speed multiplier of the animation. Default is 1.0f. |
    | blendInPeriod | Blend in period override option for the animation. Keep it below 0.0f to use the default period. |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#a79f812f55f13db5de6db41ab4892715e)SetAnimationAtChannel() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBSkeletonExtensions.SetAnimationAtChannel | ( | this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton*, | |  |  | int | *animationIndex*, | |  |  | int | *channelNo*, | |  |  | float | *animationSpeedMultiplier* = 1::0f, | |  |  | float | *blendInPeriod* = -1::0f, | |  |  | float | *startProgress* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_skeleton_extensions.html#abf8f8bd10d01576b6446592fec9291e6)GetActionAtChannel()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) TaleWorlds.MountAndBlade.MBSkeletonExtensions.GetActionAtChannel | ( | this [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton*, | |  |  | int | *channelNo* ) | | static |


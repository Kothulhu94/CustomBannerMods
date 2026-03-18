--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html ---

TaleWorlds.MountAndBlade.MBAnimation Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MBAnimation](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#aa68495b49523f18063d419d3b26386a6) (MBAnimation animation) |
| bool | [Equals](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a012b3118d1987f6397abb7659cc04909) ([MBAnimation](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#aa68495b49523f18063d419d3b26386a6) a) |
| override int | [GetHashCode](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a81244adf7b618e7949a92453a26e532a) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GetAnimationIndexWithName](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a0e5fa12434dccf5d2b0d1bf1b20486e3) (string animationName) |
| static [Agent.ActionCodeType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016) | [GetActionType](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a84a79b4eb807f58f7c35942387d4a620) ([ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndex) |
| static void | [PrefetchAnimationClip](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a32c7b5969246a389862b698128cfda12) ([MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) actionSet, [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndexCache) |
| static float | [GetAnimationDuration](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a4c4a0504c97a4ce76a3c4c584dbe3bfe) (string animationName) |
| static float | [GetAnimationDuration](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a4201ed6533ecbb256d6ddcb8b3c434e5) (int animationIndex) |
| static float | [GetAnimationParameter1](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a6cca0b3d6003ef2d8db1ea6162716eeb) (string animationName) |
| static float | [GetAnimationParameter1](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a4a3761717a5fc452385bc575f4024c55) (int animationIndex) |
| static float | [GetAnimationParameter2](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#afc99174b2c8a82f2bfee09219ffc0dfb) (string animationName) |
| static float | [GetAnimationParameter2](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#ac5e2beced09b6a53358546ffe0dbe4b1) (int animationIndex) |
| static float | [GetAnimationParameter3](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#aa3311dc6b5644f56be3ba8676e0f8d19) (string animationName) |
| static float | [GetAnimationBlendInPeriod](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a399f1e12be3aed25c6a5b017d32678f4) (string animationName) |
| static float | [GetAnimationBlendInPeriod](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#abc1cc11cac50baa0c07a3c3034b2b34b) (int animationIndex) |
| static int | [GetAnimationBlendsWithActionIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a26e0c9905d0c65f057483bfe21246a23) (string animationName) |
| static float | [GetAnimationBlendsWithActionIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a55a7355c4218a42606353d52f918b58f) (int animationIndex) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetAnimationDisplacementAtProgress](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#afaef7d9605f8d3ad96a0fcdc6a427a89) (string animationName, float progress) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetAnimationDisplacementAtProgress](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a3dde7a9127cb4cd198dbff8f1a2e1927) (int animationIndex, float progress) |
| static int | [GetActionCodeWithName](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#ab98a98271e1e0aff14fec54423df6f9e) (string name) |
| static int | [GetNumActionCodes](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#aebdab0e2123a1ddeeffd071a39dd87e6) () |
| static int | [GetNumAnimations](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#afd214482d9e89d53a0d0f8c9aca41680) () |
| static bool | [IsAnyAnimationLoadingFromDisk](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a9f198a65725b0772d2da1cae5197a658) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#aa68495b49523f18063d419d3b26386a6)MBAnimation()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MBAnimation.MBAnimation | ( | MBAnimation | *animation* | ) |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a012b3118d1987f6397abb7659cc04909)Equals()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MBAnimation.Equals | ( | [MBAnimation](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#aa68495b49523f18063d419d3b26386a6) | *a* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a81244adf7b618e7949a92453a26e532a)GetHashCode()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.MountAndBlade.MBAnimation.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a0e5fa12434dccf5d2b0d1bf1b20486e3)GetAnimationIndexWithName()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBAnimation.GetAnimationIndexWithName | ( | string | *animationName* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a84a79b4eb807f58f7c35942387d4a620)GetActionType()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Agent.ActionCodeType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016) TaleWorlds.MountAndBlade.MBAnimation.GetActionType | ( | [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndex* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a32c7b5969246a389862b698128cfda12)PrefetchAnimationClip()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBAnimation.PrefetchAnimationClip | ( | [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) | *actionSet*, | |  |  | [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndexCache* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a4c4a0504c97a4ce76a3c4c584dbe3bfe)GetAnimationDuration() [1/2]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBAnimation.GetAnimationDuration | ( | string | *animationName* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a4201ed6533ecbb256d6ddcb8b3c434e5)GetAnimationDuration() [2/2]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBAnimation.GetAnimationDuration | ( | int | *animationIndex* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a6cca0b3d6003ef2d8db1ea6162716eeb)GetAnimationParameter1() [1/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBAnimation.GetAnimationParameter1 | ( | string | *animationName* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a4a3761717a5fc452385bc575f4024c55)GetAnimationParameter1() [2/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBAnimation.GetAnimationParameter1 | ( | int | *animationIndex* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#afc99174b2c8a82f2bfee09219ffc0dfb)GetAnimationParameter2() [1/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBAnimation.GetAnimationParameter2 | ( | string | *animationName* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#ac5e2beced09b6a53358546ffe0dbe4b1)GetAnimationParameter2() [2/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBAnimation.GetAnimationParameter2 | ( | int | *animationIndex* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#aa3311dc6b5644f56be3ba8676e0f8d19)GetAnimationParameter3()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBAnimation.GetAnimationParameter3 | ( | string | *animationName* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a399f1e12be3aed25c6a5b017d32678f4)GetAnimationBlendInPeriod() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBAnimation.GetAnimationBlendInPeriod | ( | string | *animationName* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#abc1cc11cac50baa0c07a3c3034b2b34b)GetAnimationBlendInPeriod() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBAnimation.GetAnimationBlendInPeriod | ( | int | *animationIndex* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a26e0c9905d0c65f057483bfe21246a23)GetAnimationBlendsWithActionIndex() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBAnimation.GetAnimationBlendsWithActionIndex | ( | string | *animationName* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a55a7355c4218a42606353d52f918b58f)GetAnimationBlendsWithActionIndex() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBAnimation.GetAnimationBlendsWithActionIndex | ( | int | *animationIndex* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#afaef7d9605f8d3ad96a0fcdc6a427a89)GetAnimationDisplacementAtProgress() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.MBAnimation.GetAnimationDisplacementAtProgress | ( | string | *animationName*, | |  |  | float | *progress* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a3dde7a9127cb4cd198dbff8f1a2e1927)GetAnimationDisplacementAtProgress() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.MBAnimation.GetAnimationDisplacementAtProgress | ( | int | *animationIndex*, | |  |  | float | *progress* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#ab98a98271e1e0aff14fec54423df6f9e)GetActionCodeWithName()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBAnimation.GetActionCodeWithName | ( | string | *name* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#aebdab0e2123a1ddeeffd071a39dd87e6)GetNumActionCodes()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBAnimation.GetNumActionCodes | ( |  | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#afd214482d9e89d53a0d0f8c9aca41680)GetNumAnimations()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBAnimation.GetNumAnimations | ( |  | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_animation.html#a9f198a65725b0772d2da1cae5197a658)IsAnyAnimationLoadingFromDisk()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBAnimation.IsAnyAnimationLoadingFromDisk | ( |  | ) |  | | static |


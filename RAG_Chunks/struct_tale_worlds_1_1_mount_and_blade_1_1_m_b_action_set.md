--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html ---

TaleWorlds.MountAndBlade.MBActionSet Struct ReferenceStructure for accessing action sets.

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [Equals](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#abb083f55fa36432e7419bfcfab411c6e) (MBActionSet a) |
|  | Over-ride for Equals function. Index check is made instead of pointer check. |
| bool | [Equals](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#aa81dd9fdf1389bd5cbb6300c8600fc83) (int index) |
|  | Over-ride for Equals function. Index check is made instead of pointer check. |
| override int | [GetHashCode](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a73420f2b3c8e1861665d38845b732f7f) () |
|  | Over-ride for GetHashCode function. |
| string | [GetName](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#ac83bd441fae1af39a9e95b95a5702f24) () |
| string | [GetSkeletonName](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a91da60fbc83fbb9e9f1c7c20cfe6af49) () |
| string | [GetAnimationName](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a38eab366d9c1c4098f78fdcd57d38c53) (in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionCode) |
| bool | [AreActionsAlternatives](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a878329a1c0009227d78efc4b80695ae4) (in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionCode1, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionCode2) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GetNumberOfActionSets](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a98fb6a3d72eea960b43cdc8eec967dd2) () |
| static int | [GetNumberOfMonsterUsageSets](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a1a8dddd70bc1c1ddb520324afc00ba65) () |
| static MBActionSet | [GetActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a8fd7dcda04675aafd81f8ccf8874901f) (string objectID) |
| static MBActionSet | [GetActionSetWithIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a2c0cbe6cda307bfb6d31d0dd56423aa6) (int index) |
| static sbyte | [GetBoneIndexWithId](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#af17d48256d76c0cdc2a3bbda3a9ccfa8) (string actionSetId, string boneId) |
| static bool | [GetBoneHasParentBone](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a7128442c6009cef81841ebc70e17e7d8) (string actionSetId, sbyte boneIndex) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetActionDisplacementVector](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#aaa4e2e240720c6ac6633d4eec92b9c67) (MBActionSet actionSet, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndexCache) |
| static [AnimFlags](namespace_tale_worlds_1_1_mount_and_blade.html#aee58182af722eaf22dec720de2cc5818) | [GetActionAnimationFlags](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#aa76b1e27062ee272b0360deb568fbdba) (MBActionSet actionSet, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndexCache) |
| static bool | [CheckActionAnimationClipExists](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a1da647aa56260d2f35f8cfc16124716f) (MBActionSet actionSet, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndexCache) |
| static int | [GetAnimationIndexOfAction](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a95bea85a2135ab599fa6fec655e3932e) (MBActionSet actionSet, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndexCache) |
| static string | [GetActionAnimationName](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a5dd2f43ae2cab4de66c1cba5c83ec9c3) (MBActionSet actionSet, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndexCache) |
| static float | [GetActionAnimationDuration](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a1352ba12e2e291c45891a3d65cd98f05) (MBActionSet actionSet, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndexCache) |
| static [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | [GetActionAnimationContinueToAction](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a4ede357c29c16b00a2586df29e7f598a) (MBActionSet actionSet, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndexCache) |
| static float | [GetTotalAnimationDurationWithContinueToAction](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a8b20567bdfffb4f06fee12e70169e22e) (MBActionSet actionSet, [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndexCache) |
| static float | [GetActionBlendOutStartProgress](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#ad1f3624084e2806f57a95ffc2447356e) (MBActionSet actionSet, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndexCache) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly MBActionSet | [InvalidActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a8441e1a6a98f89325ed1ccf1b6da75e3) = new MBActionSet(-1) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#af25c86dcfadb1365a063700dc5171104) `[get]` |
|  | Gets a value indicating whether the engine index of object is valid or not. |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#abb083f55fa36432e7419bfcfab411c6e)Equals() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MBActionSet.Equals | ( | MBActionSet | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | Object that will be checked. |

Returns
:   Returns true when both objects have the same index.

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#aa81dd9fdf1389bd5cbb6300c8600fc83)Equals() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MBActionSet.Equals | ( | int | *index* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | index | Index that will be checked. |

Returns
:   Returns true when index of object is equal to index parameter.

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a73420f2b3c8e1861665d38845b732f7f)GetHashCode()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.MountAndBlade.MBActionSet.GetHashCode | ( |  | ) |  |

Returns
:   [Engine](namespace_tale_worlds_1_1_engine.html) index is returned as the hash code since it is unique.

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#ac83bd441fae1af39a9e95b95a5702f24)GetName()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.MBActionSet.GetName | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a91da60fbc83fbb9e9f1c7c20cfe6af49)GetSkeletonName()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.MBActionSet.GetSkeletonName | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a38eab366d9c1c4098f78fdcd57d38c53)GetAnimationName()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.MBActionSet.GetAnimationName | ( | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionCode* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a878329a1c0009227d78efc4b80695ae4)AreActionsAlternatives()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MBActionSet.AreActionsAlternatives | ( | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionCode1*, |
|  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionCode2* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a98fb6a3d72eea960b43cdc8eec967dd2)GetNumberOfActionSets()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBActionSet.GetNumberOfActionSets | ( |  | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a1a8dddd70bc1c1ddb520324afc00ba65)GetNumberOfMonsterUsageSets()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBActionSet.GetNumberOfMonsterUsageSets | ( |  | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a8fd7dcda04675aafd81f8ccf8874901f)GetActionSet()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBActionSet TaleWorlds.MountAndBlade.MBActionSet.GetActionSet | ( | string | *objectID* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a2c0cbe6cda307bfb6d31d0dd56423aa6)GetActionSetWithIndex()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBActionSet TaleWorlds.MountAndBlade.MBActionSet.GetActionSetWithIndex | ( | int | *index* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#af17d48256d76c0cdc2a3bbda3a9ccfa8)GetBoneIndexWithId()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | sbyte TaleWorlds.MountAndBlade.MBActionSet.GetBoneIndexWithId | ( | string | *actionSetId*, | |  |  | string | *boneId* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a7128442c6009cef81841ebc70e17e7d8)GetBoneHasParentBone()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBActionSet.GetBoneHasParentBone | ( | string | *actionSetId*, | |  |  | sbyte | *boneIndex* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#aaa4e2e240720c6ac6633d4eec92b9c67)GetActionDisplacementVector()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.MBActionSet.GetActionDisplacementVector | ( | MBActionSet | *actionSet*, | |  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndexCache* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#aa76b1e27062ee272b0360deb568fbdba)GetActionAnimationFlags()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [AnimFlags](namespace_tale_worlds_1_1_mount_and_blade.html#aee58182af722eaf22dec720de2cc5818) TaleWorlds.MountAndBlade.MBActionSet.GetActionAnimationFlags | ( | MBActionSet | *actionSet*, | |  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndexCache* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a1da647aa56260d2f35f8cfc16124716f)CheckActionAnimationClipExists()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBActionSet.CheckActionAnimationClipExists | ( | MBActionSet | *actionSet*, | |  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndexCache* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a95bea85a2135ab599fa6fec655e3932e)GetAnimationIndexOfAction()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBActionSet.GetAnimationIndexOfAction | ( | MBActionSet | *actionSet*, | |  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndexCache* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a5dd2f43ae2cab4de66c1cba5c83ec9c3)GetActionAnimationName()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MBActionSet.GetActionAnimationName | ( | MBActionSet | *actionSet*, | |  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndexCache* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a1352ba12e2e291c45891a3d65cd98f05)GetActionAnimationDuration()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBActionSet.GetActionAnimationDuration | ( | MBActionSet | *actionSet*, | |  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndexCache* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a4ede357c29c16b00a2586df29e7f598a)GetActionAnimationContinueToAction()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) TaleWorlds.MountAndBlade.MBActionSet.GetActionAnimationContinueToAction | ( | MBActionSet | *actionSet*, | |  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndexCache* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a8b20567bdfffb4f06fee12e70169e22e)GetTotalAnimationDurationWithContinueToAction()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBActionSet.GetTotalAnimationDurationWithContinueToAction | ( | MBActionSet | *actionSet*, | |  |  | [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndexCache* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#ad1f3624084e2806f57a95ffc2447356e)GetActionBlendOutStartProgress()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBActionSet.GetActionBlendOutStartProgress | ( | MBActionSet | *actionSet*, | |  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndexCache* ) | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#a8441e1a6a98f89325ed1ccf1b6da75e3)InvalidActionSet
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly MBActionSet TaleWorlds.MountAndBlade.MBActionSet.InvalidActionSet = new MBActionSet(-1) | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html#af25c86dcfadb1365a063700dc5171104)IsValid
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MBActionSet.IsValid | | get |


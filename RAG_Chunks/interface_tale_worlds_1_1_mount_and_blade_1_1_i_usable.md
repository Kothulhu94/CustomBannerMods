--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_usable.html ---

TaleWorlds.MountAndBlade.IUsable Interface ReferenceInherited by [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), and [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnUse](interface_tale_worlds_1_1_mount_and_blade_1_1_i_usable.html#a3330b77edb1af39f70baed98feefd041) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, sbyte agentBoneIndex) |
| void | [OnUseStopped](interface_tale_worlds_1_1_mount_and_blade_1_1_i_usable.html#aa2e9cc62a3bd81ae89596d08e6415f80) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, bool isSuccessful, int preferenceIndex) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_usable.html#a3330b77edb1af39f70baed98feefd041)OnUse()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUsable.OnUse | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent*, |
|  |  | sbyte | *agentBoneIndex* ) |

Implemented in [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#ab657dfa52fa5cb14e002d2ca11c9789c), [SandBox.Objects.AnimationPoints.ChairUsePoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_chair_use_point.html#a00ffa9a831e0ddd052e890cfaa5991a3), [SandBox.Objects.AnimationPoints.DynamicObjectAnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_dynamic_object_animation_point.html#abd99452b9a9533d42f3571cb449fdff3), [SandBox.Objects.PassageUsePoint](class_sand_box_1_1_objects_1_1_passage_use_point.html#a9d47158809763dcf1256d954b8e83854), [SandBox.Objects.PatrolPoint](class_sand_box_1_1_objects_1_1_patrol_point.html#a0460404dab206e179ec5f850688eefa9), [SandBox.Objects.TeleportUsePoint](class_sand_box_1_1_objects_1_1_teleport_use_point.html#ade3a45d8336333cde07f565d9b7eb339), [SandBox.Objects.Usables.DisguiseMissionUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_disguise_mission_use_point.html#a54f7b9fcd0c52cbcbe5b42152f300c00), [SandBox.Objects.Usables.ShadowingSecureZoneUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_shadowing_secure_zone_use_point.html#a51a2849b77d8459cf89e06f743c75c73), [SandBox.Objects.Usables.StealthAreaUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_stealth_area_use_point.html#a4048ae0d6d7b87c990fa32d06567855d), [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acda375fc5df86ad6390a4b35c28fd989), [TaleWorlds.MountAndBlade.SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html#af97b43a4a1fddbda5e7b5d8b6fb133ad), [TaleWorlds.MountAndBlade.StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a36d4261a9e6ee9c9406a08b681cf7bf1), and [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a2064fe3da747b8b1c6d4350897a5bb02).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_usable.html#aa2e9cc62a3bd81ae89596d08e6415f80)OnUseStopped()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUsable.OnUseStopped | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent*, |
|  |  | bool | *isSuccessful*, |
|  |  | int | *preferenceIndex* ) |

Implemented in [SandBox.Objects.AnimationPoints.AnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_animation_point.html#a726503156f9d4f3d9bccd8fda4685de3), [SandBox.Objects.AnimationPoints.DynamicObjectAnimationPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_dynamic_object_animation_point.html#a0ced0cb7383a1d549d97b75a0c663f11), [SandBox.Objects.AnimationPoints.PlayMusicPoint](class_sand_box_1_1_objects_1_1_animation_points_1_1_play_music_point.html#af9a95801c88a868e6cd12dc29489ab23), [SandBox.Objects.PassageUsePoint](class_sand_box_1_1_objects_1_1_passage_use_point.html#a35a3373b28cad73b7becb82234ebb03f), [SandBox.Objects.PatrolPoint](class_sand_box_1_1_objects_1_1_patrol_point.html#a84974b70228a92b5de2dcdf78a15afbd), [SandBox.Objects.Usables.DisguiseMissionUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_disguise_mission_use_point.html#a3f80043709b35ad4be59e558b435f64e), [SandBox.Objects.Usables.ShadowingSecureZoneUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_shadowing_secure_zone_use_point.html#a0d0b4603f64c1f9fabf1dbd2fa817135), [SandBox.Objects.Usables.StealthAreaUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_stealth_area_use_point.html#ac6870d262c1e57d7bf55ba7f06e000cc), [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7eed2c8aa8e72e1570decace7ae685c3), [TaleWorlds.MountAndBlade.SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html#ab6ddd6538a38d8b963d4e79c6f4dae3e), [TaleWorlds.MountAndBlade.StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#a96540fc09a482d0c3069ccc4948b472b), and [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a844dd40143c1b38145851a8290c12d8b).


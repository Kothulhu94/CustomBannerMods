--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html ---

TaleWorlds.MountAndBlade.RangedSiegeWeaponAi.ThreatSeeker Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ThreatSeeker](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a4863a6d5e285b744281ac969efbbcb39) ([RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) weapon) |
| [Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) | [PrepareTargetFromTask](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a6696ce9145c9ee6ec1d00214a327a129) () |
| bool | [UpdateThreatSeekerTask](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#ac05bf49f83e4e58eb4a5adf1527f4b70) () |
| void | [PrepareThreatSeekerTask](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a7bb54e7a5e140a8e156dd6a335ccd7ce) (Action lastAction) |
| void | [Release](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a06036fa7ff861c9b3419feeff7f02788) () |
| List< [Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) > | [GetAllThreats](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a7830d872d0678b4448a16a8f957b82c1) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) | [GetTargetFlagsOfFormation](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a7441e45741ce8da364b3116cffc5390a) () |
| static [Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) | [GetMaxThreat](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a910da5a5f6c4641ffc5665b9faa3c459) (List< [ICastleKeyPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_castle_key_position.html) > castleKeyPositions) |

|  |  |
| --- | --- |
| Public Attributes | |
| [RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | [Weapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a736323855086d04883a3250f656a1451) |
| List< [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > | [WeaponPositions](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a642a023245a08a41ea551f94cd8c15b8) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a4863a6d5e285b744281ac969efbbcb39)ThreatSeeker()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.RangedSiegeWeaponAi.ThreatSeeker.ThreatSeeker | ( | [RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | *weapon* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a6696ce9145c9ee6ec1d00214a327a129)PrepareTargetFromTask()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) TaleWorlds.MountAndBlade.RangedSiegeWeaponAi.ThreatSeeker.PrepareTargetFromTask | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#ac05bf49f83e4e58eb4a5adf1527f4b70)UpdateThreatSeekerTask()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.RangedSiegeWeaponAi.ThreatSeeker.UpdateThreatSeekerTask | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a7bb54e7a5e140a8e156dd6a335ccd7ce)PrepareThreatSeekerTask()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.RangedSiegeWeaponAi.ThreatSeeker.PrepareThreatSeekerTask | ( | Action | *lastAction* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a06036fa7ff861c9b3419feeff7f02788)Release()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.RangedSiegeWeaponAi.ThreatSeeker.Release | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a7830d872d0678b4448a16a8f957b82c1)GetAllThreats()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) > TaleWorlds.MountAndBlade.RangedSiegeWeaponAi.ThreatSeeker.GetAllThreats | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a7441e45741ce8da364b3116cffc5390a)GetTargetFlagsOfFormation()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) TaleWorlds.MountAndBlade.RangedSiegeWeaponAi.ThreatSeeker.GetTargetFlagsOfFormation | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a910da5a5f6c4641ffc5665b9faa3c459)GetMaxThreat()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Threat](class_tale_worlds_1_1_mount_and_blade_1_1_threat.html) TaleWorlds.MountAndBlade.RangedSiegeWeaponAi.ThreatSeeker.GetMaxThreat | ( | List< [ICastleKeyPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_castle_key_position.html) > | *castleKeyPositions* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a736323855086d04883a3250f656a1451)Weapon
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) TaleWorlds.MountAndBlade.RangedSiegeWeaponAi.ThreatSeeker.Weapon |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai_1_1_threat_seeker.html#a642a023245a08a41ea551f94cd8c15b8)WeaponPositions
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)> TaleWorlds.MountAndBlade.RangedSiegeWeaponAi.ThreatSeeker.WeaponPositions |


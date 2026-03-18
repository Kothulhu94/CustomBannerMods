--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html ---

TaleWorlds.MountAndBlade.KillingBlow Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a0bde430c318ac3c54cdc184815674539) ([Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) ragdollImpulsePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) ragdollImpulseAmount, int deathAction, int weaponItemKind, [Agent.KillInfo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7) overrideKillInfo=[Agent.KillInfo.Invalid](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a4bbb8f967da6d1a610596d7257179c2b)) |
| bool | [IsHeadShot](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#ab11fe35b153706b1b26aa9e74b6c1843) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [RagdollImpulseLocalPoint](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#aa14729962dbab806f4050e5db7184ac1) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [RagdollImpulseAmount](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a4fc2913c707ee8c1c3321a710632dccf) |
| int | [DeathAction](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#ac05740c1873e9307cf15b5539f8f71d2) |
| [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | [DamageType](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a725b3b9223883f65f5cddda0540bab86) |
| [AgentAttackType](namespace_tale_worlds_1_1_core.html#a38b124473f5d2f7d9190f338db49e8bd) | [AttackType](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#aedf8b328518721261967c345fa359360) |
| int | [OwnerId](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a74c4f4687fe9759b910bd7aa1625c1c8) |
| [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) | [VictimBodyPart](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#aa6e63d344f6b3fe9d4b0dc6107ff1c60) |
| int | [WeaponClass](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a4994ccbdea13a3a5f6c3693d5e3eb79b) |
| [Agent.KillInfo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7) | [OverrideKillInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a189bc9ac2d34391a690bd1967641248e) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [BlowPosition](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#ab762438a8b0ee3dc076db9e387170eea) |
| [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | [WeaponRecordWeaponFlags](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a7265881dd776cc0976b1cdd5893f6cb5) |
| int | [WeaponItemKind](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a83ebb5239e1d8a370320e7d6d7ea5828) |
| int | [InflictedDamage](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#aff0b154a6ca5c6030a6905e4b91b679f) |
| bool | [IsMissile](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#ab4f55f43c9fa38b6fd5388fe2279f9cb) |
| bool | [IsValid](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a166e849c97db0c974d0367d804d64e1f) |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a0bde430c318ac3c54cdc184815674539)KillingBlow()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.KillingBlow.KillingBlow | ( | [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *b*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *ragdollImpulsePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *ragdollImpulseAmount*, |
|  |  | int | *deathAction*, |
|  |  | int | *weaponItemKind*, |
|  |  | [Agent.KillInfo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7) | *overrideKillInfo* = [Agent::KillInfo::Invalid](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a4bbb8f967da6d1a610596d7257179c2b) ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#ab11fe35b153706b1b26aa9e74b6c1843)IsHeadShot()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.KillingBlow.IsHeadShot | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#aa14729962dbab806f4050e5db7184ac1)RagdollImpulseLocalPoint
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.KillingBlow.RagdollImpulseLocalPoint |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a4fc2913c707ee8c1c3321a710632dccf)RagdollImpulseAmount
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.KillingBlow.RagdollImpulseAmount |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#ac05740c1873e9307cf15b5539f8f71d2)DeathAction
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.KillingBlow.DeathAction |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a725b3b9223883f65f5cddda0540bab86)DamageType
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) TaleWorlds.MountAndBlade.KillingBlow.DamageType |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#aedf8b328518721261967c345fa359360)AttackType
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [AgentAttackType](namespace_tale_worlds_1_1_core.html#a38b124473f5d2f7d9190f338db49e8bd) TaleWorlds.MountAndBlade.KillingBlow.AttackType |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a74c4f4687fe9759b910bd7aa1625c1c8)OwnerId
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.KillingBlow.OwnerId |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#aa6e63d344f6b3fe9d4b0dc6107ff1c60)VictimBodyPart
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) TaleWorlds.MountAndBlade.KillingBlow.VictimBodyPart |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a4994ccbdea13a3a5f6c3693d5e3eb79b)WeaponClass
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.KillingBlow.WeaponClass |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a189bc9ac2d34391a690bd1967641248e)OverrideKillInfo
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Agent.KillInfo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7) TaleWorlds.MountAndBlade.KillingBlow.OverrideKillInfo |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#ab762438a8b0ee3dc076db9e387170eea)BlowPosition
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.KillingBlow.BlowPosition |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a7265881dd776cc0976b1cdd5893f6cb5)WeaponRecordWeaponFlags
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) TaleWorlds.MountAndBlade.KillingBlow.WeaponRecordWeaponFlags |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a83ebb5239e1d8a370320e7d6d7ea5828)WeaponItemKind
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.KillingBlow.WeaponItemKind |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#aff0b154a6ca5c6030a6905e4b91b679f)InflictedDamage
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.KillingBlow.InflictedDamage |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#ab4f55f43c9fa38b6fd5388fe2279f9cb)IsMissile
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.KillingBlow.IsMissile |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html#a166e849c97db0c974d0367d804d64e1f)IsValid
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.KillingBlow.IsValid |


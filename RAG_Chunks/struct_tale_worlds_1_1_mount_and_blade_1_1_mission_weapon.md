--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html ---

TaleWorlds.MountAndBlade.MissionWeapon Struct Reference|  |  |
| --- | --- |
| Classes | |
| struct | [ImpactSoundModifier](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon_1_1_impact_sound_modifier.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnGetWeaponDataDelegate](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a35b6df59568b6e1f3de57ba721f3cc5e) (ref [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) weaponData, [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) weapon, bool isFemale, [Banner](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#af40adeeea58d18863ad05e79ac58a133) banner, bool needBatchedVersion) |
|  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [ItemModifier](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a9efc6f70a8790b839e635318347fa1a9) itemModifier, [Banner](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#af40adeeea58d18863ad05e79ac58a133) banner) |
|  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a5ab103f4d6970f835025648b7e48cfc8) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) primaryItem, [ItemModifier](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a9efc6f70a8790b839e635318347fa1a9) itemModifier, [Banner](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#af40adeeea58d18863ad05e79ac58a133) banner, short dataValue) |
|  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a565f99be5c6c7f85ab193fc060950386) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) primaryItem, [ItemModifier](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a9efc6f70a8790b839e635318347fa1a9) itemModifier, [Banner](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#af40adeeea58d18863ad05e79ac58a133) banner, short dataValue, short reloadPhase, MissionWeapon? ammoWeapon) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetModifiedItemName](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a337ebc5346d72ab4ffbc2a76c4d3e860) () |
| bool | [IsEqualTo](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a7cf8b5c7986b7fdef6b7a7d68cf09b4a) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) other) |
| bool | [IsSameType](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72f683aeafe799bbeaaa9523345a8240) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) other) |
| float | [GetWeight](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a53b08d2a25d4c9273b1e5f3a498fa0f8) () |
| [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | [GetWeaponComponentDataForUsage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aeaebe0728e92f421b7a7fcec625dc866) (int usageIndex) |
| int | [GetGetModifiedArmorForCurrentUsage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aef4652879a3499ebaa26f578c46269bc) () |
| int | [GetModifiedThrustDamageForCurrentUsage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a10294c3520736a995fc670cd285e7e68) () |
| int | [GetModifiedSwingDamageForCurrentUsage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ae6b10c6bb5e40fa7b98302fa8c244e04) () |
| int | [GetModifiedMissileDamageForCurrentUsage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a58f07c689349afcd150cf96a4795092b) () |
| int | [GetModifiedThrustSpeedForCurrentUsage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a494e8c0034183e56697056d34f4a4c6c) () |
| int | [GetModifiedSwingSpeedForCurrentUsage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a6cf85a2b1ad5f39a4458bc43ca7c51ae) () |
| int | [GetModifiedMissileSpeedForCurrentUsage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ad5d9f822ab44fefa9baf1a977bb7a4e4) () |
| int | [GetModifiedMissileSpeedForUsage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a6265e492def28771c50b36532a8ee567) (int usageIndex) |
| int | [GetModifiedHandlingForCurrentUsage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a17258a3fd5c2c859767dee673102c4cf) () |
| [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) | [GetWeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a2a19de8adc81182538c20161077fc258) (bool needBatchedVersionForMeshes) |
| [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html)[] | [GetWeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a56819a5ba1909d22970925382ce14e76) () |
| [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html) | [GetWeaponStatsDataForUsage](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ac9cf19235f08a2a4b8d9d6e54d076999) (int usageIndex) |
| [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) | [GetAmmoWeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a1d89571d9256173abda3bedb08c3417f) (bool needBatchedVersion) |
| [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html)[] | [GetAmmoWeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aabd03bdf18f853df9be7bdf17d02ff93) () |
| int | [GetAttachedWeaponsCount](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a725282d4803ac9eec173a5ec027570b7) () |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) | [GetAttachedWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aea85bab74d55942733aa81eea1c30781) (int attachmentIndex) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetAttachedWeaponFrame](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a214abd82b3eb91b8f17716cc00711671) (int attachmentIndex) |
| bool | [IsShield](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a19aecff6c235514464385d13fb27bd7d) () |
| bool | [IsBanner](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a2f00c638bdb7bb8feab5f10d9c4f0293) () |
| bool | [IsAnyAmmo](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a23cffc003dcdcd3f793037101c2d50f6) () |
| bool | [HasAnyUsageWithWeaponClass](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a2d773a108350a3bfb99f9b72bd7f77a6) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass) |
| bool | [HasAnyUsageWithAmmoClass](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a2acaa66dacfcce176b9a0509baae811e) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) ammoClass) |
| bool | [HasAllUsagesWithAnyWeaponFlag](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a08c2ab6695089b3104737baef3db5c53) ([WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) flags) |
| bool | [HasAnyUsageWithoutWeaponFlag](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ab1fb3f8fa0a3c1b7032ef00c0a9af3cd) ([WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) flags) |
| void | [GatherInformationFromWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aa052b59147b1ba60f027c441caac925b) (out bool weaponHasMelee, out bool weaponHasShield, out bool weaponHasPolearm, out bool weaponHasNonConsumableRanged, out bool weaponHasThrown, out [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) rangedAmmoClass) |
| bool | [GetConsumableIfAny](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ae47138ee700246e2edefec1889666930) (out [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) consumableWeapon) |
| bool | [IsAnyConsumable](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a7bf256f795f5a3fdddc3e45958f6b872) () |
| int | [GetRangedUsageIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#af331181045781da8535f76c9c416e96a) () |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) | [Consume](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a0d791769f8efab0de2e324ca3458225c) (short count) |
| void | [ConsumeAmmo](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a667edd0fde0a9e51327d5b82404e8ae8) (short count) |
| void | [SetAmmo](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aa0d6d03bb13c17b3f7f388fe106c46c1) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) ammoWeapon) |
| void | [ReloadAmmo](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a107d9f3d4d1e995093e985c6208e99e0) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) ammoWeapon, short reloadPhase) |
| void | [AttachWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a7f1d7959e12fd43bdb52850e7764fd5a) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) attachedWeapon, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) attachFrame) |
| void | [RemoveAttachedWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#add2a4546da079dc7eee8510addd19e2f) (int attachmentIndex) |
| bool | [HasEnoughSpaceForAmount](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a92e393a29b6a4b03a157c4e78d243ffc) (int amount) |
| void | [SetRandomGlossMultiplier](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a03d54a166bbc88602dd40074d1840883) (int seed) |
| void | [AddExtraModifiedMaxValue](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aea7d2322350f772ac8f0deb1c943ff26) (short extraValue) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [CurrentUsageIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aad5c78e4d026b091471643d31671a86c) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const short | [ReloadPhaseCountMax](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aa4fa963311103850f7e52fe5b35984ba) = 10 |
| static [OnGetWeaponDataDelegate](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a35b6df59568b6e1f3de57ba721f3cc5e) | [OnGetWeaponDataHandler](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#abec8d71549896490643d27c73236057e) |
| static readonly [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) | [Invalid](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a26d3d71eabed1cf76cba7d10c4d64a73) = new [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb)(null, null, null) |

|  |  |
| --- | --- |
| Properties | |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [Item](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ad13a5632a17a781232632a7a6d7dc9d7) `[get]` |
| ItemModifier | [ItemModifier](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a9efc6f70a8790b839e635318347fa1a9) `[get]` |
| int | [WeaponsCount](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a84dc8026a208c845d244ba7a3f60aec3) `[get]` |
| [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | [CurrentUsageItem](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a1c97c8108ef270c254e67e09075c6faf) `[get]` |
| short | [ReloadPhase](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a0de785d6e6dafed4ce88f039e462cd61) `[get, set]` |
| short | [ReloadPhaseCount](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a16bee3b356d95cdc41923f625fd17aa1) `[get]` |
| bool | [IsReloading](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a74e27b4358afa5fd444a87996cf8b314) `[get]` |
| Banner | [Banner](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#af40adeeea58d18863ad05e79ac58a133) `[get]` |
| float | [GlossMultiplier](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a68681beacd3a46404a9b1212306a10c1) `[get]` |
| short | [RawDataForNetwork](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aa2e28f5df1365d9760ab35d4c4624643) `[get]` |
| short | [HitPoints](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ac65c7d601e7639972b1bc38cd84268f4) `[get, set]` |
| short | [Amount](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ad08e5c393b69ca00d450b168a578478d) `[get, set]` |
| short | [Ammo](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a07edb5b14eafabcf0f17dc50df7cc5a1) `[get]` |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) | [AmmoWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a32bb38562015fa04104f0c6049560bfe) `[get]` |
| short | [MaxAmmo](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a1fcfccc098df9a8210391d428bf6ef93) `[get]` |
| short | [ModifiedMaxAmount](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a9b7b3599114a5564317bc362b89ccf12) `[get]` |
| short | [ModifiedMaxHitPoints](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a2773311182669919b66671b9a8bfca64) `[get]` |
| bool | [IsEmpty](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a0877344d9f6814f3ee3b20d682e61683) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb)MissionWeapon() [1/3]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionWeapon.MissionWeapon | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | [ItemModifier](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a9efc6f70a8790b839e635318347fa1a9) | *itemModifier*, |
|  |  | [Banner](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#af40adeeea58d18863ad05e79ac58a133) | *banner* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a5ab103f4d6970f835025648b7e48cfc8)MissionWeapon() [2/3]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionWeapon.MissionWeapon | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *primaryItem*, |
|  |  | [ItemModifier](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a9efc6f70a8790b839e635318347fa1a9) | *itemModifier*, |
|  |  | [Banner](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#af40adeeea58d18863ad05e79ac58a133) | *banner*, |
|  |  | short | *dataValue* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a565f99be5c6c7f85ab193fc060950386)MissionWeapon() [3/3]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionWeapon.MissionWeapon | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *primaryItem*, |
|  |  | [ItemModifier](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a9efc6f70a8790b839e635318347fa1a9) | *itemModifier*, |
|  |  | [Banner](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#af40adeeea58d18863ad05e79ac58a133) | *banner*, |
|  |  | short | *dataValue*, |
|  |  | short | *reloadPhase*, |
|  |  | MissionWeapon? | *ammoWeapon* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a35b6df59568b6e1f3de57ba721f3cc5e)OnGetWeaponDataDelegate()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MissionWeapon.OnGetWeaponDataDelegate | ( | ref [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) | *weaponData*, |
|  |  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) | *weapon*, |
|  |  | bool | *isFemale*, |
|  |  | [Banner](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#af40adeeea58d18863ad05e79ac58a133) | *banner*, |
|  |  | bool | *needBatchedVersion* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a337ebc5346d72ab4ffbc2a76c4d3e860)GetModifiedItemName()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.MissionWeapon.GetModifiedItemName | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a7cf8b5c7986b7fdef6b7a7d68cf09b4a)IsEqualTo()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionWeapon.IsEqualTo | ( | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) | *other* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72f683aeafe799bbeaaa9523345a8240)IsSameType()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionWeapon.IsSameType | ( | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) | *other* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a53b08d2a25d4c9273b1e5f3a498fa0f8)GetWeight()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MissionWeapon.GetWeight | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aeaebe0728e92f421b7a7fcec625dc866)GetWeaponComponentDataForUsage()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) TaleWorlds.MountAndBlade.MissionWeapon.GetWeaponComponentDataForUsage | ( | int | *usageIndex* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aef4652879a3499ebaa26f578c46269bc)GetGetModifiedArmorForCurrentUsage()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionWeapon.GetGetModifiedArmorForCurrentUsage | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a10294c3520736a995fc670cd285e7e68)GetModifiedThrustDamageForCurrentUsage()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionWeapon.GetModifiedThrustDamageForCurrentUsage | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ae6b10c6bb5e40fa7b98302fa8c244e04)GetModifiedSwingDamageForCurrentUsage()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionWeapon.GetModifiedSwingDamageForCurrentUsage | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a58f07c689349afcd150cf96a4795092b)GetModifiedMissileDamageForCurrentUsage()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionWeapon.GetModifiedMissileDamageForCurrentUsage | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a494e8c0034183e56697056d34f4a4c6c)GetModifiedThrustSpeedForCurrentUsage()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionWeapon.GetModifiedThrustSpeedForCurrentUsage | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a6cf85a2b1ad5f39a4458bc43ca7c51ae)GetModifiedSwingSpeedForCurrentUsage()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionWeapon.GetModifiedSwingSpeedForCurrentUsage | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ad5d9f822ab44fefa9baf1a977bb7a4e4)GetModifiedMissileSpeedForCurrentUsage()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionWeapon.GetModifiedMissileSpeedForCurrentUsage | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a6265e492def28771c50b36532a8ee567)GetModifiedMissileSpeedForUsage()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionWeapon.GetModifiedMissileSpeedForUsage | ( | int | *usageIndex* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a17258a3fd5c2c859767dee673102c4cf)GetModifiedHandlingForCurrentUsage()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionWeapon.GetModifiedHandlingForCurrentUsage | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a2a19de8adc81182538c20161077fc258)GetWeaponData()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) TaleWorlds.MountAndBlade.MissionWeapon.GetWeaponData | ( | bool | *needBatchedVersionForMeshes* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a56819a5ba1909d22970925382ce14e76)GetWeaponStatsData()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html)[] TaleWorlds.MountAndBlade.MissionWeapon.GetWeaponStatsData | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ac9cf19235f08a2a4b8d9d6e54d076999)GetWeaponStatsDataForUsage()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html) TaleWorlds.MountAndBlade.MissionWeapon.GetWeaponStatsDataForUsage | ( | int | *usageIndex* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a1d89571d9256173abda3bedb08c3417f)GetAmmoWeaponData()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WeaponData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_data.html) TaleWorlds.MountAndBlade.MissionWeapon.GetAmmoWeaponData | ( | bool | *needBatchedVersion* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aabd03bdf18f853df9be7bdf17d02ff93)GetAmmoWeaponStatsData()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WeaponStatsData](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_stats_data.html)[] TaleWorlds.MountAndBlade.MissionWeapon.GetAmmoWeaponStatsData | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a725282d4803ac9eec173a5ec027570b7)GetAttachedWeaponsCount()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionWeapon.GetAttachedWeaponsCount | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aea85bab74d55942733aa81eea1c30781)GetAttachedWeapon()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) TaleWorlds.MountAndBlade.MissionWeapon.GetAttachedWeapon | ( | int | *attachmentIndex* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a214abd82b3eb91b8f17716cc00711671)GetAttachedWeaponFrame()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.MissionWeapon.GetAttachedWeaponFrame | ( | int | *attachmentIndex* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a19aecff6c235514464385d13fb27bd7d)IsShield()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionWeapon.IsShield | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a2f00c638bdb7bb8feab5f10d9c4f0293)IsBanner()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionWeapon.IsBanner | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a23cffc003dcdcd3f793037101c2d50f6)IsAnyAmmo()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionWeapon.IsAnyAmmo | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a2d773a108350a3bfb99f9b72bd7f77a6)HasAnyUsageWithWeaponClass()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionWeapon.HasAnyUsageWithWeaponClass | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a2acaa66dacfcce176b9a0509baae811e)HasAnyUsageWithAmmoClass()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionWeapon.HasAnyUsageWithAmmoClass | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *ammoClass* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a08c2ab6695089b3104737baef3db5c53)HasAllUsagesWithAnyWeaponFlag()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionWeapon.HasAllUsagesWithAnyWeaponFlag | ( | [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | *flags* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ab1fb3f8fa0a3c1b7032ef00c0a9af3cd)HasAnyUsageWithoutWeaponFlag()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionWeapon.HasAnyUsageWithoutWeaponFlag | ( | [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | *flags* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aa052b59147b1ba60f027c441caac925b)GatherInformationFromWeapon()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionWeapon.GatherInformationFromWeapon | ( | out bool | *weaponHasMelee*, |
|  |  | out bool | *weaponHasShield*, |
|  |  | out bool | *weaponHasPolearm*, |
|  |  | out bool | *weaponHasNonConsumableRanged*, |
|  |  | out bool | *weaponHasThrown*, |
|  |  | out [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *rangedAmmoClass* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ae47138ee700246e2edefec1889666930)GetConsumableIfAny()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionWeapon.GetConsumableIfAny | ( | out [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *consumableWeapon* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a7bf256f795f5a3fdddc3e45958f6b872)IsAnyConsumable()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionWeapon.IsAnyConsumable | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#af331181045781da8535f76c9c416e96a)GetRangedUsageIndex()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionWeapon.GetRangedUsageIndex | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a0d791769f8efab0de2e324ca3458225c)Consume()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) TaleWorlds.MountAndBlade.MissionWeapon.Consume | ( | short | *count* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a667edd0fde0a9e51327d5b82404e8ae8)ConsumeAmmo()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionWeapon.ConsumeAmmo | ( | short | *count* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aa0d6d03bb13c17b3f7f388fe106c46c1)SetAmmo()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionWeapon.SetAmmo | ( | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) | *ammoWeapon* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a107d9f3d4d1e995093e985c6208e99e0)ReloadAmmo()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionWeapon.ReloadAmmo | ( | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) | *ammoWeapon*, |
|  |  | short | *reloadPhase* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a7f1d7959e12fd43bdb52850e7764fd5a)AttachWeapon()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionWeapon.AttachWeapon | ( | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) | *attachedWeapon*, |
|  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *attachFrame* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#add2a4546da079dc7eee8510addd19e2f)RemoveAttachedWeapon()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionWeapon.RemoveAttachedWeapon | ( | int | *attachmentIndex* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a92e393a29b6a4b03a157c4e78d243ffc)HasEnoughSpaceForAmount()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionWeapon.HasEnoughSpaceForAmount | ( | int | *amount* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a03d54a166bbc88602dd40074d1840883)SetRandomGlossMultiplier()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionWeapon.SetRandomGlossMultiplier | ( | int | *seed* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aea7d2322350f772ac8f0deb1c943ff26)AddExtraModifiedMaxValue()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionWeapon.AddExtraModifiedMaxValue | ( | short | *extraValue* | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aa4fa963311103850f7e52fe5b35984ba)ReloadPhaseCountMax
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const short TaleWorlds.MountAndBlade.MissionWeapon.ReloadPhaseCountMax = 10 | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#abec8d71549896490643d27c73236057e)OnGetWeaponDataHandler
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnGetWeaponDataDelegate](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a35b6df59568b6e1f3de57ba721f3cc5e) TaleWorlds.MountAndBlade.MissionWeapon.OnGetWeaponDataHandler | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a26d3d71eabed1cf76cba7d10c4d64a73)Invalid
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) TaleWorlds.MountAndBlade.MissionWeapon.Invalid = new [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb)(null, null, null) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aad5c78e4d026b091471643d31671a86c)CurrentUsageIndex
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.MissionWeapon.CurrentUsageIndex |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ad13a5632a17a781232632a7a6d7dc9d7)Item
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.MountAndBlade.MissionWeapon.Item | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a9efc6f70a8790b839e635318347fa1a9)ItemModifier
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ItemModifier TaleWorlds.MountAndBlade.MissionWeapon.ItemModifier | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a84dc8026a208c845d244ba7a3f60aec3)WeaponsCount
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionWeapon.WeaponsCount | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a1c97c8108ef270c254e67e09075c6faf)CurrentUsageItem
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) TaleWorlds.MountAndBlade.MissionWeapon.CurrentUsageItem | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a0de785d6e6dafed4ce88f039e462cd61)ReloadPhase
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.MountAndBlade.MissionWeapon.ReloadPhase | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a16bee3b356d95cdc41923f625fd17aa1)ReloadPhaseCount
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.MountAndBlade.MissionWeapon.ReloadPhaseCount | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a74e27b4358afa5fd444a87996cf8b314)IsReloading
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionWeapon.IsReloading | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#af40adeeea58d18863ad05e79ac58a133)Banner
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.MountAndBlade.MissionWeapon.Banner | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a68681beacd3a46404a9b1212306a10c1)GlossMultiplier
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MissionWeapon.GlossMultiplier | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#aa2e28f5df1365d9760ab35d4c4624643)RawDataForNetwork
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.MountAndBlade.MissionWeapon.RawDataForNetwork | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ac65c7d601e7639972b1bc38cd84268f4)HitPoints
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.MountAndBlade.MissionWeapon.HitPoints | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#ad08e5c393b69ca00d450b168a578478d)Amount
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.MountAndBlade.MissionWeapon.Amount | | getset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a07edb5b14eafabcf0f17dc50df7cc5a1)Ammo
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.MountAndBlade.MissionWeapon.Ammo | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a32bb38562015fa04104f0c6049560bfe)AmmoWeapon
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a72c2e9076f280c05f5e6153e9e390ccb) TaleWorlds.MountAndBlade.MissionWeapon.AmmoWeapon | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a1fcfccc098df9a8210391d428bf6ef93)MaxAmmo
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.MountAndBlade.MissionWeapon.MaxAmmo | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a9b7b3599114a5564317bc362b89ccf12)ModifiedMaxAmount
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.MountAndBlade.MissionWeapon.ModifiedMaxAmount | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a2773311182669919b66671b9a8bfca64)ModifiedMaxHitPoints
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.MountAndBlade.MissionWeapon.ModifiedMaxHitPoints | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html#a0877344d9f6814f3ee3b20d682e61683)IsEmpty
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionWeapon.IsEmpty | | get |


--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html ---

TaleWorlds.MountAndBlade.MissionEquipment Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a226aa50dc962e763dc0a8761b34174a0) () |
|  | [MissionEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a444bbc7c81576f2afa9a94e70029da95) ([Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) spawnEquipment, [Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner) |
| void | [FillFrom](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a8c65fa39e1b3be4dd4cded706f5efe2f) ([MissionEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a226aa50dc962e763dc0a8761b34174a0) sourceEquipment) |
| void | [FillFrom](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a3a757a07a222eb24bcb3d04fe8fb868f) ([Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) sourceEquipment, [Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner) |
| float | [GetTotalWeightOfWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a8dd730f55dc90083b6070fac1970ced7) () |
| bool | [HasAmmo](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ab7484804cd795e72ee9b8da854d70fd2) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equipmentIndex, out int rangedUsageIndex, out bool hasLoadedAmmo, out bool noAmmoInThisSlot) |
|  | Caution, unlike the convention in this class, will not only check if equipment includes a quiver(AmmoClass) item but will also check whether that item has positive quantity of ammunition(amount). |
| int | [GetAmmoAmount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a08bbc8f315fe307f25e7efd5619bc1a4) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) weaponIndex) |
| int | [GetMaxAmmo](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ade26add85ac63dc426c286165fdc8a10) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) weaponIndex) |
| void | [GetAmmoCountAndIndexOfType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ac532a09d0f9406ea72b5361086a5978a) ([ItemObject.ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) itemType, out int ammoCount, out [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) eIndex, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equippedIndex=EquipmentIndex.None) |
| void | [CheckLoadedAmmos](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ac23a15bba7c060c054641ac6e9a09644) () |
| void | [SetUsageIndexOfSlot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a49429f20e7c664755599f41a7fad926a) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, int usageIndex) |
| void | [SetReloadPhaseOfSlot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#acda6ed904604c66517a38cdcbe09e2cc) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, short reloadPhase) |
| void | [SetAmountOfSlot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a58f78d9a740762c92d3b7436f197a8c8) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, short dataValue, bool addOverflowToMaxAmount=false) |
| void | [SetHitPointsOfSlot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#aef84a58dd0e2bfc1e6d96275389dfb20) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, short dataValue, bool addOverflowToMaxHitPoints=false) |
| void | [SetReloadedAmmoOfSlot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ac22e2ecacf3eed9bad9327d9c3a75306) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) ammoSlotIndex, short totalAmmo) |
| void | [SetConsumedAmmoOfSlot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a5b492932ee4f9d84d4eceb672280dd39) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, short count) |
| void | [AttachWeaponToWeaponInSlot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a758641e07499f38233fb1d29d2c8d8e0) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, ref [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) attachLocalFrame) |
| bool | [HasShield](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ae4a5cd509220555bf1337ec156942ce1) () |
| bool | [HasAnyWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a6fa1af36a3a522ff3199729623f8969c) () |
| bool | [HasAnyWeaponWithFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a94556e91888673cc1c860539f705c464) ([WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) flags) |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetBanner](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#afa39df1e9f820b3cfee60fc2d2978729) () |
| bool | [HasRangedWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#aeb40b92fa2147a265762fc1bd62b37d4) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) requiredAmmoClass=WeaponClass.Undefined) |
| bool | [ContainsNonConsumableRangedWeaponWithAmmo](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a0e86230456786ec410d7b7cc631ca633) () |
| bool | [ContainsMeleeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a606336a5156b4c9ed2ab55ce9ee57fa9) () |
| bool | [ContainsShield](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a7866ce6f8b572d28bd0b68300ba0c5bb) () |
| bool | [ContainsSpear](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a0bee5d8e7215e332b6ee217203f052b8) () |
| bool | [ContainsThrownWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a887d0b72335f73b2bf06d4fc238ce5f9) () |
| void | [SetGlossMultipliersOfWeaponsRandomly](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a56e0f3d34b3fd92bd1561e7ee33db7eb) (int seed) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | [SelectWeaponPickUpSlot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a0fbcf48de5cd098889273a64f8e92464) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentPickingUp, [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weaponBeingPickedUp, bool isStuckMissile) |
| static bool | [DoesWeaponFitToSlot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ac3b57bcc8ffaa5d2caf5d3b22cf01920) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon) |

|  |  |
| --- | --- |
| Properties | |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | [this[int index]](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a5e31ce219d255fe1657a15d07ba8b394) `[get, set]` |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | [this[EquipmentIndex index]](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ae4af85682ef2cf51b7c028d1e4669670) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a226aa50dc962e763dc0a8761b34174a0)MissionEquipment() [1/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionEquipment.MissionEquipment | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a444bbc7c81576f2afa9a94e70029da95)MissionEquipment() [2/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionEquipment.MissionEquipment | ( | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *spawnEquipment*, |
|  |  | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | *banner* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a8c65fa39e1b3be4dd4cded706f5efe2f)FillFrom() [1/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionEquipment.FillFrom | ( | [MissionEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a226aa50dc962e763dc0a8761b34174a0) | *sourceEquipment* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a3a757a07a222eb24bcb3d04fe8fb868f)FillFrom() [2/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionEquipment.FillFrom | ( | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *sourceEquipment*, |
|  |  | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | *banner* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a8dd730f55dc90083b6070fac1970ced7)GetTotalWeightOfWeapons()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MissionEquipment.GetTotalWeightOfWeapons | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a0fbcf48de5cd098889273a64f8e92464)SelectWeaponPickUpSlot()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) TaleWorlds.MountAndBlade.MissionEquipment.SelectWeaponPickUpSlot | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agentPickingUp*, | |  |  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weaponBeingPickedUp*, | |  |  | bool | *isStuckMissile* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ab7484804cd795e72ee9b8da854d70fd2)HasAmmo()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionEquipment.HasAmmo | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equipmentIndex*, |
|  |  | out int | *rangedUsageIndex*, |
|  |  | out bool | *hasLoadedAmmo*, |
|  |  | out bool | *noAmmoInThisSlot* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a08bbc8f315fe307f25e7efd5619bc1a4)GetAmmoAmount()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionEquipment.GetAmmoAmount | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *weaponIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ade26add85ac63dc426c286165fdc8a10)GetMaxAmmo()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionEquipment.GetMaxAmmo | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *weaponIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ac532a09d0f9406ea72b5361086a5978a)GetAmmoCountAndIndexOfType()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionEquipment.GetAmmoCountAndIndexOfType | ( | [ItemObject.ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) | *itemType*, |
|  |  | out int | *ammoCount*, |
|  |  | out [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *eIndex*, |
|  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equippedIndex* = EquipmentIndex::None ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ac3b57bcc8ffaa5d2caf5d3b22cf01920)DoesWeaponFitToSlot()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MissionEquipment.DoesWeaponFitToSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, | |  |  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ac23a15bba7c060c054641ac6e9a09644)CheckLoadedAmmos()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionEquipment.CheckLoadedAmmos | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a49429f20e7c664755599f41a7fad926a)SetUsageIndexOfSlot()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionEquipment.SetUsageIndexOfSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | int | *usageIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#acda6ed904604c66517a38cdcbe09e2cc)SetReloadPhaseOfSlot()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionEquipment.SetReloadPhaseOfSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | short | *reloadPhase* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a58f78d9a740762c92d3b7436f197a8c8)SetAmountOfSlot()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionEquipment.SetAmountOfSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | short | *dataValue*, |
|  |  | bool | *addOverflowToMaxAmount* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#aef84a58dd0e2bfc1e6d96275389dfb20)SetHitPointsOfSlot()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionEquipment.SetHitPointsOfSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | short | *dataValue*, |
|  |  | bool | *addOverflowToMaxHitPoints* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ac22e2ecacf3eed9bad9327d9c3a75306)SetReloadedAmmoOfSlot()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionEquipment.SetReloadedAmmoOfSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *ammoSlotIndex*, |
|  |  | short | *totalAmmo* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a5b492932ee4f9d84d4eceb672280dd39)SetConsumedAmmoOfSlot()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionEquipment.SetConsumedAmmoOfSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | short | *count* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a758641e07499f38233fb1d29d2c8d8e0)AttachWeaponToWeaponInSlot()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionEquipment.AttachWeaponToWeaponInSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | ref [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *attachLocalFrame* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ae4a5cd509220555bf1337ec156942ce1)HasShield()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionEquipment.HasShield | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a6fa1af36a3a522ff3199729623f8969c)HasAnyWeapon()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionEquipment.HasAnyWeapon | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a94556e91888673cc1c860539f705c464)HasAnyWeaponWithFlags()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionEquipment.HasAnyWeaponWithFlags | ( | [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | *flags* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#afa39df1e9f820b3cfee60fc2d2978729)GetBanner()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.MountAndBlade.MissionEquipment.GetBanner | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#aeb40b92fa2147a265762fc1bd62b37d4)HasRangedWeapon()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionEquipment.HasRangedWeapon | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *requiredAmmoClass* = WeaponClass::Undefined | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a0e86230456786ec410d7b7cc631ca633)ContainsNonConsumableRangedWeaponWithAmmo()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionEquipment.ContainsNonConsumableRangedWeaponWithAmmo | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a606336a5156b4c9ed2ab55ce9ee57fa9)ContainsMeleeWeapon()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionEquipment.ContainsMeleeWeapon | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a7866ce6f8b572d28bd0b68300ba0c5bb)ContainsShield()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionEquipment.ContainsShield | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a0bee5d8e7215e332b6ee217203f052b8)ContainsSpear()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionEquipment.ContainsSpear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a887d0b72335f73b2bf06d4fc238ce5f9)ContainsThrownWeapon()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionEquipment.ContainsThrownWeapon | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a56e0f3d34b3fd92bd1561e7ee33db7eb)SetGlossMultipliersOfWeaponsRandomly()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionEquipment.SetGlossMultipliersOfWeaponsRandomly | ( | int | *seed* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#a5e31ce219d255fe1657a15d07ba8b394)this[int index]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) TaleWorlds.MountAndBlade.MissionEquipment.this[int index] | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html#ae4af85682ef2cf51b7c028d1e4669670)this[EquipmentIndex index]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) TaleWorlds.MountAndBlade.MissionEquipment.this[[EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) index] | | getset |


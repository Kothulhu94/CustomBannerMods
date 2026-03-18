--- SOURCE: class_tale_worlds_1_1_core_1_1_weapon_component_data.html ---

TaleWorlds.Core.WeaponComponentData Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [WeaponTiers](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa7b080eda3e819eff2f5f390fe2b535b) {     [Tier1](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa7b080eda3e819eff2f5f390fe2b535ba0fdf99ebbdcd0198744caa9b8c5c6ca4) ,     [Tier2](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa7b080eda3e819eff2f5f390fe2b535bad167d667548ae1364f67b9ce0b6918a5) ,     [Tier3](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa7b080eda3e819eff2f5f390fe2b535ba1fee01fe8bbe05778f82f32df56b0061) ,     [Tier4](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa7b080eda3e819eff2f5f390fe2b535ba7aac5960e1b9dacecffcf57aa0926010) ,     [Special](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa7b080eda3e819eff2f5f390fe2b535bab4c2b550635fe54fd29f2b64dfaca55d)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Init](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a90c284e249e33ed4f3cdbe9e3543681b) (string weaponUsageName, string physicsMaterial, string itemUsage, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) thrustDamageType, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) swingDamageType, int bodyArmor, int weaponLength, float weaponBalance, float inertia, float centerOfMass, int handling, float swingDamageFactor, float thrustDamageFactor, short maxDataValue, string passBySoundCode, int accuracy, int missileSpeed, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) stickingFrame, [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) ammoClass, float sweetSpot, int swingSpeed, int swingDamage, int thrustSpeed, int thrustDamage, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rotationSpeed, [WeaponTiers](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa7b080eda3e819eff2f5f390fe2b535b) tier, Int16 reloadPhaseCount) |
| void | [SetFrame](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#ad19d0080ddddff9d623698210d2f6745) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [SetAmmoOffset](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa640e1e7fad8c9242ac0527283c2b814) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) ammoOffset) |
|  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aafdc340da6b57ae0cf9645ecbe636a34) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass=[WeaponClass.Undefined](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61aec0fc0100c4fc1ce4eea230c3dc10360), [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) weaponFlags=0) |
| void | [Deserialize](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#adb8a8680699741fd9c8a3d0529e2d195) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, XmlNode node) |
| float | [GetRealWeaponLength](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a3128f03a109ae2ff8f3cd6717f23f5c2) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetMissileStartingFrame](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a3f5004956048253ab30feb368b15a354) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [GetRelevantSkillFromWeaponClass](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a05b63722e645a6342b87f4df0d4e1886) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass) |
| static [ItemObject.ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) | [GetItemTypeFromWeaponClass](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#adc61d8b1f62cb540ee443a4b62965b8e) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass) |

|  |  |
| --- | --- |
| Public Attributes | |
| [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | [WeaponFlags](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a3a9f0d1991c2736c969f5756f1d6c7dc) |

|  |  |
| --- | --- |
| Properties | |
| [WeaponTiers](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa7b080eda3e819eff2f5f390fe2b535b) | [WeaponTier](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a512fe901b897abef78830be0c70ee745) `[get]` |
| string | [WeaponDescriptionId](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#ad1f2707f065a77faa79ae0b7db2aa7a3) `[get]` |
| int | [BodyArmor](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a54bf4b24c9a2666b62eb2a1855993eea) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html). Do not use this without modifier check. |
| string | [PhysicsMaterial](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#adf7af5372fb83fb53e554d40c77bbcbf) `[get]` |
| string | [FlyingSoundCode](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a281939b2e6a416367aad08eeb2c4359b) `[get]` |
| string | [PassbySoundCode](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#af65f8891e66c61fe630ccb5ff640e14f) `[get]` |
| string | [ItemUsage](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a259c19a2624435f9ecedc8655e48aa4c) `[get]` |
| int | [ThrustSpeed](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a0f2b8ed27d87080f1ede722b3ba67f7b) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) and MissionWeapon. Do not use this without modifier check. |
| int | [SwingSpeed](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a656debb5a27ef55b5b4f6ccbdfab9605) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) and MissionWeapon. Do not use this without modifier check. |
| int | [MissileSpeed](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a9c879462db454d9ea37b978692356011) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) and MissionWeapon. Do not use this without modifier check. |
| int | [WeaponLength](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#adc9e1ca04a6fc141cca134177ba20ae5) `[get]` |
| float | [WeaponBalance](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a68f5447c75a60d6f60ae0261082924a0) `[get]` |
| int | [ThrustDamage](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#acaba013076bdf50e21ced6c7571bc5f6) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) and MissionWeapon. Do not use this without modifier check. |
| [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | [ThrustDamageType](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#ae42dab574e6548cb40584a09dbe62714) `[get]` |
| int | [SwingDamage](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a20e3cfb1a1d21d074f17bbcba55f5baa) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) and MissionWeapon. Do not use this without modifier check. |
| [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | [SwingDamageType](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa2037c3442d291a150361d47d05bf9db) `[get]` |
| int | [FireDamage](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa70c72deb88b846265b0622a24d2ebc8) `[get]` |
| int | [Accuracy](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a7eb30e2e6e95eb26b14d22cbbddd1ddc) `[get]` |
| [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | [WeaponClass](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa00a6fb29beba05390829d4178811765) `[get]` |
| [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | [AmmoClass](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a24a4599850779c4e024618dd3241bdaf) `[get]` |
| int | [MissileDamage](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a1e8d8c5c18884a9214885efefff04e71) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) and MissionWeapon. Do not use this without modifier check. |
| float | [TotalInertia](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a0bd0fdada1619e02c232e9db1367fdfb) `[get]` |
| float | [CenterOfMass](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a7e1294345faab74f259e4fcb1edf99a1) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CenterOfMass3D](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#ad89a025aa6d8a222d38bb4200df5ddb3) `[get]` |
| float | [SwingDamageFactor](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a4015305e0d620ef21c7227f296d4b09f) `[get]` |
| float | [ThrustDamageFactor](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a09620856e7f90e9bbf6fa98a3645e3c2) `[get]` |
| int | [Handling](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aebe84efb5a857df7b7d45faf584bbd35) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) and MissionWeapon. Do not use this without modifier check. |
| float | [SweetSpotReach](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a9995e5d4b5877161afc32e6bdb58f1fd) `[get]` |
| string | [TrailParticleName](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a909893cba3c9788a2b4c00d75ae43a96) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [StickingFrame](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#abc3b91370937b921d7a01f9df7313037) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [AmmoOffset](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#af2013d6bc254399bc1b953b25bae1f08) `[get]` |
| short | [MaxDataValue](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a2908f45f18ed155016586d373866f65f) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) and MissionWeapon. Do not use this without modifier check. |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [Frame](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a80a30b3fe3e68e8f933d44adfa206523) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [RotationSpeed](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a3b97c9cb53cdbdbe4bd760defbe36208) `[get]` |
| Int16 | [ReloadPhaseCount](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#acaf116daed128db7e1afe84cde4811ba) `[get]` |
| bool | [IsMeleeWeapon](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a0763fbf20cfb1086150675c01a4b61d1) `[get]` |
| bool | [IsRangedWeapon](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a3e2b7759fcb7682cec8b0ab7bb768a44) `[get]` |
| bool | [IsPolearm](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a3e522772916b1b41b4163176620d22d8) `[get]` |
| bool | [IsConsumable](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a4b66acb68c38d5dd838a5aeb1bd6c3fd) `[get]` |
| bool | [IsAmmo](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#ad5c02603e0d8f1edeac58e439f8d3654) `[get]` |
| bool | [IsShield](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a1af447a19b8481e22a92f602d34d9097) `[get]` |
| bool | [IsTwoHanded](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a76c4009fc4fb15254423c9cc253e189c) `[get]` |
| bool | [IsOneHanded](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a0a03afaac38289cc7658d3758f3f506e) `[get]` |
| bool | [IsBow](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#adc2362e7829ee18cda8083f944077de9) `[get]` |
| bool | [IsCrossBow](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aafd700d6d92dc998ed849abc6e648431) `[get]` |
| [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [RelevantSkill](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a14946b1b4ec7facb7c39ba8cbcfb2d31) `[get]` |
| bool | [CanHitMultipleTargets](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a290bb654cf68da86eda607f55532b0bc) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa7b080eda3e819eff2f5f390fe2b535b)WeaponTiers
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.WeaponComponentData.WeaponTiers](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa7b080eda3e819eff2f5f390fe2b535b) |

| Enumerator | |
| --- | --- |
| Tier1 |  |
| Tier2 |  |
| Tier3 |  |
| Tier4 |  |
| Special |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aafdc340da6b57ae0cf9645ecbe636a34)WeaponComponentData()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.WeaponComponentData.WeaponComponentData | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass* = [WeaponClass::Undefined](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61aec0fc0100c4fc1ce4eea230c3dc10360), |
|  |  | [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | *weaponFlags* = 0 ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a90c284e249e33ed4f3cdbe9e3543681b)Init()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.WeaponComponentData.Init | ( | string | *weaponUsageName*, |
|  |  | string | *physicsMaterial*, |
|  |  | string | *itemUsage*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *thrustDamageType*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *swingDamageType*, |
|  |  | int | *bodyArmor*, |
|  |  | int | *weaponLength*, |
|  |  | float | *weaponBalance*, |
|  |  | float | *inertia*, |
|  |  | float | *centerOfMass*, |
|  |  | int | *handling*, |
|  |  | float | *swingDamageFactor*, |
|  |  | float | *thrustDamageFactor*, |
|  |  | short | *maxDataValue*, |
|  |  | string | *passBySoundCode*, |
|  |  | int | *accuracy*, |
|  |  | int | *missileSpeed*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *stickingFrame*, |
|  |  | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *ammoClass*, |
|  |  | float | *sweetSpot*, |
|  |  | int | *swingSpeed*, |
|  |  | int | *swingDamage*, |
|  |  | int | *thrustSpeed*, |
|  |  | int | *thrustDamage*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rotationSpeed*, |
|  |  | [WeaponTiers](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa7b080eda3e819eff2f5f390fe2b535b) | *tier*, |
|  |  | Int16 | *reloadPhaseCount* ) |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#ad19d0080ddddff9d623698210d2f6745)SetFrame()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.WeaponComponentData.SetFrame | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa640e1e7fad8c9242ac0527283c2b814)SetAmmoOffset()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.WeaponComponentData.SetAmmoOffset | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *ammoOffset* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a05b63722e645a6342b87f4df0d4e1886)GetRelevantSkillFromWeaponClass()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) TaleWorlds.Core.WeaponComponentData.GetRelevantSkillFromWeaponClass | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#adc61d8b1f62cb540ee443a4b62965b8e)GetItemTypeFromWeaponClass()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ItemObject.ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) TaleWorlds.Core.WeaponComponentData.GetItemTypeFromWeaponClass | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#adb8a8680699741fd9c8a3d0529e2d195)Deserialize()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.WeaponComponentData.Deserialize | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | XmlNode | *node* ) |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a3128f03a109ae2ff8f3cd6717f23f5c2)GetRealWeaponLength()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Core.WeaponComponentData.GetRealWeaponLength | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a3f5004956048253ab30feb368b15a354)GetMissileStartingFrame()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Core.WeaponComponentData.GetMissileStartingFrame | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a3a9f0d1991c2736c969f5756f1d6c7dc)WeaponFlags
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) TaleWorlds.Core.WeaponComponentData.WeaponFlags |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a512fe901b897abef78830be0c70ee745)WeaponTier
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponTiers](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa7b080eda3e819eff2f5f390fe2b535b) TaleWorlds.Core.WeaponComponentData.WeaponTier | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#ad1f2707f065a77faa79ae0b7db2aa7a3)WeaponDescriptionId
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.WeaponComponentData.WeaponDescriptionId | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a54bf4b24c9a2666b62eb2a1855993eea)BodyArmor
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.WeaponComponentData.BodyArmor | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#adf7af5372fb83fb53e554d40c77bbcbf)PhysicsMaterial
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.WeaponComponentData.PhysicsMaterial | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a281939b2e6a416367aad08eeb2c4359b)FlyingSoundCode
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.WeaponComponentData.FlyingSoundCode | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#af65f8891e66c61fe630ccb5ff640e14f)PassbySoundCode
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.WeaponComponentData.PassbySoundCode | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a259c19a2624435f9ecedc8655e48aa4c)ItemUsage
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.WeaponComponentData.ItemUsage | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a0f2b8ed27d87080f1ede722b3ba67f7b)ThrustSpeed
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.WeaponComponentData.ThrustSpeed | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a656debb5a27ef55b5b4f6ccbdfab9605)SwingSpeed
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.WeaponComponentData.SwingSpeed | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a9c879462db454d9ea37b978692356011)MissileSpeed
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.WeaponComponentData.MissileSpeed | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#adc9e1ca04a6fc141cca134177ba20ae5)WeaponLength
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.WeaponComponentData.WeaponLength | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a68f5447c75a60d6f60ae0261082924a0)WeaponBalance
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponComponentData.WeaponBalance | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#acaba013076bdf50e21ced6c7571bc5f6)ThrustDamage
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.WeaponComponentData.ThrustDamage | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#ae42dab574e6548cb40584a09dbe62714)ThrustDamageType
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) TaleWorlds.Core.WeaponComponentData.ThrustDamageType | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a20e3cfb1a1d21d074f17bbcba55f5baa)SwingDamage
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.WeaponComponentData.SwingDamage | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa2037c3442d291a150361d47d05bf9db)SwingDamageType
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) TaleWorlds.Core.WeaponComponentData.SwingDamageType | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa70c72deb88b846265b0622a24d2ebc8)FireDamage
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.WeaponComponentData.FireDamage | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a7eb30e2e6e95eb26b14d22cbbddd1ddc)Accuracy
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.WeaponComponentData.Accuracy | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aa00a6fb29beba05390829d4178811765)WeaponClass
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) TaleWorlds.Core.WeaponComponentData.WeaponClass | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a24a4599850779c4e024618dd3241bdaf)AmmoClass
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) TaleWorlds.Core.WeaponComponentData.AmmoClass | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a1e8d8c5c18884a9214885efefff04e71)MissileDamage
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.WeaponComponentData.MissileDamage | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a0bd0fdada1619e02c232e9db1367fdfb)TotalInertia
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponComponentData.TotalInertia | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a7e1294345faab74f259e4fcb1edf99a1)CenterOfMass
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponComponentData.CenterOfMass | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#ad89a025aa6d8a222d38bb4200df5ddb3)CenterOfMass3D
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.WeaponComponentData.CenterOfMass3D | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a4015305e0d620ef21c7227f296d4b09f)SwingDamageFactor
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponComponentData.SwingDamageFactor | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a09620856e7f90e9bbf6fa98a3645e3c2)ThrustDamageFactor
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponComponentData.ThrustDamageFactor | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aebe84efb5a857df7b7d45faf584bbd35)Handling
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.WeaponComponentData.Handling | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a9995e5d4b5877161afc32e6bdb58f1fd)SweetSpotReach
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponComponentData.SweetSpotReach | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a909893cba3c9788a2b4c00d75ae43a96)TrailParticleName
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.WeaponComponentData.TrailParticleName | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#abc3b91370937b921d7a01f9df7313037)StickingFrame
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Core.WeaponComponentData.StickingFrame | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#af2013d6bc254399bc1b953b25bae1f08)AmmoOffset
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.WeaponComponentData.AmmoOffset | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a2908f45f18ed155016586d373866f65f)MaxDataValue
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.Core.WeaponComponentData.MaxDataValue | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a80a30b3fe3e68e8f933d44adfa206523)Frame
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Core.WeaponComponentData.Frame | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a3b97c9cb53cdbdbe4bd760defbe36208)RotationSpeed
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.WeaponComponentData.RotationSpeed | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#acaf116daed128db7e1afe84cde4811ba)ReloadPhaseCount
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Int16 TaleWorlds.Core.WeaponComponentData.ReloadPhaseCount | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a0763fbf20cfb1086150675c01a4b61d1)IsMeleeWeapon
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponComponentData.IsMeleeWeapon | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a3e2b7759fcb7682cec8b0ab7bb768a44)IsRangedWeapon
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponComponentData.IsRangedWeapon | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a3e522772916b1b41b4163176620d22d8)IsPolearm
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponComponentData.IsPolearm | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a4b66acb68c38d5dd838a5aeb1bd6c3fd)IsConsumable
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponComponentData.IsConsumable | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#ad5c02603e0d8f1edeac58e439f8d3654)IsAmmo
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponComponentData.IsAmmo | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a1af447a19b8481e22a92f602d34d9097)IsShield
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponComponentData.IsShield | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a76c4009fc4fb15254423c9cc253e189c)IsTwoHanded
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponComponentData.IsTwoHanded | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a0a03afaac38289cc7658d3758f3f506e)IsOneHanded
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponComponentData.IsOneHanded | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#adc2362e7829ee18cda8083f944077de9)IsBow
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponComponentData.IsBow | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#aafd700d6d92dc998ed849abc6e648431)IsCrossBow
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponComponentData.IsCrossBow | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a14946b1b4ec7facb7c39ba8cbcfb2d31)RelevantSkill
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) TaleWorlds.Core.WeaponComponentData.RelevantSkill | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_component_data.html#a290bb654cf68da86eda607f55532b0bc)CanHitMultipleTargets
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponComponentData.CanHitMultipleTargets | | get |


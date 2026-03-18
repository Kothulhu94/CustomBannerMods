--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html ---

TaleWorlds.MountAndBlade.FaceGen Class ReferenceInherits [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | [GetMonster](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a3a0dbc77b25bac2553ca35671e9b7bb3) (string monsterID) |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | [GetMonsterWithSuffix](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a0e9e27f85e5535e644b51fc36fbaea5e) (int race, string suffix) |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | [GetBaseMonsterFromRace](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a5c2b12175df4d997c7f263cd686bad16) (int race) |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetRandomBodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a424760fa5c1f0a248bb305749c071513) (int race, bool isFemale, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyPropertiesMin, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyPropertiesMax, int hairCoverType, int seed, string hairTags, string beardTags, string tattooTags, float variationAmount) |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyPropertiesWithAge](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a703cf24303e00bac3c10097b021a298e) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, float age) |
| void | [GetParamsFromBody](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a00b22cb7b2bf23bd2fed357485b91cab) (ref [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) faceGenerationParams, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, bool earsAreHidden, bool mouthIsHidden) |
| [BodyMeshMaturityType](namespace_tale_worlds_1_1_core.html#aa06b6ee7ceb44144d9586582b3ac0130) | [GetMaturityTypeWithAge](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a30a9c546d979bbbf92033908777bf36d) (float age) |
| int | [GetRaceCount](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#ae984be1ea49fc473e2b95f992393a28e) () |
| int | [GetRaceOrDefault](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a63b8551e5663936834abb57e32ee918d) (string raceId) |
| string | [GetBaseMonsterNameFromRace](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#aa0585ae8db2fbf5c598ddfca6d9c1afc) (int race) |
| string[] | [GetRaceNames](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a083b660a4ba4438b3c22360e77ab0ef2) () |
| int[] | [GetHairIndicesByTag](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a63f75a085d4a5ded092d20fa7a7cc1b7) (int race, int curGender, float age, string tag) |
| int[] | [GetFacialIndicesByTag](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#ad0aa1bdbca505f727d53e93235cf0737) (int race, int curGender, float age, string tag) |
| int[] | [GetTattooIndicesByTag](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#ae8ee0c61ba3fb3496475ac5346dbd5d6) (int race, int curGender, float age, string tag) |
| float | [GetTattooZeroProbability](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#aa719bb7551da49f32dbe00e4f50c83e2) (int race, int curGender, float age) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [CreateInstance](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#af011a743d313a0b99ed0ced38a48a58c) () |
| static void | [FlushFaceCache](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#aea64083595f54a977f57fe890663d85e) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#af011a743d313a0b99ed0ced38a48a58c)CreateInstance()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.FaceGen.CreateInstance | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a3a0dbc77b25bac2553ca35671e9b7bb3)GetMonster()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) TaleWorlds.MountAndBlade.FaceGen.GetMonster | ( | string | *monsterID* | ) |  |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a3f4ebb097da0c62cce231f783059729b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a0e9e27f85e5535e644b51fc36fbaea5e)GetMonsterWithSuffix()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) TaleWorlds.MountAndBlade.FaceGen.GetMonsterWithSuffix | ( | int | *race*, |
|  |  | string | *suffix* ) |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a7d5db8e5ee72bd9334553ae811e29eb7).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a5c2b12175df4d997c7f263cd686bad16)GetBaseMonsterFromRace()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) TaleWorlds.MountAndBlade.FaceGen.GetBaseMonsterFromRace | ( | int | *race* | ) |  |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a8ca34ae3839db51358bebb2f0a1dafb1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a424760fa5c1f0a248bb305749c071513)GetRandomBodyProperties()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.FaceGen.GetRandomBodyProperties | ( | int | *race*, |
|  |  | bool | *isFemale*, |
|  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyPropertiesMin*, |
|  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyPropertiesMax*, |
|  |  | int | *hairCoverType*, |
|  |  | int | *seed*, |
|  |  | string | *hairTags*, |
|  |  | string | *beardTags*, |
|  |  | string | *tattooTags*, |
|  |  | float | *variationAmount* ) |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#aee242ee62b518b6f6003165def2667fb).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a703cf24303e00bac3c10097b021a298e)GetBodyPropertiesWithAge()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.FaceGen.GetBodyPropertiesWithAge | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, |
|  |  | float | *age* ) |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#af7e71dda0887a0042dc22657b1221646).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a00b22cb7b2bf23bd2fed357485b91cab)GetParamsFromBody()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.FaceGen.GetParamsFromBody | ( | ref [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) | *faceGenerationParams*, |
|  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, |
|  |  | bool | *earsAreHidden*, |
|  |  | bool | *mouthIsHidden* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a30a9c546d979bbbf92033908777bf36d)GetMaturityTypeWithAge()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BodyMeshMaturityType](namespace_tale_worlds_1_1_core.html#aa06b6ee7ceb44144d9586582b3ac0130) TaleWorlds.MountAndBlade.FaceGen.GetMaturityTypeWithAge | ( | float | *age* | ) |  |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#af42918d96b1b116ce5d13a98d5b6ec1e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#aea64083595f54a977f57fe890663d85e)FlushFaceCache()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.FaceGen.FlushFaceCache | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#ae984be1ea49fc473e2b95f992393a28e)GetRaceCount()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.FaceGen.GetRaceCount | ( |  | ) |  |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#ad2084d99f0750000c3ac4904513c17ac).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a63b8551e5663936834abb57e32ee918d)GetRaceOrDefault()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.FaceGen.GetRaceOrDefault | ( | string | *raceId* | ) |  |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a789a8e16501713d714eb612584473611).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#aa0585ae8db2fbf5c598ddfca6d9c1afc)GetBaseMonsterNameFromRace()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.FaceGen.GetBaseMonsterNameFromRace | ( | int | *race* | ) |  |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a6cda4f1d1c364771b06448b12c7fd610).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a083b660a4ba4438b3c22360e77ab0ef2)GetRaceNames()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string[] TaleWorlds.MountAndBlade.FaceGen.GetRaceNames | ( |  | ) |  |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a4db18d0bcf707c68a00f31e6b3f99600).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a63f75a085d4a5ded092d20fa7a7cc1b7)GetHairIndicesByTag()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int[] TaleWorlds.MountAndBlade.FaceGen.GetHairIndicesByTag | ( | int | *race*, |
|  |  | int | *curGender*, |
|  |  | float | *age*, |
|  |  | string | *tag* ) |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a4d80e3caea28db68f61362c2a0fc0023).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#ad0aa1bdbca505f727d53e93235cf0737)GetFacialIndicesByTag()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int[] TaleWorlds.MountAndBlade.FaceGen.GetFacialIndicesByTag | ( | int | *race*, |
|  |  | int | *curGender*, |
|  |  | float | *age*, |
|  |  | string | *tag* ) |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a536d127df1ba5e79d5907a248da4485f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#ae8ee0c61ba3fb3496475ac5346dbd5d6)GetTattooIndicesByTag()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int[] TaleWorlds.MountAndBlade.FaceGen.GetTattooIndicesByTag | ( | int | *race*, |
|  |  | int | *curGender*, |
|  |  | float | *age*, |
|  |  | string | *tag* ) |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a48b0e47dfa51da6692c6a52bb99a0647).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#aa719bb7551da49f32dbe00e4f50c83e2)GetTattooZeroProbability()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.FaceGen.GetTattooZeroProbability | ( | int | *race*, |
|  |  | int | *curGender*, |
|  |  | float | *age* ) |

Implements [TaleWorlds.Core.IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a06a375cd6a568332ccfa1575eb44fc3d).


--- SOURCE: interface_tale_worlds_1_1_core_1_1_i_face_gen.html ---

TaleWorlds.Core.IFaceGen Interface ReferenceInherited by [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetRandomBodyProperties](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#aee242ee62b518b6f6003165def2667fb) (int race, bool isFemale, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyPropertiesMin, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyPropertiesMax, int hairCoverType, int seed, string hairTags, string beardTags, string tatooTags, float variationAmount) |
| void | [GenerateParentBody](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#af40ab96d29c0010dae11152f14ead299) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) childBodyProperties, int race, ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) motherBodyProperties, ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) fatherBodyProperties) |
| void | [SetBody](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a2972b13e627c9bf476bb22f401717931) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, int build, int weight) |
| void | [SetHair](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a7cd0d8c75af064b9aa4a44aa7ff67a9f) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, int hair, int beard, int tattoo) |
| void | [SetPigmentation](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a640c0feeb172fcf4b1708eab685aa22d) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, int skinColor, int hairColor, int eyeColor) |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyPropertiesWithAge](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#af7e71dda0887a0042dc22657b1221646) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, float age) |
| [BodyMeshMaturityType](namespace_tale_worlds_1_1_core.html#aa06b6ee7ceb44144d9586582b3ac0130) | [GetMaturityTypeWithAge](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#af42918d96b1b116ce5d13a98d5b6ec1e) (float age) |
| int | [GetRaceCount](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#ad2084d99f0750000c3ac4904513c17ac) () |
| int | [GetRaceOrDefault](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a789a8e16501713d714eb612584473611) (string raceId) |
| string | [GetBaseMonsterNameFromRace](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a6cda4f1d1c364771b06448b12c7fd610) (int race) |
| string[] | [GetRaceNames](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a4db18d0bcf707c68a00f31e6b3f99600) () |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | [GetMonster](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a3f4ebb097da0c62cce231f783059729b) (string monsterID) |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | [GetMonsterWithSuffix](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a7d5db8e5ee72bd9334553ae811e29eb7) (int race, string suffix) |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | [GetBaseMonsterFromRace](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a8ca34ae3839db51358bebb2f0a1dafb1) (int race) |
| int[] | [GetHairIndicesByTag](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a4d80e3caea28db68f61362c2a0fc0023) (int race, int curGender, float age, string tag) |
| int[] | [GetFacialIndicesByTag](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a536d127df1ba5e79d5907a248da4485f) (int race, int curGender, float age, string tag) |
| int[] | [GetTattooIndicesByTag](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a48b0e47dfa51da6692c6a52bb99a0647) (int race, int curGender, float age, string tag) |
| float | [GetTattooZeroProbability](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a06a375cd6a568332ccfa1575eb44fc3d) (int race, int curGender, float age) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#aee242ee62b518b6f6003165def2667fb)GetRandomBodyProperties()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.Core.IFaceGen.GetRandomBodyProperties | ( | int | *race*, |
|  |  | bool | *isFemale*, |
|  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyPropertiesMin*, |
|  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyPropertiesMax*, |
|  |  | int | *hairCoverType*, |
|  |  | int | *seed*, |
|  |  | string | *hairTags*, |
|  |  | string | *beardTags*, |
|  |  | string | *tatooTags*, |
|  |  | float | *variationAmount* ) |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a424760fa5c1f0a248bb305749c071513).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#af40ab96d29c0010dae11152f14ead299)GenerateParentBody()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.IFaceGen.GenerateParentBody | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *childBodyProperties*, |
|  |  | int | *race*, |
|  |  | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *motherBodyProperties*, |
|  |  | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *fatherBodyProperties* ) |

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a2972b13e627c9bf476bb22f401717931)SetBody()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.IFaceGen.SetBody | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, |
|  |  | int | *build*, |
|  |  | int | *weight* ) |

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a7cd0d8c75af064b9aa4a44aa7ff67a9f)SetHair()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.IFaceGen.SetHair | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, |
|  |  | int | *hair*, |
|  |  | int | *beard*, |
|  |  | int | *tattoo* ) |

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a640c0feeb172fcf4b1708eab685aa22d)SetPigmentation()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.IFaceGen.SetPigmentation | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, |
|  |  | int | *skinColor*, |
|  |  | int | *hairColor*, |
|  |  | int | *eyeColor* ) |

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#af7e71dda0887a0042dc22657b1221646)GetBodyPropertiesWithAge()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.Core.IFaceGen.GetBodyPropertiesWithAge | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, |
|  |  | float | *age* ) |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a703cf24303e00bac3c10097b021a298e).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#af42918d96b1b116ce5d13a98d5b6ec1e)GetMaturityTypeWithAge()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BodyMeshMaturityType](namespace_tale_worlds_1_1_core.html#aa06b6ee7ceb44144d9586582b3ac0130) TaleWorlds.Core.IFaceGen.GetMaturityTypeWithAge | ( | float | *age* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a30a9c546d979bbbf92033908777bf36d).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#ad2084d99f0750000c3ac4904513c17ac)GetRaceCount()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Core.IFaceGen.GetRaceCount | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#ae984be1ea49fc473e2b95f992393a28e).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a789a8e16501713d714eb612584473611)GetRaceOrDefault()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.IFaceGen.GetRaceOrDefault | ( | string | *raceId* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a63b8551e5663936834abb57e32ee918d).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a6cda4f1d1c364771b06448b12c7fd610)GetBaseMonsterNameFromRace()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Core.IFaceGen.GetBaseMonsterNameFromRace | ( | int | *race* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#aa0585ae8db2fbf5c598ddfca6d9c1afc).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a4db18d0bcf707c68a00f31e6b3f99600)GetRaceNames()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string[] TaleWorlds.Core.IFaceGen.GetRaceNames | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a083b660a4ba4438b3c22360e77ab0ef2).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a3f4ebb097da0c62cce231f783059729b)GetMonster()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) TaleWorlds.Core.IFaceGen.GetMonster | ( | string | *monsterID* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a3a0dbc77b25bac2553ca35671e9b7bb3).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a7d5db8e5ee72bd9334553ae811e29eb7)GetMonsterWithSuffix()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) TaleWorlds.Core.IFaceGen.GetMonsterWithSuffix | ( | int | *race*, |
|  |  | string | *suffix* ) |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a0e9e27f85e5535e644b51fc36fbaea5e).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a8ca34ae3839db51358bebb2f0a1dafb1)GetBaseMonsterFromRace()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) TaleWorlds.Core.IFaceGen.GetBaseMonsterFromRace | ( | int | *race* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a5c2b12175df4d997c7f263cd686bad16).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a4d80e3caea28db68f61362c2a0fc0023)GetHairIndicesByTag()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int[] TaleWorlds.Core.IFaceGen.GetHairIndicesByTag | ( | int | *race*, |
|  |  | int | *curGender*, |
|  |  | float | *age*, |
|  |  | string | *tag* ) |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#a63f75a085d4a5ded092d20fa7a7cc1b7).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a536d127df1ba5e79d5907a248da4485f)GetFacialIndicesByTag()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int[] TaleWorlds.Core.IFaceGen.GetFacialIndicesByTag | ( | int | *race*, |
|  |  | int | *curGender*, |
|  |  | float | *age*, |
|  |  | string | *tag* ) |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#ad0aa1bdbca505f727d53e93235cf0737).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a48b0e47dfa51da6692c6a52bb99a0647)GetTattooIndicesByTag()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int[] TaleWorlds.Core.IFaceGen.GetTattooIndicesByTag | ( | int | *race*, |
|  |  | int | *curGender*, |
|  |  | float | *age*, |
|  |  | string | *tag* ) |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#ae8ee0c61ba3fb3496475ac5346dbd5d6).

[◆](interface_tale_worlds_1_1_core_1_1_i_face_gen.html#a06a375cd6a568332ccfa1575eb44fc3d)GetTattooZeroProbability()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.Core.IFaceGen.GetTattooZeroProbability | ( | int | *race*, |
|  |  | int | *curGender*, |
|  |  | float | *age* ) |

Implemented in [TaleWorlds.MountAndBlade.FaceGen](class_tale_worlds_1_1_mount_and_blade_1_1_face_gen.html#aa719bb7551da49f32dbe00e4f50c83e2).


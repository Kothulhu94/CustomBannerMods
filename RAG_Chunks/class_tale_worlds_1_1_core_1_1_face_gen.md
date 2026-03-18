--- SOURCE: class_tale_worlds_1_1_core_1_1_face_gen.html ---

TaleWorlds.Core.FaceGen Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SetInstance](class_tale_worlds_1_1_core_1_1_face_gen.html#a6ac48d29049db259c9fd15e11e13e7dc) ([IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html) faceGen) |
| static [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetRandomBodyProperties](class_tale_worlds_1_1_core_1_1_face_gen.html#aab619515c725adba690032690f22fba2) (int race, bool isFemale, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyPropertiesMin, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyPropertiesMax, int hairCoverType, int seed, string hairTags, string beardTags, string tatooTags, float variationAmount) |
| static int | [GetRaceCount](class_tale_worlds_1_1_core_1_1_face_gen.html#a1ad8c1c41a3c335abb65118d27f5328e) () |
| static int | [GetRaceOrDefault](class_tale_worlds_1_1_core_1_1_face_gen.html#a67f7fd9523524b7272e3dfee5eca2655) (string raceId) |
| static string | [GetBaseMonsterNameFromRace](class_tale_worlds_1_1_core_1_1_face_gen.html#a31ecfacd382e90d38a1c2c2983b8910b) (int race) |
| static string[] | [GetRaceNames](class_tale_worlds_1_1_core_1_1_face_gen.html#a9263180fb206f942fd34b7b7363218e7) () |
| static [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | [GetMonster](class_tale_worlds_1_1_core_1_1_face_gen.html#a454a66c5afb9037da4fc148f5c16d578) (string monsterID) |
| static [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | [GetMonsterWithSuffix](class_tale_worlds_1_1_core_1_1_face_gen.html#a464b07ebc8ee9d3892402e5e77e7704e) (int race, string suffix) |
| static [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | [GetBaseMonsterFromRace](class_tale_worlds_1_1_core_1_1_face_gen.html#aa800e4478ded2b59ae619e3456ea2e97) (int race) |
| static void | [GenerateParentKey](class_tale_worlds_1_1_core_1_1_face_gen.html#a98f5b47e990887bf027475e7ad7ad2df) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) childBodyProperties, int race, ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) motherBodyProperties, ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) fatherBodyProperties) |
| static void | [SetHair](class_tale_worlds_1_1_core_1_1_face_gen.html#a0da70b26d173bd5c1c7973493a8876fb) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, int hair, int beard, int tattoo) |
| static void | [SetBody](class_tale_worlds_1_1_core_1_1_face_gen.html#a44ccd8969296b17d546d1f4fd1f93402) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, int build, int weight) |
| static void | [SetPigmentation](class_tale_worlds_1_1_core_1_1_face_gen.html#a50fee651c8e18031e3d22f26823b1fc1) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, int skinColor, int hairColor, int eyeColor) |
| static [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyPropertiesWithAge](class_tale_worlds_1_1_core_1_1_face_gen.html#a676b201e6faeefdfeed9b2132212d5e5) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) originalBodyProperties, float age) |
| static [BodyMeshMaturityType](namespace_tale_worlds_1_1_core.html#aa06b6ee7ceb44144d9586582b3ac0130) | [GetMaturityTypeWithAge](class_tale_worlds_1_1_core_1_1_face_gen.html#a333fda6e514127f0945d76b2e342ff75) (float age) |
| static int[] | [GetHairIndicesByTag](class_tale_worlds_1_1_core_1_1_face_gen.html#a7c6954e10174926b1f4fb980c500e5e9) (int race, int curGender, float age, string tag) |
| static int[] | [GetFacialIndicesByTag](class_tale_worlds_1_1_core_1_1_face_gen.html#abf270218005bb09060263e305b89caed) (int race, int curGender, float age, string tag) |
| static int[] | [GetTattooIndicesByTag](class_tale_worlds_1_1_core_1_1_face_gen.html#aa6032362f1f9d3e166ab23cb687d193c) (int race, int curGender, float age, string tag) |
| static float | [GetTattooZeroProbability](class_tale_worlds_1_1_core_1_1_face_gen.html#a12380d0e47889d11b4f46e624d3f215c) (int race, int curGender, float age) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [MonsterSuffixSettlement](class_tale_worlds_1_1_core_1_1_face_gen.html#add4351709d59e65bbeb8ea1c0925f884) = "\_settlement" |
| const string | [MonsterSuffixSettlementSlow](class_tale_worlds_1_1_core_1_1_face_gen.html#aa8f47d55ab12774f34da053ca4c91b5c) = "\_settlement\_slow" |
| const string | [MonsterSuffixSettlementFast](class_tale_worlds_1_1_core_1_1_face_gen.html#a122a3e7e2b0e9221d572c8f6a07f5633) = "\_settlement\_fast" |
| const string | [MonsterSuffixChild](class_tale_worlds_1_1_core_1_1_face_gen.html#a6130c006b5ac78e81e2b0bccc76c39ba) = "\_child" |
| static bool | [ShowDebugValues](class_tale_worlds_1_1_core_1_1_face_gen.html#a19cf0c49d80a6716737a789ad72d3827) |
| static bool | [UpdateDeformKeys](class_tale_worlds_1_1_core_1_1_face_gen.html#a162c723fc564d4132b086ca680a0a63e) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a6ac48d29049db259c9fd15e11e13e7dc)SetInstance()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.FaceGen.SetInstance | ( | [IFaceGen](interface_tale_worlds_1_1_core_1_1_i_face_gen.html) | *faceGen* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#aab619515c725adba690032690f22fba2)GetRandomBodyProperties()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.Core.FaceGen.GetRandomBodyProperties | ( | int | *race*, | |  |  | bool | *isFemale*, | |  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyPropertiesMin*, | |  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyPropertiesMax*, | |  |  | int | *hairCoverType*, | |  |  | int | *seed*, | |  |  | string | *hairTags*, | |  |  | string | *beardTags*, | |  |  | string | *tatooTags*, | |  |  | float | *variationAmount* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a1ad8c1c41a3c335abb65118d27f5328e)GetRaceCount()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Core.FaceGen.GetRaceCount | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a67f7fd9523524b7272e3dfee5eca2655)GetRaceOrDefault()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Core.FaceGen.GetRaceOrDefault | ( | string | *raceId* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a31ecfacd382e90d38a1c2c2983b8910b)GetBaseMonsterNameFromRace()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Core.FaceGen.GetBaseMonsterNameFromRace | ( | int | *race* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a9263180fb206f942fd34b7b7363218e7)GetRaceNames()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string[] TaleWorlds.Core.FaceGen.GetRaceNames | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a454a66c5afb9037da4fc148f5c16d578)GetMonster()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Monster](class_tale_worlds_1_1_core_1_1_monster.html) TaleWorlds.Core.FaceGen.GetMonster | ( | string | *monsterID* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a464b07ebc8ee9d3892402e5e77e7704e)GetMonsterWithSuffix()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Monster](class_tale_worlds_1_1_core_1_1_monster.html) TaleWorlds.Core.FaceGen.GetMonsterWithSuffix | ( | int | *race*, | |  |  | string | *suffix* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#aa800e4478ded2b59ae619e3456ea2e97)GetBaseMonsterFromRace()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Monster](class_tale_worlds_1_1_core_1_1_monster.html) TaleWorlds.Core.FaceGen.GetBaseMonsterFromRace | ( | int | *race* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a98f5b47e990887bf027475e7ad7ad2df)GenerateParentKey()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.FaceGen.GenerateParentKey | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *childBodyProperties*, | |  |  | int | *race*, | |  |  | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *motherBodyProperties*, | |  |  | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *fatherBodyProperties* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a0da70b26d173bd5c1c7973493a8876fb)SetHair()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.FaceGen.SetHair | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, | |  |  | int | *hair*, | |  |  | int | *beard*, | |  |  | int | *tattoo* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a44ccd8969296b17d546d1f4fd1f93402)SetBody()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.FaceGen.SetBody | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, | |  |  | int | *build*, | |  |  | int | *weight* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a50fee651c8e18031e3d22f26823b1fc1)SetPigmentation()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.FaceGen.SetPigmentation | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, | |  |  | int | *skinColor*, | |  |  | int | *hairColor*, | |  |  | int | *eyeColor* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a676b201e6faeefdfeed9b2132212d5e5)GetBodyPropertiesWithAge()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.Core.FaceGen.GetBodyPropertiesWithAge | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *originalBodyProperties*, | |  |  | float | *age* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a333fda6e514127f0945d76b2e342ff75)GetMaturityTypeWithAge()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [BodyMeshMaturityType](namespace_tale_worlds_1_1_core.html#aa06b6ee7ceb44144d9586582b3ac0130) TaleWorlds.Core.FaceGen.GetMaturityTypeWithAge | ( | float | *age* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a7c6954e10174926b1f4fb980c500e5e9)GetHairIndicesByTag()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int[] TaleWorlds.Core.FaceGen.GetHairIndicesByTag | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | float | *age*, | |  |  | string | *tag* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#abf270218005bb09060263e305b89caed)GetFacialIndicesByTag()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int[] TaleWorlds.Core.FaceGen.GetFacialIndicesByTag | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | float | *age*, | |  |  | string | *tag* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#aa6032362f1f9d3e166ab23cb687d193c)GetTattooIndicesByTag()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int[] TaleWorlds.Core.FaceGen.GetTattooIndicesByTag | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | float | *age*, | |  |  | string | *tag* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a12380d0e47889d11b4f46e624d3f215c)GetTattooZeroProbability()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Core.FaceGen.GetTattooZeroProbability | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | float | *age* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#add4351709d59e65bbeb8ea1c0925f884)MonsterSuffixSettlement
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.Core.FaceGen.MonsterSuffixSettlement = "\_settlement" | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#aa8f47d55ab12774f34da053ca4c91b5c)MonsterSuffixSettlementSlow
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.Core.FaceGen.MonsterSuffixSettlementSlow = "\_settlement\_slow" | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a122a3e7e2b0e9221d572c8f6a07f5633)MonsterSuffixSettlementFast
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.Core.FaceGen.MonsterSuffixSettlementFast = "\_settlement\_fast" | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a6130c006b5ac78e81e2b0bccc76c39ba)MonsterSuffixChild
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.Core.FaceGen.MonsterSuffixChild = "\_child" | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a19cf0c49d80a6716737a789ad72d3827)ShowDebugValues
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.FaceGen.ShowDebugValues | | static |

[◆](class_tale_worlds_1_1_core_1_1_face_gen.html#a162c723fc564d4132b086ca680a0a63e)UpdateDeformKeys
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.FaceGen.UpdateDeformKeys | | static |


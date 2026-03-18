--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html ---

TaleWorlds.MountAndBlade.MBBodyProperties Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [GenerationType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ab6494509d3771d1f4d15dd88ac0aa562) {     [FromMother](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ab6494509d3771d1f4d15dd88ac0aa562a4f55b690e92c0f2e2164b4e04a900a0f) ,     [FromFather](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ab6494509d3771d1f4d15dd88ac0aa562a49cdcfdcb020acd8a25ebdf7ecab8c1e) ,     [Count](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ab6494509d3771d1f4d15dd88ac0aa562ae93f994f01c537c4e2f7d8528c3eb5e9)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GetNumEditableDeformKeys](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aa6bd97d38f141bf80f2e08834e08e1ee) (int race, bool initialGender, int age) |
| static void | [GetParamsFromKey](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a1a8401d27f0bd71c8bb8c99e19808275) (ref [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) faceGenerationParams, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, bool earsAreHidden, bool mouthHidden) |
| static void | [GetParamsMax](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ac853544b71d92d6aa9d2d5526eb1b5db) (int race, int curGender, int curAge, ref int hairNum, ref int beardNum, ref int faceTextureNum, ref int mouthTextureNum, ref int faceTattooNum, ref int soundNum, ref int eyebrowNum, ref float scale) |
| static void | [GetZeroProbabilities](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aa8bf61354dad62c30641f127b8012acf) (int race, int curGender, float curAge, ref float tattooZeroProbability) |
| static void | [ProduceNumericKeyWithParams](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a3965528bb61161d4c18a34cccb4564eb) ([FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) faceGenerationParams, bool earsAreHidden, bool mouthIsHidden, ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties) |
| static void | [TransformFaceKeysToDefaultFace](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a35789d9c033277628fc7307fb41e8870) (ref [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) faceGenerationParams) |
| static void | [ProduceNumericKeyWithDefaultValues](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aebec0072d4d5a2520f0dd45fabbba0fe) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) initialBodyProperties, bool earsAreHidden, bool mouthIsHidden, int race, int gender, int age) |
| static [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetRandomBodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a0d585c6390a640a2d55022d9899931c8) (int race, bool isFemale, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyPropertiesMin, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyPropertiesMax, int hairCoverType, int seed, string hairTags, string beardTags, string tatooTags, float variationAmount) |
| static [DeformKeyData](struct_tale_worlds_1_1_mount_and_blade_1_1_deform_key_data.html) | [GetDeformKeyData](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a4802b46844610fc9487e453e6ae04463) (int keyNo, int race, int gender, int age) |
| static int | [GetFaceGenInstancesLength](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ac1ca607ec8145029e7b546a68a37f72b) (int race, int gender, int age) |
| static bool | [EnforceConstraints](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aa7a884ba2693e3788eb55ca5977d3d26) (ref [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) faceGenerationParams) |
| static float | [GetScaleFromKey](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a9b9f28d7a72833e25eba6983eebc0c2b) (int race, int gender, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties) |
| static int | [GetHairColorCount](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a0d2ff6118448f04942828c0860a00d89) (int race, int curGender, int age) |
| static List< UInt32 > | [GetHairColorGradientPoints](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aadb6bc6f9aa54fe3922f579b5fb407b6) (int race, int curGender, int age) |
| static int | [GetTatooColorCount](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a292e103ab4b689206de70fbd83035c51) (int race, int curGender, int age) |
| static List< uint > | [GetTatooColorGradientPoints](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a78119d14834c548b4014c7035358272b) (int race, int curGender, int age) |
| static int | [GetSkinColorCount](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a169d3715e3cd3e8063cd1e54d5595fd5) (int race, int curGender, int age) |
| static [BodyMeshMaturityType](namespace_tale_worlds_1_1_core.html#aa06b6ee7ceb44144d9586582b3ac0130) | [GetMaturityType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a882266bba5cee26308e9f019dd051ada) (float age) |
| static void | [FlushFaceCache](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a5e257a9185d75ce71a35f7e0b9cb9867) () |
| static string[] | [GetRaceIds](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aa34f131d14e1662691cd9827bbffc167) () |
| static int[] | [GetHairIndicesByTag](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#af07a5e11ff8783fd9f1c959caebc14fb) (int race, int curGender, float age, string tag) |
| static int[] | [GetFacialIndicesByTag](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ace138156bfdd6d3888962e91c51dc819) (int race, int curGender, float age, string tag) |
| static int[] | [GetTattooIndicesByTag](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a94a59815591b935644463cd8d57abbcf) (int race, int curGender, float age, string tag) |
| static List< UInt32 > | [GetSkinColorGradientPoints](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a258ddcb26d741d0f579df94dd24748ea) (int race, int curGender, int age) |
| static List< bool > | [GetVoiceTypeUsableForPlayerData](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a3460e6da698ac26e6424704e871056f0) (int race, int curGender, float age, int voiceTypeCount) |
| static void | [SetHair](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ad580f04821f93bcfdfd9c99ab0b35c1f) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, int hair, int beard, int tattoo) |
| static void | [SetBody](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aa0573e30bef9c1c208ba008a813d011f) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, int build, int weight) |
| static void | [SetPigmentation](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aeb670531e25b0afe461b72de33395874) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, int skinColor, int hairColor, int eyeColor) |
| static void | [GenerateParentKey](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ad603c1eda47a5fa697507534e3945492) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) childBodyProperties, int race, ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) motherBodyProperties, ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) fatherBodyProperties) |
| static [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyPropertiesWithAge](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#adee53f6dace4cb5cac842018d3dda3b2) (ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties, float age) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ab6494509d3771d1f4d15dd88ac0aa562)GenerationType
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MBBodyProperties.GenerationType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ab6494509d3771d1f4d15dd88ac0aa562) |

| Enumerator | |
| --- | --- |
| FromMother |  |
| FromFather |  |
| Count |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aa6bd97d38f141bf80f2e08834e08e1ee)GetNumEditableDeformKeys()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBBodyProperties.GetNumEditableDeformKeys | ( | int | *race*, | |  |  | bool | *initialGender*, | |  |  | int | *age* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a1a8401d27f0bd71c8bb8c99e19808275)GetParamsFromKey()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBBodyProperties.GetParamsFromKey | ( | ref [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) | *faceGenerationParams*, | |  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, | |  |  | bool | *earsAreHidden*, | |  |  | bool | *mouthHidden* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ac853544b71d92d6aa9d2d5526eb1b5db)GetParamsMax()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBBodyProperties.GetParamsMax | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | int | *curAge*, | |  |  | ref int | *hairNum*, | |  |  | ref int | *beardNum*, | |  |  | ref int | *faceTextureNum*, | |  |  | ref int | *mouthTextureNum*, | |  |  | ref int | *faceTattooNum*, | |  |  | ref int | *soundNum*, | |  |  | ref int | *eyebrowNum*, | |  |  | ref float | *scale* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aa8bf61354dad62c30641f127b8012acf)GetZeroProbabilities()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBBodyProperties.GetZeroProbabilities | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | float | *curAge*, | |  |  | ref float | *tattooZeroProbability* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a3965528bb61161d4c18a34cccb4564eb)ProduceNumericKeyWithParams()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBBodyProperties.ProduceNumericKeyWithParams | ( | [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) | *faceGenerationParams*, | |  |  | bool | *earsAreHidden*, | |  |  | bool | *mouthIsHidden*, | |  |  | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a35789d9c033277628fc7307fb41e8870)TransformFaceKeysToDefaultFace()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBBodyProperties.TransformFaceKeysToDefaultFace | ( | ref [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) | *faceGenerationParams* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aebec0072d4d5a2520f0dd45fabbba0fe)ProduceNumericKeyWithDefaultValues()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBBodyProperties.ProduceNumericKeyWithDefaultValues | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *initialBodyProperties*, | |  |  | bool | *earsAreHidden*, | |  |  | bool | *mouthIsHidden*, | |  |  | int | *race*, | |  |  | int | *gender*, | |  |  | int | *age* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a0d585c6390a640a2d55022d9899931c8)GetRandomBodyProperties()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.MBBodyProperties.GetRandomBodyProperties | ( | int | *race*, | |  |  | bool | *isFemale*, | |  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyPropertiesMin*, | |  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyPropertiesMax*, | |  |  | int | *hairCoverType*, | |  |  | int | *seed*, | |  |  | string | *hairTags*, | |  |  | string | *beardTags*, | |  |  | string | *tatooTags*, | |  |  | float | *variationAmount* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a4802b46844610fc9487e453e6ae04463)GetDeformKeyData()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [DeformKeyData](struct_tale_worlds_1_1_mount_and_blade_1_1_deform_key_data.html) TaleWorlds.MountAndBlade.MBBodyProperties.GetDeformKeyData | ( | int | *keyNo*, | |  |  | int | *race*, | |  |  | int | *gender*, | |  |  | int | *age* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ac1ca607ec8145029e7b546a68a37f72b)GetFaceGenInstancesLength()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBBodyProperties.GetFaceGenInstancesLength | ( | int | *race*, | |  |  | int | *gender*, | |  |  | int | *age* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aa7a884ba2693e3788eb55ca5977d3d26)EnforceConstraints()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBBodyProperties.EnforceConstraints | ( | ref [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) | *faceGenerationParams* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a9b9f28d7a72833e25eba6983eebc0c2b)GetScaleFromKey()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBBodyProperties.GetScaleFromKey | ( | int | *race*, | |  |  | int | *gender*, | |  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a0d2ff6118448f04942828c0860a00d89)GetHairColorCount()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBBodyProperties.GetHairColorCount | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | int | *age* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aadb6bc6f9aa54fe3922f579b5fb407b6)GetHairColorGradientPoints()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< UInt32 > TaleWorlds.MountAndBlade.MBBodyProperties.GetHairColorGradientPoints | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | int | *age* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a292e103ab4b689206de70fbd83035c51)GetTatooColorCount()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBBodyProperties.GetTatooColorCount | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | int | *age* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a78119d14834c548b4014c7035358272b)GetTatooColorGradientPoints()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< uint > TaleWorlds.MountAndBlade.MBBodyProperties.GetTatooColorGradientPoints | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | int | *age* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a169d3715e3cd3e8063cd1e54d5595fd5)GetSkinColorCount()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBBodyProperties.GetSkinColorCount | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | int | *age* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a882266bba5cee26308e9f019dd051ada)GetMaturityType()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [BodyMeshMaturityType](namespace_tale_worlds_1_1_core.html#aa06b6ee7ceb44144d9586582b3ac0130) TaleWorlds.MountAndBlade.MBBodyProperties.GetMaturityType | ( | float | *age* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a5e257a9185d75ce71a35f7e0b9cb9867)FlushFaceCache()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBBodyProperties.FlushFaceCache | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aa34f131d14e1662691cd9827bbffc167)GetRaceIds()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string[] TaleWorlds.MountAndBlade.MBBodyProperties.GetRaceIds | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#af07a5e11ff8783fd9f1c959caebc14fb)GetHairIndicesByTag()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int[] TaleWorlds.MountAndBlade.MBBodyProperties.GetHairIndicesByTag | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | float | *age*, | |  |  | string | *tag* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ace138156bfdd6d3888962e91c51dc819)GetFacialIndicesByTag()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int[] TaleWorlds.MountAndBlade.MBBodyProperties.GetFacialIndicesByTag | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | float | *age*, | |  |  | string | *tag* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a94a59815591b935644463cd8d57abbcf)GetTattooIndicesByTag()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int[] TaleWorlds.MountAndBlade.MBBodyProperties.GetTattooIndicesByTag | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | float | *age*, | |  |  | string | *tag* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a258ddcb26d741d0f579df94dd24748ea)GetSkinColorGradientPoints()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< UInt32 > TaleWorlds.MountAndBlade.MBBodyProperties.GetSkinColorGradientPoints | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | int | *age* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#a3460e6da698ac26e6424704e871056f0)GetVoiceTypeUsableForPlayerData()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< bool > TaleWorlds.MountAndBlade.MBBodyProperties.GetVoiceTypeUsableForPlayerData | ( | int | *race*, | |  |  | int | *curGender*, | |  |  | float | *age*, | |  |  | int | *voiceTypeCount* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ad580f04821f93bcfdfd9c99ab0b35c1f)SetHair()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBBodyProperties.SetHair | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, | |  |  | int | *hair*, | |  |  | int | *beard*, | |  |  | int | *tattoo* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aa0573e30bef9c1c208ba008a813d011f)SetBody()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBBodyProperties.SetBody | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, | |  |  | int | *build*, | |  |  | int | *weight* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#aeb670531e25b0afe461b72de33395874)SetPigmentation()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBBodyProperties.SetPigmentation | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, | |  |  | int | *skinColor*, | |  |  | int | *hairColor*, | |  |  | int | *eyeColor* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#ad603c1eda47a5fa697507534e3945492)GenerateParentKey()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBBodyProperties.GenerateParentKey | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *childBodyProperties*, | |  |  | int | *race*, | |  |  | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *motherBodyProperties*, | |  |  | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *fatherBodyProperties* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_body_properties.html#adee53f6dace4cb5cac842018d3dda3b2)GetBodyPropertiesWithAge()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.MBBodyProperties.GetBodyPropertiesWithAge | ( | ref [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties*, | |  |  | float | *age* ) | | static |


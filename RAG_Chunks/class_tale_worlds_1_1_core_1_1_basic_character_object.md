--- SOURCE: class_tale_worlds_1_1_core_1_1_basic_character_object.html ---

TaleWorlds.Core.BasicCharacterObject Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

Inherited by [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ac5fe2ea1a8d3fcb99b876fa34feebd10) () |
|  | This function is not same with get property of Name. It overrides the function in MBObjectBase class. It is used in encyclopedia etc. |
| override string | [ToString](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a9bf85a9902929170f3e29ef1eacce14a) () |
| void | [InitializeEquipmentsOnLoad](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a818d8c250a1101af9d92381c4dedd10f) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a97373628d8b9c791bdf222d59acc5407) character) |
| [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) | [GetFirstEquipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ab28a6ec42f8d51f8c7da90128855e78f) (Func< [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81), bool > predicate) |
| virtual [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyPropertiesMin](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a655dd5f207ffad4833c578d5f7944124) (bool returnBaseValue=false) |
| virtual [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyPropertiesMax](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a844ac49f150b4ee1b14fca6f60326ded) (bool returnBaseValue=false) |
| virtual [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyProperties](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a4b587db46dcd8f9ecf3e8488ed4c0abd) ([Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) equipment, int seed=-1) |
| virtual void | [UpdatePlayerCharacterBodyProperties](class_tale_worlds_1_1_core_1_1_basic_character_object.html#abf8feb95673ae7b55f15e0e39cf96a1e) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) properties, int race, bool isFemale) |
|  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a97373628d8b9c791bdf222d59acc5407) () |
| int | [GetDefaultFaceSeed](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a5532da5caadeeb047b9c6016429cd630) (int rank) |
| float | [GetStepSize](class_tale_worlds_1_1_core_1_1_basic_character_object.html#af626de99937ee0dbf3b95b25cd390618) () |
| bool | [HasMount](class_tale_worlds_1_1_core_1_1_basic_character_object.html#afb2f961a5e83787dd6241969fe396802) () |
| virtual int | [MaxHitPoints](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a4c39866b7173aea5ee69c14c0f4b53f5) () |
| virtual float | [GetPower](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ad9d9813b9a1ae6ab3296debd1f7f8ec0) () |
| virtual float | [GetBattlePower](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a8d4abbf29a34e79e53ee627ba5637ccb) () |
| virtual float | [GetMoraleResistance](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aa05656b29cade1cd89bf916dfb6a236d) () |
| virtual int | [GetMountKeySeed](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a1c31d875166ef247f782cd654eaa695f) () |
| virtual int | [GetBattleTier](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a8d541b58ad99db1aa184860d09487b30) () |
| [MBCharacterSkills](class_tale_worlds_1_1_core_1_1_m_b_character_skills.html) | [GetDefaultCharacterSkills](class_tale_worlds_1_1_core_1_1_basic_character_object.html#adeeb8c02ce3e492ccf1e6e9e9d8af8e3) () |
| virtual int | [GetSkillValue](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a42ea2bc67456fe86b090e72583a23a12) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a036f5c085184281cd1a06399010cdab0) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| virtual [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [GetFormationClass](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a455c0163c9617798707a8c7ea10aadde) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly int | [SkillAffectingMaxLevel](class_tale_worlds_1_1_core_1_1_basic_character_object.html#afb2868dfe395c615bcbcfacf38fe9494) = 32 |
| const float | [DefaultKnockbackResistance](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a7f7d0a1cee9188b3569cd56bd268644a) = 25f |
| const float | [DefaultKnockdownResistance](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ab2fb89201492b1141a1e1bb696b7b921) = 50f |
| const float | [DefaultDismountResistance](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a45c20ef6f4bd7d5c2ec66dbaaa4e6ea4) = 50f |
| const int | [MaxBattleTier](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aafe02cc2dc6cd11f1e3eaabc1e63b155) = 7 |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [FillFrom](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a764f8630d2e39076e23277bce8196d73) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a97373628d8b9c791bdf222d59acc5407) character) |
| void | [InitializeHeroBasicCharacterOnAfterLoad](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a8c7abae9ccd4c11f6d0b08906e8e3f1e) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a97373628d8b9c791bdf222d59acc5407) originCharacter) |
| void | [AddEquipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ac157e3b706e54e595ed2b91e481ba8d3) ([MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) equipmentRoster, EquipmentType equipmentType) |
| int | [FetchDefaultFormationGroup](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a29f0cf181f5c3c66af8ee815f5561771) (string innerText) |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [\_basicName](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a78b957bd41478a70bfad45731dcd742d) |
| [MBCharacterSkills](class_tale_worlds_1_1_core_1_1_m_b_character_skills.html) | [DefaultCharacterSkills](class_tale_worlds_1_1_core_1_1_basic_character_object.html#af2ccdcf630483d67d95d5dcbb1bc3f34) |

|  |  |
| --- | --- |
| Properties | |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a1341f0b6bc90fd7ae2d995e02a4ab4b0) `[get]` |
| virtual [MBBodyProperty](class_tale_worlds_1_1_core_1_1_m_b_body_property.html) | [BodyPropertyRange](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aab74cde3896117d2dac4dcc5623a1ed2) `[get, protected set]` |
| int | [DefaultFormationGroup](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a64c5b4b3b2e10de4069b5cbfd8beefba) `[get, set]` |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [DefaultFormationClass](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ad4604bb9572d069c2acc2c65e0d8081a) `[get, protected set]` |
| float | [KnockbackResistance](class_tale_worlds_1_1_core_1_1_basic_character_object.html#afa7b545c363c3b784630fef38cb37d87) `[get]` |
| float | [KnockdownResistance](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a69fdfc66e6d1bc9c9939f503016fbbcc) `[get]` |
| float | [DismountResistance](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aa2bd753f24338d20ecd2f623ca066d4e) `[get]` |
| [FormationPositionPreference](namespace_tale_worlds_1_1_core.html#a27a08ddbccef9cfbcf5de8653eb5244e) | [FormationPositionPreference](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ae96465dd6dc66e51ead01147675ff79e) `[get, protected set]` |
| bool | [IsInfantry](class_tale_worlds_1_1_core_1_1_basic_character_object.html#abe3a5355ca29acbdabfcfe7a803e217b) `[get]` |
| virtual bool | [IsMounted](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a3c620e1b0b210aa9e1ac8ae5c01ffeee) `[get]` |
| virtual bool | [IsRanged](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a038e694a04b51c61192ba62d0d533ab8) `[get]` |
| float | [SkillFactor](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a993dbbebdd79f2653f8b6a239d72b676) `[get]` |
| int | [Race](class_tale_worlds_1_1_core_1_1_basic_character_object.html#abffd02910658a543728dc5d35d7c7183) `[get, set]` |
| virtual bool | [IsFemale](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a1f337fb8ed7dfe1e0ce3b90c18b0410a) `[get, set]` |
| bool | [FaceMeshCache](class_tale_worlds_1_1_core_1_1_basic_character_object.html#adf14244ecb30862b81c63e83e626950a) `[get]` |
| virtual MBReadOnlyList< [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) > | [AllEquipments](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a1ed0775ab2a25e62a355c6256d4f85b1) `[get]` |
| virtual Equipment | [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) `[get]` |
| virtual IEnumerable< [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) > | [BattleEquipments](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a811390b81632a0dab46ed5af2fb09c63) `[get]` |
| virtual [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) | [FirstBattleEquipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a9d8c6a0b31e2e8daf99aba97c5ad4b3a) `[get]` |
| virtual [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) | [RandomBattleEquipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a08cd3a12e3cf6452c665eaef4560ba94) `[get]` |
| virtual IEnumerable< [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) > | [CivilianEquipments](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ac2a26863401114782b33c5debd890b1c) `[get]` |
| virtual [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) | [FirstCivilianEquipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a92f60d08ac6f000cd31541b033f54ad8) `[get]` |
| virtual [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) | [RandomCivilianEquipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a5f4595a0d2f08c398c2f2ce49e9c34ed) `[get]` |
| virtual [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) | [GetRandomEquipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#adb64583329515afe836cac22519a51cb) `[get]` |
| bool | [IsObsolete](class_tale_worlds_1_1_core_1_1_basic_character_object.html#abf613bbb77b4ec088bac80981be12787) `[get]` |
| virtual int | [Level](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a894e280e5571fd16147a8e692e068e21) `[get, set]` |
|  | Gets or sets the Level. |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [Culture](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aac81c0bb032f8ae5673e44c68956e6b8) `[get, set]` |
|  | Gets or sets the culture of this character. |
| virtual bool | [IsPlayerCharacter](class_tale_worlds_1_1_core_1_1_basic_character_object.html#acdb7f31c98b100200b7eb9645613c2e9) `[get]` |
| virtual float | [Age](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a4260576827b896f9b2a161dd7c8eb9f5) `[get, set]` |
| virtual int | [HitPoints](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a91adf100763a5e0282158aa258018c61) `[get]` |
| float | [FaceDirtAmount](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aea7f8b5257527cca707ef7e06bf4b7bf) `[get, set]` |
| virtual bool | [IsHero](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ad6a1b6dbacf4ae3888fb1b80a86d5703) `[get]` |
| bool | [IsSoldier](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a51370bd3d2535892dffc55767f16084b) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a97373628d8b9c791bdf222d59acc5407)BasicCharacterObject()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.BasicCharacterObject.BasicCharacterObject | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ac5fe2ea1a8d3fcb99b876fa34feebd10)GetName()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.BasicCharacterObject.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db).

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a9bf85a9902929170f3e29ef1eacce14a)ToString()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Core.BasicCharacterObject.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a818d8c250a1101af9d92381c4dedd10f)InitializeEquipmentsOnLoad()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.BasicCharacterObject.InitializeEquipmentsOnLoad | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a97373628d8b9c791bdf222d59acc5407) | *character* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ab28a6ec42f8d51f8c7da90128855e78f)GetFirstEquipment()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) TaleWorlds.Core.BasicCharacterObject.GetFirstEquipment | ( | Func< [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81), bool > | *predicate* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a655dd5f207ffad4833c578d5f7944124)GetBodyPropertiesMin()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.Core.BasicCharacterObject.GetBodyPropertiesMin | ( | bool | *returnBaseValue* = false | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6015d59f2c1c544b04f5d2caf6be480b).

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a764f8630d2e39076e23277bce8196d73)FillFrom()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.BasicCharacterObject.FillFrom | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a97373628d8b9c791bdf222d59acc5407) | *character* | ) |  | | protected |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a844ac49f150b4ee1b14fca6f60326ded)GetBodyPropertiesMax()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.Core.BasicCharacterObject.GetBodyPropertiesMax | ( | bool | *returnBaseValue* = false | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#afeea5ae58ff341b321e003051844cab2).

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a4b587db46dcd8f9ecf3e8488ed4c0abd)GetBodyProperties()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.Core.BasicCharacterObject.GetBodyProperties | ( | [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) | *equipment*, | |  |  | int | *seed* = -1 ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a20bbcb629c13a7a2f022879490767e26).

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#abf8feb95673ae7b55f15e0e39cf96a1e)UpdatePlayerCharacterBodyProperties()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.Core.BasicCharacterObject.UpdatePlayerCharacterBodyProperties | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *properties*, | |  |  | int | *race*, | |  |  | bool | *isFemale* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a229b2e35324a08e2f4177b3b3d54cd56).

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a5532da5caadeeb047b9c6016429cd630)GetDefaultFaceSeed()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.BasicCharacterObject.GetDefaultFaceSeed | ( | int | *rank* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#af626de99937ee0dbf3b95b25cd390618)GetStepSize()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Core.BasicCharacterObject.GetStepSize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#afb2f961a5e83787dd6241969fe396802)HasMount()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.BasicCharacterObject.HasMount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a4c39866b7173aea5ee69c14c0f4b53f5)MaxHitPoints()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual int TaleWorlds.Core.BasicCharacterObject.MaxHitPoints | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ab2435f54c2f82d7d0f7ea6248ae33c1e).

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ad9d9813b9a1ae6ab3296debd1f7f8ec0)GetPower()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual float TaleWorlds.Core.BasicCharacterObject.GetPower | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#afe0dabaa06b3f1696738a332d5a339d2).

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a8d4abbf29a34e79e53ee627ba5637ccb)GetBattlePower()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual float TaleWorlds.Core.BasicCharacterObject.GetBattlePower | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a2078a7d7805ed5148eb83fba8a9252bc).

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aa05656b29cade1cd89bf916dfb6a236d)GetMoraleResistance()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual float TaleWorlds.Core.BasicCharacterObject.GetMoraleResistance | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1ce6833d58d3416b8f62bbc3aa738d49).

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a1c31d875166ef247f782cd654eaa695f)GetMountKeySeed()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual int TaleWorlds.Core.BasicCharacterObject.GetMountKeySeed | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#abf4e0c228a424e273695a1f3d8eb7715).

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a8d541b58ad99db1aa184860d09487b30)GetBattleTier()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual int TaleWorlds.Core.BasicCharacterObject.GetBattleTier | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#adeeb8c02ce3e492ccf1e6e9e9d8af8e3)GetDefaultCharacterSkills()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MBCharacterSkills](class_tale_worlds_1_1_core_1_1_m_b_character_skills.html) TaleWorlds.Core.BasicCharacterObject.GetDefaultCharacterSkills | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a42ea2bc67456fe86b090e72583a23a12)GetSkillValue()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual int TaleWorlds.Core.BasicCharacterObject.GetSkillValue | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aeaf48005c2355806455637b1dbd74a8b).

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a8c7abae9ccd4c11f6d0b08906e8e3f1e)InitializeHeroBasicCharacterOnAfterLoad()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.BasicCharacterObject.InitializeHeroBasicCharacterOnAfterLoad | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a97373628d8b9c791bdf222d59acc5407) | *originCharacter* | ) |  | | protected |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a036f5c085184281cd1a06399010cdab0)Deserialize()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.BasicCharacterObject.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Reimplemented in [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ab7af1336146cbbed86b03e0252a61514).

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ac157e3b706e54e595ed2b91e481ba8d3)AddEquipment()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.BasicCharacterObject.AddEquipment | ( | [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) | *equipmentRoster*, | |  |  | EquipmentType | *equipmentType* ) | | protected |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a29f0cf181f5c3c66af8ee815f5561771)FetchDefaultFormationGroup()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Core.BasicCharacterObject.FetchDefaultFormationGroup | ( | string | *innerText* | ) |  | | protected |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a455c0163c9617798707a8c7ea10aadde)GetFormationClass()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.Core.BasicCharacterObject.GetFormationClass | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a86ab67dcc6378764530de0070c18e183).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#afb2868dfe395c615bcbcfacf38fe9494)SkillAffectingMaxLevel
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly int TaleWorlds.Core.BasicCharacterObject.SkillAffectingMaxLevel = 32 | | static |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a7f7d0a1cee9188b3569cd56bd268644a)DefaultKnockbackResistance
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Core.BasicCharacterObject.DefaultKnockbackResistance = 25f | | static |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ab2fb89201492b1141a1e1bb696b7b921)DefaultKnockdownResistance
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Core.BasicCharacterObject.DefaultKnockdownResistance = 50f | | static |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a45c20ef6f4bd7d5c2ec66dbaaa4e6ea4)DefaultDismountResistance
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Core.BasicCharacterObject.DefaultDismountResistance = 50f | | static |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aafe02cc2dc6cd11f1e3eaabc1e63b155)MaxBattleTier
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.BasicCharacterObject.MaxBattleTier = 7 | | static |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a78b957bd41478a70bfad45731dcd742d)\_basicName
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.BasicCharacterObject.\_basicName | | protected |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#af2ccdcf630483d67d95d5dcbb1bc3f34)DefaultCharacterSkills
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBCharacterSkills](class_tale_worlds_1_1_core_1_1_m_b_character_skills.html) TaleWorlds.Core.BasicCharacterObject.DefaultCharacterSkills | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a1341f0b6bc90fd7ae2d995e02a4ab4b0)Name
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.BasicCharacterObject.Name | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aab74cde3896117d2dac4dcc5623a1ed2)BodyPropertyRange
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [MBBodyProperty](class_tale_worlds_1_1_core_1_1_m_b_body_property.html) TaleWorlds.Core.BasicCharacterObject.BodyPropertyRange | | getprotected set |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a64c5b4b3b2e10de4069b5cbfd8beefba)DefaultFormationGroup
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.BasicCharacterObject.DefaultFormationGroup | | getset |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ad4604bb9572d069c2acc2c65e0d8081a)DefaultFormationClass
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.Core.BasicCharacterObject.DefaultFormationClass | | getprotected set |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#afa7b545c363c3b784630fef38cb37d87)KnockbackResistance
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BasicCharacterObject.KnockbackResistance | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a69fdfc66e6d1bc9c9939f503016fbbcc)KnockdownResistance
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BasicCharacterObject.KnockdownResistance | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aa2bd753f24338d20ecd2f623ca066d4e)DismountResistance
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BasicCharacterObject.DismountResistance | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ae96465dd6dc66e51ead01147675ff79e)FormationPositionPreference
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationPositionPreference](namespace_tale_worlds_1_1_core.html#a27a08ddbccef9cfbcf5de8653eb5244e) TaleWorlds.Core.BasicCharacterObject.FormationPositionPreference | | getprotected set |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#abe3a5355ca29acbdabfcfe7a803e217b)IsInfantry
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.BasicCharacterObject.IsInfantry | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a3c620e1b0b210aa9e1ac8ae5c01ffeee)IsMounted
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.BasicCharacterObject.IsMounted | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a038e694a04b51c61192ba62d0d533ab8)IsRanged
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.BasicCharacterObject.IsRanged | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a993dbbebdd79f2653f8b6a239d72b676)SkillFactor
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BasicCharacterObject.SkillFactor | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#abffd02910658a543728dc5d35d7c7183)Race
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.BasicCharacterObject.Race | | getset |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a1f337fb8ed7dfe1e0ce3b90c18b0410a)IsFemale
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.BasicCharacterObject.IsFemale | | getset |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#adf14244ecb30862b81c63e83e626950a)FaceMeshCache
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.BasicCharacterObject.FaceMeshCache | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a1ed0775ab2a25e62a355c6256d4f85b1)AllEquipments
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual MBReadOnlyList<[Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81)> TaleWorlds.Core.BasicCharacterObject.AllEquipments | | getprotected |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81)Equipment
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual Equipment TaleWorlds.Core.BasicCharacterObject.Equipment | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a811390b81632a0dab46ed5af2fb09c63)BattleEquipments
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual IEnumerable<[Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81)> TaleWorlds.Core.BasicCharacterObject.BattleEquipments | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a9d8c6a0b31e2e8daf99aba97c5ad4b3a)FirstBattleEquipment
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) TaleWorlds.Core.BasicCharacterObject.FirstBattleEquipment | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a08cd3a12e3cf6452c665eaef4560ba94)RandomBattleEquipment
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) TaleWorlds.Core.BasicCharacterObject.RandomBattleEquipment | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ac2a26863401114782b33c5debd890b1c)CivilianEquipments
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual IEnumerable<[Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81)> TaleWorlds.Core.BasicCharacterObject.CivilianEquipments | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a92f60d08ac6f000cd31541b033f54ad8)FirstCivilianEquipment
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) TaleWorlds.Core.BasicCharacterObject.FirstCivilianEquipment | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a5f4595a0d2f08c398c2f2ce49e9c34ed)RandomCivilianEquipment
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) TaleWorlds.Core.BasicCharacterObject.RandomCivilianEquipment | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#adb64583329515afe836cac22519a51cb)GetRandomEquipment
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) TaleWorlds.Core.BasicCharacterObject.GetRandomEquipment | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#abf613bbb77b4ec088bac80981be12787)IsObsolete
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.BasicCharacterObject.IsObsolete | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a894e280e5571fd16147a8e692e068e21)Level
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual int TaleWorlds.Core.BasicCharacterObject.Level | | getset |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aac81c0bb032f8ae5673e44c68956e6b8)Culture
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.Core.BasicCharacterObject.Culture | | getset |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#acdb7f31c98b100200b7eb9645613c2e9)IsPlayerCharacter
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.BasicCharacterObject.IsPlayerCharacter | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a4260576827b896f9b2a161dd7c8eb9f5)Age
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual float TaleWorlds.Core.BasicCharacterObject.Age | | getset |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a91adf100763a5e0282158aa258018c61)HitPoints
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual int TaleWorlds.Core.BasicCharacterObject.HitPoints | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aea7f8b5257527cca707ef7e06bf4b7bf)FaceDirtAmount
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BasicCharacterObject.FaceDirtAmount | | getset |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ad6a1b6dbacf4ae3888fb1b80a86d5703)IsHero
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.Core.BasicCharacterObject.IsHero | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a51370bd3d2535892dffc55767f16084b)IsSoldier
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.BasicCharacterObject.IsSoldier | | get |


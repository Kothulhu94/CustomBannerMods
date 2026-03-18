--- SOURCE: class_tale_worlds_1_1_core_1_1_monster.html ---

TaleWorlds.Core.Monster Class ReferencesealedInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_monster.html#a05a1d276668bb6695f7f8cab346f2422) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| sbyte | [GetBoneToAttachForItemFlags](class_tale_worlds_1_1_core_1_1_monster.html#ab9be50218ef9d00b2819292e0b1b77e2) ([ItemFlags](namespace_tale_worlds_1_1_core.html#a15c85da8a745978ee9af9c5677c007c1) itemFlags) |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static Func< string, string, sbyte > | [GetBoneIndexWithId](class_tale_worlds_1_1_core_1_1_monster.html#ad5030b5822638f54f9b71ac1e6a2c29c) |
| static Func< string, sbyte, bool > | [GetBoneHasParentBone](class_tale_worlds_1_1_core_1_1_monster.html#aae8f596c0621a0e9db6e389459c04438) |

|  |  |
| --- | --- |
| Properties | |
| string | [BaseMonster](class_tale_worlds_1_1_core_1_1_monster.html#aee95d34793d0cf5333f3dbf0a9716185) `[get]` |
| float | [BodyCapsuleRadius](class_tale_worlds_1_1_core_1_1_monster.html#ac6e69a38451d56384395172a5e58c0f1) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [BodyCapsulePoint1](class_tale_worlds_1_1_core_1_1_monster.html#a407a14227102921551a56e4dc5420fa5) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [BodyCapsulePoint2](class_tale_worlds_1_1_core_1_1_monster.html#a3714e4204e55ad7a28ee6efdb50fce7a) `[get]` |
| float | [CrouchedBodyCapsuleRadius](class_tale_worlds_1_1_core_1_1_monster.html#aa39758208aa5bf26a1fca63707eb64fa) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CrouchedBodyCapsulePoint1](class_tale_worlds_1_1_core_1_1_monster.html#ae752ef576059a6d1ffec944e1d239990) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CrouchedBodyCapsulePoint2](class_tale_worlds_1_1_core_1_1_monster.html#abd4f4d0574ca7c7450b1f4dd1a243ec3) `[get]` |
| [AgentFlag](namespace_tale_worlds_1_1_core.html#a4eadec2c483252505ae0d0ab98de39fe) | [Flags](class_tale_worlds_1_1_core_1_1_monster.html#a2eea232cc686245cb5543194117c2b38) `[get]` |
| int | [Weight](class_tale_worlds_1_1_core_1_1_monster.html#a33c7762d2d1550db9e7f92bb572007b7) `[get]` |
| int | [HitPoints](class_tale_worlds_1_1_core_1_1_monster.html#ac9fe4679914d1b3f4907e12c4000bd2a) `[get]` |
| string | [ActionSetCode](class_tale_worlds_1_1_core_1_1_monster.html#a689e5dcb8f655a037345422ec5ea721b) `[get]` |
| string | [FemaleActionSetCode](class_tale_worlds_1_1_core_1_1_monster.html#a6e794d58bf717e471a9fce2b305417d1) `[get]` |
| int | [NumPaces](class_tale_worlds_1_1_core_1_1_monster.html#a045f1f266e1e79db2a5d18da3cfb94fd) `[get]` |
| string | [MonsterUsage](class_tale_worlds_1_1_core_1_1_monster.html#ad3d3bac9533a72c2a0c79286f96b44d9) `[get]` |
| float | [WalkingSpeedLimit](class_tale_worlds_1_1_core_1_1_monster.html#aae89c28f403abba58f13e6d133470650) `[get]` |
| float | [CrouchWalkingSpeedLimit](class_tale_worlds_1_1_core_1_1_monster.html#ae965c3f82fc2483ea18b43a6a41d3839) `[get]` |
| float | [JumpAcceleration](class_tale_worlds_1_1_core_1_1_monster.html#a6b2be682dee578a8642ea15c600b2f5e) `[get]` |
| float | [AbsorbedDamageRatio](class_tale_worlds_1_1_core_1_1_monster.html#a00a722ffccd64688e003b1b96a9c3fff) `[get]` |
| string | [SoundAndCollisionInfoClassName](class_tale_worlds_1_1_core_1_1_monster.html#a08f096de4dcfda75307ef7f7c6b80250) `[get]` |
| float | [RiderCameraHeightAdder](class_tale_worlds_1_1_core_1_1_monster.html#ad9c8020fe17590b25a9c8bc6628dfe5d) `[get]` |
| float | [RiderBodyCapsuleHeightAdder](class_tale_worlds_1_1_core_1_1_monster.html#a77f9f8c16ed1f0cf371bf3cadce8e926) `[get]` |
| float | [RiderBodyCapsuleForwardAdder](class_tale_worlds_1_1_core_1_1_monster.html#a59e2fe2844d52c9b75582153d37e0c20) `[get]` |
| float | [StandingChestHeight](class_tale_worlds_1_1_core_1_1_monster.html#a22dedc19482635cb095544094a2b1deb) `[get]` |
| float | [StandingPelvisHeight](class_tale_worlds_1_1_core_1_1_monster.html#a7fc8cfb5ec4aaed7be5cb9fc48d243a8) `[get]` |
| float | [StandingEyeHeight](class_tale_worlds_1_1_core_1_1_monster.html#a2c042b5a5c4519835b661934e670015b) `[get]` |
| float | [CrouchEyeHeight](class_tale_worlds_1_1_core_1_1_monster.html#a098909e5db9fc57f2fd5dfef909463e9) `[get]` |
| float | [MountedEyeHeight](class_tale_worlds_1_1_core_1_1_monster.html#a9d263265fb8f13548645966058f33aa0) `[get]` |
| float | [RiderEyeHeightAdder](class_tale_worlds_1_1_core_1_1_monster.html#a4644ddb8c15f688cfdaaddce82756d6f) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [EyeOffsetWrtHead](class_tale_worlds_1_1_core_1_1_monster.html#a75d7715ed9f75855c6cfa2e3e05a4cbc) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [FirstPersonCameraOffsetWrtHead](class_tale_worlds_1_1_core_1_1_monster.html#ad19be8d773b6c4da5ca9f23de6d7dfbc) `[get]` |
| float | [ArmLength](class_tale_worlds_1_1_core_1_1_monster.html#a0f44ea0d805897bc522a71ed9fd4ca32) `[get]` |
| float | [ArmWeight](class_tale_worlds_1_1_core_1_1_monster.html#aede5168b7843b9afde045b0b4b1d0e87) `[get]` |
| float | [JumpSpeedLimit](class_tale_worlds_1_1_core_1_1_monster.html#ae988d861ad7fdab141000fe9803dd398) `[get]` |
| float | [RelativeSpeedLimitForCharge](class_tale_worlds_1_1_core_1_1_monster.html#a90c0bff45827ece6559bc55d96691a38) `[get]` |
| int | [FamilyType](class_tale_worlds_1_1_core_1_1_monster.html#a1d48cd1823719ba1b886e6659d71c7ff) `[get]` |
| sbyte[] | [IndicesOfRagdollBonesToCheckForCorpses](class_tale_worlds_1_1_core_1_1_monster.html#a76cadd874c7d83f6c58b8e8f0b7a3273) `[get]` |
| sbyte[] | [RagdollFallSoundBoneIndices](class_tale_worlds_1_1_core_1_1_monster.html#a7c0bb804eafe4b8aa15fc5f7c5c27302) `[get]` |
| sbyte | [HeadLookDirectionBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#aaa7a8c9226c20fc23868846e334e4bed) `[get]` |
| sbyte | [SpineLowerBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a368f4412aef04e00e0874ebb5443d192) `[get]` |
| sbyte | [SpineUpperBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a7f94c2a80fa1702b451044d2c68195c4) `[get]` |
| sbyte | [ThoraxLookDirectionBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#ac3693166d71d690e73b0e67b219f6e1f) `[get]` |
| sbyte | [NeckRootBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#ad842c45676d1310875a0a42abaa7463b) `[get]` |
| sbyte | [PelvisBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a3f629fc6f8e8b53d43c19ad588900ec7) `[get]` |
| sbyte | [RightUpperArmBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#ac2efb7c33a4f1dfb0a8134b736567b83) `[get]` |
| sbyte | [LeftUpperArmBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a325e7962848b666a9e967b03360b3e80) `[get]` |
| sbyte | [FallBlowDamageBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a27991a8b682aed1be1a6ca0659a38430) `[get]` |
| sbyte | [TerrainDecalBone0Index](class_tale_worlds_1_1_core_1_1_monster.html#ade53f77e7e7570646babecbd5b6b1910) `[get]` |
| sbyte | [TerrainDecalBone1Index](class_tale_worlds_1_1_core_1_1_monster.html#a9932a845d87592d2a69d936d8bf22cf9) `[get]` |
| sbyte[] | [RagdollStationaryCheckBoneIndices](class_tale_worlds_1_1_core_1_1_monster.html#a33f6436bc2b1c9559c17e6836132bedd) `[get]` |
| sbyte[] | [MoveAdderBoneIndices](class_tale_worlds_1_1_core_1_1_monster.html#aa3548c0f30d5d8c49ab4a6c0e60d41f4) `[get]` |
| sbyte[] | [SplashDecalBoneIndices](class_tale_worlds_1_1_core_1_1_monster.html#a679d60eda8eb6b689b119f38d0917b51) `[get]` |
| sbyte[] | [BloodBurstBoneIndices](class_tale_worlds_1_1_core_1_1_monster.html#a506d9d7a23db958f7e0d6cdbb3706a4c) `[get]` |
| sbyte | [MainHandBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a7da03e69f875ae6a2f4014c23309ec13) `[get]` |
| sbyte | [OffHandBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#aa0e87e45f501ee1d6f64b82572cd9c67) `[get]` |
| sbyte | [MainHandItemBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#aacbcb0564e78e6ba9e855db4f596b991) `[get]` |
| sbyte | [OffHandItemBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a3ed8175e60e90a0d5769b9fc44c00ce4) `[get]` |
| sbyte | [MainHandItemSecondaryBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#aeb9639131e3a543d54c0cbc3ea0509e5) `[get]` |
| sbyte | [OffHandItemSecondaryBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a7bb01490e16c14d3a40709b3ff1403cb) `[get]` |
| sbyte | [OffHandShoulderBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#ab63bff6d6ecd90004398ab31b706715d) `[get]` |
| sbyte | [HandNumBonesForIk](class_tale_worlds_1_1_core_1_1_monster.html#aaaf5b71929f750f31e9b4934a7d3cc1d) `[get]` |
| sbyte | [PrimaryFootBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#aebdb066002ceb864826e06424ff0f235) `[get]` |
| sbyte | [SecondaryFootBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a9688bc64748b7f81c985c577cdc98034) `[get]` |
| sbyte | [RightFootIkEndEffectorBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a49ce6c6216a7e1025222e635be7cf2b2) `[get]` |
| sbyte | [LeftFootIkEndEffectorBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a628e904c3449b2d1bc0f0a65df1cc500) `[get]` |
| sbyte | [RightFootIkTipBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#ab3c4c0ea6453c9867f1b4e3c85af345f) `[get]` |
| sbyte | [LeftFootIkTipBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a4a296a16c4d6266eb98dc3c8d703cb0e) `[get]` |
| sbyte | [FootNumBonesForIk](class_tale_worlds_1_1_core_1_1_monster.html#a41024605c8dd73f66768230b5b6bdbb1) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [ReinHandleLeftLocalPosition](class_tale_worlds_1_1_core_1_1_monster.html#a5e5256edf705a37992773819a3a12fbf) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [ReinHandleRightLocalPosition](class_tale_worlds_1_1_core_1_1_monster.html#a85859a8d475b2f2cf38e79c80a42f09c) `[get]` |
| string | [ReinSkeleton](class_tale_worlds_1_1_core_1_1_monster.html#a105917aff8b6610f41001daf7a434587) `[get]` |
| string | [ReinCollisionBody](class_tale_worlds_1_1_core_1_1_monster.html#a5452de68d70fe4be240ed25869101f66) `[get]` |
| sbyte | [FrontBoneToDetectGroundSlopeIndex](class_tale_worlds_1_1_core_1_1_monster.html#ae6af61ce0d500db344e6a9aa5a0410b3) `[get]` |
| sbyte | [BackBoneToDetectGroundSlopeIndex](class_tale_worlds_1_1_core_1_1_monster.html#a6cd7d4bf070533c7b163959f7f56f0d5) `[get]` |
| sbyte[] | [BoneIndicesToModifyOnSlopingGround](class_tale_worlds_1_1_core_1_1_monster.html#adf2e468575117c86c592e7eed2e83a6f) `[get]` |
| sbyte | [BodyRotationReferenceBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a744e8e5b11d3ca20dcdd6d6bc54bf52b) `[get]` |
| sbyte | [RiderSitBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a7b7c8f34da7649f915e30addcb0ae133) `[get]` |
| sbyte | [ReinHandleBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a50c6e8d2840946f7d7e4c630498d4394) `[get]` |
| sbyte | [ReinCollision1BoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#ad0b5990f526b22082a175e3bc2d9595d) `[get]` |
| sbyte | [ReinCollision2BoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a9c0c6ef1154992e7e9edbf1d5725f166) `[get]` |
| sbyte | [ReinHeadBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#aa1a04b597427ecf14248b9f5b8721873) `[get]` |
| sbyte | [ReinHeadRightAttachmentBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#acfaa562b2e9c48d1e454473e3fbf18d5) `[get]` |
| sbyte | [ReinHeadLeftAttachmentBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a2487c600aa78e33efb297d9eaf155121) `[get]` |
| sbyte | [ReinRightHandBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a45f5e1e42a736e1c9b0ab8b70969c81c) `[get]` |
| sbyte | [ReinLeftHandBoneIndex](class_tale_worlds_1_1_core_1_1_monster.html#a012a533924cfe2e4f80f90756903d690) `[get]` |
| [IMonsterMissionData](interface_tale_worlds_1_1_core_1_1_i_monster_mission_data.html) | [MonsterMissionData](class_tale_worlds_1_1_core_1_1_monster.html#a15cdcca95eab1b9d38a0f43d5e7065ff) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a05a1d276668bb6695f7f8cab346f2422)Deserialize()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.Monster.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ab9be50218ef9d00b2819292e0b1b77e2)GetBoneToAttachForItemFlags()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| sbyte TaleWorlds.Core.Monster.GetBoneToAttachForItemFlags | ( | [ItemFlags](namespace_tale_worlds_1_1_core.html#a15c85da8a745978ee9af9c5677c007c1) | *itemFlags* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ad5030b5822638f54f9b71ac1e6a2c29c)GetBoneIndexWithId
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<string, string, sbyte> TaleWorlds.Core.Monster.GetBoneIndexWithId | | static |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aae8f596c0621a0e9db6e389459c04438)GetBoneHasParentBone
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<string, sbyte, bool> TaleWorlds.Core.Monster.GetBoneHasParentBone | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aee95d34793d0cf5333f3dbf0a9716185)BaseMonster
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.Monster.BaseMonster | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ac6e69a38451d56384395172a5e58c0f1)BodyCapsuleRadius
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.BodyCapsuleRadius | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a407a14227102921551a56e4dc5420fa5)BodyCapsulePoint1
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.Monster.BodyCapsulePoint1 | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a3714e4204e55ad7a28ee6efdb50fce7a)BodyCapsulePoint2
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.Monster.BodyCapsulePoint2 | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aa39758208aa5bf26a1fca63707eb64fa)CrouchedBodyCapsuleRadius
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.CrouchedBodyCapsuleRadius | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ae752ef576059a6d1ffec944e1d239990)CrouchedBodyCapsulePoint1
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.Monster.CrouchedBodyCapsulePoint1 | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#abd4f4d0574ca7c7450b1f4dd1a243ec3)CrouchedBodyCapsulePoint2
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.Monster.CrouchedBodyCapsulePoint2 | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a2eea232cc686245cb5543194117c2b38)Flags
---------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentFlag](namespace_tale_worlds_1_1_core.html#a4eadec2c483252505ae0d0ab98de39fe) TaleWorlds.Core.Monster.Flags | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a33c7762d2d1550db9e7f92bb572007b7)Weight
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.Monster.Weight | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ac9fe4679914d1b3f4907e12c4000bd2a)HitPoints
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.Monster.HitPoints | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a689e5dcb8f655a037345422ec5ea721b)ActionSetCode
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.Monster.ActionSetCode | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a6e794d58bf717e471a9fce2b305417d1)FemaleActionSetCode
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.Monster.FemaleActionSetCode | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a045f1f266e1e79db2a5d18da3cfb94fd)NumPaces
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.Monster.NumPaces | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ad3d3bac9533a72c2a0c79286f96b44d9)MonsterUsage
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.Monster.MonsterUsage | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aae89c28f403abba58f13e6d133470650)WalkingSpeedLimit
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.WalkingSpeedLimit | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ae965c3f82fc2483ea18b43a6a41d3839)CrouchWalkingSpeedLimit
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.CrouchWalkingSpeedLimit | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a6b2be682dee578a8642ea15c600b2f5e)JumpAcceleration
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.JumpAcceleration | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a00a722ffccd64688e003b1b96a9c3fff)AbsorbedDamageRatio
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.AbsorbedDamageRatio | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a08f096de4dcfda75307ef7f7c6b80250)SoundAndCollisionInfoClassName
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.Monster.SoundAndCollisionInfoClassName | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ad9c8020fe17590b25a9c8bc6628dfe5d)RiderCameraHeightAdder
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.RiderCameraHeightAdder | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a77f9f8c16ed1f0cf371bf3cadce8e926)RiderBodyCapsuleHeightAdder
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.RiderBodyCapsuleHeightAdder | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a59e2fe2844d52c9b75582153d37e0c20)RiderBodyCapsuleForwardAdder
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.RiderBodyCapsuleForwardAdder | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a22dedc19482635cb095544094a2b1deb)StandingChestHeight
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.StandingChestHeight | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a7fc8cfb5ec4aaed7be5cb9fc48d243a8)StandingPelvisHeight
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.StandingPelvisHeight | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a2c042b5a5c4519835b661934e670015b)StandingEyeHeight
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.StandingEyeHeight | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a098909e5db9fc57f2fd5dfef909463e9)CrouchEyeHeight
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.CrouchEyeHeight | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a9d263265fb8f13548645966058f33aa0)MountedEyeHeight
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.MountedEyeHeight | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a4644ddb8c15f688cfdaaddce82756d6f)RiderEyeHeightAdder
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.RiderEyeHeightAdder | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a75d7715ed9f75855c6cfa2e3e05a4cbc)EyeOffsetWrtHead
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.Monster.EyeOffsetWrtHead | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ad19be8d773b6c4da5ca9f23de6d7dfbc)FirstPersonCameraOffsetWrtHead
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.Monster.FirstPersonCameraOffsetWrtHead | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a0f44ea0d805897bc522a71ed9fd4ca32)ArmLength
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.ArmLength | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aede5168b7843b9afde045b0b4b1d0e87)ArmWeight
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.ArmWeight | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ae988d861ad7fdab141000fe9803dd398)JumpSpeedLimit
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.JumpSpeedLimit | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a90c0bff45827ece6559bc55d96691a38)RelativeSpeedLimitForCharge
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.Monster.RelativeSpeedLimitForCharge | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a1d48cd1823719ba1b886e6659d71c7ff)FamilyType
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.Monster.FamilyType | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a76cadd874c7d83f6c58b8e8f0b7a3273)IndicesOfRagdollBonesToCheckForCorpses
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte [] TaleWorlds.Core.Monster.IndicesOfRagdollBonesToCheckForCorpses | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a7c0bb804eafe4b8aa15fc5f7c5c27302)RagdollFallSoundBoneIndices
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte [] TaleWorlds.Core.Monster.RagdollFallSoundBoneIndices | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aaa7a8c9226c20fc23868846e334e4bed)HeadLookDirectionBoneIndex
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.HeadLookDirectionBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a368f4412aef04e00e0874ebb5443d192)SpineLowerBoneIndex
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.SpineLowerBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a7f94c2a80fa1702b451044d2c68195c4)SpineUpperBoneIndex
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.SpineUpperBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ac3693166d71d690e73b0e67b219f6e1f)ThoraxLookDirectionBoneIndex
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.ThoraxLookDirectionBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ad842c45676d1310875a0a42abaa7463b)NeckRootBoneIndex
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.NeckRootBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a3f629fc6f8e8b53d43c19ad588900ec7)PelvisBoneIndex
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.PelvisBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ac2efb7c33a4f1dfb0a8134b736567b83)RightUpperArmBoneIndex
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.RightUpperArmBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a325e7962848b666a9e967b03360b3e80)LeftUpperArmBoneIndex
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.LeftUpperArmBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a27991a8b682aed1be1a6ca0659a38430)FallBlowDamageBoneIndex
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.FallBlowDamageBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ade53f77e7e7570646babecbd5b6b1910)TerrainDecalBone0Index
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.TerrainDecalBone0Index | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a9932a845d87592d2a69d936d8bf22cf9)TerrainDecalBone1Index
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.TerrainDecalBone1Index | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a33f6436bc2b1c9559c17e6836132bedd)RagdollStationaryCheckBoneIndices
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte [] TaleWorlds.Core.Monster.RagdollStationaryCheckBoneIndices | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aa3548c0f30d5d8c49ab4a6c0e60d41f4)MoveAdderBoneIndices
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte [] TaleWorlds.Core.Monster.MoveAdderBoneIndices | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a679d60eda8eb6b689b119f38d0917b51)SplashDecalBoneIndices
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte [] TaleWorlds.Core.Monster.SplashDecalBoneIndices | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a506d9d7a23db958f7e0d6cdbb3706a4c)BloodBurstBoneIndices
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte [] TaleWorlds.Core.Monster.BloodBurstBoneIndices | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a7da03e69f875ae6a2f4014c23309ec13)MainHandBoneIndex
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.MainHandBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aa0e87e45f501ee1d6f64b82572cd9c67)OffHandBoneIndex
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.OffHandBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aacbcb0564e78e6ba9e855db4f596b991)MainHandItemBoneIndex
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.MainHandItemBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a3ed8175e60e90a0d5769b9fc44c00ce4)OffHandItemBoneIndex
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.OffHandItemBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aeb9639131e3a543d54c0cbc3ea0509e5)MainHandItemSecondaryBoneIndex
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.MainHandItemSecondaryBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a7bb01490e16c14d3a40709b3ff1403cb)OffHandItemSecondaryBoneIndex
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.OffHandItemSecondaryBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ab63bff6d6ecd90004398ab31b706715d)OffHandShoulderBoneIndex
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.OffHandShoulderBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aaaf5b71929f750f31e9b4934a7d3cc1d)HandNumBonesForIk
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.HandNumBonesForIk | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aebdb066002ceb864826e06424ff0f235)PrimaryFootBoneIndex
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.PrimaryFootBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a9688bc64748b7f81c985c577cdc98034)SecondaryFootBoneIndex
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.SecondaryFootBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a49ce6c6216a7e1025222e635be7cf2b2)RightFootIkEndEffectorBoneIndex
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.RightFootIkEndEffectorBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a628e904c3449b2d1bc0f0a65df1cc500)LeftFootIkEndEffectorBoneIndex
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.LeftFootIkEndEffectorBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ab3c4c0ea6453c9867f1b4e3c85af345f)RightFootIkTipBoneIndex
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.RightFootIkTipBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a4a296a16c4d6266eb98dc3c8d703cb0e)LeftFootIkTipBoneIndex
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.LeftFootIkTipBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a41024605c8dd73f66768230b5b6bdbb1)FootNumBonesForIk
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.FootNumBonesForIk | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a5e5256edf705a37992773819a3a12fbf)ReinHandleLeftLocalPosition
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.Monster.ReinHandleLeftLocalPosition | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a85859a8d475b2f2cf38e79c80a42f09c)ReinHandleRightLocalPosition
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.Monster.ReinHandleRightLocalPosition | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a105917aff8b6610f41001daf7a434587)ReinSkeleton
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.Monster.ReinSkeleton | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a5452de68d70fe4be240ed25869101f66)ReinCollisionBody
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.Monster.ReinCollisionBody | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ae6af61ce0d500db344e6a9aa5a0410b3)FrontBoneToDetectGroundSlopeIndex
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.FrontBoneToDetectGroundSlopeIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a6cd7d4bf070533c7b163959f7f56f0d5)BackBoneToDetectGroundSlopeIndex
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.BackBoneToDetectGroundSlopeIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#adf2e468575117c86c592e7eed2e83a6f)BoneIndicesToModifyOnSlopingGround
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte [] TaleWorlds.Core.Monster.BoneIndicesToModifyOnSlopingGround | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a744e8e5b11d3ca20dcdd6d6bc54bf52b)BodyRotationReferenceBoneIndex
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.BodyRotationReferenceBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a7b7c8f34da7649f915e30addcb0ae133)RiderSitBoneIndex
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.RiderSitBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a50c6e8d2840946f7d7e4c630498d4394)ReinHandleBoneIndex
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.ReinHandleBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#ad0b5990f526b22082a175e3bc2d9595d)ReinCollision1BoneIndex
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.ReinCollision1BoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a9c0c6ef1154992e7e9edbf1d5725f166)ReinCollision2BoneIndex
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.ReinCollision2BoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#aa1a04b597427ecf14248b9f5b8721873)ReinHeadBoneIndex
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.ReinHeadBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#acfaa562b2e9c48d1e454473e3fbf18d5)ReinHeadRightAttachmentBoneIndex
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.ReinHeadRightAttachmentBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a2487c600aa78e33efb297d9eaf155121)ReinHeadLeftAttachmentBoneIndex
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.ReinHeadLeftAttachmentBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a45f5e1e42a736e1c9b0ab8b70969c81c)ReinRightHandBoneIndex
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.ReinRightHandBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a012a533924cfe2e4f80f90756903d690)ReinLeftHandBoneIndex
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte TaleWorlds.Core.Monster.ReinLeftHandBoneIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_monster.html#a15cdcca95eab1b9d38a0f43d5e7065ff)MonsterMissionData
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMonsterMissionData](interface_tale_worlds_1_1_core_1_1_i_monster_mission_data.html) TaleWorlds.Core.Monster.MonsterMissionData | | get |


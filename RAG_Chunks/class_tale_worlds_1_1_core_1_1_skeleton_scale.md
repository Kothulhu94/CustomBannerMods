--- SOURCE: class_tale_worlds_1_1_core_1_1_skeleton_scale.html ---

TaleWorlds.Core.SkeletonScale Class ReferencesealedInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SkeletonScale](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#a5f1eb4700c59589b92a960955156b1da) () |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#acca9aef8c4b9dd8c2464cce31ba07921) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| void | [SetBoneIndices](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#a6bd412556b08c4f8962358e302f736ef) (sbyte[] boneIndices) |
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
| Properties | |
| string | [SkeletonModel](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#a14ac857ac9b6b3540659edcfa850912d) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [MountSitBoneScale](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#a9a39b32dbcc0e06e3c6d01acfdf45f19) `[get]` |
| float | [MountRadiusAdder](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#aefd889f0941b0cd5f67d02167c881c41) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] | [Scales](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#a23f9e8fe974e27cc3c33b24963b0da9d) `[get]` |
| List< string > | [BoneNames](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#ad453f655d03cb5a1ea52c520545f84cb) `[get]` |
| sbyte[] | [BoneIndices](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#a301f7f1708591dc69750c024d08cda0f) `[get]` |
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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#a5f1eb4700c59589b92a960955156b1da)SkeletonScale()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.SkeletonScale.SkeletonScale | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#acca9aef8c4b9dd8c2464cce31ba07921)Deserialize()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.SkeletonScale.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#a6bd412556b08c4f8962358e302f736ef)SetBoneIndices()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.SkeletonScale.SetBoneIndices | ( | sbyte[] | *boneIndices* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#a14ac857ac9b6b3540659edcfa850912d)SkeletonModel
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.SkeletonScale.SkeletonModel | | get |

[◆](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#a9a39b32dbcc0e06e3c6d01acfdf45f19)MountSitBoneScale
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.SkeletonScale.MountSitBoneScale | | get |

[◆](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#aefd889f0941b0cd5f67d02167c881c41)MountRadiusAdder
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.SkeletonScale.MountRadiusAdder | | get |

[◆](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#a23f9e8fe974e27cc3c33b24963b0da9d)Scales
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) [] TaleWorlds.Core.SkeletonScale.Scales | | get |

[◆](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#ad453f655d03cb5a1ea52c520545f84cb)BoneNames
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<string> TaleWorlds.Core.SkeletonScale.BoneNames | | get |

[◆](class_tale_worlds_1_1_core_1_1_skeleton_scale.html#a301f7f1708591dc69750c024d08cda0f)BoneIndices
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | sbyte [] TaleWorlds.Core.SkeletonScale.BoneIndices | | get |


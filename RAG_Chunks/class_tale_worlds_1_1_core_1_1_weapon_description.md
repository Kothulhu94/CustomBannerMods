--- SOURCE: class_tale_worlds_1_1_core_1_1_weapon_description.html ---

TaleWorlds.Core.WeaponDescription Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_weapon_description.html#ad535e8456c6c30d3678c8935aa38c741) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
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
| Public Attributes | |
| bool | [UseCenterOfMassAsHandBase](class_tale_worlds_1_1_core_1_1_weapon_description.html#a45ab8a5be37b6347b532c6edf6bd211d) |

|  |  |
| --- | --- |
| Properties | |
| [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | [WeaponClass](class_tale_worlds_1_1_core_1_1_weapon_description.html#a6634d9dd1099ebc8310afc7b99eaf0c0) `[get]` |
| [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | [WeaponFlags](class_tale_worlds_1_1_core_1_1_weapon_description.html#a6cded63c0232be880824f81dc21f8399) `[get]` |
| string | [ItemUsageFeatures](class_tale_worlds_1_1_core_1_1_weapon_description.html#a98033ef14f54b8820df6f0cdb41fc0f0) `[get]` |
| bool | [RotatedInHand](class_tale_worlds_1_1_core_1_1_weapon_description.html#a2b600b46d30b5be7ba30d97d4c30e202) `[get]` |
| bool | [IsHiddenFromUI](class_tale_worlds_1_1_core_1_1_weapon_description.html#a4096ffc21ae2b4de3440944f42087715) `[get, set]` |
| MBReadOnlyList< [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) > | [AvailablePieces](class_tale_worlds_1_1_core_1_1_weapon_description.html#af2aceebaa4509f1bf5d82b94d5a84fab) `[get]` |
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

[◆](class_tale_worlds_1_1_core_1_1_weapon_description.html#ad535e8456c6c30d3678c8935aa38c741)Deserialize()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.WeaponDescription.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_description.html#a45ab8a5be37b6347b532c6edf6bd211d)UseCenterOfMassAsHandBase
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.Core.WeaponDescription.UseCenterOfMassAsHandBase |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_description.html#a6634d9dd1099ebc8310afc7b99eaf0c0)WeaponClass
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) TaleWorlds.Core.WeaponDescription.WeaponClass | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_description.html#a6cded63c0232be880824f81dc21f8399)WeaponFlags
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) TaleWorlds.Core.WeaponDescription.WeaponFlags | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_description.html#a98033ef14f54b8820df6f0cdb41fc0f0)ItemUsageFeatures
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.WeaponDescription.ItemUsageFeatures | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_description.html#a2b600b46d30b5be7ba30d97d4c30e202)RotatedInHand
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponDescription.RotatedInHand | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_description.html#a4096ffc21ae2b4de3440944f42087715)IsHiddenFromUI
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponDescription.IsHiddenFromUI | | getset |

[◆](class_tale_worlds_1_1_core_1_1_weapon_description.html#af2aceebaa4509f1bf5d82b94d5a84fab)AvailablePieces
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html)> TaleWorlds.Core.WeaponDescription.AvailablePieces | | get |


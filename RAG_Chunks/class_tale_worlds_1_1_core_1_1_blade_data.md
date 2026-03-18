--- SOURCE: class_tale_worlds_1_1_core_1_1_blade_data.html ---

TaleWorlds.Core.BladeData Class ReferencesealedInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BladeData](class_tale_worlds_1_1_core_1_1_blade_data.html#adf6f8143c6110edf92bdc7dc72eb2db2) ([CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) pieceType, float bladeLength) |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_blade_data.html#adb04ae5c60e4f772a221a1bfc51f70da) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode childNode) |
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
| readonly [CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) | [PieceType](class_tale_worlds_1_1_core_1_1_blade_data.html#a387369d51d13fdd0f52e8398d6913ac0) |

|  |  |
| --- | --- |
| Properties | |
| [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | [ThrustDamageType](class_tale_worlds_1_1_core_1_1_blade_data.html#abbbc6522ff5554248a534feeb981d11b) `[get]` |
| float | [ThrustDamageFactor](class_tale_worlds_1_1_core_1_1_blade_data.html#a2cef12715d130076ab6ca02ef025d705) `[get]` |
| [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | [SwingDamageType](class_tale_worlds_1_1_core_1_1_blade_data.html#a50cabd80b7122039e2321b64cf8ee3a9) `[get]` |
| float | [SwingDamageFactor](class_tale_worlds_1_1_core_1_1_blade_data.html#a6a2def3b61541a2e05a1e15614831616) `[get]` |
| float | [BladeLength](class_tale_worlds_1_1_core_1_1_blade_data.html#a358ae4471a5b21b5175a11c13a87ff8f) `[get]` |
| float | [BladeWidth](class_tale_worlds_1_1_core_1_1_blade_data.html#a349af0254fcd5d33281965f6cde650a2) `[get]` |
| short | [StackAmount](class_tale_worlds_1_1_core_1_1_blade_data.html#a36ce84930d0c8f8c6a1bef1fc2f2f8cd) `[get]` |
| string | [PhysicsMaterial](class_tale_worlds_1_1_core_1_1_blade_data.html#a0c6aba98dc930e32a4708ec188f51340) `[get]` |
| string | [BodyName](class_tale_worlds_1_1_core_1_1_blade_data.html#a83da8a7aae58bc3e914b86083765a778) `[get]` |
| string | [HolsterMeshName](class_tale_worlds_1_1_core_1_1_blade_data.html#a2f115925ac85208d85750a921cf57d5d) `[get]` |
| string | [HolsterBodyName](class_tale_worlds_1_1_core_1_1_blade_data.html#a9a77b7f18eff734b62bccf93ff66c93e) `[get]` |
| float | [HolsterMeshLength](class_tale_worlds_1_1_core_1_1_blade_data.html#a3ea10634edd8a4dd4e0c87e0bb5845ba) `[get]` |
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

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#adf6f8143c6110edf92bdc7dc72eb2db2)BladeData()
------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.BladeData.BladeData | ( | [CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) | *pieceType*, |
|  |  | float | *bladeLength* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#adb04ae5c60e4f772a221a1bfc51f70da)Deserialize()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.BladeData.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *childNode* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#a387369d51d13fdd0f52e8398d6913ac0)PieceType
----------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) TaleWorlds.Core.BladeData.PieceType |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#abbbc6522ff5554248a534feeb981d11b)ThrustDamageType
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) TaleWorlds.Core.BladeData.ThrustDamageType | | get |

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#a2cef12715d130076ab6ca02ef025d705)ThrustDamageFactor
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BladeData.ThrustDamageFactor | | get |

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#a50cabd80b7122039e2321b64cf8ee3a9)SwingDamageType
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) TaleWorlds.Core.BladeData.SwingDamageType | | get |

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#a6a2def3b61541a2e05a1e15614831616)SwingDamageFactor
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BladeData.SwingDamageFactor | | get |

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#a358ae4471a5b21b5175a11c13a87ff8f)BladeLength
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BladeData.BladeLength | | get |

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#a349af0254fcd5d33281965f6cde650a2)BladeWidth
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BladeData.BladeWidth | | get |

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#a36ce84930d0c8f8c6a1bef1fc2f2f8cd)StackAmount
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.Core.BladeData.StackAmount | | get |

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#a0c6aba98dc930e32a4708ec188f51340)PhysicsMaterial
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.BladeData.PhysicsMaterial | | get |

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#a83da8a7aae58bc3e914b86083765a778)BodyName
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.BladeData.BodyName | | get |

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#a2f115925ac85208d85750a921cf57d5d)HolsterMeshName
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.BladeData.HolsterMeshName | | get |

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#a9a77b7f18eff734b62bccf93ff66c93e)HolsterBodyName
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.BladeData.HolsterBodyName | | get |

[◆](class_tale_worlds_1_1_core_1_1_blade_data.html#a3ea10634edd8a4dd4e0c87e0bb5845ba)HolsterMeshLength
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BladeData.HolsterMeshLength | | get |


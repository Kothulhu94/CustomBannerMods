--- SOURCE: class_tale_worlds_1_1_core_1_1_ship_slot.html ---

TaleWorlds.Core.ShipSlot Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ShipSlot](class_tale_worlds_1_1_core_1_1_ship_slot.html#a89431ecce5191d32fa57ab591e42c92a) () |
| override void | [AfterRegister](class_tale_worlds_1_1_core_1_1_ship_slot.html#a4ca1f874973557bf44d1af959fb67e87) () |
| void | [AddMatchingPiece](class_tale_worlds_1_1_core_1_1_ship_slot.html#a8bccfae5e1cbb01ab14787ebdf2096dd) ([ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html) upgradePiece) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSlotTypeName](class_tale_worlds_1_1_core_1_1_ship_slot.html#a082eafb34c1448e6675daa6fcea4d125) () |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_ship_slot.html#affa787d9c72de9577e1c542875a376e8) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
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
| string | [TypeId](class_tale_worlds_1_1_core_1_1_ship_slot.html#a0b73d1c47543fae3a5ca60bad015e052) `[get]` |
| string | [MainPrefabId](class_tale_worlds_1_1_core_1_1_ship_slot.html#a647597806da4da78079476454e7bf6f8) `[get]` |
| MBReadOnlyList< [ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html) > | [MatchingPieces](class_tale_worlds_1_1_core_1_1_ship_slot.html#ad2fa8d213b7d081b2a47da40ee00dfd7) `[get]` |
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

[◆](class_tale_worlds_1_1_core_1_1_ship_slot.html#a89431ecce5191d32fa57ab591e42c92a)ShipSlot()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.ShipSlot.ShipSlot | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_ship_slot.html#a4ca1f874973557bf44d1af959fb67e87)AfterRegister()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Core.ShipSlot.AfterRegister | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216).

[◆](class_tale_worlds_1_1_core_1_1_ship_slot.html#a8bccfae5e1cbb01ab14787ebdf2096dd)AddMatchingPiece()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ShipSlot.AddMatchingPiece | ( | [ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html) | *upgradePiece* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_ship_slot.html#a082eafb34c1448e6675daa6fcea4d125)GetSlotTypeName()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.ShipSlot.GetSlotTypeName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_ship_slot.html#affa787d9c72de9577e1c542875a376e8)Deserialize()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.ShipSlot.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_ship_slot.html#a0b73d1c47543fae3a5ca60bad015e052)TypeId
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ShipSlot.TypeId | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_slot.html#a647597806da4da78079476454e7bf6f8)MainPrefabId
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ShipSlot.MainPrefabId | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_slot.html#ad2fa8d213b7d081b2a47da40ee00dfd7)MatchingPieces
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html)> TaleWorlds.Core.ShipSlot.MatchingPieces | | get |


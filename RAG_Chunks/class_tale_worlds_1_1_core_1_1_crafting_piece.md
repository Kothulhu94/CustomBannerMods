--- SOURCE: class_tale_worlds_1_1_core_1_1_crafting_piece.html ---

TaleWorlds.Core.CraftingPiece Class ReferencesealedInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) {     [Invalid](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6aa4bbb8f967da6d1a610596d7257179c2b) = -1 ,     [Blade](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6aa1ea52f26e7e0ce08e462f87f5e35096c) ,     [Guard](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6aa57cc9b210b0e3ff7b28013cec3d36acf) ,     [Handle](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6aac0eab4629ee23a645d4747074335ba60) ,     [Pommel](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6aab895523503d4a8b7a7370a9e446b4bc9) ,     [NumberOfPieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6aa48a97b511576f2c2b6629758ed24925b)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ad9b5e810cad20e201a52292806d32553) () |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_crafting_piece.html#aebf37641303ff19862cb12dbd0bce727) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
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
| Static Public Member Functions | |
| static [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ad9b5e810cad20e201a52292806d32553) | [GetInvalidCraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a42d22846353ee2e28ddf596fb5bc22e4) ([PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) pieceType) |

|  |  |
| --- | --- |
| Public Attributes | |
| [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | [AdditionalWeaponFlags](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a61ee73295c3492b233d39f0a34c75876) |
| [ItemFlags](namespace_tale_worlds_1_1_core.html#a15c85da8a745978ee9af9c5677c007c1) | [AdditionalItemFlags](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a8174931887662a1c2c9478d38c434d6e) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a446a16a14f6f35ad047975bfca707868) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a63be7cc7a8221ffa561c05575a405b44) `[get]` |
| [PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) | [PieceType](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ad8bd831684c83ecb0bd5e07d46822731) `[get]` |
| string | [MeshName](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ad42b26029553d585a2a26563f6cb2afe) `[get]` |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [Culture](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a6fc0ea2622d2af41e429a2ac0cc42c9d) `[get]` |
| float | [Length](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a95f970d5d113d4d5e74b8a6080df398d) `[get]` |
| float | [DistanceToNextPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a1c1f480ab287677bbdbd1a74970de25b) `[get]` |
| float | [DistanceToPreviousPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a972971edab70b5bf865a0dcf0a4fc095) `[get]` |
| float | [PieceOffset](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ab70dcf0ae44569e2b7a5db8f031ae26f) `[get]` |
| float | [PreviousPieceOffset](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ac44fec80ee79b93623ee1de36f3b88d2) `[get]` |
| float | [NextPieceOffset](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a790861517e7153cb938525fa02454a55) `[get]` |
| float | [Weight](class_tale_worlds_1_1_core_1_1_crafting_piece.html#adc200d29e9d5bdbd2dd5c31c03334c36) `[get]` |
| float | [Inertia](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a990ac7173781a76eff9bdfe824790fb9) `[get]` |
| float | [CenterOfMass](class_tale_worlds_1_1_core_1_1_crafting_piece.html#afda39ff31d1d415c5b1e34236237b03b) `[get]` |
| int | [ArmorBonus](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a5fb2ec2094897d654f3cef309444cfcf) `[get]` |
| int | [SwingDamageBonus](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a657e6ee78d18eca7a8ca7033c661a9ea) `[get]` |
| int | [SwingSpeedBonus](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a75142c7a8659702b744b9bfb2137fea8) `[get]` |
| int | [ThrustDamageBonus](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a304e118296b0a1b630df58c20d1b7e94) `[get]` |
| int | [ThrustSpeedBonus](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a8ec326121b6b1c309c11c65dfd65533b) `[get]` |
| int | [HandlingBonus](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a20c148b9c0ca688eac364e7ad53e22b4) `[get]` |
| int | [AccuracyBonus](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ab9f8bb8d48c90948668f24c7baff911a) `[get]` |
| int | [PieceTier](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ad91efc80b5e8d7db718da80c5d386c9f) `[get]` |
| bool | [FullScale](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ae420aa543061dbde1bcc7188a501799e) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [ItemHolsterPosShift](class_tale_worlds_1_1_core_1_1_crafting_piece.html#af0f1409aa8f224ef8d3a6384bf9bb8f6) `[get]` |
| float | [Appearance](class_tale_worlds_1_1_core_1_1_crafting_piece.html#aa29c50cb6c6d488d0de8191ddd11010d) `[get]` |
| bool | [IsGivenByDefault](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ae4a8c2af89edeb8b803f13c1a9f98afe) `[get]` |
| bool | [IsHiddenOnDesigner](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a8178f57f049b6e8d0434c4e8c84f66e1) `[get]` |
| bool | [IsUnique](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a2eebac4c3b7def17226f8176b04f3feb) `[get]` |
| string | [ItemUsageFeaturesToExclude](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a51be624293fd0ee1f6b3816b9d29f96b) `[get]` |
| MBReadOnlyList<([CraftingMaterials](namespace_tale_worlds_1_1_core.html#ac393a05bb383e95156b22888e4e23795), int)> | [MaterialsUsed](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a65375c1bca5742c27d3e19c04225f3ff) `[get]` |
| bool | [IsEmptyPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html#af39eef247461f8ed10c4302c1b8f4c08) `[get]` |
| int | [CraftingCost](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ab237b82b5eb929a07d95199fe0e53366) `[get]` |
| int | [RequiredSkillValue](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a0c0f81e26c08eb4c6fc160c28095584c) `[get]` |
| BladeData | [BladeData](class_tale_worlds_1_1_core_1_1_crafting_piece.html#aa6a937e10e860416df4fcd152a866210) `[get]` |
| static MBReadOnlyList< [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ad9b5e810cad20e201a52292806d32553) > | [All](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a65e3968e0f107ff873ea1c486e350de6) `[get]` |
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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a)PieceTypes
---------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) |

| Enumerator | |
| --- | --- |
| Invalid |  |
| Blade |  |
| Guard |  |
| Handle |  |
| Pommel |  |
| NumberOfPieceTypes |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ad9b5e810cad20e201a52292806d32553)CraftingPiece()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.CraftingPiece.CraftingPiece | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a42d22846353ee2e28ddf596fb5bc22e4)GetInvalidCraftingPiece()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ad9b5e810cad20e201a52292806d32553) TaleWorlds.Core.CraftingPiece.GetInvalidCraftingPiece | ( | [PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) | *pieceType* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#aebf37641303ff19862cb12dbd0bce727)Deserialize()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.CraftingPiece.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a61ee73295c3492b233d39f0a34c75876)AdditionalWeaponFlags
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) TaleWorlds.Core.CraftingPiece.AdditionalWeaponFlags |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a8174931887662a1c2c9478d38c434d6e)AdditionalItemFlags
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ItemFlags](namespace_tale_worlds_1_1_core.html#a15c85da8a745978ee9af9c5677c007c1) TaleWorlds.Core.CraftingPiece.AdditionalItemFlags |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a446a16a14f6f35ad047975bfca707868)IsValid
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.CraftingPiece.IsValid | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a63be7cc7a8221ffa561c05575a405b44)Name
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.CraftingPiece.Name | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ad8bd831684c83ecb0bd5e07d46822731)PieceType
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) TaleWorlds.Core.CraftingPiece.PieceType | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ad42b26029553d585a2a26563f6cb2afe)MeshName
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.CraftingPiece.MeshName | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a6fc0ea2622d2af41e429a2ac0cc42c9d)Culture
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.Core.CraftingPiece.Culture | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a95f970d5d113d4d5e74b8a6080df398d)Length
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.CraftingPiece.Length | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a1c1f480ab287677bbdbd1a74970de25b)DistanceToNextPiece
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.CraftingPiece.DistanceToNextPiece | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a972971edab70b5bf865a0dcf0a4fc095)DistanceToPreviousPiece
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.CraftingPiece.DistanceToPreviousPiece | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ab70dcf0ae44569e2b7a5db8f031ae26f)PieceOffset
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.CraftingPiece.PieceOffset | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ac44fec80ee79b93623ee1de36f3b88d2)PreviousPieceOffset
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.CraftingPiece.PreviousPieceOffset | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a790861517e7153cb938525fa02454a55)NextPieceOffset
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.CraftingPiece.NextPieceOffset | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#adc200d29e9d5bdbd2dd5c31c03334c36)Weight
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.CraftingPiece.Weight | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a990ac7173781a76eff9bdfe824790fb9)Inertia
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.CraftingPiece.Inertia | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#afda39ff31d1d415c5b1e34236237b03b)CenterOfMass
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.CraftingPiece.CenterOfMass | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a5fb2ec2094897d654f3cef309444cfcf)ArmorBonus
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.CraftingPiece.ArmorBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a657e6ee78d18eca7a8ca7033c661a9ea)SwingDamageBonus
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.CraftingPiece.SwingDamageBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a75142c7a8659702b744b9bfb2137fea8)SwingSpeedBonus
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.CraftingPiece.SwingSpeedBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a304e118296b0a1b630df58c20d1b7e94)ThrustDamageBonus
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.CraftingPiece.ThrustDamageBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a8ec326121b6b1c309c11c65dfd65533b)ThrustSpeedBonus
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.CraftingPiece.ThrustSpeedBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a20c148b9c0ca688eac364e7ad53e22b4)HandlingBonus
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.CraftingPiece.HandlingBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ab9f8bb8d48c90948668f24c7baff911a)AccuracyBonus
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.CraftingPiece.AccuracyBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ad91efc80b5e8d7db718da80c5d386c9f)PieceTier
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.CraftingPiece.PieceTier | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ae420aa543061dbde1bcc7188a501799e)FullScale
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.CraftingPiece.FullScale | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#af0f1409aa8f224ef8d3a6384bf9bb8f6)ItemHolsterPosShift
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.CraftingPiece.ItemHolsterPosShift | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#aa29c50cb6c6d488d0de8191ddd11010d)Appearance
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.CraftingPiece.Appearance | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ae4a8c2af89edeb8b803f13c1a9f98afe)IsGivenByDefault
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.CraftingPiece.IsGivenByDefault | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a8178f57f049b6e8d0434c4e8c84f66e1)IsHiddenOnDesigner
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.CraftingPiece.IsHiddenOnDesigner | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a2eebac4c3b7def17226f8176b04f3feb)IsUnique
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.CraftingPiece.IsUnique | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a51be624293fd0ee1f6b3816b9d29f96b)ItemUsageFeaturesToExclude
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.CraftingPiece.ItemUsageFeaturesToExclude | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a65375c1bca5742c27d3e19c04225f3ff)MaterialsUsed
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<([CraftingMaterials](namespace_tale_worlds_1_1_core.html#ac393a05bb383e95156b22888e4e23795), int)> TaleWorlds.Core.CraftingPiece.MaterialsUsed | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#af39eef247461f8ed10c4302c1b8f4c08)IsEmptyPiece
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.CraftingPiece.IsEmptyPiece | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ab237b82b5eb929a07d95199fe0e53366)CraftingCost
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.CraftingPiece.CraftingCost | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a0c0f81e26c08eb4c6fc160c28095584c)RequiredSkillValue
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.CraftingPiece.RequiredSkillValue | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#aa6a937e10e860416df4fcd152a866210)BladeData
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | BladeData TaleWorlds.Core.CraftingPiece.BladeData | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_piece.html#a65e3968e0f107ff873ea1c486e350de6)All
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html#ad9b5e810cad20e201a52292806d32553)> TaleWorlds.Core.CraftingPiece.All | | staticget |


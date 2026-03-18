--- SOURCE: class_tale_worlds_1_1_core_1_1_crafting_template.html ---

TaleWorlds.Core.CraftingTemplate Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [CraftingStatTypes](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4d) {     [Weight](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4da8c489d0946f66d17d73f26366a4bf620) ,     [WeaponReach](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4da37959376ced4e31f920c4632ce022616) ,     [ThrustSpeed](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4daada128f29e0ae70112f694d46ccfc7bd) ,     [SwingSpeed](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4da2ed73a310fffb602ff998dd028901511) ,     [ThrustDamage](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4da01690427e650332adac2f4eb9c63a262) ,     [SwingDamage](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4dad7d30c08ad43651404a58ae160becf5f) ,     [Handling](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4da2605fbb693837be42d0cd0e701cb5aa3) ,     [MissileDamage](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4da295dc701b090fa62b3d5f7544d90f786) ,     [MissileSpeed](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4da6808ce0104928c513abf4677858cdb8d) ,     [Accuracy](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4dad78f1fb7e69f7cddcf3e168f2663db20) ,     [StackAmount](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4da3197fbc96db09ac20515c04ff57a28c8) ,     [NumStatTypes](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4da0cea7ea11d9a095622235287ba6e4c94)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html#a22f453d8d4046e6226d02f30fa6c6a89) () |
|  | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html#a4c2f6307c57a997d20cfe988aa8cc525) (string stringId) |
| int | [GetIndexOfUsageDataWithId](class_tale_worlds_1_1_core_1_1_crafting_template.html#a92f01366f9c6104b00e02aac3c020fb9) (string weaponDescriptionId) |
| bool | [IsPieceTypeHiddenOnHolster](class_tale_worlds_1_1_core_1_1_crafting_template.html#a352695f99e4c23fd9c7149c8d3cf350b) ([CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) pieceType) |
| IEnumerable< KeyValuePair< [CraftingStatTypes](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4d), float > > | [GetStatDatas](class_tale_worlds_1_1_core_1_1_crafting_template.html#a7da8d0a67d0d80a33b6a6b25d33aeb25) (string weaponDescriptionId, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) thrustDamageType, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) swingDamageType) |
| override string | [ToString](class_tale_worlds_1_1_core_1_1_crafting_template.html#a639e521ffa481c14faee47abd50d087a) () |
| bool | [IsPieceTypeUsable](class_tale_worlds_1_1_core_1_1_crafting_template.html#a8f2491fd2902bb39109da28b8f8295f6) ([CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) pieceType) |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_crafting_template.html#a9da5d8fe64095c833eb890a5565091a4) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
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
| static [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html#a22f453d8d4046e6226d02f30fa6c6a89) | [GetTemplateFromId](class_tale_worlds_1_1_core_1_1_crafting_template.html#ab5c8ff9bc69cae2a24f1ad69471d2835) (string templateId) |

|  |  |
| --- | --- |
| Public Attributes | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TemplateName](class_tale_worlds_1_1_core_1_1_crafting_template.html#a87060c06b52416357caf197f0758850b) |

|  |  |
| --- | --- |
| Properties | |
| [PieceData](struct_tale_worlds_1_1_core_1_1_piece_data.html)[] | [BuildOrders](class_tale_worlds_1_1_core_1_1_crafting_template.html#af65ced1868f8202ba5d41096aac54d5b) `[get]` |
| [WeaponDescription](class_tale_worlds_1_1_core_1_1_weapon_description.html)[] | [WeaponDescriptions](class_tale_worlds_1_1_core_1_1_crafting_template.html#a8e94af619cef374c7ecdbd7fa20f0a62) `[get]` |
| List< [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) > | [Pieces](class_tale_worlds_1_1_core_1_1_crafting_template.html#a0f0e3701c2afaa1405781d12bfb51b30) `[get]` |
| [ItemObject.ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) | [ItemType](class_tale_worlds_1_1_core_1_1_crafting_template.html#a0c267d32ae848960a3e437ebced2ce17) `[get]` |
| ItemModifierGroup | [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_crafting_template.html#a8f0f873759b8f0415d7267fb5466e3fd) `[get]` |
| string[] | [ItemHolsters](class_tale_worlds_1_1_core_1_1_crafting_template.html#a40fb0f495940fbefe71bb5d2b09dedfb) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [ItemHolsterPositionShift](class_tale_worlds_1_1_core_1_1_crafting_template.html#a552b7b5a912311695b29b1c1cafbb737) `[get]` |
| bool | [UseWeaponAsHolsterMesh](class_tale_worlds_1_1_core_1_1_crafting_template.html#a98972099779422cb1cb52fa26fc35a43) `[get]` |
| bool | [AlwaysShowHolsterWithWeapon](class_tale_worlds_1_1_core_1_1_crafting_template.html#a339bc8b98d1c5c869cc36fa4fa98d68c) `[get]` |
| bool | [RotateWeaponInHolster](class_tale_worlds_1_1_core_1_1_crafting_template.html#a6f96e7698e4cd2023d6d813378f29cc3) `[get]` |
| [CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) | [PieceTypeToScaleHolsterWith](class_tale_worlds_1_1_core_1_1_crafting_template.html#aeec9b92c35fe43ac6509845579118be7) `[get]` |
| static MBReadOnlyList< [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html#a22f453d8d4046e6226d02f30fa6c6a89) > | [All](class_tale_worlds_1_1_core_1_1_crafting_template.html#a0abc78f67a248974b17904ce7731d266) `[get]` |
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

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4d)CraftingStatTypes
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.CraftingTemplate.CraftingStatTypes](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4d) |

| Enumerator | |
| --- | --- |
| Weight |  |
| WeaponReach |  |
| ThrustSpeed |  |
| SwingSpeed |  |
| ThrustDamage |  |
| SwingDamage |  |
| Handling |  |
| MissileDamage |  |
| MissileSpeed |  |
| Accuracy |  |
| StackAmount |  |
| NumStatTypes |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a22f453d8d4046e6226d02f30fa6c6a89)CraftingTemplate() [1/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.CraftingTemplate.CraftingTemplate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a4c2f6307c57a997d20cfe988aa8cc525)CraftingTemplate() [2/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.CraftingTemplate.CraftingTemplate | ( | string | *stringId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a92f01366f9c6104b00e02aac3c020fb9)GetIndexOfUsageDataWithId()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.CraftingTemplate.GetIndexOfUsageDataWithId | ( | string | *weaponDescriptionId* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a352695f99e4c23fd9c7149c8d3cf350b)IsPieceTypeHiddenOnHolster()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.CraftingTemplate.IsPieceTypeHiddenOnHolster | ( | [CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) | *pieceType* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a7da8d0a67d0d80a33b6a6b25d33aeb25)GetStatDatas()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| IEnumerable< KeyValuePair< [CraftingStatTypes](class_tale_worlds_1_1_core_1_1_crafting_template.html#ad538bf5ce7b134bfbbe5e8d38d72ff4d), float > > TaleWorlds.Core.CraftingTemplate.GetStatDatas | ( | string | *weaponDescriptionId*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *thrustDamageType*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *swingDamageType* ) |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a639e521ffa481c14faee47abd50d087a)ToString()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Core.CraftingTemplate.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a8f2491fd2902bb39109da28b8f8295f6)IsPieceTypeUsable()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.CraftingTemplate.IsPieceTypeUsable | ( | [CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) | *pieceType* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a9da5d8fe64095c833eb890a5565091a4)Deserialize()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.CraftingTemplate.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#ab5c8ff9bc69cae2a24f1ad69471d2835)GetTemplateFromId()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html#a22f453d8d4046e6226d02f30fa6c6a89) TaleWorlds.Core.CraftingTemplate.GetTemplateFromId | ( | string | *templateId* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a87060c06b52416357caf197f0758850b)TemplateName
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.CraftingTemplate.TemplateName |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#af65ced1868f8202ba5d41096aac54d5b)BuildOrders
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PieceData](struct_tale_worlds_1_1_core_1_1_piece_data.html) [] TaleWorlds.Core.CraftingTemplate.BuildOrders | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a8e94af619cef374c7ecdbd7fa20f0a62)WeaponDescriptions
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponDescription](class_tale_worlds_1_1_core_1_1_weapon_description.html) [] TaleWorlds.Core.CraftingTemplate.WeaponDescriptions | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a0f0e3701c2afaa1405781d12bfb51b30)Pieces
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html)> TaleWorlds.Core.CraftingTemplate.Pieces | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a0c267d32ae848960a3e437ebced2ce17)ItemType
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemObject.ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) TaleWorlds.Core.CraftingTemplate.ItemType | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a8f0f873759b8f0415d7267fb5466e3fd)ItemModifierGroup
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ItemModifierGroup TaleWorlds.Core.CraftingTemplate.ItemModifierGroup | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a40fb0f495940fbefe71bb5d2b09dedfb)ItemHolsters
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string [] TaleWorlds.Core.CraftingTemplate.ItemHolsters | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a552b7b5a912311695b29b1c1cafbb737)ItemHolsterPositionShift
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.CraftingTemplate.ItemHolsterPositionShift | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a98972099779422cb1cb52fa26fc35a43)UseWeaponAsHolsterMesh
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.CraftingTemplate.UseWeaponAsHolsterMesh | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a339bc8b98d1c5c869cc36fa4fa98d68c)AlwaysShowHolsterWithWeapon
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.CraftingTemplate.AlwaysShowHolsterWithWeapon | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a6f96e7698e4cd2023d6d813378f29cc3)RotateWeaponInHolster
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.CraftingTemplate.RotateWeaponInHolster | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#aeec9b92c35fe43ac6509845579118be7)PieceTypeToScaleHolsterWith
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) TaleWorlds.Core.CraftingTemplate.PieceTypeToScaleHolsterWith | | get |

[◆](class_tale_worlds_1_1_core_1_1_crafting_template.html#a0abc78f67a248974b17904ce7731d266)All
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html#a22f453d8d4046e6226d02f30fa6c6a89)> TaleWorlds.Core.CraftingTemplate.All | | staticget |


--- SOURCE: class_tale_worlds_1_1_core_1_1_armor_component.html ---

TaleWorlds.Core.ArmorComponent Class ReferenceInherits [TaleWorlds.Core.ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [ArmorMaterialTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99) : sbyte {     [None](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99a6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [Cloth](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99a6eb838828b15bd5becbb96da8f979614) = 1 ,     [Leather](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99abdf7ad23e89b55f904bca0304819309e) = 2 ,     [Chainmail](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99a8c03e115ed5bd919086178d8ecf1e75c) = 3 ,     [Plate](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99abc9a8055ff921d3d9c876ff6eb02fddb) = 4   } |
| enum | [HairCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7) {     [None](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7a6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [Type1](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7a3fc8355f4568d0bc9fa60829e4db7ad8) ,     [Type2](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7a843171beb7019761cbdf01fa3b1b61fb) ,     [Type3](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7a459e4c1992412014278341a5705d8aec) ,     [Type4](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7a17bc479530517e70b6ce6639d64c9b6b) ,     [All](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7ab1c94ca2fbc3e78fc30069c8d0f01680) ,     [NumHairCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7af5b747f0aed8b555505f0abf1bfb1753)   } |
| enum | [BeardCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76) {     [None](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76a6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [Type1](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76a3fc8355f4568d0bc9fa60829e4db7ad8) ,     [Type2](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76a843171beb7019761cbdf01fa3b1b61fb) ,     [Type3](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76a459e4c1992412014278341a5705d8aec) ,     [Type4](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76a17bc479530517e70b6ce6639d64c9b6b) ,     [All](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76ab1c94ca2fbc3e78fc30069c8d0f01680) ,     [NumBeardBoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76a6aad66c13cf64effc2aef3c6eb390e0c)   } |
| enum | [HorseHarnessCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a823d3396e0a86c96ed82bb51fb32cff2) {     [None](class_tale_worlds_1_1_core_1_1_armor_component.html#a823d3396e0a86c96ed82bb51fb32cff2a6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [Type1](class_tale_worlds_1_1_core_1_1_armor_component.html#a823d3396e0a86c96ed82bb51fb32cff2a3fc8355f4568d0bc9fa60829e4db7ad8) ,     [Type2](class_tale_worlds_1_1_core_1_1_armor_component.html#a823d3396e0a86c96ed82bb51fb32cff2a843171beb7019761cbdf01fa3b1b61fb) ,     [All](class_tale_worlds_1_1_core_1_1_armor_component.html#a823d3396e0a86c96ed82bb51fb32cff2ab1c94ca2fbc3e78fc30069c8d0f01680) ,     [HorseHarnessCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a823d3396e0a86c96ed82bb51fb32cff2ad2db295310b53ecd3f7da5b77be5d953)   } |
| enum | [HorseTailCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a99b63a3f3bcad37761eb7518b75ea586) {     [None](class_tale_worlds_1_1_core_1_1_armor_component.html#a99b63a3f3bcad37761eb7518b75ea586a6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [All](class_tale_worlds_1_1_core_1_1_armor_component.html#a99b63a3f3bcad37761eb7518b75ea586ab1c94ca2fbc3e78fc30069c8d0f01680)   } |
| enum | [BodyMeshTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a9324c90a345f218fe122d5d9439c6a99) {     [Normal](class_tale_worlds_1_1_core_1_1_armor_component.html#a9324c90a345f218fe122d5d9439c6a99a960b44c579bc2f6818d2daaf9e4c16f0) = 0 ,     [Upperbody](class_tale_worlds_1_1_core_1_1_armor_component.html#a9324c90a345f218fe122d5d9439c6a99a99ab84dabc7828060878978e2a46ccd1) = 1 ,     [Shoulders](class_tale_worlds_1_1_core_1_1_armor_component.html#a9324c90a345f218fe122d5d9439c6a99a538f750b2882bfd1fe20c3fd667c1574) = 2 ,     [BodyMeshTypesNum](class_tale_worlds_1_1_core_1_1_armor_component.html#a9324c90a345f218fe122d5d9439c6a99a61253df45346e7353e2ce6cf69bf4368) = 3   } |
| enum | [BodyDeformTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#af7a1e685872a37d946b00abbf2371cbc) {     [Medium](class_tale_worlds_1_1_core_1_1_armor_component.html#af7a1e685872a37d946b00abbf2371cbca87f8a6ab85c9ced3702b4ea641ad4bb5) = 0 ,     [Large](class_tale_worlds_1_1_core_1_1_armor_component.html#af7a1e685872a37d946b00abbf2371cbca3a69b34ce86dacb205936a8094f6c743) = 1 ,     [Skinny](class_tale_worlds_1_1_core_1_1_armor_component.html#af7a1e685872a37d946b00abbf2371cbcaf14f493d449c6fde80bda526009214d0) = 2 ,     [BodyMeshTypesNum](class_tale_worlds_1_1_core_1_1_armor_component.html#af7a1e685872a37d946b00abbf2371cbca61253df45346e7353e2ce6cf69bf4368) = 3   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ArmorComponent](class_tale_worlds_1_1_core_1_1_armor_component.html#a782cdb29837e3cd3d2a42da6b23aa2f2) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| override [ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html#a2ee720148fe6c25a2ceb780721d5f725) | [GetCopy](class_tale_worlds_1_1_core_1_1_armor_component.html#a4317a234c20456a2be177d7286bed5ff) () |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_armor_component.html#a34185cedbb3b1a412b32ecb7d10f4670) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| Public Member Functions inherited from [TaleWorlds.Core.ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html) | |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_item_component.html#a6ac3b10aca5e561af97b46ae38c45a3a) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| [ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html#a2ee720148fe6c25a2ceb780721d5f725) | [GetCopy](class_tale_worlds_1_1_core_1_1_item_component.html#a2b8cbfc2e40e54b74030bfc720e152d2) () |
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
| int | [HeadArmor](class_tale_worlds_1_1_core_1_1_armor_component.html#aba483ed63d6565b6023cf8a8fecc2786) `[get]` |
| int | [BodyArmor](class_tale_worlds_1_1_core_1_1_armor_component.html#a5cfa6e7fe4df35a0534bc4c88ed43386) `[get]` |
| int | [LegArmor](class_tale_worlds_1_1_core_1_1_armor_component.html#adbc52a5f176755f1b1eb2f5e03a4e135) `[get]` |
| int | [ArmArmor](class_tale_worlds_1_1_core_1_1_armor_component.html#ae74b7cda306ab14361814ab2918f3338) `[get]` |
| int | [ManeuverBonus](class_tale_worlds_1_1_core_1_1_armor_component.html#a5e0f4bc7a91625963fddcbbaa7eb4253) `[get]` |
| int | [SpeedBonus](class_tale_worlds_1_1_core_1_1_armor_component.html#a49c9b7ce8a6a0589234b143464c2bcbb) `[get]` |
| int | [ChargeBonus](class_tale_worlds_1_1_core_1_1_armor_component.html#a07de81c3d8bfdc553ec89083ee2b6859) `[get]` |
| int | [FamilyType](class_tale_worlds_1_1_core_1_1_armor_component.html#a28756d1dd84de571fc6be7d1a7b0804b) `[get]` |
| bool | [MultiMeshHasGenderVariations](class_tale_worlds_1_1_core_1_1_armor_component.html#aeac28b7862562086e64716483b56673d) `[get]` |
| [ArmorMaterialTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99) | [MaterialType](class_tale_worlds_1_1_core_1_1_armor_component.html#aa229e5570722ca44b1fc71e0b20aab32) `[get]` |
| [SkinMask](namespace_tale_worlds_1_1_core.html#a8f2c9489fbe9d4227249302e76537533) | [MeshesMask](class_tale_worlds_1_1_core_1_1_armor_component.html#a3a9d6ccb8f99696a9282402d0e21db5c) `[get]` |
| [BodyMeshTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a9324c90a345f218fe122d5d9439c6a99) | [BodyMeshType](class_tale_worlds_1_1_core_1_1_armor_component.html#ab919a143e4ae32d66b6220c8387877f4) `[get]` |
| [BodyDeformTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#af7a1e685872a37d946b00abbf2371cbc) | [BodyDeformType](class_tale_worlds_1_1_core_1_1_armor_component.html#a0a37c1834908cbcc776f2ea3ad509264) `[get]` |
| [HairCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7) | [HairCoverType](class_tale_worlds_1_1_core_1_1_armor_component.html#a36a79af1f26d5368414cbcc279ddf165) `[get]` |
| [BeardCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76) | [BeardCoverType](class_tale_worlds_1_1_core_1_1_armor_component.html#a59fc7c8ee5908fde82259a9ab60ee775) `[get]` |
| [HorseHarnessCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a823d3396e0a86c96ed82bb51fb32cff2) | [ManeCoverType](class_tale_worlds_1_1_core_1_1_armor_component.html#ad2922ecd7236fc6cadddbad9b260a521) `[get]` |
| [HorseTailCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a99b63a3f3bcad37761eb7518b75ea586) | [TailCoverType](class_tale_worlds_1_1_core_1_1_armor_component.html#ad6e9fc57127b40a8935b71b9d7b02e6a) `[get]` |
| int | [StealthFactor](class_tale_worlds_1_1_core_1_1_armor_component.html#ae943d2f71e2ba8797c4a734f6fa72e23) `[get]` |
| string | [ReinsMesh](class_tale_worlds_1_1_core_1_1_armor_component.html#ad6ea4c451af8950537f9aaaf442e24a4) `[get]` |
| string | [ReinsRopeMesh](class_tale_worlds_1_1_core_1_1_armor_component.html#a3a13d40d79846313c268143e539e2143) `[get]` |
| Properties inherited from [TaleWorlds.Core.ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html) | |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [Item](class_tale_worlds_1_1_core_1_1_item_component.html#aa69328db32063a71a0d403ba2a5366c7) `[get, set]` |
| ItemModifierGroup | [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_component.html#a546f74aaae70e4455e4540fd5166b678) `[get, protected set]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.Core.ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html) | |
|  | [ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html#a2ee720148fe6c25a2ceb780721d5f725) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99)ArmorMaterialTypes
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ArmorComponent.ArmorMaterialTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99) : sbyte |

| Enumerator | |
| --- | --- |
| None |  |
| Cloth |  |
| Leather |  |
| Chainmail |  |
| Plate |  |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7)HairCoverTypes
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ArmorComponent.HairCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7) |

| Enumerator | |
| --- | --- |
| None |  |
| Type1 |  |
| Type2 |  |
| Type3 |  |
| Type4 |  |
| All |  |
| NumHairCoverTypes |  |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76)BeardCoverTypes
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ArmorComponent.BeardCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76) |

| Enumerator | |
| --- | --- |
| None |  |
| Type1 |  |
| Type2 |  |
| Type3 |  |
| Type4 |  |
| All |  |
| NumBeardBoverTypes |  |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a823d3396e0a86c96ed82bb51fb32cff2)HorseHarnessCoverTypes
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ArmorComponent.HorseHarnessCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a823d3396e0a86c96ed82bb51fb32cff2) |

| Enumerator | |
| --- | --- |
| None |  |
| Type1 |  |
| Type2 |  |
| All |  |
| HorseHarnessCoverTypes |  |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a99b63a3f3bcad37761eb7518b75ea586)HorseTailCoverTypes
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ArmorComponent.HorseTailCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a99b63a3f3bcad37761eb7518b75ea586) |

| Enumerator | |
| --- | --- |
| None |  |
| All |  |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a9324c90a345f218fe122d5d9439c6a99)BodyMeshTypes
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ArmorComponent.BodyMeshTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a9324c90a345f218fe122d5d9439c6a99) |

| Enumerator | |
| --- | --- |
| Normal |  |
| Upperbody |  |
| Shoulders |  |
| BodyMeshTypesNum |  |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#af7a1e685872a37d946b00abbf2371cbc)BodyDeformTypes
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ArmorComponent.BodyDeformTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#af7a1e685872a37d946b00abbf2371cbc) |

| Enumerator | |
| --- | --- |
| Medium |  |
| Large |  |
| Skinny |  |
| BodyMeshTypesNum |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a782cdb29837e3cd3d2a42da6b23aa2f2)ArmorComponent()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.ArmorComponent.ArmorComponent | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a4317a234c20456a2be177d7286bed5ff)GetCopy()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html#a2ee720148fe6c25a2ceb780721d5f725) TaleWorlds.Core.ArmorComponent.GetCopy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a34185cedbb3b1a412b32ecb7d10f4670)Deserialize()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.ArmorComponent.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#aba483ed63d6565b6023cf8a8fecc2786)HeadArmor
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ArmorComponent.HeadArmor | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a5cfa6e7fe4df35a0534bc4c88ed43386)BodyArmor
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ArmorComponent.BodyArmor | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#adbc52a5f176755f1b1eb2f5e03a4e135)LegArmor
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ArmorComponent.LegArmor | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#ae74b7cda306ab14361814ab2918f3338)ArmArmor
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ArmorComponent.ArmArmor | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a5e0f4bc7a91625963fddcbbaa7eb4253)ManeuverBonus
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ArmorComponent.ManeuverBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a49c9b7ce8a6a0589234b143464c2bcbb)SpeedBonus
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ArmorComponent.SpeedBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a07de81c3d8bfdc553ec89083ee2b6859)ChargeBonus
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ArmorComponent.ChargeBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a28756d1dd84de571fc6be7d1a7b0804b)FamilyType
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ArmorComponent.FamilyType | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#aeac28b7862562086e64716483b56673d)MultiMeshHasGenderVariations
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ArmorComponent.MultiMeshHasGenderVariations | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#aa229e5570722ca44b1fc71e0b20aab32)MaterialType
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ArmorMaterialTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99) TaleWorlds.Core.ArmorComponent.MaterialType | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a3a9d6ccb8f99696a9282402d0e21db5c)MeshesMask
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SkinMask](namespace_tale_worlds_1_1_core.html#a8f2c9489fbe9d4227249302e76537533) TaleWorlds.Core.ArmorComponent.MeshesMask | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#ab919a143e4ae32d66b6220c8387877f4)BodyMeshType
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BodyMeshTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a9324c90a345f218fe122d5d9439c6a99) TaleWorlds.Core.ArmorComponent.BodyMeshType | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a0a37c1834908cbcc776f2ea3ad509264)BodyDeformType
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BodyDeformTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#af7a1e685872a37d946b00abbf2371cbc) TaleWorlds.Core.ArmorComponent.BodyDeformType | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a36a79af1f26d5368414cbcc279ddf165)HairCoverType
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HairCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7) TaleWorlds.Core.ArmorComponent.HairCoverType | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a59fc7c8ee5908fde82259a9ab60ee775)BeardCoverType
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BeardCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76) TaleWorlds.Core.ArmorComponent.BeardCoverType | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#ad2922ecd7236fc6cadddbad9b260a521)ManeCoverType
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HorseHarnessCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a823d3396e0a86c96ed82bb51fb32cff2) TaleWorlds.Core.ArmorComponent.ManeCoverType | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#ad6e9fc57127b40a8935b71b9d7b02e6a)TailCoverType
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HorseTailCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a99b63a3f3bcad37761eb7518b75ea586) TaleWorlds.Core.ArmorComponent.TailCoverType | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#ae943d2f71e2ba8797c4a734f6fa72e23)StealthFactor
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ArmorComponent.StealthFactor | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#ad6ea4c451af8950537f9aaaf442e24a4)ReinsMesh
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ArmorComponent.ReinsMesh | | get |

[◆](class_tale_worlds_1_1_core_1_1_armor_component.html#a3a13d40d79846313c268143e539e2143)ReinsRopeMesh
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ArmorComponent.ReinsRopeMesh | | get |


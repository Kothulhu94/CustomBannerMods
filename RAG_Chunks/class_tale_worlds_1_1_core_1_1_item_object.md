--- SOURCE: class_tale_worlds_1_1_core_1_1_item_object.html ---

TaleWorlds.Core.ItemObject Class ReferencesealedInitializes a new instance of the [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html "Initializes a new instance of the ItemObject class.") class.

Inherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [ItemUsageSetFlags](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22) {     [RequiresMount](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22affcda0b25c11d20e85f871ab522d19ab) = 0x01 ,     [RequiresNoMount](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22ab7159598f37fdc74e8a656ddde3fdd64) = 0x02 ,     [RequiresShield](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22ae41abc2098e432b37060af5d6559830b) = 0x04 ,     [RequiresNoShield](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22ab31eac94afe232d2d2f3f72c672bb922) = 0x08 ,     [PassiveUsage](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22a03156f527d6e9a148fe986fbe96cda81) = 0x10   } |
| enum | [ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) {     [Invalid](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa4bbb8f967da6d1a610596d7257179c2b) = 0 ,     [Horse](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa38069b4eb64e325cb7ac65bd641b2188) = 1 ,     [OneHandedWeapon](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caaa237868ad5fe07bd74a1ebacff94af42) ,     [TwoHandedWeapon](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caaafe5ee6022406791d5d771d134cf1f60) ,     [Polearm](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa6415d0fae1bfea75f0b11b5a3f323874) ,     [Arrows](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa4e05974b02cc4aa95db4d85baef6b6b4) ,     [Bolts](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caaa8eadd644fa289ddc87352b856177be9) ,     [SlingStones](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa70f69e3280571d9affd46130ed13ba9a) ,     [Shield](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa970da5f1f2e32aeb9e488dd017160ab4) ,     [Bow](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa48fce5d02f6935e50f256d5dedac4437) ,     [Crossbow](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caaecd03afff3ba51979312a1114f791d13) ,     [Sling](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caaf52ed02e39529973298852a9e0c7087e) ,     [Thrown](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa24dcddf95764a178ee7704cb567d1430) ,     [Goods](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa9b2cfa29e7882e3649d5f3b9921afdb0) ,     [HeadArmor](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa71203c5a2afba5ec7534a2fd00abda52) ,     [BodyArmor](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa83939600fb52bedcfaa188694bb9905f) ,     [LegArmor](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caac9093c346819e0748ad59b714a5ff372) ,     [HandArmor](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa49e0fc1e970ef9330bd5faffae326fd4) ,     [Pistol](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa524b64722661b303ed5754c492c0ef14) ,     [Musket](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caadd60bcc7f465fe1cbcc7f2dade05f485) ,     [Bullets](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa1411e2631996697a68c519df86f578b9) ,     [Animal](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa161e7ce7bfdc89ab4b9f52c1d4c94212) ,     [Book](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa2b1f94ef23b79bf90eb891cae1df7a90) ,     [ChestArmor](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa3526d087a9b4c6c38f60ce72913c74b4) ,     [Cape](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa679355c6c670c65aeddd96d9724159f2) ,     [HorseHarness](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa4c2ce960d67fa946e5de7d3a1748ac47) ,     [Banner](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402caa6ff29916f99fff9d2494d28e721ae77e)   } |
| enum | [ItemTiers](class_tale_worlds_1_1_core_1_1_item_object.html#af0f4a5df6fea5675da90dd17574c4cd8) {     [Tier1](class_tale_worlds_1_1_core_1_1_item_object.html#af0f4a5df6fea5675da90dd17574c4cd8a0fdf99ebbdcd0198744caa9b8c5c6ca4) = 0 ,     [Tier2](class_tale_worlds_1_1_core_1_1_item_object.html#af0f4a5df6fea5675da90dd17574c4cd8ad167d667548ae1364f67b9ce0b6918a5) = 1 ,     [Tier3](class_tale_worlds_1_1_core_1_1_item_object.html#af0f4a5df6fea5675da90dd17574c4cd8a1fee01fe8bbe05778f82f32df56b0061) = 2 ,     [Tier4](class_tale_worlds_1_1_core_1_1_item_object.html#af0f4a5df6fea5675da90dd17574c4cd8a7aac5960e1b9dacecffcf57aa0926010) = 3 ,     [Tier5](class_tale_worlds_1_1_core_1_1_item_object.html#af0f4a5df6fea5675da90dd17574c4cd8a1f71693058d07557f02a29e50746f1aa) = 4 ,     [Tier6](class_tale_worlds_1_1_core_1_1_item_object.html#af0f4a5df6fea5675da90dd17574c4cd8a33cc927ca6834f71d067822577c7ed54) = 5 ,     [NumTiers](class_tale_worlds_1_1_core_1_1_item_object.html#af0f4a5df6fea5675da90dd17574c4cd8a00ecd32667e158b9a00d6026777f9622) = 6   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a9e8a624b8cfafc646c7d3200a44ec29a) () |
|  | Initializes a new instance of the [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html "Initializes a new instance of the ItemObject class.") class. |
|  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a72f7f1b494b282c61df354ab6146ab7c) (string stringId) |
|  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a28477f4fdfb1c316804cb4c48635d34b) (ItemObject itemToCopy) |
| override int | [GetHashCode](class_tale_worlds_1_1_core_1_1_item_object.html#ad5ed3a0a3e9fb3c0f3dc8e78f88611c6) () |
| void | [SetItemFlagsForCosmetics](class_tale_worlds_1_1_core_1_1_item_object.html#a21d22c67b42ac5cfaf572e801158b3c7) ([ItemFlags](namespace_tale_worlds_1_1_core.html#a15c85da8a745978ee9af9c5677c007c1) newFlags) |
| void | [DetermineItemCategoryForItem](class_tale_worlds_1_1_core_1_1_item_object.html#afd80ee0f064b5f8f6662c661a9b68e21) () |
| void | [AddWeapon](class_tale_worlds_1_1_core_1_1_item_object.html#a1f52f83719b4f30854195571ab89e9c2) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon, [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_modifier_group.html) itemModifierGroup) |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_item_object.html#a9f21d720a64d6c92e906541515c6aab5) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override string | [ToString](class_tale_worlds_1_1_core_1_1_item_object.html#a4a9070cd9c19c1dc3c894006ec89b4a6) () |
| [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | [GetWeaponWithUsageIndex](class_tale_worlds_1_1_core_1_1_item_object.html#a08acd78c9929c6c692beca31fee2ea0a) (int usageIndex) |
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
| static [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a9e8a624b8cfafc646c7d3200a44ec29a) | [InitializeTradeGood](class_tale_worlds_1_1_core_1_1_item_object.html#ace4e35c0fdc3fa9d8fe2ce3cf9bb4931) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a9e8a624b8cfafc646c7d3200a44ec29a) item, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, string meshName, [ItemCategory](class_tale_worlds_1_1_core_1_1_item_object.html#afbcb6fadd2234d01fee1bc12f5de5b94) category, int value, float weight, [ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) itemType, bool isFood=false) |
| static void | [InitAsPlayerCraftedItem](class_tale_worlds_1_1_core_1_1_item_object.html#a015dc582a1f67288e2be3ca11e3336d1) (ref [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a9e8a624b8cfafc646c7d3200a44ec29a) itemObject) |
| static [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a9e8a624b8cfafc646c7d3200a44ec29a) | [GetCraftedItemObjectFromHashedCode](class_tale_worlds_1_1_core_1_1_item_object.html#a0ec9a3c576dd0a45ada3d3c50d0597b8) (string hashedCode) |
| static [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a9e8a624b8cfafc646c7d3200a44ec29a) | [GetItemFromWeaponKind](class_tale_worlds_1_1_core_1_1_item_object.html#a715306305945e557d8bb39bf1fc1d7f8) (int weaponKind) |
| static [ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) | [GetAmmoTypeForItemType](class_tale_worlds_1_1_core_1_1_item_object.html#a80754e076c4d5cd3343579173ca81c78) ([ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) itemType) |
| static float | [GetAirFrictionConstant](class_tale_worlds_1_1_core_1_1_item_object.html#ab8532fe98336cf871876b7b8d8bf58f2) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass, [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) weaponFlags) |

|  |  |
| --- | --- |
| Public Attributes | |
| [ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) | [Type](class_tale_worlds_1_1_core_1_1_item_object.html#a208f74eec54d0ffa45ad6d2ab81e800b) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [DefaultAppearanceValue](class_tale_worlds_1_1_core_1_1_item_object.html#a4861081891728477fa8833266d6e5143) = 0.5f |
| const int | [MaxHolsterSlotCount](class_tale_worlds_1_1_core_1_1_item_object.html#a3beffebf9b29eb9793689e9b0e2c559e) = 4 |

|  |  |
| --- | --- |
| Properties | |
| ItemComponent | [ItemComponent](class_tale_worlds_1_1_core_1_1_item_object.html#a68dc216298e932bd7829b514e88a5d2e) `[get]` |
| string | [MultiMeshName](class_tale_worlds_1_1_core_1_1_item_object.html#a4564fb5f7df69691c84679de93eb7c9b) `[get]` |
| string | [HolsterMeshName](class_tale_worlds_1_1_core_1_1_item_object.html#a150741945ac91b21ea61343f8f6480b9) `[get]` |
| string | [HolsterWithWeaponMeshName](class_tale_worlds_1_1_core_1_1_item_object.html#abd33726ae0818ab7a6b8bdf81d6f599a) `[get]` |
| string[] | [ItemHolsters](class_tale_worlds_1_1_core_1_1_item_object.html#a84ca6739e05f068012d37e6bc5702fa1) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [HolsterPositionShift](class_tale_worlds_1_1_core_1_1_item_object.html#aeb2efe77c0bd9e6c9166b4263d187d9d) `[get]` |
| bool | [HasLowerHolsterPriority](class_tale_worlds_1_1_core_1_1_item_object.html#adee7e031ea425f549ab833d3559cb9b8) `[get]` |
| string | [FlyingMeshName](class_tale_worlds_1_1_core_1_1_item_object.html#afd28805d595fd302245c825913cc7ba1) `[get]` |
| string | [BodyName](class_tale_worlds_1_1_core_1_1_item_object.html#ac0205af04f61affa22bcc292986044d2) `[get]` |
| string | [SkeletonName](class_tale_worlds_1_1_core_1_1_item_object.html#a604c630eb25b793ef13c5adc4995e164) `[get]` |
| string | [StaticAnimationName](class_tale_worlds_1_1_core_1_1_item_object.html#a1d7e35b475bb3aa636a0e9775d56e6ed) `[get]` |
| string | [HolsterBodyName](class_tale_worlds_1_1_core_1_1_item_object.html#a6a6bb6ec01076869b6490fc95f2c22a3) `[get]` |
| string | [CollisionBodyName](class_tale_worlds_1_1_core_1_1_item_object.html#aa4fa53388907e4d8d3fdce0b7c28b170) `[get]` |
| bool | [RecalculateBody](class_tale_worlds_1_1_core_1_1_item_object.html#a8267a3c7da9c643d9000f3587494b2f2) `[get]` |
| string | [PrefabName](class_tale_worlds_1_1_core_1_1_item_object.html#abbb9eed389331156e48f5f40388c358f) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_core_1_1_item_object.html#a01968bb0caba959ce21cc61b12b63877) `[get]` |
| [ItemFlags](namespace_tale_worlds_1_1_core.html#a15c85da8a745978ee9af9c5677c007c1) | [ItemFlags](class_tale_worlds_1_1_core_1_1_item_object.html#ad6fd3f093cdace304cec302265637535) `[get]` |
| ItemCategory | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_object.html#afbcb6fadd2234d01fee1bc12f5de5b94) `[get]` |
| int | [Value](class_tale_worlds_1_1_core_1_1_item_object.html#ab2a2f0b25e5068403c7f2536f1579017) `[get]` |
| float | [Effectiveness](class_tale_worlds_1_1_core_1_1_item_object.html#aafe0be591f6ee80927ddd8839b6b46a2) `[get]` |
| float | [Weight](class_tale_worlds_1_1_core_1_1_item_object.html#a57e102eeb3f985cac1046d6b07e67459) `[get]` |
| int | [Difficulty](class_tale_worlds_1_1_core_1_1_item_object.html#a500d8d11a875c05f67789e45f476bacb) `[get]` |
| float | [Appearance](class_tale_worlds_1_1_core_1_1_item_object.html#a63cd806343489402927fce0e479a596f) `[get]` |
| bool | [IsUsingTableau](class_tale_worlds_1_1_core_1_1_item_object.html#a8e2175dcd01505ac9bd2ed0b38db1833) `[get]` |
| bool | [IsUsingTeamColor](class_tale_worlds_1_1_core_1_1_item_object.html#ac81df5f3e0f86a0fe62fb0c28fc95eb6) `[get]` |
| bool | [DoesNotHideChest](class_tale_worlds_1_1_core_1_1_item_object.html#a3eae11f4b51badf03de31ae51f31f7d3) `[get]` |
| bool | [IsCivilian](class_tale_worlds_1_1_core_1_1_item_object.html#ac97afda4279f69bea84b6fa95257b106) `[get]` |
| bool | [IsStealthItem](class_tale_worlds_1_1_core_1_1_item_object.html#acad6b7910ddccaaf3210ffcf4c2854cb) `[get]` |
| bool | [UsingFacegenScaling](class_tale_worlds_1_1_core_1_1_item_object.html#a7f625e0f311c06d94b74adaa34f87980) `[get]` |
| string | [ArmBandMeshName](class_tale_worlds_1_1_core_1_1_item_object.html#a826de6b43704d9c9baa8a3b401b38ca2) `[get]` |
| bool | [IsFood](class_tale_worlds_1_1_core_1_1_item_object.html#a585e2da9a7a2a9ed60bd5636b4e55758) `[get]` |
| bool | [IsUniqueItem](class_tale_worlds_1_1_core_1_1_item_object.html#a176c22b475bb71e26389cbf705e2c0a1) `[get]` |
| float | [ScaleFactor](class_tale_worlds_1_1_core_1_1_item_object.html#aae82316e4f64d15a8f4a39977401500b) `[get]` |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [Culture](class_tale_worlds_1_1_core_1_1_item_object.html#acccb3e527dba236aafc0939ee4da3229) `[get]` |
| bool | [MultiplayerItem](class_tale_worlds_1_1_core_1_1_item_object.html#adfc29feabe0e2854de2fff952cc7dc1f) `[get]` |
| bool | [NotMerchandise](class_tale_worlds_1_1_core_1_1_item_object.html#ac160340356d930b99eb185c28ae73f76) `[get]` |
| bool | [IsCraftedByPlayer](class_tale_worlds_1_1_core_1_1_item_object.html#a9e7b700190326b61cc3c47174188bae9) `[get]` |
| int | [LodAtlasIndex](class_tale_worlds_1_1_core_1_1_item_object.html#a418f71b8e64af0d3d641d2ddb338ad08) `[get]` |
| bool | [IsTransferable](class_tale_worlds_1_1_core_1_1_item_object.html#a0d4a51e30a92e3568bcc640d932f78a2) `[get]` |
| float | [Tierf](class_tale_worlds_1_1_core_1_1_item_object.html#a2bb0281f51b1989f8fead875d7e069f6) `[get]` |
| bool | [IsCraftedWeapon](class_tale_worlds_1_1_core_1_1_item_object.html#a8ac630a1eab558fc811be4747669b211) `[get]` |
| [ItemTiers](class_tale_worlds_1_1_core_1_1_item_object.html#af0f4a5df6fea5675da90dd17574c4cd8) | [Tier](class_tale_worlds_1_1_core_1_1_item_object.html#ac4c7799a2a020ae899611f80607c9227) `[get]` |
| WeaponDesign | [WeaponDesign](class_tale_worlds_1_1_core_1_1_item_object.html#ae9427cc13d2866335d37cbd63b7630ff) `[get]` |
| [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | [PrimaryWeapon](class_tale_worlds_1_1_core_1_1_item_object.html#a06349667be85637b128aab788534b6d0) `[get]` |
| WeaponComponent | [WeaponComponent](class_tale_worlds_1_1_core_1_1_item_object.html#a6449b7c6d7e4aa27c144d98a608f61bd) `[get]` |
| bool | [HasWeaponComponent](class_tale_worlds_1_1_core_1_1_item_object.html#adf22852e456d2396a95be7fb1c40af37) `[get]` |
| HorseComponent | [HorseComponent](class_tale_worlds_1_1_core_1_1_item_object.html#a4490815a2763caa33a83317ef2e71daa) `[get]` |
| bool | [HasHorseComponent](class_tale_worlds_1_1_core_1_1_item_object.html#abf58a0591ac3ad0f7d1aceaa142f00ab) `[get]` |
| ArmorComponent | [ArmorComponent](class_tale_worlds_1_1_core_1_1_item_object.html#ae304ec5cb8cab540f69cee61c6d9e96f) `[get]` |
| bool | [HasArmorComponent](class_tale_worlds_1_1_core_1_1_item_object.html#a719eb10f7557b5b108289dd593495e5f) `[get]` |
| BannerComponent | [BannerComponent](class_tale_worlds_1_1_core_1_1_item_object.html#a7e5e03c5244e9fef540dde59f051ae84) `[get]` |
| bool | [HasBannerComponent](class_tale_worlds_1_1_core_1_1_item_object.html#ad0f57cf4249fb8a5b7a0d19e359b0161) `[get]` |
| SaddleComponent | [SaddleComponent](class_tale_worlds_1_1_core_1_1_item_object.html#a8347d17cf0e327bf18dceb871c473a2b) `[get]` |
| bool | [HasSaddleComponent](class_tale_worlds_1_1_core_1_1_item_object.html#ab9e0191948d821c1bc741449f0b5e9c2) `[get]` |
| [TradeItemComponent](class_tale_worlds_1_1_core_1_1_trade_item_component.html) | [FoodComponent](class_tale_worlds_1_1_core_1_1_item_object.html#a4965b1ab489e8b0a89f4f0f3f33ecf47) `[get]` |
| bool | [HasFoodComponent](class_tale_worlds_1_1_core_1_1_item_object.html#afb595bb2c33007bebf1b59f4b352314e) `[get]` |
| MBReadOnlyList< [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) > | [Weapons](class_tale_worlds_1_1_core_1_1_item_object.html#aa5419c5dbb5409701f38e627a0411e90) `[get]` |
| [ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) | [ItemType](class_tale_worlds_1_1_core_1_1_item_object.html#a4145f47611c9a90350ee4dc0652d0303) `[get]` |
|  | Gets the type of the item. |
| bool | [IsMountable](class_tale_worlds_1_1_core_1_1_item_object.html#ab11172d69c874dd42f4805172f0ddbe9) `[get]` |
| bool | [IsTradeGood](class_tale_worlds_1_1_core_1_1_item_object.html#ac35111819e396b16491ee26bd150962a) `[get]` |
| bool | [IsBannerItem](class_tale_worlds_1_1_core_1_1_item_object.html#a8947464bf5b02abe2c76eec2733321d5) `[get]` |
| bool | [IsAnimal](class_tale_worlds_1_1_core_1_1_item_object.html#a38ce392c44dba1303b14a40f97f06853) `[get]` |
| [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [RelevantSkill](class_tale_worlds_1_1_core_1_1_item_object.html#a11b59560ee2b81ef8ed269a66cd2e2df) `[get]` |
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

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22)ItemUsageSetFlags
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ItemObject.ItemUsageSetFlags](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22) |

| Enumerator | |
| --- | --- |
| RequiresMount |  |
| RequiresNoMount |  |
| RequiresShield |  |
| RequiresNoShield |  |
| PassiveUsage |  |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca)ItemTypeEnum
--------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ItemObject.ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) |

| Enumerator | |
| --- | --- |
| Invalid |  |
| Horse |  |
| OneHandedWeapon |  |
| TwoHandedWeapon |  |
| Polearm |  |
| Arrows |  |
| Bolts |  |
| SlingStones |  |
| Shield |  |
| Bow |  |
| Crossbow |  |
| Sling |  |
| Thrown |  |
| Goods |  |
| HeadArmor |  |
| BodyArmor |  |
| LegArmor |  |
| HandArmor |  |
| Pistol |  |
| Musket |  |
| Bullets |  |
| Animal |  |
| Book |  |
| ChestArmor |  |
| Cape |  |
| HorseHarness |  |
| Banner |  |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#af0f4a5df6fea5675da90dd17574c4cd8)ItemTiers
-----------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ItemObject.ItemTiers](class_tale_worlds_1_1_core_1_1_item_object.html#af0f4a5df6fea5675da90dd17574c4cd8) |

| Enumerator | |
| --- | --- |
| Tier1 |  |
| Tier2 |  |
| Tier3 |  |
| Tier4 |  |
| Tier5 |  |
| Tier6 |  |
| NumTiers |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a9e8a624b8cfafc646c7d3200a44ec29a)ItemObject() [1/3]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.ItemObject.ItemObject | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a72f7f1b494b282c61df354ab6146ab7c)ItemObject() [2/3]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.ItemObject.ItemObject | ( | string | *stringId* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a28477f4fdfb1c316804cb4c48635d34b)ItemObject() [3/3]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.ItemObject.ItemObject | ( | ItemObject | *itemToCopy* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ace4e35c0fdc3fa9d8fe2ce3cf9bb4931)InitializeTradeGood()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a9e8a624b8cfafc646c7d3200a44ec29a) TaleWorlds.Core.ItemObject.InitializeTradeGood | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a9e8a624b8cfafc646c7d3200a44ec29a) | *item*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, | |  |  | string | *meshName*, | |  |  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_object.html#afbcb6fadd2234d01fee1bc12f5de5b94) | *category*, | |  |  | int | *value*, | |  |  | float | *weight*, | |  |  | [ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) | *itemType*, | |  |  | bool | *isFood* = false ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a015dc582a1f67288e2be3ca11e3336d1)InitAsPlayerCraftedItem()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.ItemObject.InitAsPlayerCraftedItem | ( | ref [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a9e8a624b8cfafc646c7d3200a44ec29a) | *itemObject* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ad5ed3a0a3e9fb3c0f3dc8e78f88611c6)GetHashCode()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Core.ItemObject.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a21d22c67b42ac5cfaf572e801158b3c7)SetItemFlagsForCosmetics()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ItemObject.SetItemFlagsForCosmetics | ( | [ItemFlags](namespace_tale_worlds_1_1_core.html#a15c85da8a745978ee9af9c5677c007c1) | *newFlags* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#afd80ee0f064b5f8f6662c661a9b68e21)DetermineItemCategoryForItem()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ItemObject.DetermineItemCategoryForItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a0ec9a3c576dd0a45ada3d3c50d0597b8)GetCraftedItemObjectFromHashedCode()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a9e8a624b8cfafc646c7d3200a44ec29a) TaleWorlds.Core.ItemObject.GetCraftedItemObjectFromHashedCode | ( | string | *hashedCode* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a1f52f83719b4f30854195571ab89e9c2)AddWeapon()
-------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.ItemObject.AddWeapon | ( | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon*, |
|  |  | [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_modifier_group.html) | *itemModifierGroup* ) |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a9f21d720a64d6c92e906541515c6aab5)Deserialize()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.ItemObject.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a4a9070cd9c19c1dc3c894006ec89b4a6)ToString()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Core.ItemObject.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a715306305945e557d8bb39bf1fc1d7f8)GetItemFromWeaponKind()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html#a9e8a624b8cfafc646c7d3200a44ec29a) TaleWorlds.Core.ItemObject.GetItemFromWeaponKind | ( | int | *weaponKind* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a80754e076c4d5cd3343579173ca81c78)GetAmmoTypeForItemType()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) TaleWorlds.Core.ItemObject.GetAmmoTypeForItemType | ( | [ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) | *itemType* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ab8532fe98336cf871876b7b8d8bf58f2)GetAirFrictionConstant()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Core.ItemObject.GetAirFrictionConstant | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass*, | |  |  | [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | *weaponFlags* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a08acd78c9929c6c692beca31fee2ea0a)GetWeaponWithUsageIndex()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) TaleWorlds.Core.ItemObject.GetWeaponWithUsageIndex | ( | int | *usageIndex* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a4861081891728477fa8833266d6e5143)DefaultAppearanceValue
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Core.ItemObject.DefaultAppearanceValue = 0.5f | | static |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a3beffebf9b29eb9793689e9b0e2c559e)MaxHolsterSlotCount
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.ItemObject.MaxHolsterSlotCount = 4 | | static |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a208f74eec54d0ffa45ad6d2ab81e800b)Type
------------------------------------------------------------------------------------------

|  |
| --- |
| [ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) TaleWorlds.Core.ItemObject.Type |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a68dc216298e932bd7829b514e88a5d2e)ItemComponent
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ItemComponent TaleWorlds.Core.ItemObject.ItemComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a4564fb5f7df69691c84679de93eb7c9b)MultiMeshName
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ItemObject.MultiMeshName | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a150741945ac91b21ea61343f8f6480b9)HolsterMeshName
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ItemObject.HolsterMeshName | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#abd33726ae0818ab7a6b8bdf81d6f599a)HolsterWithWeaponMeshName
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ItemObject.HolsterWithWeaponMeshName | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a84ca6739e05f068012d37e6bc5702fa1)ItemHolsters
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string [] TaleWorlds.Core.ItemObject.ItemHolsters | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#aeb2efe77c0bd9e6c9166b4263d187d9d)HolsterPositionShift
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.ItemObject.HolsterPositionShift | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#adee7e031ea425f549ab833d3559cb9b8)HasLowerHolsterPriority
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.HasLowerHolsterPriority | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#afd28805d595fd302245c825913cc7ba1)FlyingMeshName
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ItemObject.FlyingMeshName | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ac0205af04f61affa22bcc292986044d2)BodyName
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ItemObject.BodyName | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a604c630eb25b793ef13c5adc4995e164)SkeletonName
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ItemObject.SkeletonName | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a1d7e35b475bb3aa636a0e9775d56e6ed)StaticAnimationName
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ItemObject.StaticAnimationName | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a6a6bb6ec01076869b6490fc95f2c22a3)HolsterBodyName
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ItemObject.HolsterBodyName | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#aa4fa53388907e4d8d3fdce0b7c28b170)CollisionBodyName
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ItemObject.CollisionBodyName | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a8267a3c7da9c643d9000f3587494b2f2)RecalculateBody
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.RecalculateBody | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#abbb9eed389331156e48f5f40388c358f)PrefabName
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ItemObject.PrefabName | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a01968bb0caba959ce21cc61b12b63877)Name
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.ItemObject.Name | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ad6fd3f093cdace304cec302265637535)ItemFlags
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemFlags](namespace_tale_worlds_1_1_core.html#a15c85da8a745978ee9af9c5677c007c1) TaleWorlds.Core.ItemObject.ItemFlags | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#afbcb6fadd2234d01fee1bc12f5de5b94)ItemCategory
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ItemCategory TaleWorlds.Core.ItemObject.ItemCategory | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ab2a2f0b25e5068403c7f2536f1579017)Value
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ItemObject.Value | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#aafe0be591f6ee80927ddd8839b6b46a2)Effectiveness
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemObject.Effectiveness | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a57e102eeb3f985cac1046d6b07e67459)Weight
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemObject.Weight | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a500d8d11a875c05f67789e45f476bacb)Difficulty
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ItemObject.Difficulty | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a63cd806343489402927fce0e479a596f)Appearance
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemObject.Appearance | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a8e2175dcd01505ac9bd2ed0b38db1833)IsUsingTableau
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsUsingTableau | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ac81df5f3e0f86a0fe62fb0c28fc95eb6)IsUsingTeamColor
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsUsingTeamColor | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a3eae11f4b51badf03de31ae51f31f7d3)DoesNotHideChest
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.DoesNotHideChest | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ac97afda4279f69bea84b6fa95257b106)IsCivilian
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsCivilian | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#acad6b7910ddccaaf3210ffcf4c2854cb)IsStealthItem
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsStealthItem | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a7f625e0f311c06d94b74adaa34f87980)UsingFacegenScaling
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.UsingFacegenScaling | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a826de6b43704d9c9baa8a3b401b38ca2)ArmBandMeshName
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ItemObject.ArmBandMeshName | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a585e2da9a7a2a9ed60bd5636b4e55758)IsFood
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsFood | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a176c22b475bb71e26389cbf705e2c0a1)IsUniqueItem
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsUniqueItem | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#aae82316e4f64d15a8f4a39977401500b)ScaleFactor
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemObject.ScaleFactor | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#acccb3e527dba236aafc0939ee4da3229)Culture
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.Core.ItemObject.Culture | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#adfc29feabe0e2854de2fff952cc7dc1f)MultiplayerItem
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.MultiplayerItem | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ac160340356d930b99eb185c28ae73f76)NotMerchandise
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.NotMerchandise | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a9e7b700190326b61cc3c47174188bae9)IsCraftedByPlayer
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsCraftedByPlayer | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a418f71b8e64af0d3d641d2ddb338ad08)LodAtlasIndex
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ItemObject.LodAtlasIndex | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a0d4a51e30a92e3568bcc640d932f78a2)IsTransferable
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsTransferable | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a2bb0281f51b1989f8fead875d7e069f6)Tierf
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemObject.Tierf | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a8ac630a1eab558fc811be4747669b211)IsCraftedWeapon
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsCraftedWeapon | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ac4c7799a2a020ae899611f80607c9227)Tier
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemTiers](class_tale_worlds_1_1_core_1_1_item_object.html#af0f4a5df6fea5675da90dd17574c4cd8) TaleWorlds.Core.ItemObject.Tier | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ae9427cc13d2866335d37cbd63b7630ff)WeaponDesign
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | WeaponDesign TaleWorlds.Core.ItemObject.WeaponDesign | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a06349667be85637b128aab788534b6d0)PrimaryWeapon
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) TaleWorlds.Core.ItemObject.PrimaryWeapon | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a6449b7c6d7e4aa27c144d98a608f61bd)WeaponComponent
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | WeaponComponent TaleWorlds.Core.ItemObject.WeaponComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#adf22852e456d2396a95be7fb1c40af37)HasWeaponComponent
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.HasWeaponComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a4490815a2763caa33a83317ef2e71daa)HorseComponent
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | HorseComponent TaleWorlds.Core.ItemObject.HorseComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#abf58a0591ac3ad0f7d1aceaa142f00ab)HasHorseComponent
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.HasHorseComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ae304ec5cb8cab540f69cee61c6d9e96f)ArmorComponent
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ArmorComponent TaleWorlds.Core.ItemObject.ArmorComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a719eb10f7557b5b108289dd593495e5f)HasArmorComponent
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.HasArmorComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a7e5e03c5244e9fef540dde59f051ae84)BannerComponent
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | BannerComponent TaleWorlds.Core.ItemObject.BannerComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ad0f57cf4249fb8a5b7a0d19e359b0161)HasBannerComponent
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.HasBannerComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a8347d17cf0e327bf18dceb871c473a2b)SaddleComponent
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SaddleComponent TaleWorlds.Core.ItemObject.SaddleComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ab9e0191948d821c1bc741449f0b5e9c2)HasSaddleComponent
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.HasSaddleComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a4965b1ab489e8b0a89f4f0f3f33ecf47)FoodComponent
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TradeItemComponent](class_tale_worlds_1_1_core_1_1_trade_item_component.html) TaleWorlds.Core.ItemObject.FoodComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#afb595bb2c33007bebf1b59f4b352314e)HasFoodComponent
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.HasFoodComponent | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#aa5419c5dbb5409701f38e627a0411e90)Weapons
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html)> TaleWorlds.Core.ItemObject.Weapons | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a4145f47611c9a90350ee4dc0652d0303)ItemType
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemTypeEnum](class_tale_worlds_1_1_core_1_1_item_object.html#a0e9300d29651608303ca1bb2ade402ca) TaleWorlds.Core.ItemObject.ItemType | | get |

Returns
:   Item type

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ab11172d69c874dd42f4805172f0ddbe9)IsMountable
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsMountable | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#ac35111819e396b16491ee26bd150962a)IsTradeGood
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsTradeGood | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a8947464bf5b02abe2c76eec2733321d5)IsBannerItem
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsBannerItem | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a38ce392c44dba1303b14a40f97f06853)IsAnimal
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemObject.IsAnimal | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_object.html#a11b59560ee2b81ef8ed269a66cd2e2df)RelevantSkill
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) TaleWorlds.Core.ItemObject.RelevantSkill | | get |


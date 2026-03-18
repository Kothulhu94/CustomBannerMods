--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_character_object.html ---

TaleWorlds.CampaignSystem.CharacterObject Class ReferencesealedInherits [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html), and [TaleWorlds.Core.ICharacterData](interface_tale_worlds_1_1_core_1_1_i_character_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#afc8e6cd483a0ceb296bf45c4606363e4) () |
| override int | [MaxHitPoints](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ab2435f54c2f82d7d0f7ea6248ae33c1e) () |
|  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) () |
|  | Initializes a new instance of the [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) class. |
| override void | [AfterRegister](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a9a38af5536784bb3c13d7f81be28da1e) () |
| override [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyPropertiesMin](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6015d59f2c1c544b04f5d2caf6be480b) (bool returnBaseValue=false) |
|  | Gets or sets this character's face and body keys. |
| override [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyPropertiesMax](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#afeea5ae58ff341b321e003051844cab2) (bool returnBaseValue=false) |
| override void | [UpdatePlayerCharacterBodyProperties](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a229b2e35324a08e2f4177b3b3d54cd56) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) properties, int race, bool isFemale) |
| [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) | [GetDefaultOccupation](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#adef5542bc11167a1d7eba1af530401dd) () |
| bool | [HasThrowingWeapon](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a234489d7710b3cd040d7b5578f0d546d) () |
| int | [GetUpgradeXpCost](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a249029408c21e56b60a8abd115481f05) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, int index) |
| int | [GetUpgradeGoldCost](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a830d2be52e3008a52337ea50f1ebce07) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, int index) |
| void | [InitializeHeroCharacterOnAfterLoad](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a7c230f0a61272bfe05d41f46495252fe) () |
| override void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ab7af1336146cbbed86b03e0252a61514) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
|  | De-serializes the object from an XmlNode. |
| override float | [GetPower](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#afe0dabaa06b3f1696738a332d5a339d2) () |
| override float | [GetBattlePower](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a2078a7d7805ed5148eb83fba8a9252bc) () |
| override float | [GetMoraleResistance](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1ce6833d58d3416b8f62bbc3aa738d49) () |
| void | [GetSimulationAttackPower](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa6f2ffad771ff756f8e41331020c76f9) (out float attackPoints, out float defencePoints, [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) equipment=null) |
| float | [GetHeadArmorSum](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a340d39416c4c0e533edea8988d014b3e) (Equipment.EquipmentType equipmentType=Equipment.EquipmentType.Battle) |
| float | [GetBodyArmorSum](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a3227da01bf54bb02ab35866599cbe9cf) (Equipment.EquipmentType equipmentType=Equipment.EquipmentType.Battle) |
| float | [GetLegArmorSum](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa6520bdcff325ffb2fa96d03e09abf82) (Equipment.EquipmentType equipmentType=Equipment.EquipmentType.Battle) |
| float | [GetArmArmorSum](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a38bb7c305dbb8bdf8abf340da1da82ba) (Equipment.EquipmentType equipmentType=Equipment.EquipmentType.Battle) |
| float | [GetHorseArmorSum](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a44e733245cefa6795a575cf3cbc40f0b) (Equipment.EquipmentType equipmentType=Equipment.EquipmentType.Battle) |
| float | [GetTotalArmorSum](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a9b502c860ec39b23b932c198052e6e3a) (Equipment.EquipmentType equipmentType=Equipment.EquipmentType.Battle) |
| override [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyProperties](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a20bbcb629c13a7a2f022879490767e26) ([Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) equipment, int seed=-1) |
| void | [SetTransferableInPartyScreen](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1775a09bd50fe489c2e386fbbda2e723) (bool isTransferable) |
|  | Locks character object in the party screen. |
| void | [SetTransferableInHideouts](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#af4ec96e35ddc7d5b3256a58736b7a299) (bool isTransferable) |
|  | Locks character object in the hideout management screen. |
| void | [ClearAttributes](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a7dac4aaf516d49b1a1759bbee69ac037) () |
| int | [GetTraitLevel](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a5314c273b22fa8182d02c8a7012a73b5) ([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait) |
| bool | [GetPerkValue](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ae61177ba4749b91d407d6861cb7c6676) ([PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk) |
| override int | [GetSkillValue](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aeaf48005c2355806455637b1dbd74a8b) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | [GetPersona](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a53caa03d682a9b3a49b99977fe41f4ec) () |
| override int | [GetMountKeySeed](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#abf4e0c228a424e273695a1f3d8eb7715) () |
| override [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [GetFormationClass](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a86ab67dcc6378764530de0070c18e183) () |
| Public Member Functions inherited from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ac5fe2ea1a8d3fcb99b876fa34feebd10) () |
|  | This function is not same with get property of Name. It overrides the function in MBObjectBase class. It is used in encyclopedia etc. |
| override string | [ToString](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a9bf85a9902929170f3e29ef1eacce14a) () |
| void | [InitializeEquipmentsOnLoad](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a818d8c250a1101af9d92381c4dedd10f) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a97373628d8b9c791bdf222d59acc5407) character) |
| [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81) | [GetFirstEquipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ab28a6ec42f8d51f8c7da90128855e78f) (Func< [Equipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a6fbfba4ae6d6ef7b13407f8ff2e6cb81), bool > predicate) |
|  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a97373628d8b9c791bdf222d59acc5407) () |
| int | [GetDefaultFaceSeed](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a5532da5caadeeb047b9c6016429cd630) (int rank) |
| float | [GetStepSize](class_tale_worlds_1_1_core_1_1_basic_character_object.html#af626de99937ee0dbf3b95b25cd390618) () |
| bool | [HasMount](class_tale_worlds_1_1_core_1_1_basic_character_object.html#afb2f961a5e83787dd6241969fe396802) () |
| virtual int | [GetBattleTier](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a8d541b58ad99db1aa184860d09487b30) () |
| [MBCharacterSkills](class_tale_worlds_1_1_core_1_1_m_b_character_skills.html) | [GetDefaultCharacterSkills](class_tale_worlds_1_1_core_1_1_basic_character_object.html#adeeb8c02ce3e492ccf1e6e9e9d8af8e3) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) | [CreateFrom](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1d44573109e63bb0473b15b166442031) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) character, [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html)? staticBodyProperties=null) |
| static [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) | [Find](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a07b425a9adcc717c8728f4e290fe702b) (string idString) |
| static [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) | [FindFirst](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa72e99745e2a62fbe18597126c9650e0) (Predicate< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) > predicate) |
| static IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) > | [FindAll](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a3ec8f0c4a77ccc1cf57f80521d817ec1) (Predicate< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) > predicate) |

|  |  |
| --- | --- |
| Properties | |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a8ad60b414195af0866060e6618804daa) `[get]` |
| string | [EncyclopediaLink](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a39f1599c2cf82644d1a59b32b9098752) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaLinkWithName](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a83508e4ae20e415353dbd6b38022762b) `[get]` |
| bool | [HiddenInEncyclopedia](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ae35f701504c5d8e05277071d00491724) `[get, set]` |
| bool | [IsNotTransferableInPartyScreen](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#abc840d52b0cacbcb9123c18b1d759b75) `[get]` |
| bool | [IsNotTransferableInHideouts](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ac7d65ab8d83c07ee6d5581240edec0a5) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) | [OriginalCharacter](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a5aefd2ea672f6dd4350f91a7f52cd048) `[get]` |
| bool | [IsOriginalCharacter](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6b0ba22284e13f76671efe4b45e6c121) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [HeroObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#af86b0d2ea8998e9b0a6a535aa88defc0) `[get]` |
| override Equipment | [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) `[get]` |
| override IEnumerable< [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) > | [BattleEquipments](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa73da221210534c4f23d40a3e80389ab) `[get]` |
| override IEnumerable< [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) > | [CivilianEquipments](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a2b88d726c25f3e4ebab43555c4f7637d) `[get]` |
| IEnumerable< [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) > | [StealthEquipments](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6bd502818998c2847fd7cf637befc357) `[get]` |
| override [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) | [FirstBattleEquipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a7e3faf9370a482cc56354411f8c61f79) `[get]` |
| override [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) | [FirstCivilianEquipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6ce56018e8b44b8a090ce400a1a6f2eb) `[get]` |
| [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) | [FirstStealthEquipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#abf9a09a83b96c2f932968f1c257a8259) `[get]` |
| override [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) | [RandomBattleEquipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ac092908e5d699eb9772f4a857077eae2) `[get]` |
| override [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) | [RandomCivilianEquipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a45443817e449db981756f246aed9e416) `[get]` |
| override int | [HitPoints](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6d0a05ec7840eb6483a6e103770c02cb) `[get]` |
| [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) | [RandomStealthEquipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#afc2f1bf2ca618e65a4563a7cf7022d88) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [MaxHitPointsExplanation](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a96fd39dbc312b57c0d97699edf34866e) `[get]` |
| override int | [Level](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a4842b01f5b8e4640ad40bc4c177aeebd) `[get]` |
| static [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) | [PlayerCharacter](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ae9757a12e8b786771d0d0da167e4b828) `[get]` |
| static [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) | [OneToOneConversationCharacter](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a3912a2b0c008f0406684d8534bcadbb6) `[get]` |
| static IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) > | [ConversationCharacters](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a578b1aa7eef51ac961fadd48a12db18b) `[get]` |
| bool | [IsMariner](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a5ef8cbef3c720954b34e74e95bb449ba) `[get]` |
| new [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | [Culture](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ac83e8e926a29557cae3b597c9b29aa19) `[get]` |
| override bool | [IsFemale](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a94f76860e2299cf0207463cf3f01130c) `[get]` |
| bool | [IsBasicTroop](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a60069a2edf51425ced4fb75cc9034404) `[get, set]` |
| bool | [IsTemplate](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a9302baaa8c586c8c98328b52dadaf8b5) `[get]` |
| bool | [IsChildTemplate](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aef4a1fa0ba6f018aa45414016d519940) `[get]` |
| override bool | [IsPlayerCharacter](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa5fdf4d300074897781ee5ac002b45f2) `[get]` |
| override bool | [IsHero](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a62b1d5fc0eebd9650249e3f2308e4825) `[get]` |
|  | Gets or sets a value indicating whether the NPC is hero. |
| bool | [IsRegular](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#afcab4b5120b9043b6c421ef1c1f4fa07) `[get]` |
| [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) | [Occupation](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa967843d0d3dafed3bb2fd30ff6b2ef1) `[get]` |
| override float | [Age](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a84aa486de7850df4fb84a03f1636da5a) `[get]` |
| int | [ConformityNeededToRecruitPrisoner](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a28da504a44fd607a6834aa75e97ef611) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432)[] | [UpgradeTargets](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a66a9a7f18710731ed10dea988557e8bc) = new [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432)[0] `[get]` |
| [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | [UpgradeRequiresItemFromCategory](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a309d956019df75275c148a50bd4fc4ae) `[get]` |
| override bool | [IsMounted](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a57718a8e6c778d8f610a385dbeb182ce) `[get]` |
| override bool | [IsRanged](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6ce5c7b63ec79b680212ec40c4654c0e) `[get]` |
| int | [TroopWage](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a76373abbed5d9e968234e57a599de922) `[get]` |
| int | [Tier](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa2643a1f753df35c4c020013a55d3976) `[get]` |
| static MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) > | [All](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ac26e7f803f29f8316c6c606e48a85293) `[get]` |
| Properties inherited from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | |
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

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Attributes inherited from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | |
| static readonly int | [SkillAffectingMaxLevel](class_tale_worlds_1_1_core_1_1_basic_character_object.html#afb2868dfe395c615bcbcfacf38fe9494) = 32 |
| const float | [DefaultKnockbackResistance](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a7f7d0a1cee9188b3569cd56bd268644a) = 25f |
| const float | [DefaultKnockdownResistance](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ab2fb89201492b1141a1e1bb696b7b921) = 50f |
| const float | [DefaultDismountResistance](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a45c20ef6f4bd7d5c2ec66dbaaa4e6ea4) = 50f |
| const int | [MaxBattleTier](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aafe02cc2dc6cd11f1e3eaabc1e63b155) = 7 |
| Protected Member Functions inherited from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | |
| void | [FillFrom](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a764f8630d2e39076e23277bce8196d73) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a97373628d8b9c791bdf222d59acc5407) character) |
| void | [InitializeHeroBasicCharacterOnAfterLoad](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a8c7abae9ccd4c11f6d0b08906e8e3f1e) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a97373628d8b9c791bdf222d59acc5407) originCharacter) |
| void | [AddEquipment](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ac157e3b706e54e595ed2b91e481ba8d3) ([MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) equipmentRoster, EquipmentType equipmentType) |
| int | [FetchDefaultFormationGroup](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a29f0cf181f5c3c66af8ee815f5561771) (string innerText) |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |
| Protected Attributes inherited from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [\_basicName](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a78b957bd41478a70bfad45731dcd742d) |
| [MBCharacterSkills](class_tale_worlds_1_1_core_1_1_m_b_character_skills.html) | [DefaultCharacterSkills](class_tale_worlds_1_1_core_1_1_basic_character_object.html#af2ccdcf630483d67d95d5dcbb1bc3f34) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432)CharacterObject()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CharacterObject.CharacterObject | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#afc8e6cd483a0ceb296bf45c4606363e4)ToString()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.CharacterObject.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ab2435f54c2f82d7d0f7ea6248ae33c1e)MaxHitPoints()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.CharacterObject.MaxHitPoints | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a4c39866b7173aea5ee69c14c0f4b53f5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1d44573109e63bb0473b15b166442031)CreateFrom()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) TaleWorlds.CampaignSystem.CharacterObject.CreateFrom | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) | *character*, | |  |  | [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html)? | *staticBodyProperties* = null ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a9a38af5536784bb3c13d7f81be28da1e)AfterRegister()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CharacterObject.AfterRegister | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6015d59f2c1c544b04f5d2caf6be480b)GetBodyPropertiesMin()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.CampaignSystem.CharacterObject.GetBodyPropertiesMin | ( | bool | *returnBaseValue* = false | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a655dd5f207ffad4833c578d5f7944124).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#afeea5ae58ff341b321e003051844cab2)GetBodyPropertiesMax()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.CampaignSystem.CharacterObject.GetBodyPropertiesMax | ( | bool | *returnBaseValue* = false | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a844ac49f150b4ee1b14fca6f60326ded).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a229b2e35324a08e2f4177b3b3d54cd56)UpdatePlayerCharacterBodyProperties()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CharacterObject.UpdatePlayerCharacterBodyProperties | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *properties*, | |  |  | int | *race*, | |  |  | bool | *isFemale* ) | | virtual |

Reimplemented from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#abf8feb95673ae7b55f15e0e39cf96a1e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#adef5542bc11167a1d7eba1af530401dd)GetDefaultOccupation()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) TaleWorlds.CampaignSystem.CharacterObject.GetDefaultOccupation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a234489d7710b3cd040d7b5578f0d546d)HasThrowingWeapon()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CharacterObject.HasThrowingWeapon | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a249029408c21e56b60a8abd115481f05)GetUpgradeXpCost()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterObject.GetUpgradeXpCost | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | int | *index* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a830d2be52e3008a52337ea50f1ebce07)GetUpgradeGoldCost()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterObject.GetUpgradeGoldCost | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | int | *index* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a7c230f0a61272bfe05d41f46495252fe)InitializeHeroCharacterOnAfterLoad()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterObject.InitializeHeroCharacterOnAfterLoad | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ab7af1336146cbbed86b03e0252a61514)Deserialize()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CharacterObject.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | node | XmlNode to be de-serialized from. |

Reimplemented from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a036f5c085184281cd1a06399010cdab0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#afe0dabaa06b3f1696738a332d5a339d2)GetPower()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override float TaleWorlds.CampaignSystem.CharacterObject.GetPower | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#ad9d9813b9a1ae6ab3296debd1f7f8ec0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a2078a7d7805ed5148eb83fba8a9252bc)GetBattlePower()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override float TaleWorlds.CampaignSystem.CharacterObject.GetBattlePower | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a8d4abbf29a34e79e53ee627ba5637ccb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1ce6833d58d3416b8f62bbc3aa738d49)GetMoraleResistance()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override float TaleWorlds.CampaignSystem.CharacterObject.GetMoraleResistance | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#aa05656b29cade1cd89bf916dfb6a236d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa6f2ffad771ff756f8e41331020c76f9)GetSimulationAttackPower()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterObject.GetSimulationAttackPower | ( | out float | *attackPoints*, |
|  |  | out float | *defencePoints*, |
|  |  | [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) | *equipment* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a340d39416c4c0e533edea8988d014b3e)GetHeadArmorSum()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.CharacterObject.GetHeadArmorSum | ( | Equipment.EquipmentType | *equipmentType* = Equipment::EquipmentType::Battle | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a3227da01bf54bb02ab35866599cbe9cf)GetBodyArmorSum()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.CharacterObject.GetBodyArmorSum | ( | Equipment.EquipmentType | *equipmentType* = Equipment::EquipmentType::Battle | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa6520bdcff325ffb2fa96d03e09abf82)GetLegArmorSum()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.CharacterObject.GetLegArmorSum | ( | Equipment.EquipmentType | *equipmentType* = Equipment::EquipmentType::Battle | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a38bb7c305dbb8bdf8abf340da1da82ba)GetArmArmorSum()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.CharacterObject.GetArmArmorSum | ( | Equipment.EquipmentType | *equipmentType* = Equipment::EquipmentType::Battle | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a44e733245cefa6795a575cf3cbc40f0b)GetHorseArmorSum()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.CharacterObject.GetHorseArmorSum | ( | Equipment.EquipmentType | *equipmentType* = Equipment::EquipmentType::Battle | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a9b502c860ec39b23b932c198052e6e3a)GetTotalArmorSum()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.CharacterObject.GetTotalArmorSum | ( | Equipment.EquipmentType | *equipmentType* = Equipment::EquipmentType::Battle | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a20bbcb629c13a7a2f022879490767e26)GetBodyProperties()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.CampaignSystem.CharacterObject.GetBodyProperties | ( | [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) | *equipment*, | |  |  | int | *seed* = -1 ) | | virtual |

Reimplemented from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a4b587db46dcd8f9ecf3e8488ed4c0abd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1775a09bd50fe489c2e386fbbda2e723)SetTransferableInPartyScreen()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterObject.SetTransferableInPartyScreen | ( | bool | *isTransferable* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | isTransferable |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#af4ec96e35ddc7d5b3256a58736b7a299)SetTransferableInHideouts()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterObject.SetTransferableInHideouts | ( | bool | *isTransferable* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | isTransferable |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a7dac4aaf516d49b1a1759bbee69ac037)ClearAttributes()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterObject.ClearAttributes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a5314c273b22fa8182d02c8a7012a73b5)GetTraitLevel()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CharacterObject.GetTraitLevel | ( | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ae61177ba4749b91d407d6861cb7c6676)GetPerkValue()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CharacterObject.GetPerkValue | ( | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aeaf48005c2355806455637b1dbd74a8b)GetSkillValue()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.CharacterObject.GetSkillValue | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a42ea2bc67456fe86b090e72583a23a12).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a53caa03d682a9b3a49b99977fe41f4ec)GetPersona()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) TaleWorlds.CampaignSystem.CharacterObject.GetPersona | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#abf4e0c228a424e273695a1f3d8eb7715)GetMountKeySeed()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.CharacterObject.GetMountKeySeed | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a1c31d875166ef247f782cd654eaa695f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a86ab67dcc6378764530de0070c18e183)GetFormationClass()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.CampaignSystem.CharacterObject.GetFormationClass | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html#a455c0163c9617798707a8c7ea10aadde).

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a07b425a9adcc717c8728f4e290fe702b)Find()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) TaleWorlds.CampaignSystem.CharacterObject.Find | ( | string | *idString* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa72e99745e2a62fbe18597126c9650e0)FindFirst()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) TaleWorlds.CampaignSystem.CharacterObject.FindFirst | ( | Predicate< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) > | *predicate* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a3ec8f0c4a77ccc1cf57f80521d817ec1)FindAll()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) > TaleWorlds.CampaignSystem.CharacterObject.FindAll | ( | Predicate< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) > | *predicate* | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a8ad60b414195af0866060e6618804daa)Name
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CharacterObject.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a39f1599c2cf82644d1a59b32b9098752)EncyclopediaLink
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.CharacterObject.EncyclopediaLink | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a83508e4ae20e415353dbd6b38022762b)EncyclopediaLinkWithName
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CharacterObject.EncyclopediaLinkWithName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ae35f701504c5d8e05277071d00491724)HiddenInEncyclopedia
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CharacterObject.HiddenInEncyclopedia | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#abc840d52b0cacbcb9123c18b1d759b75)IsNotTransferableInPartyScreen
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CharacterObject.IsNotTransferableInPartyScreen | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ac7d65ab8d83c07ee6d5581240edec0a5)IsNotTransferableInHideouts
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CharacterObject.IsNotTransferableInHideouts | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a5aefd2ea672f6dd4350f91a7f52cd048)OriginalCharacter
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) TaleWorlds.CampaignSystem.CharacterObject.OriginalCharacter | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6b0ba22284e13f76671efe4b45e6c121)IsOriginalCharacter
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CharacterObject.IsOriginalCharacter | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#af86b0d2ea8998e9b0a6a535aa88defc0)HeroObject
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.CharacterObject.HeroObject | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e)Equipment
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override Equipment TaleWorlds.CampaignSystem.CharacterObject.Equipment | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa73da221210534c4f23d40a3e80389ab)BattleEquipments
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override IEnumerable<[Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e)> TaleWorlds.CampaignSystem.CharacterObject.BattleEquipments | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a2b88d726c25f3e4ebab43555c4f7637d)CivilianEquipments
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override IEnumerable<[Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e)> TaleWorlds.CampaignSystem.CharacterObject.CivilianEquipments | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6bd502818998c2847fd7cf637befc357)StealthEquipments
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e)> TaleWorlds.CampaignSystem.CharacterObject.StealthEquipments | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a7e3faf9370a482cc56354411f8c61f79)FirstBattleEquipment
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) TaleWorlds.CampaignSystem.CharacterObject.FirstBattleEquipment | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6ce56018e8b44b8a090ce400a1a6f2eb)FirstCivilianEquipment
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) TaleWorlds.CampaignSystem.CharacterObject.FirstCivilianEquipment | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#abf9a09a83b96c2f932968f1c257a8259)FirstStealthEquipment
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) TaleWorlds.CampaignSystem.CharacterObject.FirstStealthEquipment | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ac092908e5d699eb9772f4a857077eae2)RandomBattleEquipment
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) TaleWorlds.CampaignSystem.CharacterObject.RandomBattleEquipment | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a45443817e449db981756f246aed9e416)RandomCivilianEquipment
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) TaleWorlds.CampaignSystem.CharacterObject.RandomCivilianEquipment | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6d0a05ec7840eb6483a6e103770c02cb)HitPoints
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.CharacterObject.HitPoints | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#afc2f1bf2ca618e65a4563a7cf7022d88)RandomStealthEquipment
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Equipment](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a0767184a5742d3108cc048706ea37b5e) TaleWorlds.CampaignSystem.CharacterObject.RandomStealthEquipment | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a96fd39dbc312b57c0d97699edf34866e)MaxHitPointsExplanation
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.CharacterObject.MaxHitPointsExplanation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a4842b01f5b8e4640ad40bc4c177aeebd)Level
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.CharacterObject.Level | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ae9757a12e8b786771d0d0da167e4b828)PlayerCharacter
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) TaleWorlds.CampaignSystem.CharacterObject.PlayerCharacter | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a3912a2b0c008f0406684d8534bcadbb6)OneToOneConversationCharacter
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) TaleWorlds.CampaignSystem.CharacterObject.OneToOneConversationCharacter | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a578b1aa7eef51ac961fadd48a12db18b)ConversationCharacters
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432)> TaleWorlds.CampaignSystem.CharacterObject.ConversationCharacters | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a5ef8cbef3c720954b34e74e95bb449ba)IsMariner
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CharacterObject.IsMariner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ac83e8e926a29557cae3b597c9b29aa19)Culture
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | new [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) TaleWorlds.CampaignSystem.CharacterObject.Culture | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a94f76860e2299cf0207463cf3f01130c)IsFemale
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.CharacterObject.IsFemale | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a60069a2edf51425ced4fb75cc9034404)IsBasicTroop
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CharacterObject.IsBasicTroop | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a9302baaa8c586c8c98328b52dadaf8b5)IsTemplate
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CharacterObject.IsTemplate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aef4a1fa0ba6f018aa45414016d519940)IsChildTemplate
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CharacterObject.IsChildTemplate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa5fdf4d300074897781ee5ac002b45f2)IsPlayerCharacter
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.CharacterObject.IsPlayerCharacter | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a62b1d5fc0eebd9650249e3f2308e4825)IsHero
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.CharacterObject.IsHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#afcab4b5120b9043b6c421ef1c1f4fa07)IsRegular
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CharacterObject.IsRegular | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa967843d0d3dafed3bb2fd30ff6b2ef1)Occupation
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) TaleWorlds.CampaignSystem.CharacterObject.Occupation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a84aa486de7850df4fb84a03f1636da5a)Age
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.CharacterObject.Age | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a28da504a44fd607a6834aa75e97ef611)ConformityNeededToRecruitPrisoner
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CharacterObject.ConformityNeededToRecruitPrisoner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a66a9a7f18710731ed10dea988557e8bc)UpgradeTargets
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432) [] TaleWorlds.CampaignSystem.CharacterObject.UpgradeTargets = new [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432)[0] | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a309d956019df75275c148a50bd4fc4ae)UpgradeRequiresItemFromCategory
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) TaleWorlds.CampaignSystem.CharacterObject.UpgradeRequiresItemFromCategory | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a57718a8e6c778d8f610a385dbeb182ce)IsMounted
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.CharacterObject.IsMounted | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a6ce5c7b63ec79b680212ec40c4654c0e)IsRanged
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.CharacterObject.IsRanged | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a76373abbed5d9e968234e57a599de922)TroopWage
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CharacterObject.TroopWage | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#aa2643a1f753df35c4c020013a55d3976)Tier
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CharacterObject.Tier | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#ac26e7f803f29f8316c6c606e48a85293)All
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html#a1de99d6b2219c5f98a54a04f10f54432)> TaleWorlds.CampaignSystem.CharacterObject.All | | staticget |


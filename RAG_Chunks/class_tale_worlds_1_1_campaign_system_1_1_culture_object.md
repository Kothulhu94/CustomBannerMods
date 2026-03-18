--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_culture_object.html ---

TaleWorlds.CampaignSystem.CultureObject Class ReferencesealedRepresents a campaign culture.

Inherits [TaleWorlds.Core.BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [BoardGameType](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69a) {     [None](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69aa6adf97f83acf6453d4a6a4b1070f3754) = -1 ,     [Seega](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69aaf45d6de3aeef09a54ab03a275db48dd4) = 0 ,     [Puluc](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69aac0fca4ae2b044da3630c84649fa829d4) = 1 ,     [Konane](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69aa398418c3d9d93de8aa8b8d5c5e815334) = 2 ,     [MuTorere](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69aa56ea8feac4f0982e911183e683e91fed) = 3 ,     [Tablut](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69aa50e3f1b237918e9814b7797bf8a694a1) = 4 ,     [BaghChal](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69aa90b302a972d9f5cd4c2b842bc3311eac) = 5 ,     [Total](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69aa96b0141273eabab320119c467cdcaf17)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [HasTrait](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a347a124e8362da48bb928d418afe2000) ([CultureTrait](class_tale_worlds_1_1_campaign_system_1_1_culture_trait.html) trait) |
| bool | [HasFeat](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a8fab0aa24f20839766e6305997962e8b) ([FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html) feat) |
| IEnumerable< [FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html) > | [GetCulturalFeats](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ad0e7307fefed6432ef71efe41e1f234c) (Func< [FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html), bool > predicate=null) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ab5712b06d4e2a07c1c7939def803fbcb) () |
| override void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0a08e66bd8de6732ee891113f76d89cc) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a2f6579c13255e1601be91a883fc4d0b3) () |
| Public Member Functions inherited from [TaleWorlds.Core.BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | |
| override string | [ToString](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#aace27c5341fc5c9adff6eb436ee7834d) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Properties | |
| [CultureTrait](class_tale_worlds_1_1_campaign_system_1_1_culture_trait.html)[] | [Traits](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#adab3eec51a4726630cc65ee6d7d4d341) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [BasicTroop](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aa78f76df9e1b686d5e5ace93ccc307c5) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [EliteBasicTroop](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a86913f8978072f63fee5e4f9e1a6c4a7) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [MeleeMilitiaTroop](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0e5cab3fa49545dfe49163bb6a3317b8) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [MeleeEliteMilitiaTroop](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a948c76081e37e4a8f2825f6347944f52) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [RangedEliteMilitiaTroop](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a31ed0b523ae859c1dc6e352041c0a4b0) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [RangedMilitiaTroop](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a06f983e7c0ca841951c5e009c0ceb5ce) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [TournamentMaster](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0a1c1015945f8ddbe84eaf8e419acb45) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Villager](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a331faa65fe7b73d29a5c6dd1ef978ea0) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [CaravanMaster](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a575a2276c3c46bb3c4114f7dabaaf88b) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [CaravanGuard](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a216f73257495355701f35498828d4413) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [PrisonGuard](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aa53dd4a4dd8fd28f9807f4904249a0c2) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Guard](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#affbefdef82a7a6cce6301884c120f674) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Blacksmith](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0e00a30d3fecb7af88268a5f40158880) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Weaponsmith](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a3739f898bdc76fd62895b5946bb59efb) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Townswoman](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a1c7d9784314d1f8188d10ef6ad17352b) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [TownswomanInfant](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a032aeb4cadabf16edd4d859f592fe17b) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [TownswomanChild](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a2f115d4bc73a222daff71ff9c5f1824e) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [TownswomanTeenager](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a824c47e1d0a54cda063bd993f47dbce9) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [VillageWoman](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a33fab2603205ce6487d1b11e85bd4262) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [VillagerMaleChild](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a4029fa70d8f6e3e0788920cef1336451) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [VillagerMaleTeenager](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0750bb764cd904dc9c76c389ff868e8b) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [VillagerFemaleChild](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a7889f15a3290a347137e197e80ea38b1) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [VillagerFemaleTeenager](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a1da7297daf172826f37e9c1884010a7f) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Townsman](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#adc38e15eefcbff1a22720df37c1951ed) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [TownsmanInfant](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a9b3ded1aa46fd3699613992d0cde4748) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [TownsmanChild](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a4a5ebe4c6671f3d20704e2b8fb47432c) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [TownsmanTeenager](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ac55071f29814c992016f47690517d431) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [RansomBroker](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aaf20bae000d94a0fad1272dc9f034d64) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GangleaderBodyguard](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a26003adae6609bdec4ff4b84ac44652f) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [MerchantNotary](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aad711bc7ecb8eb0338f986f7095d0f98) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [ArtisanNotary](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a038517fdcfcf67e74d9ca828d0c39e30) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [PreacherNotary](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a612df6044728cf2c48a6a41ce44e81db) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [RuralNotableNotary](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a81f6ca68b7c213558bbfff0ddca3a165) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [ShopWorker](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ac67b8c82cb873a45bbed55f991570af0) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Tavernkeeper](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a63c08ff547aca32c4ea56845a722131a) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [TavernGamehost](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a1b5e68d294c27c6c3b2b6a88e2d05cb4) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Musician](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a69b6f091a4242adb07038c17b6bb76e2) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [TavernWench](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a4151fad3113ee859961dffc1d9f76e90) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Armorer](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a1768f5f4d3117b8077efe8d96b1f9bb9) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [HorseMerchant](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#afe67a2ee7020e1ebf9416646ad9d6167) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Barber](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aa629187079970eb11ae09a7758ada942) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Merchant](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0edf719260e78a734458ea6709a2fe47) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Beggar](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#afae168238dedec421bae17de792d7e32) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [FemaleBeggar](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ab694a5d28114421cb1adc95a5e7a2d2c) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [FemaleDancer](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ad04784a8daef6c25dd87ad53f493d0df) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [Shipwright](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a5ac30e1769f0b5b9abf7b68666fd9056) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [MilitiaVeteranArcher](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0b4aeadc636623da70049145a62bfbd0) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GearDummy](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aaebb9cacae62233d578dbf91b0304b8a) `[get]` |
| [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) | [DefaultBattleEquipmentRoster](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ac86291597673fc55fa09d6af3e7b3e52) `[get]` |
| [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) | [DefaultCivilianEquipmentRoster](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#accb6ee0fcdb28cdc1b5399a7aa2acca5) `[get]` |
| [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) | [DefaultStealthEquipmentRoster](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ae147f19464831d81f7b4e33b57e85a4f) `[get]` |
| [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) | [DuelPresetEquipmentRoster](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a65b4c5a7e1f50894116425aa22ca24ce) `[get]` |
| [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) | [MarriageBrideEquipmentRoster](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#abf24601384dd85c8a8750cb15bb6aa24) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [BanditChief](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aa52111455975bb91fbe691a9f79dcffd) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [BanditRaider](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a32099b478d1e1ef27329440256ea28cb) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [BanditBandit](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a4714138897d3a0780c6ddaeb09be0b2c) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [BanditBoss](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aaa86d0ad009be5dd962ada9cead04613) `[get]` |
| [MBBodyProperty](class_tale_worlds_1_1_core_1_1_m_b_body_property.html) | [DefaultCharacterCreationBodyProperty](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ac2e82d9cedcec81cdfd0a426e8acd4a2) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaText](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ad16370fe26362f23411e439e2e41b26c) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [StartingPoint](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a6173cb44070c8cda5dd869b4ae33fcae) `[get]` |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [DefaultPartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a298635f611d704ab995dbe8a8d3cadc8) `[get]` |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [VillagerPartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a9fb05aa1def05489843da2c6791cad71) `[get]` |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [FishingPartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ad309c56838caadf074835e811b742c05) `[get]` |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [MilitiaPartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ab9c40ef6f0bd1e04eb8caf5e17995ee5) `[get]` |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [RebelsPartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a2dfc2de0e0d12a52c5e01bfc1eb18420) `[get]` |
| MBList< [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) > | [CaravanPartyTemplates](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a474bc7b373bc8fe9478f121441611ecb) `[get]` |
| MBList< [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) > | [EliteCaravanPartyTemplates](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a5d1a584b21bfb8ed148d3fdd3e90feb9) `[get]` |
| MBList< [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) > | [AvailableShipHulls](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a7d7c1e004813d6cac1ff5b93c8c350f3) `[get]` |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [BanditBossPartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a4dfe26988288788b307ecf6473e1798a) `[get]` |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [VassalRewardTroopsPartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ac244b8235691bffc4f5877c831cd0fd0) `[get]` |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [SettlementPatrolPartyTemplateWeak](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ab000f9436aca4def758d1ba88a63cb74) `[get]` |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [SettlementPatrolPartyTemplateModerate](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a97ab22e6b186d511ca2d7b45b72e8d66) `[get]` |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [SettlementPatrolPartyTemplateStrong](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ac322d8b07044c7fc7274427f677a7cf4) `[get]` |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [SettlementPatrolPartyTemplateNaval](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ad8392591b2caa80f608690a956d18322) `[get]` |
| MBReadOnlyList< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [VassalRewardItems](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aa800f56e2c6a8d5d768d8e5360a3c0ca) `[get]` |
| MBReadOnlyList< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [BannerBearerReplacementWeapons](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a75619748a3f1425f8311d60a33d105eb) `[get]` |
| MBReadOnlyList< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [MaleNameList](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a9696fe3ca69cc6c2ba9da0b37fb64d88) `[get]` |
| MBReadOnlyList< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [FemaleNameList](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a695f9082423b3f912928be064c3fd6a6) `[get]` |
| MBReadOnlyList< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [ClanNameList](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a60fb5684738eacda6d11163b54b3899b) `[get]` |
| MBReadOnlyList< [FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html) > | [CultureFeats](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a325e26672cf613bb6199141812600b81) `[get]` |
| MBReadOnlyList< [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html) > | [DefaultPolicyList](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ad9b828611fd36ae7707721bb10045728) `[get]` |
| MBReadOnlyList< int > | [PossibleClanBannerIconsIDs](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#adb0653c61959752a378a92173d95141f) `[get]` |
| MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [NotableTemplates](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0a0dad17601f7331a540845b6c0ac0cb) `[get]` |
| MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [RebelliousHeroTemplates](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a4b69d4d70fb60163389f3810a9987311) `[get]` |
| MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [LordTemplates](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a47aa7c437fdaebce605227fde2ef0b12) `[get]` |
| MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [TournamentTeamTemplatesForOneParticipant](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a43eed8fec88feff8c96476f5e26ead56) `[get]` |
| MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [TournamentTeamTemplatesForTwoParticipant](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a8c411e7f56f7ea37b8444239916bdbde) `[get]` |
| MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [TournamentTeamTemplatesForFourParticipant](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a9e9f2aa78babfdc6b7563f2096cdc520) `[get]` |
| MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [BasicMercenaryTroops](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ae636c489c77ae7e2b1ac4223324d266c) `[get]` |
| int | [MilitiaBonus](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a445cd39b36b83b36d58d93b56bd0b1f6) `[get, set]` |
| int | [ProsperityBonus](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a6d88de1138aaeb5771d1ffee0157261d) `[get, set]` |
| [BoardGameType](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69a) | [BoardGame](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#abd33fd32423929924c6f30bb5d7d3a4d) `[get]` |
| float | [NavalFactor](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a8b320e1fdc157d2cbf036935bb09e0e5) `[get]` |
| Properties inherited from [TaleWorlds.Core.BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#ad44d0f122ac7dc7d0f562d0ba1706b3a) `[get]` |
| bool | [IsMainCulture](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a53731eaa2842ac9eb6dedee6f14dfb75) `[get]` |
| bool | [IsBandit](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a9e265e5d55c7182f230c7973c3f98469) `[get]` |
| bool | [CanHaveSettlement](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a48fb2f71a2bae5935ef6dd910b7c5eca) `[get]` |
| uint | [Color](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a514160abb6f52436d4cf514d66ee5371) `[get]` |
| uint | [Color2](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#ae4453082495646c4cc630e9abe49209e) `[get]` |
| uint | [ClothAlternativeColor](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a49a8c90109fc6e94cf3ebd4605a2c4f1) `[get]` |
| uint | [ClothAlternativeColor2](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a2c83870edc37d46c26c852e453fbe080) `[get]` |
| uint | [BackgroundColor1](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#af2e360b96a8c37273960c38429416a9f) `[get]` |
| uint | [ForegroundColor1](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a4c93dbef03b672643b4b227d711acfe1) `[get]` |
| uint | [BackgroundColor2](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a48233acc2dc63135d3ce35d7748b08b0) `[get]` |
| uint | [ForegroundColor2](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#ab06ef46a94c39c3213d668971686e4ed) `[get]` |
| string | [EncounterBackgroundMesh](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#ac79a2edb28346511312c53a826d69bdf) `[get, set]` |
| Banner | [Banner](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a7c7ae3feac1f8c89a710d6d079506ee4) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69a)BoardGameType
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.CultureObject.BoardGameType](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69a) |

| Enumerator | |
| --- | --- |
| None |  |
| Seega |  |
| Puluc |  |
| Konane |  |
| MuTorere |  |
| Tablut |  |
| BaghChal |  |
| Total |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a347a124e8362da48bb928d418afe2000)HasTrait()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CultureObject.HasTrait | ( | [CultureTrait](class_tale_worlds_1_1_campaign_system_1_1_culture_trait.html) | *trait* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a8fab0aa24f20839766e6305997962e8b)HasFeat()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CultureObject.HasFeat | ( | [FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html) | *feat* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ad0e7307fefed6432ef71efe41e1f234c)GetCulturalFeats()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html) > TaleWorlds.CampaignSystem.CultureObject.GetCulturalFeats | ( | Func< [FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html), bool > | *predicate* = null | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ab5712b06d4e2a07c1c7939def803fbcb)ToString()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.CultureObject.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0a08e66bd8de6732ee891113f76d89cc)Deserialize()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CultureObject.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.Core.BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#af5970d116c9779607106c7fc1ec3e136).

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a2f6579c13255e1601be91a883fc4d0b3)GetName()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CultureObject.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#adab3eec51a4726630cc65ee6d7d4d341)Traits
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CultureTrait](class_tale_worlds_1_1_campaign_system_1_1_culture_trait.html) [] TaleWorlds.CampaignSystem.CultureObject.Traits | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aa78f76df9e1b686d5e5ace93ccc307c5)BasicTroop
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.BasicTroop | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a86913f8978072f63fee5e4f9e1a6c4a7)EliteBasicTroop
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.EliteBasicTroop | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0e5cab3fa49545dfe49163bb6a3317b8)MeleeMilitiaTroop
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.MeleeMilitiaTroop | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a948c76081e37e4a8f2825f6347944f52)MeleeEliteMilitiaTroop
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.MeleeEliteMilitiaTroop | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a31ed0b523ae859c1dc6e352041c0a4b0)RangedEliteMilitiaTroop
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.RangedEliteMilitiaTroop | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a06f983e7c0ca841951c5e009c0ceb5ce)RangedMilitiaTroop
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.RangedMilitiaTroop | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0a1c1015945f8ddbe84eaf8e419acb45)TournamentMaster
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.TournamentMaster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a331faa65fe7b73d29a5c6dd1ef978ea0)Villager
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Villager | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a575a2276c3c46bb3c4114f7dabaaf88b)CaravanMaster
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.CaravanMaster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a216f73257495355701f35498828d4413)CaravanGuard
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.CaravanGuard | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aa53dd4a4dd8fd28f9807f4904249a0c2)PrisonGuard
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.PrisonGuard | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#affbefdef82a7a6cce6301884c120f674)Guard
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Guard | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0e00a30d3fecb7af88268a5f40158880)Blacksmith
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Blacksmith | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a3739f898bdc76fd62895b5946bb59efb)Weaponsmith
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Weaponsmith | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a1c7d9784314d1f8188d10ef6ad17352b)Townswoman
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Townswoman | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a032aeb4cadabf16edd4d859f592fe17b)TownswomanInfant
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.TownswomanInfant | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a2f115d4bc73a222daff71ff9c5f1824e)TownswomanChild
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.TownswomanChild | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a824c47e1d0a54cda063bd993f47dbce9)TownswomanTeenager
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.TownswomanTeenager | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a33fab2603205ce6487d1b11e85bd4262)VillageWoman
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.VillageWoman | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a4029fa70d8f6e3e0788920cef1336451)VillagerMaleChild
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.VillagerMaleChild | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0750bb764cd904dc9c76c389ff868e8b)VillagerMaleTeenager
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.VillagerMaleTeenager | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a7889f15a3290a347137e197e80ea38b1)VillagerFemaleChild
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.VillagerFemaleChild | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a1da7297daf172826f37e9c1884010a7f)VillagerFemaleTeenager
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.VillagerFemaleTeenager | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#adc38e15eefcbff1a22720df37c1951ed)Townsman
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Townsman | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a9b3ded1aa46fd3699613992d0cde4748)TownsmanInfant
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.TownsmanInfant | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a4a5ebe4c6671f3d20704e2b8fb47432c)TownsmanChild
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.TownsmanChild | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ac55071f29814c992016f47690517d431)TownsmanTeenager
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.TownsmanTeenager | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aaf20bae000d94a0fad1272dc9f034d64)RansomBroker
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.RansomBroker | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a26003adae6609bdec4ff4b84ac44652f)GangleaderBodyguard
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.GangleaderBodyguard | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aad711bc7ecb8eb0338f986f7095d0f98)MerchantNotary
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.MerchantNotary | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a038517fdcfcf67e74d9ca828d0c39e30)ArtisanNotary
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.ArtisanNotary | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a612df6044728cf2c48a6a41ce44e81db)PreacherNotary
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.PreacherNotary | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a81f6ca68b7c213558bbfff0ddca3a165)RuralNotableNotary
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.RuralNotableNotary | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ac67b8c82cb873a45bbed55f991570af0)ShopWorker
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.ShopWorker | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a63c08ff547aca32c4ea56845a722131a)Tavernkeeper
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Tavernkeeper | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a1b5e68d294c27c6c3b2b6a88e2d05cb4)TavernGamehost
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.TavernGamehost | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a69b6f091a4242adb07038c17b6bb76e2)Musician
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Musician | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a4151fad3113ee859961dffc1d9f76e90)TavernWench
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.TavernWench | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a1768f5f4d3117b8077efe8d96b1f9bb9)Armorer
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Armorer | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#afe67a2ee7020e1ebf9416646ad9d6167)HorseMerchant
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.HorseMerchant | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aa629187079970eb11ae09a7758ada942)Barber
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Barber | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0edf719260e78a734458ea6709a2fe47)Merchant
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Merchant | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#afae168238dedec421bae17de792d7e32)Beggar
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Beggar | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ab694a5d28114421cb1adc95a5e7a2d2c)FemaleBeggar
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.FemaleBeggar | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ad04784a8daef6c25dd87ad53f493d0df)FemaleDancer
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.FemaleDancer | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a5ac30e1769f0b5b9abf7b68666fd9056)Shipwright
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.Shipwright | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0b4aeadc636623da70049145a62bfbd0)MilitiaVeteranArcher
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.MilitiaVeteranArcher | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aaebb9cacae62233d578dbf91b0304b8a)GearDummy
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.GearDummy | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ac86291597673fc55fa09d6af3e7b3e52)DefaultBattleEquipmentRoster
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) TaleWorlds.CampaignSystem.CultureObject.DefaultBattleEquipmentRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#accb6ee0fcdb28cdc1b5399a7aa2acca5)DefaultCivilianEquipmentRoster
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) TaleWorlds.CampaignSystem.CultureObject.DefaultCivilianEquipmentRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ae147f19464831d81f7b4e33b57e85a4f)DefaultStealthEquipmentRoster
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) TaleWorlds.CampaignSystem.CultureObject.DefaultStealthEquipmentRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a65b4c5a7e1f50894116425aa22ca24ce)DuelPresetEquipmentRoster
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) TaleWorlds.CampaignSystem.CultureObject.DuelPresetEquipmentRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#abf24601384dd85c8a8750cb15bb6aa24)MarriageBrideEquipmentRoster
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBEquipmentRoster](class_tale_worlds_1_1_core_1_1_m_b_equipment_roster.html) TaleWorlds.CampaignSystem.CultureObject.MarriageBrideEquipmentRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aa52111455975bb91fbe691a9f79dcffd)BanditChief
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.BanditChief | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a32099b478d1e1ef27329440256ea28cb)BanditRaider
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.BanditRaider | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a4714138897d3a0780c6ddaeb09be0b2c)BanditBandit
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.BanditBandit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aaa86d0ad009be5dd962ada9cead04613)BanditBoss
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.CultureObject.BanditBoss | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ac2e82d9cedcec81cdfd0a426e8acd4a2)DefaultCharacterCreationBodyProperty
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBBodyProperty](class_tale_worlds_1_1_core_1_1_m_b_body_property.html) TaleWorlds.CampaignSystem.CultureObject.DefaultCharacterCreationBodyProperty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ad16370fe26362f23411e439e2e41b26c)EncyclopediaText
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CultureObject.EncyclopediaText | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a6173cb44070c8cda5dd869b4ae33fcae)StartingPoint
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.CultureObject.StartingPoint | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a298635f611d704ab995dbe8a8d3cadc8)DefaultPartyTemplate
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.CultureObject.DefaultPartyTemplate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a9fb05aa1def05489843da2c6791cad71)VillagerPartyTemplate
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.CultureObject.VillagerPartyTemplate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ad309c56838caadf074835e811b742c05)FishingPartyTemplate
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.CultureObject.FishingPartyTemplate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ab9c40ef6f0bd1e04eb8caf5e17995ee5)MilitiaPartyTemplate
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.CultureObject.MilitiaPartyTemplate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a2dfc2de0e0d12a52c5e01bfc1eb18420)RebelsPartyTemplate
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.CultureObject.RebelsPartyTemplate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a474bc7b373bc8fe9478f121441611ecb)CaravanPartyTemplates
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html)> TaleWorlds.CampaignSystem.CultureObject.CaravanPartyTemplates | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a5d1a584b21bfb8ed148d3fdd3e90feb9)EliteCaravanPartyTemplates
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html)> TaleWorlds.CampaignSystem.CultureObject.EliteCaravanPartyTemplates | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a7d7c1e004813d6cac1ff5b93c8c350f3)AvailableShipHulls
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html)> TaleWorlds.CampaignSystem.CultureObject.AvailableShipHulls | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a4dfe26988288788b307ecf6473e1798a)BanditBossPartyTemplate
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.CultureObject.BanditBossPartyTemplate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ac244b8235691bffc4f5877c831cd0fd0)VassalRewardTroopsPartyTemplate
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.CultureObject.VassalRewardTroopsPartyTemplate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ab000f9436aca4def758d1ba88a63cb74)SettlementPatrolPartyTemplateWeak
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.CultureObject.SettlementPatrolPartyTemplateWeak | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a97ab22e6b186d511ca2d7b45b72e8d66)SettlementPatrolPartyTemplateModerate
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.CultureObject.SettlementPatrolPartyTemplateModerate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ac322d8b07044c7fc7274427f677a7cf4)SettlementPatrolPartyTemplateStrong
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.CultureObject.SettlementPatrolPartyTemplateStrong | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ad8392591b2caa80f608690a956d18322)SettlementPatrolPartyTemplateNaval
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.CultureObject.SettlementPatrolPartyTemplateNaval | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#aa800f56e2c6a8d5d768d8e5360a3c0ca)VassalRewardItems
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html)> TaleWorlds.CampaignSystem.CultureObject.VassalRewardItems | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a75619748a3f1425f8311d60a33d105eb)BannerBearerReplacementWeapons
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html)> TaleWorlds.CampaignSystem.CultureObject.BannerBearerReplacementWeapons | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a9696fe3ca69cc6c2ba9da0b37fb64d88)MaleNameList
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)> TaleWorlds.CampaignSystem.CultureObject.MaleNameList | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a695f9082423b3f912928be064c3fd6a6)FemaleNameList
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)> TaleWorlds.CampaignSystem.CultureObject.FemaleNameList | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a60fb5684738eacda6d11163b54b3899b)ClanNameList
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)> TaleWorlds.CampaignSystem.CultureObject.ClanNameList | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a325e26672cf613bb6199141812600b81)CultureFeats
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html)> TaleWorlds.CampaignSystem.CultureObject.CultureFeats | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ad9b828611fd36ae7707721bb10045728)DefaultPolicyList
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html)> TaleWorlds.CampaignSystem.CultureObject.DefaultPolicyList | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#adb0653c61959752a378a92173d95141f)PossibleClanBannerIconsIDs
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<int> TaleWorlds.CampaignSystem.CultureObject.PossibleClanBannerIconsIDs | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0a0dad17601f7331a540845b6c0ac0cb)NotableTemplates
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.CultureObject.NotableTemplates | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a4b69d4d70fb60163389f3810a9987311)RebelliousHeroTemplates
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.CultureObject.RebelliousHeroTemplates | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a47aa7c437fdaebce605227fde2ef0b12)LordTemplates
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.CultureObject.LordTemplates | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a43eed8fec88feff8c96476f5e26ead56)TournamentTeamTemplatesForOneParticipant
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.CultureObject.TournamentTeamTemplatesForOneParticipant | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a8c411e7f56f7ea37b8444239916bdbde)TournamentTeamTemplatesForTwoParticipant
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.CultureObject.TournamentTeamTemplatesForTwoParticipant | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a9e9f2aa78babfdc6b7563f2096cdc520)TournamentTeamTemplatesForFourParticipant
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.CultureObject.TournamentTeamTemplatesForFourParticipant | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#ae636c489c77ae7e2b1ac4223324d266c)BasicMercenaryTroops
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.CultureObject.BasicMercenaryTroops | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a445cd39b36b83b36d58d93b56bd0b1f6)MilitiaBonus
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CultureObject.MilitiaBonus | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a6d88de1138aaeb5771d1ffee0157261d)ProsperityBonus
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CultureObject.ProsperityBonus | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#abd33fd32423929924c6f30bb5d7d3a4d)BoardGame
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BoardGameType](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a93a804fc17a3f89e1528215f9828e69a) TaleWorlds.CampaignSystem.CultureObject.BoardGame | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a8b320e1fdc157d2cbf036935bb09e0e5)NavalFactor
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CultureObject.NavalFactor | | get |


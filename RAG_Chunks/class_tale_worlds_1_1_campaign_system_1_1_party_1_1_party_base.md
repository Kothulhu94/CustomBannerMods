--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html ---

TaleWorlds.CampaignSystem.Party.PartyBase Class ReferencesealedBase party class.

Inherits [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html), [TaleWorlds.CampaignSystem.IRandomOwner](interface_tale_worlds_1_1_campaign_system_1_1_i_random_owner.html), and [TaleWorlds.CampaignSystem.Map.IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnVisibilityChanged](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a371b807f7ffc35518ff81d526265c76e) (bool value) |
| void | [OnConsumedFood](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ac38879175aff79dcfc8bf7af123c1155) () |
| void | [SetCustomOwner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a5a742a73a6a6ca822903dff32226cade) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) customOwner) |
| void | [SetLevelMaskIsDirty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a993a408f9a20935854e51346dce279a1) () |
| void | [OnLevelMaskUpdated](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a0f40827e789ce3dee6e325057aa5436d) () |
| void | [SetCustomName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ad7018bf8d4991b2cac1d559c1d109c3f) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name) |
| void | [SetCustomBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a47608b603feafb6710f4451bc3f8f7df) ([Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a1a3172c27fadc2ea06ad7e424e1e5b54) banner) |
| int | [GetNumberOfHealthyMenOfTier](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a894460049ada98c6f4baed1e22d16a07) (int tier) |
| float | [CalculateCurrentStrength](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#af9cd230b1e158e93d869d96e23fe61c8) () |
| float | [GetCustomStrength](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ab87ae92d8dc96377ef34d53fa26bbd6c) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, MapEvent.PowerCalculationContext context) |
|  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a6a569d649263abc3ad86317a9119db60) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a7616b1228135e5f9a5bb4ef4e34a5c01) mobileParty) |
|  | Be careful when using this directly, especially when creating dummy parties (consider using roster / [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html "MobileParty class stores data related with mobile parties.") instead) since this does not register itself to the Campaign.Parties and needs manual deletion if its somehow referenced. |
|  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a4cec172c32e1a9797ce6fdcb01bb4e5e) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a7da2e31fb1bbc3f520384babfd217cb7) settlement) |
| int | [GetShipsVersion](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a440ec7f8e189a2c09dd4f8b3203e99db) () |
| int | [GetNumberOfMenWith](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#afda2765ce7261f44bdde5795857cff0f) ([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait) |
| int | [AddPrisoner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a4b93d4bd5793d458111fc82d80500a7b) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) element, int numberToAdd) |
| int | [AddMember](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a58f27d27bfc4f0aff4a3bf16f131b1a8) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) element, int numberToAdd, int numberToAddWounded=0) |
| void | [AddPrisoners](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a543c3b88def76320b5681adf20e6b017) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) roster) |
| void | [AddMembers](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a8bfe38a08351b96acc873b914e9ea105) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) roster) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ae9f4a0f8fb8cf1ff737d2a6f6d93eb6c) () |
| int | [AddElementToMemberRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a4c7661e288468581405e1c08b8b26c9f) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) element, int numberToAdd, bool insertAtFront=false) |
| void | [AddToMemberRosterElementAtIndex](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#af69397cc7f3b8ff72200fef940becad7) (int index, int numberToAdd, int woundedCount=0) |
| void | [WoundMemberRosterElements](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ab2b0f2902a295c2f3f40b1f7e575d862) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) elementObj, int numberToWound) |
| void | [WoundMemberRosterElementsWithIndex](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a7544a014c745cb7a0f7a5d6bc8ec31dd) (int elementIndex, int numberToWound) |
| void | [UpdateVisibilityAndInspected](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a770d89006b25725ffaf6db4f3c1b0bd9) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) fromPosition, float mainPartySeeingRange=0) |
| void | [SetAsCameraFollowParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a4b98134a3c942d11670e544c30e1273d) () |
| void | [SetVisualAsDirty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a476e0186e4f134d442aaf88e2ea46737) () |
| void | [OnVisualsUpdated](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#aa6053f38628f1b86d62622f4aaba6d8c) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [IsPartyUnderPlayerCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a3cf45a8b8fa6bd9a2d4c022f548aa575) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a6a569d649263abc3ad86317a9119db60) party) |

|  |  |
| --- | --- |
| Properties | |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [Position](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a83bd84e17000ab1e904d808ec4a38ec5) `[get]` |
| bool | [IsVisible](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a1ef1ba71c7f4290b937950ae58901087) `[get]` |
| bool | [IsActive](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ac390a058e7a20482637d292273563893) `[get]` |
| SiegeEvent | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a5507e32b869cc4b9df02596362dc367a) `[get]` |
| Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a7da2e31fb1bbc3f520384babfd217cb7) `[get]` |
| MobileParty | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a7616b1228135e5f9a5bb4ef4e34a5c01) `[get]` |
| bool | [IsSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ad27fc5ab37886e01269d7026cfcda83d) `[get]` |
| bool | [IsMobile](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ad520fe884ab19a8fc1e2e949d33f902f) `[get]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [MemberRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#abe82193742d1f414d2c4bff94375a27a) `[get]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [PrisonRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a803e10e3898dcb590b5349b9021e13e1) `[get]` |
| ItemRoster | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#aad0c909f093ea9f0ca3fe3d8b80dd4c9) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a38b4d62b0da972be2ce5ae3b6094fc2f) `[get]` |
| float | [DaysStarving](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a5b75975d7d21a313309ea3b2b9d82179) `[get]` |
| int | [RemainingFoodPercentage](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#af815b0eb1ddb2870ef55008398fd45ed) `[get, set]` |
| bool | [IsStarving](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#aee4750137a956722eaf16fa9e003d415) `[get]` |
| string | [Id](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ae1830a20f12a57097931dc2dcffa82d5) `[get]` |
| float | [HealingRateForMemberRegulars](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ab69dc8e6828873153154dc786dee56bc) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [HealingRateForMemberRegularsExplained](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#aff871d1d9fb77ddc01364446892d4f66) `[get]` |
| float | [HealingRateForMemberHeroes](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#adfee5c8a0a7f2b8caf9d15eb2ef11519) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [HealingRateForMemberHeroesExplained](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a7c64212e36b2f1adb88819ba867b084f) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ac39a416cae7daf6be45f23c5e6747e7b) `[get]` |
|  | Owner of the party. Not necessarily a member of the party. |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [LeaderHero](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a34d4f6f32d3e8481f8b4fcfa8235c4b4) `[get]` |
| static [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a6a569d649263abc3ad86317a9119db60) | [MainParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a20532bae5b73a4ca1892139a68dbb41a) `[get]` |
| bool | [LevelMaskIsDirty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a3c1271ace6552e632db6944cd6bb2138) `[get]` |
| int | [Index](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a25ce94045cf74e6e520dfa0590f975c5) `[get]` |
| bool | [IsValid](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a6f7b2f28c96eeb650715e332b8897be9) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a723ac8c12ce64d1c16db5d2dd7889cda) `[get]` |
| int | [RandomValue](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ae6e2063931447fe9a90f5b05573f9de3) = [MBRandom.RandomInt](class_tale_worlds_1_1_core_1_1_m_b_random.html#a7d276a08934ed0203f18e814b5584619)(1, int.MaxValue) `[get]` |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | [Culture](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a0882ee2957cba623731901a7ec8fc992) `[get]` |
| Tuple< uint, uint > | [PrimaryColorPair](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#abcffdd8bf525524896d51f8f886b6edd) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [CustomName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a44f3bc722bd805f36ed769718b9c9bd2) `[get]` |
| [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a1a3172c27fadc2ea06ad7e424e1e5b54) | [CustomBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a329a3c545e5ca7b1a756c88e21e1b205) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a1a3172c27fadc2ea06ad7e424e1e5b54) `[get]` |
| MapEvent | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ab6c31116d4787fb4ab8f487b89fcdcd4) `[get]` |
| MapEventSide | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a0f5b74161ca85e3f82e560b8b27a75f8) `[get, set]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [Side](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#acf635298be9e8bb334ff3cbf515139d0) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [OpponentSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ad56fc1dc6c486d74a9d92ff299bb1d8e) `[get]` |
| int | [PartySizeLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a68afacd605975918030b1de7a6c47d27) `[get]` |
| int | [PrisonerSizeLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a889c1b91ab79e5439c2b631f946d1d9e) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [PartySizeLimitExplainer](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a244f109f1278004b2e9d55dfcc236ffd) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [PrisonerSizeLimitExplainer](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a009ee7087311ffc93e2b4dbf9e34cbcd) `[get]` |
| int | [NumberOfHealthyMembers](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a4bd56606e6bb3cdeb536b422ce87b1f4) `[get]` |
| int | [NumberOfRegularMembers](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#aa97c9b34cdcf90d625bff91d9fba1cc7) `[get]` |
| int | [NumberOfWoundedTotalMembers](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a94cb4f6a9e5dd259af530d1ab635dffb) `[get]` |
| int | [NumberOfAllMembers](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#af9d12596debc10fe3230e33bd1703b2e) `[get]` |
| int | [NumberOfPrisoners](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a1a32a4067a06e07cafbf21122c5a7e65) `[get]` |
| int | [NumberOfMounts](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a3c12d3fe415f0ad469675c7df052808f) `[get]` |
| int | [NumberOfPackAnimals](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a53cdb7e0c3bcea8522769bb2c719eb4f) `[get]` |
| IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [PrisonerHeroes](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a1362edd04fa3e5bbe7217bdc05d1db21) `[get]` |
| int | [NumberOfMenWithHorse](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a06c1db7fd7bbe2263d0a8daca9b3e14e) `[get]` |
| int | [NumberOfMenWithoutHorse](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#af8d62c246f2b6414db57d50f50eeedcf) `[get]` |
| float | [EstimatedStrength](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a2ceffc9bd70fb85312ad7a02f013e722) `[get]` |
| MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | [Ships](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a25437a0aa264bd9a6b2fa1ea3ef06fc5) `[get]` |
| [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | [FlagShip](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a5a7440fb219c276bc84be840e4e31ab5) `[get]` |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [BasicCulture](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a4a8c1065dc49b56419401d8dce61ee30) `[get]` |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [General](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a70c4a51af3251d6cf15976496056d775) `[get]` |
| bool | [IsVisualDirty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ab71d5a5145b9bedb9823dfef9e199c18) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a6a569d649263abc3ad86317a9119db60)PartyBase() [1/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Party.PartyBase.PartyBase | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a7616b1228135e5f9a5bb4ef4e34a5c01) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a4cec172c32e1a9797ce6fdcb01bb4e5e)PartyBase() [2/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Party.PartyBase.PartyBase | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a7da2e31fb1bbc3f520384babfd217cb7) | *settlement* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a371b807f7ffc35518ff81d526265c76e)OnVisibilityChanged()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.OnVisibilityChanged | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ac38879175aff79dcfc8bf7af123c1155)OnConsumedFood()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.OnConsumedFood | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a5a742a73a6a6ca822903dff32226cade)SetCustomOwner()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.SetCustomOwner | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *customOwner* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a3cf45a8b8fa6bd9a2d4c022f548aa575)IsPartyUnderPlayerCommand()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Party.PartyBase.IsPartyUnderPlayerCommand | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a6a569d649263abc3ad86317a9119db60) | *party* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a993a408f9a20935854e51346dce279a1)SetLevelMaskIsDirty()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.SetLevelMaskIsDirty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a0f40827e789ce3dee6e325057aa5436d)OnLevelMaskUpdated()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.OnLevelMaskUpdated | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ad7018bf8d4991b2cac1d559c1d109c3f)SetCustomName()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.SetCustomName | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a47608b603feafb6710f4451bc3f8f7df)SetCustomBanner()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.SetCustomBanner | ( | [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a1a3172c27fadc2ea06ad7e424e1e5b54) | *banner* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a894460049ada98c6f4baed1e22d16a07)GetNumberOfHealthyMenOfTier()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.PartyBase.GetNumberOfHealthyMenOfTier | ( | int | *tier* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#af9cd230b1e158e93d869d96e23fe61c8)CalculateCurrentStrength()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Party.PartyBase.CalculateCurrentStrength | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ab87ae92d8dc96377ef34d53fa26bbd6c)GetCustomStrength()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Party.PartyBase.GetCustomStrength | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | MapEvent.PowerCalculationContext | *context* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a440ec7f8e189a2c09dd4f8b3203e99db)GetShipsVersion()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.PartyBase.GetShipsVersion | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#afda2765ce7261f44bdde5795857cff0f)GetNumberOfMenWith()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.PartyBase.GetNumberOfMenWith | ( | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a4b93d4bd5793d458111fc82d80500a7b)AddPrisoner()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.PartyBase.AddPrisoner | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *element*, |
|  |  | int | *numberToAdd* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a58f27d27bfc4f0aff4a3bf16f131b1a8)AddMember()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.PartyBase.AddMember | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *element*, |
|  |  | int | *numberToAdd*, |
|  |  | int | *numberToAddWounded* = 0 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a543c3b88def76320b5681adf20e6b017)AddPrisoners()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.AddPrisoners | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *roster* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a8bfe38a08351b96acc873b914e9ea105)AddMembers()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.AddMembers | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *roster* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ae9f4a0f8fb8cf1ff737d2a6f6d93eb6c)ToString()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Party.PartyBase.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a4c7661e288468581405e1c08b8b26c9f)AddElementToMemberRoster()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.PartyBase.AddElementToMemberRoster | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *element*, |
|  |  | int | *numberToAdd*, |
|  |  | bool | *insertAtFront* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#af69397cc7f3b8ff72200fef940becad7)AddToMemberRosterElementAtIndex()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.AddToMemberRosterElementAtIndex | ( | int | *index*, |
|  |  | int | *numberToAdd*, |
|  |  | int | *woundedCount* = 0 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ab2b0f2902a295c2f3f40b1f7e575d862)WoundMemberRosterElements()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.WoundMemberRosterElements | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *elementObj*, |
|  |  | int | *numberToWound* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a7544a014c745cb7a0f7a5d6bc8ec31dd)WoundMemberRosterElementsWithIndex()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.WoundMemberRosterElementsWithIndex | ( | int | *elementIndex*, |
|  |  | int | *numberToWound* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a770d89006b25725ffaf6db4f3c1b0bd9)UpdateVisibilityAndInspected()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.UpdateVisibilityAndInspected | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *fromPosition*, |
|  |  | float | *mainPartySeeingRange* = 0 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a4b98134a3c942d11670e544c30e1273d)SetAsCameraFollowParty()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.SetAsCameraFollowParty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a476e0186e4f134d442aaf88e2ea46737)SetVisualAsDirty()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.SetVisualAsDirty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#aa6053f38628f1b86d62622f4aaba6d8c)OnVisualsUpdated()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyBase.OnVisualsUpdated | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a83bd84e17000ab1e904d808ec4a38ec5)Position
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Party.PartyBase.Position | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a1ef1ba71c7f4290b937950ae58901087)IsVisible
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyBase.IsVisible | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ac390a058e7a20482637d292273563893)IsActive
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyBase.IsActive | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a5507e32b869cc4b9df02596362dc367a)SiegeEvent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SiegeEvent TaleWorlds.CampaignSystem.Party.PartyBase.SiegeEvent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a7da2e31fb1bbc3f520384babfd217cb7)Settlement
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Settlement TaleWorlds.CampaignSystem.Party.PartyBase.Settlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a7616b1228135e5f9a5bb4ef4e34a5c01)MobileParty
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MobileParty TaleWorlds.CampaignSystem.Party.PartyBase.MobileParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ad27fc5ab37886e01269d7026cfcda83d)IsSettlement
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyBase.IsSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ad520fe884ab19a8fc1e2e949d33f902f)IsMobile
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyBase.IsMobile | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#abe82193742d1f414d2c4bff94375a27a)MemberRoster
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.PartyBase.MemberRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a803e10e3898dcb590b5349b9021e13e1)PrisonRoster
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.PartyBase.PrisonRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#aad0c909f093ea9f0ca3fe3d8b80dd4c9)ItemRoster
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ItemRoster TaleWorlds.CampaignSystem.Party.PartyBase.ItemRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a38b4d62b0da972be2ce5ae3b6094fc2f)Name
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyBase.Name | | get |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#a8c22f00b4cee26b345dc6232ad4f1522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a5b75975d7d21a313309ea3b2b9d82179)DaysStarving
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.PartyBase.DaysStarving | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#af815b0eb1ddb2870ef55008398fd45ed)RemainingFoodPercentage
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.RemainingFoodPercentage | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#aee4750137a956722eaf16fa9e003d415)IsStarving
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyBase.IsStarving | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ae1830a20f12a57097931dc2dcffa82d5)Id
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Party.PartyBase.Id | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ab69dc8e6828873153154dc786dee56bc)HealingRateForMemberRegulars
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.PartyBase.HealingRateForMemberRegulars | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#aff871d1d9fb77ddc01364446892d4f66)HealingRateForMemberRegularsExplained
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Party.PartyBase.HealingRateForMemberRegularsExplained | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#adfee5c8a0a7f2b8caf9d15eb2ef11519)HealingRateForMemberHeroes
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.PartyBase.HealingRateForMemberHeroes | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a7c64212e36b2f1adb88819ba867b084f)HealingRateForMemberHeroesExplained
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Party.PartyBase.HealingRateForMemberHeroesExplained | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ac39a416cae7daf6be45f23c5e6747e7b)Owner
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyBase.Owner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a34d4f6f32d3e8481f8b4fcfa8235c4b4)LeaderHero
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyBase.LeaderHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a20532bae5b73a4ca1892139a68dbb41a)MainParty
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a6a569d649263abc3ad86317a9119db60) TaleWorlds.CampaignSystem.Party.PartyBase.MainParty | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a3c1271ace6552e632db6944cd6bb2138)LevelMaskIsDirty
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyBase.LevelMaskIsDirty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a25ce94045cf74e6e520dfa0590f975c5)Index
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.Index | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a6f7b2f28c96eeb650715e332b8897be9)IsValid
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyBase.IsValid | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a723ac8c12ce64d1c16db5d2dd7889cda)MapFaction
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Party.PartyBase.MapFaction | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ae6e2063931447fe9a90f5b05573f9de3)RandomValue
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.RandomValue = [MBRandom.RandomInt](class_tale_worlds_1_1_core_1_1_m_b_random.html#a7d276a08934ed0203f18e814b5584619)(1, int.MaxValue) | | get |

Implements [TaleWorlds.CampaignSystem.IRandomOwner](interface_tale_worlds_1_1_campaign_system_1_1_i_random_owner.html#ad9f2a476dc29e7b3268949ab048d5ac7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a0882ee2957cba623731901a7ec8fc992)Culture
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) TaleWorlds.CampaignSystem.Party.PartyBase.Culture | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#abcffdd8bf525524896d51f8f886b6edd)PrimaryColorPair
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Tuple<uint, uint> TaleWorlds.CampaignSystem.Party.PartyBase.PrimaryColorPair | | get |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#a2cfbcfba83fd48bd8341f2ebcdfa333d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a44f3bc722bd805f36ed769718b9c9bd2)CustomName
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyBase.CustomName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a329a3c545e5ca7b1a756c88e21e1b205)CustomBanner
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a1a3172c27fadc2ea06ad7e424e1e5b54) TaleWorlds.CampaignSystem.Party.PartyBase.CustomBanner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a1a3172c27fadc2ea06ad7e424e1e5b54)Banner
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.CampaignSystem.Party.PartyBase.Banner | | get |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#ad9273cd85a1b3b5aa7ab8db3899ce061).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ab6c31116d4787fb4ab8f487b89fcdcd4)MapEvent
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapEvent TaleWorlds.CampaignSystem.Party.PartyBase.MapEvent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a0f5b74161ca85e3f82e560b8b27a75f8)MapEventSide
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapEventSide TaleWorlds.CampaignSystem.Party.PartyBase.MapEventSide | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#acf635298be9e8bb334ff3cbf515139d0)Side
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.Party.PartyBase.Side | | get |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#a5386c84e433d7a197715f790dcb32ceb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ad56fc1dc6c486d74a9d92ff299bb1d8e)OpponentSide
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.Party.PartyBase.OpponentSide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a68afacd605975918030b1de7a6c47d27)PartySizeLimit
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.PartySizeLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a889c1b91ab79e5439c2b631f946d1d9e)PrisonerSizeLimit
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.PrisonerSizeLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a244f109f1278004b2e9d55dfcc236ffd)PartySizeLimitExplainer
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Party.PartyBase.PartySizeLimitExplainer | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a009ee7087311ffc93e2b4dbf9e34cbcd)PrisonerSizeLimitExplainer
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Party.PartyBase.PrisonerSizeLimitExplainer | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a4bd56606e6bb3cdeb536b422ce87b1f4)NumberOfHealthyMembers
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.NumberOfHealthyMembers | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#aa97c9b34cdcf90d625bff91d9fba1cc7)NumberOfRegularMembers
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.NumberOfRegularMembers | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a94cb4f6a9e5dd259af530d1ab635dffb)NumberOfWoundedTotalMembers
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.NumberOfWoundedTotalMembers | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#af9d12596debc10fe3230e33bd1703b2e)NumberOfAllMembers
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.NumberOfAllMembers | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a1a32a4067a06e07cafbf21122c5a7e65)NumberOfPrisoners
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.NumberOfPrisoners | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a3c12d3fe415f0ad469675c7df052808f)NumberOfMounts
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.NumberOfMounts | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a53cdb7e0c3bcea8522769bb2c719eb4f)NumberOfPackAnimals
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.NumberOfPackAnimals | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a1362edd04fa3e5bbe7217bdc05d1db21)PrisonerHeroes
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.Party.PartyBase.PrisonerHeroes | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a06c1db7fd7bbe2263d0a8daca9b3e14e)NumberOfMenWithHorse
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.NumberOfMenWithHorse | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#af8d62c246f2b6414db57d50f50eeedcf)NumberOfMenWithoutHorse
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyBase.NumberOfMenWithoutHorse | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a2ceffc9bd70fb85312ad7a02f013e722)EstimatedStrength
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.PartyBase.EstimatedStrength | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a25437a0aa264bd9a6b2fa1ea3ef06fc5)Ships
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html)> TaleWorlds.CampaignSystem.Party.PartyBase.Ships | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a5a7440fb219c276bc84be840e4e31ab5)FlagShip
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) TaleWorlds.CampaignSystem.Party.PartyBase.FlagShip | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a4a8c1065dc49b56419401d8dce61ee30)BasicCulture
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.CampaignSystem.Party.PartyBase.BasicCulture | | get |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#a12557e16a93d68d470670af6410e30ea).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#a70c4a51af3251d6cf15976496056d775)General
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.CampaignSystem.Party.PartyBase.General | | get |

Implements [TaleWorlds.Core.IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html#adece67aa0876a4f2f3997a1a3a295b1e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html#ab71d5a5145b9bedb9823dfef9e199c18)IsVisualDirty
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyBase.IsVisualDirty | | get |


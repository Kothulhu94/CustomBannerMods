--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html ---

TaleWorlds.CampaignSystem.Party.MobileParty Class Referencesealed[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html "MobileParty class stores data related with mobile parties.") class stores data related with mobile parties.

Inherits [TaleWorlds.CampaignSystem.CampaignObjectBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_object_base.html), , [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html), and [TaleWorlds.CampaignSystem.ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [PartyObjective](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952) {     [Neutral](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952ae9bb5320b3890b6747c91b5a71ae5a01) ,     [Defensive](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952a3727b4d2311005c88de3b4a52f3de3a2) ,     [Aggressive](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952a389a96d0d9b3feb46b8c9d941566a4ae) ,     [NumberOfPartyObjectives](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952a7b2f005246fdf4128402a0f06d7fbfcc)   } |
| enum | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) {     [None](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848a6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [Default](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848a7a1920d61156abc05a60135aefe8bc67) = 1 ,     [Naval](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848a0115c3bbcaa109ba6695e5395cb72ac2) = 2 ,     [All](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848ab1c94ca2fbc3e78fc30069c8d0f01680) = Default | Naval   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetLandNavigationAccess](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a201fe07cc8c5e46d7bca42646743a249) (bool access) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abda32d050e65b911fe935fd96376a4ea) () |
| bool | [HasLimitedWage](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a44e9994886cb25357c88ebb72bad33b2) () |
| int | [GetAvailableWageBudget](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7855e5366382ffb92e2a1785ae8accbf) () |
| bool | [IsWageLimitExceeded](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a328b97456460168cbb53987abfb19543) () |
| void | [SetWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac0238db3ecc4f47219bd2bb149c4cb2a) (int newLimit) |
| void | [SetNavalVisualAsDirty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#adc094a34face0d56a626c6b5ce69aab2) () |
| void | [OnNavalVisualsUpdated](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af7cb62d4f320984c6025a0474e9a46bd) () |
| void | [SetSailAtPosition](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a03c6207fb298a6c93b5a3285494e015c) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| void | [CancelNavigationTransition](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a62ee4c5376c0e36e11a4befcb76416f3) () |
| void | [ChangeIsCurrentlyAtSeaCheat](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#afe75f2cbb8c511eba385aecc55717fbb) () |
| void | [SetCustomHomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a09fdb790abfd09d9f7b1c1953a3af15e) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) customHomeSettlement) |
| void | [SetTargetSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6d9ab74923952babec024ef3b007c513) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool isTargetingPort) |
|  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) () |
|  | Initializes a new instance of the [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html "MobileParty class stores data related with mobile parties.") class. Use CreateParty to create party, do not call new [MobileParty()](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1 "Initializes a new instance of the MobileParty class. Use CreateParty to create party,..."). |
| void | [SetPartyScout](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6b422c634d3c774fb6449c32effddf1f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [SetPartyQuartermaster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a720459fded61e6cb55fa90eaf0c6e28d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [SetPartyEngineer](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a84ebbd8fb4039561e3913f9ee6609089) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [SetPartySurgeon](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aea022cd0812a756f8b06c24e5c04179e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acda784a2bd05d2de53536bfc89d17d5c) () |
| void | [ChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a965b32d9c84c77abab3e0369fd10e835) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |
| void | [OnPartyInteraction](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0bf99e26174be2d80da9384f14f685fe) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) engagingParty) |
| void | [SetPositionAfterMapChange](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a15d7bc909df9202b08a6a488bbf66252) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) newPosition) |
| void | [RemovePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a94f9e5895da3d8f0cb45fc124a47eb1a) () |
| void | [CheckPositionsForMapChangeAndUpdateIfNeeded](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aad8e7732dc4d694a09a6e9614151c765) () |
| void | [CheckAiForMapChangeAndUpdateIfNeeded](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac4a48c4371a08b2bce9a9f856adbe7a8) () |
| void | [MovePartyToTheClosestLand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0e64659135ff40ca289550885316b566) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetBehaviorText](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9b0d00a8e0f2db872866b16357a29569) () |
| override void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab949f7f99c06eb6db69617836981a450) () |
| void | [InitializeMobilePartyAtPosition](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#afb5b3308c514a7f8ca5e4758de7eb3ce) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| void | [InitializeMobilePartyAtPosition](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a733d5158398f45eed30ba75a3f7b8c15) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) memberRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) prisonerRoster, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, bool isNaval=false) |
| void | [InitializeMobilePartyAroundPosition](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab910630552c3db6bacfe988bd1ea2cfa) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) memberRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) prisonerRoster, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, float spawnRadius, float minSpawnRadius=0, bool isNaval=false) |
| void | [InitializeMobilePartyAtPosition](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a11a91703e63d2fc799b9e797426987d7) ([PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) pt, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| void | [InitializeMobilePartyAroundPosition](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a5c8d77bc9c1fe25ebefaec4b15712972) ([PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) pt, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, float spawnRadius, float minSpawnRadius=0) |
| void | [SetDisorganized](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#afe5d609a0c3cf390321f596c6496e12a) (bool isDisorganized) |
| void | [RecalculateShortTermBehavior](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a38c0299bb59316c5f4dc2fd47db41d01) () |
| bool | [IsFleeing](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a49102e75371d41ee48d1235847b2505d) () |
| void | [SetPartyUsedByQuest](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a3c255a5f6eb234fd62f0f34fdfeea3d3) (bool isActivelyUsed) |
| void | [IgnoreForHours](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a313e94d1a07b4b997ebacd0de4b32e1f) (float hours) |
| void | [IgnoreByOtherPartiesTill](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a01006540d1973bd61328bf3999724988) ([CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) time) |
| void | [SetAnchor](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a1aa59b1ffc41aa5e361d474776c165ab) ([AnchorPoint](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html) anchor) |
| void | [SetPartyObjective](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a83e6a53780a0c8c7457038113fc00f93) ([PartyObjective](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952) objective) |
| void | [UpdateVersionNo](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7e5553f3f7868666a78d7311b30f5349) () |
| bool | [IsSpotted](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab12754a2434bc5a56e2ede31efd29906) () |
| int | [AddElementToMemberRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#afeca7b172354d9ca7f13ac5339b317fe) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) element, int numberToAdd, bool insertAtFront=false) |
| int | [AddPrisoner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae89da3f38031c4eb3a71dc55cb82579a) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) element, int numberToAdd) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetPositionAsVec3](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a31ba82b670225e785eb9ff39aaa5f5a1) () |
| float | [GetTotalLandStrengthWithFollowers](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a8d29844a260ec3583b6cab18af80b2bb) (bool includeNonAttachedArmyMembers=true) |
| bool | [HasPerk](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7e3d1da9204fed426591da074a53286f) ([PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk, bool checkSecondaryRole=false) |
| void | [SetHeroPartyRole](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a8c5410c0326f4f715b0ac631b664ae87) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) partyRole) |
| [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) | [GetHeroPartyRole](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aee2f3ac00ba172660f281856f6fa7c56) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [RemoveHeroPartyRole](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a8c284b93c55f9548dfbdaa19a34acf0f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetRoleHolder](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a40a962fdcab844ecf10cd44517ac9fc0) ([PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) partyRole) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetEffectiveRoleHolder](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a8100dd7a468bddd55429eeab28bf6710) ([PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) partyRole) |
| int | [GetNumDaysForFoodToLast](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a47477649cf22a7a51896fe0fa91537f0) () |
| bool | [RecalculateLongTermPath](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9d43d9c014326f493cf05e1502a74d54) () |
| int | [GetRegionSwitchCostFromLandToSea](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af0aafce9a727729d447ea07eb3d6fbde) () |
| int | [GetRegionSwitchCostFromSeaToLand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aec30ffecd2c8181976a3059806fceb56) () |
| void | [SetMoveModeHold](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#affff6128f8dce6348f65f7a2d29cad1c) () |
| void | [SetMoveEngageParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6f7f86ddf27dc030ca0f9033c51f1af3) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) party, [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType) |
| void | [SetMoveGoAroundParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2429d6f69159c333e28ddaef8107d18a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) party, [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType) |
| void | [SetMoveGoToSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac1652730ebf1cd361702ea22da25bc72) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType, bool isTargetingThePort) |
| void | [SetMoveGoToPoint](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a51227a6df2d6c38080f48e0dd8c07b25) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) point, [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType) |
| void | [SetMoveToNearestLand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a031971041d319e7d4e1e2dba996cfbd6) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [SetMoveGoToInteractablePoint](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aeef6a2627c91815e70b6beebe28d1d0e) ([IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) point, [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType) |
| void | [SetMoveEscortParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0bb5fc7b3a97463d12d320131bc65541) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) mobileParty, [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType, bool isTargetingPort) |
| void | [SetMovePatrolAroundPoint](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa2729dabc7d5444cdd5b80a387237277) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) point, [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType) |
| void | [SetMovePatrolAroundSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a84651d68d8fc1228316ade0d72cf1696) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType, bool isTargetingPort) |
| void | [SetMoveRaidSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac615c4c81fbe78b05d22dff431531b7e) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType) |
| void | [SetMoveBesiegeSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a5d2eefa2867863cf6edfd6d05a05660f) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType) |
| void | [SetMoveDefendSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a1aa80abe81565918d4b78455d1f78800) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool isTargetingPort, [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType) |
| bool | [ComputeIsWaiting](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a936dc06ed67509dfe91e56c0acc316c2) () |
| void | [InitializePartyTrade](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad2b286880e7ca528f558168e888eb10a) (int initialGold) |
| void | [AddTaxGold](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd18bf1007de2f6dd5338678663ce378) (int amount) |
| void | [SetPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a440b7f6de2f61f3b08f89ed067124df7) ([PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa1bc1bdc86575058b3b29ee35a31ad42) partyComponent, bool firstTimePartyComponentCreation=true) |
| void | [UpdatePartyComponentFlags](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a85c2b6fb074412796488e9d8b5cd97df) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Deserialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [IsFleeBehavior](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a67d79e2ab1d0229bd41f1cd79a93afa2) ([AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) aiBehavior) |
| static LocatableSearchData< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | [StartFindingLocatablesAroundPosition](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa943a0e320bc06878884116a279af4f9) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, float radius) |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | [FindNextLocatable](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6278b9a4e5cada1d7b1ebe5e5a895cd8) (ref LocatableSearchData< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > data) |
| static void | [UpdateLocator](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a4ac82b6018d4dece88fc3418edec45e2) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) party) |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | [CreateParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aaf2082f5b4f9a245753c40bc607267bc) (string stringId, [PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa1bc1bdc86575058b3b29ee35a31ad42) component) |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [HasUnpaidWages](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a05fe503b702e9f410b99defdff09bbec) |
| bool | [IsInfoHidden](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a3b153740e373c945aef50952b77f0024) = false |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [NextLongTermPathPoint](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a549ddb93cc29c471c3f7c5d861a3695a) = [CampaignVec2.Invalid](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html#a4253bceee41a103119a8bbc379b4ba32) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [AverageFleeTargetDirection](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a808f341074b045bef69cb67cc539f4e3) |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [NextTargetPosition](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a83799c042627d360cc8abfab75897d55) |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [MoveTargetPoint](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f77912a7ffc2843e80eee8e120607ff) |
| [MoveModeType](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#ac1fc9f5da68587132812b914717cc038) | [PartyMoveMode](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0da4ea667ef0ddbc5efa234fd6740f8d) |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | [MoveTargetParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9013359121ed20492ef620dd6e0a4d71) |
| bool | [StartTransitionNextFrameToExitFromPort](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aae7b5fa25922d712d7f1fd546fbd109f) |
| [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) | [Path](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a44b07cc06b721d47633b73c9ca188546) |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | [PathLastFace](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a626818db3f6aaf9f9473cb54d73973a1) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [DefaultPartyTradeInitialGold](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac5e4631835aa717ecca5f553dbaa1e7e) = 5000 |
| const int | [ClanRoleAssignmentMinimumSkillValue](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6f362c015e966e8ecd7698574f347862) = 0 |
| const int | [MinimumSpareGoldForWageBudget](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aaa6f6b165da374bb87b233cc5aca34ab) = 5 |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [PreAfterLoad](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae5cb25f2b28ddc117828da7d5feef69c) () |
| override void | [OnBeforeLoad](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a38222d04e100f83703b9a506ce05208b) () |
| override void | [AfterLoad](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad6a8f5550b00ed4b253132f48e727ab8) () |

|  |  |
| --- | --- |
| Properties | |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | [MainParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af2ca971ed7b3c2239254e5f881be7760) `[get]` |
| static MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | [All](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abdeadd11309b79f7267ac3fadfd99f59) `[get]` |
| static MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | [AllCaravanParties](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a3fa4cd4744b69206a10723c723ae890a) `[get]` |
| static MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | [AllPatrolParties](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a1ccf174008dcc7f9d10fd8d42890c9d5) `[get]` |
| static MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | [AllBanditParties](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a622badb34c0888655f2f83b85af3391c) `[get]` |
| static MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | [AllLordParties](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a3ee7670fed47ee6bb482d7a675a4d283) `[get]` |
| static MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | [AllGarrisonParties](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a83d014ec6c36725fe650cf8e9ff4289d) `[get]` |
| static MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | [AllMilitiaParties](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acb1b225c11b0699a8e5a0101024ad4d4) `[get]` |
| static MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | [AllVillagerParties](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af49c5139c21ee2ebb56ea248d1de8916) `[get]` |
| static MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | [AllCustomParties](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9c3eadc68c995884a57154c4ed3769ea) `[get]` |
| static MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | [AllPartiesWithoutPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af974d05e67086fb35e04cd269517473b) `[get]` |
| static int | [Count](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac5ee905d552ad612684df1a56fb1e78c) `[get]` |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | [ConversationParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9a467d6bf6726c5ff052ca15b37819ba) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aac1d15fc82dc1ae9c68f228fe55d504d) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [LastVisitedSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abc1767bc6fe57443a6aa2bae60249b8e) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Bearing](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac94dffe302e1dcf83b5f22cf46263511) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | [AttachedParties](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af8cf2115b327a2847f70a021cb254eb3) `[get]` |
| bool | [HasLandNavigationCapability](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a44e798af7b9b125c1da29f46a650babb) = true `[get]` |
| MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | [Ships](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aaa1409a25bf297ac50eacb03706e61e3) `[get]` |
| bool | [HasNavalNavigationCapability](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0386c1b4bd69323be87102e84ef576bf) `[get]` |
| float | [Aggressiveness](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a8f07ef03a9c7c4053f22baec4c6ba52a) `[get, set]` |
| int | [PaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae63e21292adbfc62cf86c1794d7246b1) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae0f1ab85ea5c21fa0167577529e1bb11) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [ArmyPositionAdder](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa63f926dae5d95c65dfc626e7396ab8e) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [AiBehaviorTarget](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a225046884258694468f3c099ea70105c) `[get]` |
| [PartyObjective](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952) | [Objective](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a44cf1187b0a7006d9f60525fdffde21e) = [PartyObjective.Neutral](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952ae9bb5320b3890b6747c91b5a71ae5a01) `[get]` |
| [MobilePartyAi](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html) | [Ai](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acc6354bfb923f9637856ca5ef686db24) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [Party](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac8b65406435b34e07fc9257a343ed825) `[get]` |
| bool | [IsActive](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae9e22f46bd3278277f9e477deb2a9b1f) `[get, set]` |
| bool | [IsInRaftState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9f04b17c4006e18d721db5f45cc78458) `[get, set]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [DisorganizedUntilTime](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac2c1b165d04cf598c8de0b7c2bbd1c97) `[get]` |
| float | [LastCalculatedBaseSpeed](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd6c60d4024f1a8b51bffbd449adab5f) `[get]` |
| [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html) | [ThinkParamsCache](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a049075415acb30d7e89d3fa77cc233f3) `[get]` |
| float | [Speed](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7b97ce9df9cad98c4a87efd565b3efd7) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [SpeedExplained](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad632e171d34783ecd220b851c0991bd1) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | [ShortTermTargetParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac42b51640cb6b3a20cd3d2cf11ff6e60) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [ShortTermTargetSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abebcac8819bf75f7a728231f94793401) `[get]` |
| bool | [IsDisorganized](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a487ee253e13e3b1871fcc08a2bf74c57) `[get]` |
| bool | [IsCurrentlyUsedByAQuest](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#adc829ce5cc361302267cae3795c1a589) `[get]` |
| [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) | [ShortTermBehavior](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac5a94cbde901208b86e111b50962e12d) `[get]` |
| bool | [IsPartyTradeActive](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7064e56f463a8b96b1c283ff9be475e6) = false `[get]` |
| int | [PartyTradeGold](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad034080f1c8344bbb010dde9d3091226) `[get, set]` |
| int | [PartyTradeTaxGold](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2b8df1435fde84c68b348c66b6442985) = 0 `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [StationaryStartTime](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a52a4704ee146908cd375d35e310f26d2) `[get]` |
| int | [VersionNo](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6dc13ac0e6496a6d79af3e370c9e3d70) `[get]` |
| bool | [ShouldJoinPlayerBattles](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a434166fbd62f7aa2051b507ec78ef943) `[get, set]` |
| bool | [IsDisbanding](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a86bb10c05ee1083438f26e44767f1689) `[get, set]` |
| int | [RandomValue](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a3a1d9282c8f70bf48f9eeade142189fc) `[get]` |
| [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | [NavigationCapability](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a12f9d148d9da90118ce8583102014667) `[get]` |
| bool | [IsCurrentlyAtSea](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae2e993f8986ba0978fda916eed446103) `[get, set]` |
| bool | [IsNavalVisualDirty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa2dd0494d8018bd004641c86f2e9ac98) `[get]` |
| bool | [IsTargetingPort](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ada9c4cbcada684875d28b7f905f8d3e6) `[get]` |
| [AnchorPoint](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html) | [Anchor](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa053eff2564f46d43e87e943aeef6906) `[get]` |
| bool | [IsTransitionInProgress](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0c85f3639a2b4f1b07e4d0a12d8a07d9) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [EndPositionForNavigationTransition](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abe3c5a33b94bf740bc59e9767555f083) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [NavigationTransitionStartTime](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#addb47374de3e50d84909e03faee3a836) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [NavigationTransitionDuration](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aaea307964b4c7700116b420bdf4be082) = [CampaignTime.Zero](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a4a9e01e38a255d6f60447d96049a68a5) `[get]` |
| [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | [DesiredAiNavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a86d17246721151ad09dee8fe3c462906) `[get, set]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [CurrentSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a4c4acb32f860971d8dba9c72b6acaeee) `[get, set]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [HomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad250c32fd3f29aa096356184aaa6b594) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | [AttachedTo](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2fec3ec42db830e9d9a0511726f87762) `[get, set]` |
| Army | [Army](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac7a2832a38f3a6ab50eac5d7b1a5310c) `[get, set]` |
| BesiegerCamp | [BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aac6f13048f4ed4045bd0b7e68a09ba8b) `[get, set]` |
| [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) | [DefaultBehavior](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae30ae450429ec4e5bf14d39eba6ebf6e) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [TargetSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a254c9498c4e48f71c659482a299f2e5e) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [TargetPosition](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a99e89235367142f37c240953398e996c) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | [TargetParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a4f2bc3fe2e4eaa14829ba3167b1b1247) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [LeaderHero](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af1327199d4498aba931e3d6bb73e36ee) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a932f1f1f75cb2b6996a0c09664f23efc) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [EffectiveScout](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a90679b4e92d45128e6a6292ca42480f8) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [EffectiveQuartermaster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a694e213d68b27aa2f01dcde57c0538de) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [EffectiveEngineer](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0f4010796b83445954cf74a8d7ccc54c) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [EffectiveSurgeon](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9bfd6fde0b1fcaa4f79bbb6fd8d7630d) `[get]` |
| float | [RecentEventsMorale](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abe7d353ed6e0d6565ec9de84aa7908e3) `[get, set]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [SeeingRangeExplanation](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a93a4de02b89c3a182ecc4c05aa92504c) `[get]` |
| int | [InventoryCapacity](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a53c03be90a361c925e17dad6f8d53d4f) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [InventoryCapacityExplainedNumber](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa6e167c23e6c1af52704a5732b6578a6) `[get]` |
| float | [TotalWeightCarried](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a271000ed44eb8869f515599473db58c2) `[get]` |
| MapEventSide | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9d67c7930bc88b85ca69b04d88f4eff0) `[get, set]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [TotalWeightCarriedExplainedNumber](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a38dfebb6b66d36a906bf46363e591e4c) `[get]` |
| float | [Morale](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acfb6248368b15f500a464aa17fc8b2be) `[get]` |
| float | [FoodChange](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9ae7df3eab57154d1effa9a4dd04f197) `[get]` |
| float | [BaseFoodChange](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a84808dbf1659be2743692ec4ffe0636e) `[get]` |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [ActualClan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#adfd80d645f63cbf56e5f990ddbd7ddd3) `[get, set]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [FoodChangeExplained](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab866421a3e813c731e9e04dce7492b66) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [MoraleExplained](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac744afb8f9489bff40dd4f3bb3a6d4c2) `[get]` |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | [CurrentNavigationFace](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6de4c68214e697ef5d6d0e12dd7516b2) `[get]` |
| int | [PathBegin](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a605f06bfcc2fe284f27103bd029daa78) `[get]` |
| bool | [ForceAiNoPathMode](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7ffdd726f26750ea68d47b48d7200f88) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [EventPositionAdder](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a1a16103aa4fce790bdc5817d42a1c1da) `[get, set]` |
| bool | [IsVisible](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a01d920f01a3fbb6d914e9837fb033c4b) `[get, set]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [Position](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2b734fcbd8a03fceed0cec8eeef27450) `[get, set]` |
| bool | [IsInspected](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aea963275aee38aff6ae562e13f7ff193) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetPosition2D](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab49ae40acfa58f5596f0429eb9812d3e) `[get]` |
| int | [TotalWage](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae0eaf49bcac0e7a1afdd98f354eabfb2) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [TotalWageExplained](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7618a197cbdf6177cdf3996c29ac53a3) `[get]` |
| MapEvent | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a522f396261d4df06d5036c818c36f257) `[get]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [MemberRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a16c80e8034db90ef9c5866b454f0e8e2) `[get]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [PrisonRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a794732930e4d2ffa235b5de13d670f2f) `[get]` |
| ItemRoster | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a80fd99c34fa9eea7486b56e0d02131d1) `[get]` |
| bool | [IsMainParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a5a7aaf663108c4b0d1817f0d6d384a95) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9980ede3f4bfe0b42faab2e1a1768a9e) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [ArmyName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac04a5fb2a7094481bf78827f2a40d4ac) `[get]` |
| SiegeEvent | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9411e609b4946d0a0e3d33e1673719e6) `[get]` |
| float | [Food](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a08740d5318cdc181297d5f2678fff991) `[get]` |
| int | [TotalFoodAtInventory](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abe21c1af1e316879bbfdd8668ad1ff94) `[get]` |
| float | [SeeingRange](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a98d045473130b99202cfc5404e319cc2) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [BesiegedSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#adec28d6f503a300ba93035162d9b47cc) `[get]` |
| bool | [IsEngaging](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a37f8a88e3a3cc10d0d950af585a26412) `[get]` |
| float | [PartySizeRatio](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#adb6229575ecbf349405abc3a91e08452) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [VisualPosition2DWithoutError](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7f09b23e5c0b00d551606a7f39402724) `[get]` |
| bool | [IsMoving](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9f8345bfb5f1a7e846c789ba75627ff6) `[get]` |
| bool | [ShouldBeIgnored](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a60320bef5c497e8f525996fa1fae7ad9) `[get]` |
| VillagerPartyComponent | [VillagerPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad791544f97f2611b26ad56abe3a8f645) `[get]` |
| CaravanPartyComponent | [CaravanPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a5e237da4320289d59d0424516b25f950) `[get]` |
| WarPartyComponent | [WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac7d68249b4309a5932ed07a7beac3e7a) `[get]` |
| BanditPartyComponent | [BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad999a037a5af28ba6540cd5903363e75) `[get]` |
| PatrolPartyComponent | [PatrolPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ada79a173c6e5f94519d13c1d21e8628e) `[get]` |
| LordPartyComponent | [LordPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aadb502acbc2c6e9f52f828ce75082a27) `[get]` |
| GarrisonPartyComponent | [GarrisonPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac5d7a6ce789ab24f1f61aa72802f2530) `[get]` |
| PartyComponent | [PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa1bc1bdc86575058b3b29ee35a31ad42) `[get]` |
| bool | [IsMilitia](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7555439a84b503e71b21d71184a11811) `[get]` |
| bool | [IsLordParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a4cbb065ce03831c6cf16e1a6d9482f37) `[get]` |
| bool | [IsVillager](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a60b4f5ded7f3236fcf717b0cc660cc27) `[get]` |
| bool | [IsCaravan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a25382b046ac94652a361417efbc38d57) `[get]` |
| bool | [IsPatrolParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af39d349ce4b3bb469e1c183a22f849a3) `[get]` |
| bool | [IsGarrison](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a3f926dcd012b562d4a8882d1d4b5358f) `[get]` |
| bool | [IsCustomParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a48d68f36f983bcfe05ffceb4aea08f9d) `[get]` |
| bool | [IsBandit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a031d7bd919cab660c0f61276cdcbb9ea) `[get]` |
| bool | [IsBanditBossParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae8e0d8a52f4644c31c0a030e4bfdda22) `[get]` |
| bool | [AvoidHostileActions](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac8c53989471bc89afc35f2c3d908ebad) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) | |
| bool | [IsReady](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html#a69166dbcedc127fea26c01d2428d01d7) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952)PartyObjective
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Party.MobileParty.PartyObjective](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952) |

| Enumerator | |
| --- | --- |
| Neutral |  |
| Defensive |  |
| Aggressive |  |
| NumberOfPartyObjectives |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848)NavigationType
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Party.MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) |

| Enumerator | |
| --- | --- |
| None |  |
| Default |  |
| Naval |  |
| All |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1)MobileParty()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Party.MobileParty.MobileParty | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a201fe07cc8c5e46d7bca42646743a249)SetLandNavigationAccess()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetLandNavigationAccess | ( | bool | *access* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abda32d050e65b911fe935fd96376a4ea)GetName()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.MobileParty.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a44e9994886cb25357c88ebb72bad33b2)HasLimitedWage()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.MobileParty.HasLimitedWage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7855e5366382ffb92e2a1785ae8accbf)GetAvailableWageBudget()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.MobileParty.GetAvailableWageBudget | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a328b97456460168cbb53987abfb19543)IsWageLimitExceeded()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.MobileParty.IsWageLimitExceeded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac0238db3ecc4f47219bd2bb149c4cb2a)SetWagePaymentLimit()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetWagePaymentLimit | ( | int | *newLimit* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#adc094a34face0d56a626c6b5ce69aab2)SetNavalVisualAsDirty()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetNavalVisualAsDirty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af7cb62d4f320984c6025a0474e9a46bd)OnNavalVisualsUpdated()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.OnNavalVisualsUpdated | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a03c6207fb298a6c93b5a3285494e015c)SetSailAtPosition()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetSailAtPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a62ee4c5376c0e36e11a4befcb76416f3)CancelNavigationTransition()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.CancelNavigationTransition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#afe75f2cbb8c511eba385aecc55717fbb)ChangeIsCurrentlyAtSeaCheat()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.ChangeIsCurrentlyAtSeaCheat | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a09fdb790abfd09d9f7b1c1953a3af15e)SetCustomHomeSettlement()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetCustomHomeSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *customHomeSettlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6d9ab74923952babec024ef3b007c513)SetTargetSettlement()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetTargetSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *isTargetingPort* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6b422c634d3c774fb6449c32effddf1f)SetPartyScout()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetPartyScout | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a720459fded61e6cb55fa90eaf0c6e28d)SetPartyQuartermaster()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetPartyQuartermaster | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a84ebbd8fb4039561e3913f9ee6609089)SetPartyEngineer()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetPartyEngineer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aea022cd0812a756f8b06c24e5c04179e)SetPartySurgeon()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetPartySurgeon | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acda784a2bd05d2de53536bfc89d17d5c)ToString()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Party.MobileParty.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a965b32d9c84c77abab3e0369fd10e835)ChangePartyLeader()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.ChangePartyLeader | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newLeader* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0bf99e26174be2d80da9384f14f685fe)OnPartyInteraction()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.OnPartyInteraction | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | *engagingParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a15d7bc909df9202b08a6a488bbf66252)SetPositionAfterMapChange()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetPositionAfterMapChange | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *newPosition* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a94f9e5895da3d8f0cb45fc124a47eb1a)RemovePartyLeader()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.RemovePartyLeader | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aad8e7732dc4d694a09a6e9614151c765)CheckPositionsForMapChangeAndUpdateIfNeeded()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.CheckPositionsForMapChangeAndUpdateIfNeeded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac4a48c4371a08b2bce9a9f856adbe7a8)CheckAiForMapChangeAndUpdateIfNeeded()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.CheckAiForMapChangeAndUpdateIfNeeded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae5cb25f2b28ddc117828da7d5feef69c)PreAfterLoad()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.MobileParty.PreAfterLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a38222d04e100f83703b9a506ce05208b)OnBeforeLoad()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.MobileParty.OnBeforeLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad6a8f5550b00ed4b253132f48e727ab8)AfterLoad()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.MobileParty.AfterLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0e64659135ff40ca289550885316b566)MovePartyToTheClosestLand()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.MovePartyToTheClosestLand | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9b0d00a8e0f2db872866b16357a29569)GetBehaviorText()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.MobileParty.GetBehaviorText | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab949f7f99c06eb6db69617836981a450)Initialize()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.MobileParty.Initialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#afb5b3308c514a7f8ca5e4758de7eb3ce)InitializeMobilePartyAtPosition() [1/3]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.InitializeMobilePartyAtPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a733d5158398f45eed30ba75a3f7b8c15)InitializeMobilePartyAtPosition() [2/3]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.InitializeMobilePartyAtPosition | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *memberRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *prisonerRoster*, |
|  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, |
|  |  | bool | *isNaval* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab910630552c3db6bacfe988bd1ea2cfa)InitializeMobilePartyAroundPosition() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.InitializeMobilePartyAroundPosition | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *memberRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *prisonerRoster*, |
|  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, |
|  |  | float | *spawnRadius*, |
|  |  | float | *minSpawnRadius* = 0, |
|  |  | bool | *isNaval* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a11a91703e63d2fc799b9e797426987d7)InitializeMobilePartyAtPosition() [3/3]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.InitializeMobilePartyAtPosition | ( | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *pt*, |
|  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a5c8d77bc9c1fe25ebefaec4b15712972)InitializeMobilePartyAroundPosition() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.InitializeMobilePartyAroundPosition | ( | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *pt*, |
|  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, |
|  |  | float | *spawnRadius*, |
|  |  | float | *minSpawnRadius* = 0 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#afe5d609a0c3cf390321f596c6496e12a)SetDisorganized()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetDisorganized | ( | bool | *isDisorganized* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a38c0299bb59316c5f4dc2fd47db41d01)RecalculateShortTermBehavior()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.RecalculateShortTermBehavior | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a67d79e2ab1d0229bd41f1cd79a93afa2)IsFleeBehavior()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsFleeBehavior | ( | [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) | *aiBehavior* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a49102e75371d41ee48d1235847b2505d)IsFleeing()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.MobileParty.IsFleeing | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a3c255a5f6eb234fd62f0f34fdfeea3d3)SetPartyUsedByQuest()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetPartyUsedByQuest | ( | bool | *isActivelyUsed* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a313e94d1a07b4b997ebacd0de4b32e1f)IgnoreForHours()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.IgnoreForHours | ( | float | *hours* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a01006540d1973bd61328bf3999724988)IgnoreByOtherPartiesTill()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.IgnoreByOtherPartiesTill | ( | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *time* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a1aa59b1ffc41aa5e361d474776c165ab)SetAnchor()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetAnchor | ( | [AnchorPoint](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html) | *anchor* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a83e6a53780a0c8c7457038113fc00f93)SetPartyObjective()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetPartyObjective | ( | [PartyObjective](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952) | *objective* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7e5553f3f7868666a78d7311b30f5349)UpdateVersionNo()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.UpdateVersionNo | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab12754a2434bc5a56e2ede31efd29906)IsSpotted()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.MobileParty.IsSpotted | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#afeca7b172354d9ca7f13ac5339b317fe)AddElementToMemberRoster()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.MobileParty.AddElementToMemberRoster | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *element*, |
|  |  | int | *numberToAdd*, |
|  |  | bool | *insertAtFront* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae89da3f38031c4eb3a71dc55cb82579a)AddPrisoner()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.MobileParty.AddPrisoner | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *element*, |
|  |  | int | *numberToAdd* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a31ba82b670225e785eb9ff39aaa5f5a1)GetPositionAsVec3()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.CampaignSystem.Party.MobileParty.GetPositionAsVec3 | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#ae172008491c85da53167da47d59ee6d2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a8d29844a260ec3583b6cab18af80b2bb)GetTotalLandStrengthWithFollowers()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Party.MobileParty.GetTotalLandStrengthWithFollowers | ( | bool | *includeNonAttachedArmyMembers* = true | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7e3d1da9204fed426591da074a53286f)HasPerk()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.MobileParty.HasPerk | ( | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk*, |
|  |  | bool | *checkSecondaryRole* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a8c5410c0326f4f715b0ac631b664ae87)SetHeroPartyRole()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetHeroPartyRole | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) | *partyRole* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aee2f3ac00ba172660f281856f6fa7c56)GetHeroPartyRole()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) TaleWorlds.CampaignSystem.Party.MobileParty.GetHeroPartyRole | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a8c284b93c55f9548dfbdaa19a34acf0f)RemoveHeroPartyRole()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.RemoveHeroPartyRole | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a40a962fdcab844ecf10cd44517ac9fc0)GetRoleHolder()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.MobileParty.GetRoleHolder | ( | [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) | *partyRole* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a8100dd7a468bddd55429eeab28bf6710)GetEffectiveRoleHolder()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.MobileParty.GetEffectiveRoleHolder | ( | [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) | *partyRole* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a47477649cf22a7a51896fe0fa91537f0)GetNumDaysForFoodToLast()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.MobileParty.GetNumDaysForFoodToLast | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9d43d9c014326f493cf05e1502a74d54)RecalculateLongTermPath()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.MobileParty.RecalculateLongTermPath | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af0aafce9a727729d447ea07eb3d6fbde)GetRegionSwitchCostFromLandToSea()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.MobileParty.GetRegionSwitchCostFromLandToSea | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aec30ffecd2c8181976a3059806fceb56)GetRegionSwitchCostFromSeaToLand()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.MobileParty.GetRegionSwitchCostFromSeaToLand | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#affff6128f8dce6348f65f7a2d29cad1c)SetMoveModeHold()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMoveModeHold | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6f7f86ddf27dc030ca0f9033c51f1af3)SetMoveEngageParty()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMoveEngageParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | *party*, |
|  |  | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2429d6f69159c333e28ddaef8107d18a)SetMoveGoAroundParty()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMoveGoAroundParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | *party*, |
|  |  | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac1652730ebf1cd361702ea22da25bc72)SetMoveGoToSettlement()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMoveGoToSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType*, |
|  |  | bool | *isTargetingThePort* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a51227a6df2d6c38080f48e0dd8c07b25)SetMoveGoToPoint()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMoveGoToPoint | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *point*, |
|  |  | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a031971041d319e7d4e1e2dba996cfbd6)SetMoveToNearestLand()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMoveToNearestLand | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aeef6a2627c91815e70b6beebe28d1d0e)SetMoveGoToInteractablePoint()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMoveGoToInteractablePoint | ( | [IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) | *point*, |
|  |  | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0bb5fc7b3a97463d12d320131bc65541)SetMoveEscortParty()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMoveEscortParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | *mobileParty*, |
|  |  | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType*, |
|  |  | bool | *isTargetingPort* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa2729dabc7d5444cdd5b80a387237277)SetMovePatrolAroundPoint()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMovePatrolAroundPoint | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *point*, |
|  |  | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a84651d68d8fc1228316ade0d72cf1696)SetMovePatrolAroundSettlement()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMovePatrolAroundSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType*, |
|  |  | bool | *isTargetingPort* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac615c4c81fbe78b05d22dff431531b7e)SetMoveRaidSettlement()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMoveRaidSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a5d2eefa2867863cf6edfd6d05a05660f)SetMoveBesiegeSettlement()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMoveBesiegeSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a1aa80abe81565918d4b78455d1f78800)SetMoveDefendSettlement()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetMoveDefendSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *isTargetingPort*, |
|  |  | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa943a0e320bc06878884116a279af4f9)StartFindingLocatablesAroundPosition()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | LocatableSearchData< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > TaleWorlds.CampaignSystem.Party.MobileParty.StartFindingLocatablesAroundPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, | |  |  | float | *radius* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6278b9a4e5cada1d7b1ebe5e5a895cd8)FindNextLocatable()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) TaleWorlds.CampaignSystem.Party.MobileParty.FindNextLocatable | ( | ref LocatableSearchData< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) > | *data* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a4ac82b6018d4dece88fc3418edec45e2)UpdateLocator()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.MobileParty.UpdateLocator | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) | *party* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a936dc06ed67509dfe91e56c0acc316c2)ComputeIsWaiting()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.MobileParty.ComputeIsWaiting | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad2b286880e7ca528f558168e888eb10a)InitializePartyTrade()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.InitializePartyTrade | ( | int | *initialGold* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd18bf1007de2f6dd5338678663ce378)AddTaxGold()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.AddTaxGold | ( | int | *amount* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aaf2082f5b4f9a245753c40bc607267bc)CreateParty()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) TaleWorlds.CampaignSystem.Party.MobileParty.CreateParty | ( | string | *stringId*, | |  |  | [PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa1bc1bdc86575058b3b29ee35a31ad42) | *component* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a440b7f6de2f61f3b08f89ed067124df7)SetPartyComponent()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.SetPartyComponent | ( | [PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa1bc1bdc86575058b3b29ee35a31ad42) | *partyComponent*, |
|  |  | bool | *firstTimePartyComponentCreation* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a85c2b6fb074412796488e9d8b5cd97df)UpdatePartyComponentFlags()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobileParty.UpdatePartyComponentFlags | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac5e4631835aa717ecca5f553dbaa1e7e)DefaultPartyTradeInitialGold
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Party.MobileParty.DefaultPartyTradeInitialGold = 5000 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6f362c015e966e8ecd7698574f347862)ClanRoleAssignmentMinimumSkillValue
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Party.MobileParty.ClanRoleAssignmentMinimumSkillValue = 0 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aaa6f6b165da374bb87b233cc5aca34ab)MinimumSpareGoldForWageBudget
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Party.MobileParty.MinimumSpareGoldForWageBudget = 5 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a05fe503b702e9f410b99defdff09bbec)HasUnpaidWages
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.Party.MobileParty.HasUnpaidWages |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a3b153740e373c945aef50952b77f0024)IsInfoHidden
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Party.MobileParty.IsInfoHidden = false |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a549ddb93cc29c471c3f7c5d861a3695a)NextLongTermPathPoint
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.NextLongTermPathPoint = [CampaignVec2.Invalid](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html#a4253bceee41a103119a8bbc379b4ba32) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a808f341074b045bef69cb67cc539f4e3)AverageFleeTargetDirection
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.AverageFleeTargetDirection |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a83799c042627d360cc8abfab75897d55)NextTargetPosition
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.NextTargetPosition |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f77912a7ffc2843e80eee8e120607ff)MoveTargetPoint
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.MoveTargetPoint |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0da4ea667ef0ddbc5efa234fd6740f8d)PartyMoveMode
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MoveModeType](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#ac1fc9f5da68587132812b914717cc038) TaleWorlds.CampaignSystem.Party.MobileParty.PartyMoveMode |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9013359121ed20492ef620dd6e0a4d71)MoveTargetParty
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) TaleWorlds.CampaignSystem.Party.MobileParty.MoveTargetParty |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aae7b5fa25922d712d7f1fd546fbd109f)StartTransitionNextFrameToExitFromPort
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Party.MobileParty.StartTransitionNextFrameToExitFromPort |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a44b07cc06b721d47633b73c9ca188546)Path
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) TaleWorlds.CampaignSystem.Party.MobileParty.Path |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a626818db3f6aaf9f9473cb54d73973a1)PathLastFace
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) TaleWorlds.CampaignSystem.Party.MobileParty.PathLastFace |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af2ca971ed7b3c2239254e5f881be7760)MainParty
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) TaleWorlds.CampaignSystem.Party.MobileParty.MainParty | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abdeadd11309b79f7267ac3fadfd99f59)All
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1)> TaleWorlds.CampaignSystem.Party.MobileParty.All | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a3fa4cd4744b69206a10723c723ae890a)AllCaravanParties
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1)> TaleWorlds.CampaignSystem.Party.MobileParty.AllCaravanParties | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a1ccf174008dcc7f9d10fd8d42890c9d5)AllPatrolParties
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1)> TaleWorlds.CampaignSystem.Party.MobileParty.AllPatrolParties | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a622badb34c0888655f2f83b85af3391c)AllBanditParties
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1)> TaleWorlds.CampaignSystem.Party.MobileParty.AllBanditParties | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a3ee7670fed47ee6bb482d7a675a4d283)AllLordParties
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1)> TaleWorlds.CampaignSystem.Party.MobileParty.AllLordParties | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a83d014ec6c36725fe650cf8e9ff4289d)AllGarrisonParties
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1)> TaleWorlds.CampaignSystem.Party.MobileParty.AllGarrisonParties | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acb1b225c11b0699a8e5a0101024ad4d4)AllMilitiaParties
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1)> TaleWorlds.CampaignSystem.Party.MobileParty.AllMilitiaParties | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af49c5139c21ee2ebb56ea248d1de8916)AllVillagerParties
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1)> TaleWorlds.CampaignSystem.Party.MobileParty.AllVillagerParties | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9c3eadc68c995884a57154c4ed3769ea)AllCustomParties
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1)> TaleWorlds.CampaignSystem.Party.MobileParty.AllCustomParties | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af974d05e67086fb35e04cd269517473b)AllPartiesWithoutPartyComponent
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1)> TaleWorlds.CampaignSystem.Party.MobileParty.AllPartiesWithoutPartyComponent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac5ee905d552ad612684df1a56fb1e78c)Count
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.MobileParty.Count | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9a467d6bf6726c5ff052ca15b37819ba)ConversationParty
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) TaleWorlds.CampaignSystem.Party.MobileParty.ConversationParty | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aac1d15fc82dc1ae9c68f228fe55d504d)Name
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.MobileParty.Name | | get |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a9fb1af1ef552ebd3d10304da752defa7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abc1767bc6fe57443a6aa2bae60249b8e)LastVisitedSettlement
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Party.MobileParty.LastVisitedSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac94dffe302e1dcf83b5f22cf46263511)Bearing
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.Bearing | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af8cf2115b327a2847f70a021cb254eb3)AttachedParties
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1)> TaleWorlds.CampaignSystem.Party.MobileParty.AttachedParties | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a44e798af7b9b125c1da29f46a650babb)HasLandNavigationCapability
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.HasLandNavigationCapability = true | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aaa1409a25bf297ac50eacb03706e61e3)Ships
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html)> TaleWorlds.CampaignSystem.Party.MobileParty.Ships | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0386c1b4bd69323be87102e84ef576bf)HasNavalNavigationCapability
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.HasNavalNavigationCapability | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a8f07ef03a9c7c4053f22baec4c6ba52a)Aggressiveness
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobileParty.Aggressiveness | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae63e21292adbfc62cf86c1794d7246b1)PaymentLimit
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.MobileParty.PaymentLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae0f1ab85ea5c21fa0167577529e1bb11)Banner
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.CampaignSystem.Party.MobileParty.Banner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa63f926dae5d95c65dfc626e7396ab8e)ArmyPositionAdder
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.ArmyPositionAdder | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a225046884258694468f3c099ea70105c)AiBehaviorTarget
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.AiBehaviorTarget | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a44cf1187b0a7006d9f60525fdffde21e)Objective
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyObjective](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952) TaleWorlds.CampaignSystem.Party.MobileParty.Objective = [PartyObjective.Neutral](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2f9c1dd2acca269f67b6812f4ee3a952ae9bb5320b3890b6747c91b5a71ae5a01) | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acc6354bfb923f9637856ca5ef686db24)Ai
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobilePartyAi](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html) TaleWorlds.CampaignSystem.Party.MobileParty.Ai | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac8b65406435b34e07fc9257a343ed825)Party
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Party.MobileParty.Party | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae9e22f46bd3278277f9e477deb2a9b1f)IsActive
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsActive | | getset |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a9a94a3139781933fc6095d4a190ed447).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9f04b17c4006e18d721db5f45cc78458)IsInRaftState
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsInRaftState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac2c1b165d04cf598c8de0b7c2bbd1c97)DisorganizedUntilTime
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Party.MobileParty.DisorganizedUntilTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd6c60d4024f1a8b51bffbd449adab5f)LastCalculatedBaseSpeed
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobileParty.LastCalculatedBaseSpeed | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a049075415acb30d7e89d3fa77cc233f3)ThinkParamsCache
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html) TaleWorlds.CampaignSystem.Party.MobileParty.ThinkParamsCache | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7b97ce9df9cad98c4a87efd565b3efd7)Speed
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobileParty.Speed | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad632e171d34783ecd220b851c0991bd1)SpeedExplained
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Party.MobileParty.SpeedExplained | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac42b51640cb6b3a20cd3d2cf11ff6e60)ShortTermTargetParty
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) TaleWorlds.CampaignSystem.Party.MobileParty.ShortTermTargetParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abebcac8819bf75f7a728231f94793401)ShortTermTargetSettlement
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Party.MobileParty.ShortTermTargetSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a487ee253e13e3b1871fcc08a2bf74c57)IsDisorganized
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsDisorganized | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#adc829ce5cc361302267cae3795c1a589)IsCurrentlyUsedByAQuest
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsCurrentlyUsedByAQuest | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac5a94cbde901208b86e111b50962e12d)ShortTermBehavior
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) TaleWorlds.CampaignSystem.Party.MobileParty.ShortTermBehavior | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7064e56f463a8b96b1c283ff9be475e6)IsPartyTradeActive
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsPartyTradeActive = false | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad034080f1c8344bbb010dde9d3091226)PartyTradeGold
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.MobileParty.PartyTradeGold | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2b8df1435fde84c68b348c66b6442985)PartyTradeTaxGold
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.MobileParty.PartyTradeTaxGold = 0 | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a52a4704ee146908cd375d35e310f26d2)StationaryStartTime
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Party.MobileParty.StationaryStartTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6dc13ac0e6496a6d79af3e370c9e3d70)VersionNo
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.MobileParty.VersionNo | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a434166fbd62f7aa2051b507ec78ef943)ShouldJoinPlayerBattles
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.ShouldJoinPlayerBattles | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a86bb10c05ee1083438f26e44767f1689)IsDisbanding
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsDisbanding | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a3a1d9282c8f70bf48f9eeade142189fc)RandomValue
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.MobileParty.RandomValue | | get |

Implements [TaleWorlds.CampaignSystem.IRandomOwner](interface_tale_worlds_1_1_campaign_system_1_1_i_random_owner.html#ad9f2a476dc29e7b3268949ab048d5ac7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a12f9d148d9da90118ce8583102014667)NavigationCapability
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) TaleWorlds.CampaignSystem.Party.MobileParty.NavigationCapability | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae2e993f8986ba0978fda916eed446103)IsCurrentlyAtSea
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsCurrentlyAtSea | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa2dd0494d8018bd004641c86f2e9ac98)IsNavalVisualDirty
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsNavalVisualDirty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ada9c4cbcada684875d28b7f905f8d3e6)IsTargetingPort
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsTargetingPort | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa053eff2564f46d43e87e943aeef6906)Anchor
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AnchorPoint](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html) TaleWorlds.CampaignSystem.Party.MobileParty.Anchor | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0c85f3639a2b4f1b07e4d0a12d8a07d9)IsTransitionInProgress
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsTransitionInProgress | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abe3c5a33b94bf740bc59e9767555f083)EndPositionForNavigationTransition
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.EndPositionForNavigationTransition | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#addb47374de3e50d84909e03faee3a836)NavigationTransitionStartTime
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Party.MobileParty.NavigationTransitionStartTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aaea307964b4c7700116b420bdf4be082)NavigationTransitionDuration
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Party.MobileParty.NavigationTransitionDuration = [CampaignTime.Zero](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a4a9e01e38a255d6f60447d96049a68a5) | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a86d17246721151ad09dee8fe3c462906)DesiredAiNavigationType
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) TaleWorlds.CampaignSystem.Party.MobileParty.DesiredAiNavigationType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a4c4acb32f860971d8dba9c72b6acaeee)CurrentSettlement
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Party.MobileParty.CurrentSettlement | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad250c32fd3f29aa096356184aaa6b594)HomeSettlement
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Party.MobileParty.HomeSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2fec3ec42db830e9d9a0511726f87762)AttachedTo
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) TaleWorlds.CampaignSystem.Party.MobileParty.AttachedTo | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac7a2832a38f3a6ab50eac5d7b1a5310c)Army
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Army TaleWorlds.CampaignSystem.Party.MobileParty.Army | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aac6f13048f4ed4045bd0b7e68a09ba8b)BesiegerCamp
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | BesiegerCamp TaleWorlds.CampaignSystem.Party.MobileParty.BesiegerCamp | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae30ae450429ec4e5bf14d39eba6ebf6e)DefaultBehavior
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) TaleWorlds.CampaignSystem.Party.MobileParty.DefaultBehavior | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a254c9498c4e48f71c659482a299f2e5e)TargetSettlement
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Party.MobileParty.TargetSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a99e89235367142f37c240953398e996c)TargetPosition
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.TargetPosition | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a4f2bc3fe2e4eaa14829ba3167b1b1247)TargetParty
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acd41f8de70469dff3053f80b964d5ad1) TaleWorlds.CampaignSystem.Party.MobileParty.TargetParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af1327199d4498aba931e3d6bb73e36ee)LeaderHero
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.MobileParty.LeaderHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a932f1f1f75cb2b6996a0c09664f23efc)Owner
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.MobileParty.Owner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a90679b4e92d45128e6a6292ca42480f8)EffectiveScout
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.MobileParty.EffectiveScout | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a694e213d68b27aa2f01dcde57c0538de)EffectiveQuartermaster
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.MobileParty.EffectiveQuartermaster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a0f4010796b83445954cf74a8d7ccc54c)EffectiveEngineer
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.MobileParty.EffectiveEngineer | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9bfd6fde0b1fcaa4f79bbb6fd8d7630d)EffectiveSurgeon
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.MobileParty.EffectiveSurgeon | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abe7d353ed6e0d6565ec9de84aa7908e3)RecentEventsMorale
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobileParty.RecentEventsMorale | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a93a4de02b89c3a182ecc4c05aa92504c)SeeingRangeExplanation
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Party.MobileParty.SeeingRangeExplanation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a53c03be90a361c925e17dad6f8d53d4f)InventoryCapacity
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.MobileParty.InventoryCapacity | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa6e167c23e6c1af52704a5732b6578a6)InventoryCapacityExplainedNumber
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Party.MobileParty.InventoryCapacityExplainedNumber | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a271000ed44eb8869f515599473db58c2)TotalWeightCarried
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobileParty.TotalWeightCarried | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9d67c7930bc88b85ca69b04d88f4eff0)MapEventSide
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapEventSide TaleWorlds.CampaignSystem.Party.MobileParty.MapEventSide | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a38dfebb6b66d36a906bf46363e591e4c)TotalWeightCarriedExplainedNumber
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Party.MobileParty.TotalWeightCarriedExplainedNumber | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#acfb6248368b15f500a464aa17fc8b2be)Morale
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobileParty.Morale | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9ae7df3eab57154d1effa9a4dd04f197)FoodChange
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobileParty.FoodChange | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a84808dbf1659be2743692ec4ffe0636e)BaseFoodChange
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobileParty.BaseFoodChange | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#adfd80d645f63cbf56e5f990ddbd7ddd3)ActualClan
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.Party.MobileParty.ActualClan | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab866421a3e813c731e9e04dce7492b66)FoodChangeExplained
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Party.MobileParty.FoodChangeExplained | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac744afb8f9489bff40dd4f3bb3a6d4c2)MoraleExplained
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Party.MobileParty.MoraleExplained | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a6de4c68214e697ef5d6d0e12dd7516b2)CurrentNavigationFace
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) TaleWorlds.CampaignSystem.Party.MobileParty.CurrentNavigationFace | | get |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#aafc1ce3465c81b843115c55e18f63da1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a605f06bfcc2fe284f27103bd029daa78)PathBegin
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.MobileParty.PathBegin | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7ffdd726f26750ea68d47b48d7200f88)ForceAiNoPathMode
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.ForceAiNoPathMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a1a16103aa4fce790bdc5817d42a1c1da)EventPositionAdder
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.EventPositionAdder | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a01d920f01a3fbb6d914e9837fb033c4b)IsVisible
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsVisible | | getset |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a3a703415b6c660034bba2b73841d0005).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a2b734fcbd8a03fceed0cec8eeef27450)Position
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.Position | | getset |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a4b2b24b574807e41e0c1b4afe629adb1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aea963275aee38aff6ae562e13f7ff193)IsInspected
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsInspected | | getset |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a52a27327b9546405aca825138d341bd9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab49ae40acfa58f5596f0429eb9812d3e)GetPosition2D
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.GetPosition2D | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae0eaf49bcac0e7a1afdd98f354eabfb2)TotalWage
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.MobileParty.TotalWage | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7618a197cbdf6177cdf3996c29ac53a3)TotalWageExplained
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Party.MobileParty.TotalWageExplained | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a522f396261d4df06d5036c818c36f257)MapEvent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapEvent TaleWorlds.CampaignSystem.Party.MobileParty.MapEvent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a16c80e8034db90ef9c5866b454f0e8e2)MemberRoster
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.MobileParty.MemberRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a794732930e4d2ffa235b5de13d670f2f)PrisonRoster
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.MobileParty.PrisonRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a80fd99c34fa9eea7486b56e0d02131d1)ItemRoster
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ItemRoster TaleWorlds.CampaignSystem.Party.MobileParty.ItemRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a5a7aaf663108c4b0d1817f0d6d384a95)IsMainParty
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsMainParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9980ede3f4bfe0b42faab2e1a1768a9e)MapFaction
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Party.MobileParty.MapFaction | | get |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a779a86170e3020b297abca9923ff4f47).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac04a5fb2a7094481bf78827f2a40d4ac)ArmyName
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.MobileParty.ArmyName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9411e609b4946d0a0e3d33e1673719e6)SiegeEvent
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SiegeEvent TaleWorlds.CampaignSystem.Party.MobileParty.SiegeEvent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a08740d5318cdc181297d5f2678fff991)Food
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobileParty.Food | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#abe21c1af1e316879bbfdd8668ad1ff94)TotalFoodAtInventory
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.MobileParty.TotalFoodAtInventory | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a98d045473130b99202cfc5404e319cc2)SeeingRange
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobileParty.SeeingRange | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#adec28d6f503a300ba93035162d9b47cc)BesiegedSettlement
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Party.MobileParty.BesiegedSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a37f8a88e3a3cc10d0d950af585a26412)IsEngaging
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsEngaging | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#adb6229575ecbf349405abc3a91e08452)PartySizeRatio
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobileParty.PartySizeRatio | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7f09b23e5c0b00d551606a7f39402724)VisualPosition2DWithoutError
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Party.MobileParty.VisualPosition2DWithoutError | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a9f8345bfb5f1a7e846c789ba75627ff6)IsMoving
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsMoving | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a60320bef5c497e8f525996fa1fae7ad9)ShouldBeIgnored
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.ShouldBeIgnored | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad791544f97f2611b26ad56abe3a8f645)VillagerPartyComponent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | VillagerPartyComponent TaleWorlds.CampaignSystem.Party.MobileParty.VillagerPartyComponent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a5e237da4320289d59d0424516b25f950)CaravanPartyComponent
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CaravanPartyComponent TaleWorlds.CampaignSystem.Party.MobileParty.CaravanPartyComponent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac7d68249b4309a5932ed07a7beac3e7a)WarPartyComponent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | WarPartyComponent TaleWorlds.CampaignSystem.Party.MobileParty.WarPartyComponent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ad999a037a5af28ba6540cd5903363e75)BanditPartyComponent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | BanditPartyComponent TaleWorlds.CampaignSystem.Party.MobileParty.BanditPartyComponent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ada79a173c6e5f94519d13c1d21e8628e)PatrolPartyComponent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | PatrolPartyComponent TaleWorlds.CampaignSystem.Party.MobileParty.PatrolPartyComponent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aadb502acbc2c6e9f52f828ce75082a27)LordPartyComponent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | LordPartyComponent TaleWorlds.CampaignSystem.Party.MobileParty.LordPartyComponent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac5d7a6ce789ab24f1f61aa72802f2530)GarrisonPartyComponent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | GarrisonPartyComponent TaleWorlds.CampaignSystem.Party.MobileParty.GarrisonPartyComponent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#aa1bc1bdc86575058b3b29ee35a31ad42)PartyComponent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | PartyComponent TaleWorlds.CampaignSystem.Party.MobileParty.PartyComponent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a7555439a84b503e71b21d71184a11811)IsMilitia
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsMilitia | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a4cbb065ce03831c6cf16e1a6d9482f37)IsLordParty
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsLordParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a60b4f5ded7f3236fcf717b0cc660cc27)IsVillager
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsVillager | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a25382b046ac94652a361417efbc38d57)IsCaravan
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsCaravan | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#af39d349ce4b3bb469e1c183a22f849a3)IsPatrolParty
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsPatrolParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a3f926dcd012b562d4a8882d1d4b5358f)IsGarrison
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsGarrison | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a48d68f36f983bcfe05ffceb4aea08f9d)IsCustomParty
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsCustomParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#a031d7bd919cab660c0f61276cdcbb9ea)IsBandit
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsBandit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ae8e0d8a52f4644c31c0a030e4bfdda22)IsBanditBossParty
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.IsBanditBossParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ac8c53989471bc89afc35f2c3d908ebad)AvoidHostileActions
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobileParty.AvoidHostileActions | | get |


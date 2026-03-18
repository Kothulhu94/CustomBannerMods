--- SOURCE: struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html ---

TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData Struct Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [PartyScreenLogicInitializationData](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html) | [CreateBasicInitDataWithMainParty](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ac22511c79ea162873f717dc796804be5) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftMemberRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftPrisonerRoster, [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) memberTransferState, [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) prisonerTransferState, [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) accompanyingTransferState, [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) troopTransferableDelegate, [PartyScreenHelper.PartyScreenMode](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505) partyScreenMode, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) leftOwnerParty=null, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) leftPartyName=null, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) header=null, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) leftLeaderHero=null, int leftPartyMembersSizeLimit=0, int leftPartyPrisonersSizeLimit=0, [PartyPresentationDoneButtonDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a2f881e84b72b01e10427d4921d0cb367) partyPresentationDoneButtonDelegate=null, [PartyPresentationDoneButtonConditionDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a76d3ba1b861912fc43cd6647edf9157a) partyPresentationDoneButtonConditionDelegate=null, [PartyPresentationCancelButtonDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#afa5b679baff5ffc480598cb27e13fab1) partyPresentationCancelButtonDelegate=null, [PartyPresentationCancelButtonActivateDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ab8982f0f51ab2acc4f9c4f09b3a7230e) partyPresentationCancelButtonActivateDelegate=null, [PartyScreenClosedDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a9bebaa42c572337a463452d28cd064a6) partyScreenClosedDelegate=null, bool isDismissMode=false, bool transferHealthiesGetWoundedsFirst=false, bool isTroopUpgradesDisabled=false, bool showProgressBar=false, int questModeWageDaysMultiplier=0) |
| static [PartyScreenLogicInitializationData](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html) | [CreateBasicInitDataWithMainPartyAndOther](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a28fb6e3e90cf4eadc81bffad32610170) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) memberTransferState, [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) prisonerTransferState, [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) accompanyingTransferState, [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) troopTransferableDelegate, [PartyScreenHelper.PartyScreenMode](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505) partyScreenMode, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) header=null, [PartyPresentationDoneButtonDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a2f881e84b72b01e10427d4921d0cb367) partyPresentationDoneButtonDelegate=null, [PartyPresentationDoneButtonConditionDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a76d3ba1b861912fc43cd6647edf9157a) partyPresentationDoneButtonConditionDelegate=null, [PartyPresentationCancelButtonDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#afa5b679baff5ffc480598cb27e13fab1) partyPresentationCancelButtonDelegate=null, [PartyPresentationCancelButtonActivateDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ab8982f0f51ab2acc4f9c4f09b3a7230e) partyPresentationCancelButtonActivateDelegate=null, [PartyScreenClosedDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a9bebaa42c572337a463452d28cd064a6) partyScreenClosedDelegate=null, bool isDismissMode=false, bool transferHealthiesGetWoundedsFirst=false, bool isTroopUpgradesDisabled=true, bool showProgressBar=false) |

|  |  |
| --- | --- |
| Public Attributes | |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [LeftMemberRoster](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a0cdce8fc6e3c062ca0c64fea8ab39dc2) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [LeftPrisonerRoster](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a0a14969a9c998750dd06af0fc78dec77) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [RightMemberRoster](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a77cd9c132098a7a3b47e36e732a7a667) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [RightPrisonerRoster](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#aa3386cb64f866e8d67901cb1e46e2237) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [LeftOwnerParty](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a55d773fc0b6a652283f1d56a6e3259d8) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [RightOwnerParty](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ac6f27d593df62c420ec8b0ae8f6d8517) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [LeftPartyName](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#aa60947d087e97e67222e1c323a2550b3) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [RightPartyName](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a17471e9fb39c7a52fe00f213e489cdd9) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Header](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#aed28d768ad349748c746e86d6b5648df) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [LeftLeaderHero](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a97ffd6fec44cb4fe520757c860b09a73) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [RightLeaderHero](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ac62462e38453cf724abc4d66caaee80b) |
| int | [LeftPartyMembersSizeLimit](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a4f445db3dee0ca6cea8fbd7b0e4733eb) |
| int | [LeftPartyPrisonersSizeLimit](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#aa6d361b840b213c8b7328f0d1cc44ebe) |
| int | [RightPartyMembersSizeLimit](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a7868984fb0f324472bb2409e0e119f16) |
| int | [RightPartyPrisonersSizeLimit](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#aab8018ffacf7af0b2fc31b06e24596aa) |
| PartyPresentationDoneButtonDelegate | [PartyPresentationDoneButtonDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a2f881e84b72b01e10427d4921d0cb367) |
| PartyPresentationDoneButtonConditionDelegate | [PartyPresentationDoneButtonConditionDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a76d3ba1b861912fc43cd6647edf9157a) |
| PartyPresentationCancelButtonActivateDelegate | [PartyPresentationCancelButtonActivateDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ab8982f0f51ab2acc4f9c4f09b3a7230e) |
| [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) | [TroopTransferableDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a7ed51aa249951a9b3dbb4e1f7e5bfccc) |
| [CanTalkToHeroDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a5e24b3cf4fc2049840567fba4cfb674e) | [CanTalkToTroopDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a69c7198343442eb6fd46c4767f9d81e9) |
| PartyPresentationCancelButtonDelegate | [PartyPresentationCancelButtonDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#afa5b679baff5ffc480598cb27e13fab1) |
| PartyScreenClosedDelegate | [PartyScreenClosedDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a9bebaa42c572337a463452d28cd064a6) |
| bool | [DoNotApplyGoldTransactions](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a09f576e5fce8d5910d85574651b28d55) |
| bool | [IsDismissMode](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ae86035f9d8d2e697f1651898d63bd4af) |
| bool | [TransferHealthiesGetWoundedsFirst](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a776edb1763a34b305888f9907b54d91c) |
| bool | [IsTroopUpgradesDisabled](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a36f168e88168be32a58425594107b248) |
| bool | [ShowProgressBar](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a3474ccf80edca93d72000bc4f1a6eedf) |
| int | [QuestModeWageDaysMultiplier](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a2164d3e09b1dd0440e0a7c8c78acde9e) |
| [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) | [MemberTransferState](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a563cf9ae706a914573a1b79bbfc45740) |
| [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) | [PrisonerTransferState](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a7d2801c59f28377f3158c2b4f1efe5a5) |
| [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) | [AccompanyingTransferState](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#aa2a8a9f74d65054d7e9ba78382569583) |
| [PartyScreenHelper.PartyScreenMode](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505) | [PartyScreenMode](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a29d1b9b3cd0812f808c12c2f796a045f) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ac22511c79ea162873f717dc796804be5)CreateBasicInitDataWithMainParty()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [PartyScreenLogicInitializationData](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.CreateBasicInitDataWithMainParty | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftMemberRoster*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftPrisonerRoster*, | |  |  | [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) | *memberTransferState*, | |  |  | [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) | *prisonerTransferState*, | |  |  | [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) | *accompanyingTransferState*, | |  |  | [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) | *troopTransferableDelegate*, | |  |  | [PartyScreenHelper.PartyScreenMode](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505) | *partyScreenMode*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *leftOwnerParty* = null, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *leftPartyName* = null, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *header* = null, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *leftLeaderHero* = null, | |  |  | int | *leftPartyMembersSizeLimit* = 0, | |  |  | int | *leftPartyPrisonersSizeLimit* = 0, | |  |  | [PartyPresentationDoneButtonDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a2f881e84b72b01e10427d4921d0cb367) | *partyPresentationDoneButtonDelegate* = null, | |  |  | [PartyPresentationDoneButtonConditionDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a76d3ba1b861912fc43cd6647edf9157a) | *partyPresentationDoneButtonConditionDelegate* = null, | |  |  | [PartyPresentationCancelButtonDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#afa5b679baff5ffc480598cb27e13fab1) | *partyPresentationCancelButtonDelegate* = null, | |  |  | [PartyPresentationCancelButtonActivateDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ab8982f0f51ab2acc4f9c4f09b3a7230e) | *partyPresentationCancelButtonActivateDelegate* = null, | |  |  | [PartyScreenClosedDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a9bebaa42c572337a463452d28cd064a6) | *partyScreenClosedDelegate* = null, | |  |  | bool | *isDismissMode* = false, | |  |  | bool | *transferHealthiesGetWoundedsFirst* = false, | |  |  | bool | *isTroopUpgradesDisabled* = false, | |  |  | bool | *showProgressBar* = false, | |  |  | int | *questModeWageDaysMultiplier* = 0 ) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a28fb6e3e90cf4eadc81bffad32610170)CreateBasicInitDataWithMainPartyAndOther()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [PartyScreenLogicInitializationData](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.CreateBasicInitDataWithMainPartyAndOther | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) | *memberTransferState*, | |  |  | [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) | *prisonerTransferState*, | |  |  | [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) | *accompanyingTransferState*, | |  |  | [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) | *troopTransferableDelegate*, | |  |  | [PartyScreenHelper.PartyScreenMode](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505) | *partyScreenMode*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *header* = null, | |  |  | [PartyPresentationDoneButtonDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a2f881e84b72b01e10427d4921d0cb367) | *partyPresentationDoneButtonDelegate* = null, | |  |  | [PartyPresentationDoneButtonConditionDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a76d3ba1b861912fc43cd6647edf9157a) | *partyPresentationDoneButtonConditionDelegate* = null, | |  |  | [PartyPresentationCancelButtonDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#afa5b679baff5ffc480598cb27e13fab1) | *partyPresentationCancelButtonDelegate* = null, | |  |  | [PartyPresentationCancelButtonActivateDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ab8982f0f51ab2acc4f9c4f09b3a7230e) | *partyPresentationCancelButtonActivateDelegate* = null, | |  |  | [PartyScreenClosedDelegate](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a9bebaa42c572337a463452d28cd064a6) | *partyScreenClosedDelegate* = null, | |  |  | bool | *isDismissMode* = false, | |  |  | bool | *transferHealthiesGetWoundedsFirst* = false, | |  |  | bool | *isTroopUpgradesDisabled* = true, | |  |  | bool | *showProgressBar* = false ) | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a0cdce8fc6e3c062ca0c64fea8ab39dc2)LeftMemberRoster
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.LeftMemberRoster |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a0a14969a9c998750dd06af0fc78dec77)LeftPrisonerRoster
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.LeftPrisonerRoster |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a77cd9c132098a7a3b47e36e732a7a667)RightMemberRoster
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.RightMemberRoster |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#aa3386cb64f866e8d67901cb1e46e2237)RightPrisonerRoster
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.RightPrisonerRoster |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a55d773fc0b6a652283f1d56a6e3259d8)LeftOwnerParty
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.LeftOwnerParty |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ac6f27d593df62c420ec8b0ae8f6d8517)RightOwnerParty
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.RightOwnerParty |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#aa60947d087e97e67222e1c323a2550b3)LeftPartyName
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.LeftPartyName |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a17471e9fb39c7a52fe00f213e489cdd9)RightPartyName
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.RightPartyName |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#aed28d768ad349748c746e86d6b5648df)Header
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.Header |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a97ffd6fec44cb4fe520757c860b09a73)LeftLeaderHero
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.LeftLeaderHero |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ac62462e38453cf724abc4d66caaee80b)RightLeaderHero
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.RightLeaderHero |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a4f445db3dee0ca6cea8fbd7b0e4733eb)LeftPartyMembersSizeLimit
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.LeftPartyMembersSizeLimit |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#aa6d361b840b213c8b7328f0d1cc44ebe)LeftPartyPrisonersSizeLimit
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.LeftPartyPrisonersSizeLimit |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a7868984fb0f324472bb2409e0e119f16)RightPartyMembersSizeLimit
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.RightPartyMembersSizeLimit |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#aab8018ffacf7af0b2fc31b06e24596aa)RightPartyPrisonersSizeLimit
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.RightPartyPrisonersSizeLimit |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a2f881e84b72b01e10427d4921d0cb367)PartyPresentationDoneButtonDelegate
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| PartyPresentationDoneButtonDelegate TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.PartyPresentationDoneButtonDelegate |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a76d3ba1b861912fc43cd6647edf9157a)PartyPresentationDoneButtonConditionDelegate
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| PartyPresentationDoneButtonConditionDelegate TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.PartyPresentationDoneButtonConditionDelegate |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ab8982f0f51ab2acc4f9c4f09b3a7230e)PartyPresentationCancelButtonActivateDelegate
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| PartyPresentationCancelButtonActivateDelegate TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.PartyPresentationCancelButtonActivateDelegate |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a7ed51aa249951a9b3dbb4e1f7e5bfccc)TroopTransferableDelegate
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.TroopTransferableDelegate |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a69c7198343442eb6fd46c4767f9d81e9)CanTalkToTroopDelegate
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CanTalkToHeroDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a5e24b3cf4fc2049840567fba4cfb674e) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.CanTalkToTroopDelegate |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#afa5b679baff5ffc480598cb27e13fab1)PartyPresentationCancelButtonDelegate
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| PartyPresentationCancelButtonDelegate TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.PartyPresentationCancelButtonDelegate |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a9bebaa42c572337a463452d28cd064a6)PartyScreenClosedDelegate
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| PartyScreenClosedDelegate TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.PartyScreenClosedDelegate |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a09f576e5fce8d5910d85574651b28d55)DoNotApplyGoldTransactions
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.DoNotApplyGoldTransactions |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#ae86035f9d8d2e697f1651898d63bd4af)IsDismissMode
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.IsDismissMode |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a776edb1763a34b305888f9907b54d91c)TransferHealthiesGetWoundedsFirst
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.TransferHealthiesGetWoundedsFirst |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a36f168e88168be32a58425594107b248)IsTroopUpgradesDisabled
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.IsTroopUpgradesDisabled |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a3474ccf80edca93d72000bc4f1a6eedf)ShowProgressBar
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.ShowProgressBar |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a2164d3e09b1dd0440e0a7c8c78acde9e)QuestModeWageDaysMultiplier
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.QuestModeWageDaysMultiplier |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a563cf9ae706a914573a1b79bbfc45740)MemberTransferState
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.MemberTransferState |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a7d2801c59f28377f3158c2b4f1efe5a5)PrisonerTransferState
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.PrisonerTransferState |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#aa2a8a9f74d65054d7e9ba78382569583)AccompanyingTransferState
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.AccompanyingTransferState |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html#a29d1b9b3cd0812f808c12c2f796a045f)PartyScreenMode
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyScreenHelper.PartyScreenMode](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505) TaleWorlds.CampaignSystem.Party.PartyScreenLogicInitializationData.PartyScreenMode |


--- SOURCE: class_helpers_1_1_party_screen_helper.html ---

Helpers.PartyScreenHelper Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [PartyScreenMode](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505) {     [Normal](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505a960b44c579bc2f6818d2daaf9e4c16f0) ,     [Shared](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505aa6156ea9d66fef24e87e841fbabf7cca) ,     [Loot](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505a6794e7b16f55b952b04e118ec3a7cc78) ,     [Ransom](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505aa606b3b02930b70dff78144b4f61a81f) ,     [PrisonerManage](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505a6f67277594e1485103f891a2cac180ac) ,     [TroopsManage](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505a44c284197e0fbe4af9ddd3ec9c273893) ,     [QuestTroopManage](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505a8f66c09cb3ab3ccc83797c6cf414a142)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [PartyState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_party_state.html) | [GetActivePartyState](class_helpers_1_1_party_screen_helper.html#a12e89dc468551a5680d04bd10a9a596a) () |
| static void | [CloseScreen](class_helpers_1_1_party_screen_helper.html#aedc93567e5b5e72ba2d947959cf6eb8f) (bool isForced, bool fromCancel=false) |
| static void | [OpenScreenAsCheat](class_helpers_1_1_party_screen_helper.html#aee4093ead931d83e2aa5a5f3387fce33) () |
| static void | [OpenScreenAsNormal](class_helpers_1_1_party_screen_helper.html#a4bbb95ad70578a7719df36e1f421d62b) () |
| static void | [OpenScreenAsRansom](class_helpers_1_1_party_screen_helper.html#a0e9a00cd4795b5c385f47516a7b6d642) () |
| static void | [OpenScreenAsLoot](class_helpers_1_1_party_screen_helper.html#af00affa144a8f618ecb55a2e38f0fd8f) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftMemberRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftPrisonerRoster, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) leftPartyName, int leftPartySizeLimit, [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) partyScreenClosedDelegate=null) |
| static void | [OpenScreenAsManageTroopsAndPrisoners](class_helpers_1_1_party_screen_helper.html#a18bcbda12750e9d6ea72b73940daae95) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) leftParty, [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) onPartyScreenClosed=null) |
| static void | [OpenScreenAsReceiveTroops](class_helpers_1_1_party_screen_helper.html#ae7b778c639b77229dc6af779d0f2cdd7) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftMemberParty, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) leftPartyName, [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) partyScreenClosedDelegate=null) |
| static void | [OpenScreenAsManageTroops](class_helpers_1_1_party_screen_helper.html#a362acb658131cecbcae7ac03a59118c1) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) leftParty) |
| static void | [OpenScreenAsDonateTroops](class_helpers_1_1_party_screen_helper.html#a06d27ed349b7abdcfced310136255e69) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) leftParty) |
| static void | [OpenScreenAsDonateGarrisonWithCurrentSettlement](class_helpers_1_1_party_screen_helper.html#a72e745a61d6d3aac037d32ae7bfcc1fd) () |
| static void | [OpenScreenAsDonatePrisoners](class_helpers_1_1_party_screen_helper.html#a42eea65654bd505f326682cc3837d545) () |
| static bool | [DonatePrisonerTransferableDelegate](class_helpers_1_1_party_screen_helper.html#a86ebad68fa7f77df519d2d1fe8a7b68d) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, PartyScreenLogic.TroopType type, PartyScreenLogic.PartyRosterSide side, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) LeftOwnerParty) |
| static void | [OpenScreenAsManagePrisoners](class_helpers_1_1_party_screen_helper.html#af343044633d47eb148db2e2940dfec14) () |
| static bool | [TroopTransferableDelegate](class_helpers_1_1_party_screen_helper.html#a2b862421930aad991e40e78632c9ca6f) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, PartyScreenLogic.TroopType type, PartyScreenLogic.PartyRosterSide side, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) leftOwnerParty) |
| static bool | [ClanManageTroopAndPrisonerTransferableDelegate](class_helpers_1_1_party_screen_helper.html#a9139df4c684d967b293870929210d2de) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, PartyScreenLogic.TroopType type, PartyScreenLogic.PartyRosterSide side, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) LeftOwnerParty) |
| static bool | [ClanManageTroopTransferableDelegate](class_helpers_1_1_party_screen_helper.html#ad2a7a6810889e7c0cc8decce7efb9ca6) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, PartyScreenLogic.TroopType type, PartyScreenLogic.PartyRosterSide side, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) LeftOwnerParty) |
| static bool | [DonateModeTroopTransferableDelegate](class_helpers_1_1_party_screen_helper.html#a2400543bd47582a9a022f20fc8df3074) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, PartyScreenLogic.TroopType type, PartyScreenLogic.PartyRosterSide side, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) LeftOwnerParty) |
| static void | [OpenScreenWithCondition](class_helpers_1_1_party_screen_helper.html#a9a01edf823cc2556dc20d0d7e34d3c90) ([IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) isTroopTransferable, [PartyPresentationDoneButtonConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a87ed33d0f6e195c7cfba6fe1c563a7af) doneButtonCondition, [PartyPresentationDoneButtonDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a76f32bded9bbc30b00064d831aa8c6b4) onDoneClicked, [PartyPresentationCancelButtonDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a996bcd2a5b443e80a2d3024b0864afda) onCancelClicked, PartyScreenLogic.TransferState memberTransferState, PartyScreenLogic.TransferState prisonerTransferState, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) leftPartyName, int limit, bool showProgressBar, bool isDonating, [PartyScreenMode](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505) screenMode=[PartyScreenMode.Normal](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505a960b44c579bc2f6818d2daaf9e4c16f0), [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) memberRosterLeft=null, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) prisonerRosterLeft=null) |
| static void | [OpenScreenForManagingAlley](class_helpers_1_1_party_screen_helper.html#ac873b03717350fb303c62426cec88b95) (bool isNewAlley, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) memberRosterLeft, [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) isTroopTransferable, [PartyPresentationDoneButtonConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a87ed33d0f6e195c7cfba6fe1c563a7af) doneButtonCondition, [PartyPresentationDoneButtonDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a76f32bded9bbc30b00064d831aa8c6b4) onDoneClicked, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) leftPartyName, [PartyPresentationCancelButtonDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a996bcd2a5b443e80a2d3024b0864afda) onCancelButtonClicked) |
| static void | [OpenScreenAsQuest](class_helpers_1_1_party_screen_helper.html#aebf1a80fa0e731cd99719b141df1510c) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftMemberRoster, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) leftPartyName, int leftPartySizeLimit, int questDaysMultiplier, [PartyPresentationDoneButtonConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a87ed33d0f6e195c7cfba6fe1c563a7af) doneButtonCondition, [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) onPartyScreenClosed, [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) isTroopTransferable, [PartyPresentationCancelButtonActivateDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a254d2a313fde73897cc5e1550b721e98) partyPresentationCancelButtonActivateDelegate=null) |
| static void | [OpenScreenWithDummyRoster](class_helpers_1_1_party_screen_helper.html#a309e0a73aaad45db371fb6ca28b1e0ad) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftMemberRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftPrisonerRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) rightMemberRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) rightPrisonerRoster, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) leftPartyName, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) rightPartyName, int leftPartySizeLimit, int rightPartySizeLimit, [PartyPresentationDoneButtonConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a87ed33d0f6e195c7cfba6fe1c563a7af) doneButtonCondition, [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) onPartyScreenClosed, [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) isTroopTransferable, [CanTalkToHeroDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a5e24b3cf4fc2049840567fba4cfb674e) canTalkToTroopDelegate=null, [PartyPresentationCancelButtonActivateDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a254d2a313fde73897cc5e1550b721e98) partyPresentationCancelButtonActivateDelegate=null) |
| static void | [OpenScreenWithDummyRosterWithMainParty](class_helpers_1_1_party_screen_helper.html#aad2d1cb07ad6e0f5d45b3f9f369a051f) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftMemberRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftPrisonerRoster, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) leftPartyName, int leftPartySizeLimit, [PartyPresentationDoneButtonConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a87ed33d0f6e195c7cfba6fe1c563a7af) doneButtonCondition, [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) onPartyScreenClosed, [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) isTroopTransferable, [PartyPresentationCancelButtonActivateDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a254d2a313fde73897cc5e1550b721e98) partyPresentationCancelButtonActivateDelegate=null) |
| static void | [OpenScreenAsCreateClanPartyForHero](class_helpers_1_1_party_screen_helper.html#a91e7b36f7ec9a09016dff375f9800dc1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) onScreenClosed=null, [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) isTroopTransferable=null) |

Member Enumeration Documentation
--------------------------------

[◆](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505)PartyScreenMode
------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [Helpers.PartyScreenHelper.PartyScreenMode](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505) |

| Enumerator | |
| --- | --- |
| Normal |  |
| Shared |  |
| Loot |  |
| Ransom |  |
| PrisonerManage |  |
| TroopsManage |  |
| QuestTroopManage |  |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_party_screen_helper.html#a12e89dc468551a5680d04bd10a9a596a)GetActivePartyState()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [PartyState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_party_state.html) Helpers.PartyScreenHelper.GetActivePartyState | ( |  | ) |  | | static |

[◆](class_helpers_1_1_party_screen_helper.html#aedc93567e5b5e72ba2d947959cf6eb8f)CloseScreen()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.CloseScreen | ( | bool | *isForced*, | |  |  | bool | *fromCancel* = false ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#aee4093ead931d83e2aa5a5f3387fce33)OpenScreenAsCheat()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsCheat | ( |  | ) |  | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a4bbb95ad70578a7719df36e1f421d62b)OpenScreenAsNormal()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsNormal | ( |  | ) |  | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a0e9a00cd4795b5c385f47516a7b6d642)OpenScreenAsRansom()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsRansom | ( |  | ) |  | | static |

[◆](class_helpers_1_1_party_screen_helper.html#af00affa144a8f618ecb55a2e38f0fd8f)OpenScreenAsLoot()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsLoot | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftMemberRoster*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftPrisonerRoster*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *leftPartyName*, | |  |  | int | *leftPartySizeLimit*, | |  |  | [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) | *partyScreenClosedDelegate* = null ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a18bcbda12750e9d6ea72b73940daae95)OpenScreenAsManageTroopsAndPrisoners()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsManageTroopsAndPrisoners | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *leftParty*, | |  |  | [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) | *onPartyScreenClosed* = null ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#ae7b778c639b77229dc6af779d0f2cdd7)OpenScreenAsReceiveTroops()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsReceiveTroops | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftMemberParty*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *leftPartyName*, | |  |  | [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) | *partyScreenClosedDelegate* = null ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a362acb658131cecbcae7ac03a59118c1)OpenScreenAsManageTroops()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsManageTroops | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *leftParty* | ) |  | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a06d27ed349b7abdcfced310136255e69)OpenScreenAsDonateTroops()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsDonateTroops | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *leftParty* | ) |  | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a72e745a61d6d3aac037d32ae7bfcc1fd)OpenScreenAsDonateGarrisonWithCurrentSettlement()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsDonateGarrisonWithCurrentSettlement | ( |  | ) |  | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a42eea65654bd505f326682cc3837d545)OpenScreenAsDonatePrisoners()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsDonatePrisoners | ( |  | ) |  | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a86ebad68fa7f77df519d2d1fe8a7b68d)DonatePrisonerTransferableDelegate()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.PartyScreenHelper.DonatePrisonerTransferableDelegate | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | PartyScreenLogic.TroopType | *type*, | |  |  | PartyScreenLogic.PartyRosterSide | *side*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *LeftOwnerParty* ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#af343044633d47eb148db2e2940dfec14)OpenScreenAsManagePrisoners()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsManagePrisoners | ( |  | ) |  | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a2b862421930aad991e40e78632c9ca6f)TroopTransferableDelegate()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.PartyScreenHelper.TroopTransferableDelegate | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | PartyScreenLogic.TroopType | *type*, | |  |  | PartyScreenLogic.PartyRosterSide | *side*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *leftOwnerParty* ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a9139df4c684d967b293870929210d2de)ClanManageTroopAndPrisonerTransferableDelegate()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.PartyScreenHelper.ClanManageTroopAndPrisonerTransferableDelegate | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | PartyScreenLogic.TroopType | *type*, | |  |  | PartyScreenLogic.PartyRosterSide | *side*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *LeftOwnerParty* ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#ad2a7a6810889e7c0cc8decce7efb9ca6)ClanManageTroopTransferableDelegate()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.PartyScreenHelper.ClanManageTroopTransferableDelegate | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | PartyScreenLogic.TroopType | *type*, | |  |  | PartyScreenLogic.PartyRosterSide | *side*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *LeftOwnerParty* ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a2400543bd47582a9a022f20fc8df3074)DonateModeTroopTransferableDelegate()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.PartyScreenHelper.DonateModeTroopTransferableDelegate | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | PartyScreenLogic.TroopType | *type*, | |  |  | PartyScreenLogic.PartyRosterSide | *side*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *LeftOwnerParty* ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a9a01edf823cc2556dc20d0d7e34d3c90)OpenScreenWithCondition()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenWithCondition | ( | [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) | *isTroopTransferable*, | |  |  | [PartyPresentationDoneButtonConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a87ed33d0f6e195c7cfba6fe1c563a7af) | *doneButtonCondition*, | |  |  | [PartyPresentationDoneButtonDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a76f32bded9bbc30b00064d831aa8c6b4) | *onDoneClicked*, | |  |  | [PartyPresentationCancelButtonDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a996bcd2a5b443e80a2d3024b0864afda) | *onCancelClicked*, | |  |  | PartyScreenLogic.TransferState | *memberTransferState*, | |  |  | PartyScreenLogic.TransferState | *prisonerTransferState*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *leftPartyName*, | |  |  | int | *limit*, | |  |  | bool | *showProgressBar*, | |  |  | bool | *isDonating*, | |  |  | [PartyScreenMode](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505) | *screenMode* = [PartyScreenMode::Normal](class_helpers_1_1_party_screen_helper.html#a531af70a1a5ffc7a3fa879262790c505a960b44c579bc2f6818d2daaf9e4c16f0), | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *memberRosterLeft* = null, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *prisonerRosterLeft* = null ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#ac873b03717350fb303c62426cec88b95)OpenScreenForManagingAlley()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenForManagingAlley | ( | bool | *isNewAlley*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *memberRosterLeft*, | |  |  | [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) | *isTroopTransferable*, | |  |  | [PartyPresentationDoneButtonConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a87ed33d0f6e195c7cfba6fe1c563a7af) | *doneButtonCondition*, | |  |  | [PartyPresentationDoneButtonDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a76f32bded9bbc30b00064d831aa8c6b4) | *onDoneClicked*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *leftPartyName*, | |  |  | [PartyPresentationCancelButtonDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a996bcd2a5b443e80a2d3024b0864afda) | *onCancelButtonClicked* ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#aebf1a80fa0e731cd99719b141df1510c)OpenScreenAsQuest()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsQuest | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftMemberRoster*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *leftPartyName*, | |  |  | int | *leftPartySizeLimit*, | |  |  | int | *questDaysMultiplier*, | |  |  | [PartyPresentationDoneButtonConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a87ed33d0f6e195c7cfba6fe1c563a7af) | *doneButtonCondition*, | |  |  | [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) | *onPartyScreenClosed*, | |  |  | [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) | *isTroopTransferable*, | |  |  | [PartyPresentationCancelButtonActivateDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a254d2a313fde73897cc5e1550b721e98) | *partyPresentationCancelButtonActivateDelegate* = null ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a309e0a73aaad45db371fb6ca28b1e0ad)OpenScreenWithDummyRoster()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenWithDummyRoster | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftMemberRoster*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftPrisonerRoster*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *rightMemberRoster*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *rightPrisonerRoster*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *leftPartyName*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *rightPartyName*, | |  |  | int | *leftPartySizeLimit*, | |  |  | int | *rightPartySizeLimit*, | |  |  | [PartyPresentationDoneButtonConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a87ed33d0f6e195c7cfba6fe1c563a7af) | *doneButtonCondition*, | |  |  | [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) | *onPartyScreenClosed*, | |  |  | [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) | *isTroopTransferable*, | |  |  | [CanTalkToHeroDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a5e24b3cf4fc2049840567fba4cfb674e) | *canTalkToTroopDelegate* = null, | |  |  | [PartyPresentationCancelButtonActivateDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a254d2a313fde73897cc5e1550b721e98) | *partyPresentationCancelButtonActivateDelegate* = null ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#aad2d1cb07ad6e0f5d45b3f9f369a051f)OpenScreenWithDummyRosterWithMainParty()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenWithDummyRosterWithMainParty | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftMemberRoster*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftPrisonerRoster*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *leftPartyName*, | |  |  | int | *leftPartySizeLimit*, | |  |  | [PartyPresentationDoneButtonConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a87ed33d0f6e195c7cfba6fe1c563a7af) | *doneButtonCondition*, | |  |  | [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) | *onPartyScreenClosed*, | |  |  | [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) | *isTroopTransferable*, | |  |  | [PartyPresentationCancelButtonActivateDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a254d2a313fde73897cc5e1550b721e98) | *partyPresentationCancelButtonActivateDelegate* = null ) | | static |

[◆](class_helpers_1_1_party_screen_helper.html#a91e7b36f7ec9a09016dff375f9800dc1)OpenScreenAsCreateClanPartyForHero()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.PartyScreenHelper.OpenScreenAsCreateClanPartyForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) | *onScreenClosed* = null, | |  |  | [IsTroopTransferableDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a0bb7004c6d241e2edafe68d18ab5adb5) | *isTroopTransferable* = null ) | | static |


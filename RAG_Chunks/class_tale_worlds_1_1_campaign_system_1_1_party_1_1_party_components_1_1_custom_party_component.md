--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html ---

TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent Class ReferenceInherits [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html).

|  |  |
| --- | --- |
| Classes | |
| class | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a05a464052a051c065ec1ebc2fba22774) () |
| void | [SetBaseSpeed](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a725891e95bd1f3cd1c6ea6b928c544e9) (float speed) |
| override void | [GetMountAndHarnessVisualIdsForPartyIcon](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a95d0ce00262221789837483110145b9f) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, out string mountStringId, out string harnessStringId) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html) | |
| delegate void | [OnPartyComponentCreatedDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ace8920c5d5ebe4eec2959b6a64731126) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty) |
| virtual void | [SetWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ae62c187242165b4f71fefda2db6abe0c) (int newLimit) |
| [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad6823059866c50583270e38735d703ed) () |
| virtual void | [ClearCachedName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a55d879bb34b02f27924dc8eae6f4bef0) () |
| void | [ChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a0c7601e2f1a98b9b6f4d0cc17503f0f1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | [CreateCustomPartyWithPartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#adf1481d58cee4f6b6c5c1d990b6ae4b6) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, float spawnRadius, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) homeSettlement, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) partyTemplate, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, string partyMountStringId="", string partyHarnessStringId="", float customPartyBaseSpeed=0.0f, bool avoidHostileActions=false) |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | [CreateCustomPartyWithPartyTemplate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a00060685780b2fd0291a351700afdc03) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, float spawnRadius, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) homeSettlement, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) partyTemplate, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) leader, string partyMountStringId="", string partyHarnessStringId="", float customPartyBaseSpeed=0.0f, bool avoidHostileActions=false) |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | [CreateCustomPartyWithTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a633a01ec54a69cd82bb79d9e01ab3589) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, float spawnRadius, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) homeSettlement, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troopRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) prisonerRoster, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, string partyMountStringId="", string partyHarnessStringId="", float customPartyBaseSpeed=0.0f, bool avoidHostileActions=false) |
| static void | [ConvertPartyToCustomParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#af18b35db33abb05c1cc5cff40b15d24d) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) homeSettlement, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, string partyMountStringId="", string partyHarnessStringId="", float customPartyBaseSpeed=0.0f, bool avoidHostileActions=false) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [CustomPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a0acab21c0bfd7b3556a6ac764db8b660) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) homeSettlement, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, string partyMountStringId, string partyHarnessStringId, float customPartyBaseSpeed, bool avoidHostileActions, [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html) args, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) leader=null) |
| override void | [OnMobilePartySetOnCreation](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#abeb196ecaddff6bb4b5042cf9482c7b8) () |
| override void | [OnChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#ab1bb8d2fd7eea80ebbdf4757536bafe7) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html) | |
| virtual void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a5f3bc1ed376a3dd658ca5fadca14df39) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#aa9ca4a2d81beda9e861b8f4bd67348bb) () |

|  |  |
| --- | --- |
| Properties | |
| float | [CustomPartyBaseSpeed](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#af8014cf943c96d6a1ae5a0733e829451) `[get, set]` |
| override bool | [AvoidHostileActions](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#acbf7a3b21e6114cb6755adfa20978874) `[get]` |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Leader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a80b4444680ffba0f7a16ebc5fe974444) `[get]` |
| float | [BaseSpeed](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#acd0a8d9e31f5f6cd4f40bd918d81fd1b) `[get]` |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [PartyOwner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a14e9f47e65c4e23d1850741629545125) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a21861a6aaa21bf8ca2bc99ccf1c33146) `[get]` |
| override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [HomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a84daa399096b8012c41f6017e943ae1d) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html) | |
| MobileParty | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [Party](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a374e9b0633c1f43e9120327d13a2923d) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [PartyOwner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a9a8f5d1ff3b5944988935eba5d5f90a2) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a16d9961799d5d1a66bf2fbf5854e53c8) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [HomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#abf95312007a55e73813a17958749e49b) `[get]` |
| virtual bool | [AvoidHostileActions](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ac1a519ce62fe23ade7ad3dd0ca4962bc) `[get]` |
| virtual int | [WagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a48c19b85a004837f24a97febbb5dd953) `[get]` |
| virtual [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Leader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#abbb51fb66272224189d1b9a402445b52) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) `[get]` |
| virtual bool | [CanHaveNavalNavigationCapability](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#aff05772b3ee6b5327f82611eaf3447e7) `[get]` |
| virtual bool | [CanHaveLandNavigationCapability](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a22002cdd26ff95e3c37e72cb9165bd02) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a0acab21c0bfd7b3556a6ac764db8b660)CustomPartyComponent()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.CustomPartyComponent | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *homeSettlement*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, | |  |  | string | *partyMountStringId*, | |  |  | string | *partyHarnessStringId*, | |  |  | float | *customPartyBaseSpeed*, | |  |  | bool | *avoidHostileActions*, | |  |  | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component_1_1_initialization_args.html) | *args*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *leader* = null ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a05a464052a051c065ec1ebc2fba22774)GetDefaultComponentBanner()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.GetDefaultComponentBanner | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#adf1481d58cee4f6b6c5c1d990b6ae4b6)CreateCustomPartyWithPartyTemplate() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.CreateCustomPartyWithPartyTemplate | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, | |  |  | float | *spawnRadius*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *homeSettlement*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *partyTemplate*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, | |  |  | string | *partyMountStringId* = "", | |  |  | string | *partyHarnessStringId* = "", | |  |  | float | *customPartyBaseSpeed* = 0::0f, | |  |  | bool | *avoidHostileActions* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a00060685780b2fd0291a351700afdc03)CreateCustomPartyWithPartyTemplate() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.CreateCustomPartyWithPartyTemplate | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, | |  |  | float | *spawnRadius*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *homeSettlement*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *partyTemplate*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *leader*, | |  |  | string | *partyMountStringId* = "", | |  |  | string | *partyHarnessStringId* = "", | |  |  | float | *customPartyBaseSpeed* = 0::0f, | |  |  | bool | *avoidHostileActions* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a633a01ec54a69cd82bb79d9e01ab3589)CreateCustomPartyWithTroopRoster()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.CreateCustomPartyWithTroopRoster | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, | |  |  | float | *spawnRadius*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *homeSettlement*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troopRoster*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *prisonerRoster*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, | |  |  | string | *partyMountStringId* = "", | |  |  | string | *partyHarnessStringId* = "", | |  |  | float | *customPartyBaseSpeed* = 0::0f, | |  |  | bool | *avoidHostileActions* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#af18b35db33abb05c1cc5cff40b15d24d)ConvertPartyToCustomParty()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.ConvertPartyToCustomParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | *mobileParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *homeSettlement*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, | |  |  | string | *partyMountStringId* = "", | |  |  | string | *partyHarnessStringId* = "", | |  |  | float | *customPartyBaseSpeed* = 0::0f, | |  |  | bool | *avoidHostileActions* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a725891e95bd1f3cd1c6ea6b928c544e9)SetBaseSpeed()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.SetBaseSpeed | ( | float | *speed* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a95d0ce00262221789837483110145b9f)GetMountAndHarnessVisualIdsForPartyIcon()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.GetMountAndHarnessVisualIdsForPartyIcon | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | out string | *mountStringId*, | |  |  | out string | *harnessStringId* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a98cba1b028a000ece5b9a76de58afe11).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#abeb196ecaddff6bb4b5042cf9482c7b8)OnMobilePartySetOnCreation()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.OnMobilePartySetOnCreation | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ab7cf36708f67ec4f7fc68565bc977873).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#ab1bb8d2fd7eea80ebbdf4757536bafe7)OnChangePartyLeader()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.OnChangePartyLeader | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newLeader* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#affc069550111a9db7f22d30096c622a9).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#af8014cf943c96d6a1ae5a0733e829451)CustomPartyBaseSpeed
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.CustomPartyBaseSpeed | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#acbf7a3b21e6114cb6755adfa20978874)AvoidHostileActions
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.AvoidHostileActions | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a80b4444680ffba0f7a16ebc5fe974444)Leader
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.Leader | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#acd0a8d9e31f5f6cd4f40bd918d81fd1b)BaseSpeed
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.BaseSpeed | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a14e9f47e65c4e23d1850741629545125)PartyOwner
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.PartyOwner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a21861a6aaa21bf8ca2bc99ccf1c33146)Name
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a84daa399096b8012c41f6017e943ae1d)HomeSettlement
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent.HomeSettlement | | get |


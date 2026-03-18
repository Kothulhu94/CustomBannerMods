--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html ---

TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent Class ReferenceInherits [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html).

|  |  |
| --- | --- |
| Classes | |
| class | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component_1_1_initialization_args.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a09874f5e2cffbef3fbdd91b2d3204411) () |
| override void | [ClearCachedName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a639cde6d287bf988ad9275c0fff5344b) () |
| override void | [GetMountAndHarnessVisualIdsForPartyIcon](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#ab8e37936cba0a3c736e6635201dda343) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, out string mountStringId, out string harnessStringId) |
| void | [ChangeHomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a06f703b7cbb89417f5813145a3bcfce3) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) newHomeSettlement) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html) | |
| delegate void | [OnPartyComponentCreatedDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ace8920c5d5ebe4eec2959b6a64731126) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty) |
| virtual void | [SetWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ae62c187242165b4f71fefda2db6abe0c) (int newLimit) |
| [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad6823059866c50583270e38735d703ed) () |
| void | [ChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a0c7601e2f1a98b9b6f4d0cc17503f0f1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [ConvertPartyToCaravanParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a9ac582a1e65e8eec4b2d0bd0d9cd44aa) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) caravanOwner, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) spawnSettlement, bool isInitialSpawn=false, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) caravanLeader=null, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) caravanItems=null, bool isElite=false) |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | [CreateCaravanParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aeecdc71e37d69e2af0bb5ebb829ad9fa) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) caravanOwner, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) spawnSettlement, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) templateObject, bool isInitialSpawn=false, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) caravanLeader=null, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) caravanItems=null, bool isElite=false) |
| static void | [TransferCaravanOwnership](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a0d03faef2b966d39ab47d7ae70670ccb) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) caravan, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) homeSettlement) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [CaravanPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a71f80a5603a3c8d1be057da0dd81f337) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) partyLeader, bool isElite, [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component_1_1_initialization_args.html) args) |
| override void | [OnMobilePartySetOnCreation](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a9cb70b1a294a92a910da2364fa658d94) () |
| override void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a601d51d669e207480bd71e56c22ff666) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a7bc25dce99c36206f4c31148640b1a2a) () |
| override void | [OnChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a67e959cdd7a3945658eab9ffe040aca3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |

|  |  |
| --- | --- |
| Properties | |
| Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#ae20511e6f12e944fb25e6d1c9a1f65d8) `[get]` |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [PartyOwner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#af34e23d6665d1609192c97d27045fe60) `[get]` |
| bool | [IsElite](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#ad3d5ece98f116884e5daccbb1b98da77) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a239debc53550702ec2f5f84fffeca26e) `[get]` |
| override bool | [CanHaveNavalNavigationCapability](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a96a42546de71f80ed562a937a03de8e1) `[get]` |
| override bool | [CanHaveLandNavigationCapability](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a5a5c7a8a9e14e707076cd1da418219cc) `[get]` |
| override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) | [HomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#afeecf80b01e654ad0f16d69c5aefe647) `[get]` |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Leader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a593c3d67414091ce90087c15f2e5f081) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a71f80a5603a3c8d1be057da0dd81f337)CaravanPartyComponent()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.CaravanPartyComponent | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *partyLeader*, | |  |  | bool | *isElite*, | |  |  | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component_1_1_initialization_args.html) | *args* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a09874f5e2cffbef3fbdd91b2d3204411)GetDefaultComponentBanner()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.GetDefaultComponentBanner | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a9cb70b1a294a92a910da2364fa658d94)OnMobilePartySetOnCreation()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.OnMobilePartySetOnCreation | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ab7cf36708f67ec4f7fc68565bc977873).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a601d51d669e207480bd71e56c22ff666)OnInitialize()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a5f3bc1ed376a3dd658ca5fadca14df39).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a7bc25dce99c36206f4c31148640b1a2a)OnFinalize()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#aa9ca4a2d81beda9e861b8f4bd67348bb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a9ac582a1e65e8eec4b2d0bd0d9cd44aa)ConvertPartyToCaravanParty()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.ConvertPartyToCaravanParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | *mobileParty*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *caravanOwner*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) | *spawnSettlement*, | |  |  | bool | *isInitialSpawn* = false, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *caravanLeader* = null, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *caravanItems* = null, | |  |  | bool | *isElite* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a67e959cdd7a3945658eab9ffe040aca3)OnChangePartyLeader()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.OnChangePartyLeader | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newLeader* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#affc069550111a9db7f22d30096c622a9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a639cde6d287bf988ad9275c0fff5344b)ClearCachedName()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.ClearCachedName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a55d879bb34b02f27924dc8eae6f4bef0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aeecdc71e37d69e2af0bb5ebb829ad9fa)CreateCaravanParty()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.CreateCaravanParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *caravanOwner*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) | *spawnSettlement*, | |  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *templateObject*, | |  |  | bool | *isInitialSpawn* = false, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *caravanLeader* = null, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *caravanItems* = null, | |  |  | bool | *isElite* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#ab8e37936cba0a3c736e6635201dda343)GetMountAndHarnessVisualIdsForPartyIcon()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.GetMountAndHarnessVisualIdsForPartyIcon | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | out string | *mountStringId*, | |  |  | out string | *harnessStringId* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a98cba1b028a000ece5b9a76de58afe11).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a0d03faef2b966d39ab47d7ae70670ccb)TransferCaravanOwnership()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.TransferCaravanOwnership | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | *caravan*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) | *homeSettlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a06f703b7cbb89417f5813145a3bcfce3)ChangeHomeSettlement()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.ChangeHomeSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) | *newHomeSettlement* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4)Settlement
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Settlement TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.Settlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#ae20511e6f12e944fb25e6d1c9a1f65d8)Owner
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.Owner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#af34e23d6665d1609192c97d27045fe60)PartyOwner
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.PartyOwner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#ad3d5ece98f116884e5daccbb1b98da77)IsElite
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.IsElite | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a239debc53550702ec2f5f84fffeca26e)Name
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a96a42546de71f80ed562a937a03de8e1)CanHaveNavalNavigationCapability
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.CanHaveNavalNavigationCapability | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a5a5c7a8a9e14e707076cd1da418219cc)CanHaveLandNavigationCapability
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.CanHaveLandNavigationCapability | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#afeecf80b01e654ad0f16d69c5aefe647)HomeSettlement
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#aaa869af4881a7d6c4eca77cd43ce20f4) TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.HomeSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a593c3d67414091ce90087c15f2e5f081)Leader
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent.Leader | | get |


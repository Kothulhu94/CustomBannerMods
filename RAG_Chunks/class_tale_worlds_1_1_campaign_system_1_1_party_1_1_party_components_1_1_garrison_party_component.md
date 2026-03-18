--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html ---

TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent Class ReferenceInherits [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html).

|  |  |
| --- | --- |
| Classes | |
| class | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component_1_1_initialization_args.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#aa05cdbf86999b9208c8145b6bbfe64b7) () |
| override void | [SetWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a355dea782015f28f8f6241927055fd66) (int newLimit) |
| override void | [ClearCachedName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#afbd34d0fa7280e3e3ffb1a23c39272c0) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html) | |
| delegate void | [OnPartyComponentCreatedDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ace8920c5d5ebe4eec2959b6a64731126) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty) |
| [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad6823059866c50583270e38735d703ed) () |
| void | [ChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a0c7601e2f1a98b9b6f4d0cc17503f0f1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |
| virtual void | [GetMountAndHarnessVisualIdsForPartyIcon](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a98cba1b028a000ece5b9a76de58afe11) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, out string mountStringId, out string harnessStringId) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | [CreateGarrisonParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a9c8d50dd17b1dca0a7c5b799eee9d12f) (string stringId, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a101af76f97bcc632b3a002f3d751e0dc) settlement) |
| static void | [ConvertPartyToGarrisonParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a067a69a5a5c7a601a90f23dd163bcc5b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a101af76f97bcc632b3a002f3d751e0dc) settlement) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [GarrisonPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#acd6d20022de50ba122c5031386f22d93) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a101af76f97bcc632b3a002f3d751e0dc) settlement, [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component_1_1_initialization_args.html) args) |
| override void | [OnMobilePartySetOnCreation](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#acc4caae1ad5f0e30596537564ec88047) () |
| override void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a2e382abca2ceb8ea34e2183ed83c9af8) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a0cc12b2aecca4af3c116c9052f569b88) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html) | |
| virtual void | [OnChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#affc069550111a9db7f22d30096c622a9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |

|  |  |
| --- | --- |
| Properties | |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [PartyOwner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a1827c33a2745d90a23d5fc0176a26f05) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a85e212d363e08f0b31cd463abba3d628) `[get]` |
| override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a101af76f97bcc632b3a002f3d751e0dc) | [HomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#adc35f6fbab061d7a74f8ce34a757f304) `[get]` |
| override int | [WagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a8ceef0a24d833a884a76b3cd501ccf5c) `[get]` |
| override bool | [CanHaveNavalNavigationCapability](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a1dce6fbf2f569c6e6b75b7f2d06d5c6b) `[get]` |
| Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a101af76f97bcc632b3a002f3d751e0dc) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#acd6d20022de50ba122c5031386f22d93)GarrisonPartyComponent()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.GarrisonPartyComponent | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a101af76f97bcc632b3a002f3d751e0dc) | *settlement*, | |  |  | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component_1_1_initialization_args.html) | *args* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a9c8d50dd17b1dca0a7c5b799eee9d12f)CreateGarrisonParty()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.CreateGarrisonParty | ( | string | *stringId*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a101af76f97bcc632b3a002f3d751e0dc) | *settlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a067a69a5a5c7a601a90f23dd163bcc5b)ConvertPartyToGarrisonParty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.ConvertPartyToGarrisonParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | *mobileParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a101af76f97bcc632b3a002f3d751e0dc) | *settlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#aa05cdbf86999b9208c8145b6bbfe64b7)GetDefaultComponentBanner()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.GetDefaultComponentBanner | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a355dea782015f28f8f6241927055fd66)SetWagePaymentLimit()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.SetWagePaymentLimit | ( | int | *newLimit* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ae62c187242165b4f71fefda2db6abe0c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#acc4caae1ad5f0e30596537564ec88047)OnMobilePartySetOnCreation()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.OnMobilePartySetOnCreation | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ab7cf36708f67ec4f7fc68565bc977873).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a2e382abca2ceb8ea34e2183ed83c9af8)OnInitialize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a5f3bc1ed376a3dd658ca5fadca14df39).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a0cc12b2aecca4af3c116c9052f569b88)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#aa9ca4a2d81beda9e861b8f4bd67348bb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#afbd34d0fa7280e3e3ffb1a23c39272c0)ClearCachedName()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.ClearCachedName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a55d879bb34b02f27924dc8eae6f4bef0).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a1827c33a2745d90a23d5fc0176a26f05)PartyOwner
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.PartyOwner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a85e212d363e08f0b31cd463abba3d628)Name
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#adc35f6fbab061d7a74f8ce34a757f304)HomeSettlement
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a101af76f97bcc632b3a002f3d751e0dc) TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.HomeSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a8ceef0a24d833a884a76b3cd501ccf5c)WagePaymentLimit
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.WagePaymentLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a1dce6fbf2f569c6e6b75b7f2d06d5c6b)CanHaveNavalNavigationCapability
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.CanHaveNavalNavigationCapability | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a101af76f97bcc632b3a002f3d751e0dc)Settlement
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Settlement TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent.Settlement | | get |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html ---

TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent Class ReferenceInherits [TaleWorlds.CampaignSystem.Party.PartyComponents.WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html).

|  |  |
| --- | --- |
| Classes | |
| class | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component_1_1_initialization_args.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetHomeHideout](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a679457df7a13a74b52681f0f4e320ab3) ([Hideout](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a429d57af493993d710994ae4c6298a19) hideout) |
| override void | [ClearCachedName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a644dc7a73650130dc39fed3cbb391a24) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html) | |
| override [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#ac292f084643b1d8521c5aea9a993e2d0) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html) | |
| delegate void | [OnPartyComponentCreatedDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ace8920c5d5ebe4eec2959b6a64731126) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty) |
| virtual void | [SetWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ae62c187242165b4f71fefda2db6abe0c) (int newLimit) |
| [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad6823059866c50583270e38735d703ed) () |
| void | [ChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a0c7601e2f1a98b9b6f4d0cc17503f0f1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |
| virtual void | [GetMountAndHarnessVisualIdsForPartyIcon](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a98cba1b028a000ece5b9a76de58afe11) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, out string mountStringId, out string harnessStringId) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | [CreateBanditParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#aecb0120b22dc66a06e49fb0568fab286) (string stringId, [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#ae4d27c2dd11d2dbef17bdc694b2392ec) clan, [Hideout](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a429d57af493993d710994ae4c6298a19) hideout, bool isBossParty, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) pt, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) initialPosition) |
| static void | [ConvertPartyToBanditParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a366ea2b5e612a87d65fdcd122c68b22a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty, [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#ae4d27c2dd11d2dbef17bdc694b2392ec) clan, [Hideout](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a429d57af493993d710994ae4c6298a19) hideout, bool isBossParty) |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | [CreateLooterParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a93ab72d640e62abfc36786986b6ea5f5) (string stringId, [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#ae4d27c2dd11d2dbef17bdc694b2392ec) clan, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) relatedSettlement, bool isBossParty, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) pt, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) initialPosition) |
| static void | [ConvertPartyToLooterParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a4548befce8c159239130365dad3d43a2) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty, [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#ae4d27c2dd11d2dbef17bdc694b2392ec) clan, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) relatedSettlement) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a093bc079628f9ebf49ac24b5b72a892d) ([Hideout](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a429d57af493993d710994ae4c6298a19) hideout, bool isBossParty, [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component_1_1_initialization_args.html) args) |
|  | [BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#ac0f01f2b56f8322eaf3bf90d24c37786) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) relatedSettlement, [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component_1_1_initialization_args.html) args) |
| override void | [OnMobilePartySetOnCreation](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#afe5a71b26972cdd3c21f3d537eee89e8) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html) | |
| override void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#a2a5b3a961d2b017a4af3567a5dc74a51) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#a2f647e1ad1fcb0c9b2fb6b455cd10349) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html) | |
| virtual void | [OnChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#affc069550111a9db7f22d30096c622a9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |

|  |  |
| --- | --- |
| Properties | |
| Hideout | [Hideout](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a429d57af493993d710994ae4c6298a19) `[get]` |
| bool | [IsBossParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a0ab60ef85f8848ad72600d4f5eabd3ee) `[get]` |
| override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [HomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a91da4850efc9b7396ffdd1bf68f0d7a6) `[get]` |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [PartyOwner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a276dfc33ba09898eef1a95cf903ed44f) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a4404575c36097e5259662056eccb9f9e) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html) | |
| Clan | [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#ae4d27c2dd11d2dbef17bdc694b2392ec) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a093bc079628f9ebf49ac24b5b72a892d)BanditPartyComponent() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.BanditPartyComponent | ( | [Hideout](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a429d57af493993d710994ae4c6298a19) | *hideout*, | |  |  | bool | *isBossParty*, | |  |  | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component_1_1_initialization_args.html) | *args* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#ac0f01f2b56f8322eaf3bf90d24c37786)BanditPartyComponent() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.BanditPartyComponent | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *relatedSettlement*, | |  |  | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component_1_1_initialization_args.html) | *args* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#aecb0120b22dc66a06e49fb0568fab286)CreateBanditParty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.CreateBanditParty | ( | string | *stringId*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#ae4d27c2dd11d2dbef17bdc694b2392ec) | *clan*, | |  |  | [Hideout](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a429d57af493993d710994ae4c6298a19) | *hideout*, | |  |  | bool | *isBossParty*, | |  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *pt*, | |  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *initialPosition* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a366ea2b5e612a87d65fdcd122c68b22a)ConvertPartyToBanditParty()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.ConvertPartyToBanditParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | *mobileParty*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#ae4d27c2dd11d2dbef17bdc694b2392ec) | *clan*, | |  |  | [Hideout](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a429d57af493993d710994ae4c6298a19) | *hideout*, | |  |  | bool | *isBossParty* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a93ab72d640e62abfc36786986b6ea5f5)CreateLooterParty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.CreateLooterParty | ( | string | *stringId*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#ae4d27c2dd11d2dbef17bdc694b2392ec) | *clan*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *relatedSettlement*, | |  |  | bool | *isBossParty*, | |  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *pt*, | |  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *initialPosition* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a4548befce8c159239130365dad3d43a2)ConvertPartyToLooterParty()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.ConvertPartyToLooterParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | *mobileParty*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#ae4d27c2dd11d2dbef17bdc694b2392ec) | *clan*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *relatedSettlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a679457df7a13a74b52681f0f4e320ab3)SetHomeHideout()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.SetHomeHideout | ( | [Hideout](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a429d57af493993d710994ae4c6298a19) | *hideout* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a644dc7a73650130dc39fed3cbb391a24)ClearCachedName()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.ClearCachedName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a55d879bb34b02f27924dc8eae6f4bef0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#afe5a71b26972cdd3c21f3d537eee89e8)OnMobilePartySetOnCreation()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.OnMobilePartySetOnCreation | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ab7cf36708f67ec4f7fc68565bc977873).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a429d57af493993d710994ae4c6298a19)Hideout
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Hideout TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.Hideout | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a0ab60ef85f8848ad72600d4f5eabd3ee)IsBossParty
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.IsBossParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a91da4850efc9b7396ffdd1bf68f0d7a6)HomeSettlement
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.HomeSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a276dfc33ba09898eef1a95cf903ed44f)PartyOwner
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.PartyOwner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a4404575c36097e5259662056eccb9f9e)Name
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent.Name | | get |


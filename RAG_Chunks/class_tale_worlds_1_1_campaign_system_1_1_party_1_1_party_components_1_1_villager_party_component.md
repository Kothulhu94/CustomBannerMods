--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html ---

TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent Class ReferenceInherits [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html).

|  |  |
| --- | --- |
| Classes | |
| class | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component_1_1_initialization_args.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a5136eb8d3bbe760f1c17237a324498eb) () |
| override void | [ClearCachedName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a0eead5c15c2e6e93118e047ad588d307) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html) | |
| delegate void | [OnPartyComponentCreatedDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ace8920c5d5ebe4eec2959b6a64731126) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty) |
| virtual void | [SetWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ae62c187242165b4f71fefda2db6abe0c) (int newLimit) |
| [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad6823059866c50583270e38735d703ed) () |
| void | [ChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a0c7601e2f1a98b9b6f4d0cc17503f0f1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |
| virtual void | [GetMountAndHarnessVisualIdsForPartyIcon](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a98cba1b028a000ece5b9a76de58afe11) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, out string mountStringId, out string harnessStringId) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | [CreateVillagerParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a7e006aee1843e5a90d5a4a69f5b02357) (string stringId, [Village](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ae4f833f27497b517807b3a5627548f26) village) |
| static void | [ConvertPartyToVillagerParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a23a9ced2543e983a58584dbdc407d23d) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty, [Village](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ae4f833f27497b517807b3a5627548f26) village) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [VillagerPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a005d54f5af43de0a5e639fb02c228d5c) ([Village](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ae4f833f27497b517807b3a5627548f26) village, [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component_1_1_initialization_args.html) args) |
| override void | [OnMobilePartySetOnCreation](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ad448e616630bd481f2a06c0b6ec6cc86) () |
| override void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a1a8a55c0d2b0f9586830fdf210c7c007) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ace26b43795b6796c5bb3e4b293c41f27) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html) | |
| virtual void | [OnChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#affc069550111a9db7f22d30096c622a9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |

|  |  |
| --- | --- |
| Protected Attributes | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [\_cachedName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a2513827f94c41b3c756bb11140e7e125) |

|  |  |
| --- | --- |
| Properties | |
| Village | [Village](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ae4f833f27497b517807b3a5627548f26) `[get]` |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [PartyOwner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a64da6610d61a656b38ad547dd1b53f45) `[get]` |
| override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [HomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ac5b7dc9bddf744e947e8b259cc0a8fa7) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#acab217706881bb6a7764860f8e0ad518) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a005d54f5af43de0a5e639fb02c228d5c)VillagerPartyComponent()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.VillagerPartyComponent | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ae4f833f27497b517807b3a5627548f26) | *village*, | |  |  | [InitializationArgs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component_1_1_initialization_args.html) | *args* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a7e006aee1843e5a90d5a4a69f5b02357)CreateVillagerParty()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.CreateVillagerParty | ( | string | *stringId*, | |  |  | [Village](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ae4f833f27497b517807b3a5627548f26) | *village* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a23a9ced2543e983a58584dbdc407d23d)ConvertPartyToVillagerParty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.ConvertPartyToVillagerParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | *mobileParty*, | |  |  | [Village](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ae4f833f27497b517807b3a5627548f26) | *village* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a5136eb8d3bbe760f1c17237a324498eb)GetDefaultComponentBanner()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.GetDefaultComponentBanner | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ad448e616630bd481f2a06c0b6ec6cc86)OnMobilePartySetOnCreation()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.OnMobilePartySetOnCreation | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ab7cf36708f67ec4f7fc68565bc977873).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a1a8a55c0d2b0f9586830fdf210c7c007)OnInitialize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a5f3bc1ed376a3dd658ca5fadca14df39).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ace26b43795b6796c5bb3e4b293c41f27)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#aa9ca4a2d81beda9e861b8f4bd67348bb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a0eead5c15c2e6e93118e047ad588d307)ClearCachedName()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.ClearCachedName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a55d879bb34b02f27924dc8eae6f4bef0).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a2513827f94c41b3c756bb11140e7e125)\_cachedName
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.\_cachedName | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ae4f833f27497b517807b3a5627548f26)Village
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Village TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.Village | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a64da6610d61a656b38ad547dd1b53f45)PartyOwner
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.PartyOwner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ac5b7dc9bddf744e947e8b259cc0a8fa7)HomeSettlement
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.HomeSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#acab217706881bb6a7764860f8e0ad518)Name
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent.Name | | get |


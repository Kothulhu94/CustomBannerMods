--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html ---

TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent Class ReferenceabstractInherited by [TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html), [TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html), [TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html), [TaleWorlds.CampaignSystem.Party.PartyComponents.MilitiaPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_militia_party_component.html), [TaleWorlds.CampaignSystem.Party.PartyComponents.PatrolPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_patrol_party_component.html), [TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html), and [TaleWorlds.CampaignSystem.Party.PartyComponents.WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnPartyComponentCreatedDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ace8920c5d5ebe4eec2959b6a64731126) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) mobileParty) |
| virtual void | [SetWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ae62c187242165b4f71fefda2db6abe0c) (int newLimit) |
| [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad6823059866c50583270e38735d703ed) () |
| virtual void | [ClearCachedName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a55d879bb34b02f27924dc8eae6f4bef0) () |
| void | [ChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a0c7601e2f1a98b9b6f4d0cc17503f0f1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |
| virtual void | [GetMountAndHarnessVisualIdsForPartyIcon](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a98cba1b028a000ece5b9a76de58afe11) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, out string mountStringId, out string harnessStringId) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual void | [OnMobilePartySetOnCreation](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ab7cf36708f67ec4f7fc68565bc977873) () |
| virtual void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a5f3bc1ed376a3dd658ca5fadca14df39) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#aa9ca4a2d81beda9e861b8f4bd67348bb) () |
| virtual void | [OnChangePartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#affc069550111a9db7f22d30096c622a9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |

|  |  |
| --- | --- |
| Properties | |
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

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ace8920c5d5ebe4eec2959b6a64731126)OnPartyComponentCreatedDelegate()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.OnPartyComponentCreatedDelegate | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ae62c187242165b4f71fefda2db6abe0c)SetWagePaymentLimit()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.SetWagePaymentLimit | ( | int | *newLimit* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a355dea782015f28f8f6241927055fd66), and [TaleWorlds.CampaignSystem.Party.PartyComponents.LordPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_lord_party_component.html#a5efc9c9e28c7e708b2a48781444c7a81).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad6823059866c50583270e38735d703ed)GetDefaultComponentBanner()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [Banner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118) TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.GetDefaultComponentBanner | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ab7cf36708f67ec4f7fc68565bc977873)OnMobilePartySetOnCreation()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.OnMobilePartySetOnCreation | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#afe5a71b26972cdd3c21f3d537eee89e8), [TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a9cb70b1a294a92a910da2364fa658d94), [TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#abeb196ecaddff6bb4b5042cf9482c7b8), [TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#acc4caae1ad5f0e30596537564ec88047), [TaleWorlds.CampaignSystem.Party.PartyComponents.LordPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_lord_party_component.html#a3b6fd2d5647ebcf56bf70c259be31889), [TaleWorlds.CampaignSystem.Party.PartyComponents.MilitiaPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_militia_party_component.html#ac78f353889394a8077ebbaefdf9ff49a), [TaleWorlds.CampaignSystem.Party.PartyComponents.PatrolPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_patrol_party_component.html#a8965f0626272d1bf34ec5b55e47307cc), and [TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ad448e616630bd481f2a06c0b6ec6cc86).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a5f3bc1ed376a3dd658ca5fadca14df39)OnInitialize()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a601d51d669e207480bd71e56c22ff666), [TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a2e382abca2ceb8ea34e2183ed83c9af8), [TaleWorlds.CampaignSystem.Party.PartyComponents.MilitiaPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_militia_party_component.html#a5715ad922104568520a66d28c34ba0ca), [TaleWorlds.CampaignSystem.Party.PartyComponents.PatrolPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_patrol_party_component.html#ada50ba5af21138e1a5d3a022ee903256), [TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a1a8a55c0d2b0f9586830fdf210c7c007), and [TaleWorlds.CampaignSystem.Party.PartyComponents.WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#a2a5b3a961d2b017a4af3567a5dc74a51).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#aa9ca4a2d81beda9e861b8f4bd67348bb)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a7bc25dce99c36206f4c31148640b1a2a), [TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#a0cc12b2aecca4af3c116c9052f569b88), [TaleWorlds.CampaignSystem.Party.PartyComponents.MilitiaPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_militia_party_component.html#ab3f836d46bfd7b96c805912ec115412b), [TaleWorlds.CampaignSystem.Party.PartyComponents.PatrolPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_patrol_party_component.html#a30d5b4b4360e886b8fee9f9cb018a733), [TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#ace26b43795b6796c5bb3e4b293c41f27), and [TaleWorlds.CampaignSystem.Party.PartyComponents.WarPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_war_party_component.html#a2f647e1ad1fcb0c9b2fb6b455cd10349).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a55d879bb34b02f27924dc8eae6f4bef0)ClearCachedName()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.ClearCachedName | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Party.PartyComponents.BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html#a644dc7a73650130dc39fed3cbb391a24), [TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a639cde6d287bf988ad9275c0fff5344b), [TaleWorlds.CampaignSystem.Party.PartyComponents.GarrisonPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_garrison_party_component.html#afbd34d0fa7280e3e3ffb1a23c39272c0), [TaleWorlds.CampaignSystem.Party.PartyComponents.LordPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_lord_party_component.html#a3a115bc0186cabcd93a6f044983704c4), [TaleWorlds.CampaignSystem.Party.PartyComponents.MilitiaPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_militia_party_component.html#a22b3b04316482ffcd9d939a8ce13b9f1), and [TaleWorlds.CampaignSystem.Party.PartyComponents.VillagerPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_villager_party_component.html#a0eead5c15c2e6e93118e047ad588d307).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a0c7601e2f1a98b9b6f4d0cc17503f0f1)ChangePartyLeader()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.ChangePartyLeader | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newLeader* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#affc069550111a9db7f22d30096c622a9)OnChangePartyLeader()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.OnChangePartyLeader | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newLeader* | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#a67e959cdd7a3945658eab9ffe040aca3), [TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#ab1bb8d2fd7eea80ebbdf4757536bafe7), and [TaleWorlds.CampaignSystem.Party.PartyComponents.LordPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_lord_party_component.html#a48a60939949d03ae89286c5b8a9b6661).

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a98cba1b028a000ece5b9a76de58afe11)GetMountAndHarnessVisualIdsForPartyIcon()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.GetMountAndHarnessVisualIdsForPartyIcon | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | out string | *mountStringId*, | |  |  | out string | *harnessStringId* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Party.PartyComponents.CaravanPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html#ab8e37936cba0a3c736e6635201dda343), and [TaleWorlds.CampaignSystem.Party.PartyComponents.CustomPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_custom_party_component.html#a95d0ce00262221789837483110145b9f).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad5cbd620a7b099133277449ef021ba32)MobileParty
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MobileParty TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.MobileParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a374e9b0633c1f43e9120327d13a2923d)Party
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.Party | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a9a8f5d1ff3b5944988935eba5d5f90a2)PartyOwner
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.PartyOwner | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a16d9961799d5d1a66bf2fbf5854e53c8)Name
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.Name | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#abf95312007a55e73813a17958749e49b)HomeSettlement
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.HomeSettlement | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ac1a519ce62fe23ade7ad3dd0ca4962bc)AvoidHostileActions
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.AvoidHostileActions | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a48c19b85a004837f24a97febbb5dd953)WagePaymentLimit
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual int TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.WagePaymentLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#abbb51fb66272224189d1b9a402445b52)Leader
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.Leader | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#ad911c760c9b055a63e87364ded329118)Banner
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.Banner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#aff05772b3ee6b5327f82611eaf3447e7)CanHaveNavalNavigationCapability
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.CanHaveNavalNavigationCapability | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_party_component.html#a22002cdd26ff95e3c37e72cb9165bd02)CanHaveLandNavigationCapability
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.CampaignSystem.Party.PartyComponents.PartyComponent.CanHaveLandNavigationCapability | | get |


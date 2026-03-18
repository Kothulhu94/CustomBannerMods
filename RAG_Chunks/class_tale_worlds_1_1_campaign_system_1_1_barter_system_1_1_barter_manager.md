--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html ---

TaleWorlds.CampaignSystem.BarterSystem.BarterManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate bool | [BarterContextInitializer](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#ac2c4186d5c4acb484af1381bc4a309dc) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) barterable, [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) args, object obj=null) |
| delegate void | [BarterCloseEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a97d1b5e493b90a6f1f07cad1ef2c0323) () |
| delegate void | [BarterBeginEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a450571dd3ea6e453c71800d9ee4f4651) ([BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) args) |
|  | [BarterManager](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#ac4e9b2b77efc1d1bb99bccee29f99270) () |
| void | [BeginPlayerBarter](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a85db3e584a30b7ce5cb78e9cd762f835) ([BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) args) |
| void | [StartBarterOffer](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#aecee4dd021e996d1d5c2e27256ed3a66) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) offerer, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) other, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) offererParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) otherParty, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) beneficiaryOfOtherHero=null, [BarterContextInitializer](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#ac2c4186d5c4acb484af1381bc4a309dc) InitContext=null, int persuasionCostReduction=0, bool isAIBarter=false, IEnumerable< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > defaultBarterables=null) |
| void | [ExecuteAiBarter](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#acd2d9ef9f4d3056ab77c65c476f6b167) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) faction1Hero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) faction2Hero, [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) barterable) |
| void | [ExecuteAiBarter](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a8692f6e9818e9006ed173f5742eb6a62) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) faction1Hero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) faction2Hero, IEnumerable< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > baseBarterables) |
| void | [ExecuteAIBarter](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#aacb4de69156a563ab669363698cedf88) ([BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) barterData, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) faction1Hero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) faction2Hero) |
| void | [Close](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a6b01799a2f69aff6b4cb50f9a406f3e7) () |
| bool | [IsOfferAcceptable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#aebb5153400a8d78ed380369e7fa015fa) ([BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) args, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| float | [GetOfferValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a774496766a3e65f1c4c9bc94569eb4a2) ([BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) barterData, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| float | [GetOfferValue](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a8d3cfcef6ecb5a84af383b2432f6f065) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) selfHero, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) selfParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) offererParty, IEnumerable< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > offeredBarters) |
| void | [ApplyAndFinalizePlayerBarter](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a260078ca8910cfaff05ed2d2d7d899c9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) offererHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero, [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) barterData) |
| void | [CancelAndFinalizePlayerBarter](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a73c36981fa30698e40e52ae4cc7bcd6d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) offererHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero, [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) barterData) |
| bool | [CanPlayerBarterWithHero](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a0a3175720f417114082a1f1a85405e72) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| bool | [InitializeMarriageBarterContext](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a6fb599739c912615d3bd289b986d4547) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) barterable, [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) args, object obj) |
| bool | [InitializeJoinFactionBarterContext](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a3b58481f66d46d94a684a69aacf9e29b) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) barterable, [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) args, object obj) |
| bool | [InitializeMakePeaceBarterContext](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a8a7ebb3d340a1b9116087c47ac6ea76f) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) barterable, [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) args, object obj) |
| bool | [InitializeSafePassageBarterContext](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#af73409bc12c13a3266ef1cb47cc798af) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) barterable, [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) args, object obj) |

|  |  |
| --- | --- |
| Public Attributes | |
| [BarterCloseEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a97d1b5e493b90a6f1f07cad1ef2c0323) | [Closed](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a33e245e5b1baaf120ed9d106b5b0e1ea) |
| [BarterBeginEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a450571dd3ea6e453c71800d9ee4f4651) | [BarterBegin](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a2b9368b6f3801ed8e1ec83ab9a6f87e4) |

|  |  |
| --- | --- |
| Properties | |
| static [BarterManager](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#ac4e9b2b77efc1d1bb99bccee29f99270) | [Instance](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a1cb0bbcacb5e1ff0c061457dcaf9ec77) `[get]` |
| bool | [LastBarterIsAccepted](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a0c754162d959c9d2b3b6cce4de422ca8) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#ac4e9b2b77efc1d1bb99bccee29f99270)BarterManager()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.BarterSystem.BarterManager.BarterManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#ac2c4186d5c4acb484af1381bc4a309dc)BarterContextInitializer()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate bool TaleWorlds.CampaignSystem.BarterSystem.BarterManager.BarterContextInitializer | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | *barterable*, |
|  |  | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *args*, |
|  |  | object | *obj* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a97d1b5e493b90a6f1f07cad1ef2c0323)BarterCloseEventDelegate()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.BarterSystem.BarterManager.BarterCloseEventDelegate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a450571dd3ea6e453c71800d9ee4f4651)BarterBeginEventDelegate()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.BarterSystem.BarterManager.BarterBeginEventDelegate | ( | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *args* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a85db3e584a30b7ce5cb78e9cd762f835)BeginPlayerBarter()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.BarterManager.BeginPlayerBarter | ( | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *args* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#aecee4dd021e996d1d5c2e27256ed3a66)StartBarterOffer()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.BarterManager.StartBarterOffer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *offerer*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *other*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *offererParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *otherParty*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *beneficiaryOfOtherHero* = null, |
|  |  | [BarterContextInitializer](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#ac2c4186d5c4acb484af1381bc4a309dc) | *InitContext* = null, |
|  |  | int | *persuasionCostReduction* = 0, |
|  |  | bool | *isAIBarter* = false, |
|  |  | IEnumerable< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > | *defaultBarterables* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#acd2d9ef9f4d3056ab77c65c476f6b167)ExecuteAiBarter() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.BarterManager.ExecuteAiBarter | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *faction1Hero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *faction2Hero*, |
|  |  | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | *barterable* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a8692f6e9818e9006ed173f5742eb6a62)ExecuteAiBarter() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.BarterManager.ExecuteAiBarter | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *faction1Hero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *faction2Hero*, |
|  |  | IEnumerable< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > | *baseBarterables* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#aacb4de69156a563ab669363698cedf88)ExecuteAIBarter()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.BarterManager.ExecuteAIBarter | ( | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *barterData*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *faction1Hero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *faction2Hero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a6b01799a2f69aff6b4cb50f9a406f3e7)Close()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.BarterManager.Close | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#aebb5153400a8d78ed380369e7fa015fa)IsOfferAcceptable()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.BarterSystem.BarterManager.IsOfferAcceptable | ( | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *args*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a774496766a3e65f1c4c9bc94569eb4a2)GetOfferValueForFaction()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.BarterSystem.BarterManager.GetOfferValueForFaction | ( | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *barterData*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a8d3cfcef6ecb5a84af383b2432f6f065)GetOfferValue()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.BarterSystem.BarterManager.GetOfferValue | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *selfHero*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *selfParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *offererParty*, |
|  |  | IEnumerable< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > | *offeredBarters* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a260078ca8910cfaff05ed2d2d7d899c9)ApplyAndFinalizePlayerBarter()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.BarterManager.ApplyAndFinalizePlayerBarter | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *offererHero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherHero*, |
|  |  | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *barterData* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a73c36981fa30698e40e52ae4cc7bcd6d)CancelAndFinalizePlayerBarter()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.BarterManager.CancelAndFinalizePlayerBarter | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *offererHero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherHero*, |
|  |  | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *barterData* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a0a3175720f417114082a1f1a85405e72)CanPlayerBarterWithHero()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.BarterSystem.BarterManager.CanPlayerBarterWithHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a6fb599739c912615d3bd289b986d4547)InitializeMarriageBarterContext()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.BarterSystem.BarterManager.InitializeMarriageBarterContext | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | *barterable*, |
|  |  | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *args*, |
|  |  | object | *obj* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a3b58481f66d46d94a684a69aacf9e29b)InitializeJoinFactionBarterContext()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.BarterSystem.BarterManager.InitializeJoinFactionBarterContext | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | *barterable*, |
|  |  | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *args*, |
|  |  | object | *obj* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a8a7ebb3d340a1b9116087c47ac6ea76f)InitializeMakePeaceBarterContext()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.BarterSystem.BarterManager.InitializeMakePeaceBarterContext | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | *barterable*, |
|  |  | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *args*, |
|  |  | object | *obj* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#af73409bc12c13a3266ef1cb47cc798af)InitializeSafePassageBarterContext()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.BarterSystem.BarterManager.InitializeSafePassageBarterContext | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | *barterable*, |
|  |  | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *args*, |
|  |  | object | *obj* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a33e245e5b1baaf120ed9d106b5b0e1ea)Closed
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BarterCloseEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a97d1b5e493b90a6f1f07cad1ef2c0323) TaleWorlds.CampaignSystem.BarterSystem.BarterManager.Closed |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a2b9368b6f3801ed8e1ec83ab9a6f87e4)BarterBegin
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BarterBeginEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a450571dd3ea6e453c71800d9ee4f4651) TaleWorlds.CampaignSystem.BarterSystem.BarterManager.BarterBegin |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a1cb0bbcacb5e1ff0c061457dcaf9ec77)Instance
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BarterManager](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#ac4e9b2b77efc1d1bb99bccee29f99270) TaleWorlds.CampaignSystem.BarterSystem.BarterManager.Instance | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#a0c754162d959c9d2b3b6cce4de422ca8)LastBarterIsAccepted
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.BarterSystem.BarterManager.LastBarterIsAccepted | | get |


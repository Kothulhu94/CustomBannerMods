--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html ---

TaleWorlds.CampaignSystem.BarterSystem.BarterData Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a515c8a99eb34dab734618de8825c0789) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) offerer, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) other, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) offererParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) otherParty, [BarterManager.BarterContextInitializer](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#ac2c4186d5c4acb484af1381bc4a309dc) contextInitializer=null, int persuasionCostReduction=0, bool isAiBarter=false) |
| void | [AddBarterable< T >](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#ab9807bd31c99ff1aa9ce3de82faa4292) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) barterable, bool isContextDependent=false) |
| void | [AddBarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#acc546d023bb5855fd7d8ac8ccddc6ac9) ([BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) barterGroup) |
| List< [BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) > | [GetBarterGroups](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a10cdde75147b5b9c236e7f52646beda7) () |
| List< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > | [GetBarterables](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#aa4ba5688403699585ead1abc1530f041) () |
| [BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) | [GetBarterGroup< T >](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a29b7fccbf25298fedc52b7d3cd156751) () |
| List< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > | [GetOfferedBarterables](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a0f630a52bacbf7908eb3ca3b9b9664dd) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [OffererHero](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a70192cdc256666a0c988b186aafa1713) |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [OtherHero](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a51950247b352be49c50dcd2cc2c37cb0) |
| readonly [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [OffererParty](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a0009abf5dcc5b0de7fad770a76e4f7c0) |
| readonly [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [OtherParty](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#aeee01b617e34f072df1cba916d21706d) |
| readonly [BarterManager.BarterContextInitializer](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#ac2c4186d5c4acb484af1381bc4a309dc) | [ContextInitializer](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#af565c4b49aef0d6e735db2beb6688afe) |
| readonly int | [PersuasionCostReduction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a3f9449d35fb1fe8d6db3a0ac669de091) |

|  |  |
| --- | --- |
| Properties | |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [OffererMapFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#ae2e3e2fc6eed2675d4f531b1acd64753) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [OtherMapFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a421705dd3e01c2e6e9eb17f274f6ccc7) `[get]` |
| bool | [IsAiBarter](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#acf302241d0ee59e04a8335d6ff8444af) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a515c8a99eb34dab734618de8825c0789)BarterData()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.BarterSystem.BarterData.BarterData | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *offerer*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *other*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *offererParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *otherParty*, |
|  |  | [BarterManager.BarterContextInitializer](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#ac2c4186d5c4acb484af1381bc4a309dc) | *contextInitializer* = null, |
|  |  | int | *persuasionCostReduction* = 0, |
|  |  | bool | *isAiBarter* = false ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#ab9807bd31c99ff1aa9ce3de82faa4292)AddBarterable< T >()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.BarterData.AddBarterable< T > | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | *barterable*, |
|  |  | bool | *isContextDependent* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#acc546d023bb5855fd7d8ac8ccddc6ac9)AddBarterGroup()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.BarterData.AddBarterGroup | ( | [BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) | *barterGroup* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a10cdde75147b5b9c236e7f52646beda7)GetBarterGroups()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) > TaleWorlds.CampaignSystem.BarterSystem.BarterData.GetBarterGroups | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#aa4ba5688403699585ead1abc1530f041)GetBarterables()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > TaleWorlds.CampaignSystem.BarterSystem.BarterData.GetBarterables | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a29b7fccbf25298fedc52b7d3cd156751)GetBarterGroup< T >()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) TaleWorlds.CampaignSystem.BarterSystem.BarterData.GetBarterGroup< T > | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a0f630a52bacbf7908eb3ca3b9b9664dd)GetOfferedBarterables()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > TaleWorlds.CampaignSystem.BarterSystem.BarterData.GetOfferedBarterables | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a70192cdc256666a0c988b186aafa1713)OffererHero
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.BarterSystem.BarterData.OffererHero |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a51950247b352be49c50dcd2cc2c37cb0)OtherHero
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.BarterSystem.BarterData.OtherHero |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a0009abf5dcc5b0de7fad770a76e4f7c0)OffererParty
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.BarterSystem.BarterData.OffererParty |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#aeee01b617e34f072df1cba916d21706d)OtherParty
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.BarterSystem.BarterData.OtherParty |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#af565c4b49aef0d6e735db2beb6688afe)ContextInitializer
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [BarterManager.BarterContextInitializer](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_manager.html#ac2c4186d5c4acb484af1381bc4a309dc) TaleWorlds.CampaignSystem.BarterSystem.BarterData.ContextInitializer |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a3f9449d35fb1fe8d6db3a0ac669de091)PersuasionCostReduction
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.CampaignSystem.BarterSystem.BarterData.PersuasionCostReduction |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#ae2e3e2fc6eed2675d4f531b1acd64753)OffererMapFaction
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.BarterSystem.BarterData.OffererMapFaction | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#a421705dd3e01c2e6e9eb17f274f6ccc7)OtherMapFaction
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.BarterSystem.BarterData.OtherMapFaction | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html#acf302241d0ee59e04a8335d6ff8444af)IsAiBarter
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.BarterSystem.BarterData.IsAiBarter | | get |


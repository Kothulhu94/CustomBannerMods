--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html ---

TaleWorlds.CampaignSystem.PlayerCaptivity Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetRansomAmount](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#aa9c93d7c0cef0588e128d38938dd5c07) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [StartCaptivity](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#a4339b7d73ed5c450ea59cb5854bc8685) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) captorParty) |
| static void | [OnPlayerCharacterChanged](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#ab3308ed4f8e4d9dc0d00b76c45569bb3) () |
| static void | [EndCaptivity](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#ad17caf44ad05e39037763d2203e9163c) () |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [CountOfOffers](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#aa961e50670db527303e7e8443120ca4c) = 0 |
| int | [CurrentRansomAmount](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#aa3c185e9dc03c3d08076a53344da71d5) = 0 |

|  |  |
| --- | --- |
| Properties | |
| static [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [CaptorParty](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#af9e7f12e3602dc2886cc7d7f76f0a203) `[get, set]` |
| static float | [RandomNumber](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#a1826cedd7c7e52f23b98ae863bfedbd3) `[get, set]` |
| static bool | [IsCaptive](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#abcee311a4d5f68f45d2a6761ed4730a4) `[get]` |
| static int | [CaptiveTimeInDays](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#a4d22d9cd322cacc0bc77bb306194bb54) `[get]` |
| static [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [CaptivityStartTime](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#a5adf95efe2e1779076263f25a3af904c) `[get]` |
| static [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [LastCheckTime](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#a9c3ef2085b596b2f85d1febc4faa8548) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#a4339b7d73ed5c450ea59cb5854bc8685)StartCaptivity()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.PlayerCaptivity.StartCaptivity | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *captorParty* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#ab3308ed4f8e4d9dc0d00b76c45569bb3)OnPlayerCharacterChanged()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.PlayerCaptivity.OnPlayerCharacterChanged | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#aa9c93d7c0cef0588e128d38938dd5c07)SetRansomAmount()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.PlayerCaptivity.SetRansomAmount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#ad17caf44ad05e39037763d2203e9163c)EndCaptivity()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.PlayerCaptivity.EndCaptivity | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#aa961e50670db527303e7e8443120ca4c)CountOfOffers
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.PlayerCaptivity.CountOfOffers = 0 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#aa3c185e9dc03c3d08076a53344da71d5)CurrentRansomAmount
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.PlayerCaptivity.CurrentRansomAmount = 0 |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#af9e7f12e3602dc2886cc7d7f76f0a203)CaptorParty
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.PlayerCaptivity.CaptorParty | | staticgetset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#a1826cedd7c7e52f23b98ae863bfedbd3)RandomNumber
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.PlayerCaptivity.RandomNumber | | staticgetset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#abcee311a4d5f68f45d2a6761ed4730a4)IsCaptive
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.PlayerCaptivity.IsCaptive | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#a4d22d9cd322cacc0bc77bb306194bb54)CaptiveTimeInDays
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.PlayerCaptivity.CaptiveTimeInDays | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#a5adf95efe2e1779076263f25a3af904c)CaptivityStartTime
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.PlayerCaptivity.CaptivityStartTime | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_player_captivity.html#a9c3ef2085b596b2f85d1febc4faa8548)LastCheckTime
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.PlayerCaptivity.LastCheckTime | | staticgetset |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_stance_link.html ---

TaleWorlds.CampaignSystem.StanceLink Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetCasualties](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a16801b147c8ea5142ac8210918ed5f46) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| int | [GetSuccessfulSieges](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a5e4ee22410309b1fc1738e276de3cfa8) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| int | [GetSuccessfulRaids](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a48a6880bd543f0f8f1d95fd50a6d77ef) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| int | [GetTotalTributePaid](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#ac7bd92a55602a107fbfdce408a9ffe99) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| int | [GetSuccessfulTownSieges](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a4d7cf758cc86821b0c69fced4b284983) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| int | [GetDailyTributeToPay](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a564bae79d4a62593f970edee21ea7379) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| void | [SetDailyTributePaid](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#ae6e35a9b7a20f9fcf8fe180b30ed5f9f) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) payer, int dailyTribute, int dailyTributeInstallments) |
| int | [GetRemainingTributePaymentCount](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a51c562f454ed9d7919e15b6609244c5e) () |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [BehaviorPriority](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#abd052de86db34acab6145d96fb9ce985) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsNeutral](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#acc4e8bbb652e8921ede57da045a829ed) `[get]` |
| bool | [IsAtWar](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a81e93504cf3e5e369020cb14cf64f775) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [Faction1](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#af9ea3616e7cf52cb7fa3dab0aa23dce3) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [Faction2](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a32c28d735531719968436ffb16b4e35e) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [WarStartDate](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a0295fc159fa4a5202fa2a261cb9c5d4c) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [PeaceDeclarationDate](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a9361665e54a17bf70ae30a71ded951cb) `[get]` |
| int | [TroopCasualties1](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#aa24a2a3022be28097296f26cc4aeaebe) `[get, set]` |
| int | [TroopCasualties2](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#acf9da914f75579c322668e7f01a4f986) `[get, set]` |
| int | [ShipCasualties1](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a91953b85e69de750366cdd6cf46213aa) `[get, set]` |
| int | [ShipCasualties2](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a6540e52a9a83cae1611d700e741c92ce) `[get, set]` |
| int | [SuccessfulSieges1](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a82f431ce93817363ebe3710f7cf7ed86) `[get, set]` |
| int | [SuccessfulSieges2](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a82a511b582b25689a431ab9a02168cdb) `[get, set]` |
| int | [SuccessfulRaids1](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#af95abefd2485e527c7d91051bc8746ec) `[get, set]` |
| int | [SuccessfulRaids2](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#ae86527fe7834c6b5b73f3673adb984d3) `[get, set]` |
| int | [TotalTributePaidFrom1To2](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a0926ff7833f974719f2f283069e00c39) `[get, set]` |
| int | [TotalTributePaidFrom2To1](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#ad3da35fe56f1b294f83c4ff5cf77d3c0) `[get, set]` |
| int | [DailyTributeInstallments](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#ae7076780cebc9ba29727f649472888ae) `[get, set]` |
| int | [SuccessfulTownSieges1](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a1094f44db56dfb67843389c5c23898da) `[get, set]` |
| int | [SuccessfulTownSieges2](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a1b8a10852d744c2734db0d56a641e690) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a16801b147c8ea5142ac8210918ed5f46)GetCasualties()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.StanceLink.GetCasualties | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a5e4ee22410309b1fc1738e276de3cfa8)GetSuccessfulSieges()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.StanceLink.GetSuccessfulSieges | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a48a6880bd543f0f8f1d95fd50a6d77ef)GetSuccessfulRaids()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.StanceLink.GetSuccessfulRaids | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#ac7bd92a55602a107fbfdce408a9ffe99)GetTotalTributePaid()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.StanceLink.GetTotalTributePaid | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a4d7cf758cc86821b0c69fced4b284983)GetSuccessfulTownSieges()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.StanceLink.GetSuccessfulTownSieges | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a564bae79d4a62593f970edee21ea7379)GetDailyTributeToPay()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.StanceLink.GetDailyTributeToPay | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#ae6e35a9b7a20f9fcf8fe180b30ed5f9f)SetDailyTributePaid()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.StanceLink.SetDailyTributePaid | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *payer*, |
|  |  | int | *dailyTribute*, |
|  |  | int | *dailyTributeInstallments* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a51c562f454ed9d7919e15b6609244c5e)GetRemainingTributePaymentCount()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.StanceLink.GetRemainingTributePaymentCount | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#abd052de86db34acab6145d96fb9ce985)BehaviorPriority
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.StanceLink.BehaviorPriority |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#acc4e8bbb652e8921ede57da045a829ed)IsNeutral
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.StanceLink.IsNeutral | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a81e93504cf3e5e369020cb14cf64f775)IsAtWar
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.StanceLink.IsAtWar | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#af9ea3616e7cf52cb7fa3dab0aa23dce3)Faction1
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.StanceLink.Faction1 | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a32c28d735531719968436ffb16b4e35e)Faction2
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.StanceLink.Faction2 | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a0295fc159fa4a5202fa2a261cb9c5d4c)WarStartDate
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.StanceLink.WarStartDate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a9361665e54a17bf70ae30a71ded951cb)PeaceDeclarationDate
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.StanceLink.PeaceDeclarationDate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#aa24a2a3022be28097296f26cc4aeaebe)TroopCasualties1
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.TroopCasualties1 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#acf9da914f75579c322668e7f01a4f986)TroopCasualties2
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.TroopCasualties2 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a91953b85e69de750366cdd6cf46213aa)ShipCasualties1
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.ShipCasualties1 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a6540e52a9a83cae1611d700e741c92ce)ShipCasualties2
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.ShipCasualties2 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a82f431ce93817363ebe3710f7cf7ed86)SuccessfulSieges1
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.SuccessfulSieges1 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a82a511b582b25689a431ab9a02168cdb)SuccessfulSieges2
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.SuccessfulSieges2 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#af95abefd2485e527c7d91051bc8746ec)SuccessfulRaids1
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.SuccessfulRaids1 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#ae86527fe7834c6b5b73f3673adb984d3)SuccessfulRaids2
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.SuccessfulRaids2 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a0926ff7833f974719f2f283069e00c39)TotalTributePaidFrom1To2
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.TotalTributePaidFrom1To2 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#ad3da35fe56f1b294f83c4ff5cf77d3c0)TotalTributePaidFrom2To1
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.TotalTributePaidFrom2To1 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#ae7076780cebc9ba29727f649472888ae)DailyTributeInstallments
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.DailyTributeInstallments | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a1094f44db56dfb67843389c5c23898da)SuccessfulTownSieges1
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.SuccessfulTownSieges1 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html#a1b8a10852d744c2734db0d56a641e690)SuccessfulTownSieges2
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.StanceLink.SuccessfulTownSieges2 | | getset |


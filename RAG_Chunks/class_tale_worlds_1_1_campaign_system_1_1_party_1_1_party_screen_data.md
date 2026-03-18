--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html ---

TaleWorlds.CampaignSystem.Party.PartyScreenData Class ReferenceInherits IEnumerable.

|  |  |
| --- | --- |
| Public Member Functions | |
| override [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) | [GetHashCode](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a34d58a25a38a72e95e627130e45ec01f) () |
|  | [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) () |
| void | [InitializeCopyFrom](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a06325ff7d81deb8b91a047ca9ab95e41) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) rightParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) leftParty) |
| void | [CopyFromPartyAndRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#ac3f1c1b100f4267f52aefb3b3f40968f) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) rightPartyMemberRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) rightPartyPrisonerRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftPartyMemberRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftPartyPrisonerRoster, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) rightParty) |
| void | [CopyFromScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#ae69942d201f3873e8bb55155dc82ec51) ([PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) data) |
| void | [BindRostersFrom](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a7a89d2b7b02a1ea4e71309639278c1cf) ([TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) rightPartyMemberRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) rightPartyPrisonerRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftPartyMemberRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftPartyPrisonerRoster, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) rightParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) leftParty) |
| void | [ResetUsing](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a8c892482e50f8ab860f7ea0bed87a488) ([PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) partyScreenData) |
| bool | [IsThereAnyTroopTradeDifferenceBetween](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a262d930f6c3f18df8431b4ab5b91650c) ([PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) other) |
| List< [TroopTradeDifference](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_troop_trade_difference.html) > | [GetTroopTradeDifferencesFromTo](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#abe89e63d67559f9e0cbf118c82b49e48) ([PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) toPartyScreenData, PartyRosterSide side=PartyRosterSide.None) |
| IEnumerator<([TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), bool)> | [GetEnumerator](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a8a76bde617aebc6d896b26105cede2ce) () |
| override bool | [Equals](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a604147db251ff60a9a2d23f314c3b581) (object obj) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [operator==](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a5945ec9769549fbeccf7be7edc96b4c1) ([PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) a, [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) b) |
| static bool | [operator!=](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a4f8a2fc4c2092fe9b7d8fa42c2e1c360) ([PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) first, [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) second) |

|  |  |
| --- | --- |
| Public Attributes | |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [RightMemberRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a2c5b090e8c61d0688d5160a7f614c2c3) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [LeftMemberRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a9db7482ae1f390d7783165787c3f8ff5) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [RightPrisonerRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#aff7a3d86f72bb6a7a58a421bdb62e1cb) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [LeftPrisonerRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#abc4bf451a1ca1df496e14fbec82fbd75) |
| [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | [RightItemRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50f8a0a5807a14005f4c953b09a8bb43) |
| Dictionary< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) > | [RightRecruitableData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a1ceb92529c3a53adab3e998416c3b722) |
| [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) | [PartyGoldChangeAmount](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#ae3ec11c809f6315caacd3b193e289f70) |
|  | [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) |
| [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) | [PartyInfluenceChangeAmount](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a05197b5a7b256f86b4acb068af38ea04) |
| [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) | [PartyMoraleChangeAmount](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a1f9808618fa579e277045496379f4aea) |
| [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) | [PartyHorseChangeAmount](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#ae9ad724f8f841f3065418298abf05790) |
| List< Tuple< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) > > | [UpgradedTroopsHistory](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#aacee655b5e50520e1f5d6cd81c3b0298) |
| List< Tuple< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) > > | [TransferredPrisonersHistory](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a82ba14487d99b6d2e887091306eebdf7) |
| List< Tuple< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) > > | [RecruitedPrisonersHistory](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a5a8d76c888ca313bd7b1225432d78b4e) |
| List< Tuple< [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html), [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) > > | [UsedUpgradeHorsesHistory](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a601224993bbcb241717fcf05d5675c10) |

|  |  |
| --- | --- |
| Properties | |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [RightParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a5c4e11641a862b2e4530d3ecf2ae33a3) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [LeftParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#ae6e97eaa4b4d817bafb056af09dd8b28) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [RightPartyLeaderHero](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a631ee5f4c460b7a553420d7f405f730c) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [LeftPartyLeaderHero](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a3c11d464f9ed4578ae10249affcb490c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e)PartyScreenData()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Party.PartyScreenData.PartyScreenData | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a34d58a25a38a72e95e627130e45ec01f)GetHashCode()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) TaleWorlds.CampaignSystem.Party.PartyScreenData.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a06325ff7d81deb8b91a047ca9ab95e41)InitializeCopyFrom()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyScreenData.InitializeCopyFrom | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *rightParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *leftParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#ac3f1c1b100f4267f52aefb3b3f40968f)CopyFromPartyAndRoster()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyScreenData.CopyFromPartyAndRoster | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *rightPartyMemberRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *rightPartyPrisonerRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftPartyMemberRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftPartyPrisonerRoster*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *rightParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#ae69942d201f3873e8bb55155dc82ec51)CopyFromScreenData()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyScreenData.CopyFromScreenData | ( | [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) | *data* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a7a89d2b7b02a1ea4e71309639278c1cf)BindRostersFrom()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyScreenData.BindRostersFrom | ( | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *rightPartyMemberRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *rightPartyPrisonerRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftPartyMemberRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftPartyPrisonerRoster*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *rightParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *leftParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a8c892482e50f8ab860f7ea0bed87a488)ResetUsing()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyScreenData.ResetUsing | ( | [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) | *partyScreenData* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a262d930f6c3f18df8431b4ab5b91650c)IsThereAnyTroopTradeDifferenceBetween()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenData.IsThereAnyTroopTradeDifferenceBetween | ( | [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) | *other* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#abe89e63d67559f9e0cbf118c82b49e48)GetTroopTradeDifferencesFromTo()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [TroopTradeDifference](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_troop_trade_difference.html) > TaleWorlds.CampaignSystem.Party.PartyScreenData.GetTroopTradeDifferencesFromTo | ( | [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) | *toPartyScreenData*, |
|  |  | PartyRosterSide | *side* = PartyRosterSide::None ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a8a76bde617aebc6d896b26105cede2ce)GetEnumerator()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerator<([TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), bool)> TaleWorlds.CampaignSystem.Party.PartyScreenData.GetEnumerator | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a604147db251ff60a9a2d23f314c3b581)Equals()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.Party.PartyScreenData.Equals | ( | object | *obj* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a5945ec9769549fbeccf7be7edc96b4c1)operator==()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Party.PartyScreenData.operator== | ( | [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) | *a*, | |  |  | [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) | *b* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a4f8a2fc4c2092fe9b7d8fa42c2e1c360)operator!=()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Party.PartyScreenData.operator!= | ( | [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) | *first*, | |  |  | [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a169f329d2528ce17c59070f9bacd413e) | *second* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a2c5b090e8c61d0688d5160a7f614c2c3)RightMemberRoster
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.PartyScreenData.RightMemberRoster |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a9db7482ae1f390d7783165787c3f8ff5)LeftMemberRoster
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.PartyScreenData.LeftMemberRoster |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#aff7a3d86f72bb6a7a58a421bdb62e1cb)RightPrisonerRoster
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.PartyScreenData.RightPrisonerRoster |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#abc4bf451a1ca1df496e14fbec82fbd75)LeftPrisonerRoster
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.PartyScreenData.LeftPrisonerRoster |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50f8a0a5807a14005f4c953b09a8bb43)RightItemRoster
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) TaleWorlds.CampaignSystem.Party.PartyScreenData.RightItemRoster |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a1ceb92529c3a53adab3e998416c3b722)RightRecruitableData
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Dictionary<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc)> TaleWorlds.CampaignSystem.Party.PartyScreenData.RightRecruitableData |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#ae3ec11c809f6315caacd3b193e289f70)PartyGoldChangeAmount
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) TaleWorlds.CampaignSystem.Party.PartyScreenData.PartyGoldChangeAmount |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc)int
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| TaleWorlds.CampaignSystem.Party.PartyScreenData.int |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a05197b5a7b256f86b4acb068af38ea04)PartyInfluenceChangeAmount
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) TaleWorlds.CampaignSystem.Party.PartyScreenData.PartyInfluenceChangeAmount |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a1f9808618fa579e277045496379f4aea)PartyMoraleChangeAmount
----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) TaleWorlds.CampaignSystem.Party.PartyScreenData.PartyMoraleChangeAmount |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#ae9ad724f8f841f3065418298abf05790)PartyHorseChangeAmount
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc) TaleWorlds.CampaignSystem.Party.PartyScreenData.PartyHorseChangeAmount |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#aacee655b5e50520e1f5d6cd81c3b0298)UpgradedTroopsHistory
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<Tuple<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc)> > TaleWorlds.CampaignSystem.Party.PartyScreenData.UpgradedTroopsHistory |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a82ba14487d99b6d2e887091306eebdf7)TransferredPrisonersHistory
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<Tuple<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc)> > TaleWorlds.CampaignSystem.Party.PartyScreenData.TransferredPrisonersHistory |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a5a8d76c888ca313bd7b1225432d78b4e)RecruitedPrisonersHistory
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<Tuple<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc)> > TaleWorlds.CampaignSystem.Party.PartyScreenData.RecruitedPrisonersHistory |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a601224993bbcb241717fcf05d5675c10)UsedUpgradeHorsesHistory
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<Tuple<[EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html), [int](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a50dcae25f3f7b69ae7e3d6daae5ea6dc)> > TaleWorlds.CampaignSystem.Party.PartyScreenData.UsedUpgradeHorsesHistory |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a5c4e11641a862b2e4530d3ecf2ae33a3)RightParty
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Party.PartyScreenData.RightParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#ae6e97eaa4b4d817bafb056af09dd8b28)LeftParty
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Party.PartyScreenData.LeftParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a631ee5f4c460b7a553420d7f405f730c)RightPartyLeaderHero
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyScreenData.RightPartyLeaderHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html#a3c11d464f9ed4578ae10249affcb490c)LeftPartyLeaderHero
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Party.PartyScreenData.LeftPartyLeaderHero | | get |


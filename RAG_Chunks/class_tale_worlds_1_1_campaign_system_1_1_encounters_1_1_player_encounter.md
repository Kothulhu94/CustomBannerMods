--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html ---

TaleWorlds.CampaignSystem.Encounters.PlayerEncounter Class Reference[PlayerEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html "PlayerEncounter keeps track of information about encounters player faced.") keeps track of information about encounters player faced.

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnLoad](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a58f37fafca7734e3e4c10b801309ac45) () |
| void | [SetupFields](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aa9b991d382b035863eaf5d1b57113a68) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty) |
| void | [SetMeetingFalseForCompanion](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#abeb2471cc2e84a2fd85177a8f4975bad) () |
| void | [SetIsSallyOutAmbush](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a31c33033dbbc55ba80d825bb0b3cd871) (bool value) |
| void | [SetIsBlockadeAttack](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a71673bf4ae47a055d68bb2ec7c98e5bb) (bool value) |
| void | [SetIsBlockadeSallyOutAttack](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a39ae86568ee84836153c9a605c3a9d6f) (bool value) |
| void | [SetPlayerSiegeInterruptedByEnemyDefection](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#abb316c5942f4a56739badea8096ae6c3) () |
| bool | [CheckIfBattleShouldContinueAfterBattleMission](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a20a0693b0d1cd1918760a765f82306fb) () |
| void | [FinalizeBattle](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a3a6908949aa3f9567d3e8c0253a271ad) () |
| void | [FindNonAttachedNpcPartiesWhoWillJoinEvent](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aa7ca17bb5ed8a9461ea54588b0513ad5) (List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > partiesToJoinPlayerSide, List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > partiesToJoinEnemySide) |
|  | Populates the lists for each side only with base mobile parties - excluding their attached parties. Nearby party search does not include main party. |
| void | [FindAllNpcPartiesWhoWillJoinEvent](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a110054adc0d9280f354563de62c1e601) (List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > partiesToJoinPlayerSide, List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > partiesToJoinEnemySide) |
|  | Populates the lists for each side with the mobile parties in the area and their attached parties. Nearby party search does not include main party. |
| void | [InterruptEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#abc475bd01390914209b6504216056418) (string encounterInterrupedType) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [RestartPlayerEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a047f06b2ccaa116e8a104219425d1058) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, bool forcePlayerOutFromSettlement=true) |
| static void | [Init](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#abdf790c2bb06747df9a71bd993ca045e) () |
| static bool | [IsNavalEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ae1512eb9190537d3166b5a7f8e31d063) () |
| static [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | [StartBattle](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a82020e3f6ad5eba0dce3c28ca121e941) () |
| static void | [JoinBattle](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab8a8c611b88a80a8fb4e52e952012dbd) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| static void | [Start](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a6dd89194e401e9bd97b0c92010a6a096) () |
| static void | [ProtectPlayerSide](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a75a2fab62996be31acd38c3a838cdbcf) (float hoursToProtect=1.0f) |
| static void | [Finish](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a13c33a50081f918744234b2a6b7f3208) (bool forcePlayerOutFromSettlement=true) |
| static void | [EndBattleByCheat](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#acc5bb4012c8fac05079be986d0dc1c5d) (bool playerWon) |
| static void | [Update](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a9e14498c155555c3eaf12f3ea0a18bb1) () |
| static void | [DoMeeting](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a226794dffcc452a52a56d8769b397abe) () |
| static void | [SetMeetingDone](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ad4ac04ec3b44fd8da0119af2a3da4ccf) () |
| static bool | [CheckIfLeadingAvaliable](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab94c9ff6e8c93b7913badc89b8315eb5) () |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetLeadingHero](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a6f8553e7ab29783fdb1c24448121512b) () |
| static void | [SetPlayerVictorious](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a5b712c550f47974c94816f47882ad7fc) () |
|  | Set player side as winner of map event. Sometimes, this may be needed if all enemies are not dispatched (battle is too big, etc.). |
| static void | [SetPlayerSiegeContinueWithDefenderPullBack](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aa7a076e099e92de8efd0050072b87763) () |
| static void | [StartAttackMission](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a32257a8ab029bc7f3343bde003da3aff) () |
| static void | [EnterSettlement](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a634564fc8497b862d4577beab31494a9) () |
| static void | [LeaveBattle](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab2c6c0ecaa218d96f1f59679a76c7855) () |
| static void | [LeaveSettlement](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#afbd52b94be570271e9d8bbd5e02ab151) () |
| static void | [InitSimulation](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a8650adf21df9b6485a572b8f4de96528) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) selectedTroopsForPlayerSide, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) selectedTroopsForOtherSide) |
| static void | [StartSiegeAmbushMission](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aaf8fe7756f95bcf721bdabd16e7fab2d) () |
| static void | [StartVillageBattleMission](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#addd1cd1fb20dce5582e4dc219d2318a6) () |
| static void | [StartCombatMissionWithDialogueInTownCenter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a2ef151bd3108e8aa810f4f863b02ead3) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) characterToTalkTo) |
| static void | [StartHostileAction](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab5ce81313265e1aa98d0410a89d86453) () |
| static void | [GetBattleRewards](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a67d7fbae285d3237ca3853bec1122b31) (out float renownChange, out float influenceChange, out float moraleChange, out float goldChange, out float playerEarnedLootPercentage, out [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) playerEarnedFigurehead, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) renownExplainedNumber, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) influenceExplainedNumber, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) moraleExplainedNumber) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [FirstInit](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a8c60798d471c82de60a96eac5e81d201) = true |
| float | [PlayerPartyInitialStrength](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ae02458474bea7de104e6236aae4594c9) |
| float | [PartiesStrengthRatioBeforePlayerJoin](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#abd8a84072e1eb59e7cd184fa5ad02ecf) = 0.0f |
| bool | [ForceRaid](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a4f81181595192b63dd3094acfb22c892) |
| bool | [ForceSallyOut](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a8df85d5f29f931c97a596fec11ec5e64) |
| bool | [ForceHideoutSendTroops](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a952be256f31d34efef63bf7544148ead) |
| bool | [ForceVolunteers](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a9ce75054a541c421e80933bf8601f5bb) |
| bool | [ForceSupplies](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a51a7f9a4de1476a647d9345d04827943) |
| BattleSimulation | [BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a4ae6f52e488bfd689c4c9a74d6316e77) |
| [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) | [PlayerLootedFigurehead](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a9a306343a88f7046096ac46d70d46770) = null |
| bool | [ForceBlockadeAttack](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a1b611eea8617e9f8ffec21113feb4e09) = false |
| bool | [ForceBlockadeSallyOutAttack](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a83467c60113842b7953d54e1636fe1dc) = false |

|  |  |
| --- | --- |
| Properties | |
| static PlayerEncounter | [Current](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aeb07a7d68dfbdf6d0ab73bb74840ed41) `[get]` |
| static LocationEncounter | [LocationEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a96cc573ddf75a31b288d382c544c8fcd) `[get, set]` |
| static [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | [Battle](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a03e24801718cef769b7712f2a2407b4f) `[get]` |
| static [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [EncounteredParty](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a9052493c17d6d882eb5b436152d1ce02) `[get]` |
| static [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [EncounteredMobileParty](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aab4db22865772df8be81510f40f90db7) `[get]` |
| static [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | [EncounteredBattle](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a12707139b6565631fb6352ffc08881c3) `[get]` |
| static [BattleState](namespace_tale_worlds_1_1_core.html#a53c64d3498c18a933d19dbf60e962fed) | [BattleState](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aa6d76b1b43d4c75d95bb44c1d6495c14) `[get]` |
| static [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [WinningSide](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab41bf9d6e86ced46868ac46e4d8b7e90) `[get]` |
| static bool | [BattleChallenge](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a4f77e5c722e60e82bd680c58eabf08a5) `[get, set]` |
| static bool | [PlayerIsDefender](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a086b7fbfcd529ec70134b0c436de32ab) `[get]` |
| static bool | [PlayerIsAttacker](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aebb6e2f14e766617d9ac1b27e9ab8385) `[get]` |
| static bool | [LeaveEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#afe3d34cf349c305dbcd5434d0c10b25f) `[get, set]` |
| static bool | [MeetingDone](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a8ed24f0de300f5c72c3739a29f7496f5) `[get]` |
| static bool | [PlayerSurrender](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#af6981dd75290091b685350844dd14122) `[get, set]` |
| static bool | [EnemySurrender](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#acc459a87175fb5f6bfb012ac50ad853e) `[get, set]` |
| static bool | [IsActive](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a4b2a7ffff8aa5f89037569cff8a7d45d) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [OpponentSide](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab2326746483e278367fe739cc451cf37) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [PlayerSide](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a460a84caca11abac22d5398ea94f6db9) `[get]` |
| bool | [IsJoinedBattle](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a055d04e0e719dc3ed940ea0c8e17ce51) `[get]` |
| static bool | [InsideSettlement](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#adc69916decffe7624dd016e9a8629046) `[get]` |
| static CampaignBattleResult | [CampaignBattleResult](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#add6ba38e75c97c4eb8ec7771d8a1933c) `[get, set]` |
| static [BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a4ae6f52e488bfd689c4c9a74d6316e77) | [CurrentBattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab84ed40e28a442ef5a77bec726a6090f) `[get]` |
| [PlayerEncounterState](namespace_tale_worlds_1_1_campaign_system_1_1_encounters.html#ab82f338afd97644e760a4d504fceba98) | [EncounterState](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a1a5d8a9a1d30c502cc460ba10c0a3173) `[get]` |
| [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | [RosterToReceiveLootItems](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a81f50f3a632eb1925976debc933bf5dd) `[get]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [RosterToReceiveLootPrisoners](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a688138b190bdcf6254f20ce688a91a8b) `[get]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [RosterToReceiveLootMembers](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a1a1e259f84a410d219970c1dca747b06) `[get]` |
| List< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | [ReceivedLootShips](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a6beefd875747a24f38810596ea5c219e) `[get]` |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [EncounterSettlement](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a5f06bcb5d6a5c235c341cf60c768ab92) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [EncounterSettlementAux](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a313885b3649fd68e8b4390d8890da099) `[get]` |
| bool | [IsPlayerWaiting](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a5e15145c2908ec65b2f068b634b89fac) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a58f37fafca7734e3e4c10b801309ac45)OnLoad()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.OnLoad | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a047f06b2ccaa116e8a104219425d1058)RestartPlayerEncounter()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.RestartPlayerEncounter | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | bool | *forcePlayerOutFromSettlement* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#abdf790c2bb06747df9a71bd993ca045e)Init()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.Init | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aa9b991d382b035863eaf5d1b57113a68)SetupFields()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.SetupFields | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ae1512eb9190537d3166b5a7f8e31d063)IsNavalEncounter()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.IsNavalEncounter | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a82020e3f6ad5eba0dce3c28ca121e941)StartBattle()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.StartBattle | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab8a8c611b88a80a8fb4e52e952012dbd)JoinBattle()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.JoinBattle | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a6dd89194e401e9bd97b0c92010a6a096)Start()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.Start | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a75a2fab62996be31acd38c3a838cdbcf)ProtectPlayerSide()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.ProtectPlayerSide | ( | float | *hoursToProtect* = 1::0f | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a13c33a50081f918744234b2a6b7f3208)Finish()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.Finish | ( | bool | *forcePlayerOutFromSettlement* = true | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#acc5bb4012c8fac05079be986d0dc1c5d)EndBattleByCheat()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.EndBattleByCheat | ( | bool | *playerWon* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a9e14498c155555c3eaf12f3ea0a18bb1)Update()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.Update | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a226794dffcc452a52a56d8769b397abe)DoMeeting()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.DoMeeting | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ad4ac04ec3b44fd8da0119af2a3da4ccf)SetMeetingDone()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.SetMeetingDone | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#abeb2471cc2e84a2fd85177a8f4975bad)SetMeetingFalseForCompanion()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.SetMeetingFalseForCompanion | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab94c9ff6e8c93b7913badc89b8315eb5)CheckIfLeadingAvaliable()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.CheckIfLeadingAvaliable | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a6f8553e7ab29783fdb1c24448121512b)GetLeadingHero()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.GetLeadingHero | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a5b712c550f47974c94816f47882ad7fc)SetPlayerVictorious()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.SetPlayerVictorious | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a31c33033dbbc55ba80d825bb0b3cd871)SetIsSallyOutAmbush()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.SetIsSallyOutAmbush | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a71673bf4ae47a055d68bb2ec7c98e5bb)SetIsBlockadeAttack()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.SetIsBlockadeAttack | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a39ae86568ee84836153c9a605c3a9d6f)SetIsBlockadeSallyOutAttack()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.SetIsBlockadeSallyOutAttack | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#abb316c5942f4a56739badea8096ae6c3)SetPlayerSiegeInterruptedByEnemyDefection()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.SetPlayerSiegeInterruptedByEnemyDefection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aa7a076e099e92de8efd0050072b87763)SetPlayerSiegeContinueWithDefenderPullBack()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.SetPlayerSiegeContinueWithDefenderPullBack | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a32257a8ab029bc7f3343bde003da3aff)StartAttackMission()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.StartAttackMission | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a20a0693b0d1cd1918760a765f82306fb)CheckIfBattleShouldContinueAfterBattleMission()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.CheckIfBattleShouldContinueAfterBattleMission | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a3a6908949aa3f9567d3e8c0253a271ad)FinalizeBattle()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.FinalizeBattle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aa7ca17bb5ed8a9461ea54588b0513ad5)FindNonAttachedNpcPartiesWhoWillJoinEvent()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.FindNonAttachedNpcPartiesWhoWillJoinEvent | ( | List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | *partiesToJoinPlayerSide*, |
|  |  | List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | *partiesToJoinEnemySide* ) |

Parameters
:   |  |  |
    | --- | --- |
    | partiesToJoinPlayerSide | Returns all non-attached ally parties in map event including nearby ones that will join |
    | partiesToJoinEnemySide | Returns all non-attached enemy parties in map event including nearby ones that will join |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a110054adc0d9280f354563de62c1e601)FindAllNpcPartiesWhoWillJoinEvent()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.FindAllNpcPartiesWhoWillJoinEvent | ( | List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | *partiesToJoinPlayerSide*, |
|  |  | List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | *partiesToJoinEnemySide* ) |

Parameters
:   |  |  |
    | --- | --- |
    | partiesToJoinPlayerSide | Returns all ally parties in map event including attached parties and nearby ones that will join |
    | partiesToJoinEnemySide | Returns all enemy parties in map event including attached parties and nearby ones that will join |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a634564fc8497b862d4577beab31494a9)EnterSettlement()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.EnterSettlement | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab2c6c0ecaa218d96f1f59679a76c7855)LeaveBattle()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.LeaveBattle | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#afbd52b94be570271e9d8bbd5e02ab151)LeaveSettlement()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.LeaveSettlement | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a8650adf21df9b6485a572b8f4de96528)InitSimulation()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.InitSimulation | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *selectedTroopsForPlayerSide*, | |  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *selectedTroopsForOtherSide* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#abc475bd01390914209b6504216056418)InterruptEncounter()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.InterruptEncounter | ( | string | *encounterInterrupedType* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aaf8fe7756f95bcf721bdabd16e7fab2d)StartSiegeAmbushMission()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.StartSiegeAmbushMission | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#addd1cd1fb20dce5582e4dc219d2318a6)StartVillageBattleMission()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.StartVillageBattleMission | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a2ef151bd3108e8aa810f4f863b02ead3)StartCombatMissionWithDialogueInTownCenter()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.StartCombatMissionWithDialogueInTownCenter | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *characterToTalkTo* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab5ce81313265e1aa98d0410a89d86453)StartHostileAction()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.StartHostileAction | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a67d7fbae285d3237ca3853bec1122b31)GetBattleRewards()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.GetBattleRewards | ( | out float | *renownChange*, | |  |  | out float | *influenceChange*, | |  |  | out float | *moraleChange*, | |  |  | out float | *goldChange*, | |  |  | out float | *playerEarnedLootPercentage*, | |  |  | out [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) | *playerEarnedFigurehead*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *renownExplainedNumber*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *influenceExplainedNumber*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *moraleExplainedNumber* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a8c60798d471c82de60a96eac5e81d201)FirstInit
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.FirstInit = true |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ae02458474bea7de104e6236aae4594c9)PlayerPartyInitialStrength
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.PlayerPartyInitialStrength |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#abd8a84072e1eb59e7cd184fa5ad02ecf)PartiesStrengthRatioBeforePlayerJoin
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.PartiesStrengthRatioBeforePlayerJoin = 0.0f |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a4f81181595192b63dd3094acfb22c892)ForceRaid
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.ForceRaid |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a8df85d5f29f931c97a596fec11ec5e64)ForceSallyOut
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.ForceSallyOut |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a952be256f31d34efef63bf7544148ead)ForceHideoutSendTroops
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.ForceHideoutSendTroops |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a9ce75054a541c421e80933bf8601f5bb)ForceVolunteers
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.ForceVolunteers |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a51a7f9a4de1476a647d9345d04827943)ForceSupplies
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.ForceSupplies |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a4ae6f52e488bfd689c4c9a74d6316e77)BattleSimulation
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| BattleSimulation TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.BattleSimulation |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a9a306343a88f7046096ac46d70d46770)PlayerLootedFigurehead
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.PlayerLootedFigurehead = null |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a1b611eea8617e9f8ffec21113feb4e09)ForceBlockadeAttack
----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.ForceBlockadeAttack = false |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a83467c60113842b7953d54e1636fe1dc)ForceBlockadeSallyOutAttack
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.ForceBlockadeSallyOutAttack = false |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aeb07a7d68dfbdf6d0ab73bb74840ed41)Current
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | PlayerEncounter TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.Current | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a96cc573ddf75a31b288d382c544c8fcd)LocationEncounter
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | LocationEncounter TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.LocationEncounter | | staticgetset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a03e24801718cef769b7712f2a2407b4f)Battle
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.Battle | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a9052493c17d6d882eb5b436152d1ce02)EncounteredParty
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.EncounteredParty | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aab4db22865772df8be81510f40f90db7)EncounteredMobileParty
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.EncounteredMobileParty | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a12707139b6565631fb6352ffc08881c3)EncounteredBattle
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.EncounteredBattle | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aa6d76b1b43d4c75d95bb44c1d6495c14)BattleState
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleState](namespace_tale_worlds_1_1_core.html#a53c64d3498c18a933d19dbf60e962fed) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.BattleState | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab41bf9d6e86ced46868ac46e4d8b7e90)WinningSide
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.WinningSide | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a4f77e5c722e60e82bd680c58eabf08a5)BattleChallenge
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.BattleChallenge | | staticgetset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a086b7fbfcd529ec70134b0c436de32ab)PlayerIsDefender
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.PlayerIsDefender | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#aebb6e2f14e766617d9ac1b27e9ab8385)PlayerIsAttacker
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.PlayerIsAttacker | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#afe3d34cf349c305dbcd5434d0c10b25f)LeaveEncounter
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.LeaveEncounter | | staticgetset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a8ed24f0de300f5c72c3739a29f7496f5)MeetingDone
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.MeetingDone | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#af6981dd75290091b685350844dd14122)PlayerSurrender
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.PlayerSurrender | | staticgetset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#acc459a87175fb5f6bfb012ac50ad853e)EnemySurrender
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.EnemySurrender | | staticgetset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a4b2a7ffff8aa5f89037569cff8a7d45d)IsActive
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.IsActive | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab2326746483e278367fe739cc451cf37)OpponentSide
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.OpponentSide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a460a84caca11abac22d5398ea94f6db9)PlayerSide
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.PlayerSide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a055d04e0e719dc3ed940ea0c8e17ce51)IsJoinedBattle
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.IsJoinedBattle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#adc69916decffe7624dd016e9a8629046)InsideSettlement
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.InsideSettlement | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#add6ba38e75c97c4eb8ec7771d8a1933c)CampaignBattleResult
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CampaignBattleResult TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.CampaignBattleResult | | staticgetset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#ab84ed40e28a442ef5a77bec726a6090f)CurrentBattleSimulation
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a4ae6f52e488bfd689c4c9a74d6316e77) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.CurrentBattleSimulation | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a1a5d8a9a1d30c502cc460ba10c0a3173)EncounterState
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PlayerEncounterState](namespace_tale_worlds_1_1_campaign_system_1_1_encounters.html#ab82f338afd97644e760a4d504fceba98) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.EncounterState | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a81f50f3a632eb1925976debc933bf5dd)RosterToReceiveLootItems
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.RosterToReceiveLootItems | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a688138b190bdcf6254f20ce688a91a8b)RosterToReceiveLootPrisoners
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.RosterToReceiveLootPrisoners | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a1a1e259f84a410d219970c1dca747b06)RosterToReceiveLootMembers
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.RosterToReceiveLootMembers | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a6beefd875747a24f38810596ea5c219e)ReceivedLootShips
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html)> TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.ReceivedLootShips | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a5f06bcb5d6a5c235c341cf60c768ab92)EncounterSettlement
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.EncounterSettlement | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a313885b3649fd68e8b4390d8890da099)EncounterSettlementAux
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.EncounterSettlementAux | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_player_encounter.html#a5e15145c2908ec65b2f068b634b89fac)IsPlayerWaiting
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Encounters.PlayerEncounter.IsPlayerWaiting | | getset |


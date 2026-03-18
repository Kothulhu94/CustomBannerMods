--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html ---

TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry Class ReferenceInherits [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html), and [TaleWorlds.CampaignSystem.LogEntries.IWarLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_war_log.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [VillageStateChangedLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#a918351099a945e64ed135275cd7e3164) ([Village](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#aa681d497fd1dc780a436862d2957844e) village, [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) oldState, [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) newState, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) raiderParty) |
| bool | [IsRelatedToWar](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#ae7344de29a97082c8821fb6acbccdc0d) ([StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) stance, out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) effector, out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) effected) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#ad2a9a5c05838f20f0f77845621ba4906) () |
| override int | [GetAsRumor](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#aad302b21a90e7885eb88ff32e578bfdc) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) talkSettlement, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) comment) |
| override void | [GetConversationScoreAndComment](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#a3b67e8326606717bbe008ee1041f86f4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) talkTroop, bool findString, out string comment, out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) score) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| virtual [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | [GetImportanceForClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a7c6f6efbaf5023b9ff5a327f1035eb97) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetHistoricComment](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a3e6d93f7728dbe250d7f7d374f4a4598) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) talkTroop) |
| virtual int | [AsReasonForEnmity](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a923b525085ea88a16913013269aced27) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceHero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceHero2) |
| virtual int | [GetValueAsPoliticsAbuseOfPower](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ae5596b47b211f9a3ad0416a9054a44f9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceTroop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) liege) |
| virtual int | [GetValueAsPoliticsSlightedClan](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a8c6212c66ff1f49f35d48b748dff0e38) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceTroop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) liege) |
| virtual int | [GetValueAsPoliticsShowedWeakness](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#acbfa8603d87b10253b9670ff7aa1fa20) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) referenceTroop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) liege) |
| virtual bool | [IsValid](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a83f43de30ed08ab699fec650be10a21e) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Village | [Village](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#aa681d497fd1dc780a436862d2957844e) |
| readonly [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) | [OldState](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#acaacb97cc5968d65e15d26b3b2b4b8b4) |
| readonly [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) | [NewState](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#abeada17a7e6be5a094c44ce92b1bb190) |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [RaiderPartyMapFaction](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#a3797dda7577d344d847271d97706cdd3) |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [VillageRealmWhenRaided](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#a077fe52b3a0b4e42c35a685e3bd3a5b8) |
| readonly bool | [RealmsAtWarWhenRaided](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#a3146d6df7c88afb4e99cd41f912fd51d) |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [RaidLeader](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#aa5b8ee1e380206f3c0f7e35e6b9af734) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| static void | [AddLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#aae352405d30de4fb59eb5c6e8bb2171b) ([LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) logEntry) |
| static void | [AddLogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a9d8fbc79cd5d870a1e900782f1f5886b) ([LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) logEntry, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) gameTime) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [MilitaryNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a39f60666598fff5a6618e49d91a00048) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) benefiter, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) affected) |
| [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [DiplomaticNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a23f398711eeb7a912a3d3b5943ecfd2d) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [AdversityNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a41e99acb466cc9e002331ed2015f44c6) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [PoliticalNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ae89e1c61ac912ef306b8a81bd2e4400e) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [CivilianNotification](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a361f6f567b55859864a758fff3257ee0) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| Static Protected Attributes inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| const uint | [NotificationDefaultTextColor](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a58cdc628f53b87f73ceeefd87a484f5a) = 0x000000 |
| Properties inherited from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html) | |
| long | [Id](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ab64d6317b6b3da5d89b28dfe0af32d49) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GameTime](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a7a261f8d5d25128f503a53c5951d6f6b) `[get]` |
| virtual [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [KeepInHistoryTime](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#ae6e768fe50e4094d5dcc21a5c3c2cd3c) `[get]` |
| virtual [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | [NotificationType](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a8af557fe13d2e1e14039485a2a79068f) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#a918351099a945e64ed135275cd7e3164)VillageStateChangedLogEntry()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry.VillageStateChangedLogEntry | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#aa681d497fd1dc780a436862d2957844e) | *village*, |
|  |  | [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) | *oldState*, |
|  |  | [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) | *newState*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *raiderParty* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#ae7344de29a97082c8821fb6acbccdc0d)IsRelatedToWar()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry.IsRelatedToWar | ( | [StanceLink](class_tale_worlds_1_1_campaign_system_1_1_stance_link.html) | *stance*, |
|  |  | out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *effector*, |
|  |  | out [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *effected* ) |

Implements [TaleWorlds.CampaignSystem.LogEntries.IWarLog](interface_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_i_war_log.html#a4799c9a434b9dbe96dc78274b5452db6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#ad2a9a5c05838f20f0f77845621ba4906)ToString()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#aad302b21a90e7885eb88ff32e578bfdc)GetAsRumor()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry.GetAsRumor | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *talkSettlement*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *comment* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#aec025534c9341d340f1f05a8dce17bfa).

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#a3b67e8326606717bbe008ee1041f86f4)GetConversationScoreAndComment()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry.GetConversationScoreAndComment | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *talkTroop*, | |  |  | bool | *findString*, | |  |  | out string | *comment*, | |  |  | out [ImportanceEnum](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a5da9ede756ccd51196b69792411e705d) | *score* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.LogEntries.LogEntry](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_log_entry.html#a5908ac9bdee45378cf193ea497758ade).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#aa681d497fd1dc780a436862d2957844e)Village
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Village TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry.Village |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#acaacb97cc5968d65e15d26b3b2b4b8b4)OldState
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry.OldState |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#abeada17a7e6be5a094c44ce92b1bb190)NewState
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry.NewState |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#a3797dda7577d344d847271d97706cdd3)RaiderPartyMapFaction
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry.RaiderPartyMapFaction |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#a077fe52b3a0b4e42c35a685e3bd3a5b8)VillageRealmWhenRaided
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry.VillageRealmWhenRaided |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#a3146d6df7c88afb4e99cd41f912fd51d)RealmsAtWarWhenRaided
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry.RealmsAtWarWhenRaided |

[◆](class_tale_worlds_1_1_campaign_system_1_1_log_entries_1_1_village_state_changed_log_entry.html#aa5b8ee1e380206f3c0f7e35e6b9af734)RaidLeader
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.LogEntries.VillageStateChangedLogEntry.RaidLeader |


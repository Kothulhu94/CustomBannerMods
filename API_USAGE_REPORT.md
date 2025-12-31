# API Usage Report: Ten Custom Mods

This document lists every external Bannerlord API usage detected across the 10 custom modules.
It is grouped by functionality.

## Architecture
| API Name | Function/Description | Usage Count | Examples |
|---|---|---|---|
| `Inherits CampaignBehaviorBase` | Class inherits from standard Campaign Behavior (Logic Container). | 50 | BetterGov: AutoResolveIssuesBehavior.cs<br>Brigands: BanditCohesionBehavior.cs<br>Brigands: SanityCheckBehavior.cs<br>...(+47 more) |
| `Inherits MBSubModuleBase` | Class inherits from Module entry point. | 10 | BetterGov: BetterGovSubModule.cs<br>Brigands: BrigandsUnifiedSubModule.cs<br>CoastalLife: CoastalLifeSubModule.cs<br>...(+7 more) |
| `Inherits SaveableTypeDefiner` | Game API Method/Property. | 1 | Landlord: LandlordSaveDefiner.cs |

## Namespaces & Core
| API Name | Function/Description | Usage Count | Examples |
|---|---|---|---|
| `TaleWorlds.CampaignSystem` | Core namespace for Campaign logic (Map, Parties, Clans). | 282 | BetterGov: AutoResolveIssuesBehavior.cs<br>BetterGov: AutoResolveIssuesBehavior.cs<br>BetterGov: AutoResolveIssuesBehavior.cs<br>...(+2 more) |
| `TaleWorlds.Core` | Core game systems (Items, Basic Types, Managers). | 78 | BetterGov: AutoResolveIssuesBehavior.cs<br>BetterGov: BetterGovSubModule.cs<br>BetterGov: AutoGovernorPatches.cs<br>...(+2 more) |
| `TaleWorlds.Library` | Low-level utilities (Math, Color, Debug, FileSystem). | 69 | BetterGov: AutoResolveIssuesBehavior.cs<br>BetterGov: BetterGovSubModule.cs<br>Brigands: BanditCohesionBehavior.cs<br>...(+2 more) |
| `TaleWorlds.Localization` | TextObject and localization system. | 33 | Brigands: BanditCohesionBehavior.cs<br>Brigands: PressGangBehavior.cs<br>Brigands: BanditTerrorBehavior.cs<br>...(+2 more) |
| `TaleWorlds.MountAndBlade` | Battle engine and SubModule infrastructure. | 11 | BetterGov: BetterGovSubModule.cs<br>Brigands: BrigandsUnifiedSubModule.cs<br>CoastalLife: CoastalLifeSubModule.cs<br>...(+2 more) |
| `TaleWorlds.ObjectSystem` | MBObjectBase and Guid/StringId management. | 10 | Brigands: SyndicateFactionBehavior.cs<br>CoastalLife: ShipDumperBehavior.cs<br>FieldSquire: SquireSpawnBehavior.cs<br>...(+2 more) |
| `TaleWorlds.SaveSystem` | Game API Method/Property. | 6 | Landlord: EconomyBehavior.cs<br>Landlord: LandlordSaveDefiner.cs<br>Landlord: LandlordState.cs<br>...(+2 more) |
| `TaleWorlds.ScreenSystem` | Screen management (Layers, UI state). | 3 | FieldSquire: SquireDialogBehavior.cs<br>FieldSquire: SquireTownManagementVM.cs<br>FieldSquire: SquireTownManagementVM.cs |
| `TaleWorlds.ModuleManager` | Game API Method/Property. | 2 | BetterGov: BetterGovSubModule.cs<br>LudusMagnus: LudusCreationBehavior.cs |
| `TaleWorlds.Engine` | Game Engine access (WorldToScreen, Physics). | 2 | FieldSquire: SquireDialogBehavior.cs<br>FieldSquire: SquireTownManagementVM.cs |
| `TaleWorlds.InputSystem` | Game API Method/Property. | 1 | LivingLegend: LivingLegendPatches.cs |

## Events
| API Name | Function/Description | Usage Count | Examples |
|---|---|---|---|
| `CampaignEvents.DailyTickEvent` | Event: Triggered every in-game day. | 19 | Brigands: SanityCheckBehavior.cs<br>Brigands: PartyAlignmentFixerBehavior.cs<br>Brigands: BanditTerrorBehavior.cs<br>...(+2 more) |
| `CampaignEvents.OnSessionLaunchedEvent` | Event: Triggered when the campaign session begins. | 19 | Brigands: PartyAlignmentFixerBehavior.cs<br>Brigands: RecruitWarlordBehavior.cs<br>Brigands: SyndicateFactionBehavior.cs<br>...(+2 more) |
| `CampaignEvents.HourlyTickEvent` | Event: Triggered every in-game hour. | 11 | BetterGov: AutoResolveIssuesBehavior.cs<br>Brigands: BanditTerrorBehavior.cs<br>Brigands: BanditTrainingBehavior.cs<br>...(+2 more) |
| `CampaignEvents.SettlementEntered` | Event: Triggered when a party enters a settlement. | 6 | FieldSquire: SquireLogisticsBehavior.cs<br>HappyParty: EliteRecruiterBehavior.cs<br>HappyParty: GourmetArmyBehavior.cs<br>...(+2 more) |
| `CampaignEvents.MapEventEnded` | Event: Triggered when a battle or map event finishes. | 4 | Brigands: PressGangBehavior.cs<br>Brigands: RecruitWarlordBehavior.cs<br>Landlord: ViolenceBehavior.cs<br>...(+1 more) |
| `CampaignEvents.WeeklyTickEvent` | Event: Triggered every in-game week. | 4 | Brigands: WarlordSpawnBehavior.cs<br>Landlord: EconomyBehavior.cs<br>LudusMagnus: LudusRivalryBehavior.cs<br>...(+1 more) |
| `CampaignEvents.DailyTickPartyEvent` | Game API Method/Property. | 2 | Brigands: PressGangBehavior.cs<br>LudusMagnus: AiVisitLudusBehavior.cs |
| `CampaignEvents.MapEventStarted` | Event: Triggered when a battle starts. | 2 | Brigands: RecruitWarlordBehavior.cs<br>Landlord: ViolenceBehavior.cs |
| `CampaignEvents.AiHourlyTickEvent` | Game API Method/Property. | 2 | LudusMagnus: AiProcuratorBehavior.cs<br>LudusMagnus: AiVisitLudusBehavior.cs |
| `CampaignEvents.HeroKilledEvent` | Game API Method/Property. | 1 | Brigands: RecruitWarlordBehavior.cs |
| `CampaignEvents.OnGameLoadedEvent` | Event: Triggered after a save game is loaded. | 1 | Brigands: SyndicateFactionBehavior.cs |
| `CampaignEvents.OnNewGameCreatedEvent` | Event: Triggered when a new campaign starts. | 1 | Brigands: SyndicateFactionBehavior.cs |
| `CampaignEvents.DailyTickSettlementEvent` | Game API Method/Property. | 1 | CoastalLife: CoastalPatrolBehavior.cs |
| `CampaignEvents.OnSettlementLeftEvent` | Event: Triggered when a party leaves a settlement. | 1 | CoastalLife: CoastalPatrolBehavior.cs |
| `CampaignEvents.MobilePartyDestroyed` | Game API Method/Property. | 1 | CoastalLife: CoastalPatrolBehavior.cs |
| `CampaignEvents.OnSettlementOwnerChangedEvent` | Game API Method/Property. | 1 | CoastalLife: CoastalPatrolBehavior.cs |
| `CampaignEvents.DailyTickClanEvent` | Game API Method/Property. | 1 | LivingLegend: LivingLegendBehavior.cs |
| `CampaignEvents.PlayerTraitChangedEvent` | Game API Method/Property. | 1 | LivingLegend: LivingLegendBehavior.cs |
| `CampaignEvents.WarDeclared` | Game API Method/Property. | 1 | LudusMagnus: LudusQuestBehavior.cs |

## Actions (State Changes)
| API Name | Function/Description | Usage Count | Examples |
|---|---|---|---|
| `GiveGoldAction.ApplyBetweenCharacters` | Transfers gold from one hero to another. | 26 | BetterGov: AutoResolveIssuesBehavior.cs<br>CoastalLife: CoastalPatrolBehavior.cs<br>CoastalLife: PortEconomyBehavior.cs<br>...(+2 more) |
| `ChangeRelationAction.ApplyRelationChangeBetweenHeroes` | Game API Method/Property. | 9 | BetterGov: AutoResolveIssuesBehavior.cs<br>Brigands: SyndicateFactionBehavior.cs<br>Brigands: SyndicateFactionBehavior.cs<br>...(+2 more) |
| `AddCompanionAction.Apply` | Adds a hero to a clan as a companion. | 8 | Brigands: RecruitWarlordBehavior.cs<br>Brigands: WarlordSpawnBehavior.cs<br>FieldSquire: SquireSpawnBehavior.cs<br>...(+2 more) |
| `AddHeroToPartyAction.Apply` | Adds a hero to a specific mobile party. | 5 | Brigands: RecruitWarlordBehavior.cs<br>FieldSquire: SquireSpawnBehavior.cs<br>FieldSquire: SquireSpawnBehavior.cs<br>...(+2 more) |
| `GiveGoldAction.ApplyForCharacterToSettlement` | Game API Method/Property. | 5 | Landlord: EconomyBehavior.cs<br>Landlord: EconomyBehavior.cs<br>Landlord: EconomyBehavior.cs<br>...(+2 more) |
| `GiveGoldAction.ApplyForSettlementToCharacter` | Transfers gold from a settlement to a hero. | 4 | HonestWork: CastleJobBehavior.cs<br>HonestWork: TownJobBehavior.cs<br>Landlord: EconomyBehavior.cs<br>...(+1 more) |
| `GiveGoldAction.ApplyForSettlementToParty` | Transfers gold from a settlement to a party. | 2 | CoastalLife: CoastalJobBehavior.cs<br>HonestWork: VillageLaborBehavior.cs |
| `EndCaptivityAction.ApplyByRansom` | Releases a prisoner via ransom. | 1 | Brigands: BanditTerrorBehavior.cs |
| `KillCharacterAction.KillCharacterActionDetail` | Enum specifying how a character died. | 1 | Brigands: RecruitWarlordBehavior.cs |
| `EndCaptivityAction.ApplyByReleasedByChoice` | Game API Method/Property. | 1 | Brigands: RecruitWarlordBehavior.cs |
| `KillCharacterAction.ApplyByRemove` | Removes a character from the game (Soft Kill). | 1 | FieldSquire: SquireSpawnBehavior.cs |
| `EndCaptivityAction.ApplyByEscape` | Releases a prisoner via escape. | 1 | FieldSquire: SquireSpawnBehavior.cs |
| `ChangeRelationAction.ApplyPlayerRelation` | Game API Method/Property. | 1 | LivingLegend: LivingLegendBehavior.cs |

## Game Entities (Properties)
| API Name | Function/Description | Usage Count | Examples |
|---|---|---|---|
| `Hero.MainHero` | The player character. | 109 | Brigands: RecruitWarlordBehavior.cs<br>Brigands: SyndicateFactionBehavior.cs<br>Brigands: SyndicateFactionBehavior.cs<br>...(+2 more) |
| `Settlement.CurrentSettlement` | Game API Method/Property. | 63 | CoastalLife: CoastalJobBehavior.cs<br>CoastalLife: CoastalJobBehavior.cs<br>CoastalLife: CoastalJobBehavior.cs<br>...(+2 more) |
| `Clan.PlayerClan` | The player's clan. | 54 | BetterGov: AutoResolveIssuesBehavior.cs<br>Brigands: BanditCohesionBehavior.cs<br>Brigands: BanditCohesionBehavior.cs<br>...(+2 more) |
| `MobileParty.MainParty` | The player's mobile party. | 33 | Brigands: PressGangBehavior.cs<br>Brigands: BanditTerrorBehavior.cs<br>Brigands: BanditTrainingBehavior.cs<br>...(+2 more) |
| `Hero.OneToOneConversationHero` | Game API Method/Property. | 18 | Brigands: RecruitWarlordBehavior.cs<br>Brigands: RecruitWarlordBehavior.cs<br>Brigands: RecruitWarlordBehavior.cs<br>...(+2 more) |
| `Settlement.All` | Collection of all settlements in the game. | 17 | BetterGov: AutoResolveIssuesBehavior.cs<br>Brigands: BanditTerrorBehavior.cs<br>Brigands: WarlordSpawnBehavior.cs<br>...(+2 more) |
| `MobileParty.NavigationType` | Game API Method/Property. | 17 | Brigands: BanditTerrorBehavior.cs<br>Brigands: BanditTerrorBehavior.cs<br>LivingLegend: LivingLegendBehavior.cs<br>...(+2 more) |
| `MobileParty.All` | Game API Method/Property. | 16 | Brigands: SanityCheckBehavior.cs<br>Brigands: PartyAlignmentFixerBehavior.cs<br>Brigands: BanditTerrorBehavior.cs<br>...(+2 more) |
| `Clan.All` | Game API Method/Property. | 12 | Brigands: SyndicateFactionBehavior.cs<br>Brigands: SyndicateFactionBehavior.cs<br>Brigands: SyndicateFactionBehavior.cs<br>...(+2 more) |
| `Hero.CharacterStates` | Game API Method/Property. | 12 | Brigands: SyndicateFactionBehavior.cs<br>Brigands: SyndicateFactionBehavior.cs<br>Brigands: WarlordSpawnBehavior.cs<br>...(+2 more) |
| `Settlement.Town` | Game API Method/Property. | 12 | LudusMagnus: LudusAiManagementBehavior.cs<br>LudusMagnus: LudusAiManagementBehavior.cs<br>LudusMagnus: LudusAiManagementBehavior.cs<br>...(+2 more) |
| `Clan.Leader` | Game API Method/Property. | 8 | HappyParty: TavernCleanerBehavior.cs<br>HappyParty: TavernCleanerBehavior.cs<br>HappyParty: TavernCleanerBehavior.cs<br>...(+2 more) |
| `Settlement.GatePosition` | Game API Method/Property. | 8 | LudusMagnus: AiVisitLudusBehavior.cs<br>LudusMagnus: LudusRivalryBehavior.cs<br>LudusMagnus: LudusSentinelBehavior.cs<br>...(+2 more) |
| `Settlement.Name` | Game API Method/Property. | 7 | LudusMagnus: LudusAiManagementBehavior.cs<br>LudusMagnus: LudusAiManagementBehavior.cs<br>LudusMagnus: LudusRivalryBehavior.cs<br>...(+2 more) |
| `Hero.AllAliveHeroes` | Collection of all living heroes. | 6 | FieldSquire: SquireDialogBehavior.cs<br>FieldSquire: SquireSpawnBehavior.cs<br>FieldSquire: SquireSpawnBehavior.cs<br>...(+2 more) |
| `Town.Governor` | Game API Method/Property. | 5 | BetterGov: GovernorService.cs<br>BetterGov: GovernorService.cs<br>BetterGov: GovernorService.cs<br>...(+2 more) |
| `Town.Prosperity` | The prosperity value of a town. | 5 | Brigands: BanditTerrorBehavior.cs<br>CoastalLife: CoastalJobBehavior.cs<br>CoastalLife: PortEconomyBehavior.cs<br>...(+2 more) |
| `Clan.StringId` | Game API Method/Property. | 5 | Brigands: RecruitWarlordBehavior.cs<br>Brigands: WarlordBattlePatch.cs<br>HappyParty: JobSeekerBehavior.cs<br>...(+2 more) |
| `MobileParty.CreateParty` | Game API Method/Property. | 5 | LivingLegend: LivingLegendBehavior.cs<br>LudusMagnus: LudusRivalryBehavior.cs<br>LudusMagnus: LudusSentinelBehavior.cs<br>...(+2 more) |
| `Settlement.OwnerClan` | Game API Method/Property. | 4 | BetterGov: GovernorService.cs<br>LivingLegend: LivingLegendModel.cs<br>LivingLegend: LivingLegendModel.cs<br>...(+1 more) |
| `Hero.CurrentSettlement` | Game API Method/Property. | 4 | FieldSquire: SquireDialogBehavior.cs<br>FieldSquire: SquireDialogBehavior.cs<br>FieldSquire: SquireDialogBehavior.cs<br>...(+1 more) |
| `Town.GarrisonParty` | Game API Method/Property. | 4 | HonestWork: CastleJobBehavior.cs<br>HonestWork: CastleJobBehavior.cs<br>HonestWork: CastleJobBehavior.cs<br>...(+1 more) |
| `Settlement.Parties` | Game API Method/Property. | 4 | LudusMagnus: LudusSiegeReliefBehavior.cs<br>LudusMagnus: LudusEconomyBehavior.cs<br>LudusMagnus: LudusStaffBehavior.cs<br>...(+1 more) |
| `Clan.Settlements` | Game API Method/Property. | 4 | LudusMagnus: LudusCreationBehavior.cs<br>NewClans: NewClansBehavior.cs<br>NewClans: NewClansBehavior.cs<br>...(+1 more) |
| `Clan.IsEliminated` | Game API Method/Property. | 3 | Brigands: PartyAlignmentFixerBehavior.cs<br>HappyParty: JobSeekerBehavior.cs<br>HappyParty: TavernCleanerBehavior.cs |
| `Clan.Name` | Game API Method/Property. | 3 | Brigands: PartyAlignmentFixerBehavior.cs<br>HappyParty: TavernCleanerBehavior.cs<br>LudusMagnus: LudusRivalryBehavior.cs |
| `MobileParty.IsActive` | Game API Method/Property. | 3 | Brigands: PressGangBehavior.cs<br>HappyParty: TavernCleanerBehavior.cs<br>HappyParty: TavernCleanerBehavior.cs |
| `Village.VillageState` | Game API Method/Property. | 3 | Brigands: BanditTerrorBehavior.cs<br>LivingLegend: LivingLegendBehavior.cs<br>LudusMagnus: LudusSentinelBehavior.cs |
| `Village.VillageStates` | Game API Method/Property. | 3 | Brigands: BanditTerrorBehavior.cs<br>LivingLegend: LivingLegendBehavior.cs<br>LudusMagnus: LudusSentinelBehavior.cs |
| `Village.GetItemPrice` | Game API Method/Property. | 3 | FieldSquire: SquireLogisticsBehavior.cs<br>Landlord: EconomyBehavior.cs<br>Landlord: EconomyBehavior.cs |
| `Village.Gold` | Game API Method/Property. | 3 | Landlord: EconomyBehavior.cs<br>Landlord: EconomyBehavior.cs<br>Landlord: EconomyBehavior.cs |
| `Village.Hearth` | The hearth (population/growth) value of a village. | 2 | Brigands: BanditTerrorBehavior.cs<br>Landlord: EconomyBehavior.cs |
| `Town.IsUnderSiege` | Game API Method/Property. | 2 | CoastalLife: CoastalPatrolBehavior.cs<br>CoastalLife: CoastalPatrolBehavior.cs |
| `Hero.Name` | Game API Method/Property. | 2 | FieldSquire: SquireDialogBehavior.cs<br>FieldSquire: SquireDialogBehavior.cs |
| `Town.GetItemPrice` | Game API Method/Property. | 2 | FieldSquire: SquireLogisticsBehavior.cs<br>HappyParty: GourmetArmyBehavior.cs |
| `Clan.WarPartyComponents` | Game API Method/Property. | 2 | HappyParty: TavernCleanerBehavior.cs<br>HappyParty: TavernCleanerBehavior.cs |
| `Town.Security` | The security rating of a town. | 2 | HonestWork: CastleJobBehavior.cs<br>HonestWork: CastleJobBehavior.cs |
| `Settlement.ItemRoster` | Game API Method/Property. | 2 | HonestWork: TownJobBehavior.cs<br>HonestWork: TownJobBehavior.cs |
| `Village.VillageType` | Game API Method/Property. | 2 | HonestWork: VillageLaborBehavior.cs<br>HonestWork: VillageLaborBehavior.cs |
| `Settlement.Find` | Game API Method/Property. | 2 | Landlord: EconomyBehavior.cs<br>LudusMagnus: LudusCreationBehavior.cs |
| `Settlement.FindFirst` | Game API Method/Property. | 2 | LudusMagnus: LudusProcuratorBehavior.cs<br>LudusMagnus: LudusProcuratorBehavior.cs |
| `Hero.Level` | Game API Method/Property. | 2 | LudusMagnus: AscensionRitual.cs<br>LudusMagnus: AscensionRitual.cs |
| `Clan.CreateCompanionToLordClan` | Game API Method/Property. | 2 | NewClans: NewClansBehavior.cs<br>NewClans: NewClansBehavior.cs |
| `Clan.IsBanditFaction` | Game API Method/Property. | 1 | Brigands: PartyAlignmentFixerBehavior.cs |
| `Clan.CreateClan` | Game API Method/Property. | 1 | Brigands: SyndicateFactionBehavior.cs |
| `Hero.GetSkillValue` | Game API Method/Property. | 1 | FieldSquire: SquireDialogBehavior.cs |
| `MobileParty.MemberRoster` | Game API Method/Property. | 1 | FieldSquire: PartySizeLimitPatch.cs |
| `Town.Loyalty` | The loyalty rating of a town. | 1 | HonestWork: CastleJobBehavior.cs |
| `Clan.IsMinorFaction` | Game API Method/Property. | 1 | LivingLegend: LivingLegendBehavior.cs |
| `Settlement.BoundVillages` | Game API Method/Property. | 1 | LudusMagnus: LudusSentinelBehavior.cs |
| `Town.FoodStocks` | Game API Method/Property. | 1 | LudusMagnus: LudusProcuratorBehavior.cs |
| `Town.Gold` | Game API Method/Property. | 1 | LudusMagnus: LudusProcuratorBehavior.cs |
| `Hero.CharacterObject` | Game API Method/Property. | 1 | LudusMagnus: AscensionRitual.cs |
| `Hero.HeroDeveloper` | Game API Method/Property. | 1 | LudusMagnus: AscensionRitual.cs |
| `Clan.Renown` | Game API Method/Property. | 1 | LudusMagnus: CouncilVotingModel.cs |
| `Clan.Kingdom` | Game API Method/Property. | 1 | NewClans: NewClansBehavior.cs |

## UI & Feedback
| API Name | Function/Description | Usage Count | Examples |
|---|---|---|---|
| `InformationManager.DisplayMessage` | Displays a chat message to the player. | 78 | Brigands: RecruitWarlordBehavior.cs<br>CoastalLife: CoastalJobBehavior.cs<br>CoastalLife: PortEconomyBehavior.cs<br>...(+2 more) |
| `InformationManager.ShowInquiry` | Opens a popup dialog box. | 3 | FieldSquire: SquireDialogBehavior.cs<br>Landlord: EconomyBehavior.cs<br>LudusMagnus: LudusRivalryBehavior.cs |

## Other APIs
| API Name | Function/Description | Usage Count | Examples |
|---|---|---|---|
| `GameMenuOption.LeaveType` | Game API Method/Property. | 50 | CoastalLife: CoastalJobBehavior.cs<br>CoastalLife: CoastalJobBehavior.cs<br>CoastalLife: CoastalJobBehavior.cs<br>...(+2 more) |
| `Campaign.Current` | Singleton access to the active Campaign instance. | 14 | BetterGov: AutoResolveIssuesBehavior.cs<br>BetterGov: AutoResolveIssuesBehavior.cs<br>Brigands: MergePatches.cs<br>...(+2 more) |
| `Game.Current` | Singleton access to the active Game instance. | 10 | BetterGov: AutoGovernorPatches.cs<br>Brigands: PressGangBehavior.cs<br>Landlord: EconomyBehavior.cs<br>...(+2 more) |
| `ItemObject.ItemTypeEnum` | Game API Method/Property. | 10 | Landlord: EconomyBehavior.cs<br>Landlord: EconomyBehavior.cs<br>Landlord: EconomyBehavior.cs<br>...(+2 more) |
| `ItemObject.ItemTiers` | Game API Method/Property. | 5 | Landlord: EconomyBehavior.cs<br>Landlord: EconomyBehavior.cs<br>Landlord: EconomyBehavior.cs<br>...(+2 more) |
| `CharacterObject.All` | Game API Method/Property. | 3 | FieldSquire: SquireSpawnBehavior.cs<br>FieldSquire: SquireSpawnBehavior.cs<br>LudusMagnus: LudusRivalryBehavior.cs |
| `Mission.Current` | Game API Method/Property. | 2 | FieldSquire: SquireCombatPatch.cs<br>FieldSquire: SquireCombatPatch.cs |
| `TroopRoster.CreateDummyTroopRoster` | Game API Method/Property. | 2 | Landlord: EconomyBehavior.cs<br>Landlord: LandlordState.cs |
| `Kingdom.Leader` | Game API Method/Property. | 2 | NewClans: NewClansBehavior.cs<br>NewClans: NewClansBehavior.cs |
| `Kingdom.All` | Game API Method/Property. | 1 | Brigands: SyndicateFactionBehavior.cs |
| `TextObject.GetEmpty` | Game API Method/Property. | 1 | CoastalLife: CoastalPatrolBehavior.cs |
| `CampaignGameStarter.AddModel` | Game API Method/Property. | 1 | LudusMagnus: LudusSubModule.cs |
| `CharacterObject.Level` | Game API Method/Property. | 1 | LudusMagnus: AscensionRitual.cs |


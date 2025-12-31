# API Verification Report

Validation of scanned APIs against actual Game DLLs using ILSpy.
*Note: Signatures are extracted via text search on decompiled source. Inherited members may show as missing if not overridden in the derived class.*

| API | Status | Verified Signature / Error |
|---|---|---|
| `AddCompanionAction.Apply` | ✅ VERIFIED | `public static void Apply(Clan clan, Hero companion)` |
| `AddHeroToPartyAction.Apply` | ✅ VERIFIED | `public static void Apply(Hero hero, MobileParty party, bool showNotification = true)` |
| `Campaign.Current` | ✅ VERIFIED | `public ConversationContext CurrentConversationContext;` |
| `CampaignEvents.AiHourlyTickEvent` | ✅ VERIFIED | `public static IMbEvent<MobileParty, PartyThinkParams> AiHourlyTickEvent => Instance._aiHourlyTick...` |
| `CampaignEvents.DailyTickClanEvent` | ✅ VERIFIED | `public static IMbEvent<Clan> DailyTickClanEvent => Instance._dailyTickClanEvent;` |
| `CampaignEvents.DailyTickEvent` | ✅ VERIFIED | `public static IMbEvent DailyTickEvent => Instance._dailyTickEvent;` |
| `CampaignEvents.DailyTickPartyEvent` | ✅ VERIFIED | `public static IMbEvent<MobileParty> DailyTickPartyEvent => Instance._dailyTickPartyEvent;` |
| `CampaignEvents.DailyTickSettlementEvent` | ✅ VERIFIED | `public static IMbEvent<Settlement> DailyTickSettlementEvent => Instance._dailyTickSettlementEvent;` |
| `CampaignEvents.HeroKilledEvent` | ✅ VERIFIED | `public static IMbEvent<Hero, Hero, KillCharacterAction.KillCharacterActionDetail, bool> HeroKille...` |
| `CampaignEvents.HourlyTickEvent` | ✅ VERIFIED | `public static IMbEvent HourlyTickEvent => Instance._hourlyTickEvent;` |
| `CampaignEvents.MapEventEnded` | ✅ VERIFIED | `public static IMbEvent<MapEvent> MapEventEnded => Instance._mapEventEnded;` |
| `CampaignEvents.MapEventStarted` | ✅ VERIFIED | `public static IMbEvent<MapEvent, PartyBase, PartyBase> MapEventStarted => Instance._mapEventStarted;` |
| `CampaignEvents.MobilePartyDestroyed` | ✅ VERIFIED | `public static IMbEvent<MobileParty, PartyBase> MobilePartyDestroyed => Instance._mobilePartyDestr...` |
| `CampaignEvents.OnGameLoadedEvent` | ✅ VERIFIED | `public static IMbEvent<CampaignGameStarter> OnGameLoadedEvent => Instance._onGameLoadedEvent;` |
| `CampaignEvents.OnNewGameCreatedEvent` | ✅ VERIFIED | `public static IMbEvent<CampaignGameStarter> OnNewGameCreatedEvent => Instance._onNewGameCreatedEv...` |
| `CampaignEvents.OnSessionLaunchedEvent` | ✅ VERIFIED | `public static IMbEvent<CampaignGameStarter> OnSessionLaunchedEvent => Instance._onSessionLaunched...` |
| `CampaignEvents.OnSettlementLeftEvent` | ✅ VERIFIED | `public static IMbEvent<MobileParty, Settlement> OnSettlementLeftEvent => Instance._onSettlementLe...` |
| `CampaignEvents.OnSettlementOwnerChangedEvent` | ✅ VERIFIED | `public static IMbEvent<Settlement, bool, Hero, Hero, Hero, ChangeOwnerOfSettlementAction.ChangeOw...` |
| `CampaignEvents.PlayerTraitChangedEvent` | ✅ VERIFIED | `public static IMbEvent<TraitObject, int> PlayerTraitChangedEvent => Instance._playerTraitChangedE...` |
| `CampaignEvents.SettlementEntered` | ✅ VERIFIED | `public static IMbEvent<MobileParty, Settlement, Hero> SettlementEntered => Instance._settlementEn...` |
| `CampaignEvents.WarDeclared` | ✅ VERIFIED | `public static IMbEvent<IFaction, IFaction, DeclareWarAction.DeclareWarDetail> WarDeclared => Inst...` |
| `CampaignEvents.WeeklyTickEvent` | ✅ VERIFIED | `public static IMbEvent WeeklyTickEvent => Instance._weeklyTickEvent;` |
| `CampaignGameStarter.AddModel` | ✅ VERIFIED | `public void AddModel(GameModel gameModel)` |
| `ChangeRelationAction.ApplyPlayerRelation` | ✅ VERIFIED | `public static void ApplyPlayerRelation(Hero gainedRelationWith, int relation, bool affectRelative...` |
| `ChangeRelationAction.ApplyRelationChangeBetweenHeroes` | ✅ VERIFIED | `public static void ApplyRelationChangeBetweenHeroes(Hero hero, Hero gainedRelationWith, int relat...` |
| `CharacterObject.All` | ✅ VERIFIED | `public static MBReadOnlyList<CharacterObject> All => Campaign.Current.Characters;` |
| `CharacterObject.Level` | ✅ VERIFIED | `public override int Level` |
| `Clan.All` | ✅ VERIFIED | `internal bool _distanceToClosestNonAllyFortificationCacheDirty = true;` |
| `Clan.CreateClan` | ✅ VERIFIED | `public static Clan CreateClan(string stringID)` |
| `Clan.CreateCompanionToLordClan` | ✅ VERIFIED | `public static Clan CreateCompanionToLordClan(Hero hero, Settlement settlement, TextObject clanNam...` |
| `Clan.IsBanditFaction` | ✅ VERIFIED | `public bool IsBanditFaction { get; private set; }` |
| `Clan.IsEliminated` | ✅ VERIFIED | `public bool IsEliminated => _isEliminated;` |
| `Clan.IsMinorFaction` | ✅ VERIFIED | `public bool IsMinorFaction { get; private set; }` |
| `Clan.Kingdom` | ✅ VERIFIED | `public Kingdom Kingdom` |
| `Clan.Leader` | ✅ VERIFIED | `public Hero Leader => _leader;` |
| `Clan.Name` | ✅ VERIFIED | `public TextObject Name { get; private set; }` |
| `Clan.PlayerClan` | ✅ VERIFIED | `public static Clan PlayerClan => Campaign.Current.PlayerDefaultFaction;` |
| `Clan.Renown` | ✅ VERIFIED | `public float Renown { get; set; }` |
| `Clan.Settlements` | ✅ VERIFIED | `public MBReadOnlyList<Settlement> Settlements => _settlementsCache;` |
| `Clan.StringId` | ✅ VERIFIED | `public string EncyclopediaLink => Campaign.Current.EncyclopediaManager.GetIdentifier(typeof(Clan)...` |
| `Clan.WarPartyComponents` | ✅ VERIFIED | `public MBReadOnlyList<WarPartyComponent> WarPartyComponents => _warPartyComponentsCache;` |
| `EndCaptivityAction.ApplyByEscape` | ✅ VERIFIED | `public static void ApplyByEscape(Hero character, Hero facilitator = null, bool showNotification =...` |
| `EndCaptivityAction.ApplyByRansom` | ✅ VERIFIED | `public static void ApplyByRansom(Hero character, Hero facilitator)` |
| `EndCaptivityAction.ApplyByReleasedByChoice` | ✅ VERIFIED | `public static void ApplyByReleasedByChoice(FlattenedTroopRoster troopRoster)` |
| `Game.Current` | ✅ VERIFIED | `public State CurrentState { get; private set; }` |
| `GameMenuOption.LeaveType` | ⚠️ MISSING_TYPE | `Type not found in DLLs` |
| `GiveGoldAction.ApplyBetweenCharacters` | ✅ VERIFIED | `public static void ApplyBetweenCharacters(Hero giverHero, Hero recipientHero, int amount, bool di...` |
| `GiveGoldAction.ApplyForCharacterToSettlement` | ✅ VERIFIED | `public static void ApplyForCharacterToSettlement(Hero giverHero, Settlement settlement, int amoun...` |
| `GiveGoldAction.ApplyForSettlementToCharacter` | ✅ VERIFIED | `public static void ApplyForSettlementToCharacter(Settlement giverSettlement, Hero recipientHero, ...` |
| `GiveGoldAction.ApplyForSettlementToParty` | ✅ VERIFIED | `public static void ApplyForSettlementToParty(Settlement giverSettlement, PartyBase recipientParty...` |
| `Hero.AllAliveHeroes` | ✅ VERIFIED | `public static MBReadOnlyList<Hero> AllAliveHeroes => Campaign.Current.AliveHeroes;` |
| `Hero.CharacterObject` | ✅ VERIFIED | `public CharacterObject[] VolunteerTypes;` |
| `Hero.CharacterStates` | ✅ VERIFIED | `public enum CharacterStates` |
| `Hero.CurrentSettlement` | ✅ VERIFIED | `public Settlement CurrentSettlement` |
| `Hero.GetSkillValue` | ✅ VERIFIED | `public int GetSkillValue(SkillObject skill)` |
| `Hero.HeroDeveloper` | ✅ VERIFIED | `public HeroDeveloper HeroDeveloper => _heroDeveloper;` |
| `Hero.Level` | ✅ VERIFIED | `public int Level;` |
| `Hero.MainHero` | ✅ VERIFIED | `public bool IsHumanPlayerCharacter => this == MainHero;` |
| `Hero.Name` | ✅ VERIFIED | `public TextObject FirstName => _firstName;` |
| `Hero.OneToOneConversationHero` | ✅ VERIFIED | `public static Hero OneToOneConversationHero => Campaign.Current.ConversationManager.OneToOneConve...` |
| `InformationManager.DisplayMessage` | ✅ VERIFIED | `public static event Action<InformationMessage> DisplayMessageInternal;` |
| `InformationManager.ShowInquiry` | ✅ VERIFIED | `public static event Action<InquiryData, bool, bool> OnShowInquiry;` |
| `Inherits CampaignBehaviorBase` | ✅ VERIFIED | `public abstract class CampaignBehaviorBase : ICampaignBehavior` |
| `Inherits MBSubModuleBase` | ✅ VERIFIED | `public abstract class MBSubModuleBase` |
| `Inherits SaveableTypeDefiner` | ✅ VERIFIED | `public abstract class SaveableTypeDefiner` |
| `ItemObject.ItemTiers` | ✅ VERIFIED | `public enum ItemTiers` |
| `ItemObject.ItemTypeEnum` | ✅ VERIFIED | `public enum ItemTypeEnum` |
| `KillCharacterAction.ApplyByRemove` | ✅ VERIFIED | `public static void ApplyByRemove(Hero victim, bool showNotification = false, bool isForced = true)` |
| `KillCharacterAction.KillCharacterActionDetail` | ✅ VERIFIED | `public enum KillCharacterActionDetail` |
| `Kingdom.All` | ✅ VERIFIED | `public MBReadOnlyList<Kingdom> AlliedKingdoms => _alliedKingdoms;` |
| `Kingdom.Leader` | ✅ VERIFIED | `public Hero Leader => _rulingClan?.Leader;` |
| `Mission.Current` | ✅ VERIFIED | `internal UIntPtr Channel0CurrentActionPointer;` |
| `MobileParty.All` | ✅ VERIFIED | `public static MBReadOnlyList<MobileParty> All => Campaign.Current.MobileParties;` |
| `MobileParty.CreateParty` | ✅ VERIFIED | `public static MobileParty CreateParty(string stringId, PartyComponent component)` |
| `MobileParty.IsActive` | ✅ VERIFIED | `public bool IsActive { get; set; }` |
| `MobileParty.MainParty` | ✅ VERIFIED | `public static MobileParty MainParty => Campaign.Current.MainParty;` |
| `MobileParty.MemberRoster` | ✅ VERIFIED | `public int TotalWage => (int)Campaign.Current.Models.PartyWageModel.GetTotalWage(this, MemberRost...` |
| `MobileParty.NavigationType` | ✅ VERIFIED | `public enum NavigationType` |
| `Settlement.All` | ✅ VERIFIED | `public float NearbyLandAllyIntensity { get; set; }` |
| `Settlement.BoundVillages` | ✅ VERIFIED | `public MBReadOnlyList<Village> BoundVillages => _boundVillages;` |
| `Settlement.CurrentSettlement` | ✅ VERIFIED | `public static Settlement CurrentSettlement` |
| `Settlement.Find` | ✅ VERIFIED | `public static Settlement Find(string idString)` |
| `Settlement.FindFirst` | ✅ VERIFIED | `public static Settlement FindFirst(Func<Settlement, bool> predicate)` |
| `Settlement.GatePosition` | ✅ VERIFIED | `public CampaignVec2 GatePosition { get; private set; }` |
| `Settlement.ItemRoster` | ✅ VERIFIED | `public readonly ItemRoster Stash;` |
| `Settlement.Name` | ✅ VERIFIED | `public TextObject Name` |
| `Settlement.OwnerClan` | ✅ VERIFIED | `public Hero Owner => OwnerClan.Leader;` |
| `Settlement.Parties` | ✅ VERIFIED | `public int NumberOfLordPartiesTargeting;` |
| `Settlement.Town` | ✅ VERIFIED | `public Town Town;` |
| `TextObject.GetEmpty` | ✅ VERIFIED | `public static TextObject GetEmpty()` |
| `Town.FoodStocks` | ✅ VERIFIED | `public float FoodChange => Campaign.Current.Models.SettlementFoodModel.CalculateTownFoodStocksCha...` |
| `Town.GarrisonParty` | ⚠️ MISSING_MEMBER | `Member 'GarrisonParty' not found in Town` |
| `Town.GetItemPrice` | ✅ VERIFIED | `public override int GetItemPrice(ItemObject item, MobileParty tradingParty = null, bool isSelling...` |
| `Town.Gold` | ⚠️ MISSING_MEMBER | `Member 'Gold' not found in Town` |
| `Town.Governor` | ✅ VERIFIED | `public Hero Governor` |
| `Town.IsUnderSiege` | ✅ VERIFIED | `public bool IsUnderSiege => base.Settlement.IsUnderSiege;` |
| `Town.Loyalty` | ✅ VERIFIED | `public float LoyaltyChange => Campaign.Current.Models.SettlementLoyaltyModel.CalculateLoyaltyChan...` |
| `Town.Prosperity` | ✅ VERIFIED | `public float Prosperity` |
| `Town.Security` | ✅ VERIFIED | `public float SecurityChange => Campaign.Current.Models.SettlementSecurityModel.CalculateSecurityC...` |
| `TroopRoster.CreateDummyTroopRoster` | ✅ VERIFIED | `public static TroopRoster CreateDummyTroopRoster()` |
| `Village.GetItemPrice` | ✅ VERIFIED | `public override int GetItemPrice(ItemObject item, MobileParty tradingParty = null, bool isSelling...` |
| `Village.Gold` | ⚠️ MISSING_MEMBER | `Member 'Gold' not found in Village` |
| `Village.Hearth` | ✅ VERIFIED | `public const int MidHearthThreshold = 600;` |
| `Village.VillageState` | ✅ VERIFIED | `public enum VillageStates` |
| `Village.VillageStates` | ✅ VERIFIED | `public enum VillageStates` |
| `Village.VillageType` | ✅ VERIFIED | `public VillageType VillageType;` |

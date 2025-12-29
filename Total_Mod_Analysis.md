# Comprehensive Bannerlord Mod Analysis & Code Quality Report

This document combines a deep-dive analysis of mod mechanics with a technical code quality assessment. 

---

## 1. HappyParty
**Theme:** Enhancements to Party AI and QoL for wandering heroes.

### Core Mechanics
*   **Wanderer Validation:** Checks spawned Wanderers and fixes missing equipment or active states.
*   **Elite Recruiter:**
    *   **Logic:** AI Lords entering settlements buy Tier 3+ troops from Notables if they have gold and space.
*   **Gourmet Army:**
    *   **Logic:** AI Lords buy food items in settlements.
    *   **Target:** 1 Food Item per **5** Troops.
    *   **Effect:** Increases AI party morale and field endurance.
*   **Job Seeker (Headhunter):**
    *   **Logic:** AI Lords with < 4 Companions look for specialized staff (Surgeon, Engineer, Scout, Quartermaster).
    *   **Condition:** Leader Skill < 50 AND current staff skill < 60.
    *   **Hire:** Finds a Wanderer (Skill > 60) in town. Cost: **2000** Gold.
*   **Ransom Prisoner:**
    *   **Logic:** AI Lords entering towns automatically ransom **all** prisoners.
    *   **Value:** `TroopTier * 100` (Min 50).
*   **Tavern Cleaner:**
    *   **Trigger:** Hourly (Hour 2).
    *   **Action:** Moves stuck Lords/Wanderers from settlements to their Clan Leader's party.
    *   **Chaos Mode:** If no party exists, **creates a new Lord Party** for the wanderer, preventing world stagnation.

### Code Quality Assessment
**Rating**: **Green**
*   **Analysis**:
    *   **Structure**: Clean separation of behaviors (`EliteRecruiter`, `GourmetArmy`, `JobSeeker`, `TavernCleaner`).
    *   **Logic**: `JobSeekerBehavior` intelligently caches needed roles and only scans for wanderers when necessary. `TavernCleanerBehavior` uses a robust "Chaos Mode" check.
    *   **Performance**: Event-driven (`OnSettlementEntered`). No expensive loops in `HourlyTick`.
    *   **Most Complicated Function**: `TavernCleanerBehavior.ProcessStuckHero` - Manages complex party creation and hero teleportation logic to fix soft-locked state.
*   **Recommendations**: None. The mod is well-optimized.

---

## 2. HonestWork
**Theme:** Immersive player jobs in towns and villages.

### Core Mechanics
*   **Town Jobs:**
    *   **Types:** Guard, Thug, Artisan, Instructor, Outrider, Physician, Official.
    *   **Wage:** `10 + (Prosperity / 250)`.
    *   **XP:** 50 XP/hour base (scaling with duration).
    *   **Bonuses (Hourly):**
        *   Guard: +0.1 Security.
        *   Thug: -0.1 Security.
        *   Artisan/Official: +0.1 Prosperity.
        *   Physician: +0.1 Loyalty.
        *   Outrider: +0.1 Militia.
        *   Instructor: +1 XP to Garrison troops.
    *   **Shift Bonus (8h):**
        *   **Item:** Random item from market (Value limit `Wage * 10`).
        *   **Renown:** +0.5.
        *   **Relation:** +1 with random Notable (Thugs target Gang Leaders).
*   **Village Labor:**
    *   **Wage:** `Hearths / 10`.
    *   **XP:** 20 Athletics XP/hour.
    *   **Shift Bonus (8h):**
        *   Adds **5** units of Primary Production to village.
        *   Gives Player **1** random item from village.
        *   +1 Relation with Notable.
*   **Castle Service:**
    *   **Wage:** `25 + (Prosperity / 100)`.
    *   **Effects:** +Security/Loyalty + Garrison XP (15/man).
    *   **Shift Bonus:** Promotes **5** Militia troops to Veterans + Adds **1** Elite Recruit to Garrison.

### Code Quality Assessment
**Rating**: **Green**
*   **Analysis**:
    *   **Structure**: Centralized `TownJobBehavior`, `CastleJobBehavior`, and `VillageLaborBehavior`.
    *   **Logic**: Implements a "Punch-Clock" system tracking hours worked. AI Work Logic (`ProcessAIHourlyWork`) uses a deterministic seed.
    *   **Performance**: Highly optimized. Uses `_cachedWorkers` to minimize allocation during hourly ticks.
    *   **Most Complicated Function**: `TownJobBehavior.ProcessAIHourlyWork` - Aggregates potential workers, assigns jobs deterministically, and applies effects.
*   **Recommendations**: None. Excellent use of caching.

---

## 3. Landlord
**Theme:** Purchasing plots of land in villages for passive income.

### Core Mechanics
*   **Buying Land:**
    *   **Costs:** 10k (Normal), 50k (Good), 100k (Great).
    *   **AI:** Lords with >150k Gold will buy plots.
*   **Production:**
    *   **Formula:** `8.0 * YieldMult * Efficiency` (Daily). **(Corrected from 5.0f)**.
    *   **Consumption:** `Garrison / 40.0`.
    *   **Stimulus:** Selling goods injects **50%** of profit into Village Gold.
*   **Economy:**
    *   **Surplus:** Split between Stash and Auto-Sell based on `StashYieldPct`.
    *   **Selling:** Items added to Village ItemRoster; Gold (Profit) given to Player.
*   **Violence (Razing):**
    *   **Action:** Burn hostile plots.
    *   **Loot:** 50% of Land Value + 5 Goods.
    *   **Consequence:** -10 Relation, -50 Hearths, **Declares War** (if not already at war).
*   **Upgrades (Guardhouse):**
    *   **Level 1:** 5,000g. Cap: 50 Troops, 200 Items.
    *   **Level 2:** 10,000g. Cap: 100 Troops, 400 Items.
    *   **Level 3:** 15,000g. Cap: 200 Troops, 600 Items.

### Code Quality Assessment
**Rating**: **Green**
*   **Analysis**:
    *   **Structure**: `EconomyBehavior` for production, `ViolenceBehavior` for pillaging.
    *   **Logic**: Production uses a robust `OnHourlyTick` (Hour 22) check. `ViolenceBehavior` correctly handles MapEvents to clear garrisons when plots are raided. 
    *   **Performance**: Efficient. Inventory logic uses `ItemRoster` efficiently.
    *   **Most Complicated Function**: `EconomyBehavior.OnHourlyTick` - Handles yield calculation, garrison consumption, surplus stashing vs. selling.
*   **Recommendations**: None. (Yield formula restored to dynamic calculation).

---

## 4. LivingLegend
**Theme:** High-end Renown spending and "Legend" status abilities.

### Core Mechanics
*   **Tier 6+ Perks:**
    *   If Clan Tier >= 6 AND Renown > 6000:
        *   **Cost:** -10 Renown/Daily.
        *   **Bonus:** +1 Militia Change daily, +2 Loyalty daily in owned settlements.
        *   **Companion Limit:** Increases by `(Renown - 6000) / 1000`.
*   **Renown Abilities (Actions):**
    *   **Call to Arms (Diplomacy):** Force a lord to join your army. **Cost: 500 Renown**.
    *   **Rally Militia (Village):** Spawn a 40-man Militia Patrol for 5 days. **Cost: 200 Renown**.
    *   **Recruit Minor Faction:** Recruit a minor faction leader as a Companion. **Cost: 2000 Renown**.

### Code Quality Assessment
**Rating**: **Green**
*   **Analysis**:
    *   **Structure**: `LivingLegendBehavior` handles renown costs; `LivingLegendModel` handles stat buffs.
    *   **Logic**: Models strictly override base values when conditions (Tier 6 + Renown) are met. Patrol spawning uses proper cleanup logic on daily tick.
    *   **Performance**: Zero impact. Model overrides are fast O(1) checks.
    *   **Most Complicated Function**: `LivingLegendBehavior.OnDailyClanTick` - Manages the "Renown Drain" and cleans up expired militia patrols.
*   **Recommendations**: None.

---

## 5. NewClans
**Theme:** Promoting companions to form new noble clans.

### Core Mechanics
*   **Cleanup:** Automatically deletes "Empty" clans (0 Heroes) on startup to keep the encyclopedia clean.
*   **Promotion (Conversation):**
    *   **Conditions:**
        *   Player is Kingdom Vassal.
        *   **Constraint**: Player cannot be the Faction Leader (King). `Clan.PlayerClan.Kingdom.Leader == Hero.MainHero` returns false.
        *   Gold >= 1,000,000.
    *   **Cost:**
        *   Player pays **1,000,000** Gold.
        *   Faction Leader receives **1,000,000** Gold.
    *   **Fief Assignment:**
        *   Takes a Castle/Town from the "Greediest" clan in the kingdom (Most fiefs).
        *   Fallback: Takes from Player.
    *   **Result:** Creates new Clan with the Companion as Leader. Companion leaves player party and teleports to fief.

### Code Quality Assessment
**Rating**: **Green**
*   **Analysis**:
    *   **Structure**: Single behavior `NewClansBehavior`.
    *   **Logic**: promotion acts as a complex transaction: Debits gold, finds "Greedy" clan, transfers fief, creates new clan, moves hero. Error handling in place for failed transfers (refunds gold).
    *   **Performance**: Logic only triggers on User Dialog interaction. No passive overhead.
    *   **Most Complicated Function**: `companion_promote_consequence` - The dense transaction script.
*   **Recommendations**: Verify `Clan.CreateCompanionToLordClan` compatibility if game version updates.

---

## 6. FieldSquire
**Theme:** Non-combatant logistics companion for supply automation and remote management.

### Core Mechanics
*   **The Squire:**
    *   **Spawn:** Unique non-combat hero ("Your Squire") spawned into party.
    *   **Party Slot:** Consumes **0** Party Capacity (`+1` Limit via Harmony if Squire is present).
*   **Remote Management:**
    *   **UI:** Custom Gauntlet Layer allows full Town Management screen access for any owned settlement.
*   **Logistics (Auto-Buy):**
    *   **Trigger:** On Settlement Entry & Hourly Tick.
    *   **Logic:**
        *   Iterates through **ALL** valid food items in settlement market.
        *   Checks player's stash count.
        *   **Buy Amount:** `Threshold - CurrentCount`.
    *   **Condition:** Player Gold > 2000.

### Code Quality Assessment
**Rating**: **Green**
*   **Analysis**:
    *   **Structure**: `SquireDialogBehavior` (Interaction), `SquireLogisticsBehavior` (Automation), `SquireSpawnBehavior` (Setup).
    *   **Logic**: `SquireDialogBehavior` caches `Hero.AllAliveHeroes` daily to prevent lag. `SquireLogisticsBehavior` intelligently scans settlement markets.
    *   **Performance**: Caching avoids the common `Hero.All` iteration lag.
    *   **Most Complicated Function**: `SquireDialogBehavior.FindWandererBySkill` - Filters global hero list by skill and distance using cached positions.
*   **Recommendations**: Ensure `SquireSpawnBehavior` correctly handles save-loading for the Squire character to prevent duplication.

---

## 7. Ascension
**Theme:** Recursive unit progression system allowing veterans to "Prestige".

### Core Mechanics
*   **Grant Ascension (Menu):**
    *   **Condition:** Party must contain **Tier 5+** non-hero troops.
*   **The Ascension Process:**
    *   **Targeting:** Finds the "Root Recruit" of the veteran unit (walks back the upgrade tree via `FindRootViaScan`).
    *   **Transformation:**
        *   Creates a new Character Object: `[OriginalID]_asc_[Rank]`.
        *   **Reset:** Unit Level reset to **1**.
    *   **Stat Boosts (Per Rank):**
        *   **All Skills:** +10 base.
        *   **Physical Skills:** +10 extra (Simulating +2 Attribute points).

### Code Quality Assessment
**Rating**: **Green**
*   **Analysis**:
    *   **Structure**: `AscensionBehavior` handles the ritual.
    *   **Logic**: Uses `FindRootViaScan` to dynamically reverse-engineer unit upgrade trees and find the "Base" unit. Caches the Root lookup (`_rootCache`) to make subsequent ascensions instant.
    *   **Performance**: Heavy initial scan (O(N) on all unit types) runs once on first demand, then cached.
    *   **Most Complicated Function**: `FindRootViaScan` - Iterates all loaded `CharacterObjects` to build a Parent->Child map and traverses it to find the root ancestor.
*   **Recommendations**: None. The caching mechanism solves the inherent performance cost of upgrade tree traversal.

---

## 8. BetterGov
**Theme:** Automated Governance and bureaucracy improvements.

### Core Mechanics
*   **Auto-Governor Assignment:** Automatically assigns party leader as Governor if the seat is empty when entering an owned settlement.
*   **Auto-Resolve Issues:**
    *   **Trigger:** Hour 14:00.
    *   **AI Governors:** Instantly resolve issues older than 7 days, granting +5 Relation.
    *   **Player Governors:** Attempts to use "Alternative Solution" via logic.

*   *(Note: BetterGov was assessed in a previous pass but is included here for completeness of the mechanics report.)*

---

## 9. Brigands
**Theme:** Expansion of Bandit factions into more organized threats.

### Core Mechanics
*   **Bandit Cohesion:** Merges small bandit parties into large "Hordes" or "Syndicate Hordes" (Cap 40-60).
*   **Terror:** Bandit parties > 2x Militia strength will target and raid villages.
*   **Warlords (The Syndicate):** Spawns "Syndicate" Lord Parties from Cruel wanderers. They declare war on everyone and demand ransom.

*   *(Note: Brigands was assessed in a previous pass but is included here for completeness of the mechanics report.)*

---

## 10. CoastalLife
**Theme:** Maritime economy and naval gameplay expansion.

### Core Mechanics
*   **Coast Guard:** Hire maritime patrols for ports.
*   **Jobs:** Deckhand, Shipwright, HarborMaster jobs with wages based on prosperity.
*   **Docking Slip:** Passive income investment (10k Cost, 10% daily return based on prosperity).

### Code Quality Assessment
**Rating**: **Red** (Excluded from Optimization)
*   **Analysis**: Known issues with `NavalDLC` dependencies and ship management.
*   **Recommendation**: Requires dedicated debugging session separate from this audit.

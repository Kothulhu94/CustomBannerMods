# Bannerlord Mods Deep Dive Analysis

This document provides a detailed breakdown of the logic, mechanics, and exact numbers for the 9 analyzed Bannerlord mods.

---

## 1. BetterGov
**Theme:** Automated Governance and bureaucracy improvements.
### Core Mechanics
*   **Auto-Governor Assignment:**
    *   **Logic:** When a party led by a clan member enters a Town/Castle owned by the same clan:
        *   If the Governor seat is **empty**, the party leader is automatically assigned as Governor.
    *   **Logic:** When the party leaves the settlement:
        *   The Governor seat is vacated (set to null).
*   **Auto-Resolve Issues:**
    *   **Trigger:** Daily Tick (Settlement).
    *   **Conditions:**
        *   Settlement has a Governor.
        *   Issue is older than **7 days**.
        *   Notable is **not** a Gang Leader.
        *   Issue is **not** being solved by a quest.
    *   **Resolution Method:**
        *   **Player Clan Governor:** Attempts to use the "Alternative Solution" (Troops/Gold/Influence cost) via Reflection (`SolveIssue`).
        *   **AI Clan Governor:**
            *   Instantly resolves issue.
            *   **Reward:** +5 Relation between Governor and Notable.
            *   Result: Issue is deactivated.

---

## 2. Brigands
**Theme:** Expansion of Bandit factions into more organized, dangerous threats.
### Core Mechanics
*   **Bandit Cohesion (Merging):**
    *   **Logic:** Merges identical bandit types (or Syndicate with Bandits) if they are close.
    *   **Priority:** Syndicate Parties > Larger Parties.
    *   **Cap:** `40 + (PlayerClanTier * 20)` troops per party.
    *   **Renaming:** Parties > 40 troops are renamed to "Grand [Culture] Horde" or "Syndicate [Culture] Horde".
*   **Recruitment (Press Gang):**
    *   **Daily:** Bandit parties recruit from their own prisoner stacks.
        *   **Chance:** **20%** per prisoner per day.
    *   **Victory Bonus:** If a bandit party wins a Raid (MapEvent), they gain **5-15** Looter recruits instantly.
*   **Terror (Raiding AI):**
    *   **Trigger:** Hourly.
    *   **Range:** Scans settlements within distance squared 22500 (~150.0f units).
    *   **Condition:** Bandit Strength > (Militia Strength * **2.0**).
    *   **Corsairs:** Only target Coastal/River settlements (water within 3.0f radius).
    *   **Action:** Orders the bandit party to Raid the village.
*   **Training:**
    *   **Daily XP:** Every bandit Troop Stack gains **500 XP** per man.
    *   **Upgrades:** If troops have enough XP, they automatically upgrade to a random target, bypassing usual AI budget restrictions.
*   **Warlords (The Syndicate):**
    *   **Spawn Logic (Weekly):** Scans Towns for Wanderers (Companions) with no party.
        *   **Condition:** Trait Mercy < 0 (Cruel) **OR** Roguery > 60.
        *   **Chance:** **10%** per week.
        *   **Effect:** Creates "TheSyndicate" Lord Party commanded by the Wanderer.
    *   **Diplomacy:** "TheSyndicate" clan declares war on **everyone** (Clans and Kingdoms) daily. Relation set to **-100**.
    *   **Recruitment:** Defeating a Warlord allows the player to recruit them as a Companion via dialogue (if they are a prisoner).

---

## 3. CoastalLife
**Theme:** Maritime economy and naval gameplay expansion.
### Core Mechanics
*   **Coast Guard:**
    *   **Commission:** Player can hire patrols at towns.
    *   **Cost:** `(MarineTier * 50 * 20) + (ShipValue * 2)`.
    *   **Composition:** 20 Marines + 2 Ships.
    *   **AI Spawning:** AI Coastal Towns at war with > 5x cost in gold have a **20%** daily chance to spawn a patrol.
*   **Jobs (CoastalJobBehavior):**
    *   **Wage:** `TownProsperity / 500` (Base).
    *   **Deckhand:** Base Wage + Mariner XP.
    *   **Shipwright:** Base Wage * **1.5** + Boatswain XP.
    *   **HarborMaster:** Base Wage * **2.0** + Shipmaster XP.
    *   **Shift Bonus (8h):** +0.5 Renown.
*   **Docking Slip (PortEconomy):**
    *   **Cost:** **10,000** Gold.
    *   **Income:** Daily Gold = `TownProsperity * 0.1`.
    *   **Logic:** Checks daily if the player owns the slip via a Dictionary lookup.

---

## 4. HappyParty
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
    *   **Daily:** Checks for Clan Heroes stuck in settlements (no party).
    *   **Action:** Teleports them to the Clan Leader's party or a War Party.

---

## 5. HonestWork
**Theme:** immersive player jobs in towns and villages.
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

---

## 6. Landlord
**Theme:** Purchasing plots of land in villages for passive income and production.
### Core Mechanics
*   **Buying Land:**
    *   **Slots:** 3 per Village.
    *   **Tier 1:** 10,000g (Yield 1.0x).
    *   **Tier 2:** 50,000g (Yield 1.2x).
    *   **Tier 3:** 100,000g (Yield 1.5x).
*   **Production Logic:**
    *   Player selects a crop (Food/Animal).
    *   **Daily Output:** `5.0 * YieldMultiplier`.
    *   **Consumption:** Garrison consumes `TroopCount / 40.0` units.
*   **Economy:**
    *   **Surplus:** Split between Stash and Auto-Sell based on `StashYieldPct`.
    *   **Selling:** Items added to Village ItemRoster; Gold (Profit) given to Player.
*   **Upgrades (Guardhouse):**
    *   **Level 1:** 5,000g. Cap: 50 Troops, 200 Items.
    *   **Level 2:** 10,000g. Cap: 100 Troops, 400 Items.
    *   **Level 3:** 15,000g. Cap: 200 Troops, 600 Items.
*   **Violence:**
    *   **Raze:** Burning a hostile plot removes it and reduces Village Hearths by **50**.
    *   **War:** Player can declare war via the plot menu if relations allow.

---

## 7. LivingLegend
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

---

## 8. NewClans
**Theme:** Promoting companions to form new noble clans.
### Core Mechanics
*   **Cleanup:**
    *   Automatically deletes "Empty" clans (0 Heroes) on startup to keep the encyclopedia clean.
*   **Promotion (Conversation):**
    *   **Conditions:**
        *   Player is Kingdom Vassal (but not King) - *Wait, checks `Clan.PlayerClan.Kingdom.Leader == Hero.MainHero` to return false. So Kings cannot promote?*
        *   Gold >= 1,000,000.
    *   **Cost:**
        *   Player pays **1,000,000** Gold.
        *   Faction Leader receives **1,000,000** Gold (Money sink/Transfer).
    *   **Fief Assignment:**
        *   Takes a Castle/Town from the "Greediest" clan in the kingdom (Most fiefs).
        *   Fallback: Takes from Player.
    *   **Result:** Creates new Clan with the Companion as Leader. Companion leaves player party and teleports to fief.

---

## 9. FieldSquire
**Theme:** Non-combatant logistics companion for supply automation and remote management.
### Core Mechanics
*   **The Squire:**
    *   **Spawn:** Unique non-combat hero ("Your Squire") spawned into party.
    *   **Party Slot:** Consumes **0** Party Capacity (`+1` Limit via Harmony if Squire is present).
    *   **Combat:** Hard-coded exclusion prevents Squire from spawning in Mission scenes.
*   **Remote Management:**
    *   **UI:** Custom Gauntlet Layer allows full Town Management screen access for any owned settlement from anywhere on the map.
    *   **Dialogue:** Triggered via conversation with Squire.
*   **Logistics (Auto-Buy):**
    *   **Trigger:** On Settlement Entry & Hourly Tick.
    *   **Settings:** Configurable Stock Threshold (5-50).
    *   **Logic (Refined):**
        *   Iterates through **ALL** valid food items in settlement market.
        *   Checks player's stash count for *that specific item*.
        *   **Buy Amount:** `Threshold - CurrentCount`.
        *   **Conditions:** Player Gold > 2000.
    *   **Cost:** Deducts gold automatically; items appear in inventory.

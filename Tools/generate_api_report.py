
import json

INPUT_FILE = "d:/Bannerlord_Mods/api_scan_results.json"
OUTPUT_FILE = "d:/Bannerlord_Mods/API_USAGE_REPORT.md"

descriptions = {
    "TaleWorlds.CampaignSystem": "Core namespace for Campaign logic (Map, Parties, Clans).",
    "TaleWorlds.Core": "Core game systems (Items, Basic Types, Managers).",
    "TaleWorlds.Library": "Low-level utilities (Math, Color, Debug, FileSystem).",
    "TaleWorlds.MountAndBlade": "Battle engine and SubModule infrastructure.",
    "TaleWorlds.Localization": "TextObject and localization system.",
    "TaleWorlds.ObjectSystem": "MBObjectBase and Guid/StringId management.",
    "TaleWorlds.Engine": "Game Engine access (WorldToScreen, Physics).",
    "TaleWorlds.ScreenSystem": "Screen management (Layers, UI state).",
    
    "CampaignEvents.HourlyTickEvent": "Event: Triggered every in-game hour.",
    "CampaignEvents.DailyTickEvent": "Event: Triggered every in-game day.",
    "CampaignEvents.WeeklyTickEvent": "Event: Triggered every in-game week.",
    "CampaignEvents.OnSessionLaunchedEvent": "Event: Triggered when the campaign session begins.",
    "CampaignEvents.OnGameLoadedEvent": "Event: Triggered after a save game is loaded.",
    "CampaignEvents.OnNewGameCreatedEvent": "Event: Triggered when a new campaign starts.",
    "CampaignEvents.SettlementEntered": "Event: Triggered when a party enters a settlement.",
    "CampaignEvents.OnSettlementLeftEvent": "Event: Triggered when a party leaves a settlement.",
    "CampaignEvents.MapEventEnded": "Event: Triggered when a battle or map event finishes.",
    "CampaignEvents.MapEventStarted": "Event: Triggered when a battle starts.",
    
    "Inherits CampaignBehaviorBase": "Class inherits from standard Campaign Behavior (Logic Container).",
    "Inherits MBSubModuleBase": "Class inherits from Module entry point.",
    
    "MobileParty.MainParty": "The player's mobile party.",
    "Clan.PlayerClan": "The player's clan.",
    "Settlement.All": "Collection of all settlements in the game.",
    "Hero.AllAliveHeroes": "Collection of all living heroes.",
    "Hero.MainHero": "The player character.",
    "Campaign.Current": "Singleton access to the active Campaign instance.",
    "Game.Current": "Singleton access to the active Game instance.",
    
    "GiveGoldAction.ApplyBetweenCharacters": "Transfers gold from one hero to another.",
    "GiveGoldAction.ApplyForSettlementToParty": "Transfers gold from a settlement to a party.",
    "GiveGoldAction.ApplyForSettlementToCharacter": "Transfers gold from a settlement to a hero.",
    
    "AddCompanionAction.Apply": "Adds a hero to a clan as a companion.",
    "AddHeroToPartyAction.Apply": "Adds a hero to a specific mobile party.",
    "KillCharacterAction.ApplyByRemove": "Removes a character from the game (Soft Kill).",
    "KillCharacterAction.KillCharacterActionDetail": "Enum specifying how a character died.",
    "EndCaptivityAction.ApplyByEscape": "Releases a prisoner via escape.",
    "EndCaptivityAction.ApplyByRansom": "Releases a prisoner via ransom.",
    
    "Town.Prosperity": "The prosperity value of a town.",
    "Town.Security": "The security rating of a town.",
    "Town.Loyalty": "The loyalty rating of a town.",
    "Village.Hearth": "The hearth (population/growth) value of a village.",
    
    "InformationManager.DisplayMessage": "Displays a chat message to the player.",
    "InformationManager.ShowInquiry": "Opens a popup dialog box.",
}

def get_category(name):
    if "Event" in name: return "Events"
    if "Action" in name: return "Actions (State Changes)"
    if "TaleWorlds" in name or "System" in name: return "Namespaces & Core"
    if "Inherits" in name: return "Architecture"
    if any(x in name for x in ["Town", "Village", "Clan", "Hero", "MobileParty", "Settlement"]): return "Game Entities (Properties)"
    if "InformationManager" in name: return "UI & Feedback"
    return "Other APIs"

def main():
    with open(INPUT_FILE, 'r') as f:
        data = json.load(f)

    # Group by category
    categories = {
        "Architecture": [],
        "Namespaces & Core": [],
        "Events": [],
        "Actions (State Changes)": [],
        "Game Entities (Properties)": [],
        "UI & Feedback": [],
        "Other APIs": []
    }
    
    for api, details in data.items():
        cat = get_category(api)
        desc = descriptions.get(api, "Game API Method/Property.")
        categories[cat].append({
            "api": api,
            "desc": desc,
            "count": details["count"],
            "locations": details["locations"]
        })

    with open(OUTPUT_FILE, 'w') as f:
        f.write("# API Usage Report: Ten Custom Mods\n\n")
        f.write("This document lists every external Bannerlord API usage detected across the 10 custom modules.\n")
        f.write("It is grouped by functionality.\n\n")
        
        for cat, items in categories.items():
            if not items: continue
            
            f.write(f"## {cat}\n")
            f.write("| API Name | Function/Description | Usage Count | Examples |\n")
            f.write("|---|---|---|---|\n")
            
            # Sort by count desc
            items.sort(key=lambda x: x['count'], reverse=True)
            
            for item in items:
                locs = "<br>".join(item['locations'][:3])
                if len(item['locations']) > 3:
                    locs += f"<br>...(+{len(item['locations'])-3} more)"
                f.write(f"| `{item['api']}` | {item['desc']} | {item['count']} | {locs} |\n")
            f.write("\n")

if __name__ == "__main__":
    main()

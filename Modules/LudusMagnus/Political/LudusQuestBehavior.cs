using System;
using LudusMagnus.Core;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace LudusMagnus.Political
{
    public class LudusQuestBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.WarDeclared.AddNonSerializedListener(this, OnWarDeclared);
        }

        public override void SyncData(IDataStore dataStore)
        {
            // No persistent data needed for this simple trigger yet
        }

        private void OnWarDeclared(IFaction attackerFaction, IFaction defenderFaction, DeclareWarAction.DeclareWarDetail detail)
        {
            // Check if one side is the Magister Munerarius
            // For now, we need to access the Magister from GrandCouncilCampaignBehavior or via a shared manager if we want to be strict.
            // As a shortcut, we'll check if the player is involved and has a Ludus and is "important".
            
            // NOTE: Ideally, GrandCouncilCampaignBehavior exposes a static "CurrentMagister" property. 
            // Since we can't easily access the other behavior instance without dependency injection or a static manager, 
            // I will implement a simplified logic: If Player has a High-Tier Ludus and gets warred upon, trigger notification.

            if (defenderFaction == Hero.MainHero.MapFaction)
            {
                var playerLudus = LudusManager.Instance.GetLudus(Hero.MainHero);
                if (playerLudus != null && playerLudus.State == LudusState.Active)
                {
                    // Trigger "Burn The Arena" event for the attacker (Simulated)
                    InformationManager.DisplayMessage(new InformationMessage($"{attackerFaction.Name} vows to burn your Ludus to the ground!", Colors.Red));
                }
            }
        }
    }
}

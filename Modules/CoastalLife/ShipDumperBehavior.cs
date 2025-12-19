using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.ObjectSystem;

namespace CoastalLife
{
    public class ShipDumperBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<ShipDumperBehavior> _logger;

        public ShipDumperBehavior(ILogger<ShipDumperBehavior> logger)
        {
            _logger = logger;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSessionLaunched(CampaignGameStarter campaignStarter)
        {
            try
            {
                _logger.LogDebug("ShipDumperBehavior: Starting Deep Reflection on NavalDLC...");

                // 1. Get NavalDLC Assembly
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                var navalAssembly = assemblies.FirstOrDefault(a => a.GetName().Name == "NavalDLC");

                if (navalAssembly == null)
                {
                    _logger.LogCritical("CRITICAL: NavalDLC Assembly NOT FOUND in AppDomain!");
                    return;
                }

                _logger.LogInformation($"Located NavalDLC Assembly: {navalAssembly.FullName}");

                // 2. Scan for relevant types
                var types = navalAssembly.GetTypes();
                var relevantTypes = types.Where(t => 
                    t.Name.Contains("Ship") || 
                    t.Name.Contains("Action") || 
                    t.Name.Contains("Patrol") ||
                    t.Name.Contains("Guard")
                ).OrderBy(t => t.Name).ToList();

                _logger.LogDebug($"Found {relevantTypes.Count} relevant types:");
                foreach (var t in relevantTypes)
                {
                    _logger.LogDebug($"TYPE: {t.Name} ({t.Namespace})");
                    
                    // Detail specific types of interest
                    if (t.Name == "Ship" || t.Name == "ChangeShipOwnerAction")
                    {
                        _logger.LogDebug($"  --- Details for {t.Name} ---");
                        
                        // Constructors
                        foreach (var ctor in t.GetConstructors())
                        {
                            var p = string.Join(", ", ctor.GetParameters().Select(param => $"{param.ParameterType.Name} {param.Name}"));
                            _logger.LogDebug($"  CTOR: {t.Name}({p})");
                        }

                        // Methods (Public Static) - often used for Actions
                        foreach (var method in t.GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.DeclaredOnly))
                        {
                            var p = string.Join(", ", method.GetParameters().Select(param => $"{param.ParameterType.Name} {param.Name}"));
                            _logger.LogDebug($"  METHOD: {method.ReturnType.Name} {method.Name}({p})");
                        }
                    }
                }
                
                _logger.LogInformation("ShipDumperBehavior: Reflection Complete.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"ShipDumperBehavior Error: {ex.Message}");
                _logger.LogError(ex.StackTrace);
            }
        }
    }
}

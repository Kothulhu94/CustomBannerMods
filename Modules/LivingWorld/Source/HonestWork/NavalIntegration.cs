using System;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using HarmonyLib;

namespace HonestWork
{
    public static class NavalIntegration
    {
        private static bool? _isEnabled;
        public static bool IsEnabled 
        {
            get 
            {
                if (!_isEnabled.HasValue) Initialize();
                return _isEnabled.Value;
            }
        }

        public static SkillObject Mariner { get; private set; }
        public static SkillObject Boatswain { get; private set; }
        public static SkillObject Shipmaster { get; private set; }

        private static MethodInfo _getShipyardMethod;

        public static void Initialize()
        {
            _isEnabled = false;
            try 
            {
                Type skillsType = AccessTools.TypeByName("NavalDLC.CharacterDevelopment.NavalSkills");
                if (skillsType != null)
                {
                    // Mariner
                    Mariner = (AccessTools.Property(skillsType, "Mariner")?.GetValue(null) 
                               ?? AccessTools.Field(skillsType, "Mariner")?.GetValue(null)) as SkillObject;
                    
                    // Boatswain
                    Boatswain = (AccessTools.Property(skillsType, "Boatswain")?.GetValue(null) 
                                 ?? AccessTools.Field(skillsType, "Boatswain")?.GetValue(null)) as SkillObject;
                    
                    // Shipmaster
                    Shipmaster = (AccessTools.Property(skillsType, "Shipmaster")?.GetValue(null) 
                                  ?? AccessTools.Field(skillsType, "Shipmaster")?.GetValue(null)) as SkillObject;
                }

                Type extensionsType = AccessTools.TypeByName("NavalDLC.NavalDLCExtensions");
                if (extensionsType != null)
                {
                    _getShipyardMethod = AccessTools.Method(extensionsType, "GetShipyard", new[] { typeof(Town) });
                }

                _isEnabled = Mariner != null && _getShipyardMethod != null;
                
                if (_isEnabled.Value)
                {
                    Serilog.Log.Information("NavalIntegration: Initialized successfully. Skills: Mariner={Mariner}, Boatswain={Boatswain}, Shipmaster={Shipmaster}", 
                        Mariner != null, Boatswain != null, Shipmaster != null);
                }
                else
                {
                    Serilog.Log.Warning("NavalIntegration: Initialization failed or incomplete. Mariner={Mariner}, GetShipyard={GetShipyard}", 
                        Mariner != null, _getShipyardMethod != null);
                }
            }
            catch (Exception ex)
            {
                Serilog.Log.Error(ex, "NavalIntegration: Critical error during initialization.");
                _isEnabled = false;
            }
        }

        public static bool HasShipyard(Town town)
        {
            if (!IsEnabled || town == null) return false;
            try
            {
                return _getShipyardMethod.Invoke(null, new object[] { town }) != null;
            }
            catch (Exception ex)
            {
                Serilog.Log.Error(ex, "NavalIntegration: Error invoking GetShipyard for {Town}", town.Name);
                return false;
            }
        }
    }
}

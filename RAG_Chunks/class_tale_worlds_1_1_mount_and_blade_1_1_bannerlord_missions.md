--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_missions.html ---

TaleWorlds.MountAndBlade.BannerlordMissions Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [AtmosphereInfo](struct_tale_worlds_1_1_library_1_1_atmosphere_info.html) | [CreateAtmosphereInfoForMission](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_missions.html#a6199ab8333566fd27ae6e09c80a92392) (string seasonId, int timeOfDay) |
| static [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | [OpenCustomBattleMission](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_missions.html#a78b025c9e8baf6133a96ed26d70c0e0c) (string scene, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) playerCharacter, [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) playerParty, [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) enemyParty, bool isPlayerGeneral, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) playerSideGeneralCharacter, string sceneLevels="", string seasonString="", float timeOfDay=6) |
| static [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | [OpenSiegeMissionWithDeployment](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_missions.html#a4e66743fba642d3ae975e83dadd2ab8d) (string scene, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) playerCharacter, [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) playerParty, [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) enemyParty, bool isPlayerGeneral, float[] wallHitPointPercentages, bool hasAnySiegeTower, List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > siegeWeaponsOfAttackers, List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > siegeWeaponsOfDefenders, bool isPlayerAttacker, int sceneUpgradeLevel=0, string seasonString="", bool isSallyOut=false, bool isReliefForceAttack=false, float timeOfDay=6) |
| static [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | [OpenCustomBattleLordsHallMission](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_missions.html#a730a7614c8a0a1f8adc23ec8c0ab96bf) (string scene, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) playerCharacter, [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) playerParty, [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) enemyParty, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) playerSideGeneralCharacter, string sceneLevels="", int sceneUpgradeLevel=0, string seasonString="") |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_missions.html#a6199ab8333566fd27ae6e09c80a92392)CreateAtmosphereInfoForMission()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [AtmosphereInfo](struct_tale_worlds_1_1_library_1_1_atmosphere_info.html) TaleWorlds.MountAndBlade.BannerlordMissions.CreateAtmosphereInfoForMission | ( | string | *seasonId*, | |  |  | int | *timeOfDay* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_missions.html#a78b025c9e8baf6133a96ed26d70c0e0c)OpenCustomBattleMission()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) TaleWorlds.MountAndBlade.BannerlordMissions.OpenCustomBattleMission | ( | string | *scene*, | |  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *playerCharacter*, | |  |  | [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) | *playerParty*, | |  |  | [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) | *enemyParty*, | |  |  | bool | *isPlayerGeneral*, | |  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *playerSideGeneralCharacter*, | |  |  | string | *sceneLevels* = "", | |  |  | string | *seasonString* = "", | |  |  | float | *timeOfDay* = 6 ) | | static |

Custom Battle Specific

[Common](class_tale_worlds_1_1_library_1_1_common.html)

Boundaries

Hightlights

Deployment

[Objectives](namespace_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_objectives.html)

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_missions.html#a4e66743fba642d3ae975e83dadd2ab8d)OpenSiegeMissionWithDeployment()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) TaleWorlds.MountAndBlade.BannerlordMissions.OpenSiegeMissionWithDeployment | ( | string | *scene*, | |  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *playerCharacter*, | |  |  | [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) | *playerParty*, | |  |  | [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) | *enemyParty*, | |  |  | bool | *isPlayerGeneral*, | |  |  | float[] | *wallHitPointPercentages*, | |  |  | bool | *hasAnySiegeTower*, | |  |  | List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > | *siegeWeaponsOfAttackers*, | |  |  | List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > | *siegeWeaponsOfDefenders*, | |  |  | bool | *isPlayerAttacker*, | |  |  | int | *sceneUpgradeLevel* = 0, | |  |  | string | *seasonString* = "", | |  |  | bool | *isSallyOut* = false, | |  |  | bool | *isReliefForceAttack* = false, | |  |  | float | *timeOfDay* = 6 ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_missions.html#a730a7614c8a0a1f8adc23ec8c0ab96bf)OpenCustomBattleLordsHallMission()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) TaleWorlds.MountAndBlade.BannerlordMissions.OpenCustomBattleLordsHallMission | ( | string | *scene*, | |  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *playerCharacter*, | |  |  | [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) | *playerParty*, | |  |  | [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_combatant.html) | *enemyParty*, | |  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *playerSideGeneralCharacter*, | |  |  | string | *sceneLevels* = "", | |  |  | int | *sceneUpgradeLevel* = 0, | |  |  | string | *seasonString* = "" ) | | static |


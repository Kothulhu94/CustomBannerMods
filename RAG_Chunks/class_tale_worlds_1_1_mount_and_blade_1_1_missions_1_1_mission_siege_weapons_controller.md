--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html ---

TaleWorlds.MountAndBlade.Missions.MissionSiegeWeaponsController Class ReferenceManages siege weapons on mission side for a battle side.

Inherits [TaleWorlds.MountAndBlade.Missions.IMissionSiegeWeaponsController](interface_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_i_mission_siege_weapons_controller.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionSiegeWeaponsController](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html#a38a5521229593d88ad05d53ccd284c40) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > weapons) |
| int | [GetMaxDeployableWeaponCount](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html#a7a42b0d9ed5483cf41b192276eb22eef) (Type t) |
| IEnumerable< [IMissionSiegeWeapon](interface_tale_worlds_1_1_core_1_1_i_mission_siege_weapon.html) > | [GetSiegeWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html#a9f297ebb261f332d26c9688c760360e0) () |
| void | [OnWeaponDeployed](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html#a460d3987e73c6cfce329d9789a2dc7cb) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) missionWeapon) |
| void | [OnWeaponUndeployed](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html#addf6e01c02249a55ae64e6ee99a6d314) ([SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) missionWeapon) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Type | [GetWeaponType](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html#afad2be65dd95462c8ac8cf6b0bcc54df) ([ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) weapon) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html#a38a5521229593d88ad05d53ccd284c40)MissionSiegeWeaponsController()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Missions.MissionSiegeWeaponsController.MissionSiegeWeaponsController | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > | *weapons* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html#a7a42b0d9ed5483cf41b192276eb22eef)GetMaxDeployableWeaponCount()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Missions.MissionSiegeWeaponsController.GetMaxDeployableWeaponCount | ( | Type | *t* | ) |  |

Implements [TaleWorlds.MountAndBlade.Missions.IMissionSiegeWeaponsController](interface_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_i_mission_siege_weapons_controller.html#a0b854752c803c5cef2d8980f928f6c1b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html#a9f297ebb261f332d26c9688c760360e0)GetSiegeWeapons()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [IMissionSiegeWeapon](interface_tale_worlds_1_1_core_1_1_i_mission_siege_weapon.html) > TaleWorlds.MountAndBlade.Missions.MissionSiegeWeaponsController.GetSiegeWeapons | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.Missions.IMissionSiegeWeaponsController](interface_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_i_mission_siege_weapons_controller.html#ac7412a2da7341919e04dd0dcf6c86def).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html#a460d3987e73c6cfce329d9789a2dc7cb)OnWeaponDeployed()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.MissionSiegeWeaponsController.OnWeaponDeployed | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *missionWeapon* | ) |  |

Implements [TaleWorlds.MountAndBlade.Missions.IMissionSiegeWeaponsController](interface_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_i_mission_siege_weapons_controller.html#adfb38c403b1ba7cda1e2d423cce94e66).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html#addf6e01c02249a55ae64e6ee99a6d314)OnWeaponUndeployed()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Missions.MissionSiegeWeaponsController.OnWeaponUndeployed | ( | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html) | *missionWeapon* | ) |  |

Implements [TaleWorlds.MountAndBlade.Missions.IMissionSiegeWeaponsController](interface_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_i_mission_siege_weapons_controller.html#a008abdbb8000fcac8b37cd4b802f0119).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_mission_siege_weapons_controller.html#afad2be65dd95462c8ac8cf6b0bcc54df)GetWeaponType()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Type TaleWorlds.MountAndBlade.Missions.MissionSiegeWeaponsController.GetWeaponType | ( | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | *weapon* | ) |  | | static |


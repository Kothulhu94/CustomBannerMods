--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_visual_ship_factory.html ---

TaleWorlds.MountAndBlade.VisualShipFactory Class ReferenceFactory class for instantiating visual ship and ship components to be used for Campaign and UI purposes.

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [InitializeShipEntityCache](class_tale_worlds_1_1_mount_and_blade_1_1_visual_ship_factory.html#a3e2a060b2ee96701e5448cf2a10d3203) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
| static void | [DeregisterVisualShipCache](class_tale_worlds_1_1_mount_and_blade_1_1_visual_ship_factory.html#aaf3b8635415d0c28d08fb8a300fd5bfe) () |
| static [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [CreateVisualShip](class_tale_worlds_1_1_mount_and_blade_1_1_visual_ship_factory.html#a04593a20e14415237b4acf08c3ca6319) (string shipPrefab, [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, List< [ShipVisualSlotInfo](struct_tale_worlds_1_1_core_1_1_ship_visual_slot_info.html) > upgrades, int shipSeed, float hitPointRatio, uint sailColor1=4294967295, uint sailColor2=4294967295, bool createPhysics=false) |
| static [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [CreateVisualShipForCampaign](class_tale_worlds_1_1_mount_and_blade_1_1_visual_ship_factory.html#a330362b35c5a5d955b090d355d35dbf3) (string shipPrefab, [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, List< [ShipVisualSlotInfo](struct_tale_worlds_1_1_core_1_1_ship_visual_slot_info.html) > upgrades, int shipSeed, string shipCustomSailPatternId, uint sailColor1=4294967295, uint sailColor2=4294967295) |
| static void | [RefreshUpgrades](class_tale_worlds_1_1_mount_and_blade_1_1_visual_ship_factory.html#ad5219e1eb29e3fc0b9d90dbd0a46040b) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) shipEntity, List< [ShipVisualSlotInfo](struct_tale_worlds_1_1_core_1_1_ship_visual_slot_info.html) > upgrades) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_visual_ship_factory.html#a3e2a060b2ee96701e5448cf2a10d3203)InitializeShipEntityCache()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.VisualShipFactory.InitializeShipEntityCache | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_visual_ship_factory.html#aaf3b8635415d0c28d08fb8a300fd5bfe)DeregisterVisualShipCache()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.VisualShipFactory.DeregisterVisualShipCache | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_visual_ship_factory.html#a04593a20e14415237b4acf08c3ca6319)CreateVisualShip()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.VisualShipFactory.CreateVisualShip | ( | string | *shipPrefab*, | |  |  | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | List< [ShipVisualSlotInfo](struct_tale_worlds_1_1_core_1_1_ship_visual_slot_info.html) > | *upgrades*, | |  |  | int | *shipSeed*, | |  |  | float | *hitPointRatio*, | |  |  | uint | *sailColor1* = 4294967295, | |  |  | uint | *sailColor2* = 4294967295, | |  |  | bool | *createPhysics* = false ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_visual_ship_factory.html#a330362b35c5a5d955b090d355d35dbf3)CreateVisualShipForCampaign()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.VisualShipFactory.CreateVisualShipForCampaign | ( | string | *shipPrefab*, | |  |  | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | List< [ShipVisualSlotInfo](struct_tale_worlds_1_1_core_1_1_ship_visual_slot_info.html) > | *upgrades*, | |  |  | int | *shipSeed*, | |  |  | string | *shipCustomSailPatternId*, | |  |  | uint | *sailColor1* = 4294967295, | |  |  | uint | *sailColor2* = 4294967295 ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_visual_ship_factory.html#ad5219e1eb29e3fc0b9d90dbd0a46040b)RefreshUpgrades()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.VisualShipFactory.RefreshUpgrades | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *shipEntity*, | |  |  | List< [ShipVisualSlotInfo](struct_tale_worlds_1_1_core_1_1_ship_visual_slot_info.html) > | *upgrades* ) | | static |


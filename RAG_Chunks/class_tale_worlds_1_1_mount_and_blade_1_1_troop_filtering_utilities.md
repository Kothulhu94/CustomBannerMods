--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html ---

TaleWorlds.MountAndBlade.TroopFilteringUtilities Class ReferenceHelper class which keeps static method for troop filtering operations using troop trait masks.

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) | [GetFilter](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#ab4e416a16ca1759e72019670adacc696) (bool isMounted, bool isRanged, bool isMelee, bool hasHeavyArmor, bool hasThrown, bool hasSpear, bool hasShield) |
|  | Constructs and returns a troop filter from the given values. |
| static [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) | [GetFilter](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a5937d05309f7288631441d08664c63d7) (params [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90)[] formationClasses) |
|  | Returns a troop traits mask for the given list of formation classes. |
| static [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) | [GetFilter](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a50922dfbb99992e3837db665cde638b6) (params [FormationFilterType](namespace_tale_worlds_1_1_core.html#a18e2f46c2749a54afdee287077060ae9)[] filterTypes) |
|  | Returns a troop traits mask for the given formation filter types. |
| static void | [GetPriorityFunction](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#ad5bdaa76d5c7487a5318b160d1558440) ([TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) filter, out Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), int > priorityFunc) |
|  | Returns a priority scoring function for evaluating agents for the given troop filter. |
| static void | [GetPriorityFunction](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#af172d5b39231379777c93b1fdf0b73fe) ([TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) filter, out Func< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html), int > priorityFunc) |
|  | Returns a priority scoring function for evaluating agent origins for the given troop filter. |
| static int | [GetTroopPriority](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a863449f4ed58ffc4e17116432c899fdc) ([TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) troopMask, int battleTier, [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) filter) |
|  | Returns troop priority for the given troop mask, the troop's battle tier and a troop mask filter. |
| static int | [GetMaxPriority](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a6ea35786f00449f9a19cf462b75c9862) ([TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) filter) |
|  | Returns maximum priority score a troop filter can get. |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MinPriority](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a1b6030edc51d5b65bc43fc386f629ef0) = 1 |
|  | Minimum priority score which is always added to make sure max priority is never zero for any filter. |
| const int | [EquipmentPriority](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a744fda71d53b696be07b28c92b8838bf) = 10 |
|  | Default score for equipment (i.e. having spear, having heavy armor, having shield). |
| const int | [EngagementTypePriority](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a1bd27b6d37cfe021effdfd513f1679ec) = 100 |
|  | Default score for troop being melee or ranged. |
| const int | [MountedPriority](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#ab0bea54bc090d579d81f7609de4357ef) = 1000 |
|  | Score for being mounted or not. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#ab4e416a16ca1759e72019670adacc696)GetFilter() [1/3]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) TaleWorlds.MountAndBlade.TroopFilteringUtilities.GetFilter | ( | bool | *isMounted*, | |  |  | bool | *isRanged*, | |  |  | bool | *isMelee*, | |  |  | bool | *hasHeavyArmor*, | |  |  | bool | *hasThrown*, | |  |  | bool | *hasSpear*, | |  |  | bool | *hasShield* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a5937d05309f7288631441d08664c63d7)GetFilter() [2/3]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) TaleWorlds.MountAndBlade.TroopFilteringUtilities.GetFilter | ( | params [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90)[] | *formationClasses* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a50922dfbb99992e3837db665cde638b6)GetFilter() [3/3]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) TaleWorlds.MountAndBlade.TroopFilteringUtilities.GetFilter | ( | params [FormationFilterType](namespace_tale_worlds_1_1_core.html#a18e2f46c2749a54afdee287077060ae9)[] | *filterTypes* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#ad5bdaa76d5c7487a5318b160d1558440)GetPriorityFunction() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.TroopFilteringUtilities.GetPriorityFunction | ( | [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) | *filter*, | |  |  | out Func< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), int > | *priorityFunc* ) | | static |

This version uses [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)'s [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665 "Mask for filtering troops (both agent origins and agents) with respect to their traits.") which can dynamically change during the mission

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#af172d5b39231379777c93b1fdf0b73fe)GetPriorityFunction() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.TroopFilteringUtilities.GetPriorityFunction | ( | [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) | *filter*, | |  |  | out Func< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html), int > | *priorityFunc* ) | | static |

This version uses agent origin's troop traits mask which is constant throughout the mission

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a863449f4ed58ffc4e17116432c899fdc)GetTroopPriority()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.TroopFilteringUtilities.GetTroopPriority | ( | [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) | *troopMask*, | |  |  | int | *battleTier*, | |  |  | [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) | *filter* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a6ea35786f00449f9a19cf462b75c9862)GetMaxPriority()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.TroopFilteringUtilities.GetMaxPriority | ( | [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) | *filter* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a1b6030edc51d5b65bc43fc386f629ef0)MinPriority
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.TroopFilteringUtilities.MinPriority = 1 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a744fda71d53b696be07b28c92b8838bf)EquipmentPriority
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.TroopFilteringUtilities.EquipmentPriority = 10 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#a1bd27b6d37cfe021effdfd513f1679ec)EngagementTypePriority
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.TroopFilteringUtilities.EngagementTypePriority = 100 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_troop_filtering_utilities.html#ab0bea54bc090d579d81f7609de4357ef)MountedPriority
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.TroopFilteringUtilities.MountedPriority = 1000 | | static |


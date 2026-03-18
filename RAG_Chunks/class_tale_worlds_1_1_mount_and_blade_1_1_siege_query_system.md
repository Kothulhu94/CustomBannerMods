--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html ---

TaleWorlds.MountAndBlade.SiegeQuerySystem Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SiegeQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#ac0a8c3bace296ede9fb0227f4d4418e5) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, IEnumerable< [SiegeLane](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html) > lanes) |
| void | [Expire](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a816b8551441114c52aec640497148570) () |
| int | [DeterminePositionAssociatedSide](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a495a525c028284585a54883d919fcb29) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [AreSidesRelated](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a9f156797bae2add374ba5a09a9e1efe0) ([FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) side, int connectedSides) |
| static int | [SideDistance](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a9d4f921c5e9ede9cccecb40a683e9228) (int connectedSides, int side) |
|  | Right shifts both until one is zero then counts remaining 0 bits right of meaningful bits to determine binary distance. |

|  |  |
| --- | --- |
| Public Attributes | |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [DefenderLeftToDefenderMidDir](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a2fa607040df2e2b7f0dbfc9ee0fa1d86) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [DefenderMidToDefenderRightDir](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#aa85e72379dfc978b0b2be40730cd689a) |

|  |  |
| --- | --- |
| Properties | |
| int | [LeftRegionMemberCount](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a4b7c4ca9862ddbd14b5974da067ffd9f) `[get]` |
| int | [LeftCloseAttackerCount](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a18e88dc7c9d8aa6f44b06be1e9c688f7) `[get]` |
| int | [MiddleRegionMemberCount](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#affa578801b404d7279c05d85c5eb062d) `[get]` |
| int | [MiddleCloseAttackerCount](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a4852fcd0e8128eea62409692c3eadfe9) `[get]` |
| int | [RightRegionMemberCount](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a33fd0f484302aea8c3b1d80d08743776) `[get]` |
| int | [RightCloseAttackerCount](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#ac620ee45e22c6e43074d5b54006e7951) `[get]` |
| int | [InsideAttackerCount](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a7e33d88f9e621cfcbf49e7c00c060309) `[get]` |
| int | [LeftDefenderCount](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a0e30dfae8a89175e667c896bd34444d5) `[get]` |
| int | [MiddleDefenderCount](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a886c536c0eaa6a4197ae11416c96fc94) `[get]` |
| int | [RightDefenderCount](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#affc365671f293167243e792250d6897e) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [LeftDefenderOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#aca4adc051ba7df81c8230745ff5a8d4f) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [MidDefenderOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#aec989ae95f3f223695b6dac98c7ff2a7) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [RightDefenderOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#af81aa7631942fda3d3d9c0ca3301a022) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [LeftAttackerOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a821598e9d77cc8de51f34fda04829b27) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [MiddleAttackerOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a036ae7f01a0fd438e96fd0c29d6794e3) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [RightAttackerOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a41f3af122f4a7c85134609ba393cddc0) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [LeftToMidDir](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a639187037b44823f2c6e46dc42fa75a2) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [MidToLeftDir](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a0e7ee5047c8a972bb942d4fb7adeeee8) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [MidToRightDir](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a313d8c44e74ce9b346cdd92643f031f5) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [RightToMidDir](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a41c82cc4804ac1e050df64f3b170b5ef) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#ac0a8c3bace296ede9fb0227f4d4418e5)SiegeQuerySystem()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.SiegeQuerySystem.SiegeQuerySystem | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | IEnumerable< [SiegeLane](class_tale_worlds_1_1_mount_and_blade_1_1_siege_lane.html) > | *lanes* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a816b8551441114c52aec640497148570)Expire()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeQuerySystem.Expire | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a495a525c028284585a54883d919fcb29)DeterminePositionAssociatedSide()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.SiegeQuerySystem.DeterminePositionAssociatedSide | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a9f156797bae2add374ba5a09a9e1efe0)AreSidesRelated()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.SiegeQuerySystem.AreSidesRelated | ( | [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) | *side*, | |  |  | int | *connectedSides* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a9d4f921c5e9ede9cccecb40a683e9228)SideDistance()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.SiegeQuerySystem.SideDistance | ( | int | *connectedSides*, | |  |  | int | *side* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | connectedSides |  |

Bitwise representation of sides connected

Parameters
:   |  |  |
    | --- | --- |
    | side |  |

side to compare to

Returns

Distance between logical sides

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a2fa607040df2e2b7f0dbfc9ee0fa1d86)DefenderLeftToDefenderMidDir
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.SiegeQuerySystem.DefenderLeftToDefenderMidDir |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#aa85e72379dfc978b0b2be40730cd689a)DefenderMidToDefenderRightDir
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.SiegeQuerySystem.DefenderMidToDefenderRightDir |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a4b7c4ca9862ddbd14b5974da067ffd9f)LeftRegionMemberCount
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeQuerySystem.LeftRegionMemberCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a18e88dc7c9d8aa6f44b06be1e9c688f7)LeftCloseAttackerCount
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeQuerySystem.LeftCloseAttackerCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#affa578801b404d7279c05d85c5eb062d)MiddleRegionMemberCount
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeQuerySystem.MiddleRegionMemberCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a4852fcd0e8128eea62409692c3eadfe9)MiddleCloseAttackerCount
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeQuerySystem.MiddleCloseAttackerCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a33fd0f484302aea8c3b1d80d08743776)RightRegionMemberCount
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeQuerySystem.RightRegionMemberCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#ac620ee45e22c6e43074d5b54006e7951)RightCloseAttackerCount
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeQuerySystem.RightCloseAttackerCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a7e33d88f9e621cfcbf49e7c00c060309)InsideAttackerCount
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeQuerySystem.InsideAttackerCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a0e30dfae8a89175e667c896bd34444d5)LeftDefenderCount
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeQuerySystem.LeftDefenderCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a886c536c0eaa6a4197ae11416c96fc94)MiddleDefenderCount
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeQuerySystem.MiddleDefenderCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#affc365671f293167243e792250d6897e)RightDefenderCount
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.SiegeQuerySystem.RightDefenderCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#aca4adc051ba7df81c8230745ff5a8d4f)LeftDefenderOrigin
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.SiegeQuerySystem.LeftDefenderOrigin | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#aec989ae95f3f223695b6dac98c7ff2a7)MidDefenderOrigin
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.SiegeQuerySystem.MidDefenderOrigin | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#af81aa7631942fda3d3d9c0ca3301a022)RightDefenderOrigin
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.SiegeQuerySystem.RightDefenderOrigin | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a821598e9d77cc8de51f34fda04829b27)LeftAttackerOrigin
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.SiegeQuerySystem.LeftAttackerOrigin | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a036ae7f01a0fd438e96fd0c29d6794e3)MiddleAttackerOrigin
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.SiegeQuerySystem.MiddleAttackerOrigin | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a41f3af122f4a7c85134609ba393cddc0)RightAttackerOrigin
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.SiegeQuerySystem.RightAttackerOrigin | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a639187037b44823f2c6e46dc42fa75a2)LeftToMidDir
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.SiegeQuerySystem.LeftToMidDir | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a0e7ee5047c8a972bb942d4fb7adeeee8)MidToLeftDir
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.SiegeQuerySystem.MidToLeftDir | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a313d8c44e74ce9b346cdd92643f031f5)MidToRightDir
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.SiegeQuerySystem.MidToRightDir | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html#a41c82cc4804ac1e050df64f3b170b5ef)RightToMidDir
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.SiegeQuerySystem.RightToMidDir | | get |


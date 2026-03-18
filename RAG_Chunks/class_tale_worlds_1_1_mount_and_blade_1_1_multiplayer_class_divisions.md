--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html ---

TaleWorlds.MountAndBlade.MultiplayerClassDivisions Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) |
| class | [MPHeroClassGroup](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class_group.html) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static IEnumerable< [MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) > | [GetMPHeroClasses](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a3004d3d3dea039ceb10ed3036eb75b3b) ([BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture) |
| static MBReadOnlyList< [MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) > | [GetMPHeroClasses](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a6e5e775db09e013afcdc7b65efe587f4) () |
| static [MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) | [GetMPHeroClassForCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#aff2ae1ce79854643315ebaf67be18e0c) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character) |
| static List< List< [IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html) > > | [GetAllPerksForHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a905b54e32ffc62b87e1c82d97ecf50bf) ([MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) heroClass, string forcedForGameMode=null) |
| static [MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) | [GetMPHeroClassForPeer](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#af2a6846020ab198717db30c85b1ef5ae) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer, bool skipTeamCheck=false) |
| static [TargetIconType](namespace_tale_worlds_1_1_mount_and_blade.html#ac880639f3f1119ec55dca3b0a70a0ca4) | [GetMPHeroClassForFormation](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a6f94f24f43e10a310d4bd0013e216ccf) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| static List< List< [IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html) > > | [GetAvailablePerksForPeer](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a23a7ea3fc22bcfb194f097733b5673ed) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer) |
| static void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a57aeb9d8052be31ad20910003004ba95) () |
| static void | [Release](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#aa18c6e015b572df7073bee1dccf86dd7) () |
| static int | [GetMinimumTroopCost](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a9f796f823c46d954589f66a1f5250f72) ([BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture=null) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static IEnumerable< [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) > | [AvailableCultures](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a8efa19f6c1a5da33aa582ffaf8ad7f98) |

|  |  |
| --- | --- |
| Properties | |
| static List< [MPHeroClassGroup](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class_group.html) > | [MultiplayerHeroClassGroups](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a0710b8529133258da5c3f9d65f3acae7) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a3004d3d3dea039ceb10ed3036eb75b3b)GetMPHeroClasses() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) > TaleWorlds.MountAndBlade.MultiplayerClassDivisions.GetMPHeroClasses | ( | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a6e5e775db09e013afcdc7b65efe587f4)GetMPHeroClasses() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | MBReadOnlyList< [MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) > TaleWorlds.MountAndBlade.MultiplayerClassDivisions.GetMPHeroClasses | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#aff2ae1ce79854643315ebaf67be18e0c)GetMPHeroClassForCharacter()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.GetMPHeroClassForCharacter | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a905b54e32ffc62b87e1c82d97ecf50bf)GetAllPerksForHeroClass()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< List< [IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html) > > TaleWorlds.MountAndBlade.MultiplayerClassDivisions.GetAllPerksForHeroClass | ( | [MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) | *heroClass*, | |  |  | string | *forcedForGameMode* = null ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#af2a6846020ab198717db30c85b1ef5ae)GetMPHeroClassForPeer()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.GetMPHeroClassForPeer | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer*, | |  |  | bool | *skipTeamCheck* = false ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a6f94f24f43e10a310d4bd0013e216ccf)GetMPHeroClassForFormation()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TargetIconType](namespace_tale_worlds_1_1_mount_and_blade.html#ac880639f3f1119ec55dca3b0a70a0ca4) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.GetMPHeroClassForFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a23a7ea3fc22bcfb194f097733b5673ed)GetAvailablePerksForPeer()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< List< [IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html) > > TaleWorlds.MountAndBlade.MultiplayerClassDivisions.GetAvailablePerksForPeer | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *missionPeer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a57aeb9d8052be31ad20910003004ba95)Initialize()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MultiplayerClassDivisions.Initialize | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#aa18c6e015b572df7073bee1dccf86dd7)Release()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MultiplayerClassDivisions.Release | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a9f796f823c46d954589f66a1f5250f72)GetMinimumTroopCost()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MultiplayerClassDivisions.GetMinimumTroopCost | ( | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture* = null | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a8efa19f6c1a5da33aa582ffaf8ad7f98)AvailableCultures
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html)> TaleWorlds.MountAndBlade.MultiplayerClassDivisions.AvailableCultures | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions.html#a0710b8529133258da5c3f9d65f3acae7)MultiplayerHeroClassGroups
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[MPHeroClassGroup](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class_group.html)> TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MultiplayerHeroClassGroups | | staticget |


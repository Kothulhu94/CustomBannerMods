--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html ---

TaleWorlds.MountAndBlade.MPPerkSelectionManager Class Reference|  |  |
| --- | --- |
| Classes | |
| struct | [MPPerkSelection](struct_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager_1_1_m_p_perk_selection.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [InitializeForUser](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#a3df2c88bde0ee0335a48135c2d47cbd5) (string username, PlayerId playerId) |
| void | [ResetPendingChanges](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#af010fc871097d0bc7034fbd460b30423) () |
| void | [TryToApplyAndSavePendingChanges](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#a99571ea186a2b5a0aae303c3903d77e8) () |
| List< [MPPerkSelection](struct_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager_1_1_m_p_perk_selection.html) > | [GetSelectionsForHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#a80032f8a4c7c8f383d9e4d0f5b6cbd9d) ([MultiplayerClassDivisions.MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) currentHeroClass) |
| void | [SetSelectionsForHeroClassTemporarily](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#a9eda2ea7c33feff7a2d30516ecdfc038) ([MultiplayerClassDivisions.MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) currentHeroClass, List< [MPPerkSelection](struct_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager_1_1_m_p_perk_selection.html) > perkChoices) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [FreeInstance](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#a3be2aca6117a8037bc89abf571fca632) () |

|  |  |
| --- | --- |
| Public Attributes | |
| Action | [OnAfterResetPendingChanges](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#a9bb06204413c9602645498ab02ff3e45) |

|  |  |
| --- | --- |
| Properties | |
| static [MPPerkSelectionManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html) | [Instance](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#ac85c94253015564f29401b5cbdc41de3) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#a3be2aca6117a8037bc89abf571fca632)FreeInstance()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MPPerkSelectionManager.FreeInstance | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#a3df2c88bde0ee0335a48135c2d47cbd5)InitializeForUser()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MPPerkSelectionManager.InitializeForUser | ( | string | *username*, |
|  |  | PlayerId | *playerId* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#af010fc871097d0bc7034fbd460b30423)ResetPendingChanges()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MPPerkSelectionManager.ResetPendingChanges | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#a99571ea186a2b5a0aae303c3903d77e8)TryToApplyAndSavePendingChanges()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MPPerkSelectionManager.TryToApplyAndSavePendingChanges | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#a80032f8a4c7c8f383d9e4d0f5b6cbd9d)GetSelectionsForHeroClass()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [MPPerkSelection](struct_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager_1_1_m_p_perk_selection.html) > TaleWorlds.MountAndBlade.MPPerkSelectionManager.GetSelectionsForHeroClass | ( | [MultiplayerClassDivisions.MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) | *currentHeroClass* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#a9eda2ea7c33feff7a2d30516ecdfc038)SetSelectionsForHeroClassTemporarily()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MPPerkSelectionManager.SetSelectionsForHeroClassTemporarily | ( | [MultiplayerClassDivisions.MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) | *currentHeroClass*, |
|  |  | List< [MPPerkSelection](struct_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager_1_1_m_p_perk_selection.html) > | *perkChoices* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#a9bb06204413c9602645498ab02ff3e45)OnAfterResetPendingChanges
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.MPPerkSelectionManager.OnAfterResetPendingChanges |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html#ac85c94253015564f29401b5cbdc41de3)Instance
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MPPerkSelectionManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_selection_manager.html) TaleWorlds.MountAndBlade.MPPerkSelectionManager.Instance | | staticget |


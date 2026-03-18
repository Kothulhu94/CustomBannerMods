--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html ---

TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView Class ReferenceInherits [TaleWorlds.MountAndBlade.UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html).

Inherited by [TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.BallistaView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ballista_view.html), [TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.BricoleView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_bricole_view.html), [TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.MangonelView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_mangonel_view.html), and [TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.TrebuchetView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_trebuchet_view.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#aaea1f3ea4532340bc5789346515df9aa) ([RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a82476c4c8a875ead39753f5fa74dfb13) rangedSiegeWeapon, [MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a1fe1e3a9aec0282030f85ac9b07d911c) missionScreen) |
| override bool | [IsOnTickRequired](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#ae7ffcb12231f728cd982e076bf3b03d6) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnAdded](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#af246232a1778c0a3ddcc115c67a811f5) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
| override void | [OnMissionReset](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a5060b26e2bebda16677fe3d7c775b1f2) () |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#ac4903130ee9f05a137c475b6a670e187) (float dt) |
| virtual void | [HandleUserInput](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a9a436c7b19d3d10b2dc5679b87a6fb8f) (float dt) |
| virtual void | [StartUsingWeaponCamera](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a0605112a1700ed98c7aac62ac0b99691) () |
| virtual void | [HandleUserCameraRotation](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a0f3d9f1e7f5609297b5281a1f8b18900) (float dt) |
| override void | [OnMissionObjectDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a5bd570c585991eade5f17e3b1b486b97) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| bool | [UsesMouseForAiming](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a5ed85defa80376429313a6094f151871) |

|  |  |
| --- | --- |
| Properties | |
| RangedSiegeWeapon | [RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a82476c4c8a875ead39753f5fa74dfb13) `[get]` |
| MissionScreen | [MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a1fe1e3a9aec0282030f85ac9b07d911c) `[get]` |
| Camera | [Camera](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a023368645647109bc8674f23387da9f6) `[get]` |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [CameraHolder](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#af78ee1581f0edd220e9a5251ba5b41a5) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [PilotAgent](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#adcdef0cd2a979397ec04bf2a16b0f758) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#aaea1f3ea4532340bc5789346515df9aa)Initialize()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.Initialize | ( | [RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a82476c4c8a875ead39753f5fa74dfb13) | *rangedSiegeWeapon*, |
|  |  | [MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a1fe1e3a9aec0282030f85ac9b07d911c) | *missionScreen* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#af246232a1778c0a3ddcc115c67a811f5)OnAdded()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.OnAdded | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a5060b26e2bebda16677fe3d7c775b1f2)OnMissionReset()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.OnMissionReset | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#ae7ffcb12231f728cd982e076bf3b03d6)IsOnTickRequired()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.IsOnTickRequired | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html#ad80280b8807678ee7ea71a287636f3a6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#ac4903130ee9f05a137c475b6a670e187)OnTick()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a9a436c7b19d3d10b2dc5679b87a6fb8f)HandleUserInput()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.HandleUserInput | ( | float | *dt* | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a0605112a1700ed98c7aac62ac0b99691)StartUsingWeaponCamera()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.StartUsingWeaponCamera | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.BallistaView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ballista_view.html#a986ae494d99e3d0b2491b5e16ab61da4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a0f3d9f1e7f5609297b5281a1f8b18900)HandleUserCameraRotation()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.HandleUserCameraRotation | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.BallistaView](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ballista_view.html#a368d346686d37407968f763a477309f4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a5bd570c585991eade5f17e3b1b486b97)OnMissionObjectDisabled()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.OnMissionObjectDisabled | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMissionObjectComponent](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object_component.html).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a5ed85defa80376429313a6094f151871)UsesMouseForAiming
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.UsesMouseForAiming | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a82476c4c8a875ead39753f5fa74dfb13)RangedSiegeWeapon
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | RangedSiegeWeapon TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.RangedSiegeWeapon | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a1fe1e3a9aec0282030f85ac9b07d911c)MissionScreen
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MissionScreen TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.MissionScreen | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#a023368645647109bc8674f23387da9f6)Camera
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Camera TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.Camera | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#af78ee1581f0edd220e9a5251ba5b41a5)CameraHolder
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.CameraHolder | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_siege_weapon_1_1_ranged_siege_weapon_view.html#adcdef0cd2a979397ec04bf2a16b0f758)PilotAgent
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.View.MissionViews.SiegeWeapon.RangedSiegeWeaponView.PilotAgent | | get |


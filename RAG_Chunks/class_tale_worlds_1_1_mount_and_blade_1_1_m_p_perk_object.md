--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html ---

TaleWorlds.MountAndBlade.MPPerkObject Class ReferenceInherits [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html).

|  |  |
| --- | --- |
| Classes | |
| class | [MPOnSpawnPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html) |
| class | [MPPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html) |
| class | [MPCombatPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| MPPerkObject | [Clone](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ad9cabb4a700515e4a780c35818464b3d) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a56e17a72ebbba7e0ca189e5d2c2f25ea) () |
| int | [GetExtraTroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ac4aa3c1383ebcd8564bae2acaa26eee5) (bool isWarmup) |
| List<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> | [GetAlternativeEquipments](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a2c6b09ac4de921c129750f8d9f3d686f) (bool isWarmup, bool isPlayer, List<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> alternativeEquipments, bool getAllEquipments=false) |
| float | [GetDrivenPropertyBonusOnSpawn](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#acec2b853234b5cd582017f5716a17ee3) (bool isWarmup, bool isPlayer, [DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) drivenProperty, float baseValue) |
| float | [GetHitpoints](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#acecad2a3bfdcc9c10ae7bee1e4801ea7) (bool isWarmup, bool isPlayer) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GetTroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a8d79b3c379df3ad8613571f96bccd52b) ([MultiplayerClassDivisions.MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) heroClass, int botsPerFormation, [MPOnSpawnPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html) onSpawnPerkHandler) |
| static [IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html) | [Deserialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a7f2b4bc70baa3a6ec1e5298027028ccc) (XmlNode node) |
| static [MPPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html) | [GetPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#aaf7558f9cb1285aa585ea9712fd36d97) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| static [MPPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html) | [GetPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a6bda19779461cec35f82aa13cbc04809) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| static [MPCombatPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html) | [GetCombatPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a267d2104f5b15659d0446596e204b4ea) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) defender) |
| static [MPOnSpawnPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html) | [GetOnSpawnPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a59636753083e9731c4534484e8dd8d66) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| static [MPOnSpawnPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html) | [GetOnSpawnPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a36f34fad1b75877c393e876ea53d582a) (IEnumerable< [IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html) > perks) |
| static void | [RaiseEventForAllPeers](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a8115ac544ad97280927aad413a1efc25) ([MPPerkCondition.PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) flags) |
| static void | [RaiseEventForAllPeersOnTeam](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ae6f2f64367a286d4f3c7782f2fbc4fdf) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) side, [MPPerkCondition.PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) flags) |
| static void | [TickAllPeerPerks](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a2219c6c4877fd54b60e93f02fc6435bf) (int tickCount) |
| static string | [RaiseEventForAllPeersCommand](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a2e695aa2f456d7dd2257cfe9c868a3f0) (List< string > strings) |
| static string | [TickAllPeerPerksCommand](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#af59e2bbc7761371a92598f6dee006fda) (List< string > strings) |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a87db9347a8c8d3be10a8c45b3912f8d0) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Description](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a1d12259de789a5613bf4de1999a2634a) `[get]` |
| bool | [HasBannerBearer](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a621a8964302da6d5bf99ee57aae96be0) `[get]` |
| List< string > | [GameModes](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a7b09f615429e92c269646d1cfbeb1dbe) `[get]` |
| int | [PerkListIndex](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#afb257b28481b951dac42734bf1a58f8b) `[get]` |
| string | [IconId](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a908f4e261ab19f37528b7a656afb4603) `[get]` |
| string | [HeroIdleAnimOverride](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ae76e21cd6e6831d29ae7f2589a63f957) `[get]` |
| string | [HeroMountIdleAnimOverride](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ab9e0e001f2e22d63f62abb9f734ee63b) `[get]` |
| string | [TroopIdleAnimOverride](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a383ab014b4461b54af41098519e7ad54) `[get]` |
| string | [TroopMountIdleAnimOverride](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a9be4720e7d4b9836553cab1bec3a5aa5) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ad9cabb4a700515e4a780c35818464b3d)Clone()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MPPerkObject TaleWorlds.MountAndBlade.MPPerkObject.Clone | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a590d9716158e98cb6929bde5fc018b0c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a56e17a72ebbba7e0ca189e5d2c2f25ea)Reset()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MPPerkObject.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ac4aa3c1383ebcd8564bae2acaa26eee5)GetExtraTroopCount()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MPPerkObject.GetExtraTroopCount | ( | bool | *isWarmup* | ) |  |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a9880940607167704d305f0fb5759bd5f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a2c6b09ac4de921c129750f8d9f3d686f)GetAlternativeEquipments()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> TaleWorlds.MountAndBlade.MPPerkObject.GetAlternativeEquipments | ( | bool | *isWarmup*, |
|  |  | bool | *isPlayer*, |
|  |  | List<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> | *alternativeEquipments*, |
|  |  | bool | *getAllEquipments* = false ) |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a081e58c27dc14774201de63cd67c04e4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#acec2b853234b5cd582017f5716a17ee3)GetDrivenPropertyBonusOnSpawn()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.GetDrivenPropertyBonusOnSpawn | ( | bool | *isWarmup*, |
|  |  | bool | *isPlayer*, |
|  |  | [DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) | *drivenProperty*, |
|  |  | float | *baseValue* ) |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a9e2bb44b66407149a818bbd13cccf6ab).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#acecad2a3bfdcc9c10ae7bee1e4801ea7)GetHitpoints()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.MPPerkObject.GetHitpoints | ( | bool | *isWarmup*, |
|  |  | bool | *isPlayer* ) |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a91694b7f608ab970776fb49a66d318dc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a8d79b3c379df3ad8613571f96bccd52b)GetTroopCount()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MPPerkObject.GetTroopCount | ( | [MultiplayerClassDivisions.MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) | *heroClass*, | |  |  | int | *botsPerFormation*, | |  |  | [MPOnSpawnPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html) | *onSpawnPerkHandler* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a7f2b4bc70baa3a6ec1e5298027028ccc)Deserialize()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html) TaleWorlds.MountAndBlade.MPPerkObject.Deserialize | ( | XmlNode | *node* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#aaf7558f9cb1285aa585ea9712fd36d97)GetPerkHandler() [1/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MPPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html) TaleWorlds.MountAndBlade.MPPerkObject.GetPerkHandler | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a6bda19779461cec35f82aa13cbc04809)GetPerkHandler() [2/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MPPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html) TaleWorlds.MountAndBlade.MPPerkObject.GetPerkHandler | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a267d2104f5b15659d0446596e204b4ea)GetCombatPerkHandler()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MPCombatPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_combat_perk_handler.html) TaleWorlds.MountAndBlade.MPPerkObject.GetCombatPerkHandler | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attacker*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *defender* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a59636753083e9731c4534484e8dd8d66)GetOnSpawnPerkHandler() [1/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MPOnSpawnPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html) TaleWorlds.MountAndBlade.MPPerkObject.GetOnSpawnPerkHandler | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a36f34fad1b75877c393e876ea53d582a)GetOnSpawnPerkHandler() [2/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MPOnSpawnPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_on_spawn_perk_handler.html) TaleWorlds.MountAndBlade.MPPerkObject.GetOnSpawnPerkHandler | ( | IEnumerable< [IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html) > | *perks* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a8115ac544ad97280927aad413a1efc25)RaiseEventForAllPeers()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MPPerkObject.RaiseEventForAllPeers | ( | [MPPerkCondition.PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) | *flags* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ae6f2f64367a286d4f3c7782f2fbc4fdf)RaiseEventForAllPeersOnTeam()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MPPerkObject.RaiseEventForAllPeersOnTeam | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *side*, | |  |  | [MPPerkCondition.PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) | *flags* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a2219c6c4877fd54b60e93f02fc6435bf)TickAllPeerPerks()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MPPerkObject.TickAllPeerPerks | ( | int | *tickCount* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a2e695aa2f456d7dd2257cfe9c868a3f0)RaiseEventForAllPeersCommand()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MPPerkObject.RaiseEventForAllPeersCommand | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#af59e2bbc7761371a92598f6dee006fda)TickAllPeerPerksCommand()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MPPerkObject.TickAllPeerPerksCommand | ( | List< string > | *strings* | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a87db9347a8c8d3be10a8c45b3912f8d0)Name
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.MPPerkObject.Name | | get |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a8b4b2de1c3b53b758591eae30b4e1fd4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a1d12259de789a5613bf4de1999a2634a)Description
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.MPPerkObject.Description | | get |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a67eb5edd1c5d423903b012577095872a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a621a8964302da6d5bf99ee57aae96be0)HasBannerBearer
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MPPerkObject.HasBannerBearer | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a7b09f615429e92c269646d1cfbeb1dbe)GameModes
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<string> TaleWorlds.MountAndBlade.MPPerkObject.GameModes | | get |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a865d428c239d09bcf0115cd32ffdf71f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#afb257b28481b951dac42734bf1a58f8b)PerkListIndex
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MPPerkObject.PerkListIndex | | get |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a7f59ba6fbdadfa56b2d4290301e9f6ba).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a908f4e261ab19f37528b7a656afb4603)IconId
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MPPerkObject.IconId | | get |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a4d101cf82f7115898b723484737dcbd4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ae76e21cd6e6831d29ae7f2589a63f957)HeroIdleAnimOverride
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MPPerkObject.HeroIdleAnimOverride | | get |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#ad2c43774f4147a525cb6e5c9e61cab3d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#ab9e0e001f2e22d63f62abb9f734ee63b)HeroMountIdleAnimOverride
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MPPerkObject.HeroMountIdleAnimOverride | | get |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a8b6be5f1bb222440689443f123861f63).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a383ab014b4461b54af41098519e7ad54)TroopIdleAnimOverride
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MPPerkObject.TroopIdleAnimOverride | | get |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a8d187eb9de1fc3fb9b0c6e76d17c5f13).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html#a9be4720e7d4b9836553cab1bec3a5aa5)TroopMountIdleAnimOverride
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MPPerkObject.TroopMountIdleAnimOverride | | get |

Implements [TaleWorlds.MountAndBlade.IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html#a23dc610b6c7681f68c9a04a5df5ed86f).


--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html ---

TaleWorlds.MountAndBlade.IFocusable Interface ReferenceInherited by [SandBox.Missions.CoverAnimalAgentComponent](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html), [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), [TaleWorlds.MountAndBlade.DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html), [TaleWorlds.MountAndBlade.DuelZoneLandmark](class_tale_worlds_1_1_mount_and_blade_1_1_duel_zone_landmark.html), [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html), and [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnFocusGain](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#a42697fa1ea31f29be949e5325dfbc95e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| void | [OnFocusLose](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#af920e5735d03cd6b971c458640fd6bba) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetInfoTextForBeingNotInteractable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#af5595369849cf9b7ba326828eab1c33d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ae296d89b1b2262987e2a6c7bb88368f8) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |

|  |  |
| --- | --- |
| Properties | |
| [FocusableObjectType](namespace_tale_worlds_1_1_mount_and_blade.html#aa83361d8fb674ed9b16444d43d30d141) | [FocusableObjectType](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ad45e6dc0d435f66db8f1dee1055b18d6) `[get]` |
| bool | [IsFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#a1acaf86c44c33cbc58c6c9b88dcd682c) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#a42697fa1ea31f29be949e5325dfbc95e)OnFocusGain()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFocusable.OnFocusGain | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent* | ) |  |

Implemented in [SandBox.Missions.CoverAnimalAgentComponent](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a5313502038b404ce0964cd167ba0f6bc), [SandBox.Objects.TeleportUsePoint](class_sand_box_1_1_objects_1_1_teleport_use_point.html#a5e009b7bf9ad718c3575671dae36b57a), [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afd52e23614f81ac535cc9265859d15aa), [TaleWorlds.MountAndBlade.DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a4e3a16a4fc574cc51126620d8c6d21ed), [TaleWorlds.MountAndBlade.DuelZoneLandmark](class_tale_worlds_1_1_mount_and_blade_1_1_duel_zone_landmark.html#afa41d4d2d1155b9ce6ae096d33a8f65f), [TaleWorlds.MountAndBlade.TrainingIcon](class_tale_worlds_1_1_mount_and_blade_1_1_training_icon.html#a64be363610fadd2f144853610f428a4b), [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a54afc29002fc4db9129e2a222266c789), and [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aa15a812a0128b612164af424d85ea4e6).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#af920e5735d03cd6b971c458640fd6bba)OnFocusLose()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFocusable.OnFocusLose | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent* | ) |  |

Implemented in [SandBox.Missions.CoverAnimalAgentComponent](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#ad0cfd17335eeb6a81c4b12083b6aaa31), [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8a1f47e424dfb718a4165a63d1923dcf), [TaleWorlds.MountAndBlade.DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a3f77c9d85204a2de32fa94d5adaf8bab), [TaleWorlds.MountAndBlade.DuelZoneLandmark](class_tale_worlds_1_1_mount_and_blade_1_1_duel_zone_landmark.html#afcca93b3b9cd3bd65f426561144e5d5c), [TaleWorlds.MountAndBlade.TrainingIcon](class_tale_worlds_1_1_mount_and_blade_1_1_training_icon.html#a16c516af7f5ff17a71bd8e0e2eec0705), [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a5756d077496044cac2ed3623cd19af6a), and [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#af997bed64c826467232fec994242a010).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#af5595369849cf9b7ba326828eab1c33d)GetInfoTextForBeingNotInteractable()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.IFocusable.GetInfoTextForBeingNotInteractable | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent* | ) |  |

Implemented in [SandBox.Missions.CoverAnimalAgentComponent](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a2eea6cf3d4df1a34b4727233a30bb220), [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae27eac28789e19d43459a8e31de7721e), [TaleWorlds.MountAndBlade.DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a0a0fb220200601a625ed4598592c4c33), [TaleWorlds.MountAndBlade.DuelZoneLandmark](class_tale_worlds_1_1_mount_and_blade_1_1_duel_zone_landmark.html#a0a4a71fcc5822faf2ef9fc9709d9f77c), [TaleWorlds.MountAndBlade.SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html#a2bb9865c15594a2daa01561888ea49a8), [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#aff8ecaec44cb3bcc0197ecf6f9b01d14), and [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aab1cbfda24ec2b6849b953b8f29e9b6a).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ae296d89b1b2262987e2a6c7bb88368f8)GetDescriptionText()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.IFocusable.GetDescriptionText | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  |

Implemented in [SandBox.Missions.CoverAnimalAgentComponent](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a3cb22f77a8d4c0efab0d84062b7b712f), [SandBox.Objects.PatrolPoint](class_sand_box_1_1_objects_1_1_patrol_point.html#a11664d186ee6ad4c694d43d4f0ac6aa8), [SandBox.Objects.Usables.Chair](class_sand_box_1_1_objects_1_1_usables_1_1_chair.html#a803202e0365fd67072dd468317e17baf), [SandBox.Objects.Usables.CheckpointUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_checkpoint_use_point.html#a58712abbf05d416fe2f6f86e1c77fbad), [SandBox.Objects.Usables.DisguiseMissionUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_disguise_mission_use_point.html#aecc461ec67eb2589fbc5f00149b52586), [SandBox.Objects.Usables.MusicianGroup](class_sand_box_1_1_objects_1_1_usables_1_1_musician_group.html#aa9aef6b5f71b5bdf6aa7eaaf6dda787e), [SandBox.Objects.Usables.Passage](class_sand_box_1_1_objects_1_1_usables_1_1_passage.html#ab3cdd46150f67fcf7bad4173b517719c), [SandBox.Objects.Usables.PatrolArea](class_sand_box_1_1_objects_1_1_usables_1_1_patrol_area.html#a4522f6f3b519692dff09affbd5f4891d), [SandBox.Objects.Usables.ShadowingSecureZoneUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_shadowing_secure_zone_use_point.html#aadf53f7e72ecd86b74a8920ccadc342e), [SandBox.Objects.Usables.SmithingMachine](class_sand_box_1_1_objects_1_1_usables_1_1_smithing_machine.html#a27e32de129f0c7d0cd9553b73952f969), [SandBox.Objects.Usables.StealthAreaUsePoint](class_sand_box_1_1_objects_1_1_usables_1_1_stealth_area_use_point.html#a2aa5d4a40476b16bda700adea6714057), [SandBox.Objects.Usables.UsablePlace](class_sand_box_1_1_objects_1_1_usables_1_1_usable_place.html#a1219cf638a1a90261f5c0c8b84ba1996), [TaleWorlds.MountAndBlade.Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5c1fbf8210e89616442c380614e91a89), [TaleWorlds.MountAndBlade.Ballista](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#ad014df364a0e80db4a44dd1a604fe213), [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a4de21924a9d34f665d411f3642aca421), [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#ab040446d3d583c70f2ad9c0d4d42d045), [TaleWorlds.MountAndBlade.DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a4d154c8c827ddd2e51d67552e0a4b65e), [TaleWorlds.MountAndBlade.DuelZoneLandmark](class_tale_worlds_1_1_mount_and_blade_1_1_duel_zone_landmark.html#a655be32ed63bd519161a807a40382258), [TaleWorlds.MountAndBlade.ExitDoor](class_tale_worlds_1_1_mount_and_blade_1_1_exit_door.html#a70448f815fd3f620b36e447419e26ae0), [TaleWorlds.MountAndBlade.Mangonel](class_tale_worlds_1_1_mount_and_blade_1_1_mangonel.html#a4cd34408d1e2e6fa480470d97ede0322), [TaleWorlds.MountAndBlade.Objects.Usables.AmmoBarrelBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_ammo_barrel_base.html#a1755aea829a62e5e9abec0f1c1ea24b0), [TaleWorlds.MountAndBlade.Objects.Usables.ArrowBarrel](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_arrow_barrel.html#aa8c35d3c2084e77c2e8998aa9b80258d), [TaleWorlds.MountAndBlade.Objects.Usables.ClimbingMachine](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_climbing_machine.html#a1b456619c03dd633404a8713a94c9506), [TaleWorlds.MountAndBlade.Objects.Usables.EventTriggeringUsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_event_triggering_usable_machine.html#a81eb1d02dd2481b60ef7625da955d291), [TaleWorlds.MountAndBlade.Objects.Usables.JavelinBarrel](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_javelin_barrel.html#ae1673895a1d40ee43ad153a34a479a8c), [TaleWorlds.MountAndBlade.Objects.Usables.SiegeMachineStonePile](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_usables_1_1_siege_machine_stone_pile.html#abceccdf2601c7485176181b319784b3f), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#af75de6b143432318d41db7b794f60124), [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#aaf5148d54a5ac78da0554f2042d81f71), [TaleWorlds.MountAndBlade.SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html#a062ed8a3dec7f6ceca2881534badd3d2), [TaleWorlds.MountAndBlade.StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html#ae77c920ae1c4b73188884c59a6da0d03), [TaleWorlds.MountAndBlade.StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html#a9dd486a6b2539bceddb34cc6b1d2298c), [TaleWorlds.MountAndBlade.TrainingIcon](class_tale_worlds_1_1_mount_and_blade_1_1_training_icon.html#ae1a80ac1306743989e0ee8e6fdac2c48), [TaleWorlds.MountAndBlade.Trebuchet](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet.html#abed06a0e748efb7ef1b53e1a0fb08967), [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a8611445480f4dbf8da3df065933f9365), and [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#aa227a955dcb577a5d59ae329ec0298db).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ad45e6dc0d435f66db8f1dee1055b18d6)FocusableObjectType
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FocusableObjectType](namespace_tale_worlds_1_1_mount_and_blade.html#aa83361d8fb674ed9b16444d43d30d141) TaleWorlds.MountAndBlade.IFocusable.FocusableObjectType | | get |

Implemented in [SandBox.Missions.CoverAnimalAgentComponent](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a49f266359118574cc48bff9024a4ff4c), [SandBox.Objects.PassageUsePoint](class_sand_box_1_1_objects_1_1_passage_use_point.html#abf39a5ad919103bae572cc4654e02eb9), [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#aaa630923e82032586ca9e311fda7a43f), [TaleWorlds.MountAndBlade.DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#af79e0c0c4151c3d4cff3b3ea0b6f4b3b), [TaleWorlds.MountAndBlade.DuelZoneLandmark](class_tale_worlds_1_1_mount_and_blade_1_1_duel_zone_landmark.html#a305e260bbd8a99aae246edadd08e15a6), [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#abcbb0aa3eb7586452c6012a8786b8b41), and [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#ab6ff66b345c22e8dcffcd7df4c04a73f).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#a1acaf86c44c33cbc58c6c9b88dcd682c)IsFocusable
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.IFocusable.IsFocusable | | get |

Implemented in [SandBox.Missions.CoverAnimalAgentComponent](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a339f0c98f1e3bed7c41bd45c57d81afa), [TaleWorlds.MountAndBlade.DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html#a77399e5de500757ae9a71a42c718cd25), [TaleWorlds.MountAndBlade.DuelZoneLandmark](class_tale_worlds_1_1_mount_and_blade_1_1_duel_zone_landmark.html#ae8c4d4ecf04069d744e86cb74c131029), [TaleWorlds.MountAndBlade.UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html#a8601d28166f23a8f850eb90d1d86f3c4), and [TaleWorlds.MountAndBlade.UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html#a7675e969c6d4685bbc466c8896fd42ae).


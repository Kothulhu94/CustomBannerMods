--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_multiplayer_mangonel_spawner.html ---

TaleWorlds.MountAndBlade.Objects.Siege.MultiplayerMangonelSpawner Class ReferenceInherits [TaleWorlds.MountAndBlade.Objects.Siege.MangonelSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html).

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| enum | [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) : uint {     [None](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [TickOccasionally](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da9cee052f50afabfc1098c1aa6af80b75) = 0x00000001 ,     [Tick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0b3516a5bbb77566f904f9d3877f4710) = 0x00000002 ,     [TickParallel](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da5f5a8f4b9ce783164665db4d70e03ee3) = 0x00000004 ,     [TickParallel2](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154da0ea9f0c260cdfd8b20ce19a48dbc329f) = 0x00000008 ,     [FixedTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154dadd067942f0b8cc66859698bc9711ba15) = 0x00000010 ,     [FixedParallelTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daa226d712a5ffd8d400f850393ff68492) = 0x00000020 ,     [TickParallel3](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154daf785c2c005d708ea434168efc10611b8) = 0x00000040   } |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.Objects.Siege.MangonelSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html) | |
| override void | [AssignParameters](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#a58f444b3e685e25000a24d008dc2cc50) ([SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) [\_spawnerMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a7d2449bd0874c0e6a6e15257a890f033)) |
|  | This function has "\_spawnerMissionHelper" argument because when this function has been called the spawner script hasn't acquired SpawnerMissionHelper yet. |
| Public Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [SetScriptComponentToTick](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ae15c963749bd0f9a75bba24a333b39d4) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) tickReq) |
| void | [SetScriptComponentToTickMT](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9b2183852eb7b70042ed82ef917022c6) ([TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) value) |
| virtual [TickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a54d07f4578ec5bf43af6e5a451e9154d) | [GetTickRequirement](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#ac17100a83d592505ed8d9ac565e512a5) () |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.Objects.Siege.MangonelSpawner](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html) | |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [projectile\_pile](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#a1571acbb84896d0d8c3d1bcdeca4ad9d) = [MatrixFrame.Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) |
| string | [AddOnDeployTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#a5ae164c080689714e29d407456ffae48) = "" |
| string | [RemoveOnDeployTag](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#aa34501fbfd75f5661b589e652a5615bf) = "" |
| bool | [ammo\_pos\_a\_enabled](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#af54ce3d1b331702e291eb6fa12f66225) = true |
| bool | [ammo\_pos\_b\_enabled](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#ace03e44006d4d0e46c79cc364e741627) = true |
| bool | [ammo\_pos\_c\_enabled](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#a04115ef05cb66c7d63df5ffe037bc58a) = true |
| bool | [ammo\_pos\_d\_enabled](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#a476057fd9321fa8c3679a768f4540e1b) = true |
| bool | [ammo\_pos\_e\_enabled](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#aaf20acdce6a036ac7c0627eb70949eda) = true |
| bool | [ammo\_pos\_f\_enabled](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#aaa849db6e3e15fb148d8535ed77af03b) = true |
| bool | [ammo\_pos\_g\_enabled](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#a2ae58b28ab0d67388693e9842775066f) = true |
| bool | [ammo\_pos\_h\_enabled](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_mangonel_spawner.html#a4cc59cc4b63c4e002a49a2cf23b533a5) = true |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html) | |
| string | [ToBeSpawnedOverrideName](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a42841a9c707593f9f35e715fe94792c8) = "" |
| string | [ToBeSpawnedOverrideNameForFireVersion](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a14aae7a1fe000bc7ac844fe1c0ebaf10) = "" |
| Protected Member Functions inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| void | [InvalidateWeakPointersIfValid](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#af39d73d0c78790ba81a40a5a350c0526) () |
|  | [ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0bc136bb53989f2b9a4f23f12f54a332) () |
| virtual void | [OnRemoved](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a4778f913080fc216866daa15518c8ecd) (int removeReason) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.Objects.Siege.SpawnerBase](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html) | |
| [SpawnerEntityEditorHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_editor_helper.html) | [\_spawnerEditorHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a36ae72189adf79cea47efdbc15af4642) = null |
| [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) | [\_spawnerMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#a7d2449bd0874c0e6a6e15257a890f033) = null |
| [SpawnerEntityMissionHelper](class_tale_worlds_1_1_mount_and_blade_1_1_spawner_entity_mission_helper.html) | [\_spawnerMissionHelperFire](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_siege_1_1_spawner_base.html#abce255df73789f982d92a11c57d0016d) = null |
| Properties inherited from [TaleWorlds.Engine.ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GameEntity](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a0a02cc65cc567db6101ea4afa275ff36) `[get]` |
| [ManagedScriptComponent](class_tale_worlds_1_1_engine_1_1_managed_script_component.html) | [ScriptComponent](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a8d7c5772e6b456b1e22ccd46a0b391ce) `[get]` |
| ManagedScriptHolder | [ManagedScriptHolder](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a58417dd71bf3daca6eb58df177617c2d) `[get]` |
| Scene | [Scene](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html#a9d7d5b77582948847f1d1c532face2c8) `[get]` |


--- SOURCE: class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html ---

SandBox.Missions.CoverAnimalAgentComponent Class ReferenceInherits [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html), and [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CoverAnimalAgentComponent](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a9e5925535fd100cd5d7e731a053d0d71) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) agent) |
| void | [SetDynamicPatrolArea](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a77955cf79cee07560e361f882585a742) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) parentPatrolPoint) |
| void | [StartMovement](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a48538ff0d6d5d09bbc423b50c3045b79) () |
| override void | [OnTick](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a2901e38468cf987cd851877b6e71507e) (float dt) |
| bool | [IsTargetReached](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a827363a8cb4d517bf1a753f848701012) () |
| void | [SetTargetFrame](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a10f53a59fb316fc65edf1528e564c292) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, float rotation, float rangeThreshold=1.0f, Agent.AIScriptedFrameFlags flags=Agent.AIScriptedFrameFlags.None) |
| void | [OnFocusGain](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a5313502038b404ce0964cd167ba0f6bc) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) userAgent) |
| void | [OnFocusLose](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#ad0cfd17335eeb6a81c4b12083b6aaa31) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) userAgent) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetInfoTextForBeingNotInteractable](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a2eea6cf3d4df1a34b4727233a30bb220) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) userAgent) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a3cb22f77a8d4c0efab0d84062b7b712f) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | |
| virtual void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a23212feac472e08d23165fe6db7cd28f) () |
| virtual void | [OnTickParallel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a4cf2b9047a9068d5ed8a91e15b8d45d4) (float dt) |
| virtual float | [GetMoraleAddition](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a50f9e9736a7fe32eee200fcae949d30f) () |
| virtual float | [GetMoraleDecreaseConstant](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad632fe59edb9b7c4d79a4166b3ceda40) () |
| virtual void | [OnItemPickup](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#af943da73b5c5015d8cede597df2e5500) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) item) |
| virtual void | [OnWeaponDrop](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad09f9803d1bd76cc43f85d8c21a1d7d4) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) droppedWeapon) |
| virtual void | [OnStopUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a94d4186a8544b74f93f47e4f8a67a753) () |
| virtual void | [OnWeaponHPChanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad10774dc526a149ead4cf05c540142f2) ([TaleWorlds.Core.ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, int hitPoints) |
| virtual void | [OnRetreating](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a091078b59471649794d1b8792d286605) () |
| virtual void | [OnMount](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68eb40d609376819d7449be8f1ead5cf) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) mount) |
| virtual void | [OnDismount](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a49064846b17ce1a14ed1edb99b082cf1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) mount) |
| virtual void | [OnHit](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ab9f12157938b85af29b4d5cb91539b8d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) affectorAgent, int damage, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) affectorWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnDisciplineChanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a893a41fdfad686d7fa36e81c01e70370) () |
| virtual void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a12cec8129389d6a70645aca41a797674) () |
| virtual void | [OnAgentTeleported](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#aff9ffe09f9846409e86968055d9b6871) () |
| virtual void | [OnAIInputSet](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#af81841738899b2aee40e1ffc2a0f093a) (ref [Agent.EventControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429) eventFlag, ref [Agent.MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) movementFlag, ref [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) inputVector) |
| virtual void | [OnComponentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a8e1db4125ef644c5a22a663fafcc340a) () |
|  | Only called if component is manually removed without removing the owner [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) during the mission. |
| virtual void | [OnFormationSet](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a2782f6a10b66065665b38a5b3a390f93) () |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsMovementStarted](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#af3c791eb31543a17712ccec4bd9682a1) `[get]` |
| bool | [IsAtFinalPoint](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#acacf8da491976898bb0b0f8ffcd98fd8) `[get]` |
| [FocusableObjectType](namespace_tale_worlds_1_1_mount_and_blade.html#aa83361d8fb674ed9b16444d43d30d141) | [FocusableObjectType](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a49f266359118574cc48bff9024a4ff4c) `[get]` |
| virtual bool | [IsFocusable](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a339f0c98f1e3bed7c41bd45c57d81afa) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | |
|  | [AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a72d82f2ac09f7f436c49a0b07fb83314) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) agent) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | |
| readonly Agent | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a9e5925535fd100cd5d7e731a053d0d71)CoverAnimalAgentComponent()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.Missions.CoverAnimalAgentComponent.CoverAnimalAgentComponent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *agent* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a77955cf79cee07560e361f882585a742)SetDynamicPatrolArea()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Missions.CoverAnimalAgentComponent.SetDynamicPatrolArea | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *parentPatrolPoint* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a48538ff0d6d5d09bbc423b50c3045b79)StartMovement()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Missions.CoverAnimalAgentComponent.StartMovement | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a2901e38468cf987cd851877b6e71507e)OnTick()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Missions.CoverAnimalAgentComponent.OnTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a3c75fd76296919a27d232e63e41d5790).

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a827363a8cb4d517bf1a753f848701012)IsTargetReached()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.Missions.CoverAnimalAgentComponent.IsTargetReached | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a10f53a59fb316fc65edf1528e564c292)SetTargetFrame()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Missions.CoverAnimalAgentComponent.SetTargetFrame | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, |
|  |  | float | *rotation*, |
|  |  | float | *rangeThreshold* = 1::0f, |
|  |  | Agent.AIScriptedFrameFlags | *flags* = Agent::AIScriptedFrameFlags::None ) |

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a5313502038b404ce0964cd167ba0f6bc)OnFocusGain()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Missions.CoverAnimalAgentComponent.OnFocusGain | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *userAgent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#a42697fa1ea31f29be949e5325dfbc95e).

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#ad0cfd17335eeb6a81c4b12083b6aaa31)OnFocusLose()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Missions.CoverAnimalAgentComponent.OnFocusLose | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *userAgent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#af920e5735d03cd6b971c458640fd6bba).

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a2eea6cf3d4df1a34b4727233a30bb220)GetInfoTextForBeingNotInteractable()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Missions.CoverAnimalAgentComponent.GetInfoTextForBeingNotInteractable | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *userAgent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#af5595369849cf9b7ba326828eab1c33d).

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a3cb22f77a8d4c0efab0d84062b7b712f)GetDescriptionText()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.Missions.CoverAnimalAgentComponent.GetDescriptionText | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ae296d89b1b2262987e2a6c7bb88368f8).

Property Documentation
----------------------

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#af3c791eb31543a17712ccec4bd9682a1)IsMovementStarted
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Missions.CoverAnimalAgentComponent.IsMovementStarted | | get |

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#acacf8da491976898bb0b0f8ffcd98fd8)IsAtFinalPoint
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Missions.CoverAnimalAgentComponent.IsAtFinalPoint | | get |

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a49f266359118574cc48bff9024a4ff4c)FocusableObjectType
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FocusableObjectType](namespace_tale_worlds_1_1_mount_and_blade.html#aa83361d8fb674ed9b16444d43d30d141) SandBox.Missions.CoverAnimalAgentComponent.FocusableObjectType | | get |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ad45e6dc0d435f66db8f1dee1055b18d6).

[◆](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a339f0c98f1e3bed7c41bd45c57d81afa)IsFocusable
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool SandBox.Missions.CoverAnimalAgentComponent.IsFocusable | | get |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#a1acaf86c44c33cbc58c6c9b88dcd682c).


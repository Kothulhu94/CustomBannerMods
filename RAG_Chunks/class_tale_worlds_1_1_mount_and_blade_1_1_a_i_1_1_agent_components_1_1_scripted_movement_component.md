--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html ---

TaleWorlds.MountAndBlade.AI.AgentComponents.ScriptedMovementComponent Class ReferenceInherits [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ScriptedMovementComponent](class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html#a5ed3b13aa8144e4d48882c7c7a29020b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) agent, bool isCharacterToTalkTo=false, float dialogueProximityOffset=0.0f) |
| void | [SetTargetAgent](class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html#a5566e7ef429aa35efdcd0ff0056fb6fa) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) targetAgent) |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html#a6127b599da2ccb3a7f0415e15a0a4f02) (float dt) |
| bool | [ShouldConversationStartWithAgent](class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html#a57f95be19ef80eb4af56c44e43f68f27) () |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html#a4cb5cf7fa3e1e81e0b6265f3b6118037) () |
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
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | |
|  | [AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a72d82f2ac09f7f436c49a0b07fb83314) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) agent) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | |
| readonly Agent | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html#a5ed3b13aa8144e4d48882c7c7a29020b)ScriptedMovementComponent()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.AI.AgentComponents.ScriptedMovementComponent.ScriptedMovementComponent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *agent*, |
|  |  | bool | *isCharacterToTalkTo* = false, |
|  |  | float | *dialogueProximityOffset* = 0::0f ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html#a5566e7ef429aa35efdcd0ff0056fb6fa)SetTargetAgent()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AI.AgentComponents.ScriptedMovementComponent.SetTargetAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *targetAgent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html#a6127b599da2ccb3a7f0415e15a0a4f02)OnTick()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.AI.AgentComponents.ScriptedMovementComponent.OnTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a3c75fd76296919a27d232e63e41d5790).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html#a57f95be19ef80eb4af56c44e43f68f27)ShouldConversationStartWithAgent()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.AI.AgentComponents.ScriptedMovementComponent.ShouldConversationStartWithAgent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html#a4cb5cf7fa3e1e81e0b6265f3b6118037)Reset()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.AI.AgentComponents.ScriptedMovementComponent.Reset | ( |  | ) |  |


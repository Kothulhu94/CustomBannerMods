--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html ---

TaleWorlds.MountAndBlade.CommonAIComponent Class ReferenceInherits [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CommonAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#ad7b2d92ae5cdf248ecfcf9b88d185507) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) agent) |
| override void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a5d9b9db14fe0906009e7e082fcbb666c) () |
| override void | [OnTickParallel](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a2d1b8e1b19b7d257711d2ba4cd82e9f0) (float dt) |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#ac319d5667bb7dbc96ea0c18d8b3ec724) (float dt) |
| void | [Panic](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a9a5aa9295e72981523eb2a4ba81fb708) () |
| void | [Retreat](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a59a30281870f6a1c7e8bb4e867fb3730) (bool useCachingSystem=false) |
| void | [StopRetreating](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#aa26158cff98d1f98db34e3726bf0c610) () |
| bool | [CanPanic](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a950d88a3e77c0d961f80c5ade6a931b3) () |
| override void | [OnHit](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#add5528ccbcbebf032212245acabb90b3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) affectorAgent, int damage, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) affectorWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| override void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#ac7d4ddeb4cc4df4a7055aad21609ea88) () |
| override void | [OnComponentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a3ddc033a3b29f3fc355ee3f846b95b8f) () |
|  | Only called if component is manually removed without removing the owner [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) during the mission. |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | |
| virtual float | [GetMoraleAddition](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a50f9e9736a7fe32eee200fcae949d30f) () |
| virtual float | [GetMoraleDecreaseConstant](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad632fe59edb9b7c4d79a4166b3ceda40) () |
| virtual void | [OnItemPickup](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#af943da73b5c5015d8cede597df2e5500) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) item) |
| virtual void | [OnWeaponDrop](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad09f9803d1bd76cc43f85d8c21a1d7d4) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) droppedWeapon) |
| virtual void | [OnStopUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a94d4186a8544b74f93f47e4f8a67a753) () |
| virtual void | [OnWeaponHPChanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad10774dc526a149ead4cf05c540142f2) ([TaleWorlds.Core.ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, int hitPoints) |
| virtual void | [OnRetreating](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a091078b59471649794d1b8792d286605) () |
| virtual void | [OnMount](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68eb40d609376819d7449be8f1ead5cf) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) mount) |
| virtual void | [OnDismount](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a49064846b17ce1a14ed1edb99b082cf1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) mount) |
| virtual void | [OnDisciplineChanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a893a41fdfad686d7fa36e81c01e70370) () |
| virtual void | [OnAgentTeleported](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#aff9ffe09f9846409e86968055d9b6871) () |
| virtual void | [OnAIInputSet](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#af81841738899b2aee40e1ffc2a0f093a) (ref [Agent.EventControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429) eventFlag, ref [Agent.MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) movementFlag, ref [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) inputVector) |
| virtual void | [OnFormationSet](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a2782f6a10b66065665b38a5b3a390f93) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [MoraleThresholdForPanicking](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#af9b91f0cc0135669f44c000ab0f75814) = 0.01f |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsPanicked](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a394b453ba15ae7234a630a183c0dd465) `[get]` |
| bool | [IsRetreating](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#af2a5645e506e306dbfafaf50a1102639) `[get]` |
| int | [ReservedRiderAgentIndex](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a7aa512a7c891bf8a4a99031c912bc36f) `[get]` |
| float | [InitialMorale](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#abb84bebc76973900cf06550aceef33a9) `[get]` |
| float | [RecoveryMorale](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#ae5ad3789d3728e4a36abfd91c19e59c2) `[get]` |
| float | [Morale](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a9ecb0ef3868d8712d735c9fd9207c1b5) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | |
|  | [AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a72d82f2ac09f7f436c49a0b07fb83314) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) agent) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | |
| readonly Agent | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#ad7b2d92ae5cdf248ecfcf9b88d185507)CommonAIComponent()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.CommonAIComponent.CommonAIComponent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *agent* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a5d9b9db14fe0906009e7e082fcbb666c)Initialize()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.CommonAIComponent.Initialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a23212feac472e08d23165fe6db7cd28f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a2d1b8e1b19b7d257711d2ba4cd82e9f0)OnTickParallel()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.CommonAIComponent.OnTickParallel | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a4cf2b9047a9068d5ed8a91e15b8d45d4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#ac319d5667bb7dbc96ea0c18d8b3ec724)OnTick()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.CommonAIComponent.OnTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a3c75fd76296919a27d232e63e41d5790).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a9a5aa9295e72981523eb2a4ba81fb708)Panic()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CommonAIComponent.Panic | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a59a30281870f6a1c7e8bb4e867fb3730)Retreat()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CommonAIComponent.Retreat | ( | bool | *useCachingSystem* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#aa26158cff98d1f98db34e3726bf0c610)StopRetreating()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CommonAIComponent.StopRetreating | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a950d88a3e77c0d961f80c5ade6a931b3)CanPanic()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.CommonAIComponent.CanPanic | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#add5528ccbcbebf032212245acabb90b3)OnHit()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.CommonAIComponent.OnHit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *affectorAgent*, | |  |  | int | *damage*, | |  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *affectorWeapon*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *b*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ab9f12157938b85af29b4d5cb91539b8d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#ac7d4ddeb4cc4df4a7055aad21609ea88)OnAgentRemoved()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.CommonAIComponent.OnAgentRemoved | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a12cec8129389d6a70645aca41a797674).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a3ddc033a3b29f3fc355ee3f846b95b8f)OnComponentRemoved()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.CommonAIComponent.OnComponentRemoved | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a8e1db4125ef644c5a22a663fafcc340a).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#af9b91f0cc0135669f44c000ab0f75814)MoraleThresholdForPanicking
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.CommonAIComponent.MoraleThresholdForPanicking = 0.01f | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a394b453ba15ae7234a630a183c0dd465)IsPanicked
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.CommonAIComponent.IsPanicked | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#af2a5645e506e306dbfafaf50a1102639)IsRetreating
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.CommonAIComponent.IsRetreating | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a7aa512a7c891bf8a4a99031c912bc36f)ReservedRiderAgentIndex
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.CommonAIComponent.ReservedRiderAgentIndex | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#abb84bebc76973900cf06550aceef33a9)InitialMorale
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.CommonAIComponent.InitialMorale | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#ae5ad3789d3728e4a36abfd91c19e59c2)RecoveryMorale
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.CommonAIComponent.RecoveryMorale | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a9ecb0ef3868d8712d735c9fd9207c1b5)Morale
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.CommonAIComponent.Morale | | getset |


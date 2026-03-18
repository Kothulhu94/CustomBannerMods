--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html ---

TaleWorlds.MountAndBlade.AgentComponent Class ReferenceabstractInherited by [SandBox.CampaignAgentComponent](class_sand_box_1_1_campaign_agent_component.html), [SandBox.Missions.CoverAnimalAgentComponent](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html), [TaleWorlds.MountAndBlade.AI.AgentComponents.ScriptedMovementComponent](class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html), [TaleWorlds.MountAndBlade.CommonAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html), [TaleWorlds.MountAndBlade.HumanAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html), [TaleWorlds.MountAndBlade.MPPerksAgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html), and [TaleWorlds.MountAndBlade.VictoryComponent](class_tale_worlds_1_1_mount_and_blade_1_1_victory_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a23212feac472e08d23165fe6db7cd28f) () |
| virtual void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a3c75fd76296919a27d232e63e41d5790) (float dt) |
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
| Protected Member Functions | |
|  | [AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a72d82f2ac09f7f436c49a0b07fb83314) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) agent) |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly Agent | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a72d82f2ac09f7f436c49a0b07fb83314)AgentComponent()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.AgentComponent.AgentComponent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *agent* | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a23212feac472e08d23165fe6db7cd28f)Initialize()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.Initialize | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.CommonAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a5d9b9db14fe0906009e7e082fcbb666c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a3c75fd76296919a27d232e63e41d5790)OnTick()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented in [SandBox.CampaignAgentComponent](class_sand_box_1_1_campaign_agent_component.html#a28ee88fd91aec6b87e24be16b0cc7238), [SandBox.Missions.CoverAnimalAgentComponent](class_sand_box_1_1_missions_1_1_cover_animal_agent_component.html#a2901e38468cf987cd851877b6e71507e), [TaleWorlds.MountAndBlade.AI.AgentComponents.ScriptedMovementComponent](class_tale_worlds_1_1_mount_and_blade_1_1_a_i_1_1_agent_components_1_1_scripted_movement_component.html#a6127b599da2ccb3a7f0415e15a0a4f02), [TaleWorlds.MountAndBlade.CommonAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#ac319d5667bb7dbc96ea0c18d8b3ec724), and [TaleWorlds.MountAndBlade.HumanAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a9edf5347e3fe3c79b4129066bd0c0e4b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a4cf2b9047a9068d5ed8a91e15b8d45d4)OnTickParallel()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnTickParallel | ( | float | *dt* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.CommonAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a2d1b8e1b19b7d257711d2ba4cd82e9f0), and [TaleWorlds.MountAndBlade.HumanAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a2b407e2c329ab037eff78f0e07e3d97e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a50f9e9736a7fe32eee200fcae949d30f)GetMoraleAddition()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.AgentComponent.GetMoraleAddition | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.CampaignAgentComponent](class_sand_box_1_1_campaign_agent_component.html#a1cf96662efbc58884a332ac26fafafb9).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad632fe59edb9b7c4d79a4166b3ceda40)GetMoraleDecreaseConstant()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.AgentComponent.GetMoraleDecreaseConstant | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.CampaignAgentComponent](class_sand_box_1_1_campaign_agent_component.html#a41affeb20f1929ce67d19dd159548c66).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#af943da73b5c5015d8cede597df2e5500)OnItemPickup()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnItemPickup | ( | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *item* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.MPPerksAgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a5959cdd88f58b2e3123093d6745456a3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad09f9803d1bd76cc43f85d8c21a1d7d4)OnWeaponDrop()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnWeaponDrop | ( | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *droppedWeapon* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.MPPerksAgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a40ccd59c7cee7d2f40fe79a17c2c80a8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a94d4186a8544b74f93f47e4f8a67a753)OnStopUsingGameObject()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnStopUsingGameObject | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.CampaignAgentComponent](class_sand_box_1_1_campaign_agent_component.html#a17ab4113928f9f5194bfd999b11ee06f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad10774dc526a149ead4cf05c540142f2)OnWeaponHPChanged()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnWeaponHPChanged | ( | [TaleWorlds.Core.ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | int | *hitPoints* ) | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a091078b59471649794d1b8792d286605)OnRetreating()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnRetreating | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.HumanAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#ab2284d6adb975c96c29d78263d66a54d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68eb40d609376819d7449be8f1ead5cf)OnMount()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnMount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *mount* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.MPPerksAgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a16a03e072f87eba1f12add823591f9a2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a49064846b17ce1a14ed1edb99b082cf1)OnDismount()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnDismount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *mount* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.HumanAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a229c64419d5f8ce3a4cf0a5cd2bdd927), and [TaleWorlds.MountAndBlade.MPPerksAgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a6e0a4c8fa9acc39462af803d47ea2b4e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ab9f12157938b85af29b4d5cb91539b8d)OnHit()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnHit | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *affectorAgent*, | |  |  | int | *damage*, | |  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *affectorWeapon*, | |  |  | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *b*, | |  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.CommonAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#add5528ccbcbebf032212245acabb90b3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a893a41fdfad686d7fa36e81c01e70370)OnDisciplineChanged()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnDisciplineChanged | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a12cec8129389d6a70645aca41a797674)OnAgentRemoved()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnAgentRemoved | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.CommonAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#ac7d4ddeb4cc4df4a7055aad21609ea88), [TaleWorlds.MountAndBlade.HumanAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a12266e13e70f2da8ad44d6fac03bfbde), and [TaleWorlds.MountAndBlade.MPPerksAgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#aecea2bd123fe761b474e58466ac94092).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#aff9ffe09f9846409e86968055d9b6871)OnAgentTeleported()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnAgentTeleported | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#af81841738899b2aee40e1ffc2a0f093a)OnAIInputSet()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnAIInputSet | ( | ref [Agent.EventControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429) | *eventFlag*, | |  |  | ref [Agent.MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) | *movementFlag*, | |  |  | ref [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *inputVector* ) | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a8e1db4125ef644c5a22a663fafcc340a)OnComponentRemoved()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnComponentRemoved | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.CommonAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_common_a_i_component.html#a3ddc033a3b29f3fc355ee3f846b95b8f), and [TaleWorlds.MountAndBlade.HumanAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#a9873d2cd3273c3e9530e86221b6bc6c7).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a2782f6a10b66065665b38a5b3a390f93)OnFormationSet()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.AgentComponent.OnFormationSet | ( |  | ) |  | | virtual |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521)Agent
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly Agent TaleWorlds.MountAndBlade.AgentComponent.Agent | | protected |


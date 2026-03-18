--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html ---

TaleWorlds.MountAndBlade.MPPerksAgentComponent Class ReferenceInherits [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MPPerksAgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a6c6f46a0f265ad0bb61cb87af3f87bba) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) agent) |
| override void | [OnMount](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a16a03e072f87eba1f12add823591f9a2) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) mount) |
| override void | [OnDismount](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a6e0a4c8fa9acc39462af803d47ea2b4e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) mount) |
| override void | [OnItemPickup](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a5959cdd88f58b2e3123093d6745456a3) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) item) |
| override void | [OnWeaponDrop](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a40ccd59c7cee7d2f40fe79a17c2c80a8) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) droppedWeapon) |
| override void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#aecea2bd123fe761b474e58466ac94092) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | |
| virtual void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a23212feac472e08d23165fe6db7cd28f) () |
| virtual void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a3c75fd76296919a27d232e63e41d5790) (float dt) |
| virtual void | [OnTickParallel](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a4cf2b9047a9068d5ed8a91e15b8d45d4) (float dt) |
| virtual float | [GetMoraleAddition](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a50f9e9736a7fe32eee200fcae949d30f) () |
| virtual float | [GetMoraleDecreaseConstant](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad632fe59edb9b7c4d79a4166b3ceda40) () |
| virtual void | [OnStopUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a94d4186a8544b74f93f47e4f8a67a753) () |
| virtual void | [OnWeaponHPChanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad10774dc526a149ead4cf05c540142f2) ([TaleWorlds.Core.ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, int hitPoints) |
| virtual void | [OnRetreating](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a091078b59471649794d1b8792d286605) () |
| virtual void | [OnHit](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ab9f12157938b85af29b4d5cb91539b8d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) affectorAgent, int damage, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) affectorWeapon, in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| virtual void | [OnDisciplineChanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a893a41fdfad686d7fa36e81c01e70370) () |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a6c6f46a0f265ad0bb61cb87af3f87bba)MPPerksAgentComponent()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MPPerksAgentComponent.MPPerksAgentComponent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *agent* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a16a03e072f87eba1f12add823591f9a2)OnMount()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MPPerksAgentComponent.OnMount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *mount* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68eb40d609376819d7449be8f1ead5cf).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a6e0a4c8fa9acc39462af803d47ea2b4e)OnDismount()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MPPerksAgentComponent.OnDismount | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a68b5231ade2b169343a70d429f0a0521) | *mount* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a49064846b17ce1a14ed1edb99b082cf1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a5959cdd88f58b2e3123093d6745456a3)OnItemPickup()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MPPerksAgentComponent.OnItemPickup | ( | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *item* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#af943da73b5c5015d8cede597df2e5500).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#a40ccd59c7cee7d2f40fe79a17c2c80a8)OnWeaponDrop()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MPPerksAgentComponent.OnWeaponDrop | ( | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *droppedWeapon* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#ad09f9803d1bd76cc43f85d8c21a1d7d4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perks_agent_component.html#aecea2bd123fe761b474e58466ac94092)OnAgentRemoved()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MPPerksAgentComponent.OnAgentRemoved | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html#a12cec8129389d6a70645aca41a797674).


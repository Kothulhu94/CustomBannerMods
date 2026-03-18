--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_team.html ---

TaleWorlds.MountAndBlade.Team Class ReferenceInherits [TaleWorlds.Core.IMissionTeam](interface_tale_worlds_1_1_core_1_1_i_mission_team.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acb8282512f02a0d0fa7f3e5e10ccc596) ([MBTeam](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a4a596973134d045a8db3d46ccf03360f) mbTeam, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a7afe43a8ef6f518e093d2d435be548a9) mission, uint color=0xFFFFFFFF, uint color2=0xFFFFFFFF, [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a09833d6b622a54c59778660a8f3a331f) banner=null) |
| void | [SetCustomOrderController](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ace66cb8439fe162b74ffbc98d1410f71) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) customMasterOrderController, [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) customPlayerOrderController) |
| void | [UpdateCachedEnemyDataForFleeing](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a1937ff654926019b35d532661a469cd0) () |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a19ad54a7e313292a0046da743d8e08e4) () |
| void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ab94aab43209e6c3e4de9da907ab9df4b) () |
| void | [AssignPlayerAsSergeantOfFormation](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a8d7fc0a044071ed3ae76401ee465618c) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass) |
| void | [AddTacticOption](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a35faeb9cda810cc521992d66a8b0906c) ([TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) tacticOption) |
| void | [RemoveTacticOption](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a6ae520459101f486eeea9cb78ca09431) (Type tacticType) |
| void | [ClearTacticOptions](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a233e8672e60db028447bed460325b9ab) () |
| void | [ResetTactic](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a1953c3ed79f0a215ee07a1018009b534) () |
| void | [AddTeamAI](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a192e220cebc2429acad2dc27c491f330) ([TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html) teamAI, bool forceNotAIControlled=false) |
| void | [DelegateCommandToAI](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a7d5e0603a3c125fa12334d1df3fd0100) () |
| void | [RearrangeFormationsAccordingToFilter](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a6d14e1f4509cb0fcdb82f89c3580611d) (List<([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, int troopCount, [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) troopFilter, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > excludedAgents)> MassTransferData) |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ac3122aeee380b6a938f83ca2fa71cb0f) (float dt) |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [GetFormation](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a301166a2f4172a0a3ea49952ee069e24) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationIndex) |
| void | [SetIsEnemyOf](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a87c2b40b209e3821b184009f4700766f) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acb8282512f02a0d0fa7f3e5e10ccc596) otherTeam, bool isEnemyOf) |
| bool | [IsEnemyOf](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ae125904be1d7f08c72c785a1c3e55cd9) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acb8282512f02a0d0fa7f3e5e10ccc596) otherTeam) |
| bool | [IsFriendOf](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a67637bba0b56795fb10f522b9f73c6b4) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acb8282512f02a0d0fa7f3e5e10ccc596) otherTeam) |
| void | [AddAgentToTeam](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#adb29e2b8198d5f0269de8e7340bd636e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit) |
| void | [RemoveAgentFromTeam](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a6de1df5e367ee0d9f7672338aa72067a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit) |
| void | [DeactivateAgent](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a3592229a6c7a1fe83e406fa6d6c055b6) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a1117059924d38691b072e6fd803abe5c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override string | [ToString](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#aeb6438c61f9961cf84715b890fb80e52) () |
| void | [OnMissionEnded](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a2de7b6500ae93fe7e4116710be511090) () |
| void | [TriggerOnFormationsChanged](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a3647fc05fada0840981470a8d273f56a) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | [GetOrderControllerOf](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#abcfe7824e0860f1dc6fc4c2ace21bd32) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [SetPlayerRole](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a067828e21d07b626228b45eac85e1d66) (bool isPlayerGeneral, bool isPlayerSergeant) |
| bool | [HasAnyEnemyTeamsWithAgents](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a74ac38a3b7b14fa87b48c6ec38214913) (bool ignoreMountedAgents) |
| bool | [HasAnyFormationsIncludingSpecialThatIsNotEmpty](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#af2d0292dfe950639569d3f546b622e31) () |
| int | [GetFormationCount](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ade7d57a796d49660a0e3c76549eb08cf) () |
| int | [GetAIControlledFormationCount](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a945f3e77fb660e02ba9d1472bc27755e) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetAveragePositionOfEnemies](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a9014e59d26e2e6312f1a94f193666701) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetAveragePosition](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a62e80f4f9935d7323db66aaab4b1135b) () |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetMedianPosition](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a2160bcb87433041bd4a3a21883c5cf4d) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) averagePosition) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetWeightedAverageOfEnemies](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a0294dd529ba24606c810dc497f6479b4) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) basePoint) |
| void | [DisableDetachmentTicking](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ace44fab579677985916cd206a5861a5b) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [DoesFirstFormationClassContainSecond](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a907afe89fe4ea7379afafe8eba5cd0af) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) f1, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) f2) |
| static [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [GetFormationFormationClass](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#af578ddf3c935fa460b5b509d8b0cda7e) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) f) |
| static [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [GetPlayerTeamFormationClass](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a327fd9319b9ffb54af64927e882ff84b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) mainAgent) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly MBTeam | [MBTeam](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a4a596973134d045a8db3d46ccf03360f) |

|  |  |
| --- | --- |
| Properties | |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [Side](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ab1814f2457d99cccce6dc67c0c324762) `[get]` |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a7afe43a8ef6f518e093d2d435be548a9) `[get]` |
| MBList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [FormationsIncludingEmpty](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ade2ddf81bb6d0af468dda9fc59cf39f6) `[get]` |
| MBList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [FormationsIncludingSpecialAndEmpty](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ad0c77dc346dd45536ce4d2a8ada1594a) `[get]` |
| [TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html) | [TeamAI](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a294270683aa7a2c3d2d06c34816c839f) `[get]` |
| bool | [IsPlayerTeam](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#aa1e6e5d1ca0cccd90e31d137871426dd) `[get]` |
| bool | [IsPlayerAlly](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#af36cd1396e4f3540678c1acc6ddfdd9c) `[get]` |
| [TeamSideEnum](namespace_tale_worlds_1_1_core.html#a15c7283e7d5f7d4abc93f22069624726) | [TeamSide](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#aa23637628e5d9463756d6f53cd39f466) `[get]` |
| bool | [IsDefender](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a191d34d653f7aae0e54e00310a8889ac) `[get]` |
| bool | [IsAttacker](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a8230729c0119ed1685fcc2090cd20ab0) `[get]` |
| uint | [Color](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a2a62d2af6c823978ecd3cb75821c1072) `[get]` |
| uint | [Color2](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acd8a75b61ce91ec187490457c16c8282) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a09833d6b622a54c59778660a8f3a331f) `[get]` |
| [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | [MasterOrderController](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a4d5f7afff1c047fae35ba4ddd9727fa3) `[get]` |
| [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | [PlayerOrderController](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a903090253805d02d0dce527673870850) `[get]` |
| [TeamQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html) | [QuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a52a615a775c58678f318a5d4594bcff5) `[get]` |
| DetachmentManager | [DetachmentManager](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a1e1b922d1e784b75d70f2f671f4e037a) `[get]` |
| bool | [IsPlayerGeneral](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ad9d2b4dbad7778098cf2067c884bd45c) `[get]` |
| bool | [IsPlayerSergeant](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ad0e61b27d5b069a648fdc7980d4ec574) `[get]` |
| MBReadOnlyList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [ActiveAgents](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a61ef9f6bebbc927970434a0c1e4de083) `[get]` |
| MBReadOnlyList< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [TeamAgents](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a237ce19f7f3c01be3192ca095c2c6aa2) `[get]` |
| MBReadOnlyList< ValueTuple< float, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html), int, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), bool > > | [CachedEnemyDataForFleeing](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ac4a78a2db034daafbe2ace66001c8266) `[get]` |
|  | Keeps a list of enemy data (can be agents or formations) to be used while computing team flee positions. Each tuple represents data for an enemy formation or an enemy agent without formation This is computed/cached only once each tick and only for those teams including retreating agents. Tuple entries are: |
| int | [TeamIndex](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ae1d29082e05c01797321f57e7e57724c) `[get]` |
| float | [MoraleChangeFactor](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a968f2543a2fb9a76acabd5cdc8f9041b) `[get]` |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [GeneralsFormation](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a6f7172a2d4a9aa9e7fed220e3d4297b7) `[get, set]` |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [BodyGuardFormation](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a42eb066f4fbb6664bb03364c534a2788) `[get, set]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GeneralAgent](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a973a679121a06ea972d8b05be450e70b) `[get, set]` |
| IEnumerable< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [Heroes](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a675caaa52bb6377f8278a004cdc9f302) `[get]` |
| bool | [HasBots](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a2044d1274e1a9de6447adde8ba62296f) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [Leader](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a3214efa83ed56442432e5e7ed34979b3) `[get]` |
| static [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acb8282512f02a0d0fa7f3e5e10ccc596) | [Invalid](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a8c401063104286007cec2ac46ebe5497) `[get]` |
| bool | [IsValid](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#aaef02f5c075e091567b4c4e578e9f949) `[get]` |
| bool | [HasTeamAi](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a0fc40a4d45270a80f4f79efd83b14b33) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action< [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acb8282512f02a0d0fa7f3e5e10ccc596), [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [OnFormationsChanged](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ac0dc9aa137ff909e416d51510062dead) |
| [OnOrderIssuedDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#a7f395cbbac47ee66d0d985574f2740e9) | [OnOrderIssued](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ad6cdd51ffba19bbcf253d81c2643219b) |
| Action< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [OnFormationAIActiveBehaviorChanged](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a44be3b116794cd1b383379c77c1e4ce8) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acb8282512f02a0d0fa7f3e5e10ccc596)Team()
------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Team.Team | ( | [MBTeam](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a4a596973134d045a8db3d46ccf03360f) | *mbTeam*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a7afe43a8ef6f518e093d2d435be548a9) | *mission*, |
|  |  | uint | *color* = 0xFFFFFFFF, |
|  |  | uint | *color2* = 0xFFFFFFFF, |
|  |  | [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a09833d6b622a54c59778660a8f3a331f) | *banner* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ace66cb8439fe162b74ffbc98d1410f71)SetCustomOrderController()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.SetCustomOrderController | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *customMasterOrderController*, |
|  |  | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *customPlayerOrderController* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a1937ff654926019b35d532661a469cd0)UpdateCachedEnemyDataForFleeing()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.UpdateCachedEnemyDataForFleeing | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a19ad54a7e313292a0046da743d8e08e4)Reset()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ab94aab43209e6c3e4de9da907ab9df4b)Clear()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a907afe89fe4ea7379afafe8eba5cd0af)DoesFirstFormationClassContainSecond()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.Team.DoesFirstFormationClassContainSecond | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *f1*, | |  |  | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *f2* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#af578ddf3c935fa460b5b509d8b0cda7e)GetFormationFormationClass()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.Team.GetFormationFormationClass | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *f* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a327fd9319b9ffb54af64927e882ff84b)GetPlayerTeamFormationClass()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.MountAndBlade.Team.GetPlayerTeamFormationClass | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *mainAgent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a8d7fc0a044071ed3ae76401ee465618c)AssignPlayerAsSergeantOfFormation()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.AssignPlayerAsSergeantOfFormation | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer*, |
|  |  | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a35faeb9cda810cc521992d66a8b0906c)AddTacticOption()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.AddTacticOption | ( | [TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | *tacticOption* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a6ae520459101f486eeea9cb78ca09431)RemoveTacticOption()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.RemoveTacticOption | ( | Type | *tacticType* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a233e8672e60db028447bed460325b9ab)ClearTacticOptions()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.ClearTacticOptions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a1953c3ed79f0a215ee07a1018009b534)ResetTactic()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.ResetTactic | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a192e220cebc2429acad2dc27c491f330)AddTeamAI()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.AddTeamAI | ( | [TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html) | *teamAI*, |
|  |  | bool | *forceNotAIControlled* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a7d5e0603a3c125fa12334d1df3fd0100)DelegateCommandToAI()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.DelegateCommandToAI | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a6d14e1f4509cb0fcdb82f89c3580611d)RearrangeFormationsAccordingToFilter()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.RearrangeFormationsAccordingToFilter | ( | List<([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, int troopCount, [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) troopFilter, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > excludedAgents)> | *MassTransferData* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ac3122aeee380b6a938f83ca2fa71cb0f)Tick()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a301166a2f4172a0a3ea49952ee069e24)GetFormation()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.Team.GetFormation | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a87c2b40b209e3821b184009f4700766f)SetIsEnemyOf()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.SetIsEnemyOf | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acb8282512f02a0d0fa7f3e5e10ccc596) | *otherTeam*, |
|  |  | bool | *isEnemyOf* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ae125904be1d7f08c72c785a1c3e55cd9)IsEnemyOf()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Team.IsEnemyOf | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acb8282512f02a0d0fa7f3e5e10ccc596) | *otherTeam* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a67637bba0b56795fb10f522b9f73c6b4)IsFriendOf()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Team.IsFriendOf | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acb8282512f02a0d0fa7f3e5e10ccc596) | *otherTeam* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#adb29e2b8198d5f0269de8e7340bd636e)AddAgentToTeam()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.AddAgentToTeam | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a6de1df5e367ee0d9f7672338aa72067a)RemoveAgentFromTeam()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.RemoveAgentFromTeam | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a3592229a6c7a1fe83e406fa6d6c055b6)DeactivateAgent()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.DeactivateAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a1117059924d38691b072e6fd803abe5c)OnAgentRemoved()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#aeb6438c61f9961cf84715b890fb80e52)ToString()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.MountAndBlade.Team.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a2de7b6500ae93fe7e4116710be511090)OnMissionEnded()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.OnMissionEnded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a3647fc05fada0840981470a8d273f56a)TriggerOnFormationsChanged()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.TriggerOnFormationsChanged | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#abcfe7824e0860f1dc6fc4c2ace21bd32)GetOrderControllerOf()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) TaleWorlds.MountAndBlade.Team.GetOrderControllerOf | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a067828e21d07b626228b45eac85e1d66)SetPlayerRole()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.SetPlayerRole | ( | bool | *isPlayerGeneral*, |
|  |  | bool | *isPlayerSergeant* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a74ac38a3b7b14fa87b48c6ec38214913)HasAnyEnemyTeamsWithAgents()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Team.HasAnyEnemyTeamsWithAgents | ( | bool | *ignoreMountedAgents* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#af2d0292dfe950639569d3f546b622e31)HasAnyFormationsIncludingSpecialThatIsNotEmpty()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Team.HasAnyFormationsIncludingSpecialThatIsNotEmpty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ade7d57a796d49660a0e3c76549eb08cf)GetFormationCount()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Team.GetFormationCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a945f3e77fb660e02ba9d1472bc27755e)GetAIControlledFormationCount()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Team.GetAIControlledFormationCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a9014e59d26e2e6312f1a94f193666701)GetAveragePositionOfEnemies()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Team.GetAveragePositionOfEnemies | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a62e80f4f9935d7323db66aaab4b1135b)GetAveragePosition()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Team.GetAveragePosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a2160bcb87433041bd4a3a21883c5cf4d)GetMedianPosition()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Team.GetMedianPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *averagePosition* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a0294dd529ba24606c810dc497f6479b4)GetWeightedAverageOfEnemies()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Team.GetWeightedAverageOfEnemies | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *basePoint* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ace44fab579677985916cd206a5861a5b)DisableDetachmentTicking()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Team.DisableDetachmentTicking | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a4a596973134d045a8db3d46ccf03360f)MBTeam
------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly MBTeam TaleWorlds.MountAndBlade.Team.MBTeam |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ab1814f2457d99cccce6dc67c0c324762)Side
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.MountAndBlade.Team.Side | | get |

Implements [TaleWorlds.Core.IMissionTeam](interface_tale_worlds_1_1_core_1_1_i_mission_team.html#a131e3aea7120a95b6b41e5d71b649d9d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a7afe43a8ef6f518e093d2d435be548a9)Mission
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Mission TaleWorlds.MountAndBlade.Team.Mission | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ade2ddf81bb6d0af468dda9fc59cf39f6)FormationsIncludingEmpty
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.Team.FormationsIncludingEmpty | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ad0c77dc346dd45536ce4d2a8ada1594a)FormationsIncludingSpecialAndEmpty
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.Team.FormationsIncludingSpecialAndEmpty | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a294270683aa7a2c3d2d06c34816c839f)TeamAI
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html) TaleWorlds.MountAndBlade.Team.TeamAI | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#aa1e6e5d1ca0cccd90e31d137871426dd)IsPlayerTeam
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Team.IsPlayerTeam | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#af36cd1396e4f3540678c1acc6ddfdd9c)IsPlayerAlly
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Team.IsPlayerAlly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#aa23637628e5d9463756d6f53cd39f466)TeamSide
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TeamSideEnum](namespace_tale_worlds_1_1_core.html#a15c7283e7d5f7d4abc93f22069624726) TaleWorlds.MountAndBlade.Team.TeamSide | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a191d34d653f7aae0e54e00310a8889ac)IsDefender
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Team.IsDefender | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a8230729c0119ed1685fcc2090cd20ab0)IsAttacker
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Team.IsAttacker | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a2a62d2af6c823978ecd3cb75821c1072)Color
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.Team.Color | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acd8a75b61ce91ec187490457c16c8282)Color2
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.Team.Color2 | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a09833d6b622a54c59778660a8f3a331f)Banner
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.MountAndBlade.Team.Banner | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a4d5f7afff1c047fae35ba4ddd9727fa3)MasterOrderController
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) TaleWorlds.MountAndBlade.Team.MasterOrderController | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a903090253805d02d0dce527673870850)PlayerOrderController
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) TaleWorlds.MountAndBlade.Team.PlayerOrderController | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a52a615a775c58678f318a5d4594bcff5)QuerySystem
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TeamQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_team_query_system.html) TaleWorlds.MountAndBlade.Team.QuerySystem | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a1e1b922d1e784b75d70f2f671f4e037a)DetachmentManager
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | DetachmentManager TaleWorlds.MountAndBlade.Team.DetachmentManager | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ad9d2b4dbad7778098cf2067c884bd45c)IsPlayerGeneral
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Team.IsPlayerGeneral | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ad0e61b27d5b069a648fdc7980d4ec574)IsPlayerSergeant
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Team.IsPlayerSergeant | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a61ef9f6bebbc927970434a0c1e4de083)ActiveAgents
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> TaleWorlds.MountAndBlade.Team.ActiveAgents | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a237ce19f7f3c01be3192ca095c2c6aa2)TeamAgents
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> TaleWorlds.MountAndBlade.Team.TeamAgents | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ac4a78a2db034daafbe2ace66001c8266)CachedEnemyDataForFleeing
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<ValueTuple<float, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html), int, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), bool> > TaleWorlds.MountAndBlade.Team.CachedEnemyDataForFleeing | | get |

* MaxSpeed of enemy group
* MedianPosition of enemy group
* Size of enemy group (number of agents)
* Line segment start position of enemy group/formation (if size > 0)
* Line segment end position of enemy group/formation (if size > 0)
* Whether if enemy is cavalry REMARK\_ATES: This was used to be enemyData within Mission.cs... but moved here for optimization purposes as it can be computed once for each team with panicking formations and agents during pre-tick. This data can be re-used by panicking/retreating agents within this team but will be cleared every tick

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ae1d29082e05c01797321f57e7e57724c)TeamIndex
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Team.TeamIndex | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a968f2543a2fb9a76acabd5cdc8f9041b)MoraleChangeFactor
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Team.MoraleChangeFactor | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a6f7172a2d4a9aa9e7fed220e3d4297b7)GeneralsFormation
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.Team.GeneralsFormation | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a42eb066f4fbb6664bb03364c534a2788)BodyGuardFormation
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.Team.BodyGuardFormation | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a973a679121a06ea972d8b05be450e70b)GeneralAgent
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Team.GeneralAgent | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a675caaa52bb6377f8278a004cdc9f302)Heroes
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html)> TaleWorlds.MountAndBlade.Team.Heroes | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a2044d1274e1a9de6447adde8ba62296f)HasBots
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Team.HasBots | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a3214efa83ed56442432e5e7ed34979b3)Leader
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.Team.Leader | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a8c401063104286007cec2ac46ebe5497)Invalid
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acb8282512f02a0d0fa7f3e5e10ccc596) TaleWorlds.MountAndBlade.Team.Invalid | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#aaef02f5c075e091567b4c4e578e9f949)IsValid
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Team.IsValid | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a0fc40a4d45270a80f4f79efd83b14b33)HasTeamAi
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Team.HasTeamAi | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ac0dc9aa137ff909e416d51510062dead)OnFormationsChanged
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#acb8282512f02a0d0fa7f3e5e10ccc596), [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.Team.OnFormationsChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#ad6cdd51ffba19bbcf253d81c2643219b)OnOrderIssued
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnOrderIssuedDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#a7f395cbbac47ee66d0d985574f2740e9) TaleWorlds.MountAndBlade.Team.OnOrderIssued |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team.html#a44be3b116794cd1b383379c77c1e4ce8)OnFormationAIActiveBehaviorChanged
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.Team.OnFormationAIActiveBehaviorChanged |


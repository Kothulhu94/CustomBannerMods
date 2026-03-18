--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html ---

TaleWorlds.MountAndBlade.OrderController Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a05ec6f13b7d608cdff05c56a4de89613) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a30f240d5ab9488b7bec8c78c58cbdf17) team, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) owner) |
| void | [SelectFormation](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a06577be3cb2edede9d6ffbf69ad847f5) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [DeselectFormation](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aa6d54243eb2b7ffd14acc2535aee68e3) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| bool | [IsFormationListening](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a558f10ca9a95d3f412f4744f0836cfe1) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| bool | [IsFormationSelectable](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a482c15e12b61bf053736fa97fd42eff0) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| bool | [BackupAndDisableGesturesEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aa9ecaa3045e49f30598868aa034da639) () |
| void | [RestoreGesturesEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#ae0f2e12eccd2112ed6334ba2805604fe) (bool oldValue) |
| void | [SelectAllFormations](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a5816ddb568f1dce14cd306cfa3321c56) (bool uiFeedback=false) |
|  | Does not select empty or special (bodyguard etc...) formations. |
| void | [ClearSelectedFormations](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a0c4cd2e71ff59f5202e4ed54fb9ced10) () |
| virtual void | [SetOrder](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a1079230d637fe04145741c3053715350) ([OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType) |
| virtual void | [SetOrderWithAgent](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a7ebbbc573dd742caffae831220a2f22e) ([OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [SetOrderWithPosition](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a421e18edc2d33d60d99afc1950eb731c) ([OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) orderPosition) |
| virtual void | [SetOrderWithFormation](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a0c147b3c2eb62bc760ddb72e974c319b) ([OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) orderFormation) |
| void | [SetOrderWithFormationAndPercentage](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a2f29e344cf1cda0b90d3e6db8b44d00d) ([OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) orderFormation, float percentage) |
| void | [TransferUnitWithPriorityFunction](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a2c212da41918c58dde9d9467d983306b) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) orderFormation, int number, bool hasShield, bool hasSpear, bool hasThrown, bool isHeavy, bool isRanged, bool isMounted, bool excludeBannerman, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > excludedAgents) |
|  | Only to be used by Order of Battle UI. |
| void | [RearrangeFormationsAccordingToFilters](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#ad640956716fb177e5608d95bc770437c) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a30f240d5ab9488b7bec8c78c58cbdf17) team, List<([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, int troopCount, [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) troopFilter, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > excludedAgents)> MassTransferData) |
|  | Only to be used by Order of Battle UI. |
| void | [SetOrderWithFormationAndNumber](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aae2037556b886ad2d86319c4f31fec5e) ([OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) orderFormation, int number) |
| virtual void | [SetOrderWithTwoPositions](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aac6018d4c3df903ff069d68d3799bc1c) ([OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position1, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position2) |
| virtual void | [SetOrderWithOrderableObject](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a0b30b5cfd09861fc11d51b177b4809bc) ([IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html) target) |
| void | [SimulateNewOrderWithPositionAndDirection](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a92fb94555d1b162b188982ebff7212dd) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) formationLineBegin, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) formationLineEnd, out List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > simulationAgentFrames, bool isFormationLayoutVertical) |
| void | [SimulateNewFacingOrder](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#af0b90837cf6b0939dd54d688980be156) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction, out List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > simulationAgentFrames) |
| void | [SimulateNewCustomWidthOrder](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a9c34e824e8f13ce0e53591fd5e40c928) (float width, out List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > simulationAgentFrames) |
| void | [SimulateDestinationFrames](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a894600d1c39e34eb544ec9a32f7df6d0) (out List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > simulationAgentFrames, float minDistance=3f) |
| void | [TransferUnits](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a0e4bd99bb659dd148fface6b2fe7c952) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) source, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) target, int count) |
| IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [SplitFormation](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a43776cdb7ba08da97f7c3e20ea452aa1) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, int count=2) |
| void | [TickDebug](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#af2bc9fe1af1b5d9b0d0104f7ad49a9e4) () |
| void | [AddOrderOverride](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a37898cd06e426b7341d8e2147e60a5a5) (Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html), [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) > orderOverride) |
| [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [GetOverridenOrderType](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a6c7a48263bb9c1895242583f4208fa1c) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [SetFormationUpdateEnabledAfterSetOrder](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aded6fc7704ee3cf8fc352a62f37f2f98) (bool value) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [GetActiveMovementOrderOf](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aceaf02114a728874061c4e87f136dbe0) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| static [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [GetActiveFacingOrderOf](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a0742753ac069d3f2d463f766527d2ab1) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| static [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [GetActiveRidingOrderOf](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#abd3bc568f55c8cb9f2c0e98833a1a778) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| static [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [GetActiveArrangementOrderOf](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a2e56886159190135622920d8ef1f4242) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| static [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [GetActiveFormOrderOf](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a13e1f7696e2cf22682984addfa46ec53) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| static [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [GetActiveFiringOrderOf](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a46bb8f8595fb42f0bf0c8b2251bd3946) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| static [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [GetActiveAIControlOrderOf](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a5c0d08318ff935cd1d06146d646386f5) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| static void | [SimulateNewOrderWithPositionAndDirection](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aefea93ccc7220ca9c8bb44c82b3e5296) (IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > formations, Dictionary< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > [simulationFormations](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a2748218472a85f7443467254b648138c), [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) formationLineBegin, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) formationLineEnd, out List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > simulationAgentFrames, bool isFormationLayoutVertical=true) |
| static void | [SimulateNewOrderWithPositionAndDirection](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#ac9502fb284b38b3d222bb737dd1fcc27) (IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > formations, Dictionary< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > [simulationFormations](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a2748218472a85f7443467254b648138c), [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) formationLineBegin, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) formationLineEnd, out List< ValueTuple< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), int, float, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html), [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > formationChanges, out bool isLineShort, bool isFormationLayoutVertical=true) |
| static IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [SortFormationsForHorizontalLayout](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a6a7f7ed4686d023c21bc0ebe053db412) (IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > formations) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetOrderLookAtDirection](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a11399fccb05a6d2480f31824b78a7213) (IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > formations, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) target) |
| static float | [GetOrderFormCustomWidth](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a1ad500e52b473427e505bf4356aee56d) (IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > formations, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) orderPosition) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a30f240d5ab9488b7bec8c78c58cbdf17) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [Owner](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#afe98be11356ce8109492ce70d51d41e8) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [FormationGapInLine](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a4188c4082c72b6e57b17c7eb72ac15b9) = 1.5f |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [OnSelectedFormationsCollectionChanged](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a48f6446db156fa2ce7313752b25fb85e) () |
| virtual void | [SelectFormation](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a4e5485ccb420b63b8c21d70ebea95f3b) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) selectorAgent) |
| bool | [IsFormationSelectable](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a5e6f06d83106f491ca894e7cae16e5f1) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) selectorAgent) |
| bool | [AreGesturesEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aef034d46031b404161b5c6bfe043287c) () |
| virtual void | [SelectAllFormations](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#ac363ef8ecf5aa54c0aa3622c2966a588) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) selectorAgent, bool uiFeedback) |
| void | [BeforeSetOrder](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a4b51b94ea208e06fc962c1ceb497de42) ([OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType) |
| void | [FireOnOrderIssued](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#afd8bbb7759e612182c855f63f52d3d41) ([OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) orderType, MBReadOnlyList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > appliedFormations, [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a05ec6f13b7d608cdff05c56a4de89613) orderController, params Object[] delegateParams) |

|  |  |
| --- | --- |
| Static Protected Member Functions | |
| static void | [PlayFormationSelectedGesture](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a3c378ca770a389030a8334fdef427d39) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | [\_mission](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a7f0acd3a0f1a50f714962ae60ceac60e) |
| readonly MBList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [\_selectedFormations](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#af25d8b040660770147bed33ff30d1196) |
| bool | [\_formationUpdateEnabledAfterSetOrder](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a1e7ce76c3f9fc306a952bbc2787e1468) = true |

|  |  |
| --- | --- |
| Properties | |
| SiegeWeaponController | [SiegeWeaponController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a56e2c1adf664568eebe6d3d7e92ca9df) `[get]` |
| MBReadOnlyList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [SelectedFormations](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#ac6b7bf81daac06c0ce0adb0e88f8c999) `[get]` |
| bool | [FormationUpdateEnabledAfterSetOrder](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a33e00fa9f8548e1729f36e4d834ec485) `[get]` |
| Dictionary< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | [simulationFormations](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a2748218472a85f7443467254b648138c) `[get]` |

|  |  |
| --- | --- |
| Events | |
| [OnOrderIssuedDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#a7f395cbbac47ee66d0d985574f2740e9) | [OnOrderIssued](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#af4dc95b03081008f679ed6fb2467663e) |
| Action | [OnSelectedFormationsChanged](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#ad268961cee41da9b10d2d94d5584f378) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a05ec6f13b7d608cdff05c56a4de89613)OrderController()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.OrderController.OrderController | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a30f240d5ab9488b7bec8c78c58cbdf17) | *team*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *owner* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a48f6446db156fa2ce7313752b25fb85e)OnSelectedFormationsCollectionChanged()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.OrderController.OnSelectedFormationsCollectionChanged | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a4e5485ccb420b63b8c21d70ebea95f3b)SelectFormation() [1/2]
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.OrderController.SelectFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *selectorAgent* ) | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a06577be3cb2edede9d6ffbf69ad847f5)SelectFormation() [2/2]
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.SelectFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aa6d54243eb2b7ffd14acc2535aee68e3)DeselectFormation()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.DeselectFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a558f10ca9a95d3f412f4744f0836cfe1)IsFormationListening()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.OrderController.IsFormationListening | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a482c15e12b61bf053736fa97fd42eff0)IsFormationSelectable() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.OrderController.IsFormationSelectable | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aa9ecaa3045e49f30598868aa034da639)BackupAndDisableGesturesEnabled()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.OrderController.BackupAndDisableGesturesEnabled | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#ae0f2e12eccd2112ed6334ba2805604fe)RestoreGesturesEnabled()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.RestoreGesturesEnabled | ( | bool | *oldValue* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a5e6f06d83106f491ca894e7cae16e5f1)IsFormationSelectable() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.OrderController.IsFormationSelectable | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *selectorAgent* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aef034d46031b404161b5c6bfe043287c)AreGesturesEnabled()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.OrderController.AreGesturesEnabled | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#ac363ef8ecf5aa54c0aa3622c2966a588)SelectAllFormations() [1/2]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.OrderController.SelectAllFormations | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *selectorAgent*, | |  |  | bool | *uiFeedback* ) | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a5816ddb568f1dce14cd306cfa3321c56)SelectAllFormations() [2/2]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.SelectAllFormations | ( | bool | *uiFeedback* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a0c4cd2e71ff59f5202e4ed54fb9ced10)ClearSelectedFormations()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.ClearSelectedFormations | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a1079230d637fe04145741c3053715350)SetOrder()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.OrderController.SetOrder | ( | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *orderType* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a3c378ca770a389030a8334fdef427d39)PlayFormationSelectedGesture()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.OrderController.PlayFormationSelectedGesture | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* ) | | staticprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a4b51b94ea208e06fc962c1ceb497de42)BeforeSetOrder()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.OrderController.BeforeSetOrder | ( | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *orderType* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a7ebbbc573dd742caffae831220a2f22e)SetOrderWithAgent()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.OrderController.SetOrderWithAgent | ( | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *orderType*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* ) | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a421e18edc2d33d60d99afc1950eb731c)SetOrderWithPosition()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.OrderController.SetOrderWithPosition | ( | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *orderType*, | |  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *orderPosition* ) | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a0c147b3c2eb62bc760ddb72e974c319b)SetOrderWithFormation()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.OrderController.SetOrderWithFormation | ( | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *orderType*, | |  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *orderFormation* ) | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a2f29e344cf1cda0b90d3e6db8b44d00d)SetOrderWithFormationAndPercentage()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.SetOrderWithFormationAndPercentage | ( | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *orderType*, |
|  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *orderFormation*, |
|  |  | float | *percentage* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a2c212da41918c58dde9d9467d983306b)TransferUnitWithPriorityFunction()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.TransferUnitWithPriorityFunction | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *orderFormation*, |
|  |  | int | *number*, |
|  |  | bool | *hasShield*, |
|  |  | bool | *hasSpear*, |
|  |  | bool | *hasThrown*, |
|  |  | bool | *isHeavy*, |
|  |  | bool | *isRanged*, |
|  |  | bool | *isMounted*, |
|  |  | bool | *excludeBannerman*, |
|  |  | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *excludedAgents* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#ad640956716fb177e5608d95bc770437c)RearrangeFormationsAccordingToFilters()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.RearrangeFormationsAccordingToFilters | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a30f240d5ab9488b7bec8c78c58cbdf17) | *team*, |
|  |  | List<([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, int troopCount, [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) troopFilter, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > excludedAgents)> | *MassTransferData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aae2037556b886ad2d86319c4f31fec5e)SetOrderWithFormationAndNumber()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.SetOrderWithFormationAndNumber | ( | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *orderType*, |
|  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *orderFormation*, |
|  |  | int | *number* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aac6018d4c3df903ff069d68d3799bc1c)SetOrderWithTwoPositions()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.OrderController.SetOrderWithTwoPositions | ( | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *orderType*, | |  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position1*, | |  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position2* ) | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a0b30b5cfd09861fc11d51b177b4809bc)SetOrderWithOrderableObject()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.OrderController.SetOrderWithOrderableObject | ( | [IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html) | *target* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aceaf02114a728874061c4e87f136dbe0)GetActiveMovementOrderOf()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.OrderController.GetActiveMovementOrderOf | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a0742753ac069d3f2d463f766527d2ab1)GetActiveFacingOrderOf()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.OrderController.GetActiveFacingOrderOf | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#abd3bc568f55c8cb9f2c0e98833a1a778)GetActiveRidingOrderOf()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.OrderController.GetActiveRidingOrderOf | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a2e56886159190135622920d8ef1f4242)GetActiveArrangementOrderOf()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.OrderController.GetActiveArrangementOrderOf | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a13e1f7696e2cf22682984addfa46ec53)GetActiveFormOrderOf()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.OrderController.GetActiveFormOrderOf | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a46bb8f8595fb42f0bf0c8b2251bd3946)GetActiveFiringOrderOf()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.OrderController.GetActiveFiringOrderOf | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a5c0d08318ff935cd1d06146d646386f5)GetActiveAIControlOrderOf()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.OrderController.GetActiveAIControlOrderOf | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a92fb94555d1b162b188982ebff7212dd)SimulateNewOrderWithPositionAndDirection() [1/3]
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.SimulateNewOrderWithPositionAndDirection | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *formationLineBegin*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *formationLineEnd*, |
|  |  | out List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > | *simulationAgentFrames*, |
|  |  | bool | *isFormationLayoutVertical* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#af0b90837cf6b0939dd54d688980be156)SimulateNewFacingOrder()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.SimulateNewFacingOrder | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction*, |
|  |  | out List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > | *simulationAgentFrames* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a9c34e824e8f13ce0e53591fd5e40c928)SimulateNewCustomWidthOrder()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.SimulateNewCustomWidthOrder | ( | float | *width*, |
|  |  | out List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > | *simulationAgentFrames* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aefea93ccc7220ca9c8bb44c82b3e5296)SimulateNewOrderWithPositionAndDirection() [2/3]
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.OrderController.SimulateNewOrderWithPositionAndDirection | ( | IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | *formations*, | |  |  | Dictionary< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | *simulationFormations*, | |  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *formationLineBegin*, | |  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *formationLineEnd*, | |  |  | out List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > | *simulationAgentFrames*, | |  |  | bool | *isFormationLayoutVertical* = true ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#ac9502fb284b38b3d222bb737dd1fcc27)SimulateNewOrderWithPositionAndDirection() [3/3]
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.OrderController.SimulateNewOrderWithPositionAndDirection | ( | IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | *formations*, | |  |  | Dictionary< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | *simulationFormations*, | |  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *formationLineBegin*, | |  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *formationLineEnd*, | |  |  | out List< ValueTuple< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), int, float, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html), [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > | *formationChanges*, | |  |  | out bool | *isLineShort*, | |  |  | bool | *isFormationLayoutVertical* = true ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a894600d1c39e34eb544ec9a32f7df6d0)SimulateDestinationFrames()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.SimulateDestinationFrames | ( | out List< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > | *simulationAgentFrames*, |
|  |  | float | *minDistance* = 3f ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a6a7f7ed4686d023c21bc0ebe053db412)SortFormationsForHorizontalLayout()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > TaleWorlds.MountAndBlade.OrderController.SortFormationsForHorizontalLayout | ( | IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | *formations* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a11399fccb05a6d2480f31824b78a7213)GetOrderLookAtDirection()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.OrderController.GetOrderLookAtDirection | ( | IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | *formations*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *target* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a1ad500e52b473427e505bf4356aee56d)GetOrderFormCustomWidth()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.OrderController.GetOrderFormCustomWidth | ( | IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | *formations*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *orderPosition* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a0e4bd99bb659dd148fface6b2fe7c952)TransferUnits()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.TransferUnits | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *source*, |
|  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *target*, |
|  |  | int | *count* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a43776cdb7ba08da97f7c3e20ea452aa1)SplitFormation()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| IEnumerable< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > TaleWorlds.MountAndBlade.OrderController.SplitFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, |
|  |  | int | *count* = 2 ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#afd8bbb7759e612182c855f63f52d3d41)FireOnOrderIssued()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.OrderController.FireOnOrderIssued | ( | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *orderType*, | |  |  | MBReadOnlyList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | *appliedFormations*, | |  |  | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a05ec6f13b7d608cdff05c56a4de89613) | *orderController*, | |  |  | params Object[] | *delegateParams* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#af2bc9fe1af1b5d9b0d0104f7ad49a9e4)TickDebug()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.TickDebug | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a37898cd06e426b7341d8e2147e60a5a5)AddOrderOverride()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.AddOrderOverride | ( | Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html), [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) > | *orderOverride* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a6c7a48263bb9c1895242583f4208fa1c)GetOverridenOrderType()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.OrderController.GetOverridenOrderType | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#aded6fc7704ee3cf8fc352a62f37f2f98)SetFormationUpdateEnabledAfterSetOrder()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.OrderController.SetFormationUpdateEnabledAfterSetOrder | ( | bool | *value* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a4188c4082c72b6e57b17c7eb72ac15b9)FormationGapInLine
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.OrderController.FormationGapInLine = 1.5f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a7f0acd3a0f1a50f714962ae60ceac60e)\_mission
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) TaleWorlds.MountAndBlade.OrderController.\_mission | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a30f240d5ab9488b7bec8c78c58cbdf17)Team
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Team TaleWorlds.MountAndBlade.OrderController.Team |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#afe98be11356ce8109492ce70d51d41e8)Owner
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.OrderController.Owner |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#af25d8b040660770147bed33ff30d1196)\_selectedFormations
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly MBList<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.OrderController.\_selectedFormations | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a1e7ce76c3f9fc306a952bbc2787e1468)\_formationUpdateEnabledAfterSetOrder
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.OrderController.\_formationUpdateEnabledAfterSetOrder = true | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a56e2c1adf664568eebe6d3d7e92ca9df)SiegeWeaponController
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SiegeWeaponController TaleWorlds.MountAndBlade.OrderController.SiegeWeaponController | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#ac6b7bf81daac06c0ce0adb0e88f8c999)SelectedFormations
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.OrderController.SelectedFormations | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a33e00fa9f8548e1729f36e4d834ec485)FormationUpdateEnabledAfterSetOrder
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.OrderController.FormationUpdateEnabledAfterSetOrder | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#a2748218472a85f7443467254b648138c)simulationFormations
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html)> TaleWorlds.MountAndBlade.OrderController.simulationFormations | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#af4dc95b03081008f679ed6fb2467663e)OnOrderIssued
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnOrderIssuedDelegate](namespace_tale_worlds_1_1_mount_and_blade.html#a7f395cbbac47ee66d0d985574f2740e9) TaleWorlds.MountAndBlade.OrderController.OnOrderIssued |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html#ad268961cee41da9b10d2d94d5584f378)OnSelectedFormationsChanged
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.OrderController.OnSelectedFormationsChanged |


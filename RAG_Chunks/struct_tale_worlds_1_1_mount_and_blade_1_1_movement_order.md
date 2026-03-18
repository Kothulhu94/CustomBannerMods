--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html ---

TaleWorlds.MountAndBlade.MovementOrder Struct Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) {     [Invalid](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a4bbb8f967da6d1a610596d7257179c2b) = 0 ,     [AttackEntity](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a831cadba3d4415118c7bf1f47747f75b) = 1 ,     [Charge](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a517349a3cdc1acf50617693e3ba33988) = 2 ,     [ChargeToTarget](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a615a6e7a9cd083cd3a2923e669f5fd9a) = 3 ,     [Follow](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a3903aab323863bd2e9b68218a7a65ebd) = 4 ,     [FollowEntity](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a1e528bbde352bc6ad18b7838c6f989fa) = 5 ,     [Move](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a6bc362dbf494c61ea117fe3c71ca48a5) = 7 ,     [Retreat](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a008bec353de180da9782954e7a1374e6) = 8 ,     [Stop](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a11a755d598c0c417f9a36758c3da7481) = 9 ,     [Advance](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a0a86dddc699c7e6fe7f1e43153a5cbee) = 10 ,     [FallBack](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95ad4e119b080e498be2b4712005e81f842) = 11   } |
| enum | [MovementStateEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a18231c246a87529c0da1a981fef77527) {     [Charge](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a18231c246a87529c0da1a981fef77527a517349a3cdc1acf50617693e3ba33988) = 0 ,     [Hold](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a18231c246a87529c0da1a981fef77527abcd8db575b47c838e5d551e3973db4ac) = 1 ,     [Retreat](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a18231c246a87529c0da1a981fef77527a008bec353de180da9782954e7a1374e6) = 2 ,     [StandGround](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a18231c246a87529c0da1a981fef77527a43bffab507dfb5c2cc7006e4e714c043)   } |
| enum | [Side](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae624bcdad60caaa144605804f1f01658) {     [Front](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae624bcdad60caaa144605804f1f01658a5835bab1ade0060909e31a06af2e2cde) ,     [Rear](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae624bcdad60caaa144605804f1f01658ac3e5b78d161cdc6f1f24fc7ef16d4795) ,     [Left](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae624bcdad60caaa144605804f1f01658a945d5e233cf7d6240f6b783b36a374ff) ,     [Right](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae624bcdad60caaa144605804f1f01658a92b09c7c48c520c3c55e497875da437c)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [Equals](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a5420d3d6ce53ec7be3357831a91e44da) (object obj) |
| override int | [GetHashCode](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ab74c3074f8fc6659edb707383169ff5e) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetPosition](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae20319727c50796eee433a7fc5203e18) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) f) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetTargetVelocity](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a128aaf187970fdf5228d9e9077c63fad) () |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [CreateNewOrderWorldPositionMT](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae026d2e8ed5b39bab89eafa78bbbe2c8) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) f, [WorldPosition.WorldPositionEnforcedCache](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9) worldPositionEnforcedCache) |
| void | [ResetPositionCache](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a216087972ef8267f925503bfd187b252) () |
| bool | [AreOrdersPracticallySame](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a30a30406394dce3188e4b646eeb44db6) (MovementOrder m1, MovementOrder m2, bool isAIControlled) |
| void | [OnApply](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a88039b7be06753dad941b52375c5dc9c) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [OnCancel](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a574023feb26f7e79b85f62aa46bc7eed) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [OnUnitJoinOrLeave](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae481bd46bced373a2ba0d42b0b28143e) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) unit, bool isJoining) |
| bool | [IsApplicable](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#aad0258cb189c880b4ee81986c6017709) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| bool | [Tick](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a234bc3f9433d9a67f859fa7b8256908e) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [OnArrangementChanged](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#adbfa41fa3f1f10e4170a294d11bb76a6) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [Advance](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a0f9ef700121378935a935871ad38abd2) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, float distance) |
| void | [FallBack](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a81186243603e596d2a86c380bafb0771) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, float distance) |
| MovementOrder | [GetSubstituteOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a3d05708b1b80dba16f18dd9db90e6e90) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [operator!=](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a9ceb9c2ec1f92082e525c30aa93b72af) (in MovementOrder m, MovementOrder obj) |
| static bool | [operator==](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a0a1754b3c17f7aeca33725405c76e7ce) (in MovementOrder m, MovementOrder obj) |
| static MovementOrder | [MovementOrderChargeToTarget](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#acc731f639e65654342072bafc2e55aac) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) targetFormation) |
| static MovementOrder | [MovementOrderFollow](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a9748fd8f92f93b318376cfcf43566867) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent) |
| static MovementOrder | [MovementOrderFollowEntity](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#aad4feb57d4229509590770763a40ebbc) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) targetEntity) |
| static MovementOrder | [MovementOrderMove](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a7120da6c288bb09a288dddf2a29c9b89) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position) |
| static MovementOrder | [MovementOrderAttackEntity](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#acbe6a79c0ad0425f985c02578982f980) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) targetEntity, bool surroundEntity) |
| static int | [GetMovementOrderDefensiveness](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a6126c88fec46ffed2fa3d011e53e3ffa) ([MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) orderEnum) |
| static int | [GetMovementOrderDefensivenessChange](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#af132ef57efa1baa88153d899b22c9c40) ([MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) previousOrderEnum, [MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) nextOrderEnum) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) | [OrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a685fc5ce767d77ccee179499a10973df) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [TargetEntity](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#acee86ad6a2ed2fa47f78efce7019d8dc) |
| readonly bool | [\_isFacingDirection](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a076f0572163da7e6f4bee029424a3713) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly MovementOrder | [MovementOrderNull](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#adcc93f99dbe2eaeff014c4b9bf6f498a) = new MovementOrder([MovementOrderEnum.Invalid](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a4bbb8f967da6d1a610596d7257179c2b)) |
| static readonly MovementOrder | [MovementOrderCharge](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#af46e8ce86e1bc630811f6855089463d9) = new MovementOrder([MovementOrderEnum.Charge](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a517349a3cdc1acf50617693e3ba33988)) |
| static readonly MovementOrder | [MovementOrderRetreat](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a137521027ec87d411719e44478f1dc8f) = new MovementOrder([MovementOrderEnum.Retreat](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a008bec353de180da9782954e7a1374e6)) |
| static readonly MovementOrder | [MovementOrderStop](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a93681ada83262ca685075d421120eb5d) = new MovementOrder([MovementOrderEnum.Stop](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a11a755d598c0c417f9a36758c3da7481)) |
| static readonly MovementOrder | [MovementOrderAdvance](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a503ab6b6aa51d5d006fe086c6dec9b9a) = new MovementOrder([MovementOrderEnum.Advance](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a0a86dddc699c7e6fe7f1e43153a5cbee)) |
| static readonly MovementOrder | [MovementOrderFallBack](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ac63d3cce07400f83795d99269e41d922) = new MovementOrder([MovementOrderEnum.FallBack](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95ad4e119b080e498be2b4712005e81f842)) |

|  |  |
| --- | --- |
| Properties | |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [TargetFormation](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a0971abb5cf9f2a1a6d4b68c8764000ba) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [\_targetAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a9b18f5ba01b08060282fbf946e1add14) `[get]` |
| [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [OrderType](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a5ce27b6ce3393b21f581cda08635118a) `[get]` |
| [MovementStateEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a18231c246a87529c0da1a981fef77527) | [MovementState](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a5dfad90f888e1e66849579d18bf40ce4) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95)MovementOrderEnum
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MovementOrder.MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) |

| Enumerator | |
| --- | --- |
| Invalid |  |
| AttackEntity |  |
| Charge |  |
| ChargeToTarget |  |
| Follow |  |
| FollowEntity |  |
| Move |  |
| Retreat |  |
| Stop |  |
| Advance |  |
| FallBack |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a18231c246a87529c0da1a981fef77527)MovementStateEnum
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MovementOrder.MovementStateEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a18231c246a87529c0da1a981fef77527) |

| Enumerator | |
| --- | --- |
| Charge |  |
| Hold |  |
| Retreat |  |
| StandGround |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae624bcdad60caaa144605804f1f01658)Side
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MovementOrder.Side](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae624bcdad60caaa144605804f1f01658) |

| Enumerator | |
| --- | --- |
| Front |  |
| Rear |  |
| Left |  |
| Right |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a5420d3d6ce53ec7be3357831a91e44da)Equals()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MovementOrder.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ab74c3074f8fc6659edb707383169ff5e)GetHashCode()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.MountAndBlade.MovementOrder.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a9ceb9c2ec1f92082e525c30aa93b72af)operator!=()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MovementOrder.operator!= | ( | in MovementOrder | *m*, | |  |  | MovementOrder | *obj* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a0a1754b3c17f7aeca33725405c76e7ce)operator==()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MovementOrder.operator== | ( | in MovementOrder | *m*, | |  |  | MovementOrder | *obj* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#acc731f639e65654342072bafc2e55aac)MovementOrderChargeToTarget()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MovementOrder TaleWorlds.MountAndBlade.MovementOrder.MovementOrderChargeToTarget | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *targetFormation* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a9748fd8f92f93b318376cfcf43566867)MovementOrderFollow()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MovementOrder TaleWorlds.MountAndBlade.MovementOrder.MovementOrderFollow | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#aad4feb57d4229509590770763a40ebbc)MovementOrderFollowEntity()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MovementOrder TaleWorlds.MountAndBlade.MovementOrder.MovementOrderFollowEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *targetEntity* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a7120da6c288bb09a288dddf2a29c9b89)MovementOrderMove()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MovementOrder TaleWorlds.MountAndBlade.MovementOrder.MovementOrderMove | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#acbe6a79c0ad0425f985c02578982f980)MovementOrderAttackEntity()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MovementOrder TaleWorlds.MountAndBlade.MovementOrder.MovementOrderAttackEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *targetEntity*, | |  |  | bool | *surroundEntity* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a6126c88fec46ffed2fa3d011e53e3ffa)GetMovementOrderDefensiveness()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MovementOrder.GetMovementOrderDefensiveness | ( | [MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) | *orderEnum* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#af132ef57efa1baa88153d899b22c9c40)GetMovementOrderDefensivenessChange()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MovementOrder.GetMovementOrderDefensivenessChange | ( | [MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) | *previousOrderEnum*, | |  |  | [MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) | *nextOrderEnum* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae20319727c50796eee433a7fc5203e18)GetPosition()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.MovementOrder.GetPosition | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *f* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a128aaf187970fdf5228d9e9077c63fad)GetTargetVelocity()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.MovementOrder.GetTargetVelocity | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae026d2e8ed5b39bab89eafa78bbbe2c8)CreateNewOrderWorldPositionMT()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.MovementOrder.CreateNewOrderWorldPositionMT | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *f*, |
|  |  | [WorldPosition.WorldPositionEnforcedCache](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9) | *worldPositionEnforcedCache* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a216087972ef8267f925503bfd187b252)ResetPositionCache()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MovementOrder.ResetPositionCache | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a30a30406394dce3188e4b646eeb44db6)AreOrdersPracticallySame()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MovementOrder.AreOrdersPracticallySame | ( | MovementOrder | *m1*, |
|  |  | MovementOrder | *m2*, |
|  |  | bool | *isAIControlled* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a88039b7be06753dad941b52375c5dc9c)OnApply()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MovementOrder.OnApply | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a574023feb26f7e79b85f62aa46bc7eed)OnCancel()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MovementOrder.OnCancel | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ae481bd46bced373a2ba0d42b0b28143e)OnUnitJoinOrLeave()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MovementOrder.OnUnitJoinOrLeave | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *unit*, |
|  |  | bool | *isJoining* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#aad0258cb189c880b4ee81986c6017709)IsApplicable()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MovementOrder.IsApplicable | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a234bc3f9433d9a67f859fa7b8256908e)Tick()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MovementOrder.Tick | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#adbfa41fa3f1f10e4170a294d11bb76a6)OnArrangementChanged()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MovementOrder.OnArrangementChanged | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a0f9ef700121378935a935871ad38abd2)Advance()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MovementOrder.Advance | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, |
|  |  | float | *distance* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a81186243603e596d2a86c380bafb0771)FallBack()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MovementOrder.FallBack | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, |
|  |  | float | *distance* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a3d05708b1b80dba16f18dd9db90e6e90)GetSubstituteOrder()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MovementOrder TaleWorlds.MountAndBlade.MovementOrder.GetSubstituteOrder | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#adcc93f99dbe2eaeff014c4b9bf6f498a)MovementOrderNull
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly MovementOrder TaleWorlds.MountAndBlade.MovementOrder.MovementOrderNull = new MovementOrder([MovementOrderEnum.Invalid](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a4bbb8f967da6d1a610596d7257179c2b)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#af46e8ce86e1bc630811f6855089463d9)MovementOrderCharge
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly MovementOrder TaleWorlds.MountAndBlade.MovementOrder.MovementOrderCharge = new MovementOrder([MovementOrderEnum.Charge](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a517349a3cdc1acf50617693e3ba33988)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a137521027ec87d411719e44478f1dc8f)MovementOrderRetreat
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly MovementOrder TaleWorlds.MountAndBlade.MovementOrder.MovementOrderRetreat = new MovementOrder([MovementOrderEnum.Retreat](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a008bec353de180da9782954e7a1374e6)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a93681ada83262ca685075d421120eb5d)MovementOrderStop
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly MovementOrder TaleWorlds.MountAndBlade.MovementOrder.MovementOrderStop = new MovementOrder([MovementOrderEnum.Stop](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a11a755d598c0c417f9a36758c3da7481)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a503ab6b6aa51d5d006fe086c6dec9b9a)MovementOrderAdvance
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly MovementOrder TaleWorlds.MountAndBlade.MovementOrder.MovementOrderAdvance = new MovementOrder([MovementOrderEnum.Advance](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95a0a86dddc699c7e6fe7f1e43153a5cbee)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#ac63d3cce07400f83795d99269e41d922)MovementOrderFallBack
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly MovementOrder TaleWorlds.MountAndBlade.MovementOrder.MovementOrderFallBack = new MovementOrder([MovementOrderEnum.FallBack](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95ad4e119b080e498be2b4712005e81f842)) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a685fc5ce767d77ccee179499a10973df)OrderEnum
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [MovementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a76e586c5e2ab511f2c81b00ad8059d95) TaleWorlds.MountAndBlade.MovementOrder.OrderEnum |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#acee86ad6a2ed2fa47f78efce7019d8dc)TargetEntity
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.MovementOrder.TargetEntity |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a076f0572163da7e6f4bee029424a3713)\_isFacingDirection
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.MovementOrder.\_isFacingDirection |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a0971abb5cf9f2a1a6d4b68c8764000ba)TargetFormation
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.MovementOrder.TargetFormation | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a9b18f5ba01b08060282fbf946e1add14)\_targetAgent
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.MovementOrder.\_targetAgent | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a5ce27b6ce3393b21f581cda08635118a)OrderType
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.MovementOrder.OrderType | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a5dfad90f888e1e66849579d18bf40ce4)MovementState
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MovementStateEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html#a18231c246a87529c0da1a981fef77527) TaleWorlds.MountAndBlade.MovementOrder.MovementState | | get |


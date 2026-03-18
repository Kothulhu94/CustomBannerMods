--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html ---

TaleWorlds.MountAndBlade.ITargetable Interface ReferenceInherited by [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html), and [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) | [GetTargetFlags](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a4896040b596dbef060fe758288c6dc50) () |
| float | [GetTargetValue](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a1886be0506013fe8a507455e8757cabd) (List< [Vec3](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a3ed452285ffcd12f5f9f3c1e6efd3db7) > referencePositions) |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetTargetEntity](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a5aa5463024c31a3ba6a7b7fc24fae5d6) () |
| [Vec3](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a3ed452285ffcd12f5f9f3c1e6efd3db7) | [GetTargetingOffset](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a8b4decd19d26033b51fea1229768f90a) () |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [GetSide](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a98702e32aad7d27beddd4b9e10cfaea8) () |
| [Vec3](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a3ed452285ffcd12f5f9f3c1e6efd3db7) | [GetTargetGlobalVelocity](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a5c2feb09f5f7100ff061c326195347a3) () |
| bool | [IsDestructable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a8ad0bcc26578d15cd5f685f914b0916e) () |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [Entity](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a76be23473311b932f02e0847ff2914ea) () |
| [Vec3](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a3ed452285ffcd12f5f9f3c1e6efd3db7) | [ComputeGlobalPhysicsBoundingBoxMinMax](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a799f4ef79e424866871412e5953af0bb) () |

|  |  |
| --- | --- |
| Public Attributes | |
|  | [Vec3](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a3ed452285ffcd12f5f9f3c1e6efd3db7) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a4896040b596dbef060fe758288c6dc50)GetTargetFlags()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TargetFlags](namespace_tale_worlds_1_1_mount_and_blade.html#a54230c76514f63e19c2e14dfedae9fb4) TaleWorlds.MountAndBlade.ITargetable.GetTargetFlags | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.Ballista](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a3758b69d67a7745d337e49abd5e29527), [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#ac968d519652f3d012fdf39085fac0ca2), [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#aebf49ecc00a4d18155f984a10ac98afe), [TaleWorlds.MountAndBlade.Mangonel](class_tale_worlds_1_1_mount_and_blade_1_1_mangonel.html#a79fc2579813686a5d260a09de7176669), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a26e1c7f7415b3088b570682b0dad7466), [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a9fb62f407ec516cb468ce2510422240c), [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a5e92e28256a00dbfed4037dfe754aaac), and [TaleWorlds.MountAndBlade.Trebuchet](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet.html#a264843d7a07151e2d23f242b106db9e1).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a1886be0506013fe8a507455e8757cabd)GetTargetValue()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.ITargetable.GetTargetValue | ( | List< [Vec3](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a3ed452285ffcd12f5f9f3c1e6efd3db7) > | *referencePositions* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.Ballista](class_tale_worlds_1_1_mount_and_blade_1_1_ballista.html#a0c0a3eb63f693236d3036d7897cb3610), [TaleWorlds.MountAndBlade.BatteringRam](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram.html#a39cc9819565a3a91062a9b00a2673262), [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#aac5d28153ed06885d9cb385742338ae5), [TaleWorlds.MountAndBlade.Mangonel](class_tale_worlds_1_1_mount_and_blade_1_1_mangonel.html#a35557556915721d665d7d884729d96a7), [TaleWorlds.MountAndBlade.SiegeLadder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder.html#a801822eefc478a336a1b871540c69129), [TaleWorlds.MountAndBlade.SiegeTower](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower.html#a6ec85f00f062feea39b32786da997cc4), [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a0f45ce6a53a41d4b0143f7a7d08e995d), and [TaleWorlds.MountAndBlade.Trebuchet](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet.html#a63d6cb225870535fe80dfd847e400bfe).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a5aa5463024c31a3ba6a7b7fc24fae5d6)GetTargetEntity()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.MountAndBlade.ITargetable.GetTargetEntity | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#a551055ff9df44abe448b2d940ef28281), and [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a55e93698cedbb4963a503758475ee251).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a8b4decd19d26033b51fea1229768f90a)GetTargetingOffset()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a3ed452285ffcd12f5f9f3c1e6efd3db7) TaleWorlds.MountAndBlade.ITargetable.GetTargetingOffset | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#a1b307cbc9e08f2d4889ff817e4d79307), and [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a3ebe3ad09b2d50e66cec54412f88135f).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a98702e32aad7d27beddd4b9e10cfaea8)GetSide()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.MountAndBlade.ITargetable.GetSide | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#a3f3bfa95b45a9596d6e1ecc2729ef27f), and [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a1efe44f7f390ec3bb08e77e66c8068d0).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a5c2feb09f5f7100ff061c326195347a3)GetTargetGlobalVelocity()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a3ed452285ffcd12f5f9f3c1e6efd3db7) TaleWorlds.MountAndBlade.ITargetable.GetTargetGlobalVelocity | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#a7a62ca33dbdb1b4140a8aad27383fea8), and [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#abe922cfc407185f4b0a40cfd0b987d0e).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a8ad0bcc26578d15cd5f685f914b0916e)IsDestructable()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ITargetable.IsDestructable | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#ada586676ee7a022fdb45144afc886188), and [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a29cebb1d01706f1efff91c6530e6640a).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a76be23473311b932f02e0847ff2914ea)Entity()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.MountAndBlade.ITargetable.Entity | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#a5ab37c1214cf37edcff720507a014b1e), and [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a9b9aa4f3be2d18eeb037283c8ace843d).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a799f4ef79e424866871412e5953af0bb)ComputeGlobalPhysicsBoundingBoxMinMax()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a3ed452285ffcd12f5f9f3c1e6efd3db7) TaleWorlds.MountAndBlade.ITargetable.ComputeGlobalPhysicsBoundingBoxMinMax | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.CastleGate](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate.html#a6c6e21970918c246d5765f4069d336b9), and [TaleWorlds.MountAndBlade.SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_siege_weapon.html#a4305cb6425e1ceaf57e8573c6113a189).

Member Data Documentation
-------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_targetable.html#a3ed452285ffcd12f5f9f3c1e6efd3db7)Vec3
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| TaleWorlds.MountAndBlade.ITargetable.Vec3 |


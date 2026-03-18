--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html ---

TaleWorlds.CampaignSystem.Naval.Ship Class ReferencesealedInherits [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html), and [TaleWorlds.CampaignSystem.IRandomOwner](interface_tale_worlds_1_1_campaign_system_1_1_i_random_owner.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [ChangeFigurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a09db426870afc418a9513001a558154a) ([Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a848a5fffd4a50c79233818aa0aeacf42) figurehead) |
| [ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html) | [GetPieceAtSlot](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a8477daa806a1b0541d7090da2c080c80) (string slotTag) |
| void | [EquipUpgradePiece](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a5c9c30fd3307eeb0a6bca4f26b8bde32) (string slotTag, [ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html) newUpgradePiece) |
| bool | [HasSlot](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a171efd82827d0071a5dfe3566388a0eb) (string slotTag) |
| void | [SetName](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a283d58965f703cffd6cb8144ab16b4d5) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name) |
|  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a32680aa34cbc6985d91374be5ab2406c) ([ShipHull](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ad5c0b70cf4338d1a0e1b933c8884b695) shipHull) |
| float | [GetCampaignSpeed](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ace9e463a170c242281a34c0155b2cf37) () |
| MBList< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a672ecafb15ccb43ad36916f09ecce716) () |
| void | [UpdateVersionNo](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a9d6f0be66d7a9064b05592e00a1a55f5) () |
| float | [GetCombatFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a1ba8c38a2b6b1d118e182f970ac99045) () |
| void | [OnShipDamaged](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ac95f4f9e7aaccd32e65a47f052a66b43) (float rawDamage, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) rammingShip, out float modifiedDamage) |
| List< [ShipVisualSlotInfo](struct_tale_worlds_1_1_core_1_1_ship_visual_slot_info.html) > | [GetShipVisualSlotInfos](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a5df0c3d62fc1b5d0318d10101908b764) () |
| List< [ShipSlotAndPieceName](struct_tale_worlds_1_1_core_1_1_ship_slot_and_piece_name.html) > | [GetShipSlotAndPieceNames](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#af48be91cdeb0a6eed5d2c73cc4604ba2) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly ShipHull | [ShipHull](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ad5c0b70cf4338d1a0e1b933c8884b695) |

|  |  |
| --- | --- |
| Properties | |
| Figurehead | [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a848a5fffd4a50c79233818aa0aeacf42) `[get]` |
| bool | [IsInvulnerable](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a4794f4f8d7773583967a600ede151d30) `[get, set]` |
| bool | [IsTradeable](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a5d6db0e33c2720712988949c5acffe21) = true `[get, set]` |
| bool | [IsUsedByQuest](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a38aa1ef3722693745908d891f2831804) `[get, set]` |
| int | [RandomValue](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a0345393950d14a387f2087f70032d58a) = [MBRandom.RandomInt](class_tale_worlds_1_1_core_1_1_m_b_random.html#a7d276a08934ed0203f18e814b5584619)(1, int.MaxValue) `[get]` |
| string | [CustomSailPatternId](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a6c1574e011cb22fefb3306b36c59d4b5) = "" `[get, set]` |
| MBReadOnlyList< [ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html) > | [UnlockedUpgradePieces](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ad7fd1956d03fec230f69ff4d3e5d3666) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a75aa88f563425306c8127336d5cee30f) `[get]` |
| uint | [VersionNo](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#afef83581d5cd5ef9a8dbddff03a1c59f) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#abd584b241fbab9d43b968bcedb6a6ac8) `[get, set]` |
| float | [HitPoints](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a4dcd4674ce983ab3b3f098031b976773) `[get, set]` |
| float | [MaxHitPoints](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#aaf3ff84925776370b7a2399ad154436e) `[get]` |
| float | [MaxFireHitPoints](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a0a154053bb794a69dd8e7f0022191246) `[get]` |
| float | [SailHitPoints](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#acd7bba7fd62ef273970c1fac5225e43a) `[get, set]` |
| int | [TotalCrewCapacity](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a3005795f415112f49bb335b1ae031fcc) `[get]` |
| float | [MaxSailHitPoints](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a7a0ba5dc816fe395d22326b77ab2255b) `[get]` |
| int | [SeaWorthiness](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#aeb4668b46923b159411f3fcad35dd602) `[get]` |
| float | [FlagshipScore](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a8ac31916850b2ee9f55ce04c714e3b0c) `[get]` |
| int | [MainDeckCrewCapacity](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a8dbd98a2e4b94ceb8722253aa2072a59) `[get]` |
| float | [InventoryCapacity](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#afb97e368f0ce52068c8b7f97994516ae) `[get]` |
| int | [SkeletalCrewCapacity](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a2e3ea68fe7aea897449fe4d17172c7f6) `[get]` |
| float | [CrewCapacityBonusFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#aeed7ecff0ec0da56b0f628d6d605c2e7) `[get]` |
| float | [ShipWeightFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ab3da4fcdd95a2d6eddbe3a5f4e5e6e42) `[get]` |
| float | [ForwardDragFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ab7a41cdf908f6d69785bb65665de42de) `[get]` |
| float | [CrewShieldHitPointsFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#aa00e17932decebcaf2c8c5c04d1e1d59) `[get]` |
| int | [AdditionalAmmo](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a3ab8f7de958090ae048cca10ad6cd6cd) `[get]` |
| float | [MaxOarPowerFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a77e917af5de4eda5825c204ffdec1c53) `[get]` |
| float | [MaxOarForceFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ace7044115e0b47f746d59cb1dcc99cbb) `[get]` |
| float | [SailForceFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a701e584210e24934176ccd253d1e53ba) `[get]` |
| float | [CrewMeleeDamageFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a3082e7e18278676be55d7f2e45b3adde) `[get]` |
| int | [AdditionalArcherQuivers](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a7f17562d67d5eb44525c04fbaa1b44e8) `[get]` |
| int | [AdditionalThrowingWeaponStack](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a7a285e0ffac80c137d0e8fae94711e15) `[get]` |
| float | [SailRotationSpeedFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a563dcf5235df9476368c502a0ea9fbac) `[get]` |
| float | [FurlUnfurlSpeedFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ace8aa1fb7c39528f590cea8e282bfb24) `[get]` |
| float | [RudderSurfaceAreaFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a60fcfe139f008a504e989a54fe89682a) `[get]` |
| float | [MaxRudderForceFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ae5a4c422c1357ffd41f933805d2fa0fd) `[get]` |
| bool | [CanEquipFigurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#aad31e2db519ae4729ee7f199f9cee55e) `[get]` |
| float | [CampaignSpeedBonusFactor](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#af6a1b4c4e42d8526b09d1b09715d3472) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a32680aa34cbc6985d91374be5ab2406c)Ship()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Naval.Ship.Ship | ( | [ShipHull](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ad5c0b70cf4338d1a0e1b933c8884b695) | *shipHull* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a09db426870afc418a9513001a558154a)ChangeFigurehead()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.Ship.ChangeFigurehead | ( | [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a848a5fffd4a50c79233818aa0aeacf42) | *figurehead* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a8477daa806a1b0541d7090da2c080c80)GetPieceAtSlot()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html) TaleWorlds.CampaignSystem.Naval.Ship.GetPieceAtSlot | ( | string | *slotTag* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a5c9c30fd3307eeb0a6bca4f26b8bde32)EquipUpgradePiece()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.Ship.EquipUpgradePiece | ( | string | *slotTag*, |
|  |  | [ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html) | *newUpgradePiece* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a171efd82827d0071a5dfe3566388a0eb)HasSlot()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Naval.Ship.HasSlot | ( | string | *slotTag* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a283d58965f703cffd6cb8144ab16b4d5)SetName()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.Ship.SetName | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ace9e463a170c242281a34c0155b2cf37)GetCampaignSpeed()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Naval.Ship.GetCampaignSpeed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a672ecafb15ccb43ad36916f09ecce716)GetSiegeEngines()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBList< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.Naval.Ship.GetSiegeEngines | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a9d6f0be66d7a9064b05592e00a1a55f5)UpdateVersionNo()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.Ship.UpdateVersionNo | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a1ba8c38a2b6b1d118e182f970ac99045)GetCombatFactor()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Naval.Ship.GetCombatFactor | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ac95f4f9e7aaccd32e65a47f052a66b43)OnShipDamaged()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.Ship.OnShipDamaged | ( | float | *rawDamage*, |
|  |  | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *rammingShip*, |
|  |  | out float | *modifiedDamage* ) |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ab8ee6142626c6b56a2fb04aecc18df3a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a5df0c3d62fc1b5d0318d10101908b764)GetShipVisualSlotInfos()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [ShipVisualSlotInfo](struct_tale_worlds_1_1_core_1_1_ship_visual_slot_info.html) > TaleWorlds.CampaignSystem.Naval.Ship.GetShipVisualSlotInfos | ( |  | ) |  |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a41ee3428c61a844dc8a9d7bb7b86f39e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#af48be91cdeb0a6eed5d2c73cc4604ba2)GetShipSlotAndPieceNames()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [ShipSlotAndPieceName](struct_tale_worlds_1_1_core_1_1_ship_slot_and_piece_name.html) > TaleWorlds.CampaignSystem.Naval.Ship.GetShipSlotAndPieceNames | ( |  | ) |  |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#aef10ae076465bf2b37d8af57d9c40b7f).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ad5c0b70cf4338d1a0e1b933c8884b695)ShipHull
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly ShipHull TaleWorlds.CampaignSystem.Naval.Ship.ShipHull |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a848a5fffd4a50c79233818aa0aeacf42)Figurehead
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Figurehead TaleWorlds.CampaignSystem.Naval.Ship.Figurehead | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a4794f4f8d7773583967a600ede151d30)IsInvulnerable
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Naval.Ship.IsInvulnerable | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a5d6db0e33c2720712988949c5acffe21)IsTradeable
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Naval.Ship.IsTradeable = true | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a38aa1ef3722693745908d891f2831804)IsUsedByQuest
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Naval.Ship.IsUsedByQuest | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a0345393950d14a387f2087f70032d58a)RandomValue
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Naval.Ship.RandomValue = [MBRandom.RandomInt](class_tale_worlds_1_1_core_1_1_m_b_random.html#a7d276a08934ed0203f18e814b5584619)(1, int.MaxValue) | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a91e245b9ad75847988d98e6c0cdadfe1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a6c1574e011cb22fefb3306b36c59d4b5)CustomSailPatternId
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Naval.Ship.CustomSailPatternId = "" | | getset |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a72eff86bddecdcd1e39b415494c61d2a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ad7fd1956d03fec230f69ff4d3e5d3666)UnlockedUpgradePieces
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html)> TaleWorlds.CampaignSystem.Naval.Ship.UnlockedUpgradePieces | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a75aa88f563425306c8127336d5cee30f)Name
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Naval.Ship.Name | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ada5e2c22d51b92778cf92c24ffcb1ac8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#afef83581d5cd5ef9a8dbddff03a1c59f)VersionNo
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.CampaignSystem.Naval.Ship.VersionNo | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#abd584b241fbab9d43b968bcedb6a6ac8)Owner
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Naval.Ship.Owner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a4dcd4674ce983ab3b3f098031b976773)HitPoints
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.HitPoints | | getset |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a8fc326e311d74049e70240e754e9f95d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#aaf3ff84925776370b7a2399ad154436e)MaxHitPoints
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.MaxHitPoints | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a7548416c3884e89b504ca1fe7b1fa830).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a0a154053bb794a69dd8e7f0022191246)MaxFireHitPoints
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.MaxFireHitPoints | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a9864e38646e30b6174e4847b5bc7c4e2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#acd7bba7fd62ef273970c1fac5225e43a)SailHitPoints
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.SailHitPoints | | getset |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a6b13ea298b571886a934c882eec23f65).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a3005795f415112f49bb335b1ae031fcc)TotalCrewCapacity
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Naval.Ship.TotalCrewCapacity | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a3c3fa66bcc38d3c72b5760f94f22f5b6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a7a0ba5dc816fe395d22326b77ab2255b)MaxSailHitPoints
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.MaxSailHitPoints | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a482cca7f52ced03381a7cb6011f950cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#aeb4668b46923b159411f3fcad35dd602)SeaWorthiness
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Naval.Ship.SeaWorthiness | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a8ac31916850b2ee9f55ce04c714e3b0c)FlagshipScore
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.FlagshipScore | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a8dbd98a2e4b94ceb8722253aa2072a59)MainDeckCrewCapacity
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Naval.Ship.MainDeckCrewCapacity | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#aa5c0437f0c36ddb4b07b8715ffa34433).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#afb97e368f0ce52068c8b7f97994516ae)InventoryCapacity
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.InventoryCapacity | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a2e3ea68fe7aea897449fe4d17172c7f6)SkeletalCrewCapacity
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Naval.Ship.SkeletalCrewCapacity | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a26d4c04947d59cca9a11092bcca77637).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#aeed7ecff0ec0da56b0f628d6d605c2e7)CrewCapacityBonusFactor
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.CrewCapacityBonusFactor | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ab3da4fcdd95a2d6eddbe3a5f4e5e6e42)ShipWeightFactor
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.ShipWeightFactor | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a08de281fcc7fd2694e36ca766fafb331).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ab7a41cdf908f6d69785bb65665de42de)ForwardDragFactor
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.ForwardDragFactor | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ab7c14434f78a87f2785b3cf3ea1c077f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#aa00e17932decebcaf2c8c5c04d1e1d59)CrewShieldHitPointsFactor
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.CrewShieldHitPointsFactor | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ae1fdd458ff508bdb6900aa7d825af880).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a3ab8f7de958090ae048cca10ad6cd6cd)AdditionalAmmo
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Naval.Ship.AdditionalAmmo | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a77e917af5de4eda5825c204ffdec1c53)MaxOarPowerFactor
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.MaxOarPowerFactor | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a8f0761cf6db25375da505952a133456c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ace7044115e0b47f746d59cb1dcc99cbb)MaxOarForceFactor
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.MaxOarForceFactor | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a54bdea8debcd0f2918753d2eac92d6c0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a701e584210e24934176ccd253d1e53ba)SailForceFactor
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.SailForceFactor | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a225793300a95eaf4a0bc467ca110b8ae).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a3082e7e18278676be55d7f2e45b3adde)CrewMeleeDamageFactor
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.CrewMeleeDamageFactor | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#abfd41e3cf1f17213da95e637e42a01f2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a7f17562d67d5eb44525c04fbaa1b44e8)AdditionalArcherQuivers
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Naval.Ship.AdditionalArcherQuivers | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#af3ff30098d3f3891433535a82991788a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a7a285e0ffac80c137d0e8fae94711e15)AdditionalThrowingWeaponStack
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Naval.Ship.AdditionalThrowingWeaponStack | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a73f29299b3df5cc05abe0eb84ace4276).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a563dcf5235df9476368c502a0ea9fbac)SailRotationSpeedFactor
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.SailRotationSpeedFactor | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ad5b3fdf7262724b0cdbde937fd5ddab6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ace8aa1fb7c39528f590cea8e282bfb24)FurlUnfurlSpeedFactor
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.FurlUnfurlSpeedFactor | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a0991fea60ec4e7663bc6be9ff92ca3ef).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a60fcfe139f008a504e989a54fe89682a)RudderSurfaceAreaFactor
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.RudderSurfaceAreaFactor | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a25ca615cfc57d2cd1eab84140b0a8b6f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ae5a4c422c1357ffd41f933805d2fa0fd)MaxRudderForceFactor
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.MaxRudderForceFactor | | get |

Implements [TaleWorlds.Core.IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a75c47936631b00124446bd8ca73a994f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#aad31e2db519ae4729ee7f199f9cee55e)CanEquipFigurehead
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Naval.Ship.CanEquipFigurehead | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#af6a1b4c4e42d8526b09d1b09715d3472)CampaignSpeedBonusFactor
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Naval.Ship.CampaignSpeedBonusFactor | | get |


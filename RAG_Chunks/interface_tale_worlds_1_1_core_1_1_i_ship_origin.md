--- SOURCE: interface_tale_worlds_1_1_core_1_1_i_ship_origin.html ---

TaleWorlds.Core.IShipOrigin Interface ReferenceInherited by [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnShipDamaged](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ab8ee6142626c6b56a2fb04aecc18df3a) (float rawDamage, [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) rammingShip, out float modifiedDamage) |
| void | [OnSailDamaged](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a43896a2b748159c66057e11dd668717b) (float rawDamage) |
| List< [ShipVisualSlotInfo](struct_tale_worlds_1_1_core_1_1_ship_visual_slot_info.html) > | [GetShipVisualSlotInfos](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a41ee3428c61a844dc8a9d7bb7b86f39e) () |
| List< [ShipSlotAndPieceName](struct_tale_worlds_1_1_core_1_1_ship_slot_and_piece_name.html) > | [GetShipSlotAndPieceNames](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#aef10ae076465bf2b37d8af57d9c40b7f) () |

|  |  |
| --- | --- |
| Properties | |
| [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) | [Hull](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a18561ed2e730c2620ee93fe4915c20ae) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ada5e2c22d51b92778cf92c24ffcb1ac8) `[get]` |
| string | [OriginShipId](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a18c4e9d6037f819c23ca8289531e9750) `[get]` |
| bool | [IsPlayerShip](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a0ecf8d3f4db7c3a176af763c03d360e3) `[get]` |
| float | [HitPoints](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a8fc326e311d74049e70240e754e9f95d) `[get]` |
| float | [MaxHitPoints](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a7548416c3884e89b504ca1fe7b1fa830) `[get]` |
| float | [MaxFireHitPoints](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a9864e38646e30b6174e4847b5bc7c4e2) `[get]` |
| float | [SailHitPoints](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a6b13ea298b571886a934c882eec23f65) `[get]` |
| float | [MaxSailHitPoints](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a482cca7f52ced03381a7cb6011f950cc) `[get]` |
| int | [TotalCrewCapacity](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a3c3fa66bcc38d3c72b5760f94f22f5b6) `[get]` |
| int | [MainDeckCrewCapacity](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#aa5c0437f0c36ddb4b07b8715ffa34433) `[get]` |
| int | [SkeletalCrewCapacity](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a26d4c04947d59cca9a11092bcca77637) `[get]` |
| int | [DefaultFormationGroupIndex](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a9645000414ee112284eaca8a038c42f9) `[get]` |
| float | [ForwardDragFactor](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ab7c14434f78a87f2785b3cf3ea1c077f) `[get]` |
| float | [ShipWeightFactor](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a08de281fcc7fd2694e36ca766fafb331) `[get]` |
| float | [RudderSurfaceAreaFactor](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a25ca615cfc57d2cd1eab84140b0a8b6f) `[get]` |
| int | [RandomValue](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a91e245b9ad75847988d98e6c0cdadfe1) `[get]` |
| string | [CustomSailPatternId](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a72eff86bddecdcd1e39b415494c61d2a) `[get]` |
| float | [MaxRudderForceFactor](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a75c47936631b00124446bd8ca73a994f) `[get]` |
| float | [MaxOarForceFactor](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a54bdea8debcd0f2918753d2eac92d6c0) `[get]` |
| float | [SailForceFactor](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a225793300a95eaf4a0bc467ca110b8ae) `[get]` |
| float | [MaxOarPowerFactor](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a8f0761cf6db25375da505952a133456c) `[get]` |
| float | [SailRotationSpeedFactor](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ad5b3fdf7262724b0cdbde937fd5ddab6) `[get]` |
| float | [FurlUnfurlSpeedFactor](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a0991fea60ec4e7663bc6be9ff92ca3ef) `[get]` |
| float | [CrewShieldHitPointsFactor](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ae1fdd458ff508bdb6900aa7d825af880) `[get]` |
| float | [CrewMeleeDamageFactor](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#abfd41e3cf1f17213da95e637e42a01f2) `[get]` |
| int | [AdditionalArcherQuivers](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#af3ff30098d3f3891433535a82991788a) `[get]` |
| int | [AdditionalThrowingWeaponStack](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a73f29299b3df5cc05abe0eb84ace4276) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ab8ee6142626c6b56a2fb04aecc18df3a)OnShipDamaged()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.IShipOrigin.OnShipDamaged | ( | float | *rawDamage*, |
|  |  | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *rammingShip*, |
|  |  | out float | *modifiedDamage* ) |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ac95f4f9e7aaccd32e65a47f052a66b43).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a43896a2b748159c66057e11dd668717b)OnSailDamaged()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.IShipOrigin.OnSailDamaged | ( | float | *rawDamage* | ) |  |

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a41ee3428c61a844dc8a9d7bb7b86f39e)GetShipVisualSlotInfos()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [ShipVisualSlotInfo](struct_tale_worlds_1_1_core_1_1_ship_visual_slot_info.html) > TaleWorlds.Core.IShipOrigin.GetShipVisualSlotInfos | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a5df0c3d62fc1b5d0318d10101908b764).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#aef10ae076465bf2b37d8af57d9c40b7f)GetShipSlotAndPieceNames()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [ShipSlotAndPieceName](struct_tale_worlds_1_1_core_1_1_ship_slot_and_piece_name.html) > TaleWorlds.Core.IShipOrigin.GetShipSlotAndPieceNames | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#af48be91cdeb0a6eed5d2c73cc4604ba2).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a18561ed2e730c2620ee93fe4915c20ae)Hull
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) TaleWorlds.Core.IShipOrigin.Hull | | get |

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ada5e2c22d51b92778cf92c24ffcb1ac8)Name
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.IShipOrigin.Name | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a75aa88f563425306c8127336d5cee30f).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a18c4e9d6037f819c23ca8289531e9750)OriginShipId
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.IShipOrigin.OriginShipId | | get |

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a0ecf8d3f4db7c3a176af763c03d360e3)IsPlayerShip
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.IShipOrigin.IsPlayerShip | | get |

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a8fc326e311d74049e70240e754e9f95d)HitPoints
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.HitPoints | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a4dcd4674ce983ab3b3f098031b976773).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a7548416c3884e89b504ca1fe7b1fa830)MaxHitPoints
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.MaxHitPoints | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#aaf3ff84925776370b7a2399ad154436e).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a9864e38646e30b6174e4847b5bc7c4e2)MaxFireHitPoints
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.MaxFireHitPoints | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a0a154053bb794a69dd8e7f0022191246).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a6b13ea298b571886a934c882eec23f65)SailHitPoints
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.SailHitPoints | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#acd7bba7fd62ef273970c1fac5225e43a).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a482cca7f52ced03381a7cb6011f950cc)MaxSailHitPoints
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.MaxSailHitPoints | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a7a0ba5dc816fe395d22326b77ab2255b).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a3c3fa66bcc38d3c72b5760f94f22f5b6)TotalCrewCapacity
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.IShipOrigin.TotalCrewCapacity | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a3005795f415112f49bb335b1ae031fcc).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#aa5c0437f0c36ddb4b07b8715ffa34433)MainDeckCrewCapacity
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.IShipOrigin.MainDeckCrewCapacity | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a8dbd98a2e4b94ceb8722253aa2072a59).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a26d4c04947d59cca9a11092bcca77637)SkeletalCrewCapacity
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.IShipOrigin.SkeletalCrewCapacity | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a2e3ea68fe7aea897449fe4d17172c7f6).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a9645000414ee112284eaca8a038c42f9)DefaultFormationGroupIndex
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.IShipOrigin.DefaultFormationGroupIndex | | get |

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ab7c14434f78a87f2785b3cf3ea1c077f)ForwardDragFactor
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.ForwardDragFactor | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ab7a41cdf908f6d69785bb65665de42de).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a08de281fcc7fd2694e36ca766fafb331)ShipWeightFactor
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.ShipWeightFactor | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ab3da4fcdd95a2d6eddbe3a5f4e5e6e42).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a25ca615cfc57d2cd1eab84140b0a8b6f)RudderSurfaceAreaFactor
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.RudderSurfaceAreaFactor | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a60fcfe139f008a504e989a54fe89682a).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a91e245b9ad75847988d98e6c0cdadfe1)RandomValue
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.IShipOrigin.RandomValue | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a0345393950d14a387f2087f70032d58a).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a72eff86bddecdcd1e39b415494c61d2a)CustomSailPatternId
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.IShipOrigin.CustomSailPatternId | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a6c1574e011cb22fefb3306b36c59d4b5).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a75c47936631b00124446bd8ca73a994f)MaxRudderForceFactor
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.MaxRudderForceFactor | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ae5a4c422c1357ffd41f933805d2fa0fd).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a54bdea8debcd0f2918753d2eac92d6c0)MaxOarForceFactor
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.MaxOarForceFactor | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ace7044115e0b47f746d59cb1dcc99cbb).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a225793300a95eaf4a0bc467ca110b8ae)SailForceFactor
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.SailForceFactor | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a701e584210e24934176ccd253d1e53ba).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a8f0761cf6db25375da505952a133456c)MaxOarPowerFactor
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.MaxOarPowerFactor | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a77e917af5de4eda5825c204ffdec1c53).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ad5b3fdf7262724b0cdbde937fd5ddab6)SailRotationSpeedFactor
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.SailRotationSpeedFactor | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a563dcf5235df9476368c502a0ea9fbac).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a0991fea60ec4e7663bc6be9ff92ca3ef)FurlUnfurlSpeedFactor
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.FurlUnfurlSpeedFactor | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#ace8aa1fb7c39528f590cea8e282bfb24).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#ae1fdd458ff508bdb6900aa7d825af880)CrewShieldHitPointsFactor
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.CrewShieldHitPointsFactor | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#aa00e17932decebcaf2c8c5c04d1e1d59).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#abfd41e3cf1f17213da95e637e42a01f2)CrewMeleeDamageFactor
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.IShipOrigin.CrewMeleeDamageFactor | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a3082e7e18278676be55d7f2e45b3adde).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#af3ff30098d3f3891433535a82991788a)AdditionalArcherQuivers
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.IShipOrigin.AdditionalArcherQuivers | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a7f17562d67d5eb44525c04fbaa1b44e8).

[◆](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html#a73f29299b3df5cc05abe0eb84ace4276)AdditionalThrowingWeaponStack
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.IShipOrigin.AdditionalThrowingWeaponStack | | get |

Implemented in [TaleWorlds.CampaignSystem.Naval.Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html#a7a285e0ffac80c137d0e8fae94711e15).


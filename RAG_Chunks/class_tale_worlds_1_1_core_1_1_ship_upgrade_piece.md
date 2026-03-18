--- SOURCE: class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html ---

TaleWorlds.Core.ShipUpgradePiece Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a9e8c5b0765d7cb97ab62538868d90d5c) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override string | [ToString](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a8e6704775fa54ba570ada6cf340ad492) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#aa7507f9b237e1249019907cd0a997b6b) () |
| bool | [DoesPieceMatchSlot](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#ae7b96ec1de699307b924670f99bf98a4) ([ShipSlot](class_tale_worlds_1_1_core_1_1_ship_slot.html) slot) |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a6702389b68030543f33a51d5da58a87f) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Description](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a643848b3837cc3193044d7e596fd2a39) `[get]` |
| MBReadOnlyList< [ShipSlot](class_tale_worlds_1_1_core_1_1_ship_slot.html) > | [TargetSlots](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a9ba19aec757dbcded8ab8493c224c4c2) `[get]` |
| int | [LightValue](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#ab93b55c2514af5d5fe713581bbaee6d2) `[get]` |
| int | [MediumValue](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#af823369708a3c930b763781ee039834e) `[get]` |
| int | [HeavyValue](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#ae655f74d3fb92b8cb3853e817c0bffee) `[get]` |
| string | [SlotPrefabChildTagId](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#abe1b815baef2dfd8ddbe17c4f8eeaadf) `[get]` |
| bool | [NotMerchandise](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a51477c498862067f909a1420d3b2ff02) `[get]` |
| float | [CombatFactor](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a8781f44b158467ab7ac71914ef443ff8) `[get]` |
| float | [CrewCapacityBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a5e89cf0608f45c7fd57a46775fc4632b) `[get]` |
| int | [RequiredPortLevel](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a0ab354d5bf38f127f6268d8ad76f51f4) `[get]` |
| float | [ShipWeightBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a6e2f6a2d9c55c6c7e270298afd0f64e5) `[get]` |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [RequiredCulture1](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a57a56039a1e71856494b74daa0d18200) `[get]` |
| float | [DecreaseForwardDragMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a93e6bfa8bf214f9c868e557934d2b5d5) `[get]` |
| float | [CampaignSpeedBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a0b96f2fa34bc7806a774d4f3494e67c8) `[get]` |
| float | [MaxHitPointsBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#aa40d6d78aa80d975bb93def41cfd3852) `[get]` |
| float | [MaxSailHitPointsBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a3705e3e2a4e4a99fc0a12b77c14590b6) `[get]` |
| int | [SeaWorthinessBonus](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#aff38aa972333174e2999b221fb73e988) `[get]` |
| float | [CrewShieldHitPointsBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#ae2340e60d99eca41839b9386c7de88a6) `[get]` |
| float | [InventoryCapacityBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#abcef5560de50394413332f6c29f2a283) `[get]` |
| int | [AdditionalAmmoBonus](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#ac15853dd826a26df362cc2d51025df57) `[get]` |
| float | [MaxOarPowerBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#aa09db2cf6c7c93ec5402580643389a90) `[get]` |
| float | [MaxOarForceBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a3c097761e6f80a5c18d56d8b63bbbd18) `[get]` |
| float | [SailForceBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a90757040685a250f8ca1ced8304d1d9d) `[get]` |
| float | [CrewMeleeDamageBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a4b7ef5573aa9cd26a829f20320f9781b) `[get]` |
| int | [ArcherQuiverBonus](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a7493436d423da619f74d5ff735555551) `[get]` |
| int | [ThrowingWeaponStackBonus](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#af9b13717980cd3082eeccca8bbfc03fc) `[get]` |
| float | [SailRotationSpeedBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#affa9d68fd07b904cb3d5b62780213b48) `[get]` |
| float | [FurlUnfurlSpeedBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#ac403d774b185c4c56f2e7c2994a22e7e) `[get]` |
| float | [RudderSurfaceAreaBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a095f3422dd8a16d7e6e7485ef281baaf) `[get]` |
| float | [MaxRudderForceBonusMultiplier](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a6661f6bccf76bee9e98d09190b671f76) `[get]` |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [RequiredCulture2](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#aac4bef5d6672bb64d6b779ed46fa6982) `[get]` |
| [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | [SiegeEngine](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#acd7acc50e46fe38c9f1ea15fc9624a70) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a9e8c5b0765d7cb97ab62538868d90d5c)Deserialize()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.ShipUpgradePiece.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a8e6704775fa54ba570ada6cf340ad492)ToString()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Core.ShipUpgradePiece.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#aa7507f9b237e1249019907cd0a997b6b)GetName()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.ShipUpgradePiece.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db).

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#ae7b96ec1de699307b924670f99bf98a4)DoesPieceMatchSlot()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.ShipUpgradePiece.DoesPieceMatchSlot | ( | [ShipSlot](class_tale_worlds_1_1_core_1_1_ship_slot.html) | *slot* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a6702389b68030543f33a51d5da58a87f)Name
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.ShipUpgradePiece.Name | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a643848b3837cc3193044d7e596fd2a39)Description
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.ShipUpgradePiece.Description | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a9ba19aec757dbcded8ab8493c224c4c2)TargetSlots
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[ShipSlot](class_tale_worlds_1_1_core_1_1_ship_slot.html)> TaleWorlds.Core.ShipUpgradePiece.TargetSlots | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#ab93b55c2514af5d5fe713581bbaee6d2)LightValue
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipUpgradePiece.LightValue | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#af823369708a3c930b763781ee039834e)MediumValue
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipUpgradePiece.MediumValue | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#ae655f74d3fb92b8cb3853e817c0bffee)HeavyValue
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipUpgradePiece.HeavyValue | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#abe1b815baef2dfd8ddbe17c4f8eeaadf)SlotPrefabChildTagId
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ShipUpgradePiece.SlotPrefabChildTagId | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a51477c498862067f909a1420d3b2ff02)NotMerchandise
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ShipUpgradePiece.NotMerchandise | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a8781f44b158467ab7ac71914ef443ff8)CombatFactor
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.CombatFactor | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a5e89cf0608f45c7fd57a46775fc4632b)CrewCapacityBonusMultiplier
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.CrewCapacityBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a0ab354d5bf38f127f6268d8ad76f51f4)RequiredPortLevel
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipUpgradePiece.RequiredPortLevel | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a6e2f6a2d9c55c6c7e270298afd0f64e5)ShipWeightBonusMultiplier
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.ShipWeightBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a57a56039a1e71856494b74daa0d18200)RequiredCulture1
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.Core.ShipUpgradePiece.RequiredCulture1 | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a93e6bfa8bf214f9c868e557934d2b5d5)DecreaseForwardDragMultiplier
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.DecreaseForwardDragMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a0b96f2fa34bc7806a774d4f3494e67c8)CampaignSpeedBonusMultiplier
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.CampaignSpeedBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#aa40d6d78aa80d975bb93def41cfd3852)MaxHitPointsBonusMultiplier
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.MaxHitPointsBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a3705e3e2a4e4a99fc0a12b77c14590b6)MaxSailHitPointsBonusMultiplier
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.MaxSailHitPointsBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#aff38aa972333174e2999b221fb73e988)SeaWorthinessBonus
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipUpgradePiece.SeaWorthinessBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#ae2340e60d99eca41839b9386c7de88a6)CrewShieldHitPointsBonusMultiplier
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.CrewShieldHitPointsBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#abcef5560de50394413332f6c29f2a283)InventoryCapacityBonusMultiplier
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.InventoryCapacityBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#ac15853dd826a26df362cc2d51025df57)AdditionalAmmoBonus
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipUpgradePiece.AdditionalAmmoBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#aa09db2cf6c7c93ec5402580643389a90)MaxOarPowerBonusMultiplier
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.MaxOarPowerBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a3c097761e6f80a5c18d56d8b63bbbd18)MaxOarForceBonusMultiplier
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.MaxOarForceBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a90757040685a250f8ca1ced8304d1d9d)SailForceBonusMultiplier
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.SailForceBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a4b7ef5573aa9cd26a829f20320f9781b)CrewMeleeDamageBonusMultiplier
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.CrewMeleeDamageBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a7493436d423da619f74d5ff735555551)ArcherQuiverBonus
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipUpgradePiece.ArcherQuiverBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#af9b13717980cd3082eeccca8bbfc03fc)ThrowingWeaponStackBonus
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipUpgradePiece.ThrowingWeaponStackBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#affa9d68fd07b904cb3d5b62780213b48)SailRotationSpeedBonusMultiplier
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.SailRotationSpeedBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#ac403d774b185c4c56f2e7c2994a22e7e)FurlUnfurlSpeedBonusMultiplier
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.FurlUnfurlSpeedBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a095f3422dd8a16d7e6e7485ef281baaf)RudderSurfaceAreaBonusMultiplier
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.RudderSurfaceAreaBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#a6661f6bccf76bee9e98d09190b671f76)MaxRudderForceBonusMultiplier
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipUpgradePiece.MaxRudderForceBonusMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#aac4bef5d6672bb64d6b779ed46fa6982)RequiredCulture2
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.Core.ShipUpgradePiece.RequiredCulture2 | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html#acd7acc50e46fe38c9f1ea15fc9624a70)SiegeEngine
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) TaleWorlds.Core.ShipUpgradePiece.SiegeEngine | | get |


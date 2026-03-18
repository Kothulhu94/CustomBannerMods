--- SOURCE: class_tale_worlds_1_1_core_1_1_ship_hull.html ---

TaleWorlds.Core.ShipHull Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [ShipType](class_tale_worlds_1_1_core_1_1_ship_hull.html#af22c50b07c217512c6242e74038d2c4e) {     [Light](class_tale_worlds_1_1_core_1_1_ship_hull.html#af22c50b07c217512c6242e74038d2c4ea9914a0ce04a7b7b6a8e39bec55064b82) ,     [Medium](class_tale_worlds_1_1_core_1_1_ship_hull.html#af22c50b07c217512c6242e74038d2c4ea87f8a6ab85c9ced3702b4ea641ad4bb5) ,     [Heavy](class_tale_worlds_1_1_core_1_1_ship_hull.html#af22c50b07c217512c6242e74038d2c4eaf9ffe67a20da9cbff56b420fca4bd491)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override string | [ToString](class_tale_worlds_1_1_core_1_1_ship_hull.html#a16e051d2505d8497caccbd3e6bbb3e35) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_core_1_1_ship_hull.html#a8e3e9a810594d6868bbe89241464b872) () |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_ship_hull.html#a3ab86cf42623f063ddaf845def72d004) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
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
| Public Attributes | |
| MBReadOnlyDictionary< string, [ShipSlot](class_tale_worlds_1_1_core_1_1_ship_slot.html) > | [AvailableSlots](class_tale_worlds_1_1_core_1_1_ship_hull.html#a98f8c7a334a687a5c11f463f447d617b) |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_core_1_1_ship_hull.html#abb59e4ef12c37f7ecb99a3de83171b4d) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Description](class_tale_worlds_1_1_core_1_1_ship_hull.html#ab6d466b795542b13f7a6665367a26cba) `[get]` |
| string | [EncyclopediaLink](class_tale_worlds_1_1_core_1_1_ship_hull.html#af50784c57f04804bedce713bd2314715) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaLinkWithName](class_tale_worlds_1_1_core_1_1_ship_hull.html#a4e29cb360294a14636c5b97cfc94fb36) `[get]` |
| float | [BaseSpeed](class_tale_worlds_1_1_core_1_1_ship_hull.html#acede10f99ff5026d779628d9460defa4) `[get]` |
| int | [Value](class_tale_worlds_1_1_core_1_1_ship_hull.html#a81cbd5fe0e49bc843a6d6b138b65e263) `[get]` |
| bool | [HasHold](class_tale_worlds_1_1_core_1_1_ship_hull.html#a463bf3be03f8362f3c24484bb96ff62d) `[get]` |
| bool | [CanNavigateShallowWater](class_tale_worlds_1_1_core_1_1_ship_hull.html#ad9f25aaaed8cd6d25b03db8d6b3c7e63) `[get]` |
| bool | [CanEquipFigurehead](class_tale_worlds_1_1_core_1_1_ship_hull.html#ae23a93b49365f31be86053f5befd1bcd) `[get]` |
| float | [ProductionBuildWeight](class_tale_worlds_1_1_core_1_1_ship_hull.html#a83fd047dd9251e0e58ec12919b67fadb) `[get]` |
| int | [SeaWorthiness](class_tale_worlds_1_1_core_1_1_ship_hull.html#a5fae2ba79115d33bd3a113f3be82d5d4) `[get]` |
| [ShipType](class_tale_worlds_1_1_core_1_1_ship_hull.html#af22c50b07c217512c6242e74038d2c4e) | [Type](class_tale_worlds_1_1_core_1_1_ship_hull.html#a073560fc6344de3090ab6e7e173010ff) `[get]` |
| bool | [IsTradeShip](class_tale_worlds_1_1_core_1_1_ship_hull.html#a729b8b4058b8dd40d6f0687a09ef6b5e) `[get]` |
| string | [MissionShipObjectId](class_tale_worlds_1_1_core_1_1_ship_hull.html#a965a04c2143f2130be24f47a8e17f93b) `[get]` |
| int | [DefaultFormationGroup](class_tale_worlds_1_1_core_1_1_ship_hull.html#abb85d21fe17584dc6a2c7067484e278a) `[get]` |
| int | [InventoryCapacity](class_tale_worlds_1_1_core_1_1_ship_hull.html#ae52ce6c457602894c0508f3474699def) `[get]` |
| int | [MaxHitPoints](class_tale_worlds_1_1_core_1_1_ship_hull.html#a724f763441507ea43be8c8c90745ccfa) `[get]` |
| int | [MaxFireHitPoints](class_tale_worlds_1_1_core_1_1_ship_hull.html#ac768cd5fa2303a5fd8a7255da6d38535) `[get]` |
| int | [MaxSailHitPoints](class_tale_worlds_1_1_core_1_1_ship_hull.html#a0c73607a6d16e74413fa7020b537177c) `[get]` |
| int | [TotalCrewCapacity](class_tale_worlds_1_1_core_1_1_ship_hull.html#a5714fc6a7bf0be5900c0b866e9cc3cdc) `[get]` |
| int | [MainDeckCrewCapacity](class_tale_worlds_1_1_core_1_1_ship_hull.html#a6aa610a96272a12f84c561b76a9db8a5) `[get]` |
| int | [SkeletalCrewCapacity](class_tale_worlds_1_1_core_1_1_ship_hull.html#ab90d7f3bfb80ca22fd35cf2c76ab5ab2) `[get]` |
| float | [MapVisualScale](class_tale_worlds_1_1_core_1_1_ship_hull.html#aac2d2fb7cc18abbf1f208df20a0e53e9) `[get]` |
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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#af22c50b07c217512c6242e74038d2c4e)ShipType
--------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ShipHull.ShipType](class_tale_worlds_1_1_core_1_1_ship_hull.html#af22c50b07c217512c6242e74038d2c4e) |

| Enumerator | |
| --- | --- |
| Light |  |
| Medium |  |
| Heavy |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a16e051d2505d8497caccbd3e6bbb3e35)ToString()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Core.ShipHull.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a8e3e9a810594d6868bbe89241464b872)GetName()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.ShipHull.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db).

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a3ab86cf42623f063ddaf845def72d004)Deserialize()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.ShipHull.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a98f8c7a334a687a5c11f463f447d617b)AvailableSlots
--------------------------------------------------------------------------------------------------

|  |
| --- |
| MBReadOnlyDictionary<string, [ShipSlot](class_tale_worlds_1_1_core_1_1_ship_slot.html)> TaleWorlds.Core.ShipHull.AvailableSlots |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#abb59e4ef12c37f7ecb99a3de83171b4d)Name
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.ShipHull.Name | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#ab6d466b795542b13f7a6665367a26cba)Description
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.ShipHull.Description | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#af50784c57f04804bedce713bd2314715)EncyclopediaLink
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ShipHull.EncyclopediaLink | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a4e29cb360294a14636c5b97cfc94fb36)EncyclopediaLinkWithName
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.ShipHull.EncyclopediaLinkWithName | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#acede10f99ff5026d779628d9460defa4)BaseSpeed
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipHull.BaseSpeed | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a81cbd5fe0e49bc843a6d6b138b65e263)Value
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipHull.Value | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a463bf3be03f8362f3c24484bb96ff62d)HasHold
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ShipHull.HasHold | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#ad9f25aaaed8cd6d25b03db8d6b3c7e63)CanNavigateShallowWater
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ShipHull.CanNavigateShallowWater | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#ae23a93b49365f31be86053f5befd1bcd)CanEquipFigurehead
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ShipHull.CanEquipFigurehead | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a83fd047dd9251e0e58ec12919b67fadb)ProductionBuildWeight
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipHull.ProductionBuildWeight | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a5fae2ba79115d33bd3a113f3be82d5d4)SeaWorthiness
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipHull.SeaWorthiness | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a073560fc6344de3090ab6e7e173010ff)Type
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ShipType](class_tale_worlds_1_1_core_1_1_ship_hull.html#af22c50b07c217512c6242e74038d2c4e) TaleWorlds.Core.ShipHull.Type | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a729b8b4058b8dd40d6f0687a09ef6b5e)IsTradeShip
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ShipHull.IsTradeShip | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a965a04c2143f2130be24f47a8e17f93b)MissionShipObjectId
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ShipHull.MissionShipObjectId | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#abb85d21fe17584dc6a2c7067484e278a)DefaultFormationGroup
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipHull.DefaultFormationGroup | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#ae52ce6c457602894c0508f3474699def)InventoryCapacity
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipHull.InventoryCapacity | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a724f763441507ea43be8c8c90745ccfa)MaxHitPoints
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipHull.MaxHitPoints | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#ac768cd5fa2303a5fd8a7255da6d38535)MaxFireHitPoints
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipHull.MaxFireHitPoints | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a0c73607a6d16e74413fa7020b537177c)MaxSailHitPoints
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipHull.MaxSailHitPoints | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a5714fc6a7bf0be5900c0b866e9cc3cdc)TotalCrewCapacity
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipHull.TotalCrewCapacity | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#a6aa610a96272a12f84c561b76a9db8a5)MainDeckCrewCapacity
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipHull.MainDeckCrewCapacity | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#ab90d7f3bfb80ca22fd35cf2c76ab5ab2)SkeletalCrewCapacity
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ShipHull.SkeletalCrewCapacity | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_hull.html#aac2d2fb7cc18abbf1f208df20a0e53e9)MapVisualScale
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ShipHull.MapVisualScale | | get |


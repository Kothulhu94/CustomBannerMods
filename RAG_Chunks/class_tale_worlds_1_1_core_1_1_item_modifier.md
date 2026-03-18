--- SOURCE: class_tale_worlds_1_1_core_1_1_item_modifier.html ---

TaleWorlds.Core.ItemModifier Class ReferencesealedInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html#a7cadf6d272d342dc3666790329b48358) () |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_item_modifier.html#ae7c8bbeb00be9e2550fc81215c1e4b5e) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
|  | De-serializes the object from an XmlNode. |
| bool | [Equals](class_tale_worlds_1_1_core_1_1_item_modifier.html#a6a10959a326e2701700ee962adbe5cc3) ([ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html#a7cadf6d272d342dc3666790329b48358) other) |
| override int | [GetHashCode](class_tale_worlds_1_1_core_1_1_item_modifier.html#a240a1c103ee92972b75355c57208db38) () |
| int | [ModifyDamage](class_tale_worlds_1_1_core_1_1_item_modifier.html#a7a34a51493aab5cb2a27d5f4a2a346a8) (int baseDamage) |
| int | [ModifySpeed](class_tale_worlds_1_1_core_1_1_item_modifier.html#add9184f8b05925fe9d6eb0392e10632b) (int baseSpeed) |
| int | [ModifyMountSpeed](class_tale_worlds_1_1_core_1_1_item_modifier.html#af0042ee38829d3fd4f7e2eecabff4173) (int baseSpeed) |
| int | [ModifyMountManeuver](class_tale_worlds_1_1_core_1_1_item_modifier.html#ac49e3c2c9cdffd49683a8ab54310656a) (int baseManeuver) |
| int | [ModifyMountCharge](class_tale_worlds_1_1_core_1_1_item_modifier.html#ae5e2cb20d1ec1e59c57e44fbfe72a5e7) (int baseCharge) |
| int | [ModifyMountHitPoints](class_tale_worlds_1_1_core_1_1_item_modifier.html#a4039bc9f10dd038ccd1f2b96d1d708fb) (int baseCharge) |
| int | [ModifyMissileSpeed](class_tale_worlds_1_1_core_1_1_item_modifier.html#a602d2da02fd6c750f56b37195f74d812) (int baseSpeed) |
| int | [ModifyArmor](class_tale_worlds_1_1_core_1_1_item_modifier.html#ae37532a72e269bcc748fcd406ea69449) (int armorValue) |
| short | [ModifyHitPoints](class_tale_worlds_1_1_core_1_1_item_modifier.html#a8d80bb991133ed8c333092a471e9520e) (short baseHitPoints) |
| short | [ModifyStackCount](class_tale_worlds_1_1_core_1_1_item_modifier.html#ae3744c4b9a687ee427f2dae9b9131bb0) (short baseStackCount) |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_core_1_1_item_modifier.html#af8092820f47c671b03c400bf5b391d0d) `[get]` |
| int | [Damage](class_tale_worlds_1_1_core_1_1_item_modifier.html#a6c963e72a8c862fe6730805d9fac38a7) `[get]` |
| int | [Speed](class_tale_worlds_1_1_core_1_1_item_modifier.html#abd63e221eb159e4101c36cb1c99290e2) `[get]` |
| int | [MissileSpeed](class_tale_worlds_1_1_core_1_1_item_modifier.html#a813f4c318c92378150b6ee32ac23f1e7) `[get]` |
| int | [Armor](class_tale_worlds_1_1_core_1_1_item_modifier.html#a14819dd24eedd9c7b4e465b3853698c8) `[get]` |
| short | [HitPoints](class_tale_worlds_1_1_core_1_1_item_modifier.html#a06dfef80b0b505caede1f1ccef947461) `[get]` |
| short | [StackCount](class_tale_worlds_1_1_core_1_1_item_modifier.html#a3dffc4869ae95f6351ee833febf300a5) `[get]` |
| float | [MountSpeed](class_tale_worlds_1_1_core_1_1_item_modifier.html#a0047dfc0200fade262e4077c3f03c2e4) `[get]` |
| float | [Maneuver](class_tale_worlds_1_1_core_1_1_item_modifier.html#a58f66fba9e583930bec3815969103f5b) `[get]` |
| float | [ChargeDamage](class_tale_worlds_1_1_core_1_1_item_modifier.html#ac3c85168c7e76aada51a779affb6e2c6) `[get]` |
| float | [MountHitPoints](class_tale_worlds_1_1_core_1_1_item_modifier.html#a90f03a89ce6123818175b986b0a7f4b8) `[get]` |
| float | [LootDropScore](class_tale_worlds_1_1_core_1_1_item_modifier.html#a231bbbe95eaf73a125d61365ecf7f113) `[get]` |
| float | [ProductionDropScore](class_tale_worlds_1_1_core_1_1_item_modifier.html#ae4a19f765b927e6ee1ee009a48ddc7ce) `[get]` |
| float | [PriceMultiplier](class_tale_worlds_1_1_core_1_1_item_modifier.html#a6016ed54eb93037391b9e4dff916fc50) `[get]` |
| [ItemQuality](namespace_tale_worlds_1_1_core.html#aebf9446f74d061b64b5a59626ee69a96) | [ItemQuality](class_tale_worlds_1_1_core_1_1_item_modifier.html#a7aeb3fd2f50dd3cf576f53f4f2b679af) `[get]` |
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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a7cadf6d272d342dc3666790329b48358)ItemModifier()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.ItemModifier.ItemModifier | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#ae7c8bbeb00be9e2550fc81215c1e4b5e)Deserialize()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.ItemModifier.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | node | XmlNode to be de-serialized from. |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a6a10959a326e2701700ee962adbe5cc3)Equals()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.ItemModifier.Equals | ( | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html#a7cadf6d272d342dc3666790329b48358) | *other* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a240a1c103ee92972b75355c57208db38)GetHashCode()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Core.ItemModifier.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a7a34a51493aab5cb2a27d5f4a2a346a8)ModifyDamage()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.ItemModifier.ModifyDamage | ( | int | *baseDamage* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#add9184f8b05925fe9d6eb0392e10632b)ModifySpeed()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.ItemModifier.ModifySpeed | ( | int | *baseSpeed* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#af0042ee38829d3fd4f7e2eecabff4173)ModifyMountSpeed()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.ItemModifier.ModifyMountSpeed | ( | int | *baseSpeed* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#ac49e3c2c9cdffd49683a8ab54310656a)ModifyMountManeuver()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.ItemModifier.ModifyMountManeuver | ( | int | *baseManeuver* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#ae5e2cb20d1ec1e59c57e44fbfe72a5e7)ModifyMountCharge()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.ItemModifier.ModifyMountCharge | ( | int | *baseCharge* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a4039bc9f10dd038ccd1f2b96d1d708fb)ModifyMountHitPoints()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.ItemModifier.ModifyMountHitPoints | ( | int | *baseCharge* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a602d2da02fd6c750f56b37195f74d812)ModifyMissileSpeed()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.ItemModifier.ModifyMissileSpeed | ( | int | *baseSpeed* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#ae37532a72e269bcc748fcd406ea69449)ModifyArmor()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.ItemModifier.ModifyArmor | ( | int | *armorValue* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a8d80bb991133ed8c333092a471e9520e)ModifyHitPoints()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| short TaleWorlds.Core.ItemModifier.ModifyHitPoints | ( | short | *baseHitPoints* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#ae3744c4b9a687ee427f2dae9b9131bb0)ModifyStackCount()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| short TaleWorlds.Core.ItemModifier.ModifyStackCount | ( | short | *baseStackCount* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#af8092820f47c671b03c400bf5b391d0d)Name
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.ItemModifier.Name | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a6c963e72a8c862fe6730805d9fac38a7)Damage
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ItemModifier.Damage | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#abd63e221eb159e4101c36cb1c99290e2)Speed
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ItemModifier.Speed | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a813f4c318c92378150b6ee32ac23f1e7)MissileSpeed
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ItemModifier.MissileSpeed | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a14819dd24eedd9c7b4e465b3853698c8)Armor
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ItemModifier.Armor | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a06dfef80b0b505caede1f1ccef947461)HitPoints
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.Core.ItemModifier.HitPoints | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a3dffc4869ae95f6351ee833febf300a5)StackCount
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | short TaleWorlds.Core.ItemModifier.StackCount | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a0047dfc0200fade262e4077c3f03c2e4)MountSpeed
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemModifier.MountSpeed | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a58f66fba9e583930bec3815969103f5b)Maneuver
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemModifier.Maneuver | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#ac3c85168c7e76aada51a779affb6e2c6)ChargeDamage
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemModifier.ChargeDamage | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a90f03a89ce6123818175b986b0a7f4b8)MountHitPoints
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemModifier.MountHitPoints | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a231bbbe95eaf73a125d61365ecf7f113)LootDropScore
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemModifier.LootDropScore | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#ae4a19f765b927e6ee1ee009a48ddc7ce)ProductionDropScore
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemModifier.ProductionDropScore | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a6016ed54eb93037391b9e4dff916fc50)PriceMultiplier
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemModifier.PriceMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier.html#a7aeb3fd2f50dd3cf576f53f4f2b679af)ItemQuality
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemQuality](namespace_tale_worlds_1_1_core.html#aebf9446f74d061b64b5a59626ee69a96) TaleWorlds.Core.ItemModifier.ItemQuality | | get |


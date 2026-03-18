--- SOURCE: class_tale_worlds_1_1_core_1_1_horse_component.html ---

TaleWorlds.Core.HorseComponent Class ReferenceInherits [TaleWorlds.Core.ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [MaterialProperty](struct_tale_worlds_1_1_core_1_1_horse_component_1_1_material_property.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [HorseComponent](class_tale_worlds_1_1_core_1_1_horse_component.html#a3f9a75ad84d2f3e5bec3df37942a6016) () |
| override [ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html#a2ee720148fe6c25a2ceb780721d5f725) | [GetCopy](class_tale_worlds_1_1_core_1_1_horse_component.html#a901d12ec0a8c9922ada6bec17af7e2df) () |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_horse_component.html#a7e164d57c6aa6c396652f9f34e25ef21) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| Public Member Functions inherited from [TaleWorlds.Core.ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html) | |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_item_component.html#a6ac3b10aca5e561af97b46ae38c45a3a) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| [ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html#a2ee720148fe6c25a2ceb780721d5f725) | [GetCopy](class_tale_worlds_1_1_core_1_1_item_component.html#a2b8cbfc2e40e54b74030bfc720e152d2) () |
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
| Public Attributes | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [ModifiedName](class_tale_worlds_1_1_core_1_1_horse_component.html#a3a1e35f825cdbcc71ce63c1a56da0ca2) |
| List< KeyValuePair< string, bool > > | [AdditionalMeshesNameList](class_tale_worlds_1_1_core_1_1_horse_component.html#a9e3e0d4061ace2280ead7f1b146f32f2) |

|  |  |
| --- | --- |
| Properties | |
| Monster | [Monster](class_tale_worlds_1_1_core_1_1_horse_component.html#a3cfe1335e9759feb078e354c6ea6a5a4) `[get]` |
| int | [Maneuver](class_tale_worlds_1_1_core_1_1_horse_component.html#a20357be7ddb80a89e5327de9f368dafb) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html). Do not use this without modifier check. |
| int | [ChargeDamage](class_tale_worlds_1_1_core_1_1_horse_component.html#af6a516f38d93889601381758b3f6375e) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html). Do not use this without modifier check. |
| int | [Speed](class_tale_worlds_1_1_core_1_1_horse_component.html#a856586785d042f40a55780f4e8ddb53b) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html). Do not use this without modifier check. |
| int | [BodyLength](class_tale_worlds_1_1_core_1_1_horse_component.html#a921012b9bd6c63d4fe662d87e7a9b6b4) `[get]` |
| int | [HitPoints](class_tale_worlds_1_1_core_1_1_horse_component.html#ad39bee01220c4c87203c7221528d06ac) `[get]` |
|  | Used internally by [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html). Do not use this without modifier check. |
| int | [HitPointBonus](class_tale_worlds_1_1_core_1_1_horse_component.html#ad4afb76908866bffde31a70c1b787eef) `[get]` |
| bool | [IsRideable](class_tale_worlds_1_1_core_1_1_horse_component.html#a1fd3ce5d91aefbf4eff2c8d2d35e24e0) `[get]` |
| bool | [IsPackAnimal](class_tale_worlds_1_1_core_1_1_horse_component.html#a80f990526eb9f39921893a3b5f14bd63) `[get]` |
| bool | [IsMount](class_tale_worlds_1_1_core_1_1_horse_component.html#a3efa14081df07a5afb59511ae8a0aa40) `[get]` |
| bool | [IsLiveStock](class_tale_worlds_1_1_core_1_1_horse_component.html#ac048ef640bd22e277003563ca50ee07b) `[get]` |
| MBReadOnlyList< [MaterialProperty](struct_tale_worlds_1_1_core_1_1_horse_component_1_1_material_property.html) > | [HorseMaterialNames](class_tale_worlds_1_1_core_1_1_horse_component.html#aab416af70fdb14c4de2df55c13008974) `[get]` |
| int | [MeatCount](class_tale_worlds_1_1_core_1_1_horse_component.html#ac94768a709ed11deecc686da5af65dce) `[get]` |
| int | [HideCount](class_tale_worlds_1_1_core_1_1_horse_component.html#ac943923c71f4d56647e3df47777cb855) `[get]` |
| SkeletonScale | [SkeletonScale](class_tale_worlds_1_1_core_1_1_horse_component.html#a6b5d2c1dd474fb2030847119aafef8ac) `[get]` |
| Properties inherited from [TaleWorlds.Core.ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html) | |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [Item](class_tale_worlds_1_1_core_1_1_item_component.html#aa69328db32063a71a0d403ba2a5366c7) `[get, set]` |
| ItemModifierGroup | [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_component.html#a546f74aaae70e4455e4540fd5166b678) `[get, protected set]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.Core.ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html) | |
|  | [ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html#a2ee720148fe6c25a2ceb780721d5f725) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a3f9a75ad84d2f3e5bec3df37942a6016)HorseComponent()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.HorseComponent.HorseComponent | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a901d12ec0a8c9922ada6bec17af7e2df)GetCopy()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html#a2ee720148fe6c25a2ceb780721d5f725) TaleWorlds.Core.HorseComponent.GetCopy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a7e164d57c6aa6c396652f9f34e25ef21)Deserialize()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.HorseComponent.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a3a1e35f825cdbcc71ce63c1a56da0ca2)ModifiedName
------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.HorseComponent.ModifiedName |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a9e3e0d4061ace2280ead7f1b146f32f2)AdditionalMeshesNameList
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<KeyValuePair<string, bool> > TaleWorlds.Core.HorseComponent.AdditionalMeshesNameList |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a3cfe1335e9759feb078e354c6ea6a5a4)Monster
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Monster TaleWorlds.Core.HorseComponent.Monster | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a20357be7ddb80a89e5327de9f368dafb)Maneuver
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.HorseComponent.Maneuver | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#af6a516f38d93889601381758b3f6375e)ChargeDamage
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.HorseComponent.ChargeDamage | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a856586785d042f40a55780f4e8ddb53b)Speed
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.HorseComponent.Speed | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a921012b9bd6c63d4fe662d87e7a9b6b4)BodyLength
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.HorseComponent.BodyLength | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#ad39bee01220c4c87203c7221528d06ac)HitPoints
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.HorseComponent.HitPoints | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#ad4afb76908866bffde31a70c1b787eef)HitPointBonus
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.HorseComponent.HitPointBonus | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a1fd3ce5d91aefbf4eff2c8d2d35e24e0)IsRideable
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.HorseComponent.IsRideable | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a80f990526eb9f39921893a3b5f14bd63)IsPackAnimal
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.HorseComponent.IsPackAnimal | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a3efa14081df07a5afb59511ae8a0aa40)IsMount
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.HorseComponent.IsMount | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#ac048ef640bd22e277003563ca50ee07b)IsLiveStock
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.HorseComponent.IsLiveStock | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#aab416af70fdb14c4de2df55c13008974)HorseMaterialNames
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MaterialProperty](struct_tale_worlds_1_1_core_1_1_horse_component_1_1_material_property.html)> TaleWorlds.Core.HorseComponent.HorseMaterialNames | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#ac94768a709ed11deecc686da5af65dce)MeatCount
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.HorseComponent.MeatCount | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#ac943923c71f4d56647e3df47777cb855)HideCount
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.HorseComponent.HideCount | | get |

[◆](class_tale_worlds_1_1_core_1_1_horse_component.html#a6b5d2c1dd474fb2030847119aafef8ac)SkeletonScale
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SkeletonScale TaleWorlds.Core.HorseComponent.SkeletonScale | | get |


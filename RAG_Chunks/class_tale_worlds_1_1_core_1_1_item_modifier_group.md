--- SOURCE: class_tale_worlds_1_1_core_1_1_item_modifier_group.html ---

TaleWorlds.Core.ItemModifierGroup Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#a27c992803070ea6ac5b14adb3ef11690) () |
|  | [ItemModifierGroup](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#ae550827b1029d949354347abb9338390) (string id) |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#a0d2a0030e76ec6273ced75c290a76955) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
|  | De-serializes the object from an XmlNode. |
| void | [AddItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#aae3a5f4cf48e8244b53061e66b90ab00) ([ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) itemModifier) |
| [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | [GetRandomItemModifierLootScoreBased](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#a82ca2e1b61bb4d2e0a693b7d43043e55) () |
| [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | [GetRandomItemModifierProductionScoreBased](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#a55905573996d0718f6d158d47de763b4) () |
| List< [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) > | [GetModifiersBasedOnQuality](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#ae8060fbda6529ad58a348098955ccb8e) ([ItemQuality](namespace_tale_worlds_1_1_core.html#aebf9446f74d061b64b5a59626ee69a96) quality) |
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
| int | [NoModifierLootScore](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#ad532ad7de66cc94cf172136498a1d61d) `[get]` |
| int | [NoModifierProductionScore](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#a8cc93abdb8bda7baf2c056ae93d20c0a) `[get]` |
| MBReadOnlyList< [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) > | [ItemModifiers](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#ad904a5eaf7e253e8feceae660b82d7c0) `[get]` |
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

[◆](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#a27c992803070ea6ac5b14adb3ef11690)ItemModifierGroup() [1/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.ItemModifierGroup.ItemModifierGroup | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#ae550827b1029d949354347abb9338390)ItemModifierGroup() [2/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.ItemModifierGroup.ItemModifierGroup | ( | string | *id* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#a0d2a0030e76ec6273ced75c290a76955)Deserialize()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.ItemModifierGroup.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | node | XmlNode to be de-serialized from. |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#aae3a5f4cf48e8244b53061e66b90ab00)AddItemModifier()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ItemModifierGroup.AddItemModifier | ( | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *itemModifier* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#a82ca2e1b61bb4d2e0a693b7d43043e55)GetRandomItemModifierLootScoreBased()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) TaleWorlds.Core.ItemModifierGroup.GetRandomItemModifierLootScoreBased | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#a55905573996d0718f6d158d47de763b4)GetRandomItemModifierProductionScoreBased()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) TaleWorlds.Core.ItemModifierGroup.GetRandomItemModifierProductionScoreBased | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#ae8060fbda6529ad58a348098955ccb8e)GetModifiersBasedOnQuality()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) > TaleWorlds.Core.ItemModifierGroup.GetModifiersBasedOnQuality | ( | [ItemQuality](namespace_tale_worlds_1_1_core.html#aebf9446f74d061b64b5a59626ee69a96) | *quality* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#ad532ad7de66cc94cf172136498a1d61d)NoModifierLootScore
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ItemModifierGroup.NoModifierLootScore | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#a8cc93abdb8bda7baf2c056ae93d20c0a)NoModifierProductionScore
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ItemModifierGroup.NoModifierProductionScore | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_modifier_group.html#ad904a5eaf7e253e8feceae660b82d7c0)ItemModifiers
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html)> TaleWorlds.Core.ItemModifierGroup.ItemModifiers | | get |


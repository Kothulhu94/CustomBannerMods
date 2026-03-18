--- SOURCE: class_tale_worlds_1_1_core_1_1_trade_item_component.html ---

TaleWorlds.Core.TradeItemComponent Class ReferenceInherits [TaleWorlds.Core.ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TradeItemComponent](class_tale_worlds_1_1_core_1_1_trade_item_component.html#a9cb40506c9290a59bdcc3c2fa62af446) () |
|  | [TradeItemComponent](class_tale_worlds_1_1_core_1_1_trade_item_component.html#a0cb69a8aac6068db5961dff10e4d588c) (TradeItemComponent a) |
| override [ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html#a2ee720148fe6c25a2ceb780721d5f725) | [GetCopy](class_tale_worlds_1_1_core_1_1_trade_item_component.html#a273ae4c10c4451a05b03e9acd979a0d4) () |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_trade_item_component.html#a399991fbcd7284a7819f32f0dd25e94d) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| Public Member Functions inherited from [TaleWorlds.Core.ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html) | |
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
| Properties | |
| int | [MoraleBonus](class_tale_worlds_1_1_core_1_1_trade_item_component.html#ab82cac2947c76bdd2c09542b7149ad1a) `[get]` |
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

[◆](class_tale_worlds_1_1_core_1_1_trade_item_component.html#a9cb40506c9290a59bdcc3c2fa62af446)TradeItemComponent() [1/2]
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.TradeItemComponent.TradeItemComponent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_trade_item_component.html#a0cb69a8aac6068db5961dff10e4d588c)TradeItemComponent() [2/2]
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.TradeItemComponent.TradeItemComponent | ( | TradeItemComponent | *a* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_trade_item_component.html#a273ae4c10c4451a05b03e9acd979a0d4)GetCopy()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html#a2ee720148fe6c25a2ceb780721d5f725) TaleWorlds.Core.TradeItemComponent.GetCopy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_trade_item_component.html#a399991fbcd7284a7819f32f0dd25e94d)Deserialize()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.TradeItemComponent.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.Core.ItemComponent](class_tale_worlds_1_1_core_1_1_item_component.html#a6ac3b10aca5e561af97b46ae38c45a3a).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_trade_item_component.html#ab82cac2947c76bdd2c09542b7149ad1a)MoraleBonus
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.TradeItemComponent.MoraleBonus | | get |


--- SOURCE: class_tale_worlds_1_1_core_1_1_item_category.html ---

TaleWorlds.Core.ItemCategory Class ReferencesealedInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [Property](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897f) {     [None](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897fa6adf97f83acf6453d4a6a4b1070f3754) ,     [BonusToProduction](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897faa8a42dfc8f71c3582e21768ddf7b6747) ,     [BonusToFoodStores](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897fa26d2ba3179c16b736fd7dd489ad36852) ,     [BonusToProsperity](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897fa4834096c6e31276f5cbb4ccfd945d836) ,     [BonusToLoyalty](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897faaf583083a8ceb98e2d45fd266c53df2e) ,     [BonusToMilitia](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897fa3edd5a41fa49d550976df7ff3a88a072) ,     [BonusToGarrison](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897fa0ad1e8b1126b7b4159ea8de28346d726) ,     [BonusToTax](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897faf0d33908b78ea0a8e07e51627a4778f8)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html#a1e2822994e0e5d8fa5d024519e1d72b3) () |
|  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html#a6255fbfbece3c1b7c9cdc6c8d466615d) (string stringId) |
| [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html#a1e2822994e0e5d8fa5d024519e1d72b3) | [InitializeObject](class_tale_worlds_1_1_core_1_1_item_category.html#a633119a92badb924ee709019a8e43950) (bool isTradeGood=false, int baseDemand=0, int luxuryDemand=0, [Property](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897f) properties=[Property.None](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897fa6adf97f83acf6453d4a6a4b1070f3754), [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html#a1e2822994e0e5d8fa5d024519e1d72b3) canSubstitute=null, float substitutionFactor=0f, bool isAnimal=false, bool isValid=true) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_core_1_1_item_category.html#a9c1d8ba95839fdc85094e72cbd0ff1fc) () |
| override string | [ToString](class_tale_worlds_1_1_core_1_1_item_category.html#a72026f6b4039f28f3f035154531ad768) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| virtual void | [Deserialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsTradeGood](class_tale_worlds_1_1_core_1_1_item_category.html#abb7cdd58ba517e51928f4658da9a217f) `[get]` |
| bool | [IsAnimal](class_tale_worlds_1_1_core_1_1_item_category.html#a57fd7eb9f20c13d88a97fe011e46d2d8) `[get]` |
| [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html#a1e2822994e0e5d8fa5d024519e1d72b3) | [CanSubstitute](class_tale_worlds_1_1_core_1_1_item_category.html#a7084f4d6c854f7498f04227c7811a73e) `[get]` |
|  | More expensive trade goods can substitute less expensive ones. Add this property to the expensive category. |
| float | [SubstitutionFactor](class_tale_worlds_1_1_core_1_1_item_category.html#a22eb0361a91809184b78d7c756f67beb) `[get]` |
| [Property](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897f) | [Properties](class_tale_worlds_1_1_core_1_1_item_category.html#a40359f01e7649031b4527a21a7f66fde) `[get]` |
| bool | [IsValid](class_tale_worlds_1_1_core_1_1_item_category.html#a165316caffa20615cd0978381f781390) `[get]` |
| float | [BaseDemand](class_tale_worlds_1_1_core_1_1_item_category.html#a4f146fab24d1dcf89deca4dfefad6d03) `[get]` |
| float | [LuxuryDemand](class_tale_worlds_1_1_core_1_1_item_category.html#a2bb9fc62142120f556783587c17b354f) `[get]` |
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

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897f)Property
------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.ItemCategory.Property](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897f) |

| Enumerator | |
| --- | --- |
| None |  |
| BonusToProduction |  |
| BonusToFoodStores |  |
| BonusToProsperity |  |
| BonusToLoyalty |  |
| BonusToMilitia |  |
| BonusToGarrison |  |
| BonusToTax |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a1e2822994e0e5d8fa5d024519e1d72b3)ItemCategory() [1/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.ItemCategory.ItemCategory | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a6255fbfbece3c1b7c9cdc6c8d466615d)ItemCategory() [2/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.ItemCategory.ItemCategory | ( | string | *stringId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a633119a92badb924ee709019a8e43950)InitializeObject()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html#a1e2822994e0e5d8fa5d024519e1d72b3) TaleWorlds.Core.ItemCategory.InitializeObject | ( | bool | *isTradeGood* = false, |
|  |  | int | *baseDemand* = 0, |
|  |  | int | *luxuryDemand* = 0, |
|  |  | [Property](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897f) | *properties* = [Property::None](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897fa6adf97f83acf6453d4a6a4b1070f3754), |
|  |  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html#a1e2822994e0e5d8fa5d024519e1d72b3) | *canSubstitute* = null, |
|  |  | float | *substitutionFactor* = 0f, |
|  |  | bool | *isAnimal* = false, |
|  |  | bool | *isValid* = true ) |

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a9c1d8ba95839fdc85094e72cbd0ff1fc)GetName()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.ItemCategory.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db).

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a72026f6b4039f28f3f035154531ad768)ToString()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Core.ItemCategory.ToString | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#abb7cdd58ba517e51928f4658da9a217f)IsTradeGood
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemCategory.IsTradeGood | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a57fd7eb9f20c13d88a97fe011e46d2d8)IsAnimal
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemCategory.IsAnimal | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a7084f4d6c854f7498f04227c7811a73e)CanSubstitute
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html#a1e2822994e0e5d8fa5d024519e1d72b3) TaleWorlds.Core.ItemCategory.CanSubstitute | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a22eb0361a91809184b78d7c756f67beb)SubstitutionFactor
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemCategory.SubstitutionFactor | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a40359f01e7649031b4527a21a7f66fde)Properties
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Property](class_tale_worlds_1_1_core_1_1_item_category.html#a9ce1c76536311fdcc5ccb7ceabee897f) TaleWorlds.Core.ItemCategory.Properties | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a165316caffa20615cd0978381f781390)IsValid
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemCategory.IsValid | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a4f146fab24d1dcf89deca4dfefad6d03)BaseDemand
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemCategory.BaseDemand | | get |

[◆](class_tale_worlds_1_1_core_1_1_item_category.html#a2bb9fc62142120f556783587c17b354f)LuxuryDemand
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ItemCategory.LuxuryDemand | | get |


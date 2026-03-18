--- SOURCE: class_tale_worlds_1_1_core_1_1_basic_culture_object.html ---

TaleWorlds.Core.BasicCultureObject Class ReferenceRepresents a culture.

Inherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

Inherited by [TaleWorlds.CampaignSystem.CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override string | [ToString](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#aace27c5341fc5c9adff6eb436ee7834d) () |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#af5970d116c9779607106c7fc1ec3e136) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
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
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#ad44d0f122ac7dc7d0f562d0ba1706b3a) `[get]` |
| bool | [IsMainCulture](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a53731eaa2842ac9eb6dedee6f14dfb75) `[get]` |
| bool | [IsBandit](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a9e265e5d55c7182f230c7973c3f98469) `[get]` |
| bool | [CanHaveSettlement](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a48fb2f71a2bae5935ef6dd910b7c5eca) `[get]` |
| uint | [Color](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a514160abb6f52436d4cf514d66ee5371) `[get]` |
| uint | [Color2](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#ae4453082495646c4cc630e9abe49209e) `[get]` |
| uint | [ClothAlternativeColor](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a49a8c90109fc6e94cf3ebd4605a2c4f1) `[get]` |
| uint | [ClothAlternativeColor2](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a2c83870edc37d46c26c852e453fbe080) `[get]` |
| uint | [BackgroundColor1](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#af2e360b96a8c37273960c38429416a9f) `[get]` |
| uint | [ForegroundColor1](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a4c93dbef03b672643b4b227d711acfe1) `[get]` |
| uint | [BackgroundColor2](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a48233acc2dc63135d3ce35d7748b08b0) `[get]` |
| uint | [ForegroundColor2](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#ab06ef46a94c39c3213d668971686e4ed) `[get]` |
| string | [EncounterBackgroundMesh](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#ac79a2edb28346511312c53a826d69bdf) `[get, set]` |
| Banner | [Banner](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a7c7ae3feac1f8c89a710d6d079506ee4) `[get]` |
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

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#aace27c5341fc5c9adff6eb436ee7834d)ToString()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Core.BasicCultureObject.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#af5970d116c9779607106c7fc1ec3e136)Deserialize()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.BasicCultureObject.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Reimplemented in [TaleWorlds.CampaignSystem.CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html#a0a08e66bd8de6732ee891113f76d89cc).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#ad44d0f122ac7dc7d0f562d0ba1706b3a)Name
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.BasicCultureObject.Name | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a53731eaa2842ac9eb6dedee6f14dfb75)IsMainCulture
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.BasicCultureObject.IsMainCulture | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a9e265e5d55c7182f230c7973c3f98469)IsBandit
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.BasicCultureObject.IsBandit | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a48fb2f71a2bae5935ef6dd910b7c5eca)CanHaveSettlement
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.BasicCultureObject.CanHaveSettlement | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a514160abb6f52436d4cf514d66ee5371)Color
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.BasicCultureObject.Color | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#ae4453082495646c4cc630e9abe49209e)Color2
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.BasicCultureObject.Color2 | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a49a8c90109fc6e94cf3ebd4605a2c4f1)ClothAlternativeColor
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.BasicCultureObject.ClothAlternativeColor | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a2c83870edc37d46c26c852e453fbe080)ClothAlternativeColor2
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.BasicCultureObject.ClothAlternativeColor2 | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#af2e360b96a8c37273960c38429416a9f)BackgroundColor1
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.BasicCultureObject.BackgroundColor1 | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a4c93dbef03b672643b4b227d711acfe1)ForegroundColor1
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.BasicCultureObject.ForegroundColor1 | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a48233acc2dc63135d3ce35d7748b08b0)BackgroundColor2
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.BasicCultureObject.BackgroundColor2 | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#ab06ef46a94c39c3213d668971686e4ed)ForegroundColor2
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.BasicCultureObject.ForegroundColor2 | | get |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#ac79a2edb28346511312c53a826d69bdf)EncounterBackgroundMesh
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.BasicCultureObject.EncounterBackgroundMesh | | getset |

[◆](class_tale_worlds_1_1_core_1_1_basic_culture_object.html#a7c7ae3feac1f8c89a710d6d079506ee4)Banner
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.Core.BasicCultureObject.Banner | | get |


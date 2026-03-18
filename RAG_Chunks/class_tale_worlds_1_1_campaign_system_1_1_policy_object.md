--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_policy_object.html ---

TaleWorlds.CampaignSystem.PolicyObject Class ReferencesealedInherits [TaleWorlds.Core.PropertyObject](class_tale_worlds_1_1_core_1_1_property_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#acc3c5548391100afbd9d0e12682ad04d) (string stringId) |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#a2d656c8e3ea3ebb1cf5399ce35db25ae) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) logEntryDescription, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) secondaryEffects, float authoritarianWeight, float oligarchyWeight, float egalitarianWeight) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#a1587e8c7653275591e764b310d2ba88a) () |
| Public Member Functions inherited from [TaleWorlds.Core.PropertyObject](class_tale_worlds_1_1_core_1_1_property_object.html) | |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_core_1_1_property_object.html#a525db79355b3fd5976da6f4be902f710) () |
|  | [PropertyObject](class_tale_worlds_1_1_core_1_1_property_object.html#a7f91a6c80350afbe6063796ac25c52ac) (string stringId) |
|  | Initializes a new instance of the [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) class. |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_property_object.html#af14d14eb7a89d31715686f1793b47d3d) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description) |
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
| static Library.MBReadOnlyList< [PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#acc3c5548391100afbd9d0e12682ad04d) > | [All](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#ac3b59b29ade99e8f5945efcca880346f) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [SecondaryEffects](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#a40f06dbb51b72602db6bf4e2e5b3f762) `[get]` |
| float | [AuthoritarianWeight](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#a5e8763d5d43ccd93a80257dd1986c696) `[get]` |
| float | [OligarchicWeight](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#a39e4d1cc8f6e7ca7d7bfa35da63d3f9c) `[get]` |
| float | [EgalitarianWeight](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#af0ee7e16f0fb0c41ae6109d04fe76f1b) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [LogEntryDescription](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#a9eae1dbb76b8f4b99383efce15386d0d) `[get]` |
| Properties inherited from [TaleWorlds.Core.PropertyObject](class_tale_worlds_1_1_core_1_1_property_object.html) | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_core_1_1_property_object.html#abf9462a1cb0a31f98617f67d9158a8d0) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Description](class_tale_worlds_1_1_core_1_1_property_object.html#aa3ddc69b5696db9a8a5daf63c3e0ab5d) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#acc3c5548391100afbd9d0e12682ad04d)PolicyObject()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.PolicyObject.PolicyObject | ( | string | *stringId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#a2d656c8e3ea3ebb1cf5399ce35db25ae)Initialize()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.PolicyObject.Initialize | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *logEntryDescription*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *secondaryEffects*, |
|  |  | float | *authoritarianWeight*, |
|  |  | float | *oligarchyWeight*, |
|  |  | float | *egalitarianWeight* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#a1587e8c7653275591e764b310d2ba88a)ToString()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.PolicyObject.ToString | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#ac3b59b29ade99e8f5945efcca880346f)All
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Library.MBReadOnlyList<[PolicyObject](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#acc3c5548391100afbd9d0e12682ad04d)> TaleWorlds.CampaignSystem.PolicyObject.All | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#a40f06dbb51b72602db6bf4e2e5b3f762)SecondaryEffects
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.PolicyObject.SecondaryEffects | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#a5e8763d5d43ccd93a80257dd1986c696)AuthoritarianWeight
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.PolicyObject.AuthoritarianWeight | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#a39e4d1cc8f6e7ca7d7bfa35da63d3f9c)OligarchicWeight
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.PolicyObject.OligarchicWeight | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#af0ee7e16f0fb0c41ae6109d04fe76f1b)EgalitarianWeight
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.PolicyObject.EgalitarianWeight | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_policy_object.html#a9eae1dbb76b8f4b99383efce15386d0d)LogEntryDescription
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.PolicyObject.LogEntryDescription | | get |


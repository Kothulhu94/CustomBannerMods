--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html ---

TaleWorlds.CampaignSystem.CharacterDevelopment.FeatObject Class ReferencesealedInherits [TaleWorlds.Core.PropertyObject](class_tale_worlds_1_1_core_1_1_property_object.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [AdditionType](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a85fa695f153193131f581d01291cba24) {     [Add](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a85fa695f153193131f581d01291cba24aec211f7c20af43e742bf2570c3cb84f9) ,     [AddFactor](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a85fa695f153193131f581d01291cba24a4cc4aa8cadacabb6489d2e23bfd88df5)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#ad95a114c6a2a0beeb0c83163e6291b73) (string stringId) |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#acbf16ae6d4db14927d68ce5427c166bb) (string name, string description, float effectBonus, bool isPositiveEffect, [AdditionType](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a85fa695f153193131f581d01291cba24) incrementType) |
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
| static Library.MBReadOnlyList< [FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#ad95a114c6a2a0beeb0c83163e6291b73) > | [All](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a09a37289ee10a7b6f36b286d18a254b9) `[get]` |
| float | [EffectBonus](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#af50ee69371fa0be0f1498e4b8b7384b0) `[get]` |
| [AdditionType](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a85fa695f153193131f581d01291cba24) | [IncrementType](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a4aa0e191055760c693fbe28ffb0f46aa) `[get]` |
| bool | [IsPositive](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#adf59f18e393313e55df73afee9481edc) `[get]` |
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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a85fa695f153193131f581d01291cba24)AdditionType
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.CharacterDevelopment.FeatObject.AdditionType](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a85fa695f153193131f581d01291cba24) |

| Enumerator | |
| --- | --- |
| Add |  |
| AddFactor |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#ad95a114c6a2a0beeb0c83163e6291b73)FeatObject()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CharacterDevelopment.FeatObject.FeatObject | ( | string | *stringId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#acbf16ae6d4db14927d68ce5427c166bb)Initialize()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.FeatObject.Initialize | ( | string | *name*, |
|  |  | string | *description*, |
|  |  | float | *effectBonus*, |
|  |  | bool | *isPositiveEffect*, |
|  |  | [AdditionType](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a85fa695f153193131f581d01291cba24) | *incrementType* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a09a37289ee10a7b6f36b286d18a254b9)All
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Library.MBReadOnlyList<[FeatObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#ad95a114c6a2a0beeb0c83163e6291b73)> TaleWorlds.CampaignSystem.CharacterDevelopment.FeatObject.All | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#af50ee69371fa0be0f1498e4b8b7384b0)EffectBonus
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CharacterDevelopment.FeatObject.EffectBonus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a4aa0e191055760c693fbe28ffb0f46aa)IncrementType
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AdditionType](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#a85fa695f153193131f581d01291cba24) TaleWorlds.CampaignSystem.CharacterDevelopment.FeatObject.IncrementType | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_feat_object.html#adf59f18e393313e55df73afee9481edc)IsPositive
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CharacterDevelopment.FeatObject.IsPositive | | get |


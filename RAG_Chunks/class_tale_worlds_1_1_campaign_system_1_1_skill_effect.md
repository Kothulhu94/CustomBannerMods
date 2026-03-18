--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html ---

TaleWorlds.CampaignSystem.SkillEffect Class ReferencesealedInherits [TaleWorlds.Core.PropertyObject](class_tale_worlds_1_1_core_1_1_property_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#a729b96e894defc4d55a5bb6ed86d864d) (string stringId) |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#a4609372ec6cd10aaacc836516c4a8bca) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) effectedSkill, [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) role, float bonus, [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) incrementType, float baseValue=0f, float limitMin=float.MinValue, float limitMax=float.MaxValue) |
| float | [GetSkillEffectValue](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#a998b23ccd8f86f29ed3f64cc3183e831) (int skillLevel) |
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
| static MBReadOnlyList< [SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#a729b96e894defc4d55a5bb6ed86d864d) > | [All](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#aedc3da53919be16abe74f4759286451d) `[get]` |
| [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) | [Role](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#ac71fc742afbbec9d11be6ccec2e7b1ee) `[get]` |
| [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) | [IncrementType](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#acf525b46bd25a697491bb9ef26c1c56a) `[get]` |
| [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [EffectedSkill](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#afd5fcc6d8070e162370ca3db27b2e918) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#a729b96e894defc4d55a5bb6ed86d864d)SkillEffect()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.SkillEffect.SkillEffect | ( | string | *stringId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#a4609372ec6cd10aaacc836516c4a8bca)Initialize()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.SkillEffect.Initialize | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description*, |
|  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *effectedSkill*, |
|  |  | [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) | *role*, |
|  |  | float | *bonus*, |
|  |  | [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) | *incrementType*, |
|  |  | float | *baseValue* = 0f, |
|  |  | float | *limitMin* = float::MinValue, |
|  |  | float | *limitMax* = float::MaxValue ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#a998b23ccd8f86f29ed3f64cc3183e831)GetSkillEffectValue()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.SkillEffect.GetSkillEffectValue | ( | int | *skillLevel* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#aedc3da53919be16abe74f4759286451d)All
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[SkillEffect](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#a729b96e894defc4d55a5bb6ed86d864d)> TaleWorlds.CampaignSystem.SkillEffect.All | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#ac71fc742afbbec9d11be6ccec2e7b1ee)Role
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) TaleWorlds.CampaignSystem.SkillEffect.Role | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#acf525b46bd25a697491bb9ef26c1c56a)IncrementType
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) TaleWorlds.CampaignSystem.SkillEffect.IncrementType | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_skill_effect.html#afd5fcc6d8070e162370ca3db27b2e918)EffectedSkill
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) TaleWorlds.CampaignSystem.SkillEffect.EffectedSkill | | get |


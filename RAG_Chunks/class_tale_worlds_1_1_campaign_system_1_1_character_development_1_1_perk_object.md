--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html ---

TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject Class ReferencesealedInherits [TaleWorlds.Core.PropertyObject](class_tale_worlds_1_1_core_1_1_property_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a637798e07fa4cd675b0e63a265923563) (string stringId) |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#ac383a388c82ff7fee7a140345e652da9) (string name, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, int requiredSkillValue, [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a637798e07fa4cd675b0e63a265923563) alternativePerk, string primaryDescription, [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) primaryRole, float primaryBonus, [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) incrementType, string secondaryDescription="", [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) secondaryRole=[PartyRole.None](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cfa6adf97f83acf6453d4a6a4b1070f3754), float secondaryBonus=0.0f, [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) secondaryIncrementType=EffectIncrementType.Invalid, [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) primaryTroopUsageMask=TroopUsageFlags.Undefined, [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) secondaryTroopUsageMask=TroopUsageFlags.Undefined) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a6cfd1815c109d20a8cd8ff817247b62a) () |
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
| static MBReadOnlyList< [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a637798e07fa4cd675b0e63a265923563) > | [All](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#adcac4e5f45505f9c9ed0c4af3ca3f7cd) `[get]` |
| [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [Skill](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a6bd854113361d2874335cbd22c42b27a) `[get]` |
| float | [RequiredSkillValue](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#af480f2c4fbe3945375cf67c1df16e87d) `[get]` |
| [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a637798e07fa4cd675b0e63a265923563) | [AlternativePerk](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#ab4c900fb79e0afc8c5478bb58f46ee16) `[get]` |
| [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) | [PrimaryRole](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a0924f8c9bdb66de109b240524d8625ab) `[get]` |
| [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) | [SecondaryRole](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a0806771ed93baa17e73ffc425a4e982e) `[get]` |
| float | [PrimaryBonus](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a55b0dd87046b9fef8761506f8c95e063) `[get]` |
| float | [SecondaryBonus](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a44f555e095fdfcdd8476bfc2bb2e0c4d) `[get]` |
| [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) | [PrimaryIncrementType](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#aa3942cc3019aa03d5d18ccb938735b63) `[get]` |
| [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) | [SecondaryIncrementType](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#aed1e07bb17020ba3d722f09674f31dbb) `[get]` |
| [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) | [PrimaryTroopUsageMask](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#af7e36a2ea8dabc5257a3888f24e8be07) `[get]` |
| [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) | [SecondaryTroopUsageMask](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#adb4579dc48cc348f1060e5ab2ee93ded) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [PrimaryDescription](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a38386d54c451f1a9bec4e6f562b0c829) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [SecondaryDescription](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#adb9c9621f6803479b25c995e5c1be8d9) `[get]` |
| bool | [IsTrash](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#ad5a49ea6b3be4431ee0f0999a9ffbc96) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a637798e07fa4cd675b0e63a265923563)PerkObject()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.PerkObject | ( | string | *stringId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#ac383a388c82ff7fee7a140345e652da9)Initialize()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.Initialize | ( | string | *name*, |
|  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | int | *requiredSkillValue*, |
|  |  | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a637798e07fa4cd675b0e63a265923563) | *alternativePerk*, |
|  |  | string | *primaryDescription*, |
|  |  | [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) | *primaryRole*, |
|  |  | float | *primaryBonus*, |
|  |  | [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) | *incrementType*, |
|  |  | string | *secondaryDescription* = "", |
|  |  | [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) | *secondaryRole* = [PartyRole::None](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cfa6adf97f83acf6453d4a6a4b1070f3754), |
|  |  | float | *secondaryBonus* = 0::0f, |
|  |  | [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) | *secondaryIncrementType* = EffectIncrementType::Invalid, |
|  |  | [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) | *primaryTroopUsageMask* = TroopUsageFlags::Undefined, |
|  |  | [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) | *secondaryTroopUsageMask* = TroopUsageFlags::Undefined ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a6cfd1815c109d20a8cd8ff817247b62a)ToString()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.ToString | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#adcac4e5f45505f9c9ed0c4af3ca3f7cd)All
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a637798e07fa4cd675b0e63a265923563)> TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.All | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a6bd854113361d2874335cbd22c42b27a)Skill
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.Skill | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#af480f2c4fbe3945375cf67c1df16e87d)RequiredSkillValue
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.RequiredSkillValue | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#ab4c900fb79e0afc8c5478bb58f46ee16)AlternativePerk
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a637798e07fa4cd675b0e63a265923563) TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.AlternativePerk | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a0924f8c9bdb66de109b240524d8625ab)PrimaryRole
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.PrimaryRole | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a0806771ed93baa17e73ffc425a4e982e)SecondaryRole
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyRole](namespace_tale_worlds_1_1_campaign_system.html#af60f394cea2e7c527bf1950e31fd13cf) TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.SecondaryRole | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a55b0dd87046b9fef8761506f8c95e063)PrimaryBonus
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.PrimaryBonus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a44f555e095fdfcdd8476bfc2bb2e0c4d)SecondaryBonus
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.SecondaryBonus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#aa3942cc3019aa03d5d18ccb938735b63)PrimaryIncrementType
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.PrimaryIncrementType | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#aed1e07bb17020ba3d722f09674f31dbb)SecondaryIncrementType
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EffectIncrementType](namespace_tale_worlds_1_1_core.html#a75c4a0450b5435c513e0e23882d2b92f) TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.SecondaryIncrementType | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#af7e36a2ea8dabc5257a3888f24e8be07)PrimaryTroopUsageMask
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.PrimaryTroopUsageMask | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#adb4579dc48cc348f1060e5ab2ee93ded)SecondaryTroopUsageMask
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.SecondaryTroopUsageMask | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#a38386d54c451f1a9bec4e6f562b0c829)PrimaryDescription
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.PrimaryDescription | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#adb9c9621f6803479b25c995e5c1be8d9)SecondaryDescription
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.SecondaryDescription | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html#ad5a49ea6b3be4431ee0f0999a9ffbc96)IsTrash
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CharacterDevelopment.PerkObject.IsTrash | | get |


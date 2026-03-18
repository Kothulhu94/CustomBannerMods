--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_concept.html ---

TaleWorlds.CampaignSystem.Concept Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a02daa05ea71d067a7b0181941b54208e) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
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
| Static Public Member Functions | |
| static bool | [IsGroupMember](class_tale_worlds_1_1_campaign_system_1_1_concept.html#af43f54eb81ad433fc0dbf6cbbc115bc0) (string groupName, [Concept](class_tale_worlds_1_1_campaign_system_1_1_concept.html) c) |
| static void | [SetConceptTextLinks](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a68ef4c58bf0e7c6a93ec418c4df044f5) () |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Title](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a4389708b3159d28b3c78104124d22b3e) `[get, set]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Description](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a44f130ecde95c01e58dc9e2c547cdd2f) `[get, set]` |
| string | [FilterGroup](class_tale_worlds_1_1_campaign_system_1_1_concept.html#adef15fa1c41e2e4904d2e4646a359f88) `[get, set]` |
| string | [LinkID](class_tale_worlds_1_1_campaign_system_1_1_concept.html#af2e1455ed0e99486acea068006a968ee) `[get]` |
| static MBReadOnlyList< [Concept](class_tale_worlds_1_1_campaign_system_1_1_concept.html) > | [All](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a669b5e57b8fc536ea84bb3224695b249) `[get]` |
| string | [EncyclopediaLink](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a126e140c40a80c1d063895a14af0aca8) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaLinkWithName](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a0649489099e26e5f321433e73119ccfb) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a02daa05ea71d067a7b0181941b54208e)Deserialize()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Concept.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_campaign_system_1_1_concept.html#af43f54eb81ad433fc0dbf6cbbc115bc0)IsGroupMember()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Concept.IsGroupMember | ( | string | *groupName*, | |  |  | [Concept](class_tale_worlds_1_1_campaign_system_1_1_concept.html) | *c* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a68ef4c58bf0e7c6a93ec418c4df044f5)SetConceptTextLinks()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Concept.SetConceptTextLinks | ( |  | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a4389708b3159d28b3c78104124d22b3e)Title
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Concept.Title | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a44f130ecde95c01e58dc9e2c547cdd2f)Description
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Concept.Description | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_concept.html#adef15fa1c41e2e4904d2e4646a359f88)FilterGroup
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Concept.FilterGroup | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_concept.html#af2e1455ed0e99486acea068006a968ee)LinkID
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Concept.LinkID | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a669b5e57b8fc536ea84bb3224695b249)All
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Concept](class_tale_worlds_1_1_campaign_system_1_1_concept.html)> TaleWorlds.CampaignSystem.Concept.All | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a126e140c40a80c1d063895a14af0aca8)EncyclopediaLink
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Concept.EncyclopediaLink | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_concept.html#a0649489099e26e5f321433e73119ccfb)EncyclopediaLinkWithName
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Concept.EncyclopediaLinkWithName | | get |


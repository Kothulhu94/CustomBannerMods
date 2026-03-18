--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html ---

TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplexTemplate Class ReferencesealedInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [LocationComplexTemplate](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html#a60b830a626386f001f477221de368ef7) () |
| override void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html#ad57c7b1e24e382244c673e3ab1eb70c5) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
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
| List< [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) > | [Locations](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html#a02dab2e4f992b8edd0fc0033c05ce1e0) = new List<[Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html)>() |
| List< KeyValuePair< string, string > > | [Passages](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html#a755563a98b30f888541849e4a7db01bf) = new List<KeyValuePair<string, string>>() |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html#a60b830a626386f001f477221de368ef7)LocationComplexTemplate()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplexTemplate.LocationComplexTemplate | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html#ad57c7b1e24e382244c673e3ab1eb70c5)Deserialize()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplexTemplate.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html#a02dab2e4f992b8edd0fc0033c05ce1e0)Locations
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html)> TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplexTemplate.Locations = new List<[Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html)>() |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_complex_template.html#a755563a98b30f888541849e4a7db01bf)Passages
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<KeyValuePair<string, string> > TaleWorlds.CampaignSystem.Settlements.Locations.LocationComplexTemplate.Passages = new List<KeyValuePair<string, string>>() |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html ---

TaleWorlds.CampaignSystem.Incidents.Incident Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate bool | [IncidentOptionConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a0800e97328c90291930693b733b8109e) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text) |
| delegate void | [IncidentOptionConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a9a6e316eb1b03416cfd96dc1444f27d8) () |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a2582d2db88465bb9f8ad4649c2d4d70e) (string title, string description, IncidentTrigger trigger, IncidentType type, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) cooldown, Func< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html), bool > condition) |
|  | [Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a6e3faac890faa077d584b24aa26b63ac) (string id) |
| void | [AddOption](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a86543007a6d96df4c8d7ecb13746dc38) (string text, List< [IncidentEffect](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html) > effects, [IncidentOptionConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a0800e97328c90291930693b733b8109e) condition=null, [IncidentOptionConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a9a6e316eb1b03416cfd96dc1444f27d8) consequence=null) |
| bool | [CanIncidentBeInvoked](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a999cdeff05701fd5fd85391f2b217a2a) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetOptionText](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a9b3bed83b21a5c2ac8a0c79066e9b2b5) (int index) |
| List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [GetOptionHint](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a324087658014e861e2899a45a9657379) (int index) |
| List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [InvokeOption](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#ac6a7a31e0203c7a6f3dce654e7929e94) (int index) |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| virtual void | [Deserialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Title](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a2cb220a59c33eafd76de933ef21855d3) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Description](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a130154713334d256bcd3a0b5bc150327) `[get]` |
| IncidentTrigger | [Trigger](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a4c6334940d0baba28870e974fd7f6e2b) `[get]` |
| IncidentType | [Type](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#ae1519a944bf6de1f26cf4b1e4ceb5d19) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [Cooldown](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#ae836903871c7078a6d49bd397a714afb) `[get]` |
| int | [NumOfOptions](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a8c1a3a3723b061d641058cad86838bf0) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a6e3faac890faa077d584b24aa26b63ac)Incident()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Incidents.Incident.Incident | ( | string | *id* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a0800e97328c90291930693b733b8109e)IncidentOptionConditionDelegate()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate bool TaleWorlds.CampaignSystem.Incidents.Incident.IncidentOptionConditionDelegate | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a9a6e316eb1b03416cfd96dc1444f27d8)IncidentOptionConsequenceDelegate()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Incidents.Incident.IncidentOptionConsequenceDelegate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a2582d2db88465bb9f8ad4649c2d4d70e)Initialize()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Incidents.Incident.Initialize | ( | string | *title*, |
|  |  | string | *description*, |
|  |  | IncidentTrigger | *trigger*, |
|  |  | IncidentType | *type*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *cooldown*, |
|  |  | Func< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html), bool > | *condition* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a86543007a6d96df4c8d7ecb13746dc38)AddOption()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Incidents.Incident.AddOption | ( | string | *text*, |
|  |  | List< [IncidentEffect](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident_effect.html) > | *effects*, |
|  |  | [IncidentOptionConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a0800e97328c90291930693b733b8109e) | *condition* = null, |
|  |  | [IncidentOptionConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a9a6e316eb1b03416cfd96dc1444f27d8) | *consequence* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a999cdeff05701fd5fd85391f2b217a2a)CanIncidentBeInvoked()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Incidents.Incident.CanIncidentBeInvoked | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a9b3bed83b21a5c2ac8a0c79066e9b2b5)GetOptionText()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Incidents.Incident.GetOptionText | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a324087658014e861e2899a45a9657379)GetOptionHint()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > TaleWorlds.CampaignSystem.Incidents.Incident.GetOptionHint | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#ac6a7a31e0203c7a6f3dce654e7929e94)InvokeOption()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > TaleWorlds.CampaignSystem.Incidents.Incident.InvokeOption | ( | int | *index* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a2cb220a59c33eafd76de933ef21855d3)Title
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Incidents.Incident.Title | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a130154713334d256bcd3a0b5bc150327)Description
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Incidents.Incident.Description | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a4c6334940d0baba28870e974fd7f6e2b)Trigger
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IncidentTrigger TaleWorlds.CampaignSystem.Incidents.Incident.Trigger | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#ae1519a944bf6de1f26cf4b1e4ceb5d19)Type
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IncidentType TaleWorlds.CampaignSystem.Incidents.Incident.Type | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#ae836903871c7078a6d49bd397a714afb)Cooldown
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Incidents.Incident.Cooldown | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html#a8c1a3a3723b061d641058cad86838bf0)NumOfOptions
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Incidents.Incident.NumOfOptions | | get |


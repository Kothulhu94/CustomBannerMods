--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html ---

TaleWorlds.CampaignSystem.MBCampaignEvent Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [CampaignEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ad1269c0cd6618a2ff64b9b3a73ac2282) ([MBCampaignEvent](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#af788b65320e334daebce985250eb4ef7) campaignEvent, params object[] delegateParams) |
|  | Delegate of [Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html) Event. |
|  | [MBCampaignEvent](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#af788b65320e334daebce985250eb4ef7) (String eventName) |
|  | [MBCampaignEvent](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a850c8a7cff92cb2a49a1905bd9dd8840) ([CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) triggerPeriod, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) initialWait) |
| void | [AddHandler](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ace98744060751381a7deb56175a238a4) ([CampaignEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ad1269c0cd6618a2ff64b9b3a73ac2282) gameEventDelegate) |
| void | [RunHandlers](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ae8bbf7b914c54c943dc3f59b73dacafe) (params Object[] delegateParams) |
| void | [Unregister](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a1e0e6241b4551159920ab398d73236ba) (Object instance) |
| void | [CheckUpdate](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a6704c7a07fe3c272f7cd93d761aa28d8) () |
| void | [DeletePeriodicEvent](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a535a55f97ffdb87ca2d4b4fd7c02e5f8) () |

|  |  |
| --- | --- |
| Public Attributes | |
| String | [description](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#aaf58055a25b389d56c442f7e0c90f948) |

|  |  |
| --- | --- |
| Protected Attributes | |
| List< [CampaignEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ad1269c0cd6618a2ff64b9b3a73ac2282) > | [handlers](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ad59065fb7d461f7e9bcfbcbbc95b85fc) = new List<[CampaignEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ad1269c0cd6618a2ff64b9b3a73ac2282)>() |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [NextTriggerTime](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a3fa05109ae16bffb6d1a33a749265491) |

|  |  |
| --- | --- |
| Properties | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [TriggerPeriod](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a5d8f811e0917f21e00ae1cdd3e5ce9c1) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [InitialWait](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a1e6f5563199a1532b5a234c660430cd2) `[get]` |
| bool | [isEventDeleted](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ac4682ad909820ff4bb628d861caefb7d) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#af788b65320e334daebce985250eb4ef7)MBCampaignEvent() [1/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.MBCampaignEvent.MBCampaignEvent | ( | String | *eventName* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a850c8a7cff92cb2a49a1905bd9dd8840)MBCampaignEvent() [2/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.MBCampaignEvent.MBCampaignEvent | ( | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *triggerPeriod*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *initialWait* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ad1269c0cd6618a2ff64b9b3a73ac2282)CampaignEventDelegate()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.MBCampaignEvent.CampaignEventDelegate | ( | [MBCampaignEvent](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#af788b65320e334daebce985250eb4ef7) | *campaignEvent*, |
|  |  | params object[] | *delegateParams* ) |

Parameters
:   |  |  |
    | --- | --- |
    | campaignEvent | The campaign event. |
    | delegateParams | The delegate params. |

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ace98744060751381a7deb56175a238a4)AddHandler()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MBCampaignEvent.AddHandler | ( | [CampaignEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ad1269c0cd6618a2ff64b9b3a73ac2282) | *gameEventDelegate* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ae8bbf7b914c54c943dc3f59b73dacafe)RunHandlers()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MBCampaignEvent.RunHandlers | ( | params Object[] | *delegateParams* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a1e0e6241b4551159920ab398d73236ba)Unregister()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MBCampaignEvent.Unregister | ( | Object | *instance* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a6704c7a07fe3c272f7cd93d761aa28d8)CheckUpdate()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MBCampaignEvent.CheckUpdate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a535a55f97ffdb87ca2d4b4fd7c02e5f8)DeletePeriodicEvent()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MBCampaignEvent.DeletePeriodicEvent | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#aaf58055a25b389d56c442f7e0c90f948)description
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| String TaleWorlds.CampaignSystem.MBCampaignEvent.description |

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ad59065fb7d461f7e9bcfbcbbc95b85fc)handlers
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[CampaignEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ad1269c0cd6618a2ff64b9b3a73ac2282)> TaleWorlds.CampaignSystem.MBCampaignEvent.handlers = new List<[CampaignEventDelegate](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ad1269c0cd6618a2ff64b9b3a73ac2282)>() | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a3fa05109ae16bffb6d1a33a749265491)NextTriggerTime
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.MBCampaignEvent.NextTriggerTime | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a5d8f811e0917f21e00ae1cdd3e5ce9c1)TriggerPeriod
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.MBCampaignEvent.TriggerPeriod | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#a1e6f5563199a1532b5a234c660430cd2)InitialWait
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.MBCampaignEvent.InitialWait | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_m_b_campaign_event.html#ac4682ad909820ff4bb628d861caefb7d)isEventDeleted
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MBCampaignEvent.isEventDeleted | | getset |


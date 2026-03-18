--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html ---

TaleWorlds.CampaignSystem.MbEvent< T > Class Template ReferenceInherits [TaleWorlds.CampaignSystem.IMbEvent< out T >](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [EventHandlerRec](class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html#a0653bde57c9d79293b4787c5121ab9d7) (object owner, Action< TS > action) |
| void | [AddNonSerializedListener](class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html#a34d3e892b1fbefc53340c1dffe84b657) (object owner, Action< T > action) |
| void | [Invoke](class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html#a4606b7a0ce18fa82afa1a27b2fd8abdf) (T t) |
| void | [ClearListeners](class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html#a17c0ac3eb7ce02f9589e73c276b7992e) (object o) |

|  |  |
| --- | --- |
| Public Attributes | |
| [EventHandlerRec](class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html#a0653bde57c9d79293b4787c5121ab9d7)< TS > | [Next](class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html#ae246c08fee90d1e1947eff6c73333b0e) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html#a0653bde57c9d79293b4787c5121ab9d7)EventHandlerRec()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TaleWorlds.CampaignSystem.MbEvent](class_tale_worlds_1_1_campaign_system_1_1_mb_event.html)< T >.EventHandlerRec | ( | object | *owner*, |
|  |  | Action< TS > | *action* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html#a34d3e892b1fbefc53340c1dffe84b657)AddNonSerializedListener()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void [TaleWorlds.CampaignSystem.MbEvent](class_tale_worlds_1_1_campaign_system_1_1_mb_event.html)< T >.AddNonSerializedListener | ( | object | *owner*, |
|  |  | Action< T > | *action* ) |

Implements [TaleWorlds.CampaignSystem.IMbEvent< out T >](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event-1-g.html#ad7205921ea47b8dacd527a1f48e883ed).

[◆](class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html#a4606b7a0ce18fa82afa1a27b2fd8abdf)Invoke()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void [TaleWorlds.CampaignSystem.MbEvent](class_tale_worlds_1_1_campaign_system_1_1_mb_event.html)< T >.Invoke | ( | T | *t* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html#a17c0ac3eb7ce02f9589e73c276b7992e)ClearListeners()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void [TaleWorlds.CampaignSystem.MbEvent](class_tale_worlds_1_1_campaign_system_1_1_mb_event.html)< T >.ClearListeners | ( | object | *o* | ) |  |

Implements [TaleWorlds.CampaignSystem.IMbEventBase](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event_base.html#afa45fcdd6450926afb14b391d2898231).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html#ae246c08fee90d1e1947eff6c73333b0e)Next
------------------------------------------------------------------------------------------------------

|  |
| --- |
| [EventHandlerRec](class_tale_worlds_1_1_campaign_system_1_1_mb_event-1-g.html#a0653bde57c9d79293b4787c5121ab9d7)<TS> [TaleWorlds.CampaignSystem.MbEvent](class_tale_worlds_1_1_campaign_system_1_1_mb_event.html)< T >.Next |


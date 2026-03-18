--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html ---

TaleWorlds.CampaignSystem.ICampaignBehaviorManager Interface ReferenceInherited by [TaleWorlds.CampaignSystem.CampaignBehaviors.CampaignBehaviorManager](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_campaign_behavior_manager.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [RegisterEvents](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#a3cefce91c97f05edfef2a232f42b9b35) () |
| T | [GetBehavior< T >](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#aa262506878a501ed32f03010029a6919) () |
| IEnumerable< T > | [GetBehaviors< T >](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#a8816c608ae5bd228e5304c8b4bede556) () |
| void | [AddBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#a05b244415aa4e04e486ca272b574e425) ([CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) campaignBehavior) |
| void | [RemoveBehavior< T >](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#aabcc4ca3a3b2bae2971f80c0b8f99410) () |
| void | [ClearBehaviors](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#a12d7376166f1d0d570a529b9072f02db) () |
| void | [LoadBehaviorData](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#a8a91d3098e1af2023d0f45a3f186bd8b) () |
| void | [InitializeCampaignBehaviors](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#a871fb74032929465613f424595c5c67e) (IEnumerable< [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) > inputComponents) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#a3cefce91c97f05edfef2a232f42b9b35)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignBehaviorManager.RegisterEvents | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CampaignBehaviorManager](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_campaign_behavior_manager.html#a557da5e4d6dddb6cd05c7aa1e893468e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#aa262506878a501ed32f03010029a6919)GetBehavior< T >()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.CampaignSystem.ICampaignBehaviorManager.GetBehavior< T > | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CampaignBehaviorManager](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_campaign_behavior_manager.html#a6904a4e480a8bd1f2ae795e133b4ff70).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#a8816c608ae5bd228e5304c8b4bede556)GetBehaviors< T >()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< T > TaleWorlds.CampaignSystem.ICampaignBehaviorManager.GetBehaviors< T > | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CampaignBehaviorManager](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_campaign_behavior_manager.html#a2eb5a26c592826688ba0da0f014896e3).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#a05b244415aa4e04e486ca272b574e425)AddBehavior()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignBehaviorManager.AddBehavior | ( | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | *campaignBehavior* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CampaignBehaviorManager](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_campaign_behavior_manager.html#a56b2bff5001b9d4aacbc1e620ca11cf1).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#aabcc4ca3a3b2bae2971f80c0b8f99410)RemoveBehavior< T >()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignBehaviorManager.RemoveBehavior< T > | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CampaignBehaviorManager](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_campaign_behavior_manager.html#a0360f9da2d0b6cb25898e53370dd584d).

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html)* |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#a12d7376166f1d0d570a529b9072f02db)ClearBehaviors()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignBehaviorManager.ClearBehaviors | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CampaignBehaviorManager](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_campaign_behavior_manager.html#ac8f8c45c18c4ad16a7272eaf5d44a7f5).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#a8a91d3098e1af2023d0f45a3f186bd8b)LoadBehaviorData()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignBehaviorManager.LoadBehaviorData | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CampaignBehaviorManager](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_campaign_behavior_manager.html#adbb89427554d429591a0594d81d4b299).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior_manager.html#a871fb74032929465613f424595c5c67e)InitializeCampaignBehaviors()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ICampaignBehaviorManager.InitializeCampaignBehaviors | ( | IEnumerable< [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) > | *inputComponents* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.CampaignBehaviorManager](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_campaign_behavior_manager.html#af365e89aaa785d2b8fe775829753cd46).


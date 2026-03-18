--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html ---

TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionTask Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PersuasionTask](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#a28dc833d7d3108a1b546a10428ef21bc) (int reservationType) |
| void | [AddOptionToTask](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#a94e6f907725c401481b783bc5ef13d7d) ([PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) option) |
| void | [BlockAllOptions](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#ace93b6efcb38b1b4d3d3c585ddeccc6b) () |
| void | [UnblockAllOptions](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#add48f79c058ae33fea0256e6c831eb77) () |
| void | [ApplyEffects](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#aa72612542c22911d91f5908c63c730c9) (float moveToNextStageChance, float blockRandomOptionChance) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly MBList< [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) > | [Options](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#aa27c13c6347966265106820e61cb6299) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [SpokenLine](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#a714b9d37c679a8cf95cfdebbbbd87f28) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [ImmediateFailLine](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#a692a41b0f2f52d0f408532d009a0ad65) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [FinalFailLine](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#a7061df197c8836edf0748c76ca9e3189) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TryLaterLine](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#a232b4cb23f42c9a386c8298b85f767e2) |
| readonly int | [ReservationType](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#ac08e284c3819e5c9e3e4f705fa032c07) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#a28dc833d7d3108a1b546a10428ef21bc)PersuasionTask()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionTask.PersuasionTask | ( | int | *reservationType* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#a94e6f907725c401481b783bc5ef13d7d)AddOptionToTask()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionTask.AddOptionToTask | ( | [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) | *option* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#ace93b6efcb38b1b4d3d3c585ddeccc6b)BlockAllOptions()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionTask.BlockAllOptions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#add48f79c058ae33fea0256e6c831eb77)UnblockAllOptions()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionTask.UnblockAllOptions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#aa72612542c22911d91f5908c63c730c9)ApplyEffects()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionTask.ApplyEffects | ( | float | *moveToNextStageChance*, |
|  |  | float | *blockRandomOptionChance* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#aa27c13c6347966265106820e61cb6299)Options
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly MBList<[PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html)> TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionTask.Options |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#a714b9d37c679a8cf95cfdebbbbd87f28)SpokenLine
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionTask.SpokenLine |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#a692a41b0f2f52d0f408532d009a0ad65)ImmediateFailLine
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionTask.ImmediateFailLine |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#a7061df197c8836edf0748c76ca9e3189)FinalFailLine
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionTask.FinalFailLine |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#a232b4cb23f42c9a386c8298b85f767e2)TryLaterLine
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionTask.TryLaterLine |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_task.html#ac08e284c3819e5c9e3e4f705fa032c07)ReservationType
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.CampaignSystem.Conversation.Persuasion.PersuasionTask.ReservationType |


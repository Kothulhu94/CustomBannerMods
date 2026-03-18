--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html ---

TaleWorlds.CampaignSystem.Conversation.ConversationSentence Class Reference[Conversation](namespace_tale_worlds_1_1_campaign_system_1_1_conversation.html) Sentence class.

|  |  |
| --- | --- |
| Public Types | |
| enum | [DialogLineFlags](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a54b4f2236a382ee752584cebbda125eb) {     [PlayerLine](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a54b4f2236a382ee752584cebbda125eba9addf3f3e1db669c6466a741a69e1b62) = 0x00000001 ,     [RepeatForObjects](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a54b4f2236a382ee752584cebbda125eba274ff5991970fda1ab8b2d1e5225c8ac) = 0x00000002 ,     [SpecialLine](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a54b4f2236a382ee752584cebbda125eba9477ff03f22f36eed6f30007fb17b8df) = 0x00000004 ,     [UsedOnce](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a54b4f2236a382ee752584cebbda125eba5d24db929302c22966dbd00b246e1089) = 0x00000008   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate bool | [OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) () |
|  | The on condition delegate. |
| delegate bool | [OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
|  | The on clickable condition delegate. If pass show and clickable, otherwise still show but can not click. |
| delegate [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) | [OnPersuasionOptionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a157eab26e34d7aaeaf959d47ce2c3501) () |
|  | The persuasion option lazy initializer. |
| delegate void | [OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) () |
|  | On Consequence delegate. |
| delegate bool | [OnMultipleConversationConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a7f8ec110330fbf72a85fd1b76225ef83) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
|  | On Multiple [Conversation](namespace_tale_worlds_1_1_campaign_system_1_1_conversation.html) Consequence delegate. |
| ConversationSentence | [Variation](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a3c05c4a443be0039f4c46a5f17ed294c) (params object[] list) |
| void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a971b354a257ccab888b4aa5c4802fdb5) (XmlNode node, Type typeOfConversationCallbacks, [ConversationManager](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html) conversationManager, int defaultPriority) |
|  | Deserialize from Xml data. |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SetObjectsToRepeatOver](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a30900c1353936cab1a6f7eae0af85407) (IReadOnlyList< object > objectsToRepeatOver, int maxRepeatedDialogsInConversation=5) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [AgentIndex](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a7d79685909fe018438800b289c58549f) |
| int | [NextAgentIndex](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a314d976eef082044e64001af6246f851) |
| bool | [IsClickable](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a169bde488e72f02de3c0c82908d7f46d) = true |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [HintText](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ae09083852676f5aeeed830411c327166) |
| [OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) | [OnCondition](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e88e7a8992515857648268db021fc4a) |
| [OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) | [OnClickableCondition](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#addc8615f83c3a0f38c2ee5a02ef375b3) |
| [OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) | [OnConsequence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#af89cc1063562172a28e805e561bf11c9) |
| [OnMultipleConversationConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a7f8ec110330fbf72a85fd1b76225ef83) | [IsSpeaker](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ab9decde8e4e8ad84ec0ed11b79787b9f) |
| [OnMultipleConversationConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a7f8ec110330fbf72a85fd1b76225ef83) | [IsListener](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a65c9f234df0187d7b10fedbc946da28e) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f) = 100 |
|  | Default conversation sentence priority. |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Text](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ad9db43551ed28c0df2313b3612a917cb) `[get]` |
|  | Sentence text. |
| int | [Index](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ad34c4418c1760e44b632eb44719e9c6e) `[get]` |
| string | [Id](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a35411aa6b00581a080fc8f3ebd1a5fe2) `[get]` |
| bool | [IsPlayer](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ae5de848870d33365d39775037d7addad) `[get]` |
| bool | [IsRepeatable](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a64a47d6eab5590f200ef91ba890d993f) `[get]` |
| bool | [IsSpecial](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a56e85de53653d439ab77e47e37f68d1a) `[get]` |
| bool | [IsUsedOnce](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a377e4da8fc4422543090ff9d469e5a77) `[get]` |
| int | [Priority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a84be93e7192578af9ddab25059951434) `[get]` |
| int | [InputToken](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a37741759cd320c11ceeec67136fd7bd9) `[get]` |
|  | Input Token index. |
| int | [OutputToken](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a5e8b636827e3143cbe0671ba61d20dec) `[get]` |
|  | Output Token index. |
| object | [RelatedObject](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a78e1c38db795d2b2655dd40f1c699ce9) `[get]` |
| bool | [IsWithVariation](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#aa0078d38f7a9adf699778992668feb30) `[get]` |
| [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) | [PersuationOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a99f1db3d9c664b97ad090a81e5486264) `[get]` |
| bool | [HasPersuasion](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ab23d2a1de32388cd8b937ee118e4e487) `[get]` |
| string | [SkillName](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a86ad0748cd7cca2cdac386d939294303) `[get]` |
| string | [TraitName](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a645018866dd32eefe0e394f87289ec62) `[get]` |
| static object | [CurrentProcessedRepeatObject](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2a58cbd3ccadce5ba14ed798b6fb5c44) `[get]` |
| static object | [SelectedRepeatObject](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#af7c92fdbd7b5087d7a3dfb458cbf7799) `[get]` |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [SelectedRepeatLine](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#acdb79e669ec1fc8a4cec2f79e8b28008) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a54b4f2236a382ee752584cebbda125eb)DialogLineFlags
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Conversation.ConversationSentence.DialogLineFlags](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a54b4f2236a382ee752584cebbda125eb) |

| Enumerator | |
| --- | --- |
| PlayerLine |  |
| RepeatForObjects |  |
| SpecialLine |  |
| UsedOnce |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697)OnConditionDelegate()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate bool TaleWorlds.CampaignSystem.Conversation.ConversationSentence.OnConditionDelegate | ( |  | ) |  |

Returns
:   Whether if condition pass or not.

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91)OnClickableConditionDelegate()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate bool TaleWorlds.CampaignSystem.Conversation.ConversationSentence.OnClickableConditionDelegate | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* | ) |  |

Returns
:   Whether if condition pass or not.

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a157eab26e34d7aaeaf959d47ce2c3501)OnPersuasionOptionDelegate()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) TaleWorlds.CampaignSystem.Conversation.ConversationSentence.OnPersuasionOptionDelegate | ( |  | ) |  |

Returns
:   Whether if condition pass or not.

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df)OnConsequenceDelegate()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Conversation.ConversationSentence.OnConsequenceDelegate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a7f8ec110330fbf72a85fd1b76225ef83)OnMultipleConversationConsequenceDelegate()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate bool TaleWorlds.CampaignSystem.Conversation.ConversationSentence.OnMultipleConversationConsequenceDelegate | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a3c05c4a443be0039f4c46a5f17ed294c)Variation()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| ConversationSentence TaleWorlds.CampaignSystem.Conversation.ConversationSentence.Variation | ( | params object[] | *list* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a971b354a257ccab888b4aa5c4802fdb5)Deserialize()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationSentence.Deserialize | ( | XmlNode | *node*, |
|  |  | Type | *typeOfConversationCallbacks*, |
|  |  | [ConversationManager](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html) | *conversationManager*, |
|  |  | int | *defaultPriority* ) |

Parameters
:   |  |  |
    | --- | --- |
    | node | The node. |
    | typeOfConversationCallbacks | The type of conversation callbacks. |
    | conversationManager |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a30900c1353936cab1a6f7eae0af85407)SetObjectsToRepeatOver()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Conversation.ConversationSentence.SetObjectsToRepeatOver | ( | IReadOnlyList< object > | *objectsToRepeatOver*, | |  |  | int | *maxRepeatedDialogsInConversation* = 5 ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f)DefaultPriority
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Conversation.ConversationSentence.DefaultPriority = 100 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a7d79685909fe018438800b289c58549f)AgentIndex
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Conversation.ConversationSentence.AgentIndex |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a314d976eef082044e64001af6246f851)NextAgentIndex
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Conversation.ConversationSentence.NextAgentIndex |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a169bde488e72f02de3c0c82908d7f46d)IsClickable
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Conversation.ConversationSentence.IsClickable = true |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ae09083852676f5aeeed830411c327166)HintText
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Conversation.ConversationSentence.HintText |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e88e7a8992515857648268db021fc4a)OnCondition
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) TaleWorlds.CampaignSystem.Conversation.ConversationSentence.OnCondition |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#addc8615f83c3a0f38c2ee5a02ef375b3)OnClickableCondition
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) TaleWorlds.CampaignSystem.Conversation.ConversationSentence.OnClickableCondition |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#af89cc1063562172a28e805e561bf11c9)OnConsequence
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) TaleWorlds.CampaignSystem.Conversation.ConversationSentence.OnConsequence |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ab9decde8e4e8ad84ec0ed11b79787b9f)IsSpeaker
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnMultipleConversationConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a7f8ec110330fbf72a85fd1b76225ef83) TaleWorlds.CampaignSystem.Conversation.ConversationSentence.IsSpeaker |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a65c9f234df0187d7b10fedbc946da28e)IsListener
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnMultipleConversationConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a7f8ec110330fbf72a85fd1b76225ef83) TaleWorlds.CampaignSystem.Conversation.ConversationSentence.IsListener |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ad9db43551ed28c0df2313b3612a917cb)Text
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Conversation.ConversationSentence.Text | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ad34c4418c1760e44b632eb44719e9c6e)Index
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Conversation.ConversationSentence.Index | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a35411aa6b00581a080fc8f3ebd1a5fe2)Id
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Conversation.ConversationSentence.Id | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ae5de848870d33365d39775037d7addad)IsPlayer
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Conversation.ConversationSentence.IsPlayer | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a64a47d6eab5590f200ef91ba890d993f)IsRepeatable
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Conversation.ConversationSentence.IsRepeatable | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a56e85de53653d439ab77e47e37f68d1a)IsSpecial
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Conversation.ConversationSentence.IsSpecial | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a377e4da8fc4422543090ff9d469e5a77)IsUsedOnce
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Conversation.ConversationSentence.IsUsedOnce | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a84be93e7192578af9ddab25059951434)Priority
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Conversation.ConversationSentence.Priority | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a37741759cd320c11ceeec67136fd7bd9)InputToken
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Conversation.ConversationSentence.InputToken | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a5e8b636827e3143cbe0671ba61d20dec)OutputToken
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Conversation.ConversationSentence.OutputToken | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a78e1c38db795d2b2655dd40f1c699ce9)RelatedObject
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.CampaignSystem.Conversation.ConversationSentence.RelatedObject | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#aa0078d38f7a9adf699778992668feb30)IsWithVariation
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Conversation.ConversationSentence.IsWithVariation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a99f1db3d9c664b97ad090a81e5486264)PersuationOptionArgs
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) TaleWorlds.CampaignSystem.Conversation.ConversationSentence.PersuationOptionArgs | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ab23d2a1de32388cd8b937ee118e4e487)HasPersuasion
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Conversation.ConversationSentence.HasPersuasion | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a86ad0748cd7cca2cdac386d939294303)SkillName
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Conversation.ConversationSentence.SkillName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a645018866dd32eefe0e394f87289ec62)TraitName
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Conversation.ConversationSentence.TraitName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2a58cbd3ccadce5ba14ed798b6fb5c44)CurrentProcessedRepeatObject
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.CampaignSystem.Conversation.ConversationSentence.CurrentProcessedRepeatObject | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#af7c92fdbd7b5087d7a3dfb458cbf7799)SelectedRepeatObject
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.CampaignSystem.Conversation.ConversationSentence.SelectedRepeatObject | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#acdb79e669ec1fc8a4cec2f79e8b28008)SelectedRepeatLine
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Conversation.ConversationSentence.SelectedRepeatLine | | staticget |


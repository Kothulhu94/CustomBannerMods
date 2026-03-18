--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html ---

TaleWorlds.CampaignSystem.Conversation.ConversationManager Class Reference[Conversation](namespace_tale_worlds_1_1_campaign_system_1_1_conversation.html) Manager class.

|  |  |
| --- | --- |
| Classes | |
| class | [TaggedString](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager_1_1_tagged_string.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [CreateConversationSentenceIndex](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a16def67e8816484499eb1410713c02d1) () |
|  | [ConversationManager](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#afbdb0f2c9340a6fbeabc67ee04d911cc) () |
|  | Initializes a new instance of the [ConversationManager](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html "Conversation Manager class.") class. |
| void | [StartNew](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#af601f61a8c1885993be6bf5533f274f4) (int startingToken, bool setActionsInstantly) |
| void | [ProcessSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a6ecf65e01980f0fed817d0b464f485bc) ([ConversationSentenceOption](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence_option.html) conversationSentenceOption) |
|  | Process sentence and run its consequence method. |
| void | [UpdateCurrentSentenceText](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#acfe190e869661bf3d803ee3fe8dc7979) () |
|  | Update Current Sentence Text. |
| bool | [IsConversationEnded](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a9dd5cb3f2c9b0ae4ad356cedd389b2ef) () |
|  | Is [Conversation](namespace_tale_worlds_1_1_campaign_system_1_1_conversation.html) Ended. |
| void | [ClearCurrentOptions](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a116d4d2797c6d3002164d22ba88b7b54) () |
| void | [AddToCurrentOptions](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a5b84434360a7aa08a51ebf710a32a7ef) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text, String id, bool isClickable, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) hintText) |
| void | [GetPlayerSentenceOptions](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a9b50a50d087de103b50e23b1cfb04218) () |
|  | Get Player Sentence Options. |
| int | [GetStateIndex](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a858ad37c6e4544a4b6c3ae3b0782759a) (string str) |
|  | Get State Index. |
| void | [DisableSentenceSort](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a558d2b1dec0380d3cbcb65efcfc0de5b) () |
| void | [EnableSentenceSort](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#afb5119e8fdff8abf214bd77032c5646b) () |
| void | [AddDialogFlow](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ab27f1be0f56e274d807be5df8a88d9f3) ([DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) dialogFlow, object relatedObject=null) |
| [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) | [AddDialogLineMultiAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ab3d48abc270bf1765d390385821a1891) (string id, string inputToken, string outputToken, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text, [ConversationSentence.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) conditionDelegate, [ConversationSentence.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) consequenceDelegate, int agentIndex, int nextAgentIndex, int priority=[ConversationSentence.DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f), [ConversationSentence.OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) clickableConditionDelegate=null) |
| bool | [IsAgentInConversation](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a01578d190cb7f9249bd13e5fdc5d9abc) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| void | [BeginConversation](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#aeaf671420aff79d4debc4b511b1eaf0d) () |
| void | [EndConversation](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#abb8a4a1e3f70bf72bb903e11dba56e38) () |
| void | [DoOption](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#af6dbded189ef76ced01dbb2a75ffc168) (int optionIndex) |
| void | [DoOption](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a740cb93309c153d30b7c27ceefea705d) (string optionID) |
| void | [DoConversationContinuedCallback](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a9399ac93ae9932e7fbe62b785f45b222) () |
| void | [DoOptionContinue](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a2151a8132a478cb7fa015b2efa41687e) () |
| void | [ContinueConversation](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#aad5c45000be3bb4306da2408c5356bc2) () |
| void | [SetupAndStartMissionConversation](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#afbb1399eb3b86f0da425c8eb9a4c0c62) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent, [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) mainAgent, bool setActionsInstantly) |
| void | [SetupAndStartMissionConversationWithMultipleAgents](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a0fd7fd7114b672a1530f25e10d086911) (IEnumerable< [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) > agents, [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) mainAgent) |
| void | [SetupAndStartMapConversation](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a2a9c2aa5966692bcc40bebb07d976c1a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent, [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) mainAgent) |
| void | [AddConversationAgents](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a64faeb1d830c007c2e84103ccca3bd6e) (IEnumerable< [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) > agents, bool setActionsInstantly) |
| void | [RemoveConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a72e7a51a69d4fa8884a4dca28b5984f3) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
|  | Should only be used during multiple agent conversations to remove excess conversation agents. |
| bool | [IsConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#aa8bdbb31627a48ee0178c5f808f60449) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| void | [RemoveRelatedLines](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a50a55d00508c074a2d8b01aa1d06fbdc) (object o) |
| void | [OnConversationDeactivate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a10521f7642081ac113283e5fa3c4d6a0) () |
| void | [OnConversationActivate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#af9114f199e9b5e620f05cc036cbf342a) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [FindMatchingTextOrNull](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#abbbb8f8d0b901bba846388a4069aed22) (string id, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| IEnumerable< string > | [GetApplicableTagNames](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ad856524c67a5a6943eca871ec7646028) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| bool | [IsTagApplicable](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a3c4b8294d621db155f4cda4a7062ad2f) (string tagId, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| void | [OpenMapConversation](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#adb3886ff826222ca4da0ab20e92cec95) ([ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) playerCharacterData, [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) conversationPartnerData) |
| void | [GetPersuasionChanceValues](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a1f307eb5cfab47cd16cb5458e07e008e) (out float successValue, out float critSuccessValue, out float critFailValue) |
| void | [GetPersuasionChances](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#aa36c245de36d2da1ab8c20da03ab7b64) ([ConversationSentenceOption](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence_option.html) conversationSentenceOption, out float successChance, out float critSuccessChance, out float critFailChance, out float failChance) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [StartPersuasion](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#aae9d5656498d25d58ffdc8b9a90e5243) (float goalValue, float successValue, float failValue, float criticalSuccessValue, float criticalFailValue, float initialProgress=-1f, [PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) difficulty=PersuasionDifficulty.Medium) |
| static void | [EndPersuasion](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ae2c43e5d409414dd27b7c30a89e79a01) () |
| static void | [PersuasionCommitProgress](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a968d747dac756f0e2f78083924a28c2d) ([PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) persuasionOptionArgs) |
| static void | [Clear](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#acfc75de998b9444ab08c40b05f7ad288) () |
| static bool | [GetPersuasionIsActive](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ab549f51024e55a7d8c79f9dcf2a28ca8) () |
| static bool | [GetPersuasionProgressSatisfied](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a512f1ced30fea0402ffa9e98c03b1cdf) () |
| static bool | [GetPersuasionIsFailure](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a4e03fd52f99f44916579c6b39052bc96) () |
| static float | [GetPersuasionProgress](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a3db6bc0bb9836a69df8be3027ab91d68) () |
| static float | [GetPersuasionGoalValue](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#af8e22a2b57dd94e0a63dfbfdb51466f5) () |
| static IEnumerable< Tuple< [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html), [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) > > | [GetPersuasionChosenOptions](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a6c6f89b3e055de1f8a486429b76fc3ee) () |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [ActiveToken](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#acc5d3faa7e252e4de3e9762dc9893834) |
|  | Active Token index. |
| List< Tuple< string, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > > | [DetailedDebugLog](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#acd792f4b0c203e83c131807fc9a53c2d) = new List<Tuple<string, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)>>() |
|  | [Debug](class_tale_worlds_1_1_library_1_1_debug.html) information text of the current sentence. |
| string | [CurrentFaceAnimationRecord](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a3325ed409be35527aafd101fd811a9a4) |
|  | Face animation record of the current sentence. |
| int | [LastSelectedButtonIndex](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#afc0aaca73d097921d51ea17b5bc78628) |
| ConversationAnimationManager | [ConversationAnimationManager](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ae475e98d4afb3ed0f5bde79a7b0809db) |
| bool | [CurrentConversationIsFirst](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ac542347910560803dca3413c145efdef) |

|  |  |
| --- | --- |
| Properties | |
| string | [CurrentSentenceText](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a36853b17c21e20a3505c7690a3782a0a) `[get]` |
|  | Text of the current sentence. |
| bool | [IsConversationFlowActive](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a27ba9983ceec26d3572ee0df4a82261a) `[get]` |
| List< [ConversationSentenceOption](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence_option.html) > | [CurOptions](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#acfc97c39676c7a6cbe672005fba6cb8e) `[get, protected set]` |
|  | Gets or sets CurOptions. |
| IReadOnlyList< [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) > | [ConversationAgents](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a6e8f257d21118f6e0905b4dc705cf234) `[get]` |
| [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | [OneToOneConversationAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a1a97a25558ddadef79f89911f0d7e8de) `[get]` |
| [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | [SpeakerAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ad1be3cea7518943f860025eef862c0bd) `[get]` |
| [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | [ListenerAgent](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#aae099f631fa9ce2ee1892a2b167bcdd9) `[get]` |
| bool | [IsConversationInProgress](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a91783ff110d77a2b26b88bf5b46750e4) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [OneToOneConversationHero](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a4b862876de4b9f52dd5129a9daeb17a5) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [OneToOneConversationCharacter](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a82e977e1f75a08d59a72fb4189ca78a1) `[get]` |
| IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [ConversationCharacters](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a7619fc99751a582658b12471d6007852) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [ConversationParty](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ad5b89be944392278a47382ee243634ff) `[get]` |
| bool | [NeedsToActivateForMapConversation](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a9dc9f5715648b55f12305cbbaab9ca20) `[get]` |
| [IConversationStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_i_conversation_state_handler.html) | [Handler](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ac3dc6e59f785995a86398abf700df545) `[get, set]` |

|  |  |
| --- | --- |
| Events | |
| Action< [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) > | [ConsequenceRunned](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a330f379545089b1ad5071b9c2bc0c5cf) |
| Action< [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) > | [ConditionRunned](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a098d1d22d68ffc78156f5b2a1a99688d) |
| Action< [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) > | [ClickableConditionRunned](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a50c960f4dc1d844a7ca2c439e1590bed) |
| Action | [ConversationSetup](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a82c51e0b09b125c1df42401096373c05) |
| Action | [ConversationBegin](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ad1aa14f1cb7678b682ec6e51758450fb) |
| Action | [ConversationEnd](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a62ea325c43cee49669d0e7566a08b5bd) |
| Action | [ConversationEndOneShot](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a2291b4d59e85453ea28c4d6c1e460d46) |
| Action | [ConversationContinued](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a36951e8d311203bf92af730607a86e1a) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#afbdb0f2c9340a6fbeabc67ee04d911cc)ConversationManager()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Conversation.ConversationManager.ConversationManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a16def67e8816484499eb1410713c02d1)CreateConversationSentenceIndex()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Conversation.ConversationManager.CreateConversationSentenceIndex | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#af601f61a8c1885993be6bf5533f274f4)StartNew()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.StartNew | ( | int | *startingToken*, |
|  |  | bool | *setActionsInstantly* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a6ecf65e01980f0fed817d0b464f485bc)ProcessSentence()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.ProcessSentence | ( | [ConversationSentenceOption](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence_option.html) | *conversationSentenceOption* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | conversationSentenceOption | The conversation sentence option. |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#acfe190e869661bf3d803ee3fe8dc7979)UpdateCurrentSentenceText()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.UpdateCurrentSentenceText | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a9dd5cb3f2c9b0ae4ad356cedd389b2ef)IsConversationEnded()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Conversation.ConversationManager.IsConversationEnded | ( |  | ) |  |

Returns
:   Whether conversation ended or not.

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a116d4d2797c6d3002164d22ba88b7b54)ClearCurrentOptions()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.ClearCurrentOptions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a5b84434360a7aa08a51ebf710a32a7ef)AddToCurrentOptions()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.AddToCurrentOptions | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text*, |
|  |  | String | *id*, |
|  |  | bool | *isClickable*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *hintText* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a9b50a50d087de103b50e23b1cfb04218)GetPlayerSentenceOptions()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.GetPlayerSentenceOptions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a858ad37c6e4544a4b6c3ae3b0782759a)GetStateIndex()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Conversation.ConversationManager.GetStateIndex | ( | string | *str* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | str | The str. |

Returns
:   state index

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a558d2b1dec0380d3cbcb65efcfc0de5b)DisableSentenceSort()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.DisableSentenceSort | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#afb5119e8fdff8abf214bd77032c5646b)EnableSentenceSort()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.EnableSentenceSort | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ab27f1be0f56e274d807be5df8a88d9f3)AddDialogFlow()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.AddDialogFlow | ( | [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | *dialogFlow*, |
|  |  | object | *relatedObject* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ab3d48abc270bf1765d390385821a1891)AddDialogLineMultiAgent()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) TaleWorlds.CampaignSystem.Conversation.ConversationManager.AddDialogLineMultiAgent | ( | string | *id*, |
|  |  | string | *inputToken*, |
|  |  | string | *outputToken*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text*, |
|  |  | [ConversationSentence.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) | *conditionDelegate*, |
|  |  | [ConversationSentence.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) | *consequenceDelegate*, |
|  |  | int | *agentIndex*, |
|  |  | int | *nextAgentIndex*, |
|  |  | int | *priority* = [ConversationSentence::DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f), |
|  |  | [ConversationSentence.OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) | *clickableConditionDelegate* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a01578d190cb7f9249bd13e5fdc5d9abc)IsAgentInConversation()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Conversation.ConversationManager.IsAgentInConversation | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#aeaf671420aff79d4debc4b511b1eaf0d)BeginConversation()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.BeginConversation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#abb8a4a1e3f70bf72bb903e11dba56e38)EndConversation()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.EndConversation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#af6dbded189ef76ced01dbb2a75ffc168)DoOption() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.DoOption | ( | int | *optionIndex* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a740cb93309c153d30b7c27ceefea705d)DoOption() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.DoOption | ( | string | *optionID* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a9399ac93ae9932e7fbe62b785f45b222)DoConversationContinuedCallback()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.DoConversationContinuedCallback | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a2151a8132a478cb7fa015b2efa41687e)DoOptionContinue()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.DoOptionContinue | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#aad5c45000be3bb4306da2408c5356bc2)ContinueConversation()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.ContinueConversation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#afbb1399eb3b86f0da425c8eb9a4c0c62)SetupAndStartMissionConversation()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.SetupAndStartMissionConversation | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent*, |
|  |  | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *mainAgent*, |
|  |  | bool | *setActionsInstantly* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a0fd7fd7114b672a1530f25e10d086911)SetupAndStartMissionConversationWithMultipleAgents()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.SetupAndStartMissionConversationWithMultipleAgents | ( | IEnumerable< [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) > | *agents*, |
|  |  | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *mainAgent* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a2a9c2aa5966692bcc40bebb07d976c1a)SetupAndStartMapConversation()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.SetupAndStartMapConversation | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent*, |
|  |  | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *mainAgent* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a64faeb1d830c007c2e84103ccca3bd6e)AddConversationAgents()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.AddConversationAgents | ( | IEnumerable< [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) > | *agents*, |
|  |  | bool | *setActionsInstantly* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a72e7a51a69d4fa8884a4dca28b5984f3)RemoveConversationAgent()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.RemoveConversationAgent | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | agent |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#aa8bdbb31627a48ee0178c5f808f60449)IsConversationAgent()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Conversation.ConversationManager.IsConversationAgent | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a50a55d00508c074a2d8b01aa1d06fbdc)RemoveRelatedLines()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.RemoveRelatedLines | ( | object | *o* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a10521f7642081ac113283e5fa3c4d6a0)OnConversationDeactivate()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.OnConversationDeactivate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#af9114f199e9b5e620f05cc036cbf342a)OnConversationActivate()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.OnConversationActivate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#abbbb8f8d0b901bba846388a4069aed22)FindMatchingTextOrNull()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Conversation.ConversationManager.FindMatchingTextOrNull | ( | string | *id*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ad856524c67a5a6943eca871ec7646028)GetApplicableTagNames()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< string > TaleWorlds.CampaignSystem.Conversation.ConversationManager.GetApplicableTagNames | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a3c4b8294d621db155f4cda4a7062ad2f)IsTagApplicable()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Conversation.ConversationManager.IsTagApplicable | ( | string | *tagId*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#adb3886ff826222ca4da0ab20e92cec95)OpenMapConversation()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.OpenMapConversation | ( | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) | *playerCharacterData*, |
|  |  | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) | *conversationPartnerData* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#aae9d5656498d25d58ffdc8b9a90e5243)StartPersuasion()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Conversation.ConversationManager.StartPersuasion | ( | float | *goalValue*, | |  |  | float | *successValue*, | |  |  | float | *failValue*, | |  |  | float | *criticalSuccessValue*, | |  |  | float | *criticalFailValue*, | |  |  | float | *initialProgress* = -1f, | |  |  | [PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) | *difficulty* = PersuasionDifficulty::Medium ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ae2c43e5d409414dd27b7c30a89e79a01)EndPersuasion()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Conversation.ConversationManager.EndPersuasion | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a968d747dac756f0e2f78083924a28c2d)PersuasionCommitProgress()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Conversation.ConversationManager.PersuasionCommitProgress | ( | [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) | *persuasionOptionArgs* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#acfc75de998b9444ab08c40b05f7ad288)Clear()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Conversation.ConversationManager.Clear | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a1f307eb5cfab47cd16cb5458e07e008e)GetPersuasionChanceValues()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.GetPersuasionChanceValues | ( | out float | *successValue*, |
|  |  | out float | *critSuccessValue*, |
|  |  | out float | *critFailValue* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ab549f51024e55a7d8c79f9dcf2a28ca8)GetPersuasionIsActive()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Conversation.ConversationManager.GetPersuasionIsActive | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a512f1ced30fea0402ffa9e98c03b1cdf)GetPersuasionProgressSatisfied()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Conversation.ConversationManager.GetPersuasionProgressSatisfied | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a4e03fd52f99f44916579c6b39052bc96)GetPersuasionIsFailure()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Conversation.ConversationManager.GetPersuasionIsFailure | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a3db6bc0bb9836a69df8be3027ab91d68)GetPersuasionProgress()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.Conversation.ConversationManager.GetPersuasionProgress | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#af8e22a2b57dd94e0a63dfbfdb51466f5)GetPersuasionGoalValue()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.Conversation.ConversationManager.GetPersuasionGoalValue | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a6c6f89b3e055de1f8a486429b76fc3ee)GetPersuasionChosenOptions()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | IEnumerable< Tuple< [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html), [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) > > TaleWorlds.CampaignSystem.Conversation.ConversationManager.GetPersuasionChosenOptions | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#aa36c245de36d2da1ab8c20da03ab7b64)GetPersuasionChances()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Conversation.ConversationManager.GetPersuasionChances | ( | [ConversationSentenceOption](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence_option.html) | *conversationSentenceOption*, |
|  |  | out float | *successChance*, |
|  |  | out float | *critSuccessChance*, |
|  |  | out float | *critFailChance*, |
|  |  | out float | *failChance* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#acc5d3faa7e252e4de3e9762dc9893834)ActiveToken
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Conversation.ConversationManager.ActiveToken |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#acd792f4b0c203e83c131807fc9a53c2d)DetailedDebugLog
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<Tuple<string, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> > TaleWorlds.CampaignSystem.Conversation.ConversationManager.DetailedDebugLog = new List<Tuple<string, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)>>() |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a3325ed409be35527aafd101fd811a9a4)CurrentFaceAnimationRecord
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.CampaignSystem.Conversation.ConversationManager.CurrentFaceAnimationRecord |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#afc0aaca73d097921d51ea17b5bc78628)LastSelectedButtonIndex
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Conversation.ConversationManager.LastSelectedButtonIndex |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ae475e98d4afb3ed0f5bde79a7b0809db)ConversationAnimationManager
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| ConversationAnimationManager TaleWorlds.CampaignSystem.Conversation.ConversationManager.ConversationAnimationManager |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ac542347910560803dca3413c145efdef)CurrentConversationIsFirst
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Conversation.ConversationManager.CurrentConversationIsFirst |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a36853b17c21e20a3505c7690a3782a0a)CurrentSentenceText
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Conversation.ConversationManager.CurrentSentenceText | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a27ba9983ceec26d3572ee0df4a82261a)IsConversationFlowActive
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Conversation.ConversationManager.IsConversationFlowActive | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#acfc97c39676c7a6cbe672005fba6cb8e)CurOptions
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[ConversationSentenceOption](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence_option.html)> TaleWorlds.CampaignSystem.Conversation.ConversationManager.CurOptions | | getprotected set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a6e8f257d21118f6e0905b4dc705cf234)ConversationAgents
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyList<[IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html)> TaleWorlds.CampaignSystem.Conversation.ConversationManager.ConversationAgents | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a1a97a25558ddadef79f89911f0d7e8de)OneToOneConversationAgent
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) TaleWorlds.CampaignSystem.Conversation.ConversationManager.OneToOneConversationAgent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ad1be3cea7518943f860025eef862c0bd)SpeakerAgent
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) TaleWorlds.CampaignSystem.Conversation.ConversationManager.SpeakerAgent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#aae099f631fa9ce2ee1892a2b167bcdd9)ListenerAgent
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) TaleWorlds.CampaignSystem.Conversation.ConversationManager.ListenerAgent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a91783ff110d77a2b26b88bf5b46750e4)IsConversationInProgress
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Conversation.ConversationManager.IsConversationInProgress | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a4b862876de4b9f52dd5129a9daeb17a5)OneToOneConversationHero
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Conversation.ConversationManager.OneToOneConversationHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a82e977e1f75a08d59a72fb4189ca78a1)OneToOneConversationCharacter
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.Conversation.ConversationManager.OneToOneConversationCharacter | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a7619fc99751a582658b12471d6007852)ConversationCharacters
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.Conversation.ConversationManager.ConversationCharacters | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ad5b89be944392278a47382ee243634ff)ConversationParty
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.Conversation.ConversationManager.ConversationParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a9dc9f5715648b55f12305cbbaab9ca20)NeedsToActivateForMapConversation
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Conversation.ConversationManager.NeedsToActivateForMapConversation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ac3dc6e59f785995a86398abf700df545)Handler
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IConversationStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_i_conversation_state_handler.html) TaleWorlds.CampaignSystem.Conversation.ConversationManager.Handler | | getset |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a330f379545089b1ad5071b9c2bc0c5cf)ConsequenceRunned
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html)> TaleWorlds.CampaignSystem.Conversation.ConversationManager.ConsequenceRunned |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a098d1d22d68ffc78156f5b2a1a99688d)ConditionRunned
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html)> TaleWorlds.CampaignSystem.Conversation.ConversationManager.ConditionRunned |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a50c960f4dc1d844a7ca2c439e1590bed)ClickableConditionRunned
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html)> TaleWorlds.CampaignSystem.Conversation.ConversationManager.ClickableConditionRunned |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a82c51e0b09b125c1df42401096373c05)ConversationSetup
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.CampaignSystem.Conversation.ConversationManager.ConversationSetup |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#ad1aa14f1cb7678b682ec6e51758450fb)ConversationBegin
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.CampaignSystem.Conversation.ConversationManager.ConversationBegin |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a62ea325c43cee49669d0e7566a08b5bd)ConversationEnd
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.CampaignSystem.Conversation.ConversationManager.ConversationEnd |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a2291b4d59e85453ea28c4d6c1e460d46)ConversationEndOneShot
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.CampaignSystem.Conversation.ConversationManager.ConversationEndOneShot |

[◆](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html#a36951e8d311203bf92af730607a86e1a)ConversationContinued
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.CampaignSystem.Conversation.ConversationManager.ConversationContinued |


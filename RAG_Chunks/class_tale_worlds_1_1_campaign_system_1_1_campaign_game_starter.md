--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html ---

TaleWorlds.CampaignSystem.CampaignGameStarter Class ReferenceInherits [TaleWorlds.Core.IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a3fa5bb2a4ba797da4e305ea7c4ef2726) ([GameMenuManager](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html) gameMenuManager, [ConversationManager](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html) conversationManager) |
| void | [UnregisterNonReadyObjects](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#acd7467d3fa0b1dba0015c44d096ba118) () |
| void | [AddBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a9084da834ff5ab1ed2536b28f73c9b1c) ([CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) campaignBehavior) |
| void | [RemoveBehaviors< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a3b2cd9cf3c0f746a7e10d55e95f37b74) () |
| bool | [RemoveBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#ac6723360a59e9866d46e3f7c32a99c87) (T behavior) |
| T | [GetModel< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a51512df71aa2d5849fe7893b58437684) () |
| void | [AddModel](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#aa47bcf7387b06718b136637a94a054a5) ([GameModel](class_tale_worlds_1_1_core_1_1_game_model.html) gameModel) |
| void | [AddModel< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a2596c0ce5c0288fc3644f830767f5dff) (MBGameModel< T > gameModel) |
| void | [AddGameMenu](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a7d6d8f13c243dc997280c61ac89a0ad4) (string menuId, string menuText, [OnInitDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#ae01fba5e92213046937417cfab6b6ef5) initDelegate, GameMenu.MenuOverlayType overlay=GameMenu.MenuOverlayType.None, GameMenu.MenuFlags menuFlags=GameMenu.MenuFlags.None, object relatedObject=null) |
| void | [AddWaitGameMenu](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a4fb70dacc1c40f58f14b0e8a3fa8863d) (string idString, string text, [OnInitDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#ae01fba5e92213046937417cfab6b6ef5) initDelegate, [OnConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#a812ba69ef85df5525f772e2d4ba0158a) condition, [OnConsequenceDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#a639003d18b3a5d6068698217e0193265) consequence, [OnTickDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#a05791a312d92c840f251eb62ab268f51) tick, GameMenu.MenuAndOptionType type, GameMenu.MenuOverlayType overlay=GameMenu.MenuOverlayType.None, float targetWaitHours=0.0f, GameMenu.MenuFlags flags=GameMenu.MenuFlags.None, object relatedObject=null) |
| void | [AddGameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a2a548616d5bc2661132d71b88c71b130) (string menuId, string optionId, string optionText, [GameMenuOption.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a67f0448f025b739bc2f931a7eee24b66) condition, [GameMenuOption.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#afae542885d132e26e2aaae06a63371b3) consequence, bool isLeave=false, int index=-1, bool isRepeatable=false, object relatedObject=null) |
| [GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) | [GetPresumedGameMenu](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#ada3072cb4f40e563af7082d0067ab3fe) (string stringId) |
| void | [AddDialogFlow](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#aab754c4fee64236470009d2fb294667b) ([DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) dialogFlow, object relatedObject=null) |
| [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) | [AddPlayerLine](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#abc007cf84183d0f1a73e0c28a65ba90e) (string id, string inputToken, string outputToken, string text, [ConversationSentence.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) conditionDelegate, [ConversationSentence.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) consequenceDelegate, int priority=[ConversationSentence.DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f), [ConversationSentence.OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) clickableConditionDelegate=null, [ConversationSentence.OnPersuasionOptionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a157eab26e34d7aaeaf959d47ce2c3501) persuasionOptionDelegate=null) |
| [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) | [AddRepeatablePlayerLine](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#af1cd557ea251cdfd217648c6871b4921) (string id, string inputToken, string outputToken, string text, string continueListingRepeatedObjectsText, string continueListingOptionOutputToken, [ConversationSentence.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) conditionDelegate, [ConversationSentence.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) consequenceDelegate, int priority=[ConversationSentence.DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f), [ConversationSentence.OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) clickableConditionDelegate=null) |
| [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) | [AddDialogLineWithVariation](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#af9650b1acdc96eafed05dad01432080a) (string id, string inputToken, string outputToken, [ConversationSentence.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) conditionDelegate, [ConversationSentence.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) consequenceDelegate, int priority=[ConversationSentence.DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f), string idleActionId="", string idleFaceAnimId="", string reactionId="", string reactionFaceAnimId="", [ConversationSentence.OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) clickableConditionDelegate=null) |
| [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) | [AddDialogLine](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#ada839c7e59fedd1555ec1fbb160a8875) (string id, string inputToken, string outputToken, string text, [ConversationSentence.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) conditionDelegate, [ConversationSentence.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) consequenceDelegate, int priority=[ConversationSentence.DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f), [ConversationSentence.OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) clickableConditionDelegate=null) |
| [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) | [AddDialogLineMultiAgent](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#ac92d315373b3a19ed5fe81c570abaca8) (string id, string inputToken, string outputToken, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text, [ConversationSentence.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) conditionDelegate, [ConversationSentence.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) consequenceDelegate, int agentIndex, int nextAgentIndex, int priority=[ConversationSentence.DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f), [ConversationSentence.OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) clickableConditionDelegate=null) |

|  |  |
| --- | --- |
| Properties | |
| ICollection< [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) > | [CampaignBehaviors](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a0de3c6bec931d807d44c29901df9e1df) `[get]` |
| IEnumerable< [GameModel](class_tale_worlds_1_1_core_1_1_game_model.html) > | [Models](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#aed5776b214a6846ddba8c95248ae5661) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a3fa5bb2a4ba797da4e305ea7c4ef2726)CampaignGameStarter()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CampaignGameStarter.CampaignGameStarter | ( | [GameMenuManager](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_manager.html) | *gameMenuManager*, |
|  |  | [ConversationManager](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_manager.html) | *conversationManager* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#acd7467d3fa0b1dba0015c44d096ba118)UnregisterNonReadyObjects()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignGameStarter.UnregisterNonReadyObjects | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a9084da834ff5ab1ed2536b28f73c9b1c)AddBehavior()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignGameStarter.AddBehavior | ( | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | *campaignBehavior* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a3b2cd9cf3c0f746a7e10d55e95f37b74)RemoveBehaviors< T >()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignGameStarter.RemoveBehaviors< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html)* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#ac6723360a59e9866d46e3f7c32a99c87)RemoveBehavior< T >()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignGameStarter.RemoveBehavior< T > | ( | T | *behavior* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html)* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a51512df71aa2d5849fe7893b58437684)GetModel< T >()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.CampaignSystem.CampaignGameStarter.GetModel< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *GameModel* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#aa47bcf7387b06718b136637a94a054a5)AddModel()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignGameStarter.AddModel | ( | [GameModel](class_tale_worlds_1_1_core_1_1_game_model.html) | *gameModel* | ) |  |

Implements [TaleWorlds.Core.IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html#a8a464f4ee9c6fa45780cd694fb7c46be).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a2596c0ce5c0288fc3644f830767f5dff)AddModel< T >()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void [TaleWorlds.CampaignSystem.CampaignGameStarter.AddModel](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#aa47bcf7387b06718b136637a94a054a5)< T > | ( | MBGameModel< T > | *gameModel* | ) |  |

Implements [TaleWorlds.Core.IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html#a3c90cb1dfd9823662319796dff95a93c).

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *GameModel* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a7d6d8f13c243dc997280c61ac89a0ad4)AddGameMenu()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignGameStarter.AddGameMenu | ( | string | *menuId*, |
|  |  | string | *menuText*, |
|  |  | [OnInitDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#ae01fba5e92213046937417cfab6b6ef5) | *initDelegate*, |
|  |  | GameMenu.MenuOverlayType | *overlay* = GameMenu::MenuOverlayType::None, |
|  |  | GameMenu.MenuFlags | *menuFlags* = GameMenu::MenuFlags::None, |
|  |  | object | *relatedObject* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a4fb70dacc1c40f58f14b0e8a3fa8863d)AddWaitGameMenu()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignGameStarter.AddWaitGameMenu | ( | string | *idString*, |
|  |  | string | *text*, |
|  |  | [OnInitDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#ae01fba5e92213046937417cfab6b6ef5) | *initDelegate*, |
|  |  | [OnConditionDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#a812ba69ef85df5525f772e2d4ba0158a) | *condition*, |
|  |  | [OnConsequenceDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#a639003d18b3a5d6068698217e0193265) | *consequence*, |
|  |  | [OnTickDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_game_menus.html#a05791a312d92c840f251eb62ab268f51) | *tick*, |
|  |  | GameMenu.MenuAndOptionType | *type*, |
|  |  | GameMenu.MenuOverlayType | *overlay* = GameMenu::MenuOverlayType::None, |
|  |  | float | *targetWaitHours* = 0::0f, |
|  |  | GameMenu.MenuFlags | *flags* = GameMenu::MenuFlags::None, |
|  |  | object | *relatedObject* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a2a548616d5bc2661132d71b88c71b130)AddGameMenuOption()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignGameStarter.AddGameMenuOption | ( | string | *menuId*, |
|  |  | string | *optionId*, |
|  |  | string | *optionText*, |
|  |  | [GameMenuOption.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a67f0448f025b739bc2f931a7eee24b66) | *condition*, |
|  |  | [GameMenuOption.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#afae542885d132e26e2aaae06a63371b3) | *consequence*, |
|  |  | bool | *isLeave* = false, |
|  |  | int | *index* = -1, |
|  |  | bool | *isRepeatable* = false, |
|  |  | object | *relatedObject* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#ada3072cb4f40e563af7082d0067ab3fe)GetPresumedGameMenu()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) TaleWorlds.CampaignSystem.CampaignGameStarter.GetPresumedGameMenu | ( | string | *stringId* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#aab754c4fee64236470009d2fb294667b)AddDialogFlow()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignGameStarter.AddDialogFlow | ( | [DialogFlow](class_tale_worlds_1_1_campaign_system_1_1_dialog_flow.html) | *dialogFlow*, |
|  |  | object | *relatedObject* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#abc007cf84183d0f1a73e0c28a65ba90e)AddPlayerLine()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) TaleWorlds.CampaignSystem.CampaignGameStarter.AddPlayerLine | ( | string | *id*, |
|  |  | string | *inputToken*, |
|  |  | string | *outputToken*, |
|  |  | string | *text*, |
|  |  | [ConversationSentence.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) | *conditionDelegate*, |
|  |  | [ConversationSentence.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) | *consequenceDelegate*, |
|  |  | int | *priority* = [ConversationSentence::DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f), |
|  |  | [ConversationSentence.OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) | *clickableConditionDelegate* = null, |
|  |  | [ConversationSentence.OnPersuasionOptionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a157eab26e34d7aaeaf959d47ce2c3501) | *persuasionOptionDelegate* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#af1cd557ea251cdfd217648c6871b4921)AddRepeatablePlayerLine()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) TaleWorlds.CampaignSystem.CampaignGameStarter.AddRepeatablePlayerLine | ( | string | *id*, |
|  |  | string | *inputToken*, |
|  |  | string | *outputToken*, |
|  |  | string | *text*, |
|  |  | string | *continueListingRepeatedObjectsText*, |
|  |  | string | *continueListingOptionOutputToken*, |
|  |  | [ConversationSentence.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) | *conditionDelegate*, |
|  |  | [ConversationSentence.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) | *consequenceDelegate*, |
|  |  | int | *priority* = [ConversationSentence::DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f), |
|  |  | [ConversationSentence.OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) | *clickableConditionDelegate* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#af9650b1acdc96eafed05dad01432080a)AddDialogLineWithVariation()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) TaleWorlds.CampaignSystem.CampaignGameStarter.AddDialogLineWithVariation | ( | string | *id*, |
|  |  | string | *inputToken*, |
|  |  | string | *outputToken*, |
|  |  | [ConversationSentence.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) | *conditionDelegate*, |
|  |  | [ConversationSentence.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) | *consequenceDelegate*, |
|  |  | int | *priority* = [ConversationSentence::DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f), |
|  |  | string | *idleActionId* = "", |
|  |  | string | *idleFaceAnimId* = "", |
|  |  | string | *reactionId* = "", |
|  |  | string | *reactionFaceAnimId* = "", |
|  |  | [ConversationSentence.OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) | *clickableConditionDelegate* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#ada839c7e59fedd1555ec1fbb160a8875)AddDialogLine()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) TaleWorlds.CampaignSystem.CampaignGameStarter.AddDialogLine | ( | string | *id*, |
|  |  | string | *inputToken*, |
|  |  | string | *outputToken*, |
|  |  | string | *text*, |
|  |  | [ConversationSentence.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) | *conditionDelegate*, |
|  |  | [ConversationSentence.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) | *consequenceDelegate*, |
|  |  | int | *priority* = [ConversationSentence::DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f), |
|  |  | [ConversationSentence.OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) | *clickableConditionDelegate* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#ac92d315373b3a19ed5fe81c570abaca8)AddDialogLineMultiAgent()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ConversationSentence](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html) TaleWorlds.CampaignSystem.CampaignGameStarter.AddDialogLineMultiAgent | ( | string | *id*, |
|  |  | string | *inputToken*, |
|  |  | string | *outputToken*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text*, |
|  |  | [ConversationSentence.OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#affa143751eee3d9c84dcef17852bd697) | *conditionDelegate*, |
|  |  | [ConversationSentence.OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#ac60d040604457b2db55b3919f77e61df) | *consequenceDelegate*, |
|  |  | int | *agentIndex*, |
|  |  | int | *nextAgentIndex*, |
|  |  | int | *priority* = [ConversationSentence::DefaultPriority](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a2e33535700d81b37bfa06a7dfce2343f), |
|  |  | [ConversationSentence.OnClickableConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_sentence.html#a42b13dd4ef66d6c8c42ddbd66927fb91) | *clickableConditionDelegate* = null ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#a0de3c6bec931d807d44c29901df9e1df)CampaignBehaviors
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ICollection<[CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html)> TaleWorlds.CampaignSystem.CampaignGameStarter.CampaignBehaviors | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html#aed5776b214a6846ddba8c95248ae5661)Models
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[GameModel](class_tale_worlds_1_1_core_1_1_game_model.html)> TaleWorlds.CampaignSystem.CampaignGameStarter.Models | | get |

Implements [TaleWorlds.Core.IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html#a1eadb64b62a592bbf440a08a5efcc0c3).


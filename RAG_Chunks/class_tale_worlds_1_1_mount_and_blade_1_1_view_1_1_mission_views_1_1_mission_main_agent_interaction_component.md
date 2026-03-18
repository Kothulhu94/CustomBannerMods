--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html ---

TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [MissionFocusGainedEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a519ae5f492dccd94a3633c3afeb6ad46) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusableObject, bool isInteractable) |
| delegate void | [MissionFocusLostEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a40aec24b8868190d35b131e6e794d74a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusableObject) |
| delegate void | [MissionFocusHealthChangeDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#ab2676f763eb929c2abf3768eb7d50a88) ([IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusable, float healthPercentage, bool hideHealthbarWhenFull) |
| void | [SetCurrentFocusedObject](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#ad1ec76f92b848ecf8a47196143cd5177) ([IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusedObject, [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusedMachine, sbyte focusedObjectBoneIndex, bool isInteractable) |
| void | [ClearFocus](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a36d2d743603b464b1ca6289c939e015f) () |
| void | [OnClearScene](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#aa1fa61a90851d286b5ac635a20fb0ec0) () |
|  | [MissionMainAgentInteractionComponent](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a49fb7e15d444d06c2d4e6a95ee852032) ([MissionMainAgentController](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_controller.html) mainAgentController) |
| void | [FocusTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a86964a4b094a18afbd4f143c3f2df000) () |
| void | [FocusStateCheckTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a050c73aa498c291397bfe89cc3b389f6) () |
| void | [FocusedItemHealthTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#acddeced2afa208bfaceee139aed2a278) () |

|  |  |
| --- | --- |
| Properties | |
| [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | [CurrentFocusedObject](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a0109a9d07f43f885bfc212b5e0fbf0cb) `[get]` |
| [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | [CurrentFocusedMachine](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#abb9423e16d2553c11e94cf0b7fb5e0af) `[get]` |

|  |  |
| --- | --- |
| Events | |
| [MissionFocusGainedEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a519ae5f492dccd94a3633c3afeb6ad46) | [OnFocusGained](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a95ff5a3e04f435b85ffdb64dd0c8831c) |
| [MissionFocusLostEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a40aec24b8868190d35b131e6e794d74a) | [OnFocusLost](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#abb67498a5e856a933a76150b236d9406) |
| [MissionFocusHealthChangeDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#ab2676f763eb929c2abf3768eb7d50a88) | [OnFocusHealthChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a05acab14d7f8a9ad8e3dcfac7ff69be8) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a49fb7e15d444d06c2d4e6a95ee852032)MissionMainAgentInteractionComponent()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.MissionMainAgentInteractionComponent | ( | [MissionMainAgentController](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_controller.html) | *mainAgentController* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a519ae5f492dccd94a3633c3afeb6ad46)MissionFocusGainedEventDelegate()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.MissionFocusGainedEventDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | *focusableObject*, |
|  |  | bool | *isInteractable* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a40aec24b8868190d35b131e6e794d74a)MissionFocusLostEventDelegate()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.MissionFocusLostEventDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | *focusableObject* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#ab2676f763eb929c2abf3768eb7d50a88)MissionFocusHealthChangeDelegate()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.MissionFocusHealthChangeDelegate | ( | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | *focusable*, |
|  |  | float | *healthPercentage*, |
|  |  | bool | *hideHealthbarWhenFull* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#ad1ec76f92b848ecf8a47196143cd5177)SetCurrentFocusedObject()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.SetCurrentFocusedObject | ( | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | *focusedObject*, |
|  |  | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | *focusedMachine*, |
|  |  | sbyte | *focusedObjectBoneIndex*, |
|  |  | bool | *isInteractable* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a36d2d743603b464b1ca6289c939e015f)ClearFocus()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.ClearFocus | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#aa1fa61a90851d286b5ac635a20fb0ec0)OnClearScene()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.OnClearScene | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a86964a4b094a18afbd4f143c3f2df000)FocusTick()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.FocusTick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a050c73aa498c291397bfe89cc3b389f6)FocusStateCheckTick()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.FocusStateCheckTick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#acddeced2afa208bfaceee139aed2a278)FocusedItemHealthTick()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.FocusedItemHealthTick | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a0109a9d07f43f885bfc212b5e0fbf0cb)CurrentFocusedObject
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.CurrentFocusedObject | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#abb9423e16d2553c11e94cf0b7fb5e0af)CurrentFocusedMachine
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.CurrentFocusedMachine | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a95ff5a3e04f435b85ffdb64dd0c8831c)OnFocusGained
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MissionFocusGainedEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a519ae5f492dccd94a3633c3afeb6ad46) TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.OnFocusGained |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#abb67498a5e856a933a76150b236d9406)OnFocusLost
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MissionFocusLostEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a40aec24b8868190d35b131e6e794d74a) TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.OnFocusLost |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#a05acab14d7f8a9ad8e3dcfac7ff69be8)OnFocusHealthChanged
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MissionFocusHealthChangeDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_mission_main_agent_interaction_component.html#ab2676f763eb929c2abf3768eb7d50a88) TaleWorlds.MountAndBlade.View.MissionViews.MissionMainAgentInteractionComponent.OnFocusHealthChanged |


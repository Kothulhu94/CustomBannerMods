--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_scene_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SceneModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSceneModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_scene_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| string | [GetConversationSceneForMapPosition](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_scene_model.html#a419fc1504b98298ad244613bf969620a) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) campaignPosition) |
| string | [GetBattleSceneForMapPatch](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_scene_model.html#ae704ec3f6bc9152f94d880805d223683) ([MapPatchData](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_patch_data.html) mapPatch, bool isNavalEncounter) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_scene_model.html#a419fc1504b98298ad244613bf969620a)GetConversationSceneForMapPosition()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.SceneModel.GetConversationSceneForMapPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *campaignPosition* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_scene_model.html#ae704ec3f6bc9152f94d880805d223683)GetBattleSceneForMapPatch()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.SceneModel.GetBattleSceneForMapPatch | ( | [MapPatchData](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_patch_data.html) | *mapPatch*, | |  |  | bool | *isNavalEncounter* ) | | abstract |


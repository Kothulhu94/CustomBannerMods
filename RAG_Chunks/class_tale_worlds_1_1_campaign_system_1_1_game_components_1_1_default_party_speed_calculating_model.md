--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_speed_calculating_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPartySpeedCalculatingModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PartySpeedModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_speed_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateBaseSpeed](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_speed_calculating_model.html#acc4cd985f6963160ca827dfa9e29b774) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, bool includeDescriptions=false, int additionalTroopOnFootCount=0, int additionalTroopOnHorseCount=0) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateFinalSpeed](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_speed_calculating_model.html#af598bdaf8a282fb8a7c253324fd60d41) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) finalSpeed) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartySpeedModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_speed_model.html) | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateBaseSpeed](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_speed_model.html#a9a15debfc8f1b8ee029fc78bd0aade54) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool includeDescriptions=false, int additionalTroopOnFootCount=0, int additionalTroopOnHorseCount=0) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateFinalSpeed](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_speed_model.html#aafec4966b8e6aec20bf9ce2409b116ca) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) finalSpeed) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override float | [BaseSpeed](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_speed_calculating_model.html#a9c63995afb5b8df9346411390041a2be) `[get]` |
| override float | [MinimumSpeed](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_speed_calculating_model.html#a8af9d749346334978b7e8e5912d77b69) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartySpeedModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_speed_model.html) | |
| float | [BaseSpeed](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_speed_model.html#ac00204e2e0523bbeaf31f474ba0964c9) `[get]` |
| float | [MinimumSpeed](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_speed_model.html#a203fd55385d7463897f9044bf0dc037a) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_speed_calculating_model.html#acc4cd985f6963160ca827dfa9e29b774)CalculateBaseSpeed()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartySpeedCalculatingModel.CalculateBaseSpeed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | bool | *includeDescriptions* = false, |
|  |  | int | *additionalTroopOnFootCount* = 0, |
|  |  | int | *additionalTroopOnHorseCount* = 0 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_speed_calculating_model.html#af598bdaf8a282fb8a7c253324fd60d41)CalculateFinalSpeed()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartySpeedCalculatingModel.CalculateFinalSpeed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *finalSpeed* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_speed_calculating_model.html#a9c63995afb5b8df9346411390041a2be)BaseSpeed
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartySpeedCalculatingModel.BaseSpeed | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_speed_calculating_model.html#a8af9d749346334978b7e8e5912d77b69)MinimumSpeed
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartySpeedCalculatingModel.MinimumSpeed | | get |


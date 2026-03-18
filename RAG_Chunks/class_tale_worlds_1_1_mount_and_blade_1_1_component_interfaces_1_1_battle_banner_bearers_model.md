--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html ---

TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [SandBox.SandboxBattleBannerBearersModel](class_sand_box_1_1_sandbox_battle_banner_bearers_model.html), [TaleWorlds.MountAndBlade.CustomBattleBannerBearersModel](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_banner_bearers_model.html), and [TaleWorlds.MountAndBlade.MultiplayerBattleBannerBearersModel](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_battle_banner_bearers_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [InitializeModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#af18c8ef3de50a00f3dc29bcb07002b4b) ([BannerBearerLogic](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a4c10b14b891e6f9c3a1d271a7afe0d92) bannerBearerLogic) |
| void | [FinalizeModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a414893d8fdbf71223bdf049b7cc7c7e6) () |
| bool | [IsFormationBanner](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#aa32fcda8525c4917b6ad0874b5feb46f) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) item) |
| bool | [IsBannerSearchingAgent](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#aa13c9668a2a4a55ab750dbfb0a0c9407) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| bool | [IsInteractableFormationBanner](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#ae3e211cf1b8712b52c4989bb9ce70b30) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) item, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) interactingAgent) |
| bool | [HasFormationBanner](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#adc934832c81f86d41ee8b8ee2c3d94ca) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| bool | [HasBannerOnGround](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a867e2a2e65c08bfb812ca5e579ac92a5) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetFormationBanner](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a1530c1b09e92f603b4764b603caa7404) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | [GetFormationBannerBearers](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#ad49fa887f828363aac565bafdc51c32c) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| [BannerComponent](class_tale_worlds_1_1_core_1_1_banner_component.html) | [GetActiveBanner](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a9884ebeeb384b011c037fa0eb4befd4c) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| int | [GetMinimumFormationTroopCountToBearBanners](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a83e3adaa6e94e4bce4f709053a929a7f) () |
| float | [GetBannerInteractionDistance](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#ac367310d8cca3e724f513d6585655e4c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) interactingAgent) |
| bool | [CanBannerBearerProvideEffectToFormation](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a668aca0a4314d9a77143f9e501ded36f) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| bool | [CanAgentPickUpAnyBanner](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a6ebe1f86df41dfd08a3571a17287fe95) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| bool | [CanAgentBecomeBannerBearer](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#ad114e465152a8eb971fd66a4bf873270) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| int | [GetAgentBannerBearingPriority](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a10cd8a913c618207ee92d09bd6dea85c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| bool | [CanFormationDeployBannerBearers](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a3b5b857bf8918b9310d21a6ea391cb1c) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| int | [GetDesiredNumberOfBannerBearersForFormation](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a115b2e61f22170b47047c5003a8b6501) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetBannerBearerReplacementWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a5c345a54a55798bb74a0fe9bcba194b2) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) agentCharacter) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [DefaultDetachmentCostMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a337261d4f9852686a445096d93949566) = 10f |

|  |  |
| --- | --- |
| Properties | |
| BannerBearerLogic | [BannerBearerLogic](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a4c10b14b891e6f9c3a1d271a7afe0d92) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#af18c8ef3de50a00f3dc29bcb07002b4b)InitializeModel()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.InitializeModel | ( | [BannerBearerLogic](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a4c10b14b891e6f9c3a1d271a7afe0d92) | *bannerBearerLogic* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a414893d8fdbf71223bdf049b7cc7c7e6)FinalizeModel()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.FinalizeModel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#aa32fcda8525c4917b6ad0874b5feb46f)IsFormationBanner()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.IsFormationBanner | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, |
|  |  | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *item* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#aa13c9668a2a4a55ab750dbfb0a0c9407)IsBannerSearchingAgent()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.IsBannerSearchingAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#ae3e211cf1b8712b52c4989bb9ce70b30)IsInteractableFormationBanner()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.IsInteractableFormationBanner | ( | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *item*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *interactingAgent* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#adc934832c81f86d41ee8b8ee2c3d94ca)HasFormationBanner()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.HasFormationBanner | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a867e2a2e65c08bfb812ca5e579ac92a5)HasBannerOnGround()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.HasBannerOnGround | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a1530c1b09e92f603b4764b603caa7404)GetFormationBanner()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.GetFormationBanner | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#ad49fa887f828363aac565bafdc51c32c)GetFormationBannerBearers()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.GetFormationBannerBearers | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a9884ebeeb384b011c037fa0eb4befd4c)GetActiveBanner()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BannerComponent](class_tale_worlds_1_1_core_1_1_banner_component.html) TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.GetActiveBanner | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a83e3adaa6e94e4bce4f709053a929a7f)GetMinimumFormationTroopCountToBearBanners()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.GetMinimumFormationTroopCountToBearBanners | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#ac367310d8cca3e724f513d6585655e4c)GetBannerInteractionDistance()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.GetBannerInteractionDistance | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *interactingAgent* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a668aca0a4314d9a77143f9e501ded36f)CanBannerBearerProvideEffectToFormation()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.CanBannerBearerProvideEffectToFormation | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a6ebe1f86df41dfd08a3571a17287fe95)CanAgentPickUpAnyBanner()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.CanAgentPickUpAnyBanner | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#ad114e465152a8eb971fd66a4bf873270)CanAgentBecomeBannerBearer()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.CanAgentBecomeBannerBearer | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a10cd8a913c618207ee92d09bd6dea85c)GetAgentBannerBearingPriority()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.GetAgentBannerBearingPriority | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a3b5b857bf8918b9310d21a6ea391cb1c)CanFormationDeployBannerBearers()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.CanFormationDeployBannerBearers | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a115b2e61f22170b47047c5003a8b6501)GetDesiredNumberOfBannerBearersForFormation()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.GetDesiredNumberOfBannerBearersForFormation | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a5c345a54a55798bb74a0fe9bcba194b2)GetBannerBearerReplacementWeapon()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.GetBannerBearerReplacementWeapon | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *agentCharacter* | ) |  | | abstract |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a337261d4f9852686a445096d93949566)DefaultDetachmentCostMultiplier
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.DefaultDetachmentCostMultiplier = 10f | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_banner_bearers_model.html#a4c10b14b891e6f9c3a1d271a7afe0d92)BannerBearerLogic
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | BannerBearerLogic TaleWorlds.MountAndBlade.ComponentInterfaces.BattleBannerBearersModel.BannerBearerLogic | | getprotected |


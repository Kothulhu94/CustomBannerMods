--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_xp_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultCombatXpModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.CombatXpModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [GetSkillForWeapon](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_xp_model.html#a9447d6d39a7889a1b48520a978164270) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon, bool isSiegeEngineHit) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetXpFromHit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_xp_model.html#a7e4e365eab3692d6b8368783fbe3d45b) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) attackerTroop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) captain, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) attackedTroop, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, int damage, bool isFatal, [MissionTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645) missionType) |
| override float | [GetXpMultiplierFromShotDifficulty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_xp_model.html#ad76e3f402000313332004f9411766fe8) (float shotDifficulty) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.CombatXpModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html) | |
| [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [GetSkillForWeapon](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#ad2deac9e2f8b5737ac7e6f514ab6e129) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon, bool isSiegeEngineHit) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetXpFromHit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a4f0e80af2b56310848112eb5132ec38f) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) attackerTroop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) captain, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) attackedTroop, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, int damage, bool isFatal, [MissionTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645) missionType) |
| float | [GetXpMultiplierFromShotDifficulty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#aa9c0219b027ab75a7617e7c00b677f20) (float shotDifficulty) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override float | [CaptainRadius](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_xp_model.html#a341fd77cb5261295121cd031f0000751) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.CombatXpModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html) | |
| float | [CaptainRadius](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a455e955039f67ceaa40ec76d5276c880) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.CombatXpModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html) | |
| enum | [MissionTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645) {     [Battle](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645a747d99f92ee9c080ba26108ac5d26488) ,     [PracticeFight](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645a9f7cd1206102ba800b631edc64c22bb3) ,     [Tournament](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645a4f4dc29df9d29cbec61a725ff3ce6e72) ,     [SimulationBattle](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645ad4a55fba43fbf31140bdae6fc2c41ba1) ,     [NoXp](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645a1333da4a60d9dd07515a984cb6fae064)   } |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_xp_model.html#a9447d6d39a7889a1b48520a978164270)GetSkillForWeapon()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) TaleWorlds.CampaignSystem.GameComponents.DefaultCombatXpModel.GetSkillForWeapon | ( | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon*, |
|  |  | bool | *isSiegeEngineHit* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_xp_model.html#a7e4e365eab3692d6b8368783fbe3d45b)GetXpFromHit()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultCombatXpModel.GetXpFromHit | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *attackerTroop*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *captain*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *attackedTroop*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, |
|  |  | int | *damage*, |
|  |  | bool | *isFatal*, |
|  |  | [MissionTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645) | *missionType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_xp_model.html#ad76e3f402000313332004f9411766fe8)GetXpMultiplierFromShotDifficulty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultCombatXpModel.GetXpMultiplierFromShotDifficulty | ( | float | *shotDifficulty* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_xp_model.html#a341fd77cb5261295121cd031f0000751)CaptainRadius
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultCombatXpModel.CaptainRadius | | get |


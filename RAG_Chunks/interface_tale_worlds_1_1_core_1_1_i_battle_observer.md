--- SOURCE: interface_tale_worlds_1_1_core_1_1_i_battle_observer.html ---

TaleWorlds.Core.IBattleObserver Interface ReferenceInherited by [SandBox.ViewModelCollection.SPScoreboardVM](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html), [TaleWorlds.CampaignSystem.BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html), and [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.CustomBattleScoreboardVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_custom_battle_scoreboard_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [TroopNumberChanged](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#af10c1c0878a63c6fc7d3b56358d4c594) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) battleCombatant, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, int number=0, int numberKilled=0, int numberWounded=0, int numberRouted=0, int killCount=0, int numberReadyToUpgrade=0) |
| void | [TroopSideChanged](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#a58b7b9b97ba5d1430d94acab50fb2ce4) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) prevSide, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) newSide, [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) battleCombatant, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character) |
| void | [HeroSkillIncreased](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#ae015cd21dd8db68daccd3d8063afd438) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) battleCombatant, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) heroCharacter, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| void | [BattleResultsReady](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#ae7cfdfa6581d02c9cefc23937d32cdbd) () |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#af10c1c0878a63c6fc7d3b56358d4c594)TroopNumberChanged()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.IBattleObserver.TroopNumberChanged | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | *battleCombatant*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, |
|  |  | int | *number* = 0, |
|  |  | int | *numberKilled* = 0, |
|  |  | int | *numberWounded* = 0, |
|  |  | int | *numberRouted* = 0, |
|  |  | int | *killCount* = 0, |
|  |  | int | *numberReadyToUpgrade* = 0 ) |

Implemented in [SandBox.ViewModelCollection.SPScoreboardVM](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a0f6bc2cd240a7faddb4190858f207c38), [TaleWorlds.CampaignSystem.BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a4c634ae77f6a99b60da524e4ab6833ef), and [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.CustomBattleScoreboardVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_custom_battle_scoreboard_v_m.html#a5972a9c3fac5ed18f167d35fa17cc626).

[◆](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#a58b7b9b97ba5d1430d94acab50fb2ce4)TroopSideChanged()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.IBattleObserver.TroopSideChanged | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *prevSide*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *newSide*, |
|  |  | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | *battleCombatant*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character* ) |

Implemented in [SandBox.ViewModelCollection.SPScoreboardVM](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a1d5c22b5dada331b71e853a476a12046), [TaleWorlds.CampaignSystem.BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a6d0afe8801d6164f1479000c721bfbe3), and [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.CustomBattleScoreboardVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_custom_battle_scoreboard_v_m.html#ab9c1c3f9e2c45f9a14a17ed9b64b9892).

[◆](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#ae015cd21dd8db68daccd3d8063afd438)HeroSkillIncreased()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.IBattleObserver.HeroSkillIncreased | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | *battleCombatant*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *heroCharacter*, |
|  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* ) |

Implemented in [SandBox.ViewModelCollection.SPScoreboardVM](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a7e9a256975c32a3485f99996f757a8c7), [TaleWorlds.CampaignSystem.BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a6ffe2bac90873e5db5c1daf27ed08a71), and [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.CustomBattleScoreboardVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_custom_battle_scoreboard_v_m.html#aaed9df1a3fba8ee7bb372e2e17411b15).

[◆](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#ae7cfdfa6581d02c9cefc23937d32cdbd)BattleResultsReady()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.IBattleObserver.BattleResultsReady | ( |  | ) |  |

Implemented in [SandBox.ViewModelCollection.SPScoreboardVM](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a0c990414d31b11cf275ab4852612eb93), [TaleWorlds.CampaignSystem.BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a40f35bf945288c3d86273040847bb469), and [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.CustomBattleScoreboardVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_custom_battle_scoreboard_v_m.html#afbdb76dbd3d2609390759da90e6cee29).


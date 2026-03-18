--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html ---

TaleWorlds.CampaignSystem.BattleSimulation Class ReferenceThis class will handle all battle simulations (normal battle, siege etc) where the player choose to order his troops to attack while the hero stays back.

Inherits [TaleWorlds.Core.IBattleObserver](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a6b7cf7baef5e781e2ca17ba54c8f3e59) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) selectedTroopsForPlayerSide, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) selectedTroopsForOtherSide) |
| void | [Play](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#aa4d1ed8cd083e2df8ccbd2d457d8bd45) () |
| void | [FastForward](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#ac20a6d4dbd76d1475d2a1e546fb29ddf) () |
| void | [Skip](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#aa276985bce0fee57b4a7b58a6d8922c3) () |
| void | [Pause](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a82c38de6f9e7de6fc5d0bc08a1df272a) () |
| void | [OnFinished](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#ac73e14d3fbf617f2bf477d0d2676e7ef) () |
| void | [OnPlayerRetreat](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#ae88ef5b37dad900636f45fe8b4b12b11) () |
| void | [Tick](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a4479afd27be0111c46be3480d7423332) (float dt) |
| void | [ResetSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a7319bc04c1487925c69b065c8968dba6) () |
| void | [TroopNumberChanged](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a4c634ae77f6a99b60da524e4ab6833ef) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) battleCombatant, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, int number=0, int numberKilled=0, int numberWounded=0, int numberRouted=0, int killCount=0, int numberReadyToUpgrade=0) |
| void | [HeroSkillIncreased](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a6ffe2bac90873e5db5c1daf27ed08a71) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) battleCombatant, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) heroCharacter, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| void | [BattleResultsReady](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a40f35bf945288c3d86273040847bb469) () |
| void | [TroopSideChanged](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a6d0afe8801d6164f1479000c721bfbe3) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) prevSide, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) newSide, [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) battleCombatant, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html)[] | [SelectedTroops](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a7e9ab2ea37fafd5caa83519d23ffbcb1) = new [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html)[2] |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsSimulationFinished](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#aeae22b37ee5721e5214c72669cd40059) `[get]` |
| MapEvent | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a60b61c24a3a9c1804dd48caf04a0165f) `[get]` |
| bool | [IsPlayerRetreated](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a0837dcb5cf06bee4071d0f5b15780fe5) `[get]` |
| [IBattleObserver](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html) | [BattleObserver](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#ac1355c117ec4f8c54c2f2fff09cb6ab3) `[get, set]` |
| List< List< [BattleResultPartyData](struct_tale_worlds_1_1_campaign_system_1_1_battle_result_party_data.html) > > | [Teams](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#acd1a7855e887e1f77107c0293cbd95e0) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a6b7cf7baef5e781e2ca17ba54c8f3e59)BattleSimulation()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.BattleSimulation.BattleSimulation | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *selectedTroopsForPlayerSide*, |
|  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *selectedTroopsForOtherSide* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#aa4d1ed8cd083e2df8ccbd2d457d8bd45)Play()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BattleSimulation.Play | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#ac20a6d4dbd76d1475d2a1e546fb29ddf)FastForward()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BattleSimulation.FastForward | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#aa276985bce0fee57b4a7b58a6d8922c3)Skip()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BattleSimulation.Skip | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a82c38de6f9e7de6fc5d0bc08a1df272a)Pause()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BattleSimulation.Pause | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#ac73e14d3fbf617f2bf477d0d2676e7ef)OnFinished()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BattleSimulation.OnFinished | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#ae88ef5b37dad900636f45fe8b4b12b11)OnPlayerRetreat()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BattleSimulation.OnPlayerRetreat | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a4479afd27be0111c46be3480d7423332)Tick()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BattleSimulation.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a7319bc04c1487925c69b065c8968dba6)ResetSimulation()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BattleSimulation.ResetSimulation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a4c634ae77f6a99b60da524e4ab6833ef)TroopNumberChanged()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BattleSimulation.TroopNumberChanged | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | *battleCombatant*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, |
|  |  | int | *number* = 0, |
|  |  | int | *numberKilled* = 0, |
|  |  | int | *numberWounded* = 0, |
|  |  | int | *numberRouted* = 0, |
|  |  | int | *killCount* = 0, |
|  |  | int | *numberReadyToUpgrade* = 0 ) |

Implements [TaleWorlds.Core.IBattleObserver](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#af10c1c0878a63c6fc7d3b56358d4c594).

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a6ffe2bac90873e5db5c1daf27ed08a71)HeroSkillIncreased()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BattleSimulation.HeroSkillIncreased | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | *battleCombatant*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *heroCharacter*, |
|  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* ) |

Implements [TaleWorlds.Core.IBattleObserver](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#ae015cd21dd8db68daccd3d8063afd438).

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a40f35bf945288c3d86273040847bb469)BattleResultsReady()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BattleSimulation.BattleResultsReady | ( |  | ) |  |

Implements [TaleWorlds.Core.IBattleObserver](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#ae7cfdfa6581d02c9cefc23937d32cdbd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a6d0afe8801d6164f1479000c721bfbe3)TroopSideChanged()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BattleSimulation.TroopSideChanged | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *prevSide*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *newSide*, |
|  |  | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | *battleCombatant*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character* ) |

Implements [TaleWorlds.Core.IBattleObserver](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#a58b7b9b97ba5d1430d94acab50fb2ce4).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a7e9ab2ea37fafd5caa83519d23ffbcb1)SelectedTroops
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) [] TaleWorlds.CampaignSystem.BattleSimulation.SelectedTroops = new [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html)[2] |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#aeae22b37ee5721e5214c72669cd40059)IsSimulationFinished
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.BattleSimulation.IsSimulationFinished | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a60b61c24a3a9c1804dd48caf04a0165f)MapEvent
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapEvent TaleWorlds.CampaignSystem.BattleSimulation.MapEvent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#a0837dcb5cf06bee4071d0f5b15780fe5)IsPlayerRetreated
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.BattleSimulation.IsPlayerRetreated | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#ac1355c117ec4f8c54c2f2fff09cb6ab3)BattleObserver
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IBattleObserver](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html) TaleWorlds.CampaignSystem.BattleSimulation.BattleObserver | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html#acd1a7855e887e1f77107c0293cbd95e0)Teams
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<List<[BattleResultPartyData](struct_tale_worlds_1_1_campaign_system_1_1_battle_result_party_data.html)> > TaleWorlds.CampaignSystem.BattleSimulation.Teams | | get |


--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html ---

SandBox.ViewModelCollection.SPScoreboardVM Class ReferenceInherits [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html), and [TaleWorlds.Core.IBattleObserver](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SPScoreboardVM](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#ac8f35d95875229deb1c70469d8b99103) ([BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html) simulation) |
| override void | [Initialize](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a54a652d4cb642708e47782c8bf5c097e) ([IMissionScreen](interface_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_i_mission_screen.html) missionScreen, [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, Action releaseSimulationSources, Action< bool > onToggle) |
| override void | [ExecutePlayAction](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a5d763529f33a80a877cf0510d941e0e2) () |
| override void | [ExecuteFastForwardAction](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a37c6ef23be4d927c7c83cb3ca2cf33e4) () |
| override void | [ExecutePauseSimulationAction](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a640501eac7758e68a34accfd5f616479) () |
| override void | [ExecuteEndSimulationAction](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a74b95d198f3b4f76e1685bfa16ccf3ec) () |
| override void | [ExecuteQuitAction](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a6be2a948a60a137398f1f2474756da19) () |
| void | [OnBattleOver](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a07db5b8b1080e5a64dfd4dd4b0c39eae) () |
| void | [OnExitBattle](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#ad5f5d04fd534a0563b2fa80bc4dc9925) () |
| void | [TroopNumberChanged](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a0f6bc2cd240a7faddb4190858f207c38) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) battleCombatant, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, int number=0, int numberDead=0, int numberWounded=0, int numberRouted=0, int numberKilled=0, int numberReadyToUpgrade=0) |
| void | [HeroSkillIncreased](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a7e9a256975c32a3485f99996f757a8c7) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) battleCombatant, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) heroCharacter, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) upgradedSkill) |
| void | [BattleResultsReady](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a0c990414d31b11cf275ab4852612eb93) () |
| void | [TroopSideChanged](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a1d5c22b5dada331b71e853a476a12046) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) prevSide, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) newSide, [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) battleCombatant, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html) | |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a31cecf7feb39dcfd3d2cf873e34ee705) () |
|  | Used for updating localized texts. |
| void | [OnMainHeroDeath](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#aef486ff28f43416a0d0712a42e06b8fa) () |
| void | [OnTakenControlOfAnotherAgent](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a449cc0b3908e58b1bd2e4800c6e1067a) () |
| virtual void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#ac502a99382af1cb92e76fa2993dd8f7c) () |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a708886e1752afc7beaab8ecdd196e1b4) (float dt) |
| void | [SetMouseState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a8b6d25612df68effd252104deede9a42) (bool visible) |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a84ba71ae9ce36e2cbb1845402277a6a8) () |
| virtual void | [ExecuteShowScoreboardAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a4a4f79461fce397788cd8322103bb2f5) () |
| virtual void | [SetShortcuts](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a94fd08cebf987b61f48adefb4d8b9b2e) ([ScoreboardHotkeys](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_hotkeys.html) shortcuts) |
| Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| void | [OnPropertyChanged](class_tale_worlds_1_1_library_1_1_view_model.html#a1a9dee9bab5986a33083d31a689dc7fe) ([CallerMemberName] string propertyName=null) |
|  | Method for notifying binded views about the changes in a property. Uses reflection to get the value of the property. If reflection is not needed or updated value of the property is already known, use [OnPropertyChangedWithValue()](class_tale_worlds_1_1_library_1_1_view_model.html#a0d6928eeec2b43ac9ae089830783bd7f) instead. |
| void | [OnPropertyChangedWithValue< T >](class_tale_worlds_1_1_library_1_1_view_model.html#ae5000d209ee6d4e7baec2fa8e8803c7e) (T value, [CallerMemberName]string propertyName=null) |
|  | Faster method for notifying binded views about the changes in a property. To avoid reflection, caller can pass changed value to this method. If caller does not have access rights to the value, use [OnPropertyChanged()](class_tale_worlds_1_1_library_1_1_view_model.html#a1a9dee9bab5986a33083d31a689dc7fe "Method for notifying binded views about the changes in a property. Uses reflection to get the value o...") instead. |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a0d6928eeec2b43ac9ae089830783bd7f) (bool value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#abf208d3c50803f5d1f70fa658c21dc96) (int value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a991eb5001ba6210a9fefb4a69f8883c2) (float value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#ac54722f74e27aa6143d62a9dc589fb95) (uint value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a62ff1ab710820c9583a4b6ee66bb05e8) ([Color](struct_tale_worlds_1_1_library_1_1_color.html) value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#adb40c37120d9480a9c61934104b3b0ee) (double value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3298a1b9a60a7057cac4df839915f49d) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) value, [CallerMemberName] string propertyName=null) |
| object | [GetViewModelAtPath](class_tale_worlds_1_1_library_1_1_view_model.html#adab1a5fac562c67766ef900113c2fd48) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) path, bool isList) |
| object | [GetViewModelAtPath](class_tale_worlds_1_1_library_1_1_view_model.html#a58ad0a333f63aeb396cf0282a65b3b73) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) path) |
| object | [GetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#a870f5daf5e6f307138260ee84406bd4e) (string name, [PropertyTypeFeeder](namespace_tale_worlds_1_1_library.html#a74850bfe0b5488f44574810b7462b0f7) propertyTypeFeeder) |
| object | [GetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#a6c761a8baf9a75c1d8fd65dbaed24055) (string name) |
| Type | [GetPropertyType](class_tale_worlds_1_1_library_1_1_view_model.html#ade14a4f33f7022fa0b20393db6e5f1b1) (string name) |
| void | [SetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#ad53397f315ef866a738a5e65556043df) (string name, object value) |
| void | [ExecuteCommand](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb) (string commandName, object[] parameters) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [UpdateQuitText](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a2f64b0315874aff1f5a0cd1b8ef92ab5) () |
| override void | [OnTick](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#aba7b8366ba08c3fc39c111487e21b127) (float dt) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html) | |
| virtual bool | [IsPowerComparerRelevant](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#aea27d849d60ebcb3f0dccc0914c1a2bc) () |
| void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#aa57b2ad87f1609797426741dcc9000ed) (float dt) |
| [SPScoreboardSideVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_side_v_m.html) | [GetSide](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a358903a4e3978d0ec7d840403549eba9) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| float | [GetBattleMoraleOfSide](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a709b608064e018e7c738ac5e6c1af9d4) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Properties | |
| override MBBindingList< [BattleResultVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_battle_result_v_m.html) > | [BattleResults](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a60f331a6f73b102eb5f4e200ff298e6f) `[get, set]` |
| Properties inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html) | |
| int | [MissionTimeInSeconds](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a278490499297592bd99ca97739d075da) `[get, set]` |
| string | [MissionTimeStr](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a928676246a70795267b0488aa83372ad) `[get, set]` |
| bool | [IsPowerComparerEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#ac5751b20df467dafc20f31525724829d) `[get, set]` |
| string | [QuitText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a004e673d2fb97ad6431e098d9df1ff8e) `[get, set]` |
| string | [ShowScoreboardText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a0409ef31789c5f8f41d5b1b6fc9f5941) `[get, set]` |
| string | [FastForwardText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#ae650b6355122b5e167b83e6554ee514b) `[get, set]` |
| string | [MoraleText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a99eb9a7f6a595731d35f91b3e13b3596) `[get, set]` |
| [SPScoreboardSideVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_side_v_m.html) | [Attackers](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a428ecfcaace6930f5b2affab8afe75a6) `[get, set]` |
| [SPScoreboardSideVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_side_v_m.html) | [Defenders](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a3557098af001ebd734db50419bf2bd88) `[get, set]` |
| [SPScoreboardSideVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_s_p_scoreboard_side_v_m.html) | [NeutralTroops](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#adb5ec09806eb62122ea3d460a5718f90) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [KillHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a6615b0db1e405f14ca4b045df8e43d03) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DeadHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#afa28bcf13f9c2995cffd8b7dcbe394b1) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [UpgradeHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a31ab4ece485a59ddf5f3a1565e53d227) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [WoundedHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a01b8c23d3dc431cd2d747a1185c25037) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RoutedHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#aeca80f25a8fca5ae33706eedeb7c9edf) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RemainingHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#ab1902d39c4e90b8c4f0c84b1ea984185) `[get, set]` |
| int | [BattleResultIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a18a48723e1d43c0210853477e114d919) `[get, set]` |
| string | [BattleResult](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a9dbb469687e02f2ebb3b8e97ac837fdb) `[get, set]` |
| bool | [IsMouseEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a5db335142d284facafbd0a39149b3986) `[get, set]` |
| bool | [IsOver](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#aefce6e54de35ce145e3cb14641495012) `[get, set]` |
| string | [SimulationResult](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a603ab03602fcfd652949747ac67ea4a0) `[get, set]` |
| bool | [IsMainCharacterDead](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#ab8ae1b05f570dd3b7cefba919f6e8ea5) `[get, set]` |
| bool | [ShowScoreboard](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#ae29da65d7530c7edf7641d040330ca6f) `[get, set]` |
| bool | [IsSimulation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a5868e8e88f8e4f92820eebac3a2a092f) `[get, set]` |
| bool | [IsNavalBattle](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a70476ed6eaceb4a5d7bca60a844c2548) `[get, set]` |
| bool | [IsFastForwarding](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a0a3863fdc15304dbec9f77f9de69d5f2) `[get, set]` |
| bool | [IsPaused](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#af8f104e904f424f36f5e8fe0a82be487) `[get, set]` |
| [PowerLevelComparer](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_power_level_comparer.html) | [PowerComparer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a07231e219258cba5fd54474e846481cf) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ShowMouseKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#af0b40877196b1c200d3a1ef7fe28040d) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ShowScoreboardKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a76e71b63c7e47dd6c0bd05402d92ebbb) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a3ad873f79b3d731fb1afbbfdbc63a7f3) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [FastForwardKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a88c7a6f12458a8376859ad87546dee51) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [PauseInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a48ad42028ce4e8c39f78034cc4137e3a) `[get, set]` |
| virtual MBBindingList< [BattleResultVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_battle_result_v_m.html) > | [BattleResults](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a6695322d4b73d79ac2b462922805f069) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html) | |
| enum | [Categories](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a4f117e18819ec38555e0c7640fc1722c) {     [Party](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a4f117e18819ec38555e0c7640fc1722ca094a173d3b32f44f5b5c996e8710ae28) = 0 ,     [Tactical](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a4f117e18819ec38555e0c7640fc1722ca4e0619e57cb50c4ab1230c2dd72df1ba) ,     [NumOfCategories](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a4f117e18819ec38555e0c7640fc1722ca93c6aeb7f892055eabf6ad91bfdef403)   } |
| Static Public Member Functions inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html) | |
| static string | [GetFormattedTimeTextFromSeconds](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#adfd5bb443ba9cbe7b6d5c341b7e1003e) (int seconds) |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Protected Types inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html) | |
| enum | [BattleResultType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a895fa69a9e5713f290913acadb1705fc) {     [NotOver](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a895fa69a9e5713f290913acadb1705fca97a1fa1357e2f375bc607d97b2bc0973) = -1 ,     [Defeat](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a895fa69a9e5713f290913acadb1705fca570e9d24849e2161b5a969599fb03446) = 0 ,     [Victory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a895fa69a9e5713f290913acadb1705fca1f5c647d9066bc9e350b70aa2d16aec4) = 1 ,     [Retreat](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a895fa69a9e5713f290913acadb1705fca008bec353de180da9782954e7a1374e6) = 2   } |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html) | |
| Action | [OnFastForwardIncreaseSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a3ecba785313a9fda7da15b8849d2f850) |
| Action | [OnFastForwardDecreaseSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#aa9da71e10e6b5e75af3f4e88b6b0d2b6) |
| Action | [OnFastForwardResetSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a6ca6794cf0254d9c5d3017c846fbea60) |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [PlayerSide](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#ad59d425b3426686366b4795caf7c27bf) |
| [IMissionScreen](interface_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_i_mission_screen.html) | [\_missionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a2674684814ffcf942690ed57915d2168) |
| [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | [\_mission](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a388f581644df23e43cf3dd915b9767f8) |
| [BattleEndLogic](class_tale_worlds_1_1_mount_and_blade_1_1_battle_end_logic.html) | [\_battleEndLogic](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a19423a7bd7b8a322644c7e4655de31bf) |
| [InquiryData](class_tale_worlds_1_1_library_1_1_inquiry_data.html) | [\_retreatInquiryData](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a41995e8cf17e933db9d078a1089cbdb3) |
| Action | [\_releaseSimulationSources](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#adf8a42f703c65eddd53804f8c0d32580) |
| Action< bool > | [OnToggle](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#ae49ed507d9446386d364d60400252132) |
| Static Protected Attributes inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html) | |
| const float | [MissionEndScoreboardDelayTime](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a27ee1906fbdf633a08e80373a7c2dcd8) = 1.5f |
| Events inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| PropertyChangedEventHandler | [PropertyChanged](class_tale_worlds_1_1_library_1_1_view_model.html#a7f8d83700f17f8092632c1eaa406d665) `[add, remove]` |
| [PropertyChangedWithValueEventHandler](namespace_tale_worlds_1_1_library.html#aa511552e184232616e64f386cf1146b5) | [PropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#acad8d628c31163e3022bea1e04675de6) `[add, remove]` |
| [PropertyChangedWithBoolValueEventHandler](namespace_tale_worlds_1_1_library.html#a6b0d7e614739868a8f81c53a64f081bd) | [PropertyChangedWithBoolValue](class_tale_worlds_1_1_library_1_1_view_model.html#a4d3b2d6f05fc919dca9e764b9e36af5d) `[add, remove]` |
| [PropertyChangedWithIntValueEventHandler](namespace_tale_worlds_1_1_library.html#a91bc6d8c78c447d9acf86771f3b3e932) | [PropertyChangedWithIntValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3b31df15300b9652b9b5f664e03a5af9) `[add, remove]` |
| [PropertyChangedWithFloatValueEventHandler](namespace_tale_worlds_1_1_library.html#aa44f77d2af0c3adb609a79640e080914) | [PropertyChangedWithFloatValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3cb9bd971256835c5f6169cb58d67470) `[add, remove]` |
| [PropertyChangedWithUIntValueEventHandler](namespace_tale_worlds_1_1_library.html#aec7149fde7f195f3c4b4f10c4ce23cb8) | [PropertyChangedWithUIntValue](class_tale_worlds_1_1_library_1_1_view_model.html#a197c48c4f8ba00372fc86a548ccb86f7) `[add, remove]` |
| [PropertyChangedWithColorValueEventHandler](namespace_tale_worlds_1_1_library.html#a90de79687e9792b5065a8a4e9c30eeac) | [PropertyChangedWithColorValue](class_tale_worlds_1_1_library_1_1_view_model.html#aea6e76a6562fbdf20688565257699162) `[add, remove]` |
| [PropertyChangedWithDoubleValueEventHandler](namespace_tale_worlds_1_1_library.html#a8ce8e1aa20a71b9da4d1655fe04b089b) | [PropertyChangedWithDoubleValue](class_tale_worlds_1_1_library_1_1_view_model.html#a7d6e829c2ae2ef0147ca5f05e554dfc4) `[add, remove]` |
| [PropertyChangedWithVec2ValueEventHandler](namespace_tale_worlds_1_1_library.html#aa3ec79ffa85e522745c02340a7a41f2e) | [PropertyChangedWithVec2Value](class_tale_worlds_1_1_library_1_1_view_model.html#a8d1fb5f70c9230599a24b5d89a9a18f4) `[add, remove]` |
| Events inherited from [TaleWorlds.Library.IViewModel](interface_tale_worlds_1_1_library_1_1_i_view_model.html) | |
| [PropertyChangedWithValueEventHandler](namespace_tale_worlds_1_1_library.html#aa511552e184232616e64f386cf1146b5) | [PropertyChangedWithValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a19415fe20feafa29a4e6d8d61dd95834) |
| [PropertyChangedWithBoolValueEventHandler](namespace_tale_worlds_1_1_library.html#a6b0d7e614739868a8f81c53a64f081bd) | [PropertyChangedWithBoolValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ae0ed3e57e466612e46fcf77b394b9ba6) |
| [PropertyChangedWithIntValueEventHandler](namespace_tale_worlds_1_1_library.html#a91bc6d8c78c447d9acf86771f3b3e932) | [PropertyChangedWithIntValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ad33c6216fef22f2e150e0c0673c3c6ef) |
| [PropertyChangedWithFloatValueEventHandler](namespace_tale_worlds_1_1_library.html#aa44f77d2af0c3adb609a79640e080914) | [PropertyChangedWithFloatValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#acef7bf697f161b4c0d742215107b0b8b) |
| [PropertyChangedWithUIntValueEventHandler](namespace_tale_worlds_1_1_library.html#aec7149fde7f195f3c4b4f10c4ce23cb8) | [PropertyChangedWithUIntValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#afd24d3b78a5e7fab669c340045b8533f) |
| [PropertyChangedWithColorValueEventHandler](namespace_tale_worlds_1_1_library.html#a90de79687e9792b5065a8a4e9c30eeac) | [PropertyChangedWithColorValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a3bc123550acc0a47f8c061c5a8300fa1) |
| [PropertyChangedWithDoubleValueEventHandler](namespace_tale_worlds_1_1_library.html#a8ce8e1aa20a71b9da4d1655fe04b089b) | [PropertyChangedWithDoubleValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a4b1a715b622570235d8224ecef32dc13) |
| [PropertyChangedWithVec2ValueEventHandler](namespace_tale_worlds_1_1_library.html#aa3ec79ffa85e522745c02340a7a41f2e) | [PropertyChangedWithVec2Value](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a5b8667b3ad8595517ada80e2928bd6ab) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#ac8f35d95875229deb1c70469d8b99103)SPScoreboardVM()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.ViewModelCollection.SPScoreboardVM.SPScoreboardVM | ( | [BattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_battle_simulation.html) | *simulation* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a2f64b0315874aff1f5a0cd1b8ef92ab5)UpdateQuitText()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.SPScoreboardVM.UpdateQuitText | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a94677bc10a4308d8e2440a2398016fd6).

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a54a652d4cb642708e47782c8bf5c097e)Initialize()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.SPScoreboardVM.Initialize | ( | [IMissionScreen](interface_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_i_mission_screen.html) | *missionScreen*, | |  |  | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, | |  |  | Action | *releaseSimulationSources*, | |  |  | Action< bool > | *onToggle* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a9ca148a530a3db67f944f776ecd3d87e).

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#aba7b8366ba08c3fc39c111487e21b127)OnTick()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.SPScoreboardVM.OnTick | ( | float | *dt* | ) |  | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a5d763529f33a80a877cf0510d941e0e2)ExecutePlayAction()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.SPScoreboardVM.ExecutePlayAction | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#ae422d2e7eaf5820fc14bbf339cd4b383).

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a37c6ef23be4d927c7c83cb3ca2cf33e4)ExecuteFastForwardAction()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.SPScoreboardVM.ExecuteFastForwardAction | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#ae579762a9d56bf9578fdc70b3d165c3c).

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a640501eac7758e68a34accfd5f616479)ExecutePauseSimulationAction()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.SPScoreboardVM.ExecutePauseSimulationAction | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a62f0ad8e8c249b57735a638a27f48096).

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a74b95d198f3b4f76e1685bfa16ccf3ec)ExecuteEndSimulationAction()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.SPScoreboardVM.ExecuteEndSimulationAction | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#acfb5e4d3053f23e977256acad2682f5a).

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a6be2a948a60a137398f1f2474756da19)ExecuteQuitAction()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.SPScoreboardVM.ExecuteQuitAction | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.ViewModelCollection.Scoreboard.ScoreboardBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_scoreboard_1_1_scoreboard_base_v_m.html#a66afc9c7f6e022ecdf0c804fd8a72c28).

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a07db5b8b1080e5a64dfd4dd4b0c39eae)OnBattleOver()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SPScoreboardVM.OnBattleOver | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#ad5f5d04fd534a0563b2fa80bc4dc9925)OnExitBattle()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SPScoreboardVM.OnExitBattle | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a0f6bc2cd240a7faddb4190858f207c38)TroopNumberChanged()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SPScoreboardVM.TroopNumberChanged | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | *battleCombatant*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, |
|  |  | int | *number* = 0, |
|  |  | int | *numberDead* = 0, |
|  |  | int | *numberWounded* = 0, |
|  |  | int | *numberRouted* = 0, |
|  |  | int | *numberKilled* = 0, |
|  |  | int | *numberReadyToUpgrade* = 0 ) |

Implements [TaleWorlds.Core.IBattleObserver](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#af10c1c0878a63c6fc7d3b56358d4c594).

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a7e9a256975c32a3485f99996f757a8c7)HeroSkillIncreased()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SPScoreboardVM.HeroSkillIncreased | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | *battleCombatant*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *heroCharacter*, |
|  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *upgradedSkill* ) |

Implements [TaleWorlds.Core.IBattleObserver](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#ae015cd21dd8db68daccd3d8063afd438).

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a0c990414d31b11cf275ab4852612eb93)BattleResultsReady()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SPScoreboardVM.BattleResultsReady | ( |  | ) |  |

Implements [TaleWorlds.Core.IBattleObserver](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#ae7cfdfa6581d02c9cefc23937d32cdbd).

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a1d5c22b5dada331b71e853a476a12046)TroopSideChanged()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SPScoreboardVM.TroopSideChanged | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *prevSide*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *newSide*, |
|  |  | [IBattleCombatant](interface_tale_worlds_1_1_core_1_1_i_battle_combatant.html) | *battleCombatant*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character* ) |

Implements [TaleWorlds.Core.IBattleObserver](interface_tale_worlds_1_1_core_1_1_i_battle_observer.html#a58b7b9b97ba5d1430d94acab50fb2ce4).

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_s_p_scoreboard_v_m.html#a60f331a6f73b102eb5f4e200ff298e6f)BattleResults
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override MBBindingList<[BattleResultVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_battle_result_v_m.html)> SandBox.ViewModelCollection.SPScoreboardVM.BattleResults | | getset |


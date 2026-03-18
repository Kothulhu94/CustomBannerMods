--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionAgentStatusVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#aeeb3b16e9fe15f662643db24dcb14e48) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) missionCamera, Func< float > getCameraToggleProgress) |
| void | [InitializeMainAgentPropterties](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#adc4c2d8d9c6d7094ebe49f04b67fdfcc) () |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ac2d32a75e2d6420aaf53c8fff4169583) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a12b69d7d7daffabacef00325b875bf78) () |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#adea6edbdec912090b90ad10bf5f378a6) (float dt) |
| void | [OnEquipmentInteractionViewToggled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a8700feefad3d922e4645077c2c3d573d) (bool isActive) |
| void | [OnMainAgentWeaponChange](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a4822e1f87c97c3330e09319147e29b98) () |
| void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a6f874b74ad3444784a06f687ff837aac) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [OnAgentDeleted](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a14ae940d97227bab8bc8763667af54ef) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| void | [OnMainAgentHit](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a15fed534d1c80f0097fbe15404ce13f8) (int damage, float distance) |
| void | [OnFocusGained](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#af5dfb9fdbbee3298fdfb56093e3dc64a) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) mainAgent, [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusableObject, bool isInteractable) |
| void | [OnFocusLost](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a492d9c34ac698bcf4b83cc61372f363d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusableObject) |
| void | [OnSecondaryFocusGained](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a5e6bab2dce363eadbeb1137091997c69) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusableObject, bool isInteractable) |
| void | [OnSecondaryFocusLost](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ac03570fe0d01c524599260d023339a50) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusableObject) |
| void | [OnAgentInteraction](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ae13bebed9fb036c4a32ebd50b7ce15da) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, sbyte agentBoneIndex) |
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
| Properties | |
| bool | [IsInDeployement](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#abfb0f6d60e07ec3ba14415c55d7e4339) `[get, set]` |
| [MissionAgentTakenDamageVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_agent_taken_damage_v_m.html) | [TakenDamageController](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#af0288c523299edb526e033ccba8624d6) `[get, set]` |
| [AgentInteractionInterfaceVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html) | [InteractionInterface](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#af43448f79fbda6d0b599647c72ca2c58) `[get, set]` |
| int | [AgentHealth](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a5773f4be4f6d258a3d5ccea2e4c1c55b) `[get, set]` |
| int | [AgentHealthMax](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#adc905262ab3804ec38785f93ea9e79f6) `[get, set]` |
| int | [HorseHealth](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a0af6b8239f0911fb43eeda0f78c7f695) `[get, set]` |
| int | [HorseHealthMax](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#adeff29f9029e0ce6f1e15a3056e49a4b) `[get, set]` |
| int | [ShieldHealth](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ae48513fe85b7acbc563fdbb863e55276) `[get, set]` |
| int | [ShieldHealthMax](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a2288cb9ece0afc19e8c43dbeb5f88938) `[get, set]` |
| bool | [IsPlayerActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a3db097b665e6724130207c4b8078a39d) `[get, set]` |
| bool | [IsCombatUIActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a32df7788ae0a29d7f7e5b3a94660bd21) `[get, set]` |
| bool | [ShowAgentHealthBar](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#aedcb13ff82ea7a2d4b7d98ed96a3e126) `[get, set]` |
| bool | [ShowMountHealthBar](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ac123a49756f1b505f927d6ac50bc62cb) `[get, set]` |
| bool | [ShowShieldHealthBar](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ad26a5d9d2b77b8c25720f9f936b447a2) `[get, set]` |
| bool | [IsInteractionAvailable](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ae256b8092b9a2fd475313ff3f89e5434) `[get, set]` |
| bool | [IsAgentStatusPrioritized](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a3583bca7a4f82d5d28091b499db2e10d) `[get, set]` |
| bool | [IsAgentStatusAvailable](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a73cb66feefcb371c010c9558ae486f57) `[get, set]` |
| int | [CouchLanceState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a32e2ed68b01c1da1d8ed94f4b89ec3c1) `[get, set]` |
| int | [SpearBraceState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a9a24ccd0a62d9d1164c2d0923071f818) `[get, set]` |
| int | [TroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a6cc40f8bc3c152fa24f560731d0c8fe5) `[get, set]` |
| bool | [IsTroopsActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a342f5d085e059832a0393ee4f76631f1) `[get, set]` |
| bool | [IsGoldActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#aebe802470af31ed220a29910c3c90c24) `[get, set]` |
| int | [GoldAmount](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#abb45b31a956804a8c8929bae25d0a7d7) `[get, set]` |
| bool | [ShowAmmoCount](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a11985ebe9e351bc4524f92ef583a7d53) `[get, set]` |
| int | [AmmoCount](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#af76110e4f1bc691376ef560181046540) `[get, set]` |
| float | [TroopsAmmoPercentage](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a6e1e1ba328e089b058988389c767ca4d) `[get, set]` |
| bool | [TroopsAmmoAvailable](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a6a8fbb16c5af3950c9df8aed4254a6df) `[get, set]` |
| bool | [IsAmmoCountAlertEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a8c096a8290932765df3a196098b03716) `[get, set]` |
| float | [CameraToggleProgress](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ac645d28ec9e4ddbef87a15bd58829200) `[get, set]` |
| string | [CameraToggleText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a9b21848cf83b040f43fa3bf1fbe77642) `[get, set]` |
| [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) | [OffhandWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ae7db1b01b2626323b2195ca4156632ba) `[get, set]` |
| [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) | [PrimaryWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a0d528a9368348da5e4c08e8556696e45) `[get, set]` |
| [MissionAgentDamageFeedVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_damage_feed_1_1_mission_agent_damage_feed_v_m.html) | [TakenDamageFeed](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a8d2c95c2ace6e0552941db913a9c5856) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#aeeb3b16e9fe15f662643db24dcb14e48)MissionAgentStatusVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.MissionAgentStatusVM | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *missionCamera*, |
|  |  | Func< float > | *getCameraToggleProgress* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#adc4c2d8d9c6d7094ebe49f04b67fdfcc)InitializeMainAgentPropterties()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.InitializeMainAgentPropterties | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ac2d32a75e2d6420aaf53c8fff4169583)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a12b69d7d7daffabacef00325b875bf78)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#adea6edbdec912090b90ad10bf5f378a6)Tick()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a8700feefad3d922e4645077c2c3d573d)OnEquipmentInteractionViewToggled()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.OnEquipmentInteractionViewToggled | ( | bool | *isActive* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a4822e1f87c97c3330e09319147e29b98)OnMainAgentWeaponChange()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.OnMainAgentWeaponChange | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a6f874b74ad3444784a06f687ff837aac)OnAgentRemoved()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a14ae940d97227bab8bc8763667af54ef)OnAgentDeleted()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.OnAgentDeleted | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a15fed534d1c80f0097fbe15404ce13f8)OnMainAgentHit()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.OnMainAgentHit | ( | int | *damage*, |
|  |  | float | *distance* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#af5dfb9fdbbee3298fdfb56093e3dc64a)OnFocusGained()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.OnFocusGained | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *mainAgent*, |
|  |  | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | *focusableObject*, |
|  |  | bool | *isInteractable* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a492d9c34ac698bcf4b83cc61372f363d)OnFocusLost()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.OnFocusLost | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | *focusableObject* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a5e6bab2dce363eadbeb1137091997c69)OnSecondaryFocusGained()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.OnSecondaryFocusGained | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | *focusableObject*, |
|  |  | bool | *isInteractable* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ac03570fe0d01c524599260d023339a50)OnSecondaryFocusLost()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.OnSecondaryFocusLost | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | *focusableObject* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ae13bebed9fb036c4a32ebd50b7ce15da)OnAgentInteraction()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.OnAgentInteraction | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | sbyte | *agentBoneIndex* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#abfb0f6d60e07ec3ba14415c55d7e4339)IsInDeployement
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.IsInDeployement | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#af0288c523299edb526e033ccba8624d6)TakenDamageController
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionAgentTakenDamageVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_agent_taken_damage_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.TakenDamageController | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#af43448f79fbda6d0b599647c72ca2c58)InteractionInterface
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentInteractionInterfaceVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html) TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.InteractionInterface | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a5773f4be4f6d258a3d5ccea2e4c1c55b)AgentHealth
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.AgentHealth | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#adc905262ab3804ec38785f93ea9e79f6)AgentHealthMax
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.AgentHealthMax | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a0af6b8239f0911fb43eeda0f78c7f695)HorseHealth
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.HorseHealth | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#adeff29f9029e0ce6f1e15a3056e49a4b)HorseHealthMax
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.HorseHealthMax | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ae48513fe85b7acbc563fdbb863e55276)ShieldHealth
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.ShieldHealth | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a2288cb9ece0afc19e8c43dbeb5f88938)ShieldHealthMax
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.ShieldHealthMax | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a3db097b665e6724130207c4b8078a39d)IsPlayerActive
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.IsPlayerActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a32df7788ae0a29d7f7e5b3a94660bd21)IsCombatUIActive
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.IsCombatUIActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#aedcb13ff82ea7a2d4b7d98ed96a3e126)ShowAgentHealthBar
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.ShowAgentHealthBar | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ac123a49756f1b505f927d6ac50bc62cb)ShowMountHealthBar
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.ShowMountHealthBar | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ad26a5d9d2b77b8c25720f9f936b447a2)ShowShieldHealthBar
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.ShowShieldHealthBar | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ae256b8092b9a2fd475313ff3f89e5434)IsInteractionAvailable
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.IsInteractionAvailable | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a3583bca7a4f82d5d28091b499db2e10d)IsAgentStatusPrioritized
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.IsAgentStatusPrioritized | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a73cb66feefcb371c010c9558ae486f57)IsAgentStatusAvailable
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.IsAgentStatusAvailable | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a32e2ed68b01c1da1d8ed94f4b89ec3c1)CouchLanceState
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.CouchLanceState | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a9a24ccd0a62d9d1164c2d0923071f818)SpearBraceState
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.SpearBraceState | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a6cc40f8bc3c152fa24f560731d0c8fe5)TroopCount
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.TroopCount | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a342f5d085e059832a0393ee4f76631f1)IsTroopsActive
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.IsTroopsActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#aebe802470af31ed220a29910c3c90c24)IsGoldActive
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.IsGoldActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#abb45b31a956804a8c8929bae25d0a7d7)GoldAmount
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.GoldAmount | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a11985ebe9e351bc4524f92ef583a7d53)ShowAmmoCount
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.ShowAmmoCount | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#af76110e4f1bc691376ef560181046540)AmmoCount
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.AmmoCount | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a6e1e1ba328e089b058988389c767ca4d)TroopsAmmoPercentage
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.TroopsAmmoPercentage | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a6a8fbb16c5af3950c9df8aed4254a6df)TroopsAmmoAvailable
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.TroopsAmmoAvailable | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a8c096a8290932765df3a196098b03716)IsAmmoCountAlertEnabled
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.IsAmmoCountAlertEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ac645d28ec9e4ddbef87a15bd58829200)CameraToggleProgress
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.CameraToggleProgress | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a9b21848cf83b040f43fa3bf1fbe77642)CameraToggleText
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.CameraToggleText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#ae7db1b01b2626323b2195ca4156632ba)OffhandWeapon
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.OffhandWeapon | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a0d528a9368348da5e4c08e8556696e45)PrimaryWeapon
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.PrimaryWeapon | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_mission_agent_status_v_m.html#a8d2c95c2ace6e0552941db913a9c5856)TakenDamageFeed
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionAgentDamageFeedVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_damage_feed_1_1_mission_agent_damage_feed_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.MissionAgentStatusVM.TakenDamageFeed | | getset |


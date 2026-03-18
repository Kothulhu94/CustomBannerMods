--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html ---

TaleWorlds.MountAndBlade.AttackInformation Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a7fc63059fe1682888f02903758247ccb) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) hitObject, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) attackCollisionData, in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon) |
|  | [AttackInformation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ac339b18e1e6e1b9694c96c18f451941d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) victimAgent, float armorAmountFloat, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) shieldOnBack, [AgentFlag](namespace_tale_worlds_1_1_core.html#a4eadec2c483252505ae0d0ab98de39fe) victimAgentFlags, AIStateFlag victimAgentAIStateFlags, float victimAgentAbsorbedDamageRatio, float damageMultiplierOfBone, float combatDifficultyMultiplier, [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) attackerWeapon, [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) victimMainHandWeapon, [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) victimShield, bool canGiveDamageToAgentShield, bool isVictimAgentLeftStance, bool isFriendlyFire, bool doesAttackerHaveMountAgent, bool doesVictimHaveMountAgent, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) attackerAgentMovementVelocity, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) attackerAgentMountMovementDirection, float attackerMovementDirectionAsAngle, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) victimAgentMovementVelocity, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) victimAgentMountMovementDirection, float victimMovementDirectionAsAngle, bool isVictimAgentSameWithAttackerAgent, bool isAttackerAgentMine, bool doesAttackerHaveRiderAgent, bool isAttackerAgentRiderAgentMine, bool isAttackerAgentMount, bool isVictimAgentMine, bool doesVictimHaveRiderAgent, bool isVictimAgentRiderAgentMine, bool isVictimAgentMount, bool isAttackerAgentNull, bool isAttackerAIControlled, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) attackerAgentCharacter, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) attackerRiderAgentCharacter, [Monster](class_tale_worlds_1_1_core_1_1_monster.html) attackerAgentMonster, [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) attackerAgentOrigin, [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) attackerRiderAgentOrigin, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) victimAgentCharacter, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) victimRiderAgentCharacter, [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) victimAgentOrigin, [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) victimRiderAgentOrigin, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) attackerAgentPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) attackerAgentMovementDirection, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) attackerAgentVelocity, float attackerAgentMountChargeDamageProperty, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) attackerAgentCurrentWeaponOffset, bool isAttackerAgentHuman, bool isAttackerAgentActive, bool isAttackerAgentDoingPassiveAttack, bool isVictimAgentNull, float victimAgentScale, float victimAgentHealth, float victimAgentMaxHealth, float victimAgentWeight, float victimAgentTotalEncumbrance, bool isVictimAgentHuman, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) victimAgentPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) victimAgentMovementDirection, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) victimAgentVelocity, int weaponAttachBoneIndex, [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) offHandItem, bool isHeadShot, bool isVictimRiderAgentSameAsAttackerAgent, bool isAttackerPlayer, bool isVictimPlayer, [DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html) hitObjectDestructibleComponent) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [AttackerAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#adbfebcbf6270a59f0e28097db5752b3f) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [VictimAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a3b3d8b29c2ba293d6a0b0ef368b9979e) |
| float | [ArmorAmountFloat](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a6880dc47725befc8cc9a67bb6dc9e136) |
| [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | [ShieldOnBack](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aa30a47bcb8241db1fc3063e51d8b7030) |
| [AgentFlag](namespace_tale_worlds_1_1_core.html#a4eadec2c483252505ae0d0ab98de39fe) | [VictimAgentFlags](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a9d92eb8c0928186b340eb26d3a3d4f1b) |
| AIStateFlag | [VictimAgentAIStateFlags](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ad2ffcb59f1d025cd925ee8391dc74e94) |
| float | [VictimAgentAbsorbedDamageRatio](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a3dbd3df5ee021bcadbb2c67211313ea3) |
| float | [DamageMultiplierOfBone](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ad1f15116903326e54712d729fdb23f62) |
| float | [CombatDifficultyMultiplier](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a7f4205535c747d125317e4b375edea1e) |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | [AttackerWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aa6efe65de281fd9b3620268c0d518d38) |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | [VictimMainHandWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a8a0dc2570f4d7f1d91db865795d64f5a) |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | [VictimShield](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ab1c2eddaf2a19c356c372d4a857428ad) |
| bool | [CanGiveDamageToAgentShield](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a756fdc50fee079d386748f8b676a1ac2) |
| bool | [IsVictimAgentLeftStance](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a9d9960c5aeb7ccc83eacb3e21b119a9b) |
| bool | [IsFriendlyFire](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ab0f74ae8026eb8b98b5dd9dfa18d6617) |
| bool | [DoesAttackerHaveMountAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ac050d6f9a79ec2688c7ce6fa3c3099bd) |
| bool | [DoesVictimHaveMountAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a80d6361fb7e68719c5aa7cc84e703c39) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [AttackerAgentMovementVelocity](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a101c2f85bac70263594c1076691a16e2) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [AttackerAgentMountMovementDirection](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a961da6641ab5f9786168bac45bf1fed3) |
| float | [AttackerMovementDirectionAsAngle](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aac969cdafb0a7cfa1281082f4c2f96ee) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [VictimAgentMovementVelocity](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aa687b467d3725725bdf47ed0852b2697) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [VictimAgentMountMovementDirection](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a63f5801c5d0b7acc934f57b4058374a2) |
| float | [VictimMovementDirectionAsAngle](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a63d0779c1aec0f9adb39ab1ea34eef9f) |
| bool | [IsVictimAgentSameWithAttackerAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#afd5eaf93c7a86f955c423396239d439f) |
| bool | [IsAttackerAgentMine](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a936a50198736472ad451740a398aa72d) |
| bool | [DoesAttackerHaveRiderAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a8c7aef77e85cb2137482de3bab8ad095) |
| bool | [IsAttackerAgentRiderAgentMine](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a2d4b078e4fe867d9297b9a939e79a5d4) |
| bool | [IsAttackerAgentMount](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#af0a83f484f506cbed384bd89ceee9b74) |
| bool | [IsVictimAgentMine](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ad78c9ba139b76100999ef21d39faf157) |
| bool | [DoesVictimHaveRiderAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a052c9d50dbf0a7fdbc1c7ad8f94f1b1e) |
| bool | [IsVictimAgentRiderAgentMine](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a0eba191c11437a5b13feb6d27ebd218d) |
| bool | [IsVictimAgentMount](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a2b8784507a1b580398c3148b40b11852) |
| bool | [IsAttackerAgentNull](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a1a1e8333e5b4be38d1cd5c40e8df80cc) |
| bool | [IsAttackerAIControlled](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a860a87cd7b64fd09d7f12b89d59d5959) |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [AttackerAgentCharacter](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aa689ca9618e77c8db92122b6631201f5) |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [AttackerRiderAgentCharacter](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a005eea12eb1711f9d73b51a755d4a1a3) |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | [AttackerAgentMonster](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a7805e6e6718111ed224554d0e5fc97db) |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | [AttackerAgentOrigin](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a5c5d5ad116041d6858fcf353d2b659f3) |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | [AttackerRiderAgentOrigin](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ab5fa883600b17779a6daf6b67208eafe) |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [VictimAgentCharacter](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#abeefc44fe588cd76a36558537e79bebe) |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [VictimRiderAgentCharacter](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a34e68c67c034351e526c016fc0bc7e3a) |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | [VictimAgentOrigin](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#acf76e9ac39775a7efa484381f2200228) |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | [VictimRiderAgentOrigin](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a3fae811e5a8ef330f6bd1b763f2b4ce8) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [AttackerAgentPosition](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#acee4b75eeb291ff74eaa00bdb430434d) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [AttackerAgentMovementDirection](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a67ef621b38f951fb1e74f275d7d5c41d) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [AttackerAgentVelocity](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a8d056c2e1795019eb1e448e7cf0dee9f) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [VictimAgentPosition](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ae8a551c4c23f0e77e10bb23f080e9a7e) |
| float | [AttackerAgentMountChargeDamageProperty](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a6328218f972723cab696bd9bb0d42b85) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [VictimAgentVelocity](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a68ad72dbceca1df529db519f7e2f75a3) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [VictimAgentMovementDirection](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a256a01e0633e9913ed0f177969dbafdd) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [AttackerAgentCurrentWeaponOffset](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a93ade657ef28fca6cc3b844e28fceedc) |
| bool | [IsAttackerAgentHuman](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aaf816a8ca98ce656fc9fb75d1c4fd301) |
| bool | [IsAttackerAgentActive](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a0868d2ecafe56bb2061ca1b6cd5e1ca8) |
| bool | [IsAttackerAgentDoingPassiveAttack](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a47e3b10e89fd4189f09b2285af4950c6) |
| bool | [IsVictimAgentNull](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a5b4f24bb0c241330d47d27b43183ae9d) |
| float | [VictimAgentScale](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a0546e860f7d81e37dd14cef0c0bf0796) |
| float | [VictimAgentWeight](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a11ffeda4aad759c2c230aee101454eac) |
| float | [VictimAgentHealth](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a26668957a35183cf2ff6ecfcb8afea98) |
| float | [VictimAgentMaxHealth](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a0568f046ccd474ab55ff70f17a2acb1a) |
| float | [VictimAgentTotalEncumbrance](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a79722e667deef7df1673a72d74b6414e) |
| bool | [IsVictimAgentHuman](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a4c8abeaf20e74d5facb427ddd88ccf8b) |
| int | [WeaponAttachBoneIndex](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a07e253f1199be8d14d0a3ad7e660613d) |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | [OffHandItem](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a8b1bad73aae52040cfae6b27bab74f27) |
| bool | [IsHeadShot](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ab175b47542a401f5ac6bd3c21b44add2) |
| bool | [IsVictimRiderAgentSameAsAttackerAgent](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a6254880bb1bfc4fee076193040b84027) |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [AttackerCaptainCharacter](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a33424282b332854ff36c26b163f1c4e5) |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [VictimCaptainCharacter](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a2d3c83432679cc3fcaf7c6d7a19dc531) |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [AttackerFormation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a1730de0a26640cbeb6c98a3673dea316) |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [VictimFormation](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#af431ca8d52a47d693f317f605fc9dfe5) |
| float | [AttackerHitPointRate](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a356a90dbc9fe552dcf592ec8243b0415) |
| float | [VictimHitPointRate](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ae9ecfe2eaecfb1542d69f74fe02d6425) |
| bool | [IsAttackerPlayer](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aa7fdbaf85d5d053f9cd7e385eb88c467) |
| bool | [IsVictimPlayer](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aebf302480c9ec276293e9e0ad941a781) |
| [DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html) | [HitObjectDestructibleComponent](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a5cf4b9d4fa1b6220eb526b5d9db4b995) |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a7fc63059fe1682888f02903758247ccb)AttackInformation() [1/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.AttackInformation.AttackInformation | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *hitObject*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *attackCollisionData*, |
|  |  | in [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *attackerWeapon* ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ac339b18e1e6e1b9694c96c18f451941d)AttackInformation() [2/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.AttackInformation.AttackInformation | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *victimAgent*, |
|  |  | float | *armorAmountFloat*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *shieldOnBack*, |
|  |  | [AgentFlag](namespace_tale_worlds_1_1_core.html#a4eadec2c483252505ae0d0ab98de39fe) | *victimAgentFlags*, |
|  |  | AIStateFlag | *victimAgentAIStateFlags*, |
|  |  | float | *victimAgentAbsorbedDamageRatio*, |
|  |  | float | *damageMultiplierOfBone*, |
|  |  | float | *combatDifficultyMultiplier*, |
|  |  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *attackerWeapon*, |
|  |  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *victimMainHandWeapon*, |
|  |  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *victimShield*, |
|  |  | bool | *canGiveDamageToAgentShield*, |
|  |  | bool | *isVictimAgentLeftStance*, |
|  |  | bool | *isFriendlyFire*, |
|  |  | bool | *doesAttackerHaveMountAgent*, |
|  |  | bool | *doesVictimHaveMountAgent*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *attackerAgentMovementVelocity*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *attackerAgentMountMovementDirection*, |
|  |  | float | *attackerMovementDirectionAsAngle*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *victimAgentMovementVelocity*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *victimAgentMountMovementDirection*, |
|  |  | float | *victimMovementDirectionAsAngle*, |
|  |  | bool | *isVictimAgentSameWithAttackerAgent*, |
|  |  | bool | *isAttackerAgentMine*, |
|  |  | bool | *doesAttackerHaveRiderAgent*, |
|  |  | bool | *isAttackerAgentRiderAgentMine*, |
|  |  | bool | *isAttackerAgentMount*, |
|  |  | bool | *isVictimAgentMine*, |
|  |  | bool | *doesVictimHaveRiderAgent*, |
|  |  | bool | *isVictimAgentRiderAgentMine*, |
|  |  | bool | *isVictimAgentMount*, |
|  |  | bool | *isAttackerAgentNull*, |
|  |  | bool | *isAttackerAIControlled*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *attackerAgentCharacter*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *attackerRiderAgentCharacter*, |
|  |  | [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | *attackerAgentMonster*, |
|  |  | [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | *attackerAgentOrigin*, |
|  |  | [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | *attackerRiderAgentOrigin*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *victimAgentCharacter*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *victimRiderAgentCharacter*, |
|  |  | [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | *victimAgentOrigin*, |
|  |  | [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | *victimRiderAgentOrigin*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *attackerAgentPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *attackerAgentMovementDirection*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *attackerAgentVelocity*, |
|  |  | float | *attackerAgentMountChargeDamageProperty*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *attackerAgentCurrentWeaponOffset*, |
|  |  | bool | *isAttackerAgentHuman*, |
|  |  | bool | *isAttackerAgentActive*, |
|  |  | bool | *isAttackerAgentDoingPassiveAttack*, |
|  |  | bool | *isVictimAgentNull*, |
|  |  | float | *victimAgentScale*, |
|  |  | float | *victimAgentHealth*, |
|  |  | float | *victimAgentMaxHealth*, |
|  |  | float | *victimAgentWeight*, |
|  |  | float | *victimAgentTotalEncumbrance*, |
|  |  | bool | *isVictimAgentHuman*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *victimAgentPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *victimAgentMovementDirection*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *victimAgentVelocity*, |
|  |  | int | *weaponAttachBoneIndex*, |
|  |  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *offHandItem*, |
|  |  | bool | *isHeadShot*, |
|  |  | bool | *isVictimRiderAgentSameAsAttackerAgent*, |
|  |  | bool | *isAttackerPlayer*, |
|  |  | bool | *isVictimPlayer*, |
|  |  | [DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html) | *hitObjectDestructibleComponent* ) |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#adbfebcbf6270a59f0e28097db5752b3f)AttackerAgent
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerAgent |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a3b3d8b29c2ba293d6a0b0ef368b9979e)VictimAgent
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.AttackInformation.VictimAgent |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a6880dc47725befc8cc9a67bb6dc9e136)ArmorAmountFloat
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.ArmorAmountFloat |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aa30a47bcb8241db1fc3063e51d8b7030)ShieldOnBack
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) TaleWorlds.MountAndBlade.AttackInformation.ShieldOnBack |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a9d92eb8c0928186b340eb26d3a3d4f1b)VictimAgentFlags
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [AgentFlag](namespace_tale_worlds_1_1_core.html#a4eadec2c483252505ae0d0ab98de39fe) TaleWorlds.MountAndBlade.AttackInformation.VictimAgentFlags |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ad2ffcb59f1d025cd925ee8391dc74e94)VictimAgentAIStateFlags
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| AIStateFlag TaleWorlds.MountAndBlade.AttackInformation.VictimAgentAIStateFlags |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a3dbd3df5ee021bcadbb2c67211313ea3)VictimAgentAbsorbedDamageRatio
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.VictimAgentAbsorbedDamageRatio |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ad1f15116903326e54712d729fdb23f62)DamageMultiplierOfBone
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.DamageMultiplierOfBone |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a7f4205535c747d125317e4b375edea1e)CombatDifficultyMultiplier
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.CombatDifficultyMultiplier |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aa6efe65de281fd9b3620268c0d518d38)AttackerWeapon
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerWeapon |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a8a0dc2570f4d7f1d91db865795d64f5a)VictimMainHandWeapon
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) TaleWorlds.MountAndBlade.AttackInformation.VictimMainHandWeapon |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ab1c2eddaf2a19c356c372d4a857428ad)VictimShield
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) TaleWorlds.MountAndBlade.AttackInformation.VictimShield |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a756fdc50fee079d386748f8b676a1ac2)CanGiveDamageToAgentShield
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.CanGiveDamageToAgentShield |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a9d9960c5aeb7ccc83eacb3e21b119a9b)IsVictimAgentLeftStance
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsVictimAgentLeftStance |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ab0f74ae8026eb8b98b5dd9dfa18d6617)IsFriendlyFire
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsFriendlyFire |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ac050d6f9a79ec2688c7ce6fa3c3099bd)DoesAttackerHaveMountAgent
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.DoesAttackerHaveMountAgent |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a80d6361fb7e68719c5aa7cc84e703c39)DoesVictimHaveMountAgent
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.DoesVictimHaveMountAgent |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a101c2f85bac70263594c1076691a16e2)AttackerAgentMovementVelocity
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerAgentMovementVelocity |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a961da6641ab5f9786168bac45bf1fed3)AttackerAgentMountMovementDirection
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerAgentMountMovementDirection |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aac969cdafb0a7cfa1281082f4c2f96ee)AttackerMovementDirectionAsAngle
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.AttackerMovementDirectionAsAngle |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aa687b467d3725725bdf47ed0852b2697)VictimAgentMovementVelocity
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.AttackInformation.VictimAgentMovementVelocity |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a63f5801c5d0b7acc934f57b4058374a2)VictimAgentMountMovementDirection
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.AttackInformation.VictimAgentMountMovementDirection |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a63d0779c1aec0f9adb39ab1ea34eef9f)VictimMovementDirectionAsAngle
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.VictimMovementDirectionAsAngle |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#afd5eaf93c7a86f955c423396239d439f)IsVictimAgentSameWithAttackerAgent
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsVictimAgentSameWithAttackerAgent |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a936a50198736472ad451740a398aa72d)IsAttackerAgentMine
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsAttackerAgentMine |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a8c7aef77e85cb2137482de3bab8ad095)DoesAttackerHaveRiderAgent
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.DoesAttackerHaveRiderAgent |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a2d4b078e4fe867d9297b9a939e79a5d4)IsAttackerAgentRiderAgentMine
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsAttackerAgentRiderAgentMine |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#af0a83f484f506cbed384bd89ceee9b74)IsAttackerAgentMount
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsAttackerAgentMount |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ad78c9ba139b76100999ef21d39faf157)IsVictimAgentMine
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsVictimAgentMine |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a052c9d50dbf0a7fdbc1c7ad8f94f1b1e)DoesVictimHaveRiderAgent
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.DoesVictimHaveRiderAgent |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a0eba191c11437a5b13feb6d27ebd218d)IsVictimAgentRiderAgentMine
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsVictimAgentRiderAgentMine |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a2b8784507a1b580398c3148b40b11852)IsVictimAgentMount
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsVictimAgentMount |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a1a1e8333e5b4be38d1cd5c40e8df80cc)IsAttackerAgentNull
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsAttackerAgentNull |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a860a87cd7b64fd09d7f12b89d59d5959)IsAttackerAIControlled
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsAttackerAIControlled |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aa689ca9618e77c8db92122b6631201f5)AttackerAgentCharacter
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerAgentCharacter |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a005eea12eb1711f9d73b51a755d4a1a3)AttackerRiderAgentCharacter
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerRiderAgentCharacter |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a7805e6e6718111ed224554d0e5fc97db)AttackerAgentMonster
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Monster](class_tale_worlds_1_1_core_1_1_monster.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerAgentMonster |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a5c5d5ad116041d6858fcf353d2b659f3)AttackerAgentOrigin
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerAgentOrigin |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ab5fa883600b17779a6daf6b67208eafe)AttackerRiderAgentOrigin
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerRiderAgentOrigin |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#abeefc44fe588cd76a36558537e79bebe)VictimAgentCharacter
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.AttackInformation.VictimAgentCharacter |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a34e68c67c034351e526c016fc0bc7e3a)VictimRiderAgentCharacter
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.AttackInformation.VictimRiderAgentCharacter |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#acf76e9ac39775a7efa484381f2200228)VictimAgentOrigin
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) TaleWorlds.MountAndBlade.AttackInformation.VictimAgentOrigin |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a3fae811e5a8ef330f6bd1b763f2b4ce8)VictimRiderAgentOrigin
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) TaleWorlds.MountAndBlade.AttackInformation.VictimRiderAgentOrigin |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#acee4b75eeb291ff74eaa00bdb430434d)AttackerAgentPosition
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerAgentPosition |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a67ef621b38f951fb1e74f275d7d5c41d)AttackerAgentMovementDirection
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerAgentMovementDirection |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a8d056c2e1795019eb1e448e7cf0dee9f)AttackerAgentVelocity
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerAgentVelocity |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ae8a551c4c23f0e77e10bb23f080e9a7e)VictimAgentPosition
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackInformation.VictimAgentPosition |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a6328218f972723cab696bd9bb0d42b85)AttackerAgentMountChargeDamageProperty
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.AttackerAgentMountChargeDamageProperty |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a68ad72dbceca1df529db519f7e2f75a3)VictimAgentVelocity
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackInformation.VictimAgentVelocity |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a256a01e0633e9913ed0f177969dbafdd)VictimAgentMovementDirection
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.AttackInformation.VictimAgentMovementDirection |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a93ade657ef28fca6cc3b844e28fceedc)AttackerAgentCurrentWeaponOffset
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerAgentCurrentWeaponOffset |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aaf816a8ca98ce656fc9fb75d1c4fd301)IsAttackerAgentHuman
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsAttackerAgentHuman |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a0868d2ecafe56bb2061ca1b6cd5e1ca8)IsAttackerAgentActive
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsAttackerAgentActive |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a47e3b10e89fd4189f09b2285af4950c6)IsAttackerAgentDoingPassiveAttack
------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsAttackerAgentDoingPassiveAttack |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a5b4f24bb0c241330d47d27b43183ae9d)IsVictimAgentNull
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsVictimAgentNull |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a0546e860f7d81e37dd14cef0c0bf0796)VictimAgentScale
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.VictimAgentScale |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a11ffeda4aad759c2c230aee101454eac)VictimAgentWeight
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.VictimAgentWeight |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a26668957a35183cf2ff6ecfcb8afea98)VictimAgentHealth
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.VictimAgentHealth |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a0568f046ccd474ab55ff70f17a2acb1a)VictimAgentMaxHealth
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.VictimAgentMaxHealth |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a79722e667deef7df1673a72d74b6414e)VictimAgentTotalEncumbrance
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.VictimAgentTotalEncumbrance |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a4c8abeaf20e74d5facb427ddd88ccf8b)IsVictimAgentHuman
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsVictimAgentHuman |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a07e253f1199be8d14d0a3ad7e660613d)WeaponAttachBoneIndex
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.AttackInformation.WeaponAttachBoneIndex |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a8b1bad73aae52040cfae6b27bab74f27)OffHandItem
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) TaleWorlds.MountAndBlade.AttackInformation.OffHandItem |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ab175b47542a401f5ac6bd3c21b44add2)IsHeadShot
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsHeadShot |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a6254880bb1bfc4fee076193040b84027)IsVictimRiderAgentSameAsAttackerAgent
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsVictimRiderAgentSameAsAttackerAgent |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a33424282b332854ff36c26b163f1c4e5)AttackerCaptainCharacter
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerCaptainCharacter |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a2d3c83432679cc3fcaf7c6d7a19dc531)VictimCaptainCharacter
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.AttackInformation.VictimCaptainCharacter |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a1730de0a26640cbeb6c98a3673dea316)AttackerFormation
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.AttackInformation.AttackerFormation |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#af431ca8d52a47d693f317f605fc9dfe5)VictimFormation
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.AttackInformation.VictimFormation |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a356a90dbc9fe552dcf592ec8243b0415)AttackerHitPointRate
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.AttackerHitPointRate |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#ae9ecfe2eaecfb1542d69f74fe02d6425)VictimHitPointRate
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.MountAndBlade.AttackInformation.VictimHitPointRate |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aa7fdbaf85d5d053f9cd7e385eb88c467)IsAttackerPlayer
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsAttackerPlayer |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#aebf302480c9ec276293e9e0ad941a781)IsVictimPlayer
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.AttackInformation.IsVictimPlayer |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_information.html#a5cf4b9d4fa1b6220eb526b5d9db4b995)HitObjectDestructibleComponent
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [DestructableComponent](class_tale_worlds_1_1_mount_and_blade_1_1_destructable_component.html) TaleWorlds.MountAndBlade.AttackInformation.HitObjectDestructibleComponent |


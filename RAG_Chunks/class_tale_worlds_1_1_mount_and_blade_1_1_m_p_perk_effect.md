--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect.html ---

TaleWorlds.MountAndBlade.MPPerkEffect Class ReferenceabstractInherits [TaleWorlds.MountAndBlade.MPPerkEffectBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html).

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static MPPerkEffect | [CreateFrom](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect.html#a682a6e8e81625b3fd8dd869c5ffb77e2) (XmlNode node) |

|  |  |
| --- | --- |
| Static Protected Attributes | |
| static Dictionary< string, Type > | [Registered](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect.html#a4466095c6331a0762af121ea2e626307) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MPPerkEffectBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html) | |
| virtual void | [OnUpdate](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a7e39f7708d4c18fe7c7e4fc40d141a4b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, bool newState) |
| virtual void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a08db0f68f14a6537abaa98fbf51249dc) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer, int tickCount) |
| virtual void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a7df51d8e0e103c4006a0ffdbe06e3330) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, int tickCount) |
| virtual float | [GetDamage](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a34f227d250da930b0e1f13c1dd62fb63) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType, bool isAlternativeAttack) |
| virtual float | [GetMountDamage](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a7692b7aabb48c2b611df68e3496a5cf5) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType, bool isAlternativeAttack) |
| virtual float | [GetDamageTaken](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a5019bcde63928ec11c3d2fb53fbcee9d) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType) |
| virtual float | [GetMountDamageTaken](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a59b51c8c2c9d94b221644c079ecdfe9b) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType) |
| virtual float | [GetSpeedBonusEffectiveness](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#ac2533a2c6eadec5bfeaa006c84f90a23) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attacker, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType) |
| virtual float | [GetShieldDamage](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#ab93f11fffae929fc0cdf57817aeeff1a) (bool isCorrectSideBlock) |
| virtual float | [GetShieldDamageTaken](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a96e9a7455810a0397fb5d02fcd4a7c4c) (bool isCorrectSideBlock) |
| virtual float | [GetRangedAccuracy](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a0669559fdf55204b45d4d31a4120bf6f) () |
| virtual float | [GetThrowingWeaponSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a9cfc73db7cb3fd181bc74102d9ebf3ae) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon) |
| virtual float | [GetDamageInterruptionThreshold](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a6ea3fac5846f46e5348e53e93a3102d1) () |
| virtual float | [GetMountManeuver](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a612484f31605c3f03e6359bf510c1f89) () |
| virtual float | [GetMountSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a053847e9bfe4af7632585477f42adeff) () |
| virtual float | [GetRangedHeadShotDamage](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a3ec7c749ef50d9e923ba856bdf498476) () |
| virtual int | [GetGoldOnKill](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a86d406d17fc80fdfd8a35402104a2eaa) (float attackerValue, float victimValue) |
| virtual int | [GetGoldOnAssist](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#ae0f7b2afbbaf932fe5eab7cd7b42b887) () |
| virtual int | [GetRewardedGoldOnAssist](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a1095f7dc977defa29cd02557f05cb018) () |
| virtual bool | [GetIsTeamRewardedOnDeath](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#aa5999db50c994324f0c125aa4c86b4f8) () |
| virtual void | [CalculateRewardedGoldOnDeath](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a0089a1d237c82e5ed4eb6e2bda09c7e6) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, List< ValueTuple< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html), int > > teamMembers) |
| virtual float | [GetDrivenPropertyBonus](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#ae5f06683d6dfbd457edbbc6c3c964b86) ([DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) drivenProperty, float baseValue) |
| virtual float | [GetEncumbrance](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#a0f200d07258b8b7b2782099b6cd2073a) (bool isOnBody) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MPPerkEffectBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html) | |
| void | [Deserialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#aa4e900a780b869c55d2135aa9d89d9f6) (XmlNode node) |
| Properties inherited from [TaleWorlds.MountAndBlade.MPPerkEffectBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html) | |
| virtual bool | [IsTickRequired](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#aaaec707dae4f18e7ee7503950a7d77c2) `[get]` |
| bool | [IsDisabledInWarmup](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect_base.html#ae3cd181178339720e4e18bdbea3fdb4f) `[get, protected set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect.html#a682a6e8e81625b3fd8dd869c5ffb77e2)CreateFrom()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MPPerkEffect TaleWorlds.MountAndBlade.MPPerkEffect.CreateFrom | ( | XmlNode | *node* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_effect.html#a4466095c6331a0762af121ea2e626307)Registered
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, Type> TaleWorlds.MountAndBlade.MPPerkEffect.Registered | | staticprotected |


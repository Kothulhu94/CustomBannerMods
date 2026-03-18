--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html ---

TaleWorlds.MountAndBlade.CustomBattleAgentOrigin Class ReferenceInherits [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CustomBattleAgentOrigin](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a856bff47d27b517fa0ff4fbe5b7e3811) ([CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#abd9eb111cb727052ea0cb05c3fd68a6b) customBattleCombatant, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) characterObject, [CustomBattleTroopSupplier](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html) troopSupplier, bool isPlayerSide, int rank=-1, [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) uniqueNo=default([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html))) |
| void | [SetWounded](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a1dd39900667a4d959b63e811332ee2b3) () |
| void | [SetKilled](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a91514832362b13fd231dede583ae94ef) () |
| void | [SetRouted](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a24c1b80d4636b35e0cc5a9da461ce35a) (bool isOrderRetreat) |
| void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#aa6a9e8030aa673843ae0073d377e8820) (float agentHealth) |
| void | [SetBanner](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a329e9da3b1b78503a7c6724758611770) ([Banner](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a86aad1bbcb2a22790ff8c506f1fe5806) banner) |

|  |  |
| --- | --- |
| Properties | |
| CustomBattleCombatant | [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#abd9eb111cb727052ea0cb05c3fd68a6b) `[get]` |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [Troop](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a6cd471e06cfb3c2189ec36819afb56ba) `[get]` |
| int | [Rank](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a4316ac04f7cf12a492b9451b9abfa5f5) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a86aad1bbcb2a22790ff8c506f1fe5806) `[get]` |
| bool | [IsUnderPlayersCommand](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a9f7c4b230bc3dc058913699164aaa67a) `[get]` |
| uint | [FactionColor](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a59b4d88b37fd762a79ea92080acfa2b1) `[get]` |
| uint | [FactionColor2](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a401200a838b1fd2c164db002f33d23b1) `[get]` |
| int | [Seed](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#ab8402e937a40d93aed770800cec15494) `[get]` |
| int | [UniqueSeed](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a48e9db1e295e60ed963a3cd286cefd26) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a856bff47d27b517fa0ff4fbe5b7e3811)CustomBattleAgentOrigin()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.CustomBattleAgentOrigin | ( | [CustomBattleCombatant](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#abd9eb111cb727052ea0cb05c3fd68a6b) | *customBattleCombatant*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *characterObject*, |
|  |  | [CustomBattleTroopSupplier](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_troop_supplier.html) | *troopSupplier*, |
|  |  | bool | *isPlayerSide*, |
|  |  | int | *rank* = -1, |
|  |  | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *uniqueNo* = default([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html)) ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a1dd39900667a4d959b63e811332ee2b3)SetWounded()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.SetWounded | ( |  | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab167100d19f31a0eb94a863aa8a154c6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a91514832362b13fd231dede583ae94ef)SetKilled()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.SetKilled | ( |  | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a438891fdc394bfd6993824f8827343f1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a24c1b80d4636b35e0cc5a9da461ce35a)SetRouted()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.SetRouted | ( | bool | *isOrderRetreat* | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a4d0a73e7aaeb8df3ffaf3239bc39e212).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#aa6a9e8030aa673843ae0073d377e8820)OnAgentRemoved()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.OnAgentRemoved | ( | float | *agentHealth* | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a72051987ed67f5c1425e7f5bf1c47479).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a329e9da3b1b78503a7c6724758611770)SetBanner()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.SetBanner | ( | [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a86aad1bbcb2a22790ff8c506f1fe5806) | *banner* | ) |  |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aa411d63117f2804949cc66b9fb8b762c).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#abd9eb111cb727052ea0cb05c3fd68a6b)CustomBattleCombatant
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CustomBattleCombatant TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.CustomBattleCombatant | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a6cd471e06cfb3c2189ec36819afb56ba)Troop
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.Troop | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a0d06f9cb48e698deeaea198032641071).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a4316ac04f7cf12a492b9451b9abfa5f5)Rank
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.Rank | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a86aad1bbcb2a22790ff8c506f1fe5806)Banner
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.Banner | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#ab5cfbab0ba6a53da4965d6a4f7425d3b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a9f7c4b230bc3dc058913699164aaa67a)IsUnderPlayersCommand
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.IsUnderPlayersCommand | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#aedb89daad1f6f8b34f0568395fa7f789).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a59b4d88b37fd762a79ea92080acfa2b1)FactionColor
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.FactionColor | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a10a63fd7006739b4d6d4ae154a5c0b2c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a401200a838b1fd2c164db002f33d23b1)FactionColor2
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.FactionColor2 | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a2e1c8f930df2af3fb33231f312d64237).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#ab8402e937a40d93aed770800cec15494)Seed
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.Seed | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a89eb1c68b129baa62cee10f30e862c0e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_agent_origin.html#a48e9db1e295e60ed963a3cd286cefd26)UniqueSeed
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.CustomBattleAgentOrigin.UniqueSeed | | get |

Implements [TaleWorlds.Core.IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html#a95d4c2d79eeee3dab9ba814a6943eb69).


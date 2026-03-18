--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition-1-g.html ---

TaleWorlds.MountAndBlade.MPPerkCondition< T > Class Template ReferenceabstractInherits [TaleWorlds.MountAndBlade.MPPerkCondition](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html).

|  |  |
| --- | --- |
| Protected Member Functions | |
| override bool | [IsGameModesValid](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition-1-g.html#a4ea585d0d18afb48455d81b4c5976423) (List< string > gameModes) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MPPerkCondition](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html) | |
| void | [Deserialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a53feb3b8d44d5dccd3a8ceed5b2aee5c) (XmlNode node) |

|  |  |
| --- | --- |
| Properties | |
| T | [GameModeInstance](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition-1-g.html#acfd69b6d8d8a122852ef53436ab48969) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.MPPerkCondition](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html) | |
| virtual [PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) | [EventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a1c610e5d9c92d8a6ea1e06315ab672eb) `[get]` |
| virtual bool | [IsPeerCondition](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a852090fb19e39873332f442be2588e80) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.MountAndBlade.MPPerkCondition](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html) | |
| enum | [PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a6adf97f83acf6453d4a6a4b1070f3754) = 0x0 ,     [MoraleChange](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a576dd694671f052ec54024ff51fec97c) = 0x00000001 ,     [FlagCapture](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a9f046643687270f61dc8f3ae8663a988) = 0x00000002 ,     [FlagRemoval](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a5fac575ba37466d1a122d41ecd261ac1) = 0x00000004 ,     [HealthChange](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a9c1b4bf686d1d456820fe5fa0b92bdcd) = 0x00000008 ,     [AliveBotCountChange](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a9490e096b00784c554dabb1366f1054c) = 0x00000010 ,     [PeerControlledAgentChange](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4aa17db2184163a25479218b9dcdf165d9) = 0x00000020 ,     [BannerPickUp](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a0072ac8bbca9aacd3c6e32abe7e5066e) = 0x00000040 ,     [BannerDrop](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a66b1bcd26c3b92f00b6bec2b5f742daa) = 0x00000080 ,     [SpawnEnd](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a247e316ba0590cf11d8d9e6495b7e9e8) = 0x00000100 ,     [MountHealthChange](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a6cad0c3beb6df14f5714427faa702715) = 0x00000200 ,     [MountChange](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a469901dbb2fad29e96f980995b3d6fd7) = 0x00000400 ,     [AgentEventsMask](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a9cd1b3b4d2d6a88a962d6bfe57eacbca) = HealthChange | PeerControlledAgentChange | MountHealthChange | MountChange   } |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MPPerkCondition](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html) | |
| bool | [Check](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#abfaed3337f7dfe840a51fd0503e4a2d2) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| bool | [Check](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a9a22cd15eb0c4361d91ee6a92218220b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| Static Public Member Functions inherited from [TaleWorlds.MountAndBlade.MPPerkCondition](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html) | |
| static MPPerkCondition | [CreateFrom](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a0cb03d890d52a3d758ad0444bd659958) (List< string > gameModes, XmlNode node) |
| Static Protected Attributes inherited from [TaleWorlds.MountAndBlade.MPPerkCondition](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html) | |
| static Dictionary< string, Type > | [Registered](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#aa0621fb718832c30cafbc9a876af08be) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition-1-g.html#a4ea585d0d18afb48455d81b4c5976423)IsGameModesValid()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool [TaleWorlds.MountAndBlade.MPPerkCondition](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html)< T >.IsGameModesValid | ( | List< string > | *gameModes* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MPPerkCondition](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a6860b6c587411f986c0017775a352218).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition-1-g.html#acfd69b6d8d8a122852ef53436ab48969)GameModeInstance
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | T [TaleWorlds.MountAndBlade.MPPerkCondition](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html)< T >.GameModeInstance | | getprotected |


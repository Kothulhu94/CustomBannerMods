--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html ---

TaleWorlds.MountAndBlade.MPPerkCondition Class ReferenceabstractInherited by [TaleWorlds.MountAndBlade.MPPerkCondition< T >](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition-1-g.html), and [TaleWorlds.MountAndBlade.Network.Gameplay.Perks.Conditions.BannerBearerCondition](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_gameplay_1_1_perks_1_1_conditions_1_1_banner_bearer_condition.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a6adf97f83acf6453d4a6a4b1070f3754) = 0x0 ,     [MoraleChange](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a576dd694671f052ec54024ff51fec97c) = 0x00000001 ,     [FlagCapture](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a9f046643687270f61dc8f3ae8663a988) = 0x00000002 ,     [FlagRemoval](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a5fac575ba37466d1a122d41ecd261ac1) = 0x00000004 ,     [HealthChange](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a9c1b4bf686d1d456820fe5fa0b92bdcd) = 0x00000008 ,     [AliveBotCountChange](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a9490e096b00784c554dabb1366f1054c) = 0x00000010 ,     [PeerControlledAgentChange](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4aa17db2184163a25479218b9dcdf165d9) = 0x00000020 ,     [BannerPickUp](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a0072ac8bbca9aacd3c6e32abe7e5066e) = 0x00000040 ,     [BannerDrop](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a66b1bcd26c3b92f00b6bec2b5f742daa) = 0x00000080 ,     [SpawnEnd](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a247e316ba0590cf11d8d9e6495b7e9e8) = 0x00000100 ,     [MountHealthChange](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a6cad0c3beb6df14f5714427faa702715) = 0x00000200 ,     [MountChange](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a469901dbb2fad29e96f980995b3d6fd7) = 0x00000400 ,     [AgentEventsMask](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4a9cd1b3b4d2d6a88a962d6bfe57eacbca) = HealthChange | PeerControlledAgentChange | MountHealthChange | MountChange   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [Check](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#abfaed3337f7dfe840a51fd0503e4a2d2) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| bool | [Check](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a9a22cd15eb0c4361d91ee6a92218220b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static MPPerkCondition | [CreateFrom](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a0cb03d890d52a3d758ad0444bd659958) (List< string > gameModes, XmlNode node) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual bool | [IsGameModesValid](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a6860b6c587411f986c0017775a352218) (List< string > gameModes) |
| void | [Deserialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a53feb3b8d44d5dccd3a8ceed5b2aee5c) (XmlNode node) |

|  |  |
| --- | --- |
| Static Protected Attributes | |
| static Dictionary< string, Type > | [Registered](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#aa0621fb718832c30cafbc9a876af08be) |

|  |  |
| --- | --- |
| Properties | |
| virtual [PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) | [EventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a1c610e5d9c92d8a6ea1e06315ab672eb) `[get]` |
| virtual bool | [IsPeerCondition](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a852090fb19e39873332f442be2588e80) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4)PerkEventFlags
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MPPerkCondition.PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) |

| Enumerator | |
| --- | --- |
| None |  |
| MoraleChange |  |
| FlagCapture |  |
| FlagRemoval |  |
| HealthChange |  |
| AliveBotCountChange |  |
| PeerControlledAgentChange |  |
| BannerPickUp |  |
| BannerDrop |  |
| SpawnEnd |  |
| MountHealthChange |  |
| MountChange |  |
| AgentEventsMask |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#abfaed3337f7dfe840a51fd0503e4a2d2)Check() [1/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MPPerkCondition.Check | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a9a22cd15eb0c4361d91ee6a92218220b)Check() [2/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MPPerkCondition.Check | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a6860b6c587411f986c0017775a352218)IsGameModesValid()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MPPerkCondition.IsGameModesValid | ( | List< string > | *gameModes* | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.MPPerkCondition< T >](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition-1-g.html#a4ea585d0d18afb48455d81b4c5976423).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a53feb3b8d44d5dccd3a8ceed5b2aee5c)Deserialize()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MPPerkCondition.Deserialize | ( | XmlNode | *node* | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a0cb03d890d52a3d758ad0444bd659958)CreateFrom()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MPPerkCondition TaleWorlds.MountAndBlade.MPPerkCondition.CreateFrom | ( | List< string > | *gameModes*, | |  |  | XmlNode | *node* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#aa0621fb718832c30cafbc9a876af08be)Registered
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, Type> TaleWorlds.MountAndBlade.MPPerkCondition.Registered | | staticprotected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a1c610e5d9c92d8a6ea1e06315ab672eb)EventFlags
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [PerkEventFlags](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#add7419f62f3a83105dfb9afc41d939a4) TaleWorlds.MountAndBlade.MPPerkCondition.EventFlags | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_condition.html#a852090fb19e39873332f442be2588e80)IsPeerCondition
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.MountAndBlade.MPPerkCondition.IsPeerCondition | | get |


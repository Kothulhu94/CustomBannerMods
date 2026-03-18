--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html ---

TaleWorlds.MountAndBlade.MissionPeer Class ReferenceInherits [TaleWorlds.Core.PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnUpdateEquipmentSetIndexEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a6bf084c46bd8f79b52a8eb384faab4cc) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) lobbyPeer, int equipmentSetIndex) |
| delegate void | [OnPerkUpdateEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aedebc09fb3cf744575f55e85ae64edd3) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) peer) |
| delegate void | [OnTeamChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a52500f38a8f98ad6c1197dc276bcb936) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) peer, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aa01de8c58cec236071e04d3edaadae69) previousTeam, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aa01de8c58cec236071e04d3edaadae69) newTeam) |
| delegate void | [OnCultureChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ad3b00f58a05ddc021deaf932f4001236) ([BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) newCulture) |
| delegate void | [OnPlayerKilledDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ae0171d82dc9da6ccd7983d3a0cb4c85c) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) killerPeer, [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) killedPeer) |
|  | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) () |
| void | [SetMutedFromPlatform](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a7c1494d3e76550dd202825ae93266b68) (bool isMuted) |
| void | [SetMuted](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ae982c9191b4388014f35925c75cafae4) (bool isMuted) |
| void | [ResetRequestedKickPollCount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#afa8bc4953e904601a1c25b5c87a98bac) () |
| void | [IncrementRequestedKickPollCount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a71dbd6d1ec68eb638346f0e23dbb7c60) () |
| int | [GetSelectedPerkIndexWithPerkListIndex](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a4ce25b7aa9c0e7cd776001d2084d54b9) (int troopIndex, int perkListIndex) |
| bool | [SelectPerk](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a47ae657c846c60c614e84ff3e14597fe) (int perkListIndex, int perkIndex, int enforcedSelectedTroopIndex=-1) |
| void | [HandleVoteChange](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a9a5e6497894ec7acada67bfc51217052) ([CultureVoteTypes](namespace_tale_worlds_1_1_mount_and_blade.html#a5baf7ad76f6c62066c21ac9085ceee05) voteType, [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) culture) |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ab8b3a0f90175768ea884543db49f71a3) () |
| override void | [OnInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a3980706690e7c9722d833d71171a1fe4) () |
| int | [GetAmountOfAgentVisualsForPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#af32f5cce019abc50ab4be975bc7b6fa0) () |
| [PeerVisualsHolder](class_tale_worlds_1_1_mount_and_blade_1_1_peer_visuals_holder.html) | [GetVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a562b73d54847d5694ab1f1615fc05ff4) (int visualIndex) |
| void | [ClearVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a6f5534ab584769dae27b7e1ddd6d679d) (int visualIndex) |
| void | [ClearAllVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a9ba74255c3e0c7746db9622141c3fae3) (bool freeResources=false) |
| void | [OnVisualsSpawned](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a17f232f554d44d3d61cb40eeb60bf290) ([PeerVisualsHolder](class_tale_worlds_1_1_mount_and_blade_1_1_peer_visuals_holder.html) visualsHolder, int visualIndex) |
| IEnumerable< [IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html) > | [GetAllAgentVisualsForPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#abc6b19c0c5f17d7e7fca1386c45bc272) () |
| [IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html) | [GetAgentVisualForPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a69fae21ab9c64533f625af2d7e0c2dc3) (int visualsIndex) |
| [IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html) | [GetAgentVisualForPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a267e3ac75dc99678fc3b3f518fe83ac6) (int visualsIndex, out [IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html) mountAgentVisuals) |
| void | [TickInactivityStatus](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a4b547cbd240b0c37da333d519a701b29) () |
| void | [OnKillAnotherPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#af5b709ab4a2f603720033471ea7035ea) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) victimPeer) |
| void | [OverrideCultureWithTeamCulture](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a39018ca7f1d69ee14432ff1823775868) () |
| int | [GetNumberOfTimesPeerKilledPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a6619d2523c922da5b3ce53ca9f1e0a08) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) killedPeer) |
| void | [ResetKillRegistry](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a7525722a94007bc35d03c1bdb9caff23) () |
| bool | [RefreshSelectedPerks](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aa7ed2ab0b472e65879e1af703e099a3e) () |
| void | [OnTeamInitialPerkInfoReceived](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aaeb0358d8fccae092236fe319199fd72) (int[] perks) |
| Public Member Functions inherited from [TaleWorlds.Core.PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | |
| virtual void | [Initialize](class_tale_worlds_1_1_core_1_1_peer_component.html#a58487504c7c2600d31ad90c63cff06df) () |
| T | [GetComponent< T >](class_tale_worlds_1_1_core_1_1_peer_component.html#a10c7cee39e2ba15cdf532e4cbe947080) () |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [CaptainBeingDetachedThreshold](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#af6dca6a35a62c55d1b9e47cdf73ebdbe) = 125 |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [NumberOfPerkLists](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aba6ef491ee5ebacb3b61e0146d856475) = 3 |
| const int | [MaxNumberOfTroopTypesPerCulture](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ad14554c7c88781c1c10feda0917816be) = 16 |
| const int | [MinKDACount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a72c90ee97bd4f653e04e61069b5641a2) = -1000 |
| const int | [MaxKDACount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#af687e2a471f976126fa4ee082f1cb08f) = 100000 |
| const int | [MinScore](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a9729f2a98cb382ef92f1c2b41d7e9370) = -1000000 |
| const int | [MaxScore](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#abe0c8f8f9d657191c1325fff61e61a74) = 1000000 |
| const int | [MinSpawnTimer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a5264cb0fc4d016e66e60005710d36a91) = 3 |

|  |  |
| --- | --- |
| Properties | |
| DateTime | [JoinTime](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a1fe7db91fa6a0933316b4c57d3d7c2a7) `[get]` |
| bool | [EquipmentUpdatingExpired](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a85f2c11d99442a5fdf555e089df2e169) = false `[get, set]` |
| bool | [TeamInitialPerkInfoReady](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a447a028c37be4c76b05577730e121f36) `[get]` |
| bool | [HasSpawnedAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ad4f1b25eb6f47e6539d0b1ec0563b5db) `[get, set]` |
| int | [SelectedTroopIndex](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#adb81ba871fa9be980251e6d1de1701c7) `[get, set]` |
| int | [NextSelectedTroopIndex](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#acb29e954d54ad806e4ac57e21df45432) `[get, set]` |
| [MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | [Representative](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a76bbaa3d453ed94f5cc4cfd85388952b) `[get]` |
| MBReadOnlyList< int[]> | [Perks](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a32ee2e5a7e3408b2271b712b7c7cb2a9) `[get]` |
| string | [DisplayedName](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a83167e0d127815f88f195087c222916b) `[get]` |
| MBReadOnlyList< [MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html) > | [SelectedPerks](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a15ad003ee83ded07f7aa433724b3a68b) `[get]` |
| [Timer](class_tale_worlds_1_1_core_1_1_timer.html) | [SpawnTimer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ac7c97c2ebd0f5ac0d88c01567e35397b) `[get]` |
| bool | [HasSpawnTimerExpired](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a2fb3d67f291d0ac0d5618951d61dcba6) `[get, set]` |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [VotedForBan](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a041557c6cc98f9b9f1b08d1ba592e586) `[get]` |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [VotedForSelection](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a31fb37b5aff8bdec8258f3d528c226ab) `[get]` |
| bool | [WantsToSpawnAsBot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a21022f37e41ce724df0429e12d72f7cb) `[get, set]` |
| int | [SpawnCountThisRound](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a64e4d711cbce0c4aa1c313801815c496) `[get, set]` |
| int | [RequestedKickPollCount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a5eb77c020fe4b0b20f4ade6821335f76) `[get]` |
| int | [KillCount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aad1a01f852853f656b4196f6f12c2059) `[get]` |
| int | [AssistCount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#acd2553cfb50f07c5feb0694421c9bc20) `[get]` |
| int | [DeathCount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a31abb6b7e252d17a0052f0da8f9f12a9) `[get]` |
| int | [Score](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a14c780170ed63974f98a7b7750878e27) `[get]` |
| int | [BotsUnderControlAlive](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a00f6bcee4991c36a7986212e047dafd2) `[get, set]` |
| int | [BotsUnderControlTotal](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a2a8b1c830137ebd33f8255be1fe61a84) `[get]` |
| bool | [IsControlledAgentActive](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a0fe1913f482db885af89984d51e4eafc) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [ControlledAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a04f231fdbdd2d83bd1b1febc856cc011) `[get, set]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [FollowedAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a293099f73a017493080e76b9ef2da0a8) `[get, set]` |
| Team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aa01de8c58cec236071e04d3edaadae69) `[get, set]` |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [Culture](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ae7b363d129ee9e2fdd84fb5ac27b2a4f) `[get, set]` |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [ControlledFormation](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a47a9231649bd164ea8d418a0e4835f86) `[get, set]` |
| bool | [IsAgentAliveForChatting](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a3c87602def397bf75b6eabfec5908e12) `[get]` |
| bool | [IsMutedFromPlatform](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ac209a345985a3133412147f683b81bce) `[get]` |
| bool | [IsMuted](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a5b49f9eb54af0b67228fe9d231def301) `[get]` |
| bool | [IsMutedFromGameOrPlatform](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a3ed479c034e991ad83ad88bc24f69798) `[get]` |
| Properties inherited from [TaleWorlds.Core.PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | |
| [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) | [Peer](class_tale_worlds_1_1_core_1_1_peer_component.html#a0b55a99e5343ad8152dda65b6772fae3) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_core_1_1_peer_component.html#a2bf947d41e1e13df87c579ebfe013feb) `[get]` |
|  | [Platform](namespace_tale_worlds_1_1_library.html#aab3fe05d1610830a919823c10105cc1c) provided (GDK, Steam, etc.) name of the peer. Used in logging. MissionPeer.DisplayedName is used to display the name in game. |
| bool | [IsMine](class_tale_worlds_1_1_core_1_1_peer_component.html#a466560d242dc24f6cf2cbe4a156de7fd) `[get]` |
| uint | [TypeId](class_tale_worlds_1_1_core_1_1_peer_component.html#a51ed4bd65c904826b7a63e6fe908a06d) `[get, set]` |

|  |  |
| --- | --- |
| Events | |
| static [OnUpdateEquipmentSetIndexEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a6bf084c46bd8f79b52a8eb384faab4cc) | [OnEquipmentIndexRefreshed](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a4e0615e306d4f56412a9ecc0b2622cf0) |
| static [OnPerkUpdateEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aedebc09fb3cf744575f55e85ae64edd3) | [OnPerkSelectionUpdated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a35b0f2a19f1880523deb8cb1780e9ea3) |
| static [OnTeamChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a52500f38a8f98ad6c1197dc276bcb936) | [OnPreTeamChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a92e59a16f9057929c535ab13eb46e6f6) |
| static [OnTeamChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a52500f38a8f98ad6c1197dc276bcb936) | [OnTeamChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a81e81c419bebd4062d49410f54ebd9d9) |
| static [OnPlayerKilledDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ae0171d82dc9da6ccd7983d3a0cb4c85c) | [OnPlayerKilled](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a7b09b072d3f078cbf268e73dfdc93277) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f)MissionPeer()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionPeer.MissionPeer | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a6bf084c46bd8f79b52a8eb384faab4cc)OnUpdateEquipmentSetIndexEventDelegate()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MissionPeer.OnUpdateEquipmentSetIndexEventDelegate | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) | *lobbyPeer*, |
|  |  | int | *equipmentSetIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aedebc09fb3cf744575f55e85ae64edd3)OnPerkUpdateEventDelegate()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MissionPeer.OnPerkUpdateEventDelegate | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) | *peer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a52500f38a8f98ad6c1197dc276bcb936)OnTeamChangedDelegate()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MissionPeer.OnTeamChangedDelegate | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *peer*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aa01de8c58cec236071e04d3edaadae69) | *previousTeam*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aa01de8c58cec236071e04d3edaadae69) | *newTeam* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ad3b00f58a05ddc021deaf932f4001236)OnCultureChangedDelegate()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MissionPeer.OnCultureChangedDelegate | ( | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *newCulture* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ae0171d82dc9da6ccd7983d3a0cb4c85c)OnPlayerKilledDelegate()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MissionPeer.OnPlayerKilledDelegate | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) | *killerPeer*, |
|  |  | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) | *killedPeer* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a7c1494d3e76550dd202825ae93266b68)SetMutedFromPlatform()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.SetMutedFromPlatform | ( | bool | *isMuted* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ae982c9191b4388014f35925c75cafae4)SetMuted()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.SetMuted | ( | bool | *isMuted* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#afa8bc4953e904601a1c25b5c87a98bac)ResetRequestedKickPollCount()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.ResetRequestedKickPollCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a71dbd6d1ec68eb638346f0e23dbb7c60)IncrementRequestedKickPollCount()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.IncrementRequestedKickPollCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a4ce25b7aa9c0e7cd776001d2084d54b9)GetSelectedPerkIndexWithPerkListIndex()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionPeer.GetSelectedPerkIndexWithPerkListIndex | ( | int | *troopIndex*, |
|  |  | int | *perkListIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a47ae657c846c60c614e84ff3e14597fe)SelectPerk()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionPeer.SelectPerk | ( | int | *perkListIndex*, |
|  |  | int | *perkIndex*, |
|  |  | int | *enforcedSelectedTroopIndex* = -1 ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a9a5e6497894ec7acada67bfc51217052)HandleVoteChange()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.HandleVoteChange | ( | [CultureVoteTypes](namespace_tale_worlds_1_1_mount_and_blade.html#a5baf7ad76f6c62066c21ac9085ceee05) | *voteType*, |
|  |  | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *culture* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ab8b3a0f90175768ea884543db49f71a3)OnFinalize()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionPeer.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html#a0c4362730984fd102625cb716e4632a6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a3980706690e7c9722d833d71171a1fe4)OnInitialize()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionPeer.OnInitialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html#a68180b2dc821f86d05865f69edfc1d0f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#af32f5cce019abc50ab4be975bc7b6fa0)GetAmountOfAgentVisualsForPeer()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionPeer.GetAmountOfAgentVisualsForPeer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a562b73d54847d5694ab1f1615fc05ff4)GetVisuals()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PeerVisualsHolder](class_tale_worlds_1_1_mount_and_blade_1_1_peer_visuals_holder.html) TaleWorlds.MountAndBlade.MissionPeer.GetVisuals | ( | int | *visualIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a6f5534ab584769dae27b7e1ddd6d679d)ClearVisuals()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.ClearVisuals | ( | int | *visualIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a9ba74255c3e0c7746db9622141c3fae3)ClearAllVisuals()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.ClearAllVisuals | ( | bool | *freeResources* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a17f232f554d44d3d61cb40eeb60bf290)OnVisualsSpawned()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.OnVisualsSpawned | ( | [PeerVisualsHolder](class_tale_worlds_1_1_mount_and_blade_1_1_peer_visuals_holder.html) | *visualsHolder*, |
|  |  | int | *visualIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#abc6b19c0c5f17d7e7fca1386c45bc272)GetAllAgentVisualsForPeer()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html) > TaleWorlds.MountAndBlade.MissionPeer.GetAllAgentVisualsForPeer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a69fae21ab9c64533f625af2d7e0c2dc3)GetAgentVisualForPeer() [1/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html) TaleWorlds.MountAndBlade.MissionPeer.GetAgentVisualForPeer | ( | int | *visualsIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a267e3ac75dc99678fc3b3f518fe83ac6)GetAgentVisualForPeer() [2/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html) TaleWorlds.MountAndBlade.MissionPeer.GetAgentVisualForPeer | ( | int | *visualsIndex*, |
|  |  | out [IAgentVisual](interface_tale_worlds_1_1_mount_and_blade_1_1_i_agent_visual.html) | *mountAgentVisuals* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a4b547cbd240b0c37da333d519a701b29)TickInactivityStatus()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.TickInactivityStatus | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#af5b709ab4a2f603720033471ea7035ea)OnKillAnotherPeer()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.OnKillAnotherPeer | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) | *victimPeer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a39018ca7f1d69ee14432ff1823775868)OverrideCultureWithTeamCulture()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.OverrideCultureWithTeamCulture | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a6619d2523c922da5b3ce53ca9f1e0a08)GetNumberOfTimesPeerKilledPeer()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionPeer.GetNumberOfTimesPeerKilledPeer | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a8f5688dea3a59f725200a4008d371e4f) | *killedPeer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a7525722a94007bc35d03c1bdb9caff23)ResetKillRegistry()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.ResetKillRegistry | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aa7ed2ab0b472e65879e1af703e099a3e)RefreshSelectedPerks()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionPeer.RefreshSelectedPerks | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aaeb0358d8fccae092236fe319199fd72)OnTeamInitialPerkInfoReceived()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionPeer.OnTeamInitialPerkInfoReceived | ( | int[] | *perks* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aba6ef491ee5ebacb3b61e0146d856475)NumberOfPerkLists
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionPeer.NumberOfPerkLists = 3 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ad14554c7c88781c1c10feda0917816be)MaxNumberOfTroopTypesPerCulture
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionPeer.MaxNumberOfTroopTypesPerCulture = 16 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a72c90ee97bd4f653e04e61069b5641a2)MinKDACount
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionPeer.MinKDACount = -1000 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#af687e2a471f976126fa4ee082f1cb08f)MaxKDACount
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionPeer.MaxKDACount = 100000 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a9729f2a98cb382ef92f1c2b41d7e9370)MinScore
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionPeer.MinScore = -1000000 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#abe0c8f8f9d657191c1325fff61e61a74)MaxScore
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionPeer.MaxScore = 1000000 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a5264cb0fc4d016e66e60005710d36a91)MinSpawnTimer
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionPeer.MinSpawnTimer = 3 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#af6dca6a35a62c55d1b9e47cdf73ebdbe)CaptainBeingDetachedThreshold
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.MissionPeer.CaptainBeingDetachedThreshold = 125 |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a1fe7db91fa6a0933316b4c57d3d7c2a7)JoinTime
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | DateTime TaleWorlds.MountAndBlade.MissionPeer.JoinTime | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a85f2c11d99442a5fdf555e089df2e169)EquipmentUpdatingExpired
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionPeer.EquipmentUpdatingExpired = false | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a447a028c37be4c76b05577730e121f36)TeamInitialPerkInfoReady
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionPeer.TeamInitialPerkInfoReady | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ad4f1b25eb6f47e6539d0b1ec0563b5db)HasSpawnedAgentVisuals
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionPeer.HasSpawnedAgentVisuals | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#adb81ba871fa9be980251e6d1de1701c7)SelectedTroopIndex
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionPeer.SelectedTroopIndex | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#acb29e954d54ad806e4ac57e21df45432)NextSelectedTroopIndex
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionPeer.NextSelectedTroopIndex | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a76bbaa3d453ed94f5cc4cfd85388952b)Representative
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) TaleWorlds.MountAndBlade.MissionPeer.Representative | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a32ee2e5a7e3408b2271b712b7c7cb2a9)Perks
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<int[]> TaleWorlds.MountAndBlade.MissionPeer.Perks | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a83167e0d127815f88f195087c222916b)DisplayedName
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MissionPeer.DisplayedName | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a15ad003ee83ded07f7aa433724b3a68b)SelectedPerks
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MPPerkObject](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object.html)> TaleWorlds.MountAndBlade.MissionPeer.SelectedPerks | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ac7c97c2ebd0f5ac0d88c01567e35397b)SpawnTimer
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Timer](class_tale_worlds_1_1_core_1_1_timer.html) TaleWorlds.MountAndBlade.MissionPeer.SpawnTimer | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a2fb3d67f291d0ac0d5618951d61dcba6)HasSpawnTimerExpired
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionPeer.HasSpawnTimerExpired | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a041557c6cc98f9b9f1b08d1ba592e586)VotedForBan
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.MountAndBlade.MissionPeer.VotedForBan | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a31fb37b5aff8bdec8258f3d528c226ab)VotedForSelection
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.MountAndBlade.MissionPeer.VotedForSelection | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a21022f37e41ce724df0429e12d72f7cb)WantsToSpawnAsBot
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionPeer.WantsToSpawnAsBot | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a64e4d711cbce0c4aa1c313801815c496)SpawnCountThisRound
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionPeer.SpawnCountThisRound | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a5eb77c020fe4b0b20f4ade6821335f76)RequestedKickPollCount
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionPeer.RequestedKickPollCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aad1a01f852853f656b4196f6f12c2059)KillCount
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionPeer.KillCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#acd2553cfb50f07c5feb0694421c9bc20)AssistCount
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionPeer.AssistCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a31abb6b7e252d17a0052f0da8f9f12a9)DeathCount
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionPeer.DeathCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a14c780170ed63974f98a7b7750878e27)Score
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionPeer.Score | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a00f6bcee4991c36a7986212e047dafd2)BotsUnderControlAlive
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionPeer.BotsUnderControlAlive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a2a8b1c830137ebd33f8255be1fe61a84)BotsUnderControlTotal
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionPeer.BotsUnderControlTotal | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a0fe1913f482db885af89984d51e4eafc)IsControlledAgentActive
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionPeer.IsControlledAgentActive | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a04f231fdbdd2d83bd1b1febc856cc011)ControlledAgent
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.MissionPeer.ControlledAgent | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a293099f73a017493080e76b9ef2da0a8)FollowedAgent
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.MissionPeer.FollowedAgent | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aa01de8c58cec236071e04d3edaadae69)Team
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Team TaleWorlds.MountAndBlade.MissionPeer.Team | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ae7b363d129ee9e2fdd84fb5ac27b2a4f)Culture
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.MountAndBlade.MissionPeer.Culture | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a47a9231649bd164ea8d418a0e4835f86)ControlledFormation
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.MissionPeer.ControlledFormation | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a3c87602def397bf75b6eabfec5908e12)IsAgentAliveForChatting
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionPeer.IsAgentAliveForChatting | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ac209a345985a3133412147f683b81bce)IsMutedFromPlatform
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionPeer.IsMutedFromPlatform | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a5b49f9eb54af0b67228fe9d231def301)IsMuted
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionPeer.IsMuted | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a3ed479c034e991ad83ad88bc24f69798)IsMutedFromGameOrPlatform
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MissionPeer.IsMutedFromGameOrPlatform | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a4e0615e306d4f56412a9ecc0b2622cf0)OnEquipmentIndexRefreshed
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnUpdateEquipmentSetIndexEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a6bf084c46bd8f79b52a8eb384faab4cc) TaleWorlds.MountAndBlade.MissionPeer.OnEquipmentIndexRefreshed | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a35b0f2a19f1880523deb8cb1780e9ea3)OnPerkSelectionUpdated
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnPerkUpdateEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#aedebc09fb3cf744575f55e85ae64edd3) TaleWorlds.MountAndBlade.MissionPeer.OnPerkSelectionUpdated | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a92e59a16f9057929c535ab13eb46e6f6)OnPreTeamChanged
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnTeamChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a52500f38a8f98ad6c1197dc276bcb936) TaleWorlds.MountAndBlade.MissionPeer.OnPreTeamChanged | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a81e81c419bebd4062d49410f54ebd9d9)OnTeamChanged
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnTeamChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a52500f38a8f98ad6c1197dc276bcb936) TaleWorlds.MountAndBlade.MissionPeer.OnTeamChanged | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a7b09b072d3f078cbf268e73dfdc93277)OnPlayerKilled
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OnPlayerKilledDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ae0171d82dc9da6ccd7983d3a0cb4c85c) TaleWorlds.MountAndBlade.MissionPeer.OnPlayerKilled | | static |


--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html ---

TaleWorlds.MountAndBlade.MultiplayerOptions Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [MultiplayerOption](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_1_1_multiplayer_option.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [MultiplayerOptionsAccessMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574) {     [DefaultMapOptions](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574aa86aea3ff6d706fa36e3c5261873b4e1) ,     [CurrentMapOptions](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574a03c496b39ceba47f8404591e8e4a7c9d) ,     [NextMapOptions](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574a8c5865750f2b574a0205a4f5c94ce69b) ,     [NumAccessModes](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574aa7480a66625b2dcdca18b24da827f43b)   } |
| enum | [OptionValueType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a9b4cd111fd32543a1e74b47c17fe1476) {     [Bool](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a9b4cd111fd32543a1e74b47c17fe1476ac26f15e86e3de4c398a8273272aba034) ,     [Integer](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a9b4cd111fd32543a1e74b47c17fe1476aa0faef0851b4294c06f2b94bb1cb2044) ,     [Enum](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a9b4cd111fd32543a1e74b47c17fe1476acf20423ed48998082c20099488a0917c) ,     [String](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a9b4cd111fd32543a1e74b47c17fe1476a27118326006d3829667a400ad23d5d98)   } |
| enum | [OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) {     [ServerName](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a1b8588424b9bc162b2192f326326df85) ,     [WelcomeMessage](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a85b102fe2fc48f51dfcddd31db9c8b6f) ,     [GamePassword](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5ae067e6a2d0442a9e9dbeab4cdef4b4a6) ,     [AdminPassword](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5aac37154dff754bcf60ccf3da555da312) ,     [GameDefinitionId](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5ac62cd4ddb879828c5274471923b293a5) ,     [AllowPollsToKickPlayers](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a07303ce6a6381bceab1278045b013b17) ,     [AllowPollsToBanPlayers](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a119a2b6750777b46d91cbcfb1680791f) ,     [AllowPollsToChangeMaps](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a447842b54f35522eef4b6851c78cadff) ,     [AllowIndividualBanners](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a4a503d22c23dbd1f1ba9b48ab6c35449) ,     [UseRealisticBlocking](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a0ee5737699c87f434d36d78876dc18ff) ,     [PremadeMatchGameMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5ae8b8381245617431d2c344661b0cd68c) ,     [GameType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5afcb34b6c36bd6c046af317a0e1f1fa19) ,     [PremadeGameType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5aeea98113427cef86ea3304de9f3dc8b4) ,     [Map](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a46f3ea056caa3126b91f3f70beea068c) ,     [CultureTeam1](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a1e44aca8158036074edf46ecdfe193d2) ,     [CultureTeam2](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a8ac0451a2d7c37cfea9e64c57b6079f8) ,     [MaxNumberOfPlayers](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a7c54a78c3a20d96011e269820e268673) ,     [MinNumberOfPlayersForMatchStart](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5ac756e5e9058314141b4a0640553c63b0) ,     [NumberOfBotsTeam1](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a404e62f0a28d6041ec6f137c6a5c51ea) ,     [NumberOfBotsTeam2](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5af094fbb1e728975decdd8298ba50036f) ,     [NumberOfBotsPerFormation](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a280c066f604226902d49b53fceb374de) ,     [FriendlyFireDamageMeleeSelfPercent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5afb6ed77d56c61ec44e9f1b7559a2b785) ,     [FriendlyFireDamageMeleeFriendPercent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a50c8968530a6e771f2336c2820d651b9) ,     [FriendlyFireDamageRangedSelfPercent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5abc39b67924597f963d9743a3dd8f3a54) ,     [FriendlyFireDamageRangedFriendPercent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a99285e12e02172c85401765258b7b64f) ,     [SpectatorCamera](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5afb96345c0cd481572ed26d10a380b41b) ,     [WarmupTimeLimitInSeconds](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a4749aa976b0b7b5e31d1003842e967c0) ,     [MapTimeLimit](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5ad1273130a040d57bbf10c9ef10cd7b1f) ,     [RoundTimeLimit](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a7eb332a3be328b29cb5c05c29a43ebb5) ,     [RoundPreparationTimeLimit](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a46eac05bf2ddb09ec96e188c30da5507) ,     [RoundTotal](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5af8a6410c2c6f14f6c959159f968ab622) ,     [RespawnPeriodTeam1](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5ac215671c5384bdf5567fea4bcf5717d6) ,     [RespawnPeriodTeam2](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a68ca4b73202ce18f9f95b05e7f65bcbb) ,     [UnlimitedGold](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a756683fb5e3aa2471beb94a72cc12f2a) ,     [GoldGainChangePercentageTeam1](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a4742ee557f4d84f70050d3cc75ba6144) ,     [GoldGainChangePercentageTeam2](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a774c59fb80da5aa21c7893e1429732f9) ,     [MinScoreToWinMatch](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a965dce350077e2077f8839363c7a9a2c) ,     [MinScoreToWinDuel](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a748cc51e6ee8ebf9b6f584c0393011f7) ,     [PollAcceptThreshold](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a6000df9a4fbb4996fabe73b1f2f61d13) ,     [AutoTeamBalanceThreshold](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a4b6e3ab7efb9214691a2bb5e06d49d48) ,     [EnableMissionRecording](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5ae957c576d305327ceb758e9fb4e373a0) ,     [SingleSpawn](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a0fb16a28516a097f890a3b3d47b6d072) ,     [DisableInactivityKick](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5a385dee3d5d6f8f296cf69debf434afab) ,     [NumOfSlots](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5aa6ecafb5a680d03980a6dd5877ee943e)   } |
| enum | [OptionsCategory](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7caecb09a78b087f5d97aea6097ef195) {     [Default](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7caecb09a78b087f5d97aea6097ef195a7a1920d61156abc05a60135aefe8bc67) ,     [PremadeMatch](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7caecb09a78b087f5d97aea6097ef195a4155923de52defd8cbd01d1a13183a19)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MultiplayerOptions](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a6948f6b5849fadb651c405640817399a) () |
| [MultiplayerOption](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_1_1_multiplayer_option.html) | [GetOptionFromOptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7f4b106d6e7704675d01777768a368af) ([OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) optionType, [MultiplayerOptionsAccessMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574) mode=[MultiplayerOptionsAccessMode.CurrentMapOptions](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574a03c496b39ceba47f8404591e8e4a7c9d)) |
| void | [OnGameTypeChanged](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a4301ad3c44a0b6f356d541313575711d) ([MultiplayerOptionsAccessMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574) mode=[MultiplayerOptionsAccessMode.CurrentMapOptions](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574a03c496b39ceba47f8404591e8e4a7c9d)) |
| void | [InitializeNextAndDefaultOptionContainers](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#ace80b9492e6b91e2e8e3b27711d65bee) () |
| int | [GetNumberOfPlayersForGameMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#af7df5dcd15d629c24990dbcbbe4666ca) (string gameModeID) |
| int | [GetRoundCountForGameMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a15dd69c44f51c7784b47773ef7612ab8) (string gameModeID) |
| int | [GetRoundTimeLimitInMinutesForGameMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a71a037652104a9208e688871da69388b) (string gameModeID) |
| void | [InitializeFromCommandList](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a44928d026cfa2e095b9c1e42172e9edd) (List< string > arguments) |
| void | [ResetDefaultsToCurrent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a8dbdaa8153613be92469905fdbeec6a5) () |
| List< string > | [GetMultiplayerOptionsTextList](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a8d18cde4e6426cafc2d0363dac0dd1ae) ([OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) optionType) |
| List< string > | [GetMultiplayerOptionsList](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a952de58d2466064cc74745a03a523a88) ([OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) optionType) |
| void | [InitializeAllOptionsFromNext](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#af18ee8e09b72305887f007730788b10d) () |
| MBList< string > | [GetMapList](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a8eee6dfea2c12742cb542daa7ef54cd8) () |
| string | [GetValueTextForOptionWithMultipleSelection](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7bc0d1bffcc2019d27ae27f1ce74d75b) ([OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) optionType) |
| void | [SetValueForOptionWithMultipleSelectionFromText](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7dced4e70b5a999da278bd2f92640f7d) ([OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) optionType, string value) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [Release](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a62b8dfb240b280faf39b46b3c85a15d5) () |
| static bool | [TryGetOptionTypeFromString](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a3cb23e14cee5ad0b46f55b6e5d2f8d3a) (string optionTypeString, out [OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) optionType, out [MultiplayerOptionsProperty](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html) optionAttribute) |

|  |  |
| --- | --- |
| Public Attributes | |
| [OptionsCategory](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7caecb09a78b087f5d97aea6097ef195) | [CurrentOptionsCategory](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a82dfffd8d344b653f6788ae0fc986818) = [OptionsCategory.Default](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7caecb09a78b087f5d97aea6097ef195a7a1920d61156abc05a60135aefe8bc67) |

|  |  |
| --- | --- |
| Properties | |
| static [MultiplayerOptions](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a6948f6b5849fadb651c405640817399a) | [Instance](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a5d34b9ef939ab5e52769abd3887a5862) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574)MultiplayerOptionsAccessMode
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MultiplayerOptions.MultiplayerOptionsAccessMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574) |

| Enumerator | |
| --- | --- |
| DefaultMapOptions |  |
| CurrentMapOptions |  |
| NextMapOptions |  |
| NumAccessModes |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a9b4cd111fd32543a1e74b47c17fe1476)OptionValueType
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MultiplayerOptions.OptionValueType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a9b4cd111fd32543a1e74b47c17fe1476) |

| Enumerator | |
| --- | --- |
| Bool |  |
| Integer |  |
| Enum |  |
| String |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5)OptionType
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MultiplayerOptions.OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) |

| Enumerator | |
| --- | --- |
| ServerName |  |
| WelcomeMessage |  |
| GamePassword |  |
| AdminPassword |  |
| GameDefinitionId |  |
| AllowPollsToKickPlayers |  |
| AllowPollsToBanPlayers |  |
| AllowPollsToChangeMaps |  |
| AllowIndividualBanners |  |
| UseRealisticBlocking |  |
| PremadeMatchGameMode |  |
| GameType |  |
| PremadeGameType |  |
| Map |  |
| CultureTeam1 |  |
| CultureTeam2 |  |
| MaxNumberOfPlayers |  |
| MinNumberOfPlayersForMatchStart |  |
| NumberOfBotsTeam1 |  |
| NumberOfBotsTeam2 |  |
| NumberOfBotsPerFormation |  |
| FriendlyFireDamageMeleeSelfPercent |  |
| FriendlyFireDamageMeleeFriendPercent |  |
| FriendlyFireDamageRangedSelfPercent |  |
| FriendlyFireDamageRangedFriendPercent |  |
| SpectatorCamera |  |
| WarmupTimeLimitInSeconds |  |
| MapTimeLimit |  |
| RoundTimeLimit |  |
| RoundPreparationTimeLimit |  |
| RoundTotal |  |
| RespawnPeriodTeam1 |  |
| RespawnPeriodTeam2 |  |
| UnlimitedGold |  |
| GoldGainChangePercentageTeam1 |  |
| GoldGainChangePercentageTeam2 |  |
| MinScoreToWinMatch |  |
| MinScoreToWinDuel |  |
| PollAcceptThreshold |  |
| AutoTeamBalanceThreshold |  |
| EnableMissionRecording |  |
| SingleSpawn |  |
| DisableInactivityKick |  |
| NumOfSlots |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7caecb09a78b087f5d97aea6097ef195)OptionsCategory
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MultiplayerOptions.OptionsCategory](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7caecb09a78b087f5d97aea6097ef195) |

| Enumerator | |
| --- | --- |
| Default |  |
| PremadeMatch |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a6948f6b5849fadb651c405640817399a)MultiplayerOptions()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MultiplayerOptions.MultiplayerOptions | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a62b8dfb240b280faf39b46b3c85a15d5)Release()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MultiplayerOptions.Release | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7f4b106d6e7704675d01777768a368af)GetOptionFromOptionType()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MultiplayerOption](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_1_1_multiplayer_option.html) TaleWorlds.MountAndBlade.MultiplayerOptions.GetOptionFromOptionType | ( | [OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) | *optionType*, |
|  |  | [MultiplayerOptionsAccessMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574) | *mode* = [MultiplayerOptionsAccessMode::CurrentMapOptions](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574a03c496b39ceba47f8404591e8e4a7c9d) ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a4301ad3c44a0b6f356d541313575711d)OnGameTypeChanged()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerOptions.OnGameTypeChanged | ( | [MultiplayerOptionsAccessMode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574) | *mode* = [MultiplayerOptionsAccessMode::CurrentMapOptions](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a904ffe7f4f2557cbe9750a2da1b29574a03c496b39ceba47f8404591e8e4a7c9d) | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#ace80b9492e6b91e2e8e3b27711d65bee)InitializeNextAndDefaultOptionContainers()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerOptions.InitializeNextAndDefaultOptionContainers | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#af7df5dcd15d629c24990dbcbbe4666ca)GetNumberOfPlayersForGameMode()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MultiplayerOptions.GetNumberOfPlayersForGameMode | ( | string | *gameModeID* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a15dd69c44f51c7784b47773ef7612ab8)GetRoundCountForGameMode()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MultiplayerOptions.GetRoundCountForGameMode | ( | string | *gameModeID* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a71a037652104a9208e688871da69388b)GetRoundTimeLimitInMinutesForGameMode()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MultiplayerOptions.GetRoundTimeLimitInMinutesForGameMode | ( | string | *gameModeID* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a44928d026cfa2e095b9c1e42172e9edd)InitializeFromCommandList()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerOptions.InitializeFromCommandList | ( | List< string > | *arguments* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a8dbdaa8153613be92469905fdbeec6a5)ResetDefaultsToCurrent()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerOptions.ResetDefaultsToCurrent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a8d18cde4e6426cafc2d0363dac0dd1ae)GetMultiplayerOptionsTextList()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< string > TaleWorlds.MountAndBlade.MultiplayerOptions.GetMultiplayerOptionsTextList | ( | [OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) | *optionType* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a952de58d2466064cc74745a03a523a88)GetMultiplayerOptionsList()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< string > TaleWorlds.MountAndBlade.MultiplayerOptions.GetMultiplayerOptionsList | ( | [OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) | *optionType* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#af18ee8e09b72305887f007730788b10d)InitializeAllOptionsFromNext()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerOptions.InitializeAllOptionsFromNext | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a8eee6dfea2c12742cb542daa7ef54cd8)GetMapList()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBList< string > TaleWorlds.MountAndBlade.MultiplayerOptions.GetMapList | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7bc0d1bffcc2019d27ae27f1ce74d75b)GetValueTextForOptionWithMultipleSelection()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.MultiplayerOptions.GetValueTextForOptionWithMultipleSelection | ( | [OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) | *optionType* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7dced4e70b5a999da278bd2f92640f7d)SetValueForOptionWithMultipleSelectionFromText()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MultiplayerOptions.SetValueForOptionWithMultipleSelectionFromText | ( | [OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) | *optionType*, |
|  |  | string | *value* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a3cb23e14cee5ad0b46f55b6e5d2f8d3a)TryGetOptionTypeFromString()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MultiplayerOptions.TryGetOptionTypeFromString | ( | string | *optionTypeString*, | |  |  | out [OptionType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a30d64b4deaad40c791520f6e21f19fe5) | *optionType*, | |  |  | out [MultiplayerOptionsProperty](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html) | *optionAttribute* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a82dfffd8d344b653f6788ae0fc986818)CurrentOptionsCategory
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OptionsCategory](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7caecb09a78b087f5d97aea6097ef195) TaleWorlds.MountAndBlade.MultiplayerOptions.CurrentOptionsCategory = [OptionsCategory.Default](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a7caecb09a78b087f5d97aea6097ef195a7a1920d61156abc05a60135aefe8bc67) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a5d34b9ef939ab5e52769abd3887a5862)Instance
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MultiplayerOptions](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a6948f6b5849fadb651c405640817399a) TaleWorlds.MountAndBlade.MultiplayerOptions.Instance | | staticget |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html ---

TaleWorlds.CampaignSystem.Party.PartyScreenLogic Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) |
| class | [TroopComparer](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_troop_comparer.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [TroopSortType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6) {     [Invalid](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6a4bbb8f967da6d1a610596d7257179c2b) = -1 ,     [Custom](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6a90589c47f06eb971d548591f23c285af) = 0 ,     [Type](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6aa1fa27779242b4902f7ae3bdd5c6d508) ,     [Name](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6a49ee3087348e8d44e1feda1917443987) ,     [Count](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6ae93f994f01c537c4e2f7d8528c3eb5e9) ,     [Tier](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6a9483f17a69bd0b52dbc44f9106718634)   } |
| enum | [PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) : byte {     [None](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16a6adf97f83acf6453d4a6a4b1070f3754) = 99 ,     [Right](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16a92b09c7c48c520c3c55e497875da437c) = 1 ,     [Left](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16a945d5e233cf7d6240f6b783b36a374ff) = 0   } |
| enum | [TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) {     [Member](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1ba858ba4765e53c712ef672a9570474b1d) = 0x1 ,     [Prisoner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1ba0862a78e358ab0a158439d23cae77e2c) = 0x2 ,     [None](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1ba6adf97f83acf6453d4a6a4b1070f3754)   } |
| enum | [PartyCommandCode](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aebdfb003fbe4cd9df3616420338d07db) {     [TransferTroop](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aebdfb003fbe4cd9df3616420338d07dbaf344994ae1affc48b065192a605de825) = 0 ,     [UpgradeTroop](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aebdfb003fbe4cd9df3616420338d07dba8ed57adb5cc94b0d50390bb7c3bb10a2) = 1 ,     [TransferPartyLeaderTroop](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aebdfb003fbe4cd9df3616420338d07dbad157d995316fbfeae0869ba46680e11f) = 2 ,     [TransferTroopToLeaderSlot](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aebdfb003fbe4cd9df3616420338d07dbac4883d7a785f5a20629c8c95c2fee4e1) = 3 ,     [ShiftTroop](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aebdfb003fbe4cd9df3616420338d07dba96827651e1ed8d94739c0d8049ff9782) = 4 ,     [RecruitTroop](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aebdfb003fbe4cd9df3616420338d07dba2ee6f38d78fff12a2bafe38581d703d7) = 5 ,     [ExecuteTroop](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aebdfb003fbe4cd9df3616420338d07dbac756d4ab1080fa9965f89028c853017b) = 6 ,     [TransferAllTroops](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aebdfb003fbe4cd9df3616420338d07dba90f222fddc5f212e347d8709267610b4) = 7 ,     [SortTroops](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aebdfb003fbe4cd9df3616420338d07dbaf57cd0c35a2d946a0ae5233fc64b981f) = 8   } |
| enum | [TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) {     [NotTransferable](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1a1815ca33451fcb6a44a87e91a01ba60d) ,     [Transferable](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1afca07ed5a7c1e48e62112d3b8487b4f9) ,     [TransferableWithTrade](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1adea5bd1fc400d68fab67bc0902127d19)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [PresentationUpdate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#abd1400375419c06e4bc5669f637b89a7) ([PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) command) |
| delegate void | [PartyGoldDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a9a4951b1f04f4291c3ed7334985b1191) () |
| delegate void | [PartyMoraleDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a3049ffa45693d4176e89119f59a023d8) () |
| delegate void | [PartyInfluenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a31a01345c9ed8f840846ce7239769eb4) () |
| delegate void | [PartyHorseDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2728ef029512944be69557d49a4b6811) () |
| delegate void | [AfterResetDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ae77ff061836a709e24fd71c355e6f76c) ([PartyScreenLogic](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a3128055ef3790e589eafeaf181b0760f) partyScreenLogic, bool fromCancel) |
|  | [PartyScreenLogic](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a3128055ef3790e589eafeaf181b0760f) () |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a31452e508895582b7ece9a08956ee621) ([PartyScreenLogicInitializationData](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html) initializationData) |
| void | [AddCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a7fd31e0c19e836491e70fc6ef9e2fe8a) ([PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) command) |
| bool | [ValidateCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a4be0d4dad0d629f0d5bbc6b4270dcb10) ([PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) command) |
| int | [GetIndexToInsertTroop](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aecc02667edf210a0799af79d81db9c7e) ([PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) side, [TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) type, [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) troop) |
| [TroopSortType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6) | [GetActiveSortTypeForSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a1f805608fd792e1a8644fa7f71e62763) ([PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) side) |
| bool | [GetIsAscendingSortForSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a7fe48f06b8370468fe70aec5dd54fb08) ([PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) side) |
| bool | [IsDoneActive](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#af57985f19ec423f774b2dedc62116974) () |
| bool | [IsCancelActive](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a9d955091d553b758720c76d127b160a1) () |
| bool | [DoneLogic](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab5205d2c73bcf6f2146b76406d629012) (bool isForced) |
| void | [OnPartyScreenClosed](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a24edcc713c7f2daaef3e87f22d617585) (bool fromCancel) |
| bool | [IsTroopTransferable](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aa3a45b45d879ddb8a34c5e893ea972ab) ([TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) troopType, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, int side) |
| bool | [IsTroopRosterTransferable](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aa91052be52fe450461c256d65ad4c02a) ([TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) troopType) |
| bool | [IsPrisonerRecruitable](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a282ac1119961e466706b23dbef3851e2) ([TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) troopType, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) side) |
| string | [GetRecruitableReasonString](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a8fd9d4fda7f0e3761160eecaecac2374) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, bool isRecruitable, int troopCount, out bool showStackModifierText) |
| bool | [IsExecutable](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aab4480d8612062b58e15324d00cc5628) ([TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) troopType, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) side) |
| string | [GetExecutableReasonString](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aa9ee7405d4c5b6e8a61b24ef577bde4f) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, bool isExecutable) |
| int | [GetCurrentQuestCurrentCount](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aa260b9e8e4b415395d744fbdbb50befc) (bool includePrisoners, bool includeMembers) |
| int | [GetCurrentQuestRequiredCount](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a386036783a8ea87855bba9052fe90bc8) () |
| void | [Reset](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a4872b6fc0103c29da3656d4079c70da5) (bool fromCancel) |
| void | [SavePartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a4551f52d4902c96000dbb574a6f51da1) () |
| void | [ResetToLastSavedPartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a7501dfe36f2f169d5b5185fd0579824a) (bool fromCancel) |
| void | [RemoveZeroCounts](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2f756da0d805e514990d7f370b12967e) () |
| int | [GetTroopRecruitableAmount](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ac12adffe00edd8800005467b01f8160f) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [GetRoster](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ae5aa50589816ba991edf103834b2fb84) ([PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) side, [TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) troopType) |
| bool | [IsThereAnyChanges](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a5986ddc2c80bd670bcd2e7b5087abeb9) () |
| bool | [HaveRightSideGainedTroops](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2df35bcc9d2f8983ff7a1716ed3429a9) () |
| [TroopComparer](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_troop_comparer.html) | [GetComparer](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab36bc1efde43ad6e8bf8903df7fce11c) ([TroopSortType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6) sortType) |

|  |  |
| --- | --- |
| Public Attributes | |
| PartyPresentationDoneButtonDelegate | [PartyPresentationDoneButtonDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a7cf66c64cfcd2e96909cf076d12d0d0a) |
| PartyPresentationDoneButtonConditionDelegate | [PartyPresentationDoneButtonConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ad66fcbd997af96c936fd10d60ac149f2) |
| PartyPresentationCancelButtonActivateDelegate | [PartyPresentationCancelButtonActivateDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a29784f7afa267ddc8d7b5297bb300b07) |
| PartyPresentationCancelButtonDelegate | [PartyPresentationCancelButtonDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#af978408c2a7b7aad3e7307888a9984f1) |
| [PresentationUpdate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#abd1400375419c06e4bc5669f637b89a7) | [UpdateDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a518ade6df163b404c45a60f7d5dcba32) |
| IsTroopTransferableDelegate | [IsTroopTransferableDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a430954c8b58d1057dc9fb6756cab3177) |
| CanTalkToHeroDelegate | [CanTalkToHeroDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a94970114f678397ae13d30cdeaf83c22) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html)[] | [MemberRosters](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ad1faf56362e9dfbe72643f618dc54192) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html)[] | [PrisonerRosters](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a76915717bf2600b5c7a419f3101fd744) |
| bool | [IsConsumablesChanges](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a264c46c08878b680083e32ba67a34e76) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [TransferTroopToLeaderSlot](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#af04607965a1e932c4411498efd819ff1) ([PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) command) |
| void | [TransferTroop](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a02b6f753b6ae51eca1e3da824f108208) ([PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) command, bool invokeUpdate) |
| void | [ShiftTroop](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a09e18435f0d1bcd20cddd8a8c62f0b58) ([PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) command) |
| void | [TransferPartyLeaderTroop](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a4afa9fb8a33d992ecfb3fa874510e089) ([PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) command) |
| void | [UpgradeTroop](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a21c2898374ed055c840a50270dd578b0) ([PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) command) |
| void | [RecruitPrisoner](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a917ad85b25068a306aece147b9a27240) ([PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) command) |
| void | [ExecuteTroop](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab51a8a416023858fbdcedf8e8fb7c792) ([PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) command) |
| void | [TransferAllTroops](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a0f17656bdc0e39c4aebe4bbdf1625286) ([PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) command) |
| void | [SortTroops](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ac65768c0917b589681bf35ca1642a0f4) ([PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) command) |

|  |  |
| --- | --- |
| Properties | |
| [TroopSortType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6) | [ActiveOtherPartySortType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a1efdf549a52712f0bc3c1f72f9441b40) `[get, set]` |
| [TroopSortType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6) | [ActiveMainPartySortType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a11acfe9d0645378c00dd8bb6caec357b) `[get, set]` |
| bool | [IsOtherPartySortAscending](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a52417b64d7f6577ba30b6c573621cd17) `[get, set]` |
| bool | [IsMainPartySortAscending](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a6461857d3a3c1f2fffd2554a4fafbfba) `[get, set]` |
| [TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) | [MemberTransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81849775055facf71ab2e339e3c34cf1) `[get]` |
| [TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) | [PrisonerTransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#abd4ce88754dfd734ce13dafd0e2af317) `[get]` |
| [TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) | [AccompanyingTransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#af822cd9d5046fa8e67109e1fae32b9d9) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [LeftPartyName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a06b2bb6bed4713c8b2df80006928b2b6) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [RightPartyName](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aed73ff65d6430e008be26e0762b00b46) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Header](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2f22aca10a27d58e855eb8debdf89a2b) `[get]` |
| int | [LeftPartyMembersSizeLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a12fae758f364fa43c4aa8be1253f168b) `[get]` |
| int | [LeftPartyPrisonersSizeLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#af312ebb756e8cfacbefb19061d3bb2e8) `[get]` |
| int | [RightPartyMembersSizeLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aa2a88ec6b5ee54a3798958a8b29cf98f) `[get]` |
| int | [RightPartyPrisonersSizeLimit](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aaa533fde5a4c1b5b24568cd6c747291a) `[get]` |
| bool | [DoNotApplyGoldTransactions](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a00a1970cd5bba6a978ebd1427c2e4aa5) `[get]` |
| bool | [ShowProgressBar](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab34268cca916f15fff0a83dbb2905edc) `[get]` |
| string | [DoneReasonString](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2a89862c8e99a4ad72dc145f081a4a87) `[get]` |
| bool | [IsTroopUpgradesDisabled](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aea5f2ea91c7cc51cf071bdb026be78e7) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [RightPartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ad026f23e72e10149211fe4aaa1a8d334) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [LeftPartyLeader](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2608b88a3210c53431b08fadac2c34b7) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [LeftOwnerParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a8e56e4ad01e2dc72aa61365adf9fdb8d) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [RightOwnerParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ae7b32beb32e34decbb2bbd5d554083b4) `[get]` |
| [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html) | [CurrentData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab966c1418fca56833fa183d551be6b0c) `[get]` |
| bool | [TransferHealthiesGetWoundedsFirst](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aa6f9eef55cc58522d6c269bfc74f2221) `[get]` |
| int | [QuestModeWageDaysMultiplier](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aeea2996d1613ed1347a4b14cfcd08b18) `[get]` |
| Game | [Game](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a91e433ea1684cff673b02959f5585c2e) `[get, set]` |

|  |  |
| --- | --- |
| Events | |
| [PartyGoldDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a9a4951b1f04f4291c3ed7334985b1191) | [PartyGoldChange](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#af2439bd9178c37e3dfb4863d0e53b365) |
| [PartyMoraleDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a3049ffa45693d4176e89119f59a023d8) | [PartyMoraleChange](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#abc9908884eb0889ac4b98a7cc6cb456a) |
| [PartyInfluenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a31a01345c9ed8f840846ce7239769eb4) | [PartyInfluenceChange](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a22d8cf4e7ff5e105b89ba059907d8967) |
| [PartyHorseDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2728ef029512944be69557d49a4b6811) | [PartyHorseChange](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a83f77019cf6516b07ea743870edd3d18) |
| [PresentationUpdate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#abd1400375419c06e4bc5669f637b89a7) | [Update](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a0cdc04ca94813aee8343f57c4cd80168) |
| [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) | [PartyScreenClosedEvent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ae59c3cdc65cf71fb3d415d6834a8aac2) |
| [AfterResetDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ae77ff061836a709e24fd71c355e6f76c) | [AfterReset](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ac78a221a2ab06943e067b8676cacaf4a) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6)TroopSortType
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Party.PartyScreenLogic.TroopSortType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6) |

| Enumerator | |
| --- | --- |
| Invalid |  |
| Custom |  |
| Type |  |
| Name |  |
| Count |  |
| Tier |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16)PartyRosterSide
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) : byte |

| Enumerator | |
| --- | --- |
| None | No identification. |
| Right | Right hand side roster, Player's roster. |
| Left | Left hand side roster, Trader's roster. |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b)TroopType
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Party.PartyScreenLogic.TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) |

| Enumerator | |
| --- | --- |
| Member |  |
| Prisoner |  |
| None |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aebdfb003fbe4cd9df3616420338d07db)PartyCommandCode
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyCommandCode](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aebdfb003fbe4cd9df3616420338d07db) |

| Enumerator | |
| --- | --- |
| TransferTroop |  |
| UpgradeTroop |  |
| TransferPartyLeaderTroop |  |
| TransferTroopToLeaderSlot |  |
| ShiftTroop |  |
| RecruitTroop |  |
| ExecuteTroop |  |
| TransferAllTroops |  |
| SortTroops |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1)TransferState
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Party.PartyScreenLogic.TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) |

| Enumerator | |
| --- | --- |
| NotTransferable |  |
| Transferable |  |
| TransferableWithTrade |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a3128055ef3790e589eafeaf181b0760f)PartyScreenLogic()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyScreenLogic | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#abd1400375419c06e4bc5669f637b89a7)PresentationUpdate()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PresentationUpdate | ( | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) | *command* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a9a4951b1f04f4291c3ed7334985b1191)PartyGoldDelegate()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyGoldDelegate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a3049ffa45693d4176e89119f59a023d8)PartyMoraleDelegate()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyMoraleDelegate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a31a01345c9ed8f840846ce7239769eb4)PartyInfluenceDelegate()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyInfluenceDelegate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2728ef029512944be69557d49a4b6811)PartyHorseDelegate()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyHorseDelegate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ae77ff061836a709e24fd71c355e6f76c)AfterResetDelegate()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.AfterResetDelegate | ( | [PartyScreenLogic](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a3128055ef3790e589eafeaf181b0760f) | *partyScreenLogic*, |
|  |  | bool | *fromCancel* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a31452e508895582b7ece9a08956ee621)Initialize()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.Initialize | ( | [PartyScreenLogicInitializationData](struct_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_initialization_data.html) | *initializationData* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a7fd31e0c19e836491e70fc6ef9e2fe8a)AddCommand()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.AddCommand | ( | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) | *command* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a4be0d4dad0d629f0d5bbc6b4270dcb10)ValidateCommand()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.ValidateCommand | ( | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) | *command* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#af04607965a1e932c4411498efd819ff1)TransferTroopToLeaderSlot()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.TransferTroopToLeaderSlot | ( | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) | *command* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a02b6f753b6ae51eca1e3da824f108208)TransferTroop()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.TransferTroop | ( | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) | *command*, | |  |  | bool | *invokeUpdate* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a09e18435f0d1bcd20cddd8a8c62f0b58)ShiftTroop()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.ShiftTroop | ( | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) | *command* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a4afa9fb8a33d992ecfb3fa874510e089)TransferPartyLeaderTroop()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.TransferPartyLeaderTroop | ( | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) | *command* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a21c2898374ed055c840a50270dd578b0)UpgradeTroop()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.UpgradeTroop | ( | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) | *command* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a917ad85b25068a306aece147b9a27240)RecruitPrisoner()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.RecruitPrisoner | ( | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) | *command* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab51a8a416023858fbdcedf8e8fb7c792)ExecuteTroop()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.ExecuteTroop | ( | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) | *command* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a0f17656bdc0e39c4aebe4bbdf1625286)TransferAllTroops()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.TransferAllTroops | ( | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) | *command* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ac65768c0917b589681bf35ca1642a0f4)SortTroops()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.SortTroops | ( | [PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html) | *command* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aecc02667edf210a0799af79d81db9c7e)GetIndexToInsertTroop()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.PartyScreenLogic.GetIndexToInsertTroop | ( | [PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) | *side*, |
|  |  | [TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) | *type*, |
|  |  | [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) | *troop* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a1f805608fd792e1a8644fa7f71e62763)GetActiveSortTypeForSide()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TroopSortType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.GetActiveSortTypeForSide | ( | [PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a7fe48f06b8370468fe70aec5dd54fb08)GetIsAscendingSortForSide()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.GetIsAscendingSortForSide | ( | [PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#af57985f19ec423f774b2dedc62116974)IsDoneActive()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.IsDoneActive | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a9d955091d553b758720c76d127b160a1)IsCancelActive()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.IsCancelActive | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab5205d2c73bcf6f2146b76406d629012)DoneLogic()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.DoneLogic | ( | bool | *isForced* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a24edcc713c7f2daaef3e87f22d617585)OnPartyScreenClosed()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.OnPartyScreenClosed | ( | bool | *fromCancel* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aa3a45b45d879ddb8a34c5e893ea972ab)IsTroopTransferable()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.IsTroopTransferable | ( | [TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) | *troopType*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | int | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aa91052be52fe450461c256d65ad4c02a)IsTroopRosterTransferable()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.IsTroopRosterTransferable | ( | [TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) | *troopType* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a282ac1119961e466706b23dbef3851e2)IsPrisonerRecruitable()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.IsPrisonerRecruitable | ( | [TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) | *troopType*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | [PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a8fd9d4fda7f0e3761160eecaecac2374)GetRecruitableReasonString()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.Party.PartyScreenLogic.GetRecruitableReasonString | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | bool | *isRecruitable*, |
|  |  | int | *troopCount*, |
|  |  | out bool | *showStackModifierText* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aab4480d8612062b58e15324d00cc5628)IsExecutable()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.IsExecutable | ( | [TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) | *troopType*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | [PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aa9ee7405d4c5b6e8a61b24ef577bde4f)GetExecutableReasonString()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.Party.PartyScreenLogic.GetExecutableReasonString | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | bool | *isExecutable* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aa260b9e8e4b415395d744fbdbb50befc)GetCurrentQuestCurrentCount()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.PartyScreenLogic.GetCurrentQuestCurrentCount | ( | bool | *includePrisoners*, |
|  |  | bool | *includeMembers* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a386036783a8ea87855bba9052fe90bc8)GetCurrentQuestRequiredCount()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.PartyScreenLogic.GetCurrentQuestRequiredCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a4872b6fc0103c29da3656d4079c70da5)Reset()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.Reset | ( | bool | *fromCancel* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a4551f52d4902c96000dbb574a6f51da1)SavePartyScreenData()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.SavePartyScreenData | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a7501dfe36f2f169d5b5185fd0579824a)ResetToLastSavedPartyScreenData()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.ResetToLastSavedPartyScreenData | ( | bool | *fromCancel* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2f756da0d805e514990d7f370b12967e)RemoveZeroCounts()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.PartyScreenLogic.RemoveZeroCounts | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ac12adffe00edd8800005467b01f8160f)GetTroopRecruitableAmount()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Party.PartyScreenLogic.GetTroopRecruitableAmount | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ae5aa50589816ba991edf103834b2fb84)GetRoster()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.GetRoster | ( | [PartyRosterSide](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81d4bad4b2822449e4aa0dfcc56d0f16) | *side*, |
|  |  | [TroopType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#afef76cffe79f6d16475c027c240f0e1b) | *troopType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a5986ddc2c80bd670bcd2e7b5087abeb9)IsThereAnyChanges()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.IsThereAnyChanges | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2df35bcc9d2f8983ff7a1716ed3429a9)HaveRightSideGainedTroops()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.HaveRightSideGainedTroops | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab36bc1efde43ad6e8bf8903df7fce11c)GetComparer()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TroopComparer](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_troop_comparer.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.GetComparer | ( | [TroopSortType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6) | *sortType* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a7cf66c64cfcd2e96909cf076d12d0d0a)PartyPresentationDoneButtonDelegate
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| PartyPresentationDoneButtonDelegate TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyPresentationDoneButtonDelegate |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ad66fcbd997af96c936fd10d60ac149f2)PartyPresentationDoneButtonConditionDelegate
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| PartyPresentationDoneButtonConditionDelegate TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyPresentationDoneButtonConditionDelegate |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a29784f7afa267ddc8d7b5297bb300b07)PartyPresentationCancelButtonActivateDelegate
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| PartyPresentationCancelButtonActivateDelegate TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyPresentationCancelButtonActivateDelegate |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#af978408c2a7b7aad3e7307888a9984f1)PartyPresentationCancelButtonDelegate
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| PartyPresentationCancelButtonDelegate TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyPresentationCancelButtonDelegate |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a518ade6df163b404c45a60f7d5dcba32)UpdateDelegate
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PresentationUpdate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#abd1400375419c06e4bc5669f637b89a7) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.UpdateDelegate |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a430954c8b58d1057dc9fb6756cab3177)IsTroopTransferableDelegate
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| IsTroopTransferableDelegate TaleWorlds.CampaignSystem.Party.PartyScreenLogic.IsTroopTransferableDelegate |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a94970114f678397ae13d30cdeaf83c22)CanTalkToHeroDelegate
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| CanTalkToHeroDelegate TaleWorlds.CampaignSystem.Party.PartyScreenLogic.CanTalkToHeroDelegate |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ad1faf56362e9dfbe72643f618dc54192)MemberRosters
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) [] TaleWorlds.CampaignSystem.Party.PartyScreenLogic.MemberRosters |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a76915717bf2600b5c7a419f3101fd744)PrisonerRosters
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) [] TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PrisonerRosters |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a264c46c08878b680083e32ba67a34e76)IsConsumablesChanges
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.IsConsumablesChanges |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a1efdf549a52712f0bc3c1f72f9441b40)ActiveOtherPartySortType
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopSortType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.ActiveOtherPartySortType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a11acfe9d0645378c00dd8bb6caec357b)ActiveMainPartySortType
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopSortType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a249687323b4158e7782cd0f6664ab9e6) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.ActiveMainPartySortType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a52417b64d7f6577ba30b6c573621cd17)IsOtherPartySortAscending
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.IsOtherPartySortAscending | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a6461857d3a3c1f2fffd2554a4fafbfba)IsMainPartySortAscending
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.IsMainPartySortAscending | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a81849775055facf71ab2e339e3c34cf1)MemberTransferState
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.MemberTransferState | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#abd4ce88754dfd734ce13dafd0e2af317)PrisonerTransferState
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PrisonerTransferState | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#af822cd9d5046fa8e67109e1fae32b9d9)AccompanyingTransferState
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TransferState](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab28fca7a64e42e029c7a1e66e76ddbc1) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.AccompanyingTransferState | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a06b2bb6bed4713c8b2df80006928b2b6)LeftPartyName
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.LeftPartyName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aed73ff65d6430e008be26e0762b00b46)RightPartyName
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.RightPartyName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2f22aca10a27d58e855eb8debdf89a2b)Header
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.Header | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a12fae758f364fa43c4aa8be1253f168b)LeftPartyMembersSizeLimit
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyScreenLogic.LeftPartyMembersSizeLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#af312ebb756e8cfacbefb19061d3bb2e8)LeftPartyPrisonersSizeLimit
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyScreenLogic.LeftPartyPrisonersSizeLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aa2a88ec6b5ee54a3798958a8b29cf98f)RightPartyMembersSizeLimit
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyScreenLogic.RightPartyMembersSizeLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aaa533fde5a4c1b5b24568cd6c747291a)RightPartyPrisonersSizeLimit
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyScreenLogic.RightPartyPrisonersSizeLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a00a1970cd5bba6a978ebd1427c2e4aa5)DoNotApplyGoldTransactions
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.DoNotApplyGoldTransactions | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab34268cca916f15fff0a83dbb2905edc)ShowProgressBar
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.ShowProgressBar | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2a89862c8e99a4ad72dc145f081a4a87)DoneReasonString
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Party.PartyScreenLogic.DoneReasonString | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aea5f2ea91c7cc51cf071bdb026be78e7)IsTroopUpgradesDisabled
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.IsTroopUpgradesDisabled | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ad026f23e72e10149211fe4aaa1a8d334)RightPartyLeader
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.RightPartyLeader | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2608b88a3210c53431b08fadac2c34b7)LeftPartyLeader
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.LeftPartyLeader | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a8e56e4ad01e2dc72aa61365adf9fdb8d)LeftOwnerParty
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.LeftOwnerParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ae7b32beb32e34decbb2bbd5d554083b4)RightOwnerParty
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.RightOwnerParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ab966c1418fca56833fa183d551be6b0c)CurrentData
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyScreenData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_data.html) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.CurrentData | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aa6f9eef55cc58522d6c269bfc74f2221)TransferHealthiesGetWoundedsFirst
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.PartyScreenLogic.TransferHealthiesGetWoundedsFirst | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#aeea2996d1613ed1347a4b14cfcd08b18)QuestModeWageDaysMultiplier
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Party.PartyScreenLogic.QuestModeWageDaysMultiplier | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a91e433ea1684cff673b02959f5585c2e)Game
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Game TaleWorlds.CampaignSystem.Party.PartyScreenLogic.Game | | getset |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#af2439bd9178c37e3dfb4863d0e53b365)PartyGoldChange
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyGoldDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a9a4951b1f04f4291c3ed7334985b1191) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyGoldChange |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#abc9908884eb0889ac4b98a7cc6cb456a)PartyMoraleChange
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyMoraleDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a3049ffa45693d4176e89119f59a023d8) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyMoraleChange |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a22d8cf4e7ff5e105b89ba059907d8967)PartyInfluenceChange
--------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyInfluenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a31a01345c9ed8f840846ce7239769eb4) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyInfluenceChange |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a83f77019cf6516b07ea743870edd3d18)PartyHorseChange
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyHorseDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a2728ef029512944be69557d49a4b6811) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyHorseChange |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#a0cdc04ca94813aee8343f57c4cd80168)Update
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PresentationUpdate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#abd1400375419c06e4bc5669f637b89a7) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.Update |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ae59c3cdc65cf71fb3d415d6834a8aac2)PartyScreenClosedEvent
----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [PartyScreenClosedDelegate](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#afb81ccc80cbd0a87dbecbd6291cfbd2d) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyScreenClosedEvent |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ac78a221a2ab06943e067b8676cacaf4a)AfterReset
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [AfterResetDelegate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic.html#ae77ff061836a709e24fd71c355e6f76c) TaleWorlds.CampaignSystem.Party.PartyScreenLogic.AfterReset |


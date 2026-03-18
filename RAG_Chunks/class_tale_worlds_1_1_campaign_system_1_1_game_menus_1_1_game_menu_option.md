--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html ---

TaleWorlds.CampaignSystem.GameMenus.GameMenuOption Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [LeaveType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2) {     [Default](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a7a1920d61156abc05a60135aefe8bc67) ,     [Mission](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a70d529695c253d17e992cb9265abc57f) ,     [Submenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a3b0b126cd07e1c1f2677690f080ee723) ,     [BribeAndEscape](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a0605928e3e398ee1d7980d724ada901a) ,     [Escape](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a013ec032d3460d4be4431c6ab1f8f224) ,     [Craft](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2ad64fc815b787209309dca16ff96371f3) ,     [ForceToGiveGoods](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a2b55cc99ec37cf7128992cd0b57405cb) ,     [ForceToGiveTroops](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a6e6b6220e788f67375effcc53b582b22) ,     [Bribe](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a696292917787c80d98b42f08245ab5df) ,     [LeaveTroopsAndFlee](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a45b77ba383aedefa7fcddd820680b260) ,     [OrderTroopsToAttack](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a5058307ca499f4f988aaa34d565b6876) ,     [Raid](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2ac8a23798f7577fe951f173d3380bee0d) ,     [HostileAction](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2aa40afd5b865f9d9e7951c7458542c429) ,     [Recruit](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a0e401820f3b90471c2109cde456d7b63) ,     [Trade](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a5f390d80b20daad8f5d2f483fb0ae9d8) ,     [Wait](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a0f68101772bd5397ef8eb1b632798652) ,     [Leave](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2aa52945dbe283de2f7e9d63ca3417f36a) ,     [Continue](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2aa0bfb8e59e6c13fc8d990781f77694fe) ,     [Manage](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a34e34c43ec6b943c10a3cc1a1a16fb11) ,     [TroopSelection](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2aff1a28a0b08b11785afacb13bfdd4ec8) ,     [WaitQuest](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2aefaccb03c358e8d5cd5a28f16591950d) ,     [Surrender](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a92fa0b43cbcc2b7610cdb157d273c5fa) ,     [Conversation](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a9c84e2b9302627e683f348e57fd14e6b) ,     [DefendAction](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a606b514b390d508ac5fe99a98524560a) ,     [Devastate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a73f1e1bae1a8f21dc58953550c28ca36) ,     [Pillage](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2ab56d3c4f8c4e834a6c6ceda36fe7ee1b) ,     [ShowMercy](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2af2d67bfd6ec3ba74c71f9593199ff4bc) ,     [Leaderboard](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2ae02b89857b91a11b8be92fca409827ba) ,     [OpenStash](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2acc71c1e1b243a4a063b888682501023b) ,     [ManageGarrison](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a022d144407d04533b9753b74ddaebf58) ,     [StagePrisonBreak](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a05063741ffac057aab29993df8be97e7) ,     [ManagePrisoners](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a903d58a594c91ae5b0fffaf027809832) ,     [Ransom](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2aa606b3b02930b70dff78144b4f61a81f) ,     [PracticeFight](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a9f7cd1206102ba800b631edc64c22bb3) ,     [BesiegeTown](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a5e698cf5b27cdc4047053b5e13867e66) ,     [SneakIn](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a2a47df2c7b9edaf17e9027bae86504b0) ,     [LeadAssault](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a7da001841d6dc16ec7a522b513cf222f) ,     [DonateTroops](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a1267a83545a3cc8acbc439855aab14bc) ,     [DonatePrisoners](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a591d737f741c7c009e86d9baeb7ee54e) ,     [SiegeAmbush](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a6b45b269acfdb665eca080023eba662b) ,     [Warehouse](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a6416e8cb5fc0a208d94fa7f5a300dbc4) ,     [VisitPort](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2af29d56e57cffa79a289ba0f197a78891) ,     [SetSail](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a5253795b1d29b8e04f942a1fa7e5d878) ,     [ManageFleet](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a17d80d65aa2f001a8e9943f509fbcbc0) ,     [CallFleet](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2ad7258ec4378be6fbe817ad48f6910c12) ,     [OrderShipsToAttack](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a1f24220811afe9364cbacdc1c772a69f) ,     [RepairShips](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2a173415325692e2f8012146ab4d9ee8a4)   } |
| enum | [IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510) {     [None](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510a6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [AvailableIssue](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510a497a8aa27be31ea9c78d335f154abbae) = 1 ,     [ActiveIssue](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510a2a10e1ba2e8e558cea3d3c799cbf9792) = 2 ,     [ActiveStoryQuest](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510a29b0303ba4919840a31d7273d81b4875) = 4 ,     [TrackedIssue](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510a74758327a7782d2d2fbe0d788913c2ec) = 8 ,     [TrackedStoryQuest](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510aa36efddfd461bfc21065fe570c36923e) = 16   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate bool | [OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a67f0448f025b739bc2f931a7eee24b66) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| delegate void | [OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#afae542885d132e26e2aaae06a63371b3) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
|  | [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a31b85e773b1141ac8c3c850bb820bad5) ([GameMenu.MenuAndOptionType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933e) type, String idString, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text2, [OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a67f0448f025b739bc2f931a7eee24b66) condition, [OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#afae542885d132e26e2aaae06a63371b3) consequence, bool isLeave=false, bool isRepeatable=false, object relatedObject=null) |
| bool | [GetConditionsHold](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a406fdcfd0432d72a97af261a2dba75ae) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| void | [RunConsequence](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#ae92b0f0ff13ec8e11c13bd487af99290) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) menuContext) |
| void | [SetEnable](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#af5883a7d07e087a1d2037e1c767313fc) (bool isEnable) |

|  |  |
| --- | --- |
| Public Attributes | |
| [OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a67f0448f025b739bc2f931a7eee24b66) | [OnCondition](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a731784dc0d7ee0660315e329a7554c7f) |
| [OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#afae542885d132e26e2aaae06a63371b3) | [OnConsequence](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#acf71512218a68948d01019df684d0104) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static [IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510)[] | [IssueQuestFlagsValues](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a787a83f2eb1509f16fb57dd50b721da2) = ([IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510)[])Enum.GetValues(typeof([IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510))) |

|  |  |
| --- | --- |
| Properties | |
| [GameMenu.MenuAndOptionType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933e) | [Type](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#ab6be9b3303e88c3091bfef2eb203b125) `[get]` |
| [LeaveType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2) | [OptionLeaveType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a50f932ea195cec2dee18e1aaa8911e65) `[get, set]` |
| [IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510) | [OptionQuestData](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#ab43810702bbc38870943abe67e31639d) `[get, set]` |
| string | [IdString](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#af6c7d6cb99caba0d9e9b39bf6a31c67f) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Text](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#aeb6f8a0510e5f9fd4192a5aa1cfa3b00) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Text2](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#aeef71d19cb51e09963ca7dd5ea95d018) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Tooltip](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#afa9400a5585f7916764d679054967088) `[get]` |
| bool | [IsLeave](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a5126ffaeafc8355f6244f22a7846703b) `[get]` |
| bool | [IsRepeatable](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a019b28517898689fcf402518f06cc254) `[get]` |
| bool | [IsEnabled](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a1179e8e005f3e4c97abd9fa3e3f2fd64) `[get]` |
| object | [RelatedObject](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#ae3090ff97dfde5a041ceaf71145ba829) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2)LeaveType
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.LeaveType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2) |

| Enumerator | |
| --- | --- |
| Default |  |
| Mission |  |
| Submenu |  |
| BribeAndEscape |  |
| Escape |  |
| Craft |  |
| ForceToGiveGoods |  |
| ForceToGiveTroops |  |
| Bribe |  |
| LeaveTroopsAndFlee |  |
| OrderTroopsToAttack |  |
| Raid |  |
| HostileAction |  |
| Recruit |  |
| Trade |  |
| Wait |  |
| Leave |  |
| Continue |  |
| Manage |  |
| TroopSelection |  |
| WaitQuest |  |
| Surrender |  |
| Conversation |  |
| DefendAction |  |
| Devastate |  |
| Pillage |  |
| ShowMercy |  |
| Leaderboard |  |
| OpenStash |  |
| ManageGarrison |  |
| StagePrisonBreak |  |
| ManagePrisoners |  |
| Ransom |  |
| PracticeFight |  |
| BesiegeTown |  |
| SneakIn |  |
| LeadAssault |  |
| DonateTroops |  |
| DonatePrisoners |  |
| SiegeAmbush |  |
| Warehouse |  |
| VisitPort |  |
| SetSail |  |
| ManageFleet |  |
| CallFleet |  |
| OrderShipsToAttack |  |
| RepairShips |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510)IssueQuestFlags
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510) |

| Enumerator | |
| --- | --- |
| None |  |
| AvailableIssue |  |
| ActiveIssue |  |
| ActiveStoryQuest |  |
| TrackedIssue |  |
| TrackedStoryQuest |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a31b85e773b1141ac8c3c850bb820bad5)GameMenuOption()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.GameMenuOption | ( | [GameMenu.MenuAndOptionType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933e) | *type*, |
|  |  | String | *idString*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text2*, |
|  |  | [OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a67f0448f025b739bc2f931a7eee24b66) | *condition*, |
|  |  | [OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#afae542885d132e26e2aaae06a63371b3) | *consequence*, |
|  |  | bool | *isLeave* = false, |
|  |  | bool | *isRepeatable* = false, |
|  |  | object | *relatedObject* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a67f0448f025b739bc2f931a7eee24b66)OnConditionDelegate()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate bool TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.OnConditionDelegate | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#afae542885d132e26e2aaae06a63371b3)OnConsequenceDelegate()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.OnConsequenceDelegate | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a406fdcfd0432d72a97af261a2dba75ae)GetConditionsHold()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.GetConditionsHold | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, |
|  |  | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#ae92b0f0ff13ec8e11c13bd487af99290)RunConsequence()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.RunConsequence | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_menu_context.html) | *menuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#af5883a7d07e087a1d2037e1c767313fc)SetEnable()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.SetEnable | ( | bool | *isEnable* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a787a83f2eb1509f16fb57dd50b721da2)IssueQuestFlagsValues
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510) [] TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.IssueQuestFlagsValues = ([IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510)[])Enum.GetValues(typeof([IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510))) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a731784dc0d7ee0660315e329a7554c7f)OnCondition
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnConditionDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a67f0448f025b739bc2f931a7eee24b66) TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.OnCondition |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#acf71512218a68948d01019df684d0104)OnConsequence
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnConsequenceDelegate](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#afae542885d132e26e2aaae06a63371b3) TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.OnConsequence |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#ab6be9b3303e88c3091bfef2eb203b125)Type
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameMenu.MenuAndOptionType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a75a6de1769953ede245660ef2358933e) TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.Type | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a50f932ea195cec2dee18e1aaa8911e65)OptionLeaveType
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [LeaveType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2) TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.OptionLeaveType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#ab43810702bbc38870943abe67e31639d)OptionQuestData
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510) TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.OptionQuestData | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#af6c7d6cb99caba0d9e9b39bf6a31c67f)IdString
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.IdString | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#aeb6f8a0510e5f9fd4192a5aa1cfa3b00)Text
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.Text | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#aeef71d19cb51e09963ca7dd5ea95d018)Text2
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.Text2 | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#afa9400a5585f7916764d679054967088)Tooltip
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.Tooltip | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a5126ffaeafc8355f6244f22a7846703b)IsLeave
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.IsLeave | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a019b28517898689fcf402518f06cc254)IsRepeatable
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.IsRepeatable | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a1179e8e005f3e4c97abd9fa3e3f2fd64)IsEnabled
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.IsEnabled | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#ae3090ff97dfde5a041ceaf71145ba829)RelatedObject
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.CampaignSystem.GameMenus.GameMenuOption.RelatedObject | | get |


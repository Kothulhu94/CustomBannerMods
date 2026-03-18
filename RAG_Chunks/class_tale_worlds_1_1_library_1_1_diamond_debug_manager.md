--- SOURCE: class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html ---

TaleWorlds.Library.DiamondDebugManager Class ReferenceInherits [TaleWorlds.Library.IDebugManager](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [DiamondDebugCategory](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a91b50c4da1e1e9302ce596b62a14254d) {     [General](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a91b50c4da1e1e9302ce596b62a14254da0db377921f4ce762c62526131097968f) = 0 ,     [Warning](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a91b50c4da1e1e9302ce596b62a14254da0eaadb4fcb48a0a0ed7bc9868be9fbaa) = 1 ,     [Error](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a91b50c4da1e1e9302ce596b62a14254da902b0d55fddef6f8d651fe1035b7d4bd) = 2   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DiamondDebugManager](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#ab75b07f43be0519203e497dcbf7a5ee8) ([ParameterContainer](class_tale_worlds_1_1_library_1_1_parameter_container.html) parameters) |
|  | [DiamondDebugManager](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a4595a8bc6eed48bc215ce966ee50c46b) () |
| int | [GetLogLevel](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a628f2885bbfcad1e42d49981b4618511) () |
| Public Member Functions inherited from [TaleWorlds.Library.IDebugManager](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html) | |
| void | [Print](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a27026f6db3ff8b34bb8c26bd95601a18) (string message, int logLevel=0, TaleWorlds.Library.Debug.DebugColor color=TaleWorlds.Library.Debug.DebugColor.White, UInt64 debugFilter=(UInt64) Debug.DebugSystemFilter.Mono) |
| void | [PrintError](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a921c96f6b6607b9a1b5af7cb61fdb386) (string error, string stackTrace, UInt64 debugFilter=(UInt64) Debug.DebugSystemFilter.Mono) |
| void | [PrintWarning](interface_tale_worlds_1_1_library_1_1_i_debug_manager.html#a889a63b56ce24531028ffc144fc857f8) (string warning, UInt64 debugFilter=(UInt64) Debug.DebugSystemFilter.Mono) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [PrintMessage](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a70a728f202cc5fea7bdfaacb8e77d619) (string message, [DiamondDebugCategory](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a91b50c4da1e1e9302ce596b62a14254d) debugCategory) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a91b50c4da1e1e9302ce596b62a14254d)DiamondDebugCategory
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Library.DiamondDebugManager.DiamondDebugCategory](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a91b50c4da1e1e9302ce596b62a14254d) |

| Enumerator | |
| --- | --- |
| General |  |
| Warning |  |
| Error |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#ab75b07f43be0519203e497dcbf7a5ee8)DiamondDebugManager() [1/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.DiamondDebugManager.DiamondDebugManager | ( | [ParameterContainer](class_tale_worlds_1_1_library_1_1_parameter_container.html) | *parameters* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a4595a8bc6eed48bc215ce966ee50c46b)DiamondDebugManager() [2/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Library.DiamondDebugManager.DiamondDebugManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a628f2885bbfcad1e42d49981b4618511)GetLogLevel()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Library.DiamondDebugManager.GetLogLevel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a70a728f202cc5fea7bdfaacb8e77d619)PrintMessage()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.DiamondDebugManager.PrintMessage | ( | string | *message*, | |  |  | [DiamondDebugCategory](class_tale_worlds_1_1_library_1_1_diamond_debug_manager.html#a91b50c4da1e1e9302ce596b62a14254d) | *debugCategory* ) | | protected |


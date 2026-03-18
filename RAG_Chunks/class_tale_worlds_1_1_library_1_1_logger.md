--- SOURCE: class_tale_worlds_1_1_library_1_1_logger.html ---

TaleWorlds.Library.Logger Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Logger](class_tale_worlds_1_1_library_1_1_logger.html#ad2fb39ddfd104a68f3d9fec46d345455) (string name) |
|  | [Logger](class_tale_worlds_1_1_library_1_1_logger.html#a4023afdfa3917e825d093a0bc1b04888) (string name, bool writeErrorsToDifferentFile, bool logOnlyErrors, bool doNotUseProcessId, int numFiles=1, int totalFileSize=-1, bool overwrite=false) |
| void | [Print](class_tale_worlds_1_1_library_1_1_logger.html#a2e3c3cd37caee74da57c0787ca5b211c) (string log, [HTMLDebugCategory](namespace_tale_worlds_1_1_library.html#ab26344a6b7666f8773ffc566ecde9648) debugInfo=[HTMLDebugCategory.General](namespace_tale_worlds_1_1_library.html#ab26344a6b7666f8773ffc566ecde9648a0db377921f4ce762c62526131097968f)) |
| void | [Print](class_tale_worlds_1_1_library_1_1_logger.html#a16332d63767c9a013c47b0ff13090723) (string log, [HTMLDebugCategory](namespace_tale_worlds_1_1_library.html#ab26344a6b7666f8773ffc566ecde9648) debugInfo, bool printOnGlobal) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [FinishAndCloseAll](class_tale_worlds_1_1_library_1_1_logger.html#af4a3b3e5fd4477a3e9d4e04fcf197f19) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static string | [LogsFolder](class_tale_worlds_1_1_library_1_1_logger.html#a256cc0e16e87eb9b0d9b01e78c29825e) = "" |

|  |  |
| --- | --- |
| Properties | |
| bool | [LogOnlyErrors](class_tale_worlds_1_1_library_1_1_logger.html#a93cc3112d3412e16d934447728071a3d) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_logger.html#ad2fb39ddfd104a68f3d9fec46d345455)Logger() [1/2]
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.Logger.Logger | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_logger.html#a4023afdfa3917e825d093a0bc1b04888)Logger() [2/2]
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Logger.Logger | ( | string | *name*, |
|  |  | bool | *writeErrorsToDifferentFile*, |
|  |  | bool | *logOnlyErrors*, |
|  |  | bool | *doNotUseProcessId*, |
|  |  | int | *numFiles* = 1, |
|  |  | int | *totalFileSize* = -1, |
|  |  | bool | *overwrite* = false ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_logger.html#a2e3c3cd37caee74da57c0787ca5b211c)Print() [1/2]
-------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.Logger.Print | ( | string | *log*, |
|  |  | [HTMLDebugCategory](namespace_tale_worlds_1_1_library.html#ab26344a6b7666f8773ffc566ecde9648) | *debugInfo* = [HTMLDebugCategory::General](namespace_tale_worlds_1_1_library.html#ab26344a6b7666f8773ffc566ecde9648a0db377921f4ce762c62526131097968f) ) |

[◆](class_tale_worlds_1_1_library_1_1_logger.html#a16332d63767c9a013c47b0ff13090723)Print() [2/2]
-------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.Logger.Print | ( | string | *log*, |
|  |  | [HTMLDebugCategory](namespace_tale_worlds_1_1_library.html#ab26344a6b7666f8773ffc566ecde9648) | *debugInfo*, |
|  |  | bool | *printOnGlobal* ) |

[◆](class_tale_worlds_1_1_library_1_1_logger.html#af4a3b3e5fd4477a3e9d4e04fcf197f19)FinishAndCloseAll()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Library.Logger.FinishAndCloseAll | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_library_1_1_logger.html#a256cc0e16e87eb9b0d9b01e78c29825e)LogsFolder
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.Logger.LogsFolder = "" | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_logger.html#a93cc3112d3412e16d934447728071a3d)LogOnlyErrors
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.Logger.LogOnlyErrors | | getset |


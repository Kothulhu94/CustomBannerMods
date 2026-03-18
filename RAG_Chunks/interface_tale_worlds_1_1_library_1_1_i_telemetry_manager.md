--- SOURCE: interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html ---

TaleWorlds.Library.ITelemetryManager Interface Reference|  |  |
| --- | --- |
| Public Member Functions | |
| [TelemetryLevelMask](namespace_tale_worlds_1_1_library.html#ad8d0f76bfd44b70413c051072cad64f6) | [GetTelemetryLevelMask](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#a10281a9de285ab1ae4248d7462d31a37) () |
| void | [StartTelemetryConnection](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#adb4f474a3cda16bf52def352fa857bdd) (bool showErrors) |
| void | [StopTelemetryConnection](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#af2a2e6496c44160615e59a4f6d6d4f8e) () |
| void | [BeginTelemetryScopeInternal](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#a70892b1ea95c7854e91f2707acb60618) ([TelemetryLevelMask](namespace_tale_worlds_1_1_library.html#ad8d0f76bfd44b70413c051072cad64f6) levelMask, string scopeName) |
| void | [BeginTelemetryScopeBaseLevelInternal](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#a3aece6e85079cc5499e34d62a013f013) ([TelemetryLevelMask](namespace_tale_worlds_1_1_library.html#ad8d0f76bfd44b70413c051072cad64f6) levelMask, string scopeName) |
| void | [EndTelemetryScopeInternal](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#aa3b33e9d5ae2ea3b4155bce2c5c34a0d) () |
| void | [EndTelemetryScopeBaseLevelInternal](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#af9ba6f484ed5a7709619d0b6e11da253) () |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#a10281a9de285ab1ae4248d7462d31a37)GetTelemetryLevelMask()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TelemetryLevelMask](namespace_tale_worlds_1_1_library.html#ad8d0f76bfd44b70413c051072cad64f6) TaleWorlds.Library.ITelemetryManager.GetTelemetryLevelMask | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#adb4f474a3cda16bf52def352fa857bdd)StartTelemetryConnection()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.ITelemetryManager.StartTelemetryConnection | ( | bool | *showErrors* | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#af2a2e6496c44160615e59a4f6d6d4f8e)StopTelemetryConnection()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.ITelemetryManager.StopTelemetryConnection | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#a70892b1ea95c7854e91f2707acb60618)BeginTelemetryScopeInternal()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.ITelemetryManager.BeginTelemetryScopeInternal | ( | [TelemetryLevelMask](namespace_tale_worlds_1_1_library.html#ad8d0f76bfd44b70413c051072cad64f6) | *levelMask*, |
|  |  | string | *scopeName* ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#a3aece6e85079cc5499e34d62a013f013)BeginTelemetryScopeBaseLevelInternal()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.ITelemetryManager.BeginTelemetryScopeBaseLevelInternal | ( | [TelemetryLevelMask](namespace_tale_worlds_1_1_library.html#ad8d0f76bfd44b70413c051072cad64f6) | *levelMask*, |
|  |  | string | *scopeName* ) |

[◆](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#aa3b33e9d5ae2ea3b4155bce2c5c34a0d)EndTelemetryScopeInternal()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.ITelemetryManager.EndTelemetryScopeInternal | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_i_telemetry_manager.html#af9ba6f484ed5a7709619d0b6e11da253)EndTelemetryScopeBaseLevelInternal()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.ITelemetryManager.EndTelemetryScopeBaseLevelInternal | ( |  | ) |  |


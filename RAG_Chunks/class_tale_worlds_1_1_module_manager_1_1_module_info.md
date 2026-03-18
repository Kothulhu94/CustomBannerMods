--- SOURCE: class_tale_worlds_1_1_module_manager_1_1_module_info.html ---

TaleWorlds.ModuleManager.ModuleInfo Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a501d788a227242c6aa9026bc0d982e25) () |
| void | [LoadWithFullPath](class_tale_worlds_1_1_module_manager_1_1_module_info.html#afb56bda8ea953db12118ff1321b41d1c) (string fullPath) |
| void | [ActivateModule](class_tale_worlds_1_1_module_manager_1_1_module_info.html#adbd424cf6905643ccf116944af17d0c9) () |
| void | [DeactivateModule](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a66a92e3a2dfd7c429c672cbed2d46a06) () |
| void | [UpdateVersionChangeSet](class_tale_worlds_1_1_module_manager_1_1_module_info.html#afa03dc6b64666c8112ff427e9a3195d2) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly List< [SubModuleInfo](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html) > | [SubModules](class_tale_worlds_1_1_module_manager_1_1_module_info.html#aa98b92132531c51822f8a9477de6f4e0) |
| readonly List< [DependedModule](struct_tale_worlds_1_1_module_manager_1_1_depended_module.html) > | [DependedModules](class_tale_worlds_1_1_module_manager_1_1_module_info.html#af74b637743db837b3e552189e8aa749a) |
| readonly List< [DependedModule](struct_tale_worlds_1_1_module_manager_1_1_depended_module.html) > | [ModulesToLoadAfterThis](class_tale_worlds_1_1_module_manager_1_1_module_info.html#aca1a21421d39de9b611c3cd877c0a6cb) |
| readonly List< [DependedModule](struct_tale_worlds_1_1_module_manager_1_1_depended_module.html) > | [IncompatibleModules](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a49edc1e4d1ba4fd6ddfd2f7ab00a1ace) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsSelected](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a9d8bc079be3de6321f5778d7a81ec538) `[get, set]` |
| string | [Id](class_tale_worlds_1_1_module_manager_1_1_module_info.html#aed10693f603df03a63e6280fc149c076) `[get]` |
| string | [Name](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a71246d207f5cadd4e08738bf8fca078c) `[get]` |
| bool | [IsOfficial](class_tale_worlds_1_1_module_manager_1_1_module_info.html#af2742d884a239fffd3b025a95b5f957b) `[get]` |
| bool | [IsDefault](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a7ad925742c3c4d0d16d462ce12aa4379) `[get]` |
| bool | [IsRequiredOfficial](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a6731b5a0955e91e186a1d97a0582e9d0) `[get]` |
| bool | [IsActive](class_tale_worlds_1_1_module_manager_1_1_module_info.html#ab2701e79e4af11add83507afdc8f5a9a) `[get]` |
| [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html) | [Version](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a1d3216638b8f19f65623569fc8201b8c) `[get]` |
| [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html) | [RequiredBaseVersion](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a23b0f9498cd3f0e424d978d88501f75c) `[get]` |
| [ModuleCategory](namespace_tale_worlds_1_1_module_manager.html#aee846422c0b12c5e7ea59cbb916dc8cf) | [Category](class_tale_worlds_1_1_module_manager_1_1_module_info.html#ae300452eeadd94c0c88f593c803aceb3) `[get]` |
| string | [FolderPath](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a5bf7f4db5c8adfa1e9d3a1df0d487dd9) `[get]` |
| [ModuleType](namespace_tale_worlds_1_1_module_manager.html#ad715396e4ba8d96acba49cca60b7e947) | [Type](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a49693aeb2c65695bd70e861307d8cc3a) `[get]` |
| bool | [HasMultiplayerCategory](class_tale_worlds_1_1_module_manager_1_1_module_info.html#acc9c57a9835b1f2feca70cbb289b6f49) `[get]` |
| bool | [IsNative](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a1cdf822f63d098f5b6180509dfd05c15) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a501d788a227242c6aa9026bc0d982e25)ModuleInfo()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.ModuleManager.ModuleInfo.ModuleInfo | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#afb56bda8ea953db12118ff1321b41d1c)LoadWithFullPath()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.ModuleManager.ModuleInfo.LoadWithFullPath | ( | string | *fullPath* | ) |  |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#adbd424cf6905643ccf116944af17d0c9)ActivateModule()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.ModuleManager.ModuleInfo.ActivateModule | ( |  | ) |  |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a66a92e3a2dfd7c429c672cbed2d46a06)DeactivateModule()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.ModuleManager.ModuleInfo.DeactivateModule | ( |  | ) |  |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#afa03dc6b64666c8112ff427e9a3195d2)UpdateVersionChangeSet()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.ModuleManager.ModuleInfo.UpdateVersionChangeSet | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#aa98b92132531c51822f8a9477de6f4e0)SubModules
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly List<[SubModuleInfo](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html)> TaleWorlds.ModuleManager.ModuleInfo.SubModules |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#af74b637743db837b3e552189e8aa749a)DependedModules
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly List<[DependedModule](struct_tale_worlds_1_1_module_manager_1_1_depended_module.html)> TaleWorlds.ModuleManager.ModuleInfo.DependedModules |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#aca1a21421d39de9b611c3cd877c0a6cb)ModulesToLoadAfterThis
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly List<[DependedModule](struct_tale_worlds_1_1_module_manager_1_1_depended_module.html)> TaleWorlds.ModuleManager.ModuleInfo.ModulesToLoadAfterThis |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a49edc1e4d1ba4fd6ddfd2f7ab00a1ace)IncompatibleModules
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly List<[DependedModule](struct_tale_worlds_1_1_module_manager_1_1_depended_module.html)> TaleWorlds.ModuleManager.ModuleInfo.IncompatibleModules |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a9d8bc079be3de6321f5778d7a81ec538)IsSelected
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.ModuleManager.ModuleInfo.IsSelected | | getset |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#aed10693f603df03a63e6280fc149c076)Id
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.ModuleManager.ModuleInfo.Id | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a71246d207f5cadd4e08738bf8fca078c)Name
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.ModuleManager.ModuleInfo.Name | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#af2742d884a239fffd3b025a95b5f957b)IsOfficial
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.ModuleManager.ModuleInfo.IsOfficial | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a7ad925742c3c4d0d16d462ce12aa4379)IsDefault
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.ModuleManager.ModuleInfo.IsDefault | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a6731b5a0955e91e186a1d97a0582e9d0)IsRequiredOfficial
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.ModuleManager.ModuleInfo.IsRequiredOfficial | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#ab2701e79e4af11add83507afdc8f5a9a)IsActive
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.ModuleManager.ModuleInfo.IsActive | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a1d3216638b8f19f65623569fc8201b8c)Version
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html) TaleWorlds.ModuleManager.ModuleInfo.Version | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a23b0f9498cd3f0e424d978d88501f75c)RequiredBaseVersion
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html) TaleWorlds.ModuleManager.ModuleInfo.RequiredBaseVersion | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#ae300452eeadd94c0c88f593c803aceb3)Category
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ModuleCategory](namespace_tale_worlds_1_1_module_manager.html#aee846422c0b12c5e7ea59cbb916dc8cf) TaleWorlds.ModuleManager.ModuleInfo.Category | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a5bf7f4db5c8adfa1e9d3a1df0d487dd9)FolderPath
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.ModuleManager.ModuleInfo.FolderPath | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a49693aeb2c65695bd70e861307d8cc3a)Type
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ModuleType](namespace_tale_worlds_1_1_module_manager.html#ad715396e4ba8d96acba49cca60b7e947) TaleWorlds.ModuleManager.ModuleInfo.Type | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#acc9c57a9835b1f2feca70cbb289b6f49)HasMultiplayerCategory
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.ModuleManager.ModuleInfo.HasMultiplayerCategory | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_info.html#a1cdf822f63d098f5b6180509dfd05c15)IsNative
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.ModuleManager.ModuleInfo.IsNative | | get |


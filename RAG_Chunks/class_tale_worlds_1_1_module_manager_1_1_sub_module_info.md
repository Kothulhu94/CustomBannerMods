--- SOURCE: class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html ---

TaleWorlds.ModuleManager.SubModuleInfo Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [SubModuleTags](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a18fad4cddecb2a8f0a8a37aed3f13494) {     [RejectedPlatform](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a18fad4cddecb2a8f0a8a37aed3f13494a5a4ba056c500d1fac7bed630d99bc582) ,     [ExclusivePlatform](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a18fad4cddecb2a8f0a8a37aed3f13494a0b23122be0801a60671c1cb77833bf2d) ,     [DedicatedServerType](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a18fad4cddecb2a8f0a8a37aed3f13494a9a5d25bef127de63fa398dc5a93a5476) ,     [IsNoRenderModeElement](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a18fad4cddecb2a8f0a8a37aed3f13494ae78160f21d6565c5fddde9588489be2c) ,     [DependantRuntimeLibrary](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a18fad4cddecb2a8f0a8a37aed3f13494ab3e4371533fc525f691813ce1945eccc) ,     [PlayerHostedDedicatedServer](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a18fad4cddecb2a8f0a8a37aed3f13494ad242fb87dc97027e89a216082100a8d3) ,     [EngineType](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a18fad4cddecb2a8f0a8a37aed3f13494a339085d78783386eba0b8065fc3dc44c)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SubModuleInfo](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#ae16479bbf4926097122dd16934be13bc) () |
| void | [LoadFrom](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#adbf07e35c24713df5fa5772ff6874c3d) (XmlNode subModuleNode, string path, bool isOfficial) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly List< Tuple< [SubModuleTags](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a18fad4cddecb2a8f0a8a37aed3f13494), string > > | [Tags](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#affd7a0164955adaa9b53c83398b9d1ea) |

|  |  |
| --- | --- |
| Properties | |
| string | [Name](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a6718906ee09a08637235ce08c12df050) `[get]` |
| string | [DLLName](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a396b349c41a8e358bf62c0981f7d7083) `[get]` |
| string | [DLLPath](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#aeda3f22d19f6a907ae725efeee2f320d) `[get]` |
| bool | [IsTWCertifiedDLL](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a2483971dd32e3b5f4d000e677e33d5cb) `[get]` |
| bool | [DLLExists](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a6f5f39286487acf9b409585c4687b4f3) `[get]` |
|  | Some submodules are in the SubModule.xml but are not physically on disk. |
| List< string > | [Assemblies](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a7321a44b2f3a05c1c82c353057b1c96d) `[get]` |
| string | [SubModuleClassTypeName](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#ab8cfa0a6fb13836bddef7eaabc14fa1f) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a18fad4cddecb2a8f0a8a37aed3f13494)SubModuleTags
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.ModuleManager.SubModuleInfo.SubModuleTags](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a18fad4cddecb2a8f0a8a37aed3f13494) |

| Enumerator | |
| --- | --- |
| RejectedPlatform |  |
| ExclusivePlatform |  |
| DedicatedServerType |  |
| IsNoRenderModeElement |  |
| DependantRuntimeLibrary |  |
| PlayerHostedDedicatedServer |  |
| EngineType |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#ae16479bbf4926097122dd16934be13bc)SubModuleInfo()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.ModuleManager.SubModuleInfo.SubModuleInfo | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#adbf07e35c24713df5fa5772ff6874c3d)LoadFrom()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.ModuleManager.SubModuleInfo.LoadFrom | ( | XmlNode | *subModuleNode*, |
|  |  | string | *path*, |
|  |  | bool | *isOfficial* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#affd7a0164955adaa9b53c83398b9d1ea)Tags
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly List<Tuple<[SubModuleTags](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a18fad4cddecb2a8f0a8a37aed3f13494), string> > TaleWorlds.ModuleManager.SubModuleInfo.Tags |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a6718906ee09a08637235ce08c12df050)Name
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.ModuleManager.SubModuleInfo.Name | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a396b349c41a8e358bf62c0981f7d7083)DLLName
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.ModuleManager.SubModuleInfo.DLLName | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#aeda3f22d19f6a907ae725efeee2f320d)DLLPath
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.ModuleManager.SubModuleInfo.DLLPath | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a2483971dd32e3b5f4d000e677e33d5cb)IsTWCertifiedDLL
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.ModuleManager.SubModuleInfo.IsTWCertifiedDLL | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a6f5f39286487acf9b409585c4687b4f3)DLLExists
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.ModuleManager.SubModuleInfo.DLLExists | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#a7321a44b2f3a05c1c82c353057b1c96d)Assemblies
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<string> TaleWorlds.ModuleManager.SubModuleInfo.Assemblies | | get |

[◆](class_tale_worlds_1_1_module_manager_1_1_sub_module_info.html#ab8cfa0a6fb13836bddef7eaabc14fa1f)SubModuleClassTypeName
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.ModuleManager.SubModuleInfo.SubModuleClassTypeName | | get |


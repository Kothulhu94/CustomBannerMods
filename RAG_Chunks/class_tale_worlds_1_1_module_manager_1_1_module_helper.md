--- SOURCE: class_tale_worlds_1_1_module_manager_1_1_module_helper.html ---

TaleWorlds.ModuleManager.ModuleHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [GetModuleFullPath](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a6d8d38fdbf216237844c4e5a5b04a3b0) (string moduleId) |
| static [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) | [GetModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a56367a1a8b3be097936a30a4c18c2fef) (string moduleId) |
| static void | [OnModuleDeactivated](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#aea165bbe921eaca205a754b79b83114e) (string id) |
| static void | [OnModuleActivated](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a1d72791f2568d899e51d4b1ca702ba6c) (string id) |
| static void | [InitializeModules](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#aa6288105bbeb840104443e0aa2b62770) (string[] loadedModuleIds, string[] platformModulePaths=null) |
| static [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) | [InitializeSingleModule](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a4dc89736e34f57c0c87cbc977de6fcb6) (string modulePath) |
| static bool | [IsModuleActive](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a3f8f3049acd54479549443f7bf639a9a) (string moduleId) |
| static void | [InitializePlatformModuleExtension](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a27a0330ad29cbeded35152a764fc18fc) ([IPlatformModuleExtension](interface_tale_worlds_1_1_module_manager_1_1_i_platform_module_extension.html) moduleExtension, List< string > args) |
| static void | [ClearPlatformModuleExtension](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#aaf974816061dfde2dad174da18dabc13) () |
| static List< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > | [GetModuleInfos](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#ac4000acfe80a8b2c3006132aa7b0c3cd) (string[] moduleIds) |
| static List< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > | [GetModules](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a976f54678b339a7c8c054e6b4f38bf63) (Func< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html), bool > cond=null) |
| static Dictionary< string, [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) >.ValueCollection | [GetAllModules](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a073a9e4957189655e503c86500ccc35b) () |
| static List< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > | [GetActiveModules](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a2ebc0d5499f6928809f1675242be1a7e) () |
| static string | [GetMbprojPath](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#ad7b30de9721bb2cbf2069fbfb1e67e68) (string id) |
| static string | [GetXmlPathForNative](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a813e0060e3c89fd0abd4647ca9d749df) (string moduleId, string xmlName) |
| static string | [GetXmlPathForNativeWBase](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a8e8ab370b71f81103ccae01d5d11c353) (string moduleId, string xmlName) |
| static string | [GetXsltPathForNative](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a56f62944ec58eb0e0b9aad90cde516fd) (string moduleId, string xsltName) |
| static string | [GetPath](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a43ae41b6089d50ec385d4950084ad2c5) (string id) |
| static string | [GetXmlPath](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a640ee71de7f2bb4a785487acb423f4ad) (string moduleId, string xmlName) |
| static string | [GetXsltPath](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#aa6d24c4695316bb31c710488f0381238) (string moduleId, string xmlName) |
| static string | [GetXsdPathForModules](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a83de4f36d405ef246d805a1bc1108233) (string moduleId, string xsdName) |
| static string | [GetXsdPath](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a6fbe1f1f6284941ec57a51db21184ad8) (string xmlInfoId) |
| static IEnumerable< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > | [GetDependentModulesOf](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a15354f7dbff9abf8e8e09d404c1c59ea) (IEnumerable< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > source, [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) module) |
| static List< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > | [GetSortedModules](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#af473638db0880852f47b50981bd413a8) (string[] moduleIDs) |
| static List< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > | [GetModulesForLauncher](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a11688753f646175da0c0db9acbb20a7d) () |
| static MBList< string > | [GetOfficialModuleIds](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#aad7643b3e4fdd35deb6fb0011b3a1dd2) () |
|  | When using this function, we must consider if we are checking against module names or ids because in some cases they might be different. |
| static MBList< Assembly > | [GetActiveGameAssemblies](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a70bc3625d1bbeb89ac709eb1a2a7eb1f) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const char | [ModuleVersionSeperator](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#ad09925a556e5126b495748eb1d51c8c4) = ':' |
| static bool | [IsTestMode](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#abc25b64eec3eacf368bb0776ed1e8e15) = false |
| const char | [ModuleCodeSeperator](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a128bd05a3a2138224b1a6bf17e0d2b1d) = ';' |
| static readonly MBList< string > | [ModulesDisablingLoadingAfterBeingRemoved](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a0d04084ac8a80818ca372fbb6e9d0d4e) = new MBList<string>() { "StoryMode", "NavalDLC"} |
| static readonly MBList< string > | [ModulesDisablingLoadingAfterBeingAdded](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a51bd96f453c771166f13b3608c966e50) = new MBList<string>() { "NavalDLC"} |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a6d8d38fdbf216237844c4e5a5b04a3b0)GetModuleFullPath()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.ModuleManager.ModuleHelper.GetModuleFullPath | ( | string | *moduleId* | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a56367a1a8b3be097936a30a4c18c2fef)GetModuleInfo()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) TaleWorlds.ModuleManager.ModuleHelper.GetModuleInfo | ( | string | *moduleId* | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#aea165bbe921eaca205a754b79b83114e)OnModuleDeactivated()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.ModuleManager.ModuleHelper.OnModuleDeactivated | ( | string | *id* | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a1d72791f2568d899e51d4b1ca702ba6c)OnModuleActivated()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.ModuleManager.ModuleHelper.OnModuleActivated | ( | string | *id* | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#aa6288105bbeb840104443e0aa2b62770)InitializeModules()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.ModuleManager.ModuleHelper.InitializeModules | ( | string[] | *loadedModuleIds*, | |  |  | string[] | *platformModulePaths* = null ) | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a4dc89736e34f57c0c87cbc977de6fcb6)InitializeSingleModule()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) TaleWorlds.ModuleManager.ModuleHelper.InitializeSingleModule | ( | string | *modulePath* | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a3f8f3049acd54479549443f7bf639a9a)IsModuleActive()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.ModuleManager.ModuleHelper.IsModuleActive | ( | string | *moduleId* | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a27a0330ad29cbeded35152a764fc18fc)InitializePlatformModuleExtension()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.ModuleManager.ModuleHelper.InitializePlatformModuleExtension | ( | [IPlatformModuleExtension](interface_tale_worlds_1_1_module_manager_1_1_i_platform_module_extension.html) | *moduleExtension*, | |  |  | List< string > | *args* ) | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#aaf974816061dfde2dad174da18dabc13)ClearPlatformModuleExtension()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.ModuleManager.ModuleHelper.ClearPlatformModuleExtension | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#ac4000acfe80a8b2c3006132aa7b0c3cd)GetModuleInfos()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > TaleWorlds.ModuleManager.ModuleHelper.GetModuleInfos | ( | string[] | *moduleIds* | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a976f54678b339a7c8c054e6b4f38bf63)GetModules()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > TaleWorlds.ModuleManager.ModuleHelper.GetModules | ( | Func< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html), bool > | *cond* = null | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a073a9e4957189655e503c86500ccc35b)GetAllModules()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | Dictionary< string, [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) >.ValueCollection TaleWorlds.ModuleManager.ModuleHelper.GetAllModules | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a2ebc0d5499f6928809f1675242be1a7e)GetActiveModules()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | List< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > TaleWorlds.ModuleManager.ModuleHelper.GetActiveModules | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#ad7b30de9721bb2cbf2069fbfb1e67e68)GetMbprojPath()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.ModuleManager.ModuleHelper.GetMbprojPath | ( | string | *id* | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a813e0060e3c89fd0abd4647ca9d749df)GetXmlPathForNative()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.ModuleManager.ModuleHelper.GetXmlPathForNative | ( | string | *moduleId*, | |  |  | string | *xmlName* ) | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a8e8ab370b71f81103ccae01d5d11c353)GetXmlPathForNativeWBase()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.ModuleManager.ModuleHelper.GetXmlPathForNativeWBase | ( | string | *moduleId*, | |  |  | string | *xmlName* ) | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a56f62944ec58eb0e0b9aad90cde516fd)GetXsltPathForNative()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.ModuleManager.ModuleHelper.GetXsltPathForNative | ( | string | *moduleId*, | |  |  | string | *xsltName* ) | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a43ae41b6089d50ec385d4950084ad2c5)GetPath()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.ModuleManager.ModuleHelper.GetPath | ( | string | *id* | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a640ee71de7f2bb4a785487acb423f4ad)GetXmlPath()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.ModuleManager.ModuleHelper.GetXmlPath | ( | string | *moduleId*, | |  |  | string | *xmlName* ) | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#aa6d24c4695316bb31c710488f0381238)GetXsltPath()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.ModuleManager.ModuleHelper.GetXsltPath | ( | string | *moduleId*, | |  |  | string | *xmlName* ) | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a83de4f36d405ef246d805a1bc1108233)GetXsdPathForModules()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.ModuleManager.ModuleHelper.GetXsdPathForModules | ( | string | *moduleId*, | |  |  | string | *xsdName* ) | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a6fbe1f1f6284941ec57a51db21184ad8)GetXsdPath()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.ModuleManager.ModuleHelper.GetXsdPath | ( | string | *xmlInfoId* | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a15354f7dbff9abf8e8e09d404c1c59ea)GetDependentModulesOf()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > TaleWorlds.ModuleManager.ModuleHelper.GetDependentModulesOf | ( | IEnumerable< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > | *source*, | |  |  | [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) | *module* ) | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#af473638db0880852f47b50981bd413a8)GetSortedModules()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > TaleWorlds.ModuleManager.ModuleHelper.GetSortedModules | ( | string[] | *moduleIDs* | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a11688753f646175da0c0db9acbb20a7d)GetModulesForLauncher()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | List< [ModuleInfo](class_tale_worlds_1_1_module_manager_1_1_module_info.html) > TaleWorlds.ModuleManager.ModuleHelper.GetModulesForLauncher | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#aad7643b3e4fdd35deb6fb0011b3a1dd2)GetOfficialModuleIds()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | MBList< string > TaleWorlds.ModuleManager.ModuleHelper.GetOfficialModuleIds | ( |  | ) |  | | static |

Returns

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a70bc3625d1bbeb89ac709eb1a2a7eb1f)GetActiveGameAssemblies()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | MBList< Assembly > TaleWorlds.ModuleManager.ModuleHelper.GetActiveGameAssemblies | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#ad09925a556e5126b495748eb1d51c8c4)ModuleVersionSeperator
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const char TaleWorlds.ModuleManager.ModuleHelper.ModuleVersionSeperator = ':' | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#abc25b64eec3eacf368bb0776ed1e8e15)IsTestMode
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.ModuleManager.ModuleHelper.IsTestMode = false | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a128bd05a3a2138224b1a6bf17e0d2b1d)ModuleCodeSeperator
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const char TaleWorlds.ModuleManager.ModuleHelper.ModuleCodeSeperator = ';' | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a0d04084ac8a80818ca372fbb6e9d0d4e)ModulesDisablingLoadingAfterBeingRemoved
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly MBList<string> TaleWorlds.ModuleManager.ModuleHelper.ModulesDisablingLoadingAfterBeingRemoved = new MBList<string>() { "StoryMode", "NavalDLC"} | | static |

[◆](class_tale_worlds_1_1_module_manager_1_1_module_helper.html#a51bd96f453c771166f13b3608c966e50)ModulesDisablingLoadingAfterBeingAdded
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly MBList<string> TaleWorlds.ModuleManager.ModuleHelper.ModulesDisablingLoadingAfterBeingAdded = new MBList<string>() { "NavalDLC"} | | static |


--- SOURCE: class_sand_box_1_1_sand_box_save_helper.html ---

SandBox.SandBoxSaveHelper Class Reference|  |  |
| --- | --- |
| Classes | |
| struct | [ModuleCheckResult](struct_sand_box_1_1_sand_box_save_helper_1_1_module_check_result.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [SaveHelperState](class_sand_box_1_1_sand_box_save_helper.html#a8ec16c8328d9157007de28cdf2371a7d) {     [Start](class_sand_box_1_1_sand_box_save_helper.html#a8ec16c8328d9157007de28cdf2371a7daa6122a65eaa676f700ae68d393054a37) ,     [Inquiry](class_sand_box_1_1_sand_box_save_helper.html#a8ec16c8328d9157007de28cdf2371a7da41fff5bed96e5866dce2075ad9f4e7c6) ,     [LoadGame](class_sand_box_1_1_sand_box_save_helper.html#a8ec16c8328d9157007de28cdf2371a7da1613dbfa6c7c385e7aea951a03f93f58)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [TryLoadSave](class_sand_box_1_1_sand_box_save_helper.html#a08cc024e0b7222996c37b7dd330308df) (SaveGameFileInfo saveInfo, Action< LoadResult > onStartGame, Action onCancel=null) |
| static MBReadOnlyList< [ModuleCheckResult](struct_sand_box_1_1_sand_box_save_helper_1_1_module_check_result.html) > | [CheckMetaDataCompatibilityErrors](class_sand_box_1_1_sand_box_save_helper.html#aead944bece59520ec11c106595e92339) (MetaData fileMetaData) |
| static bool | [GetIsDisabledWithReason](class_sand_box_1_1_sand_box_save_helper.html#a49c9b498185b56e9f466142bc8ec3780) (SaveGameFileInfo saveGameFileInfo, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason) |
| static string | [GetModuleNameFromModuleId](class_sand_box_1_1_sand_box_save_helper.html#ab2877ac582a3443662450a57fafbf627) (string id) |

|  |  |
| --- | --- |
| Events | |
| static Action< [SaveHelperState](class_sand_box_1_1_sand_box_save_helper.html#a8ec16c8328d9157007de28cdf2371a7d) > | [OnStateChange](class_sand_box_1_1_sand_box_save_helper.html#a303d2f80ebdd52e6d208dd227a62a01c) |

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_sand_box_save_helper.html#a8ec16c8328d9157007de28cdf2371a7d)SaveHelperState
--------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.SandBoxSaveHelper.SaveHelperState](class_sand_box_1_1_sand_box_save_helper.html#a8ec16c8328d9157007de28cdf2371a7d) |

| Enumerator | |
| --- | --- |
| Start |  |
| Inquiry |  |
| LoadGame |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_sand_box_save_helper.html#a08cc024e0b7222996c37b7dd330308df)TryLoadSave()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void SandBox.SandBoxSaveHelper.TryLoadSave | ( | SaveGameFileInfo | *saveInfo*, | |  |  | Action< LoadResult > | *onStartGame*, | |  |  | Action | *onCancel* = null ) | | static |

[◆](class_sand_box_1_1_sand_box_save_helper.html#aead944bece59520ec11c106595e92339)CheckMetaDataCompatibilityErrors()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBReadOnlyList< [ModuleCheckResult](struct_sand_box_1_1_sand_box_save_helper_1_1_module_check_result.html) > SandBox.SandBoxSaveHelper.CheckMetaDataCompatibilityErrors | ( | MetaData | *fileMetaData* | ) |  | | static |

[◆](class_sand_box_1_1_sand_box_save_helper.html#a49c9b498185b56e9f466142bc8ec3780)GetIsDisabledWithReason()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool SandBox.SandBoxSaveHelper.GetIsDisabledWithReason | ( | SaveGameFileInfo | *saveGameFileInfo*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason* ) | | static |

[◆](class_sand_box_1_1_sand_box_save_helper.html#ab2877ac582a3443662450a57fafbf627)GetModuleNameFromModuleId()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string SandBox.SandBoxSaveHelper.GetModuleNameFromModuleId | ( | string | *id* | ) |  | | static |

Event Documentation
-------------------

[◆](class_sand_box_1_1_sand_box_save_helper.html#a303d2f80ebdd52e6d208dd227a62a01c)OnStateChange
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[SaveHelperState](class_sand_box_1_1_sand_box_save_helper.html#a8ec16c8328d9157007de28cdf2371a7d)> SandBox.SandBoxSaveHelper.OnStateChange | | static |


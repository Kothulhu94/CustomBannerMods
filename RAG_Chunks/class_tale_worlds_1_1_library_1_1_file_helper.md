--- SOURCE: class_tale_worlds_1_1_library_1_1_file_helper.html ---

TaleWorlds.Library.FileHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) | [SaveFile](class_tale_worlds_1_1_library_1_1_file_helper.html#a33265b71faa3709d576bc01e2e1fefc7) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, byte[] data) |
| static [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) | [SaveFileString](class_tale_worlds_1_1_library_1_1_file_helper.html#aec416b6e243816084c407499eb358330) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, string data) |
| static string | [GetFileFullPath](class_tale_worlds_1_1_library_1_1_file_helper.html#a057957cd62160dcdcd3f232ec5da07d4) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| static [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) | [AppendLineToFileString](class_tale_worlds_1_1_library_1_1_file_helper.html#ac7b2f68ad29fa80416d6898b1224b838) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, string data) |
| static Task< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > | [SaveFileAsync](class_tale_worlds_1_1_library_1_1_file_helper.html#a7a878c34176a56c4fa5b6928ee1e225e) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, byte[] data) |
| static Task< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > | [SaveFileStringAsync](class_tale_worlds_1_1_library_1_1_file_helper.html#a2d06d4c0d3af15928799fc01737d6ed8) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, string data) |
| static string | [GetError](class_tale_worlds_1_1_library_1_1_file_helper.html#ac0f1b5149c482fe29c855e85b828ffb1) () |
| static bool | [FileExists](class_tale_worlds_1_1_library_1_1_file_helper.html#a198a5ddbdea28cbe8176558ce15bd91a) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| static Task< string > | [GetFileContentStringAsync](class_tale_worlds_1_1_library_1_1_file_helper.html#a2ea9cbf885a89778b24bd0a44cdb56a9) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| static string | [GetFileContentString](class_tale_worlds_1_1_library_1_1_file_helper.html#a3399a1904e576897f0986629380db612) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| static void | [DeleteFile](class_tale_worlds_1_1_library_1_1_file_helper.html#a46c2e7662221f7722cca333776bd3c21) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| static [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html)[] | [GetFiles](class_tale_worlds_1_1_library_1_1_file_helper.html#a36e25d33f288dacd5f8ebb29502876ec) ([PlatformDirectoryPath](struct_tale_worlds_1_1_library_1_1_platform_directory_path.html) path, string searchPattern, SearchOption searchOption) |
| static byte[] | [GetFileContent](class_tale_worlds_1_1_library_1_1_file_helper.html#ab0cf001a440fbcbf1f4b2643dc944533) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) filePath) |
| static byte[] | [GetMetaDataContent](class_tale_worlds_1_1_library_1_1_file_helper.html#ae7082ca413a424cff484094f161d007c) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) filePath) |
| static void | [CopyFile](class_tale_worlds_1_1_library_1_1_file_helper.html#a9543474455142ddd11a9df6340e9bd54) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) source, [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) target) |
| static void | [CopyDirectory](class_tale_worlds_1_1_library_1_1_file_helper.html#acb09b5f423fd7e4f9dbec555327829a6) (string sourceDir, string destinationDir, bool recursive) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#a33265b71faa3709d576bc01e2e1fefc7)SaveFile()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) TaleWorlds.Library.FileHelper.SaveFile | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, | |  |  | byte[] | *data* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#aec416b6e243816084c407499eb358330)SaveFileString()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) TaleWorlds.Library.FileHelper.SaveFileString | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, | |  |  | string | *data* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#a057957cd62160dcdcd3f232ec5da07d4)GetFileFullPath()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Library.FileHelper.GetFileFullPath | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#ac7b2f68ad29fa80416d6898b1224b838)AppendLineToFileString()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) TaleWorlds.Library.FileHelper.AppendLineToFileString | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, | |  |  | string | *data* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#a7a878c34176a56c4fa5b6928ee1e225e)SaveFileAsync()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Task< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > TaleWorlds.Library.FileHelper.SaveFileAsync | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, | |  |  | byte[] | *data* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#a2d06d4c0d3af15928799fc01737d6ed8)SaveFileStringAsync()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Task< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > TaleWorlds.Library.FileHelper.SaveFileStringAsync | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, | |  |  | string | *data* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#ac0f1b5149c482fe29c855e85b828ffb1)GetError()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Library.FileHelper.GetError | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#a198a5ddbdea28cbe8176558ce15bd91a)FileExists()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Library.FileHelper.FileExists | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#a2ea9cbf885a89778b24bd0a44cdb56a9)GetFileContentStringAsync()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Task< string > TaleWorlds.Library.FileHelper.GetFileContentStringAsync | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#a3399a1904e576897f0986629380db612)GetFileContentString()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Library.FileHelper.GetFileContentString | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#a46c2e7662221f7722cca333776bd3c21)DeleteFile()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.FileHelper.DeleteFile | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#a36e25d33f288dacd5f8ebb29502876ec)GetFiles()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html)[] TaleWorlds.Library.FileHelper.GetFiles | ( | [PlatformDirectoryPath](struct_tale_worlds_1_1_library_1_1_platform_directory_path.html) | *path*, | |  |  | string | *searchPattern*, | |  |  | SearchOption | *searchOption* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#ab0cf001a440fbcbf1f4b2643dc944533)GetFileContent()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | byte[] TaleWorlds.Library.FileHelper.GetFileContent | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *filePath* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#ae7082ca413a424cff484094f161d007c)GetMetaDataContent()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | byte[] TaleWorlds.Library.FileHelper.GetMetaDataContent | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *filePath* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#a9543474455142ddd11a9df6340e9bd54)CopyFile()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.FileHelper.CopyFile | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *source*, | |  |  | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *target* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_file_helper.html#acb09b5f423fd7e4f9dbec555327829a6)CopyDirectory()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.FileHelper.CopyDirectory | ( | string | *sourceDir*, | |  |  | string | *destinationDir*, | |  |  | bool | *recursive* ) | | static |


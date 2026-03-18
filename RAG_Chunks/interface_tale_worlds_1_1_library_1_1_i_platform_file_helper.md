--- SOURCE: interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html ---

TaleWorlds.Library.IPlatformFileHelper Interface ReferenceInherited by [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) | [SaveFile](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a4aee1772780fb75bb14d84c6fdf10aa7) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, byte[] data) |
| [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) | [SaveFileString](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a93b5e82363a60df113a9b0beb5dd591b) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, string data) |
| [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) | [AppendLineToFileString](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a0356979e596d3e2fae8f57f791f67384) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, string data) |
| Task< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > | [SaveFileAsync](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a9042ce9b7bcb5a087728f84684535801) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, byte[] data) |
| Task< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > | [SaveFileStringAsync](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a9ad460a8c6171e82c87bd12369384bce) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, string data) |
| bool | [FileExists](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#aa3a135abc7f8dbaadbf834105e4ca0af) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| Task< string > | [GetFileContentStringAsync](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a89532f6f6e520653f6ad77ead48a5bd7) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| string | [GetFileContentString](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#af7b0ae6b8a7dfa825862f7faf5bf11dd) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| byte[] | [GetFileContent](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a0fd890e519d4dc91df389a4b5fd13bfd) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) filePath) |
| byte[] | [GetMetaDataContent](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a55621cd620c2548737030d45f093778d) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) filePath) |
| bool | [DeleteFile](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#af6ccd782fb8093b221c5f6136a074823) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html)[] | [GetFiles](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#afdd8487c8d210838d204d8f4df36e128) ([PlatformDirectoryPath](struct_tale_worlds_1_1_library_1_1_platform_directory_path.html) path, string searchPattern, SearchOption searchOption) |
| string | [GetFileFullPath](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a40d92525ed7620ba2c31e17d1205148d) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) filePath) |
| string | [GetError](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#aab961c133f2f326b3fd3e1a655e7108c) () |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a4aee1772780fb75bb14d84c6fdf10aa7)SaveFile()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) TaleWorlds.Library.IPlatformFileHelper.SaveFile | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, |
|  |  | byte[] | *data* ) |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a3b723089b905bba9e7b8c3ba51fce6cf).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a93b5e82363a60df113a9b0beb5dd591b)SaveFileString()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) TaleWorlds.Library.IPlatformFileHelper.SaveFileString | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, |
|  |  | string | *data* ) |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a7ef4367d44fa126f5d12aaaae39546fc).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a0356979e596d3e2fae8f57f791f67384)AppendLineToFileString()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) TaleWorlds.Library.IPlatformFileHelper.AppendLineToFileString | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, |
|  |  | string | *data* ) |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a3053bea6cba18b7c34bf7a02410396c8).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a9042ce9b7bcb5a087728f84684535801)SaveFileAsync()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| Task< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > TaleWorlds.Library.IPlatformFileHelper.SaveFileAsync | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, |
|  |  | byte[] | *data* ) |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a61980d72ceb7354891b000bdd4238396).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a9ad460a8c6171e82c87bd12369384bce)SaveFileStringAsync()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| Task< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > TaleWorlds.Library.IPlatformFileHelper.SaveFileStringAsync | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, |
|  |  | string | *data* ) |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#ac8cd3402ae6b8cc4089f64b42efce5e2).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#aa3a135abc7f8dbaadbf834105e4ca0af)FileExists()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.IPlatformFileHelper.FileExists | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a3b277a92bbc71aed2e7a183a2161df1a).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a89532f6f6e520653f6ad77ead48a5bd7)GetFileContentStringAsync()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| Task< string > TaleWorlds.Library.IPlatformFileHelper.GetFileContentStringAsync | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a0d09241b9a0715d641abe59431b75598).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#af7b0ae6b8a7dfa825862f7faf5bf11dd)GetFileContentString()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Library.IPlatformFileHelper.GetFileContentString | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#ab9434963074d45d985053a4b20ddc16d).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a0fd890e519d4dc91df389a4b5fd13bfd)GetFileContent()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| byte[] TaleWorlds.Library.IPlatformFileHelper.GetFileContent | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *filePath* | ) |  |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a86e987ba70e15c1fd87b0c54d4f84c13).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a55621cd620c2548737030d45f093778d)GetMetaDataContent()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| byte[] TaleWorlds.Library.IPlatformFileHelper.GetMetaDataContent | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *filePath* | ) |  |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a65c4a9623adbf8d26f8138ef42912b00).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#af6ccd782fb8093b221c5f6136a074823)DeleteFile()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.IPlatformFileHelper.DeleteFile | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a7fc59e9243e49dc8c41da9f314771911).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#afdd8487c8d210838d204d8f4df36e128)GetFiles()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html)[] TaleWorlds.Library.IPlatformFileHelper.GetFiles | ( | [PlatformDirectoryPath](struct_tale_worlds_1_1_library_1_1_platform_directory_path.html) | *path*, |
|  |  | string | *searchPattern*, |
|  |  | SearchOption | *searchOption* ) |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#ae1056bb9003a71e30af454901bb5126d).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a40d92525ed7620ba2c31e17d1205148d)GetFileFullPath()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Library.IPlatformFileHelper.GetFileFullPath | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *filePath* | ) |  |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a92f3a5802a63560c226c10514c707c7f).

[◆](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#aab961c133f2f326b3fd3e1a655e7108c)GetError()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Library.IPlatformFileHelper.GetError | ( |  | ) |  |

Implemented in [TaleWorlds.Library.PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#af5b5c3d0dd1a0a368098b31e7c7e39ff).


--- SOURCE: class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html ---

TaleWorlds.Library.PlatformFileHelperPC Class ReferenceInherits [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PlatformFileHelperPC](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a807a0b7e21e4abe52e0f91067ba96fb1) (string applicationName) |
| [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) | [SaveFile](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a3b723089b905bba9e7b8c3ba51fce6cf) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, byte[] data) |
| [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) | [SaveFileString](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a7ef4367d44fa126f5d12aaaae39546fc) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, string data) |
| Task< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > | [SaveFileAsync](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a61980d72ceb7354891b000bdd4238396) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, byte[] data) |
| Task< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > | [SaveFileStringAsync](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#ac8cd3402ae6b8cc4089f64b42efce5e2) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, string data) |
| [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) | [AppendLineToFileString](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a3053bea6cba18b7c34bf7a02410396c8) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path, string data) |
| string | [GetFileFullPath](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a92f3a5802a63560c226c10514c707c7f) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) filePath) |
| bool | [FileExists](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a3b277a92bbc71aed2e7a183a2161df1a) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| async Task< string > | [GetFileContentStringAsync](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a0d09241b9a0715d641abe59431b75598) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| string | [GetFileContentString](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#ab9434963074d45d985053a4b20ddc16d) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| byte[] | [GetMetaDataContent](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a65c4a9623adbf8d26f8138ef42912b00) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| byte[] | [GetFileContent](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a86e987ba70e15c1fd87b0c54d4f84c13) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| bool | [DeleteFile](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a7fc59e9243e49dc8c41da9f314771911) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| void | [CreateDirectory](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#afe78e1eb47516f216ddba95e42dbf4f6) ([PlatformDirectoryPath](struct_tale_worlds_1_1_library_1_1_platform_directory_path.html) path) |
| [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html)[] | [GetFiles](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#ae1056bb9003a71e30af454901bb5126d) ([PlatformDirectoryPath](struct_tale_worlds_1_1_library_1_1_platform_directory_path.html) path, string searchPattern, SearchOption searchOption) |
| void | [RenameFile](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a9f8e2c82883902754e5cd1c639ff5b75) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) filePath, string newName) |
| string | [GetError](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#af5b5c3d0dd1a0a368098b31e7c7e39ff) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a807a0b7e21e4abe52e0f91067ba96fb1)PlatformFileHelperPC()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.PlatformFileHelperPC.PlatformFileHelperPC | ( | string | *applicationName* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a3b723089b905bba9e7b8c3ba51fce6cf)SaveFile()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) TaleWorlds.Library.PlatformFileHelperPC.SaveFile | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, |
|  |  | byte[] | *data* ) |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a4aee1772780fb75bb14d84c6fdf10aa7).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a7ef4367d44fa126f5d12aaaae39546fc)SaveFileString()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) TaleWorlds.Library.PlatformFileHelperPC.SaveFileString | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, |
|  |  | string | *data* ) |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a93b5e82363a60df113a9b0beb5dd591b).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a61980d72ceb7354891b000bdd4238396)SaveFileAsync()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| Task< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > TaleWorlds.Library.PlatformFileHelperPC.SaveFileAsync | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, |
|  |  | byte[] | *data* ) |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a9042ce9b7bcb5a087728f84684535801).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#ac8cd3402ae6b8cc4089f64b42efce5e2)SaveFileStringAsync()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| Task< [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) > TaleWorlds.Library.PlatformFileHelperPC.SaveFileStringAsync | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, |
|  |  | string | *data* ) |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a9ad460a8c6171e82c87bd12369384bce).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a3053bea6cba18b7c34bf7a02410396c8)AppendLineToFileString()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) TaleWorlds.Library.PlatformFileHelperPC.AppendLineToFileString | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path*, |
|  |  | string | *data* ) |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a0356979e596d3e2fae8f57f791f67384).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a92f3a5802a63560c226c10514c707c7f)GetFileFullPath()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Library.PlatformFileHelperPC.GetFileFullPath | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *filePath* | ) |  |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a40d92525ed7620ba2c31e17d1205148d).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a3b277a92bbc71aed2e7a183a2161df1a)FileExists()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.PlatformFileHelperPC.FileExists | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#aa3a135abc7f8dbaadbf834105e4ca0af).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a0d09241b9a0715d641abe59431b75598)GetFileContentStringAsync()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| async Task< string > TaleWorlds.Library.PlatformFileHelperPC.GetFileContentStringAsync | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a89532f6f6e520653f6ad77ead48a5bd7).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#ab9434963074d45d985053a4b20ddc16d)GetFileContentString()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Library.PlatformFileHelperPC.GetFileContentString | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#af7b0ae6b8a7dfa825862f7faf5bf11dd).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a65c4a9623adbf8d26f8138ef42912b00)GetMetaDataContent()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| byte[] TaleWorlds.Library.PlatformFileHelperPC.GetMetaDataContent | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a55621cd620c2548737030d45f093778d).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a86e987ba70e15c1fd87b0c54d4f84c13)GetFileContent()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| byte[] TaleWorlds.Library.PlatformFileHelperPC.GetFileContent | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#a0fd890e519d4dc91df389a4b5fd13bfd).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a7fc59e9243e49dc8c41da9f314771911)DeleteFile()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.PlatformFileHelperPC.DeleteFile | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#af6ccd782fb8093b221c5f6136a074823).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#afe78e1eb47516f216ddba95e42dbf4f6)CreateDirectory()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.PlatformFileHelperPC.CreateDirectory | ( | [PlatformDirectoryPath](struct_tale_worlds_1_1_library_1_1_platform_directory_path.html) | *path* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#ae1056bb9003a71e30af454901bb5126d)GetFiles()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html)[] TaleWorlds.Library.PlatformFileHelperPC.GetFiles | ( | [PlatformDirectoryPath](struct_tale_worlds_1_1_library_1_1_platform_directory_path.html) | *path*, |
|  |  | string | *searchPattern*, |
|  |  | SearchOption | *searchOption* ) |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#afdd8487c8d210838d204d8f4df36e128).

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#a9f8e2c82883902754e5cd1c639ff5b75)RenameFile()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.PlatformFileHelperPC.RenameFile | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *filePath*, |
|  |  | string | *newName* ) |

[◆](class_tale_worlds_1_1_library_1_1_platform_file_helper_p_c.html#af5b5c3d0dd1a0a368098b31e7c7e39ff)GetError()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Library.PlatformFileHelperPC.GetError | ( |  | ) |  |

Implements [TaleWorlds.Library.IPlatformFileHelper](interface_tale_worlds_1_1_library_1_1_i_platform_file_helper.html#aab961c133f2f326b3fd3e1a655e7108c).


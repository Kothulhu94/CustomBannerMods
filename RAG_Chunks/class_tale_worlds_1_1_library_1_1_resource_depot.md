--- SOURCE: class_tale_worlds_1_1_library_1_1_resource_depot.html ---

TaleWorlds.Library.ResourceDepot Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ResourceDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html#aa52f80bbef6c08287445e08a81328f36) () |
| void | [AddLocation](class_tale_worlds_1_1_library_1_1_resource_depot.html#ae01878deb4c4fc0a8efb8ab0972a56f2) (string basePath, string location) |
| void | [CollectResources](class_tale_worlds_1_1_library_1_1_resource_depot.html#a1af6f0bbf1437f1e44b5a5ac6da412ed) () |
| string[] | [GetFiles](class_tale_worlds_1_1_library_1_1_resource_depot.html#a508e856e420edc007406481d2e1afdec) (string subDirectory, string extension, bool excludeSubContents=false) |
|  | Returns all files under subDirectory, with extension. if exludeSubContents = true will only return files in subDirectory. |
| string | [GetFilePath](class_tale_worlds_1_1_library_1_1_resource_depot.html#aeb1a49d1c63286863c85ac695c5dc9df) (string file) |
| IEnumerable< string > | [GetFilesEndingWith](class_tale_worlds_1_1_library_1_1_resource_depot.html#af345707793acdbb15e46e2082b0bf9ed) (string fileEndName) |
|  | Returns full paths of all files' names ending with fileEndName. |
| void | [StartWatchingChangesInDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html#a31bf1ad462d47001541c20a5c6222dd8) () |
| void | [StopWatchingChangesInDepot](class_tale_worlds_1_1_library_1_1_resource_depot.html#a4368992b26ab51814a882c612e685d24) () |
| void | [CheckForChanges](class_tale_worlds_1_1_library_1_1_resource_depot.html#a959dedbf54e52856bc1ac2b08fe079a6) () |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [ResourceDepotLocation](class_tale_worlds_1_1_library_1_1_resource_depot_location.html) > | [ResourceLocations](class_tale_worlds_1_1_library_1_1_resource_depot.html#ada213d9f9a51554213d4c350703f5641) `[get]` |

|  |  |
| --- | --- |
| Events | |
| [ResourceChangeEvent](namespace_tale_worlds_1_1_library.html#a7faf3735ae45e83c955a18a18b2f8f58) | [OnResourceChange](class_tale_worlds_1_1_library_1_1_resource_depot.html#a35869be496a60e0d50a458d16bea83b8) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_resource_depot.html#aa52f80bbef6c08287445e08a81328f36)ResourceDepot()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Library.ResourceDepot.ResourceDepot | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_resource_depot.html#ae01878deb4c4fc0a8efb8ab0972a56f2)AddLocation()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.ResourceDepot.AddLocation | ( | string | *basePath*, |
|  |  | string | *location* ) |

[◆](class_tale_worlds_1_1_library_1_1_resource_depot.html#a1af6f0bbf1437f1e44b5a5ac6da412ed)CollectResources()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.ResourceDepot.CollectResources | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_resource_depot.html#a508e856e420edc007406481d2e1afdec)GetFiles()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| string[] TaleWorlds.Library.ResourceDepot.GetFiles | ( | string | *subDirectory*, |
|  |  | string | *extension*, |
|  |  | bool | *excludeSubContents* = false ) |

[◆](class_tale_worlds_1_1_library_1_1_resource_depot.html#aeb1a49d1c63286863c85ac695c5dc9df)GetFilePath()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Library.ResourceDepot.GetFilePath | ( | string | *file* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_resource_depot.html#af345707793acdbb15e46e2082b0bf9ed)GetFilesEndingWith()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< string > TaleWorlds.Library.ResourceDepot.GetFilesEndingWith | ( | string | *fileEndName* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_resource_depot.html#a31bf1ad462d47001541c20a5c6222dd8)StartWatchingChangesInDepot()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.ResourceDepot.StartWatchingChangesInDepot | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_resource_depot.html#a4368992b26ab51814a882c612e685d24)StopWatchingChangesInDepot()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.ResourceDepot.StopWatchingChangesInDepot | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_resource_depot.html#a959dedbf54e52856bc1ac2b08fe079a6)CheckForChanges()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.ResourceDepot.CheckForChanges | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_resource_depot.html#ada213d9f9a51554213d4c350703f5641)ResourceLocations
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[ResourceDepotLocation](class_tale_worlds_1_1_library_1_1_resource_depot_location.html)> TaleWorlds.Library.ResourceDepot.ResourceLocations | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_library_1_1_resource_depot.html#a35869be496a60e0d50a458d16bea83b8)OnResourceChange
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ResourceChangeEvent](namespace_tale_worlds_1_1_library.html#a7faf3735ae45e83c955a18a18b2f8f58) TaleWorlds.Library.ResourceDepot.OnResourceChange |


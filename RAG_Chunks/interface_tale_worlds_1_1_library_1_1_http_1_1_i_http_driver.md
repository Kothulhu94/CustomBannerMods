--- SOURCE: interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_driver.html ---

TaleWorlds.Library.Http.IHttpDriver Interface ReferenceInherited by [TaleWorlds.Library.Http.DotNetHttpDriver](class_tale_worlds_1_1_library_1_1_http_1_1_dot_net_http_driver.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| Task< string > | [HttpGetString](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_driver.html#aa88bd2b63c48e0bce4efa0103860f80a) (string url, bool withUserToken) |
| Task< string > | [HttpPostString](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_driver.html#af8671fe3eaf091074655dcf8b2b9e150) (string url, string postData, string mediaType, bool withUserToken) |
| Task< byte[]> | [HttpDownloadData](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_driver.html#acabfc2e5c922c4f1f5f7ed3b16f505d4) (string url) |
| [IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html) | [CreateHttpPostRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_driver.html#a476890c5245d6fb76f39c591830ce365) (string address, string postData, bool withUserToken) |
| [IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html) | [CreateHttpGetRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_driver.html#a67e3ad19e0e95588dc4bdd7af227c13e) (string address, bool withUserToken) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_driver.html#aa88bd2b63c48e0bce4efa0103860f80a)HttpGetString()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| Task< string > TaleWorlds.Library.Http.IHttpDriver.HttpGetString | ( | string | *url*, |
|  |  | bool | *withUserToken* ) |

[◆](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_driver.html#af8671fe3eaf091074655dcf8b2b9e150)HttpPostString()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| Task< string > TaleWorlds.Library.Http.IHttpDriver.HttpPostString | ( | string | *url*, |
|  |  | string | *postData*, |
|  |  | string | *mediaType*, |
|  |  | bool | *withUserToken* ) |

[◆](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_driver.html#acabfc2e5c922c4f1f5f7ed3b16f505d4)HttpDownloadData()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| Task< byte[]> TaleWorlds.Library.Http.IHttpDriver.HttpDownloadData | ( | string | *url* | ) |  |

[◆](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_driver.html#a476890c5245d6fb76f39c591830ce365)CreateHttpPostRequestTask()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html) TaleWorlds.Library.Http.IHttpDriver.CreateHttpPostRequestTask | ( | string | *address*, |
|  |  | string | *postData*, |
|  |  | bool | *withUserToken* ) |

[◆](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_driver.html#a67e3ad19e0e95588dc4bdd7af227c13e)CreateHttpGetRequestTask()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html) TaleWorlds.Library.Http.IHttpDriver.CreateHttpGetRequestTask | ( | string | *address*, |
|  |  | bool | *withUserToken* ) |


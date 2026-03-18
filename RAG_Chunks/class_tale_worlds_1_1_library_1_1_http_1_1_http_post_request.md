--- SOURCE: class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html ---

TaleWorlds.Library.Http.HttpPostRequest Class ReferenceInherits [TaleWorlds.Library.Http.IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [HttpPostRequest](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#a17b50c153636e1de0e57e59ad28026b2) (HttpClient httpClient, string address, string postData) |
|  | [HttpPostRequest](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#a7d73e79ad3059163a162d557f60d1f1e) (HttpClient httpClient, string address, string postData, Version version) |
| void | [Start](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#a60e536a74acda37287b84d0ea7e028e4) () |

|  |  |
| --- | --- |
| Properties | |
| [HttpRequestTaskState](namespace_tale_worlds_1_1_library_1_1_http.html#aafaaa1ae32cfccbec93907176ad4584a) | [State](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#afff3bfc9dba3f2ef3924f909911e7e73) `[get]` |
| bool | [Successful](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#a797a2f3b2fb025f2cbe655123b2d5c32) `[get]` |
| string | [ResponseData](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#a76250b70cb43304b25b272e3e4d92bba) `[get]` |
| Exception | [Exception](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#a3dab3904e50c4480e7c34def4a9cc334) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#a17b50c153636e1de0e57e59ad28026b2)HttpPostRequest() [1/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Http.HttpPostRequest.HttpPostRequest | ( | HttpClient | *httpClient*, |
|  |  | string | *address*, |
|  |  | string | *postData* ) |

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#a7d73e79ad3059163a162d557f60d1f1e)HttpPostRequest() [2/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Http.HttpPostRequest.HttpPostRequest | ( | HttpClient | *httpClient*, |
|  |  | string | *address*, |
|  |  | string | *postData*, |
|  |  | Version | *version* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#a60e536a74acda37287b84d0ea7e028e4)Start()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Http.HttpPostRequest.Start | ( |  | ) |  |

Implements [TaleWorlds.Library.Http.IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html#ab2ead6e02fa35ae2ba388336a294ab5c).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#afff3bfc9dba3f2ef3924f909911e7e73)State
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HttpRequestTaskState](namespace_tale_worlds_1_1_library_1_1_http.html#aafaaa1ae32cfccbec93907176ad4584a) TaleWorlds.Library.Http.HttpPostRequest.State | | get |

Implements [TaleWorlds.Library.Http.IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html#a67c9dd9a12f57e10116f030e97533e0b).

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#a797a2f3b2fb025f2cbe655123b2d5c32)Successful
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.Http.HttpPostRequest.Successful | | get |

Implements [TaleWorlds.Library.Http.IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html#a30a81d62ed02b209f25161e9235dd0b6).

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#a76250b70cb43304b25b272e3e4d92bba)ResponseData
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.Http.HttpPostRequest.ResponseData | | get |

Implements [TaleWorlds.Library.Http.IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html#aaceec2735c4e2e8436328b3667b153ed).

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_post_request.html#a3dab3904e50c4480e7c34def4a9cc334)Exception
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Exception TaleWorlds.Library.Http.HttpPostRequest.Exception | | get |

Implements [TaleWorlds.Library.Http.IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html#a0bf005ada820f96b865b74204d4512f9).


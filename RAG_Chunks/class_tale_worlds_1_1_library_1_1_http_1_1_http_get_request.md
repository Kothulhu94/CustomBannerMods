--- SOURCE: class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html ---

TaleWorlds.Library.Http.HttpGetRequest Class ReferenceInherits [TaleWorlds.Library.Http.IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [HttpGetRequest](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#a4ddf7485c86b793a8ea452507727a593) (HttpClient httpClient, string address) |
|  | [HttpGetRequest](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#adbfb3441b0cfba162868172bb06bc589) (HttpClient httpClient, string address, Version version) |
| void | [Start](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#a0efb0fb40f891c165e473f2dc0912785) () |

|  |  |
| --- | --- |
| Properties | |
| [HttpRequestTaskState](namespace_tale_worlds_1_1_library_1_1_http.html#aafaaa1ae32cfccbec93907176ad4584a) | [State](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#ae01d9b861d24f3c7b163237e29930bfe) `[get]` |
| bool | [Successful](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#a574b38844ccd52933ff869c07ee7ce30) `[get]` |
| string | [ResponseData](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#af48b4ff0ff052b17da2630582fb321d8) `[get]` |
| HttpStatusCode | [ResponseStatusCode](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#afa8a7c0b916aca87a345d6a80c8c2716) `[get]` |
| Exception | [Exception](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#ad9fde358318d651411656a853549a3a8) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#a4ddf7485c86b793a8ea452507727a593)HttpGetRequest() [1/2]
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Http.HttpGetRequest.HttpGetRequest | ( | HttpClient | *httpClient*, |
|  |  | string | *address* ) |

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#adbfb3441b0cfba162868172bb06bc589)HttpGetRequest() [2/2]
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Http.HttpGetRequest.HttpGetRequest | ( | HttpClient | *httpClient*, |
|  |  | string | *address*, |
|  |  | Version | *version* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#a0efb0fb40f891c165e473f2dc0912785)Start()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Http.HttpGetRequest.Start | ( |  | ) |  |

Implements [TaleWorlds.Library.Http.IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html#ab2ead6e02fa35ae2ba388336a294ab5c).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#ae01d9b861d24f3c7b163237e29930bfe)State
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HttpRequestTaskState](namespace_tale_worlds_1_1_library_1_1_http.html#aafaaa1ae32cfccbec93907176ad4584a) TaleWorlds.Library.Http.HttpGetRequest.State | | get |

Implements [TaleWorlds.Library.Http.IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html#a67c9dd9a12f57e10116f030e97533e0b).

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#a574b38844ccd52933ff869c07ee7ce30)Successful
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.Http.HttpGetRequest.Successful | | get |

Implements [TaleWorlds.Library.Http.IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html#a30a81d62ed02b209f25161e9235dd0b6).

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#af48b4ff0ff052b17da2630582fb321d8)ResponseData
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.Http.HttpGetRequest.ResponseData | | get |

Implements [TaleWorlds.Library.Http.IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html#aaceec2735c4e2e8436328b3667b153ed).

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#afa8a7c0b916aca87a345d6a80c8c2716)ResponseStatusCode
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | HttpStatusCode TaleWorlds.Library.Http.HttpGetRequest.ResponseStatusCode | | get |

[◆](class_tale_worlds_1_1_library_1_1_http_1_1_http_get_request.html#ad9fde358318d651411656a853549a3a8)Exception
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Exception TaleWorlds.Library.Http.HttpGetRequest.Exception | | get |

Implements [TaleWorlds.Library.Http.IHttpRequestTask](interface_tale_worlds_1_1_library_1_1_http_1_1_i_http_request_task.html#a0bf005ada820f96b865b74204d4512f9).


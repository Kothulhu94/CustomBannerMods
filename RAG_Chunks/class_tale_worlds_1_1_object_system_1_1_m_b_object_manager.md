--- SOURCE: class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html ---

TaleWorlds.ObjectSystem.MBObjectManager Class Referencesealed|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Destroy](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ab29183dfbfd8f7600e94225f4fa6a45c) () |
| void | [RegisterType< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a8ae4ef740aa399aec2cfece4371571f1) (string classPrefix, string classListPrefix, uint typeId, bool autoCreateInstance=true, bool isTemporary=false) |
| bool | [HasType< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a37f48e4ad37177e2b1ea3a700162750a) () |
| bool | [HasType](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a6e1f0a4d4798740a6e590860f159e6b7) (Type type) |
| string | [FindRegisteredClassPrefix](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a6328b818a509b0f0aa0fd6cfe4c3d734) (Type type) |
| Type | [FindRegisteredType](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a302662351001e8e19c719189b26ef35b) (string classPrefix) |
| T | [RegisterObject< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a944ef2bc14e1316c1627f4cebc5f42e0) (T obj) |
| T | [RegisterPresumedObject< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ad60061a66b30cc400a7b34c37eef6e44) (T obj) |
| void | [UnregisterObject](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a3157e661ed3966de8ce2021a2a0d5bcc) ([MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) obj) |
| T | [GetObject< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a5cb4bbfb15282e9d3182b295b19e8886) (Func< T, bool > predicate) |
| MBReadOnlyList< T > | [GetObjects< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a2e0c38e0f71776c1140bf119556017ae) (Func< T, bool > predicate) |
| T | [GetObject< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ab236bdfd17632746ce5eba7176201eba) (string objectName) |
| T | [GetFirstObject< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a21438dcd2c5844cda8178b0d2f3ad498) () |
| bool | [ContainsObject< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#aec976730afd1b1bc282138af996f3580) (string objectName) |
| void | [RemoveTemporaryTypes](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#aa1bd2c847cb379ca1409fde4b13167b7) () |
| void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#af60e85a7c37563411c996a188f33fc9d) () |
| void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a4b4d1f576287812445545436a15dc224) () |
| [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | [GetObject](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a2645c16e860b17ec84d8be1c7a42a70c) ([MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) objectId) |
| [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | [GetObject](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a56320c8f1c0eafc7e685ec126555968f) (string typeName, string objectName) |
| MBReadOnlyList< T > | [GetObjectTypeList< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a73fc2485d7fbd062e818eb7edb3abe11) () |
| IList< [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) > | [CreateObjectTypeList](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#aaaaff4bfa387702f9c3059d29020b01c) (Type objectClassType) |
| void | [LoadXML](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a46d5dd5dcabe100976dafeb01150cdac) (string id, bool isDevelopment, string gameType, bool skipXmlFilterForEditor=false) |
| void | [LoadOneXmlFromFile](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a7981c9a51e490eb0183abe2ac8157c2f) (string xmlPath, string xsdPath, bool skipValidation=false) |
| XmlDocument | [LoadXMLFromFileSkipValidation](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ae7515975614224bec44c60503f1fd93d) (string xmlPath, string xsdPath) |
| void | [LoadXml](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a0b7c61d2d64d23e23f782f559b7973d8) (XmlDocument doc, bool isDevelopment=false) |
| [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | [CreateObjectFromXmlNode](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ab260ccacc6f214cc90f03927fbbc4a95) (XmlNode node) |
| [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | [CreateObjectFromXmlNode](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a637d7be5588f2ae2af2288ebdafe1ba6) (XmlNode node, string typeName) |
| [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | [CreateObjectWithoutDeserialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a3bbcc96f840c7d0c87d6173b3be4e9ad) (XmlNode node) |
| void | [UnregisterNonReadyObjects](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ad0ceda43dfdfe6fb2faaebd192335c14) () |
|  | Do not call LoadXMLFromFile method after clear operation. |
| void | [ClearAllObjects](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a1bd62b3da67495fa47eb7a0de9e71fe6) () |
| void | [ClearAllObjectsWithType](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#afc2cc02ac73c43684793e9e0294157b2) (Type type) |
| T | [ReadObjectReferenceFromXml< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a37712c6beea82906b75059a3f5a3b350) (string attributeName, XmlNode node) |
| [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | [ReadObjectReferenceFromXml](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a1cabdbb9ba388aa32663b252b2ee51b9) (string attributeName, Type objectType, XmlNode node) |
| T | [CreateObject< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#af4fad197a43ce796f3b16518390004de) (string stringId) |
| T | [CreateObject< T >](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a11e62747a562b1513fe82fadb9ebda2a) () |
| void | [DebugPrint](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#af45027c02a4db4dc5c6fb351e9bba2f0) ([PrintOutputDelegate](namespace_tale_worlds_1_1_object_system.html#ab52963004820afe891925d28be5c3a58) printOutput) |
| void | [AddHandler](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a61b2ea950f492c8a55d32641cf55fc10) ([IObjectManagerHandler](interface_tale_worlds_1_1_object_system_1_1_i_object_manager_handler.html) handler) |
| void | [RemoveHandler](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#aa4ac2f0658f9b74784be9f2250834313) ([IObjectManagerHandler](interface_tale_worlds_1_1_object_system_1_1_i_object_manager_handler.html) handler) |
| string | [DebugDump](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ae45dc3bd3b6a66c2adbeef65ad12737b) () |
|  | Debugs the dump. |
| void | [ReInitialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a529c966e6c8007e7377ad4f0822be8da) () |
| string | [GetObjectTypeIds](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ad20edc33f138354064cb9c4fee5549bc) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static MBObjectManager | [Init](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#af358db5ab093985f18c030b1142b262d) () |
| static bool | [MergeElementAttributes](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a5ecb21a4f0222b025cc8eaed10127509) (XElement element1, XElement element2) |
| static void | [MergeElements](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#aaab51480819787501edfe2f070557c4e) (XElement element1, XElement element2, string xsdPath) |
| static XmlDocument | [GetMergedXmlForManaged](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a1c54763e5913ce2e483726dd49aaa654) (string id, bool skipValidation, bool ignoreGameTypeInclusionCheck=true, string gameType="") |
| static XmlDocument | [GetMergedXmlForNative](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#af10b3a28aad3057c5ca70360c4343ebf) (string id, out List< string > usedPaths) |
| static XmlDocument | [CreateMergedXmlFile](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a7132d5ad0d8bec5cbcaefc27f8947f3a) (List< Tuple< string, string > > toBeMerged, List< string > xsltList, bool skipValidation) |
| static XmlDocument | [ApplyXslt](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a7a84beb130eca63febb6596e80faf604) (string xsltPath, XmlDocument baseDocument) |
| static XmlDocument | [MergeTwoXmls](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a9fef107cab2723b64b0c3afd43991244) (XmlDocument xmlDocument1, XmlDocument xmlDocument2, string xsdPath, bool keepDuplicates) |
| static XDocument | [ToXDocument](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#afce303d4aae1cd875bf9ef03017468ad) (XmlDocument xmlDocument) |
| static XmlDocument | [ToXmlDocument](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a30644e9e4e405f0555f2c3e37f9baf0f) (XDocument xDocument) |

|  |  |
| --- | --- |
| Properties | |
| static MBObjectManager | [Instance](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a722da1e0ed4f1f336337d4bb8f312578) `[get]` |
| int | [NumRegisteredTypes](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ade2d3fd35590b95e405f46c5f433797f) `[get]` |
| int | [MaxRegisteredTypes](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a14ced12d1fbec3a9e7ba280eded386e2) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#af358db5ab093985f18c030b1142b262d)Init()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | MBObjectManager TaleWorlds.ObjectSystem.MBObjectManager.Init | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ab29183dfbfd8f7600e94225f4fa6a45c)Destroy()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.Destroy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a8ae4ef740aa399aec2cfece4371571f1)RegisterType< T >()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.RegisterType< T > | ( | string | *classPrefix*, |
|  |  | string | *classListPrefix*, |
|  |  | uint | *typeId*, |
|  |  | bool | *autoCreateInstance* = true, |
|  |  | bool | *isTemporary* = false ) |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a37f48e4ad37177e2b1ea3a700162750a)HasType< T >()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool [TaleWorlds.ObjectSystem.MBObjectManager.HasType](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a6e1f0a4d4798740a6e590860f159e6b7)< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a6e1f0a4d4798740a6e590860f159e6b7)HasType()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.ObjectSystem.MBObjectManager.HasType | ( | Type | *type* | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a6328b818a509b0f0aa0fd6cfe4c3d734)FindRegisteredClassPrefix()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.ObjectSystem.MBObjectManager.FindRegisteredClassPrefix | ( | Type | *type* | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a302662351001e8e19c719189b26ef35b)FindRegisteredType()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| Type TaleWorlds.ObjectSystem.MBObjectManager.FindRegisteredType | ( | string | *classPrefix* | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a944ef2bc14e1316c1627f4cebc5f42e0)RegisterObject< T >()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.ObjectSystem.MBObjectManager.RegisterObject< T > | ( | T | *obj* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ad60061a66b30cc400a7b34c37eef6e44)RegisterPresumedObject< T >()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.ObjectSystem.MBObjectManager.RegisterPresumedObject< T > | ( | T | *obj* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a3157e661ed3966de8ce2021a2a0d5bcc)UnregisterObject()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.UnregisterObject | ( | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | *obj* | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a5cb4bbfb15282e9d3182b295b19e8886)GetObject< T >() [1/2]
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T [TaleWorlds.ObjectSystem.MBObjectManager.GetObject](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a2645c16e860b17ec84d8be1c7a42a70c)< T > | ( | Func< T, bool > | *predicate* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a2e0c38e0f71776c1140bf119556017ae)GetObjects< T >()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MBReadOnlyList< T > TaleWorlds.ObjectSystem.MBObjectManager.GetObjects< T > | ( | Func< T, bool > | *predicate* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ab236bdfd17632746ce5eba7176201eba)GetObject< T >() [2/2]
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T [TaleWorlds.ObjectSystem.MBObjectManager.GetObject](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a2645c16e860b17ec84d8be1c7a42a70c)< T > | ( | string | *objectName* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a21438dcd2c5844cda8178b0d2f3ad498)GetFirstObject< T >()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.ObjectSystem.MBObjectManager.GetFirstObject< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#aec976730afd1b1bc282138af996f3580)ContainsObject< T >()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.ObjectSystem.MBObjectManager.ContainsObject< T > | ( | string | *objectName* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#aa1bd2c847cb379ca1409fde4b13167b7)RemoveTemporaryTypes()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.RemoveTemporaryTypes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#af60e85a7c37563411c996a188f33fc9d)PreAfterLoad()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.PreAfterLoad | ( |  | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a4b4d1f576287812445545436a15dc224)AfterLoad()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.AfterLoad | ( |  | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a2645c16e860b17ec84d8be1c7a42a70c)GetObject() [1/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) TaleWorlds.ObjectSystem.MBObjectManager.GetObject | ( | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | *objectId* | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a56320c8f1c0eafc7e685ec126555968f)GetObject() [2/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) TaleWorlds.ObjectSystem.MBObjectManager.GetObject | ( | string | *typeName*, |
|  |  | string | *objectName* ) |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a73fc2485d7fbd062e818eb7edb3abe11)GetObjectTypeList< T >()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBReadOnlyList< T > TaleWorlds.ObjectSystem.MBObjectManager.GetObjectTypeList< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#aaaaff4bfa387702f9c3059d29020b01c)CreateObjectTypeList()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IList< [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) > TaleWorlds.ObjectSystem.MBObjectManager.CreateObjectTypeList | ( | Type | *objectClassType* | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a46d5dd5dcabe100976dafeb01150cdac)LoadXML()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.LoadXML | ( | string | *id*, |
|  |  | bool | *isDevelopment*, |
|  |  | string | *gameType*, |
|  |  | bool | *skipXmlFilterForEditor* = false ) |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a5ecb21a4f0222b025cc8eaed10127509)MergeElementAttributes()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.ObjectSystem.MBObjectManager.MergeElementAttributes | ( | XElement | *element1*, | |  |  | XElement | *element2* ) | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#aaab51480819787501edfe2f070557c4e)MergeElements()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.ObjectSystem.MBObjectManager.MergeElements | ( | XElement | *element1*, | |  |  | XElement | *element2*, | |  |  | string | *xsdPath* ) | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a1c54763e5913ce2e483726dd49aaa654)GetMergedXmlForManaged()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | XmlDocument TaleWorlds.ObjectSystem.MBObjectManager.GetMergedXmlForManaged | ( | string | *id*, | |  |  | bool | *skipValidation*, | |  |  | bool | *ignoreGameTypeInclusionCheck* = true, | |  |  | string | *gameType* = "" ) | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#af10b3a28aad3057c5ca70360c4343ebf)GetMergedXmlForNative()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | XmlDocument TaleWorlds.ObjectSystem.MBObjectManager.GetMergedXmlForNative | ( | string | *id*, | |  |  | out List< string > | *usedPaths* ) | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a7132d5ad0d8bec5cbcaefc27f8947f3a)CreateMergedXmlFile()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | XmlDocument TaleWorlds.ObjectSystem.MBObjectManager.CreateMergedXmlFile | ( | List< Tuple< string, string > > | *toBeMerged*, | |  |  | List< string > | *xsltList*, | |  |  | bool | *skipValidation* ) | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a7a84beb130eca63febb6596e80faf604)ApplyXslt()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | XmlDocument TaleWorlds.ObjectSystem.MBObjectManager.ApplyXslt | ( | string | *xsltPath*, | |  |  | XmlDocument | *baseDocument* ) | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a9fef107cab2723b64b0c3afd43991244)MergeTwoXmls()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | XmlDocument TaleWorlds.ObjectSystem.MBObjectManager.MergeTwoXmls | ( | XmlDocument | *xmlDocument1*, | |  |  | XmlDocument | *xmlDocument2*, | |  |  | string | *xsdPath*, | |  |  | bool | *keepDuplicates* ) | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#afce303d4aae1cd875bf9ef03017468ad)ToXDocument()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | XDocument TaleWorlds.ObjectSystem.MBObjectManager.ToXDocument | ( | XmlDocument | *xmlDocument* | ) |  | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a30644e9e4e405f0555f2c3e37f9baf0f)ToXmlDocument()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | XmlDocument TaleWorlds.ObjectSystem.MBObjectManager.ToXmlDocument | ( | XDocument | *xDocument* | ) |  | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a7981c9a51e490eb0183abe2ac8157c2f)LoadOneXmlFromFile()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.LoadOneXmlFromFile | ( | string | *xmlPath*, |
|  |  | string | *xsdPath*, |
|  |  | bool | *skipValidation* = false ) |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ae7515975614224bec44c60503f1fd93d)LoadXMLFromFileSkipValidation()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| XmlDocument TaleWorlds.ObjectSystem.MBObjectManager.LoadXMLFromFileSkipValidation | ( | string | *xmlPath*, |
|  |  | string | *xsdPath* ) |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a0b7c61d2d64d23e23f782f559b7973d8)LoadXml()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.LoadXml | ( | XmlDocument | *doc*, |
|  |  | bool | *isDevelopment* = false ) |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ab260ccacc6f214cc90f03927fbbc4a95)CreateObjectFromXmlNode() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) TaleWorlds.ObjectSystem.MBObjectManager.CreateObjectFromXmlNode | ( | XmlNode | *node* | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a637d7be5588f2ae2af2288ebdafe1ba6)CreateObjectFromXmlNode() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) TaleWorlds.ObjectSystem.MBObjectManager.CreateObjectFromXmlNode | ( | XmlNode | *node*, |
|  |  | string | *typeName* ) |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a3bbcc96f840c7d0c87d6173b3be4e9ad)CreateObjectWithoutDeserialize()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) TaleWorlds.ObjectSystem.MBObjectManager.CreateObjectWithoutDeserialize | ( | XmlNode | *node* | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ad0ceda43dfdfe6fb2faaebd192335c14)UnregisterNonReadyObjects()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.UnregisterNonReadyObjects | ( |  | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a1bd62b3da67495fa47eb7a0de9e71fe6)ClearAllObjects()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.ClearAllObjects | ( |  | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#afc2cc02ac73c43684793e9e0294157b2)ClearAllObjectsWithType()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.ClearAllObjectsWithType | ( | Type | *type* | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a37712c6beea82906b75059a3f5a3b350)ReadObjectReferenceFromXml< T >()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| T [TaleWorlds.ObjectSystem.MBObjectManager.ReadObjectReferenceFromXml](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a1cabdbb9ba388aa32663b252b2ee51b9)< T > | ( | string | *attributeName*, |
|  |  | XmlNode | *node* ) |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a1cabdbb9ba388aa32663b252b2ee51b9)ReadObjectReferenceFromXml()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) TaleWorlds.ObjectSystem.MBObjectManager.ReadObjectReferenceFromXml | ( | string | *attributeName*, |
|  |  | Type | *objectType*, |
|  |  | XmlNode | *node* ) |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#af4fad197a43ce796f3b16518390004de)CreateObject< T >() [1/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.ObjectSystem.MBObjectManager.CreateObject< T > | ( | string | *stringId* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |
    | *T* | : | *new()* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a11e62747a562b1513fe82fadb9ebda2a)CreateObject< T >() [2/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.ObjectSystem.MBObjectManager.CreateObject< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html)* |  |
    | *T* | : | *new()* |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#af45027c02a4db4dc5c6fb351e9bba2f0)DebugPrint()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.DebugPrint | ( | [PrintOutputDelegate](namespace_tale_worlds_1_1_object_system.html#ab52963004820afe891925d28be5c3a58) | *printOutput* | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a61b2ea950f492c8a55d32641cf55fc10)AddHandler()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.AddHandler | ( | [IObjectManagerHandler](interface_tale_worlds_1_1_object_system_1_1_i_object_manager_handler.html) | *handler* | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#aa4ac2f0658f9b74784be9f2250834313)RemoveHandler()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.RemoveHandler | ( | [IObjectManagerHandler](interface_tale_worlds_1_1_object_system_1_1_i_object_manager_handler.html) | *handler* | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ae45dc3bd3b6a66c2adbeef65ad12737b)DebugDump()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.ObjectSystem.MBObjectManager.DebugDump | ( |  | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a529c966e6c8007e7377ad4f0822be8da)ReInitialize()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.ObjectSystem.MBObjectManager.ReInitialize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ad20edc33f138354064cb9c4fee5549bc)GetObjectTypeIds()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.ObjectSystem.MBObjectManager.GetObjectTypeIds | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a722da1e0ed4f1f336337d4bb8f312578)Instance
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBObjectManager TaleWorlds.ObjectSystem.MBObjectManager.Instance | | staticget |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#ade2d3fd35590b95e405f46c5f433797f)NumRegisteredTypes
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.ObjectSystem.MBObjectManager.NumRegisteredTypes | | get |

[◆](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html#a14ced12d1fbec3a9e7ba280eded386e2)MaxRegisteredTypes
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.ObjectSystem.MBObjectManager.MaxRegisteredTypes | | get |


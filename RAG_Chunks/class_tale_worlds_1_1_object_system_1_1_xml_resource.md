--- SOURCE: class_tale_worlds_1_1_object_system_1_1_xml_resource.html ---

TaleWorlds.ObjectSystem.XmlResource Class Reference|  |  |
| --- | --- |
| Classes | |
| struct | [XsdElement](struct_tale_worlds_1_1_object_system_1_1_xml_resource_1_1_xsd_element.html) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [ReadXsdFileAndExtractInformation](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a08739fcc7cbfdb52fa7d5763af2a2fcc) (string xsdFilePath) |
| static string | [GetFullXPathOfElement](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#ab3158195e9015509226d60172357e47d) (XElement element, bool isXsd=true) |
| static void | [InitializeXmlInformationList](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a4e7c17c9ddd792f1608279b95e8f147a) (List< [MbObjectXmlInformation](struct_tale_worlds_1_1_object_system_1_1_mb_object_xml_information.html) > xmlInformation) |
| static string | [GetXmlMergeOutput](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#aec6ab292c538be6887905bc40e8fdd87) (List< String > strings) |
| static void | [GetMbprojxmls](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a4c972aba3758577d0082ce77c7ffd872) (string moduleName) |
| static void | [GetXmlListAndApply](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a2d744ef0abb66de956f8e1e505d2767c) (string moduleName) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static List< [MbObjectXmlInformation](struct_tale_worlds_1_1_object_system_1_1_mb_object_xml_information.html) > | [XmlInformationList](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a942ce2d747e1aef453f2106fca2c2bf4) = new List<[MbObjectXmlInformation](struct_tale_worlds_1_1_object_system_1_1_mb_object_xml_information.html)>() |
| static List< [MbObjectXmlInformation](struct_tale_worlds_1_1_object_system_1_1_mb_object_xml_information.html) > | [MbprojXmls](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#ac6716b820916d083bc49ee9e44e9ec60) = new List<[MbObjectXmlInformation](struct_tale_worlds_1_1_object_system_1_1_mb_object_xml_information.html)>() |
| static Dictionary< string, Dictionary< string, [XsdElement](struct_tale_worlds_1_1_object_system_1_1_xml_resource_1_1_xsd_element.html) > > | [XsdElementDictionary](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a7e57129b98f9fd452998359b01ff81f1) = new Dictionary<string, Dictionary<string, [XsdElement](struct_tale_worlds_1_1_object_system_1_1_xml_resource_1_1_xsd_element.html)>>() |
| static XNamespace | [XsNamespace](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a4249a9844dfbef442a84205fa3db59be) = "http://www.w3.org/2001/XMLSchema" |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a08739fcc7cbfdb52fa7d5763af2a2fcc)ReadXsdFileAndExtractInformation()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.ObjectSystem.XmlResource.ReadXsdFileAndExtractInformation | ( | string | *xsdFilePath* | ) |  | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#ab3158195e9015509226d60172357e47d)GetFullXPathOfElement()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.ObjectSystem.XmlResource.GetFullXPathOfElement | ( | XElement | *element*, | |  |  | bool | *isXsd* = true ) | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a4e7c17c9ddd792f1608279b95e8f147a)InitializeXmlInformationList()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.ObjectSystem.XmlResource.InitializeXmlInformationList | ( | List< [MbObjectXmlInformation](struct_tale_worlds_1_1_object_system_1_1_mb_object_xml_information.html) > | *xmlInformation* | ) |  | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#aec6ab292c538be6887905bc40e8fdd87)GetXmlMergeOutput()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.ObjectSystem.XmlResource.GetXmlMergeOutput | ( | List< String > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a4c972aba3758577d0082ce77c7ffd872)GetMbprojxmls()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.ObjectSystem.XmlResource.GetMbprojxmls | ( | string | *moduleName* | ) |  | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a2d744ef0abb66de956f8e1e505d2767c)GetXmlListAndApply()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.ObjectSystem.XmlResource.GetXmlListAndApply | ( | string | *moduleName* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a942ce2d747e1aef453f2106fca2c2bf4)XmlInformationList
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[MbObjectXmlInformation](struct_tale_worlds_1_1_object_system_1_1_mb_object_xml_information.html)> TaleWorlds.ObjectSystem.XmlResource.XmlInformationList = new List<[MbObjectXmlInformation](struct_tale_worlds_1_1_object_system_1_1_mb_object_xml_information.html)>() | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#ac6716b820916d083bc49ee9e44e9ec60)MbprojXmls
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[MbObjectXmlInformation](struct_tale_worlds_1_1_object_system_1_1_mb_object_xml_information.html)> TaleWorlds.ObjectSystem.XmlResource.MbprojXmls = new List<[MbObjectXmlInformation](struct_tale_worlds_1_1_object_system_1_1_mb_object_xml_information.html)>() | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a7e57129b98f9fd452998359b01ff81f1)XsdElementDictionary
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, Dictionary<string, [XsdElement](struct_tale_worlds_1_1_object_system_1_1_xml_resource_1_1_xsd_element.html)> > TaleWorlds.ObjectSystem.XmlResource.XsdElementDictionary = new Dictionary<string, Dictionary<string, [XsdElement](struct_tale_worlds_1_1_object_system_1_1_xml_resource_1_1_xsd_element.html)>>() | | static |

[◆](class_tale_worlds_1_1_object_system_1_1_xml_resource.html#a4249a9844dfbef442a84205fa3db59be)XsNamespace
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | XNamespace TaleWorlds.ObjectSystem.XmlResource.XsNamespace = "http://www.w3.org/2001/XMLSchema" | | static |


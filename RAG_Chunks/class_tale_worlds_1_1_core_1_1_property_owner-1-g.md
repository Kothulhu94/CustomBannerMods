--- SOURCE: class_tale_worlds_1_1_core_1_1_property_owner-1-g.html ---

TaleWorlds.Core.PropertyOwner< T > Class Template ReferenceInherits [TaleWorlds.Core.IReadOnlyPropertyOwner< T >](interface_tale_worlds_1_1_core_1_1_i_read_only_property_owner-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PropertyOwner](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#a1372d561cd4a1510265bfe5d832cf5b4) () |
|  | [PropertyOwner](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#a592f672346c5ef3701d47383a51d7956) (PropertyOwner< T > propertyOwner) |
| void | [SetPropertyValue](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#a9752d810b012f47f64337665ed083d07) (T attribute, int value) |
| int | [GetPropertyValue](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#aa264937dfc9207de66b1a817ff4d86a3) (T attribute) |
| bool | [HasProperty](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#a5e2df69967a035e672e0e6ae5abde209) (T attribute) |
| void | [ClearAllProperty](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#aed02a3b46b3f7a1ce351fb873ddad4bf) () |
| MBList< T > | [GetProperties](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#a3804108ea208911f8bec7865f0f120b4) () |
| void | [Deserialize](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#abbc3757a3333cb084ce3254f363cc0c5) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly Dictionary< T, int > | [\_attributes](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#ac8b5d426ad25d181f401e6fa391c1c9f) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#a1372d561cd4a1510265bfe5d832cf5b4)PropertyOwner() [1/2]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.PropertyOwner< T >.PropertyOwner | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#a592f672346c5ef3701d47383a51d7956)PropertyOwner() [2/2]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.PropertyOwner< T >.PropertyOwner | ( | PropertyOwner< T > | *propertyOwner* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#a9752d810b012f47f64337665ed083d07)SetPropertyValue()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.PropertyOwner< T >.SetPropertyValue | ( | T | *attribute*, |
|  |  | int | *value* ) |

[◆](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#aa264937dfc9207de66b1a817ff4d86a3)GetPropertyValue()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Core.PropertyOwner< T >.GetPropertyValue | ( | T | *attribute* | ) |  |

Implements [TaleWorlds.Core.IReadOnlyPropertyOwner< T >](interface_tale_worlds_1_1_core_1_1_i_read_only_property_owner-1-g.html#aebc1e2f9bb5a9206172e7d094844e1c7).

[◆](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#a5e2df69967a035e672e0e6ae5abde209)HasProperty()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.PropertyOwner< T >.HasProperty | ( | T | *attribute* | ) |  |

Implements [TaleWorlds.Core.IReadOnlyPropertyOwner< T >](interface_tale_worlds_1_1_core_1_1_i_read_only_property_owner-1-g.html#ab003247914c6dab2aeadcc804b826503).

[◆](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#aed02a3b46b3f7a1ce351fb873ddad4bf)ClearAllProperty()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.PropertyOwner< T >.ClearAllProperty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#a3804108ea208911f8bec7865f0f120b4)GetProperties()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBList< T > TaleWorlds.Core.PropertyOwner< T >.GetProperties | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#abbc3757a3333cb084ce3254f363cc0c5)Deserialize()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.PropertyOwner< T >.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, |
|  |  | XmlNode | *node* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_property_owner-1-g.html#ac8b5d426ad25d181f401e6fa391c1c9f)\_attributes
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly Dictionary<T, int> TaleWorlds.Core.PropertyOwner< T >.\_attributes | | protected |


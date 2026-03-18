--- SOURCE: class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html ---

TaleWorlds.Core.PropertyOwnerF< T > Class Template ReferenceInherits [TaleWorlds.Core.IReadOnlyPropertyOwnerF< T >](interface_tale_worlds_1_1_core_1_1_i_read_only_property_owner_f-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PropertyOwnerF](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#a34f0c8cb9787ff5595fa0d18444e654c) () |
|  | [PropertyOwnerF](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#ac59f8fb97f1ebb6e228c5d00256e970c) (PropertyOwnerF< T > propertyOwner) |
| void | [SetPropertyValue](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#a1e48623516ed68a91396f89827c01ab9) (T attribute, float value) |
| float | [GetPropertyValue](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#a9e96200f97e2132743487394b0735160) (T attribute) |
| bool | [HasProperty](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#a6b4aa93083cd1c8df547adbe3bbf8ab6) (T attribute) |
| void | [ClearAllProperty](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#aa23a85eae7e977eeb2b50154bcb2dfe3) () |
| MBList< T > | [GetProperties](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#a07acd5c53725fa6e03c4b39a231680ce) () |
| void | [Serialize](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#ade3d991e20ca025bd517c4c220dd13f0) (XmlWriter writer) |
| void | [Deserialize](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#a80a9e388ab3391020bc5d26be40f1929) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |

|  |  |
| --- | --- |
| Protected Attributes | |
| Dictionary< T, float > | [\_attributes](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#aa44817b876af2fa5cb14e80de232ad5e) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#a34f0c8cb9787ff5595fa0d18444e654c)PropertyOwnerF() [1/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.PropertyOwnerF< T >.PropertyOwnerF | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#ac59f8fb97f1ebb6e228c5d00256e970c)PropertyOwnerF() [2/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.PropertyOwnerF< T >.PropertyOwnerF | ( | PropertyOwnerF< T > | *propertyOwner* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#a1e48623516ed68a91396f89827c01ab9)SetPropertyValue()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.PropertyOwnerF< T >.SetPropertyValue | ( | T | *attribute*, |
|  |  | float | *value* ) |

[◆](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#a9e96200f97e2132743487394b0735160)GetPropertyValue()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Core.PropertyOwnerF< T >.GetPropertyValue | ( | T | *attribute* | ) |  |

Implements [TaleWorlds.Core.IReadOnlyPropertyOwnerF< T >](interface_tale_worlds_1_1_core_1_1_i_read_only_property_owner_f-1-g.html#a1048240a20fc69ec5eb75f0a398948ff).

[◆](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#a6b4aa93083cd1c8df547adbe3bbf8ab6)HasProperty()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.PropertyOwnerF< T >.HasProperty | ( | T | *attribute* | ) |  |

Implements [TaleWorlds.Core.IReadOnlyPropertyOwnerF< T >](interface_tale_worlds_1_1_core_1_1_i_read_only_property_owner_f-1-g.html#a27bb81da626e432d144171611a2ca624).

[◆](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#aa23a85eae7e977eeb2b50154bcb2dfe3)ClearAllProperty()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.PropertyOwnerF< T >.ClearAllProperty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#a07acd5c53725fa6e03c4b39a231680ce)GetProperties()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MBList< T > TaleWorlds.Core.PropertyOwnerF< T >.GetProperties | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#ade3d991e20ca025bd517c4c220dd13f0)Serialize()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.PropertyOwnerF< T >.Serialize | ( | XmlWriter | *writer* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#a80a9e388ab3391020bc5d26be40f1929)Deserialize()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.PropertyOwnerF< T >.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, |
|  |  | XmlNode | *node* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_property_owner_f-1-g.html#aa44817b876af2fa5cb14e80de232ad5e)\_attributes
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<T, float> TaleWorlds.Core.PropertyOwnerF< T >.\_attributes | | protected |


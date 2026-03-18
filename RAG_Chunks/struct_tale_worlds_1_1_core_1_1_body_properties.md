--- SOURCE: struct_tale_worlds_1_1_core_1_1_body_properties.html ---

TaleWorlds.Core.BodyProperties Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) ([DynamicBodyProperties](struct_tale_worlds_1_1_core_1_1_dynamic_body_properties.html) dynamicBodyProperties, [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html) staticBodyProperties) |
| override string | [ToString](struct_tale_worlds_1_1_core_1_1_body_properties.html#aa0f05680abea0b35a8e565d2ece7894a) () |
| override bool | [Equals](struct_tale_worlds_1_1_core_1_1_body_properties.html#a6ca88e664c08d89041bd45bd2d431875) (object obj) |
| override int | [GetHashCode](struct_tale_worlds_1_1_core_1_1_body_properties.html#afd6fa73c9e415fbd25dc481d996a01a5) () |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) | [ClampForMultiplayer](struct_tale_worlds_1_1_core_1_1_body_properties.html#a1b9bab2cdf9134d213938718f696ca3a) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [FromXmlNode](struct_tale_worlds_1_1_core_1_1_body_properties.html#ad07a19ba8af7c2c5d65bbc2875fb9399) (XmlNode node, out [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) bodyProperties) |
| static bool | [FromString](struct_tale_worlds_1_1_core_1_1_body_properties.html#a64305cb229236b36f41906708327b2de) (string keyValue, out [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) bodyProperties) |
| static [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) | [GetRandomBodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a3b689b502cca6ad27f56885021d48fbe) (int race, bool isFemale, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) bodyPropertiesMin, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) bodyPropertiesMax, int hairCoverType, int seed, string hairTags, string beardTags, string tattooTags, float variationAmount=0f) |
| static bool | [operator==](struct_tale_worlds_1_1_core_1_1_body_properties.html#aa17fc9f65c85934b935bcfa665407381) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) a, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) b) |
| static bool | [operator!=](struct_tale_worlds_1_1_core_1_1_body_properties.html#ab20f850f333f985d6bbe911c3031b536) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) a, [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) b) |

|  |  |
| --- | --- |
| Properties | |
| [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html) | [StaticProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a92fb974a8147e6d3311b43ecbbec2271) `[get]` |
| [DynamicBodyProperties](struct_tale_worlds_1_1_core_1_1_dynamic_body_properties.html) | [DynamicProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#adc0a355143811a1059a9e6f5ccf5462d) `[get]` |
| float | [Age](struct_tale_worlds_1_1_core_1_1_body_properties.html#a58c8974d78bc66f9fe6f594a98589623) `[get]` |
| float | [Weight](struct_tale_worlds_1_1_core_1_1_body_properties.html#a2fa2510f92d3141bd54b9dfa3c45a09a) `[get]` |
| float | [Build](struct_tale_worlds_1_1_core_1_1_body_properties.html#a591b5b3c261685118dcd66b69c6b2fac) `[get]` |
| ulong | [KeyPart1](struct_tale_worlds_1_1_core_1_1_body_properties.html#aef904bd58a85bb75b4dc157dbd5b8f6d) `[get]` |
| ulong | [KeyPart2](struct_tale_worlds_1_1_core_1_1_body_properties.html#af89d6d5f00f7ad1d8390d94d233fccee) `[get]` |
| ulong | [KeyPart3](struct_tale_worlds_1_1_core_1_1_body_properties.html#aa6e2ff5d7667039e1a2c6fd612168428) `[get]` |
| ulong | [KeyPart4](struct_tale_worlds_1_1_core_1_1_body_properties.html#a755e910487073101366ec61b78d53bc9) `[get]` |
| ulong | [KeyPart5](struct_tale_worlds_1_1_core_1_1_body_properties.html#a8f422a191088d970b2a2758a4e5b2643) `[get]` |
| ulong | [KeyPart6](struct_tale_worlds_1_1_core_1_1_body_properties.html#ae7d6031ee1107a15339bc5149aa396bf) `[get]` |
| ulong | [KeyPart7](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7ad0142ecd62046977258ba34196db39) `[get]` |
| ulong | [KeyPart8](struct_tale_worlds_1_1_core_1_1_body_properties.html#a447be07f8e9f58493f919076b9be19b3) `[get]` |
| static [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) | [Default](struct_tale_worlds_1_1_core_1_1_body_properties.html#af0e6e22220de2f6a561c213000acd904) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4)BodyProperties()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.BodyProperties.BodyProperties | ( | [DynamicBodyProperties](struct_tale_worlds_1_1_core_1_1_dynamic_body_properties.html) | *dynamicBodyProperties*, |
|  |  | [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html) | *staticBodyProperties* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#ad07a19ba8af7c2c5d65bbc2875fb9399)FromXmlNode()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Core.BodyProperties.FromXmlNode | ( | XmlNode | *node*, | |  |  | out [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) | *bodyProperties* ) | | static |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a64305cb229236b36f41906708327b2de)FromString()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Core.BodyProperties.FromString | ( | string | *keyValue*, | |  |  | out [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) | *bodyProperties* ) | | static |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a3b689b502cca6ad27f56885021d48fbe)GetRandomBodyProperties()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) TaleWorlds.Core.BodyProperties.GetRandomBodyProperties | ( | int | *race*, | |  |  | bool | *isFemale*, | |  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) | *bodyPropertiesMin*, | |  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) | *bodyPropertiesMax*, | |  |  | int | *hairCoverType*, | |  |  | int | *seed*, | |  |  | string | *hairTags*, | |  |  | string | *beardTags*, | |  |  | string | *tattooTags*, | |  |  | float | *variationAmount* = 0f ) | | static |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#aa17fc9f65c85934b935bcfa665407381)operator==()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Core.BodyProperties.operator== | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) | *a*, | |  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#ab20f850f333f985d6bbe911c3031b536)operator!=()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Core.BodyProperties.operator!= | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) | *a*, | |  |  | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#aa0f05680abea0b35a8e565d2ece7894a)ToString()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Core.BodyProperties.ToString | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a6ca88e664c08d89041bd45bd2d431875)Equals()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Core.BodyProperties.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#afd6fa73c9e415fbd25dc481d996a01a5)GetHashCode()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Core.BodyProperties.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a1b9bab2cdf9134d213938718f696ca3a)ClampForMultiplayer()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) TaleWorlds.Core.BodyProperties.ClampForMultiplayer | ( |  | ) |  |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a92fb974a8147e6d3311b43ecbbec2271)StaticProperties
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html) TaleWorlds.Core.BodyProperties.StaticProperties | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#adc0a355143811a1059a9e6f5ccf5462d)DynamicProperties
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [DynamicBodyProperties](struct_tale_worlds_1_1_core_1_1_dynamic_body_properties.html) TaleWorlds.Core.BodyProperties.DynamicProperties | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a58c8974d78bc66f9fe6f594a98589623)Age
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BodyProperties.Age | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a2fa2510f92d3141bd54b9dfa3c45a09a)Weight
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BodyProperties.Weight | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a591b5b3c261685118dcd66b69c6b2fac)Build
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.BodyProperties.Build | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#aef904bd58a85bb75b4dc157dbd5b8f6d)KeyPart1
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.BodyProperties.KeyPart1 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#af89d6d5f00f7ad1d8390d94d233fccee)KeyPart2
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.BodyProperties.KeyPart2 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#aa6e2ff5d7667039e1a2c6fd612168428)KeyPart3
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.BodyProperties.KeyPart3 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a755e910487073101366ec61b78d53bc9)KeyPart4
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.BodyProperties.KeyPart4 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a8f422a191088d970b2a2758a4e5b2643)KeyPart5
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.BodyProperties.KeyPart5 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#ae7d6031ee1107a15339bc5149aa396bf)KeyPart6
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.BodyProperties.KeyPart6 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7ad0142ecd62046977258ba34196db39)KeyPart7
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.BodyProperties.KeyPart7 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#a447be07f8e9f58493f919076b9be19b3)KeyPart8
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.BodyProperties.KeyPart8 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_body_properties.html#af0e6e22220de2f6a561c213000acd904)Default
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html#a7f41fbae8189e6b485d1bf3412c652d4) TaleWorlds.Core.BodyProperties.Default | | staticget |


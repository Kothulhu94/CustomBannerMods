--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html ---

TaleWorlds.MountAndBlade.MultiplayerOptionsProperty Class ReferenceApplying this attribute to a property in MultiplayerOptions.cs does the following things:
[More...](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#details)

Inherits Attribute.

|  |  |
| --- | --- |
| Public Types | |
| enum | [ReplicationOccurrence](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a8f960639b0ec0acd6a907da280376320) {     [Never](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a8f960639b0ec0acd6a907da280376320a6e7b34fa59e1bd229b207892956dc41c) ,     [AtMapLoad](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a8f960639b0ec0acd6a907da280376320a6ee54be72ed44decba987381c09bf072) ,     [Immediately](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a8f960639b0ec0acd6a907da280376320afd83e0ccb3e6312a62f888dd496dd0a5)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MultiplayerOptionsProperty](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a87397452e6aa0bfb4dd61bd7e5c21096) ([MultiplayerOptions.OptionValueType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a9b4cd111fd32543a1e74b47c17fe1476) optionValueType, [ReplicationOccurrence](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a8f960639b0ec0acd6a907da280376320) replicationOccurrence, string description=null, int boundsMin=0, int boundsMax=0, string[] validGameModes=null, bool hasMultipleSelections=false, Type enumType=null) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [MultiplayerOptions.OptionValueType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a9b4cd111fd32543a1e74b47c17fe1476) | [OptionValueType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#ae96cdb89ea800f4f6a6c6bfb0ca4094b) |
| readonly [ReplicationOccurrence](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a8f960639b0ec0acd6a907da280376320) | [Replication](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a81604c14d7d994809773c4a3d7b3d5bd) |
| readonly string | [Description](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a37b9f8437c715ea4a7a3e42685f50118) |
| readonly int | [BoundsMin](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#afa4568e5eeb1862402e0f3a5dbeee3d7) |
| readonly int | [BoundsMax](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a4340b0278125e41e36e33ae6d0649f16) |
| readonly string[] | [ValidGameModes](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a3c97015d643e7868dd29808ab20a2f78) |
| readonly bool | [HasMultipleSelections](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a186caf24fd92567ac4e512b39eedf47b) |
| readonly Type | [EnumType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a51bc25d2925a2bf42377bf76abf8cb15) |

|  |  |
| --- | --- |
| Properties | |
| bool | [HasBounds](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a94edf7e8a5b9a01054b2801fe8f2aba0) `[get]` |

Detailed Description
--------------------

1. It makes it automatically available as a console command for dedicated server.
2. By applying the proper [ReplicationOccurrence](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a8f960639b0ec0acd6a907da280376320), you get extra checks if you forget to replicate this property to clients.

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a8f960639b0ec0acd6a907da280376320)ReplicationOccurrence
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MultiplayerOptionsProperty.ReplicationOccurrence](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a8f960639b0ec0acd6a907da280376320) |

| Enumerator | |
| --- | --- |
| Never |  |
| AtMapLoad |  |
| Immediately |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a87397452e6aa0bfb4dd61bd7e5c21096)MultiplayerOptionsProperty()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MultiplayerOptionsProperty.MultiplayerOptionsProperty | ( | [MultiplayerOptions.OptionValueType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a9b4cd111fd32543a1e74b47c17fe1476) | *optionValueType*, |
|  |  | [ReplicationOccurrence](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a8f960639b0ec0acd6a907da280376320) | *replicationOccurrence*, |
|  |  | string | *description* = null, |
|  |  | int | *boundsMin* = 0, |
|  |  | int | *boundsMax* = 0, |
|  |  | string[] | *validGameModes* = null, |
|  |  | bool | *hasMultipleSelections* = false, |
|  |  | Type | *enumType* = null ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#ae96cdb89ea800f4f6a6c6bfb0ca4094b)OptionValueType
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [MultiplayerOptions.OptionValueType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options.html#a9b4cd111fd32543a1e74b47c17fe1476) TaleWorlds.MountAndBlade.MultiplayerOptionsProperty.OptionValueType |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a81604c14d7d994809773c4a3d7b3d5bd)Replication
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [ReplicationOccurrence](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a8f960639b0ec0acd6a907da280376320) TaleWorlds.MountAndBlade.MultiplayerOptionsProperty.Replication |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a37b9f8437c715ea4a7a3e42685f50118)Description
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string TaleWorlds.MountAndBlade.MultiplayerOptionsProperty.Description |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#afa4568e5eeb1862402e0f3a5dbeee3d7)BoundsMin
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.MountAndBlade.MultiplayerOptionsProperty.BoundsMin |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a4340b0278125e41e36e33ae6d0649f16)BoundsMax
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.MountAndBlade.MultiplayerOptionsProperty.BoundsMax |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a3c97015d643e7868dd29808ab20a2f78)ValidGameModes
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly string [] TaleWorlds.MountAndBlade.MultiplayerOptionsProperty.ValidGameModes |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a186caf24fd92567ac4e512b39eedf47b)HasMultipleSelections
---------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.MultiplayerOptionsProperty.HasMultipleSelections |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a51bc25d2925a2bf42377bf76abf8cb15)EnumType
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Type TaleWorlds.MountAndBlade.MultiplayerOptionsProperty.EnumType |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_options_property.html#a94edf7e8a5b9a01054b2801fe8f2aba0)HasBounds
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MultiplayerOptionsProperty.HasBounds | | get |


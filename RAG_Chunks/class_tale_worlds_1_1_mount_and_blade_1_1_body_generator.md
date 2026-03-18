--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html ---

TaleWorlds.MountAndBlade.BodyGenerator Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BodyGenerator](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a334538977cc9c01d72e8e8a26cb0cafa) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) troop) |
| [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) | [InitBodyGenerator](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a1372c70498955132ad322168ba889449) (bool isDressed) |
| void | [RefreshFace](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a45ffa68475948fb170339fb054b1c093) ([FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) faceGenerationParams, bool hasEquipment) |
| void | [SaveCurrentCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#af430e584dcc2dec002cbc5588ee8a8c3) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [CurrentBodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a3f204a6b0348ceb6a743915cc2be546c) |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [BodyPropertiesMin](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a4a732a9ef82cb2e4f0a2c58961a1df90) |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [BodyPropertiesMax](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a9c30ed372f1989fd43db8fca08df0143) |
| int | [Race](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a1bac9e386f8a88a84b2900a47a7a2994) |
| bool | [IsFemale](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#ab49ecca904fc7c8baf52610e151df5cd) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [FaceGenTeethAnimationName](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a9f4e75d5aa9b0586da001efb4bd61474) = "facegen\_teeth" |

|  |  |
| --- | --- |
| Properties | |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [Character](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#aded08cb24387f482ac690d1e0b4d9533) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a334538977cc9c01d72e8e8a26cb0cafa)BodyGenerator()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.BodyGenerator.BodyGenerator | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *troop* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a1372c70498955132ad322168ba889449)InitBodyGenerator()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) TaleWorlds.MountAndBlade.BodyGenerator.InitBodyGenerator | ( | bool | *isDressed* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a45ffa68475948fb170339fb054b1c093)RefreshFace()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.BodyGenerator.RefreshFace | ( | [FaceGenerationParams](struct_tale_worlds_1_1_mount_and_blade_1_1_face_generation_params.html) | *faceGenerationParams*, |
|  |  | bool | *hasEquipment* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#af430e584dcc2dec002cbc5588ee8a8c3)SaveCurrentCharacter()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.BodyGenerator.SaveCurrentCharacter | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a9f4e75d5aa9b0586da001efb4bd61474)FaceGenTeethAnimationName
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.BodyGenerator.FaceGenTeethAnimationName = "facegen\_teeth" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a3f204a6b0348ceb6a743915cc2be546c)CurrentBodyProperties
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.BodyGenerator.CurrentBodyProperties |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a4a732a9ef82cb2e4f0a2c58961a1df90)BodyPropertiesMin
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.BodyGenerator.BodyPropertiesMin |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a9c30ed372f1989fd43db8fca08df0143)BodyPropertiesMax
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.BodyGenerator.BodyPropertiesMax |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#a1bac9e386f8a88a84b2900a47a7a2994)Race
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.BodyGenerator.Race |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#ab49ecca904fc7c8baf52610e151df5cd)IsFemale
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.BodyGenerator.IsFemale |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html#aded08cb24387f482ac690d1e0b4d9533)Character
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.BodyGenerator.Character | | get |


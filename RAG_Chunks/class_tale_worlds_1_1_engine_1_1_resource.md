--- SOURCE: class_tale_worlds_1_1_engine_1_1_resource.html ---

TaleWorlds.Engine.Resource Class ReferenceabstractInherits NativeObject.

Inherited by [TaleWorlds.Engine.Material](class_tale_worlds_1_1_engine_1_1_material.html), [TaleWorlds.Engine.Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html), [TaleWorlds.Engine.PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html), [TaleWorlds.Engine.Shader](class_tale_worlds_1_1_engine_1_1_shader.html), and [TaleWorlds.Engine.Texture](class_tale_worlds_1_1_engine_1_1_texture.html).

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) () |
| void | [CheckResourceParameter](class_tale_worlds_1_1_engine_1_1_resource.html#acb4f0c2d802a8a8530c3813f8c7e9c5d) ([Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) param, string paramName="") |
|  | Check if the parameter 'param' is null or invalid and throws an exception containing 'paramName' as further information. |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](class_tale_worlds_1_1_engine_1_1_resource.html#ad0c94ab0bd3bcdd26b02ac6117e7662f) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13)Resource()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.Engine.Resource.Resource | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_resource.html#acb4f0c2d802a8a8530c3813f8c7e9c5d)CheckResourceParameter()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Resource.CheckResourceParameter | ( | [Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) | *param*, | |  |  | string | *paramName* = "" ) | | protected |

Parameters
:   |  |  |
    | --- | --- |
    | param | The parameter to check |
    | paramName | The string to be included in the exception message if check fails |

Exceptions
:   |  |  |
    | --- | --- |
    | MBNullParameterException | If 'param' is null, MBNullParameterException is thrown |
    | MBInvalidParameterException | If 'param' is invalid, MBInvalidParameterException is thrown |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_resource.html#ad0c94ab0bd3bcdd26b02ac6117e7662f)IsValid
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Resource.IsValid | | get |


--- SOURCE: class_tale_worlds_1_1_engine_1_1_shader.html ---

TaleWorlds.Engine.Shader Class ReferencesealedRepresentation of shader resource in Mono domain No means of shader copying is provided in this interface so all the accessor properties are read only.

Inherits [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| UInt64 | [GetMaterialShaderFlagMask](class_tale_worlds_1_1_engine_1_1_shader.html#abaa9f3449612f72a58e3e97e07b477f8) (string flagName, bool showErrors=true) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Shader | [GetFromResource](class_tale_worlds_1_1_engine_1_1_shader.html#a22e52a456617c846656ffd92599c7052) (string shaderName) |
|  | Returns the Mono representation of the the shader whose name is 'shaderName'. |

|  |  |
| --- | --- |
| Properties | |
| string | [Name](class_tale_worlds_1_1_engine_1_1_shader.html#af97dd8de958cfd9d830578b450ce4246) `[get]` |
|  | Gets the name of the shader. |
| Properties inherited from [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html) | |
| bool | [IsValid](class_tale_worlds_1_1_engine_1_1_resource.html#ad0c94ab0bd3bcdd26b02ac6117e7662f) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html) | |
|  | [Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) () |
| void | [CheckResourceParameter](class_tale_worlds_1_1_engine_1_1_resource.html#acb4f0c2d802a8a8530c3813f8c7e9c5d) ([Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) param, string paramName="") |
|  | Check if the parameter 'param' is null or invalid and throws an exception containing 'paramName' as further information. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_shader.html#a22e52a456617c846656ffd92599c7052)GetFromResource()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Shader TaleWorlds.Engine.Shader.GetFromResource | ( | string | *shaderName* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | shaderName | The name of the shader to be retrieved |

Returns
:   Returns the Mono representation of the shader whose name is 'shaderName' Returns the previously retrieved instance. A new instance is created if there is none previously or its has been GCed.

    If there is a shader named 'shaderName' then returns a valid MBShader object. Otherwise returns null.

[◆](class_tale_worlds_1_1_engine_1_1_shader.html#abaa9f3449612f72a58e3e97e07b477f8)GetMaterialShaderFlagMask()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| UInt64 TaleWorlds.Engine.Shader.GetMaterialShaderFlagMask | ( | string | *flagName*, |
|  |  | bool | *showErrors* = true ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_shader.html#af97dd8de958cfd9d830578b450ce4246)Name
---------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Engine.Shader.Name | | get |


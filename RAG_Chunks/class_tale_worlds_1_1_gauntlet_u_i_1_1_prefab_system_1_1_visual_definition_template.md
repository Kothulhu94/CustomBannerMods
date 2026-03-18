--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html ---

TaleWorlds.GauntletUI.PrefabSystem.VisualDefinitionTemplate Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [VisualDefinitionTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#aa44043c6a4fcff092df6b76ae0bed5ca) () |
| void | [AddVisualState](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#af118b75a7e45bb356a8e0ed09d4def10) ([VisualStateTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_state_template.html) visualState) |
| [VisualDefinition](class_tale_worlds_1_1_gauntlet_u_i_1_1_visual_definition.html) | [CreateVisualDefinition](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#a1dd05f7f506c73713071422ced22f5b5) ([BrushFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_factory.html) brushFactory, [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) spriteData, Dictionary< string, [VisualDefinitionTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#aa44043c6a4fcff092df6b76ae0bed5ca) > visualDefinitionTemplates, Dictionary< string, [ConstantDefinition](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_constant_definition.html) > constants, Dictionary< string, [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > parameters, Dictionary< string, string > defaultParameters) |

|  |  |
| --- | --- |
| Properties | |
| string | [Name](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#a869b123ebeb10eec4d9bc287df29ba2c) `[get, set]` |
| float | [TransitionDuration](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#a507ea7d07199304fc52717ced05f1423) `[get, set]` |
| float | [DelayOnBegin](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#ad97c7cf9b4df340225124c2199a30c4c) `[get, set]` |
| [AnimationInterpolation.Type](class_tale_worlds_1_1_gauntlet_u_i_1_1_animation_interpolation.html#ac95cef3eee2feb67941a067fc03d270d) | [EaseType](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#ac33dfb338a3e82dc21f4bd77bdc160a1) `[get, set]` |
| [AnimationInterpolation.Function](class_tale_worlds_1_1_gauntlet_u_i_1_1_animation_interpolation.html#a1d686c35f821b320e5cb4104d4eabc4d) | [EaseFunction](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#a17894683d87131dc21df9979ddcbbc80) `[get, set]` |
| Dictionary< string, [VisualStateTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_state_template.html) > | [VisualStates](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#abca50806cf084cdd7663deb340e6611d) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#aa44043c6a4fcff092df6b76ae0bed5ca)VisualDefinitionTemplate()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.GauntletUI.PrefabSystem.VisualDefinitionTemplate.VisualDefinitionTemplate | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#af118b75a7e45bb356a8e0ed09d4def10)AddVisualState()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.PrefabSystem.VisualDefinitionTemplate.AddVisualState | ( | [VisualStateTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_state_template.html) | *visualState* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#a1dd05f7f506c73713071422ced22f5b5)CreateVisualDefinition()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [VisualDefinition](class_tale_worlds_1_1_gauntlet_u_i_1_1_visual_definition.html) TaleWorlds.GauntletUI.PrefabSystem.VisualDefinitionTemplate.CreateVisualDefinition | ( | [BrushFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_factory.html) | *brushFactory*, |
|  |  | [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) | *spriteData*, |
|  |  | Dictionary< string, [VisualDefinitionTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#aa44043c6a4fcff092df6b76ae0bed5ca) > | *visualDefinitionTemplates*, |
|  |  | Dictionary< string, [ConstantDefinition](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_constant_definition.html) > | *constants*, |
|  |  | Dictionary< string, [WidgetAttributeTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_widget_attribute_template.html) > | *parameters*, |
|  |  | Dictionary< string, string > | *defaultParameters* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#a869b123ebeb10eec4d9bc287df29ba2c)Name
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.PrefabSystem.VisualDefinitionTemplate.Name | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#a507ea7d07199304fc52717ced05f1423)TransitionDuration
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.PrefabSystem.VisualDefinitionTemplate.TransitionDuration | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#ad97c7cf9b4df340225124c2199a30c4c)DelayOnBegin
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.PrefabSystem.VisualDefinitionTemplate.DelayOnBegin | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#ac33dfb338a3e82dc21f4bd77bdc160a1)EaseType
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AnimationInterpolation.Type](class_tale_worlds_1_1_gauntlet_u_i_1_1_animation_interpolation.html#ac95cef3eee2feb67941a067fc03d270d) TaleWorlds.GauntletUI.PrefabSystem.VisualDefinitionTemplate.EaseType | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#a17894683d87131dc21df9979ddcbbc80)EaseFunction
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AnimationInterpolation.Function](class_tale_worlds_1_1_gauntlet_u_i_1_1_animation_interpolation.html#a1d686c35f821b320e5cb4104d4eabc4d) TaleWorlds.GauntletUI.PrefabSystem.VisualDefinitionTemplate.EaseFunction | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_definition_template.html#abca50806cf084cdd7663deb340e6611d)VisualStates
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<string, [VisualStateTemplate](class_tale_worlds_1_1_gauntlet_u_i_1_1_prefab_system_1_1_visual_state_template.html)> TaleWorlds.GauntletUI.PrefabSystem.VisualDefinitionTemplate.VisualStates | | get |


--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html ---

TaleWorlds.MountAndBlade.GauntletUI.Widgets.Tutorial.TutorialObjectiveStickParentWidget.StickAnimStage Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [AnimTypes](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#ab2c72e23250ce5003d52d01e0cdb6d96) {     [Movement](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#ab2c72e23250ce5003d52d01e0cdb6d96a4642e767f9251fa40afadbc963f80b7a) ,     [FadeInLocal](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#ab2c72e23250ce5003d52d01e0cdb6d96afbf516bcb4202c6321e7f79b740f36f4) ,     [FadeOutLocal](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#ab2c72e23250ce5003d52d01e0cdb6d96ad04e14d362fb7b38ad60531dd59004a9) ,     [FadeInGlobal](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#ab2c72e23250ce5003d52d01e0cdb6d96a4d43072ffb0219a8c071b1592df4d13d) ,     [FadeOutGlobal](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#ab2c72e23250ce5003d52d01e0cdb6d96a337bf88774aada2e317d25f9c965f6d5) ,     [Stay](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#ab2c72e23250ce5003d52d01e0cdb6d96a89302eb620f755ea605acbdcd41d2547)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#abd521fc932ea81cd198bb283cf8c86eb) (float dt) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#a2091a76c18818ef66814944411942195) `[get]` |
| float | [AnimTime](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#a6fc6000be30c8308c283a395649c6092) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Direction](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#a705e99a9daa4321451f6164ccdea6bb3) `[get]` |
| [AnimTypes](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#ab2c72e23250ce5003d52d01e0cdb6d96) | [AnimType](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#a4e608a2f512c31404c61858eeb7a690f) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html#a7374fc0a06aef251d32d4fa21beeb014) | [WidgetToManipulate](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#aab167580e346b9f327ce5ea91bbc5d42) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#ab2c72e23250ce5003d52d01e0cdb6d96)AnimTypes
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum TaleWorlds.MountAndBlade.GauntletUI.Widgets.Tutorial.TutorialObjectiveStickParentWidget.StickAnimStage.AnimTypes |

| Enumerator | |
| --- | --- |
| Movement |  |
| FadeInLocal |  |
| FadeOutLocal |  |
| FadeInGlobal |  |
| FadeOutGlobal |  |
| Stay |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#abd521fc932ea81cd198bb283cf8c86eb)Tick()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GauntletUI.Widgets.Tutorial.TutorialObjectiveStickParentWidget.StickAnimStage.Tick | ( | float | *dt* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#a2091a76c18818ef66814944411942195)IsCompleted
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GauntletUI.Widgets.Tutorial.TutorialObjectiveStickParentWidget.StickAnimStage.IsCompleted | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#a6fc6000be30c8308c283a395649c6092)AnimTime
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.GauntletUI.Widgets.Tutorial.TutorialObjectiveStickParentWidget.StickAnimStage.AnimTime | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#a705e99a9daa4321451f6164ccdea6bb3)Direction
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.GauntletUI.Widgets.Tutorial.TutorialObjectiveStickParentWidget.StickAnimStage.Direction | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#a4e608a2f512c31404c61858eeb7a690f)AnimType
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AnimTypes](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#ab2c72e23250ce5003d52d01e0cdb6d96) TaleWorlds.MountAndBlade.GauntletUI.Widgets.Tutorial.TutorialObjectiveStickParentWidget.StickAnimStage.AnimType | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_widgets_1_1_tutorial_1_1_tutorial_obj77571958c273991490aa05d06d9e6690.html#aab167580e346b9f327ce5ea91bbc5d42)WidgetToManipulate
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html#a7374fc0a06aef251d32d4fa21beeb014) TaleWorlds.MountAndBlade.GauntletUI.Widgets.Tutorial.TutorialObjectiveStickParentWidget.StickAnimStage.WidgetToManipulate | | get |


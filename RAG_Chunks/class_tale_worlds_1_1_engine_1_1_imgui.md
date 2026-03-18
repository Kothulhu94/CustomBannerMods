--- SOURCE: class_tale_worlds_1_1_engine_1_1_imgui.html ---

TaleWorlds.Engine.Imgui Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [ColorStyle](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281a) : int {     [Text](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa9dffbf69ffba8bc38bc4e01abf4b1675) = 0 ,     [TextDisabled](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aae3a96937ea651675ce06873eb8398ac0) ,     [WindowBg](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa9a130f0dedb9dab2a95ab7b8c84d6915) ,     [ChildWindowBg](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa3ae7af782f5587b937e1d9f487fe4bd5) ,     [PopupBg](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa80b624eb25ab4a6cb3cd72ca8abefa72) ,     [Border](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa070554647306343cbea29ebfdd278ba8) ,     [BorderShadow](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aac98640138c5db927879595c579827650) ,     [FrameBg](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa52a19efb5e13370bbb23d7141879a41e) ,     [FrameBgHovered](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa3a66de4ba1eae5bd156867012cad8151) ,     [FrameBgActive](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa9cd6752f26c18737b93fb2b285bd5ea1) ,     [TitleBg](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa7d954eb6eadad6c18756f1dfc986cabf) ,     [TitleBgCollapsed](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa63097b78ea20819dfadd4ac8dd9f7a49) ,     [TitleBgActive](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa3f1e19c18334ace0f8d8a7dc9e3f5369) ,     [MenuBarBg](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa70043c8dd7aaf784915e05b349572c8a) ,     [ScrollbarBg](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aae937059d8159d1ad93858c0652f0523c) ,     [ScrollbarGrab](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa52d78c10786a02c9f94c5d0c5e1fc29e) ,     [ScrollbarGrabHovered](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aab86c6c7c2228839f8ada2f9ba40e1a86) ,     [ScrollbarGrabActive](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa53cb3270f6c059663d971e69421f9f44) ,     [ComboBg](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa5808524d0533b578429983f81ba80f8e) ,     [CheckMark](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa18452b5fedc3e73b764b566a33702d74) ,     [SliderGrab](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa2bbcbbc9c5ca2fa8f2c9b33dd86e6ffb) ,     [SliderGrabActive](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa3aaf6a2a0014b76ba69fbae30fc38c19) ,     [Button](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa87b7760f14fbff78d8819291f36ab9a0) ,     [ButtonHovered](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aafaea675ba618620c5af718f4ecebaaea) ,     [ButtonActive](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa9ef9a76f89d3d4a4a9a02a5b8fddbfb3) ,     [Header](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aabf50d5e661106d0abe925af3c2e6f7e7) ,     [HeaderHovered](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aafd7c0545d58588831d35f038ed5cb436) ,     [HeaderActive](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa27dae5d051fb110ea67a24ef49532494) ,     [Column](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa1976d7f704de389d9fe064e08ea35b2d) ,     [ColumnHovered](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aaa5d8ac3928b1215de08ff6702dd6486f) ,     [ColumnActive](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aaba79a48be2ffec5e4b12957a6271bca7) ,     [ResizeGrip](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa1447f7b7daafa03abbb016ab9d73288c) ,     [ResizeGripHovered](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa751ba8b6356c127cf5bb153d949a27cb) ,     [ResizeGripActive](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa5cd79d9b57ebcb6be935d87f8821a8a8) ,     [CloseButton](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa2db4324cf4a475bc104457a2e1323bf6) ,     [CloseButtonHovered](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa1f066d9184ed97e81a27f492056fd32b) ,     [CloseButtonActive](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa4a77f22149dc286a2dd502d213b6c4fa) ,     [PlotLines](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa69ede88f69312a2fc67f25f7519e575e) ,     [PlotLinesHovered](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa91c10115eabba12d1147a62e00a4d97d) ,     [PlotHistogram](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa1f7fc1b381e6fb533bceba6bc375f5c7) ,     [PlotHistogramHovered](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa00fb0f29e709c23cd979d859451c49fd) ,     [TextSelectedBg](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aae4d6eaf3ac4a68236347d40d63b8a2b4) ,     [ModalWindowDarkening](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281aa5bca5d9f7a796cfcaf1224562dbf9130)   } |
|  | call [BeginMainThreadScope()](class_tale_worlds_1_1_engine_1_1_imgui.html#ab2db8a7a716269e5322bdf7619a4a686) after [NewFrame()](class_tale_worlds_1_1_engine_1_1_imgui.html#aff73427a04c5119595f0c20b91fcf5c1) but before [Begin(string)](class_tale_worlds_1_1_engine_1_1_imgui.html#a260f245c8042a14e1ee3786f1d8ca854) [More...](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281a) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [BeginMainThreadScope](class_tale_worlds_1_1_engine_1_1_imgui.html#ab2db8a7a716269e5322bdf7619a4a686) () |
| static void | [EndMainThreadScope](class_tale_worlds_1_1_engine_1_1_imgui.html#adf8d77e833573f9565be2a98015d1858) () |
| static void | [PushStyleColor](class_tale_worlds_1_1_engine_1_1_imgui.html#aa42673458ce93fcab6cbcf853b8b0be0) ([ColorStyle](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281a) style, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color) |
| static void | [PopStyleColor](class_tale_worlds_1_1_engine_1_1_imgui.html#a413541539c99148e7331cda623e99e6a) () |
| static void | [NewFrame](class_tale_worlds_1_1_engine_1_1_imgui.html#aff73427a04c5119595f0c20b91fcf5c1) () |
| static void | [Render](class_tale_worlds_1_1_engine_1_1_imgui.html#a06f9e6195ad9bc844a2b485c3d425e61) () |
| static void | [Begin](class_tale_worlds_1_1_engine_1_1_imgui.html#a260f245c8042a14e1ee3786f1d8ca854) (string text) |
| static void | [Begin](class_tale_worlds_1_1_engine_1_1_imgui.html#ad02900996a19df9ee64f61585d2b84e7) (string text, ref bool is\_open) |
| static void | [End](class_tale_worlds_1_1_engine_1_1_imgui.html#add7555bcdab7ecd8453cdba6733bf106) () |
| static void | [Text](class_tale_worlds_1_1_engine_1_1_imgui.html#a3ed5f421f8e5fe7e1ff0f9045e8645b2) (string text) |
| static bool | [Checkbox](class_tale_worlds_1_1_engine_1_1_imgui.html#a95e4d6bfc22990d25a99a639fd158784) (string text, ref bool is\_checked) |
| static bool | [TreeNode](class_tale_worlds_1_1_engine_1_1_imgui.html#a02318e23ea7629b8c0b624ae5b82136c) (string name) |
| static void | [TreePop](class_tale_worlds_1_1_engine_1_1_imgui.html#af98f55e30acad8327bd4a01dde3b2da0) () |
| static void | [Separator](class_tale_worlds_1_1_engine_1_1_imgui.html#a1ae169062bb04b17122b25f714f919b5) () |
| static bool | [Button](class_tale_worlds_1_1_engine_1_1_imgui.html#aca48707ec87f5ab1ba7a229b15c0926a) (string text) |
| static void | [PlotLines](class_tale_worlds_1_1_engine_1_1_imgui.html#acc02015e7e382552c605734a45a529c4) (string name, float[] values, int valuesCount, int valuesOffset, string overlayText, float minScale, float maxScale, float graphWidth, float graphHeight, int stride) |
| static void | [ProgressBar](class_tale_worlds_1_1_engine_1_1_imgui.html#a4166ea3be7651c0b9ffa782b1b4d929d) (float progress) |
| static void | [NewLine](class_tale_worlds_1_1_engine_1_1_imgui.html#a3cf8afb0fdc968ea9c7e5fe96493adad) () |
| static void | [SameLine](class_tale_worlds_1_1_engine_1_1_imgui.html#a88b1fea02af31b4ea581d89f25ba724e) (float posX=0.0f, float spacingWidth=0.0f) |
| static bool | [Combo](class_tale_worlds_1_1_engine_1_1_imgui.html#abe34f9195fd666a77986d78409a6f03a) (string label, ref int selectedIndex, string items) |
| static bool | [ComboCustomSeperator](class_tale_worlds_1_1_engine_1_1_imgui.html#a103869faa63228176a5ab20d5263db18) (string label, ref int selectedIndex, string items, char seperator) |
| static bool | [InputInt](class_tale_worlds_1_1_engine_1_1_imgui.html#a790bf18ec9ae129350115b424dcdfb48) (string label, ref int value) |
| static bool | [SliderFloat](class_tale_worlds_1_1_engine_1_1_imgui.html#af3102061cdec6ad49aff7127a926b9dc) (string label, ref float value, float min, float max) |
| static void | [Columns](class_tale_worlds_1_1_engine_1_1_imgui.html#af7168530a479c2e626b07c482f441dfa) (int count=1, string id="", bool border=true) |
| static void | [NextColumn](class_tale_worlds_1_1_engine_1_1_imgui.html#ae24623c6e87c5ecaa06cf75fd7c8b28a) () |
| static bool | [RadioButton](class_tale_worlds_1_1_engine_1_1_imgui.html#a1a580c0080084206f918692984ee2397) (string label, bool active) |
| static bool | [CollapsingHeader](class_tale_worlds_1_1_engine_1_1_imgui.html#ac310b350695869da5b166e8d650bae07) (string label) |
| static bool | [IsItemHovered](class_tale_worlds_1_1_engine_1_1_imgui.html#a07df778fead05d59f46eb0d59d08bbbb) () |
| static void | [SetTooltip](class_tale_worlds_1_1_engine_1_1_imgui.html#ac0d242afa0f5990e2b0eecd9e484232b) (string label) |
| static bool | [SmallButton](class_tale_worlds_1_1_engine_1_1_imgui.html#a70c25cae93f01fc6bb5f6d50aa722bc4) (string label) |
| static bool | [InputFloat](class_tale_worlds_1_1_engine_1_1_imgui.html#a720b3b8dbcabca87f38a7142372851e4) (string label, ref float val, float step, float stepFast, int decimalPrecision=-1) |
| static bool | [InputText](class_tale_worlds_1_1_engine_1_1_imgui.html#a6e39f01c4b3e63d812753bbd3091b672) (string label, ref string text) |
| static bool | [InputTextMultilineCopyPaste](class_tale_worlds_1_1_engine_1_1_imgui.html#ae9a3c6b91ef8f2e5002c8a1e1e4b5a13) (string label, int textBoxHeight, ref string text) |
| static bool | [InputFloat2](class_tale_worlds_1_1_engine_1_1_imgui.html#a58f9d66c09a961f1a6ca90c8a6ac86b2) (string label, ref float val0, ref float val1, int decimalPrecision=-1) |
| static bool | [InputFloat3](class_tale_worlds_1_1_engine_1_1_imgui.html#a087a5fb5df57f6284d03bdf02a857de2) (string label, ref float val0, ref float val1, ref float val2, int decimalPrecision=-1) |
| static bool | [InputFloat4](class_tale_worlds_1_1_engine_1_1_imgui.html#a33adec003804ee641c4cbdc58628ec67) (string label, ref float val0, ref float val1, ref float val2, ref float val3, int decimalPrecision=-1) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281a)ColorStyle
--------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Engine.Imgui.ColorStyle](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281a) : int |

| Enumerator | |
| --- | --- |
| Text |  |
| TextDisabled |  |
| WindowBg |  |
| ChildWindowBg |  |
| PopupBg |  |
| Border |  |
| BorderShadow |  |
| FrameBg |  |
| FrameBgHovered |  |
| FrameBgActive |  |
| TitleBg |  |
| TitleBgCollapsed |  |
| TitleBgActive |  |
| MenuBarBg |  |
| ScrollbarBg |  |
| ScrollbarGrab |  |
| ScrollbarGrabHovered |  |
| ScrollbarGrabActive |  |
| ComboBg |  |
| CheckMark |  |
| SliderGrab |  |
| SliderGrabActive |  |
| Button |  |
| ButtonHovered |  |
| ButtonActive |  |
| Header |  |
| HeaderHovered |  |
| HeaderActive |  |
| Column |  |
| ColumnHovered |  |
| ColumnActive |  |
| ResizeGrip |  |
| ResizeGripHovered |  |
| ResizeGripActive |  |
| CloseButton |  |
| CloseButtonHovered |  |
| CloseButtonActive |  |
| PlotLines |  |
| PlotLinesHovered |  |
| PlotHistogram |  |
| PlotHistogramHovered |  |
| TextSelectedBg |  |
| ModalWindowDarkening |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#ab2db8a7a716269e5322bdf7619a4a686)BeginMainThreadScope()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.BeginMainThreadScope | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#adf8d77e833573f9565be2a98015d1858)EndMainThreadScope()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.EndMainThreadScope | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#aa42673458ce93fcab6cbcf853b8b0be0)PushStyleColor()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.PushStyleColor | ( | [ColorStyle](class_tale_worlds_1_1_engine_1_1_imgui.html#af83f0d83996a95dbf70f61671d6b281a) | *style*, | |  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a413541539c99148e7331cda623e99e6a)PopStyleColor()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.PopStyleColor | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#aff73427a04c5119595f0c20b91fcf5c1)NewFrame()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.NewFrame | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a06f9e6195ad9bc844a2b485c3d425e61)Render()
------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.Render | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a260f245c8042a14e1ee3786f1d8ca854)Begin() [1/2]
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.Begin | ( | string | *text* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#ad02900996a19df9ee64f61585d2b84e7)Begin() [2/2]
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.Begin | ( | string | *text*, | |  |  | ref bool | *is\_open* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#add7555bcdab7ecd8453cdba6733bf106)End()
---------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.End | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a3ed5f421f8e5fe7e1ff0f9045e8645b2)Text()
----------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.Text | ( | string | *text* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a95e4d6bfc22990d25a99a639fd158784)Checkbox()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.Checkbox | ( | string | *text*, | |  |  | ref bool | *is\_checked* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a02318e23ea7629b8c0b624ae5b82136c)TreeNode()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.TreeNode | ( | string | *name* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#af98f55e30acad8327bd4a01dde3b2da0)TreePop()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.TreePop | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a1ae169062bb04b17122b25f714f919b5)Separator()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.Separator | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#aca48707ec87f5ab1ba7a229b15c0926a)Button()
------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.Button | ( | string | *text* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#acc02015e7e382552c605734a45a529c4)PlotLines()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.PlotLines | ( | string | *name*, | |  |  | float[] | *values*, | |  |  | int | *valuesCount*, | |  |  | int | *valuesOffset*, | |  |  | string | *overlayText*, | |  |  | float | *minScale*, | |  |  | float | *maxScale*, | |  |  | float | *graphWidth*, | |  |  | float | *graphHeight*, | |  |  | int | *stride* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a4166ea3be7651c0b9ffa782b1b4d929d)ProgressBar()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.ProgressBar | ( | float | *progress* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a3cf8afb0fdc968ea9c7e5fe96493adad)NewLine()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.NewLine | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a88b1fea02af31b4ea581d89f25ba724e)SameLine()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.SameLine | ( | float | *posX* = 0::0f, | |  |  | float | *spacingWidth* = 0::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#abe34f9195fd666a77986d78409a6f03a)Combo()
-----------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.Combo | ( | string | *label*, | |  |  | ref int | *selectedIndex*, | |  |  | string | *items* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a103869faa63228176a5ab20d5263db18)ComboCustomSeperator()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.ComboCustomSeperator | ( | string | *label*, | |  |  | ref int | *selectedIndex*, | |  |  | string | *items*, | |  |  | char | *seperator* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a790bf18ec9ae129350115b424dcdfb48)InputInt()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.InputInt | ( | string | *label*, | |  |  | ref int | *value* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#af3102061cdec6ad49aff7127a926b9dc)SliderFloat()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.SliderFloat | ( | string | *label*, | |  |  | ref float | *value*, | |  |  | float | *min*, | |  |  | float | *max* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#af7168530a479c2e626b07c482f441dfa)Columns()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.Columns | ( | int | *count* = 1, | |  |  | string | *id* = "", | |  |  | bool | *border* = true ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#ae24623c6e87c5ecaa06cf75fd7c8b28a)NextColumn()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.NextColumn | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a1a580c0080084206f918692984ee2397)RadioButton()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.RadioButton | ( | string | *label*, | |  |  | bool | *active* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#ac310b350695869da5b166e8d650bae07)CollapsingHeader()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.CollapsingHeader | ( | string | *label* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a07df778fead05d59f46eb0d59d08bbbb)IsItemHovered()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.IsItemHovered | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#ac0d242afa0f5990e2b0eecd9e484232b)SetTooltip()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Imgui.SetTooltip | ( | string | *label* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a70c25cae93f01fc6bb5f6d50aa722bc4)SmallButton()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.SmallButton | ( | string | *label* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a720b3b8dbcabca87f38a7142372851e4)InputFloat()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.InputFloat | ( | string | *label*, | |  |  | ref float | *val*, | |  |  | float | *step*, | |  |  | float | *stepFast*, | |  |  | int | *decimalPrecision* = -1 ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a6e39f01c4b3e63d812753bbd3091b672)InputText()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.InputText | ( | string | *label*, | |  |  | ref string | *text* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#ae9a3c6b91ef8f2e5002c8a1e1e4b5a13)InputTextMultilineCopyPaste()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.InputTextMultilineCopyPaste | ( | string | *label*, | |  |  | int | *textBoxHeight*, | |  |  | ref string | *text* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a58f9d66c09a961f1a6ca90c8a6ac86b2)InputFloat2()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.InputFloat2 | ( | string | *label*, | |  |  | ref float | *val0*, | |  |  | ref float | *val1*, | |  |  | int | *decimalPrecision* = -1 ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a087a5fb5df57f6284d03bdf02a857de2)InputFloat3()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.InputFloat3 | ( | string | *label*, | |  |  | ref float | *val0*, | |  |  | ref float | *val1*, | |  |  | ref float | *val2*, | |  |  | int | *decimalPrecision* = -1 ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_imgui.html#a33adec003804ee641c4cbdc58628ec67)InputFloat4()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Imgui.InputFloat4 | ( | string | *label*, | |  |  | ref float | *val0*, | |  |  | ref float | *val1*, | |  |  | ref float | *val2*, | |  |  | ref float | *val3*, | |  |  | int | *decimalPrecision* = -1 ) | | static |


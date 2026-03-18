--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html ---

SandBox.GauntletUI.MapConversationTextureProvider Class ReferenceInherits [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapConversationTextureProvider](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#a681c82e22db2c7fb1d16004ad3a53558) () |
| override void | [Clear](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#add1254314d3d4c4c658639b6b0c974b3) (bool clearNextFrame) |
| override void | [SetTargetSize](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#a897f9ae178729fd5419c268236664d15) (int width, int height) |
| override void | [Tick](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#af0c115fe3bd27da0dbc04efd80a99aad) (float dt) |
| Public Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [GetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ade86cbe04ebe31e95f7022ddbcf9a4e7) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) context, string name=null) |
| void | [SetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa1070ade9147c6089986a2a874d9a465) (string name, object value) |
| object | [GetProperty](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a18435ef5f4aa4f0693498278fb76c6a2) (string name) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#a2bb8ac706d739b703299e06ebb67fb66) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |
| Protected Member Functions inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [OnGetTextureForRender](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ac65b91fd4b9ccfb73220121fa7396844) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext, string name) |

|  |  |
| --- | --- |
| Properties | |
| object | [Data](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#a7c25348bac188c4162562dd586cddbd1) `[set]` |
| bool | [IsEnabled](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#a3f87c23ae9601d73ac08d7ec5b1d12f5) `[set]` |
| Properties inherited from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html) | |
| string | [SourceInfo](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a3189b71ef4da6dfc199adddb1584191f) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#a681c82e22db2c7fb1d16004ad3a53558)MapConversationTextureProvider()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.GauntletUI.MapConversationTextureProvider.MapConversationTextureProvider | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#add1254314d3d4c4c658639b6b0c974b3)Clear()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.MapConversationTextureProvider.Clear | ( | bool | *clearNextFrame* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#ad55ae18c49d5b0fd17fd72aa11cfff11).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#a2bb8ac706d739b703299e06ebb67fb66)OnGetTextureForRender()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) SandBox.GauntletUI.MapConversationTextureProvider.OnGetTextureForRender | ( | [TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) | *twoDimensionContext*, | |  |  | string | *name* ) | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#a897f9ae178729fd5419c268236664d15)SetTargetSize()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.GauntletUI.MapConversationTextureProvider.SetTargetSize | ( | int | *width*, | |  |  | int | *height* ) | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#a1d840a6eb2069b6d62e59a37a7374393).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#af0c115fe3bd27da0dbc04efd80a99aad)Tick()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.MapConversationTextureProvider.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.GauntletUI.TextureProvider](class_tale_worlds_1_1_gauntlet_u_i_1_1_texture_provider.html#aa8e76bc61347b14690b39ec4897978ba).

Property Documentation
----------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#a7c25348bac188c4162562dd586cddbd1)Data
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object SandBox.GauntletUI.MapConversationTextureProvider.Data | | set |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_conversation_texture_provider.html#a3f87c23ae9601d73ac08d7ec5b1d12f5)IsEnabled
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.GauntletUI.MapConversationTextureProvider.IsEnabled | | set |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DefaultMapWeatherModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#acd85d1ea9f318bdb213a4bf8c04fb47e) () |
| override [AtmosphereState](class_tale_worlds_1_1_core_1_1_atmosphere_state.html) | [GetInterpolatedAtmosphereState](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#a0e5914bc4b9b17762cf7ca4e99f476e4) ([CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) timeOfYear, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) pos) |
| override [AtmosphereInfo](struct_tale_worlds_1_1_library_1_1_atmosphere_info.html) | [GetAtmosphereModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#adf7bbd7aa50ca215342cad25be71ea1f) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| override void | [InitializeCaches](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#a706cde7d5ab46932615357ec4645fc31) () |
| override [WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) | [UpdateWeatherForPosition](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#a4e030b0fa9850904327cc89be6faadac) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) ct) |
| override void | [GetSnowAndRainDataForPosition](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#abe5d7731be7c9b8e1dc52ef8f538aae9) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) ct, out float snowValue, out float rainValue) |
| override [WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) | [GetWeatherEventInPosition](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#ab8ae9b62762455d368f2e75e684ca8cd) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) pos) |
| override [WeatherEventEffectOnTerrain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ac979d67f7281a1ca9f6ddd4f7fe7f914) | [GetWeatherEffectOnTerrainForPosition](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#af1e085a85bd47bde0027ee620ba988b6) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) pos) |
| override void | [GetSeasonTimeFactorOfCampaignTime](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#ab1b013ace87be6e3c069304c8403663c) ([CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) ct, out float timeFactorForSnow, out float timeFactorForRain, bool snapCampaignTimeToWeatherPeriod=true) |
| override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetWindForPosition](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#aca389d39fc377298b7653a07c0590790) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html) | |
| [AtmosphereState](class_tale_worlds_1_1_core_1_1_atmosphere_state.html) | [GetInterpolatedAtmosphereState](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ab8a4134cd47559eb30262a656de46c83) ([CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) timeOfYear, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) pos) |
| [AtmosphereInfo](struct_tale_worlds_1_1_library_1_1_atmosphere_info.html) | [GetAtmosphereModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a39670b0fe912be871c2a598d3fb39a6e) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| void | [GetSeasonTimeFactorOfCampaignTime](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#aff22002f6a4fb1efd14ead5da5f5766c) ([CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) ct, out float timeFactorForSnow, out float timeFactorForRain, bool snapCampaignTimeToWeatherPeriod=true) |
| [WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) | [UpdateWeatherForPosition](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ae70900686417990ca4f6972639670eaa) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) ct) |
| void | [InitializeCaches](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a94e6cc015e22b9c2ed33219a1a418147) () |
| [WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) | [GetWeatherEventInPosition](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a935d3a8735d2dd5e4664f9eb79e3e271) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) pos) |
| void | [GetSnowAndRainDataForPosition](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a0ed21f5a6aa4c2405179b2dca8ea0685) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) ct, out float snowValue, out float rainValue) |
| [WeatherEventEffectOnTerrain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ac979d67f7281a1ca9f6ddd4f7fe7f914) | [GetWeatherEffectOnTerrainForPosition](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a2ff63d9fc83573da1edb53e5a964db24) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) pos) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetWindForPosition](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a45636664df2f5b05f2bc59fda9fa265a) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static bool | [ShouldOverrideWeather](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#a0787677c0faa0cedc1589a340fffc206) |
| static [WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) | [OverriddenWeather](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#a2dd0f24a43e3461b778dac6ff8ff7474) |

|  |  |
| --- | --- |
| Properties | |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [WeatherUpdatePeriod](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#af9dc258b43906ab866c29fb96450d7bf) `[get]` |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [WeatherUpdateFrequency](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#ad0d4851d82026a071bef0c8db63cf678) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html) | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [WeatherUpdateFrequency](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a7aae62c32b1b363542ebdc4bc316f175) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [WeatherUpdatePeriod](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ada2c9f94647ebbc9267900a18c9a12fb) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html) | |
| enum | [WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) {     [Clear](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18adc30bc0c7914db5918da4263fce93ad2) = 0 ,     [LightRain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18a51dd3867fb2c6a5eb7f2560d85497eb3) = 1 ,     [HeavyRain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18ab9df9cc7b4628a898283529c994aef4a) = 2 ,     [Snowy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18adb3e8d805f8bb9056efb093a595cd4ea) = 3 ,     [Blizzard](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18accf3819e0ec3939cb23aa5988bf033b2) = 4 ,     [Storm](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18afdcf3cdc04f367257c92382e032b6293) = 5   } |
| enum | [WeatherEventEffectOnTerrain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ac979d67f7281a1ca9f6ddd4f7fe7f914) {     [Default](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ac979d67f7281a1ca9f6ddd4f7fe7f914a7a1920d61156abc05a60135aefe8bc67) ,     [Wet](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ac979d67f7281a1ca9f6ddd4f7fe7f914aae789b866db2fac36cf644f4cdba1267)   } |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#acd85d1ea9f318bdb213a4bf8c04fb47e)DefaultMapWeatherModel()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.DefaultMapWeatherModel | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#a0e5914bc4b9b17762cf7ca4e99f476e4)GetInterpolatedAtmosphereState()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [AtmosphereState](class_tale_worlds_1_1_core_1_1_atmosphere_state.html) TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.GetInterpolatedAtmosphereState | ( | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *timeOfYear*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *pos* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#adf7bbd7aa50ca215342cad25be71ea1f)GetAtmosphereModel()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [AtmosphereInfo](struct_tale_worlds_1_1_library_1_1_atmosphere_info.html) TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.GetAtmosphereModel | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#a706cde7d5ab46932615357ec4645fc31)InitializeCaches()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.InitializeCaches | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#a4e030b0fa9850904327cc89be6faadac)UpdateWeatherForPosition()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.UpdateWeatherForPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *ct* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#abe5d7731be7c9b8e1dc52ef8f538aae9)GetSnowAndRainDataForPosition()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.GetSnowAndRainDataForPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *ct*, |
|  |  | out float | *snowValue*, |
|  |  | out float | *rainValue* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#ab8ae9b62762455d368f2e75e684ca8cd)GetWeatherEventInPosition()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.GetWeatherEventInPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *pos* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#af1e085a85bd47bde0027ee620ba988b6)GetWeatherEffectOnTerrainForPosition()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [WeatherEventEffectOnTerrain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ac979d67f7281a1ca9f6ddd4f7fe7f914) TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.GetWeatherEffectOnTerrainForPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *pos* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#ab1b013ace87be6e3c069304c8403663c)GetSeasonTimeFactorOfCampaignTime()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.GetSeasonTimeFactorOfCampaignTime | ( | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *ct*, |
|  |  | out float | *timeFactorForSnow*, |
|  |  | out float | *timeFactorForRain*, |
|  |  | bool | *snapCampaignTimeToWeatherPeriod* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#aca389d39fc377298b7653a07c0590790)GetWindForPosition()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.GetWindForPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#a0787677c0faa0cedc1589a340fffc206)ShouldOverrideWeather
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.ShouldOverrideWeather | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#a2dd0f24a43e3461b778dac6ff8ff7474)OverriddenWeather
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.OverriddenWeather | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#af9dc258b43906ab866c29fb96450d7bf)WeatherUpdatePeriod
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.WeatherUpdatePeriod | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html#ad0d4851d82026a071bef0c8db63cf678)WeatherUpdateFrequency
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel.WeatherUpdateFrequency | | get |


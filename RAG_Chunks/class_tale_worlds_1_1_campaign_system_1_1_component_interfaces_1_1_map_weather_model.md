--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultMapWeatherModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_weather_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) {     [Clear](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18adc30bc0c7914db5918da4263fce93ad2) = 0 ,     [LightRain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18a51dd3867fb2c6a5eb7f2560d85497eb3) = 1 ,     [HeavyRain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18ab9df9cc7b4628a898283529c994aef4a) = 2 ,     [Snowy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18adb3e8d805f8bb9056efb093a595cd4ea) = 3 ,     [Blizzard](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18accf3819e0ec3939cb23aa5988bf033b2) = 4 ,     [Storm](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18afdcf3cdc04f367257c92382e032b6293) = 5   } |
| enum | [WeatherEventEffectOnTerrain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ac979d67f7281a1ca9f6ddd4f7fe7f914) {     [Default](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ac979d67f7281a1ca9f6ddd4f7fe7f914a7a1920d61156abc05a60135aefe8bc67) ,     [Wet](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ac979d67f7281a1ca9f6ddd4f7fe7f914aae789b866db2fac36cf644f4cdba1267)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
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
| Properties | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [WeatherUpdateFrequency](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a7aae62c32b1b363542ebdc4bc316f175) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [WeatherUpdatePeriod](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ada2c9f94647ebbc9267900a18c9a12fb) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18)WeatherEvent
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) |

| Enumerator | |
| --- | --- |
| Clear |  |
| LightRain |  |
| HeavyRain |  |
| Snowy |  |
| Blizzard |  |
| Storm |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ac979d67f7281a1ca9f6ddd4f7fe7f914)WeatherEventEffectOnTerrain
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.WeatherEventEffectOnTerrain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ac979d67f7281a1ca9f6ddd4f7fe7f914) |

| Enumerator | |
| --- | --- |
| Default |  |
| Wet |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ab8a4134cd47559eb30262a656de46c83)GetInterpolatedAtmosphereState()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [AtmosphereState](class_tale_worlds_1_1_core_1_1_atmosphere_state.html) TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.GetInterpolatedAtmosphereState | ( | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *timeOfYear*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *pos* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a39670b0fe912be871c2a598d3fb39a6e)GetAtmosphereModel()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [AtmosphereInfo](struct_tale_worlds_1_1_library_1_1_atmosphere_info.html) TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.GetAtmosphereModel | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#aff22002f6a4fb1efd14ead5da5f5766c)GetSeasonTimeFactorOfCampaignTime()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.GetSeasonTimeFactorOfCampaignTime | ( | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *ct*, | |  |  | out float | *timeFactorForSnow*, | |  |  | out float | *timeFactorForRain*, | |  |  | bool | *snapCampaignTimeToWeatherPeriod* = true ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ae70900686417990ca4f6972639670eaa)UpdateWeatherForPosition()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.UpdateWeatherForPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, | |  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *ct* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a94e6cc015e22b9c2ed33219a1a418147)InitializeCaches()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.InitializeCaches | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a935d3a8735d2dd5e4664f9eb79e3e271)GetWeatherEventInPosition()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [WeatherEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a871e2e93ab8ec5556dd11b44c0c57b18) TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.GetWeatherEventInPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *pos* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a0ed21f5a6aa4c2405179b2dca8ea0685)GetSnowAndRainDataForPosition()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.GetSnowAndRainDataForPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, | |  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *ct*, | |  |  | out float | *snowValue*, | |  |  | out float | *rainValue* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a2ff63d9fc83573da1edb53e5a964db24)GetWeatherEffectOnTerrainForPosition()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [WeatherEventEffectOnTerrain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ac979d67f7281a1ca9f6ddd4f7fe7f914) TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.GetWeatherEffectOnTerrainForPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *pos* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a45636664df2f5b05f2bc59fda9fa265a)GetWindForPosition()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.GetWindForPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#a7aae62c32b1b363542ebdc4bc316f175)WeatherUpdateFrequency
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.WeatherUpdateFrequency | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_weather_model.html#ada2c9f94647ebbc9267900a18c9a12fb)WeatherUpdatePeriod
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.MapWeatherModel.WeatherUpdatePeriod | | getabstract |


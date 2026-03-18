--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html ---

TaleWorlds.MountAndBlade.Options.OptionsProvider Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) | [GetVideoOptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a61c7361e7aa32c92c7b5a489be988beb) (bool isMainMenu, Action onBrightnessClick, Action onExposureClick, Action onBenchmarkClick) |
| static [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) | [GetPerformanceOptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#aef18b10d9da821af9bd1b1dc9a76699d) (bool isMultiplayer) |
| static IEnumerable< [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) > | [GetPerformanceGraphicsOptions](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#ad2c3c6760ad4728d18b72d54ee97724c) (bool isMultiplayer) |
| static IEnumerable< [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) > | [GetPerformanceResolutionScalingOptions](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a4c2e3b279c45bf909679e488d4a4cdc3) (bool isMultiplayer) |
| static IEnumerable< [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) > | [GetPerformanceGameplayOptions](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a468738966d02bc021d7ab1f19c2f31b1) (bool isMultiplayer) |
| static IEnumerable< [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) > | [GetPerformanceAudioOptions](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#ae0744d41765fde5c67a16c4b87b9b7b7) () |
| static [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) | [GetAudioOptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#ae940e566c907164e8bfc8dec2bf8a4e4) (bool isMultiplayer) |
| static [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) | [GetGameplayOptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#accdfd34621a3cb354c61dd4efe66bdd1) (bool isMainMenu, bool isMultiplayer) |
| static IEnumerable< string > | [GetGameKeyCategoriesList](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a8b357609d419b49ee62482738406987a) (bool isMultiplayer) |
| static IEnumerable< int > | [GetHiddenGameKeys](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a10b8e2670bfb0717f1d3ed956984e4a9) (bool isNavalModuleActive) |
| static [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) | [GetControllerOptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a08696fcac1a46e7705178f106d566ea6) () |
| static Dictionary< NativeOptions.NativeOptionsType, float[]> | [GetDefaultNativeOptions](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#aa1767f6c38b44a647a608e793dc2b9d7) () |
| static Dictionary< ManagedOptionsType, float[]> | [GetDefaultManagedOptions](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a4ce74db5cc102a9ee17821b33591f448) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a61c7361e7aa32c92c7b5a489be988beb)GetVideoOptionCategory()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) TaleWorlds.MountAndBlade.Options.OptionsProvider.GetVideoOptionCategory | ( | bool | *isMainMenu*, | |  |  | Action | *onBrightnessClick*, | |  |  | Action | *onExposureClick*, | |  |  | Action | *onBenchmarkClick* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#aef18b10d9da821af9bd1b1dc9a76699d)GetPerformanceOptionCategory()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) TaleWorlds.MountAndBlade.Options.OptionsProvider.GetPerformanceOptionCategory | ( | bool | *isMultiplayer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#ad2c3c6760ad4728d18b72d54ee97724c)GetPerformanceGraphicsOptions()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) > TaleWorlds.MountAndBlade.Options.OptionsProvider.GetPerformanceGraphicsOptions | ( | bool | *isMultiplayer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a4c2e3b279c45bf909679e488d4a4cdc3)GetPerformanceResolutionScalingOptions()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) > TaleWorlds.MountAndBlade.Options.OptionsProvider.GetPerformanceResolutionScalingOptions | ( | bool | *isMultiplayer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a468738966d02bc021d7ab1f19c2f31b1)GetPerformanceGameplayOptions()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) > TaleWorlds.MountAndBlade.Options.OptionsProvider.GetPerformanceGameplayOptions | ( | bool | *isMultiplayer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#ae0744d41765fde5c67a16c4b87b9b7b7)GetPerformanceAudioOptions()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | IEnumerable< [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) > TaleWorlds.MountAndBlade.Options.OptionsProvider.GetPerformanceAudioOptions | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#ae940e566c907164e8bfc8dec2bf8a4e4)GetAudioOptionCategory()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) TaleWorlds.MountAndBlade.Options.OptionsProvider.GetAudioOptionCategory | ( | bool | *isMultiplayer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#accdfd34621a3cb354c61dd4efe66bdd1)GetGameplayOptionCategory()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) TaleWorlds.MountAndBlade.Options.OptionsProvider.GetGameplayOptionCategory | ( | bool | *isMainMenu*, | |  |  | bool | *isMultiplayer* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a8b357609d419b49ee62482738406987a)GetGameKeyCategoriesList()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< string > TaleWorlds.MountAndBlade.Options.OptionsProvider.GetGameKeyCategoriesList | ( | bool | *isMultiplayer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a10b8e2670bfb0717f1d3ed956984e4a9)GetHiddenGameKeys()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< int > TaleWorlds.MountAndBlade.Options.OptionsProvider.GetHiddenGameKeys | ( | bool | *isNavalModuleActive* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a08696fcac1a46e7705178f106d566ea6)GetControllerOptionCategory()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) TaleWorlds.MountAndBlade.Options.OptionsProvider.GetControllerOptionCategory | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#aa1767f6c38b44a647a608e793dc2b9d7)GetDefaultNativeOptions()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | Dictionary< NativeOptions.NativeOptionsType, float[]> TaleWorlds.MountAndBlade.Options.OptionsProvider.GetDefaultNativeOptions | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_options_provider.html#a4ce74db5cc102a9ee17821b33591f448)GetDefaultManagedOptions()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | Dictionary< ManagedOptionsType, float[]> TaleWorlds.MountAndBlade.Options.OptionsProvider.GetDefaultManagedOptions | ( |  | ) |  | | static |


--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_selection_option_data.html ---

TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedSelectionOptionData Class ReferenceInherits [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html), and [TaleWorlds.Engine.Options.ISelectionOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_selection_option_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ManagedSelectionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_selection_option_data.html#a9269340debcd2a35bef6dfe4ae7ddb2e) ([MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) type) |
| int | [GetSelectableOptionsLimit](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_selection_option_data.html#af82892a822b8d8972c11688b589e2196) () |
| IEnumerable< [SelectionData](struct_tale_worlds_1_1_engine_1_1_options_1_1_selection_data.html) > | [GetSelectableOptionNames](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_selection_option_data.html#afd867e7ed0980f81c68409cf43d54aa5) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html) | |
| virtual float | [GetDefaultValue](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ae0edadfe9156d1e2c16ea5fd8c1c5022) () |
| void | [Commit](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#a08f5e5a2ba16df62ed84ff746e33b32a) () |
| float | [GetValue](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#a146781fb465ba0d2dd58029f4abaa763) (bool forceRefresh) |
| void | [SetValue](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ad90620731bf0f7780c141958c5d46615) (float value) |
| object | [GetOptionType](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ad75216122e5b9b8ec3f29bd16d58f889) () |
| bool | [IsNative](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ab7c48209126ae5b44930e1e983322600) () |
| bool | [IsAction](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#aed7c4e6abd07dc7a4789db21ce4daae2) () |
|  | Not everything we show in [Options](namespace_tale_worlds_1_1_mount_and_blade_1_1_options.html) has to be Managed or Native option. We might need to show Actions like "Open Benchmark". IsAction represents if this Option is an Action and does NOT represent an option value. |
| bool | [GetIsDisabledAndReasonID](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#af955edc5ee809bf6b8cdedcd6016941b) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GetOptionsLimit](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_selection_option_data.html#a9d188ae24bae7ae4bdc6ca959c6c524d) ([MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) optionType) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html) | |
| readonly [MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) | [Type](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#aaf4843df823d285716fb1e3571b1c16a) |
|  | [string](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#aebffb7b04729b445990a200ce9115320) |
| Public Attributes inherited from [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | |
|  | [string](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#adf2e41998906519c9ab40a682eac8082) |
|  | Returns if the option is disabled or not. If the option is disabled an explanation text id is expected. This is not a localized text but it's the text id for a localized text. |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html) | |
|  | [ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#abb63aa51300399a8c030a5b255aafb71) ([MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) type) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_selection_option_data.html#a9269340debcd2a35bef6dfe4ae7ddb2e)ManagedSelectionOptionData()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedSelectionOptionData.ManagedSelectionOptionData | ( | [MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) | *type* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_selection_option_data.html#af82892a822b8d8972c11688b589e2196)GetSelectableOptionsLimit()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedSelectionOptionData.GetSelectableOptionsLimit | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.ISelectionOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_selection_option_data.html#acc3af1136c431e8fe0a236113bf83c93).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_selection_option_data.html#afd867e7ed0980f81c68409cf43d54aa5)GetSelectableOptionNames()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [SelectionData](struct_tale_worlds_1_1_engine_1_1_options_1_1_selection_data.html) > TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedSelectionOptionData.GetSelectableOptionNames | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.ISelectionOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_selection_option_data.html#a7aff06aa5001f57a770c410faaddd60e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_selection_option_data.html#a9d188ae24bae7ae4bdc6ca959c6c524d)GetOptionsLimit()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedSelectionOptionData.GetOptionsLimit | ( | [MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) | *optionType* | ) |  | | static |


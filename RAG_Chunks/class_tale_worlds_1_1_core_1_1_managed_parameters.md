--- SOURCE: class_tale_worlds_1_1_core_1_1_managed_parameters.html ---

TaleWorlds.Core.ManagedParameters Class ReferencesealedInherits [TaleWorlds.Core.IManagedParametersInitializer](interface_tale_worlds_1_1_core_1_1_i_managed_parameters_initializer.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_managed_parameters.html#ad7bb8f160a2ddf78b63df1215c944cfd) (string relativeXmlPath) |
| float | [GetManagedParameter](class_tale_worlds_1_1_core_1_1_managed_parameters.html#aa63bbab7e1fc751ea79cccab5e8ad5f4) ([ManagedParametersEnum](namespace_tale_worlds_1_1_core.html#a29b429f38e3465b595e671ba318831fe) managedParameterEnum) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static float | [GetParameter](class_tale_worlds_1_1_core_1_1_managed_parameters.html#a8bffac18fda496bb0d035df587082ce6) ([ManagedParametersEnum](namespace_tale_worlds_1_1_core.html#a29b429f38e3465b595e671ba318831fe) managedParameterType) |
| static void | [SetParameter](class_tale_worlds_1_1_core_1_1_managed_parameters.html#a38e3910ba847a0d7b1f863e491eb0bf8) ([ManagedParametersEnum](namespace_tale_worlds_1_1_core.html#a29b429f38e3465b595e671ba318831fe) managedParameterType, float newValue) |

|  |  |
| --- | --- |
| Properties | |
| static ManagedParameters | [Instance](class_tale_worlds_1_1_core_1_1_managed_parameters.html#a769691c33a34d0ce16fdd64b05286583) = new ManagedParameters() `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_managed_parameters.html#a8bffac18fda496bb0d035df587082ce6)GetParameter()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Core.ManagedParameters.GetParameter | ( | [ManagedParametersEnum](namespace_tale_worlds_1_1_core.html#a29b429f38e3465b595e671ba318831fe) | *managedParameterType* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_managed_parameters.html#a38e3910ba847a0d7b1f863e491eb0bf8)SetParameter()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.ManagedParameters.SetParameter | ( | [ManagedParametersEnum](namespace_tale_worlds_1_1_core.html#a29b429f38e3465b595e671ba318831fe) | *managedParameterType*, | |  |  | float | *newValue* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_managed_parameters.html#ad7bb8f160a2ddf78b63df1215c944cfd)Initialize()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ManagedParameters.Initialize | ( | string | *relativeXmlPath* | ) |  |

Implements [TaleWorlds.Core.IManagedParametersInitializer](interface_tale_worlds_1_1_core_1_1_i_managed_parameters_initializer.html#ab5370e45b1a922389834a52ef2e8d059).

[◆](class_tale_worlds_1_1_core_1_1_managed_parameters.html#aa63bbab7e1fc751ea79cccab5e8ad5f4)GetManagedParameter()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Core.ManagedParameters.GetManagedParameter | ( | [ManagedParametersEnum](namespace_tale_worlds_1_1_core.html#a29b429f38e3465b595e671ba318831fe) | *managedParameterEnum* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_managed_parameters.html#a769691c33a34d0ce16fdd64b05286583)Instance
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ManagedParameters TaleWorlds.Core.ManagedParameters.Instance = new ManagedParameters() | | staticget |


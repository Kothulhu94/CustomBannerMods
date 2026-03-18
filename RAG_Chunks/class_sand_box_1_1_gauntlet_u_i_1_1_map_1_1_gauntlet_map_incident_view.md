--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html ---

SandBox.GauntletUI.Map.GauntletMapIncidentView Class ReferenceInherits [SandBox.View.Map.MapIncidentView](class_sand_box_1_1_view_1_1_map_1_1_map_incident_view.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletMapIncidentView](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#ac01fdd7ecaa856821203cf29ad72fd42) ([Incident](class_sand_box_1_1_view_1_1_map_1_1_map_incident_view.html#afe5aedcb162a094deb6d1b168bdaeae4) incident) |
| Public Member Functions inherited from [SandBox.View.Map.MapIncidentView](class_sand_box_1_1_view_1_1_map_1_1_map_incident_view.html) | |
|  | [MapIncidentView](class_sand_box_1_1_view_1_1_map_1_1_map_incident_view.html#a75e2d881223b1b63086f762e8917062b) () |
|  | [MapIncidentView](class_sand_box_1_1_view_1_1_map_1_1_map_incident_view.html#a03814feb2f228e601afea695f0cbca3e) ([Incident](class_sand_box_1_1_view_1_1_map_1_1_map_incident_view.html#afe5aedcb162a094deb6d1b168bdaeae4) incident) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnMapConversationStart](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#a79c85daa055b666bc0d15fc6a288b994) () |
| override void | [OnMapConversationOver](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#a5cda93ebde5c6a5998c2460c5ec7e753) () |
| override void | [CreateLayout](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#aa26d097491d9e345f22d2e9c354ab4e1) () |
| override void | [OnFrameTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#a8d23bb194c35ffc40e8c88bebe3fb2a6) (float dt) |
| override void | [OnIdleTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#aad73e430f59ccc6dba2ec485c8670fc4) (float dt) |
| override void | [OnMenuModeTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#a4328f8a6f6df3f90d9276a255ede820c) (float dt) |
| override bool | [IsOpeningEscapeMenuOnFocusChangeAllowed](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#a1709c0942524d6705bdb3db1a25bcbbb) () |
| override void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#ad06f6849d24b726b94ed8ba2233645c8) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [SandBox.View.Map.MapIncidentView](class_sand_box_1_1_view_1_1_map_1_1_map_incident_view.html) | |
| readonly Incident | [Incident](class_sand_box_1_1_view_1_1_map_1_1_map_incident_view.html#afe5aedcb162a094deb6d1b168bdaeae4) |
| Static Protected Attributes inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| const float | [ContextAlphaModifier](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#a9efbb55b721c1331986ba14d416c84f6) = 8.5f |
| Properties inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| MapScreen | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#af4f77c9eec549e6d57cb4667f09ea0b4) `[get]` |
| MapState | [MapState](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#abf6624dfb0331164523cae87d042e691) `[get]` |
| Properties inherited from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html) | |
| bool | [IsFinalized](class_sand_box_1_1_view_1_1_sandbox_view.html#a5807fb2c109c6715d7fae1a6cf2f4693) `[get, protected set]` |
| ScreenLayer | [Layer](class_sand_box_1_1_view_1_1_sandbox_view.html#a070dec1267ecf8ff4afadffc12374024) `[get, protected set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#ac01fdd7ecaa856821203cf29ad72fd42)GauntletMapIncidentView()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.GauntletUI.Map.GauntletMapIncidentView.GauntletMapIncidentView | ( | [Incident](class_sand_box_1_1_view_1_1_map_1_1_map_incident_view.html#afe5aedcb162a094deb6d1b168bdaeae4) | *incident* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#a79c85daa055b666bc0d15fc6a288b994)OnMapConversationStart()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapIncidentView.OnMapConversationStart | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#a5cda93ebde5c6a5998c2460c5ec7e753)OnMapConversationOver()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapIncidentView.OnMapConversationOver | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#aa26d097491d9e345f22d2e9c354ab4e1)CreateLayout()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapIncidentView.CreateLayout | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#a8d23bb194c35ffc40e8c88bebe3fb2a6)OnFrameTick()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapIncidentView.OnFrameTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#aad73e430f59ccc6dba2ec485c8670fc4)OnIdleTick()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapIncidentView.OnIdleTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#a4328f8a6f6df3f90d9276a255ede820c)OnMenuModeTick()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapIncidentView.OnMenuModeTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#a1709c0942524d6705bdb3db1a25bcbbb)IsOpeningEscapeMenuOnFocusChangeAllowed()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool SandBox.GauntletUI.Map.GauntletMapIncidentView.IsOpeningEscapeMenuOnFocusChangeAllowed | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_incident_view.html#ad06f6849d24b726b94ed8ba2233645c8)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapIncidentView.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).


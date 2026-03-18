--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html ---

SandBox.View.Map.MapCameraView Class ReferenceInherits [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [InputInformation](struct_sand_box_1_1_view_1_1_map_1_1_map_camera_view_1_1_input_information.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [CameraFollowMode](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aa00899d5a537783e6af667f202ad691d) {     [Free](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aa00899d5a537783e6af667f202ad691dab24ce0cd392a5b0b8dedc66c25213594) ,     [FollowParty](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aa00899d5a537783e6af667f202ad691da3ee3536e655d3e885059581b03fe8533) ,     [MoveToPosition](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aa00899d5a537783e6af667f202ad691dad0b8917cb9f9e33a4ced929fe90a20f3)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapCameraView](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a64f71570ed236611a3172341363869b0) () |
| virtual void | [OnActivate](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ad1f38e8ba941a2ca0a8e7040fabb3759) (bool leftButtonDraggingMode, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) clickedPosition) |
| virtual void | [Initialize](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a6b72eb8edf40b4e973f2ee9f2e2e2382) () |
| virtual void | [SetCameraMode](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ae4267f6ea90511eb4ea242849d6b6774) ([CameraFollowMode](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aa00899d5a537783e6af667f202ad691d) cameraMode) |
| virtual void | [ResetCamera](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a5472ab542141c3445748634304ab7c89) (bool resetDistance, bool teleportToMainParty) |
| virtual void | [TeleportCameraToMainParty](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aa9bd94867bcbc2dd7e63b61c5ee23369) () |
| virtual void | [FastMoveCameraToMainParty](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a6ad84b0794439317c3501bca2fbc6228) () |
| virtual void | [FastMoveCameraToPosition](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a3ae9f745b0a47f700b77f4f1ae50f61d) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) target, bool isInMenu) |
| void | [OnFastMoveCameraMovementStart](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a837326437697742d7a149f030520ae16) () |
| void | [StopCameraMovementSoundEvents](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a9be5e721f3586ff524a68720be4c2da9) () |
| virtual bool | [IsCameraLockedToPlayerParty](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a87cb06d1089a7324ac0d1e86d474b62f) () |
| virtual void | [StartCameraAnimation](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ad8280c9399ee36db851d7391d999b548) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) targetPosition, float animationStopDuration) |
| virtual void | [SiegeEngineClick](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a6832702f56c8baeaf4d89af9d908f6c3) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) siegeEngineFrame) |
| virtual void | [OnExit](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a11703d88709a1c0e0fd2061d27e46d24) () |
| virtual void | [OnEscapeMenuToggled](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aeb64f13cbd4e8f229e561efb39be33a4) (bool isOpened) |
| virtual void | [HandleMouse](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a3b7a35690476c4e17698ff96ed84cada) (bool rightMouseButtonPressed, float verticalCameraInput, float mouseMoveY, float dt) |
| virtual void | [HandleLeftMouseButtonClick](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a4b8e6b7e534b09ec861b798c615c134c) (bool isMouseActive) |
| virtual void | [OnSetMapSiegeOverlayState](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a99dd0df0aee74661e1acaadf138c570f) (bool isActive, bool isMapSiegeOverlayViewNull) |
| virtual void | [OnRefreshMapSiegeOverlayRequired](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a4c7df64c9cb4f21f69bfa94d45f40cd2) (bool isMapSiegeOverlayViewNull) |
| virtual void | [OnBeforeTick](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a5e549622939ae555dc9657dc2203b409) (in [InputInformation](struct_sand_box_1_1_view_1_1_map_1_1_map_camera_view_1_1_input_information.html) inputInformation) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual void | [UpdateMapCamera](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a0c87dae60316a964616e5661da2e5c2e) (bool \_leftButtonDraggingMode, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) \_clickedPosition) |
| virtual [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetCameraTargetForPosition](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ae029480988f7118e97d2f87ba45a9f76) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) targetPosition) |
| virtual [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetCameraTargetForParty](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ac1f6c96a6df776c48bb4eba741713c31) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| virtual bool | [GetMapCameraInput](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a8e7e37dffe7f7e60695a58fcdf3241eb) ([InputInformation](struct_sand_box_1_1_view_1_1_map_1_1_map_camera_view_1_1_input_information.html) inputInformation) |
| virtual [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ComputeMapCamera](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a1e29bb338122772378482806e17328c1) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) cameraTarget, float cameraBearing, float cameraElevation, float cameraDistance, ref [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) lastUsedIdealCameraTarget) |
| virtual float | [CalculateCameraElevation](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#afd2752fea64693774f21a5ab0bc06cad) (float cameraDistance) |

|  |  |
| --- | --- |
| Protected Attributes | |
| float | [\_customMaximumCameraHeight](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#af220025815dfa453120e574c5f06927f) = 0f |

|  |  |
| --- | --- |
| Properties | |
| virtual [CameraFollowMode](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aa00899d5a537783e6af667f202ad691d) | [CurrentCameraFollowMode](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a958fc3b27bdff369a28d0474ab1032f7) `[get, set]` |
| virtual float | [CameraFastMoveMultiplier](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ac9fb3f7ad349c61e1d1ea7a31cb7a2ba) `[get, protected set]` |
| virtual float | [CameraBearing](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ad241be77d47b85917486ba7a00a2a73a) `[get, set]` |
| virtual float | [MaximumCameraHeight](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a9727339622ab7ff0a11549de285b691d) `[get]` |
| virtual float | [CameraBearingVelocity](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ae4b659ee739f4e94e88b8d02cf97fcbe) `[get, set]` |
| virtual float | [CameraDistance](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a695af09001cd214ff5f034eedc7de97b) `[get, protected set]` |
| virtual float | [TargetCameraDistance](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a7e85a830649dbef979049481ba55d257) `[get, set]` |
| virtual float | [AdditionalElevation](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a0405459f0f379c19009948ad879a9c7c) `[get, set]` |
| virtual bool | [CameraAnimationInProgress](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a3d6ab6253ca57bd3df9520b6d0d8a9ca) `[get, protected set]` |
| virtual bool | [ProcessCameraInput](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ad69d6861caefb7a0fbc66a490f5af453) `[get, protected set]` |
| virtual Camera | [Camera](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ae6fa634d2a9bfe4608b8a36e9462f03b) `[get, protected set]` |
| virtual [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [CameraFrame](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a45320b90d2f8e4a01135d5936840a47e) `[get, protected set]` |
| virtual [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [IdealCameraTarget](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a0954359dfda6a09b686decaf33ad7a79) `[get, set]` |
| Properties inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| MapScreen | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#af4f77c9eec549e6d57cb4667f09ea0b4) `[get]` |
| MapState | [MapState](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#abf6624dfb0331164523cae87d042e691) `[get]` |
| Properties inherited from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html) | |
| bool | [IsFinalized](class_sand_box_1_1_view_1_1_sandbox_view.html#a5807fb2c109c6715d7fae1a6cf2f4693) `[get, protected set]` |
| ScreenLayer | [Layer](class_sand_box_1_1_view_1_1_sandbox_view.html#a070dec1267ecf8ff4afadffc12374024) `[get, protected set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Protected Attributes inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| const float | [ContextAlphaModifier](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#a9efbb55b721c1331986ba14d416c84f6) = 8.5f |

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aa00899d5a537783e6af667f202ad691d)CameraFollowMode
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.View.Map.MapCameraView.CameraFollowMode](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aa00899d5a537783e6af667f202ad691d) |

| Enumerator | |
| --- | --- |
| Free |  |
| FollowParty |  |
| MoveToPosition |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a64f71570ed236611a3172341363869b0)MapCameraView()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.View.Map.MapCameraView.MapCameraView | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ad1f38e8ba941a2ca0a8e7040fabb3759)OnActivate()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.OnActivate | ( | bool | *leftButtonDraggingMode*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *clickedPosition* ) | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a6b72eb8edf40b4e973f2ee9f2e2e2382)Initialize()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.Initialize | ( |  | ) |  | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ae4267f6ea90511eb4ea242849d6b6774)SetCameraMode()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.SetCameraMode | ( | [CameraFollowMode](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aa00899d5a537783e6af667f202ad691d) | *cameraMode* | ) |  | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a5472ab542141c3445748634304ab7c89)ResetCamera()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.ResetCamera | ( | bool | *resetDistance*, | |  |  | bool | *teleportToMainParty* ) | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aa9bd94867bcbc2dd7e63b61c5ee23369)TeleportCameraToMainParty()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.TeleportCameraToMainParty | ( |  | ) |  | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a6ad84b0794439317c3501bca2fbc6228)FastMoveCameraToMainParty()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.FastMoveCameraToMainParty | ( |  | ) |  | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a3ae9f745b0a47f700b77f4f1ae50f61d)FastMoveCameraToPosition()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.FastMoveCameraToPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *target*, | |  |  | bool | *isInMenu* ) | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a837326437697742d7a149f030520ae16)OnFastMoveCameraMovementStart()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapCameraView.OnFastMoveCameraMovementStart | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a9be5e721f3586ff524a68720be4c2da9)StopCameraMovementSoundEvents()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.Map.MapCameraView.StopCameraMovementSoundEvents | ( |  | ) |  |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a87cb06d1089a7324ac0d1e86d474b62f)IsCameraLockedToPlayerParty()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool SandBox.View.Map.MapCameraView.IsCameraLockedToPlayerParty | ( |  | ) |  | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ad8280c9399ee36db851d7391d999b548)StartCameraAnimation()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.StartCameraAnimation | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *targetPosition*, | |  |  | float | *animationStopDuration* ) | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a6832702f56c8baeaf4d89af9d908f6c3)SiegeEngineClick()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.SiegeEngineClick | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *siegeEngineFrame* | ) |  | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a11703d88709a1c0e0fd2061d27e46d24)OnExit()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.OnExit | ( |  | ) |  | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aeb64f13cbd4e8f229e561efb39be33a4)OnEscapeMenuToggled()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.OnEscapeMenuToggled | ( | bool | *isOpened* | ) |  | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a3b7a35690476c4e17698ff96ed84cada)HandleMouse()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.HandleMouse | ( | bool | *rightMouseButtonPressed*, | |  |  | float | *verticalCameraInput*, | |  |  | float | *mouseMoveY*, | |  |  | float | *dt* ) | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a4b8e6b7e534b09ec861b798c615c134c)HandleLeftMouseButtonClick()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.HandleLeftMouseButtonClick | ( | bool | *isMouseActive* | ) |  | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a99dd0df0aee74661e1acaadf138c570f)OnSetMapSiegeOverlayState()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.OnSetMapSiegeOverlayState | ( | bool | *isActive*, | |  |  | bool | *isMapSiegeOverlayViewNull* ) | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a4c7df64c9cb4f21f69bfa94d45f40cd2)OnRefreshMapSiegeOverlayRequired()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.OnRefreshMapSiegeOverlayRequired | ( | bool | *isMapSiegeOverlayViewNull* | ) |  | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a5e549622939ae555dc9657dc2203b409)OnBeforeTick()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.OnBeforeTick | ( | in [InputInformation](struct_sand_box_1_1_view_1_1_map_1_1_map_camera_view_1_1_input_information.html) | *inputInformation* | ) |  | | virtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a0c87dae60316a964616e5661da2e5c2e)UpdateMapCamera()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.View.Map.MapCameraView.UpdateMapCamera | ( | bool | *\_leftButtonDraggingMode*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *\_clickedPosition* ) | | protectedvirtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ae029480988f7118e97d2f87ba45a9f76)GetCameraTargetForPosition()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.View.Map.MapCameraView.GetCameraTargetForPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *targetPosition* | ) |  | | protectedvirtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ac1f6c96a6df776c48bb4eba741713c31)GetCameraTargetForParty()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.View.Map.MapCameraView.GetCameraTargetForParty | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | protectedvirtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a8e7e37dffe7f7e60695a58fcdf3241eb)GetMapCameraInput()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool SandBox.View.Map.MapCameraView.GetMapCameraInput | ( | [InputInformation](struct_sand_box_1_1_view_1_1_map_1_1_map_camera_view_1_1_input_information.html) | *inputInformation* | ) |  | | protectedvirtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a1e29bb338122772378482806e17328c1)ComputeMapCamera()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) SandBox.View.Map.MapCameraView.ComputeMapCamera | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *cameraTarget*, | |  |  | float | *cameraBearing*, | |  |  | float | *cameraElevation*, | |  |  | float | *cameraDistance*, | |  |  | ref [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *lastUsedIdealCameraTarget* ) | | protectedvirtual |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#afd2752fea64693774f21a5ab0bc06cad)CalculateCameraElevation()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual float SandBox.View.Map.MapCameraView.CalculateCameraElevation | ( | float | *cameraDistance* | ) |  | | protectedvirtual |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#af220025815dfa453120e574c5f06927f)\_customMaximumCameraHeight
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.View.Map.MapCameraView.\_customMaximumCameraHeight = 0f | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a958fc3b27bdff369a28d0474ab1032f7)CurrentCameraFollowMode
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [CameraFollowMode](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#aa00899d5a537783e6af667f202ad691d) SandBox.View.Map.MapCameraView.CurrentCameraFollowMode | | getsetprotected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ac9fb3f7ad349c61e1d1ea7a31cb7a2ba)CameraFastMoveMultiplier
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual float SandBox.View.Map.MapCameraView.CameraFastMoveMultiplier | | getprotected set |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ad241be77d47b85917486ba7a00a2a73a)CameraBearing
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual float SandBox.View.Map.MapCameraView.CameraBearing | | getsetprotected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a9727339622ab7ff0a11549de285b691d)MaximumCameraHeight
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual float SandBox.View.Map.MapCameraView.MaximumCameraHeight | | getprotected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ae4b659ee739f4e94e88b8d02cf97fcbe)CameraBearingVelocity
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual float SandBox.View.Map.MapCameraView.CameraBearingVelocity | | getsetprotected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a695af09001cd214ff5f034eedc7de97b)CameraDistance
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual float SandBox.View.Map.MapCameraView.CameraDistance | | getprotected set |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a7e85a830649dbef979049481ba55d257)TargetCameraDistance
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual float SandBox.View.Map.MapCameraView.TargetCameraDistance | | getsetprotected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a0405459f0f379c19009948ad879a9c7c)AdditionalElevation
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual float SandBox.View.Map.MapCameraView.AdditionalElevation | | getsetprotected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a3d6ab6253ca57bd3df9520b6d0d8a9ca)CameraAnimationInProgress
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool SandBox.View.Map.MapCameraView.CameraAnimationInProgress | | getprotected set |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ad69d6861caefb7a0fbc66a490f5af453)ProcessCameraInput
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool SandBox.View.Map.MapCameraView.ProcessCameraInput | | getprotected set |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#ae6fa634d2a9bfe4608b8a36e9462f03b)Camera
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual Camera SandBox.View.Map.MapCameraView.Camera | | getprotected set |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a45320b90d2f8e4a01135d5936840a47e)CameraFrame
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) SandBox.View.Map.MapCameraView.CameraFrame | | getprotected set |

[◆](class_sand_box_1_1_view_1_1_map_1_1_map_camera_view.html#a0954359dfda6a09b686decaf33ad7a79)IdealCameraTarget
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.View.Map.MapCameraView.IdealCameraTarget | | getsetprotected |


--- SOURCE: class_tale_worlds_1_1_core_1_1_mission_ship_object.html ---

TaleWorlds.Core.MissionShipObject Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionShipObject](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a7fc6e65cac0570e41b9a91b58b410b44) () |
|  | Initializes a new instance of the [MissionShipObject](class_tale_worlds_1_1_core_1_1_mission_ship_object.html) class. Parameterless constructor is necessary for deserialization. |
|  | [MissionShipObject](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#aebbe714c6acfa41784a0cbfc763cccca) (string stringId) |
|  | Initializes a new instance of the [MissionShipObject](class_tale_worlds_1_1_core_1_1_mission_ship_object.html) class with string id. |
| void | [SetPhysicsReference](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a49b4c585f3974dab0c1fdfe37ffb7021) ([ShipPhysicsReference](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html) physicsReference) |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a41d7e090e8b32a6b4fa3072792e81238) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Properties | |
| string | [Prefab](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a6386a9962207a28a5a77455d99245745) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [DeploymentArea](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a6c9f640b07dc1f5840205c16fa53ee61) `[get]` |
| float | [Mass](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a0b06fe92d99ea6e073bee01d41c4ea17) `[get]` |
| float | [FloatingForceMultiplier](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#abd1d3fac453b7d7fd5aad69054696517) `[get]` |
| float | [MaximumSubmergedVolumeRatio](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a2d5b927499aeb5e55f9d48e31117d1db) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [RudderStockPosition](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a22fb1ca7d0680d02759d3ef3b4e4ea8d) `[get]` |
| float | [MaxLateralDragShift](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a8eeac2396ec66c3d80b26d84a6c630e5) `[get]` |
| float | [LateralDragShiftCriticalAngle](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#ad7af253ac21c2f4eee33c0938f249977) `[get]` |
| [ShipPhysicsReference](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html) | [PhysicsReference](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#ab5c2f3d2b27d28ad558183754d47a87b) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [MomentOfInertiaMultiplier](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#aa9c824912c56327c0b09f07dd7abcf88) `[get]` |
| [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html) | [LinearFrictionMultiplier](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a586fb59478cfe72b828e85bd076e582a) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [AngularFrictionMultiplier](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a8dc6d0b4b9fd260580c46016ad4b1db9) `[get]` |
| float | [TorqueMultiplierOfLateralBuoyantForces](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#aa074819526ed2234e9f285e3438be859) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [TorqueMultiplierOfVerticalBuoyantForces](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a47b95525f9674ce699e2023f77fec3f3) `[get]` |
| float | [OarsmenForceMultiplier](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a207643013219ed28130620b44ae38873) `[get]` |
| float | [OarsTipSpeed](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a05a9f8e7f33d650f778c6f1e6f6872b6) `[get]` |
| float | [OarFrictionMultiplier](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a034bffc3463053e74f6be775e8b48ac5) `[get]` |
| MBReadOnlyList< [ShipSail](class_tale_worlds_1_1_core_1_1_ship_sail.html) > | [Sails](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#aba28a0fbe8bb9128099938d2e6219b6d) `[get]` |
| int | [OarCount](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a5896ba4cfa4cb3a70c1ae1931440d17e) `[get]` |
| float | [RudderBladeLength](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a291defb737ec1005c2586cf751f1bec6) `[get]` |
| float | [RudderBladeHeight](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a94853ad58d6d6f5371a8f376d3b7369c) `[get]` |
| float | [RudderDeflectionCoef](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a32cf6b8dfaef53a1028281bf8e3b72a1) `[get]` |
| float | [RudderRotationMax](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a03f24b2a7f154b573f383554ab8e8483) `[get]` |
| float | [RudderRotationRate](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#abd7435612168c1fbb7933d3465b5a426) `[get]` |
| float | [RudderForceMax](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a292f9d0936f14d2e1b99a56336d0917c) `[get]` |
| float | [MaxLinearSpeed](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#af8b4ef4dd73d220ca2cd66647447345e) `[get]` |
| float | [MaxLinearAccel](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a0177f4fcac3e31a8b836c9b25669bf31) `[get]` |
| float | [MaxAngularSpeed](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a7f8801221e14f922962632c91fb5d7b5) `[get]` |
| float | [MaxAngularAccel](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a7a924962d8804aa3c6246b38c5b97c66) `[get]` |
| float | [PartialHitPointsRatio](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#ada45847506e8914d73a793370647064d) `[get]` |
| bool | [HasSails](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#aeeadc34ac81ea57edba0d1800918cb11) `[get]` |
| bool | [HasValidRudderStockPosition](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a3e4f8354b5e06c77b050f2fce2f60568) `[get]` |
| string | [ShipPhysicsReferenceId](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a1221a8c0060a24befd19a2a722d913db) `[get]` |
| float | [BowAngleLimitFromCenterline](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a8523ab0e8902e2ea63a2a556850f59e7) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a7fc6e65cac0570e41b9a91b58b410b44)MissionShipObject() [1/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.MissionShipObject.MissionShipObject | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#aebbe714c6acfa41784a0cbfc763cccca)MissionShipObject() [2/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.MissionShipObject.MissionShipObject | ( | string | *stringId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a49b4c585f3974dab0c1fdfe37ffb7021)SetPhysicsReference()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.MissionShipObject.SetPhysicsReference | ( | [ShipPhysicsReference](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html) | *physicsReference* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a41d7e090e8b32a6b4fa3072792e81238)Deserialize()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.MissionShipObject.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a6386a9962207a28a5a77455d99245745)Prefab
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.MissionShipObject.Prefab | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a6c9f640b07dc1f5840205c16fa53ee61)DeploymentArea
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Core.MissionShipObject.DeploymentArea | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a0b06fe92d99ea6e073bee01d41c4ea17)Mass
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.Mass | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#abd1d3fac453b7d7fd5aad69054696517)FloatingForceMultiplier
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.FloatingForceMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a2d5b927499aeb5e55f9d48e31117d1db)MaximumSubmergedVolumeRatio
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.MaximumSubmergedVolumeRatio | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a22fb1ca7d0680d02759d3ef3b4e4ea8d)RudderStockPosition
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.MissionShipObject.RudderStockPosition | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a8eeac2396ec66c3d80b26d84a6c630e5)MaxLateralDragShift
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.MaxLateralDragShift | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#ad7af253ac21c2f4eee33c0938f249977)LateralDragShiftCriticalAngle
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.LateralDragShiftCriticalAngle | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#ab5c2f3d2b27d28ad558183754d47a87b)PhysicsReference
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ShipPhysicsReference](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html) TaleWorlds.Core.MissionShipObject.PhysicsReference | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#aa9c824912c56327c0b09f07dd7abcf88)MomentOfInertiaMultiplier
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.MissionShipObject.MomentOfInertiaMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a586fb59478cfe72b828e85bd076e582a)LinearFrictionMultiplier
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html) TaleWorlds.Core.MissionShipObject.LinearFrictionMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a8dc6d0b4b9fd260580c46016ad4b1db9)AngularFrictionMultiplier
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.MissionShipObject.AngularFrictionMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#aa074819526ed2234e9f285e3438be859)TorqueMultiplierOfLateralBuoyantForces
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.TorqueMultiplierOfLateralBuoyantForces | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a47b95525f9674ce699e2023f77fec3f3)TorqueMultiplierOfVerticalBuoyantForces
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Core.MissionShipObject.TorqueMultiplierOfVerticalBuoyantForces | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a207643013219ed28130620b44ae38873)OarsmenForceMultiplier
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.OarsmenForceMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a05a9f8e7f33d650f778c6f1e6f6872b6)OarsTipSpeed
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.OarsTipSpeed | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a034bffc3463053e74f6be775e8b48ac5)OarFrictionMultiplier
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.OarFrictionMultiplier | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#aba28a0fbe8bb9128099938d2e6219b6d)Sails
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[ShipSail](class_tale_worlds_1_1_core_1_1_ship_sail.html)> TaleWorlds.Core.MissionShipObject.Sails | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a5896ba4cfa4cb3a70c1ae1931440d17e)OarCount
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.MissionShipObject.OarCount | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a291defb737ec1005c2586cf751f1bec6)RudderBladeLength
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.RudderBladeLength | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a94853ad58d6d6f5371a8f376d3b7369c)RudderBladeHeight
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.RudderBladeHeight | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a32cf6b8dfaef53a1028281bf8e3b72a1)RudderDeflectionCoef
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.RudderDeflectionCoef | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a03f24b2a7f154b573f383554ab8e8483)RudderRotationMax
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.RudderRotationMax | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#abd7435612168c1fbb7933d3465b5a426)RudderRotationRate
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.RudderRotationRate | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a292f9d0936f14d2e1b99a56336d0917c)RudderForceMax
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.RudderForceMax | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#af8b4ef4dd73d220ca2cd66647447345e)MaxLinearSpeed
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.MaxLinearSpeed | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a0177f4fcac3e31a8b836c9b25669bf31)MaxLinearAccel
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.MaxLinearAccel | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a7f8801221e14f922962632c91fb5d7b5)MaxAngularSpeed
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.MaxAngularSpeed | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a7a924962d8804aa3c6246b38c5b97c66)MaxAngularAccel
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.MaxAngularAccel | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#ada45847506e8914d73a793370647064d)PartialHitPointsRatio
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.PartialHitPointsRatio | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#aeeadc34ac81ea57edba0d1800918cb11)HasSails
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.MissionShipObject.HasSails | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a3e4f8354b5e06c77b050f2fce2f60568)HasValidRudderStockPosition
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.MissionShipObject.HasValidRudderStockPosition | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a1221a8c0060a24befd19a2a722d913db)ShipPhysicsReferenceId
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.MissionShipObject.ShipPhysicsReferenceId | | get |

[◆](class_tale_worlds_1_1_core_1_1_mission_ship_object.html#a8523ab0e8902e2ea63a2a556850f59e7)BowAngleLimitFromCenterline
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.MissionShipObject.BowAngleLimitFromCenterline | | get |


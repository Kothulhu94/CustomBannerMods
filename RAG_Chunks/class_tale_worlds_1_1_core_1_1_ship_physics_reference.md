--- SOURCE: class_tale_worlds_1_1_core_1_1_ship_physics_reference.html ---

TaleWorlds.Core.ShipPhysicsReference Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ShipPhysicsReference](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a8e3efe0c49a433d8cec0ad1f3b7ec819) () |
|  | [ShipPhysicsReference](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#ac1fc83156940376af3d0994bb79ae40c) (string stringId) |
| override void | [Deserialize](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#ad3661699275c8440b1947eb82f7e6255) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
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
| Static Public Member Functions | |
| static float | [GetDefaultWaterDensity](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#abf3dc2fee114c241a2408bf7bc671e6f) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly [ShipPhysicsReference](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a8e3efe0c49a433d8cec0ad1f3b7ec819) | [Default](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a95564ddf6958509d398c7032696de76c) |
| static readonly [ShipPhysicsReference](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a8e3efe0c49a433d8cec0ad1f3b7ec819) | [DefaultDebris](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#af73fda1409453822b022beb43b7283ca) |

|  |  |
| --- | --- |
| Properties | |
| [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html) | [LinearDragTerm](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a15df741d12aa131ab050121b147cf6a7) `[get]` |
| [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html) | [LinearDampingTerm](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#ab43e7011accf783d1df8889dbcbebcf0) `[get]` |
| [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html) | [ConstantLinearDampingTerm](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a55584dd6f814114227fc5255a3675208) `[get]` |
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

[◆](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a8e3efe0c49a433d8cec0ad1f3b7ec819)ShipPhysicsReference() [1/2]
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.ShipPhysicsReference.ShipPhysicsReference | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#ac1fc83156940376af3d0994bb79ae40c)ShipPhysicsReference() [2/2]
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.ShipPhysicsReference.ShipPhysicsReference | ( | string | *stringId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#ad3661699275c8440b1947eb82f7e6255)Deserialize()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.Core.ShipPhysicsReference.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#abf3dc2fee114c241a2408bf7bc671e6f)GetDefaultWaterDensity()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.Core.ShipPhysicsReference.GetDefaultWaterDensity | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a95564ddf6958509d398c7032696de76c)Default
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ShipPhysicsReference](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a8e3efe0c49a433d8cec0ad1f3b7ec819) TaleWorlds.Core.ShipPhysicsReference.Default | | static |

**Initial value:**

= new ShipPhysicsReference

{

[LinearDragTerm](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a15df741d12aa131ab050121b147cf6a7) = new [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html)(0.891263068f, 0.891263068f, 0.0009766732f, 0.00330270687f, 0.08070293f, 0.807029247f),

[LinearDampingTerm](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#ab43e7011accf783d1df8889dbcbebcf0) = new [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html)(0.28781262f, 0.28781262f, 0.00260446267f, 0.008807218f, 0.215207785f, 2.152078f),

[ConstantLinearDampingTerm](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a55584dd6f814114227fc5255a3675208) = new [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html)(0.0454545431f, 0.0454545431f, 0.0136363637f, 0.0272727273f, 0.0454545431f, 0.0454545431f),

}

[TaleWorlds.Core.ShipPhysicsReference.LinearDragTerm](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a15df741d12aa131ab050121b147cf6a7)

LinearFrictionTerm LinearDragTerm

**Definition** ShipPhysicsReference.cs:25

[TaleWorlds.Core.ShipPhysicsReference.ConstantLinearDampingTerm](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a55584dd6f814114227fc5255a3675208)

LinearFrictionTerm ConstantLinearDampingTerm

**Definition** ShipPhysicsReference.cs:31

[TaleWorlds.Core.ShipPhysicsReference.LinearDampingTerm](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#ab43e7011accf783d1df8889dbcbebcf0)

LinearFrictionTerm LinearDampingTerm

**Definition** ShipPhysicsReference.cs:28

[TaleWorlds.Core.LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html)

Keeps per direction values of the linear drag and damping term of the ship (in kg/m).

**Definition** LinearFrictionTerm.cs:5

[◆](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#af73fda1409453822b022beb43b7283ca)DefaultDebris
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ShipPhysicsReference](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a8e3efe0c49a433d8cec0ad1f3b7ec819) TaleWorlds.Core.ShipPhysicsReference.DefaultDebris | | static |

**Initial value:**

= new ShipPhysicsReference

{

[LinearDragTerm](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a15df741d12aa131ab050121b147cf6a7) = new [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html)(0.891263068f, 0.891263068f, 0.891263068f, 0.891263068f, 0.807029247f, 0.807029247f),

[LinearDampingTerm](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#ab43e7011accf783d1df8889dbcbebcf0) = new [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html)(0.28781262f, 0.28781262f, 0.28781262f, 0.28781262f, 2.152078f, 2.152078f),

[ConstantLinearDampingTerm](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a55584dd6f814114227fc5255a3675208) = new [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html)(0.0454545431f, 0.0454545431f, 0.0454545431f, 0.0454545431f, 0.0454545431f, 0.0454545431f),

}

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a15df741d12aa131ab050121b147cf6a7)LinearDragTerm
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html) TaleWorlds.Core.ShipPhysicsReference.LinearDragTerm | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#ab43e7011accf783d1df8889dbcbebcf0)LinearDampingTerm
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html) TaleWorlds.Core.ShipPhysicsReference.LinearDampingTerm | | get |

[◆](class_tale_worlds_1_1_core_1_1_ship_physics_reference.html#a55584dd6f814114227fc5255a3675208)ConstantLinearDampingTerm
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [LinearFrictionTerm](struct_tale_worlds_1_1_core_1_1_linear_friction_term.html) TaleWorlds.Core.ShipPhysicsReference.ConstantLinearDampingTerm | | get |


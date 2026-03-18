--- SOURCE: struct_tale_worlds_1_1_engine_1_1_physics_material.html ---

TaleWorlds.Engine.PhysicsMaterial Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
| [PhysicsMaterialFlags](namespace_tale_worlds_1_1_engine.html#a0220bb64bd3afbeb8ccae100b6d58f5a) | [GetFlags](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a0dcc18c027e447e0af7efe1faa967808) () |
| float | [GetDynamicFriction](struct_tale_worlds_1_1_engine_1_1_physics_material.html#ac1cd1fa2316881a1c5923be298bbf8e2) () |
| float | [GetStaticFriction](struct_tale_worlds_1_1_engine_1_1_physics_material.html#ae0587a90c9c9dfb8686f254dca8998ac) () |
| float | [GetRestitution](struct_tale_worlds_1_1_engine_1_1_physics_material.html#aa7fbaef228a0cefa380dec72c09baaf9) () |
| float | [GetLinearDamping](struct_tale_worlds_1_1_engine_1_1_physics_material.html#aa20163afe7d97ab0824a5497b7bfcd09) () |
| float | [GetAngularDamping](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a35b1d30247f66725dcf7c8d8d991a54e) () |
| bool | [Equals](struct_tale_worlds_1_1_engine_1_1_physics_material.html#aa2ecd725b1190385e30956edf7b2d504) (PhysicsMaterial m) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GetMaterialCount](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a9beaaf6153211ee779a7cbae3552d493) () |
| static PhysicsMaterial | [GetFromName](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a69117b7d2feebf090fb9aff10dd875cb) (string id) |
| static string | [GetNameAtIndex](struct_tale_worlds_1_1_engine_1_1_physics_material.html#ab6f4ab226cce9af0b5e57e6de45fc8a0) (int index) |
| static [PhysicsMaterialFlags](namespace_tale_worlds_1_1_engine.html#a0220bb64bd3afbeb8ccae100b6d58f5a) | [GetFlagsAtIndex](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a140b9e7cc10162303dba10cbcd9afff6) (int index) |
| static float | [GetRestitutionAtIndex](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a71f6131ad3eeaeb08edc9dd9181c61d4) (int index) |
| static float | [GetDynamicFrictionAtIndex](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a2446af5c6fbc294f82c4daf64a8f3a06) (int index) |
| static float | [GetStaticFrictionAtIndex](struct_tale_worlds_1_1_engine_1_1_physics_material.html#afa0cad394e6a448021ab05d0d2620047) (int index) |
| static float | [GetLinearDampingAtIndex](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a92e7bbae9afb3f3bb9f958a659128a65) (int index) |
| static float | [GetAngularDampingAtIndex](struct_tale_worlds_1_1_engine_1_1_physics_material.html#ae3d9bfb4885f9e7648789daae098e5e4) (int index) |
| static PhysicsMaterial | [GetFromIndex](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a3018761f8781eda758abc05d3429fc02) (int index) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly int | [Index](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a27792aca61feefe89cd80fc7687a5b0b) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly PhysicsMaterial | [InvalidPhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html#af7bb51f8d6b04d2e3c53e82afdbdf0b1) = new PhysicsMaterial(-1) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](struct_tale_worlds_1_1_engine_1_1_physics_material.html#aaa890775a14433cd62e00fe1389b6916) `[get]` |
| string | [Name](struct_tale_worlds_1_1_engine_1_1_physics_material.html#ab4f497f2e90be0d78df548ea1a51d7fc) `[get]` |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a0dcc18c027e447e0af7efe1faa967808)GetFlags()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [PhysicsMaterialFlags](namespace_tale_worlds_1_1_engine.html#a0220bb64bd3afbeb8ccae100b6d58f5a) TaleWorlds.Engine.PhysicsMaterial.GetFlags | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#ac1cd1fa2316881a1c5923be298bbf8e2)GetDynamicFriction()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.PhysicsMaterial.GetDynamicFriction | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#ae0587a90c9c9dfb8686f254dca8998ac)GetStaticFriction()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.PhysicsMaterial.GetStaticFriction | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#aa7fbaef228a0cefa380dec72c09baaf9)GetRestitution()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.PhysicsMaterial.GetRestitution | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#aa20163afe7d97ab0824a5497b7bfcd09)GetLinearDamping()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.PhysicsMaterial.GetLinearDamping | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a35b1d30247f66725dcf7c8d8d991a54e)GetAngularDamping()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.PhysicsMaterial.GetAngularDamping | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#aa2ecd725b1190385e30956edf7b2d504)Equals()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.PhysicsMaterial.Equals | ( | PhysicsMaterial | *m* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a9beaaf6153211ee779a7cbae3552d493)GetMaterialCount()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.PhysicsMaterial.GetMaterialCount | ( |  | ) |  | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a69117b7d2feebf090fb9aff10dd875cb)GetFromName()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | PhysicsMaterial TaleWorlds.Engine.PhysicsMaterial.GetFromName | ( | string | *id* | ) |  | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#ab6f4ab226cce9af0b5e57e6de45fc8a0)GetNameAtIndex()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.PhysicsMaterial.GetNameAtIndex | ( | int | *index* | ) |  | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a140b9e7cc10162303dba10cbcd9afff6)GetFlagsAtIndex()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [PhysicsMaterialFlags](namespace_tale_worlds_1_1_engine.html#a0220bb64bd3afbeb8ccae100b6d58f5a) TaleWorlds.Engine.PhysicsMaterial.GetFlagsAtIndex | ( | int | *index* | ) |  | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a71f6131ad3eeaeb08edc9dd9181c61d4)GetRestitutionAtIndex()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.PhysicsMaterial.GetRestitutionAtIndex | ( | int | *index* | ) |  | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a2446af5c6fbc294f82c4daf64a8f3a06)GetDynamicFrictionAtIndex()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.PhysicsMaterial.GetDynamicFrictionAtIndex | ( | int | *index* | ) |  | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#afa0cad394e6a448021ab05d0d2620047)GetStaticFrictionAtIndex()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.PhysicsMaterial.GetStaticFrictionAtIndex | ( | int | *index* | ) |  | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a92e7bbae9afb3f3bb9f958a659128a65)GetLinearDampingAtIndex()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.PhysicsMaterial.GetLinearDampingAtIndex | ( | int | *index* | ) |  | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#ae3d9bfb4885f9e7648789daae098e5e4)GetAngularDampingAtIndex()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.PhysicsMaterial.GetAngularDampingAtIndex | ( | int | *index* | ) |  | | static |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a3018761f8781eda758abc05d3429fc02)GetFromIndex()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | PhysicsMaterial TaleWorlds.Engine.PhysicsMaterial.GetFromIndex | ( | int | *index* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#a27792aca61feefe89cd80fc7687a5b0b)Index
---------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly int TaleWorlds.Engine.PhysicsMaterial.Index |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#af7bb51f8d6b04d2e3c53e82afdbdf0b1)InvalidPhysicsMaterial
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly PhysicsMaterial TaleWorlds.Engine.PhysicsMaterial.InvalidPhysicsMaterial = new PhysicsMaterial(-1) | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#aaa890775a14433cd62e00fe1389b6916)IsValid
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.PhysicsMaterial.IsValid | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_physics_material.html#ab4f497f2e90be0d78df548ea1a51d7fc)Name
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Engine.PhysicsMaterial.Name | | get |


--- SOURCE: class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html ---

TaleWorlds.Engine.GameEntityPhysicsExtensions Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) : sbyte {     [Force](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995faa9eb6b78a99cdb6ffd3d40d18621d9f80) ,     [Impulse](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995faa6b0a227bd9315bcde12dbcf6c217a9d7) ,     [VelocityChange](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995faa7c6c8f6e33aa732a3214ffe2e342cb2d) ,     [Acceleration](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995faa3b926d163371fd620b09b63219b12f52)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [HasBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aae1426ce5165354f2f215294c8b22f83) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static bool | [HasBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a97ce4fa1e6256321639cffe2eb53ee69) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static void | [AddSphereAsBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a86dd112cdd68d8921d30f9fb4ad8bd73) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sphere, float radius, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) bodyFlags) |
| static void | [AddCapsuleAsBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac5202a4dd9d319d371f18250fc2e45cd) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p2, float radius, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) bodyFlags, string physicsMaterialName="") |
| static void | [PushCapsuleShapeToEntityBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a1c37b311598a9c3a7795a43d6d40a6c2) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p2, float radius, string physicsMaterialName) |
| static void | [AddSphereAsBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a828a3f43eae266e96038c3b60e9cfcd7) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sphere, float radius, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) bodyFlags) |
| static void | [AddCapsuleAsBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a7fe7f4d12b2982d2d851f08203d039ad) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p2, float radius, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) bodyFlags, string physicsMaterialName="") |
| static void | [PopCapsuleShapeFromEntityBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a9447c3bba0eb025d7226b32ee3265992) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static void | [RemovePhysics](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a8c036a6c36f2b885e437c892de1b6482) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, bool clearingTheScene=false) |
| static void | [RemovePhysics](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a801090bdea64704b675d919b4c87b4f4) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, bool clearingTheScene=false) |
| static bool | [GetPhysicsState](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac34008d4f79aafe43ac41e595f524785) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static bool | [GetPhysicsState](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a040713a40b1876d64653ce13094ebc70) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static int | [GetPhysicsTriangleCount](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6cab81544bf65fae2fba40ae7f90db64) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static int | [GetPhysicsTriangleCount](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#af369d9c11d2c4720d97fa9506f273a65) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static bool | [HasPhysicsDefinitionWithoutFlags](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a3240321b729cf8de976bce13ca8748a1) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, int excludeFlags) |
| static bool | [HasPhysicsDefinitionWithoutFlags](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6c9d582ee089f3853fdb5606041d99c0) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, int excludeFlags) |
| static bool | [HasPhysicsBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a40dd9192bb4c68683cdd36869e46dcc6) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static bool | [HasPhysicsBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a89f057c9d44a98b371987ca71cec3343) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static bool | [HasDynamicRigidBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a140cf4c0464912ca59d5bfb4df87eb41) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static bool | [HasDynamicRigidBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ad67483b8dcd0fc64784efad232ea6454) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static bool | [HasKinematicRigidBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#acf47e6180cec401428770a4dae83d88d) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static bool | [HasKinematicRigidBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a2e624e368b285519282031426b9e2a8d) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static bool | [HasStaticPhysicsBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6623f22aee7946861b8d02164cccfbfb) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static bool | [HasStaticPhysicsBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aa7a58ad816a4ee7a82456e5123a2e0f0) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static bool | [HasDynamicRigidBodyAndActiveSimulation](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a77d92a8ef79b030bec5736f2776aca15) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static bool | [HasDynamicRigidBodyAndActiveSimulation](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac708aaa428c809755ca843b13ba69976) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static void | [CreateVariableRatePhysics](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aafe5461937ae1e76e4b9996397e134fd) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, bool forChildren) |
| static void | [CreateVariableRatePhysics](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a626c59f34cb21092b8649e4992ced29d) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, bool forChildren) |
| static void | [SetPhysicsState](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac1a5709950ad650b56d09c6ba64965c9) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, bool isEnabled, bool setChildren) |
| static void | [SetPhysicsState](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ab7525b27ccf7f144533654ede8a4274c) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, bool isEnabled, bool setChildren) |
| static void | [SetPhysicsStateOnlyVariable](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac7bf0bdc682e7c8e82bdc26ebaedef8c) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, bool isEnabled, bool setChildren) |
| static void | [SetPhysicsStateOnlyVariable](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aac528a2c6d2a9c2303b99974d97351f6) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, bool isEnabled, bool setChildren) |
| static void | [RemoveEnginePhysics](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a541bbea50d0292c7e80b4033899d6854) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static void | [RemoveEnginePhysics](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a50c9d9c8e1bd192b83fcf9cff2a3f0e3) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static bool | [IsEngineBodySleeping](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a2d9d938170a63a21e3105386f2e0c7ed) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static bool | [IsEngineBodySleeping](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aa83ba3d7d5514b831851026c219caf32) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static bool | [IsDynamicBodyStationary](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6f11a0e3b39bce0010940e991c29b038) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static bool | [IsDynamicBodyStationary](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aa4e187a6e0bdb6cd60ab91c44cc7ec1e) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static bool | [IsDynamicBodyStationaryMT](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a870f0c778d56a0359ce8e3e7f9036135) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static bool | [IsDynamicBodyStationaryMT](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#af72b721ae71fee63d6010c695ed19f9d) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static void | [ReplacePhysicsBodyWithQuadPhysicsBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a48e6045e49c06dc0718a4621f498c74e) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, UIntPtr vertices, int numberOfVertices, [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) physicsMaterial, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) bodyFlags, UIntPtr indices, int numberOfIndices) |
| static void | [ReplacePhysicsBodyWithQuadPhysicsBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ad1b1b2b5d1579206f0cb45daae3ce2a3) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, UIntPtr vertices, int numberOfVertices, [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) physicsMaterial, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) bodyFlags, UIntPtr indices, int numberOfIndices) |
| static [PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html) | [GetBodyShape](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a2eb8795e9f06e3b5726c351fd6629c98) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static [PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html) | [GetBodyShape](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#acd257f8297b2e7d1317c34fde1c248fa) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static void | [SetBodyShape](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a92865b7333f5cd95ebcc3766b4407822) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html) shape) |
| static void | [SetBodyShape](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a78abdd806b1a9ad5268be5090f269698) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html) shape) |
| static void | [AddPhysics](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac456c2d6781ee78fe49e9092696cee50) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, float mass, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localCenterOfMass, [PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html) body, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) initialGlobalVelocity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) angularGlobalVelocity, [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) physicsMaterial, bool isStatic, int collisionGroupID) |
| static void | [AddPhysics](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a78168481ae10967b5738d1eeff9239ad) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, float mass, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localCenterOfMass, [PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html) body, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) initialVelocity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) angularVelocity, [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) physicsMaterial, bool isStatic, int collisionGroupID) |
| static void | [SetVelocityLimits](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a9512ef5d6bda486e5a2df1d772b6cf4a) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, float maxLinearVelocity, float maxAngularVelocity) |
| static void | [SetVelocityLimits](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aabf3155cc148f695a5663b3b0e3ccd41) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, float maxLinearVelocity, float maxAngularVelocity) |
| static void | [SetMaxDepenetrationVelocity](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6694ff31dc082ad624aee25882e3371c) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, float maxDepenetrationVelocity) |
| static void | [SetMaxDepenetrationVelocity](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ab1562575099aab7261d8bec93a90466b) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, float maxDepenetrationVelocity) |
| static void | [SetSolverIterationCounts](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a1ffcd2b6bf917129b2ea834e17c6f2c2) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, int positionIterationCount, int velocityIterationCount) |
| static void | [SetSolverIterationCounts](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#abf359c386cad4bd7fda3f35b16365c77) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, int positionIterationCount, int velocityIterationCount) |
| static void | [ApplyLocalImpulseToDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a1400d8103ba55fd5d1874b009f7e4af1) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) impulse) |
| static void | [ApplyLocalImpulseToDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a502e8fdba2d929d9c92ae02f8f939874) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) impulse) |
| static void | [ApplyForceToDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a24ef2b3d6fbe17ed814a946f8402b205) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) force, [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) forceMode) |
| static void | [ApplyForceToDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a87b7155cd44e75c127da0a60975d0b1b) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) force, [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) forceMode) |
| static void | [ApplyGlobalForceAtLocalPosToDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6b28666af2986fbb22a9c152401d0bfa) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) globalForce, [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) forceMode) |
| static void | [ApplyGlobalForceAtLocalPosToDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a71eb38c2f725198fe12049b31e3f0ac2) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) globalForce, [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) forceMode) |
| static void | [ApplyTorqueToDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a809195233ef96ee39b52b95aa863a2dc) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) torque, [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) forceMode) |
| static void | [ApplyTorqueToDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#acb341c33aba8842dd531637699c77840) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) torque, [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) forceMode) |
| static void | [ApplyLocalForceAtLocalPosToDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#abd257b3ec93f35dd26b370462ac251a5) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localForce, [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) forceMode) |
| static void | [ApplyLocalForceAtLocalPosToDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#accb7339a677edd5f387fbe79961e72ce) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localForce, [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) forceMode) |
| static void | [ApplyAccelerationToDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#afd20251122ff393d31a84bcd443df319) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) acceleration) |
| static void | [ApplyAccelerationToDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a2e80f0a8f2fd4cea7dbad71b7ab730c3) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) acceleration) |
| static void | [DisableDynamicBodySimulation](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aeb1fbc470da45368b23b4ae5ff8f057d) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static void | [DisableDynamicBodySimulation](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a523ba1ea0c6c6a7228e24152f0058414) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static void | [DisableDynamicBodySimulationMT](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a518caf609d7650a480b67a6214f98d60) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static void | [DisableDynamicBodySimulationMT](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a4b5da46b68c7183badc01c6080b075dc) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static void | [ConvertDynamicBodyToRayCast](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a078da789878051e8d613bdae734efd8b) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static void | [ConvertDynamicBodyToRayCast](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a802954d2ae74e8ec3f67bde20695b8b2) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static void | [SetPhysicsMoveToBatched](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a60f4a6857362bb7154e3c6e0c7fd2e2a) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, bool value) |
| static void | [SetPhysicsMoveToBatched](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a94e06150c757ac835f62e85bc779b7eb) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, bool value) |
| static void | [EnableDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a65e3ec090729e6da69beddb34b421b4f) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static void | [EnableDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ad8095ce92e541ef323e7391485c7f487) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static float | [GetMass](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#adab70993af3d4df108ff8db9d261d210) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static float | [GetMass](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a8696921080a2f9e28e24344030c951cf) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static void | [SetMassAndUpdateInertiaAndCenterOfMass](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#afe43a23c0a1e7c76a7c538420df380c9) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, float mass) |
| static void | [SetMassAndUpdateInertiaAndCenterOfMass](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a394e9054819574b6eaa1a5d87a39551f) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, float mass) |
| static void | [SetCenterOfMass](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a310acc530e7b7e20e6a4492d46c61b41) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) localCenterOfMass) |
| static void | [SetCenterOfMass](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a35f3290e8e1e23f69a3534aa4f5eca7e) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) centerOfMass) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetMassSpaceInertia](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#adadadd08d372ff2cf29006d802db218f) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetMassSpaceInertia](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a7771303eba4a64d5ce9bb51a4c5cd88c) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetMassSpaceInverseInertia](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aa827f750a30fcaa531acdeaa0ff193ab) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetMassSpaceInverseInertia](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ab6ccee956de5b024f7785d32331e0232) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static void | [SetMassSpaceInertia](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a94ecf56310b316ee99c5c0b950db9eb0) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) inertia) |
| static void | [SetMassSpaceInertia](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ad054cb0b3a0b80ed6283aa2a58ed9145) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) inertia) |
| static void | [SetDamping](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a448c0355b0d9247aefc9796676abdb1a) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, float linearDamping, float angularDamping) |
| static void | [SetDamping](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#add78684580906c1efd76c0b01b96b1cb) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, float linearDamping, float angularDamping) |
| static void | [SetDampingMT](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac4ed50370a0c47dd8214c59d10a008fe) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, float linearDamping, float angularDamping) |
| static void | [SetDampingMT](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a4fec5e778542c18a048b117ceb9232a1) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, float linearDamping, float angularDamping) |
| static void | [DisableGravity](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6211bb0568ace8d62624617632397894) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static void | [DisableGravity](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6e3e2462e9493195390815e719c43e3c) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static bool | [IsGravityDisabled](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aa84bd9226055d9c73dd6c52105a3f1e4) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static bool | [IsGravityDisabled](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6ec09f7bbd1469bb161e059b14d86028) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetLinearVelocity](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a087ea83833c07bc6fe25ab7e2b2ed869) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetLinearVelocity](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#af4181146745c4f3ebd9cb1de7f837c90) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static void | [SetLinearVelocity](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a61a70b2ed5b753c3f597b8ba62e985e5) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) newLinearVelocity) |
| static void | [SetLinearVelocity](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a79c32234d8d84360377a8a17ae2059c0) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) newLinearVelocity) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetLinearVelocityMT](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a413af569abab6be401589a716513515b) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetLinearVelocityMT](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#afce9b9eb87169fa99eabc5c8d0219457) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetAngularVelocity](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a916e0cc58695c67302bf4a24ba870f1d) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetAngularVelocity](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a12b7f1b85342f4dc49c4ef93347a27e2) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetAngularVelocityMT](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aafa64b9122c05305ddfff4f3f264aebd) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetAngularVelocityMT](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a910c0690092d99e2aa374f19c7bae583) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| static void | [SetAngularVelocity](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a04bbb3b30222b2df572ddcd7a04814d7) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) newAngularVelocity) |
| static void | [SetAngularVelocity](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a4696ffc27d2fde5861cfad8e373c187a) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) newAngularVelocity) |
| static void | [GetPhysicsMinMax](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a000ff1183f87a8f329770874f955fa9a) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, bool includeChildren, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) bbmin, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) bbmax, bool returnLocal) |
|  | Parameters  |  |  | | --- | --- | | returnLocal | Determines the result if it is local or global. | |
| static void | [GetPhysicsMinMax](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a3227bc8d541cda7a811b518c4e1c99b7) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, bool includeChildren, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) bbmin, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) bbmax, bool returnLocal) |
|  | Parameters  |  |  | | --- | --- | | returnLocal | Determines the result if it is local or global. | |
| static [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) | [GetLocalPhysicsBoundingBox](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aeb2cf73b32f3fb4a4d42f0257f7366a0) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) gameEntity, bool includeChildren) |
| static [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) | [GetLocalPhysicsBoundingBox](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#abad33bf76afd2d4b4ba9267009af4b0e) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, bool includeChildren) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetLinearVelocityAtGlobalPointForEntityWithDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6d38bbc6bb520e2ae73ab5970ba2de8e) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) globalPoint) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetLinearVelocityAtGlobalPointForEntityWithDynamicBody](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a289492176e254df8e54be875d31d6626) (this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) globalPoint) |
| static void | [ComputeVelocityDeltaFromImpulse](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a846f9ba22f71f94d1575181b9aa35691) (this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) impulseGlobal, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) impulsiveTorqueGlobal, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) deltaGlobalLinearVelocity, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) deltaGlobalAngularVelocity) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa)ForceMode
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Engine.GameEntityPhysicsExtensions.ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) : sbyte |

| Enumerator | |
| --- | --- |
| Force |  |
| Impulse |  |
| VelocityChange |  |
| Acceleration |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aae1426ce5165354f2f215294c8b22f83)HasBody() [1/2]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a97ce4fa1e6256321639cffe2eb53ee69)HasBody() [2/2]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a86dd112cdd68d8921d30f9fb4ad8bd73)AddSphereAsBody() [1/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.AddSphereAsBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sphere*, | |  |  | float | *radius*, | |  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *bodyFlags* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac5202a4dd9d319d371f18250fc2e45cd)AddCapsuleAsBody() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.AddCapsuleAsBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p2*, | |  |  | float | *radius*, | |  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *bodyFlags*, | |  |  | string | *physicsMaterialName* = "" ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a1c37b311598a9c3a7795a43d6d40a6c2)PushCapsuleShapeToEntityBody()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.PushCapsuleShapeToEntityBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p2*, | |  |  | float | *radius*, | |  |  | string | *physicsMaterialName* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a828a3f43eae266e96038c3b60e9cfcd7)AddSphereAsBody() [2/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.AddSphereAsBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sphere*, | |  |  | float | *radius*, | |  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *bodyFlags* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a7fe7f4d12b2982d2d851f08203d039ad)AddCapsuleAsBody() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.AddCapsuleAsBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p2*, | |  |  | float | *radius*, | |  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *bodyFlags*, | |  |  | string | *physicsMaterialName* = "" ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a9447c3bba0eb025d7226b32ee3265992)PopCapsuleShapeFromEntityBody()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.PopCapsuleShapeFromEntityBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a8c036a6c36f2b885e437c892de1b6482)RemovePhysics() [1/2]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.RemovePhysics | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | bool | *clearingTheScene* = false ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a801090bdea64704b675d919b4c87b4f4)RemovePhysics() [2/2]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.RemovePhysics | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | bool | *clearingTheScene* = false ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac34008d4f79aafe43ac41e595f524785)GetPhysicsState() [1/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.GetPhysicsState | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a040713a40b1876d64653ce13094ebc70)GetPhysicsState() [2/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.GetPhysicsState | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6cab81544bf65fae2fba40ae7f90db64)GetPhysicsTriangleCount() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.GameEntityPhysicsExtensions.GetPhysicsTriangleCount | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#af369d9c11d2c4720d97fa9506f273a65)GetPhysicsTriangleCount() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.GameEntityPhysicsExtensions.GetPhysicsTriangleCount | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a3240321b729cf8de976bce13ca8748a1)HasPhysicsDefinitionWithoutFlags() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasPhysicsDefinitionWithoutFlags | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | int | *excludeFlags* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6c9d582ee089f3853fdb5606041d99c0)HasPhysicsDefinitionWithoutFlags() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasPhysicsDefinitionWithoutFlags | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | int | *excludeFlags* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a40dd9192bb4c68683cdd36869e46dcc6)HasPhysicsBody() [1/2]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasPhysicsBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a89f057c9d44a98b371987ca71cec3343)HasPhysicsBody() [2/2]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasPhysicsBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a140cf4c0464912ca59d5bfb4df87eb41)HasDynamicRigidBody() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasDynamicRigidBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ad67483b8dcd0fc64784efad232ea6454)HasDynamicRigidBody() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasDynamicRigidBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#acf47e6180cec401428770a4dae83d88d)HasKinematicRigidBody() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasKinematicRigidBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a2e624e368b285519282031426b9e2a8d)HasKinematicRigidBody() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasKinematicRigidBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6623f22aee7946861b8d02164cccfbfb)HasStaticPhysicsBody() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasStaticPhysicsBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aa7a58ad816a4ee7a82456e5123a2e0f0)HasStaticPhysicsBody() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasStaticPhysicsBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a77d92a8ef79b030bec5736f2776aca15)HasDynamicRigidBodyAndActiveSimulation() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasDynamicRigidBodyAndActiveSimulation | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac708aaa428c809755ca843b13ba69976)HasDynamicRigidBodyAndActiveSimulation() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.HasDynamicRigidBodyAndActiveSimulation | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aafe5461937ae1e76e4b9996397e134fd)CreateVariableRatePhysics() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.CreateVariableRatePhysics | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | bool | *forChildren* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a626c59f34cb21092b8649e4992ced29d)CreateVariableRatePhysics() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.CreateVariableRatePhysics | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | bool | *forChildren* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac1a5709950ad650b56d09c6ba64965c9)SetPhysicsState() [1/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetPhysicsState | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | bool | *isEnabled*, | |  |  | bool | *setChildren* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ab7525b27ccf7f144533654ede8a4274c)SetPhysicsState() [2/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetPhysicsState | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | bool | *isEnabled*, | |  |  | bool | *setChildren* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac7bf0bdc682e7c8e82bdc26ebaedef8c)SetPhysicsStateOnlyVariable() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetPhysicsStateOnlyVariable | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | bool | *isEnabled*, | |  |  | bool | *setChildren* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aac528a2c6d2a9c2303b99974d97351f6)SetPhysicsStateOnlyVariable() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetPhysicsStateOnlyVariable | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | bool | *isEnabled*, | |  |  | bool | *setChildren* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a541bbea50d0292c7e80b4033899d6854)RemoveEnginePhysics() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.RemoveEnginePhysics | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a50c9d9c8e1bd192b83fcf9cff2a3f0e3)RemoveEnginePhysics() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.RemoveEnginePhysics | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a2d9d938170a63a21e3105386f2e0c7ed)IsEngineBodySleeping() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.IsEngineBodySleeping | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aa83ba3d7d5514b831851026c219caf32)IsEngineBodySleeping() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.IsEngineBodySleeping | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6f11a0e3b39bce0010940e991c29b038)IsDynamicBodyStationary() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.IsDynamicBodyStationary | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aa4e187a6e0bdb6cd60ab91c44cc7ec1e)IsDynamicBodyStationary() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.IsDynamicBodyStationary | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a870f0c778d56a0359ce8e3e7f9036135)IsDynamicBodyStationaryMT() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.IsDynamicBodyStationaryMT | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#af72b721ae71fee63d6010c695ed19f9d)IsDynamicBodyStationaryMT() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.IsDynamicBodyStationaryMT | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a48e6045e49c06dc0718a4621f498c74e)ReplacePhysicsBodyWithQuadPhysicsBody() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ReplacePhysicsBodyWithQuadPhysicsBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | UIntPtr | *vertices*, | |  |  | int | *numberOfVertices*, | |  |  | [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) | *physicsMaterial*, | |  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *bodyFlags*, | |  |  | UIntPtr | *indices*, | |  |  | int | *numberOfIndices* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ad1b1b2b5d1579206f0cb45daae3ce2a3)ReplacePhysicsBodyWithQuadPhysicsBody() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ReplacePhysicsBodyWithQuadPhysicsBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | UIntPtr | *vertices*, | |  |  | int | *numberOfVertices*, | |  |  | [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) | *physicsMaterial*, | |  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *bodyFlags*, | |  |  | UIntPtr | *indices*, | |  |  | int | *numberOfIndices* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a2eb8795e9f06e3b5726c351fd6629c98)GetBodyShape() [1/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetBodyShape | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#acd257f8297b2e7d1317c34fde1c248fa)GetBodyShape() [2/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetBodyShape | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a92865b7333f5cd95ebcc3766b4407822)SetBodyShape() [1/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetBodyShape | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html) | *shape* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a78abdd806b1a9ad5268be5090f269698)SetBodyShape() [2/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetBodyShape | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html) | *shape* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac456c2d6781ee78fe49e9092696cee50)AddPhysics() [1/2]
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.AddPhysics | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | float | *mass*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *localCenterOfMass*, | |  |  | [PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html) | *body*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *initialGlobalVelocity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *angularGlobalVelocity*, | |  |  | [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) | *physicsMaterial*, | |  |  | bool | *isStatic*, | |  |  | int | *collisionGroupID* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a78168481ae10967b5738d1eeff9239ad)AddPhysics() [2/2]
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.AddPhysics | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | float | *mass*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *localCenterOfMass*, | |  |  | [PhysicsShape](class_tale_worlds_1_1_engine_1_1_physics_shape.html) | *body*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *initialVelocity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *angularVelocity*, | |  |  | [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) | *physicsMaterial*, | |  |  | bool | *isStatic*, | |  |  | int | *collisionGroupID* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a9512ef5d6bda486e5a2df1d772b6cf4a)SetVelocityLimits() [1/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetVelocityLimits | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | float | *maxLinearVelocity*, | |  |  | float | *maxAngularVelocity* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aabf3155cc148f695a5663b3b0e3ccd41)SetVelocityLimits() [2/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetVelocityLimits | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | float | *maxLinearVelocity*, | |  |  | float | *maxAngularVelocity* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6694ff31dc082ad624aee25882e3371c)SetMaxDepenetrationVelocity() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetMaxDepenetrationVelocity | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | float | *maxDepenetrationVelocity* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ab1562575099aab7261d8bec93a90466b)SetMaxDepenetrationVelocity() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetMaxDepenetrationVelocity | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | float | *maxDepenetrationVelocity* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a1ffcd2b6bf917129b2ea834e17c6f2c2)SetSolverIterationCounts() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetSolverIterationCounts | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | int | *positionIterationCount*, | |  |  | int | *velocityIterationCount* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#abf359c386cad4bd7fda3f35b16365c77)SetSolverIterationCounts() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetSolverIterationCounts | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | int | *positionIterationCount*, | |  |  | int | *velocityIterationCount* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a1400d8103ba55fd5d1874b009f7e4af1)ApplyLocalImpulseToDynamicBody() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ApplyLocalImpulseToDynamicBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *localPosition*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *impulse* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a502e8fdba2d929d9c92ae02f8f939874)ApplyLocalImpulseToDynamicBody() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ApplyLocalImpulseToDynamicBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *localPosition*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *impulse* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a24ef2b3d6fbe17ed814a946f8402b205)ApplyForceToDynamicBody() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ApplyForceToDynamicBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *force*, | |  |  | [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) | *forceMode* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a87b7155cd44e75c127da0a60975d0b1b)ApplyForceToDynamicBody() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ApplyForceToDynamicBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *force*, | |  |  | [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) | *forceMode* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6b28666af2986fbb22a9c152401d0bfa)ApplyGlobalForceAtLocalPosToDynamicBody() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ApplyGlobalForceAtLocalPosToDynamicBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *localPosition*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *globalForce*, | |  |  | [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) | *forceMode* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a71eb38c2f725198fe12049b31e3f0ac2)ApplyGlobalForceAtLocalPosToDynamicBody() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ApplyGlobalForceAtLocalPosToDynamicBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *localPosition*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *globalForce*, | |  |  | [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) | *forceMode* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a809195233ef96ee39b52b95aa863a2dc)ApplyTorqueToDynamicBody() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ApplyTorqueToDynamicBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *torque*, | |  |  | [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) | *forceMode* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#acb341c33aba8842dd531637699c77840)ApplyTorqueToDynamicBody() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ApplyTorqueToDynamicBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *torque*, | |  |  | [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) | *forceMode* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#abd257b3ec93f35dd26b370462ac251a5)ApplyLocalForceAtLocalPosToDynamicBody() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ApplyLocalForceAtLocalPosToDynamicBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *localPosition*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *localForce*, | |  |  | [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) | *forceMode* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#accb7339a677edd5f387fbe79961e72ce)ApplyLocalForceAtLocalPosToDynamicBody() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ApplyLocalForceAtLocalPosToDynamicBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *localPosition*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *localForce*, | |  |  | [ForceMode](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a0f82c186049b1d88654535d65fd995fa) | *forceMode* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#afd20251122ff393d31a84bcd443df319)ApplyAccelerationToDynamicBody() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ApplyAccelerationToDynamicBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *acceleration* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a2e80f0a8f2fd4cea7dbad71b7ab730c3)ApplyAccelerationToDynamicBody() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ApplyAccelerationToDynamicBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *acceleration* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aeb1fbc470da45368b23b4ae5ff8f057d)DisableDynamicBodySimulation() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.DisableDynamicBodySimulation | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a523ba1ea0c6c6a7228e24152f0058414)DisableDynamicBodySimulation() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.DisableDynamicBodySimulation | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a518caf609d7650a480b67a6214f98d60)DisableDynamicBodySimulationMT() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.DisableDynamicBodySimulationMT | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a4b5da46b68c7183badc01c6080b075dc)DisableDynamicBodySimulationMT() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.DisableDynamicBodySimulationMT | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a078da789878051e8d613bdae734efd8b)ConvertDynamicBodyToRayCast() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ConvertDynamicBodyToRayCast | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a802954d2ae74e8ec3f67bde20695b8b2)ConvertDynamicBodyToRayCast() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ConvertDynamicBodyToRayCast | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a60f4a6857362bb7154e3c6e0c7fd2e2a)SetPhysicsMoveToBatched() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetPhysicsMoveToBatched | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | bool | *value* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a94e06150c757ac835f62e85bc779b7eb)SetPhysicsMoveToBatched() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetPhysicsMoveToBatched | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | bool | *value* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a65e3ec090729e6da69beddb34b421b4f)EnableDynamicBody() [1/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.EnableDynamicBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ad8095ce92e541ef323e7391485c7f487)EnableDynamicBody() [2/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.EnableDynamicBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#adab70993af3d4df108ff8db9d261d210)GetMass() [1/2]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.GameEntityPhysicsExtensions.GetMass | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a8696921080a2f9e28e24344030c951cf)GetMass() [2/2]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.GameEntityPhysicsExtensions.GetMass | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#afe43a23c0a1e7c76a7c538420df380c9)SetMassAndUpdateInertiaAndCenterOfMass() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetMassAndUpdateInertiaAndCenterOfMass | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | float | *mass* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a394e9054819574b6eaa1a5d87a39551f)SetMassAndUpdateInertiaAndCenterOfMass() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetMassAndUpdateInertiaAndCenterOfMass | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | float | *mass* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a310acc530e7b7e20e6a4492d46c61b41)SetCenterOfMass() [1/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetCenterOfMass | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *localCenterOfMass* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a35f3290e8e1e23f69a3534aa4f5eca7e)SetCenterOfMass() [2/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetCenterOfMass | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *centerOfMass* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#adadadd08d372ff2cf29006d802db218f)GetMassSpaceInertia() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetMassSpaceInertia | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a7771303eba4a64d5ce9bb51a4c5cd88c)GetMassSpaceInertia() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetMassSpaceInertia | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aa827f750a30fcaa531acdeaa0ff193ab)GetMassSpaceInverseInertia() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetMassSpaceInverseInertia | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ab6ccee956de5b024f7785d32331e0232)GetMassSpaceInverseInertia() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetMassSpaceInverseInertia | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a94ecf56310b316ee99c5c0b950db9eb0)SetMassSpaceInertia() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetMassSpaceInertia | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *inertia* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ad054cb0b3a0b80ed6283aa2a58ed9145)SetMassSpaceInertia() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetMassSpaceInertia | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *inertia* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a448c0355b0d9247aefc9796676abdb1a)SetDamping() [1/2]
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetDamping | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | float | *linearDamping*, | |  |  | float | *angularDamping* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#add78684580906c1efd76c0b01b96b1cb)SetDamping() [2/2]
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetDamping | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | float | *linearDamping*, | |  |  | float | *angularDamping* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#ac4ed50370a0c47dd8214c59d10a008fe)SetDampingMT() [1/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetDampingMT | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | float | *linearDamping*, | |  |  | float | *angularDamping* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a4fec5e778542c18a048b117ceb9232a1)SetDampingMT() [2/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetDampingMT | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | float | *linearDamping*, | |  |  | float | *angularDamping* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6211bb0568ace8d62624617632397894)DisableGravity() [1/2]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.DisableGravity | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6e3e2462e9493195390815e719c43e3c)DisableGravity() [2/2]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.DisableGravity | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aa84bd9226055d9c73dd6c52105a3f1e4)IsGravityDisabled() [1/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.IsGravityDisabled | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6ec09f7bbd1469bb161e059b14d86028)IsGravityDisabled() [2/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.GameEntityPhysicsExtensions.IsGravityDisabled | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a087ea83833c07bc6fe25ab7e2b2ed869)GetLinearVelocity() [1/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetLinearVelocity | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#af4181146745c4f3ebd9cb1de7f837c90)GetLinearVelocity() [2/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetLinearVelocity | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a61a70b2ed5b753c3f597b8ba62e985e5)SetLinearVelocity() [1/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetLinearVelocity | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *newLinearVelocity* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a79c32234d8d84360377a8a17ae2059c0)SetLinearVelocity() [2/2]
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetLinearVelocity | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *newLinearVelocity* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a413af569abab6be401589a716513515b)GetLinearVelocityMT() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetLinearVelocityMT | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#afce9b9eb87169fa99eabc5c8d0219457)GetLinearVelocityMT() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetLinearVelocityMT | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a916e0cc58695c67302bf4a24ba870f1d)GetAngularVelocity() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetAngularVelocity | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a12b7f1b85342f4dc49c4ef93347a27e2)GetAngularVelocity() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetAngularVelocity | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aafa64b9122c05305ddfff4f3f264aebd)GetAngularVelocityMT() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetAngularVelocityMT | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a910c0690092d99e2aa374f19c7bae583)GetAngularVelocityMT() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetAngularVelocityMT | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a04bbb3b30222b2df572ddcd7a04814d7)SetAngularVelocity() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetAngularVelocity | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *newAngularVelocity* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a4696ffc27d2fde5861cfad8e373c187a)SetAngularVelocity() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.SetAngularVelocity | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *newAngularVelocity* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a000ff1183f87a8f329770874f955fa9a)GetPhysicsMinMax() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.GetPhysicsMinMax | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | bool | *includeChildren*, | |  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *bbmin*, | |  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *bbmax*, | |  |  | bool | *returnLocal* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a3227bc8d541cda7a811b518c4e1c99b7)GetPhysicsMinMax() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.GetPhysicsMinMax | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | bool | *includeChildren*, | |  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *bbmin*, | |  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *bbmax*, | |  |  | bool | *returnLocal* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#aeb2cf73b32f3fb4a4d42f0257f7366a0)GetLocalPhysicsBoundingBox() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetLocalPhysicsBoundingBox | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *gameEntity*, | |  |  | bool | *includeChildren* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#abad33bf76afd2d4b4ba9267009af4b0e)GetLocalPhysicsBoundingBox() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetLocalPhysicsBoundingBox | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | bool | *includeChildren* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a6d38bbc6bb520e2ae73ab5970ba2de8e)GetLinearVelocityAtGlobalPointForEntityWithDynamicBody() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetLinearVelocityAtGlobalPointForEntityWithDynamicBody | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *globalPoint* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a289492176e254df8e54be875d31d6626)GetLinearVelocityAtGlobalPointForEntityWithDynamicBody() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.GameEntityPhysicsExtensions.GetLinearVelocityAtGlobalPointForEntityWithDynamicBody | ( | this [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *globalPoint* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_game_entity_physics_extensions.html#a846f9ba22f71f94d1575181b9aa35691)ComputeVelocityDeltaFromImpulse()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.GameEntityPhysicsExtensions.ComputeVelocityDeltaFromImpulse | ( | this [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *impulseGlobal*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *impulsiveTorqueGlobal*, | |  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *deltaGlobalLinearVelocity*, | |  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *deltaGlobalAngularVelocity* ) | | static |


--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_agent.html ---

TaleWorlds.MountAndBlade.Agent Class ReferencesealedInherits DotNetObject, [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html), [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html), [TaleWorlds.MountAndBlade.IUsable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_usable.html), [TaleWorlds.MountAndBlade.IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html), and [TaleWorlds.Core.ITrackableBase](interface_tale_worlds_1_1_core_1_1_i_trackable_base.html).

|  |  |
| --- | --- |
| Classes | |
| class | [Hitter](class_tale_worlds_1_1_mount_and_blade_1_1_agent_1_1_hitter.html) |
| struct | [AgentLastHitInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_agent_1_1_agent_last_hit_info.html) |
| struct | [AgentPropertiesModifiers](struct_tale_worlds_1_1_mount_and_blade_1_1_agent_1_1_agent_properties_modifiers.html) |
| struct | [StackArray8Agent](struct_tale_worlds_1_1_mount_and_blade_1_1_agent_1_1_stack_array8_agent.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [ActionStage](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565) {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565a6adf97f83acf6453d4a6a4b1070f3754) = -1 ,     [AttackReady](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565a47782c51e54c1d5d407171cefbeadce4) ,     [AttackQuickReady](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565a39d0caff03f4c03e927040ede111e8de) ,     [AttackRelease](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565aa0befbff0899699c4cccfd7b0471a671) ,     [ReloadMidPhase](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565a27a0e6c62487c3480233a811d6affe0d) ,     [ReloadLastPhase](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565a626ca5895bc3b187a46e3cbff2e0b21b) ,     [Defend](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565a4aec8c62cef82bc80bd3192973dc8609) ,     [DefendParry](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565a64713c0ff0d6c1f98da4ba8feb76ee74) ,     [NumActionStages](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565a024f24a74a70b1ae57146dcdf77897d1)   } |
| enum | [AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a6adf97f83acf6453d4a6a4b1070f3754) = 0x00 ,     [GoToPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0ac8bf45d7adfe5621ba36f7c6480f5629) = 0x01 ,     [NoAttack](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0afd717fc56e019faf5bdeb3429d6eb17d) = 0x02 ,     [ConsiderRotation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a045c8240594651d69eb2f905b915268b) = 0x04 ,     [NeverSlowDown](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0aae23e7128fb008f13393b4997fcc3f04) = 0x08 ,     [DoNotRun](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a56874763114f4982e1b50d2a04a3e73a) = 0x10 ,     [GoWithoutMount](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0ae74913d186cf4cb6871bf16afd4e1891) = 0x20 ,     [RangerCanMoveForClearTarget](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0ae30959da14b9b7924835537496864019) = 0x80 ,     [InConversation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a5d088938cbe3262fe59d808517b12479) = 0x100 ,     [Crouch](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a497f1e75bc31c926497e67df9688f51d) = 0x200 ,     [Drag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0ab8a4d4c7e6bb7b5534b856ce7a9ccde0) = 0x400   } |
|  | Must sync with enum agent.h.enum Ai\_special\_mode\_flag. [More...](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) |
| enum | [AISpecialCombatModeFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997) {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997a6adf97f83acf6453d4a6a4b1070f3754) = 0x00 ,     [AttackEntity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997a831cadba3d4415118c7bf1f47747f75b) = 0x01 ,     [SurroundAttackEntity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997aaf0b270608beebf79cb8c510d950d1ca) = 0x02 ,     [IgnoreAmmoLimitForRangeCalculation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997a08187d747d5fb7a505c69e2e56a21061) = 0x400   } |
|  | Must sync with enum agent.h.enum Ai\_special\_mode\_flag. [More...](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997) |
| enum | [AIStateFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995) : uint {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995a6adf97f83acf6453d4a6a4b1070f3754) = 0x000 ,     [Cautious](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995afa0f09d0cb17b38fb7c17b96ee91cfea) = 0x001 ,     [PatrollingCautious](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995ad3ad499cb6d96fa07d0600b97e5b2270) = 0x002 ,     [Alarmed](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995a753e5f4ce8afd604ea85a1b95ddb13f2) = 0x003 ,     [Paused](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995ae99180abf47a8b3a856e0bcb2656990a) = 0x008 ,     [UseObjectMoving](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995a73f50e604d1d38868d1a5427f0451438) = 0x010 ,     [UseObjectUsing](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995aad5acd04b2be6a1c5f5366211c5c5404) = 0x020 ,     [UseObjectWaiting](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995a78035c23544eb41d4f19e7dd603c45e4) = 0x040 ,     [ColumnwiseFollow](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995a817a937206807e892125a8ffe17eb562) = 0x100 ,     [AlarmStateMask](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995a3cbe5afbdfc23da777a9de759101a8fa) = 0x003   } |
|  | Flags for [AI](namespace_tale_worlds_1_1_mount_and_blade_1_1_a_i.html) states of agents. [More...](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995) |
| enum | [WatchState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7aa6fe93228ddfb752808bcb9fc48891) {     [Patrolling](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7aa6fe93228ddfb752808bcb9fc48891aa97f35cf92005d4f3a99bb9c18992e6f) ,     [Cautious](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7aa6fe93228ddfb752808bcb9fc48891afa0f09d0cb17b38fb7c17b96ee91cfea) ,     [Alarmed](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7aa6fe93228ddfb752808bcb9fc48891a753e5f4ce8afd604ea85a1b95ddb13f2)   } |
| enum | [MortalityState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd592cc5cf557afcc7eaef3ae20a7eae) {     [Mortal](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd592cc5cf557afcc7eaef3ae20a7eaeaad759615d28882a52f41a75c1818ab5b) ,     [Invulnerable](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd592cc5cf557afcc7eaef3ae20a7eaea2f2d4cc4e9a1e88c7663869f1e0b049b) ,     [Immortal](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd592cc5cf557afcc7eaef3ae20a7eaea16b98d0e33bf9444817b6cf56a39cf58)   } |
| enum | [CreationType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938) {     [Invalid](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938a4bbb8f967da6d1a610596d7257179c2b) ,     [FromRoster](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938a91d387635d8dc6b80ad07d2b02b517ad) ,     [FromHorseObj](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938a0d33f4958f470785ed03c5577b730048) ,     [FromCharacterObj](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938a8eb64757927cc58d04b53314d52ed723)   } |
|  | Shows the creation type of the agent. [More...](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938) |
| enum | [EventControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429) : uint {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [Dismount](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429af7bf77579f3ef4525685e62930eedf13) = 0x00000001 ,     [Mount](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429aeace16d66cdd93ad876c620db7456077) = 0x00000002 ,     [Rear](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429ac3e5b78d161cdc6f1f24fc7ef16d4795) = 0x00000004 ,     [Jump](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a101f693f72287a2819a364f64ca1c0ed) = 0x00000008 ,     [Wield0](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a2a2be7c67905a2a55111c17aa228ced3) = 0x00000010 ,     [Wield1](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429aedb785a3a4889fda8ff2c1a78428da3f) = 0x00000020 ,     [Wield2](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a0139f79ae7c567afdf599184c37150bb) = 0x00000040 ,     [Wield3](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429aaf6c029adbb1b603c059a8185de6d769) = 0x00000080 ,     [Sheath0](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429abb6ee2d82b9dce70621af4767984ba3b) = 0x00000100 ,     [Sheath1](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a4bb4402c400eccb35f9b3143ce54986e) = 0x00000200 ,     [ToggleAlternativeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a1b5fd207ce59661072f01af68b5816bf) = 0x00000400 ,     [Walk](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a7a16a854f32231a8df9326136b09ee62) = 0x00000800 ,     [Run](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429ac5301693c4e792bcd5a479ef38fb8f8d) = 0x00001000 ,     [Crouch](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a497f1e75bc31c926497e67df9688f51d) = 0x00002000 ,     [Stand](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429af5e531e3638cf8a722a9cd26831e108f) = 0x00004000 ,     [Kick](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a3e07960fcc45408894cf1402257bd9fd) = 0x00008000 ,     [DoubleTapToDirectionUp](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a7c37812e1ea58060650987d2ce6f70f0) = 0x00010000 ,     [DoubleTapToDirectionDown](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a62c8087c6ad938524480bcf23100020b) = 0x00020000 ,     [DoubleTapToDirectionLeft](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a8e32cc36ebcd57e506657fe8c37ab4ef) = 0x00030000 ,     [DoubleTapToDirectionRight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a44c8d465198ee53085c1374e864c2757) = 0x00040000 ,     [DoubleTapToDirectionMask](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429a7d6465a2d61cfc4bc3b0f36c6451d38e) = 0x00070000   } |
| enum | [FacialAnimChannel](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5262a134add2c2f514741a32df8efc52) {     [High](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5262a134add2c2f514741a32df8efc52a655d20c1ca69519ca647684edbb2db35) = 0 ,     [Mid](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5262a134add2c2f514741a32df8efc52a55c6b09cbca39ef0cdb728eb112a5049) = 1 ,     [Low](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5262a134add2c2f514741a32df8efc52a28d0edd045e05cf5af64e35ae0c4c6ef) = 2 ,     [num\_facial\_anim\_channels](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5262a134add2c2f514741a32df8efc52a9c95ddf1689415c82ede0a6b32f1b401) = 3   } |
| enum | [ActionCodeType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016) {     [Other](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a6311ae17c1ee52b36e68aaf4ad066387) ,     [DefendFist](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a22e284c715dca74471e8affe007f1d20) ,     [DefendShield](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a7510dfcb1e6ad2ed5198d5da66ad596a) ,     [DefendForward2h](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016ae0757cc53e79eb96dd6993d272299f57) ,     [DefendUp2h](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a52d12b3b579cfb0dd7c140c7f57718c2) ,     [DefendRight2h](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a7d52cd24ff01ced7a2a03513419adc28) ,     [DefendLeft2h](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a93bd2f3fe7537631361b7e06fd8d9945) ,     [DefendForward1h](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a78facc5e69b044974afecc0d5ecd23b8) ,     [DefendUp1h](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a20f35b91a9b533e940703a32a1d47921) ,     [DefendRight1h](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a6d710550e043f1426662afcf1aaf4896) ,     [DefendLeft1h](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016ad918d75e3e05b87aee0e124285d6b722) ,     [DefendForwardStaff](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a7aab6fe2f0ca57610f130a21b5b77780) ,     [DefendUpStaff](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a21bd22fc78661534ae190d52512efb8e) ,     [DefendRightStaff](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a77bc591d11b709d48231c9e7915340db) ,     [DefendLeftStaff](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016ac36e32ed0c0ceb099a105be0e2c73da3) ,     [ReadyRanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a7f557c591d8bf76702566a7e85f4bc8c) ,     [ReleaseRanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016aed476537faee77b2c5493e14f779a01d) ,     [ReleaseThrowing](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016abbaaf16daead77579606d5363e229033) ,     [Reload](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a4d1c8263ba1036754f8db14a98f9f006) ,     [ReadyMelee](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016afcc8bb2965ba1f1131dd886585ae2a49) ,     [ReleaseMelee](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a824dfd8f634fba9e647be284e5f815cf) ,     [ParriedMelee](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016aceea1d0edaf951f653ccef230cd050f8) ,     [BlockedMelee](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a8b3fc513934b02fcd6d19a94efec2b67) ,     [Fall](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a58fa788345ab5ac21c2cef38907d4580) ,     [JumpStart](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016ae684f57e0186ad20a5f8583adb5d1643) ,     [Jump](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a101f693f72287a2819a364f64ca1c0ed) ,     [JumpEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a5330a768f7abd339f9e3f02ebcb12005) ,     [JumpEndHard](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a17c58d59f819de9ddd6cd5e296e87212) ,     [Kick](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a3e07960fcc45408894cf1402257bd9fd) ,     [KickContinue](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016adcf71b939ef114d3bcb2ff3f3a66bd00) ,     [KickHit](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a657c1cabf893936045829b0ebf4c8a94) ,     [WeaponBash](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a6e018a3fbb09c3108bd8b1a8546681e7) ,     [PassiveUsage](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a03156f527d6e9a148fe986fbe96cda81) ,     [EquipUnequip](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a5dbce79f724b5d33a4e7dce721e34b9c) ,     [SwitchAlternative](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016aa0901b5123b1ca4c74fabc14bcecdadb) ,     [Idle](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016ae599161956d626eda4cb0a5ffb85271c) ,     [Guard](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a57cc9b210b0e3ff7b28013cec3d36acf) ,     [Mount](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016aeace16d66cdd93ad876c620db7456077) ,     [Dismount](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016af7bf77579f3ef4525685e62930eedf13) ,     [Dash](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a3663598d5c5858b5a6040b1bbed4f187) ,     [MountQuickStop](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016abb541a54d3c8aa3a5298f16c275d9bc9) ,     [HitObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a5e73d7babacace42682a9ceea1a3e8fb) ,     [Sit](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a0ba672e3acbda6fa67c1f7b32f139979) ,     [SitOnTheFloor](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a4648fee44e1ef75391193f3cd7c05444) ,     [SitOnAThrone](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016ae9a51b9145983c9ce2d95df0787b7551) ,     [LadderRaise](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a0a382c58ef3f92ff113be995385420de) ,     [LadderRaiseEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a5f010c86e48a249ce4b4074761040d4f) ,     [Rear](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016ac3e5b78d161cdc6f1f24fc7ef16d4795) ,     [StrikeLight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a13bd203c5c94568c8f2d3182d656521d) ,     [StrikeMedium](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a041a48c834bf6543815d288cd73c9ebe) ,     [StrikeHeavy](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a9b3d6b1c4b7d1918b224c3bd7db40981) ,     [StrikeKnockBack](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016ac5db68e35da2f19a079475539202b3da) ,     [MountStrike](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016ad18e3400aca586a96aca239e2757bcf9) ,     [Count](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016ae93f994f01c537c4e2f7d8528c3eb5e9) ,     [StrikeBegin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a547a036002c8aa6590d2fff8f6dd9c6a) = StrikeLight ,     [StrikeEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a731ca9a2dc4a70ca5d12a164fcf36348) = StrikeKnockBack + 1 ,     [DefendAllBegin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016ac325db31aff7feb28bf95fff9c014ac2) = DefendFist ,     [DefendAllEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a6844b38f0f8de952333fccc290989ccd) = DefendLeftStaff + 1 ,     [AttackMeleeAllBegin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a37e8ca2e2b0863ce3c5a517b2b8abec0) = ReadyMelee ,     [AttackMeleeAllEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a81dfb529ea3c10cedc8551c18348780e) = BlockedMelee + 1 ,     [AttackMeleeAndRangedAllBegin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a3959f6f28a89180eed257921429fd0ea) = ReadyRanged ,     [AttackMeleeAndRangedAllEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a8b8571f46ae7c30a6a9eed9e918610dc) = BlockedMelee + 1 ,     [CombatAllBegin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a4474e7453d0de807b20c48f814b2e538) = DefendAllBegin ,     [CombatAllEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016af2a4733f6003be419e51980da3af3142) = AttackMeleeAllEnd ,     [JumpAllBegin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a94a73507d1631e140a28eb194842a7bf) = JumpStart ,     [JumpAllEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a0d12021d1e0574748a1be3e8446ddd0a) = JumpEndHard + 1 ,     [FallAllBegin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a602aae4c40feaf0fee0fc333e6b99092) = Jump ,     [FallAllEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a657ab9115ded5dc64027c8948ffe6054) = JumpEndHard + 1 ,     [KickAllBegin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a81a032dd044b1e23917c048ecfa1a0ca) = Kick ,     [KickAllEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016acf14b6c81ca17e936f43b4b22cb7be9c) = KickHit + 1 ,     [AlternativeAttackAllBegin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a685da6b3123cafffa26d1af669641b5e) = KickAllBegin ,     [AlternativeAttackAllEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016a583caf408af6bece8b0b5a4e73fedaa8) = WeaponBash + 1   } |
| enum | [GuardMode](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e258f837e094c8fd60eaf08c57e1a61) {     [MarkForDeletion](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e258f837e094c8fd60eaf08c57e1a61a9c223a08096a810d31119d82e2c2d57d) = -2 ,     [None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e258f837e094c8fd60eaf08c57e1a61a6adf97f83acf6453d4a6a4b1070f3754) = -1 ,     [Up](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e258f837e094c8fd60eaf08c57e1a61a258f49887ef8d14ac268c92b02503aaa) = 0 ,     [Down](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e258f837e094c8fd60eaf08c57e1a61a08a38277b0309070706f6652eeae9a53) ,     [Left](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e258f837e094c8fd60eaf08c57e1a61a945d5e233cf7d6240f6b783b36a374ff) ,     [Right](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e258f837e094c8fd60eaf08c57e1a61a92b09c7c48c520c3c55e497875da437c)   } |
| enum | [HandIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6de) {     [MainHand](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6dea1f9cdfca2d19bbc92349db7eb1544434) = 0 ,     [OffHand](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6dea2cc539207caf1a7e1e986b92e4462d7c) = 1   } |
| enum | [KillInfo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7) : sbyte {     [Invalid](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a4bbb8f967da6d1a610596d7257179c2b) = -1 ,     [Headshot](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a06fb12dd13ddd25b7495490bb6409f5e) ,     [CouchedLance](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a6518bf6c5d593007e38a828efb3d8065) ,     [Punch](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a140685b8f5c6b18ddb68c087c31ea975) ,     [MountHit](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a2dc981e555e487de12e442b9f24878a3) ,     [Bow](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a48fce5d02f6935e50f256d5dedac4437) ,     [Crossbow](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7aecd03afff3ba51979312a1114f791d13) ,     [ThrowingAxe](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7afd86a0082906e4236fe1d46ce01069d1) ,     [ThrowingKnife](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a58f5ddfdca949d45ecf77e1833540c43) ,     [Javelin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a640266a6d25dc6a8f8e723691dab6df9) ,     [Stone](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a2ff4ab1d379832d3edee28194fb4e7b2) ,     [Pistol](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a524b64722661b303ed5754c492c0ef14) ,     [Musket](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7add60bcc7f465fe1cbcc7f2dade05f485) ,     [OneHandedSword](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7addc9617f6b6d3715fb3525b231a7637d) ,     [TwoHandedSword](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a46446698dd35bf1d3ed41923b86cffb9) ,     [OneHandedAxe](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a52f8aff907ef976ccaa96989be3c60d9) ,     [TwoHandedAxe](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a62a1fbeeba4ab6f5d304096872158032) ,     [Mace](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a17d2c299e4d02f7b375eec3f057a5b50) ,     [Spear](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a1b84a9aa056c2d10119875c2508983ec) ,     [Morningstar](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a064b1dd62886517f23389d1fe8e63e49) ,     [Maul](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a397adb82583fc41013f93348d0737461) ,     [Backstabbed](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a3db22ff09c460bbee6b343dc5eba9ff9) ,     [Gravity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a8a88c39cef668fb55f188af09665bd40) ,     [ShieldBash](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7ae9bf37890b564df11c17ddb2f09169dd) ,     [WeaponBash](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a6e018a3fbb09c3108bd8b1a8546681e7) ,     [Kick](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a3e07960fcc45408894cf1402257bd9fd) ,     [TeamSwitch](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7ae8e9f11c2e7a87307996dc46e88acc61)   } |
| enum | [MovementBehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aae8de26b7a3c90f2606b38ac9e062cac) {     [Engaged](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aae8de26b7a3c90f2606b38ac9e062cacacc8ff50881a92c6da502af83e5736dfa) ,     [Idle](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aae8de26b7a3c90f2606b38ac9e062cacae599161956d626eda4cb0a5ffb85271c) ,     [Flee](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aae8de26b7a3c90f2606b38ac9e062caca20a8b1e6e473f9f1b219973fb365af44)   } |
| enum | [MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) : uint {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [Forward](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a67d2f6740a8eaebf4d5c6f79be8da481) = 0x00000001 ,     [Backward](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797ab3263eb38f8903efc271cc7a760da510) = 0x00000002 ,     [StrafeRight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a9b4d85f3d87b8e67d74e087541ed3743) = 0x00000004 ,     [StrafeLeft](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a619850cebb4607f51de326bd78c27429) = 0x00000008 ,     [TurnRight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a40dfa38b645f971c52766aa367a474fd) = 0x00000010 ,     [TurnLeft](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a8240c76a9676d55f5d5bfeb9a6fc7028) = 0x00000020 ,     [AttackLeft](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a94f88dfe27412fc77cc8f0cf55f4e22b) = 0x00000040 ,     [AttackRight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a0b06ea9d4803611f935dcb945bfca9b7) = 0x00000080 ,     [AttackUp](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a5fa7f29151be9cf361c259e4eda6f349) = 0x00000100 ,     [AttackDown](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a5b1de6c718c8fe262a170389c65d72d9) = 0x00000200 ,     [DefendLeft](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797aa0803587e95c2e3d187f1b6a25b20a7d) = 0x00000400 ,     [DefendRight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a43afb5dd92f80d19643cedb2c9eac25e) = 0x00000800 ,     [DefendUp](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a084fab6b1aac63f139b9ba1cf38ba3f1) = 0x00001000 ,     [DefendDown](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a96715e6d1ab63979043ae5c497cd4924) = 0x00002000 ,     [DefendAuto](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a378a9fddf352ba43bba5280dc02ab58d) = 0x00004000 ,     [DefendBlock](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797ab900965e9c594f54fa02b0d9fe58c203) = 0x00008000 ,     [Action](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a004bf6c9a40003140292e97330236c53) = 0x00010000 ,     [AttackMask](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797ae7758f1d060dcb15c5914e0b89c48988) = AttackLeft | AttackRight | AttackUp | AttackDown ,     [DefendMask](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a30c3f76fc39cc99b340cbadc4f5ec704) = DefendLeft | DefendRight | DefendUp | DefendDown | DefendAuto ,     [DefendDirMask](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797a592182317cbb373125de14769a5eaf75) = DefendLeft | DefendRight | DefendUp | DefendDown ,     [MoveMask](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797abbcb0741ee54183dd91df77caff007ec) = Forward | Backward | StrafeRight | StrafeLeft | TurnRight | TurnLeft ,     [MaxValue](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797aacbf6a529c5ebfe1089dd9d99cc6277b) = Action | (Action - 1)   } |
| enum | [UnderAttackType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6bf6f204fa49aaa08ddab2434120d27) {     [NotUnderAttack](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6bf6f204fa49aaa08ddab2434120d27a519070b9df2d202975209d95eaea20b6) ,     [UnderMeleeAttack](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6bf6f204fa49aaa08ddab2434120d27a8fa675d615c40192a37c6ba2e023e183) ,     [UnderRangedAttack](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6bf6f204fa49aaa08ddab2434120d27a5c11ab7ef6dfc1c4d1aa13d73ac353af)   } |
| enum | [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aa6adf97f83acf6453d4a6a4b1070f3754) = -1 ,     [AttackUp](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aa5fa7f29151be9cf361c259e4eda6f349) = 0 ,     [AttackDown](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aa5b1de6c718c8fe262a170389c65d72d9) = 1 ,     [AttackLeft](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aa94f88dfe27412fc77cc8f0cf55f4e22b) = 2 ,     [AttackRight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aa0b06ea9d4803611f935dcb945bfca9b7) = 3 ,     [AttackBegin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aad834f5dc96e21a7b0b98f5ef43961d2c) = 0 ,     [AttackEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aae70ca354484f126fb9b4d632adb3508e) = 4 ,     [DefendUp](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aa084fab6b1aac63f139b9ba1cf38ba3f1) = 4 ,     [DefendDown](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aa96715e6d1ab63979043ae5c497cd4924) = 5 ,     [DefendLeft](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aaa0803587e95c2e3d187f1b6a25b20a7d) = 6 ,     [DefendRight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aa43afb5dd92f80d19643cedb2c9eac25e) = 7 ,     [DefendBegin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aae9c87d070a522c58ee9f0ba8872cb08e) = 4 ,     [DefendAny](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aaa15233d884f393d1b1357d29cc3a63d0) = 8 ,     [DefendEnd](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aa4bfffa2d92d5be9077c1c12c128d90a1) = 9 ,     [AttackAny](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922aa589dd8de08429e3d0ae8570fa463e9b8) = 9   } |
| enum | [WeaponWieldActionType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835e) {     [WithAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835ea7671f6d74e057fdfafe2928bf6b7b27b) = 0 ,     [Instant](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835ea54828f327f31abd59f2f459c0247756d) = 1 ,     [InstantAfterPickUp](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835eafb04605c34b201af035c2ff8b5f61967) = 2 ,     [WithAnimationUninterruptible](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835eaf214b37f35c0006b3d95ab4999fe2bfe) = 3   } |
| enum | [StopUsingGameObjectFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713) : byte {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713a6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [AutoAttachAfterStoppingUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713a967948a82d8f55fae4e9c5ff9cfae7bc) = 0x01 ,     [DoNotWieldWeaponAfterStoppingUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713ae3ac38b730c4eea48c12c64602888024) = 0x02 ,     [DefendAfterStoppingUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713ae1bb9dea85fd8cc4a2ef0fdc3bbfc19b) = 0x04   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnAgentHealthChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a36ccd47292c6896ed280dbc5ea386080) (Agent agent, float oldHealth, float newHealth) |
| delegate void | [OnMountHealthChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af84128460d915acb53c2460c250ac909) (Agent agent, Agent mount, float oldHealth, float newHealth) |
| delegate void | [OnMainAgentWieldedItemChangeDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad987ba74a5b3c9a503c88091d2cecf0c) () |
| bool | [GetHasOnAiInputSetCallback](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a666e7d0dbb6061868634cb33444c3529) () |
| void | [SetHasOnAiInputSetCallback](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae093a8b2c913ff99da6a07ab224e8fcf) (bool value) |
| float | [GetMissileRangeWithHeightDifferenceAux](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a741394ee20c7e5d03964fdcffc69c8ea) (float targetZ) |
| string | [GetSoundAndCollisionInfoClassName](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab3df879b37aa2163281cb6d5c6fd6abb) () |
| void | [UpdateAgentStats](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a997ca2efb2281af730965fce55eb0ec8) () |
| float | [GetWeaponInaccuracy](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aeaadc52524004421fd79e2dab2c4f2ed) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) weaponSlotIndex, int weaponUsageIndex) |
| float | [DebugGetHealth](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa13fb68ec376716cbe8cac14171a375a) () |
| void | [SetTargetPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0cf381f211d2fb4ba1db6e0a1f624027) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) value) |
| void | [SetTargetZ](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a545e7633acdbee2b5a834b4b822a7585) (float targetZ) |
| void | [SetTargetUp](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1af1a6704b86f6a54f3f6242fd02b152) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetUp) |
| void | [SetCanLeadFormationsRemotely](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a11b15afbee1cddaad444c5db6979af05) (bool value) |
|  | If set, the agent can lead a formation when it is set as the formation's captain remotely. That means the agent does not need to be in the same formation which it is assigned as the captain. By default General agent and the player can have this property set. |
| void | [SetAveragePingInMilliseconds](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a958a650d82dbe6b181ea0f575ccae011) (double averagePingInMilliseconds) |
| void | [SetTargetPositionAndDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a67f2730f422ba396c92e2b25f9d45c8b) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) targetPosition, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetDirection) |
| void | [AddAcceleration](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aad38749faea7cb6254876887f3f3b706) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) acceleration) |
| void | [SetWeaponGuard](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab2abccef274cd1c35b8489a6e5c906ea) ([UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) direction) |
| void | [SetWatchState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a50ef37144e7700f2857b11d1c08c71d6) ([WatchState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7aa6fe93228ddfb752808bcb9fc48891) watchState) |
| bool | [IsAlarmStateNormal](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3f8117d69f30ae9125674e983d9d95ea) () |
| bool | [IsCautious](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a989ae7c8c95441f909ce0dd34146cb44) () |
| bool | [IsPatrollingCautious](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae18078b09efb0d3c42cfdec145d723bb) () |
| bool | [IsAlarmed](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adc0b4d54853e4830230e3c6751a26f2c) () |
| bool | [SetAlarmState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af3cb25fd568eb9d98945ab54bc07d7d6) ([AIStateFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995) alarmStateFlag) |
| void | [SetTargetFormationIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5fc9050be6c4bb26d6602aecd920133c) (int targetFormationIndex) |
| void | [StartRagdollAsCorpse](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa03f4848aa03d711eda2c47a8e6d31cb) () |
| void | [EndRagdollAsCorpse](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acbbbbbb206238ae5dbd74e0af9e852a6) () |
| bool | [IsAddedAsCorpse](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4a1bb8657e13aac2476a61ab1c1a23e1) () |
| void | [AddAsCorpse](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aee0594b02b222529f1a72e3867a53d44) () |
| void | [SetOverridenStrikeAndDeathAction](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a27fdcbea669627308b69aceba76534e8) (in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) strikeAction, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) deathAction) |
| void | [ApplyForceOnRagdoll](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0025c49184af7e209c89035c80254365) ([sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) boneIndex, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) force) |
| void | [SetVelocityLimitsOnRagdoll](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7c71e5a3b58a14c2c133251857dbc27b) (float linearVelocityLimit, float angularVelocityLimit) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetAILastSuspiciousPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad18e2628ed773d8057dfd8dbf3a2c33b) () |
| void | [SetAILastSuspiciousPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2da091ca11fb36c7097d53807d5e6aad) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) lastSuspiciousPosition, bool checkNavMeshForCorrection) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetAIMoveDestination](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae64bcdac326ab0d35ce49df2a7dfcc68) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [FindLongestDirectMoveToPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af7d6bac57f9a5a03a55ee07c8361e77c) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) targetPosition, bool checkBoundaries, bool checkFriendlyAgents, out bool isCollidedWithAgent) |
| float | [GetAIMoveStartTolerance](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abfaf21cb49c6fdde171bed3c7ff01cd5) () |
| float | [GetAIMoveStopTolerance](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1a12894b7c03ca54ac639fa0ff6f50b2) () |
| bool | [IsAIAtMoveDestination](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7ef60245195ed3735787f7088a711b6a) () |
| void | [SetFormationBanner](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5667047207aa14bd26fb4d45a2f89e5e) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) banner) |
| void | [SetIsAIPaused](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a99a3273a37fe3cf071858d9c80458727) (bool isPaused) |
| void | [ResetEnemyCaches](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa5b3f392f3f08a241bd5000dcad84308) () |
| void | [SetTargetPositionSynched](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa60c8c0017cbdb039df3770713e015a3) (ref [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) targetPosition) |
| void | [SetTargetPositionAndDirectionSynched](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aaf0ff7af7106149339574861c6660fa4) (ref [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) targetPosition, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetDirection) |
| void | [SetBodyArmorMaterialType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a73c5aec27098ede8cbec716fcfa736d8) ([ArmorComponent.ArmorMaterialTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99) bodyArmorMaterialType) |
| void | [SetUsedGameObjectForClient](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4199468dbb26049f6fc1c78e6aadc44a) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usedObject) |
| void | [SetTeam](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae4d71697e3c5cd92634d96aa44aa8ddb) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a13bb441adc4062eddd4b9548e43b5db5) team, bool sync) |
| void | [SetClothingColor1](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4eff61cb370192db1c7915bd37b3235a) (uint color) |
| void | [SetClothingColor2](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3ca6dffe0f61f68762a85094285edddf) (uint color) |
| void | [SetWieldedItemIndexAsClient](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af0403a6beec3df34166b0b1a743d2475) ([HandIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6de) handIndex, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equipmentIndex, bool isWieldedInstantly, bool isWieldedOnSpawn, int mainHandCurrentUsageIndex) |
| void | [SetPreciseRangedAimingEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab7c862f6adfd447cde4d51322c1ff95f) (bool set) |
| void | [SetAsConversationAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71023a9b0e08bf05349b67ec1287c464) (bool set) |
| void | [SetCrouchMode](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0b8e797732b2e5b47c113f6a06287c5a) (bool set) |
| void | [SetWeaponAmountInSlot](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acf9f9a87522a7314c0448bfbd5506074) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equipmentSlot, short amount, bool enforcePrimaryItem) |
|  | Sets the amount of weapons in slot and updates the weapon meshes. |
| void | [SetDraggingMode](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa5d0b01387b44d908b98cdec582a2de8) (bool set) |
| void | [SetWeaponAmmoAsClient](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9004b9c3ba9082c1601cc8cfb4fa2f06) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equipmentIndex, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) ammoEquipmentIndex, short ammo) |
| void | [SetWeaponReloadPhaseAsClient](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a69079eecf599ee6dbe2603f983dea843) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equipmentIndex, short reloadState) |
| void | [SetReloadAmmoInSlot](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab394e917cfdba1ddc7d1e2c5e1abda90) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equipmentIndex, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) ammoSlotIndex, short reloadedAmmo) |
| void | [SetUsageIndexOfWeaponInSlotAsClient](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7b146434951b8614143028e9463cf707) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, int usageIndex) |
| void | [SetRandomizeColors](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae7e5995c4c47cc058a32aecc02f4d333) (bool shouldRandomize) |
| void | [SetFormationFrameDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8f586847cd2ac2ba6a4516877f8519da) () |
| void | [SetFormationFrameEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6ba986b0992efab247fc4c18c735411d) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) positionVelocity, float formationDirectionEnforcingFactor) |
| void | [SetShouldCatchUpWithFormation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a247b71cf45821133fda4970275ab1dda) (bool value) |
| void | [SetFormationIntegrityData](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a31b470be0c48d437dcbd75d8e5272eb1) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) currentFormationDirection, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) averageVelocityOfCloseAgents, float averageMaxUnlimitedSpeedOfCloseAgents, float deviationOfPositions, bool shouldKeepWithFormationInsteadOfMovingToAgent) |
| bool | [IsCrouchingAllowed](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a83b77c8da9a07847e1455a3f5ac5c693) () |
| void | [SetCurrentActionProgress](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6a06b5477d9769bc2118c9386264570d) (int channelNo, float progress) |
| void | [SetCurrentActionSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acfc7c127bfdd95d62ae69e731b42b73d) (int channelNo, float speed) |
| bool | [SetActionChannel](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6f0581695bd0e8ca8fae78862c762bdd) (int channelNo, in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndexCache, bool ignorePriority=false, [AnimFlags](namespace_tale_worlds_1_1_mount_and_blade.html#aee58182af722eaf22dec720de2cc5818) additionalFlags=0, float blendWithNextActionFactor=0.0f, float actionSpeed=1.0f, float blendInPeriod=-0.2f, float blendOutPeriodToNoAnim=0.4f, float startProgress=0.0f, bool useLinearSmoothing=false, float blendOutPeriod=-0.2f, int actionShift=0, bool forceFaceMorphRestart=true) |
| void | [SetAttackState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3ab0c5a9ce157995dec8c795d1da5647) (int attackState) |
| void | [SetAIBehaviorParams](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1626fc1b3621802407b19d84129c658e) ([HumanAIComponent.AISimpleBehaviorKind](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4) behavior, float y1, float x2, float y2, float x3, float y3) |
| void | [SetAllBehaviorParams](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab5c704411537cae6c8f1f3e676b2efb5) ([HumanAIComponent.BehaviorValues](struct_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component_1_1_behavior_values.html)[] behaviorParams) |
| void | [SetMovementDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2f86d4c29e5976fe9fed75ec482f09ab) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction) |
| void | [SetScriptedFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7d05e47996cc56b78a87e83b81f52500) ([AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) flags) |
| void | [SetScriptedCombatFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a236e2ce6925bcc1add9c6207abe1d896) ([AISpecialCombatModeFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997) flags) |
| void | [SetScriptedPositionAndDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a00030970dcc333117c53d47cfa27dde7) (ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) scriptedPosition, float scriptedDirection, bool addHumanLikeDelay, [AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) additionalFlags=[AIScriptedFrameFlags.None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a6adf97f83acf6453d4a6a4b1070f3754)) |
| void | [SetScriptedPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a00a95c095bdc1e7141898ba546798170) (ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, bool addHumanLikeDelay, [AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) additionalFlags=[AIScriptedFrameFlags.None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a6adf97f83acf6453d4a6a4b1070f3754)) |
| void | [SetScriptedTargetEntity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae51f0723a19f32d1449afb112ac611ee) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) target, [AISpecialCombatModeFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997) additionalFlags=[AISpecialCombatModeFlags.None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997a6adf97f83acf6453d4a6a4b1070f3754), bool ignoreIfAlreadyAttacking=false) |
| void | [SetAgentExcludeStateForFaceGroupId](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a78f20e5704b2dc77c1f679ab456b7a0d) (int faceGroupId, bool isExcluded) |
| void | [SetLookAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade2c1fc0612f12c08527cbff3985ff06) (Agent agent) |
| void | [SetInteractionAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8de385419aa70b518604c36eecf7d3d0) (Agent agent) |
| void | [SetLookToPointOfInterest](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af505898446c07486a5bfe053a40f882c) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) point) |
| void | [SetAgentFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7a6cf64f8122194c2ae71db07fa7192e) ([AgentFlag](namespace_tale_worlds_1_1_core.html#a4eadec2c483252505ae0d0ab98de39fe) agentFlags) |
| void | [SetSelectedMountIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a567160dfb81e5a934dc8bea58b5fe1eb) (int mountIndex) |
| int | [GetFiringOrder](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0c86369b82e5074eb691f8c487733d3f) () |
| int | [GetRidingOrder](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a949230946ba1bd5d378a687fe09dac61) () |
| int | [GetSelectedMountIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a635731ab06eefbf0d01aacd473eb273a) () |
| int | [GetTargetFormationIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a09df26b15afbf31fa73bf6f353e95914) () |
| void | [SetFiringOrder](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa8da52f1023b1339626627880b4a1abd) ([FiringOrder.RangedWeaponUsageOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_firing_order.html#a5ca98092070b61d7f2b7f747b225e729) order) |
| void | [SetRidingOrder](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a517dfe773b49de56cf4b4dff1e048675) ([RidingOrder.RidingOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_riding_order.html#a310553d7b0a9100022168f5e2bec6cac) order) |
| void | [SetAgentFacialAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac4194ee0dbf69104f33a344dbc22e9fc) ([FacialAnimChannel](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5262a134add2c2f514741a32df8efc52) channel, string animationName, bool loop) |
| bool | [SetHandInverseKinematicsFrame](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a96661987f337a0dc596178aeea539bfb) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) leftGlobalFrame, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) rightGlobalFrame) |
| void | [SetNativeFormationNo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a35d2200cd4732ff33b68d8bf3b654b46) (int formationNo) |
| void | [SetDirectionChangeTendency](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8111f3c73eb1fd67f7191bf8a1ddd123) (float tendency) |
| float | [GetBattleImportance](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad8ca76863c7c39a6baa2be18a145bcf2) () |
| [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) | [GetTraitsMask](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ada322002a94e7621db0cafb19d3fc967) () |
|  | Returns a mask representing filterable traits of the agent which can dynamically change during the mission. For instance an agent having its shield broken will no longer return the shield bit. |
| void | [SetSynchedPrefabComponentVisibility](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2e424c7e130ff6e0447c8617df9076ac) (int componentIndex, bool visibility) |
| void | [SetActionSet](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a41f27b0b5d332b79b032b27cc672a7a1) (ref [AnimationSystemData](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html) animationSystemData) |
| void | [SetColumnwiseFollowAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab51fc4889084686b8995a2fd2bce809d) (Agent followAgent, ref [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) followPosition) |
| void | [SetHandInverseKinematicsFrameForMissionObjectUsage](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1d30976ef35d60507081fbe524cace0e) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) localIKFrame, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) boundEntityGlobalFrame, float animationHeightDifference=0.0f) |
| void | [SetWantsToYell](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abaa6493145c1fb8dea0294641dfbe2a9) () |
| void | [SetCapeClothSimulator](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9b1e833b65e17420663c62bd26a0b695) ([GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) clothSimulatorComponent) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetTargetPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aee331d2defbacac544baec0775245a98) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetTargetDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7cba58ffad7c74ef9afa3b9603319564) () |
| float | [GetAimingTimer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8723e18f1d6b856b3cef0453ed02be9e) () |
| float | [GetInteractionDistanceToUsable](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a04026a929dd6b4b757734647734ff0fe) ([IUsable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_usable.html) usable) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetInfoTextForBeingNotInteractable](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae27eac28789e19d43459a8e31de7721e) (Agent userAgent) |
| T | [GetController< T >](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0650efd14a1a10cba1c5202347bff1d0) () |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | [GetPrimaryWieldedItemIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af53ca97afd22b49f4b71a456f19af015) () |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | [GetOffhandWieldedItemIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1b26c562447d15a53479a76ff9fdbbd7) () |
| float | [GetMaximumForwardUnlimitedSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a092a6f52ef354b5724208da81e5008fa) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5c1fbf8210e89616442c380614e91a89) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) gameEntity) |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetWeaponEntityFromEquipmentSlot](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2e3a057761c51c56c571874c79e889f1) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetRetreatPos](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1bd19e6e777682e30ecf7a8cbd220245) () |
| [AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) | [GetScriptedFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd35778000079d0b2e2e23b8f158cf9e) () |
| [AISpecialCombatModeFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997) | [GetScriptedCombatFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aadddc549a07cb55e0c4258b892890a64) () |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetSteppedEntity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3325336183af3749aa6126378963fa6f) () |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetSteppedRootEntity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aec3fcc057a71bf5e2741edcb138a1396) () |
| [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | [GetSteppedBodyFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a168ad108e69146dbdd459df5ef1b9911) () |
| [AnimFlags](namespace_tale_worlds_1_1_mount_and_blade.html#aee58182af722eaf22dec720de2cc5818) | [GetCurrentAnimationFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a77f8043dc1b2b8ba93398bc73261676d) (int channelNo) |
| [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | [GetCurrentAction](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2d43b8776b00c21f5b21b814b62e474a) (int channelNo) |
| [ActionCodeType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016) | [GetCurrentActionType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a295c3e63008ed4de9f85fad7f484a912) (int channelNo) |
| [ActionStage](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565) | [GetCurrentActionStage](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a31d7e32745b933ce9ad868e8982bae46) (int channelNo) |
| [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | [GetCurrentActionDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b20c408baf3b019d0e86b41a01399bd) (int channelNo) |
| int | [GetCurrentActionPriority](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6d9387cff0945022ea52346d08315602) (int channelNo) |
| float | [GetCurrentActionProgress](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa78c8c5f1ddc903bfa2246b564675520) (int channelNo) |
| float | [GetActionChannelWeight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5144ddb5d405c6bd59fd9e8ea6aecea0) (int channelNo) |
| float | [GetActionChannelCurrentActionWeight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4e71296614bc608c8befd1fd9294faa3) (int channelNo) |
| [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) | [GetWorldFrame](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab6615ac87dab4d29c67c2bfd486c3ec8) () |
| float | [GetLookDownLimit](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a607bd6ecfec428503692f58d98ad6207) () |
| float | [GetEyeGlobalHeight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2e2997d71be5d283a9c55b1396254cf8) () |
| float | [GetMaximumSpeedLimit](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6591bc6bdd589cd90fd302de8bdb2c76) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetCurrentVelocity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad2421cb3d08a72be1dc5672614c90894) () |
| float | [GetTurnSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9e572c78cc0641e096e88ee40e65300e) () |
| float | [GetCurrentSpeedLimit](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5bb712664e70b5b4ee2e767078768fc) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetRealGlobalVelocity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#add888f689e1bcd932bcf8d5e33aaa43e) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetAverageRealGlobalVelocity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a66da8650b265a1d32ea0d40faff1e8bc) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetMovementDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6aa6efb13a9ed6d5a04caea285d81b06) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetCurWeaponOffset](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6b6e0c90b51365da26c49c1f333dd765) () |
| bool | [GetIsLeftStance](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad84e31dbb2a3cedb273d9af2a00c4d16) () |
| float | [GetPathDistanceToPoint](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7bde3c8b3ab1071503f9ff8b50d5b8ae) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) point) |
| int | [GetCurrentNavigationFaceId](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a489eab387fc7452d49c77d67ebb48bc2) () |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [GetWorldPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac4c896233737bd81d3e1d8b656eba359) () |
| int | [GetGroundMaterialForCollisionEffect](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a671c2dcf27aeeb768fd5926bc096ccfc) () |
| Agent | [GetLookAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abe9a80b18eea78bfedf00640e918c680) () |
| Agent | [GetTargetAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac1c2a3925eafad3c962f14298b4493cc) () |
| void | [SetTargetAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a996c1abcc925255f00d6bf6a3d44b3e5) (Agent agent) |
|  | Set *agent* as the new target agent. Note that if automatic target selection is not disabled, the target agent may be updated. |
| void | [SetAutomaticTargetSelection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2714b9c65b7d36a674e02f548aab8b93) (bool enable) |
|  | Enable or disable automatic target selection. Disabling automatic target selection gives the caller full control and responsibility over the target selection process. |
| [AgentFlag](namespace_tale_worlds_1_1_core.html#a4eadec2c483252505ae0d0ab98de39fe) | [GetAgentFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aadcb8a8a6880dfed30711f8b6056ea00) () |
| string | [GetAgentFacialAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4d0ce5b06434ac55c2e3e2ee3b5c04c4) () |
| string | [GetAgentVoiceDefinition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afed43009370cf6a432c2ec467be1f59d) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetEyeGlobalPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a684b3494dd25f7c5d0edce47346402c2) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetChestGlobalPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aeff5e785dd19c40ef2aeee0b29d6056c) () |
| [MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) | [GetDefendMovementFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adb1bbda7c2b8b4aec22af6ce630380bd) () |
| [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | [GetAttackDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a189ab0e683bead50badf280ca36b6702) () |
| [WeaponInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_info.html) | [GetWieldedWeaponInfo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0b8b7b24fb7223fa96cc881cc9828f28) ([HandIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6de) handIndex) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetBodyRotationConstraint](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8fa03e95663811e636a471e68a8e8325) (int channelIndex=1) |
| float | [GetTotalEncumbrance](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a880f85e53db08c36ff95b65e41ff4239) () |
| float | [GetTotalMass](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad8f18b2d47486cffdb3189d00a3d1043) () |
| T | [GetComponent< T >](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3be313217c523c8798a65897a75ee962) () |
| float | [GetAgentDrivenPropertyValue](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acaa6ed12bb07bbcea2e96dc65eb0dbf1) ([DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) type) |
| [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | [GetSteppedMachine](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a77bd0663161a71a6add5bec820feccce) () |
| int | [GetAttachedWeaponsCount](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a99964b94d87688b28e0d80bf62bca6b6) () |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | [GetAttachedWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5ae6265a6c09a8355501d798e0185e75) (int index) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetAttachedWeaponFrame](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aaf02f897f2b9c76dfde2e325b6a9f6d2) (int index) |
| [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) | [GetAttachedWeaponBoneIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a724ba3f4f7694b77556d3e057f233316) (int index) |
| void | [DeleteAttachedWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab9bb2ca9cd41cc3f8b1e5fcf9d23e50a) (int index) |
| bool | [HasRangedWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adb55e51b97aca58f5dc04b244baa62f1) (bool checkHasAmmo=false) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialFrameAtAnimationProgress](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9539afd9125f6017c28c92de4be67686) ([sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) boneIndex, int animationIndex, float progress) |
| void | [GetFormationFileAndRankInfo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a714e7898fd47ee9798e30e79472e3287) (out int fileIndex, out int rankIndex) |
| void | [GetFormationFileAndRankInfo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8611e3264d293520dfa3c3911730b199) (out int fileIndex, out int rankIndex, out int fileCount, out int rankCount) |
| void | [SetMortalityState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6ec15c9ddc0180300351e8c43adcf7af) ([MortalityState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd592cc5cf557afcc7eaef3ae20a7eae) newState) |
| void | [ToggleInvulnerable](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3b9e739e24065c4ff28c41761f2c6ea6) () |
| float | [GetArmLength](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a119c69f0d50d7f153d58a887349b38a2) () |
| float | [GetArmWeight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab478fe1b2b1dd65a0bd297b0845cc2ab) () |
| void | [GetRunningSimulationDataUntilMaximumSpeedReached](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6aa66e62728880faa0089ad18a0208b4) (ref float combatAccelerationTime, ref float maxSpeed, float[] speedValues) |
| void | [SetMaximumSpeedLimit](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5fcacba4ed4b34b7688b69984eacb6e7) (float maximumSpeedLimit, bool isMultiplier) |
| float | [GetBaseArmorEffectivenessForBodyPart](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac051e9ca2794e52dec6f36703fd3cef2) ([BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) bodyPart) |
| [AITargetVisibilityState](namespace_tale_worlds_1_1_mount_and_blade.html#a011beb62f538ed3c340ddbb2cff1bf13) | [GetLastTargetVisibilityState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a326c4c20589587b4d66e52003ef5d9f2) () |
| float | [GetMissileRange](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a89292941925526e29b57e6c1b9eb749d) () |
| void | [SetAgentIdleAnimationStatus](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a89a0a0f7e52df01107bcd4dccb326bc0) (bool idleEnabled) |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetWeaponToReplaceOnQuickAction](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a66f9074ce6834f69205cfb3db4efb91b) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) spawnedItem, out [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) possibleSlotIndex) |
| [Hitter](class_tale_worlds_1_1_mount_and_blade_1_1_agent_1_1_hitter.html) | [GetAssistingHitter](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad964bdd801d64fdad7f53e9a96407520) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e10a41a2278c97680f64e7ad75c2d20) killerPeer) |
| bool | [CanReachAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6528fffbfe38dd2c5e8e6716be67b5e2) (Agent otherAgent) |
| bool | [CanInteractWithAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b022bd15c13feacff544cc8730634f2) (Agent otherAgent, float userAgentCameraElevation) |
| bool | [CanBeAssignedForScriptedMovement](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6745900967102a070a73819b59cdf449) () |
| bool | [CanReachAndUseObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac2ade016f65de5f04c48916a9d2f7d39) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) gameObject, float distanceSq) |
|  | Checks if this agent's position and look direction are sufficient for using param game object. Checks if param gameObject is usable or not. |
| bool | [CanReachObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a092b524e17708b409236a7ac229d36b8) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) gameObject, float distanceSq) |
| bool | [CanReachObjectFromPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a60ceb3075a4199c07a1e90fc06b3144b) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) gameObject, float distanceSq, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| bool | [CanUseObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aff9e4a6a7e5dcdf14f447b3964d0b05e) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) gameObject) |
| bool | [CanMoveDirectlyToPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa0430f863f1a1e4fc47aa8389c359a84) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| bool | [CanInteractableWeaponBePickedUp](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8db4666e8f1cd6ee0a5320cff5c4ce19) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) spawnedItem) |
| bool | [CanQuickPickUp](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab56f82ba10fe650b8e24fdf2c90e1ba9) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) spawnedItem) |
| bool | [CanTeleport](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6e5adbd697012f89de66c29713130c4a) () |
| bool | [IsActive](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6f06d53678f3f4c2127133c265a854a0) () |
| bool | [IsRetreating](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adc5b2c8a25a94c67c91f74e1490cabf1) () |
| bool | [IsFadingOut](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a26eab72f2487b5f9b31ac2b720639bab) () |
| void | [SetAgentDrivenPropertyValueFromConsole](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5045327ed01e5c5274286ab0526b79ac) ([DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) type, float val) |
| bool | [IsOnLand](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad9f5f14ec3455a7d2329f953f4c3726c) () |
| bool | [IsInWater](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aeb8859b53fe55564d9cb5f7918c4458f) () |
| bool | [IsAbleToUseMachine](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a96d0f73003df0c0562bab11c3df72188) () |
| bool | [IsAgentParentEntitySameAs](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade566b75325f7e4901f0b50fe67bd881) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) toBeChecked) |
| void | [SetExcludedFromGravity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab21a60c49b451adfeee9133386f08609) (bool exclude, bool applyAverageGlobalVelocity) |
| void | [SetForceAttachedEntity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e435c963d5ae13a8a11dfd5abd759f5) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) willBeAttached) |
| bool | [IsSliding](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae78769fd963cf0bd2d8abadb445e55a2) () |
| bool | [IsSitting](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ada2b0d46db5d2406ff832cb45da850ae) () |
| bool | [IsReleasingChainAttackInMultiplayer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af6b5cb6d2ea3785ff19554f9c7e107e8) () |
| bool | [IsCameraAttachable](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a75e45028d9a68a904c84addb2b95e83e) () |
| bool | [IsSynchedPrefabComponentVisible](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6d212d9882d60060d9503a4d8ea8337e) (int componentIndex) |
| bool | [IsEnemyOf](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a289d68f40695419b4b0b0543cba0855a) (Agent otherAgent) |
| bool | [IsFriendOf](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a499cbe3c00042695385fb09153c2c89d) (Agent otherAgent) |
| void | [OnFocusGain](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afd52e23614f81ac535cc9265859d15aa) (Agent userAgent) |
| void | [OnFocusLose](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8a1f47e424dfb718a4165a63d1923dcf) (Agent userAgent) |
| void | [OnItemRemovedFromScene](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae6702921527d721b9e59ca44eb6fe7c8) () |
| void | [OnUse](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acda375fc5df86ad6390a4b35c28fd989) (Agent userAgent, [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) agentBoneIndex) |
| void | [OnUseStopped](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7eed2c8aa8e72e1570decace7ae685c3) (Agent userAgent, bool isSuccessful, int preferenceIndex) |
| void | [OnWeaponDrop](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac12d830bde133a2a52ef33cac52e47d7) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equipmentSlot) |
| void | [OnItemPickup](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a18783611fb1aa46b40f7ded20e4c43e6) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) spawnedItemEntity, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) weaponPickUpSlotIndex, out bool removeWeapon) |
| float | [GetDistanceTo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a66ba72acbcd9b288773a40f8b17b75ed) (Agent other) |
| bool | [CheckPathToAITargetAgentPassesThroughNavigationFaceIdFromDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab1f4935eefa049b00410b13e364a5478) (int navigationFaceId, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction, float overridenCostForFaceId) |
| bool | [IsTargetNavigationFaceIdBetween](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae9310020c32529ab3023a50130983ebe) (int navigationFaceIdStart, int navigationFaceIdEnd) |
| void | [CheckEquipmentForCapeClothSimulationStateChange](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a91b83fec52b189094e23ada54678c7e0) () |
| void | [CheckToDropFlaggedItem](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2d5c16d5e0364a6e78f58a54b0722e60) () |
| bool | [CheckSkillForMounting](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a070a63c354df10cda184c22b63669c90) (Agent mountAgent) |
| void | [InitializeSpawnEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd3ead52e5b35894cbaa6906988b0ee0) ([Equipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1f8e2968b02a0bcd02f435fdfea305d) spawnEquipment) |
| void | [InitializeMissionEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a340e4433a107266d2c21124f744991c0) ([MissionEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html) missionEquipment, [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a640493f3278a13f47141f6b2d431661a) banner) |
| void | [InitializeAgentProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af3afcbb3ba735d022caa4aea4084399b) ([Equipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1f8e2968b02a0bcd02f435fdfea305d) spawnEquipment, [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) agentBuildData) |
| void | [UpdateFormationOrders](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab4db2020ce84bac79190fc95367834cc) () |
| void | [UpdateWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23938d5c2b65052bcbfbae1216af93b8) () |
| void | [UpdateAgentProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6693c259c8241742fe749d8717c01d4e) () |
| void | [UpdateCustomDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a25daffc76603905d1656f482aaeb5658) () |
| void | [UpdateBodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3dafe0e7f8906e00c4cfbd7222c62859) ([BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) bodyProperties) |
| void | [UpdateSyncHealthToAllClients](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad89f47ee43b185587275df062f878c7c) (bool value) |
| void | [UpdateSpawnEquipmentAndRefreshVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a76f45a1204bbc5e9b6e7e5eefe66d90f) ([Equipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1f8e2968b02a0bcd02f435fdfea305d) newSpawnEquipment) |
| void | [ForceUpdateCachedAndFormationValues](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a546a454df2b45dbe270221af4da60d4d) (bool updateOnlyMovement, bool arrangementChangeAllowed) |
| void | [UpdateLastRangedAttackTimeDueToAnAttack](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2f951ab900cad76e999b04927161810c) (float newTime) |
| void | [InvalidateTargetAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9279b95a8d3b884dea47d64c017d53fd) () |
| void | [InvalidateAIWeaponSelections](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a41df9e3eb455ef04b2330b01377ea479) () |
| void | [ResetLookAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afa9eb6528220d56c9ee1dc7306f9652b) () |
| void | [ResetGuard](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7877475f04f7df6c345d35a9e5c00278) () |
| void | [ResetAgentProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afb3fe1be43781e1f7d3e424c6ab93278) () |
| void | [ResetAiWaitBeforeShootFactor](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0f5037dabeb97daf411a2c3da5543e5c) () |
| void | [ClearTargetFrame](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a37255dcc1e91e1f5009be054bc151d2e) () |
| void | [ClearEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aaa8088a65ede38d44a7166c9ddd410f9) () |
| void | [ClearHandInverseKinematics](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae8c58de01eb55a14d4df7c37af5159b5) () |
| void | [ClearAttachedWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6db4f30ea8ade1d0d0da9d344a2d0e88) () |
| void | [SetDetachableFromFormation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af73e4b813ebe022f857dd2c7a0083732) (bool value) |
| bool | [TryAttachToFormation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab8916b40a8652c691afea1f79067b87b) () |
| bool | [TryRemoveAllDetachmentScores](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8ba03cd1a3d52acf08dbe17c32d40810) () |
| void | [EnforceShieldUsage](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a043433669a23729d700d911a8a6e462d) ([UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) shieldDirection) |
| bool | [ObjectHasVacantPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a898030ca05f6b7063f4d6b560d08e5a4) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) gameObject) |
| bool | [InteractingWithAnyGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2cf7265b2ea5f0c62d6a7b27c5de5e3f) () |
| void | [StopUsingGameObjectMT](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3c528123285d63abbeacbc92a56ac161) (bool isSuccessful=true, [StopUsingGameObjectFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713) flags=([StopUsingGameObjectFlags.AutoAttachAfterStoppingUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713a967948a82d8f55fae4e9c5ff9cfae7bc))) |
| void | [StopUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a789eaabbd2d6d576852e4c074d4a3b6f) (bool isSuccessful=true, [StopUsingGameObjectFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713) flags=([StopUsingGameObjectFlags.AutoAttachAfterStoppingUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713a967948a82d8f55fae4e9c5ff9cfae7bc))) |
| void | [HandleStopUsingAction](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aeb04799859f57b71123497602a7feb68) () |
| void | [HandleStartUsingAction](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af2f05c01b2bfe9b013a71aea0ea698d7) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) targetObject, int preferenceIndex) |
| [AgentController](class_tale_worlds_1_1_mount_and_blade_1_1_agent_controller.html) | [AddController](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abf371b0e5d2156bc5dd8501ee51b071c) (Type type) |
| [AgentController](class_tale_worlds_1_1_mount_and_blade_1_1_agent_controller.html) | [RemoveController](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8214aa1e08d591a9d42ea7f8b08ee4d0) (Type type) |
| bool | [CanThrustAttackStickToBone](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4237dd3fcea9887c6efcd5f646690234) ([BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) bodyPart) |
| void | [GetOldWieldedItemInfo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aac8aeecec285b9351afce0161ac59417) (out int rightHandSlotIndex, out int rightHandUsageIndex, out int leftHandSlotIndex, out int leftHandUsageIndex) |
| void | [StartSwitchingWeaponUsageIndexAsClient](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3c479aa29479fef70416c47188d4f4c5) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equipmentIndex, int usageIndex, [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) currentMovementFlagUsageDirection) |
| void | [TryToWieldWeaponInSlot](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a44fac0196d32ff47f7c01f1b54dbfd35) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, [WeaponWieldActionType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835e) type, bool isWieldedOnSpawn) |
| void | [PrepareWeaponForDropInEquipmentSlot](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af4394b1e804550273b615e81a451d2a1) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, bool dropWithHolster) |
| void | [AddHitter](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adc98be741e8eacea4165f6956849b098) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e10a41a2278c97680f64e7ad75c2d20) peer, float damage, bool isFriendlyHit) |
| void | [TryToSheathWeaponInHand](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae582579170e0957c3598aa2926fe3d63) ([HandIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6de) handIndex, [WeaponWieldActionType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835e) type) |
| void | [RemoveHitter](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af32014eb7450084d3100c08d15a0b140) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e10a41a2278c97680f64e7ad75c2d20) peer, bool isFriendlyHit) |
| void | [Retreat](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af4c7d3b2c35029ef796d6e53049b7c6a) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) retreatPos) |
| void | [StopRetreating](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3e711c679b36c3778506e482a80dddaf) () |
| void | [UseGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3a780d5eb715f9152165767b6f6ca872) ([UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) usedObject, int preferenceIndex=-1) |
| void | [SaveEquipmentsOnHand](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abacedc3540d3e8e45d7117232c58bc54) () |
| void | [StartFadingOut](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a490cb03e2e6b1708d0abf892f8e5d817) () |
| bool | [IsWandering](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adcb65604426aec7d0837d3bacc0bb211) () |
| void | [SetRenderCheckEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a12bfc307f82c087cc75f51eea8cd2133) (bool value) |
| bool | [GetRenderCheckEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a860cfe0107609654b5aacf2896fc2dcd) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [ComputeAnimationDisplacement](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5071887155f7769be795f52e0d2e0a7a) (float dt) |
| void | [TickActionChannels](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0f9d4015f2039bdeea9932b1d76e4454) (float dt) |
| void | [SetIsPhysicsForceClosed](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a968aec277ba17bbe233abcf17db7b8b9) (bool isPhysicsForceClosed) |
| void | [LockAgentReplicationTableDataWithCurrentReliableSequenceNo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a26673823bb510ac07fb098ea0a1bf5dc) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) peer) |
| void | [TeleportToPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa2cb9bfe7817e5eeef223bc6dab9ebe7) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| void | [FadeOut](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6cf47c3db6dafe00924d153cd02d6a32) (bool hideInstantly, bool hideMount) |
| void | [FadeIn](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a62f14edd8006b88a7236746c738316f0) () |
| void | [DisableScriptedMovement](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4471f32cbf9b479a1541e78b8d464800) () |
| void | [DisableScriptedCombatMovement](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3f88d9dea69c9996eec8bf96d3982d5f) () |
| void | [ForceAiBehaviorSelection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4848b61abc5242c248ad4061c98e78bd) () |
| bool | [HasPathThroughNavigationFaceIdFromDirectionMT](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a97e48ca6a5f1b1920d1157c71a53272a) (int navigationFaceId, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction) |
|  | Checks if the agent's path includes any face with id *navigationFaceId* WARNING: Do not use agent [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) values directly. Their cached navigation meshes may not cover their exact position. |
| bool | [HasPathThroughNavigationFaceIdFromDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3202da33b0342eac162dd93e432b7e49) (int navigationFaceId, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction) |
|  | Checks if the agent's path includes any face with id *navigationFaceId* WARNING: Do not use agent [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) values directly. Their cached navigation meshes may not cover their exact position. |
| void | [DisableLookToPointOfInterest](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a10cbcbcc1138481a71c9aaf07bac3f02) () |
| [CompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html) | [AddPrefabComponentToBone](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6360fc2e2232dde29b5acfad34bbdc70) (string prefabName, [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) boneIndex) |
| void | [MakeVoice](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a100af76da61d898ffcb98227bfc48274) ([SkinVoiceManager.SkinVoiceType](struct_tale_worlds_1_1_mount_and_blade_1_1_skin_voice_manager_1_1_skin_voice_type.html) voiceType, [SkinVoiceManager.CombatVoiceNetworkPredictionType](class_tale_worlds_1_1_mount_and_blade_1_1_skin_voice_manager.html#a3a36fbc50e06600400f9c83dc18267e4) predictionType) |
| void | [YellAfterDelay](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7c82177d96d40076a8354a87ccf0c295) (float delayTimeInSecond) |
| void | [WieldNextWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9ad8266b5ec1426ef20982c21822f146) ([HandIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6de) weaponIndex, [WeaponWieldActionType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835e) wieldActionType=[WeaponWieldActionType.WithAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835ea7671f6d74e057fdfafe2928bf6b7b27b)) |
| [MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) | [AttackDirectionToMovementFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a781a9abd3a931a5af886055adb82ffe2) ([UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) direction) |
| [MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) | [DefendDirectionToMovementFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a241002ef0a33efb930d8e3f3ec37cc0f) ([UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) direction) |
| bool | [KickClear](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab7da5acf1e149878b48f76a19747b0da) () |
| [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | [PlayerAttackDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a41da440c8b75491f8cefde6c585e758f) () |
| [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) | [GetRandomPairOfRealBloodBurstBoneIndices](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a84a6e774147cb224739ae869758915b3) () |
| void | [CreateBloodBurstAtLimb](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adf970c7d8226c94dd59080c53dad1cc5) ([sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) realBoneIndex, float scale) |
| void | [AddComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a950a414da3d9ff8973328787f25a672f) ([AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) agentComponent) |
| bool | [RemoveComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3a17c108810516e7f43f420ec365148f) ([AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) agentComponent) |
| void | [HandleTaunt](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a87de617cb18a5e3d6686f15bcf18d20c) (int tauntIndex, bool isDefaultTaunt) |
| void | [HandleBark](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9b66b519dbc13f7fd8d0602c45595687) (int indexOfBark) |
| void | [HandleDropWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a04d62dab4186e1c307100a2d46e46476) (bool isDefendPressed, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) forcedSlotIndexToDropWeaponFrom) |
| void | [DropItem](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac3e4809fab4a51621ab0d3395dd74fb4) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) itemIndex, [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) pickedUpItemType=WeaponClass.Undefined) |
| void | [EquipItemsFromSpawnEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0fd7c7955c4802fd6acec69a801ab4e9) (bool neededBatchedItems, bool prepareImmediately, bool useFaceCache, int faceCacheID) |
| void | [WieldInitialWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2bd673f4388e0f687cbb8a3ec4efee0f) ([WeaponWieldActionType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835e) wieldActionType=[WeaponWieldActionType.InstantAfterPickUp](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835eafb04605c34b201af035c2ff8b5f61967), Equipment.InitialWeaponEquipPreference initialWeaponEquipPreference=[Core.Equipment.InitialWeaponEquipPreference.Any](class_tale_worlds_1_1_core_1_1_equipment.html#a4f20fb89d2bb249f242976b83f3c51edaed36a1ef76a59ee3f15180e0441188ad)) |
| void | [ChangeWeaponHitPoints](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6d28705b1d25542aa7d801a5fe8b2713) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, short hitPoints) |
| bool | [HasWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afdb34b73a2d50865c18098663ec47732) () |
| void | [AttachWeaponToWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3cef1fdc1c24b8c5b3915ecbbe813095) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) weaponEntity, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) attachLocalFrame) |
| void | [AttachWeaponToBone](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac342c85d8966d14df319c70954c216b8) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) weaponEntity, [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) boneIndex, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) attachLocalFrame) |
| void | [RestoreShieldHitPoints](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5be1a2211fb442f8414a407164e1d7ba) () |
| void | [Die](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a744af8c90682832cd49d466c938f9f95) ([Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) b, [KillInfo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7) overrideKillInfo=[KillInfo.Invalid](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a4bbb8f967da6d1a610596d7257179c2b)) |
| void | [MakeDead](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5048b7c52162aabf77d3245597a7e6f4) (bool isKilled, [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) actionIndex, int corpsesToFadeIndex=-1) |
| void | [RegisterBlow](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab3cd240497ec0d58e838a12d1ab6b57a) ([Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData) |
| void | [CreateBlowFromBlowAsReflection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a641912d7a515ce0f1d1af77b1c419645) (in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) blow, in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) collisionData, out [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) outBlow, out [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) outCollisionData) |
| void | [TickParallel](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a40ff5fb1d3501a0abc1d03c99d8478a0) (float dt) |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4f22e839638dcfb6daa2154365536b38) (float dt) |
| void | [DebugMore](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acce73af22241c7cf1eff9ac7004f926e) () |
| void | [Mount](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab30f739110cdaec37969313dec394553) (Agent mountAgent) |
| void | [EquipWeaponToExtraSlotAndWield](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af1a4f978e55f7daef8e44cadfc72c6e6) (ref [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon) |
| void | [RemoveEquippedWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aed71bf9e783c7b683593d32197243d6d) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex) |
| void | [EquipWeaponWithNewEntity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0bb25143c87874217753f6cd812269de) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, ref [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon) |
|  | Equips the item. |
| void | [EquipWeaponFromSpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae68a5dfff82396c4def8586afaa40fdc) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) spawnedItemEntity, bool removeWeapon) |
| void | [PreloadForRendering](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a52926d113cd01a294a92f4cdfc9c2314) () |
| int | [AddSynchedPrefabComponentToBone](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aad59887f00de0102ded95695e791ef8e) (string prefabName, [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) boneIndex) |
| bool | [WillDropWieldedShield](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9095f4bf4faaa0fd5f8681876e7be0a2) ([SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) spawnedItem) |
| bool | [HadSameTypeOfConsumableOrShieldOnSpawn](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1673baf1650339b2a11c51ff1e4da280) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass) |
| override int | [GetHashCode](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac5b8d4af8a095b1c538b5b032ab27507) () |
| bool | [TryGetImmediateEnemyAgentMovementData](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a62f7b3a2512664aa2885337f0746787b) (out float maximumForwardUnlimitedSpeed, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| bool | [HasLostShield](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a92392e10b986e6f4269186f0c7b7d8da) () |
| void | [SetLastDetachmentTickAgentTime](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af3a7ccd18a1edbe5de73155833c0b8e5) (float lastDetachmentTickAgentTime) |
| void | [SetDetachmentWeight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acb23ea636a78fa1212cadc22a6d73bdb) (float newDetachmentWeight) |
| void | [SetDetachmentIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a34e09911f101b49bde814fd392f847b5) (int newDetachmentIndex) |
| void | [SetOwningAgentMissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0b9a1aa9c6beb6f8f61110d3471ddd61) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e10a41a2278c97680f64e7ad75c2d20) owningAgentMissionPeer) |
| void | [SetMissionRepresentative](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8cc6a7dff83e9b444ed539a5d46b95bf) ([MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) missionRepresentative) |
| void | [SetIsLadderQueueUsing](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a602639c09d704d0cb826a49ad29cb5be) (bool isLadderQueueUsing) |
| void | [SetIsInLadderQueue](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a18a719ec77c06738094501e9fdb07fd4) (bool isInLadderQueue) |
| void | [UpdateLocalPositionError](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abb3b3c7b8ba682277e9a8707418ca849) () |
| void | [YellingBehaviour](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7f09beeecc962f0d964cd90ec8c36545) () |
| bool | [HasPathThroughNavigationFacesIDFromDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa83c881b423f53bc8c6c8de676de7c48) (int navigationFaceID\_1, int navigationFaceID\_2, int navigationFaceID\_3, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction) |
| bool | [HasPathThroughNavigationFacesIDFromDirectionMT](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aef1f18a7af129fdd7919898ed8788351) (int navigationFaceID\_1, int navigationFaceID\_2, int navigationFaceID\_3, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction) |
| void | [SetInitialFrame](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0b038eb60d501dd6227e7f1da9776f5e) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) initialPosition, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) initialDirection, bool canSpawnOutsideOfMissionBoundary=false) |
|  | Sets the initial frame for the agent. This frame is used when the agent gets spawned without a formation. |
| void | [ClearTargetZ](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae1e11f08547f9ada14a084f9377e308c) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | [MovementFlagToDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af670af556774d8e2bee418021174a0b7) ([MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) flag) |
| static [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | [GetActionDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac61285628c1a57aeaca157963aaf7bad) (int actionIndex) |
| static int | [GetMonsterUsageIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae505df7933a44ee50dd6bfeedb91911e) (string monsterUsage) |
| static float | [GetSoundParameterForArmorType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a407db3867bb7142b8e91d2cf47d6b67d) ([ArmorComponent.ArmorMaterialTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99) armorMaterialType) |

|  |  |
| --- | --- |
| Public Attributes | |
| [OnMainAgentWieldedItemChangeDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad987ba74a5b3c9a503c88091d2cecf0c) | [OnMainAgentWieldedItemChange](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7a96ce2f7bb25aaae9db895d69a1fac7) |
| Action | [OnAgentMountedStateChanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac1031efa9d6abe4c7bff78f4eb1cfc1e) |
| Action | [OnAgentWieldedItemChange](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aec1270a9fc62929dfb65eda3fb8c8586) |
|  | [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [BecomeTeenagerAge](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6ea90a9566258c671db46c13532e2abb) = 14 |
|  | Synced with Campaign.Current.Models.AgeModel.BecomeTeenagerAge. |
| const float | [MaxMountInteractionDistance](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae6771cc3f3ed02a7ead14a664778ff34) = 1.75f |
| const float | [DismountVelocityLimit](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a86dc36405ecadad6e54c3cd36f01160d) = 0.5f |
| const float | [HealthDyingThreshold](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6d5f4245e8f71500ccb308a2850d40c0) = 1.0f |
| const float | [CachedAndFormationValuesUpdateTime](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1859116ddc606522949a2beedf7d10b) = 0.5f |
| const float | [MaxInteractionDistance](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a924424bc00b0cbb2820333c2b4268d46) = 3.0f |
| const float | [MaxFocusDistance](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3975cb84748bff4682c15b3ac8ab3b82) = 10.0f |
| static readonly [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html)[] | [DefaultTauntActions](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae8962dc05b1242ff7f9ace989bc21784) |

|  |  |
| --- | --- |
| Properties | |
| static Agent | [Main](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0d9f38e91b16debe9ebe38e9a7b3208b) `[get]` |
| bool | [IsPlayerControlled](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8308eacd90f0bb76b631af96eea1bb3b) `[get]` |
| bool | [IsMine](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ada60a64d3368d26a4582a04ee8ee080a) `[get]` |
| bool | [IsMainAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad88e512e468da6c713e536947e29687d) `[get]` |
| bool | [IsHuman](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acf73850efcec3680af15c9ac55701996) `[get]` |
| bool | [IsMount](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab66a1a3e399f36da673550b498bc61ea) `[get]` |
| bool | [IsAIControlled](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa329d24166881ac580929290c158e8c9) `[get]` |
| bool | [IsPlayerTroop](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae7e0c1dc8db8cec35799d76d50ef76fd) `[get]` |
| bool | [IsUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2b9caf883bd18362215ca9951c397fc8) `[get]` |
| bool | [CanLeadFormationsRemotely](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98c2a5d7e97a1d14fadc486de413184a) `[get]` |
|  | If set, the agent can lead a formation as being its captain remotely. That means the agent does not need to be assigned to the formation to become its captain. By default, general agents and the player can have this property. |
| bool | [IsDetachableFromFormation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0cec72d93971ff5864e7058cb6e23253) `[get]` |
| float | [AgentScale](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adc20ef281c544e4a23649dbfe098a609) `[get]` |
| bool | [CrouchMode](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a03d9d0bfbf0cad9987fe07a5d5d0b938) `[get]` |
| bool | [WalkMode](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5d4e7578152f76595ac6a3bc71a90d21) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Position](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab7c815ee30cb8bc2ae95c525d5b1de05) `[get]` |
| [AgentMovementMode](namespace_tale_worlds_1_1_core.html#a57c7a188b7a711a6748c836cff044dae) | [MovementMode](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7424f79aecdcb17fe360bfa089913d91) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [VisualPosition](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0737a737eb962a7cc422bf0a299e2dc1) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [MovementVelocity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a968ae52c86c08eadb12a9a7a3f323741) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [AverageVelocity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1e2db515e63768caea93199788878509) `[get]` |
| float | [MovementDirectionAsAngle](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa38d0504c27eeaf00de432ff4bbb1f0a) `[get]` |
| bool | [IsLookRotationInSlowMotion](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad8e1b3a1d26f98b79384b93974717cd9) `[get]` |
| [AgentPropertiesModifiers](struct_tale_worlds_1_1_mount_and_blade_1_1_agent_1_1_agent_properties_modifiers.html) | [PropertyModifiers](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a88704d63d0bb85785c5dc5b2f4de97ad) `[get]` |
| [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) | [ActionSet](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7a3f48899df7e4032e8f26f23f74b03f) `[get]` |
| MBReadOnlyList< [AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) > | [Components](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad763afee573aa7cd7ecb99412d3300e9) `[get]` |
| MBReadOnlyList< [Hitter](class_tale_worlds_1_1_mount_and_blade_1_1_agent_1_1_hitter.html) > | [HitterList](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2140da257cf28f23af05b76b491da43e) `[get]` |
| [GuardMode](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e258f837e094c8fd60eaf08c57e1a61) | [CurrentGuardMode](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac10c8762f8f8e28bc91347b65aebda79) `[get]` |
| Agent | [ImmediateEnemy](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a95520e707c06600f5520906871072ba6) `[get]` |
| bool | [IsDoingPassiveAttack](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a84fed08444d8afe1a956667195c25c47) `[get]` |
| bool | [IsPassiveUsageConditionsAreMet](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e3d354ff63bc2407b9196725cb6e0b5) `[get]` |
| float | [CurrentAimingError](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af9fdd7f0cb79f72c0c47e71f938a23f5) `[get]` |
| float | [CurrentAimingTurbulance](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#affc5a04c28e27a2a9b66819cde36444b) `[get]` |
| [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | [AttackDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7403ccaf08ae09db5dadcb2da2d61a66) `[get]` |
| float | [WalkingSpeedLimitOfMountable](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3e629342c9e34007432c70f9fe143f69) `[get]` |
| Agent | [RiderAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af19490dd4624e89a2374b1b68a86554d) `[get]` |
| bool | [HasMount](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a46d8febb6d6612976b28c0f93fa8f3d2) `[get]` |
| bool | [CanLogCombatFor](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad3906b799b4352bcca60d8763b16d4eb) `[get]` |
| float | [MissileRangeAdjusted](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71eba325ec593a9323bc90773359596f) `[get]` |
| float | [MaximumMissileRange](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a653b43317ee97f5b3c1b5859fee7ae00) `[get]` |
| string | [Name](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e87e913f81299dc22b29eaa6f959b79) `[get]` |
|  | Gets or sets the name of agent. This function should not be used to get the name unless the value differs from its character object. |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [NameTextObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a229ec139bd166162477cc2c6e27f0da6) `[get]` |
| [AgentMovementLockedState](namespace_tale_worlds_1_1_mount_and_blade.html#a2d4a63cc3752dd189bd939610b34157b) | [MovementLockedState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ace13877adc7a2dc7eb1966191da3eeef) `[get]` |
| Monster | [Monster](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3d12ccf64939586de96da8498ae33119) `[get]` |
| bool | [IsRunningAway](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2d1e0094a4b2dacfdc0d9a6a9481a500) `[get]` |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [BodyPropertiesValue](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1fe0ab82eb2123d19111f455a300a0c3) `[get]` |
| CommonAIComponent | [CommonAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad6a4d59075a56c6207f32c55b6ff7d03) `[get]` |
| HumanAIComponent | [HumanAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a122ae9e1f7fb6f42ed24eff7e99c742f) `[get]` |
| int | [BodyPropertiesSeed](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a61bba4a0af9aea61f549a015525be912) `[get]` |
| float | [LastRangedHitTime](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2ed3033fd01d2341964470b4d2b078ea) = float.MinValue `[get]` |
| float | [LastMeleeHitTime](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a82e82d6c959f872d99d829c0ffb7afb0) = float.MinValue `[get]` |
| float | [LastRangedAttackTime](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0ed9f5ded6d63aa7dad066c2fcf26942) = float.MinValue `[get]` |
| float | [LastMeleeAttackTime](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a03560748b5dc43810258a0ab6a08bdd9) = float.MinValue `[get]` |
| bool | [IsFemale](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0413a10c06067fa563955d2a5864024a) `[get, set]` |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a640493f3278a13f47141f6b2d431661a) `[get]` |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [FormationBanner](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aeb3e4b2b325297641f50c9d9a7671d31) `[get]` |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | [WieldedWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac91c0f6aeea8a7effc44c21ee396876a) `[get]` |
| bool | [IsItemUseDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a627ddda1cbe61cef16874ebfdb5e88ad) `[get, set]` |
| bool | [SyncHealthToAllClients](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a25eeb7a29444afed7d2ecd5effc03bbc) `[get]` |
| [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | [CurrentlyUsedGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abc2cb8ed31d5f00b22683fd6d5840e9b) `[get]` |
| bool | [CombatActionsEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa5306666ee0bace8b224f269d8de3469) `[get]` |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adfe6f6ebc1f9ca71d4b4e808b4a1ed45) `[get]` |
| bool | [IsHero](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a825874383be114ff281268ffdda79ed4) `[get]` |
| int | [Index](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6946c9080342e9ca57eaa35f8baec7b4) `[get]` |
|  | Gets or sets the index given by the game engine to this agent. |
| [MissionEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html) | [Equipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1f8e2968b02a0bcd02f435fdfea305d) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AgentRole](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aaf52bed6be3929874d6ce946929b3687) `[get, set]` |
| bool | [HasBeenBuilt](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a213d34b03520c1352ba7ea284a8d7588) `[get]` |
| [MortalityState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd592cc5cf557afcc7eaef3ae20a7eae) | [CurrentMortalityState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a75f0732851c7ccf7d91d89c14a199577) `[get]` |
| [Equipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1f8e2968b02a0bcd02f435fdfea305d) | [SpawnEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5675d9658bd670ecf4cc11116ba58fd4) `[get]` |
| [FormationPositionPreference](namespace_tale_worlds_1_1_core.html#a27a08ddbccef9cfbcf5de8653eb5244e) | [FormationPositionPreference](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac3ceb6446ccc2a30fc178e26cf824701) `[get, set]` |
| bool | [RandomizeColors](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a138da16d4cf5255e986d096e23252f49) `[get]` |
| float | [CharacterPowerCached](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3ba3ed1ee93aac9b4166cfdd4d41520c) `[get]` |
| float | [WalkSpeedCached](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afb43485a18b28877cca63884bfb5e32b) `[get]` |
| [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) | [Origin](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0c684662d1d7a44b6f83d5af579f12c4) `[get, set]` |
| Team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a13bb441adc4062eddd4b9548e43b5db5) `[get]` |
| int | [KillCount](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a90f4436a068b7209c7a3191389d29c68) `[get, set]` |
| AgentDrivenProperties | [AgentDrivenProperties](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1e93156b404fee723c6dbe97ca76110) `[get]` |
| float | [BaseHealthLimit](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a73f45cee874d88d431572e761d99776c) `[get, set]` |
| string | [HorseCreationKey](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acf8c8d6740b3ed8650ae8066f32db159) `[get]` |
| float | [HealthLimit](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af0b65153046e310b4fc0783f216d1016) `[get, set]` |
| bool | [IsRangedCached](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab3f002741cc63229e552fc7be0ecf39e) `[get]` |
| bool | [HasAnyRangedWeaponCached](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1f8546964f91e2a3054d46cbce749b75) `[get]` |
| bool | [HasMeleeWeaponCached](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5e6a585fdb118771b42958b93cfc4148) `[get]` |
| bool | [HasShieldCached](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a63ecf71f772c4919394f3106d9f850e6) `[get]` |
| bool | [HasSpearCached](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a966c68aa352571aaf6ffa343f85250a2) `[get]` |
| bool | [HasThrownCached](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8811f21d0a13f6472852f234555ec1f9) `[get]` |
| [AIStateFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995) | [AIStateFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa73f8598d9045c2e175606e93041e1d5) `[get, set]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [Frame](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa5ebbaa55510cf405c37b8993302f535) `[get]` |
| [MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) | [MovementFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afa6dc2e9da85be46cef9f69fb818a14c) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [MovementInputVector](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2797696dfdfcb735d9efbba936375afb) `[get, set]` |
| [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) | [CollisionCapsule](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adb0935843c316fa59f7f847293eebf6f) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [CollisionCapsuleCenter](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a459111e2628ded1999e8a66eda5cd303) `[get]` |
| [MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) | [AgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a69464d7a3ee3da868cbf4d200781f3a2) `[get]` |
| bool | [HeadCameraMode](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4ba02fbfaebaafd6f6bcb938771509c3) `[get, set]` |
| Agent | [MountAgent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a75158e7283825607d1088449f8a425c9) `[get]` |
| [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) | [Detachment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a797cb8361442f90bb1aea0b210c07350) `[get, set]` |
| bool | [IsPaused](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a74fe206e3bb4373525c4c0328f5f4d9b) `[get, set]` |
| bool | [IsDetachedFromFormation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a53dcab6e46b13e81d9d125f49397656a) `[get]` |
| [WatchState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7aa6fe93228ddfb752808bcb9fc48891) | [CurrentWatchState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2eedfe89ad014adc3d93bde63f69449d) `[get]` |
| float | [Defensiveness](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a723c8da96476730a07e93e0c8006bab9) `[get, set]` |
| Formation | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a505d009f2570ea53f43008dcde1f6ef3) `[get, set]` |
| bool | [IsShieldUsageEncouraged](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a877359ba5f121eb7d4a18f9ea4d43407) `[get]` |
| bool | [IsPlayerUnit](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acc295b34df01d3335443e29f01f962ce) `[get]` |
| [AgentControllerType](namespace_tale_worlds_1_1_core.html#a9023c2d9c44f6d3f5d63611a38b3bedb) | [Controller](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac866dda49301a9ab304ae6b3dd54f862) `[get, set]` |
| uint | [ClothingColor1](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0d5b01fd3bb228fdc53d3b4e9de35e68) `[get]` |
|  | Gets or sets the first color applied to the agent's armors and clothes. By default it is the color of the agent's team, but it can be overridden by setting a new value. |
| uint | [ClothingColor2](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1a5147b4c84b9eafed80eec9e91a7ab1) `[get]` |
|  | Gets or sets the second color applied to the agent's armors and clothes. By default it is ClothingColor1, but it can be overridden by setting a new value. |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [LookFrame](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a73f6da923c05c698c37411e882ea14e8) `[get]` |
| float | [LookDirectionAsAngle](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af9b9e17d4caaa6066a2d431d88f1290b) `[get, set]` |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | [LookRotation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b133a2e226bb847dfe9517473e087b0) `[get]` |
| bool | [IsLookDirectionLocked](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af647803960278173184f9bfd41ad9688) `[get, set]` |
| bool | [IsCheering](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5d5856c5fe4f5fb6213748f9f4a6ff94) `[get]` |
| bool | [IsInBeingStruckAction](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6a984818c84033a242582b02c9b7a7f) `[get]` |
| MissionPeer | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e10a41a2278c97680f64e7ad75c2d20) `[get, set]` |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [Character](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a39180c08aabe8810af4a4566769ab38a) `[get, set]` |
| float | [LastDetachmentTickAgentTime](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac4f19091ea1cc6996737c8cba02d560e) `[get]` |
|  | Gets or sets the level of agent. This function should not be used to get the level unless the value differs from its character object. |
| [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e10a41a2278c97680f64e7ad75c2d20) | [OwningAgentMissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad0d7be607c6180892b05a09a75ab052b) `[get]` |
| [MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | [MissionRepresentative](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade465510bfc22a6f02848a898d612793) `[get]` |
| bool | [IsInLadderQueue](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4a9c03ff2d4b89f88475204189fdeb5f) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [LocalPositionError](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6cffe3995258a52bd91e0ca7ea6c6994) `[get]` |
| float | [DetachmentWeight](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a500e0f5ad440482134a26ba7cd84d9d4) `[get]` |
| int | [DetachmentIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6b34ab83e495945a0302caa07ce5559) = -1 `[get]` |
| bool | [IsFormationFrameEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a05432a5ca31ba6c21eb2ca034e4f5b59) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [LookDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abcc839e89e3c8dab42e547ce22057a58) `[get, set]` |
| bool | [IsLookDirectionLow](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac4273cf5b79157c0f618f54d9a31cd7d) `[get]` |
| float | [Health](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af1c81a6b39ad442f84acca466a25ce07) `[get, set]` |
| float | [Age](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1a6299648a0e4d11e799e6436350d7b8) `[get, set]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Velocity](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acc3df36553bb0cf58454d10be726abc8) `[get]` |
| [EventControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429) | [EventControlFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a623ce0ff2bbc3f309ef976f8e4a1f2f1) `[get, set]` |
| [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) | [State](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a26f71b29a39c47dc17220a32f945d0cb) `[get, set]` |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | [WieldedOffhandWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1df517896798fa55aebe26bd8dc697a0) `[get]` |

|  |  |
| --- | --- |
| Events | |
| [OnAgentHealthChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a36ccd47292c6896ed280dbc5ea386080) | [OnAgentHealthChanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a88e7336807895cbecaebc4a36a28135b) |
| [OnMountHealthChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af84128460d915acb53c2460c250ac909) | [OnMountHealthChanged](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a52d7a6ac707df4e97073a1c9a485edae) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565)ActionStage
------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.ActionStage](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565) |

| Enumerator | |
| --- | --- |
| None |  |
| AttackReady |  |
| AttackQuickReady |  |
| AttackRelease |  |
| ReloadMidPhase |  |
| ReloadLastPhase |  |
| Defend |  |
| DefendParry |  |
| NumActionStages |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0)AIScriptedFrameFlags
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) |

| Enumerator | |
| --- | --- |
| None |  |
| GoToPosition |  |
| NoAttack |  |
| ConsiderRotation |  |
| NeverSlowDown |  |
| DoNotRun |  |
| GoWithoutMount |  |
| RangerCanMoveForClearTarget |  |
| InConversation |  |
| Crouch |  |
| Drag |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997)AISpecialCombatModeFlags
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.AISpecialCombatModeFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997) |

| Enumerator | |
| --- | --- |
| None |  |
| AttackEntity |  |
| SurroundAttackEntity |  |
| IgnoreAmmoLimitForRangeCalculation |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995)AIStateFlag
------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.AIStateFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995) : uint |

| Enumerator | |
| --- | --- |
| None | Empty flag. Not necessary to use. |
| Cautious | Cautious state. This state should not be set unless it is a sneak mission. |
| PatrollingCautious | PatrollingCautious state. This state should not be set unless it is a sneak mission. |
| Alarmed | Alarmed state. [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) starts the mission with weapons wielded when this state is given. And the agent sees all enemies when under this state. |
| Paused |  |
| UseObjectMoving | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) has been ordered to use an object and agent is currently moving towards to the object. |
| UseObjectUsing | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) has been ordered to use an object and agent is currently using the object. |
| UseObjectWaiting |  |
| ColumnwiseFollow | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) has been ordered to follow another agent. |
| AlarmStateMask |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7aa6fe93228ddfb752808bcb9fc48891)WatchState
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.WatchState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7aa6fe93228ddfb752808bcb9fc48891) |

| Enumerator | |
| --- | --- |
| Patrolling |  |
| Cautious |  |
| Alarmed |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd592cc5cf557afcc7eaef3ae20a7eae)MortalityState
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.MortalityState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd592cc5cf557afcc7eaef3ae20a7eae) |

| Enumerator | |
| --- | --- |
| Mortal |  |
| Invulnerable |  |
| Immortal |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938)CreationType
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.CreationType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938) |

| Enumerator | |
| --- | --- |
| Invalid | Invalid creation type. This should never be used. |
| FromRoster | Creation from party roster. |
| FromHorseObj | Creation from an item that specifies a horse. |
| FromCharacterObj | Creation from a character. |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429)EventControlFlag
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.EventControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429) : uint |

| Enumerator | |
| --- | --- |
| None |  |
| Dismount |  |
| Mount |  |
| Rear |  |
| Jump |  |
| Wield0 |  |
| Wield1 |  |
| Wield2 |  |
| Wield3 |  |
| Sheath0 |  |
| Sheath1 |  |
| ToggleAlternativeWeapon |  |
| Walk |  |
| Run |  |
| Crouch |  |
| Stand |  |
| Kick |  |
| DoubleTapToDirectionUp |  |
| DoubleTapToDirectionDown |  |
| DoubleTapToDirectionLeft |  |
| DoubleTapToDirectionRight |  |
| DoubleTapToDirectionMask |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5262a134add2c2f514741a32df8efc52)FacialAnimChannel
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.FacialAnimChannel](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5262a134add2c2f514741a32df8efc52) |

| Enumerator | |
| --- | --- |
| High |  |
| Mid |  |
| Low |  |
| num\_facial\_anim\_channels |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016)ActionCodeType
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.ActionCodeType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016) |

| Enumerator | |
| --- | --- |
| Other |  |
| DefendFist |  |
| DefendShield |  |
| DefendForward2h |  |
| DefendUp2h |  |
| DefendRight2h |  |
| DefendLeft2h |  |
| DefendForward1h |  |
| DefendUp1h |  |
| DefendRight1h |  |
| DefendLeft1h |  |
| DefendForwardStaff |  |
| DefendUpStaff |  |
| DefendRightStaff |  |
| DefendLeftStaff |  |
| ReadyRanged |  |
| ReleaseRanged |  |
| ReleaseThrowing |  |
| Reload |  |
| ReadyMelee |  |
| ReleaseMelee |  |
| ParriedMelee |  |
| BlockedMelee |  |
| Fall |  |
| JumpStart |  |
| Jump |  |
| JumpEnd |  |
| JumpEndHard |  |
| Kick |  |
| KickContinue |  |
| KickHit |  |
| WeaponBash |  |
| PassiveUsage |  |
| EquipUnequip |  |
| SwitchAlternative |  |
| Idle |  |
| Guard |  |
| Mount |  |
| Dismount |  |
| Dash |  |
| MountQuickStop |  |
| HitObject |  |
| Sit |  |
| SitOnTheFloor |  |
| SitOnAThrone |  |
| LadderRaise |  |
| LadderRaiseEnd |  |
| Rear |  |
| StrikeLight |  |
| StrikeMedium |  |
| StrikeHeavy |  |
| StrikeKnockBack |  |
| MountStrike |  |
| Count |  |
| StrikeBegin |  |
| StrikeEnd |  |
| DefendAllBegin |  |
| DefendAllEnd |  |
| AttackMeleeAllBegin |  |
| AttackMeleeAllEnd |  |
| AttackMeleeAndRangedAllBegin |  |
| AttackMeleeAndRangedAllEnd |  |
| CombatAllBegin |  |
| CombatAllEnd |  |
| JumpAllBegin |  |
| JumpAllEnd |  |
| FallAllBegin |  |
| FallAllEnd |  |
| KickAllBegin |  |
| KickAllEnd |  |
| AlternativeAttackAllBegin |  |
| AlternativeAttackAllEnd |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e258f837e094c8fd60eaf08c57e1a61)GuardMode
----------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.GuardMode](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e258f837e094c8fd60eaf08c57e1a61) |

| Enumerator | |
| --- | --- |
| MarkForDeletion |  |
| None |  |
| Up |  |
| Down |  |
| Left |  |
| Right |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6de)HandIndex
----------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.HandIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6de) |

| Enumerator | |
| --- | --- |
| MainHand |  |
| OffHand |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7)KillInfo
---------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.KillInfo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7) : [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) |

| Enumerator | |
| --- | --- |
| Invalid |  |
| Headshot |  |
| CouchedLance |  |
| Punch |  |
| MountHit |  |
| Bow |  |
| Crossbow |  |
| ThrowingAxe |  |
| ThrowingKnife |  |
| Javelin |  |
| Stone |  |
| Pistol |  |
| Musket |  |
| OneHandedSword |  |
| TwoHandedSword |  |
| OneHandedAxe |  |
| TwoHandedAxe |  |
| Mace |  |
| Spear |  |
| Morningstar |  |
| Maul |  |
| Backstabbed |  |
| Gravity |  |
| ShieldBash |  |
| WeaponBash |  |
| Kick |  |
| TeamSwitch |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aae8de26b7a3c90f2606b38ac9e062cac)MovementBehaviorType
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.MovementBehaviorType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aae8de26b7a3c90f2606b38ac9e062cac) |

| Enumerator | |
| --- | --- |
| Engaged |  |
| Idle |  |
| Flee |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797)MovementControlFlag
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) : uint |

| Enumerator | |
| --- | --- |
| None |  |
| Forward |  |
| Backward |  |
| StrafeRight |  |
| StrafeLeft |  |
| TurnRight |  |
| TurnLeft |  |
| AttackLeft |  |
| AttackRight |  |
| AttackUp |  |
| AttackDown |  |
| DefendLeft |  |
| DefendRight |  |
| DefendUp |  |
| DefendDown |  |
| DefendAuto |  |
| DefendBlock |  |
| Action |  |
| AttackMask |  |
| DefendMask |  |
| DefendDirMask |  |
| MoveMask |  |
| MaxValue |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6bf6f204fa49aaa08ddab2434120d27)UnderAttackType
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.UnderAttackType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6bf6f204fa49aaa08ddab2434120d27) |

| Enumerator | |
| --- | --- |
| NotUnderAttack |  |
| UnderMeleeAttack |  |
| UnderRangedAttack |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a)UsageDirection
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) |

| Enumerator | |
| --- | --- |
| None |  |
| AttackUp |  |
| AttackDown |  |
| AttackLeft |  |
| AttackRight |  |
| AttackBegin |  |
| AttackEnd |  |
| DefendUp |  |
| DefendDown |  |
| DefendLeft |  |
| DefendRight |  |
| DefendBegin |  |
| DefendAny |  |
| DefendEnd |  |
| AttackAny |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835e)WeaponWieldActionType
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.WeaponWieldActionType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835e) |

| Enumerator | |
| --- | --- |
| WithAnimation | If you use this action type the wielding or sheathing action can be interrupted. And wielding or sheathing action will not be instant. If you call GetWieldedItemIndex immediately result won't be new slotIndex. |
| Instant | This action type is guarantees the wielding and sheathing. (if there is a valid weapon on the slot. The animation won't play. The item will instantly appear/disappear. |
| InstantAfterPickUp | This action is similar to Instant type, but it ensures that the picked up item is reloaded if it is consumable. |
| WithAnimationUninterruptible | This action type is guaranties the wielding and sheathing. The animation will play. |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713)StopUsingGameObjectFlags
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Agent.StopUsingGameObjectFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713) : byte |

| Enumerator | |
| --- | --- |
| None |  |
| AutoAttachAfterStoppingUsingGameObject |  |
| DoNotWieldWeaponAfterStoppingUsingGameObject |  |
| DefendAfterStoppingUsingGameObject |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a36ccd47292c6896ed280dbc5ea386080)OnAgentHealthChangedDelegate()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.Agent.OnAgentHealthChangedDelegate | ( | Agent | *agent*, |
|  |  | float | *oldHealth*, |
|  |  | float | *newHealth* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af84128460d915acb53c2460c250ac909)OnMountHealthChangedDelegate()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.Agent.OnMountHealthChangedDelegate | ( | Agent | *agent*, |
|  |  | Agent | *mount*, |
|  |  | float | *oldHealth*, |
|  |  | float | *newHealth* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad987ba74a5b3c9a503c88091d2cecf0c)OnMainAgentWieldedItemChangeDelegate()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.Agent.OnMainAgentWieldedItemChangeDelegate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a666e7d0dbb6061868634cb33444c3529)GetHasOnAiInputSetCallback()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.GetHasOnAiInputSetCallback | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae093a8b2c913ff99da6a07ab224e8fcf)SetHasOnAiInputSetCallback()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetHasOnAiInputSetCallback | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a741394ee20c7e5d03964fdcffc69c8ea)GetMissileRangeWithHeightDifferenceAux()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetMissileRangeWithHeightDifferenceAux | ( | float | *targetZ* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab3df879b37aa2163281cb6d5c6fd6abb)GetSoundAndCollisionInfoClassName()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.Agent.GetSoundAndCollisionInfoClassName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a997ca2efb2281af730965fce55eb0ec8)UpdateAgentStats()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.UpdateAgentStats | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aeaadc52524004421fd79e2dab2c4f2ed)GetWeaponInaccuracy()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetWeaponInaccuracy | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *weaponSlotIndex*, |
|  |  | int | *weaponUsageIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa13fb68ec376716cbe8cac14171a375a)DebugGetHealth()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.DebugGetHealth | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0cf381f211d2fb4ba1db6e0a1f624027)SetTargetPosition()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetTargetPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a545e7633acdbee2b5a834b4b822a7585)SetTargetZ()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetTargetZ | ( | float | *targetZ* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1af1a6704b86f6a54f3f6242fd02b152)SetTargetUp()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetTargetUp | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetUp* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a11b15afbee1cddaad444c5db6979af05)SetCanLeadFormationsRemotely()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetCanLeadFormationsRemotely | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a958a650d82dbe6b181ea0f575ccae011)SetAveragePingInMilliseconds()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetAveragePingInMilliseconds | ( | double | *averagePingInMilliseconds* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a67f2730f422ba396c92e2b25f9d45c8b)SetTargetPositionAndDirection()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetTargetPositionAndDirection | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *targetPosition*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetDirection* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aad38749faea7cb6254876887f3f3b706)AddAcceleration()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.AddAcceleration | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *acceleration* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab2abccef274cd1c35b8489a6e5c906ea)SetWeaponGuard()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetWeaponGuard | ( | [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | *direction* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a50ef37144e7700f2857b11d1c08c71d6)SetWatchState()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetWatchState | ( | [WatchState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7aa6fe93228ddfb752808bcb9fc48891) | *watchState* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3f8117d69f30ae9125674e983d9d95ea)IsAlarmStateNormal()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsAlarmStateNormal | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a989ae7c8c95441f909ce0dd34146cb44)IsCautious()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsCautious | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae18078b09efb0d3c42cfdec145d723bb)IsPatrollingCautious()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsPatrollingCautious | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adc0b4d54853e4830230e3c6751a26f2c)IsAlarmed()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsAlarmed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af3cb25fd568eb9d98945ab54bc07d7d6)SetAlarmState()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.SetAlarmState | ( | [AIStateFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995) | *alarmStateFlag* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5fc9050be6c4bb26d6602aecd920133c)SetTargetFormationIndex()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetTargetFormationIndex | ( | int | *targetFormationIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa03f4848aa03d711eda2c47a8e6d31cb)StartRagdollAsCorpse()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.StartRagdollAsCorpse | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acbbbbbb206238ae5dbd74e0af9e852a6)EndRagdollAsCorpse()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.EndRagdollAsCorpse | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4a1bb8657e13aac2476a61ab1c1a23e1)IsAddedAsCorpse()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsAddedAsCorpse | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aee0594b02b222529f1a72e3867a53d44)AddAsCorpse()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.AddAsCorpse | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a27fdcbea669627308b69aceba76534e8)SetOverridenStrikeAndDeathAction()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetOverridenStrikeAndDeathAction | ( | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *strikeAction*, |
|  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *deathAction* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0025c49184af7e209c89035c80254365)ApplyForceOnRagdoll()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ApplyForceOnRagdoll | ( | [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) | *boneIndex*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *force* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7c71e5a3b58a14c2c133251857dbc27b)SetVelocityLimitsOnRagdoll()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetVelocityLimitsOnRagdoll | ( | float | *linearVelocityLimit*, |
|  |  | float | *angularVelocityLimit* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad18e2628ed773d8057dfd8dbf3a2c33b)GetAILastSuspiciousPosition()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Agent.GetAILastSuspiciousPosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2da091ca11fb36c7097d53807d5e6aad)SetAILastSuspiciousPosition()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetAILastSuspiciousPosition | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *lastSuspiciousPosition*, |
|  |  | bool | *checkNavMeshForCorrection* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae64bcdac326ab0d35ce49df2a7dfcc68)GetAIMoveDestination()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Agent.GetAIMoveDestination | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af7d6bac57f9a5a03a55ee07c8361e77c)FindLongestDirectMoveToPosition()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Agent.FindLongestDirectMoveToPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *targetPosition*, |
|  |  | bool | *checkBoundaries*, |
|  |  | bool | *checkFriendlyAgents*, |
|  |  | out bool | *isCollidedWithAgent* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abfaf21cb49c6fdde171bed3c7ff01cd5)GetAIMoveStartTolerance()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetAIMoveStartTolerance | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1a12894b7c03ca54ac639fa0ff6f50b2)GetAIMoveStopTolerance()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetAIMoveStopTolerance | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7ef60245195ed3735787f7088a711b6a)IsAIAtMoveDestination()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsAIAtMoveDestination | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5667047207aa14bd26fb4d45a2f89e5e)SetFormationBanner()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetFormationBanner | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *banner* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a99a3273a37fe3cf071858d9c80458727)SetIsAIPaused()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetIsAIPaused | ( | bool | *isPaused* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa5b3f392f3f08a241bd5000dcad84308)ResetEnemyCaches()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ResetEnemyCaches | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa60c8c0017cbdb039df3770713e015a3)SetTargetPositionSynched()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetTargetPositionSynched | ( | ref [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *targetPosition* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aaf0ff7af7106149339574861c6660fa4)SetTargetPositionAndDirectionSynched()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetTargetPositionAndDirectionSynched | ( | ref [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *targetPosition*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetDirection* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a73c5aec27098ede8cbec716fcfa736d8)SetBodyArmorMaterialType()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetBodyArmorMaterialType | ( | [ArmorComponent.ArmorMaterialTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99) | *bodyArmorMaterialType* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4199468dbb26049f6fc1c78e6aadc44a)SetUsedGameObjectForClient()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetUsedGameObjectForClient | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usedObject* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae4d71697e3c5cd92634d96aa44aa8ddb)SetTeam()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetTeam | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a13bb441adc4062eddd4b9548e43b5db5) | *team*, |
|  |  | bool | *sync* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4eff61cb370192db1c7915bd37b3235a)SetClothingColor1()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetClothingColor1 | ( | uint | *color* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3ca6dffe0f61f68762a85094285edddf)SetClothingColor2()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetClothingColor2 | ( | uint | *color* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af0403a6beec3df34166b0b1a743d2475)SetWieldedItemIndexAsClient()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetWieldedItemIndexAsClient | ( | [HandIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6de) | *handIndex*, |
|  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equipmentIndex*, |
|  |  | bool | *isWieldedInstantly*, |
|  |  | bool | *isWieldedOnSpawn*, |
|  |  | int | *mainHandCurrentUsageIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab7c862f6adfd447cde4d51322c1ff95f)SetPreciseRangedAimingEnabled()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetPreciseRangedAimingEnabled | ( | bool | *set* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71023a9b0e08bf05349b67ec1287c464)SetAsConversationAgent()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetAsConversationAgent | ( | bool | *set* | ) |  |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#adf3ee61583e75029964d8aae20e968e3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0b8e797732b2e5b47c113f6a06287c5a)SetCrouchMode()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetCrouchMode | ( | bool | *set* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acf9f9a87522a7314c0448bfbd5506074)SetWeaponAmountInSlot()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetWeaponAmountInSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equipmentSlot*, |
|  |  | short | *amount*, |
|  |  | bool | *enforcePrimaryItem* ) |

Parameters
:   |  |  |
    | --- | --- |
    | equipmentSlot | Index of the equipment slot. |
    | amount | Amount of weapon to be set. |
    | enforcePrimaryItem |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa5d0b01387b44d908b98cdec582a2de8)SetDraggingMode()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetDraggingMode | ( | bool | *set* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9004b9c3ba9082c1601cc8cfb4fa2f06)SetWeaponAmmoAsClient()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetWeaponAmmoAsClient | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equipmentIndex*, |
|  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *ammoEquipmentIndex*, |
|  |  | short | *ammo* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a69079eecf599ee6dbe2603f983dea843)SetWeaponReloadPhaseAsClient()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetWeaponReloadPhaseAsClient | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equipmentIndex*, |
|  |  | short | *reloadState* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab394e917cfdba1ddc7d1e2c5e1abda90)SetReloadAmmoInSlot()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetReloadAmmoInSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equipmentIndex*, |
|  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *ammoSlotIndex*, |
|  |  | short | *reloadedAmmo* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7b146434951b8614143028e9463cf707)SetUsageIndexOfWeaponInSlotAsClient()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetUsageIndexOfWeaponInSlotAsClient | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | int | *usageIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae7e5995c4c47cc058a32aecc02f4d333)SetRandomizeColors()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetRandomizeColors | ( | bool | *shouldRandomize* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8f586847cd2ac2ba6a4516877f8519da)SetFormationFrameDisabled()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetFormationFrameDisabled | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6ba986b0992efab247fc4c18c735411d)SetFormationFrameEnabled()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetFormationFrameEnabled | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *positionVelocity*, |
|  |  | float | *formationDirectionEnforcingFactor* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a247b71cf45821133fda4970275ab1dda)SetShouldCatchUpWithFormation()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetShouldCatchUpWithFormation | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a31b470be0c48d437dcbd75d8e5272eb1)SetFormationIntegrityData()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetFormationIntegrityData | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *currentFormationDirection*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *averageVelocityOfCloseAgents*, |
|  |  | float | *averageMaxUnlimitedSpeedOfCloseAgents*, |
|  |  | float | *deviationOfPositions*, |
|  |  | bool | *shouldKeepWithFormationInsteadOfMovingToAgent* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a83b77c8da9a07847e1455a3f5ac5c693)IsCrouchingAllowed()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsCrouchingAllowed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6a06b5477d9769bc2118c9386264570d)SetCurrentActionProgress()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetCurrentActionProgress | ( | int | *channelNo*, |
|  |  | float | *progress* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acfc7c127bfdd95d62ae69e731b42b73d)SetCurrentActionSpeed()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetCurrentActionSpeed | ( | int | *channelNo*, |
|  |  | float | *speed* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6f0581695bd0e8ca8fae78862c762bdd)SetActionChannel()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.SetActionChannel | ( | int | *channelNo*, |
|  |  | in [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndexCache*, |
|  |  | bool | *ignorePriority* = false, |
|  |  | [AnimFlags](namespace_tale_worlds_1_1_mount_and_blade.html#aee58182af722eaf22dec720de2cc5818) | *additionalFlags* = 0, |
|  |  | float | *blendWithNextActionFactor* = 0::0f, |
|  |  | float | *actionSpeed* = 1::0f, |
|  |  | float | *blendInPeriod* = -0::2f, |
|  |  | float | *blendOutPeriodToNoAnim* = 0::4f, |
|  |  | float | *startProgress* = 0::0f, |
|  |  | bool | *useLinearSmoothing* = false, |
|  |  | float | *blendOutPeriod* = -0::2f, |
|  |  | int | *actionShift* = 0, |
|  |  | bool | *forceFaceMorphRestart* = true ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3ab0c5a9ce157995dec8c795d1da5647)SetAttackState()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetAttackState | ( | int | *attackState* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1626fc1b3621802407b19d84129c658e)SetAIBehaviorParams()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetAIBehaviorParams | ( | [HumanAIComponent.AISimpleBehaviorKind](class_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component.html#af5bb0a806d07de4fe21691beca41b4f4) | *behavior*, |
|  |  | float | *y1*, |
|  |  | float | *x2*, |
|  |  | float | *y2*, |
|  |  | float | *x3*, |
|  |  | float | *y3* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab5c704411537cae6c8f1f3e676b2efb5)SetAllBehaviorParams()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetAllBehaviorParams | ( | [HumanAIComponent.BehaviorValues](struct_tale_worlds_1_1_mount_and_blade_1_1_human_a_i_component_1_1_behavior_values.html)[] | *behaviorParams* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2f86d4c29e5976fe9fed75ec482f09ab)SetMovementDirection()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetMovementDirection | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7d05e47996cc56b78a87e83b81f52500)SetScriptedFlags()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetScriptedFlags | ( | [AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) | *flags* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a236e2ce6925bcc1add9c6207abe1d896)SetScriptedCombatFlags()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetScriptedCombatFlags | ( | [AISpecialCombatModeFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997) | *flags* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a00030970dcc333117c53d47cfa27dde7)SetScriptedPositionAndDirection()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetScriptedPositionAndDirection | ( | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *scriptedPosition*, |
|  |  | float | *scriptedDirection*, |
|  |  | bool | *addHumanLikeDelay*, |
|  |  | [AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) | *additionalFlags* = [AIScriptedFrameFlags::None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a6adf97f83acf6453d4a6a4b1070f3754) ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a00a95c095bdc1e7141898ba546798170)SetScriptedPosition()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetScriptedPosition | ( | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, |
|  |  | bool | *addHumanLikeDelay*, |
|  |  | [AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) | *additionalFlags* = [AIScriptedFrameFlags::None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0a6adf97f83acf6453d4a6a4b1070f3754) ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae51f0723a19f32d1449afb112ac611ee)SetScriptedTargetEntity()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetScriptedTargetEntity | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *target*, |
|  |  | [AISpecialCombatModeFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997) | *additionalFlags* = [AISpecialCombatModeFlags::None](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997a6adf97f83acf6453d4a6a4b1070f3754), |
|  |  | bool | *ignoreIfAlreadyAttacking* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a78f20e5704b2dc77c1f679ab456b7a0d)SetAgentExcludeStateForFaceGroupId()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetAgentExcludeStateForFaceGroupId | ( | int | *faceGroupId*, |
|  |  | bool | *isExcluded* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade2c1fc0612f12c08527cbff3985ff06)SetLookAgent()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetLookAgent | ( | Agent | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8de385419aa70b518604c36eecf7d3d0)SetInteractionAgent()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetInteractionAgent | ( | Agent | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af505898446c07486a5bfe053a40f882c)SetLookToPointOfInterest()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetLookToPointOfInterest | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *point* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7a6cf64f8122194c2ae71db07fa7192e)SetAgentFlags()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetAgentFlags | ( | [AgentFlag](namespace_tale_worlds_1_1_core.html#a4eadec2c483252505ae0d0ab98de39fe) | *agentFlags* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a567160dfb81e5a934dc8bea58b5fe1eb)SetSelectedMountIndex()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetSelectedMountIndex | ( | int | *mountIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0c86369b82e5074eb691f8c487733d3f)GetFiringOrder()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Agent.GetFiringOrder | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a949230946ba1bd5d378a687fe09dac61)GetRidingOrder()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Agent.GetRidingOrder | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a635731ab06eefbf0d01aacd473eb273a)GetSelectedMountIndex()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Agent.GetSelectedMountIndex | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a09df26b15afbf31fa73bf6f353e95914)GetTargetFormationIndex()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Agent.GetTargetFormationIndex | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa8da52f1023b1339626627880b4a1abd)SetFiringOrder()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetFiringOrder | ( | [FiringOrder.RangedWeaponUsageOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_firing_order.html#a5ca98092070b61d7f2b7f747b225e729) | *order* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a517dfe773b49de56cf4b4dff1e048675)SetRidingOrder()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetRidingOrder | ( | [RidingOrder.RidingOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_riding_order.html#a310553d7b0a9100022168f5e2bec6cac) | *order* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac4194ee0dbf69104f33a344dbc22e9fc)SetAgentFacialAnimation()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetAgentFacialAnimation | ( | [FacialAnimChannel](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5262a134add2c2f514741a32df8efc52) | *channel*, |
|  |  | string | *animationName*, |
|  |  | bool | *loop* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a96661987f337a0dc596178aeea539bfb)SetHandInverseKinematicsFrame()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.SetHandInverseKinematicsFrame | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *leftGlobalFrame*, |
|  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *rightGlobalFrame* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a35d2200cd4732ff33b68d8bf3b654b46)SetNativeFormationNo()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetNativeFormationNo | ( | int | *formationNo* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8111f3c73eb1fd67f7191bf8a1ddd123)SetDirectionChangeTendency()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetDirectionChangeTendency | ( | float | *tendency* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad8ca76863c7c39a6baa2be18a145bcf2)GetBattleImportance()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetBattleImportance | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ada322002a94e7621db0cafb19d3fc967)GetTraitsMask()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TroopTraitsMask](namespace_tale_worlds_1_1_core.html#af7216d1fb38509206a8b77172668a665) TaleWorlds.MountAndBlade.Agent.GetTraitsMask | ( |  | ) |  |

If a static mask is requested, the mask can be queried from agent's character instead

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2e424c7e130ff6e0447c8617df9076ac)SetSynchedPrefabComponentVisibility()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetSynchedPrefabComponentVisibility | ( | int | *componentIndex*, |
|  |  | bool | *visibility* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a41f27b0b5d332b79b032b27cc672a7a1)SetActionSet()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetActionSet | ( | ref [AnimationSystemData](struct_tale_worlds_1_1_mount_and_blade_1_1_animation_system_data.html) | *animationSystemData* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab51fc4889084686b8995a2fd2bce809d)SetColumnwiseFollowAgent()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetColumnwiseFollowAgent | ( | Agent | *followAgent*, |
|  |  | ref [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *followPosition* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1d30976ef35d60507081fbe524cace0e)SetHandInverseKinematicsFrameForMissionObjectUsage()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetHandInverseKinematicsFrameForMissionObjectUsage | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *localIKFrame*, |
|  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *boundEntityGlobalFrame*, |
|  |  | float | *animationHeightDifference* = 0::0f ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abaa6493145c1fb8dea0294641dfbe2a9)SetWantsToYell()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetWantsToYell | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9b1e833b65e17420663c62bd26a0b695)SetCapeClothSimulator()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetCapeClothSimulator | ( | [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | *clothSimulatorComponent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aee331d2defbacac544baec0775245a98)GetTargetPosition()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Agent.GetTargetPosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7cba58ffad7c74ef9afa3b9603319564)GetTargetDirection()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.GetTargetDirection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8723e18f1d6b856b3cef0453ed02be9e)GetAimingTimer()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetAimingTimer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a04026a929dd6b4b757734647734ff0fe)GetInteractionDistanceToUsable()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetInteractionDistanceToUsable | ( | [IUsable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_usable.html) | *usable* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae27eac28789e19d43459a8e31de7721e)GetInfoTextForBeingNotInteractable()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.Agent.GetInfoTextForBeingNotInteractable | ( | Agent | *userAgent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#af5595369849cf9b7ba326828eab1c33d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0650efd14a1a10cba1c5202347bff1d0)GetController< T >()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.MountAndBlade.Agent.GetController< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[AgentController](class_tale_worlds_1_1_mount_and_blade_1_1_agent_controller.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af53ca97afd22b49f4b71a456f19af015)GetPrimaryWieldedItemIndex()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) TaleWorlds.MountAndBlade.Agent.GetPrimaryWieldedItemIndex | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1b26c562447d15a53479a76ff9fdbbd7)GetOffhandWieldedItemIndex()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) TaleWorlds.MountAndBlade.Agent.GetOffhandWieldedItemIndex | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a092a6f52ef354b5724208da81e5008fa)GetMaximumForwardUnlimitedSpeed()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetMaximumForwardUnlimitedSpeed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5c1fbf8210e89616442c380614e91a89)GetDescriptionText()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.Agent.GetDescriptionText | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *gameEntity* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#ae296d89b1b2262987e2a6c7bb88368f8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2e3a057761c51c56c571874c79e889f1)GetWeaponEntityFromEquipmentSlot()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.MountAndBlade.Agent.GetWeaponEntityFromEquipmentSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1bd19e6e777682e30ecf7a8cbd220245)GetRetreatPos()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Agent.GetRetreatPos | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd35778000079d0b2e2e23b8f158cf9e)GetScriptedFlags()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [AIScriptedFrameFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5b0c08e8e26361a41ebdaba52aa3fa0) TaleWorlds.MountAndBlade.Agent.GetScriptedFlags | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aadddc549a07cb55e0c4258b892890a64)GetScriptedCombatFlags()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [AISpecialCombatModeFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23d0e408b40d6188320acaaebd1b6997) TaleWorlds.MountAndBlade.Agent.GetScriptedCombatFlags | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3325336183af3749aa6126378963fa6f)GetSteppedEntity()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.MountAndBlade.Agent.GetSteppedEntity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aec3fcc057a71bf5e2741edcb138a1396)GetSteppedRootEntity()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.MountAndBlade.Agent.GetSteppedRootEntity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a168ad108e69146dbdd459df5ef1b9911)GetSteppedBodyFlags()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) TaleWorlds.MountAndBlade.Agent.GetSteppedBodyFlags | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a77f8043dc1b2b8ba93398bc73261676d)GetCurrentAnimationFlag()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [AnimFlags](namespace_tale_worlds_1_1_mount_and_blade.html#aee58182af722eaf22dec720de2cc5818) TaleWorlds.MountAndBlade.Agent.GetCurrentAnimationFlag | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2d43b8776b00c21f5b21b814b62e474a)GetCurrentAction()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) TaleWorlds.MountAndBlade.Agent.GetCurrentAction | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a295c3e63008ed4de9f85fad7f484a912)GetCurrentActionType()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ActionCodeType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b8dc8a71a5b27a6fe36ea9af62f9016) TaleWorlds.MountAndBlade.Agent.GetCurrentActionType | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a31d7e32745b933ce9ad868e8982bae46)GetCurrentActionStage()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ActionStage](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a752a2a035d41490beda488b75183a565) TaleWorlds.MountAndBlade.Agent.GetCurrentActionStage | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b20c408baf3b019d0e86b41a01399bd)GetCurrentActionDirection()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) TaleWorlds.MountAndBlade.Agent.GetCurrentActionDirection | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6d9387cff0945022ea52346d08315602)GetCurrentActionPriority()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Agent.GetCurrentActionPriority | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa78c8c5f1ddc903bfa2246b564675520)GetCurrentActionProgress()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetCurrentActionProgress | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5144ddb5d405c6bd59fd9e8ea6aecea0)GetActionChannelWeight()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetActionChannelWeight | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4e71296614bc608c8befd1fd9294faa3)GetActionChannelCurrentActionWeight()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetActionChannelCurrentActionWeight | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab6615ac87dab4d29c67c2bfd486c3ec8)GetWorldFrame()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) TaleWorlds.MountAndBlade.Agent.GetWorldFrame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a607bd6ecfec428503692f58d98ad6207)GetLookDownLimit()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetLookDownLimit | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2e2997d71be5d283a9c55b1396254cf8)GetEyeGlobalHeight()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetEyeGlobalHeight | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6591bc6bdd589cd90fd302de8bdb2c76)GetMaximumSpeedLimit()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetMaximumSpeedLimit | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad2421cb3d08a72be1dc5672614c90894)GetCurrentVelocity()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Agent.GetCurrentVelocity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9e572c78cc0641e096e88ee40e65300e)GetTurnSpeed()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetTurnSpeed | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af5bb712664e70b5b4ee2e767078768fc)GetCurrentSpeedLimit()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetCurrentSpeedLimit | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#add888f689e1bcd932bcf8d5e33aaa43e)GetRealGlobalVelocity()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.GetRealGlobalVelocity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a66da8650b265a1d32ea0d40faff1e8bc)GetAverageRealGlobalVelocity()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.GetAverageRealGlobalVelocity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6aa6efb13a9ed6d5a04caea285d81b06)GetMovementDirection()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Agent.GetMovementDirection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6b6e0c90b51365da26c49c1f333dd765)GetCurWeaponOffset()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.GetCurWeaponOffset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad84e31dbb2a3cedb273d9af2a00c4d16)GetIsLeftStance()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.GetIsLeftStance | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7bde3c8b3ab1071503f9ff8b50d5b8ae)GetPathDistanceToPoint()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetPathDistanceToPoint | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *point* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a489eab387fc7452d49c77d67ebb48bc2)GetCurrentNavigationFaceId()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Agent.GetCurrentNavigationFaceId | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac4c896233737bd81d3e1d8b656eba359)GetWorldPosition()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) TaleWorlds.MountAndBlade.Agent.GetWorldPosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a671c2dcf27aeeb768fd5926bc096ccfc)GetGroundMaterialForCollisionEffect()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Agent.GetGroundMaterialForCollisionEffect | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abe9a80b18eea78bfedf00640e918c680)GetLookAgent()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Agent TaleWorlds.MountAndBlade.Agent.GetLookAgent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac1c2a3925eafad3c962f14298b4493cc)GetTargetAgent()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Agent TaleWorlds.MountAndBlade.Agent.GetTargetAgent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a996c1abcc925255f00d6bf6a3d44b3e5)SetTargetAgent()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetTargetAgent | ( | Agent | *agent* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | agent | Target agent |

Returns

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2714b9c65b7d36a674e02f548aab8b93)SetAutomaticTargetSelection()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetAutomaticTargetSelection | ( | bool | *enable* | ) |  |

Returns

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aadcb8a8a6880dfed30711f8b6056ea00)GetAgentFlags()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [AgentFlag](namespace_tale_worlds_1_1_core.html#a4eadec2c483252505ae0d0ab98de39fe) TaleWorlds.MountAndBlade.Agent.GetAgentFlags | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4d0ce5b06434ac55c2e3e2ee3b5c04c4)GetAgentFacialAnimation()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.Agent.GetAgentFacialAnimation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afed43009370cf6a432c2ec467be1f59d)GetAgentVoiceDefinition()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.Agent.GetAgentVoiceDefinition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a684b3494dd25f7c5d0edce47346402c2)GetEyeGlobalPosition()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.GetEyeGlobalPosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aeff5e785dd19c40ef2aeee0b29d6056c)GetChestGlobalPosition()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.GetChestGlobalPosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adb1bbda7c2b8b4aec22af6ce630380bd)GetDefendMovementFlag()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) TaleWorlds.MountAndBlade.Agent.GetDefendMovementFlag | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a189ab0e683bead50badf280ca36b6702)GetAttackDirection()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) TaleWorlds.MountAndBlade.Agent.GetAttackDirection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0b8b7b24fb7223fa96cc881cc9828f28)GetWieldedWeaponInfo()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WeaponInfo](struct_tale_worlds_1_1_mount_and_blade_1_1_weapon_info.html) TaleWorlds.MountAndBlade.Agent.GetWieldedWeaponInfo | ( | [HandIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6de) | *handIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8fa03e95663811e636a471e68a8e8325)GetBodyRotationConstraint()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Agent.GetBodyRotationConstraint | ( | int | *channelIndex* = 1 | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a880f85e53db08c36ff95b65e41ff4239)GetTotalEncumbrance()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetTotalEncumbrance | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad8f18b2d47486cffdb3189d00a3d1043)GetTotalMass()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetTotalMass | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3be313217c523c8798a65897a75ee962)GetComponent< T >()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.MountAndBlade.Agent.GetComponent< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acaa6ed12bb07bbcea2e96dc65eb0dbf1)GetAgentDrivenPropertyValue()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetAgentDrivenPropertyValue | ( | [DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) | *type* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a77bd0663161a71a6add5bec820feccce)GetSteppedMachine()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) TaleWorlds.MountAndBlade.Agent.GetSteppedMachine | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a99964b94d87688b28e0d80bf62bca6b6)GetAttachedWeaponsCount()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Agent.GetAttachedWeaponsCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5ae6265a6c09a8355501d798e0185e75)GetAttachedWeapon()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) TaleWorlds.MountAndBlade.Agent.GetAttachedWeapon | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aaf02f897f2b9c76dfde2e325b6a9f6d2)GetAttachedWeaponFrame()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Agent.GetAttachedWeaponFrame | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a724ba3f4f7694b77556d3e057f233316)GetAttachedWeaponBoneIndex()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) TaleWorlds.MountAndBlade.Agent.GetAttachedWeaponBoneIndex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab9bb2ca9cd41cc3f8b1e5fcf9d23e50a)DeleteAttachedWeapon()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.DeleteAttachedWeapon | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adb55e51b97aca58f5dc04b244baa62f1)HasRangedWeapon()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.HasRangedWeapon | ( | bool | *checkHasAmmo* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9539afd9125f6017c28c92de4be67686)GetBoneEntitialFrameAtAnimationProgress()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Agent.GetBoneEntitialFrameAtAnimationProgress | ( | [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) | *boneIndex*, |
|  |  | int | *animationIndex*, |
|  |  | float | *progress* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a714e7898fd47ee9798e30e79472e3287)GetFormationFileAndRankInfo() [1/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.GetFormationFileAndRankInfo | ( | out int | *fileIndex*, |
|  |  | out int | *rankIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8611e3264d293520dfa3c3911730b199)GetFormationFileAndRankInfo() [2/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.GetFormationFileAndRankInfo | ( | out int | *fileIndex*, |
|  |  | out int | *rankIndex*, |
|  |  | out int | *fileCount*, |
|  |  | out int | *rankCount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6ec15c9ddc0180300351e8c43adcf7af)SetMortalityState()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetMortalityState | ( | [MortalityState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd592cc5cf557afcc7eaef3ae20a7eae) | *newState* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3b9e739e24065c4ff28c41761f2c6ea6)ToggleInvulnerable()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ToggleInvulnerable | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a119c69f0d50d7f153d58a887349b38a2)GetArmLength()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetArmLength | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab478fe1b2b1dd65a0bd297b0845cc2ab)GetArmWeight()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetArmWeight | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6aa66e62728880faa0089ad18a0208b4)GetRunningSimulationDataUntilMaximumSpeedReached()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.GetRunningSimulationDataUntilMaximumSpeedReached | ( | ref float | *combatAccelerationTime*, |
|  |  | ref float | *maxSpeed*, |
|  |  | float[] | *speedValues* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5fcacba4ed4b34b7688b69984eacb6e7)SetMaximumSpeedLimit()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetMaximumSpeedLimit | ( | float | *maximumSpeedLimit*, |
|  |  | bool | *isMultiplier* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac051e9ca2794e52dec6f36703fd3cef2)GetBaseArmorEffectivenessForBodyPart()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetBaseArmorEffectivenessForBodyPart | ( | [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) | *bodyPart* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a326c4c20589587b4d66e52003ef5d9f2)GetLastTargetVisibilityState()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [AITargetVisibilityState](namespace_tale_worlds_1_1_mount_and_blade.html#a011beb62f538ed3c340ddbb2cff1bf13) TaleWorlds.MountAndBlade.Agent.GetLastTargetVisibilityState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a89292941925526e29b57e6c1b9eb749d)GetMissileRange()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetMissileRange | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a89a0a0f7e52df01107bcd4dccb326bc0)SetAgentIdleAnimationStatus()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetAgentIdleAnimationStatus | ( | bool | *idleEnabled* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a66f9074ce6834f69205cfb3db4efb91b)GetWeaponToReplaceOnQuickAction()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.MountAndBlade.Agent.GetWeaponToReplaceOnQuickAction | ( | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *spawnedItem*, |
|  |  | out [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *possibleSlotIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad964bdd801d64fdad7f53e9a96407520)GetAssistingHitter()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Hitter](class_tale_worlds_1_1_mount_and_blade_1_1_agent_1_1_hitter.html) TaleWorlds.MountAndBlade.Agent.GetAssistingHitter | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e10a41a2278c97680f64e7ad75c2d20) | *killerPeer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6528fffbfe38dd2c5e8e6716be67b5e2)CanReachAgent()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CanReachAgent | ( | Agent | *otherAgent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b022bd15c13feacff544cc8730634f2)CanInteractWithAgent()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CanInteractWithAgent | ( | Agent | *otherAgent*, |
|  |  | float | *userAgentCameraElevation* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6745900967102a070a73819b59cdf449)CanBeAssignedForScriptedMovement()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CanBeAssignedForScriptedMovement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac2ade016f65de5f04c48916a9d2f7d39)CanReachAndUseObject()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CanReachAndUseObject | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *gameObject*, |
|  |  | float | *distanceSq* ) |

Parameters
:   |  |  |
    | --- | --- |
    | gameObject |  |
    | distanceSq |  |

Returns

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a092b524e17708b409236a7ac229d36b8)CanReachObject()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CanReachObject | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *gameObject*, |
|  |  | float | *distanceSq* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a60ceb3075a4199c07a1e90fc06b3144b)CanReachObjectFromPosition()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CanReachObjectFromPosition | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *gameObject*, |
|  |  | float | *distanceSq*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aff9e4a6a7e5dcdf14f447b3964d0b05e)CanUseObject()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CanUseObject | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *gameObject* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa0430f863f1a1e4fc47aa8389c359a84)CanMoveDirectlyToPosition()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CanMoveDirectlyToPosition | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8db4666e8f1cd6ee0a5320cff5c4ce19)CanInteractableWeaponBePickedUp()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CanInteractableWeaponBePickedUp | ( | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *spawnedItem* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab56f82ba10fe650b8e24fdf2c90e1ba9)CanQuickPickUp()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CanQuickPickUp | ( | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *spawnedItem* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6e5adbd697012f89de66c29713130c4a)CanTeleport()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CanTeleport | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6f06d53678f3f4c2127133c265a854a0)IsActive()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsActive | ( |  | ) |  |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#ab7e7d141dcc687fa0a57cc0ac50117f2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adc5b2c8a25a94c67c91f74e1490cabf1)IsRetreating()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsRetreating | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a26eab72f2487b5f9b31ac2b720639bab)IsFadingOut()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsFadingOut | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5045327ed01e5c5274286ab0526b79ac)SetAgentDrivenPropertyValueFromConsole()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetAgentDrivenPropertyValueFromConsole | ( | [DrivenProperty](namespace_tale_worlds_1_1_core.html#a5365354e6dce5280fbc150c13f9e60cf) | *type*, |
|  |  | float | *val* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad9f5f14ec3455a7d2329f953f4c3726c)IsOnLand()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsOnLand | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aeb8859b53fe55564d9cb5f7918c4458f)IsInWater()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsInWater | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a96d0f73003df0c0562bab11c3df72188)IsAbleToUseMachine()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsAbleToUseMachine | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade566b75325f7e4901f0b50fe67bd881)IsAgentParentEntitySameAs()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsAgentParentEntitySameAs | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *toBeChecked* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab21a60c49b451adfeee9133386f08609)SetExcludedFromGravity()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetExcludedFromGravity | ( | bool | *exclude*, |
|  |  | bool | *applyAverageGlobalVelocity* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e435c963d5ae13a8a11dfd5abd759f5)SetForceAttachedEntity()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetForceAttachedEntity | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *willBeAttached* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae78769fd963cf0bd2d8abadb445e55a2)IsSliding()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsSliding | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ada2b0d46db5d2406ff832cb45da850ae)IsSitting()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsSitting | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af6b5cb6d2ea3785ff19554f9c7e107e8)IsReleasingChainAttackInMultiplayer()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsReleasingChainAttackInMultiplayer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a75e45028d9a68a904c84addb2b95e83e)IsCameraAttachable()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsCameraAttachable | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6d212d9882d60060d9503a4d8ea8337e)IsSynchedPrefabComponentVisible()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsSynchedPrefabComponentVisible | ( | int | *componentIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a289d68f40695419b4b0b0543cba0855a)IsEnemyOf()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsEnemyOf | ( | Agent | *otherAgent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a499cbe3c00042695385fb09153c2c89d)IsFriendOf()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsFriendOf | ( | Agent | *otherAgent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afd52e23614f81ac535cc9265859d15aa)OnFocusGain()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.OnFocusGain | ( | Agent | *userAgent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#a42697fa1ea31f29be949e5325dfbc95e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8a1f47e424dfb718a4165a63d1923dcf)OnFocusLose()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.OnFocusLose | ( | Agent | *userAgent* | ) |  |

Implements [TaleWorlds.MountAndBlade.IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html#af920e5735d03cd6b971c458640fd6bba).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae6702921527d721b9e59ca44eb6fe7c8)OnItemRemovedFromScene()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.OnItemRemovedFromScene | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acda375fc5df86ad6390a4b35c28fd989)OnUse()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.OnUse | ( | Agent | *userAgent*, |
|  |  | [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) | *agentBoneIndex* ) |

Implements [TaleWorlds.MountAndBlade.IUsable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_usable.html#a3330b77edb1af39f70baed98feefd041).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7eed2c8aa8e72e1570decace7ae685c3)OnUseStopped()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.OnUseStopped | ( | Agent | *userAgent*, |
|  |  | bool | *isSuccessful*, |
|  |  | int | *preferenceIndex* ) |

Implements [TaleWorlds.MountAndBlade.IUsable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_usable.html#aa2e9cc62a3bd81ae89596d08e6415f80).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac12d830bde133a2a52ef33cac52e47d7)OnWeaponDrop()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.OnWeaponDrop | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equipmentSlot* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a18783611fb1aa46b40f7ded20e4c43e6)OnItemPickup()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.OnItemPickup | ( | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *spawnedItemEntity*, |
|  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *weaponPickUpSlotIndex*, |
|  |  | out bool | *removeWeapon* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a66ba72acbcd9b288773a40f8b17b75ed)GetDistanceTo()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Agent.GetDistanceTo | ( | Agent | *other* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab1f4935eefa049b00410b13e364a5478)CheckPathToAITargetAgentPassesThroughNavigationFaceIdFromDirection()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CheckPathToAITargetAgentPassesThroughNavigationFaceIdFromDirection | ( | int | *navigationFaceId*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction*, |
|  |  | float | *overridenCostForFaceId* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae9310020c32529ab3023a50130983ebe)IsTargetNavigationFaceIdBetween()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsTargetNavigationFaceIdBetween | ( | int | *navigationFaceIdStart*, |
|  |  | int | *navigationFaceIdEnd* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a91b83fec52b189094e23ada54678c7e0)CheckEquipmentForCapeClothSimulationStateChange()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.CheckEquipmentForCapeClothSimulationStateChange | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2d5c16d5e0364a6e78f58a54b0722e60)CheckToDropFlaggedItem()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.CheckToDropFlaggedItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a070a63c354df10cda184c22b63669c90)CheckSkillForMounting()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CheckSkillForMounting | ( | Agent | *mountAgent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd3ead52e5b35894cbaa6906988b0ee0)InitializeSpawnEquipment()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.InitializeSpawnEquipment | ( | [Equipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1f8e2968b02a0bcd02f435fdfea305d) | *spawnEquipment* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a340e4433a107266d2c21124f744991c0)InitializeMissionEquipment()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.InitializeMissionEquipment | ( | [MissionEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html) | *missionEquipment*, |
|  |  | [Banner](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a640493f3278a13f47141f6b2d431661a) | *banner* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af3afcbb3ba735d022caa4aea4084399b)InitializeAgentProperties()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.InitializeAgentProperties | ( | [Equipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1f8e2968b02a0bcd02f435fdfea305d) | *spawnEquipment*, |
|  |  | [AgentBuildData](class_tale_worlds_1_1_mount_and_blade_1_1_agent_build_data.html) | *agentBuildData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab4db2020ce84bac79190fc95367834cc)UpdateFormationOrders()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.UpdateFormationOrders | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a23938d5c2b65052bcbfbae1216af93b8)UpdateWeapons()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.UpdateWeapons | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6693c259c8241742fe749d8717c01d4e)UpdateAgentProperties()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.UpdateAgentProperties | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a25daffc76603905d1656f482aaeb5658)UpdateCustomDrivenProperties()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.UpdateCustomDrivenProperties | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3dafe0e7f8906e00c4cfbd7222c62859)UpdateBodyProperties()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.UpdateBodyProperties | ( | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | *bodyProperties* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad89f47ee43b185587275df062f878c7c)UpdateSyncHealthToAllClients()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.UpdateSyncHealthToAllClients | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a76f45a1204bbc5e9b6e7e5eefe66d90f)UpdateSpawnEquipmentAndRefreshVisuals()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.UpdateSpawnEquipmentAndRefreshVisuals | ( | [Equipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1f8e2968b02a0bcd02f435fdfea305d) | *newSpawnEquipment* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a546a454df2b45dbe270221af4da60d4d)ForceUpdateCachedAndFormationValues()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ForceUpdateCachedAndFormationValues | ( | bool | *updateOnlyMovement*, |
|  |  | bool | *arrangementChangeAllowed* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2f951ab900cad76e999b04927161810c)UpdateLastRangedAttackTimeDueToAnAttack()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.UpdateLastRangedAttackTimeDueToAnAttack | ( | float | *newTime* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9279b95a8d3b884dea47d64c017d53fd)InvalidateTargetAgent()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.InvalidateTargetAgent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a41df9e3eb455ef04b2330b01377ea479)InvalidateAIWeaponSelections()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.InvalidateAIWeaponSelections | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afa9eb6528220d56c9ee1dc7306f9652b)ResetLookAgent()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ResetLookAgent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7877475f04f7df6c345d35a9e5c00278)ResetGuard()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ResetGuard | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afb3fe1be43781e1f7d3e424c6ab93278)ResetAgentProperties()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ResetAgentProperties | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0f5037dabeb97daf411a2c3da5543e5c)ResetAiWaitBeforeShootFactor()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ResetAiWaitBeforeShootFactor | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a37255dcc1e91e1f5009be054bc151d2e)ClearTargetFrame()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ClearTargetFrame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aaa8088a65ede38d44a7166c9ddd410f9)ClearEquipment()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ClearEquipment | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae8c58de01eb55a14d4df7c37af5159b5)ClearHandInverseKinematics()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ClearHandInverseKinematics | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6db4f30ea8ade1d0d0da9d344a2d0e88)ClearAttachedWeapons()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ClearAttachedWeapons | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af73e4b813ebe022f857dd2c7a0083732)SetDetachableFromFormation()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetDetachableFromFormation | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab8916b40a8652c691afea1f79067b87b)TryAttachToFormation()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.TryAttachToFormation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8ba03cd1a3d52acf08dbe17c32d40810)TryRemoveAllDetachmentScores()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.TryRemoveAllDetachmentScores | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a043433669a23729d700d911a8a6e462d)EnforceShieldUsage()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.EnforceShieldUsage | ( | [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | *shieldDirection* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a898030ca05f6b7063f4d6b560d08e5a4)ObjectHasVacantPosition()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.ObjectHasVacantPosition | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *gameObject* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2cf7265b2ea5f0c62d6a7b27c5de5e3f)InteractingWithAnyGameObject()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.InteractingWithAnyGameObject | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3c528123285d63abbeacbc92a56ac161)StopUsingGameObjectMT()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.StopUsingGameObjectMT | ( | bool | *isSuccessful* = true, |
|  |  | [StopUsingGameObjectFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713) | *flags* = ([StopUsingGameObjectFlags.AutoAttachAfterStoppingUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713a967948a82d8f55fae4e9c5ff9cfae7bc)) ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a789eaabbd2d6d576852e4c074d4a3b6f)StopUsingGameObject()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.StopUsingGameObject | ( | bool | *isSuccessful* = true, |
|  |  | [StopUsingGameObjectFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713) | *flags* = ([StopUsingGameObjectFlags.AutoAttachAfterStoppingUsingGameObject](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713a967948a82d8f55fae4e9c5ff9cfae7bc)) ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aeb04799859f57b71123497602a7feb68)HandleStopUsingAction()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.HandleStopUsingAction | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af2f05c01b2bfe9b013a71aea0ea698d7)HandleStartUsingAction()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.HandleStartUsingAction | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *targetObject*, |
|  |  | int | *preferenceIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abf371b0e5d2156bc5dd8501ee51b071c)AddController()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [AgentController](class_tale_worlds_1_1_mount_and_blade_1_1_agent_controller.html) TaleWorlds.MountAndBlade.Agent.AddController | ( | Type | *type* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8214aa1e08d591a9d42ea7f8b08ee4d0)RemoveController()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [AgentController](class_tale_worlds_1_1_mount_and_blade_1_1_agent_controller.html) TaleWorlds.MountAndBlade.Agent.RemoveController | ( | Type | *type* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4237dd3fcea9887c6efcd5f646690234)CanThrustAttackStickToBone()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.CanThrustAttackStickToBone | ( | [BoneBodyPartType](namespace_tale_worlds_1_1_mount_and_blade.html#a88860bf2968d0069d9696746ebb47115) | *bodyPart* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aac8aeecec285b9351afce0161ac59417)GetOldWieldedItemInfo()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.GetOldWieldedItemInfo | ( | out int | *rightHandSlotIndex*, |
|  |  | out int | *rightHandUsageIndex*, |
|  |  | out int | *leftHandSlotIndex*, |
|  |  | out int | *leftHandUsageIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3c479aa29479fef70416c47188d4f4c5)StartSwitchingWeaponUsageIndexAsClient()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.StartSwitchingWeaponUsageIndexAsClient | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equipmentIndex*, |
|  |  | int | *usageIndex*, |
|  |  | [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | *currentMovementFlagUsageDirection* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a44fac0196d32ff47f7c01f1b54dbfd35)TryToWieldWeaponInSlot()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.TryToWieldWeaponInSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | [WeaponWieldActionType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835e) | *type*, |
|  |  | bool | *isWieldedOnSpawn* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af4394b1e804550273b615e81a451d2a1)PrepareWeaponForDropInEquipmentSlot()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.PrepareWeaponForDropInEquipmentSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | bool | *dropWithHolster* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adc98be741e8eacea4165f6956849b098)AddHitter()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.AddHitter | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e10a41a2278c97680f64e7ad75c2d20) | *peer*, |
|  |  | float | *damage*, |
|  |  | bool | *isFriendlyHit* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae582579170e0957c3598aa2926fe3d63)TryToSheathWeaponInHand()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.TryToSheathWeaponInHand | ( | [HandIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6de) | *handIndex*, |
|  |  | [WeaponWieldActionType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835e) | *type* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af32014eb7450084d3100c08d15a0b140)RemoveHitter()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.RemoveHitter | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e10a41a2278c97680f64e7ad75c2d20) | *peer*, |
|  |  | bool | *isFriendlyHit* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af4c7d3b2c35029ef796d6e53049b7c6a)Retreat()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.Retreat | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *retreatPos* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3e711c679b36c3778506e482a80dddaf)StopRetreating()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.StopRetreating | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3a780d5eb715f9152165767b6f6ca872)UseGameObject()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.UseGameObject | ( | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) | *usedObject*, |
|  |  | int | *preferenceIndex* = -1 ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abacedc3540d3e8e45d7117232c58bc54)SaveEquipmentsOnHand()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SaveEquipmentsOnHand | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a490cb03e2e6b1708d0abf892f8e5d817)StartFadingOut()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.StartFadingOut | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adcb65604426aec7d0837d3bacc0bb211)IsWandering()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.IsWandering | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a12bfc307f82c087cc75f51eea8cd2133)SetRenderCheckEnabled()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetRenderCheckEnabled | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a860cfe0107609654b5aacf2896fc2dcd)GetRenderCheckEnabled()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.GetRenderCheckEnabled | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5071887155f7769be795f52e0d2e0a7a)ComputeAnimationDisplacement()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.ComputeAnimationDisplacement | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0f9d4015f2039bdeea9932b1d76e4454)TickActionChannels()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.TickActionChannels | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a968aec277ba17bbe233abcf17db7b8b9)SetIsPhysicsForceClosed()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetIsPhysicsForceClosed | ( | bool | *isPhysicsForceClosed* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a26673823bb510ac07fb098ea0a1bf5dc)LockAgentReplicationTableDataWithCurrentReliableSequenceNo()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.LockAgentReplicationTableDataWithCurrentReliableSequenceNo | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *peer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa2cb9bfe7817e5eeef223bc6dab9ebe7)TeleportToPosition()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.TeleportToPosition | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6cf47c3db6dafe00924d153cd02d6a32)FadeOut()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.FadeOut | ( | bool | *hideInstantly*, |
|  |  | bool | *hideMount* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a62f14edd8006b88a7236746c738316f0)FadeIn()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.FadeIn | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4471f32cbf9b479a1541e78b8d464800)DisableScriptedMovement()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.DisableScriptedMovement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3f88d9dea69c9996eec8bf96d3982d5f)DisableScriptedCombatMovement()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.DisableScriptedCombatMovement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4848b61abc5242c248ad4061c98e78bd)ForceAiBehaviorSelection()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ForceAiBehaviorSelection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a97e48ca6a5f1b1920d1157c71a53272a)HasPathThroughNavigationFaceIdFromDirectionMT()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.HasPathThroughNavigationFaceIdFromDirectionMT | ( | int | *navigationFaceId*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction* ) |

Parameters
:   |  |  |
    | --- | --- |
    | navigationFaceId | navigation face id to check |
    | direction | true only if path traverses the *navigationFaceId* face from this direction. Passing Vec2.Zero will be treated as having no direction specified |

Returns

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3202da33b0342eac162dd93e432b7e49)HasPathThroughNavigationFaceIdFromDirection()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.HasPathThroughNavigationFaceIdFromDirection | ( | int | *navigationFaceId*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction* ) |

Parameters
:   |  |  |
    | --- | --- |
    | navigationFaceId | navigation face id to check |
    | direction | true only if path traverses the *navigationFaceId* face from this direction. Passing Vec2.Zero will be treated as having no direction specified |

Returns

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a10cbcbcc1138481a71c9aaf07bac3f02)DisableLookToPointOfInterest()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.DisableLookToPointOfInterest | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6360fc2e2232dde29b5acfad34bbdc70)AddPrefabComponentToBone()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CompositeComponent](class_tale_worlds_1_1_engine_1_1_composite_component.html) TaleWorlds.MountAndBlade.Agent.AddPrefabComponentToBone | ( | string | *prefabName*, |
|  |  | [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) | *boneIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a100af76da61d898ffcb98227bfc48274)MakeVoice()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.MakeVoice | ( | [SkinVoiceManager.SkinVoiceType](struct_tale_worlds_1_1_mount_and_blade_1_1_skin_voice_manager_1_1_skin_voice_type.html) | *voiceType*, |
|  |  | [SkinVoiceManager.CombatVoiceNetworkPredictionType](class_tale_worlds_1_1_mount_and_blade_1_1_skin_voice_manager.html#a3a36fbc50e06600400f9c83dc18267e4) | *predictionType* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7c82177d96d40076a8354a87ccf0c295)YellAfterDelay()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.YellAfterDelay | ( | float | *delayTimeInSecond* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9ad8266b5ec1426ef20982c21822f146)WieldNextWeapon()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.WieldNextWeapon | ( | [HandIndex](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a79d232036cec64739a856a8650e1a6de) | *weaponIndex*, |
|  |  | [WeaponWieldActionType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835e) | *wieldActionType* = [WeaponWieldActionType::WithAnimation](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835ea7671f6d74e057fdfafe2928bf6b7b27b) ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a781a9abd3a931a5af886055adb82ffe2)AttackDirectionToMovementFlag()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) TaleWorlds.MountAndBlade.Agent.AttackDirectionToMovementFlag | ( | [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | *direction* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a241002ef0a33efb930d8e3f3ec37cc0f)DefendDirectionToMovementFlag()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) TaleWorlds.MountAndBlade.Agent.DefendDirectionToMovementFlag | ( | [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) | *direction* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab7da5acf1e149878b48f76a19747b0da)KickClear()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.KickClear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a41da440c8b75491f8cefde6c585e758f)PlayerAttackDirection()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) TaleWorlds.MountAndBlade.Agent.PlayerAttackDirection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a84a6e774147cb224739ae869758915b3)GetRandomPairOfRealBloodBurstBoneIndices()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) TaleWorlds.MountAndBlade.Agent.GetRandomPairOfRealBloodBurstBoneIndices | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adf970c7d8226c94dd59080c53dad1cc5)CreateBloodBurstAtLimb()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.CreateBloodBurstAtLimb | ( | [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) | *realBoneIndex*, |
|  |  | float | *scale* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a950a414da3d9ff8973328787f25a672f)AddComponent()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.AddComponent | ( | [AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | *agentComponent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3a17c108810516e7f43f420ec365148f)RemoveComponent()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.RemoveComponent | ( | [AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html) | *agentComponent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a87de617cb18a5e3d6686f15bcf18d20c)HandleTaunt()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.HandleTaunt | ( | int | *tauntIndex*, |
|  |  | bool | *isDefaultTaunt* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9b66b519dbc13f7fd8d0602c45595687)HandleBark()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.HandleBark | ( | int | *indexOfBark* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a04d62dab4186e1c307100a2d46e46476)HandleDropWeapon()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.HandleDropWeapon | ( | bool | *isDefendPressed*, |
|  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *forcedSlotIndexToDropWeaponFrom* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac3e4809fab4a51621ab0d3395dd74fb4)DropItem()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.DropItem | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *itemIndex*, |
|  |  | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *pickedUpItemType* = WeaponClass::Undefined ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0fd7c7955c4802fd6acec69a801ab4e9)EquipItemsFromSpawnEquipment()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.EquipItemsFromSpawnEquipment | ( | bool | *neededBatchedItems*, |
|  |  | bool | *prepareImmediately*, |
|  |  | bool | *useFaceCache*, |
|  |  | int | *faceCacheID* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2bd673f4388e0f687cbb8a3ec4efee0f)WieldInitialWeapons()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.WieldInitialWeapons | ( | [WeaponWieldActionType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835e) | *wieldActionType* = [WeaponWieldActionType::InstantAfterPickUp](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade0adbe5cd2a487139a26a0ed295835eafb04605c34b201af035c2ff8b5f61967), |
|  |  | Equipment.InitialWeaponEquipPreference | *initialWeaponEquipPreference* = [Core::Equipment::InitialWeaponEquipPreference::Any](class_tale_worlds_1_1_core_1_1_equipment.html#a4f20fb89d2bb249f242976b83f3c51edaed36a1ef76a59ee3f15180e0441188ad) ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6d28705b1d25542aa7d801a5fe8b2713)ChangeWeaponHitPoints()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ChangeWeaponHitPoints | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | short | *hitPoints* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afdb34b73a2d50865c18098663ec47732)HasWeapon()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.HasWeapon | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3cef1fdc1c24b8c5b3915ecbbe813095)AttachWeaponToWeapon()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.AttachWeaponToWeapon | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *weaponEntity*, |
|  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *attachLocalFrame* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac342c85d8966d14df319c70954c216b8)AttachWeaponToBone()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.AttachWeaponToBone | ( | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *weaponEntity*, |
|  |  | [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) | *boneIndex*, |
|  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *attachLocalFrame* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5be1a2211fb442f8414a407164e1d7ba)RestoreShieldHitPoints()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.RestoreShieldHitPoints | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a744af8c90682832cd49d466c938f9f95)Die()
------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.Die | ( | [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *b*, |
|  |  | [KillInfo](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7) | *overrideKillInfo* = [KillInfo::Invalid](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71688c82a0e357d95615b981fb0e1fb7a4bbb8f967da6d1a610596d7257179c2b) ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5048b7c52162aabf77d3245597a7e6f4)MakeDead()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.MakeDead | ( | bool | *isKilled*, |
|  |  | [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) | *actionIndex*, |
|  |  | int | *corpsesToFadeIndex* = -1 ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab3cd240497ec0d58e838a12d1ab6b57a)RegisterBlow()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.RegisterBlow | ( | [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a641912d7a515ce0f1d1af77b1c419645)CreateBlowFromBlowAsReflection()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.CreateBlowFromBlowAsReflection | ( | in [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *blow*, |
|  |  | in [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *collisionData*, |
|  |  | out [Blow](struct_tale_worlds_1_1_mount_and_blade_1_1_blow.html) | *outBlow*, |
|  |  | out [AttackCollisionData](struct_tale_worlds_1_1_mount_and_blade_1_1_attack_collision_data.html) | *outCollisionData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a40ff5fb1d3501a0abc1d03c99d8478a0)TickParallel()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.TickParallel | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4f22e839638dcfb6daa2154365536b38)Tick()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acce73af22241c7cf1eff9ac7004f926e)DebugMore()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.DebugMore | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab30f739110cdaec37969313dec394553)Mount()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.Mount | ( | Agent | *mountAgent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af1a4f978e55f7daef8e44cadfc72c6e6)EquipWeaponToExtraSlotAndWield()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.EquipWeaponToExtraSlotAndWield | ( | ref [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aed71bf9e783c7b683593d32197243d6d)RemoveEquippedWeapon()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.RemoveEquippedWeapon | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0bb25143c87874217753f6cd812269de)EquipWeaponWithNewEntity()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.EquipWeaponWithNewEntity | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | ref [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon* ) |

Parameters
:   |  |  |
    | --- | --- |
    | slotIndex | The equipment slot. |
    | weapon | Data for this weapon instance. |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae68a5dfff82396c4def8586afaa40fdc)EquipWeaponFromSpawnedItemEntity()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.EquipWeaponFromSpawnedItemEntity | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, |
|  |  | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *spawnedItemEntity*, |
|  |  | bool | *removeWeapon* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a52926d113cd01a294a92f4cdfc9c2314)PreloadForRendering()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.PreloadForRendering | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aad59887f00de0102ded95695e791ef8e)AddSynchedPrefabComponentToBone()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Agent.AddSynchedPrefabComponentToBone | ( | string | *prefabName*, |
|  |  | [sbyte](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38) | *boneIndex* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9095f4bf4faaa0fd5f8681876e7be0a2)WillDropWieldedShield()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.WillDropWieldedShield | ( | [SpawnedItemEntity](class_tale_worlds_1_1_mount_and_blade_1_1_spawned_item_entity.html) | *spawnedItem* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1673baf1650339b2a11c51ff1e4da280)HadSameTypeOfConsumableOrShieldOnSpawn()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.HadSameTypeOfConsumableOrShieldOnSpawn | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac5b8d4af8a095b1c538b5b032ab27507)GetHashCode()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.MountAndBlade.Agent.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a62f7b3a2512664aa2885337f0746787b)TryGetImmediateEnemyAgentMovementData()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.TryGetImmediateEnemyAgentMovementData | ( | out float | *maximumForwardUnlimitedSpeed*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a92392e10b986e6f4269186f0c7b7d8da)HasLostShield()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.HasLostShield | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af3a7ccd18a1edbe5de73155833c0b8e5)SetLastDetachmentTickAgentTime()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetLastDetachmentTickAgentTime | ( | float | *lastDetachmentTickAgentTime* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acb23ea636a78fa1212cadc22a6d73bdb)SetDetachmentWeight()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetDetachmentWeight | ( | float | *newDetachmentWeight* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a34e09911f101b49bde814fd392f847b5)SetDetachmentIndex()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetDetachmentIndex | ( | int | *newDetachmentIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0b9a1aa9c6beb6f8f61110d3471ddd61)SetOwningAgentMissionPeer()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetOwningAgentMissionPeer | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e10a41a2278c97680f64e7ad75c2d20) | *owningAgentMissionPeer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8cc6a7dff83e9b444ed539a5d46b95bf)SetMissionRepresentative()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetMissionRepresentative | ( | [MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | *missionRepresentative* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a602639c09d704d0cb826a49ad29cb5be)SetIsLadderQueueUsing()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetIsLadderQueueUsing | ( | bool | *isLadderQueueUsing* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a18a719ec77c06738094501e9fdb07fd4)SetIsInLadderQueue()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetIsInLadderQueue | ( | bool | *isInLadderQueue* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abb3b3c7b8ba682277e9a8707418ca849)UpdateLocalPositionError()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.UpdateLocalPositionError | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7f09beeecc962f0d964cd90ec8c36545)YellingBehaviour()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.YellingBehaviour | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa83c881b423f53bc8c6c8de676de7c48)HasPathThroughNavigationFacesIDFromDirection()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.HasPathThroughNavigationFacesIDFromDirection | ( | int | *navigationFaceID\_1*, |
|  |  | int | *navigationFaceID\_2*, |
|  |  | int | *navigationFaceID\_3*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aef1f18a7af129fdd7919898ed8788351)HasPathThroughNavigationFacesIDFromDirectionMT()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Agent.HasPathThroughNavigationFacesIDFromDirectionMT | ( | int | *navigationFaceID\_1*, |
|  |  | int | *navigationFaceID\_2*, |
|  |  | int | *navigationFaceID\_3*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0b038eb60d501dd6227e7f1da9776f5e)SetInitialFrame()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.SetInitialFrame | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *initialPosition*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *initialDirection*, |
|  |  | bool | *canSpawnOutsideOfMissionBoundary* = false ) |

Parameters
:   |  |  |
    | --- | --- |
    | initialFrame | The initial frame for the agent. |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae1e11f08547f9ada14a084f9377e308c)ClearTargetZ()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Agent.ClearTargetZ | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af670af556774d8e2bee418021174a0b7)MovementFlagToDirection()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) TaleWorlds.MountAndBlade.Agent.MovementFlagToDirection | ( | [MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) | *flag* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac61285628c1a57aeaca157963aaf7bad)GetActionDirection()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) TaleWorlds.MountAndBlade.Agent.GetActionDirection | ( | int | *actionIndex* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae505df7933a44ee50dd6bfeedb91911e)GetMonsterUsageIndex()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.Agent.GetMonsterUsageIndex | ( | string | *monsterUsage* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a407db3867bb7142b8e91d2cf47d6b67d)GetSoundParameterForArmorType()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.Agent.GetSoundParameterForArmorType | ( | [ArmorComponent.ArmorMaterialTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a57670fe2832088f82ba3fdb56e1acb99) | *armorMaterialType* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6ea90a9566258c671db46c13532e2abb)BecomeTeenagerAge
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.Agent.BecomeTeenagerAge = 14 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae6771cc3f3ed02a7ead14a664778ff34)MaxMountInteractionDistance
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.Agent.MaxMountInteractionDistance = 1.75f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a86dc36405ecadad6e54c3cd36f01160d)DismountVelocityLimit
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.Agent.DismountVelocityLimit = 0.5f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6d5f4245e8f71500ccb308a2850d40c0)HealthDyingThreshold
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.Agent.HealthDyingThreshold = 1.0f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1859116ddc606522949a2beedf7d10b)CachedAndFormationValuesUpdateTime
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.Agent.CachedAndFormationValuesUpdateTime = 0.5f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a924424bc00b0cbb2820333c2b4268d46)MaxInteractionDistance
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.Agent.MaxInteractionDistance = 3.0f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3975cb84748bff4682c15b3ac8ab3b82)MaxFocusDistance
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.Agent.MaxFocusDistance = 10.0f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae8962dc05b1242ff7f9ace989bc21784)DefaultTauntActions
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html) [] TaleWorlds.MountAndBlade.Agent.DefaultTauntActions | | static |

**Initial value:**

=

{

[ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html).[act\_taunt\_cheer\_1](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html#a21ed293f010e08c861e263fde50fff76),

[ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html).[act\_taunt\_cheer\_2](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html#a90d57f6696cb35c83d352da9ee0cf319),

[ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html).[act\_taunt\_cheer\_3](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html#a51a40b0c2a6a734d6438183460ae338b),

[ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html).[act\_taunt\_cheer\_4](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html#a7971b8c66015326489283058cc2e9b33),

}

[TaleWorlds.MountAndBlade.ActionIndexCache](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html)

**Definition** MBAnimation.cs:94

[TaleWorlds.MountAndBlade.ActionIndexCache.act\_taunt\_cheer\_1](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html#a21ed293f010e08c861e263fde50fff76)

static readonly ActionIndexCache act\_taunt\_cheer\_1

**Definition** MBAnimation.cs:287

[TaleWorlds.MountAndBlade.ActionIndexCache.act\_taunt\_cheer\_3](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html#a51a40b0c2a6a734d6438183460ae338b)

static readonly ActionIndexCache act\_taunt\_cheer\_3

**Definition** MBAnimation.cs:289

[TaleWorlds.MountAndBlade.ActionIndexCache.act\_taunt\_cheer\_4](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html#a7971b8c66015326489283058cc2e9b33)

static readonly ActionIndexCache act\_taunt\_cheer\_4

**Definition** MBAnimation.cs:290

[TaleWorlds.MountAndBlade.ActionIndexCache.act\_taunt\_cheer\_2](struct_tale_worlds_1_1_mount_and_blade_1_1_action_index_cache.html#a90d57f6696cb35c83d352da9ee0cf319)

static readonly ActionIndexCache act\_taunt\_cheer\_2

**Definition** MBAnimation.cs:288

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7a96ce2f7bb25aaae9db895d69a1fac7)OnMainAgentWieldedItemChange
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnMainAgentWieldedItemChangeDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad987ba74a5b3c9a503c88091d2cecf0c) TaleWorlds.MountAndBlade.Agent.OnMainAgentWieldedItemChange |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac1031efa9d6abe4c7bff78f4eb1cfc1e)OnAgentMountedStateChanged
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.Agent.OnAgentMountedStateChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aec1270a9fc62929dfb65eda3fb8c8586)OnAgentWieldedItemChange
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.Agent.OnAgentWieldedItemChange |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a962ed8e4fd50f82c7a0f8446e3d5af38)sbyte
------------------------------------------------------------------------------------------------

|  |
| --- |
| TaleWorlds.MountAndBlade.Agent.sbyte |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0d9f38e91b16debe9ebe38e9a7b3208b)Main
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Agent TaleWorlds.MountAndBlade.Agent.Main | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8308eacd90f0bb76b631af96eea1bb3b)IsPlayerControlled
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsPlayerControlled | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ada60a64d3368d26a4582a04ee8ee080a)IsMine
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsMine | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad88e512e468da6c713e536947e29687d)IsMainAgent
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsMainAgent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acf73850efcec3680af15c9ac55701996)IsHuman
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsHuman | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab66a1a3e399f36da673550b498bc61ea)IsMount
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsMount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa329d24166881ac580929290c158e8c9)IsAIControlled
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsAIControlled | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ae7e0c1dc8db8cec35799d76d50ef76fd)IsPlayerTroop
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsPlayerTroop | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2b9caf883bd18362215ca9951c397fc8)IsUsingGameObject
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsUsingGameObject | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98c2a5d7e97a1d14fadc486de413184a)CanLeadFormationsRemotely
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.CanLeadFormationsRemotely | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0cec72d93971ff5864e7058cb6e23253)IsDetachableFromFormation
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsDetachableFromFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adc20ef281c544e4a23649dbfe098a609)AgentScale
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.AgentScale | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a03d9d0bfbf0cad9987fe07a5d5d0b938)CrouchMode
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.CrouchMode | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5d4e7578152f76595ac6a3bc71a90d21)WalkMode
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.WalkMode | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab7c815ee30cb8bc2ae95c525d5b1de05)Position
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.Position | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7424f79aecdcb17fe360bfa089913d91)MovementMode
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentMovementMode](namespace_tale_worlds_1_1_core.html#a57c7a188b7a711a6748c836cff044dae) TaleWorlds.MountAndBlade.Agent.MovementMode | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0737a737eb962a7cc422bf0a299e2dc1)VisualPosition
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.VisualPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a968ae52c86c08eadb12a9a7a3f323741)MovementVelocity
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Agent.MovementVelocity | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1e2db515e63768caea93199788878509)AverageVelocity
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.AverageVelocity | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa38d0504c27eeaf00de432ff4bbb1f0a)MovementDirectionAsAngle
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.MovementDirectionAsAngle | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad8e1b3a1d26f98b79384b93974717cd9)IsLookRotationInSlowMotion
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsLookRotationInSlowMotion | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a88704d63d0bb85785c5dc5b2f4de97ad)PropertyModifiers
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentPropertiesModifiers](struct_tale_worlds_1_1_mount_and_blade_1_1_agent_1_1_agent_properties_modifiers.html) TaleWorlds.MountAndBlade.Agent.PropertyModifiers | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7a3f48899df7e4032e8f26f23f74b03f)ActionSet
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBActionSet](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_action_set.html) TaleWorlds.MountAndBlade.Agent.ActionSet | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad763afee573aa7cd7ecb99412d3300e9)Components
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[AgentComponent](class_tale_worlds_1_1_mount_and_blade_1_1_agent_component.html)> TaleWorlds.MountAndBlade.Agent.Components | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2140da257cf28f23af05b76b491da43e)HitterList
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hitter](class_tale_worlds_1_1_mount_and_blade_1_1_agent_1_1_hitter.html)> TaleWorlds.MountAndBlade.Agent.HitterList | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac10c8762f8f8e28bc91347b65aebda79)CurrentGuardMode
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GuardMode](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7e258f837e094c8fd60eaf08c57e1a61) TaleWorlds.MountAndBlade.Agent.CurrentGuardMode | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a95520e707c06600f5520906871072ba6)ImmediateEnemy
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Agent TaleWorlds.MountAndBlade.Agent.ImmediateEnemy | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a84fed08444d8afe1a956667195c25c47)IsDoingPassiveAttack
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsDoingPassiveAttack | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e3d354ff63bc2407b9196725cb6e0b5)IsPassiveUsageConditionsAreMet
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsPassiveUsageConditionsAreMet | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af9fdd7f0cb79f72c0c47e71f938a23f5)CurrentAimingError
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.CurrentAimingError | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#affc5a04c28e27a2a9b66819cde36444b)CurrentAimingTurbulance
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.CurrentAimingTurbulance | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7403ccaf08ae09db5dadcb2da2d61a66)AttackDirection
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UsageDirection](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1c41ed63b18df83ea37a74a65a0922a) TaleWorlds.MountAndBlade.Agent.AttackDirection | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3e629342c9e34007432c70f9fe143f69)WalkingSpeedLimitOfMountable
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.WalkingSpeedLimitOfMountable | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af19490dd4624e89a2374b1b68a86554d)RiderAgent
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Agent TaleWorlds.MountAndBlade.Agent.RiderAgent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a46d8febb6d6612976b28c0f93fa8f3d2)HasMount
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.HasMount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad3906b799b4352bcca60d8763b16d4eb)CanLogCombatFor
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.CanLogCombatFor | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a71eba325ec593a9323bc90773359596f)MissileRangeAdjusted
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.MissileRangeAdjusted | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a653b43317ee97f5b3c1b5859fee7ae00)MaximumMissileRange
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.MaximumMissileRange | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e87e913f81299dc22b29eaa6f959b79)Name
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Agent.Name | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a229ec139bd166162477cc2c6e27f0da6)NameTextObject
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.Agent.NameTextObject | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ace13877adc7a2dc7eb1966191da3eeef)MovementLockedState
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentMovementLockedState](namespace_tale_worlds_1_1_mount_and_blade.html#a2d4a63cc3752dd189bd939610b34157b) TaleWorlds.MountAndBlade.Agent.MovementLockedState | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3d12ccf64939586de96da8498ae33119)Monster
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Monster TaleWorlds.MountAndBlade.Agent.Monster | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2d1e0094a4b2dacfdc0d9a6a9481a500)IsRunningAway
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsRunningAway | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1fe0ab82eb2123d19111f455a300a0c3)BodyPropertiesValue
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.Agent.BodyPropertiesValue | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad6a4d59075a56c6207f32c55b6ff7d03)CommonAIComponent
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CommonAIComponent TaleWorlds.MountAndBlade.Agent.CommonAIComponent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a122ae9e1f7fb6f42ed24eff7e99c742f)HumanAIComponent
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | HumanAIComponent TaleWorlds.MountAndBlade.Agent.HumanAIComponent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a61bba4a0af9aea61f549a015525be912)BodyPropertiesSeed
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Agent.BodyPropertiesSeed | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2ed3033fd01d2341964470b4d2b078ea)LastRangedHitTime
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.LastRangedHitTime = float.MinValue | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a82e82d6c959f872d99d829c0ffb7afb0)LastMeleeHitTime
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.LastMeleeHitTime = float.MinValue | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0ed9f5ded6d63aa7dad066c2fcf26942)LastRangedAttackTime
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.LastRangedAttackTime = float.MinValue | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a03560748b5dc43810258a0ab6a08bdd9)LastMeleeAttackTime
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.LastMeleeAttackTime = float.MinValue | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0413a10c06067fa563955d2a5864024a)IsFemale
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsFemale | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a640493f3278a13f47141f6b2d431661a)Banner
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.MountAndBlade.Agent.Banner | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aeb3e4b2b325297641f50c9d9a7671d31)FormationBanner
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.MountAndBlade.Agent.FormationBanner | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac91c0f6aeea8a7effc44c21ee396876a)WieldedWeapon
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) TaleWorlds.MountAndBlade.Agent.WieldedWeapon | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a627ddda1cbe61cef16874ebfdb5e88ad)IsItemUseDisabled
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsItemUseDisabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a25eeb7a29444afed7d2ecd5effc03bbc)SyncHealthToAllClients
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.SyncHealthToAllClients | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abc2cb8ed31d5f00b22683fd6d5840e9b)CurrentlyUsedGameObject
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UsableMissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_usable_mission_object.html) TaleWorlds.MountAndBlade.Agent.CurrentlyUsedGameObject | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa5306666ee0bace8b224f269d8de3469)CombatActionsEnabled
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.CombatActionsEnabled | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adfe6f6ebc1f9ca71d4b4e808b4a1ed45)Mission
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Mission TaleWorlds.MountAndBlade.Agent.Mission | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a825874383be114ff281268ffdda79ed4)IsHero
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsHero | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6946c9080342e9ca57eaa35f8baec7b4)Index
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Agent.Index | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1f8e2968b02a0bcd02f435fdfea305d)Equipment
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_mission_equipment.html) TaleWorlds.MountAndBlade.Agent.Equipment | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aaf52bed6be3929874d6ce946929b3687)AgentRole
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.Agent.AgentRole | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a213d34b03520c1352ba7ea284a8d7588)HasBeenBuilt
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.HasBeenBuilt | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a75f0732851c7ccf7d91d89c14a199577)CurrentMortalityState
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MortalityState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abd592cc5cf557afcc7eaef3ae20a7eae) TaleWorlds.MountAndBlade.Agent.CurrentMortalityState | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5675d9658bd670ecf4cc11116ba58fd4)SpawnEquipment
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Equipment](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1f8e2968b02a0bcd02f435fdfea305d) TaleWorlds.MountAndBlade.Agent.SpawnEquipment | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac3ceb6446ccc2a30fc178e26cf824701)FormationPositionPreference
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationPositionPreference](namespace_tale_worlds_1_1_core.html#a27a08ddbccef9cfbcf5de8653eb5244e) TaleWorlds.MountAndBlade.Agent.FormationPositionPreference | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a138da16d4cf5255e986d096e23252f49)RandomizeColors
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.RandomizeColors | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a3ba3ed1ee93aac9b4166cfdd4d41520c)CharacterPowerCached
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.CharacterPowerCached | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afb43485a18b28877cca63884bfb5e32b)WalkSpeedCached
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.WalkSpeedCached | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0c684662d1d7a44b6f83d5af579f12c4)Origin
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) TaleWorlds.MountAndBlade.Agent.Origin | | getset |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#ac4f6b65d20f8a2207d6d82cd0e3fbe9a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a13bb441adc4062eddd4b9548e43b5db5)Team
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Team TaleWorlds.MountAndBlade.Agent.Team | | get |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#ad85ae269484b67435d3ac23c44462ab5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a90f4436a068b7209c7a3191389d29c68)KillCount
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Agent.KillCount | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad1e93156b404fee723c6dbe97ca76110)AgentDrivenProperties
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | AgentDrivenProperties TaleWorlds.MountAndBlade.Agent.AgentDrivenProperties | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a73f45cee874d88d431572e761d99776c)BaseHealthLimit
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.BaseHealthLimit | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acf8c8d6740b3ed8650ae8066f32db159)HorseCreationKey
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.Agent.HorseCreationKey | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af0b65153046e310b4fc0783f216d1016)HealthLimit
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.HealthLimit | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ab3f002741cc63229e552fc7be0ecf39e)IsRangedCached
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsRangedCached | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1f8546964f91e2a3054d46cbce749b75)HasAnyRangedWeaponCached
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.HasAnyRangedWeaponCached | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5e6a585fdb118771b42958b93cfc4148)HasMeleeWeaponCached
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.HasMeleeWeaponCached | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a63ecf71f772c4919394f3106d9f850e6)HasShieldCached
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.HasShieldCached | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a966c68aa352571aaf6ffa343f85250a2)HasSpearCached
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.HasSpearCached | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a8811f21d0a13f6472852f234555ec1f9)HasThrownCached
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.HasThrownCached | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa73f8598d9045c2e175606e93041e1d5)AIStateFlags
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AIStateFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a9bf7959dd8d468ef55afa4b4a53e0995) TaleWorlds.MountAndBlade.Agent.AIStateFlags | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa5ebbaa55510cf405c37b8993302f535)Frame
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Agent.Frame | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#afa6dc2e9da85be46cef9f69fb818a14c)MovementFlags
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MovementControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a81bece812eef7b0170864a38f387e797) TaleWorlds.MountAndBlade.Agent.MovementFlags | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2797696dfdfcb735d9efbba936375afb)MovementInputVector
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Agent.MovementInputVector | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#adb0935843c316fa59f7f847293eebf6f)CollisionCapsule
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) TaleWorlds.MountAndBlade.Agent.CollisionCapsule | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a459111e2628ded1999e8a66eda5cd303)CollisionCapsuleCenter
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.CollisionCapsuleCenter | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a69464d7a3ee3da868cbf4d200781f3a2)AgentVisuals
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) TaleWorlds.MountAndBlade.Agent.AgentVisuals | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4ba02fbfaebaafd6f6bcb938771509c3)HeadCameraMode
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.HeadCameraMode | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a75158e7283825607d1088449f8a425c9)MountAgent
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Agent TaleWorlds.MountAndBlade.Agent.MountAgent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a797cb8361442f90bb1aea0b210c07350)Detachment
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IDetachment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_detachment.html) TaleWorlds.MountAndBlade.Agent.Detachment | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a74fe206e3bb4373525c4c0328f5f4d9b)IsPaused
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsPaused | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a53dcab6e46b13e81d9d125f49397656a)IsDetachedFromFormation
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsDetachedFromFormation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a2eedfe89ad014adc3d93bde63f69449d)CurrentWatchState
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WatchState](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a7aa6fe93228ddfb752808bcb9fc48891) TaleWorlds.MountAndBlade.Agent.CurrentWatchState | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a723c8da96476730a07e93e0c8006bab9)Defensiveness
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.Defensiveness | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a505d009f2570ea53f43008dcde1f6ef3)Formation
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Formation TaleWorlds.MountAndBlade.Agent.Formation | | getset |

Implements [TaleWorlds.MountAndBlade.IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html#a18aa50613730e80b503abd206573f517).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a877359ba5f121eb7d4a18f9ea4d43407)IsShieldUsageEncouraged
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsShieldUsageEncouraged | | get |

Implements [TaleWorlds.MountAndBlade.IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html#ada5c96b4f36254c5c4b24ec3d6c38209).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acc295b34df01d3335443e29f01f962ce)IsPlayerUnit
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsPlayerUnit | | get |

Implements [TaleWorlds.MountAndBlade.IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html#a9b9d47788a4f03cce8d23dc7ed46a67f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac866dda49301a9ab304ae6b3dd54f862)Controller
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentControllerType](namespace_tale_worlds_1_1_core.html#a9023c2d9c44f6d3f5d63611a38b3bedb) TaleWorlds.MountAndBlade.Agent.Controller | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0d5b01fd3bb228fdc53d3b4e9de35e68)ClothingColor1
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.Agent.ClothingColor1 | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1a5147b4c84b9eafed80eec9e91a7ab1)ClothingColor2
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.MountAndBlade.Agent.ClothingColor2 | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a73f6da923c05c698c37411e882ea14e8)LookFrame
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.Agent.LookFrame | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af9b9e17d4caaa6066a2d431d88f1290b)LookDirectionAsAngle
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.LookDirectionAsAngle | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4b133a2e226bb847dfe9517473e087b0)LookRotation
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) TaleWorlds.MountAndBlade.Agent.LookRotation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af647803960278173184f9bfd41ad9688)IsLookDirectionLocked
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsLookDirectionLocked | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a5d5856c5fe4f5fb6213748f9f4a6ff94)IsCheering
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsCheering | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6a984818c84033a242582b02c9b7a7f)IsInBeingStruckAction
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsInBeingStruckAction | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e10a41a2278c97680f64e7ad75c2d20)MissionPeer
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MissionPeer TaleWorlds.MountAndBlade.Agent.MissionPeer | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a39180c08aabe8810af4a4566769ab38a)Character
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.Agent.Character | | getset |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#aea11c094cb4a894cca1ee485511957e6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac4f19091ea1cc6996737c8cba02d560e)LastDetachmentTickAgentTime
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.LastDetachmentTickAgentTime | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ad0d7be607c6180892b05a09a75ab052b)OwningAgentMissionPeer
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a0e10a41a2278c97680f64e7ad75c2d20) TaleWorlds.MountAndBlade.Agent.OwningAgentMissionPeer | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ade465510bfc22a6f02848a898d612793)MissionRepresentative
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) TaleWorlds.MountAndBlade.Agent.MissionRepresentative | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a4a9c03ff2d4b89f88475204189fdeb5f)IsInLadderQueue
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsInLadderQueue | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a6cffe3995258a52bd91e0ca7ea6c6994)LocalPositionError
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.Agent.LocalPositionError | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a500e0f5ad440482134a26ba7cd84d9d4)DetachmentWeight
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.DetachmentWeight | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aa6b34ab83e495945a0302caa07ce5559)DetachmentIndex
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.Agent.DetachmentIndex = -1 | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a05432a5ca31ba6c21eb2ca034e4f5b59)IsFormationFrameEnabled
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsFormationFrameEnabled | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#abcc839e89e3c8dab42e547ce22057a58)LookDirection
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.LookDirection | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#ac4273cf5b79157c0f618f54d9a31cd7d)IsLookDirectionLow
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.Agent.IsLookDirectionLow | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af1c81a6b39ad442f84acca466a25ce07)Health
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.Health | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1a6299648a0e4d11e799e6436350d7b8)Age
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.Agent.Age | | getset |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#ae4af4dbcc3481ab6e4c0b19b1127368c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#acc3df36553bb0cf58454d10be726abc8)Velocity
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.Agent.Velocity | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a623ce0ff2bbc3f309ef976f8e4a1f2f1)EventControlFlags
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EventControlFlag](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a027f37ecbc637dd0fb2a480d87139429) TaleWorlds.MountAndBlade.Agent.EventControlFlags | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a26f71b29a39c47dc17220a32f945d0cb)State
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) TaleWorlds.MountAndBlade.Agent.State | | getset |

Implements [TaleWorlds.Core.IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html#a9e6b6905ecbc75b93f005b91cb8019b3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a1df517896798fa55aebe26bd8dc697a0)WieldedOffhandWeapon
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) TaleWorlds.MountAndBlade.Agent.WieldedOffhandWeapon | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a88e7336807895cbecaebc4a36a28135b)OnAgentHealthChanged
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnAgentHealthChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a36ccd47292c6896ed280dbc5ea386080) TaleWorlds.MountAndBlade.Agent.OnAgentHealthChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a52d7a6ac707df4e97073a1c9a485edae)OnMountHealthChanged
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnMountHealthChangedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#af84128460d915acb53c2460c250ac909) TaleWorlds.MountAndBlade.Agent.OnMountHealthChanged |


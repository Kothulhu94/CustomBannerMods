--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_hero.html ---

TaleWorlds.CampaignSystem.Hero Class ReferencesealedInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html), [TaleWorlds.CampaignSystem.ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html), and [TaleWorlds.CampaignSystem.IRandomOwner](interface_tale_worlds_1_1_campaign_system_1_1_i_random_owner.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [CharacterStates](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157) {     [NotSpawned](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157a273ffc42d243746041a3ea114b200c55) ,     [Active](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157a4d3d769b812b6faa6b76e1a8abaece2d) ,     [Fugitive](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157a34946d546d22eaf06fdbe795b8de802b) ,     [Prisoner](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157a0862a78e358ab0a158439d23cae77e2c) ,     [Released](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157aea1e34304a5d8ffa7c9b0ed8ede4ef1a) ,     [Dead](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157a183b62c7f067711f9c5a54913c054617) ,     [Disabled](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157ab9f5c797ebbf55adccdd8539a65a0241) ,     [Traveling](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157a534ae0202dfc1e2f430fe1a1e7fb1dc7)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a7066fb1bbc3ec392bd973552a6e9dcd2) () |
| void | [SetName](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae2764abc90c4153e241dacca0af670f2) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) fullName, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) firstName) |
| void | [OnIssueCreatedForHero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aebd985de8c3cf94346d321531e74221e) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
| void | [OnIssueDeactivatedForHero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#afda8352d264d15b420a1b20988ab75aa) () |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a924087d205cafe6a8ada48ec38d48f50) () |
| void | [UpdateLastKnownClosestSettlement](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a3e831e8b7144258eed2568cb9715b4c7) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [SetNewOccupation](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a3b131703849174b400df88d547997ef2) ([Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) occupation) |
| void | [SetBirthDay](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a65fbc13547b8eceeec7441b91f3f6ca7) ([CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) birthday) |
| void | [SetDeathDay](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a73bf3c671f1e4c05a59efa8f1157a3ce) ([CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) deathDay) |
| void | [AddPower](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa03706bfd23529c2dbf31ba53d08e47b) (float value) |
| void | [SetHasMet](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a9dceda0220a64dc1bb10a238c442923a) () |
| void | [UpdatePowerModifier](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a1e7d04dfef5ad600d7737a33ddd8a64a) () |
| void | [UpdateHomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ada0ed7c553711d70fee885f7120c8ded) () |
| int | [GetSkillValue](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa2efe90e0470877cb2fc9692aa9f056e) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill) |
| void | [SetSkillValue](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac37cd251fde36c0cc7a3bac4114add8d) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, int value) |
| void | [ClearSkills](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ab9ebd7fe903a342461a37dd9bfa41ae2) () |
| void | [AddSkillXp](class_tale_worlds_1_1_campaign_system_1_1_hero.html#acadcc0a972b751443045a19c3d1a9734) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, float xpAmount) |
| int | [GetAttributeValue](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a25fbcfd11f7da5802b47392fa958515e) ([CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) charAttribute) |
| void | [ClearAttributes](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6e57e10c25b6bb51ba83e55244534600) () |
| void | [SetTraitLevel](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a39be1307c736814808c2797c48cd79b3) ([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int value) |
| int | [GetTraitLevel](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a24805b20fc2e961dc7ccd552cf5d1da2) ([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait) |
| void | [ClearTraits](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a704daa2ee594b8ccb7fcbc2807ebeb2f) () |
| bool | [GetPerkValue](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a40e82c022ae4d75eb7d1e21251845e72) ([PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk) |
| void | [ClearPerks](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aebc396bc935904717b6e9afabb079164) () |
|  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) (string stringId, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a95d83eccc2f3aa92b0115e321bd1b871) characterObject, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) birthDay) |
|  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac52946581de61042e22205847ce99953) (string stringId, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a95d83eccc2f3aa92b0115e321bd1b871) characterObject, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) birthDay, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) deathDay) |
|  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5479472e8fee19edc29e5bb63a308ad0) () |
| void | [ChangeState](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a51a6494c23bfd6ebc5460322b21a5ebf) ([CharacterStates](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157) newState) |
| bool | [IsHealthFull](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a18dc0b729c1cb0c1f7bae41263544d09) () |
| void | [Heal](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac5825fec233619ed251900520521e7ea) (int healAmount, bool addXp=false) |
| override void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a2bfd4f2dd7747f1edd5f036377bbb4fd) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| bool | [CanLeadParty](class_tale_worlds_1_1_campaign_system_1_1_hero.html#abca289ef544864caa408490b8c0f8c72) () |
| bool | [CanHeroEquipmentBeChanged](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a49a6f3a2211d9f56bec22cff1289be82) () |
| bool | [CanMarry](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a1015e58e4a9dee51f97accc94d3dcb20) () |
| bool | [CanBeGovernorOrHavePartyRole](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae7d4b0100b46155357a7a496a9364106) () |
| bool | [CanDie](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a409dcaf2b9de7294d163fd2e3040be92) ([KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) causeOfDeath) |
| bool | [CanBecomePrisoner](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a63fa3653ef46e63f2f44680386b939d2) () |
| bool | [CanMoveToSettlement](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a88713a836f1dbd2e2070419dddb6c47e) () |
| bool | [CanHaveCampaignIssues](class_tale_worlds_1_1_campaign_system_1_1_hero.html#af0aeb5cb700a56aed8f954be494d66ca) () |
| void | [AddInfluenceWithKingdom](class_tale_worlds_1_1_campaign_system_1_1_hero.html#af746a2c4f6e41438cce7b8e196296b2d) (float additionalInfluence) |
| float | [GetRelationWithPlayer](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ab34e152c5ba1d610b6b101e3126959b5) () |
| float | [GetUnmodifiedClanLeaderRelationshipWithPlayer](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a77fe9f4af64df9945889efc7898f72f4) () |
| void | [SetTextVariables](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a18426b2a163d45568f0efc180eb8b69b) () |
| void | [SetPersonalRelation](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a0ff6f43eb0ade61c42912319dc7fb432) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) otherHero, int value) |
| int | [GetRelation](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a63d427389072d2bf005dfc20484e77bb) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) otherHero) |
| int | [GetBaseHeroRelation](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a73968972685b4d74192ced52bcad9cd0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) otherHero) |
| bool | [IsEnemy](class_tale_worlds_1_1_campaign_system_1_1_hero.html#abbd6f787f5971ea6def5a9da1da73784) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) otherHero) |
| bool | [IsFriend](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa1b1c0378f8c8274b1413ef4503d33f5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) otherHero) |
| bool | [IsNeutral](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a047cca3995fc3dba4ebc29e092957bfb) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) otherHero) |
| void | [ModifyHair](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a393a9eef86e73a38b0af5e3795b57b99) (int hair, int beard, int tattoo) |
| void | [AddOwnedWorkshop](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a2e131992b736fc11b2b2bbc38e1f8603) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| void | [RemoveOwnedWorkshop](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a2cdbd14417d4341051eb96c7faaa0dfa) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| void | [MakeWounded](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa74c5b3eb30e54bd3ee76e7080062f45) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) killerHero=null, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) deathMarkDetail=KillCharacterAction.KillCharacterActionDetail.None) |
| void | [AddDeathMark](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6fde607520dbea613300ffe08931325e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) killerHero=null, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) deathMarkDetail=KillCharacterAction.KillCharacterActionDetail.None) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetPositionAsVec3](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a54e1300916490b8c648dd6d3075e987b) () |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GetCampaignPosition](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad46ae5201ea1389475ffabdc4775182f) () |
| [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) | [GetMapPoint](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a78eafcd1d7fc1f36a17e6058e7ae39a8) () |
| void | [ResetEquipments](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a8e90ef82ad5983b1acec972a0b7feeb8) () |
| void | [ChangeHeroGold](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ab8ca02cdd81621f9e64bbc886336b1b0) (int changeAmount) |
| void | [CheckInvalidEquipmentsAndReplaceIfNeeded](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d4fdeb6df4364e7f4d2443650eb324c) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [SetHeroEncyclopediaTextAndLinks](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a92ff47d116d84358c412f520a7ed0301) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) o) |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | [FindFirst](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6d462e50d3841c3c045be61e5e861500) (Func< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b), bool > predicate) |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | [Find](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aece1e77c65b4e7af007854e122ef8ff7) (string stringId) |
| static IEnumerable< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) > | [FindAll](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a80163dd65156945834986338b51865f0) (Func< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b), bool > predicate) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [LastTimeStampForActivity](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aeaa7ae54b34a6491dd3d24320cf8b1df) |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a95d83eccc2f3aa92b0115e321bd1b871)[] | [VolunteerTypes](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a8d8d21a88974eced71a5c0c6fe737f02) |
| int | [Level](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a72f4ba2bc390673222586ff00d91de0a) |
| bool | [HiddenInEncyclopedia](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a953af234905b7991e23f5493aa2b51ae) |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | [Culture](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a175704b378074a9ece80b102f7319362) |
| MBList< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [SpecialItems](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac1e2a059b2a32a75b8d63991f8fa0483) |
| bool | [IsPregnant](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac59194bd4530487e6fbb5f5cb284f428) = false |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MaximumNumberOfVolunteers](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4fdf19f1800016ce5bd1ca753a07a2d2) = 6 |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [PreAfterLoad](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a86e3ed76a35285e10205508c433feba5) () |
| override void | [AfterLoad](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4eca745c4ef81c2f9fb9c2e3b97db6f1) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |

|  |  |
| --- | --- |
| Properties | |
| StaticBodyProperties | [StaticBodyProperties](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5ff817758d3462fd637a4134128a58bc) `[get, set]` |
| float | [Weight](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad99b4b1459307ad5ed8da78025b2f4e1) `[get, set]` |
| float | [Build](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4099009576eb78d760dbe0b1269dabd2) `[get, set]` |
| BodyProperties | [BodyProperties](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a0e8132ba0a03d7bd5cb0e4b7737069cf) `[get]` |
| float | [PassedTimeAtHomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad4774c323e935ce63e09dfa511e1644a) `[get, set]` |
| bool | [CanHaveRecruits](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a9b1dfb9b6eb1a5cf04131ae3412ee15c) `[get]` |
| CharacterObject | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a95d83eccc2f3aa92b0115e321bd1b871) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [FirstName](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a116e87fb4535f62f0e056fe561bc306e) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ab71297e7eed0b835384b504f5fa71115) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaText](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a256f6fdccbf18b8c8fde6d1d33d0ffb5) `[get, set]` |
| string | [EncyclopediaLink](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a2760e6cc0357c82dcb16747ab612b226) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaLinkWithName](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a7e0e3aa36b9d1695aadee941a2b1963e) `[get]` |
| bool | [IsFemale](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a1c0d49bc6f3c16c626f1182b3ee841da) `[get, set]` |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [BattleEquipment](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a08704e39da4e1390031d2a313dd20dc7) `[get]` |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [CivilianEquipment](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae6d4d3fe168bb5701d23c5270a004ed8) `[get]` |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [StealthEquipment](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a27ffceaae23d7b4a681aadf5a88f3560) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [CaptivityStartTime](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a281f909fc048e70ecaa3409ef697d4cf) `[get, set]` |
| [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [PreferredUpgradeFormation](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aee609b57e96b7f6151670bc956090858) `[get, set]` |
| [CharacterStates](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157) | [HeroState](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a514f185560326fb5402c8f13e277c1aa) `[get]` |
| IReadOnlyPropertyOwner< [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) > | [CharacterAttributes](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a40cbca0b8d165268875d7bb58634fcd3) `[get]` |
| bool | [IsMinorFactionHero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac6670a7b1fd6532848138ffd8b23d4b4) `[get, set]` |
| [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | [Issue](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aeeb55463c265bb8b3cbeaf11aedccbf9) `[get]` |
| int | [WoundedHealthLimit](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a81a05e572ae46a858109ee1a63f7721f) `[get]` |
| bool | [IsNoncombatant](class_tale_worlds_1_1_campaign_system_1_1_hero.html#affddc72382a6bb3e0ec163ffc8364fbe) `[get]` |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae49430b99275c25a51c0313a28be5067) | [CompanionOf](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aafc8ce9992cdeb2671f462b81c390835) `[get, set]` |
| IEnumerable< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) > | [CompanionsInParty](class_tale_worlds_1_1_campaign_system_1_1_hero.html#af8bf5ec3e8a675b01585305fea6bf16d) `[get]` |
| [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) | [Occupation](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a3a79b1795e586716e92a9dbdf5039f6c) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a95d83eccc2f3aa92b0115e321bd1b871) | [Template](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a86d7f736643eae2105fa300b7e36516b) `[get]` |
| bool | [IsDead](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad7b310d3d1c1edf7e9ffffb226eb3b7c) `[get]` |
| bool | [IsFugitive](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a157c17c95f5ac0b07f1147213cb4c95c) `[get]` |
| bool | [IsPrisoner](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aedef74fa1253b63a133fb096164b71c0) `[get]` |
| bool | [IsReleased](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad0b499815b8dbf1ebefa116de3287151) `[get]` |
| bool | [IsActive](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a15c99f937f9a778e66a2e32708f90292) `[get]` |
| bool | [IsNotSpawned](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a193884f2839990c4d53ee73693449895) `[get]` |
| bool | [IsDisabled](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a1397a04a015a1022f9afc965c31d9d80) `[get]` |
| bool | [IsTraveling](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a9c990b154746a0d5b56ac5523bd12c1f) `[get]` |
| bool | [IsAlive](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ace9e32e11509d782604e1e4f195e9103) `[get]` |
| [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | [DeathMark](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a29368e2953a54168ef4b437fcdd24f29) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | [DeathMarkKillerHero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#af44c6319214e427c4c613b9f0fd34882) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [LastKnownClosestSettlement](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a49f799cda1d896e5b41dc991c28a8cbc) `[get]` |
| bool | [IsWanderer](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a227fbb4e572d72fd2ef8cdd527a3b573) `[get]` |
| bool | [IsTemplate](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac4a1118ea0d355847f178dbb6e1decd9) `[get]` |
| bool | [IsWounded](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a58fcbfc3b1f9e495dfc144eff7e5ec16) `[get]` |
| bool | [IsPlayerCompanion](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a37858a1ce354943db13471d84f70bc3e) `[get]` |
| bool | [IsMerchant](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4fa7d16d61ea6c591bd036d4e571e482) `[get]` |
| bool | [IsPreacher](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6c4facbe20c1f8c633b7be5e1d41dc0f) `[get]` |
| bool | [IsHeadman](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a212da26dd343765555d0e0d4353a73d7) `[get]` |
| bool | [IsGangLeader](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6ba141cb3b8c63d143929d4a0415eac7) `[get]` |
| bool | [IsArtisan](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a91de5a23e0036349ea92c2a3b16b6045) `[get]` |
| bool | [IsRuralNotable](class_tale_worlds_1_1_campaign_system_1_1_hero.html#adb9a4f8263667e452a1c883e5be62d02) `[get]` |
| bool | [IsUrbanNotable](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aeca0ebf227c126c6944e764d7371dc93) `[get]` |
| bool | [IsSpecial](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6cde8500158a795c5185f956f2270986) `[get]` |
| bool | [IsRebel](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae673395aae5822d2688dec3372945d98) `[get]` |
| bool | [IsCommander](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4c8965a766b66958808104767bc7b0ee) `[get]` |
| bool | [IsPartyLeader](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a0e61885d4fc5b173d1e24864b38dc3d9) `[get]` |
| bool | [IsNotable](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aee4bec1d46104852f21ea1b07ef3e4b9) `[get]` |
| bool | [IsLord](class_tale_worlds_1_1_campaign_system_1_1_hero.html#abe45a26ac488f0e7f11fe7ae74b237c1) `[get]` |
| int | [MaxHitPoints](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5525b2446010a257e1477bf958b5727a) `[get]` |
| int | [HitPoints](class_tale_worlds_1_1_campaign_system_1_1_hero.html#adff7e5c4edebff2b9e81ff0f39d9b0bb) `[get, set]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [BirthDay](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a86685007d337050410c17c7da0c4eb82) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [DeathDay](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a2cc156cf8e4298da5ce907dcb1b0579c) `[get]` |
| float | [Age](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae92effc1c26e19f5c22926d3dc7c9b40) `[get]` |
| bool | [IsChild](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a7ba140cbc75f58782976776166cc57a9) `[get]` |
| float | [Power](class_tale_worlds_1_1_campaign_system_1_1_hero.html#afe1d63d6bce68d5327e8013add1ab175) `[get]` |
| [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | [ClanBanner](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a9a1ddba5306d8716c673a57050bc5f75) `[get]` |
| long | [LastExaminedLogEntryID](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a1505f00cccedb5f766fc45c767e37566) `[get, set]` |
| Clan | [Clan](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae49430b99275c25a51c0313a28be5067) `[get, set]` |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae49430b99275c25a51c0313a28be5067) | [SupporterOf](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae13eb320151fcfd23b511454f5351c90) `[get, set]` |
| [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | [GovernorOf](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa913518d5bbe32fb79be8af3e29e4e99) `[get, set]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](class_tale_worlds_1_1_campaign_system_1_1_hero.html#af75cb27d646158af3d4505cf500e8b01) `[get]` |
| List< [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) > | [OwnedAlleys](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ab0dfb1245a2af667ee080d3a61ac9e28) `[get]` |
| bool | [IsFactionLeader](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4621285b090e7bea15ca27abae4bb3f2) `[get]` |
| bool | [IsKingdomLeader](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa5e4c894086d3f820efa792ae5e16d8d) `[get]` |
| bool | [IsClanLeader](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6d8437ad781f9630be76e3876b48223a) `[get]` |
| List< [CaravanPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html) > | [OwnedCaravans](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac5fd45686da7c911ebf2952e9ecbc99b) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [PartyBelongedTo](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4970923eccb902dc5bf65badf39bf753) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [PartyBelongedToAsPrisoner](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a85b82a4dc41f7dd115dae2634b7a1b71) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [StayingInSettlement](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac7bd8236959205974f77a10ac64a2aa7) `[get, set]` |
| bool | [IsHumanPlayerCharacter](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad4a512286fb42310ff4462abeef94be7) `[get]` |
| bool | [IsKnownToPlayer](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a442c43d104ce524880b90223e1140bbc) `[get, set]` |
| bool | [HasMet](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a757d5201dc8dfc51e10101adaa38ac4e) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [LastMeetingTimeWithPlayer](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aad1f9886b52d9ad60df5890fc89b2730) `[get, set]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [BornSettlement](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa510d79dbcc7a608967148e2c59d8535) `[get, set]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [HomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_hero.html#abad85605081861fce4539fc5308b005c) `[get]` |
| float | [PowerModifier](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac1eda772ee1a6f5285c94dc316ed0c85) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [CurrentSettlement](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac254c53458191cc92fc42c137af4491e) `[get]` |
| int | [Gold](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a9aba4ee0c8277247296d866379864de5) `[get, set]` |
| int | [RandomValue](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6a215a452321658811ecdfdbfee18be9) = [MBRandom.RandomInt](class_tale_worlds_1_1_core_1_1_m_b_random.html#a7d276a08934ed0203f18e814b5584619)(1, int.MaxValue) `[get]` |
| [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | [BannerItem](class_tale_worlds_1_1_campaign_system_1_1_hero.html#af46216c89c5a08aa78e7308c3759acd7) `[get, set]` |
| float | [ProbabilityOfDeath](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aad31af1945eebffe54db763cd62cb174) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | [Father](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a68945b489cbab60ca780d9ee924c99fb) `[get, set]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | [Mother](class_tale_worlds_1_1_campaign_system_1_1_hero.html#abcc027466ae8d5cc4ce39f8d84780d62) `[get, set]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) > | [ExSpouses](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac22c291e291eb42a9fed7c3fd7a98346) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | [Spouse](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad96e39ec0f1a19458f2c45cc6a9d3441) `[get, set]` |
| MBList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) > | [Children](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad2bc2b48e1364f287d1f8a72cb2a9ea1) `[get]` |
| IEnumerable< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) > | [Siblings](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5b484f49c2ac9549fb2a8759819a00ca) `[get]` |
| HeroDeveloper | [HeroDeveloper](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad46d6a08169ef1d5c881e88c4a4ae737) `[get]` |
| MBReadOnlyList< [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) > | [OwnedWorkshops](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a795bd95b1f4ecf03539fc159e609231e) `[get]` |
| static MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) > | [AllAliveHeroes](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aec4cd979eb8339cc82db3f0b0971dd64) `[get]` |
| static MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) > | [DeadOrDisabledHeroes](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad5bcf35609061dee29919bf83efc79d6) `[get]` |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | [MainHero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6dce2579f092bf9f8f66fb5905a0a604) `[get]` |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | [OneToOneConversationHero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a10b58ba4e3c9271cbe7c7e8f94159624) `[get]` |
| static bool | [IsMainHeroIll](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a709209b445366133371c797d59e656c3) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) | |
| bool | [IsReady](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html#a69166dbcedc127fea26c01d2428d01d7) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157)CharacterStates
---------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Hero.CharacterStates](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157) |

| Enumerator | |
| --- | --- |
| NotSpawned |  |
| Active |  |
| Fugitive |  |
| Prisoner |  |
| Released |  |
| Dead |  |
| Disabled |  |
| Traveling |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b)Hero() [1/3]
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Hero.Hero | ( | string | *stringId*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a95d83eccc2f3aa92b0115e321bd1b871) | *characterObject*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *birthDay* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac52946581de61042e22205847ce99953)Hero() [2/3]
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Hero.Hero | ( | string | *stringId*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a95d83eccc2f3aa92b0115e321bd1b871) | *characterObject*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *birthDay*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *deathDay* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5479472e8fee19edc29e5bb63a308ad0)Hero() [3/3]
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Hero.Hero | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a7066fb1bbc3ec392bd973552a6e9dcd2)GetName()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Hero.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db).

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae2764abc90c4153e241dacca0af670f2)SetName()
---------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.SetName | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *fullName*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *firstName* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aebd985de8c3cf94346d321531e74221e)OnIssueCreatedForHero()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.OnIssueCreatedForHero | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#afda8352d264d15b420a1b20988ab75aa)OnIssueDeactivatedForHero()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.OnIssueDeactivatedForHero | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a924087d205cafe6a8ada48ec38d48f50)ToString()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Hero.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a3e831e8b7144258eed2568cb9715b4c7)UpdateLastKnownClosestSettlement()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.UpdateLastKnownClosestSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a3b131703849174b400df88d547997ef2)SetNewOccupation()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.SetNewOccupation | ( | [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) | *occupation* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a65fbc13547b8eceeec7441b91f3f6ca7)SetBirthDay()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.SetBirthDay | ( | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *birthday* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a73bf3c671f1e4c05a59efa8f1157a3ce)SetDeathDay()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.SetDeathDay | ( | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *deathDay* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa03706bfd23529c2dbf31ba53d08e47b)AddPower()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.AddPower | ( | float | *value* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a9dceda0220a64dc1bb10a238c442923a)SetHasMet()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.SetHasMet | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a1e7d04dfef5ad600d7737a33ddd8a64a)UpdatePowerModifier()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.UpdatePowerModifier | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ada0ed7c553711d70fee885f7120c8ded)UpdateHomeSettlement()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.UpdateHomeSettlement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa2efe90e0470877cb2fc9692aa9f056e)GetSkillValue()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Hero.GetSkillValue | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac37cd251fde36c0cc7a3bac4114add8d)SetSkillValue()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.SetSkillValue | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | int | *value* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ab9ebd7fe903a342461a37dd9bfa41ae2)ClearSkills()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.ClearSkills | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#acadcc0a972b751443045a19c3d1a9734)AddSkillXp()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.AddSkillXp | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | float | *xpAmount* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a25fbcfd11f7da5802b47392fa958515e)GetAttributeValue()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Hero.GetAttributeValue | ( | [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) | *charAttribute* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6e57e10c25b6bb51ba83e55244534600)ClearAttributes()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.ClearAttributes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a39be1307c736814808c2797c48cd79b3)SetTraitLevel()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.SetTraitLevel | ( | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, |
|  |  | int | *value* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a24805b20fc2e961dc7ccd552cf5d1da2)GetTraitLevel()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Hero.GetTraitLevel | ( | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a704daa2ee594b8ccb7fcbc2807ebeb2f)ClearTraits()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.ClearTraits | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a40e82c022ae4d75eb7d1e21251845e72)GetPerkValue()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.GetPerkValue | ( | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aebc396bc935904717b6e9afabb079164)ClearPerks()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.ClearPerks | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a86e3ed76a35285e10205508c433feba5)PreAfterLoad()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Hero.PreAfterLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4eca745c4ef81c2f9fb9c2e3b97db6f1)AfterLoad()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Hero.AfterLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413).

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a51a6494c23bfd6ebc5460322b21a5ebf)ChangeState()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.ChangeState | ( | [CharacterStates](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157) | *newState* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a18dc0b729c1cb0c1f7bae41263544d09)IsHealthFull()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.IsHealthFull | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac5825fec233619ed251900520521e7ea)Heal()
------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.Heal | ( | int | *healAmount*, |
|  |  | bool | *addXp* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a2bfd4f2dd7747f1edd5f036377bbb4fd)Deserialize()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Hero.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#abca289ef544864caa408490b8c0f8c72)CanLeadParty()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.CanLeadParty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a92ff47d116d84358c412f520a7ed0301)SetHeroEncyclopediaTextAndLinks()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Hero.SetHeroEncyclopediaTextAndLinks | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | *o* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a49a6f3a2211d9f56bec22cff1289be82)CanHeroEquipmentBeChanged()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.CanHeroEquipmentBeChanged | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a1015e58e4a9dee51f97accc94d3dcb20)CanMarry()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.CanMarry | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae7d4b0100b46155357a7a496a9364106)CanBeGovernorOrHavePartyRole()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.CanBeGovernorOrHavePartyRole | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a409dcaf2b9de7294d163fd2e3040be92)CanDie()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.CanDie | ( | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *causeOfDeath* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a63fa3653ef46e63f2f44680386b939d2)CanBecomePrisoner()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.CanBecomePrisoner | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a88713a836f1dbd2e2070419dddb6c47e)CanMoveToSettlement()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.CanMoveToSettlement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#af0aeb5cb700a56aed8f954be494d66ca)CanHaveCampaignIssues()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.CanHaveCampaignIssues | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#af746a2c4f6e41438cce7b8e196296b2d)AddInfluenceWithKingdom()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.AddInfluenceWithKingdom | ( | float | *additionalInfluence* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ab34e152c5ba1d610b6b101e3126959b5)GetRelationWithPlayer()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Hero.GetRelationWithPlayer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a77fe9f4af64df9945889efc7898f72f4)GetUnmodifiedClanLeaderRelationshipWithPlayer()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Hero.GetUnmodifiedClanLeaderRelationshipWithPlayer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a18426b2a163d45568f0efc180eb8b69b)SetTextVariables()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.SetTextVariables | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a0ff6f43eb0ade61c42912319dc7fb432)SetPersonalRelation()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.SetPersonalRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | *otherHero*, |
|  |  | int | *value* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a63d427389072d2bf005dfc20484e77bb)GetRelation()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Hero.GetRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | *otherHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a73968972685b4d74192ced52bcad9cd0)GetBaseHeroRelation()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Hero.GetBaseHeroRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | *otherHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#abbd6f787f5971ea6def5a9da1da73784)IsEnemy()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.IsEnemy | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | *otherHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa1b1c0378f8c8274b1413ef4503d33f5)IsFriend()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.IsFriend | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | *otherHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a047cca3995fc3dba4ebc29e092957bfb)IsNeutral()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Hero.IsNeutral | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | *otherHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a393a9eef86e73a38b0af5e3795b57b99)ModifyHair()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.ModifyHair | ( | int | *hair*, |
|  |  | int | *beard*, |
|  |  | int | *tattoo* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a2e131992b736fc11b2b2bbc38e1f8603)AddOwnedWorkshop()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.AddOwnedWorkshop | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a2cdbd14417d4341051eb96c7faaa0dfa)RemoveOwnedWorkshop()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.RemoveOwnedWorkshop | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6d462e50d3841c3c045be61e5e861500)FindFirst()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) TaleWorlds.CampaignSystem.Hero.FindFirst | ( | Func< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b), bool > | *predicate* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aece1e77c65b4e7af007854e122ef8ff7)Find()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) TaleWorlds.CampaignSystem.Hero.Find | ( | string | *stringId* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a80163dd65156945834986338b51865f0)FindAll()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) > TaleWorlds.CampaignSystem.Hero.FindAll | ( | Func< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b), bool > | *predicate* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa74c5b3eb30e54bd3ee76e7080062f45)MakeWounded()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.MakeWounded | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | *killerHero* = null, |
|  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *deathMarkDetail* = KillCharacterAction::KillCharacterActionDetail::None ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6fde607520dbea613300ffe08931325e)AddDeathMark()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.AddDeathMark | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) | *killerHero* = null, |
|  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *deathMarkDetail* = KillCharacterAction::KillCharacterActionDetail::None ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a54e1300916490b8c648dd6d3075e987b)GetPositionAsVec3()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.CampaignSystem.Hero.GetPositionAsVec3 | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad46ae5201ea1389475ffabdc4775182f)GetCampaignPosition()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Hero.GetCampaignPosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a78eafcd1d7fc1f36a17e6058e7ae39a8)GetMapPoint()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) TaleWorlds.CampaignSystem.Hero.GetMapPoint | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a8e90ef82ad5983b1acec972a0b7feeb8)ResetEquipments()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.ResetEquipments | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ab8ca02cdd81621f9e64bbc886336b1b0)ChangeHeroGold()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.ChangeHeroGold | ( | int | *changeAmount* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d4fdeb6df4364e7f4d2443650eb324c)CheckInvalidEquipmentsAndReplaceIfNeeded()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Hero.CheckInvalidEquipmentsAndReplaceIfNeeded | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aeaa7ae54b34a6491dd3d24320cf8b1df)LastTimeStampForActivity
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Hero.LastTimeStampForActivity |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4fdf19f1800016ce5bd1ca753a07a2d2)MaximumNumberOfVolunteers
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.Hero.MaximumNumberOfVolunteers = 6 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a8d8d21a88974eced71a5c0c6fe737f02)VolunteerTypes
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a95d83eccc2f3aa92b0115e321bd1b871) [] TaleWorlds.CampaignSystem.Hero.VolunteerTypes |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a72f4ba2bc390673222586ff00d91de0a)Level
-----------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Hero.Level |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a953af234905b7991e23f5493aa2b51ae)HiddenInEncyclopedia
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Hero.HiddenInEncyclopedia |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a175704b378074a9ece80b102f7319362)Culture
-------------------------------------------------------------------------------------------------

|  |
| --- |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) TaleWorlds.CampaignSystem.Hero.Culture |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac1e2a059b2a32a75b8d63991f8fa0483)SpecialItems
------------------------------------------------------------------------------------------------------

|  |
| --- |
| MBList<[ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html)> TaleWorlds.CampaignSystem.Hero.SpecialItems |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac59194bd4530487e6fbb5f5cb284f428)IsPregnant
----------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Hero.IsPregnant = false |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5ff817758d3462fd637a4134128a58bc)StaticBodyProperties
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | StaticBodyProperties TaleWorlds.CampaignSystem.Hero.StaticBodyProperties | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad99b4b1459307ad5ed8da78025b2f4e1)Weight
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Hero.Weight | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4099009576eb78d760dbe0b1269dabd2)Build
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Hero.Build | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a0e8132ba0a03d7bd5cb0e4b7737069cf)BodyProperties
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | BodyProperties TaleWorlds.CampaignSystem.Hero.BodyProperties | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad4774c323e935ce63e09dfa511e1644a)PassedTimeAtHomeSettlement
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Hero.PassedTimeAtHomeSettlement | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a9b1dfb9b6eb1a5cf04131ae3412ee15c)CanHaveRecruits
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.CanHaveRecruits | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a95d83eccc2f3aa92b0115e321bd1b871)CharacterObject
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CharacterObject TaleWorlds.CampaignSystem.Hero.CharacterObject | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a116e87fb4535f62f0e056fe561bc306e)FirstName
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Hero.FirstName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ab71297e7eed0b835384b504f5fa71115)Name
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Hero.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a256f6fdccbf18b8c8fde6d1d33d0ffb5)EncyclopediaText
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Hero.EncyclopediaText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a2760e6cc0357c82dcb16747ab612b226)EncyclopediaLink
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Hero.EncyclopediaLink | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a7e0e3aa36b9d1695aadee941a2b1963e)EncyclopediaLinkWithName
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Hero.EncyclopediaLinkWithName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a1c0d49bc6f3c16c626f1182b3ee841da)IsFemale
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsFemale | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a08704e39da4e1390031d2a313dd20dc7)BattleEquipment
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.CampaignSystem.Hero.BattleEquipment | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae6d4d3fe168bb5701d23c5270a004ed8)CivilianEquipment
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.CampaignSystem.Hero.CivilianEquipment | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a27ffceaae23d7b4a681aadf5a88f3560)StealthEquipment
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.CampaignSystem.Hero.StealthEquipment | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a281f909fc048e70ecaa3409ef697d4cf)CaptivityStartTime
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Hero.CaptivityStartTime | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aee609b57e96b7f6151670bc956090858)PreferredUpgradeFormation
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.CampaignSystem.Hero.PreferredUpgradeFormation | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a514f185560326fb5402c8f13e277c1aa)HeroState
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterStates](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5d97848f11b7de5bae4abd3ddaf54157) TaleWorlds.CampaignSystem.Hero.HeroState | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a40cbca0b8d165268875d7bb58634fcd3)CharacterAttributes
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IReadOnlyPropertyOwner<[CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html)> TaleWorlds.CampaignSystem.Hero.CharacterAttributes | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac6670a7b1fd6532848138ffd8b23d4b4)IsMinorFactionHero
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsMinorFactionHero | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aeeb55463c265bb8b3cbeaf11aedccbf9)Issue
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) TaleWorlds.CampaignSystem.Hero.Issue | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a81a05e572ae46a858109ee1a63f7721f)WoundedHealthLimit
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Hero.WoundedHealthLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#affddc72382a6bb3e0ec163ffc8364fbe)IsNoncombatant
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsNoncombatant | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aafc8ce9992cdeb2671f462b81c390835)CompanionOf
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae49430b99275c25a51c0313a28be5067) TaleWorlds.CampaignSystem.Hero.CompanionOf | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#af8bf5ec3e8a675b01585305fea6bf16d)CompanionsInParty
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b)> TaleWorlds.CampaignSystem.Hero.CompanionsInParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a3a79b1795e586716e92a9dbdf5039f6c)Occupation
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) TaleWorlds.CampaignSystem.Hero.Occupation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a86d7f736643eae2105fa300b7e36516b)Template
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a95d83eccc2f3aa92b0115e321bd1b871) TaleWorlds.CampaignSystem.Hero.Template | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad7b310d3d1c1edf7e9ffffb226eb3b7c)IsDead
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsDead | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a157c17c95f5ac0b07f1147213cb4c95c)IsFugitive
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsFugitive | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aedef74fa1253b63a133fb096164b71c0)IsPrisoner
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsPrisoner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad0b499815b8dbf1ebefa116de3287151)IsReleased
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsReleased | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a15c99f937f9a778e66a2e32708f90292)IsActive
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsActive | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a193884f2839990c4d53ee73693449895)IsNotSpawned
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsNotSpawned | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a1397a04a015a1022f9afc965c31d9d80)IsDisabled
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsDisabled | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a9c990b154746a0d5b56ac5523bd12c1f)IsTraveling
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsTraveling | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ace9e32e11509d782604e1e4f195e9103)IsAlive
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsAlive | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a29368e2953a54168ef4b437fcdd24f29)DeathMark
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) TaleWorlds.CampaignSystem.Hero.DeathMark | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#af44c6319214e427c4c613b9f0fd34882)DeathMarkKillerHero
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) TaleWorlds.CampaignSystem.Hero.DeathMarkKillerHero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a49f799cda1d896e5b41dc991c28a8cbc)LastKnownClosestSettlement
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Hero.LastKnownClosestSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a227fbb4e572d72fd2ef8cdd527a3b573)IsWanderer
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsWanderer | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac4a1118ea0d355847f178dbb6e1decd9)IsTemplate
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsTemplate | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a58fcbfc3b1f9e495dfc144eff7e5ec16)IsWounded
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsWounded | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a37858a1ce354943db13471d84f70bc3e)IsPlayerCompanion
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsPlayerCompanion | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4fa7d16d61ea6c591bd036d4e571e482)IsMerchant
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsMerchant | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6c4facbe20c1f8c633b7be5e1d41dc0f)IsPreacher
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsPreacher | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a212da26dd343765555d0e0d4353a73d7)IsHeadman
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsHeadman | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6ba141cb3b8c63d143929d4a0415eac7)IsGangLeader
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsGangLeader | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a91de5a23e0036349ea92c2a3b16b6045)IsArtisan
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsArtisan | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#adb9a4f8263667e452a1c883e5be62d02)IsRuralNotable
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsRuralNotable | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aeca0ebf227c126c6944e764d7371dc93)IsUrbanNotable
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsUrbanNotable | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6cde8500158a795c5185f956f2270986)IsSpecial
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsSpecial | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae673395aae5822d2688dec3372945d98)IsRebel
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsRebel | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4c8965a766b66958808104767bc7b0ee)IsCommander
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsCommander | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a0e61885d4fc5b173d1e24864b38dc3d9)IsPartyLeader
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsPartyLeader | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aee4bec1d46104852f21ea1b07ef3e4b9)IsNotable
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsNotable | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#abe45a26ac488f0e7f11fe7ae74b237c1)IsLord
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsLord | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5525b2446010a257e1477bf958b5727a)MaxHitPoints
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Hero.MaxHitPoints | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#adff7e5c4edebff2b9e81ff0f39d9b0bb)HitPoints
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Hero.HitPoints | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a86685007d337050410c17c7da0c4eb82)BirthDay
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Hero.BirthDay | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a2cc156cf8e4298da5ce907dcb1b0579c)DeathDay
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Hero.DeathDay | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae92effc1c26e19f5c22926d3dc7c9b40)Age
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Hero.Age | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a7ba140cbc75f58782976776166cc57a9)IsChild
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsChild | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#afe1d63d6bce68d5327e8013add1ab175)Power
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Hero.Power | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a9a1ddba5306d8716c673a57050bc5f75)ClanBanner
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) TaleWorlds.CampaignSystem.Hero.ClanBanner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a1505f00cccedb5f766fc45c767e37566)LastExaminedLogEntryID
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | long TaleWorlds.CampaignSystem.Hero.LastExaminedLogEntryID | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae49430b99275c25a51c0313a28be5067)Clan
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Clan TaleWorlds.CampaignSystem.Hero.Clan | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae13eb320151fcfd23b511454f5351c90)SupporterOf
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ae49430b99275c25a51c0313a28be5067) TaleWorlds.CampaignSystem.Hero.SupporterOf | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa913518d5bbe32fb79be8af3e29e4e99)GovernorOf
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) TaleWorlds.CampaignSystem.Hero.GovernorOf | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#af75cb27d646158af3d4505cf500e8b01)MapFaction
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Hero.MapFaction | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ab0dfb1245a2af667ee080d3a61ac9e28)OwnedAlleys
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html)> TaleWorlds.CampaignSystem.Hero.OwnedAlleys | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4621285b090e7bea15ca27abae4bb3f2)IsFactionLeader
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsFactionLeader | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa5e4c894086d3f820efa792ae5e16d8d)IsKingdomLeader
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsKingdomLeader | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6d8437ad781f9630be76e3876b48223a)IsClanLeader
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsClanLeader | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac5fd45686da7c911ebf2952e9ecbc99b)OwnedCaravans
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[CaravanPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_caravan_party_component.html)> TaleWorlds.CampaignSystem.Hero.OwnedCaravans | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a4970923eccb902dc5bf65badf39bf753)PartyBelongedTo
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.Hero.PartyBelongedTo | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a85b82a4dc41f7dd115dae2634b7a1b71)PartyBelongedToAsPrisoner
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Hero.PartyBelongedToAsPrisoner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac7bd8236959205974f77a10ac64a2aa7)StayingInSettlement
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Hero.StayingInSettlement | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad4a512286fb42310ff4462abeef94be7)IsHumanPlayerCharacter
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsHumanPlayerCharacter | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a442c43d104ce524880b90223e1140bbc)IsKnownToPlayer
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsKnownToPlayer | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a757d5201dc8dfc51e10101adaa38ac4e)HasMet
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.HasMet | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aad1f9886b52d9ad60df5890fc89b2730)LastMeetingTimeWithPlayer
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Hero.LastMeetingTimeWithPlayer | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aa510d79dbcc7a608967148e2c59d8535)BornSettlement
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Hero.BornSettlement | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#abad85605081861fce4539fc5308b005c)HomeSettlement
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Hero.HomeSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac1eda772ee1a6f5285c94dc316ed0c85)PowerModifier
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Hero.PowerModifier | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac254c53458191cc92fc42c137af4491e)CurrentSettlement
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Hero.CurrentSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a9aba4ee0c8277247296d866379864de5)Gold
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Hero.Gold | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6a215a452321658811ecdfdbfee18be9)RandomValue
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Hero.RandomValue = [MBRandom.RandomInt](class_tale_worlds_1_1_core_1_1_m_b_random.html#a7d276a08934ed0203f18e814b5584619)(1, int.MaxValue) | | get |

Implements [TaleWorlds.CampaignSystem.IRandomOwner](interface_tale_worlds_1_1_campaign_system_1_1_i_random_owner.html#ad9f2a476dc29e7b3268949ab048d5ac7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#af46216c89c5a08aa78e7308c3759acd7)BannerItem
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) TaleWorlds.CampaignSystem.Hero.BannerItem | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aad31af1945eebffe54db763cd62cb174)ProbabilityOfDeath
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Hero.ProbabilityOfDeath | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a68945b489cbab60ca780d9ee924c99fb)Father
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) TaleWorlds.CampaignSystem.Hero.Father | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#abcc027466ae8d5cc4ce39f8d84780d62)Mother
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) TaleWorlds.CampaignSystem.Hero.Mother | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ac22c291e291eb42a9fed7c3fd7a98346)ExSpouses
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b)> TaleWorlds.CampaignSystem.Hero.ExSpouses | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad96e39ec0f1a19458f2c45cc6a9d3441)Spouse
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) TaleWorlds.CampaignSystem.Hero.Spouse | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad2bc2b48e1364f287d1f8a72cb2a9ea1)Children
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b)> TaleWorlds.CampaignSystem.Hero.Children | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a5b484f49c2ac9549fb2a8759819a00ca)Siblings
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b)> TaleWorlds.CampaignSystem.Hero.Siblings | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad46d6a08169ef1d5c881e88c4a4ae737)HeroDeveloper
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | HeroDeveloper TaleWorlds.CampaignSystem.Hero.HeroDeveloper | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a795bd95b1f4ecf03539fc159e609231e)OwnedWorkshops
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html)> TaleWorlds.CampaignSystem.Hero.OwnedWorkshops | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#aec4cd979eb8339cc82db3f0b0971dd64)AllAliveHeroes
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b)> TaleWorlds.CampaignSystem.Hero.AllAliveHeroes | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#ad5bcf35609061dee29919bf83efc79d6)DeadOrDisabledHeroes
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b)> TaleWorlds.CampaignSystem.Hero.DeadOrDisabledHeroes | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6dce2579f092bf9f8f66fb5905a0a604)MainHero
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) TaleWorlds.CampaignSystem.Hero.MainHero | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a10b58ba4e3c9271cbe7c7e8f94159624)OneToOneConversationHero
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a280b6fe8395b4f069c88f4bb3d0b704b) TaleWorlds.CampaignSystem.Hero.OneToOneConversationHero | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a709209b445366133371c797d59e656c3)IsMainHeroIll
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Hero.IsMainHeroIll | | staticget |


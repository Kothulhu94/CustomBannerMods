--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html ---

TaleWorlds.CampaignSystem.Actions.ChangeRelationAction Class Reference[ChangeRelationAction](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html "ChangeRelationAction class handles the relation changes and its after effects. Effective heroes are c...") class handles the relation changes and its after effects. Effective heroes are chosen in [DiplomacyModel.GetHeroesForEffectiveRelation(Hero, Hero, out Hero, out Hero)](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a74d4dcc751296253a658211fe7747f9a) function. will fire [CampaignEvents.HeroRelationChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac6318731f8b67f6eb85f670c0217f2da) event. To bypass its after effects, use [Hero.SetPersonalRelation(Hero, int)](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a0ff6f43eb0ade61c42912319dc7fb432) directly.

|  |  |
| --- | --- |
| Public Types | |
| enum | [ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) {     [Default](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109eda7a1920d61156abc05a60135aefe8bc67) ,     [Emissary](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109edaad5a98e198c4d2095154fe89488effe1)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [ApplyPlayerRelation](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#ac07bb9997e97c43e100998f2650ae3d6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) gainedRelationWith, int relation, bool affectRelatives=true, bool showQuickNotification=true) |
|  | Handles the relation changes using effective heroes and relation. For base relation change use See also  [Hero.SetPersonalRelation(Hero, int)](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a0ff6f43eb0ade61c42912319dc7fb432)  . Example Code: |
| static void | [ApplyRelationChangeBetweenHeroes](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a1e867eba4f8ac410656af7bc5eaaabdc) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) gainedRelationWith, int relationChange, bool showQuickNotification=true) |
|  | Handles the relation changes using effective heroes and relation. For base relation change use See also  [Hero.SetPersonalRelation(Hero, int)](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a0ff6f43eb0ade61c42912319dc7fb432)  .  Parameters  |  |  | | --- | --- | | hero |  | | gainedRelationWith |  | | relationChange |  | | showQuickNotification |  |  . |
| static void | [ApplyEmissaryRelation](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#aa815193e6c9d3e26f69d0ce9658bede8) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) emissary, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) gainedRelationWith, int relationChange, bool showQuickNotification=true) |
|  | Handles the relation changes using effective heroes and relation. For base relation change use See also  [Hero.SetPersonalRelation(Hero, int)](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a0ff6f43eb0ade61c42912319dc7fb432)  .  Parameters  |  |  | | --- | --- | | emissary |  | | gainedRelationWith |  | | relationChange |  | | showQuickNotification |  |  . |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed)ChangeRelationDetail
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Actions.ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) |

| Enumerator | |
| --- | --- |
| Default |  |
| Emissary |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#ac07bb9997e97c43e100998f2650ae3d6)ApplyPlayerRelation()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeRelationAction.ApplyPlayerRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *gainedRelationWith*, | |  |  | int | *relation*, | |  |  | bool | *affectRelatives* = true, | |  |  | bool | *showQuickNotification* = true ) | | static |

[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html).[MainHero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6dce2579f092bf9f8f66fb5905a0a604).[SetPersonalRelation](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a0ff6f43eb0ade61c42912319dc7fb432)(hero, 10);

MBInformationManager.AddQuickInformation(notification, 0, null, soundEventPath: soundEventPath);

[TaleWorlds.CampaignSystem.Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)

**Definition** Hero.cs:29

[TaleWorlds.CampaignSystem.Hero.SetPersonalRelation](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a0ff6f43eb0ade61c42912319dc7fb432)

void SetPersonalRelation(Hero otherHero, int value)

**Definition** Hero.cs:1901

[TaleWorlds.CampaignSystem.Hero.MainHero](class_tale_worlds_1_1_campaign_system_1_1_hero.html#a6dce2579f092bf9f8f66fb5905a0a604)

static Hero MainHero

**Definition** Hero.cs:1986

Parameters
:   |  |  |
    | --- | --- |
    | gainedRelationWith |  |
    | relation |  |
    | affectRelatives |  |
    | showQuickNotification |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a1e867eba4f8ac410656af7bc5eaaabdc)ApplyRelationChangeBetweenHeroes()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeRelationAction.ApplyRelationChangeBetweenHeroes | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *gainedRelationWith*, | |  |  | int | *relationChange*, | |  |  | bool | *showQuickNotification* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#aa815193e6c9d3e26f69d0ce9658bede8)ApplyEmissaryRelation()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Actions.ChangeRelationAction.ApplyEmissaryRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *emissary*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *gainedRelationWith*, | |  |  | int | *relationChange*, | |  |  | bool | *showQuickNotification* = true ) | | static |


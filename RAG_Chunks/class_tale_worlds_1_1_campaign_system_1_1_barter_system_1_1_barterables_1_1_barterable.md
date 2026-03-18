--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html ---

TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable Class ReferenceabstractInherited by [TaleWorlds.CampaignSystem.BarterSystem.Barterables.DeclareWarBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_declare_war_barterable.html), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.FiefBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_fief_barterable.html), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.GoldBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_gold_barterable.html), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.ItemBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_item_barterable.html), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.JoinKingdomAsClanBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_join_kingdom_as_clan_barterable.html), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.LeaveKingdomAsClanBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_leave_kingdom_as_clan_barterable.html), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.MercenaryJoinKingdomBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_mercenary_join_kingdom_barterable.html), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.NoAttackBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.SafePassageBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_safe_passage_barterable.html), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.SetPrisonerFreeBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_set_prisoner_free_barterable.html), and [TaleWorlds.CampaignSystem.BarterSystem.Barterables.TransferPrisonerBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_transfer_prisoner_barterable.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [BarterSide](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a626e1ef68f8cca1d2548409b08516eac) {     [Left](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a626e1ef68f8cca1d2548409b08516eaca945d5e233cf7d6240f6b783b36a374ff) ,     [Right](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a626e1ef68f8cca1d2548409b08516eaca92b09c7c48c520c3c55e497875da437c)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a09774cd7f8ac04d572e7237aa6e11449) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| virtual void | [CheckBarterLink](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a778fe2a3dd3cd5dbb9bfed0d40462edd) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) linkedBarterable) |
| int | [GetUnitValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a6f453dd249ea35fed818d58c144f0feb) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| void | [SetIsOffered](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ad89a63986957b0e3b6b3b1c60255f2f6) (bool value) |
| void | [AddBarterLink](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ab2b5850e9b1bd47856de8f5022b1c3ab) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) barterable) |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a657f35b1d729397fcd29f75cd1f14924) ([BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) barterGroup, bool isContextDependent) |
| virtual bool | [IsCompatible](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a87b0fd2be077e7c2b73fd09fc554a0dd) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) barterable) |
| [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) | [GetVisualIdentifier](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a33ac317dc0caf26eb81849c094480396) () |
| virtual string | [GetEncyclopediaLink](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#aea5609ce82fea3e19793b8d06abff5e8) () |
| void | [Apply](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ab006260c5693caf17ba35df796f30de4) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) originalOwner, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) originalParty) |

|  |  |
| --- | --- |
| Protected Attributes | |
| MBList< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) > | [\_linkedBarterables](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a5a938140d7ad81d0f032506096954022) |

|  |  |
| --- | --- |
| Properties | |
| string | [StringID](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ac4962d9d2877eeb1a4c32610e0ca2b81) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [OriginalOwner](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a0dd9e775de0861661bcfe11dd371d6ec) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [OriginalParty](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a9cc1c17817ca3a7a9c2cf391ffcbb6e4) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#aeafbc06e473c51f2c3bb66df6d21db23) `[get]` |
| virtual int | [MaxAmount](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a8843077652d336edf062f712635c3034) `[get]` |
| int | [CurrentAmount](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a8c862f503961cd2b01f127621ea8f974) `[get, set]` |
| bool | [IsOffered](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#abd84c0c43b1ebbfbba7def0d366a8761) `[get, protected set]` |
| bool | [IsContextDependent](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a420748a42aa4b05881fa601b4d808ab4) `[get, protected set]` |
| [BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) | [Group](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#aeac871ac215b64d45595e8461ec53b8a) `[get, protected set]` |
| MBReadOnlyList< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) > | [LinkedBarterables](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#afcd50f54eca59747087ef1b73ed7b9bf) `[get]` |
| [BarterSide](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a626e1ef68f8cca1d2548409b08516eac) | [Side](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ad99d79b438642ebcf42cb1bda7210b54) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a626e1ef68f8cca1d2548409b08516eac)BarterSide
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.BarterSide](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a626e1ef68f8cca1d2548409b08516eac) |

| Enumerator | |
| --- | --- |
| Left |  |
| Right |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727)Barterable()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.Barterable | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *originalOwner*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *originalParty* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a09774cd7f8ac04d572e7237aa6e11449)GetValueForFaction()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.GetValueForFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a778fe2a3dd3cd5dbb9bfed0d40462edd)CheckBarterLink()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.CheckBarterLink | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) | *linkedBarterable* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.BarterSystem.Barterables.ItemBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_item_barterable.html#a90f771b2280047e95aec97c333536393), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.JoinKingdomAsClanBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_join_kingdom_as_clan_barterable.html#a84e0a75303e4a65d48d3faaca4226ef3), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.LeaveKingdomAsClanBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_leave_kingdom_as_clan_barterable.html#a96b9d807b924a26d25cd075d8b15dab6), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#af4d9d18f17cf591d3d419b14611ebc44), and [TaleWorlds.CampaignSystem.BarterSystem.Barterables.MercenaryJoinKingdomBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_mercenary_join_kingdom_barterable.html#a25eaf1846019b3b03fb93e87c221d95f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a6f453dd249ea35fed818d58c144f0feb)GetUnitValueForFaction()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.GetUnitValueForFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ad89a63986957b0e3b6b3b1c60255f2f6)SetIsOffered()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.SetIsOffered | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ab2b5850e9b1bd47856de8f5022b1c3ab)AddBarterLink()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.AddBarterLink | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) | *barterable* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a657f35b1d729397fcd29f75cd1f14924)Initialize()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.Initialize | ( | [BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) | *barterGroup*, |
|  |  | bool | *isContextDependent* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a87b0fd2be077e7c2b73fd09fc554a0dd)IsCompatible()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.IsCompatible | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) | *barterable* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.BarterSystem.Barterables.JoinKingdomAsClanBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_join_kingdom_as_clan_barterable.html#a7967bb62186d9d27011576a95f8b9602), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.LeaveKingdomAsClanBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_leave_kingdom_as_clan_barterable.html#a52e682f8e2e0dacc9b53ea512a36114f), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#aca3cef8a740d515dc462c09528c41b6c), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#acf0bb3b1088100873562715a14c7f6e0), and [TaleWorlds.CampaignSystem.BarterSystem.Barterables.SafePassageBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_safe_passage_barterable.html#a62d2e5a6121b347a62518e4a103a933c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a33ac317dc0caf26eb81849c094480396)GetVisualIdentifier()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.GetVisualIdentifier | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#aea5609ce82fea3e19793b8d06abff5e8)GetEncyclopediaLink()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual string TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.GetEncyclopediaLink | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.BarterSystem.Barterables.FiefBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_fief_barterable.html#ab440512977859b098bb5e89f30671d94), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.GoldBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_gold_barterable.html#ae3866ac95c65aac7c1a22e9cfe00a834), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.ItemBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_item_barterable.html#ab911f5677e474aeaa50479ddf7dba92b), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.JoinKingdomAsClanBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_join_kingdom_as_clan_barterable.html#ae9afad496937956d1f8bf2c9397e32cc), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.LeaveKingdomAsClanBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_leave_kingdom_as_clan_barterable.html#ac4ee6b7f49dadcb4ca12493a93216d46), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a93b9a87eed168e511e5bf60fae38c5b4), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.MercenaryJoinKingdomBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_mercenary_join_kingdom_barterable.html#a9f226c219b3a5103111b8ae36ae1d42f), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#af5404c7bf30fa1b6ae3e2c1ed81215a7), [TaleWorlds.CampaignSystem.BarterSystem.Barterables.SetPrisonerFreeBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_set_prisoner_free_barterable.html#a973dd9b52a95ec0a72621deb1c338b3d), and [TaleWorlds.CampaignSystem.BarterSystem.Barterables.TransferPrisonerBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_transfer_prisoner_barterable.html#a4c363c648dbc8330ca38412ae4f49d90).

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ab006260c5693caf17ba35df796f30de4)Apply()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.Apply | ( |  | ) |  | | abstract |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a5a938140d7ad81d0f032506096954022)\_linkedBarterables
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727)> TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.\_linkedBarterables | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ac4962d9d2877eeb1a4c32610e0ca2b81)StringID
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.StringID | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a0dd9e775de0861661bcfe11dd371d6ec)OriginalOwner
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.OriginalOwner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a9cc1c17817ca3a7a9c2cf391ffcbb6e4)OriginalParty
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.OriginalParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#aeafbc06e473c51f2c3bb66df6d21db23)Name
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.Name | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a8843077652d336edf062f712635c3034)MaxAmount
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual int TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.MaxAmount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a8c862f503961cd2b01f127621ea8f974)CurrentAmount
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.CurrentAmount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#abd84c0c43b1ebbfbba7def0d366a8761)IsOffered
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.IsOffered | | getprotected set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a420748a42aa4b05881fa601b4d808ab4)IsContextDependent
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.IsContextDependent | | getprotected set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#aeac871ac215b64d45595e8461ec53b8a)Group
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.Group | | getprotected set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#afcd50f54eca59747087ef1b73ed7b9bf)LinkedBarterables
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727)> TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.LinkedBarterables | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ad99d79b438642ebcf42cb1bda7210b54)Side
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BarterSide](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a626e1ef68f8cca1d2548409b08516eac) TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable.Side | | get |


--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html ---

TaleWorlds.CampaignSystem.BarterSystem.Barterables.NoAttackBarterable Class ReferenceInherits [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NoAttackBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html#a892a34e803e215b0a47a96230d90317d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) originalOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) ownerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) otherParty, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) duration) |
| override void | [Apply](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html#acea0fa5c4d3cf60dfc806c1c08b04356) () |
| override int | [GetUnitValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html#ae228f042954a5974b18ea1f3a14bb607) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) | [GetVisualIdentifier](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html#af4934f73abb9d487798afb6e8bbad861) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | |
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
| Properties | |
| override string | [StringID](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html#a30913c589a22510a32ffe6dd9e8ddfd1) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? | [Name](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html#a2c14e554c501999db1d43f80865be2c0) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | |
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

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | |
| enum | [BarterSide](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a626e1ef68f8cca1d2548409b08516eac) {     [Left](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a626e1ef68f8cca1d2548409b08516eaca945d5e233cf7d6240f6b783b36a374ff) ,     [Right](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a626e1ef68f8cca1d2548409b08516eaca92b09c7c48c520c3c55e497875da437c)   } |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | |
|  | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) originalOwner, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) originalParty) |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | |
| MBList< [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) > | [\_linkedBarterables](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a5a938140d7ad81d0f032506096954022) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html#a892a34e803e215b0a47a96230d90317d)NoAttackBarterable()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.BarterSystem.Barterables.NoAttackBarterable.NoAttackBarterable | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *originalOwner*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherHero*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *ownerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *otherParty*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *duration* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html#acea0fa5c4d3cf60dfc806c1c08b04356)Apply()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.BarterSystem.Barterables.NoAttackBarterable.Apply | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html#ae228f042954a5974b18ea1f3a14bb607)GetUnitValueForFaction()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.BarterSystem.Barterables.NoAttackBarterable.GetUnitValueForFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html#af4934f73abb9d487798afb6e8bbad861)GetVisualIdentifier()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.NoAttackBarterable.GetVisualIdentifier | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html#a30913c589a22510a32ffe6dd9e8ddfd1)StringID
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.CampaignSystem.BarterSystem.Barterables.NoAttackBarterable.StringID | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_no_attack_barterable.html#a2c14e554c501999db1d43f80865be2c0)Name
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)??? TaleWorlds.CampaignSystem.BarterSystem.Barterables.NoAttackBarterable.Name | | get |


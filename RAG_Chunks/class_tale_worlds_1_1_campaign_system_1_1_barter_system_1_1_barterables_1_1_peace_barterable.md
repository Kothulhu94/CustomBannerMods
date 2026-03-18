--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html ---

TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable Class ReferenceInherits [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PeaceBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a6a2edd89e6d6f49056fe0f6f3616fb4c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) peaceOfferingFaction, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) offeredFaction, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) duration) |
|  | [PeaceBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#ace3cb286310a747ed0110f4af44c9045) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) peaceOfferingFaction, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) offeredFaction, [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) duration) |
| override int | [GetUnitValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a9e67887a4cd4021afbc2106c9519bf70) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionToEvaluateFor) |
| override bool | [IsCompatible](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#acf0bb3b1088100873562715a14c7f6e0) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) barterable) |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) | [GetVisualIdentifier](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#adc21417c624e7c908a1a8f22bdbadedd) () |
| override string | [GetEncyclopediaLink](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#af5404c7bf30fa1b6ae3e2c1ed81215a7) () |
| override void | [Apply](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a083b3254d3563127601d235540da6477) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | |
| int | [GetValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a09774cd7f8ac04d572e7237aa6e11449) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| virtual void | [CheckBarterLink](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a778fe2a3dd3cd5dbb9bfed0d40462edd) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) linkedBarterable) |
| int | [GetUnitValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a6f453dd249ea35fed818d58c144f0feb) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| void | [SetIsOffered](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ad89a63986957b0e3b6b3b1c60255f2f6) (bool value) |
| void | [AddBarterLink](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ab2b5850e9b1bd47856de8f5022b1c3ab) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) barterable) |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a657f35b1d729397fcd29f75cd1f14924) ([BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) barterGroup, bool isContextDependent) |
| [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) | [GetVisualIdentifier](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a33ac317dc0caf26eb81849c094480396) () |
| void | [Apply](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ab006260c5693caf17ba35df796f30de4) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [PeaceOfferingFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#ac2bf8824708caafc289681cf4567da08) |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [OfferedFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a79bc254aeb65fbe9d0354d3d6f8d4d7d) |

|  |  |
| --- | --- |
| Properties | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [Duration](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a3dd852754983b2d6e4a83f136b8e60a6) `[get]` |
| override string | [StringID](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a4485250bd42dbc2b19695dff40094448) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a660f7824fefb5a17e621c22d42c4534b) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a6a2edd89e6d6f49056fe0f6f3616fb4c)PeaceBarterable() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable.PeaceBarterable | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *peaceOfferingFaction*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *offeredFaction*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *duration* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#ace3cb286310a747ed0110f4af44c9045)PeaceBarterable() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable.PeaceBarterable | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *peaceOfferingFaction*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *offeredFaction*, |
|  |  | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | *duration* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a9e67887a4cd4021afbc2106c9519bf70)GetUnitValueForFaction()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable.GetUnitValueForFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionToEvaluateFor* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#acf0bb3b1088100873562715a14c7f6e0)IsCompatible()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable.IsCompatible | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) | *barterable* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a87b0fd2be077e7c2b73fd09fc554a0dd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#adc21417c624e7c908a1a8f22bdbadedd)GetVisualIdentifier()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable.GetVisualIdentifier | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#af5404c7bf30fa1b6ae3e2c1ed81215a7)GetEncyclopediaLink()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable.GetEncyclopediaLink | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#aea5609ce82fea3e19793b8d06abff5e8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a083b3254d3563127601d235540da6477)Apply()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable.Apply | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#ac2bf8824708caafc289681cf4567da08)PeaceOfferingFaction
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable.PeaceOfferingFaction |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a79bc254aeb65fbe9d0354d3d6f8d4d7d)OfferedFaction
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable.OfferedFaction |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a3dd852754983b2d6e4a83f136b8e60a6)Duration
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable.Duration | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a4485250bd42dbc2b19695dff40094448)StringID
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable.StringID | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_peace_barterable.html#a660f7824fefb5a17e621c22d42c4534b)Name
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.PeaceBarterable.Name | | get |


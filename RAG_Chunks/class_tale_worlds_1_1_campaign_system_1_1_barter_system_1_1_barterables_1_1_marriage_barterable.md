--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html ---

TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable Class ReferenceInherits [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MarriageBarterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a19102b811f359ca1296b29cc111f5291) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) ownerParty, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) heroBeingProposedTo, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) proposingHero) |
| override int | [GetUnitValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a3d1031224a28028887d865397c158aed) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| override void | [CheckBarterLink](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#af4d9d18f17cf591d3d419b14611ebc44) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) linkedBarterable) |
| override bool | [IsCompatible](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#aca3cef8a740d515dc462c09528c41b6c) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) barterable) |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) | [GetVisualIdentifier](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a8cf9634302d91ecc820981ead6ef498e) () |
| override string | [GetEncyclopediaLink](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a93b9a87eed168e511e5bf60fae38c5b4) () |
| override void | [Apply](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#ae0f06b12be7673fe9656a828a7f5a5d3) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) | |
| int | [GetValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a09774cd7f8ac04d572e7237aa6e11449) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| int | [GetUnitValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a6f453dd249ea35fed818d58c144f0feb) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| void | [SetIsOffered](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ad89a63986957b0e3b6b3b1c60255f2f6) (bool value) |
| void | [AddBarterLink](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ab2b5850e9b1bd47856de8f5022b1c3ab) ([Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) barterable) |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a657f35b1d729397fcd29f75cd1f14924) ([BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) barterGroup, bool isContextDependent) |
| [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) | [GetVisualIdentifier](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a33ac317dc0caf26eb81849c094480396) () |
| void | [Apply](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#ab006260c5693caf17ba35df796f30de4) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [ProposingHero](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#aeb2f0a3dc029e160e0d834e6100881eb) |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [HeroBeingProposedTo](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a63b4b5bad472c5c6da3c50aa5fc5405e) |

|  |  |
| --- | --- |
| Properties | |
| override string | [StringID](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a06ef370cdf4c3058486b4722d26faa45) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a938a5e63e14d1ef9230b871acb86d935) `[get]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a19102b811f359ca1296b29cc111f5291)MarriageBarterable()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable.MarriageBarterable | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *ownerParty*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *heroBeingProposedTo*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *proposingHero* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a3d1031224a28028887d865397c158aed)GetUnitValueForFaction()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable.GetUnitValueForFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#af4d9d18f17cf591d3d419b14611ebc44)CheckBarterLink()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable.CheckBarterLink | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) | *linkedBarterable* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a778fe2a3dd3cd5dbb9bfed0d40462edd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#aca3cef8a740d515dc462c09528c41b6c)IsCompatible()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable.IsCompatible | ( | [Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a02e99e5e002012169f26a8bb04c11727) | *barterable* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#a87b0fd2be077e7c2b73fd09fc554a0dd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a8cf9634302d91ecc820981ead6ef498e)GetVisualIdentifier()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable.GetVisualIdentifier | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a93b9a87eed168e511e5bf60fae38c5b4)GetEncyclopediaLink()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable.GetEncyclopediaLink | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html#aea5609ce82fea3e19793b8d06abff5e8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#ae0f06b12be7673fe9656a828a7f5a5d3)Apply()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable.Apply | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#aeb2f0a3dc029e160e0d834e6100881eb)ProposingHero
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable.ProposingHero |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a63b4b5bad472c5c6da3c50aa5fc5405e)HeroBeingProposedTo
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable.HeroBeingProposedTo |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a06ef370cdf4c3058486b4722d26faa45)StringID
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable.StringID | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_marriage_barterable.html#a938a5e63e14d1ef9230b871acb86d935)Name
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.BarterSystem.Barterables.MarriageBarterable.Name | | get |


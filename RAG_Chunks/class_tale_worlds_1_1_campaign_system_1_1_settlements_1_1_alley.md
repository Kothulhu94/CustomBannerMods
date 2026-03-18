--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html ---

TaleWorlds.CampaignSystem.Settlements.Alley Class ReferenceInherits [TaleWorlds.CampaignSystem.Settlements.SettlementArea](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_area.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) {     [Empty](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bcace2c8aed9c2fa0cfbed56cbda4d8bf07) ,     [OccupiedByGangLeader](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bca05f45e6d28aabc6ca7882f3bf4c2c68c) ,     [OccupiedByPlayer](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bca1bd9ce090cb2ef30d02a1ecb7e323e1a)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetOwner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a990c32f3011a9d069119ab7833352e5b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner) |
|  | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#afd5672e6eee0f7e948bce8755cd8cb84) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#ae1407965f244d3a8c3b28a01777c4541) settlement, string tag, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name) |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a8eb396d7c76c993e75e1c5568d0efd17) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#ae1407965f244d3a8c3b28a01777c4541) settlement, string tag, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name) |

|  |  |
| --- | --- |
| Properties | |
| override Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#ae1407965f244d3a8c3b28a01777c4541) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a4619766b5221da174fff5bbee9baf244) `[get]` |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#ae22ee561748d90098339bb9865dcb4a3) `[get]` |
| override string | [Tag](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a313d38ffe68d06f54d90ea9d9f245ed9) `[get]` |
| [AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) | [State](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a01f30fa4e2e408ab50c9e9bc7de8de5e) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.Settlements.SettlementArea](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_area.html) | |
| Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_area.html#a20522f89815749e32a48861cf7035851) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_area.html#ad3afecfb89c65fcabee12fa830cacebf) `[get]` |
| string | [Tag](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_area.html#a98a6af580d79904ee5d95c43049a94eb) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_area.html#a1f3a1031b19b8d693687e5048ac04aff) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc)AreaState
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Settlements.Alley.AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) |

| Enumerator | |
| --- | --- |
| Empty |  |
| OccupiedByGangLeader |  |
| OccupiedByPlayer |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#afd5672e6eee0f7e948bce8755cd8cb84)Alley()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Alley.Alley | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#ae1407965f244d3a8c3b28a01777c4541) | *settlement*, |
|  |  | string | *tag*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a990c32f3011a9d069119ab7833352e5b)SetOwner()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Alley.SetOwner | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a8eb396d7c76c993e75e1c5568d0efd17)Initialize()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Alley.Initialize | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#ae1407965f244d3a8c3b28a01777c4541) | *settlement*, |
|  |  | string | *tag*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#ae1407965f244d3a8c3b28a01777c4541)Settlement
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override Settlement TaleWorlds.CampaignSystem.Settlements.Alley.Settlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a4619766b5221da174fff5bbee9baf244)Name
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Alley.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#ae22ee561748d90098339bb9865dcb4a3)Owner
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Settlements.Alley.Owner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a313d38ffe68d06f54d90ea9d9f245ed9)Tag
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.CampaignSystem.Settlements.Alley.Tag | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a01f30fa4e2e408ab50c9e9bc7de8de5e)State
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) TaleWorlds.CampaignSystem.Settlements.Alley.State | | get |


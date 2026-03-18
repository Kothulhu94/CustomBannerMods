--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html ---

TaleWorlds.CampaignSystem.Settlements.Buildings.Building Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a9e1c90848f7d4b4d7490b0f87836aebf) ([BuildingType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a8ddd507d62c697edc3648a4369257e3a) buildingType, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a270edc5733386f00c42dbb2f0cc1fa00) town, float buildingProgress=0.0f, int currentLevel=0) |
| override int | [GetHashCode](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a5a9794bfaf47452a3e1eaa32e1e35ff2) () |
| int | [GetConstructionCost](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a6d7638faddda8c9702e25bc5705b787e) () |
| void | [LevelUp](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a42bf0deb4fa1d4dad94200cb38081fc4) () |
| void | [LevelDown](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#af068bffc8b1ccdaf2f1e44d4b0788cb6) () |
| void | [HitPointChanged](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a95dbc32e06323b184ec70a12105b94f7) (float change) |
| void | [AddEffectOfBuilding](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a36c35d33791bb6a2a93628bc7f66cb61) ([BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7) buildingEffect, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) result) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetBonusExplanation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a35a73c408fac0da102f1f7889d9b3592) () |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [BuildingProgress](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#af949115111305b9f6181bd42a2e42750) |
| bool | [IsCurrentlyDefault](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#ae51da1da16c85e6c67e4496d4236a6b7) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [MaxHitpoints](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#afd5c5fb442290c1b9d64a1483a0eda13) = 100 |

|  |  |
| --- | --- |
| Properties | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#aca8f1162f52c5491f41b799ef4bbd46a) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Explanation](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#ad9c5bf0a21e2696f98da4108459584b3) `[get]` |
| BuildingType | [BuildingType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a8ddd507d62c697edc3648a4369257e3a) `[get]` |
| Town | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a270edc5733386f00c42dbb2f0cc1fa00) `[get]` |
| int | [CurrentLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a1b015e16a22982960fed5584ec39b506) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a9e1c90848f7d4b4d7490b0f87836aebf)Building()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Buildings.Building.Building | ( | [BuildingType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a8ddd507d62c697edc3648a4369257e3a) | *buildingType*, |
|  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a270edc5733386f00c42dbb2f0cc1fa00) | *town*, |
|  |  | float | *buildingProgress* = 0::0f, |
|  |  | int | *currentLevel* = 0 ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a5a9794bfaf47452a3e1eaa32e1e35ff2)GetHashCode()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.Settlements.Buildings.Building.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a6d7638faddda8c9702e25bc5705b787e)GetConstructionCost()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Settlements.Buildings.Building.GetConstructionCost | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a42bf0deb4fa1d4dad94200cb38081fc4)LevelUp()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Buildings.Building.LevelUp | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#af068bffc8b1ccdaf2f1e44d4b0788cb6)LevelDown()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Buildings.Building.LevelDown | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a95dbc32e06323b184ec70a12105b94f7)HitPointChanged()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Buildings.Building.HitPointChanged | ( | float | *change* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a36c35d33791bb6a2a93628bc7f66cb61)AddEffectOfBuilding()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Buildings.Building.AddEffectOfBuilding | ( | [BuildingEffectEnum](namespace_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings.html#a7f02dad2387baa3164a3eba973b863f7) | *buildingEffect*, |
|  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *result* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a35a73c408fac0da102f1f7889d9b3592)GetBonusExplanation()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Buildings.Building.GetBonusExplanation | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#af949115111305b9f6181bd42a2e42750)BuildingProgress
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.Settlements.Buildings.Building.BuildingProgress |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#afd5c5fb442290c1b9d64a1483a0eda13)MaxHitpoints
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.Settlements.Buildings.Building.MaxHitpoints = 100 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#ae51da1da16c85e6c67e4496d4236a6b7)IsCurrentlyDefault
----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Settlements.Buildings.Building.IsCurrentlyDefault |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#aca8f1162f52c5491f41b799ef4bbd46a)Name
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Buildings.Building.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#ad9c5bf0a21e2696f98da4108459584b3)Explanation
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Buildings.Building.Explanation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a8ddd507d62c697edc3648a4369257e3a)BuildingType
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | BuildingType TaleWorlds.CampaignSystem.Settlements.Buildings.Building.BuildingType | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a270edc5733386f00c42dbb2f0cc1fa00)Town
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Town TaleWorlds.CampaignSystem.Settlements.Buildings.Building.Town | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html#a1b015e16a22982960fed5584ec39b506)CurrentLevel
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Buildings.Building.CurrentLevel | | getset |


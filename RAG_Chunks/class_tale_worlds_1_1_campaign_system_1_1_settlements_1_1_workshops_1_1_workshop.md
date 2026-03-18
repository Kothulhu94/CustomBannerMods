--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html ---

TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop Class ReferenceInherits [TaleWorlds.CampaignSystem.Settlements.SettlementArea](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_area.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a7c2304fea08a91438359e9ffddd81072) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a2b4305cce82f2339ee5e96b03b02f705) settlement, string tag) |
| override int | [GetHashCode](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#af0d0018cb24403da5b1f123a917401e0) () |
| void | [InitializeWorkshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#accfa7f4c8fca597c29a08642385b2423) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a0897464483eb9138561c1fec76bdeaa9) type) |
| void | [ChangeOwnerOfWorkshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a6e68b5033425642576361fe84128e9e5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a0897464483eb9138561c1fec76bdeaa9) type, int capital) |
| void | [ChangeWorkshopProduction](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a2225fca452e35ff7b385c58055b69bb6) ([WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a0897464483eb9138561c1fec76bdeaa9) newWorkshopType) |
| void | [SetCustomName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#ac1a797be5c9e8609b803f67c5be64a7b) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) customName) |
| void | [UpdateLastRunTime](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a1ee3bb2fa9b0e602bf732aaabfe30b49) () |
| void | [SetProgress](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a437e019120ae5841aef605e757e8b3e8) (int i, float value) |
| void | [ChangeGold](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#aa1975a544567ea83a4e57b22c0be4171) (int goldChange) |
| float | [GetProductionProgress](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#ae7aee104b8a33fef3961fcdd71359d8d) (int index) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a59bd1d09938b5ec9fd26bb494121ffb7) () |

|  |  |
| --- | --- |
| Properties | |
| override Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a2b4305cce82f2339ee5e96b03b02f705) `[get]` |
| override string | [Tag](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a8ba29c1e53dbd3c5e05a1f3910de5653) `[get]` |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#ae5331c35e3c8a3b82abd946d0fcbfcfb) `[get]` |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#af03cc550c88d31f261b4f92149afbb04) `[get]` |
| WorkshopType | [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a0897464483eb9138561c1fec76bdeaa9) `[get]` |
| int | [ProfitMade](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#aaa3b4412b56c0c61db76bb3e1fe1252d) `[get]` |
| int | [Expense](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a3be4e96cad257c009b0c0611f8c97e58) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [LastRunCampaignTime](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a06303feb175f58fea46fde110a7d693b) `[get]` |
| int | [Capital](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a49f3a821586aa3f1fb6ee268762f96ba) `[get]` |
| int | [InitialCapital](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a15de994ad1f83b187781e91f092cc9a6) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.Settlements.SettlementArea](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_area.html) | |
| Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_area.html#a20522f89815749e32a48861cf7035851) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_area.html#ad3afecfb89c65fcabee12fa830cacebf) `[get]` |
| string | [Tag](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_area.html#a98a6af580d79904ee5d95c43049a94eb) `[get]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_area.html#a1f3a1031b19b8d693687e5048ac04aff) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a7c2304fea08a91438359e9ffddd81072)Workshop()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.Workshop | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a2b4305cce82f2339ee5e96b03b02f705) | *settlement*, |
|  |  | string | *tag* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#af0d0018cb24403da5b1f123a917401e0)GetHashCode()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#accfa7f4c8fca597c29a08642385b2423)InitializeWorkshop()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.InitializeWorkshop | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, |
|  |  | [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a0897464483eb9138561c1fec76bdeaa9) | *type* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a6e68b5033425642576361fe84128e9e5)ChangeOwnerOfWorkshop()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.ChangeOwnerOfWorkshop | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, |
|  |  | [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a0897464483eb9138561c1fec76bdeaa9) | *type*, |
|  |  | int | *capital* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a2225fca452e35ff7b385c58055b69bb6)ChangeWorkshopProduction()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.ChangeWorkshopProduction | ( | [WorkshopType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a0897464483eb9138561c1fec76bdeaa9) | *newWorkshopType* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#ac1a797be5c9e8609b803f67c5be64a7b)SetCustomName()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.SetCustomName | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *customName* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a1ee3bb2fa9b0e602bf732aaabfe30b49)UpdateLastRunTime()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.UpdateLastRunTime | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a437e019120ae5841aef605e757e8b3e8)SetProgress()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.SetProgress | ( | int | *i*, |
|  |  | float | *value* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#aa1975a544567ea83a4e57b22c0be4171)ChangeGold()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.ChangeGold | ( | int | *goldChange* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#ae7aee104b8a33fef3961fcdd71359d8d)GetProductionProgress()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.GetProductionProgress | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a59bd1d09938b5ec9fd26bb494121ffb7)ToString()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.ToString | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a2b4305cce82f2339ee5e96b03b02f705)Settlement
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override Settlement TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.Settlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a8ba29c1e53dbd3c5e05a1f3910de5653)Tag
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override string TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.Tag | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#ae5331c35e3c8a3b82abd946d0fcbfcfb)Owner
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.Owner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#af03cc550c88d31f261b4f92149afbb04)Name
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a0897464483eb9138561c1fec76bdeaa9)WorkshopType
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | WorkshopType TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.WorkshopType | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#aaa3b4412b56c0c61db76bb3e1fe1252d)ProfitMade
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.ProfitMade | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a3be4e96cad257c009b0c0611f8c97e58)Expense
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.Expense | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a06303feb175f58fea46fde110a7d693b)LastRunCampaignTime
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.LastRunCampaignTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a49f3a821586aa3f1fb6ee268762f96ba)Capital
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.Capital | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html#a15de994ad1f83b187781e91f092cc9a6)InitialCapital
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Workshops.Workshop.InitialCapital | | get |


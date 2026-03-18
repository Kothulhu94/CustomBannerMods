--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html ---

TaleWorlds.CampaignSystem.Settlements.SettlementComponent Class ReferenceabstractInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

Inherited by [StoryMode.TrainingField](class_story_mode_1_1_training_field.html), [TaleWorlds.CampaignSystem.Settlements.Fief](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_fief.html), [TaleWorlds.CampaignSystem.Settlements.Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html), [TaleWorlds.CampaignSystem.Settlements.RetirementSettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_retirement_settlement_component.html), and [TaleWorlds.CampaignSystem.Settlements.Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [ProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7b) {     [Low](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7ba28d0edd045e05cf5af64e35ae0c4c6ef) ,     [Mid](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7ba55c6b09cbca39ef0cdb728eb112a5049) ,     [High](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7ba655d20c1ca69519ca647684edbb2db35) ,     [NumberOfLevels](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7baed0c129a39c54d57454d41af37becc40)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual [ProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7b) | [GetProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae17bedb053031eada832711471355c55) () |
| virtual [Banner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a19ddd822f9886170d976fc7710e30808) | [GetDefaultComponentBanner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a5c6eaac236fefeb5fa9d53b2bbb79807) () |
| virtual void | [OnPartyEntered](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a66828262ea64df8e73e7535dc785b436) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnPartyLeft](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a5441174fb66ec365807bde68a3d20c55) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnInit](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a730c0c635a6fef21752439eccd5b219f) () |
| virtual void | [OnSessionStart](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a8ae1cd2fa6596915ebae54770ac53100) () |
| void | [ChangeGold](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a7d3a0c0342730ed899e6b2fbbeb3a2f5) (int changeAmount) |
| int | [GetNumberOfTroops](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#af1ecbfef4b80916a688e8cd1aaae1476) () |
| override void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a7600ea03f492648851ba09a3d0338fc4) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| virtual int | [GetItemPrice](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#abe6b3d07ce4395232564403f71d3c648) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) tradingParty=null, bool isSelling=false) |
| virtual int | [GetItemPrice](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#afd251ebd474f348160cd04487ac8719c) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) itemRosterElement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) tradingParty=null, bool isSelling=false) |
| virtual void | [OnRelatedPartyRemoved](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a0f59e449ec0b48c740b36c7542e3d9a9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| List< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [GetPrisonerHeroes](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ab0a2a9a2eb647064853ee4e1556276c4) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual void | [OnInventoryUpdated](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad24ee0fc19f2808a49ab35bfe2d42b57) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) item, int count) |
|  | [SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a11fbeb0e8248fdfd63c62ba31104962f) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

|  |  |
| --- | --- |
| Properties | |
| int | [Gold](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#aa974492ebf10d1b34aaf0cc558994edb) `[get]` |
| float | [BackgroundCropPosition](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad3b80b27f7a0f9ee5ec05909928ecdb7) `[get, protected set]` |
| string | [BackgroundMeshName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a02260204c134e5b5a071f78b1f98f0cb) `[get, protected set]` |
| string | [WaitMeshName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad2330ad8b724bf54ed086c9db8a7fd3b) `[get, protected set]` |
| string | [CastleBackgroundMeshName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ab65efca0f050522b4f38a88c691c54ba) `[get, protected set]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a518303d4d6a6378d597df3db688fb41d) `[get]` |
| Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a0bfa0435170396579fed99c5eb2abff2) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a19ddd822f9886170d976fc7710e30808) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a2aabf9a4f16d98d1048637d5cbb4e56a) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a2e896c5eb08141ad2d6b9490243f7b74) `[get]` |
| bool | [IsOwnerUnassigned](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a4e387d93fb228e73dd7200e919c6c9ee) `[get, set]` |
| virtual bool | [IsTown](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#af081aba39edd74a5396ab2fd9ca9c379) `[get]` |
| virtual bool | [IsCastle](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad06143543c44cae86573f5fd25dc29cd) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7b)ProsperityLevel
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Settlements.SettlementComponent.ProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7b) |

| Enumerator | |
| --- | --- |
| Low |  |
| Mid |  |
| High |  |
| NumberOfLevels |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a11fbeb0e8248fdfd63c62ba31104962f)SettlementComponent()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.Settlements.SettlementComponent.SettlementComponent | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae17bedb053031eada832711471355c55)GetProsperityLevel()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [ProsperityLevel](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ae30632ba32887c9c0ab8dab569115a7b) TaleWorlds.CampaignSystem.Settlements.SettlementComponent.GetProsperityLevel | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Settlements.Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aa24ad6a3fa9cb54ae3c894da16db8c93), and [TaleWorlds.CampaignSystem.Settlements.Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#afe6ab43610f47871f344e402a423f583).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a5c6eaac236fefeb5fa9d53b2bbb79807)GetDefaultComponentBanner()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [Banner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a19ddd822f9886170d976fc7710e30808) TaleWorlds.CampaignSystem.Settlements.SettlementComponent.GetDefaultComponentBanner | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad24ee0fc19f2808a49ab35bfe2d42b57)OnInventoryUpdated()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Settlements.SettlementComponent.OnInventoryUpdated | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *item*, | |  |  | int | *count* ) | | protectedvirtual |

Reimplemented in [TaleWorlds.CampaignSystem.Settlements.Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#aa8029eb07b4e81e8ff2df34ed284d14f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a66828262ea64df8e73e7535dc785b436)OnPartyEntered()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Settlements.SettlementComponent.OnPartyEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Settlements.Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html#a108d3c275c4f8e69075a32cc3ce8847e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a5441174fb66ec365807bde68a3d20c55)OnPartyLeft()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Settlements.SettlementComponent.OnPartyLeft | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Settlements.Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html#a2e8ec047f2b90b51296b04a69af5c7ec).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a730c0c635a6fef21752439eccd5b219f)OnInit()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Settlements.SettlementComponent.OnInit | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Settlements.Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html#aa74bf7c58bb67c340826c4f9ac46deef), [TaleWorlds.CampaignSystem.Settlements.Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ac9b86f3bc425b386f547a1833e92681e), and [TaleWorlds.CampaignSystem.Settlements.Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a533a97db06948dc5077aabadec534e1e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a8ae1cd2fa6596915ebae54770ac53100)OnSessionStart()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Settlements.SettlementComponent.OnSessionStart | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Settlements.Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#ac434fd42e40ee754003b8a9940dbb3b0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a7d3a0c0342730ed899e6b2fbbeb3a2f5)ChangeGold()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.SettlementComponent.ChangeGold | ( | int | *changeAmount* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#af1ecbfef4b80916a688e8cd1aaae1476)GetNumberOfTroops()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Settlements.SettlementComponent.GetNumberOfTroops | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a7600ea03f492648851ba09a3d0338fc4)Deserialize()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.SettlementComponent.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

Reimplemented in [StoryMode.TrainingField](class_story_mode_1_1_training_field.html#a325424e30121bd232f0fb3f94c6a648b), [TaleWorlds.CampaignSystem.Settlements.Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a4f22d83112673df4c4846648e23eda35), and [TaleWorlds.CampaignSystem.Settlements.Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a1b3ecd9b3135fb5999e061d34782bcb1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#abe6b3d07ce4395232564403f71d3c648)GetItemPrice() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual int TaleWorlds.CampaignSystem.Settlements.SettlementComponent.GetItemPrice | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *tradingParty* = null, | |  |  | bool | *isSelling* = false ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Settlements.Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a37fc1b631438a3981998c98547f753ff), and [TaleWorlds.CampaignSystem.Settlements.Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a0e7ce7e21d83dbd2b081ca871f9fe62d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#afd251ebd474f348160cd04487ac8719c)GetItemPrice() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual int TaleWorlds.CampaignSystem.Settlements.SettlementComponent.GetItemPrice | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *itemRosterElement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *tradingParty* = null, | |  |  | bool | *isSelling* = false ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Settlements.Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html#a882bd7f2cd84d67afbe70fb33a7fe18d), and [TaleWorlds.CampaignSystem.Settlements.Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#a20a59806ca3a21147e7567ec9c9ae583).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a0f59e449ec0b48c740b36c7542e3d9a9)OnRelatedPartyRemoved()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.Settlements.SettlementComponent.OnRelatedPartyRemoved | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Settlements.Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html#a5d4e34e985698df9314ceba0ae4695ed).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ab0a2a9a2eb647064853ee4e1556276c4)GetPrisonerHeroes()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > TaleWorlds.CampaignSystem.Settlements.SettlementComponent.GetPrisonerHeroes | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#aa974492ebf10d1b34aaf0cc558994edb)Gold
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.SettlementComponent.Gold | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad3b80b27f7a0f9ee5ec05909928ecdb7)BackgroundCropPosition
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.SettlementComponent.BackgroundCropPosition | | getprotected set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a02260204c134e5b5a071f78b1f98f0cb)BackgroundMeshName
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.SettlementComponent.BackgroundMeshName | | getprotected set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad2330ad8b724bf54ed086c9db8a7fd3b)WaitMeshName
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.SettlementComponent.WaitMeshName | | getprotected set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ab65efca0f050522b4f38a88c691c54ba)CastleBackgroundMeshName
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.SettlementComponent.CastleBackgroundMeshName | | getprotected set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a518303d4d6a6378d597df3db688fb41d)Owner
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Settlements.SettlementComponent.Owner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a0bfa0435170396579fed99c5eb2abff2)Settlement
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Settlement TaleWorlds.CampaignSystem.Settlements.SettlementComponent.Settlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a19ddd822f9886170d976fc7710e30808)Banner
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.CampaignSystem.Settlements.SettlementComponent.Banner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a2aabf9a4f16d98d1048637d5cbb4e56a)MapFaction
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Settlements.SettlementComponent.MapFaction | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a2e896c5eb08141ad2d6b9490243f7b74)Name
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.SettlementComponent.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#a4e387d93fb228e73dd7200e919c6c9ee)IsOwnerUnassigned
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.SettlementComponent.IsOwnerUnassigned | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#af081aba39edd74a5396ab2fd9ca9c379)IsTown
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.CampaignSystem.Settlements.SettlementComponent.IsTown | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html#ad06143543c44cae86573f5fd25dc29cd)IsCastle
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.CampaignSystem.Settlements.SettlementComponent.IsCastle | | get |


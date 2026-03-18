--- SOURCE: class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html ---

SandBox.View.Map.Navigation.MapNavigationElementBase Class ReferenceabstractInherits [TaleWorlds.CampaignSystem.INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html).

Inherited by [SandBox.View.Map.Navigation.NavigationElements.CharacterDeveloperNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_character_developer_navigation_element.html), [SandBox.View.Map.Navigation.NavigationElements.ClanNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_clan_navigation_element.html), [SandBox.View.Map.Navigation.NavigationElements.EscapeMenuNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_escape_menu_navigation_element.html), [SandBox.View.Map.Navigation.NavigationElements.InventoryNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_inventory_navigation_element.html), [SandBox.View.Map.Navigation.NavigationElements.KingdomNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_kingdom_navigation_element.html), [SandBox.View.Map.Navigation.NavigationElements.PartyNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_party_navigation_element.html), and [SandBox.View.Map.Navigation.NavigationElements.QuestsNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_quests_navigation_element.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OpenView](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#afd0e95d63832d86b3cd43909993c5507) () |
| void | [OpenView](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a7034f67223edaeb9dcac8d74349a1dee) (params object[] parameters) |
| void | [GoToLink](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#ab1034f05e518fff212ef1efc6f8f80e8) () |
|  | [MapNavigationElementBase](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a55dd2e0f640f5d4467a6a7727dc97fab) ([MapNavigationHandler](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html) handler) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| [NavigationPermissionItem](struct_tale_worlds_1_1_campaign_system_1_1_navigation_permission_item.html) | [GetPermission](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a1234ebeef141af122c88c4beb4765b5a) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetTooltip](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a7494b07bfda0d83c79f5814c5e643015) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetAlertTooltip](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#af9b657ea534aba912effa88a932fdaf1) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly [MapNavigationHandler](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html) | [\_handler](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a7cd038cda77ca8521b7cad46de5b3c7d) |
| readonly [IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html) | [\_viewDataTracker](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a2bdc5024b10e216b9cf74dd8c0d4c45f) |

|  |  |
| --- | --- |
| Properties | |
| [NavigationPermissionItem](struct_tale_worlds_1_1_campaign_system_1_1_navigation_permission_item.html) | [Permission](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#afc9b2bb57ce26ac548939b43cefcbec9) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Tooltip](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a972993f3269ce6b01bab74738d2410c5) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AlertTooltip](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#aa18a07f3669413857b6aeeba75f16bc1) `[get]` |
| bool | [IsActive](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#ad5c30249e044e33bca416a9b42d3360b) `[get]` |
| bool | [IsLockingNavigation](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a282d636c8bae24c56e50893381000f8c) `[get]` |
| bool | [HasAlert](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a5e94f803cf1e388faba75d47f1c1d47e) `[get]` |
| string | [StringId](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a0b301e7a3f7a5386ba4d7e67b6301759) `[get]` |
| [Game](class_tale_worlds_1_1_core_1_1_game.html) | [\_game](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a7c08c1bd58d7229b8aac0fe9a6a0765c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a55dd2e0f640f5d4467a6a7727dc97fab)MapNavigationElementBase()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.View.Map.Navigation.MapNavigationElementBase.MapNavigationElementBase | ( | [MapNavigationHandler](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html) | *handler* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#afd0e95d63832d86b3cd43909993c5507)OpenView() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.View.Map.Navigation.MapNavigationElementBase.OpenView | ( |  | ) |  | | abstract |

Implements [TaleWorlds.CampaignSystem.INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a3fc7e230b49ad68c686e27cee355c210).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a7034f67223edaeb9dcac8d74349a1dee)OpenView() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.View.Map.Navigation.MapNavigationElementBase.OpenView | ( | params object[] | *parameters* | ) |  | | abstract |

Implements [TaleWorlds.CampaignSystem.INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#ae0ecfd2064cd61c236c1f28d32a07be5).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#ab1034f05e518fff212ef1efc6f8f80e8)GoToLink()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.View.Map.Navigation.MapNavigationElementBase.GoToLink | ( |  | ) |  | | abstract |

Implements [TaleWorlds.CampaignSystem.INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a7b0a3db8bacf60826258d1f2234a21c2).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a1234ebeef141af122c88c4beb4765b5a)GetPermission()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [NavigationPermissionItem](struct_tale_worlds_1_1_campaign_system_1_1_navigation_permission_item.html) SandBox.View.Map.Navigation.MapNavigationElementBase.GetPermission | ( |  | ) |  | | abstractprotected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a7494b07bfda0d83c79f5814c5e643015)GetTooltip()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.View.Map.Navigation.MapNavigationElementBase.GetTooltip | ( |  | ) |  | | abstractprotected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#af9b657ea534aba912effa88a932fdaf1)GetAlertTooltip()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.View.Map.Navigation.MapNavigationElementBase.GetAlertTooltip | ( |  | ) |  | | abstractprotected |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a7cd038cda77ca8521b7cad46de5b3c7d)\_handler
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [MapNavigationHandler](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_handler.html) SandBox.View.Map.Navigation.MapNavigationElementBase.\_handler | | protected |

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a2bdc5024b10e216b9cf74dd8c0d4c45f)\_viewDataTracker
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html) SandBox.View.Map.Navigation.MapNavigationElementBase.\_viewDataTracker | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#afc9b2bb57ce26ac548939b43cefcbec9)Permission
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [NavigationPermissionItem](struct_tale_worlds_1_1_campaign_system_1_1_navigation_permission_item.html) SandBox.View.Map.Navigation.MapNavigationElementBase.Permission | | get |

Implements [TaleWorlds.CampaignSystem.INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a80612f0d6bd1e78f2c44208fd5ef5b2d).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a972993f3269ce6b01bab74738d2410c5)Tooltip
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.View.Map.Navigation.MapNavigationElementBase.Tooltip | | get |

Implements [TaleWorlds.CampaignSystem.INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a04d1e5156c387e58ced29ebf79ec008b).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#aa18a07f3669413857b6aeeba75f16bc1)AlertTooltip
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) SandBox.View.Map.Navigation.MapNavigationElementBase.AlertTooltip | | get |

Implements [TaleWorlds.CampaignSystem.INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a77f5f5b4dd7dfac3b9f749698356e4d0).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#ad5c30249e044e33bca416a9b42d3360b)IsActive
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.Navigation.MapNavigationElementBase.IsActive | | getabstract |

Implements [TaleWorlds.CampaignSystem.INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a8895b957484a7aa8c41d0c5473a1e77a).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a282d636c8bae24c56e50893381000f8c)IsLockingNavigation
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.Navigation.MapNavigationElementBase.IsLockingNavigation | | getabstract |

Implements [TaleWorlds.CampaignSystem.INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a2d42712f5db91a10af2be5741d1db0e5).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a5e94f803cf1e388faba75d47f1c1d47e)HasAlert
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.View.Map.Navigation.MapNavigationElementBase.HasAlert | | getabstract |

Implements [TaleWorlds.CampaignSystem.INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a6d6cafec12776d0031297f63c454f4c8).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a0b301e7a3f7a5386ba4d7e67b6301759)StringId
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.View.Map.Navigation.MapNavigationElementBase.StringId | | getabstract |

Implements [TaleWorlds.CampaignSystem.INavigationElement](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a2c796e4537887f182b1c1cf29129a728).

[◆](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a7c08c1bd58d7229b8aac0fe9a6a0765c)\_game
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Game](class_tale_worlds_1_1_core_1_1_game.html) SandBox.View.Map.Navigation.MapNavigationElementBase.\_game | | getprotected |


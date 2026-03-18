--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html ---

TaleWorlds.CampaignSystem.INavigationElement Interface ReferenceInherited by [SandBox.View.Map.Navigation.MapNavigationElementBase](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OpenView](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a3fc7e230b49ad68c686e27cee355c210) () |
| void | [OpenView](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#ae0ecfd2064cd61c236c1f28d32a07be5) (params object[] parameters) |
| void | [GoToLink](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a7b0a3db8bacf60826258d1f2234a21c2) () |

|  |  |
| --- | --- |
| Properties | |
| string | [StringId](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a2c796e4537887f182b1c1cf29129a728) `[get]` |
| [NavigationPermissionItem](struct_tale_worlds_1_1_campaign_system_1_1_navigation_permission_item.html) | [Permission](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a80612f0d6bd1e78f2c44208fd5ef5b2d) `[get]` |
| bool | [IsLockingNavigation](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a2d42712f5db91a10af2be5741d1db0e5) `[get]` |
| bool | [IsActive](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a8895b957484a7aa8c41d0c5473a1e77a) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Tooltip](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a04d1e5156c387e58ced29ebf79ec008b) `[get]` |
| bool | [HasAlert](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a6d6cafec12776d0031297f63c454f4c8) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [AlertTooltip](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a77f5f5b4dd7dfac3b9f749698356e4d0) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a3fc7e230b49ad68c686e27cee355c210)OpenView() [1/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.INavigationElement.OpenView | ( |  | ) |  |

Implemented in [SandBox.View.Map.Navigation.MapNavigationElementBase](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#afd0e95d63832d86b3cd43909993c5507), [SandBox.View.Map.Navigation.NavigationElements.CharacterDeveloperNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_character_developer_navigation_element.html#a2f5f3cae40072b8059f0dd07869000e7), [SandBox.View.Map.Navigation.NavigationElements.ClanNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_clan_navigation_element.html#a7a106daa766afec4ab312f9dee78e32c), [SandBox.View.Map.Navigation.NavigationElements.EscapeMenuNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_escape_menu_navigation_element.html#a4405af50ef7287eec9ebf2dfd16ed9ab), [SandBox.View.Map.Navigation.NavigationElements.InventoryNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_inventory_navigation_element.html#adf440ebc11ba308565d0f27f1c2de821), [SandBox.View.Map.Navigation.NavigationElements.KingdomNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_kingdom_navigation_element.html#ae03db0b7b9b6cb00601deb4ca10463c7), [SandBox.View.Map.Navigation.NavigationElements.PartyNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_party_navigation_element.html#a8a2544fc876fea743a588891fa7c41fe), and [SandBox.View.Map.Navigation.NavigationElements.QuestsNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_quests_navigation_element.html#a462a75a33ff699b18f9872b72360527d).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#ae0ecfd2064cd61c236c1f28d32a07be5)OpenView() [2/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.INavigationElement.OpenView | ( | params object[] | *parameters* | ) |  |

Implemented in [SandBox.View.Map.Navigation.MapNavigationElementBase](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a7034f67223edaeb9dcac8d74349a1dee), [SandBox.View.Map.Navigation.NavigationElements.CharacterDeveloperNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_character_developer_navigation_element.html#af3feaa678e6853196c52236fde5290d8), [SandBox.View.Map.Navigation.NavigationElements.ClanNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_clan_navigation_element.html#a74a320f511c0769a41b47b9ccc74dcd1), [SandBox.View.Map.Navigation.NavigationElements.EscapeMenuNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_escape_menu_navigation_element.html#a901e965adc7fbf4c7400e8acce43c924), [SandBox.View.Map.Navigation.NavigationElements.InventoryNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_inventory_navigation_element.html#a25a512a3fbe9004d2ae5b86bdd04bae9), [SandBox.View.Map.Navigation.NavigationElements.KingdomNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_kingdom_navigation_element.html#acb1604374c00e7ef93edbe17464a0109), [SandBox.View.Map.Navigation.NavigationElements.PartyNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_party_navigation_element.html#aa48d3dadbce5d122f2189beb33fc7a7b), and [SandBox.View.Map.Navigation.NavigationElements.QuestsNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_quests_navigation_element.html#a2faed4deaf16018af99376a908f33c7f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a7b0a3db8bacf60826258d1f2234a21c2)GoToLink()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.INavigationElement.GoToLink | ( |  | ) |  |

Implemented in [SandBox.View.Map.Navigation.MapNavigationElementBase](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#ab1034f05e518fff212ef1efc6f8f80e8), [SandBox.View.Map.Navigation.NavigationElements.CharacterDeveloperNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_character_developer_navigation_element.html#a473e75a29b323a1dcfca21db6874662e), [SandBox.View.Map.Navigation.NavigationElements.ClanNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_clan_navigation_element.html#ad8bc08a4f10d9f9ac570636b20e38907), [SandBox.View.Map.Navigation.NavigationElements.EscapeMenuNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_escape_menu_navigation_element.html#a491f07e0cd24070745c7578f3834de9d), [SandBox.View.Map.Navigation.NavigationElements.InventoryNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_inventory_navigation_element.html#a4e6e381b43d02b9097ee770b60f79ca8), [SandBox.View.Map.Navigation.NavigationElements.KingdomNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_kingdom_navigation_element.html#a0cc30ea9af4acbd0bc35f7d35fc7c261), [SandBox.View.Map.Navigation.NavigationElements.PartyNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_party_navigation_element.html#a3e3c69ef0980d78d6f07ae4735571474), and [SandBox.View.Map.Navigation.NavigationElements.QuestsNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_quests_navigation_element.html#a092266d9b647d67b0d41e15375cac448).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a2c796e4537887f182b1c1cf29129a728)StringId
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.INavigationElement.StringId | | get |

Implemented in [SandBox.View.Map.Navigation.MapNavigationElementBase](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a0b301e7a3f7a5386ba4d7e67b6301759), [SandBox.View.Map.Navigation.NavigationElements.CharacterDeveloperNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_character_developer_navigation_element.html#a178a21405b55f073643c92bc328e0c1e), [SandBox.View.Map.Navigation.NavigationElements.ClanNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_clan_navigation_element.html#a4a4e4901939857849b581a2ac7b29dd7), [SandBox.View.Map.Navigation.NavigationElements.EscapeMenuNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_escape_menu_navigation_element.html#a93a2d77a2f2d44872b07dea69350551f), [SandBox.View.Map.Navigation.NavigationElements.InventoryNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_inventory_navigation_element.html#a0f7dd71ef98d6542ee6c74ccd15f1fb7), [SandBox.View.Map.Navigation.NavigationElements.KingdomNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_kingdom_navigation_element.html#a86ec37450072bb44eeb8a1dd0f06f2a7), [SandBox.View.Map.Navigation.NavigationElements.PartyNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_party_navigation_element.html#ae0852bb0617d7ba4acbaa4a4c2902ed1), and [SandBox.View.Map.Navigation.NavigationElements.QuestsNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_quests_navigation_element.html#a3034d47fee9e6a2126c83a0dc9f29b27).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a80612f0d6bd1e78f2c44208fd5ef5b2d)Permission
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [NavigationPermissionItem](struct_tale_worlds_1_1_campaign_system_1_1_navigation_permission_item.html) TaleWorlds.CampaignSystem.INavigationElement.Permission | | get |

Implemented in [SandBox.View.Map.Navigation.MapNavigationElementBase](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#afc9b2bb57ce26ac548939b43cefcbec9).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a2d42712f5db91a10af2be5741d1db0e5)IsLockingNavigation
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.INavigationElement.IsLockingNavigation | | get |

Implemented in [SandBox.View.Map.Navigation.MapNavigationElementBase](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a282d636c8bae24c56e50893381000f8c), [SandBox.View.Map.Navigation.NavigationElements.CharacterDeveloperNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_character_developer_navigation_element.html#a88e4a3ac84e5b51e20c8145f5f2d8520), [SandBox.View.Map.Navigation.NavigationElements.ClanNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_clan_navigation_element.html#a36664b88ee540486da67230235ffcb45), [SandBox.View.Map.Navigation.NavigationElements.EscapeMenuNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_escape_menu_navigation_element.html#a5aa1579f76c22fe17080c35e37299eef), [SandBox.View.Map.Navigation.NavigationElements.InventoryNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_inventory_navigation_element.html#a7bf57252f7a57686ebdc27de953ed458), [SandBox.View.Map.Navigation.NavigationElements.KingdomNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_kingdom_navigation_element.html#af27ab7f054dff160be578f20fcbad598), [SandBox.View.Map.Navigation.NavigationElements.PartyNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_party_navigation_element.html#a9f6d84da15a4f8ec752181dc613eae54), and [SandBox.View.Map.Navigation.NavigationElements.QuestsNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_quests_navigation_element.html#a867a90546c84a98d085a5096873d8fb0).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a8895b957484a7aa8c41d0c5473a1e77a)IsActive
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.INavigationElement.IsActive | | get |

Implemented in [SandBox.View.Map.Navigation.MapNavigationElementBase](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#ad5c30249e044e33bca416a9b42d3360b), [SandBox.View.Map.Navigation.NavigationElements.CharacterDeveloperNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_character_developer_navigation_element.html#ae4dfd978f87aea292ca8aa3a1a40c03c), [SandBox.View.Map.Navigation.NavigationElements.ClanNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_clan_navigation_element.html#a894a2f6db4a9bdc272226897dbda71dc), [SandBox.View.Map.Navigation.NavigationElements.EscapeMenuNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_escape_menu_navigation_element.html#a211dec59190e0be70979f662079f0cb2), [SandBox.View.Map.Navigation.NavigationElements.InventoryNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_inventory_navigation_element.html#af813961a2aeb861c08a78e2ce56d61d8), [SandBox.View.Map.Navigation.NavigationElements.KingdomNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_kingdom_navigation_element.html#a2dade2b8f081d27ed6b598f172c7f109), [SandBox.View.Map.Navigation.NavigationElements.PartyNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_party_navigation_element.html#aa78b22c4e7b9c94eb1af8da8869e3b1b), and [SandBox.View.Map.Navigation.NavigationElements.QuestsNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_quests_navigation_element.html#aa2c5fe66a2b0e27fdf8e6688d609d82b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a04d1e5156c387e58ced29ebf79ec008b)Tooltip
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.INavigationElement.Tooltip | | get |

Implemented in [SandBox.View.Map.Navigation.MapNavigationElementBase](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a972993f3269ce6b01bab74738d2410c5).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a6d6cafec12776d0031297f63c454f4c8)HasAlert
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.INavigationElement.HasAlert | | get |

Implemented in [SandBox.View.Map.Navigation.MapNavigationElementBase](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#a5e94f803cf1e388faba75d47f1c1d47e), [SandBox.View.Map.Navigation.NavigationElements.CharacterDeveloperNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_character_developer_navigation_element.html#a3bdcd9f7c8dc9d76be10ce3fc7c06ce3), [SandBox.View.Map.Navigation.NavigationElements.ClanNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_clan_navigation_element.html#a83b3bc5bb7afff5ae5f11c158593aaea), [SandBox.View.Map.Navigation.NavigationElements.EscapeMenuNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_escape_menu_navigation_element.html#a161ef5ac01a24c0c696d022bcf058cad), [SandBox.View.Map.Navigation.NavigationElements.InventoryNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_inventory_navigation_element.html#a7dc698caa27918f0e663e865e4bd5efc), [SandBox.View.Map.Navigation.NavigationElements.KingdomNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_kingdom_navigation_element.html#a4bc12605daa6dae796fd6a72ac80841e), [SandBox.View.Map.Navigation.NavigationElements.PartyNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_party_navigation_element.html#a284b7580f99f19f7831fe5616f129e51), and [SandBox.View.Map.Navigation.NavigationElements.QuestsNavigationElement](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_navigation_elements_1_1_quests_navigation_element.html#af552366d54225feb06cd6c4518b9b65f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_element.html#a77f5f5b4dd7dfac3b9f749698356e4d0)AlertTooltip
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.INavigationElement.AlertTooltip | | get |

Implemented in [SandBox.View.Map.Navigation.MapNavigationElementBase](class_sand_box_1_1_view_1_1_map_1_1_navigation_1_1_map_navigation_element_base.html#aa18a07f3669413857b6aeeba75f16bc1).


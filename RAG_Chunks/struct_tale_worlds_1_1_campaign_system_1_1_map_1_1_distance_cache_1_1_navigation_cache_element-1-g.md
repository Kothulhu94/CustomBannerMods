--- SOURCE: struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html ---

TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T > Struct Template ReferenceInherits IEquatable.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae) (T settlement, bool isPortUsed) |
| override int | [GetHashCode](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#ae6adb495a051e8062a5bccf7cedd1dd5) () |
| override bool | [Equals](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#aef7feb8ba349789707eaff6786bf6cdb) (object obj) |
| bool | [Equals](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a2fd0506ae5df16777e7a840b50c4b576) ([NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > other) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [Sort](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a7d4acc87f59eb7e40ba21ccb0da3d6af) (ref [NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > settlement1, ref [NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > settlement2, out bool isPairChanged) |
| static bool | [operator==](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a7b38a339d7ce866c8c22121a36793b60) ([NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > left, [NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > right) |
| static bool | [operator!=](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a57e6ecb58cbdbbad32312250054edc0b) ([NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > left, [NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > right) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly T | [Settlement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#af2b970bfb6229737806e9724c0dbf1ab) |
| readonly bool | [IsPortUsed](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a9fe216159153327b283ac296281687d3) |

|  |  |
| --- | --- |
| Properties | |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [PortPosition](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a3a524fcc007e45dad38eb8df6d0c2c7d) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GatePosition](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a48339ab91792a7a1753219a1c532ce22) `[get]` |
| string | [StringId](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#adb9f677432b42653e35e3624714acbbc) `[get]` |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)NavigationCacheElement()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T >.NavigationCacheElement | ( | T | *settlement*, |
|  |  | bool | *isPortUsed* ) |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a7d4acc87f59eb7e40ba21ccb0da3d6af)Sort()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T >.Sort | ( | ref [NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > | *settlement1*, | |  |  | ref [NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > | *settlement2*, | |  |  | out bool | *isPairChanged* ) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#ae6adb495a051e8062a5bccf7cedd1dd5)GetHashCode()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T >.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#aef7feb8ba349789707eaff6786bf6cdb)Equals() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T >.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a2fd0506ae5df16777e7a840b50c4b576)Equals() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T >.Equals | ( | [NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > | *other* | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a7b38a339d7ce866c8c22121a36793b60)operator==()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T >.operator== | ( | [NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > | *left*, | |  |  | [NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > | *right* ) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a57e6ecb58cbdbbad32312250054edc0b)operator!=()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T >.operator!= | ( | [NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > | *left*, | |  |  | [NavigationCacheElement](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a80df01378906d62cdce09223895a5aae)< T > | *right* ) | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#af2b970bfb6229737806e9724c0dbf1ab)Settlement
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly T TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T >.Settlement |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a9fe216159153327b283ac296281687d3)IsPortUsed
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T >.IsPortUsed |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a3a524fcc007e45dad38eb8df6d0c2c7d)PortPosition
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T >.PortPosition | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#a48339ab91792a7a1753219a1c532ce22)GatePosition
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T >.GatePosition | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache_element-1-g.html#adb9f677432b42653e35e3624714acbbc)StringId
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCacheElement< T >.StringId | | get |


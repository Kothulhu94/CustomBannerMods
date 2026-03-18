--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html ---

TaleWorlds.MountAndBlade.ClanFriendListService Class ReferenceInherits IFriendListService.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ClanFriendListService](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#a084ccfbb5bd95ea73e800cc76ffea587) () |
| async Task< PlayerId > | [GetUserWithName](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#ae6d814fa034110f4e68f5951964d3e74) (string name) |
| IEnumerable< PlayerId > | [GetPendingRequests](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#a66e410dcb061bb384d2c59fbd74403e4) () |
| IEnumerable< PlayerId > | [GetReceivedRequests](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#a75c4b62d42fbd0e894cfa2eb2cbc8961) () |
| void | [OnClanInfoChanged](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#ac2bab5cded2a0c39e649790ed80d983a) (List< ClanPlayerInfo > playerInfosInClan) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [CodeName](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#a1a6d0dc40653d7c2a2fcbd0aef37e781) = "ClanFriends" |

|  |  |
| --- | --- |
| Events | |
| Action< PlayerId > | [OnUserStatusChanged](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#a74f639cd37a53fa2cc3be54746454e21) |
| Action< PlayerId > | [OnFriendRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#ad08b1e03c90bac8e1bc7e6d9fc2875ca) |
| Action | [OnFriendListChanged](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#a9551cf06c65d071946c61ecf157c16a5) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#a084ccfbb5bd95ea73e800cc76ffea587)ClanFriendListService()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ClanFriendListService.ClanFriendListService | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#ae6d814fa034110f4e68f5951964d3e74)GetUserWithName()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| async Task< PlayerId > TaleWorlds.MountAndBlade.ClanFriendListService.GetUserWithName | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#a66e410dcb061bb384d2c59fbd74403e4)GetPendingRequests()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< PlayerId > TaleWorlds.MountAndBlade.ClanFriendListService.GetPendingRequests | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#a75c4b62d42fbd0e894cfa2eb2cbc8961)GetReceivedRequests()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< PlayerId > TaleWorlds.MountAndBlade.ClanFriendListService.GetReceivedRequests | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#ac2bab5cded2a0c39e649790ed80d983a)OnClanInfoChanged()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ClanFriendListService.OnClanInfoChanged | ( | List< ClanPlayerInfo > | *playerInfosInClan* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#a1a6d0dc40653d7c2a2fcbd0aef37e781)CodeName
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.ClanFriendListService.CodeName = "ClanFriends" | | static |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#a74f639cd37a53fa2cc3be54746454e21)OnUserStatusChanged
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<PlayerId> TaleWorlds.MountAndBlade.ClanFriendListService.OnUserStatusChanged |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#ad08b1e03c90bac8e1bc7e6d9fc2875ca)OnFriendRemoved
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<PlayerId> TaleWorlds.MountAndBlade.ClanFriendListService.OnFriendRemoved |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_clan_friend_list_service.html#a9551cf06c65d071946c61ecf157c16a5)OnFriendListChanged
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.ClanFriendListService.OnFriendListChanged |


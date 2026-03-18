--- SOURCE: interface_tale_worlds_1_1_core_1_1_i_communicator.html ---

TaleWorlds.Core.ICommunicator Interface ReferenceInherited by [TaleWorlds.Core.DummyCommunicator](class_tale_worlds_1_1_core_1_1_dummy_communicator.html), and [TaleWorlds.MountAndBlade.NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnSynchronizeComponentTo](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a8eb8d6c8ec9745feadbb268e6f18f58d) ([VirtualPlayer](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a1468fba0d0b3ac6133c0d9faadf6b261) peer, [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) component) |
| void | [OnAddComponent](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a96dd641a32dd4a42b0aca0783327e1d4) ([PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) component) |
| void | [OnRemoveComponent](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a578dca922147fe7d6c4dd2cc9defc1c3) ([PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) component) |

|  |  |
| --- | --- |
| Properties | |
| VirtualPlayer | [VirtualPlayer](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a1468fba0d0b3ac6133c0d9faadf6b261) `[get]` |
| bool | [IsNetworkActive](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a6ce4a0e2c7fb1fff1d4620dd5383af87) `[get]` |
| bool | [IsConnectionActive](interface_tale_worlds_1_1_core_1_1_i_communicator.html#afb6b77062a8d32497c6268d9fd0ec3ec) `[get]` |
| bool | [IsServerPeer](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a81bfeafa382e4f00e937c22b83c55315) `[get]` |
| bool | [IsSynchronized](interface_tale_worlds_1_1_core_1_1_i_communicator.html#ad04129b6ffe8fa21b3ff9a6c8c1b2084) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a8eb8d6c8ec9745feadbb268e6f18f58d)OnSynchronizeComponentTo()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.ICommunicator.OnSynchronizeComponentTo | ( | [VirtualPlayer](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a1468fba0d0b3ac6133c0d9faadf6b261) | *peer*, |
|  |  | [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | *component* ) |

Implemented in [TaleWorlds.Core.DummyCommunicator](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#af80f3afd445d2c9a892dd66559cf4892).

[◆](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a96dd641a32dd4a42b0aca0783327e1d4)OnAddComponent()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ICommunicator.OnAddComponent | ( | [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | *component* | ) |  |

Implemented in [TaleWorlds.Core.DummyCommunicator](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#ac83205198f1be2a857ee08a6e85a714c).

[◆](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a578dca922147fe7d6c4dd2cc9defc1c3)OnRemoveComponent()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ICommunicator.OnRemoveComponent | ( | [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | *component* | ) |  |

Implemented in [TaleWorlds.Core.DummyCommunicator](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#aab48b1da1fbcef9823a1894c185283ad).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a1468fba0d0b3ac6133c0d9faadf6b261)VirtualPlayer
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | VirtualPlayer TaleWorlds.Core.ICommunicator.VirtualPlayer | | get |

Implemented in [TaleWorlds.Core.DummyCommunicator](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a075bd56ec1d6c795f8a50eb97675e5b3), and [TaleWorlds.MountAndBlade.NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a82bc3a2d6739241287939d24bce93bf5).

[◆](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a6ce4a0e2c7fb1fff1d4620dd5383af87)IsNetworkActive
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ICommunicator.IsNetworkActive | | get |

Implemented in [TaleWorlds.Core.DummyCommunicator](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a7458afcea2cf65fbece35f9081e00df3), and [TaleWorlds.MountAndBlade.NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ac3482a8bfe2615d36ac99293cf4a7ccf).

[◆](interface_tale_worlds_1_1_core_1_1_i_communicator.html#afb6b77062a8d32497c6268d9fd0ec3ec)IsConnectionActive
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ICommunicator.IsConnectionActive | | get |

Implemented in [TaleWorlds.Core.DummyCommunicator](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#acc3477f42c6cd8c4814263dbd519f700), and [TaleWorlds.MountAndBlade.NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a0cb01fe1f9e49ea16452012348900d36).

[◆](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a81bfeafa382e4f00e937c22b83c55315)IsServerPeer
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ICommunicator.IsServerPeer | | get |

Implemented in [TaleWorlds.Core.DummyCommunicator](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a7f54d5f29716927f101288a70aaff222), and [TaleWorlds.MountAndBlade.NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a8d78eaed0ab2e053c319cfe4798c8b0d).

[◆](interface_tale_worlds_1_1_core_1_1_i_communicator.html#ad04129b6ffe8fa21b3ff9a6c8c1b2084)IsSynchronized
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ICommunicator.IsSynchronized | | getset |

Implemented in [TaleWorlds.Core.DummyCommunicator](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#ae1e8960d0f6e9baac198649d2ec8deb1), and [TaleWorlds.MountAndBlade.NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ab8bb1cae4f6136bc087bb56b2018f32a).


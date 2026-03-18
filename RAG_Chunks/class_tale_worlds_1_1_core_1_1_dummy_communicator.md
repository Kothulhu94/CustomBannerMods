--- SOURCE: class_tale_worlds_1_1_core_1_1_dummy_communicator.html ---

TaleWorlds.Core.DummyCommunicator Class ReferenceInherits [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnSynchronizeComponentTo](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#af80f3afd445d2c9a892dd66559cf4892) ([VirtualPlayer](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a075bd56ec1d6c795f8a50eb97675e5b3) peer, [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) component) |
| void | [OnAddComponent](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#ac83205198f1be2a857ee08a6e85a714c) ([PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) component) |
| void | [OnRemoveComponent](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#aab48b1da1fbcef9823a1894c185283ad) ([PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) component) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static DummyCommunicator | [CreateAsServer](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a0e9aebfad3ed18dcaa80d62f98c56fe0) (int index, string name) |
| static DummyCommunicator | [CreateAsClient](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#ac8318f3723671a290c13f94d43a70c11) (string name, int index) |

|  |  |
| --- | --- |
| Properties | |
| VirtualPlayer | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a075bd56ec1d6c795f8a50eb97675e5b3) `[get]` |
| bool | [IsNetworkActive](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a7458afcea2cf65fbece35f9081e00df3) `[get]` |
| bool | [IsConnectionActive](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#acc3477f42c6cd8c4814263dbd519f700) `[get]` |
| bool | [IsServerPeer](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a7f54d5f29716927f101288a70aaff222) `[get]` |
| bool | [IsSynchronized](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#ae1e8960d0f6e9baac198649d2ec8deb1) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#af80f3afd445d2c9a892dd66559cf4892)OnSynchronizeComponentTo()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.DummyCommunicator.OnSynchronizeComponentTo | ( | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a075bd56ec1d6c795f8a50eb97675e5b3) | *peer*, |
|  |  | [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | *component* ) |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a8eb8d6c8ec9745feadbb268e6f18f58d).

[◆](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#ac83205198f1be2a857ee08a6e85a714c)OnAddComponent()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.DummyCommunicator.OnAddComponent | ( | [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | *component* | ) |  |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a96dd641a32dd4a42b0aca0783327e1d4).

[◆](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#aab48b1da1fbcef9823a1894c185283ad)OnRemoveComponent()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.DummyCommunicator.OnRemoveComponent | ( | [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | *component* | ) |  |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a578dca922147fe7d6c4dd2cc9defc1c3).

[◆](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a0e9aebfad3ed18dcaa80d62f98c56fe0)CreateAsServer()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | DummyCommunicator TaleWorlds.Core.DummyCommunicator.CreateAsServer | ( | int | *index*, | |  |  | string | *name* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#ac8318f3723671a290c13f94d43a70c11)CreateAsClient()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | DummyCommunicator TaleWorlds.Core.DummyCommunicator.CreateAsClient | ( | string | *name*, | |  |  | int | *index* ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a075bd56ec1d6c795f8a50eb97675e5b3)VirtualPlayer
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | VirtualPlayer TaleWorlds.Core.DummyCommunicator.VirtualPlayer | | get |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a1468fba0d0b3ac6133c0d9faadf6b261).

[◆](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a7458afcea2cf65fbece35f9081e00df3)IsNetworkActive
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.DummyCommunicator.IsNetworkActive | | get |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a6ce4a0e2c7fb1fff1d4620dd5383af87).

[◆](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#acc3477f42c6cd8c4814263dbd519f700)IsConnectionActive
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.DummyCommunicator.IsConnectionActive | | get |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#afb6b77062a8d32497c6268d9fd0ec3ec).

[◆](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#a7f54d5f29716927f101288a70aaff222)IsServerPeer
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.DummyCommunicator.IsServerPeer | | get |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a81bfeafa382e4f00e937c22b83c55315).

[◆](class_tale_worlds_1_1_core_1_1_dummy_communicator.html#ae1e8960d0f6e9baac198649d2ec8deb1)IsSynchronized
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.DummyCommunicator.IsSynchronized | | getset |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#ad04129b6ffe8fa21b3ff9a6c8c1b2084).


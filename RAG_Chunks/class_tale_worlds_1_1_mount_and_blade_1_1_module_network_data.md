--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html ---

TaleWorlds.MountAndBlade.ModuleNetworkData Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | [ReadItemReferenceFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html#a35367262c9ba891c7d56f8736a22b0b4) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, ref bool bufferReadValid) |
| static void | [WriteItemReferenceToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html#acfebc31286cfa8f52f677061c720da7a) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) equipElement) |
| static [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | [ReadWeaponReferenceFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html#a27368f0d0457ce97639ea387310f28a6) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, ref bool bufferReadValid) |
| static void | [WriteWeaponReferenceToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html#a84d894ffd557869de0498417cd6b4172) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon) |
| static [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | [ReadMissileWeaponReferenceFromPacket](class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html#ad42fae517063e51f6e46102fe62748b6) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, ref bool bufferReadValid) |
| static void | [WriteMissileWeaponReferenceToPacket](class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html#a37613805a9dd83af67940a8a6656ffc9) ([MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) weapon) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html#a35367262c9ba891c7d56f8736a22b0b4)ReadItemReferenceFromPacket()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) TaleWorlds.MountAndBlade.ModuleNetworkData.ReadItemReferenceFromPacket | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html#acfebc31286cfa8f52f677061c720da7a)WriteItemReferenceToPacket()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ModuleNetworkData.WriteItemReferenceToPacket | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *equipElement* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html#a27368f0d0457ce97639ea387310f28a6)ReadWeaponReferenceFromPacket()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) TaleWorlds.MountAndBlade.ModuleNetworkData.ReadWeaponReferenceFromPacket | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html#a84d894ffd557869de0498417cd6b4172)WriteWeaponReferenceToPacket()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ModuleNetworkData.WriteWeaponReferenceToPacket | ( | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html#ad42fae517063e51f6e46102fe62748b6)ReadMissileWeaponReferenceFromPacket()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) TaleWorlds.MountAndBlade.ModuleNetworkData.ReadMissileWeaponReferenceFromPacket | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | ref bool | *bufferReadValid* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_module_network_data.html#a37613805a9dd83af67940a8a6656ffc9)WriteMissileWeaponReferenceToPacket()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ModuleNetworkData.WriteMissileWeaponReferenceToPacket | ( | [MissionWeapon](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_weapon.html) | *weapon* | ) |  | | static |


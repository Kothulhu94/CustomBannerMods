--- SOURCE: class_tale_worlds_1_1_core_1_1_equipment.html ---

TaleWorlds.Core.Equipment Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [EquipmentType](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cba) {     [Invalid](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cbaa4bbb8f967da6d1a610596d7257179c2b) = -1 ,     [Battle](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cbaa747d99f92ee9c080ba26108ac5d26488) ,     [Civilian](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cbaa4f288ef90a7b9b5283ecf39574f010d0) ,     [Stealth](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cbaa899db408cba5858a0f1701a2caef2628)   } |
| enum | [UnderwearTypes](class_tale_worlds_1_1_core_1_1_equipment.html#a72d409abf9e4da4ef2449568a1581be2) {     [NoUnderwear](class_tale_worlds_1_1_core_1_1_equipment.html#a72d409abf9e4da4ef2449568a1581be2a2fd56f3d42f4156755d1fbee7c2f4842) = 0 ,     [FullUnderwear](class_tale_worlds_1_1_core_1_1_equipment.html#a72d409abf9e4da4ef2449568a1581be2a62e282776ad3b229e186b7c12d8bf8b3) ,     [OnlyTop](class_tale_worlds_1_1_core_1_1_equipment.html#a72d409abf9e4da4ef2449568a1581be2ab51ba2013c2b2c74786b50ab25d21215)   } |
| enum | [InitialWeaponEquipPreference](class_tale_worlds_1_1_core_1_1_equipment.html#a4f20fb89d2bb249f242976b83f3c51ed) {     [Any](class_tale_worlds_1_1_core_1_1_equipment.html#a4f20fb89d2bb249f242976b83f3c51edaed36a1ef76a59ee3f15180e0441188ad) ,     [MeleeForMainHand](class_tale_worlds_1_1_core_1_1_equipment.html#a4f20fb89d2bb249f242976b83f3c51eda27051fbc52a28e596d16c162e48a657f) ,     [RangedForMainHand](class_tale_worlds_1_1_core_1_1_equipment.html#a4f20fb89d2bb249f242976b83f3c51edae6353fb4372894d5ab00dc16ee5ffcab)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) () |
|  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#ae883df83402289cbffae2b0b81c55e4a) ([EquipmentType](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cba) equipmentType) |
|  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a58af6c6549b3a393abf49438d9e38655) (Equipment equipment) |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) | [Clone](class_tale_worlds_1_1_core_1_1_equipment.html#a184d2f2a6dede8f783de93170a0c0a6b) (bool cloneWithoutWeapons=false) |
| void | [FillFrom](class_tale_worlds_1_1_core_1_1_equipment.html#ae8c27766b15ba63762c1b6870a180df0) ([Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) sourceEquipment, bool useSourceEquipmentType=true) |
| void | [Deserialize](class_tale_worlds_1_1_core_1_1_equipment.html#a44f2bc6708c0190d2985c3d769629f9a) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| void | [DeserializeNode](class_tale_worlds_1_1_core_1_1_equipment.html#aefa4dbdec5849db61fffba6008ad4774) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| bool | [IsEmpty](class_tale_worlds_1_1_core_1_1_equipment.html#a18b942991a2ac87aec08b3c42b908d8d) () |
| float | [GetTotalWeightOfArmor](class_tale_worlds_1_1_core_1_1_equipment.html#a531b5ceed51f8ac1c806ef8cce9f7b22) (bool forHuman) |
| float | [GetTotalWeightOfWeapons](class_tale_worlds_1_1_core_1_1_equipment.html#ad03a17e6f9f96467ab4ae18f280cd05c) () |
| float | [GetHeadArmorSum](class_tale_worlds_1_1_core_1_1_equipment.html#affd4e188251340c3034f7d4500dfd834) () |
| float | [GetHumanBodyArmorSum](class_tale_worlds_1_1_core_1_1_equipment.html#a4fe4f711a8be528c4588419b721fd883) () |
| float | [GetLegArmorSum](class_tale_worlds_1_1_core_1_1_equipment.html#ad391acea2cc6299631933b0d7be6ea1d) () |
| float | [GetArmArmorSum](class_tale_worlds_1_1_core_1_1_equipment.html#a3891a1809e2409259a3697ad86856183) () |
| float | [GetHorseArmorSum](class_tale_worlds_1_1_core_1_1_equipment.html#a8470421aa673ecfc3db30e25a71d9aef) () |
| [UnderwearTypes](class_tale_worlds_1_1_core_1_1_equipment.html#a72d409abf9e4da4ef2449568a1581be2) | [GetUnderwearType](class_tale_worlds_1_1_core_1_1_equipment.html#aec6d040542efffc566f95bfffa674f45) (bool isFemale) |
| bool | [HasWeapon](class_tale_worlds_1_1_core_1_1_equipment.html#a7b4cb3046f7fbb2283ec341853dfd59c) () |
| bool | [HasWeaponOfClass](class_tale_worlds_1_1_core_1_1_equipment.html#a688d865fe26826e1ded9d42d5539a056) ([WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) weaponClass) |
| string | [CalculateEquipmentCode](class_tale_worlds_1_1_core_1_1_equipment.html#a2dc89d6fa73790da41acee0653b1f7a6) () |
| void | [AddEquipmentToSlotWithoutAgent](class_tale_worlds_1_1_core_1_1_equipment.html#afcc8a34190771e47a46d976f1bcf38bb) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equipmentIndex, [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) itemRosterElement) |
|  | DO NOT CALL THIS FUNCTION IF YOU HAVE AGENT! USE AGENT.EQUIPITEM!!!!! |
| [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | [GetEquipmentFromSlot](class_tale_worlds_1_1_core_1_1_equipment.html#ab42b572490de81b3c40672bebef3bd19) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) equipmentIndex) |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | [GetWeaponPickUpSlotIndex](class_tale_worlds_1_1_core_1_1_equipment.html#a07315252c6dd6ba34c2ba991b0f73243) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) itemRosterElement, bool isStuckMissile) |
| bool | [IsEquipmentEqualTo](class_tale_worlds_1_1_core_1_1_equipment.html#aeb06ef3c313691ef8b4ef9695bbe9045) ([Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) other) |
| void | [GetInitialWeaponIndicesToEquip](class_tale_worlds_1_1_core_1_1_equipment.html#a2fb339220bfe6301883f4b0d586166aa) (out [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) mainHandWeaponIndex, out [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) offHandWeaponIndex, out bool isMainHandNotUsableWithOneHand, [InitialWeaponEquipPreference](class_tale_worlds_1_1_core_1_1_equipment.html#a4f20fb89d2bb249f242976b83f3c51ed) initialWeaponEquipPreference=[InitialWeaponEquipPreference.Any](class_tale_worlds_1_1_core_1_1_equipment.html#a4f20fb89d2bb249f242976b83f3c51edaed36a1ef76a59ee3f15180e0441188ad)) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | [GetEquipmentIndexFromOldEquipmentIndexName](class_tale_worlds_1_1_core_1_1_equipment.html#a99ded991ee40753427facdba2eed66b3) (string oldEquipmentIndexName) |
| static [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) | [CreateFromEquipmentCode](class_tale_worlds_1_1_core_1_1_equipment.html#a62095600718145ea4877777d70bb1965) (string equipmentCode) |
| static bool | [IsItemFitsToSlot](class_tale_worlds_1_1_core_1_1_equipment.html#ab7ba358e38dc94f27c595cbb34842b47) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) slotIndex, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| static [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) | [GetRandomEquipmentElements](class_tale_worlds_1_1_core_1_1_equipment.html#ac3bed6f73e70fc9d8b83e8fc8f28de7b) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, bool randomEquipmentModifier, [EquipmentType](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cba) equipmentType, int seed=-1) |
| static void | [SwapWeapons](class_tale_worlds_1_1_core_1_1_equipment.html#abfb5510353336939bd36e1035b779f01) ([Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) equipment, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) index1, [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) index2) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [SyncEquipments](class_tale_worlds_1_1_core_1_1_equipment.html#aa3c6ee98e6da2e80d81bdaf355fcfb14) = false |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [EquipmentSlotLength](class_tale_worlds_1_1_core_1_1_equipment.html#a16fd858621b5e9f95efca4917212dd39) = (int)[EquipmentIndex.NumEquipmentSetSlots](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61ae8ed9a2c1422b69914744d0e2ceeb098) |
| const string | [NullCode](class_tale_worlds_1_1_core_1_1_equipment.html#a176ea4a0101e9ccdaf3930de6fb8cf4f) = "@null" |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsCivilian](class_tale_worlds_1_1_core_1_1_equipment.html#a346c163e9d0a7f96afb5a78da6b3d4a1) `[get]` |
| bool | [IsBattle](class_tale_worlds_1_1_core_1_1_equipment.html#aa6168065cbd3dbbea5ed91cbb66bc365) `[get]` |
| bool | [IsStealth](class_tale_worlds_1_1_core_1_1_equipment.html#af6fe7ad16923661c6c88b25cdb76476c) `[get]` |
| [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | [this[int index]](class_tale_worlds_1_1_core_1_1_equipment.html#ad9a79bfffbbf682663355d78eca23f5a) `[get, set]` |
| [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | [this[EquipmentIndex index]](class_tale_worlds_1_1_core_1_1_equipment.html#a8f8f2dba0bdd9b7eb3ffaf69baa22892) `[get, set]` |
| [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | [Horse](class_tale_worlds_1_1_core_1_1_equipment.html#aa9477dba7911129abd1e79c0eb9df698) `[get]` |
| [ArmorComponent.HairCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7) | [HairCoverType](class_tale_worlds_1_1_core_1_1_equipment.html#af89dd5bdb3bacb0ddc07f2f763925364) `[get]` |
| [ArmorComponent.BeardCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76) | [BeardCoverType](class_tale_worlds_1_1_core_1_1_equipment.html#a87e2d4e23f71a2753bc8439a776c6c4d) `[get]` |
| [ArmorComponent.HorseHarnessCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a823d3396e0a86c96ed82bb51fb32cff2) | [ManeCoverType](class_tale_worlds_1_1_core_1_1_equipment.html#aff4c21231e7564a9769cfa0b8b280cfc) `[get]` |
| string | [ReinsMeshName](class_tale_worlds_1_1_core_1_1_equipment.html#a166247d41bc088d482dd40394dfd642b) `[get]` |
| bool | [EarsAreHidden](class_tale_worlds_1_1_core_1_1_equipment.html#adc60d1bd2c7d3407864a841ab6ad6b52) `[get]` |
| bool | [MouthIsHidden](class_tale_worlds_1_1_core_1_1_equipment.html#a92bd07297df57e5756691833d2bcd9cd) `[get]` |
| [ArmorComponent.BodyMeshTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a9324c90a345f218fe122d5d9439c6a99) | [BodyMeshType](class_tale_worlds_1_1_core_1_1_equipment.html#aa060b234973aaa79bd8994735ef954c5) `[get]` |
| [ArmorComponent.BodyDeformTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#af7a1e685872a37d946b00abbf2371cbc) | [BodyDeformType](class_tale_worlds_1_1_core_1_1_equipment.html#abf5b924ddb39a5df77f7b41f82c73639) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cba)EquipmentType
-------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.Equipment.EquipmentType](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cba) |

| Enumerator | |
| --- | --- |
| Invalid |  |
| Battle |  |
| Civilian |  |
| Stealth |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a72d409abf9e4da4ef2449568a1581be2)UnderwearTypes
--------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.Equipment.UnderwearTypes](class_tale_worlds_1_1_core_1_1_equipment.html#a72d409abf9e4da4ef2449568a1581be2) |

| Enumerator | |
| --- | --- |
| NoUnderwear |  |
| FullUnderwear |  |
| OnlyTop |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a4f20fb89d2bb249f242976b83f3c51ed)InitialWeaponEquipPreference
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Core.Equipment.InitialWeaponEquipPreference](class_tale_worlds_1_1_core_1_1_equipment.html#a4f20fb89d2bb249f242976b83f3c51ed) |

| Enumerator | |
| --- | --- |
| Any |  |
| MeleeForMainHand |  |
| RangedForMainHand |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335)Equipment() [1/3]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.Equipment.Equipment | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#ae883df83402289cbffae2b0b81c55e4a)Equipment() [2/3]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.Equipment.Equipment | ( | [EquipmentType](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cba) | *equipmentType* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a58af6c6549b3a393abf49438d9e38655)Equipment() [3/3]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.Equipment.Equipment | ( | Equipment | *equipment* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a184d2f2a6dede8f783de93170a0c0a6b)Clone()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) TaleWorlds.Core.Equipment.Clone | ( | bool | *cloneWithoutWeapons* = false | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#ae8c27766b15ba63762c1b6870a180df0)FillFrom()
----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.Equipment.FillFrom | ( | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) | *sourceEquipment*, |
|  |  | bool | *useSourceEquipmentType* = true ) |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a44f2bc6708c0190d2985c3d769629f9a)Deserialize()
-------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.Equipment.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, |
|  |  | XmlNode | *node* ) |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#aefa4dbdec5849db61fffba6008ad4774)DeserializeNode()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.Equipment.DeserializeNode | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, |
|  |  | XmlNode | *node* ) |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a99ded991ee40753427facdba2eed66b3)GetEquipmentIndexFromOldEquipmentIndexName()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) TaleWorlds.Core.Equipment.GetEquipmentIndexFromOldEquipmentIndexName | ( | string | *oldEquipmentIndexName* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a18b942991a2ac87aec08b3c42b908d8d)IsEmpty()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.Equipment.IsEmpty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a531b5ceed51f8ac1c806ef8cce9f7b22)GetTotalWeightOfArmor()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Core.Equipment.GetTotalWeightOfArmor | ( | bool | *forHuman* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#ad03a17e6f9f96467ab4ae18f280cd05c)GetTotalWeightOfWeapons()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Core.Equipment.GetTotalWeightOfWeapons | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#affd4e188251340c3034f7d4500dfd834)GetHeadArmorSum()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Core.Equipment.GetHeadArmorSum | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a4fe4f711a8be528c4588419b721fd883)GetHumanBodyArmorSum()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Core.Equipment.GetHumanBodyArmorSum | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#ad391acea2cc6299631933b0d7be6ea1d)GetLegArmorSum()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Core.Equipment.GetLegArmorSum | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a3891a1809e2409259a3697ad86856183)GetArmArmorSum()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Core.Equipment.GetArmArmorSum | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a8470421aa673ecfc3db30e25a71d9aef)GetHorseArmorSum()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Core.Equipment.GetHorseArmorSum | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#aec6d040542efffc566f95bfffa674f45)GetUnderwearType()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [UnderwearTypes](class_tale_worlds_1_1_core_1_1_equipment.html#a72d409abf9e4da4ef2449568a1581be2) TaleWorlds.Core.Equipment.GetUnderwearType | ( | bool | *isFemale* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a7b4cb3046f7fbb2283ec341853dfd59c)HasWeapon()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.Equipment.HasWeapon | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a688d865fe26826e1ded9d42d5539a056)HasWeaponOfClass()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.Equipment.HasWeaponOfClass | ( | [WeaponClass](namespace_tale_worlds_1_1_core.html#a7cdba4c3664b67213bb74551e2616f61) | *weaponClass* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a62095600718145ea4877777d70bb1965)CreateFromEquipmentCode()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) TaleWorlds.Core.Equipment.CreateFromEquipmentCode | ( | string | *equipmentCode* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a2dc89d6fa73790da41acee0653b1f7a6)CalculateEquipmentCode()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Core.Equipment.CalculateEquipmentCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#afcc8a34190771e47a46d976f1bcf38bb)AddEquipmentToSlotWithoutAgent()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.Equipment.AddEquipmentToSlotWithoutAgent | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equipmentIndex*, |
|  |  | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *itemRosterElement* ) |

Parameters
:   |  |  |
    | --- | --- |
    | equipmentIndex |  |
    | itemRosterElement |  |

Returns
:   void

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#ab42b572490de81b3c40672bebef3bd19)GetEquipmentFromSlot()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) TaleWorlds.Core.Equipment.GetEquipmentFromSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *equipmentIndex* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#ab7ba358e38dc94f27c595cbb34842b47)IsItemFitsToSlot()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Core.Equipment.IsItemFitsToSlot | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *slotIndex*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a07315252c6dd6ba34c2ba991b0f73243)GetWeaponPickUpSlotIndex()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) TaleWorlds.Core.Equipment.GetWeaponPickUpSlotIndex | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *itemRosterElement*, |
|  |  | bool | *isStuckMissile* ) |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#aeb06ef3c313691ef8b4ef9695bbe9045)IsEquipmentEqualTo()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.Equipment.IsEquipmentEqualTo | ( | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) | *other* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#ac3bed6f73e70fc9d8b83e8fc8f28de7b)GetRandomEquipmentElements()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) TaleWorlds.Core.Equipment.GetRandomEquipmentElements | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, | |  |  | bool | *randomEquipmentModifier*, | |  |  | [EquipmentType](class_tale_worlds_1_1_core_1_1_equipment.html#a0a7958125959c7bcbc83553e48af7cba) | *equipmentType*, | |  |  | int | *seed* = -1 ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#abfb5510353336939bd36e1035b779f01)SwapWeapons()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.Equipment.SwapWeapons | ( | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html#a9e1313bbb3570733961d1ab973dad335) | *equipment*, | |  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *index1*, | |  |  | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *index2* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a2fb339220bfe6301883f4b0d586166aa)GetInitialWeaponIndicesToEquip()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Core.Equipment.GetInitialWeaponIndicesToEquip | ( | out [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *mainHandWeaponIndex*, |
|  |  | out [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *offHandWeaponIndex*, |
|  |  | out bool | *isMainHandNotUsableWithOneHand*, |
|  |  | [InitialWeaponEquipPreference](class_tale_worlds_1_1_core_1_1_equipment.html#a4f20fb89d2bb249f242976b83f3c51ed) | *initialWeaponEquipPreference* = [InitialWeaponEquipPreference::Any](class_tale_worlds_1_1_core_1_1_equipment.html#a4f20fb89d2bb249f242976b83f3c51edaed36a1ef76a59ee3f15180e0441188ad) ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a16fd858621b5e9f95efca4917212dd39)EquipmentSlotLength
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.Equipment.EquipmentSlotLength = (int)[EquipmentIndex.NumEquipmentSetSlots](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61ae8ed9a2c1422b69914744d0e2ceeb098) | | static |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#aa3c6ee98e6da2e80d81bdaf355fcfb14)SyncEquipments
--------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.Core.Equipment.SyncEquipments = false |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a176ea4a0101e9ccdaf3930de6fb8cf4f)NullCode
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.Core.Equipment.NullCode = "@null" | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a346c163e9d0a7f96afb5a78da6b3d4a1)IsCivilian
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.Equipment.IsCivilian | | get |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#aa6168065cbd3dbbea5ed91cbb66bc365)IsBattle
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.Equipment.IsBattle | | get |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#af6fe7ad16923661c6c88b25cdb76476c)IsStealth
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.Equipment.IsStealth | | get |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#ad9a79bfffbbf682663355d78eca23f5a)this[int index]
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) TaleWorlds.Core.Equipment.this[int index] | | getset |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a8f8f2dba0bdd9b7eb3ffaf69baa22892)this[EquipmentIndex index]
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) TaleWorlds.Core.Equipment.this[[EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) index] | | getset |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#aa9477dba7911129abd1e79c0eb9df698)Horse
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) TaleWorlds.Core.Equipment.Horse | | get |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#af89dd5bdb3bacb0ddc07f2f763925364)HairCoverType
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ArmorComponent.HairCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a8967f19144fe5eda40b2286a5749bdd7) TaleWorlds.Core.Equipment.HairCoverType | | get |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a87e2d4e23f71a2753bc8439a776c6c4d)BeardCoverType
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ArmorComponent.BeardCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#abde298fbb3afc945bf4d6bb4d7147a76) TaleWorlds.Core.Equipment.BeardCoverType | | get |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#aff4c21231e7564a9769cfa0b8b280cfc)ManeCoverType
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ArmorComponent.HorseHarnessCoverTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a823d3396e0a86c96ed82bb51fb32cff2) TaleWorlds.Core.Equipment.ManeCoverType | | get |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a166247d41bc088d482dd40394dfd642b)ReinsMeshName
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.Equipment.ReinsMeshName | | get |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#adc60d1bd2c7d3407864a841ab6ad6b52)EarsAreHidden
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.Equipment.EarsAreHidden | | get |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#a92bd07297df57e5756691833d2bcd9cd)MouthIsHidden
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.Equipment.MouthIsHidden | | get |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#aa060b234973aaa79bd8994735ef954c5)BodyMeshType
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ArmorComponent.BodyMeshTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#a9324c90a345f218fe122d5d9439c6a99) TaleWorlds.Core.Equipment.BodyMeshType | | get |

[◆](class_tale_worlds_1_1_core_1_1_equipment.html#abf5b924ddb39a5df77f7b41f82c73639)BodyDeformType
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ArmorComponent.BodyDeformTypes](class_tale_worlds_1_1_core_1_1_armor_component.html#af7a1e685872a37d946b00abbf2371cbc) TaleWorlds.Core.Equipment.BodyDeformType | | get |


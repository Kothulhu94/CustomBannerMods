--- SOURCE: class_helpers_1_1_item_helper.html ---

Helpers.ItemHelper Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [IsWeaponComparableWithUsage](class_helpers_1_1_item_helper.html#a98a665739cdfbeae3119855f69c96ea5) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, string comparedUsageId) |
| static bool | [IsWeaponComparableWithUsage](class_helpers_1_1_item_helper.html#a3f0845b1ce95980d60c947e5760f8d6c) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, string comparedUsageId, out int comparableUsageIndex) |
| static bool | [CheckComparability](class_helpers_1_1_item_helper.html#a5fd76c6ea2f8421829a22e2c2a57f518) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) comparedItem) |
| static bool | [CheckComparability](class_helpers_1_1_item_helper.html#ae81b5a1451f69de45e86914045f48ce6) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) comparedItem, int usageIndex) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetSwingDamageText](class_helpers_1_1_item_helper.html#a4bb52c07b1e4235172f057dd16b81d3f) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon, [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) itemModifier) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetMissileDamageText](class_helpers_1_1_item_helper.html#aa988bbdb0e92def3ed819db3a0bb2283) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon, [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) itemModifier) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetThrustDamageText](class_helpers_1_1_item_helper.html#af84323b310fbaf770b3b8ce085c65021) ([WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) weapon, [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) itemModifier) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [NumberOfItems](class_helpers_1_1_item_helper.html#ab2e1fa0be47ca1a1d6ad666c41726599) (int number, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_item_helper.html#a98a665739cdfbeae3119855f69c96ea5)IsWeaponComparableWithUsage() [1/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.ItemHelper.IsWeaponComparableWithUsage | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | string | *comparedUsageId* ) | | static |

[◆](class_helpers_1_1_item_helper.html#a3f0845b1ce95980d60c947e5760f8d6c)IsWeaponComparableWithUsage() [2/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.ItemHelper.IsWeaponComparableWithUsage | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | string | *comparedUsageId*, | |  |  | out int | *comparableUsageIndex* ) | | static |

[◆](class_helpers_1_1_item_helper.html#a5fd76c6ea2f8421829a22e2c2a57f518)CheckComparability() [1/2]
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.ItemHelper.CheckComparability | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *comparedItem* ) | | static |

[◆](class_helpers_1_1_item_helper.html#ae81b5a1451f69de45e86914045f48ce6)CheckComparability() [2/2]
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.ItemHelper.CheckComparability | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *comparedItem*, | |  |  | int | *usageIndex* ) | | static |

[◆](class_helpers_1_1_item_helper.html#a4bb52c07b1e4235172f057dd16b81d3f)GetSwingDamageText()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.ItemHelper.GetSwingDamageText | ( | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon*, | |  |  | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *itemModifier* ) | | static |

[◆](class_helpers_1_1_item_helper.html#aa988bbdb0e92def3ed819db3a0bb2283)GetMissileDamageText()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.ItemHelper.GetMissileDamageText | ( | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon*, | |  |  | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *itemModifier* ) | | static |

[◆](class_helpers_1_1_item_helper.html#af84323b310fbaf770b3b8ce085c65021)GetThrustDamageText()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.ItemHelper.GetThrustDamageText | ( | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *weapon*, | |  |  | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *itemModifier* ) | | static |

[◆](class_helpers_1_1_item_helper.html#ab2e1fa0be47ca1a1d6ad666c41726599)NumberOfItems()
----------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) Helpers.ItemHelper.NumberOfItems | ( | int | *number*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* ) | | static |


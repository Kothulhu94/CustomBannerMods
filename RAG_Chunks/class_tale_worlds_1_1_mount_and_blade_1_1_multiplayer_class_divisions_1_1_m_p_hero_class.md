--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html ---

TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass Class ReferenceInherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [Equals](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a426cf61188a5536ac18855ad2df93243) (object obj) |
| override int | [GetHashCode](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#ad69b1ceb03e7dcac4906823e2b4da555) () |
| List< [IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html) > | [GetAllAvailablePerksForListIndex](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a67f41f17406717e46e6aa317214ce574) (int index, string forcedForGameMode=null) |
| override void | [Deserialize](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a50623d160132581c7fdee8fa305e9256) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| bool | [IsTroopCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#aec7fde1d708993eee720f131f20a1570) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character) |
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
| Properties | |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [HeroCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a0aee47a31ce05037af4c28f4dce1a596) `[get]` |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [TroopCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a4b2ef955b8dc71e2066409d295aad539) `[get]` |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [BannerBearerCharacter](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#ae510a1314aa60776877d7692f511f50d) `[get]` |
| [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | [Culture](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#aa1396005d4d57418f3f5ee201039c53a) `[get]` |
| [MPHeroClassGroup](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class_group.html) | [ClassGroup](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#adaa9bb0a165c3c6c1ac5d5de249a54f5) `[get]` |
| string | [HeroIdleAnim](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a155be6bdbcc58887c09da97b8f8165be) `[get]` |
| string | [HeroMountIdleAnim](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a0813fd9e0b91d9791c2576735a867b5c) `[get]` |
| string | [TroopIdleAnim](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#ae3c46f0bad881efb66dabe127d7636b0) `[get]` |
| string | [TroopMountIdleAnim](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a05759b11191df12b825fd1dd05586b5d) `[get]` |
| int | [ArmorValue](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a098a39e13020964850517db927ad2195) `[get]` |
| int | [Health](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#adc73fd85430b1ff0b8f5f40b904e6000) `[get]` |
| float | [HeroMovementSpeedMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#ac024828cff9f316b7e375688f343d22d) `[get]` |
| float | [HeroCombatMovementSpeedMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#aec45829abc3210cb2bc83de05cf5b448) `[get]` |
| float | [HeroTopSpeedReachDuration](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#ac7f3b4b225707421e904ad3b3f45cb2e) `[get]` |
| float | [TroopMovementSpeedMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a4a9fa9a367684a0959d8bb4f29de3327) `[get]` |
| float | [TroopCombatMovementSpeedMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#af8e3bcfca9be182520cb11541f7595d4) `[get]` |
| float | [TroopTopSpeedReachDuration](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a23d631bf6d43d9f383ff493e024af199) `[get]` |
| float | [TroopMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a2ac0b0ca8c778c4420603c5573d71dce) `[get]` |
| int | [TroopCost](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a05a805c7f9837dcf772db9c48beecaa4) `[get]` |
| int | [TroopCasualCost](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a48597ea3ecfd91cbda3353c8bedff272) `[get]` |
| int | [TroopBattleCost](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a298a8e7482424a3ef9d8a30c84ac2e43) `[get]` |
| int | [MeleeAI](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a916380738a7303a4075d307a11f9fca1) `[get]` |
| int | [RangedAI](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a12c674b8bbdc53f26112fbe29c360ead) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [HeroInformation](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a4e45abe46f8461b4996905e195b098ae) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TroopInformation](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a0dfe464eebae82c356aca1a4a518accc) `[get]` |
| [TargetIconType](namespace_tale_worlds_1_1_mount_and_blade.html#ac880639f3f1119ec55dca3b0a70a0ca4) | [IconType](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a291bdcf23ad99e7909e16e78261950ae) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [HeroName](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a8dba7460ce8388958de3dc21ba796035) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [TroopName](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a83b5ac10bd90cfb2b9b5a66610a4da4e) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a426cf61188a5536ac18855ad2df93243)Equals()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.Equals | ( | object | *obj* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#ad69b1ceb03e7dcac4906823e2b4da555)GetHashCode()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a67f41f17406717e46e6aa317214ce574)GetAllAvailablePerksForListIndex()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [IReadOnlyPerkObject](interface_tale_worlds_1_1_mount_and_blade_1_1_i_read_only_perk_object.html) > TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.GetAllAvailablePerksForListIndex | ( | int | *index*, |
|  |  | string | *forcedForGameMode* = null ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a50623d160132581c7fdee8fa305e9256)Deserialize()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#aec7fde1d708993eee720f131f20a1570)IsTroopCharacter()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.IsTroopCharacter | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a0aee47a31ce05037af4c28f4dce1a596)HeroCharacter
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.HeroCharacter | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a4b2ef955b8dc71e2066409d295aad539)TroopCharacter
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.TroopCharacter | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#ae510a1314aa60776877d7692f511f50d)BannerBearerCharacter
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.BannerBearerCharacter | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#aa1396005d4d57418f3f5ee201039c53a)Culture
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.Culture | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#adaa9bb0a165c3c6c1ac5d5de249a54f5)ClassGroup
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MPHeroClassGroup](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class_group.html) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.ClassGroup | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a155be6bdbcc58887c09da97b8f8165be)HeroIdleAnim
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.HeroIdleAnim | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a0813fd9e0b91d9791c2576735a867b5c)HeroMountIdleAnim
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.HeroMountIdleAnim | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#ae3c46f0bad881efb66dabe127d7636b0)TroopIdleAnim
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.TroopIdleAnim | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a05759b11191df12b825fd1dd05586b5d)TroopMountIdleAnim
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.TroopMountIdleAnim | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a098a39e13020964850517db927ad2195)ArmorValue
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.ArmorValue | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#adc73fd85430b1ff0b8f5f40b904e6000)Health
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.Health | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#ac024828cff9f316b7e375688f343d22d)HeroMovementSpeedMultiplier
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.HeroMovementSpeedMultiplier | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#aec45829abc3210cb2bc83de05cf5b448)HeroCombatMovementSpeedMultiplier
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.HeroCombatMovementSpeedMultiplier | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#ac7f3b4b225707421e904ad3b3f45cb2e)HeroTopSpeedReachDuration
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.HeroTopSpeedReachDuration | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a4a9fa9a367684a0959d8bb4f29de3327)TroopMovementSpeedMultiplier
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.TroopMovementSpeedMultiplier | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#af8e3bcfca9be182520cb11541f7595d4)TroopCombatMovementSpeedMultiplier
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.TroopCombatMovementSpeedMultiplier | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a23d631bf6d43d9f383ff493e024af199)TroopTopSpeedReachDuration
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.TroopTopSpeedReachDuration | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a2ac0b0ca8c778c4420603c5573d71dce)TroopMultiplier
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.TroopMultiplier | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a05a805c7f9837dcf772db9c48beecaa4)TroopCost
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.TroopCost | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a48597ea3ecfd91cbda3353c8bedff272)TroopCasualCost
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.TroopCasualCost | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a298a8e7482424a3ef9d8a30c84ac2e43)TroopBattleCost
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.TroopBattleCost | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a916380738a7303a4075d307a11f9fca1)MeleeAI
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.MeleeAI | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a12c674b8bbdc53f26112fbe29c360ead)RangedAI
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.RangedAI | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a4e45abe46f8461b4996905e195b098ae)HeroInformation
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.HeroInformation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a0dfe464eebae82c356aca1a4a518accc)TroopInformation
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.TroopInformation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a291bdcf23ad99e7909e16e78261950ae)IconType
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TargetIconType](namespace_tale_worlds_1_1_mount_and_blade.html#ac880639f3f1119ec55dca3b0a70a0ca4) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.IconType | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a8dba7460ce8388958de3dc21ba796035)HeroName
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.HeroName | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html#a83b5ac10bd90cfb2b9b5a66610a4da4e)TroopName
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.MultiplayerClassDivisions.MPHeroClass.TroopName | | get |


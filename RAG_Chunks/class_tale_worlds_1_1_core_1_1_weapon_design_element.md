--- SOURCE: class_tale_worlds_1_1_core_1_1_weapon_design_element.html ---

TaleWorlds.Core.WeaponDesignElement Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [RefreshDelegate](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a225913e03c8ec2461d8bd6774b3e72bb) () |
| void | [SetScale](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a90018f8d0fee65ec4a2f6a0f0064bd07) (int scalePercentage) |
| WeaponDesignElement | [GetCopy](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a181faf2016284a4f6a3bc9f1183a1df6) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static WeaponDesignElement | [GetInvalidPieceForType](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#aa7b15b472b6bc080c41155ca35f7e9cd) ([CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) pieceType) |
| static WeaponDesignElement | [CreateUsablePiece](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a2952db871e10233820327b5118d288cc) ([CraftingPiece](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a3c98e1b134faae9066ec80587f310d5f) craftingPiece, int scalePercentage=100) |

|  |  |
| --- | --- |
| Properties | |
| int | [ScalePercentage](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#ad305570a8b95c512b93b5b2a432ae6f5) `[get]` |
| float | [ScaleFactor](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#abfc587d392227fc215bae1ed60ed2d97) `[get]` |
| bool | [IsPieceScaled](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a803e9548f2c51facfbf8c4c0942e6066) `[get]` |
| CraftingPiece | [CraftingPiece](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a3c98e1b134faae9066ec80587f310d5f) `[get]` |
| bool | [IsValid](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a67f2594061ad6c1387e3c2ca9f689a83) `[get]` |
| float | [ScaledLength](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a0b15b432a20c55fecb79255d2262b8a3) `[get]` |
| float | [ScaledWeight](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#acf0276fb337aea198e3774a04d21b189) `[get]` |
| float | [ScaledCenterOfMass](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a8aae286c68ffa119e7f09806d5904f67) `[get]` |
| float | [ScaledDistanceToNextPiece](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#abbf3012ed88647310fad930ce74c6e74) `[get]` |
| float | [ScaledDistanceToPreviousPiece](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#aeda4682fd3b747954d4e232d4bf547b0) `[get]` |
| float | [ScaledBladeLength](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a89290357e560ba2cfac47ebca6318bae) `[get]` |
| float | [ScaledPieceOffset](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a145d60f1c4fc0161c0a837d6667f226f) `[get]` |
| float | [ScaledPreviousPieceOffset](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a9b7125664c8f4fa05aaa5850cd9457c5) `[get]` |
| float | [ScaledNextPieceOffset](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#aaf26dbb4f3a68e8180ccab505ebcf8c1) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a225913e03c8ec2461d8bd6774b3e72bb)RefreshDelegate()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void TaleWorlds.Core.WeaponDesignElement.RefreshDelegate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a90018f8d0fee65ec4a2f6a0f0064bd07)SetScale()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.WeaponDesignElement.SetScale | ( | int | *scalePercentage* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a181faf2016284a4f6a3bc9f1183a1df6)GetCopy()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| WeaponDesignElement TaleWorlds.Core.WeaponDesignElement.GetCopy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#aa7b15b472b6bc080c41155ca35f7e9cd)GetInvalidPieceForType()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | WeaponDesignElement TaleWorlds.Core.WeaponDesignElement.GetInvalidPieceForType | ( | [CraftingPiece.PieceTypes](class_tale_worlds_1_1_core_1_1_crafting_piece.html#abd49d9ef3473e52ebea56620d84b8e6a) | *pieceType* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a2952db871e10233820327b5118d288cc)CreateUsablePiece()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | WeaponDesignElement TaleWorlds.Core.WeaponDesignElement.CreateUsablePiece | ( | [CraftingPiece](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a3c98e1b134faae9066ec80587f310d5f) | *craftingPiece*, | |  |  | int | *scalePercentage* = 100 ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#ad305570a8b95c512b93b5b2a432ae6f5)ScalePercentage
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.WeaponDesignElement.ScalePercentage | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#abfc587d392227fc215bae1ed60ed2d97)ScaleFactor
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesignElement.ScaleFactor | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a803e9548f2c51facfbf8c4c0942e6066)IsPieceScaled
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponDesignElement.IsPieceScaled | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a3c98e1b134faae9066ec80587f310d5f)CraftingPiece
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CraftingPiece TaleWorlds.Core.WeaponDesignElement.CraftingPiece | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a67f2594061ad6c1387e3c2ca9f689a83)IsValid
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.WeaponDesignElement.IsValid | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a0b15b432a20c55fecb79255d2262b8a3)ScaledLength
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesignElement.ScaledLength | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#acf0276fb337aea198e3774a04d21b189)ScaledWeight
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesignElement.ScaledWeight | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a8aae286c68ffa119e7f09806d5904f67)ScaledCenterOfMass
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesignElement.ScaledCenterOfMass | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#abbf3012ed88647310fad930ce74c6e74)ScaledDistanceToNextPiece
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesignElement.ScaledDistanceToNextPiece | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#aeda4682fd3b747954d4e232d4bf547b0)ScaledDistanceToPreviousPiece
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesignElement.ScaledDistanceToPreviousPiece | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a89290357e560ba2cfac47ebca6318bae)ScaledBladeLength
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesignElement.ScaledBladeLength | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a145d60f1c4fc0161c0a837d6667f226f)ScaledPieceOffset
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesignElement.ScaledPieceOffset | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#a9b7125664c8f4fa05aaa5850cd9457c5)ScaledPreviousPieceOffset
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesignElement.ScaledPreviousPieceOffset | | get |

[◆](class_tale_worlds_1_1_core_1_1_weapon_design_element.html#aaf26dbb4f3a68e8180ccab505ebcf8c1)ScaledNextPieceOffset
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.WeaponDesignElement.ScaledNextPieceOffset | | get |


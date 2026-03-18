--- SOURCE: class_tale_worlds_1_1_core_1_1_formation_class_extensions.html ---

TaleWorlds.Core.FormationClassExtensions Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [GetName](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a3ac2347cc9ee9a2194e15ad38c3ef131) (this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass) |
| static [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetLocalizedName](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a2c43c23adde5ccc64bb784f4bda929e1) (this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass) |
| static [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) | [GetTroopUsageFlags](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a522dec4b96e0974c2849fa42dfc847c2) (this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) troopClass) |
| static [TroopType](namespace_tale_worlds_1_1_core.html#a5ecb53039bcaf288b346d49b66cd7f48) | [GetTroopTypeForRegularFormation](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#ad0c8b4142419660971878f2513187e63) (this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass) |
| static bool | [IsDefaultFormationClass](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a0aca68878fb2d364796afea0398e3875) (this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass) |
| static bool | [IsRegularFormationClass](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a9c419ee0e2198507865c88cb0c999934) (this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass) |
| static [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | [FallbackClass](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#aa0ae0fa559def73e9ee6b0287ea69a09) (this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) | [DefaultInfantryTroopUsageFlags](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#ad6f76b613305344325d49736f4c0da09) |
| const [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) | [DefaultRangedTroopUsageFlags](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#aca9ff0bc3ddb0506280f9af9b48c7a30) |
| const [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) | [DefaultCavalryTroopUsageFlags](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a16a86547e18c0cc7dd8aa2040b875a78) |
| const [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) | [DefaultHorseArcherTroopUsageFlags](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#ac679bc8a111f85a3b018bb5dc34347a7) |
| static [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90)[] | [FormationClassValues](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a5d3aa94c348dd72afe333d49a69eef8d) = ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90)[])Enum.GetValues(typeof([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90))) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a3ac2347cc9ee9a2194e15ad38c3ef131)GetName()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Core.FormationClassExtensions.GetName | ( | this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a2c43c23adde5ccc64bb784f4bda929e1)GetLocalizedName()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.Core.FormationClassExtensions.GetLocalizedName | ( | this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a522dec4b96e0974c2849fa42dfc847c2)GetTroopUsageFlags()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) TaleWorlds.Core.FormationClassExtensions.GetTroopUsageFlags | ( | this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *troopClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#ad0c8b4142419660971878f2513187e63)GetTroopTypeForRegularFormation()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TroopType](namespace_tale_worlds_1_1_core.html#a5ecb53039bcaf288b346d49b66cd7f48) TaleWorlds.Core.FormationClassExtensions.GetTroopTypeForRegularFormation | ( | this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a0aca68878fb2d364796afea0398e3875)IsDefaultFormationClass()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Core.FormationClassExtensions.IsDefaultFormationClass | ( | this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a9c419ee0e2198507865c88cb0c999934)IsRegularFormationClass()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Core.FormationClassExtensions.IsRegularFormationClass | ( | this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#aa0ae0fa559def73e9ee6b0287ea69a09)FallbackClass()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) TaleWorlds.Core.FormationClassExtensions.FallbackClass | ( | this [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass* | ) |  | | static |

Returns a formation's fallback class. Regular formations map to their default counterparts. Non-regular and non-default formations (i.e. Bodyguard and General) map to Infantry.

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#ad6f76b613305344325d49736f4c0da09)DefaultInfantryTroopUsageFlags
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) TaleWorlds.Core.FormationClassExtensions.DefaultInfantryTroopUsageFlags | | static |

**Initial value:**

= [TroopUsageFlags.OnFoot](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba337bdda6efedce719af876896355af7f) | [TroopUsageFlags.Melee](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872abafcbd772e48c4b07d7d3be13b37a82f5e)

| [TroopUsageFlags.OneHandedUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba5e3085a600f8e25c0bb9940e6d7bc6d4) | [TroopUsageFlags.TwoHandedUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba9427acb68a20d97d3366cf890234f6c1) | [TroopUsageFlags.PolearmUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba3bde32fa6dd4fe9825e299b54b5c7fbb) | [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab).ShieldUser

[TaleWorlds.Core.TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab)

TroopUsageFlags

**Definition** FormationClass.cs:43

[TaleWorlds.Core.TroopUsageFlags.OnFoot](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba337bdda6efedce719af876896355af7f)

@ OnFoot

**Definition** FormationClass.cs:45

[TaleWorlds.Core.TroopUsageFlags.PolearmUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba3bde32fa6dd4fe9825e299b54b5c7fbb)

@ PolearmUser

**Definition** FormationClass.cs:52

[TaleWorlds.Core.TroopUsageFlags.OneHandedUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba5e3085a600f8e25c0bb9940e6d7bc6d4)

@ OneHandedUser

**Definition** FormationClass.cs:49

[TaleWorlds.Core.TroopUsageFlags.TwoHandedUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba9427acb68a20d97d3366cf890234f6c1)

@ TwoHandedUser

**Definition** FormationClass.cs:51

[TaleWorlds.Core.TroopUsageFlags.Melee](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872abafcbd772e48c4b07d7d3be13b37a82f5e)

@ Melee

**Definition** FormationClass.cs:47

[◆](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#aca9ff0bc3ddb0506280f9af9b48c7a30)DefaultRangedTroopUsageFlags
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) TaleWorlds.Core.FormationClassExtensions.DefaultRangedTroopUsageFlags | | static |

**Initial value:**

= [TroopUsageFlags.OnFoot](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba337bdda6efedce719af876896355af7f) | [TroopUsageFlags.Ranged](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872abac2f329a17c18a701dbe1e96e03858728)

| [TroopUsageFlags.BowUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba522d5b7c1083fca7c9084d5d071b044a) | [TroopUsageFlags.CrossbowUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872abac2c75a973e0b18b3a614d18c0c27e317) | [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab).ThrownUser

[TaleWorlds.Core.TroopUsageFlags.BowUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba522d5b7c1083fca7c9084d5d071b044a)

@ BowUser

**Definition** FormationClass.cs:53

[TaleWorlds.Core.TroopUsageFlags.CrossbowUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872abac2c75a973e0b18b3a614d18c0c27e317)

@ CrossbowUser

**Definition** FormationClass.cs:55

[TaleWorlds.Core.TroopUsageFlags.Ranged](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872abac2f329a17c18a701dbe1e96e03858728)

@ Ranged

**Definition** FormationClass.cs:48

[◆](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a16a86547e18c0cc7dd8aa2040b875a78)DefaultCavalryTroopUsageFlags
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) TaleWorlds.Core.FormationClassExtensions.DefaultCavalryTroopUsageFlags | | static |

**Initial value:**

= [TroopUsageFlags.Mounted](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872abaab4e7334a8f96cc4068b7de43e57b9e4) | [TroopUsageFlags.Melee](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872abafcbd772e48c4b07d7d3be13b37a82f5e)

| [TroopUsageFlags.OneHandedUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba5e3085a600f8e25c0bb9940e6d7bc6d4) | [TroopUsageFlags.TwoHandedUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba9427acb68a20d97d3366cf890234f6c1) | [TroopUsageFlags.PolearmUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba3bde32fa6dd4fe9825e299b54b5c7fbb) | [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab).ShieldUser

[TaleWorlds.Core.TroopUsageFlags.Mounted](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872abaab4e7334a8f96cc4068b7de43e57b9e4)

@ Mounted

**Definition** FormationClass.cs:46

[◆](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#ac679bc8a111f85a3b018bb5dc34347a7)DefaultHorseArcherTroopUsageFlags
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab) TaleWorlds.Core.FormationClassExtensions.DefaultHorseArcherTroopUsageFlags | | static |

**Initial value:**

= [TroopUsageFlags.Mounted](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872abaab4e7334a8f96cc4068b7de43e57b9e4) | [TroopUsageFlags.Ranged](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872abac2f329a17c18a701dbe1e96e03858728)

| [TroopUsageFlags.BowUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872aba522d5b7c1083fca7c9084d5d071b044a) | [TroopUsageFlags.CrossbowUser](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872abac2c75a973e0b18b3a614d18c0c27e317) | [TroopUsageFlags](namespace_tale_worlds_1_1_core.html#a0a03cb213a208f99259f7310438872ab).ThrownUser

[◆](class_tale_worlds_1_1_core_1_1_formation_class_extensions.html#a5d3aa94c348dd72afe333d49a69eef8d)FormationClassValues
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) [] TaleWorlds.Core.FormationClassExtensions.FormationClassValues = ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90)[])Enum.GetValues(typeof([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90))) | | static |


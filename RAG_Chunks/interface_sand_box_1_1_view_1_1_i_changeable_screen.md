--- SOURCE: interface_sand_box_1_1_view_1_1_i_changeable_screen.html ---

SandBox.View.IChangeableScreen Interface ReferenceRepresents changeable screens. Basically screens with Reset, Cancel and Done.

Inherited by [SandBox.GauntletUI.GauntletCharacterDeveloperScreen](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_character_developer_screen.html), [SandBox.GauntletUI.GauntletInventoryScreen](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html), and [SandBox.GauntletUI.GauntletPartyScreen](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_party_screen.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [AnyUnsavedChanges](interface_sand_box_1_1_view_1_1_i_changeable_screen.html#a161c16a630dfcff9338b452336cfc827) () |
|  | Returns whether if the screen has unsaved changes at that time. Meaning, if the screen would change when pressed Reset. |
| bool | [CanChangesBeApplied](interface_sand_box_1_1_view_1_1_i_changeable_screen.html#a6ad9d2bf768bff29fc11a744a023acaf) () |
|  | Returns whether if the changes made in the screen can be applied by pressing done. |
| void | [ApplyChanges](interface_sand_box_1_1_view_1_1_i_changeable_screen.html#ac59c781aecfaed876c0ba24ec2d1d77a) () |
| void | [ResetChanges](interface_sand_box_1_1_view_1_1_i_changeable_screen.html#a33e726f41a85a6d2072377287cada7e8) () |

Member Function Documentation
-----------------------------

[◆](interface_sand_box_1_1_view_1_1_i_changeable_screen.html#a161c16a630dfcff9338b452336cfc827)AnyUnsavedChanges()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.View.IChangeableScreen.AnyUnsavedChanges | ( |  | ) |  |

Returns
:   Is there any unsaved changes at this time

[◆](interface_sand_box_1_1_view_1_1_i_changeable_screen.html#a6ad9d2bf768bff29fc11a744a023acaf)CanChangesBeApplied()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.View.IChangeableScreen.CanChangesBeApplied | ( |  | ) |  |

[◆](interface_sand_box_1_1_view_1_1_i_changeable_screen.html#ac59c781aecfaed876c0ba24ec2d1d77a)ApplyChanges()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.IChangeableScreen.ApplyChanges | ( |  | ) |  |

[◆](interface_sand_box_1_1_view_1_1_i_changeable_screen.html#a33e726f41a85a6d2072377287cada7e8)ResetChanges()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.View.IChangeableScreen.ResetChanges | ( |  | ) |  |


--- SOURCE: interface_tale_worlds_1_1_library_1_1_i_serializable_object.html ---

TaleWorlds.Library.ISerializableObject Interface ReferenceInherited by [TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html), [TaleWorlds.CampaignSystem.Party.PartyScreenLogic.PartyCommand](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_screen_logic_1_1_party_command.html), [TaleWorlds.CampaignSystem.Roster.ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html), [TaleWorlds.CampaignSystem.Roster.TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html), [TaleWorlds.CampaignSystem.Roster.TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html), [TaleWorlds.Core.EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html), [TaleWorlds.Core.ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), [TaleWorlds.Core.MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html), [TaleWorlds.Core.StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html), and [TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [DeserializeFrom](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aaaf5181fea51c7c2d4e365efe82bc703) ([IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) reader) |
| void | [SerializeTo](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aac913af86c2a4128993048fc2023b4de) ([IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) writer) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aaaf5181fea51c7c2d4e365efe82bc703)DeserializeFrom()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.ISerializableObject.DeserializeFrom | ( | [IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) | *reader* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#ad2f4332cc5f661dfb6fabdccf745961c), [TaleWorlds.CampaignSystem.Roster.TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#a081216b4559cf54585841a5a408a6322), [TaleWorlds.Core.EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html#ae8892395a86d7f241193af94dde1c421), [TaleWorlds.Core.ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a8843f62f01ab5f6d9d54d297c74df698), [TaleWorlds.Core.MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#afb652aa531dc2ed1c8a0fdb18b4a542f), [TaleWorlds.Core.StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a6700aaf7b2d352370a0460ff03dce52f), and [TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a128b5366a2a10a739cc5be09cc451632).

[◆](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aac913af86c2a4128993048fc2023b4de)SerializeTo()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.ISerializableObject.SerializeTo | ( | [IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) | *writer* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Conversation.ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html#a7a897caad0355f8ee96020e59d2b1c51), [TaleWorlds.CampaignSystem.Roster.TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html#acf17971ce0cf5d2e93ea7a70069db5bb), [TaleWorlds.Core.EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html#a9f2329bd5bc55b2959e625e5968371f1), [TaleWorlds.Core.ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a1c1b397e143c857ac5727c8f393db9ee), [TaleWorlds.Core.MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html#a100b6f27b2b7023660bc61ba107a0fa5), [TaleWorlds.Core.StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a9c8add59978856b59a6a56a43a586179), and [TaleWorlds.Core.ViewModelCollection.Information.TooltipProperty](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_tooltip_property.html#a3b9c20747f0ce59139df567e94b0ccf4).


--- SOURCE: class_tale_worlds_1_1_engine_1_1_music.html ---

TaleWorlds.Engine.Music Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static int | [GetFreeMusicChannelIndex](class_tale_worlds_1_1_engine_1_1_music.html#aab74c9af01f05f9cdcadc6c8a99a6985) () |
| static void | [LoadClip](class_tale_worlds_1_1_engine_1_1_music.html#a8dc2af04fc0da2b5cd535968119f4065) (int index, string pathToClip) |
| static void | [UnloadClip](class_tale_worlds_1_1_engine_1_1_music.html#a04a34dc8f2779dc10bb34a280df31df7) (int index) |
| static bool | [IsClipLoaded](class_tale_worlds_1_1_engine_1_1_music.html#a550b0fb127b0db44f4d7c6748549e979) (int index) |
| static void | [PlayMusic](class_tale_worlds_1_1_engine_1_1_music.html#a5886ea5234023cc6186f5b22ad869b62) (int index) |
| static void | [PlayDelayed](class_tale_worlds_1_1_engine_1_1_music.html#ae78a2a1053a0f5c84c2983f39542919d) (int index, int deltaMilliseconds) |
| static bool | [IsMusicPlaying](class_tale_worlds_1_1_engine_1_1_music.html#aa9e420a876c551bad756a0a98217ef62) (int index) |
| static void | [PauseMusic](class_tale_worlds_1_1_engine_1_1_music.html#a4a9e44a963718f847443273abd64ebcf) (int index) |
| static void | [StopMusic](class_tale_worlds_1_1_engine_1_1_music.html#a1014d8926089cd889316e93804e48191) (int index) |
| static void | [SetVolume](class_tale_worlds_1_1_engine_1_1_music.html#a9e95844f0a5f60f4b97505470ae40544) (int index, float volume) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_music.html#aab74c9af01f05f9cdcadc6c8a99a6985)GetFreeMusicChannelIndex()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Music.GetFreeMusicChannelIndex | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_music.html#a8dc2af04fc0da2b5cd535968119f4065)LoadClip()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Music.LoadClip | ( | int | *index*, | |  |  | string | *pathToClip* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_music.html#a04a34dc8f2779dc10bb34a280df31df7)UnloadClip()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Music.UnloadClip | ( | int | *index* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_music.html#a550b0fb127b0db44f4d7c6748549e979)IsClipLoaded()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Music.IsClipLoaded | ( | int | *index* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_music.html#a5886ea5234023cc6186f5b22ad869b62)PlayMusic()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Music.PlayMusic | ( | int | *index* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_music.html#ae78a2a1053a0f5c84c2983f39542919d)PlayDelayed()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Music.PlayDelayed | ( | int | *index*, | |  |  | int | *deltaMilliseconds* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_music.html#aa9e420a876c551bad756a0a98217ef62)IsMusicPlaying()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Music.IsMusicPlaying | ( | int | *index* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_music.html#a4a9e44a963718f847443273abd64ebcf)PauseMusic()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Music.PauseMusic | ( | int | *index* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_music.html#a1014d8926089cd889316e93804e48191)StopMusic()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Music.StopMusic | ( | int | *index* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_music.html#a9e95844f0a5f60f4b97505470ae40544)SetVolume()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Music.SetVolume | ( | int | *index*, | |  |  | float | *volume* ) | | static |


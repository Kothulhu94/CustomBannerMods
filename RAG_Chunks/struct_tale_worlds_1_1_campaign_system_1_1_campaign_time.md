--- SOURCE: struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html ---

TaleWorlds.CampaignSystem.CampaignTime Struct ReferenceInherits IComparable.

|  |  |
| --- | --- |
| Public Types | |
| enum | [Seasons](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a57048cef2d18a44c7de909de734ba515) {     [Spring](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a57048cef2d18a44c7de909de734ba515a38008dd81c2f4d7985ecf6e0ce8af1d1) = 0 ,     [Summer](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a57048cef2d18a44c7de909de734ba515a95884b5232ea01d055768613fc84f242) = 1 ,     [Autumn](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a57048cef2d18a44c7de909de734ba515a1e3576c804bb2b1cbf66a87b70b53ba8) = 2 ,     [Winter](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a57048cef2d18a44c7de909de734ba515ab18e66b41efd9a3df1a7bc8758da1883) = 3   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [Equals](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a0ef8ff80101596cfa9b9de6ba35aa04d) (CampaignTime other) |
| override bool | [Equals](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ad82fe2ffb39de6e7d549134325be90f9) (object obj) |
| override int | [GetHashCode](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#abc86f15a70c59ee891771d252b779e7e) () |
| int | [CompareTo](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#af951df836e37e122071c8d3b93ea0bbc) (CampaignTime other) |
| bool | [StringSameAs](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ad8b928662b4e2921d2cbcc106f03c2c6) (CampaignTime otherTime) |
| override string | [ToString](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a83c9500131b6f5bf1dcc12d32087dc98) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [Initialize](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#adb66be445bd42bae437f3023f9a3b718) () |
| static bool | [operator<](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ac4358f05c5f9f46643748e20437ea74d) (CampaignTime x, CampaignTime y) |
| static bool | [operator>](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aed09bb970bc3c9fddfecd1443e4ae686) (CampaignTime x, CampaignTime y) |
| static bool | [operator==](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a177259fa0e62aa83934827f1254e2a2e) (CampaignTime x, CampaignTime y) |
| static bool | [operator!=](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a30e39cd2937b13afb8355b99af69f2da) (CampaignTime x, CampaignTime y) |
| static bool | [operator<=](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a731bb34e998c4df079dae80145860824) (CampaignTime x, CampaignTime y) |
| static bool | [operator>=](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a9e943b9b3c1f62449d44a712cbc12e8c) (CampaignTime x, CampaignTime y) |
| static CampaignTime | [Milliseconds](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a6ea8c8887ebbb0669a0ba83a39e60d91) (long valueInMilliseconds) |
| static CampaignTime | [MillisecondsFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ab558fd1cd8a0c14973e5014b7bd34274) (long valueInMilliseconds) |
| static CampaignTime | [Seconds](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a52fb4d9cc741f7de1b3caa7e609e71bf) (long valueInSeconds) |
| static CampaignTime | [SecondsFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a13df42f5f7d63dfbd13c48384b94ec08) (long valueInSeconds) |
| static CampaignTime | [Minutes](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a1001d8fa32936ee704f1a8ab0049ab85) (long valueInMinutes) |
| static CampaignTime | [MinutesFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a7d456a194313dcd6616f73c2eb11a70a) (long valueInMinutes) |
| static CampaignTime | [Hours](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a5883dd6a6926a53b1725a470b9b6d350) (float valueInHours) |
| static CampaignTime | [HoursFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a33ad77f8d5608a40dffcd8e923256241) (float valueInHours) |
| static CampaignTime | [Days](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a7e91470785cb6f316038c2f4d4b7c7e4) (float valueInDays) |
| static CampaignTime | [DaysFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#afac59d285a50a62a0a57229c8f78c440) (float valueInDays) |
| static CampaignTime | [Weeks](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a202d04216403cedaf79f9dd2c36e6140) (float valueInWeeks) |
| static CampaignTime | [WeeksFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ab9cd8bf8d5e2f52344a72b1ed4da4f8c) (float valueInWeeks) |
| static CampaignTime | [Years](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aefd0d9f0d2456dc35c7be8a20ab71100) (float valueInYears) |
| static CampaignTime | [YearsFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ad07c9e98ffcb0dc9552c25942addfe33) (float valueInYears) |
| static CampaignTime | [operator+](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a8c6956214ee2cdaeac15ee0fd2d5c49d) (CampaignTime g1, CampaignTime g2) |
| static CampaignTime | [operator-](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a15bfb6a2d1f753d9e18068cda7c157ce) (CampaignTime g1, CampaignTime g2) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static int | [SunRise](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a40f13009a96f316ba8e11ec7068fbcff) |
| static int | [SunSet](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ad8ce1555e79d9245745299a6b8ec13a4) |
| static int | [MillisecondInSecond](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a40c156aa9a0c0d3a782cb00743e58862) |
| static int | [SecondsInMinute](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aba41094d7078d2292ca76729dc34da20) |
| static int | [MinutesInHour](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a0ee411cefabe49eb00ca7b8ff13521bc) |
| static int | [HoursInDay](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a38e18aeda8e28b8c536be5b0842f87a5) |
| static int | [DaysInWeek](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a563ba4ec64ae0ce75576895fe051169a) |
| static int | [WeeksInSeason](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ade45d1087442321a9c408e652af76ed7) |
| static int | [SeasonsInYear](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aa9f4e7f830f560afd684808af3686686) |

|  |  |
| --- | --- |
| Properties | |
| static int | [DaysInSeason](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a34c55411ad68ca39ad224d95aea3d508) `[get]` |
| static int | [DaysInYear](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a2c1508cc2f45cc61667edc01a5e6040c) `[get]` |
| static CampaignTime | [DeltaTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aa50291dacb027e9652f1733a82f34ac4) `[get]` |
| static CampaignTime | [Now](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a7f2a79d217c196a3d8a1848cd91a98af) `[get]` |
| static CampaignTime | [Never](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a6e17420a28b30292af695533589b8387) `[get]` |
| bool | [IsFuture](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a4c2e4595ec571cf98b9b94f0872e5f32) `[get]` |
| bool | [IsPast](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a064fb324651206b5812a71ac62be1427) `[get]` |
| bool | [IsNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a1eacadd6d04a2a7aedc6b64f54a4aa83) `[get]` |
| bool | [IsDayTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ae95180e32a4f850448f437eba4f5d352) `[get]` |
| float | [CurrentHourInDay](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a6d048bb7f1e132ea3d336c2ddcf320b8) `[get]` |
| bool | [IsNightTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aa706453621247356cc1a87e78e65d5c9) `[get]` |
| float | [ElapsedMillisecondsUntilNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a3cc62b2bde67fcd5960e16ee361f12d7) `[get]` |
| float | [ElapsedSecondsUntilNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#adbfd17dffd078da2fa672d35611be690) `[get]` |
| float | [ElapsedHoursUntilNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a41e52e7d8d7334ed739205b5aed12b16) `[get]` |
| float | [ElapsedDaysUntilNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a987bc531aec7471e57c48aaafb20a947) `[get]` |
| float | [ElapsedWeeksUntilNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ad9310a470d4708a179cd895efd28a936) `[get]` |
| float | [ElapsedSeasonsUntilNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#afef9aaf67d5d1e289500668338d20df4) `[get]` |
| float | [ElapsedYearsUntilNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a2170745f4d8f0a8b16d8fd410011eddd) `[get]` |
| float | [RemainingMillisecondsFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#af296a830f7dbd9d5af302f6bc882bccb) `[get]` |
| float | [RemainingSecondsFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aa1a7e3a6ebd4cb274284f0d50342d79f) `[get]` |
| float | [RemainingHoursFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ad1f53e052a7b34a92f788e84432df0e3) `[get]` |
| float | [RemainingDaysFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#afb0ec37a5fedc035bbc286663cdcea19) `[get]` |
| float | [RemainingWeeksFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a63fed81123657455b9ce16e07b2aecde) `[get]` |
| float | [RemainingSeasonsFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a963bd7f46fd74d1a97d008871bddb538) `[get]` |
| float | [RemainingYearsFromNow](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ae36f47cabee9614df0051166cb98ef09) `[get]` |
| double | [ToMilliseconds](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a000161c46d693012300b837962bbf33f) `[get]` |
| double | [ToSeconds](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#abb079739bd6c80ee6b8db262a1b8326f) `[get]` |
| double | [ToMinutes](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a0d2bc4a6d621d5e84c5cb85d285b358f) `[get]` |
| double | [ToHours](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a9ccef924569144379a100664fc7c410e) `[get]` |
| double | [ToDays](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a63d4b4577a77f467674f04898228f4c5) `[get]` |
| double | [ToWeeks](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a254f360f1b4ce9c270a2dad23cc1fcd4) `[get]` |
| double | [ToSeasons](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a9c2399d3a43d38d8b3cc5b71c6551e11) `[get]` |
| double | [ToYears](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ae4a912208d0cd055196a36f8186d8c6e) `[get]` |
| int | [GetHourOfDay](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a6dff3e14981b7c2f6710b3ff89828696) `[get]` |
| int | [GetDayOfWeek](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a02ff0b4b8d05b754a0b1051301f07c65) `[get]` |
| int | [GetDayOfSeason](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aa2a99504eb59b2f3ae9ce23a635803e5) `[get]` |
| int | [GetDayOfYear](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#adb0f0712328ce3cdb582827b993d45ca) `[get]` |
| int | [GetWeekOfSeason](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a238ca7fcc61bb7d3c625563b82f830d1) `[get]` |
| [Seasons](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a57048cef2d18a44c7de909de734ba515) | [GetSeasonOfYear](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a3a957b0bc7f100bffc4e82e656646359) `[get]` |
| int | [GetYear](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ae61ecf97afc2c251fe053bab9be5d5bb) `[get]` |
| static CampaignTime | [Zero](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a4a9e01e38a255d6f60447d96049a68a5) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a57048cef2d18a44c7de909de734ba515)Seasons
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.CampaignTime.Seasons](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a57048cef2d18a44c7de909de734ba515) |

| Enumerator | |
| --- | --- |
| Spring |  |
| Summer |  |
| Autumn |  |
| Winter |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#adb66be445bd42bae437f3023f9a3b718)Initialize()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignTime.Initialize | ( |  | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a0ef8ff80101596cfa9b9de6ba35aa04d)Equals() [1/2]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignTime.Equals | ( | CampaignTime | *other* | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ad82fe2ffb39de6e7d549134325be90f9)Equals() [2/2]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.CampaignTime.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#abc86f15a70c59ee891771d252b779e7e)GetHashCode()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.CampaignTime.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#af951df836e37e122071c8d3b93ea0bbc)CompareTo()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignTime.CompareTo | ( | CampaignTime | *other* | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ac4358f05c5f9f46643748e20437ea74d)operator<()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignTime.operator< | ( | CampaignTime | *x*, | |  |  | CampaignTime | *y* ) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aed09bb970bc3c9fddfecd1443e4ae686)operator>()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignTime.operator> | ( | CampaignTime | *x*, | |  |  | CampaignTime | *y* ) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a177259fa0e62aa83934827f1254e2a2e)operator==()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignTime.operator== | ( | CampaignTime | *x*, | |  |  | CampaignTime | *y* ) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a30e39cd2937b13afb8355b99af69f2da)operator!=()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignTime.operator!= | ( | CampaignTime | *x*, | |  |  | CampaignTime | *y* ) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a731bb34e998c4df079dae80145860824)operator<=()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignTime.operator<= | ( | CampaignTime | *x*, | |  |  | CampaignTime | *y* ) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a9e943b9b3c1f62449d44a712cbc12e8c)operator>=()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.CampaignTime.operator>= | ( | CampaignTime | *x*, | |  |  | CampaignTime | *y* ) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a6ea8c8887ebbb0669a0ba83a39e60d91)Milliseconds()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.Milliseconds | ( | long | *valueInMilliseconds* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ab558fd1cd8a0c14973e5014b7bd34274)MillisecondsFromNow()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.MillisecondsFromNow | ( | long | *valueInMilliseconds* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a52fb4d9cc741f7de1b3caa7e609e71bf)Seconds()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.Seconds | ( | long | *valueInSeconds* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a13df42f5f7d63dfbd13c48384b94ec08)SecondsFromNow()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.SecondsFromNow | ( | long | *valueInSeconds* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a1001d8fa32936ee704f1a8ab0049ab85)Minutes()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.Minutes | ( | long | *valueInMinutes* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a7d456a194313dcd6616f73c2eb11a70a)MinutesFromNow()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.MinutesFromNow | ( | long | *valueInMinutes* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a5883dd6a6926a53b1725a470b9b6d350)Hours()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.Hours | ( | float | *valueInHours* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a33ad77f8d5608a40dffcd8e923256241)HoursFromNow()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.HoursFromNow | ( | float | *valueInHours* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a7e91470785cb6f316038c2f4d4b7c7e4)Days()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.Days | ( | float | *valueInDays* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#afac59d285a50a62a0a57229c8f78c440)DaysFromNow()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.DaysFromNow | ( | float | *valueInDays* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a202d04216403cedaf79f9dd2c36e6140)Weeks()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.Weeks | ( | float | *valueInWeeks* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ab9cd8bf8d5e2f52344a72b1ed4da4f8c)WeeksFromNow()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.WeeksFromNow | ( | float | *valueInWeeks* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aefd0d9f0d2456dc35c7be8a20ab71100)Years()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.Years | ( | float | *valueInYears* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ad07c9e98ffcb0dc9552c25942addfe33)YearsFromNow()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.YearsFromNow | ( | float | *valueInYears* | ) |  | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a8c6956214ee2cdaeac15ee0fd2d5c49d)operator+()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.operator+ | ( | CampaignTime | *g1*, | |  |  | CampaignTime | *g2* ) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a15bfb6a2d1f753d9e18068cda7c157ce)operator-()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.operator- | ( | CampaignTime | *g1*, | |  |  | CampaignTime | *g2* ) | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ad8b928662b4e2921d2cbcc106f03c2c6)StringSameAs()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignTime.StringSameAs | ( | CampaignTime | *otherTime* | ) |  |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a83c9500131b6f5bf1dcc12d32087dc98)ToString()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.CampaignTime.ToString | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a40f13009a96f316ba8e11ec7068fbcff)SunRise
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.SunRise | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ad8ce1555e79d9245745299a6b8ec13a4)SunSet
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.SunSet | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a40c156aa9a0c0d3a782cb00743e58862)MillisecondInSecond
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.MillisecondInSecond | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aba41094d7078d2292ca76729dc34da20)SecondsInMinute
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.SecondsInMinute | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a0ee411cefabe49eb00ca7b8ff13521bc)MinutesInHour
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.MinutesInHour | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a38e18aeda8e28b8c536be5b0842f87a5)HoursInDay
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.HoursInDay | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a563ba4ec64ae0ce75576895fe051169a)DaysInWeek
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.DaysInWeek | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ade45d1087442321a9c408e652af76ed7)WeeksInSeason
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.WeeksInSeason | | static |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aa9f4e7f830f560afd684808af3686686)SeasonsInYear
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.SeasonsInYear | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a34c55411ad68ca39ad224d95aea3d508)DaysInSeason
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.DaysInSeason | | staticget |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a2c1508cc2f45cc61667edc01a5e6040c)DaysInYear
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.DaysInYear | | staticget |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aa50291dacb027e9652f1733a82f34ac4)DeltaTime
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.DeltaTime | | staticget |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a7f2a79d217c196a3d8a1848cd91a98af)Now
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.Now | | staticget |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a6e17420a28b30292af695533589b8387)Never
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.Never | | staticget |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a4c2e4595ec571cf98b9b94f0872e5f32)IsFuture
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CampaignTime.IsFuture | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a064fb324651206b5812a71ac62be1427)IsPast
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CampaignTime.IsPast | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a1eacadd6d04a2a7aedc6b64f54a4aa83)IsNow
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CampaignTime.IsNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ae95180e32a4f850448f437eba4f5d352)IsDayTime
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CampaignTime.IsDayTime | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a6d048bb7f1e132ea3d336c2ddcf320b8)CurrentHourInDay
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.CurrentHourInDay | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aa706453621247356cc1a87e78e65d5c9)IsNightTime
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.CampaignTime.IsNightTime | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a3cc62b2bde67fcd5960e16ee361f12d7)ElapsedMillisecondsUntilNow
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.ElapsedMillisecondsUntilNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#adbfd17dffd078da2fa672d35611be690)ElapsedSecondsUntilNow
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.ElapsedSecondsUntilNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a41e52e7d8d7334ed739205b5aed12b16)ElapsedHoursUntilNow
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.ElapsedHoursUntilNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a987bc531aec7471e57c48aaafb20a947)ElapsedDaysUntilNow
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.ElapsedDaysUntilNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ad9310a470d4708a179cd895efd28a936)ElapsedWeeksUntilNow
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.ElapsedWeeksUntilNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#afef9aaf67d5d1e289500668338d20df4)ElapsedSeasonsUntilNow
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.ElapsedSeasonsUntilNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a2170745f4d8f0a8b16d8fd410011eddd)ElapsedYearsUntilNow
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.ElapsedYearsUntilNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#af296a830f7dbd9d5af302f6bc882bccb)RemainingMillisecondsFromNow
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.RemainingMillisecondsFromNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aa1a7e3a6ebd4cb274284f0d50342d79f)RemainingSecondsFromNow
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.RemainingSecondsFromNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ad1f53e052a7b34a92f788e84432df0e3)RemainingHoursFromNow
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.RemainingHoursFromNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#afb0ec37a5fedc035bbc286663cdcea19)RemainingDaysFromNow
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.RemainingDaysFromNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a63fed81123657455b9ce16e07b2aecde)RemainingWeeksFromNow
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.RemainingWeeksFromNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a963bd7f46fd74d1a97d008871bddb538)RemainingSeasonsFromNow
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.RemainingSeasonsFromNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ae36f47cabee9614df0051166cb98ef09)RemainingYearsFromNow
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.CampaignTime.RemainingYearsFromNow | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a000161c46d693012300b837962bbf33f)ToMilliseconds
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.CampaignSystem.CampaignTime.ToMilliseconds | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#abb079739bd6c80ee6b8db262a1b8326f)ToSeconds
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.CampaignSystem.CampaignTime.ToSeconds | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a0d2bc4a6d621d5e84c5cb85d285b358f)ToMinutes
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.CampaignSystem.CampaignTime.ToMinutes | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a9ccef924569144379a100664fc7c410e)ToHours
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.CampaignSystem.CampaignTime.ToHours | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a63d4b4577a77f467674f04898228f4c5)ToDays
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.CampaignSystem.CampaignTime.ToDays | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a254f360f1b4ce9c270a2dad23cc1fcd4)ToWeeks
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.CampaignSystem.CampaignTime.ToWeeks | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a9c2399d3a43d38d8b3cc5b71c6551e11)ToSeasons
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.CampaignSystem.CampaignTime.ToSeasons | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ae4a912208d0cd055196a36f8186d8c6e)ToYears
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.CampaignSystem.CampaignTime.ToYears | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a6dff3e14981b7c2f6710b3ff89828696)GetHourOfDay
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.GetHourOfDay | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a02ff0b4b8d05b754a0b1051301f07c65)GetDayOfWeek
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.GetDayOfWeek | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#aa2a99504eb59b2f3ae9ce23a635803e5)GetDayOfSeason
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.GetDayOfSeason | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#adb0f0712328ce3cdb582827b993d45ca)GetDayOfYear
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.GetDayOfYear | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a238ca7fcc61bb7d3c625563b82f830d1)GetWeekOfSeason
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.GetWeekOfSeason | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a3a957b0bc7f100bffc4e82e656646359)GetSeasonOfYear
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Seasons](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a57048cef2d18a44c7de909de734ba515) TaleWorlds.CampaignSystem.CampaignTime.GetSeasonOfYear | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#ae61ecf97afc2c251fe053bab9be5d5bb)GetYear
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.CampaignTime.GetYear | | get |

[◆](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a4a9e01e38a255d6f60447d96049a68a5)Zero
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CampaignTime TaleWorlds.CampaignSystem.CampaignTime.Zero | | staticget |


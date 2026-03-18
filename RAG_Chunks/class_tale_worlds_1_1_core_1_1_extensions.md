--- SOURCE: class_tale_worlds_1_1_core_1_1_extensions.html ---

TaleWorlds.Core.Extensions Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [ToHexadecimalString](class_tale_worlds_1_1_core_1_1_extensions.html#acac8d95284f902a30eaae57fda6e99f9) (this uint number) |
|  | Converts the numeric value of this instance to its equivalent hexadecimal string representation. |
| static string | [Description](class_tale_worlds_1_1_core_1_1_extensions.html#ac70265de8a7655230593ad0fa83faa86) (this Enum value) |
| static float | [NextFloat](class_tale_worlds_1_1_core_1_1_extensions.html#a79c6c61598e1a410ddb60c61d865b3dc) (this Random random) |
|  | Returns a random number between 0.0f and 1.0f. |
| static TSource | [MaxBy< TSource, TKey >](class_tale_worlds_1_1_core_1_1_extensions.html#a621a70659edc121d4a7df6b3dcd80fef) (this IEnumerable< TSource > source, Func< TSource, TKey > selector) |
|  | Returns the maximal element of the given sequence, based on the given projection. |
| static TSource | [MaxBy< TSource, TKey >](class_tale_worlds_1_1_core_1_1_extensions.html#ad6f8dab75415e9cd99be2f3bfeb8c3f8) (this IEnumerable< TSource > source, Func< TSource, TKey > selector, out TKey maxKey) |
|  | Returns the maximal element of the given sequence, based on the given projection. |
| static TSource | [MaxBy< TSource, TKey >](class_tale_worlds_1_1_core_1_1_extensions.html#a3f52932f797d2271b2390a3b3ce5a082) (this IEnumerable< TSource > source, Func< TSource, TKey > selector, IComparer< TKey > comparer, out TKey maxKey) |
|  | Returns the maximal element of the given sequence, based on the given projection and the specified comparer for projected values. |
| static TSource | [MinBy< TSource, TKey >](class_tale_worlds_1_1_core_1_1_extensions.html#ab9052fc730dd6ef7a9eaca1d9fe3cc9c) (this IEnumerable< TSource > source, Func< TSource, TKey > selector) |
|  | Returns the minimal element of the given sequence, based on the given projection. |
| static TSource | [MinBy< TSource, TKey >](class_tale_worlds_1_1_core_1_1_extensions.html#a238dfbdfb317d06166cf1ba1a1b4e677) (this IEnumerable< TSource > source, Func< TSource, TKey > selector, IComparer< TKey > comparer) |
|  | Returns the minimal element of the given sequence, based on the given projection and the specified comparer for projected values. |
| static IEnumerable< TSource > | [DistinctBy< TSource, TKey >](class_tale_worlds_1_1_core_1_1_extensions.html#a408647e6bbf839cdcef6777b72ae8e81) (this IEnumerable< TSource > source, Func< TSource, TKey > keySelector) |
|  | Returns all distinct elements of the given source, where "distinctness" is determined via a projection and the default equality comparer for the projected type. |
| static IEnumerable< TSource > | [DistinctBy< TSource, TKey >](class_tale_worlds_1_1_core_1_1_extensions.html#ae4d52e1520fce4bdd93d27b3dfabc17a) (this IEnumerable< TSource > source, Func< TSource, TKey > keySelector, IEqualityComparer< TKey > comparer) |
|  | Returns all distinct elements of the given source, where "distinctness" is determined via a projection and the specified comparer for the projected type. |
| static string | [Add](class_tale_worlds_1_1_core_1_1_extensions.html#a85598650282de08026419f0307521ef1) (this string str, string appendant, bool newLine=true) |
| static IEnumerable< string > | [Split](class_tale_worlds_1_1_core_1_1_extensions.html#a37d8d19260eab64ac822a67af43c5ba2) (this string str, int maxChunkSize) |
| static [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [GetOppositeSide](class_tale_worlds_1_1_core_1_1_extensions.html#a9de67b04e78f35aa9a531a66de8742b8) (this [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| static IEnumerable< IEnumerable< T > > | [Split< T >](class_tale_worlds_1_1_core_1_1_extensions.html#a078ffbbd6c2677410f46119260409e67) (this IEnumerable< T > source, int splitItemCount) |
| static bool | [IsEmpty< T >](class_tale_worlds_1_1_core_1_1_extensions.html#a616d99606274a9749969ca1dcad24a7f) (this IEnumerable< T > source) |
|  | If the sequence is empty or has an element. |
| static void | [Shuffle< T >](class_tale_worlds_1_1_core_1_1_extensions.html#a6c0987eeb9dc79a57b191a7d97e9f53e) (this IList< T > list) |
|  | Randomizes the list. |
| static T | [GetRandomElement< T >](class_tale_worlds_1_1_core_1_1_extensions.html#a23396757b2f8f25478f0642abbf301b3) (this IReadOnlyList< T > e) |
| static T | [GetRandomElement< T >](class_tale_worlds_1_1_core_1_1_extensions.html#aadaa89b67549ffab369bb663ee201880) (this MBReadOnlyList< T > e) |
| static T | [GetRandomElement< T >](class_tale_worlds_1_1_core_1_1_extensions.html#a48a0b0cd76903e7c079268c0d38574e9) (this MBList< T > e) |
| static T | [GetRandomElement< T >](class_tale_worlds_1_1_core_1_1_extensions.html#aceeaf51ac8fab0104a7eb4473af7fb6a) (this T[] e) |
| static T | [GetRandomElementInefficiently< T >](class_tale_worlds_1_1_core_1_1_extensions.html#ab0a9ed554b1c43da8f0b8623e52e5362) (this IEnumerable< T > e) |
| static T | [GetRandomElementWithPredicate< T >](class_tale_worlds_1_1_core_1_1_extensions.html#a49550407bfd3f01154704df1bead97eb) (this T[] e, Func< T, bool > predicate) |
| static T | [GetRandomElementWithPredicate< T >](class_tale_worlds_1_1_core_1_1_extensions.html#a699fc99bdea7ff4b14ae387f6e88dd55) (this MBReadOnlyList< T > e, Func< T, bool > predicate) |
| static T | [GetRandomElementWithPredicate< T >](class_tale_worlds_1_1_core_1_1_extensions.html#abb0e6d4128c25f4fc8add7201c059a2b) (this MBList< T > e, Func< T, bool > predicate) |
| static T | [GetRandomElementWithPredicate< T >](class_tale_worlds_1_1_core_1_1_extensions.html#a88b0223c29dc912f8cf623a0e9180eed) (this IReadOnlyList< T > e, Func< T, bool > predicate) |
| static List< Tuple< T1, T2 > > | [CombineWith< T1, T2 >](class_tale_worlds_1_1_core_1_1_extensions.html#ae7fa22f9ffb3896c7c512682ef4b77a1) (this IEnumerable< T1 > list1, IEnumerable< T2 > list2) |
|  | Generates the combinations of the two lists. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#acac8d95284f902a30eaae57fda6e99f9)ToHexadecimalString()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Core.Extensions.ToHexadecimalString | ( | this uint | *number* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | number |  |

Returns
:   (i.e. "FF00FF00")

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#ac70265de8a7655230593ad0fa83faa86)Description()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Core.Extensions.Description | ( | this Enum | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a79c6c61598e1a410ddb60c61d865b3dc)NextFloat()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Core.Extensions.NextFloat | ( | this Random | *random* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | random |  |

Returns

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a621a70659edc121d4a7df6b3dcd80fef)MaxBy< TSource, TKey >() [1/3]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TSource TaleWorlds.Core.Extensions.MaxBy< TSource, TKey > | ( | this IEnumerable< TSource > | *source*, | |  |  | Func< TSource, TKey > | *selector* ) | | static |

If more than one element has the maximal projected value, the first one encountered will be returned. This overload uses the default comparer for the projected type. This operator uses immediate execution, but only buffers a single result (the current maximal element).

Template Parameters
:   |  |  |
    | --- | --- |
    | TSource | Type of the source sequence |
    | TKey | Type of the projected element |

Parameters
:   |  |  |
    | --- | --- |
    | source | Source sequence |
    | selector | Selector to use to pick the results to compare |

Returns
:   The maximal element, according to the projection.

Exceptions
:   |  |  |
    | --- | --- |
    | ArgumentNullException | *source* or *selector* is null |
    | InvalidOperationException | *source* is empty |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#ad6f8dab75415e9cd99be2f3bfeb8c3f8)MaxBy< TSource, TKey >() [2/3]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TSource TaleWorlds.Core.Extensions.MaxBy< TSource, TKey > | ( | this IEnumerable< TSource > | *source*, | |  |  | Func< TSource, TKey > | *selector*, | |  |  | out TKey | *maxKey* ) | | static |

If more than one element has the maximal projected value, the first one encountered will be returned. This overload uses the default comparer for the projected type. This operator uses immediate execution, but only buffers a single result (the current maximal element).

Template Parameters
:   |  |  |
    | --- | --- |
    | TSource | Type of the source sequence |
    | TKey | Type of the projected element |

Parameters
:   |  |  |
    | --- | --- |
    | source | Source sequence |
    | selector | Selector to use to pick the results to compare |

Returns
:   The maximal element, according to the projection.

Exceptions
:   |  |  |
    | --- | --- |
    | ArgumentNullException | *source* or *selector* is null |
    | InvalidOperationException | *source* is empty |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a3f52932f797d2271b2390a3b3ce5a082)MaxBy< TSource, TKey >() [3/3]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TSource TaleWorlds.Core.Extensions.MaxBy< TSource, TKey > | ( | this IEnumerable< TSource > | *source*, | |  |  | Func< TSource, TKey > | *selector*, | |  |  | IComparer< TKey > | *comparer*, | |  |  | out TKey | *maxKey* ) | | static |

If more than one element has the maximal projected value, the first one encountered will be returned. This overload uses the default comparer for the projected type. This operator uses immediate execution, but only buffers a single result (the current maximal element).

Template Parameters
:   |  |  |
    | --- | --- |
    | TSource | Type of the source sequence |
    | TKey | Type of the projected element |

Parameters
:   |  |  |
    | --- | --- |
    | source | Source sequence |
    | selector | Selector to use to pick the results to compare |
    | comparer | Comparer to use to compare projected values |

Returns
:   The maximal element, according to the projection.

Exceptions
:   |  |  |
    | --- | --- |
    | ArgumentNullException | *source* , *selector* or *comparer* is null |
    | InvalidOperationException | *source* is empty |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#ab9052fc730dd6ef7a9eaca1d9fe3cc9c)MinBy< TSource, TKey >() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TSource TaleWorlds.Core.Extensions.MinBy< TSource, TKey > | ( | this IEnumerable< TSource > | *source*, | |  |  | Func< TSource, TKey > | *selector* ) | | static |

If more than one element has the minimal projected value, the first one encountered will be returned. This overload uses the default comparer for the projected type. This operator uses immediate execution, but only buffers a single result (the current minimal element).

Template Parameters
:   |  |  |
    | --- | --- |
    | TSource | Type of the source sequence |
    | TKey | Type of the projected element |

Parameters
:   |  |  |
    | --- | --- |
    | source | Source sequence |
    | selector | Selector to use to pick the results to compare |

Returns
:   The minimal element, according to the projection.

Exceptions
:   |  |  |
    | --- | --- |
    | ArgumentNullException | *source* or *selector* is null |
    | InvalidOperationException | *source* is empty |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a238dfbdfb317d06166cf1ba1a1b4e677)MinBy< TSource, TKey >() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TSource TaleWorlds.Core.Extensions.MinBy< TSource, TKey > | ( | this IEnumerable< TSource > | *source*, | |  |  | Func< TSource, TKey > | *selector*, | |  |  | IComparer< TKey > | *comparer* ) | | static |

If more than one element has the minimal projected value, the first one encountered will be returned. This overload uses the default comparer for the projected type. This operator uses immediate execution, but only buffers a single result (the current minimal element).

Template Parameters
:   |  |  |
    | --- | --- |
    | TSource | Type of the source sequence |
    | TKey | Type of the projected element |

Parameters
:   |  |  |
    | --- | --- |
    | source | Source sequence |
    | selector | Selector to use to pick the results to compare |
    | comparer | Comparer to use to compare projected values |

Returns
:   The minimal element, according to the projection.

Exceptions
:   |  |  |
    | --- | --- |
    | ArgumentNullException | *source* , *selector* or *comparer* is null |
    | InvalidOperationException | *source* is empty |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a408647e6bbf839cdcef6777b72ae8e81)DistinctBy< TSource, TKey >() [1/2]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< TSource > TaleWorlds.Core.Extensions.DistinctBy< TSource, TKey > | ( | this IEnumerable< TSource > | *source*, | |  |  | Func< TSource, TKey > | *keySelector* ) | | static |

This operator uses deferred execution and streams the results, although a set of already-seen keys is retained. If a key is seen multiple times, only the first element with that key is returned.

Template Parameters
:   |  |  |
    | --- | --- |
    | TSource | Type of the source sequence |
    | TKey | Type of the projected element |

Parameters
:   |  |  |
    | --- | --- |
    | source | Source sequence |
    | keySelector | Projection for determining "distinctness" |

Returns
:   A sequence consisting of distinct elements from the source sequence, comparing them by the specified key projection.

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#ae4d52e1520fce4bdd93d27b3dfabc17a)DistinctBy< TSource, TKey >() [2/2]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< TSource > TaleWorlds.Core.Extensions.DistinctBy< TSource, TKey > | ( | this IEnumerable< TSource > | *source*, | |  |  | Func< TSource, TKey > | *keySelector*, | |  |  | IEqualityComparer< TKey > | *comparer* ) | | static |

This operator uses deferred execution and streams the results, although a set of already-seen keys is retained. If a key is seen multiple times, only the first element with that key is returned.

Template Parameters
:   |  |  |
    | --- | --- |
    | TSource | Type of the source sequence |
    | TKey | Type of the projected element |

Parameters
:   |  |  |
    | --- | --- |
    | source | Source sequence |
    | keySelector | Projection for determining "distinctness" |
    | comparer | The equality comparer to use to determine whether or not keys are equal. If null, the default equality comparer for `TSource` is used. |

Returns
:   A sequence consisting of distinct elements from the source sequence, comparing them by the specified key projection.

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a85598650282de08026419f0307521ef1)Add()
------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.Core.Extensions.Add | ( | this string | *str*, | |  |  | string | *appendant*, | |  |  | bool | *newLine* = true ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a37d8d19260eab64ac822a67af43c5ba2)Split()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< string > TaleWorlds.Core.Extensions.Split | ( | this string | *str*, | |  |  | int | *maxChunkSize* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a9de67b04e78f35aa9a531a66de8742b8)GetOppositeSide()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.Core.Extensions.GetOppositeSide | ( | this [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a078ffbbd6c2677410f46119260409e67)Split< T >()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< IEnumerable< T > > [TaleWorlds.Core.Extensions.Split](class_tale_worlds_1_1_core_1_1_extensions.html#a37d8d19260eab64ac822a67af43c5ba2)< T > | ( | this IEnumerable< T > | *source*, | |  |  | int | *splitItemCount* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a616d99606274a9749969ca1dcad24a7f)IsEmpty< T >()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Core.Extensions.IsEmpty< T > | ( | this IEnumerable< T > | *source* | ) |  | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | T |  |

Parameters
:   |  |  |
    | --- | --- |
    | source |  |

Returns

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a6c0987eeb9dc79a57b191a7d97e9f53e)Shuffle< T >()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Core.Extensions.Shuffle< T > | ( | this IList< T > | *list* | ) |  | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | T |  |

Parameters
:   |  |  |
    | --- | --- |
    | list |  |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a23396757b2f8f25478f0642abbf301b3)GetRandomElement< T >() [1/4]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T TaleWorlds.Core.Extensions.GetRandomElement< T > | ( | this IReadOnlyList< T > | *e* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#aadaa89b67549ffab369bb663ee201880)GetRandomElement< T >() [2/4]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T TaleWorlds.Core.Extensions.GetRandomElement< T > | ( | this MBReadOnlyList< T > | *e* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a48a0b0cd76903e7c079268c0d38574e9)GetRandomElement< T >() [3/4]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T TaleWorlds.Core.Extensions.GetRandomElement< T > | ( | this MBList< T > | *e* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#aceeaf51ac8fab0104a7eb4473af7fb6a)GetRandomElement< T >() [4/4]
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T TaleWorlds.Core.Extensions.GetRandomElement< T > | ( | this T[] | *e* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#ab0a9ed554b1c43da8f0b8623e52e5362)GetRandomElementInefficiently< T >()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T TaleWorlds.Core.Extensions.GetRandomElementInefficiently< T > | ( | this IEnumerable< T > | *e* | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a49550407bfd3f01154704df1bead97eb)GetRandomElementWithPredicate< T >() [1/4]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | T TaleWorlds.Core.Extensions.GetRandomElementWithPredicate< T > | ( | this T[] | *e*, | |  |  | Func< T, bool > | *predicate* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a699fc99bdea7ff4b14ae387f6e88dd55)GetRandomElementWithPredicate< T >() [2/4]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | T TaleWorlds.Core.Extensions.GetRandomElementWithPredicate< T > | ( | this MBReadOnlyList< T > | *e*, | |  |  | Func< T, bool > | *predicate* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#abb0e6d4128c25f4fc8add7201c059a2b)GetRandomElementWithPredicate< T >() [3/4]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | T TaleWorlds.Core.Extensions.GetRandomElementWithPredicate< T > | ( | this MBList< T > | *e*, | |  |  | Func< T, bool > | *predicate* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#a88b0223c29dc912f8cf623a0e9180eed)GetRandomElementWithPredicate< T >() [4/4]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | T TaleWorlds.Core.Extensions.GetRandomElementWithPredicate< T > | ( | this IReadOnlyList< T > | *e*, | |  |  | Func< T, bool > | *predicate* ) | | static |

[◆](class_tale_worlds_1_1_core_1_1_extensions.html#ae7fa22f9ffb3896c7c512682ef4b77a1)CombineWith< T1, T2 >()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List< Tuple< T1, T2 > > TaleWorlds.Core.Extensions.CombineWith< T1, T2 > | ( | this IEnumerable< T1 > | *list1*, | |  |  | IEnumerable< T2 > | *list2* ) | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | T1 |  |
    | T2 |  |

Parameters
:   |  |  |
    | --- | --- |
    | list1 |  |
    | list2 |  |

Returns


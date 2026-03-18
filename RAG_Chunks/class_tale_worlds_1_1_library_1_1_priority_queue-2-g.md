--- SOURCE: class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html ---

TaleWorlds.Library.PriorityQueue< TPriority, TValue > Class Template ReferencePriority queue based on binary heap, Elements with minimum priority dequeued first.
[More...](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#details)

Inherits ICollection.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603) () |
|  | Initializes a new instance of priority queue with default initial capacity and default priority comparer. |
|  | [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a1c510c2b06d3041ed59899f884bec37b) (int capacity) |
|  | Initializes a new instance of priority queue with specified initial capacity and default priority comparer. |
|  | [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a4fd2396296721309f410abfd68b1b191) (int capacity, IComparer< TPriority > comparer) |
|  | Initializes a new instance of priority queue with specified initial capacity and specified priority comparer. |
|  | [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#aa6d74f3e7901353a2d616955edbb65b6) (IComparer< TPriority > comparer) |
|  | Initializes a new instance of priority queue with default initial capacity and specified priority comparer. |
|  | [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a409f86d4cfdc840888934b3e88c988ea) (IEnumerable< KeyValuePair< TPriority, TValue > > data) |
|  | Initializes a new instance of priority queue with specified data and default priority comparer. |
|  | [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae83c1ce55a0d2712d57d471c07cf5738) (IEnumerable< KeyValuePair< TPriority, TValue > > data, IComparer< TPriority > comparer) |
|  | Initializes a new instance of priority queue with specified data and specified priority comparer. |
| void | [Enqueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a2adfee8bf95e17f0575eb51aef48d031) (TPriority priority, TValue value) |
|  | Enqueues element into priority queue. |
| KeyValuePair< TPriority, TValue > | [Dequeue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a26afa6b76fbdf79e79b1a533a5198e83) () |
|  | Dequeues element with minimum priority and return its priority and value as KeyValuePair<TPriority,TValue>. |
| TValue | [DequeueValue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a30ef4b8c8b038707373e784e96d032e8) () |
|  | Dequeues element with minimum priority and return its value. |
| KeyValuePair< TPriority, TValue > | [Peek](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#abf49f973e346859311194830022bf105) () |
|  | Returns priority and value of the element with minimun priority, without removing it from the queue. |
| TValue | [PeekValue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae77eec9f711e0ae5228819ea9e124a38) () |
|  | Returns value of the element with minimun priority, without removing it from the queue. |
| void | [Add](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae8a9f750cd5f668435b26e2f982bffcd) (KeyValuePair< TPriority, TValue > item) |
|  | Enqueues element into priority queue. |
| void | [Clear](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae63a710fa3e43afed6d5503472dfe09a) () |
|  | Clears the collection. |
| bool | [Contains](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#abd20532b5f4a8a72a85bf3a5c28f58d6) (KeyValuePair< TPriority, TValue > item) |
|  | Determines whether the priority queue contains a specific element. |
| void | [CopyTo](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ac8869ba333c02f47bfdcbca38f559fe0) (KeyValuePair< TPriority, TValue >[] array, int arrayIndex) |
|  | Copies the elements of the priority queue to an Array, starting at a particular Array index. |
| bool | [Remove](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a073087b4d81e2d65d2b045e1c1af5491) (KeyValuePair< TPriority, TValue > item) |
|  | Removes the first occurrence of a specific object from the priority queue. |
| IEnumerator< KeyValuePair< TPriority, TValue > > | [GetEnumerator](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#abb67dc3234aa9d5988fa4483e1de1b6e) () |
|  | Returns an enumerator that iterates through the collection. |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)< TPriority, TValue > | [MergeQueues](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a7279ab601efb443ac5261b193dbda450) ([PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)< TPriority, TValue > pq1, [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)< TPriority, TValue > pq2) |
|  | Merges two priority queues. |
| static [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)< TPriority, TValue > | [MergeQueues](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a08dd6b660988e3cce40a7726fc3f7eae) ([PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)< TPriority, TValue > pq1, [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)< TPriority, TValue > pq2, IComparer< TPriority > comparer) |
|  | Merges two priority queues and sets specified comparer for resultant priority queue. |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsEmpty](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#acda2b28cbf316f8fe6fa99ccce35cecb) `[get]` |
|  | Gets whether priority queue is empty. |
| int | [Count](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a63ef41238a728eafd7159f1151aaecb9) `[get]` |
|  | Gets number of elements in the priority queue. |
| bool | [IsReadOnly](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a2f32d6e2be7e0cd11757af6ff20a931d) `[get]` |
|  | Gets a value indicating whether the collection is read-only. |

Detailed Description
--------------------

Template Parameters
:   |  |  |
    | --- | --- |
    | TPriority | Type of priorities |
    | TValue | Type of values |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)PriorityQueue() [1/6]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Library.PriorityQueue< TPriority, TValue >.PriorityQueue | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a1c510c2b06d3041ed59899f884bec37b)PriorityQueue() [2/6]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.PriorityQueue< TPriority, TValue >.PriorityQueue | ( | int | *capacity* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | capacity | initial capacity |

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a4fd2396296721309f410abfd68b1b191)PriorityQueue() [3/6]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.PriorityQueue< TPriority, TValue >.PriorityQueue | ( | int | *capacity*, |
|  |  | IComparer< TPriority > | *comparer* ) |

Parameters
:   |  |  |
    | --- | --- |
    | capacity | initial capacity |
    | comparer | priority comparer |

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#aa6d74f3e7901353a2d616955edbb65b6)PriorityQueue() [4/6]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.PriorityQueue< TPriority, TValue >.PriorityQueue | ( | IComparer< TPriority > | *comparer* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | comparer | priority comparer |

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a409f86d4cfdc840888934b3e88c988ea)PriorityQueue() [5/6]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.PriorityQueue< TPriority, TValue >.PriorityQueue | ( | IEnumerable< KeyValuePair< TPriority, TValue > > | *data* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | data | data to be inserted into priority queue |

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae83c1ce55a0d2712d57d471c07cf5738)PriorityQueue() [6/6]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.PriorityQueue< TPriority, TValue >.PriorityQueue | ( | IEnumerable< KeyValuePair< TPriority, TValue > > | *data*, |
|  |  | IComparer< TPriority > | *comparer* ) |

Parameters
:   |  |  |
    | --- | --- |
    | data | data to be inserted into priority queue |
    | comparer | priority comparer |

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a7279ab601efb443ac5261b193dbda450)MergeQueues() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)< TPriority, TValue > TaleWorlds.Library.PriorityQueue< TPriority, TValue >.MergeQueues | ( | [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)< TPriority, TValue > | *pq1*, | |  |  | [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)< TPriority, TValue > | *pq2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | pq1 | first priority queue |
    | pq2 | second priority queue |

Returns
:   resultant priority queue

source priority queues must have equal comparers, otherwise InvalidOperationException will be thrown

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a08dd6b660988e3cce40a7726fc3f7eae)MergeQueues() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)< TPriority, TValue > TaleWorlds.Library.PriorityQueue< TPriority, TValue >.MergeQueues | ( | [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)< TPriority, TValue > | *pq1*, | |  |  | [PriorityQueue](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae5b8609ebd457315696b06e22059a603)< TPriority, TValue > | *pq2*, | |  |  | IComparer< TPriority > | *comparer* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | pq1 | first priority queue |
    | pq2 | second priority queue |
    | comparer | comparer for resultant priority queue |

Returns
:   resultant priority queue

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a2adfee8bf95e17f0575eb51aef48d031)Enqueue()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.PriorityQueue< TPriority, TValue >.Enqueue | ( | TPriority | *priority*, |
|  |  | TValue | *value* ) |

Parameters
:   |  |  |
    | --- | --- |
    | priority | element priority |
    | value | element value |

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a26afa6b76fbdf79e79b1a533a5198e83)Dequeue()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| KeyValuePair< TPriority, TValue > TaleWorlds.Library.PriorityQueue< TPriority, TValue >.Dequeue | ( |  | ) |  |

Returns
:   priority and value of the dequeued element

Method throws InvalidOperationException if priority queue is empty

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a30ef4b8c8b038707373e784e96d032e8)DequeueValue()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TValue TaleWorlds.Library.PriorityQueue< TPriority, TValue >.DequeueValue | ( |  | ) |  |

Returns
:   value of the dequeued element

Method throws InvalidOperationException if priority queue is empty

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#abf49f973e346859311194830022bf105)Peek()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| KeyValuePair< TPriority, TValue > TaleWorlds.Library.PriorityQueue< TPriority, TValue >.Peek | ( |  | ) |  |

Returns
:   priority and value of the element with minimum priority

Method throws InvalidOperationException if priority queue is empty

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae77eec9f711e0ae5228819ea9e124a38)PeekValue()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TValue TaleWorlds.Library.PriorityQueue< TPriority, TValue >.PeekValue | ( |  | ) |  |

Returns
:   value of the element with minimum priority

Method throws InvalidOperationException if priority queue is empty

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae8a9f750cd5f668435b26e2f982bffcd)Add()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.PriorityQueue< TPriority, TValue >.Add | ( | KeyValuePair< TPriority, TValue > | *item* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | item | element to add |

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ae63a710fa3e43afed6d5503472dfe09a)Clear()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.PriorityQueue< TPriority, TValue >.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#abd20532b5f4a8a72a85bf3a5c28f58d6)Contains()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.PriorityQueue< TPriority, TValue >.Contains | ( | KeyValuePair< TPriority, TValue > | *item* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | item | The object to locate in the priority queue |

Returns
:   `true` if item is found in the priority queue; otherwise, `false.`

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#ac8869ba333c02f47bfdcbca38f559fe0)CopyTo()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.PriorityQueue< TPriority, TValue >.CopyTo | ( | KeyValuePair< TPriority, TValue >[] | *array*, |
|  |  | int | *arrayIndex* ) |

Parameters
:   |  |  |
    | --- | --- |
    | array | The one-dimensional Array that is the destination of the elements copied from the priority queue. The Array must have zero-based indexing. |
    | arrayIndex | The zero-based index in array at which copying begins. |

It is not guaranteed that items will be copied in the sorted order.

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a073087b4d81e2d65d2b045e1c1af5491)Remove()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.PriorityQueue< TPriority, TValue >.Remove | ( | KeyValuePair< TPriority, TValue > | *item* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | item | The object to remove from the ICollection <(Of <(T >)>). |

Returns
:   `true` if item was successfully removed from the priority queue. This method returns false if item is not found in the collection.

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#abb67dc3234aa9d5988fa4483e1de1b6e)GetEnumerator()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerator< KeyValuePair< TPriority, TValue > > TaleWorlds.Library.PriorityQueue< TPriority, TValue >.GetEnumerator | ( |  | ) |  |

Returns
:   Enumerator

Returned enumerator does not iterate elements in sorted order.

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#acda2b28cbf316f8fe6fa99ccce35cecb)IsEmpty
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.PriorityQueue< TPriority, TValue >.IsEmpty | | get |

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a63ef41238a728eafd7159f1151aaecb9)Count
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Library.PriorityQueue< TPriority, TValue >.Count | | get |

[◆](class_tale_worlds_1_1_library_1_1_priority_queue-2-g.html#a2f32d6e2be7e0cd11757af6ff20a931d)IsReadOnly
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.PriorityQueue< TPriority, TValue >.IsReadOnly | | get |

For priority queue this property returns `false`.


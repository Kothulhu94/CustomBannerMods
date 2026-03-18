--- SOURCE: class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html ---

TaleWorlds.Library.CodeGeneration.ClassCode Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ClassCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a86b0d5bb0b4ffd1d6f07278558de667c) () |
| void | [GenerateInto](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a0d70b4cdf49985d4425c2e2e12908eeb) ([CodeGenerationFile](class_tale_worlds_1_1_library_1_1_code_generation_1_1_code_generation_file.html) codeGenerationFile) |
| void | [AddVariable](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a1de4b14dc91b09e155ba1b8c22691768) ([VariableCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_variable_code.html) variableCode) |
| void | [AddNestedClass](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a37c36d12c700f89ffae81d1a22d0e72e) ([ClassCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a86b0d5bb0b4ffd1d6f07278558de667c) clasCode) |
| void | [AddMethod](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a57bb7b95e30848a53a0279b31e055066) ([MethodCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_method_code.html) methodCode) |
| void | [AddConsturctor](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#aab7d68c8077e5f8f4d0c46bf5881e0a6) ([ConstructorCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_constructor_code.html) constructorCode) |
| void | [AddInterface](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a3f121075b4901f6a5256a3d83b6fd13a) (string interfaceName) |

|  |  |
| --- | --- |
| Properties | |
| string | [Name](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a0ebc596366d6ce02f6092090f8f43ba9) `[get, set]` |
| bool | [IsGeneric](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#abe1530a49687317b7dfec87a0c0cc5e6) `[get, set]` |
| int | [GenericTypeCount](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a71bd012c1b9f3e69fa90840c7320c3b7) `[get, set]` |
| bool | [IsPartial](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#ae537170fc26a62ba14e997b6db31adf6) `[get, set]` |
| [ClassCodeAccessModifier](namespace_tale_worlds_1_1_library_1_1_code_generation.html#ab8fc7301b1a35a084c7b8b2508bff2c1) | [AccessModifier](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a93a4d17bb7c1db9a90ceb64147ad7232) `[get, set]` |
| bool | [IsClass](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#afe33acda506dc83b740f8670bdfdf77e) `[get, set]` |
| List< string > | [InheritedInterfaces](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#af7c94bdda916436aa79bebab533c3ec6) `[get]` |
| List< [ClassCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a86b0d5bb0b4ffd1d6f07278558de667c) > | [NestedClasses](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#ac0fd4c063e32ecb3501722378fcf4d32) `[get]` |
| List< [MethodCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_method_code.html) > | [Methods](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#aaf8dc4524b0bcf2772a4b3d9d32e4e2c) `[get]` |
| List< [ConstructorCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_constructor_code.html) > | [Constructors](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#ad437ad8d08655e649dcac2601fe1508f) `[get]` |
| List< [VariableCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_variable_code.html) > | [Variables](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a02d14443f8d5c607a37f6e7ed447fdbf) `[get]` |
| CommentSection | [CommentSection](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#af760fd46a38cc076d3334ac048dfab03) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a86b0d5bb0b4ffd1d6f07278558de667c)ClassCode()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Library.CodeGeneration.ClassCode.ClassCode | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a0d70b4cdf49985d4425c2e2e12908eeb)GenerateInto()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.CodeGeneration.ClassCode.GenerateInto | ( | [CodeGenerationFile](class_tale_worlds_1_1_library_1_1_code_generation_1_1_code_generation_file.html) | *codeGenerationFile* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a1de4b14dc91b09e155ba1b8c22691768)AddVariable()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.CodeGeneration.ClassCode.AddVariable | ( | [VariableCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_variable_code.html) | *variableCode* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a37c36d12c700f89ffae81d1a22d0e72e)AddNestedClass()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.CodeGeneration.ClassCode.AddNestedClass | ( | [ClassCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a86b0d5bb0b4ffd1d6f07278558de667c) | *clasCode* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a57bb7b95e30848a53a0279b31e055066)AddMethod()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.CodeGeneration.ClassCode.AddMethod | ( | [MethodCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_method_code.html) | *methodCode* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#aab7d68c8077e5f8f4d0c46bf5881e0a6)AddConsturctor()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.CodeGeneration.ClassCode.AddConsturctor | ( | [ConstructorCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_constructor_code.html) | *constructorCode* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a3f121075b4901f6a5256a3d83b6fd13a)AddInterface()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.CodeGeneration.ClassCode.AddInterface | ( | string | *interfaceName* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a0ebc596366d6ce02f6092090f8f43ba9)Name
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Library.CodeGeneration.ClassCode.Name | | getset |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#abe1530a49687317b7dfec87a0c0cc5e6)IsGeneric
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.CodeGeneration.ClassCode.IsGeneric | | getset |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a71bd012c1b9f3e69fa90840c7320c3b7)GenericTypeCount
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Library.CodeGeneration.ClassCode.GenericTypeCount | | getset |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#ae537170fc26a62ba14e997b6db31adf6)IsPartial
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.CodeGeneration.ClassCode.IsPartial | | getset |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a93a4d17bb7c1db9a90ceb64147ad7232)AccessModifier
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ClassCodeAccessModifier](namespace_tale_worlds_1_1_library_1_1_code_generation.html#ab8fc7301b1a35a084c7b8b2508bff2c1) TaleWorlds.Library.CodeGeneration.ClassCode.AccessModifier | | getset |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#afe33acda506dc83b740f8670bdfdf77e)IsClass
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.CodeGeneration.ClassCode.IsClass | | getset |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#af7c94bdda916436aa79bebab533c3ec6)InheritedInterfaces
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<string> TaleWorlds.Library.CodeGeneration.ClassCode.InheritedInterfaces | | get |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#ac0fd4c063e32ecb3501722378fcf4d32)NestedClasses
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[ClassCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a86b0d5bb0b4ffd1d6f07278558de667c)> TaleWorlds.Library.CodeGeneration.ClassCode.NestedClasses | | get |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#aaf8dc4524b0bcf2772a4b3d9d32e4e2c)Methods
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[MethodCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_method_code.html)> TaleWorlds.Library.CodeGeneration.ClassCode.Methods | | get |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#ad437ad8d08655e649dcac2601fe1508f)Constructors
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[ConstructorCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_constructor_code.html)> TaleWorlds.Library.CodeGeneration.ClassCode.Constructors | | get |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#a02d14443f8d5c607a37f6e7ed447fdbf)Variables
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[VariableCode](class_tale_worlds_1_1_library_1_1_code_generation_1_1_variable_code.html)> TaleWorlds.Library.CodeGeneration.ClassCode.Variables | | get |

[◆](class_tale_worlds_1_1_library_1_1_code_generation_1_1_class_code.html#af760fd46a38cc076d3334ac048dfab03)CommentSection
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CommentSection TaleWorlds.Library.CodeGeneration.ClassCode.CommentSection | | getset |


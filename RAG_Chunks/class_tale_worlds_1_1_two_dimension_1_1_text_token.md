--- SOURCE: class_tale_worlds_1_1_two_dimension_1_1_text_token.html ---

TaleWorlds.TwoDimension.TextToken Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [TokenType](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817f) {     [EmptyCharacter](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817fabd800745ab3367b9a809edfcc1282b28) ,     [ZeroWidthSpace](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817fa89bb3ec382e9821ef3a0469c4eda77b2) ,     [NonBreakingSpace](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817fa313611da20a058f324656d64d5fe67f4) ,     [WordJoiner](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817fa0343888d60f4a5a0145a75dd6a6bd9e0) ,     [NewLine](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817fa16c885b2d67a4c187016f935e9a35373) ,     [Tab](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817fa5c6ba25104401c9ee0650230fc6ba413) ,     [Character](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817fa76a40e4f974fd895a0a2598c1cee28b4) ,     [Tag](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817fac101058e7ea21bbbf2a5ac893088e90b)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static TextToken | [CreateEmptyCharacter](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#acfa2d3ef1d3da70f3264112f63174fc4) () |
| static TextToken | [CreateZeroWidthSpaceCharacter](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a84d5068d39ac1b6c338fad8fb0125d95) () |
| static TextToken | [CreateNonBreakingSpaceCharacter](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a5e73954cac02eee37c21f7985dc0af21) () |
| static TextToken | [CreateWordJoinerCharacter](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a9ef45ba90c58c344413a119b837a3359) () |
| static TextToken | [CreateNewLine](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a5857ffb8b5e238295c298071043c06d7) () |
| static TextToken | [CreateTab](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a49aa6f7edb28a8c298ff9f713f850330) () |
| static TextToken | [CreateCharacter](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a059d133b4e652e7286dd7fbfa944dff4) (char character) |
| static TextToken | [CreateTag](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a59e00bb036828f9cba406cd43eb2bce4) ([RichTextTag](class_tale_worlds_1_1_two_dimension_1_1_rich_text_tag.html) tag) |
| static TextToken | [CreateCharacterCannotEndLineWith](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a7baf0e008424c2f5f6eafda7eb3f3943) (char character) |
| static TextToken | [CreateCharacterCannotStartLineWith](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#abca990451eb2bec219c7ca5a5caa0701) (char character) |
| static List< TextToken > | [CreateTokenArrayFromWord](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ab3df09349bb95d056941be57b22888f7) (string word) |

|  |  |
| --- | --- |
| Properties | |
| char | [Token](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a607df76c8669f6c6fba98c04c7a77b7d) `[get]` |
| [TokenType](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817f) | [Type](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a9698d926662d4bd51dfb79d3b5cdd938) `[get]` |
| [RichTextTag](class_tale_worlds_1_1_two_dimension_1_1_rich_text_tag.html) | [Tag](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a069b20162e8329e4d68f596312782dd2) `[get]` |
| bool | [CannotStartLineWithCharacter](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a3725d6ea342ddd040e71d744909f7a37) `[get, set]` |
| bool | [CannotEndLineWithCharacter](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a0f7f1865711626c077a0c20bb0bdd652) `[get, set]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817f)TokenType
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.TwoDimension.TextToken.TokenType](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817f) |

| Enumerator | |
| --- | --- |
| EmptyCharacter |  |
| ZeroWidthSpace |  |
| NonBreakingSpace |  |
| WordJoiner |  |
| NewLine |  |
| Tab |  |
| Character |  |
| Tag |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#acfa2d3ef1d3da70f3264112f63174fc4)CreateEmptyCharacter()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TextToken TaleWorlds.TwoDimension.TextToken.CreateEmptyCharacter | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a84d5068d39ac1b6c338fad8fb0125d95)CreateZeroWidthSpaceCharacter()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TextToken TaleWorlds.TwoDimension.TextToken.CreateZeroWidthSpaceCharacter | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a5e73954cac02eee37c21f7985dc0af21)CreateNonBreakingSpaceCharacter()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TextToken TaleWorlds.TwoDimension.TextToken.CreateNonBreakingSpaceCharacter | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a9ef45ba90c58c344413a119b837a3359)CreateWordJoinerCharacter()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TextToken TaleWorlds.TwoDimension.TextToken.CreateWordJoinerCharacter | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a5857ffb8b5e238295c298071043c06d7)CreateNewLine()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TextToken TaleWorlds.TwoDimension.TextToken.CreateNewLine | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a49aa6f7edb28a8c298ff9f713f850330)CreateTab()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TextToken TaleWorlds.TwoDimension.TextToken.CreateTab | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a059d133b4e652e7286dd7fbfa944dff4)CreateCharacter()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TextToken TaleWorlds.TwoDimension.TextToken.CreateCharacter | ( | char | *character* | ) |  | | static |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a59e00bb036828f9cba406cd43eb2bce4)CreateTag()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TextToken TaleWorlds.TwoDimension.TextToken.CreateTag | ( | [RichTextTag](class_tale_worlds_1_1_two_dimension_1_1_rich_text_tag.html) | *tag* | ) |  | | static |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a7baf0e008424c2f5f6eafda7eb3f3943)CreateCharacterCannotEndLineWith()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TextToken TaleWorlds.TwoDimension.TextToken.CreateCharacterCannotEndLineWith | ( | char | *character* | ) |  | | static |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#abca990451eb2bec219c7ca5a5caa0701)CreateCharacterCannotStartLineWith()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TextToken TaleWorlds.TwoDimension.TextToken.CreateCharacterCannotStartLineWith | ( | char | *character* | ) |  | | static |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ab3df09349bb95d056941be57b22888f7)CreateTokenArrayFromWord()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< TextToken > TaleWorlds.TwoDimension.TextToken.CreateTokenArrayFromWord | ( | string | *word* | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a607df76c8669f6c6fba98c04c7a77b7d)Token
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | char TaleWorlds.TwoDimension.TextToken.Token | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a9698d926662d4bd51dfb79d3b5cdd938)Type
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TokenType](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#ac01f58201088589633c913b0df06817f) TaleWorlds.TwoDimension.TextToken.Type | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a069b20162e8329e4d68f596312782dd2)Tag
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [RichTextTag](class_tale_worlds_1_1_two_dimension_1_1_rich_text_tag.html) TaleWorlds.TwoDimension.TextToken.Tag | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a3725d6ea342ddd040e71d744909f7a37)CannotStartLineWithCharacter
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.TextToken.CannotStartLineWithCharacter | | getset |

[◆](class_tale_worlds_1_1_two_dimension_1_1_text_token.html#a0f7f1865711626c077a0c20bb0bdd652)CannotEndLineWithCharacter
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.TextToken.CannotEndLineWithCharacter | | getset |


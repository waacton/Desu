# <img src="https://gitlab.com/Wacton/Desu/raw/main/Desu/Resources/Desu.png" width="32" height="32"> Desu
Wacton.Desu is a Japanese and kanji dictionary .NET library built upon [JMdict](https://www.edrdg.org/wiki/index.php/JMdict-EDICT_Dictionary_Project), [JMnedict](http://www.edrdg.org/enamdict/enamdict_doc.html), [KANJIDIC](https://www.edrdg.org/wiki/index.php/KANJIDIC_Project), [RADKFILE/KRADFILE](http://nihongo.monash.edu/kradinf.html), and [KanjiVG](http://kanjivg.tagaini.net/). 
<br>
The data structure uses object representations where possible.  Please refer to the above projects for detailed definitions of the properties.

## How to use 📚🇯🇵
Can be installed as a [NuGet package](https://www.nuget.org/packages/Wacton.Desu/) [![NuGet](https://img.shields.io/nuget/v/Wacton.Desu.svg?maxAge=2592000)](https://www.nuget.org/packages/Wacton.Desu/)
```
Install-Package Wacton.Desu
```
<br>

**Japanese dictionary** (JMdict)
```c#
using Wacton.Desu.Japanese;
...
var japaneseEntries = JapaneseDictionary.ParseEntries();
var japaneseEntries = await JapaneseDictionary.ParseEntriesAsync();
```
<details>
<summary>Click to see example structure of a Japanese entry: 円</summary>

```json
{
    "Sequence": 1175570,
    "Kanjis": [
        {
            "Text": "円",
            "Informations": [],
            "Priorities": [
                {
                    "Code": "ichi1",
                    "Value": 2,
                    "DisplayName": "Ichimango1"
                },
                {
                    "Code": "news1",
                    "Value": 4,
                    "DisplayName": "Newspaper1"
                },
                {
                    "Code": "nf05",
                    "Value": 10,
                    "DisplayName": "Frequency5"
                }
            ]
        },
        {
            "Text": "圓",
            "Informations": [
                {
                    "Code": "word containing out-dated kanji or kanji usage",
                    "Value": 4,
                    "DisplayName": "OutdatedKanji"
                }
            ],
            "Priorities": []
        }
    ],
    "Readings": [
        {
            "Text": "えん",
            "IsTrueKanjiReading": true,
            "Restriction": [],
            "Informations": [],
            "Priorities": [
                {
                    "Code": "ichi1",
                    "Value": 2,
                    "DisplayName": "Ichimango1"
                },
                {
                    "Code": "news1",
                    "Value": 4,
                    "DisplayName": "Newspaper1"
                },
                {
                    "Code": "nf05",
                    "Value": 10,
                    "DisplayName": "Frequency5"
                }
            ]
        }
    ],
    "Senses": [
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [
                {
                    "Code": "noun (common) (futsuumeishi)",
                    "Description": "Noun (common)",
                    "Value": 19,
                    "DisplayName": "NounCommon"
                }
            ],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "yen (Japanese monetary unit)",
                    "Language": {
                        "ThreeLetterCode": "eng",
                        "TwoLetterCode": "en",
                        "Value": 15,
                        "DisplayName": "English"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [
                {
                    "Code": "noun (common) (futsuumeishi)",
                    "Description": "Noun (common)",
                    "Value": 19,
                    "DisplayName": "NounCommon"
                }
            ],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "circle",
                    "Language": {
                        "ThreeLetterCode": "eng",
                        "TwoLetterCode": "en",
                        "Value": 15,
                        "DisplayName": "English"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "cirkel",
                    "Language": {
                        "ThreeLetterCode": "dut",
                        "TwoLetterCode": "nl",
                        "Value": 14,
                        "DisplayName": "Dutch"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "rondte",
                    "Language": {
                        "ThreeLetterCode": "dut",
                        "TwoLetterCode": "nl",
                        "Value": 14,
                        "DisplayName": "Dutch"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "{muntw.} yen",
                    "Language": {
                        "ThreeLetterCode": "dut",
                        "TwoLetterCode": "nl",
                        "Value": 14,
                        "DisplayName": "Dutch"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "yen",
                    "Language": {
                        "ThreeLetterCode": "fre",
                        "TwoLetterCode": "fr",
                        "Value": 20,
                        "DisplayName": "French"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "unité monétaire japonaise",
                    "Language": {
                        "ThreeLetterCode": "fre",
                        "TwoLetterCode": "fr",
                        "Value": 20,
                        "DisplayName": "French"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "cercle",
                    "Language": {
                        "ThreeLetterCode": "fre",
                        "TwoLetterCode": "fr",
                        "Value": 20,
                        "DisplayName": "French"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "Kreis",
                    "Language": {
                        "ThreeLetterCode": "ger",
                        "TwoLetterCode": "de",
                        "Value": 22,
                        "DisplayName": "German"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "Kugel",
                    "Language": {
                        "ThreeLetterCode": "ger",
                        "TwoLetterCode": "de",
                        "Value": 22,
                        "DisplayName": "German"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "Kreis",
                    "Language": {
                        "ThreeLetterCode": "ger",
                        "TwoLetterCode": "de",
                        "Value": 22,
                        "DisplayName": "German"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "Yen",
                    "Language": {
                        "ThreeLetterCode": "ger",
                        "TwoLetterCode": "de",
                        "Value": 22,
                        "DisplayName": "German"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "￥",
                    "Language": {
                        "ThreeLetterCode": "ger",
                        "TwoLetterCode": "de",
                        "Value": 22,
                        "DisplayName": "German"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "karika",
                    "Language": {
                        "ThreeLetterCode": "hun",
                        "TwoLetterCode": "hu",
                        "Value": 29,
                        "DisplayName": "Hungarian"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "kerület",
                    "Language": {
                        "ThreeLetterCode": "hun",
                        "TwoLetterCode": "hu",
                        "Value": 29,
                        "DisplayName": "Hungarian"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "körvonal",
                    "Language": {
                        "ThreeLetterCode": "hun",
                        "TwoLetterCode": "hu",
                        "Value": 29,
                        "DisplayName": "Hungarian"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "körzet",
                    "Language": {
                        "ThreeLetterCode": "hun",
                        "TwoLetterCode": "hu",
                        "Value": 29,
                        "DisplayName": "Hungarian"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "иена",
                    "Language": {
                        "ThreeLetterCode": "rus",
                        "TwoLetterCode": "ru",
                        "Value": 49,
                        "DisplayName": "Russian"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "круг",
                    "Language": {
                        "ThreeLetterCode": "rus",
                        "TwoLetterCode": "ru",
                        "Value": 49,
                        "DisplayName": "Russian"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "jen (japonska denarna enota)",
                    "Language": {
                        "ThreeLetterCode": "slv",
                        "TwoLetterCode": "sl",
                        "Value": 52,
                        "DisplayName": "Slovenian"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "okrogla oblika{図形}",
                    "Language": {
                        "ThreeLetterCode": "slv",
                        "TwoLetterCode": "sl",
                        "Value": 52,
                        "DisplayName": "Slovenian"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "yen (valuta){貨幣}",
                    "Language": {
                        "ThreeLetterCode": "slv",
                        "TwoLetterCode": "sl",
                        "Value": 52,
                        "DisplayName": "Slovenian"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "jen {jap. denarna enota}",
                    "Language": {
                        "ThreeLetterCode": "slv",
                        "TwoLetterCode": "sl",
                        "Value": 52,
                        "DisplayName": "Slovenian"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "Yen",
                    "Language": {
                        "ThreeLetterCode": "spa",
                        "TwoLetterCode": "es",
                        "Value": 54,
                        "DisplayName": "Spanish"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "Yenes",
                    "Language": {
                        "ThreeLetterCode": "spa",
                        "TwoLetterCode": "es",
                        "Value": 54,
                        "DisplayName": "Spanish"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "dinero",
                    "Language": {
                        "ThreeLetterCode": "spa",
                        "TwoLetterCode": "es",
                        "Value": 54,
                        "DisplayName": "Spanish"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        },
        {
            "KanjiRestriction": [],
            "ReadingRestriction": [],
            "PartsOfSpeech": [],
            "CrossReferences": [],
            "Antonyms": [],
            "Fields": [],
            "Miscellanea": [],
            "Informations": [],
            "LoanwordSources": [],
            "Dialects": [],
            "Glosses": [
                {
                    "Term": "círculo",
                    "Language": {
                        "ThreeLetterCode": "spa",
                        "TwoLetterCode": "es",
                        "Value": 54,
                        "DisplayName": "Spanish"
                    },
                    "Type": null,
                    "Gender": null
                },
                {
                    "Term": "redondel",
                    "Language": {
                        "ThreeLetterCode": "spa",
                        "TwoLetterCode": "es",
                        "Value": 54,
                        "DisplayName": "Spanish"
                    },
                    "Type": null,
                    "Gender": null
                }
            ]
        }
    ]
}
```
</details>
<br>

**Proper name dictionary** (JMnedict)
```c#
using Wacton.Desu.Names;
...
var nameEntries = NameDictionary.ParseEntries();
var nameEntries = await NameDictionary.ParseEntriesAsync();
```
<details>
<summary>Click to see example structure of a proper name entry: 円</summary>

```json
{
    "Sequence": 5142901,
    "Kanjis": [
        {
            "Text": "円",
            "Informations": [],
            "Priorities": []
        }
    ],
    "Readings": [
        {
            "Text": "えん",
            "IsTrueKanjiReading": true,
            "Restriction": [],
            "Informations": [],
            "Priorities": []
        }
    ],
    "Translations": [
        {
            "NameTypes": [
                {
                    "Code": "female given name or forename",
                    "Value": 5,
                    "DisplayName": "Female"
                },
                {
                    "Code": "family or surname",
                    "Value": 19,
                    "DisplayName": "Surname"
                }
            ],
            "CrossReferences": [],
            "Transcriptions": [
                "En"
            ]
        }
    ]
}
```
</details>
<br>

**Kanji dictionary** (KANJIDIC + KRADFILE + KanjiVG) <br>
This includes radical decomposition and SVG stroke paths where applicable (using `RadicalLookup` and `StrokeLookup`)
```c#
using Wacton.Desu.Kanji;
...
var kanjiEntries = KanjiDictionary.ParseEntries();
var kanjiEntries = await KanjiDictionary.ParseEntriesAsync();
```
<details>
<summary>Click to see example structure of a kanji entry: 円</summary>

```json
{
    "Literal": "円",
    "RadicalDecomposition": [
        "冂",
        "亠",
        "一",
        "｜"
    ],
    "Codepoints": [
        {
            "Type": {
                "Code": "ucs",
                "Description": "Unicode 4.0",
                "Value": 3,
                "DisplayName": "Unicode"
            },
            "Value": "5186"
        },
        {
            "Type": {
                "Code": "jis208",
                "Description": "JIS X 0208-1997",
                "Value": 0,
                "DisplayName": "JIS208"
            },
            "Value": "17-63"
        }
    ],
    "StrokePaths": [
        "M21.75,19.8c0.91,0.91,1.47,3.23,1.5,5.45c0.2,13.9,0.03,47.69,0.03,62.5c0,2-0.03,4.99-0.03,6",
        "M24.06,21.56c15.07-1.68,49.46-5.58,57.92-6.31c2.9-0.25,4.78,1.88,4.78,4.27c0,13.48,0,53.21,0,67.48c0,9.75-4.25,6.5-8.5,1.5",
        "M52.25,20.75c0.88,0.88,1.5,2,1.5,3.71c0,6.76,0,27.54,0,31.04",
        "M24.75,59.75c14.62-1.75,43-4.25,60.5-5.25"
    ],
    "IndexRadicals": [
        {
            "Type": {
                "Code": "classical",
                "Value": 0,
                "DisplayName": "Kangxi"
            },
            "Number": 13,
            "Radical": "冂",
            "Variants": [],
            "Value": 12,
            "DisplayName": "Radical013"
        }
    ],
    "IsIndexRadical": false,
    "Grade": {
        "Number": 1,
        "Value": 1,
        "DisplayName": "One"
    },
    "StrokeCount": 4,
    "StrokeCommonMiscounts": [],
    "Variants": [
        {
            "Type": {
                "Code": "jis208",
                "Description": "JIS X 0208",
                "Value": 0,
                "DisplayName": "JIS208"
            },
            "Value": "52-04"
        }
    ],
    "Frequency": 69,
    "RadicalNames": [],
    "JLPT": 4,
    "References": [
        {
            "Type": {
                "Code": "nelson_c",
                "Description": "Nelson: \"Modern Reader's Japanese-English Character Dictionary\"",
                "Value": 0,
                "DisplayName": "Nelson_Classic"
            },
            "Value": "617"
        },
        {
            "Type": {
                "Code": "nelson_n",
                "Description": "Nelson: \"The New Nelson Japanese-English Character Dictionary\"",
                "Value": 1,
                "DisplayName": "Nelson_New"
            },
            "Value": "385"
        },
        {
            "Type": {
                "Code": "halpern_njecd",
                "Description": "Halpern: \"New Japanese-English Character Dictionary\"",
                "Value": 2,
                "DisplayName": "Halpern_NJECD"
            },
            "Value": "2955"
        },
        {
            "Type": {
                "Code": "halpern_kkd",
                "Description": "Halpern: \"Kodansha Kanji Dictionary\"",
                "Value": 5,
                "DisplayName": "Halpern_KKD"
            },
            "Value": "3673"
        },
        {
            "Type": {
                "Code": "halpern_kkld",
                "Description": "Halpern: \"Kanji Learners Dictionary\"",
                "Value": 3,
                "DisplayName": "Halpern_KLD"
            },
            "Value": "1875"
        },
        {
            "Type": {
                "Code": "halpern_kkld_2ed",
                "Description": "Halpern: \"Kanji Learners Dictionary\", 2nd Edition",
                "Value": 4,
                "DisplayName": "Halpern_KLD_2"
            },
            "Value": "2555"
        },
        {
            "Type": {
                "Code": "heisig",
                "Description": "Heisig: \"Remembering The Kanji\"",
                "Value": 6,
                "DisplayName": "Heisig"
            },
            "Value": "1811"
        },
        {
            "Type": {
                "Code": "heisig6",
                "Description": "Heisig: \"Remembering The Kanji\", 6th Edition",
                "Value": 7,
                "DisplayName": "Heisig_6"
            },
            "Value": "1952"
        },
        {
            "Type": {
                "Code": "gakken",
                "Description": "Gakken: \"A New Dictionary Of Kanji Usage\"",
                "Value": 8,
                "DisplayName": "Gakken"
            },
            "Value": "2"
        },
        {
            "Type": {
                "Code": "oneill_names",
                "Description": "O'Neill: \"Japanese Names\"",
                "Value": 9,
                "DisplayName": "ONeill_Names"
            },
            "Value": "78"
        },
        {
            "Type": {
                "Code": "oneill_kk",
                "Description": "O'Neill: \"Essential Kanji\"",
                "Value": 10,
                "DisplayName": "ONeill_Kanji"
            },
            "Value": "159"
        },
        {
            "Type": {
                "Code": "moro",
                "Description": "Morohashi: \"Daikanwajiten\"",
                "Value": 11,
                "DisplayName": "Morohashi"
            },
            "Value": "1513 (vol 2, pg 0110)"
        },
        {
            "Type": {
                "Code": "henshall",
                "Description": "Henshall: \"A Guide To Remembering Japanese Characters\"",
                "Value": 12,
                "DisplayName": "Henshall"
            },
            "Value": "4"
        },
        {
            "Type": {
                "Code": "sh_kk",
                "Description": "Spahn & Hadamitzky: \"The Kanji Dictionary\"",
                "Value": 13,
                "DisplayName": "SpahnHadamitzky"
            },
            "Value": "13"
        },
        {
            "Type": {
                "Code": "sh_kk2",
                "Description": "Spahn & Hadamitzky: \"The Kanji Dictionary\", 2nd Edition",
                "Value": 14,
                "DisplayName": "SpahnHadamitzky_2"
            },
            "Value": "13"
        },
        {
            "Type": {
                "Code": "sakade",
                "Description": "Sakade: \"A Guide To Reading And Writing Japanese\"",
                "Value": 15,
                "DisplayName": "Sakade"
            },
            "Value": "48"
        },
        {
            "Type": {
                "Code": "jf_cards",
                "Description": "Japanese Kanji Flashcards (Hodges & Okazaki)",
                "Value": 16,
                "DisplayName": "JapaneseFlashcards"
            },
            "Value": "20"
        },
        {
            "Type": {
                "Code": "henshall3",
                "Description": "Henshall, Seeley & De Groot: \"A Guide To Reading And Writing Japanese\", 3rd Edition",
                "Value": 17,
                "DisplayName": "HenshallSeeleyDeGroot"
            },
            "Value": "50"
        },
        {
            "Type": {
                "Code": "tutt_cards",
                "Description": "Tuttle Flash Cards (Kask)",
                "Value": 18,
                "DisplayName": "TuttleFlashcards"
            },
            "Value": "25"
        },
        {
            "Type": {
                "Code": "crowley",
                "Description": "Crowley: \"The Kanji Way to Japanese Language Power\"",
                "Value": 19,
                "DisplayName": "Crowley"
            },
            "Value": "260"
        },
        {
            "Type": {
                "Code": "kanji_in_context",
                "Description": "Nishiguchi & Kono: \"Kanji In Context\"",
                "Value": 20,
                "DisplayName": "KanjiContext"
            },
            "Value": "14"
        },
        {
            "Type": {
                "Code": "busy_people",
                "Description": "AJALT: \"Japanese For Busy People\"",
                "Value": 21,
                "DisplayName": "BusyPeople"
            },
            "Value": "2.12"
        },
        {
            "Type": {
                "Code": "kodansha_compact",
                "Description": "\"Kodansha's Compact Kanji Guide\"",
                "Value": 22,
                "DisplayName": "KodenshaCompact"
            },
            "Value": "159"
        },
        {
            "Type": {
                "Code": "maniette",
                "Description": "Maniette: \"Les Kanjis Dans La Tête\"",
                "Value": 23,
                "DisplayName": "Maniette"
            },
            "Value": "185"
        }
    ],
    "QueryCodes": [
        {
            "Type": {
                "Code": "skip",
                "Description": "SKIP",
                "Value": 0,
                "DisplayName": "SKIP"
            },
            "SkipMisclassification": {
                "Code": "",
                "Value": 0,
                "DisplayName": "None"
            },
            "Value": "3-2-2"
        },
        {
            "Type": {
                "Code": "sh_desc",
                "Description": "Spahn & Hadamitzky",
                "Value": 1,
                "DisplayName": "SpahnHadamitzky"
            },
            "SkipMisclassification": null,
            "Value": "2r2.1"
        },
        {
            "Type": {
                "Code": "four_corner",
                "Description": "Four Corner",
                "Value": 2,
                "DisplayName": "FourCorner"
            },
            "SkipMisclassification": null,
            "Value": "7722.0"
        },
        {
            "Type": {
                "Code": "deroo",
                "Description": "De Roo",
                "Value": 3,
                "DisplayName": "DeRoo"
            },
            "SkipMisclassification": null,
            "Value": "3645"
        }
    ],
    "Readings": [
        {
            "Type": {
                "Code": "pinyin",
                "Value": 0,
                "DisplayName": "Pinyin"
            },
            "Value": "yuan2"
        },
        {
            "Type": {
                "Code": "korean_r",
                "Value": 1,
                "DisplayName": "KoreanRomanized"
            },
            "Value": "weon"
        },
        {
            "Type": {
                "Code": "korean_h",
                "Value": 2,
                "DisplayName": "KoreanHangul"
            },
            "Value": "원"
        },
        {
            "Type": {
                "Code": "ja_on",
                "Value": 3,
                "DisplayName": "JapaneseOn"
            },
            "Value": "エン"
        },
        {
            "Type": {
                "Code": "ja_kun",
                "Value": 4,
                "DisplayName": "JapaneseKun"
            },
            "Value": "まる.い"
        },
        {
            "Type": {
                "Code": "ja_kun",
                "Value": 4,
                "DisplayName": "JapaneseKun"
            },
            "Value": "まる"
        },
        {
            "Type": {
                "Code": "ja_kun",
                "Value": 4,
                "DisplayName": "JapaneseKun"
            },
            "Value": "まど"
        },
        {
            "Type": {
                "Code": "ja_kun",
                "Value": 4,
                "DisplayName": "JapaneseKun"
            },
            "Value": "まど.か"
        },
        {
            "Type": {
                "Code": "ja_kun",
                "Value": 4,
                "DisplayName": "JapaneseKun"
            },
            "Value": "まろ.やか"
        }
    ],
    "Meanings": [
        {
            "Language": {
                "ThreeLetterCode": "eng",
                "TwoLetterCode": "en",
                "Value": 15,
                "DisplayName": "English"
            },
            "Term": "circle"
        },
        {
            "Language": {
                "ThreeLetterCode": "eng",
                "TwoLetterCode": "en",
                "Value": 15,
                "DisplayName": "English"
            },
            "Term": "yen"
        },
        {
            "Language": {
                "ThreeLetterCode": "eng",
                "TwoLetterCode": "en",
                "Value": 15,
                "DisplayName": "English"
            },
            "Term": "round"
        },
        {
            "Language": {
                "ThreeLetterCode": "fre",
                "TwoLetterCode": "fr",
                "Value": 20,
                "DisplayName": "French"
            },
            "Term": "cercle"
        },
        {
            "Language": {
                "ThreeLetterCode": "fre",
                "TwoLetterCode": "fr",
                "Value": 20,
                "DisplayName": "French"
            },
            "Term": "yen"
        },
        {
            "Language": {
                "ThreeLetterCode": "fre",
                "TwoLetterCode": "fr",
                "Value": 20,
                "DisplayName": "French"
            },
            "Term": "rond"
        },
        {
            "Language": {
                "ThreeLetterCode": "spa",
                "TwoLetterCode": "es",
                "Value": 54,
                "DisplayName": "Spanish"
            },
            "Term": "circular"
        },
        {
            "Language": {
                "ThreeLetterCode": "spa",
                "TwoLetterCode": "es",
                "Value": 54,
                "DisplayName": "Spanish"
            },
            "Term": "redondo"
        },
        {
            "Language": {
                "ThreeLetterCode": "spa",
                "TwoLetterCode": "es",
                "Value": 54,
                "DisplayName": "Spanish"
            },
            "Term": "yen"
        },
        {
            "Language": {
                "ThreeLetterCode": "por",
                "TwoLetterCode": "pt",
                "Value": 47,
                "DisplayName": "Portuguese"
            },
            "Term": "círculo"
        },
        {
            "Language": {
                "ThreeLetterCode": "por",
                "TwoLetterCode": "pt",
                "Value": 47,
                "DisplayName": "Portuguese"
            },
            "Term": "iene"
        },
        {
            "Language": {
                "ThreeLetterCode": "por",
                "TwoLetterCode": "pt",
                "Value": 47,
                "DisplayName": "Portuguese"
            },
            "Term": "redondo"
        }
    ],
    "Nanoris": [
        "つぶら",
        "のぶ",
        "まどか",
        "みつ"
    ]
}
```
</details>
<br>

**Radical lookup** - kanji to radicals (KRADFILE)
```c#
using Wacton.Desu.Radicals;
...
var kanjiToRadicals = RadicalLookup.ParseKanjiToRadicals();
var kanjiToRadicals = await RadicalLookup.ParseKanjiToRadicalsAsync();
```
<details>
<summary>Click to see example return value of a radical lookup (kanji to radicals): 円</summary>

```json
["冂","亠","一","｜"]
```
</details>
<br>

**Radical lookup** - radical to kanjis (RADKFILE)
```c#
using Wacton.Desu.Radicals;
...
var radicalToKanjis = RadicalLookup.ParseRadicalToKanjis();
var radicalToKanjis = await RadicalLookup.ParseRadicalToKanjisAsync();
```
<details>
<summary>
Click to see example return value of a radical lookup (radical to kanjis): 冂,
<a href="https://en.wikipedia.org/wiki/Radical_13">the index radical of 円</a>
</summary>

```json
["渦","円","奥","襖","岡","禍","過","骸","柿","隔","滑","喚","換","橘","僑","喬","橋","矯","興","蕎","桐","巾","禽","愚","偶","寓","遇","隅","献","檎","向","構","溝","稿","綱","講","購","鋼","高","剛","骨","再","柵","策","冊","珊","刺","嗣","爾","璽","縞","周","週","商","尚","廠","嵩","栴","鯛","凧","嫡","凋","彫","調","摘","敵","滴","適","鏑","筒","同","洞","胴","銅","凸","内","鍋","南","楠","肉","禰","納","塙","病","丙","幣","弊","柄","蔽","瞥","箆","偏","篇","編","遍","繭","満","網","融","両","麗","藁","亂","侖","倆","儷","兩","冂","囘","册","冉","冏","冑","冓","冕","刪","厰","吶","咼","喘","喃","嚆","嚮","堝","墺","夐","奐","奧","媾","嬌","孺","崗","幤","彌","怏","恫","惆","惘","慵","懊","懣","扁","搆","攜","敞","敝","敲","斃","旃","暎","暼","朿","棘","棡","棗","槁","殃","泱","淌","渙","滿","澳","濔","瀰","灑","炯","烱","炳","煥","燠","爨","犒","猾","獻","瑁","瓊","瞞","磆","礇","禹","禺","秧","稠","稱","稾","窩","竇","竊","篝","簓","粡","鬻","絅","綢","网","罔","肭","冐","腆","膈","苒","萬","萵","蒿","蕀","蚋","蜩","蝸","衲","裔","裲","覯","訥","謫","譎","跚","蹣","輛","輌","轎","辭","迥","邇","遖","遘","釁","鎬","鑰","陋","雋","雕","霙","靹","鞅","鞆","餉","騙","驕","驪","骭","骰","骼","髀","髏","髑","髓","體","髞","髯","鬲","魍","魎","鰤","鶻","鷸","黹","黻","黼","鼈","齲","两","亹","伂","佈","侗","倎","倘","倜","偁","偂","偊","偑","偙","傐","僀","僘","儞","冃","冄","冋","冎","剮","劀","勖","勪","勱","匾","厲","响","啁","啇","喁","喎","嗃","嗗","噢","囐","圇","圊","圑","坍","坰","垌","垧","埽","堈","塍","墁","壐","奝","奟","姍","婻","婾","媢","媧","媵","媻","嫮","嬭","孋","寘","屩","峒","峝","崹","嵪","嶠","嶴","巋","巐","巘","帀","帇","帍","帒","帔","帕","帘","帟","帠","帮","帨","帲","帵","帾","幋","幐","幉","幑","幖","幘","幛","幜","幞","幨","幪","幫","幬","幭","幮","幰","庽","彤","彲","徜","徧","悑","悕","惝","惼","愌","慲","慸","憋","憍","懯","扃","扄","抐","抦","掄","掚","揥","搞","搰","摛","撇","撟","撾","擿","攦","敇","敽","斒","昞","晌","晑","暠","曬","朙","杮","枏","枘","椆","槅","槗","樀","樠","檛","檰","櫔","櫤","欐","歊","歒","殢","毃","毷","氄","氅","汭","泂","洓","淛","渢","渧","湳","溮","滈","滽","漰","潏","澚","濅","瀹","灊","灕","烔","焫","熇","爚","爯","牅","牏","猘","猧","猵","獘","獝","獮","獼","珦","琱","瑀","瑍","璚","瓛","瓻","甗","甩","痌","瘓","瘸","癟","皜","眮","睎","矞","矪","碲","碻","禑","禘","禫","禴","禸","离","秱","穪","窬","竬","笧","箐","篙","簥","籭","籲","糄","絧","絺","綗","緺","縭","繘","纚","罓","罱","羀","翮","翯","耦","耼","肦","胔","胾","脧","脼","腡","腩","膐","臋","臡","舡","舢","舨","舲","舴","舺","艃","艄","艅","艆","艋","艎","艏","艑","艖","艜","艠","艣","艧","艭","芇","芮","芾","苚","苪","茼","莿","萹","蒒","蒪","蒯","蓇","蔐","薁","薓","薾","藊","藳","蘺","蚦","蛃","蛧","蜹","蜽","蝻","螄","螌","螣","螭","螮","蟎","蟜","蠆","蠒","蠵","衕","衻","裯","褠","褵","襒","襺","覶","覼","觿","詗","詷","誷","諵","謞","譾","讁","讏","讞","豨","賙","賵","趟","趫","踽","蹁","蹛","蹢","蹩","蹻","躉","躛","躧","躺","軜","輈","輖","輞","迊","迵","逈","遰","遹","邐","邴","郗","鄅","鄗","鄘","酈","醨","醰","釃","鈉","鈰","鈵","銟","鋿","錀","鍗","鍽","鎘","鎫","鏋","鏞","鐈","鐍","鑈","鑮","镾","闒","隃","隩","雘","雟","霱","靕","鞲","鞶","韝","韴","顒","顢","颫","颭","颮","颰","颴","颷","颸","颺","颻","颿","飂","飅","飈","飌","餇","駉","駧","騧","骪","骬","骮","骯","骲","骴","骵","骶","骹","骻","骾","骿","髁","髃","髆","髈","髎","髐","髒","髕","髖","髗","髛","髜","髥","鬋","鬳","鬴","鬵","鬷","鬹","鬺","魳","鮦","鯯","鯿","鰧","鱅","鱉","鱊","鱎","鱏","鵃","鵩","鵰","鶄","鶮","鷊","鷩","鷮","鸙","鸝","齵","龞","龡","龢","龣","龥"]
```
</details>
<br>

**Stroke lookup** (KanjiVG)
```c#
using Wacton.Desu.Strokes;
...
var kanjiToStrokes = StrokeLookup.ParseKanjiToStrokes();
var kanjiToStrokes = await StrokeLookup.ParseKanjiToStrokesAsync();
```
<details>
<summary>
Click to see example return value of a stroke lookup:
05186, <a href="https://unicode-table.com/en/5186/">the 5-digit unicode number of 円</a>
</summary>

```json
[
    "M21.75,19.8c0.91,0.91,1.47,3.23,1.5,5.45c0.2,13.9,0.03,47.69,0.03,62.5c0,2-0.03,4.99-0.03,6",
    "M24.06,21.56c15.07-1.68,49.46-5.58,57.92-6.31c2.9-0.25,4.78,1.88,4.78,4.27c0,13.48,0,53.21,0,67.48c0,9.75-4.25,6.5-8.5,1.5",
    "M52.25,20.75c0.88,0.88,1.5,2,1.5,3.71c0,6.76,0,27.54,0,31.04",
    "M24.75,59.75c14.62-1.75,43-4.25,60.5-5.25"
]
```
</details>
<br>

**Rōmaji transliteration** ⚠️ _Untested - use with caution_ ⚠️
```c#
using Wacton.Desu.Romaji;
...
var transliterator = new Transliterator();
var romaji = transliterator.GetRomaji("です"); // romaji == "desu"
```
<br>

_**Notes:** This is a large library due to the embedded resource files and can take a few seconds to parse._
_Since parsing the resources are [I/O-bound operations](https://docs.microsoft.com/en-us/dotnet/csharp/async) it is recommended to use the asynchronous API._
_Example usages can be found in the [Desu.ExampleConsole](https://gitlab.com/Wacton/Desu/tree/main/Desu.ExampleConsole) and [Desu.ExampleWpf](https://gitlab.com/Wacton/Desu/tree/main/Desu.ExampleWpf) projects._
_(The Japanese dictionary contains ~200k entries, and the proper name dictionary contains ~750k entries.)_
<br>

## Attributions 🙇
This library uses the following files in conformance to their respective licences:

**JMdict** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright Jim Breen & The Electronic Dictionary Research and Development Group  
Licence URL: http://www.edrdg.org/edrdg/licence.html  
Source File URL: http://ftp.edrdg.org/pub/Nihongo/JMdict.gz _(JMdict)_

**JMnedict** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright Jim Breen & The Electronic Dictionary Research and Development Group  
Licence URL: http://www.edrdg.org/edrdg/licence.html  
Source File URL: http://ftp.edrdg.org/pub/Nihongo/JMnedict.xml.gz _(JMnedict.xml)_

**KANJIDIC2** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright Jim Breen & The Electronic Dictionary Research and Development Group  
Licence URL: http://www.edrdg.org/edrdg/licence.html  
Source File URL: http://ftp.edrdg.org/pub/Nihongo/kanjidic2.xml.gz _(kanjidic2.xml)_  

**KRADFILE** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright Jim Breen & The Electronic Dictionary Research and Development Group  
Licence URL: http://www.edrdg.org/edrdg/licence.html  
Source File URL: http://ftp.edrdg.org/pub/Nihongo/kradzip.zip  _(kradfile)_

**KRADFILE2** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright James Rose  
Licence URL: http://www.kanjicafe.com/kradfile_license.htm  
Source File URL: http://ftp.edrdg.org/pub/Nihongo/kradzip.zip  _(kradfile2)_ 

**RADKFILEX** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright Jim Breen & The Electronic Dictionary Research and Development Group  
Licence URL: http://www.edrdg.org/edrdg/licence.html  
Source File URL: http://ftp.edrdg.org/pub/Nihongo/kradzip.zip  _(radkfilex)_  

**KanjiVG** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright Ulrich Apel  
Licence URL: http://kanjivg.tagaini.net/  
Source File URL: https://github.com/KanjiVG/kanjivg/releases/download/r20160426/kanjivg-20160426.xml.gz  _(kanjivg.xml)_  

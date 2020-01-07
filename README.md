# Desu
Wacton.Desu is a Japanese and kanji dictionary .NET library built upon [JMdict](http://www.edrdg.org/jmdict/edict_doc.html), [JMnedict](http://www.edrdg.org/enamdict/enamdict_doc.html), [KANJIDIC](http://www.edrdg.org/kanjidic/kanjidic.html), [RADKFILE/KRADFILE](http://users.monash.edu/~jwb/kradinf.html), and [KanjiVG](http://kanjivg.tagaini.net/). 📚🇯🇵
<br>
The data structure uses object representations where possible.  Please refer to the above projects for detailed definitions of the properties.
<br><br>
## How to use
Can be installed as a [NuGet package](https://www.nuget.org/packages/Wacton.Desu/):
```
Install-Package Wacton.Desu
```
<br>

**Japanese dictionary** *(JMdict)*:

Create a ```JapaneseDictionary``` and ```GetEntries()```
```c#
using Wacton.Desu.Japanese;
...
var japaneseDictionary = new JapaneseDictionary();
var japaneseEntries = japaneseDictionary.GetEntries();
```
<br>

**Proper name dictionary** *(JMnedict)*:

Create a ```NameDictionary``` and ```GetEntries()```
```c#
using Wacton.Desu.Names;
...
var nameDictionary = new NameDictionary();
var nameEntries = nameDictionary.GetEntries();
```
<br>

**Kanji dictionary** *(KANJIDIC + KRADFILE + KanjiVG)*: 

Create a ```KanjiDictionary``` and ```GetEntries()```
```c#
using Wacton.Desu.Kanji;
...
var kanjiDictionary = new KanjiDictionary();
var kanjiEntries = kanjiDictionary.GetEntries();
```
<br>

**Radical lookup** *(RADKFILE/KRADFILE)*:

Create a ```RadicalLookup``` and either ```GetKanjiToRadicals()``` or ```GetRadicalToKanjis()```
```c#
using Wacton.Desu.Radicals;
...
var radicalLookup = new RadicalLookup();
var kanjiToRadicals = radicalLookup.GetKanjiToRadicals();
var radicalToKanjis = radicalLookup.GetRadicalToKanjis();
```
<br>

**Stroke lookup** *(KanjiVG)*:

Create a ```StrokeLookup``` and ```GetKanjiToStrokes()```
```c#
using Wacton.Desu.Strokes;
...
var strokeLookup = new StrokeLookup();
var kanjiToStrokes = strokeLookup.GetKanjiToStrokes();
```
<br>

**Romaji transliteration**:
Create a ```Transliterator``` and ```GetRomaji()```
```c#
using Wacton.Desu.Romaji;
...
var transliterator = new Transliterator();
var romaji = transliterator.GetRomaji("です"); // romaji == "desu"
```
<br>
Examples can be found in the [Desu.ExampleConsole](https://gitlab.com/Wacton/Desu/tree/master/Desu.ExampleConsole) and [Desu.ExampleWpf](https://gitlab.com/Wacton/Desu/tree/master/Desu.ExampleWpf) projects.
<br><br>

---

## Attributions
This library uses the following files in conformance to their respective licences:

**JMdict** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright Jim Breen & The Electronic Dictionary Research and Development Group  
Licence URL: http://www.edrdg.org/edrdg/licence.html  
Source File URL: http://www.edrdg.org/jmdict/j_jmdict.html *(JMdict.gz)*  

**JMnedict** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright Jim Breen & The Electronic Dictionary Research and Development Group  
Licence URL: http://www.edrdg.org/edrdg/licence.html  
Source File URL: http://www.edrdg.org/enamdict/enamdict_doc.html *(JMnedict.xml.gz)*  

**KANJIDIC2** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright Jim Breen & The Electronic Dictionary Research and Development Group  
Licence URL: http://www.edrdg.org/edrdg/licence.html  
Source File URL: http://nihongo.monash.edu/kanjidic2/  *(kanjidic2.xml.gz)*  

**KRADFILE** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright Jim Breen & The Electronic Dictionary Research and Development Group  
Licence URL: http://www.edrdg.org/edrdg/licence.html  
Source File URL: http://users.monash.edu/~jwb/kradinf.html  *(kradzip.zip\kradfile)*  

**KRADFILE2** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright James Rose  
Licence URL: http://www.kanjicafe.com/kradfile_license.htm  
Source File URL: http://users.monash.edu/~jwb/kradinf.html  *(kradzip.zip\kradfile2)*  

**RADKFILEX** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright Jim Breen & The Electronic Dictionary Research and Development Group  
Licence URL: http://www.edrdg.org/edrdg/licence.html  
Source File URL: http://users.monash.edu/~jwb/kradinf.html  *(kradzip.zip\radkfilex)*  

**KanjiVG** ([CC BY-SA 3](https://creativecommons.org/licenses/by-sa/3.0/))  
Copyright Ulrich Apel  
Licence URL: http://kanjivg.tagaini.net/  
Source File URL: https://github.com/KanjiVG/kanjivg/releases  *(kanjivg-___.xml.gz)*  

---

_**Notes:**_

_This is a large library due to the embedded Japanese and kanji resource files._

_The Japanese dictionary contains 185,919 entries and requires ~370MB of memory (and takes a few seconds to create)._

_The proper name dictionary contains 740,595 entries and requires ~400MB of memory (and takes a few seconds to create)._

_The kanji dictionary contains 13,108 entries and requires ~50MB of memory._

---

[![NuGet](https://img.shields.io/nuget/v/Wacton.Desu.svg?maxAge=2592000)](https://www.nuget.org/packages/Wacton.Desu/)

---

<img src="https://gitlab.com/Wacton/Desu/raw/master/Desu/Resources/Desu.png" width="32" height="32">
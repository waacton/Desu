# <img src="https://gitlab.com/Wacton/Desu/raw/master/Desu/Resources/Desu.png" width="32" height="32"> Desu
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
<br>

**Proper name dictionary** (JMnedict)
```c#
using Wacton.Desu.Names;
...
var nameEntries = NameDictionary.ParseEntries();
var nameEntries = await NameDictionary.ParseEntriesAsync();
```
<br>

**Kanji dictionary** (KANJIDIC + KRADFILE + KanjiVG) <br>
This includes radical decomposition and SVG stroke paths where applicable (using `RadicalLookup` and `StrokeLookup`)
```c#
using Wacton.Desu.Kanji;
...
var kanjiEntries = KanjiDictionary.ParseEntries();
var kanjiEntries = await KanjiDictionary.ParseEntriesAsync();
```
<br>

**Radical lookup** (RADKFILE/KRADFILE)
```c#
using Wacton.Desu.Radicals;
...
var kanjiToRadicals = RadicalLookup.ParseKanjiToRadicals();
var kanjiToRadicals = await RadicalLookup.ParseKanjiToRadicalsAsync();
...
var radicalToKanjis = RadicalLookup.ParseRadicalToKanjis();
var radicalToKanjis = await RadicalLookup.ParseRadicalToKanjisAsync();
```
<br>

**Stroke lookup** (KanjiVG)
```c#
using Wacton.Desu.Strokes;
...
var kanjiToStrokes = StrokeLookup.ParseKanjiToStrokes();
var kanjiToStrokes = await StrokeLookup.ParseKanjiToStrokesAsync();
```
<br>

**Rōmaji transliteration** ⚠️ _Untested - use with caution_ ⚠️
```c#
using Wacton.Desu.Romaji;
...
var transliterator = new Transliterator();
var romaji = transliterator.GetRomaji("です"); // romaji == "desu"
```
<br>

_**Notes:** This is a large library due to the embedded resource files._
_They can take a few seconds to parse so it is recommended to use the asynchronous API where possible._
_Example usages can be found in the [Desu.ExampleConsole](https://gitlab.com/Wacton/Desu/tree/master/Desu.ExampleConsole) and [Desu.ExampleWpf](https://gitlab.com/Wacton/Desu/tree/master/Desu.ExampleWpf) projects._
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

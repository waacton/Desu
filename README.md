# Desu
Wacton.Desu provides a .NET interface to [JMdict](http://www.edrdg.org/jmdict/j_jmdict.html) (Japanese-multilingual dictionary), with a data structure that does not rely on magic strings.  All JMdict elements have object representations where appropriate.

## How to use
Can be installed as a [NuGet package](https://www.nuget.org/packages/Wacton.Desu/):
```
Install-Package Wacton.Desu
```

Create a ```JapaneseDictionary``` object and get the entries:
```c#
var dictionary = new JapaneseDictionary();
var entries = dictionary.GetEntries();
```

An example can be found in the [Desu.Example project](https://github.com/waacton/Desu/tree/master/Desu.Example).

---

**Note:** Due to containing an embedded copy of JMdict, this is a large library.  Parsing the 170,000+ entries takes a few seconds, and requires ~250MB of memory.

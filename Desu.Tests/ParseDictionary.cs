using NUnit.Framework;
using System;
using Wacton.Desu.Japanese;
using Wacton.Desu.Kanji;
using Wacton.Desu.Names;
using Wacton.Desu.Radicals;
using Wacton.Desu.Strokes;

namespace Wacton.Desu.Tests
{
    public class ParseDictionary
    {
        [Test]
        public void Japanese()
        {
            try
            {
                JapaneseDictionary.ParseEntries();
                JapaneseDictionary.ParseCreationDate();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test]
        public void Name()
        {
            try
            {
                NameDictionary.ParseEntries();
                NameDictionary.ParseCreationDate();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test]
        public void Kanji()
        {
            try
            {
                KanjiDictionary.ParseEntries();
                KanjiDictionary.ParseCreationDate();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test]
        public void Radical()
        {
            try
            {
                RadicalLookup.ParseKanjiToRadicals();
                RadicalLookup.ParseRadicalToKanjis();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test]
        public void Stroke()
        {
            try
            {
                StrokeLookup.ParseKanjiToStrokes();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
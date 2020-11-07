using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Enums;
using Wacton.Desu.Japanese;
using Wacton.Desu.Kanji;
using Wacton.Desu.Names;

namespace Wacton.Desu.Tests
{
    public class UnusedEnums
    {
        private IEnumerable<IJapaneseEntry> japaneseEntries;
        private IEnumerable<INameEntry> nameEntries;
        private IEnumerable<IKanjiEntry> kanjiEntries;

        private static readonly string _ = "彁";

        [OneTimeSetUp]
        public void Setup()
        {
            japaneseEntries = JapaneseDictionary.ParseEntries();
            nameEntries = NameDictionary.ParseEntries();
            kanjiEntries = KanjiDictionary.ParseEntries();
        }

        [Test]
        public void BushuRadicalClassicals()
        {
            var usedEnums = kanjiEntries.SelectMany(x => x.BushuRadicals).OfType<BushuRadicalClassical>().Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new BushuRadicalClassical(_, 0, _));
        }

        [Test]
        public void BushuRadicalTypes()
        {
            var usedEnums = kanjiEntries.SelectMany(x => x.BushuRadicals).Select(x => x.Type).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new BushuRadicalType(_, _));
        }

        [Test]
        public void CodepointTypes()
        {
            var usedEnums = kanjiEntries.SelectMany(x => x.Codepoints).Select(x => x.Type).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new CodepointType(_, _, _));
        }

        [Test]
        public void Dialects()
        {
            var usedEnums = japaneseEntries.SelectMany(x => x.Senses).SelectMany(x => x.Dialects).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new Dialect(_, _));
        }

        [Test]
        public void Fields()
        {
            var usedEnums = japaneseEntries.SelectMany(x => x.Senses).SelectMany(x => x.Fields).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new Field(_, _));
        }

        [Test]
        public void GlossTypes()
        {
            var usedEnums = Enumerable.Concat(
                japaneseEntries.SelectMany(x => x.Senses).SelectMany(x => x.Glosses).Select(x => x.Type),
                japaneseEntries.SelectMany(x => x.Senses).SelectMany(x => x.LoanwordSources).Select(x => x.Type)
                ).Distinct();

            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new GlossType(_, _));
        }

        [Test]
        public void Grades()
        {
            var usedEnums = kanjiEntries.Select(x => x.Grade).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new Grade(_, 0));
        }

        [Test]
        public void KanjiInformations()
        {
            var usedEnums = Enumerable.Concat(
                japaneseEntries.SelectMany(x => x.Kanjis).SelectMany(x => x.Informations),
                nameEntries.SelectMany(x => x.Kanjis).SelectMany(x => x.Informations)
                ).Distinct();

            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new KanjiInformation(_, _));
        }

        [Test]
        public void Languages()
        {
            var usedEnums = Enumerable.Concat(
                japaneseEntries.SelectMany(x => x.Senses).SelectMany(x => x.Glosses).Select(x => x.Language),
                japaneseEntries.SelectMany(x => x.Senses).SelectMany(x => x.LoanwordSources).Select(x => x.Language)
                ).Distinct();

            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new Language(_, _));
        }

        [Test]
        public void Miscellanea()
        {
            var usedEnums = japaneseEntries.SelectMany(x => x.Senses).SelectMany(x => x.Miscellanea).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new Miscellaneous(_, _));
        }

        [Test]
        public void NameTypes()
        {
            var usedEnums = nameEntries.SelectMany(x => x.Translations).SelectMany(x => x.NameTypes).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new NameType(_, _));
        }

        [Test]
        public void PartsOfSpeech()
        {
            var usedEnums = japaneseEntries.SelectMany(x => x.Senses).SelectMany(x => x.PartsOfSpeech).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new PartOfSpeech(_, _));
        }

        [Test]
        public void Priorities()
        {
            var usedEnums = 
                japaneseEntries.SelectMany(x => x.Kanjis).SelectMany(x => x.Priorities).Concat(
                japaneseEntries.SelectMany(x => x.Readings).SelectMany(x => x.Priorities).Concat(
                nameEntries.SelectMany(x => x.Kanjis).SelectMany(x => x.Priorities).Concat(
                nameEntries.SelectMany(x => x.Readings).SelectMany(x => x.Priorities)
                ))).Distinct();

            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new Priority(_, _));
        }

        [Test]
        public void QueryCodeTypes()
        {
            var usedEnums = kanjiEntries.SelectMany(x => x.QueryCodes).Select(x => x.Type).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new QueryCodeType(_, _, _));
        }

        [Test]
        public void ReadingInformations()
        {
            var usedEnums = Enumerable.Concat(
                japaneseEntries.SelectMany(x => x.Readings).SelectMany(x => x.Informations),
                nameEntries.SelectMany(x => x.Readings).SelectMany(x => x.Informations)
                ).Distinct();

            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new ReadingInformation(_, _));
        }

        [Test]
        public void ReadingTypes()
        {
            var usedEnums = kanjiEntries.SelectMany(x => x.Readings).Select(x => x.Type).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new ReadingType(_, _));
        }

        [Test]
        public void ReferenceTypes()
        {
            var usedEnums = kanjiEntries.SelectMany(x => x.References).Select(x => x.Type).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new ReferenceType(_, _, _));
        }

        [Test]
        public void SkipMisclassifications()
        {
            var usedEnums = kanjiEntries.SelectMany(x => x.QueryCodes).Select(x => x.SkipMisclassification).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new SkipMisclassification(_, _));
        }

        [Test]
        public void VariantTypes()
        {
            var usedEnums = kanjiEntries.SelectMany(x => x.Variants).Select(x => x.Type).Distinct();
            AssertNoUnusedEnums(usedEnums);
            AssertUnusedEnumDetected(usedEnums, new VariantType(_, _, _));
        }

        private static void AssertNoUnusedEnums<T>(IEnumerable<T> usedEnums) where T: Enumeration
        {
            var allEnums = Enumeration.GetAll<T>();
            var unusedEnums = allEnums.Where(x => !usedEnums.Contains(x));
            Assert.That(unusedEnums, Is.Empty);
        }

        private static void AssertUnusedEnumDetected<T>(IEnumerable<T> usedEnums, T extraEnum) where T : Enumeration
        {
            var allEnums = Enumeration.GetAll<T>().Concat(new List<T> { extraEnum });
            var unusedEnums = allEnums.Where(x => !usedEnums.Contains(x));
            Assert.That(unusedEnums.Single(), Is.EqualTo(extraEnum));
        }
    }
}
using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Wacton.Desu.Tests
{
    public static class StrokeAssert
    {
        public static void AssertList(IEnumerable<string> expectedList, Func<IEnumerable<string>> actualListFunc)
        {
            if (expectedList == null)
            {
                Assert.Throws<KeyNotFoundException>(() => actualListFunc());
            }
            else
            {
                var actualList = actualListFunc();
                Assert.That(actualList, Is.EqualTo(expectedList));
            }
        }
    }
}
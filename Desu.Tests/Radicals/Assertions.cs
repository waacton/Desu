namespace Wacton.Desu.Tests.Radicals;

using System;
using System.Collections.Generic;
using NUnit.Framework;

public static class Assertions
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
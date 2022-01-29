namespace Wacton.Desu.Tests.Utils;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Wacton.Desu.Enums;

public static class AssertUtils
{
    public static void AssertPropertyEquality<T>(T first, T second, Func<T, object> getProperty)
    {
        AssertObjectEquality(getProperty(first), getProperty(second));
    }
    
    public static void AssertListEquality<T>(IEnumerable<T> first, IEnumerable<T> second, Action<T, T> assertAction)
    {
        var firstList = first.ToList();
        var secondList = second.ToList();
        
        if (firstList.Count != secondList.Count)
        {
            Assert.Fail("Lists are different lengths");
        }
            
        for (var i = 0; i < firstList.Count; i++)
        {
            var firstItem = firstList.ElementAt(i);
            var secondItem = secondList.ElementAt(i);
            assertAction(firstItem, secondItem);
        }
    }
    
    private static void AssertObjectEquality(object first, object second)
    {
        switch (first)
        {
            // strings reference equality depends
            // literals will be equal, but different from strings parsed at runtime
            // also handle this before 'IEnumerable' case as it is also just an IEnumerable of chars
            case string: 
                Assert.That(first, Is.EqualTo(second));
                break;
                
            // recursively check each list item for equality
            case IEnumerable: 
                var firstList = (first as IEnumerable).Cast<object>().ToList();
                var secondList = (second as IEnumerable).Cast<object>().ToList();
                Assert.That(ReferenceEquals(first, second), Is.False);
                Assert.That(firstList!.SequenceEqual(secondList!), Is.True);
                AssertListEquality(firstList, secondList, AssertObjectEquality);
                break;
                
            // custom Enumerations should be reference & value equal
            case Enumeration:
                Assert.That(ReferenceEquals(first, second), Is.True);
                Assert.That(first, Is.EqualTo(second));
                Assert.That(first.GetHashCode(), Is.EqualTo(second.GetHashCode()));
                Assert.That(first.ToString(), Is.EqualTo(second.ToString()));
                break;
                
            // fundamental types used by entries are value equal but not reference equal
            // (not concerned about higher-level types like JapaneseEntry or Sense being value equal)
            case not null:
                Assert.That(ReferenceEquals(first, second), Is.False);
                Assert.That(first, Is.EqualTo(second));
                Assert.That(first.GetHashCode(), Is.EqualTo(second.GetHashCode()));
                Assert.That(first.ToString(), Is.EqualTo(second.ToString()));
                break;
        }
    }
}
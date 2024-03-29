﻿namespace Wacton.Desu.Tests;

using System.Collections.Generic;
using NUnit.Framework;
using Wacton.Desu.Radicals;

public class GlyphReplacement
{
    [Test]
    public void ByString()
    {
        const string input = "化个并刈込尚忙扎汁犯艾邦阡老杰礼疔禹初買滴乞";
        const string expected = "⺅𠆢丷⺉⻌⺌⺖⺘⺡⺨⺾⻏⻖⺹⺣⺭⽧⽱⻂⺲啇𠂉";
        var actual = GlyphMap.Replace(input);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ByList()
    {
        var input = new List<string> { "化", "个", "并", "刈", "込", "尚", "忙", "扎", "汁", "犯", "艾", "邦", "阡", "老", "杰", "礼", "疔", "禹", "初", "買", "滴", "乞" };
        var expected = new List<string> { "⺅", "𠆢", "丷", "⺉", "⻌", "⺌", "⺖", "⺘", "⺡", "⺨", "⺾", "⻏", "⻖", "⺹", "⺣", "⺭", "⽧", "⽱", "⻂", "⺲", "啇", "𠂉" };
        var actual = GlyphMap.Replace(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
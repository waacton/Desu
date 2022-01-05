namespace Wacton.Desu.Radicals
{
    using System.Collections.Generic;

    internal class GlyphMap
    {
        public static readonly Dictionary<string, string> Replacements = new Dictionary<string, string>()
        {
            { "化", "⺅" }, // u+2E85
            { "个", "𠆢" }, // u+201A2    [replaces kradfile mapping: ⼉ u+2F09]
            { "并", "丷" }, // u+4E37     [replaces kradfile mapping: "none available"]
            { "刈", "⺉" }, // u+2E89
            { "込", "⻌" }, // u+2ECC
            { "尚", "⺌" }, // u+2E8C
            { "忙", "⺖" }, // u+2E96
            { "扎", "⺘" }, // u+2E98     [replaces kradfile mapping: ⺗ u+2E97]
            { "汁", "⺡" }, // u+2EA1
            { "犯", "⺨" }, // u+2EA8
            { "艾", "⺾" }, // u+2EBE
            { "邦", "⻏" }, // u+2ECF
            { "阡", "⻖" }, // u+2ED6     [replaces kradfile mapping: of ⻙ u+2ED9]
            { "老", "⺹" }, // u+2EB9
            { "杰", "⺣" }, // u+2EA3
            { "礼", "⺭" }, // u+2EAD
            { "疔", "⽧" }, // u+2F67
            { "禹", "⽱" }, // u+2F71
            { "初", "⻂" }, // u+2EC2
            { "買", "⺲" }, // u+2EB2
            { "滴", "啇" }, // u+5547
            { "乞", "𠂉" }, // u+20089    [not listed in kradfile mapping, presumable would say "none available"]
        };

        public static string Replace(string text)
        {
            var result = text;
            foreach(var kvp in Replacements)
            {
                result = result.Replace(kvp.Key, kvp.Value);
            }

            return result;
        }

        public static List<string> Replace(List<string> list)
        {
            var result = new List<string>();
            foreach(var item in list)
            {
                result.Add(Replace(item));
            }

            return result;
        }
    }
}

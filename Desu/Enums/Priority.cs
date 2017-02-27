namespace Wacton.Desu.Enums
{
    using System.Collections.Generic;
    using System.Linq;

    public class Priority : Enumeration
    {
        public static readonly Priority Loanword1 = new Priority("Loanword1", "gai1");
        public static readonly Priority Loanword2 = new Priority("Loanword2", "gai2");
        public static readonly Priority Ichimango1 = new Priority("Ichimango1", "ichi1");
        public static readonly Priority Ichimango2 = new Priority("Ichimango2", "ichi2");
        public static readonly Priority Newspaper1 = new Priority("Newspaper1", "news1");
        public static readonly Priority Newspaper2 = new Priority("Newspaper2", "news2");
        public static readonly Priority Frequency1 = new Priority("Frequency1", "nf01");
        public static readonly Priority Frequency2 = new Priority("Frequency2", "nf02");
        public static readonly Priority Frequency3 = new Priority("Frequency3", "nf03");
        public static readonly Priority Frequency4 = new Priority("Frequency4", "nf04");
        public static readonly Priority Frequency5 = new Priority("Frequency5", "nf05");
        public static readonly Priority Frequency6 = new Priority("Frequency6", "nf06");
        public static readonly Priority Frequency7 = new Priority("Frequency7", "nf07");
        public static readonly Priority Frequency8 = new Priority("Frequency8", "nf08");
        public static readonly Priority Frequency9 = new Priority("Frequency9", "nf09");
        public static readonly Priority Frequency10 = new Priority("Frequency10", "nf10");
        public static readonly Priority Frequency11 = new Priority("Frequency11", "nf11");
        public static readonly Priority Frequency12 = new Priority("Frequency12", "nf12");
        public static readonly Priority Frequency13 = new Priority("Frequency13", "nf13");
        public static readonly Priority Frequency14 = new Priority("Frequency14", "nf14");
        public static readonly Priority Frequency15 = new Priority("Frequency15", "nf15");
        public static readonly Priority Frequency16 = new Priority("Frequency16", "nf16");
        public static readonly Priority Frequency17 = new Priority("Frequency17", "nf17");
        public static readonly Priority Frequency18 = new Priority("Frequency18", "nf18");
        public static readonly Priority Frequency19 = new Priority("Frequency19", "nf19");
        public static readonly Priority Frequency20 = new Priority("Frequency20", "nf20");
        public static readonly Priority Frequency21 = new Priority("Frequency21", "nf21");
        public static readonly Priority Frequency22 = new Priority("Frequency22", "nf22");
        public static readonly Priority Frequency23 = new Priority("Frequency23", "nf23");
        public static readonly Priority Frequency24 = new Priority("Frequency24", "nf24");
        public static readonly Priority Frequency25 = new Priority("Frequency25", "nf25");
        public static readonly Priority Frequency26 = new Priority("Frequency26", "nf26");
        public static readonly Priority Frequency27 = new Priority("Frequency27", "nf27");
        public static readonly Priority Frequency28 = new Priority("Frequency28", "nf28");
        public static readonly Priority Frequency29 = new Priority("Frequency29", "nf29");
        public static readonly Priority Frequency30 = new Priority("Frequency30", "nf30");
        public static readonly Priority Frequency31 = new Priority("Frequency31", "nf31");
        public static readonly Priority Frequency32 = new Priority("Frequency32", "nf32");
        public static readonly Priority Frequency33 = new Priority("Frequency33", "nf33");
        public static readonly Priority Frequency34 = new Priority("Frequency34", "nf34");
        public static readonly Priority Frequency35 = new Priority("Frequency35", "nf35");
        public static readonly Priority Frequency36 = new Priority("Frequency36", "nf36");
        public static readonly Priority Frequency37 = new Priority("Frequency37", "nf37");
        public static readonly Priority Frequency38 = new Priority("Frequency38", "nf38");
        public static readonly Priority Frequency39 = new Priority("Frequency39", "nf39");
        public static readonly Priority Frequency40 = new Priority("Frequency40", "nf40");
        public static readonly Priority Frequency41 = new Priority("Frequency41", "nf41");
        public static readonly Priority Frequency42 = new Priority("Frequency42", "nf42");
        public static readonly Priority Frequency43 = new Priority("Frequency43", "nf43");
        public static readonly Priority Frequency44 = new Priority("Frequency44", "nf44");
        public static readonly Priority Frequency45 = new Priority("Frequency45", "nf45");
        public static readonly Priority Frequency46 = new Priority("Frequency46", "nf46");
        public static readonly Priority Frequency47 = new Priority("Frequency47", "nf47");
        public static readonly Priority Frequency48 = new Priority("Frequency48", "nf48");
        public static readonly Priority SpecialCommon1 = new Priority("SpecialCommon1", "spec1");
        public static readonly Priority SpecialCommon2 = new Priority("SpecialCommon2", "spec2");

        public static readonly IEnumerable<Priority> Loanword = GetAll<Priority>().Where(priority => priority.DisplayName.StartsWith("Loanword"));
        public static readonly IEnumerable<Priority> Ichimango = GetAll<Priority>().Where(priority => priority.DisplayName.StartsWith("Ichimango"));
        public static readonly IEnumerable<Priority> Newspaper = GetAll<Priority>().Where(priority => priority.DisplayName.StartsWith("Newspaper"));
        public static readonly IEnumerable<Priority> Frequency = GetAll<Priority>().Where(priority => priority.DisplayName.StartsWith("Frequency"));
        public static readonly IEnumerable<Priority> SpecialCommon = GetAll<Priority>().Where(priority => priority.DisplayName.StartsWith("SpecialCommon"));

        public string Code { get; }

        public Priority(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}

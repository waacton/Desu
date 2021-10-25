namespace Wacton.Desu.Enums
{
    using System.Collections.Generic;
    using System.Linq;

    // for details see https://www.edrdg.org/jmdictdb/cgi-bin/edhelp.py?svc=jmdict&sid=#kwabbr (Freq)
    public class Priority : Enumeration
    {
        public static readonly Priority Loanword1 = new Priority(nameof(Loanword1), "gai1");
        public static readonly Priority Loanword2 = new Priority(nameof(Loanword2), "gai2");
        public static readonly Priority Ichimango1 = new Priority(nameof(Ichimango1), "ichi1");
        public static readonly Priority Ichimango2 = new Priority(nameof(Ichimango2), "ichi2");
        public static readonly Priority Newspaper1 = new Priority(nameof(Newspaper1), "news1");
        public static readonly Priority Newspaper2 = new Priority(nameof(Newspaper2), "news2");
        public static readonly Priority Frequency1 = new Priority(nameof(Frequency1), "nf01");
        public static readonly Priority Frequency2 = new Priority(nameof(Frequency2), "nf02");
        public static readonly Priority Frequency3 = new Priority(nameof(Frequency3), "nf03");
        public static readonly Priority Frequency4 = new Priority(nameof(Frequency4), "nf04");
        public static readonly Priority Frequency5 = new Priority(nameof(Frequency5), "nf05");
        public static readonly Priority Frequency6 = new Priority(nameof(Frequency6), "nf06");
        public static readonly Priority Frequency7 = new Priority(nameof(Frequency7), "nf07");
        public static readonly Priority Frequency8 = new Priority(nameof(Frequency8), "nf08");
        public static readonly Priority Frequency9 = new Priority(nameof(Frequency9), "nf09");
        public static readonly Priority Frequency10 = new Priority(nameof(Frequency10), "nf10");
        public static readonly Priority Frequency11 = new Priority(nameof(Frequency11), "nf11");
        public static readonly Priority Frequency12 = new Priority(nameof(Frequency12), "nf12");
        public static readonly Priority Frequency13 = new Priority(nameof(Frequency13), "nf13");
        public static readonly Priority Frequency14 = new Priority(nameof(Frequency14), "nf14");
        public static readonly Priority Frequency15 = new Priority(nameof(Frequency15), "nf15");
        public static readonly Priority Frequency16 = new Priority(nameof(Frequency16), "nf16");
        public static readonly Priority Frequency17 = new Priority(nameof(Frequency17), "nf17");
        public static readonly Priority Frequency18 = new Priority(nameof(Frequency18), "nf18");
        public static readonly Priority Frequency19 = new Priority(nameof(Frequency19), "nf19");
        public static readonly Priority Frequency20 = new Priority(nameof(Frequency20), "nf20");
        public static readonly Priority Frequency21 = new Priority(nameof(Frequency21), "nf21");
        public static readonly Priority Frequency22 = new Priority(nameof(Frequency22), "nf22");
        public static readonly Priority Frequency23 = new Priority(nameof(Frequency23), "nf23");
        public static readonly Priority Frequency24 = new Priority(nameof(Frequency24), "nf24");
        public static readonly Priority Frequency25 = new Priority(nameof(Frequency25), "nf25");
        public static readonly Priority Frequency26 = new Priority(nameof(Frequency26), "nf26");
        public static readonly Priority Frequency27 = new Priority(nameof(Frequency27), "nf27");
        public static readonly Priority Frequency28 = new Priority(nameof(Frequency28), "nf28");
        public static readonly Priority Frequency29 = new Priority(nameof(Frequency29), "nf29");
        public static readonly Priority Frequency30 = new Priority(nameof(Frequency30), "nf30");
        public static readonly Priority Frequency31 = new Priority(nameof(Frequency31), "nf31");
        public static readonly Priority Frequency32 = new Priority(nameof(Frequency32), "nf32");
        public static readonly Priority Frequency33 = new Priority(nameof(Frequency33), "nf33");
        public static readonly Priority Frequency34 = new Priority(nameof(Frequency34), "nf34");
        public static readonly Priority Frequency35 = new Priority(nameof(Frequency35), "nf35");
        public static readonly Priority Frequency36 = new Priority(nameof(Frequency36), "nf36");
        public static readonly Priority Frequency37 = new Priority(nameof(Frequency37), "nf37");
        public static readonly Priority Frequency38 = new Priority(nameof(Frequency38), "nf38");
        public static readonly Priority Frequency39 = new Priority(nameof(Frequency39), "nf39");
        public static readonly Priority Frequency40 = new Priority(nameof(Frequency40), "nf40");
        public static readonly Priority Frequency41 = new Priority(nameof(Frequency41), "nf41");
        public static readonly Priority Frequency42 = new Priority(nameof(Frequency42), "nf42");
        public static readonly Priority Frequency43 = new Priority(nameof(Frequency43), "nf43");
        public static readonly Priority Frequency44 = new Priority(nameof(Frequency44), "nf44");
        public static readonly Priority Frequency45 = new Priority(nameof(Frequency45), "nf45");
        public static readonly Priority Frequency46 = new Priority(nameof(Frequency46), "nf46");
        public static readonly Priority Frequency47 = new Priority(nameof(Frequency47), "nf47");
        public static readonly Priority Frequency48 = new Priority(nameof(Frequency48), "nf48");
        public static readonly Priority SpecialCommon1 = new Priority(nameof(SpecialCommon1), "spec1");
        public static readonly Priority SpecialCommon2 = new Priority(nameof(SpecialCommon2), "spec2");

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

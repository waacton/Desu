namespace Wacton.Desu.Enums
{
    public class Dialect : Enumeration
    {
        public static readonly Dialect Hokkaido = new Dialect(nameof(Hokkaido), "Hokkaido-ben");
        public static readonly Dialect Kansai = new Dialect(nameof(Kansai), "Kansai-ben");
        public static readonly Dialect Kantou = new Dialect(nameof(Kantou), "Kantou-ben");
        public static readonly Dialect Kyoto = new Dialect(nameof(Kyoto), "Kyoto-ben");
        public static readonly Dialect Kyuushuu = new Dialect(nameof(Kyuushuu), "Kyuushuu-ben");
        public static readonly Dialect Nagano = new Dialect(nameof(Nagano), "Nagano-ben");
        public static readonly Dialect Osaka = new Dialect(nameof(Osaka), "Osaka-ben");
        public static readonly Dialect Ryuukyuu = new Dialect(nameof(Ryuukyuu), "Ryuukyuu-ben");
        public static readonly Dialect Tosa = new Dialect(nameof(Tosa), "Tosa-ben");
        public static readonly Dialect Touhoku = new Dialect(nameof(Touhoku), "Touhoku-ben");
        public static readonly Dialect Tsugaru = new Dialect(nameof(Tsugaru), "Tsugaru-ben");

        public string Code { get; }

        public Dialect(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}

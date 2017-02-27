namespace Wacton.Desu.Enums
{
    public class Dialect : Enumeration
    {
        public static readonly Dialect Hokkaido = new Dialect("Hokkaido", "Hokkaido-ben");
        public static readonly Dialect Kansai = new Dialect("Kansai", "Kansai-ben");
        public static readonly Dialect Kantou = new Dialect("Kantou", "Kantou-ben");
        public static readonly Dialect Kyoto = new Dialect("Kyoto", "Kyoto-ben");
        public static readonly Dialect Kyuushuu = new Dialect("Kyuushuu", "Kyuushuu-ben");
        public static readonly Dialect Nagano = new Dialect("Nagano", "Nagano-ben");
        public static readonly Dialect Osaka = new Dialect("Osaka", "Osaka-ben");
        public static readonly Dialect Ryuukyuu = new Dialect("Ryuukyuu", "Ryuukyuu-ben");
        public static readonly Dialect Tosa = new Dialect("Tosa", "Tosa-ben");
        public static readonly Dialect Touhoku = new Dialect("Touhoku", "Touhoku-ben");
        public static readonly Dialect Tsugaru = new Dialect("Tsugaru", "Tsugaru-ben");

        public string Code { get; }

        public Dialect(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}

namespace Wacton.Desu.Japanese
{
    using Wacton.Desu.Enums;

    public interface IGloss
    {
        string Term { get; }
        Language Language { get; }
        GlossType Type { get; }

        /// <summary> This property appears to be unused (JMdict 1.08) </summary>
        string Gender { get; }
    }
}

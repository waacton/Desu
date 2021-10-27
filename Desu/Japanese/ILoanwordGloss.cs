namespace Wacton.Desu.Japanese
{
    public interface ILoanwordGloss : IGloss
    {
        bool IsPartial { get; }
        bool IsWasei { get; }
    }
}

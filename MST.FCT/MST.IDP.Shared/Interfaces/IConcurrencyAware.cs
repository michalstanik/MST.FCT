namespace MST.IDP.Shared.Interfaces
{
    public interface IConcurrencyAware
    {
        string ConcurrencyStamp { get; set; }
    }
}

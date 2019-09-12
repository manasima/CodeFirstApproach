namespace mis.contracts
{
    public interface IRepositoryWrapper
    {
        IMemberRepository Member { get; }
        ICountryRepository Country { get; }
        void Save();
    }
}
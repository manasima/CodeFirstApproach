using mis.contracts;
using mis.data;
using mis.data.Models;

namespace mis.repository
{
    public class CountryRepository : RepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
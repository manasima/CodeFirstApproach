using mis.contracts;
using mis.data;

namespace mis.repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext repositoryContext;
        private IMemberRepository memberRepository;
        private ICountryRepository countryRepository;

        public IMemberRepository Member
        {
            get
            {
                if (memberRepository == null)
                {
                    memberRepository = new MemberRepository(repositoryContext);
                }

                return memberRepository;
            }
        }

        public ICountryRepository Country
        {
            get
            {
                if (countryRepository == null)
                {
                    countryRepository = new CountryRepository(repositoryContext);
                }

                return countryRepository;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public void Save()
        {
            repositoryContext.SaveChanges();
        }

    }
}
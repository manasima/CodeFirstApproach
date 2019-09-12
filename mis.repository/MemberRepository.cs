using System.Collections.Generic;
using System.Linq;
using mis.contracts;
using mis.data;
using mis.data.Models;

namespace mis.repository
{
    public class MemberRepository : RepositoryBase<Member>, IMemberRepository
    {
        public MemberRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return FindAll()
                .OrderBy(m => m.MemberId)
                .ToList();
        }
    }
}
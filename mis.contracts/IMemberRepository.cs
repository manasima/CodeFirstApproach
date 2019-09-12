using System.Collections.Generic;
using mis.data.Models;

namespace mis.contracts
{
    public interface IMemberRepository : IRepositoryBase<Member>
    {
        IEnumerable<Member> GetAllMembers();
    }
}
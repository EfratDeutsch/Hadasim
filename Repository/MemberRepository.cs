using Entities.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{

    public class MemberRepository : IMemberRepository
    {
        private readonly HadasimContext _HadasimContext;
        public MemberRepository(HadasimContext HadasimContext)
        {
            _HadasimContext = HadasimContext;

        }

        public async Task<IEnumerable<HmoMember>> GetAllMembers()
        {
            IEnumerable<HmoMember> memberList = await _HadasimContext.HmoMembers.ToListAsync();
            return memberList;
        }

        public async Task<HmoMember> addMember(HmoMember member)
        {
            await _HadasimContext.AddAsync(member);
            await _HadasimContext.SaveChangesAsync();
            return member;
        }
    }
}

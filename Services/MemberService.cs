using Entities.DBModels;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _IMemberRepository;
        public MemberService(IMemberRepository IMemberRepository)
        {
            _IMemberRepository = IMemberRepository;
        }
        public async Task<IEnumerable<HmoMember>> GetAllMembers()
        {
            IEnumerable<HmoMember> memberList = await _IMemberRepository.GetAllMembers();
            if (memberList != null)
                return memberList;
            else return null;
        }

        public async Task <HmoMember> addMember(HmoMember member)
        {
            HmoMember newMember = await _IMemberRepository.addMember(member);
            if (newMember != null)
                return newMember;
            else return null;
        }
    }
}

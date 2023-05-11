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
        public async Task<HmoMember> getMemberBYId(string id)
        {
            HmoMember member = await _IMemberRepository.getMemberBYId(id);
            if (member != null)
                return member;
            else return null;
        }

        public async Task <int> getNumOfNotImmuneMembers()
        {
            int numOfNotImmuneMembers = await _IMemberRepository.getNumOfNotImmuneMembers();
            return numOfNotImmuneMembers;
        }
        public async Task <Dictionary<DateTime,int>> getNumOfActivePatients()
        {
            Dictionary<DateTime, int> dic = await _IMemberRepository.getNumOfActivePatients();
            if (dic != null)
                return dic;
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

﻿using Entities.DBModels;

namespace Repository
{
    public interface IMemberRepository
    {
        Task<IEnumerable<HmoMember>> GetAllMembers(); 
        Task<HmoMember> getMemberBYId(string id);
        Task<int> getNumOfNotImmuneMembers();
        Task<Dictionary<DateTime, int>> getNumOfActivePatients();
        Task<int> getNumOfActivePatientsForSpecificDay(DateTime date);
        Task<HmoMember> addMember(HmoMember member);
      
    }
}
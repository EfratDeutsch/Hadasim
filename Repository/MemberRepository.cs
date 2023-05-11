using Entities.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public async Task<HmoMember> getMemberBYId(string id)
        {
            var query = _HadasimContext.HmoMembers.Where(member =>
                       (member.IdentityNumber == id)
                   ).ToArray<HmoMember>();

            return  query.FirstOrDefault();
        }
        public async Task <int> getNumOfNotImmuneMembers()
        {
            List<HmoMember> membersNotVaccinated = _HadasimContext.HmoMembers
            .Where(m => !_HadasimContext.Vaccinations.Any(v => v.UserId == m.UserId))
           .ToList();
            int count = membersNotVaccinated.Count;
            return count;
        }
        public async Task <Dictionary<DateTime,int>> getNumOfActivePatients()
        {
            var currentDate = DateTime.Today;

            var seakPeople = _HadasimContext.HmoMembers
                .Where(m => m.PositiveResultDate.HasValue && m.PositiveResultDate.Value >= new DateTime(currentDate.Year, currentDate.Month, 1) && m.PositiveResultDate.Value < new DateTime(currentDate.Year, currentDate.Month, 1).AddMonths(1))
                .ToList();

            var seakPeopleByWeek = seakPeople
                .GroupBy(m => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(m.PositiveResultDate.Value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday))
                .ToDictionary(g => GetFirstDateOfWeek(currentDate.Year, currentDate.Month, g.Key), g => g.Count());

            var newDict = new Dictionary<DateTime, int>();
            foreach (var kvp in seakPeopleByWeek)
            {
                newDict.Add(kvp.Key, kvp.Value);
            }
            return newDict;
        }
        private static DateTime GetFirstDateOfWeek(int year, int month, int week)
        {
            var jan1 = new DateTime(year, 1, 1);
            var daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            var firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            var firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = week;
            if (firstWeek <= 1)
            {
                weekNum -= 1;
            }

            var result = firstThursday.AddDays(weekNum * 7);
            return result.AddDays(-3);
        }
        public async Task <int> getNumOfActivePatientsForSpecificDay(DateTime date)
        {
            var activePatientsCount = _HadasimContext.HmoMembers
         .Count(member => member.PositiveResultDate.HasValue &&
                         member.PositiveResultDate >= date.AddDays(-14));

            return activePatientsCount;
        }
        public async Task<HmoMember> addMember(HmoMember member)
        {
            await _HadasimContext.AddAsync(member);
            await _HadasimContext.SaveChangesAsync();
            return member;
        }
        
    }
}

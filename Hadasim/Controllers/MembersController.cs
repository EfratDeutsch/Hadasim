using Microsoft.AspNetCore.Mvc;
using Entities.DBModels;
using System.Collections;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hadasim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService _IMembersService;
        public MembersController(IMemberService membersService)
        {
            _IMembersService = membersService;
        }
      
        // GET: api/<MembersController>
        [HttpGet]
        public async Task <IEnumerable<HmoMember>> Get()
        {
           IEnumerable <HmoMember> memberList =await _IMembersService.GetAllMembers();
            if (memberList != null)
                return memberList;
            else return null;
        }
        
      
        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MembersController>
        [HttpPost]
        public async Task<ActionResult<HmoMember>> Post([FromBody] HmoMember member)
        {
            HmoMember newMember = await _IMembersService.addMember(member);
            if (newMember != null)
                return newMember;
            else return null;
        }

        // PUT api/<MembersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MembersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

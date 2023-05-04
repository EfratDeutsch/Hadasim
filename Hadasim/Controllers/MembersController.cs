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
        
        
        
        
        //public async Task<ActionResult<UserDTO>> Get(string userName, string password)
        //{
        //    User user = await _IUserService.getUser(userName, password);
        //    UserDTO userDto = _mapper.Map<UserDTO>(user);


        //    if (userDto != null)
        //        return Ok(userDto);
        //    else return StatusCode(204);


        //}
        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MembersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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

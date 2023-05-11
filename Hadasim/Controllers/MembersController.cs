using Microsoft.AspNetCore.Mvc;
using Entities.DBModels;
using System.Collections;
using Services;
using DTO;
using AutoMapper;
using System.IO;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hadasim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService _IMembersService;
        private readonly IMapper _IMapper;
        public MembersController(IMemberService membersService, IMapper mapper)
        {
            _IMembersService = membersService;
            _IMapper = mapper;
        }

        // GET: api/<MembersController>
        [HttpGet]
        public async Task<IEnumerable<HmoMember>> Get()
        {
            IEnumerable<HmoMember> memberList = await _IMembersService.GetAllMembers();
            if (memberList != null)
                return memberList;
            else return null;
        }

        // GET: api/<MembersController>
        [HttpGet("numOfNotImmuneMembers")]
        public async Task<ActionResult<int>> GetTheNumOfNotImmuneMembers()
        {
            int numOfNotImmuneMembers = await _IMembersService.getNumOfNotImmuneMembers();
            return numOfNotImmuneMembers;
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public async Task<HmoMember> Get(string id)
        {
            HmoMember member = await _IMembersService.getMemberBYId(id);
            if (member != null)
                return member;
            else return null;
        }
        // GET api/<MembersController>/5
        [HttpGet("{date}/getNumOfActivePatients")]
        public async Task<Dictionary<DateTime, int>> getNumOfActivePatients()
        {
            Dictionary<DateTime, int> dic = await _IMembersService.getNumOfActivePatients();
            if (dic != null)
                return dic;
            else return null;

        }
        // GET api/<MembersController>/5
        [HttpGet("{date}/getNumOfActivePatientsForSpecificDay")]

        public async Task <ActionResult<int>> getNumOfActivePatientsForSpecificDay(DateTime date)
        {
            int num = await _IMembersService.getNumOfActivePatientsForSpecificDay(date);
                if (num != null)
                return num;
            else return null;
        }

        // POST api/<MembersController>
        [HttpPost]
        public async Task<ActionResult<HmoMemberDto>> Post([FromBody] HmoMemberDto member)
        {
            // Create a new HttpClient instance to download the image from the URL
            //using (HttpClient client = new HttpClient())
            //{
            //    string imageUrl = member.ImgUrl;
            //    // Download the image as a stream
            //    using (Stream stream = await client.GetStreamAsync(imageUrl))
            //    {
            //        // Generate a unique file name for the image using a GUID
            //        string fileName = $"{Guid.NewGuid()}.jpg";

            //        // Get the path to the wwwroot folder
            //        string wwwrootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

            //        // Create a subdirectory in the wwwroot folder to store the images
            //        string imagesPath = Path.Combine(wwwrootPath, "images");
            //        if (!Directory.Exists(imagesPath))
            //        {
            //            Directory.CreateDirectory(imagesPath);
            //        }

            //        // Save the image file to the images subdirectory
            //        string filePath = Path.Combine(imagesPath, fileName);
            //        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            //        {
            //            await stream.CopyToAsync(fileStream);
            //        }

            //        // Return the path to the saved image file
            //        //return $"/images/{fileName}";
            //        member.ImgUrl = filePath;
            //    }
                HmoMember newmember = _IMapper.Map<HmoMemberDto, HmoMember>(member);
                HmoMember myMember = await _IMembersService.addMember(newmember);
                HmoMemberDto ourmember = _IMapper.Map<HmoMember, HmoMemberDto>(myMember);
                if (ourmember != null)
                    return ourmember;
                else return null;
            }
        }


    }

        
    

using System.Threading.Tasks;
using AutoMapper;
using Meetings.Domain.Dtos;
using Meetings.Domain.Entities;
using Meetings.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Meetings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        private readonly IMeetingRepository meetingRepository;
        private readonly IParticipantRepository participantRepository;
        private readonly IConfiguration configuration;
        private readonly IMapper mapper;
        private readonly int limitOfParticipants;

        public MeetingsController(IMeetingRepository meetingRepository, IParticipantRepository participantRepository, IConfiguration configuration, IMapper mapper)
        {
            this.meetingRepository = meetingRepository;
            this.participantRepository = participantRepository;
            this.configuration = configuration;
            this.mapper = mapper;
            limitOfParticipants = configuration.GetValue<int>("Application:LimitOfParticipants");
        }

        // GET: api/<MeetingsController>
        [HttpGet]
        public IActionResult GetMeetings()
        {

            return Ok();
        }


        // POST api/<MeetingsController>
        [HttpPost]
        public async Task<IActionResult> CreateMeeting([FromBody] MeetingForCreatedDto meetingForCreated)
        {

            return Ok();   
        }

        [HttpPost]
        [Route("{meetingId}/participants")]
        public async Task<IActionResult> AddParticipant([FromBody] ParticipantForCreatedDto participantForCreated, [FromQuery] int meetingId)
        {
            return Ok();
        }

        // DELETE api/<MeetingsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeeting(int id)
        {
            return Ok();
        }
    }
}

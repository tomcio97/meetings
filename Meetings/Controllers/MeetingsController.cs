using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Meetings.Domain.Dtos;
using Meetings.Domain.Entities;
using Meetings.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using IConfigurationProvider = AutoMapper.IConfigurationProvider;


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
        private readonly IConfigurationProvider configurationProvider;
        private readonly int limitOfParticipants;

        public MeetingsController(IMeetingRepository meetingRepository, IParticipantRepository participantRepository, IConfiguration configuration, IMapper mapper, IConfigurationProvider configurationProvider)
        {
            this.meetingRepository = meetingRepository;
            this.participantRepository = participantRepository;
            this.configuration = configuration;
            this.mapper = mapper;
            this.configurationProvider = configurationProvider;
            this.configurationProvider = configurationProvider;
            limitOfParticipants = configuration.GetValue<int>("Application:LimitOfParticipants");
        }

        // GET: api/<MeetingsController>
        [HttpGet]
        public async Task<IActionResult> GetMeetings()
        {
            var meetings = await meetingRepository.GetMeetings().ProjectTo<MeetingForListDto>(configurationProvider).ToListAsync();
            return Ok(meetings);
        }


        // POST api/<MeetingsController>
        [HttpPost]
        public async Task<IActionResult> CreateMeeting([FromBody] MeetingForCreatedDto meetingForCreated)
        {
            if(ModelState.IsValid)
            {
               if(await meetingRepository.Add(mapper.Map<MeetingEntity>(meetingForCreated)))
                {
                    return StatusCode(201);
                }
            }

            return BadRequest("Creation failed");   
        }



        // POST api/<MeetingsController>/5/participants
        [HttpPost("{meetingId}/participants")]
        public async Task<IActionResult> AddParticipant(int meetingId, [FromBody] ParticipantForCreatedDto participantForCreated)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            // Bad meetingId
            if (meetingRepository.GetMeeting(meetingId) == null)
            {
                return NotFound();
            }

            // Check number of participants
            if (participantRepository.GetNumberOfParticipantsForMeeting(meetingId) < limitOfParticipants)
            {
                var participantEntity = mapper.Map<ParticipantEntity>(participantForCreated);
                participantEntity.MeetingId = meetingId;
                if (await participantRepository.Add(participantEntity))
                {
                    return StatusCode(201);
                }

                return BadRequest("Failed add");
            }

            return BadRequest("The limit of participants is " + limitOfParticipants);
        }



        // DELETE api/<MeetingsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeeting(int id)
        {
            var meetingEntity = meetingRepository.GetMeeting(id);
            if(meetingEntity != null)
            {
               if(await meetingRepository.Delete(meetingEntity))
                {
                    return Ok();
                }

                return BadRequest("Deletion failed");
            }

            return NotFound();
        }
    }
}

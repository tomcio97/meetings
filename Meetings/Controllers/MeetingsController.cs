using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Meetings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        // GET: api/<MeetingsController>
        [HttpGet]
        public IActionResult GetMeetings()
        {
            return Ok();
        }


        // POST api/<MeetingsController>
        [HttpPost]
        public async Task<IActionResult> CreateMeeting([FromBody] string value)
        {
            return Ok();
        }

        [HttpPost]
        [Route("{meetingId}/participants")]
        public async Task<IActionResult> AddParticipant([FromBody] string value, [FromQuery] int meetingId)
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

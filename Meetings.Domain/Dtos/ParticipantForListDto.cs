using System;
using System.Collections.Generic;
using System.Text;

namespace Meetings.Domain.Dtos
{
    public class ParticipantForListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

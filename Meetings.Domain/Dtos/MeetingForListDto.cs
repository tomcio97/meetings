using System;
using System.Collections.Generic;

namespace Meetings.Domain.Dtos
{
    public class MeetingForListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public ICollection<ParticipantForListDto> Participants { get; set; }
    }
}

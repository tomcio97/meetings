using System;
using System.Collections.Generic;

namespace Meetings.Domain.Entities
{
    public class MeetingEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public ICollection<ParticipantEntity> Participants { get; set; }
    }
}

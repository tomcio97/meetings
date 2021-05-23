namespace Meetings.Domain.Entities
{
    public class ParticipantEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int MeetingId { get; set; }
        public MeetingEntity Meeting { get; set; }
    }
}

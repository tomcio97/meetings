using System.ComponentModel.DataAnnotations;

namespace Meetings.Domain.Dtos
{
    public class ParticipantForCreatedDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public int MeetingId { get; set; }
    }
}

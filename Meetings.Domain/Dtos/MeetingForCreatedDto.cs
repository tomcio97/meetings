using System;
using System.ComponentModel.DataAnnotations;

namespace Meetings.Domain.Dtos
{
    public class MeetingForCreatedDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}

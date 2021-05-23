using System;
using System.Collections.Generic;
using System.Text;
using Meetings.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Meetings.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<MeetingEntity> Meetings { get; set; }
        public DbSet<ParticipantEntity> Participants { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}

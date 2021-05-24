using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Meetings.Domain.Entities;
using Meetings.Domain.Interfaces.Repositories;

namespace Meetings.Database.Repositories
{
    public class MeetingRepository : BaseRepository<MeetingEntity>, IMeetingRepository
    {
        private readonly ApplicationDbContext dbContext;

        public MeetingRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
        public IQueryable<MeetingEntity> GetMeetings()
        {
            return dbContext.Meetings;
        }
    }
}

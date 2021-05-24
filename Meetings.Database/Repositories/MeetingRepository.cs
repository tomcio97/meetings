using System.Linq;
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

        public MeetingEntity GetMeeting(int id)
        {
            return dbContext.Meetings.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<MeetingEntity> GetMeetings()
        {
            return dbContext.Meetings;
        }
    }
}

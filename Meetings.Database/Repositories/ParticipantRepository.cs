using System.Linq;
using Meetings.Domain.Entities;
using Meetings.Domain.Interfaces.Repositories;

namespace Meetings.Database.Repositories
{
    public class ParticipantRepository: BaseRepository<ParticipantEntity>, IParticipantRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ParticipantRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public int GetNumberOfParticipantsForMeeting(int meetingId)
        {
            return dbContext.Participants.Where(x => x.MeetingId == meetingId).Count();
        }
    }
}

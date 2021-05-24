using System.Linq;
using Meetings.Domain.Entities;

namespace Meetings.Domain.Interfaces.Repositories
{
    public interface IMeetingRepository : IBaseRepository<MeetingEntity>
    {
        IQueryable<MeetingEntity> GetMeetings();

        MeetingEntity GetMeeting(int id);
    }
}

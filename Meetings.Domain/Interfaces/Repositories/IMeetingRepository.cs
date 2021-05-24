using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Meetings.Domain.Entities;

namespace Meetings.Domain.Interfaces.Repositories
{
    public interface IMeetingRepository : IBaseRepository<MeetingEntity>
    {
        IQueryable<MeetingEntity> GetMeetings();  
    }
}

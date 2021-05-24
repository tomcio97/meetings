using System;
using System.Collections.Generic;
using System.Text;
using Meetings.Domain.Entities;
using Meetings.Domain.Interfaces.Repositories;

namespace Meetings.Database.Repositories
{
    public class ParticipantRepository: BaseRepository<ParticipantEntity>, IParticipantRepository
    {
        public ParticipantRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

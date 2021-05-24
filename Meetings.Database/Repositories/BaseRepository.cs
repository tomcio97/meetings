using System.Threading.Tasks;
using Meetings.Domain.Entities;
using Meetings.Domain.Interfaces.Repositories;

namespace Meetings.Database.Repositories
{
    public class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : BaseEntity
    {
        private readonly ApplicationDbContext dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<bool> Add(Entity entity)
        {
            dbContext.Add(entity);

           return await dbContext.SaveChangesAsync() > 0;

        }

        public async Task<bool> Delete(Entity entity)
        {
            dbContext.Remove(entity);

            return await dbContext.SaveChangesAsync() > 0;
        }
    }
}

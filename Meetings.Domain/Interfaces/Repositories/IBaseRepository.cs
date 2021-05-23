using System.Threading.Tasks;
using Meetings.Domain.Entities;

namespace Meetings.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<Entity> where Entity : BaseEntity
    {
        Task<bool> Add(Entity entity);
        Task<bool> Delete(Entity entity);
    }
}

using Phs.MongoData.Model;
using Phs.MongoData.Service;
using System.Threading.Tasks;

namespace Phs.MongoData.Interface
{
    public interface IUserRepository : IEntityService<User>
    {
        Task<User> GetUser(string username);
    }
}

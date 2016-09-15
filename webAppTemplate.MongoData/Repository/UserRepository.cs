using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Phs.MongoData.Interface;
using Phs.MongoData.Model;
using Phs.MongoData.Service;
using Phs.MongoData.Common;

namespace Phs.MongoData.Repository
{
    public class UserRepository : EntityService<User>, IUserRepository
    {
        public async Task<User> GetUser(string username)
        {
            var builder = Builders<User>.Filter;
            var filter = builder.Eq("Email", username);
            var users = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            if (users.Any())
                return users.FirstOrDefault();
	        return null;
        }

        public async Task<bool> CreateSync(User user)
        {
            user.Password = Crypto.HashSha256(user.Password);
            await ConnectionHandler.MongoCollection.InsertOneAsync(user);
            return true;
        }
    }
}

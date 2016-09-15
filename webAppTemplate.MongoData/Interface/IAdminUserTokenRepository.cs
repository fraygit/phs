using Phs.MongoData.Model;
using Phs.MongoData.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phs.MongoData.Interface
{
    public interface IAdminUserTokenRepository : IEntityService<AdminUserToken>
    {
        Task<AdminUserToken> GetUserToken(string username);
        Task<bool> IsTokenValid(string userToken);
    }
}

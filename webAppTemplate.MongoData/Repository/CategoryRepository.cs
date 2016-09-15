using Phs.MongoData.Interface;
using Phs.MongoData.Model;
using Phs.MongoData.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phs.MongoData.Repository
{
    public class CategoryRepository : EntityService<Category>, ICategoryRepository
    {
    }
}

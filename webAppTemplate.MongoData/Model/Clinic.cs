using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phs.MongoData.Model
{
    public class Clinic
    {
        public string Name { get; set; }
        public string Pho { get; set; }
        public List<string> Users { get; set; }
    }
}

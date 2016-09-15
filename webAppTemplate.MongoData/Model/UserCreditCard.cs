using Phs.MongoData.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phs.MongoData.Model
{
    public class UserCreditCard : MongoEntity
    {
        public string Username { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardName { get; set; }
        public string CreditCardNumber2 { get; set; }
        public bool IsDefault { get; set; }
    }
}

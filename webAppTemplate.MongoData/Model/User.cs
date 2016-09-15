using Phs.MongoData.Entities.Base;
using System;

namespace Phs.MongoData.Model
{
    public class User : MongoEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public string ClinicId { get; set; }
        public string Status { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime Created { get; set; } 
    }
}

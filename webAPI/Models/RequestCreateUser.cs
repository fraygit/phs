﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phs.API.Models
{
    public class RequestCreateUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
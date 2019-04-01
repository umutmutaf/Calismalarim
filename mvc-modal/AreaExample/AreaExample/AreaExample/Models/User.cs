﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AreaExample.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }

        public User()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
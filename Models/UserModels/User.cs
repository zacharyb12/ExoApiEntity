﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.UserModels
{
    public class User
    {
        public Guid Id { get; set; } = new Guid();

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.ViewModel
{
    public class BEUser
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IdRol { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Services
{
    public interface IAuthenticationService
    {
        AppUser Login(string username, string password);
    }
}

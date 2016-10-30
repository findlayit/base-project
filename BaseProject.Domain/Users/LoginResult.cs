﻿using System.Collections.Generic;

namespace BaseProject.Domain.Users
{
    public class LoginResult
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
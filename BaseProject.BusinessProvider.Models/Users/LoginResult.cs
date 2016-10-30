using System.Collections.Generic;
using System.Security.Claims;

namespace BaseProject.BusinessProvider.Models.Users
{
    public class LoginResult
    {
        public bool IsSuccessful { get; set; }
        public ClaimsIdentity Identity { get; set; }
        public List<string> Roles { get; set; }
        public int Id { get; set; }
    }
}
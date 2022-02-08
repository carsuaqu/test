using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Identity.Dominio
{
    public class ApplicationUser : IdentityUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}

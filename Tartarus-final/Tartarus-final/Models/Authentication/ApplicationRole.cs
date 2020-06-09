using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace UE.Models.Authentication
{
    public class ApplicationRole : IdentityRole
    {
        public string DisplayName { get; set; }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }

        public ApplicationRole() : base()
        {
            UserRoles = new List<ApplicationUserRole>();
        }
    }
}

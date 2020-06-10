using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Tartarus_final.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public RegistrationTypes RegistrationType { get; set; }
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
        public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
        public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }



    }
}
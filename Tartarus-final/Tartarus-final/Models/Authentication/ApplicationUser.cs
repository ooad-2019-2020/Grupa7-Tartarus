using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using UE.Common.Enums;

namespace UE.Models.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CompanyName { get; set; }

        public string Website { get; set; }

        public string RegisteringIPaddress { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IsComplete { get; set; }

        public long HubspotId { get; set; }

        public RegistrationTypes RegistrationType { get; set; }

        public ICollection<ApplicationUserRole> Roles { get; set; }

        public ApplicationUser()
        {
            Roles = new List<ApplicationUserRole>();
        }
    }
}

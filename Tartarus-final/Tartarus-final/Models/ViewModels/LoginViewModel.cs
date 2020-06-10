using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus_final.Models
{
    public class LoginViewModel
    {

        [Required]
        public string userName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remeber me")]
        public bool RememberMe { get; set; }

    }
}

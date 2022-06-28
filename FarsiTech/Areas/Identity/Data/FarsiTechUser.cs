using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FarsiTech.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the FarsiTechUser class
    public class FarsiTechUser : IdentityUser
    {
        [Required]
        [Display(Name = "نام کاربری")]
        public string FirstName { get; set; }
    }
}

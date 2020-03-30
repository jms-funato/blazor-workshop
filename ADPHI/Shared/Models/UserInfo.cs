using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ADPHI.Shared.Models
{
    public class UserInfo
    {
        //ADPHI
        //public bool IsAuthenticated { get; set; }
        //public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

    }
}

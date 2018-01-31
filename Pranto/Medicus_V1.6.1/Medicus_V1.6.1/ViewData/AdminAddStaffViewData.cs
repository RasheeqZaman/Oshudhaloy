using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medicus_V1._6._1.ViewData
{
    public class AdminAddStaffViewData
    {
        

            [Required]
            [Display(Name = "Name")]
            public string userName { get; set; }

            [Required]
            [Display(Name = "Email")]
            public string  email { get; set; }
            [Required]
            [Display(Name = "Phone Number")]
           
            public string phoneNumber { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string address { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string password { get; set; }


    }
    }

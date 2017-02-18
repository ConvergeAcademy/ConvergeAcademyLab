using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisterationModule.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please provide EmailID", AllowEmptyStrings = false)]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",
        ErrorMessage = "Please provide valid email id")]
        public string EmailD { get; set; }

        public string FullName { get; set; }

        public string Password { get; set; }
        

    }
}
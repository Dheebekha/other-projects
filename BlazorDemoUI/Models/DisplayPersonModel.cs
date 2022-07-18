using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemoUI.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15,ErrorMessage ="First Name is too Long")]
        [MinLength(5,ErrorMessage = "First Name is too Short")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Last Name is too Long")]
        [MinLength(5, ErrorMessage = "Last Name is too Short")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}

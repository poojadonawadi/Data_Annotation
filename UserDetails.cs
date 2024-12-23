using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Annotation_Practice
{
    internal class UserDetails
    {
        [Required(ErrorMessage ="The is required")]
        [StringLength(30, MinimumLength= 3, ErrorMessage ="Name should contains the characters between 3 and 30")]
        public string Name { get; set; }
        [Range(18, 70, ErrorMessage = "Age should be between 18 & 70")]
        public int Age { get; set; }
        [Required(ErrorMessage="Email is required")]
        [EmailAddress(ErrorMessage = "Provide valid email address")]
        public string Email {  get; set; }
    }
}

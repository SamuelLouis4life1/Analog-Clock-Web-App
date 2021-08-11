using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Analog_Clock_App.Models
{
    public class ApplicationUser
    {
        public int Id { get; set; }

        [Display(Name = "Complete Name ")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "Email ")]
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        //[Display(Name = "Phone Number ")]
        [Required]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Birthday ")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Birthday { get; set; }

        public ApplicationUserAddress ApplicationUserAddress { get; set; }

    }
}

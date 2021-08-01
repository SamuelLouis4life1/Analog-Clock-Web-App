using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Analog_Clock_App.Models
{
    public class ApplicationUserAddress
    {
        public int Id { get; set; }

        [Display(Name = "CEP ")]
        [MaxLength(50)]
        public string PostalCode { get; set; }
        
        [Display(Name = "Logradouro ")]
        [MaxLength(50)]
        public string StreetAddress { get; set; }

        [Display(Name = "Bairro ")]
        [MaxLength(50)]
        public string Neighborhood { get; set; }

        [Display(Name = "Localidade ")]
        [MaxLength(50)]
        public string City { get; set; }

        [Display(Name = "UF ")]
        [MaxLength(50)]
        public string State { get; set; }
        
        public string Number { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public string DDD { get; set; }
        public string Siafi { get; set; }
        public bool IsAuthorizedToPause { get; set; }
        
    }
}

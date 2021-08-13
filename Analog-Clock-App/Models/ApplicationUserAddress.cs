using Newtonsoft.Json;
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

        [JsonProperty("cep")]
        [Display(Name = "Postal Code")]
        [MaxLength(50)]
        public string PostalCode { get; set; }

        [JsonProperty("logradouro")]
        [Display(Name = "Street Address ")]
        [MaxLength(50)]
        public string logradouro { get; set; } // StreetAddress


        [JsonProperty("complemento")]
        [Display(Name = "Addicional Address ")]
        [MaxLength(50)]
        public string complemento { get; set; } // AddicionalAddress

        [JsonProperty("bairro")]
        [Display(Name = "Neighborhood ")]
        [MaxLength(50)]
        public string bairro { get; set; } // Neighborhood


        [JsonProperty("localidade")]
        [Display(Name = "City ")]
        [MaxLength(50)]
        public string localidade { get; set; } // City

        [JsonProperty("uf")]
        [Display(Name = "State ")]
        [MaxLength(50)]
        public string uf { get; set; } // State

        [JsonProperty("numero")]
        [Display(Name = "Number ")]
        public string Number { get; set; } // Number

        [JsonProperty("ibge")]
        public string Ibge { get; set; }

        [JsonProperty("gia")]
        public string Gia { get; set; }

        [JsonProperty("ddd")]
        public string DDD { get; set; }

        [JsonProperty("siafi")]
        public string Siafi { get; set; }

        public bool IsAuthorizedToPause { get; set; }

    }
}

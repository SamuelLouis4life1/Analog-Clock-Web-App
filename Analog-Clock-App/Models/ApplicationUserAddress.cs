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
        public string StreetAddress { get; set; }


        [JsonProperty("bairro")]
        [Display(Name = "Neighborhood ")]
        [MaxLength(50)]
        public string AddicionalAddress { get; set; }

        [JsonProperty("bairro")]
        [Display(Name = "Neighborhood ")]
        [MaxLength(50)]
        public string Neighborhood { get; set; }
        

        [JsonProperty("localidade")]
        [Display(Name = "City ")]
        [MaxLength(50)]
        public string City { get; set; }

        [JsonProperty("uf")]
        [Display(Name = "State ")]
        [MaxLength(50)]
        public string State { get; set; }

        [JsonProperty("numero")]
        [MaxLength(5)]
        public string Number { get; set; }

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

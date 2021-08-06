using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Analog_Clock_App.Models
{
    public interface IApplicationUserAddress
    {
        [Get("/ws/{cep}/json/")]
        Task<ApplicationUserAddress> GetAddressAsync (string cep);
    }
}

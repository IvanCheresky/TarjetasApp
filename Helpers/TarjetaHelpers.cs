using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TarjetasApp.Models;

namespace TarjetasApp.Helpers
{
    public class TarjetaHelpers
    {
        public static bool IsTarjetaValid(Tarjeta tarjeta)
        {
            return tarjeta.Vencimiento > DateTime.Now;
        }

        public static bool AreTarjetasEqual(Tarjeta tarjeta1, Tarjeta tarjeta2)
        {
            return tarjeta1.Marca == tarjeta2.Marca && tarjeta1.Numero == tarjeta2.Numero &&
                   tarjeta1.Titular == tarjeta2.Titular && tarjeta1.Vencimiento == tarjeta2.Vencimiento;
        }
    }
}

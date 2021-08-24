using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using TarjetasApp.Models;

namespace TarjetasApp.Helpers
{
    public class TasaCalculator
    {
        public double CalcularTasa(Marca marca, DateTime date)
        {
            switch (marca)
            {
                case Marca.SQUA:
                    return (double)date.Year / (double)date.Month;
                case Marca.SCO:
                    return (double)date.Month * 0.5;
                case Marca.PERE:
                    return (double) date.Month * 0.1;
            }

            throw new InvalidEnumArgumentException();
        }

    }
}

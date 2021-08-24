using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TarjetasApp.Helpers
{
    public class TransactionHelpers
    {
        public static bool IsTransactionValid(double amount)
        {
            return amount < 100;
        }
    }
}

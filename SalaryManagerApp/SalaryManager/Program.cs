using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManager
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new CurrencyWS.CurrencyConverterClient();
            client.GetPolishEuroRate();
        }
    }
}

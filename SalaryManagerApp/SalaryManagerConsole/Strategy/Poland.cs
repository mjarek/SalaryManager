using SalaryManagerConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole.Repository
{
    class Poland : IStrategy
    {
        public string Country => "Poland";
        public string Currency => "PLN";
        public double GetEuroRate()
        {
            try
            {
                var client = new WsCurrency.CurrencyConverterClient();
                return client.GetPolishEuroRate();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
                throw ex;
            }
        }

    }
}

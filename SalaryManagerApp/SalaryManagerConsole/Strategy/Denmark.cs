using SalaryManagerConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole.Repository
{
    class Denmark : IStrategy
    {
        public string Country => "Denmark";
        public string Currency => "DKK";

        public double GetEuroRate()
        {
            try
            {
                var client = new WsCurrency.CurrencyConverterClient();
                return client.GetDanishEuroRate();
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

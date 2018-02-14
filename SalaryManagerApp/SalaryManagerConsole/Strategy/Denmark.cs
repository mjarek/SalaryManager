using SalaryManagerConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole.Repository
{
  public class Denmark : IStrategy
    {
        public string Country => Helper.Country.Denmark.ToString();
        public string Currency => Properties.Resource.DenmarkCurrency;

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

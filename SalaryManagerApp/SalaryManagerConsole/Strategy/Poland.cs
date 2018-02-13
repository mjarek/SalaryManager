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
        public double GetEuroRate()
        {
            try
            {
                var client = new WsCurrency.CurrencyConverterClient();
                return client.GetPolishEuroRate();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReCalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}

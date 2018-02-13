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
        public double GetEuroRate()
        {
            var client = new WsCurrency.CurrencyConverterClient();
            return client.GetDanishEuroRate();

        }

        public void ReCalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}

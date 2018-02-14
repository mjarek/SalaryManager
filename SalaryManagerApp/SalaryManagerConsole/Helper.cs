using SalaryManagerConsole.Interface;
using SalaryManagerConsole.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole
{
    public class Helper
    {
        public enum Country
        {
            Denmark = 1,
            Poland = 2
        }

        public static void ShowMessageAboutSalaries(Salary[] salary)
        {
            foreach (var item in salary)
            {
              Console.WriteLine(String.Format(Resource.ConsoleSalaryMessage, item.Name,item.Country,item.Amount,item.SignCurrency));
            }
        }
    }
}

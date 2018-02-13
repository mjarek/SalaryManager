using SalaryManagerConsole.Interface;
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
                var message = new StringBuilder();
                
                //Console.WriteLine(item.Name + " earns in after conversion from the euro :" + item.Amount.ToString());
                Console.WriteLine(String.Format("{0} earns in {1} after conversion from the euro : {2} {3}", item.Name,item.Country,item.Amount,item.SignCurrency));
            }
        }
    }
}

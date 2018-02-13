using SalaryManagerConsole.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //First scenario : Team works in Denamrk.

            var yourChoice = Helper.Country.Denmark;
            var strategy = new CreatorStrategy().GetStrategy(yourChoice);
            var manager = new SalaryManager(strategy);
           
        }
    }
}

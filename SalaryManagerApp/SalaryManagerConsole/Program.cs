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
            try
            {
                var manager = new SalaryManager(new SalaryInternationalTeam());
                var creatorStrategy = new CreatorStrategy();

                Console.WriteLine(Environment.NewLine + "First scenario : Team works in Denmark" + Environment.NewLine);
                manager.Strategy = creatorStrategy.GetStrategy(Helper.Country.Denmark);
                Helper.ShowMessageAboutSalaries(manager.RecalculationSalary());


                Console.WriteLine(Environment.NewLine + "Second scenario: move team to Poland" + Environment.NewLine);
                manager.Strategy = creatorStrategy.GetStrategy(Helper.Country.Poland);
                Helper.ShowMessageAboutSalaries(manager.RecalculationSalary());

                Console.WriteLine(Environment.NewLine + "Third scenario: Back to Denmark" + Environment.NewLine);
                manager.Strategy = creatorStrategy.GetStrategy(Helper.Country.Denmark);
                Helper.ShowMessageAboutSalaries(manager.RecalculationSalary());

                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.InnerException);
            } 






        }
    }
}

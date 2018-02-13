using SalaryManagerConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole
{
    public class SalaryManager
    {
        private readonly ISalaryRepository _salaryRepository;
        public IStrategy Strategy { get; set; }

        public SalaryManager(ISalaryRepository salaryRepository)
        {
            _salaryRepository = salaryRepository;
        } 

        public Salary[] RecalculationSalary()
        {
           var salaryInTeam =  _salaryRepository.GetSalaries();
           var euroRate = Strategy.GetEuroRate();

            foreach (var item in salaryInTeam)
            {
                item.Amount = item.Amount * euroRate;
                item.Country = Strategy.Country;
                item.SignCurrency = Strategy.Currency;
            }
            return salaryInTeam;
        }
       

    }
}

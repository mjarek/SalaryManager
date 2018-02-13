using SalaryManagerConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole.Repository
{
    class SalaryInternationalTeam : ISalaryRepository
    {
        public Salary[] GetSalaries()
        {
            Salary[] data = { new Salary { Name = "Jan Nowak", Amount = 2000 },
                new Salary { Name = "John Cook", Amount = 2500 },
                new Salary { Name = "Philip Mors", Amount = 3150 }
             };

            return data;
        }
    }
}

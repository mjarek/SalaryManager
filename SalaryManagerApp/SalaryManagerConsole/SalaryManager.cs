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

        public SalaryManager(ISalaryRepository salaryRepository)
        {
            _salaryRepository = salaryRepository;
        }

    }
}

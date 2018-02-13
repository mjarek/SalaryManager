using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole.Interface
{
   public interface IStrategy
    {
        double GetEuroRate();
        void ReCalculateSalary();
    }
}

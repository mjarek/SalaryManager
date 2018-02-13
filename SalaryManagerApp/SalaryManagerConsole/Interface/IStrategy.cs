using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole.Interface
{
   public interface IStrategy
    {
        string Country { get;  }
        string Currency { get; }
        double GetEuroRate();
       
    }
}

using SalaryManagerConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole.Repository
{
    class CreatorStrategy
    {
        private Dictionary<string, Type> _salary;
        public CreatorStrategy()
        {
            LoadStrategy();
        }




        private void LoadStrategy()
        {
            _salary = new Dictionary<string, Type>();

            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetInterface(typeof(ISalaryRepository).ToString()) != null)
                {
                    _salary.Add(type.Name.ToLower(), type);
                }
            }
        }

        private Type GetTypeToCreate(string name)
        {
            return (from checker in _salary where checker.Key.Equals(name) select _salary[checker.Key]).FirstOrDefault();
        }

        public ISalaryRepository GetStrategy(Helper.Country name)
        {
            var t = GetTypeToCreate(name.ToString().ToLower());
            if (t == null) return null;
            return Activator.CreateInstance(t) as ISalaryRepository;
        }
    }
}


﻿using SalaryManagerConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole.Repository
{
    public class CreatorStrategy
    {
        private Dictionary<string, Type> _strategies;
        public CreatorStrategy()
        {
            LoadStrategy();
        }

        private void LoadStrategy()
        {
            _strategies = new Dictionary<string, Type>();

           foreach (var type in Assembly.GetExecutingAssembly().GetTypes().Where(x => x.GetInterface(typeof(IStrategy).ToString()) != null))
            {
                 _strategies.Add(type.Name.ToLower(), type);
            }
        }

        private Type GetTypeToCreate(string name)
        {
            return _strategies.Where(x => x.Key.Equals(name)).Select(x => x.Value).FirstOrDefault();    
        }

        public IStrategy GetStrategy(Helper.Country name)
        {
            var type = GetTypeToCreate(name.ToString().ToLower());
            if (type == null) return null;
            return Activator.CreateInstance(type) as IStrategy;
        }
    }
}


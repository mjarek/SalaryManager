using Moq;
using NUnit.Framework;
using SalaryManagerConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryManagerConsole.Properties;

namespace SalaryManagerConsole.UnitTests
{
    [TestFixture]
    class SalaryManagerTests
    {

        [Test]
       public void RecalculationSalary_WhenCalled_returnSalaryAfterRecalculation()
        {
            var salaryDataMock = new Mock<ISalaryRepository>();
                salaryDataMock.Setup(x => x.GetSalaries()).Returns(new Salary[] { new Salary { Name = "Test", Amount = 1000, Country = Helper.Country.Poland.ToString(), SignCurrency = Resource.PolandCurrency } });

            var strategyMock = new Mock<IStrategy>();
                strategyMock.Setup(x => x.GetEuroRate()).Returns(4);
                
            var manager = new SalaryManager(salaryDataMock.Object);
                manager.Strategy = strategyMock.Object;

            var result = manager.RecalculationSalary();

            Assert.That(result[0].Amount, Is.EqualTo(4000));



        }
    }
}

using NUnit.Framework;
using SalaryManagerConsole.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole.UnitTests
{[TestFixture]
    class CreatorStrategyTests
    {
        [Test]
        [TestCase(Helper.Country.Denmark, "Denmark")]
        [TestCase(Helper.Country.Poland, "Poland")]
        public void GetStrategy_WhenCalled_Return(Helper.Country insert,string output )
        {
            var creator = new CreatorStrategy();
            var result = creator.GetStrategy(insert);

            Assert.That(result.Country, Is.EqualTo(output));
        }

    }
}

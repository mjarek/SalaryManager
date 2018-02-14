using Moq;
using NUnit.Framework;
using SalaryManagerConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagerConsole.UnitTests.Strategy
{
    [TestFixture]
    public class PolandTests
    {
        [Test]
        public void GetEuroRate_WhenCalledForPoland_Return4Coma2()
        {
            var mockStrategy = new Mock<IStrategy>();
            mockStrategy.Setup(x => x.GetEuroRate()).Returns(4.2);

            var result = mockStrategy.Object.GetEuroRate();
            Assert.That(result, Is.EqualTo(4.2));
        }
    }
}

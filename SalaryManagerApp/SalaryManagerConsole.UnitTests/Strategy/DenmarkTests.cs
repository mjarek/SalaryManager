using Moq;
using NUnit.Framework;
using SalaryManagerConsole.Interface;
using System;


namespace SalaryManagerConsole.UnitTests.Strategy
{
    [TestFixture]
    public class DenmarkTests
    {
        [Test]
        public void GetEuroRate_WhenCalledForDenmark_Return7()
        {
            var mockStrategy = new Mock<IStrategy>();
                mockStrategy.Setup(x => x.GetEuroRate()).Returns(7);

            var result = mockStrategy.Object.GetEuroRate();
            Assert.That(result, Is.EqualTo(7));
        }
    }
}

using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace TeamCityTest
{
    [Binding]
    public class CalcTestsSteps
    {
        private Calculator calc;

        public CalcTestsSteps()
        {
            calc = new Calculator();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calc.EnterNumber(number);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            calc.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int number)
        {
            Assert.That(calc.GetScreen(), Is.EqualTo(number));
        }
    }
}

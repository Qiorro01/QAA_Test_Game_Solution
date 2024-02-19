using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public class Feature1StepDefinitions
    {
        [Given(@"I put (.*) in to the calculator")]
        public void GivenIPutInToTheCalculator(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {
            throw new PendingStepException();
        }

        [Then(@"(.*) should be displayed as a result")]
        public void ThenShouldBeDisplayedAsAResult(int p0)
        {
            throw new PendingStepException();
        }
    }
}

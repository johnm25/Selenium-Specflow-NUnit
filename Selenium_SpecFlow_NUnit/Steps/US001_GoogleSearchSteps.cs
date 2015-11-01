using System;
using NUnit.Framework;
using Selenium_SpecFlow.Support;
using TechTalk.SpecFlow;

namespace Selenium_SpecFlow_NUnit.Steps
{
    using OpenQA.Selenium;

    [Binding]
    public class US001_GoogleSearchSteps : SeleniumStepsBase
    {
        [Given(@"I have '(.*)' page opened")]
        public void GivenIHavePageOpened(string p0)
        {
            selenium.NavigateTo(string.Empty);
        }

        [Given(@"I have entered '(.*)' into the text box of which name is '(.*)'")]
        public void GivenIHaveEnteredIntoTheTextBoxOfWhichNameIs(string p0, string p1)
        {
            var element = selenium.FindElement(By.Name("q"));
            element.SendKeys(p0);
            element.Submit();
            // selenium.SetTextBoxValue(p1,p0);
        }

        [When(@"I press button of which id is '(.*)'")]
        public void WhenIPressButtonOfWhichIdIs(string p0)
        {
            selenium.ClickButton("gbqfb");
        }

        
        [Then(@"I should be navigated to search result page with '(.*)' on it")]
        public void ThenIShouldBeNavigatedToSearchResultPageWithOnIt(string p0)
        {
            Assert.Greater(selenium.FindElements(OpenQA.Selenium.By.PartialLinkText(p0)).Count,0);
        }
    }
}

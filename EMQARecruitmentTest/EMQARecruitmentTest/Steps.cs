using EMQAPageObjects;
using OpenQA.Selenium;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace EMQARecruitmentTest
{
    [Binding]
    public class EuromoneyHomePage_ManagementTeamSteps
    {
        [Given(@"I am on the Euromoney Homepage from and I click on the Navigation Menu Bar")]
        public void GivenIAmOnTheEuromoneyHomepageFromAndIClickOnTheNavigationMenuBar()
        {
            var driver = (IWebDriver)ScenarioContext.Current.GetBindingInstance(typeof(IWebDriver));
            var menuNavigation = new MenuNavigation();
            menuNavigation.NavigatetoUrl();
        }


        [Given(@"I am on the Management Team Homepage")]
        public void GivenIAmOnTheManagementTeamHomepage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I access the Navigation Menu bar")]
        public void WhenIAccessTheNavigationMenuBar()
        {
            //var homePageLinks = HomePageLinks.
        }

        [When(@"I click on the link ""(.*)""")]
        public void WhenIClickOnTheLink(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on '(.*)'")]
        public void WhenIClickOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am navigated to the Management Team Homepage")]
        public void ThenIAmNavigatedToTheManagementTeamHomepage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I view a list of the Management Team and their details")]
        public void ThenIViewAListOfTheManagementTeamAndTheirDetails()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"I am navigated to the specified Portfolio Page")]
        public void ThenIAmNavigatedToTheSpecifiedPortfolioPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am on Pricing, data and market intelligence Homepage")]
        public void GivenIAmOnPricingDataAndMarketIntelligenceHomepage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click on '(.*)'")]
        public void GivenIClickOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the site logs me into the brand and I am in the Home page ‘IJGlobal \| Infrastructure Journal and Project Finance Magazine’")]
        public void ThenTheSiteLogsMeIntoTheBrandAndIAmInTheHomePageIJGlobalInfrastructureJournalAndProjectFinanceMagazine()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am on the brand 'IJGlobal \| Infrastructure Journal and Project Finance Magazine’ Homepage")]
        public void GivenIAmOnTheBrandIJGlobalInfrastructureJournalAndProjectFinanceMagazineHomepage()
        {
            ScenarioContext.Current.Pending();
        }



        [Then(@"I verify Rank on the page")]
        public void ThenIVerifyRankOnThePage()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"the site logs me into the brand and I am in the Home page ""(.*)""")]
        public void ThenTheSiteLogsMeIntoTheBrandAndIAmInTheHomePage(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am on the brand Homepage ""(.*)""")]
        public void GivenIAmOnTheBrandHomepage(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}

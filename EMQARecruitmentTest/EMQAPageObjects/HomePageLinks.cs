using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMQAPageObjects
{
    public class HomePageLinks : MenuNavigation
    {
        private IWebDriver driver;
        public HomePageLinks(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly By _whoLink = By.XPath("");
        private readonly By _managementTeamTitle = By.XPath("");
        public HomePageLinks clickOnWhoWeAre()
        {
            driver.FindElement(_whoLink).Click();
            driver.FindElement(_managementTeamTitle).Click();
            return new HomePageSubLinks(driver);
        }
    }


}

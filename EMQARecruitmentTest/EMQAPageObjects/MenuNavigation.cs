using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMQAPageObjects
{

    public class MenuNavigation
    {
        private readonly By _whoLink = By.ClassName("menu_trigger");
        public MenuNavigation NavigatetoUrl()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.euromoneyplc.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            driver.FindElement(_whoLink).Click();
            return new HomePageLinks(driver);

        }
    }
}


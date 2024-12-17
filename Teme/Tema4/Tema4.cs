using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tema4
{
    public class Tema4
    {
        IWebDriver driver;

        [Test]
        public void Tema4Test()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IWebElement widgetsButton = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][4]"));
            widgetsButton.Click();

            IWebElement widgetsAutoComplete = driver.FindElement(By.XPath("//span[text()='Auto Complete']"));
            widgetsAutoComplete.Click();

            IWebElement widgetsAutoCompleteMultipleElementsField = driver.FindElement(By.Id("autoCompleteMultipleInput"));
            widgetsAutoCompleteMultipleElementsField.Click();

            //Selectam toate culorile care contin litera i - avem doar 3
            // - primul element afisat este deja ales pentru a fi selectat
            widgetsAutoCompleteMultipleElementsField.SendKeys("i");
            widgetsAutoCompleteMultipleElementsField.SendKeys(Keys.Enter);
            widgetsAutoCompleteMultipleElementsField.SendKeys("i");
            widgetsAutoCompleteMultipleElementsField.SendKeys(Keys.Enter);
            widgetsAutoCompleteMultipleElementsField.SendKeys("i");
            widgetsAutoCompleteMultipleElementsField.SendKeys(Keys.Enter);

            IWebElement widgetsAutoCompleteSingleElementField = driver.FindElement(By.Id("autoCompleteSingleInput"));
            widgetsAutoCompleteSingleElementField.Click();

            //Alegem culoarea numarul 2 din 3 care contine litera i
            // - avem nevoie doar de o apasare sageata in jos
            widgetsAutoCompleteSingleElementField.SendKeys("i");
            widgetsAutoCompleteSingleElementField.SendKeys(Keys.ArrowDown);
            widgetsAutoCompleteSingleElementField.SendKeys(Keys.Enter);
        }

        [TearDown]
        public void TearDown()
        {
            System.Threading.Thread.Sleep(5000);
            driver.Dispose();
            driver.Quit();
        }
    }
}

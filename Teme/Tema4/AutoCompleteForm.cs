using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tema4
{
    public class Tema4CuFor
    {
        IWebDriver driver;

        [Test]
        public void Tema4CuForTest()
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

            //Avem 3 culori care contin litera i si folosim for cu 3 iteratii
            for (int i = 1;  i <= 3; i++)
            {
                widgetsAutoCompleteMultipleElementsField.SendKeys("i");
                widgetsAutoCompleteMultipleElementsField.SendKeys(Keys.Enter);
                if (i == 1)
                {
                    Console.WriteLine("Am ales prima culoare afisata ce contine litera i");
                }
                else if (i == 2)
                {
                    Console.WriteLine("Am ales a doua culoare ce contine litera i");
                }
                else
                {
                    Console.WriteLine("Am ales a treia culoare, si ultima din lista, ce contine litera i");
                }
            }

            IWebElement widgetsAutoCompleteSingleElementField = driver.FindElement(By.Id("autoCompleteSingleInput"));
            widgetsAutoCompleteSingleElementField.Click();

            widgetsAutoCompleteSingleElementField.SendKeys("i");
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

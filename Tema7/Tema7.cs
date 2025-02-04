using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;

namespace Tema7
{
    public class LoopsPractice
    {
        
        IWebDriver driver;

        [Test]
        public void LoppsPracticeMethods()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IWebElement interactionsButton = driver.FindElement(By.XPath("//h5[text()='Interactions']"));
            interactionsButton.Click();

            IWebElement selectableOption = driver.FindElement(By.XPath("//li[@id='item-1']/span[text()='Selectable']"));
            selectableOption.Click();

            IWebElement gridSelect = driver.FindElement(By.XPath("//a[@id='demo-tab-grid']"));
            gridSelect.Click();

            List<IWebElement> elementsGrid = driver.FindElements(By.XPath("//li[@class='list-group-item list-group-item-action']")).ToList();

            int oddNumber = 1;
            foreach (IWebElement element in elementsGrid)
            {
                if (oddNumber % 2 != 0)
                {
                    element.Click();
                    Console.WriteLine(element.Text);
                }
                oddNumber++;
                            }
        }

        [TearDown]
        public void TearDown()
        {
            System.Threading.Thread.Sleep(1000);
            driver.Dispose();
            driver.Quit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tema4
{
    public class SelectMenuForm
    {
        IWebDriver driver;

        [Test]
        public void SelectMenuTest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IWebElement widgetsButton = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][4]"));
            widgetsButton.Click();

            IJavaScriptExecutor jsscroll = (IJavaScriptExecutor)driver;
            jsscroll.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement widgetsSelectMenu = driver.FindElement(By.XPath("//span[text()='Select Menu']"));
            widgetsSelectMenu.Click();

            //Solutie propusa de ChatGPT
            IWebElement dropdownValue = driver.FindElement(By.CssSelector("#withOptGroup > div > div.css-1hwfws3"));
            dropdownValue.Click();

            //Am incercat diverse metode dar solutia asta propuse de ChatGPT a functionat
            IWebElement optionSelectValue = driver.FindElement(By.XPath("//div[contains(text(), 'A root option')]"));
            optionSelectValue.Click();

            IWebElement dropdownTitle = driver.FindElement(By.CssSelector("#selectOne > div > div.css-1hwfws3"));
            dropdownTitle.Click();

            //Am incercat diverse metode dar solutia asta propuse de ChatGPT a functionat
            IWebElement optionSelectTitle = driver.FindElement(By.XPath("//div[contains(text(), 'Other')]"));
            optionSelectTitle.Click();

            IWebElement optionOldStyleMenu = driver.FindElement(By.Id("oldSelectMenu"));
            optionOldStyleMenu.Click();
            optionOldStyleMenu.SendKeys("m");
            optionOldStyleMenu.SendKeys(Keys.Enter);

            IWebElement optionMultiSelectDropdown = driver.FindElement(By.XPath("//div[contains(text(), 'Select...')]"));
            optionMultiSelectDropdown.Click();

            IWebElement optionMultiSelectDropdownValueOne = driver.FindElement(By.XPath("//div[contains(text(), 'Red')]"));
            optionMultiSelectDropdownValueOne.Click();

            IWebElement optionMultiSelectDropdownValueTwo = driver.FindElement(By.XPath("//div[contains(text(), 'Green')]"));
            optionMultiSelectDropdownValueTwo.Click();

            IWebElement optioStandardMultiselect = driver.FindElement(By.Id("cars"));
            optioStandardMultiselect.SendKeys("Saab");

            Console.WriteLine("Sa vedem daca merge pana aici");
        }

        [TearDown]
        public void TearDown()
        {
            System.Threading.Thread.Sleep(2000);
            driver.Dispose();
            driver.Quit();
        }
    }
}

using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;

namespace UltimaTema
{
    [TestFixture]
    public class ProgressBarTests
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            // Initialize WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestProgressBar()
        {
            // Navigate to the page
            driver.Navigate().GoToUrl("https://demoqa.com");

            // Click on "Widgets"
            IWebElement widgetsElement = driver.FindElement(By.XPath("//h5[text()='Widgets']"));
            widgetsElement.Click();
            Thread.Sleep(2000); // Wait for page transition

            IJavaScriptExecutor jsscroll = (IJavaScriptExecutor)driver;
            jsscroll.ExecuteScript("window.scrollTo(0,1000)");

            // Click on "Progress Bar"
            IWebElement progressBarMenu = driver.FindElement(By.XPath("//span[text()='Progress Bar']"));
            progressBarMenu.Click();
            Thread.Sleep(2000); // Wait for page transition

            IWebElement progressBar = driver.FindElement(By.CssSelector("div[role='progressbar']"));
            string startValue = progressBar.GetAttribute("aria-valuenow");
            Console.WriteLine($"The start value of the progress bar is {startValue}%");

            // Click "Start" button
            IWebElement startButton = driver.FindElement(By.Id("startStopButton"));
            startButton.Click();

            // Click "Stop" button after a time between 1 and 10 seconds
            Random random = new Random();
            int randomNumber = random.Next(10, 100);
            Console.WriteLine($"Generated random number is {randomNumber}, \n so the progress bar should stop at {randomNumber}%");
            Thread.Sleep(randomNumber * 100);
            startButton.Click();
            IWebElement progressBarStop = driver.FindElement(By.CssSelector("div[role='progressbar']"));
            string stopValue = progressBar.GetAttribute("aria-valuenow");
            Console.WriteLine($"The stop value of the progress bar is {stopValue}%");

            Thread.Sleep(3000);
        }

        [TearDown]
        public void TearDown()
        {
            // Close the browser
            driver.Quit();
            driver.Dispose();
        }
    }
}

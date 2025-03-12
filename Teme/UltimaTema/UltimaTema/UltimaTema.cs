using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace UltimaTema
{
    public class UltimaTemaClass
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com");
        }

        [Test]
        public void UltimaTemaMethod()
        {
            // Click pe "Widgets"
            IWebElement widgetsLink = driver.FindElement(By.XPath("//h5[text()='Widgets']"));
            widgetsLink.Click();
            Thread.Sleep(1000);

            IWebElement accordianLink = driver.FindElement(By.XPath("//span[text()='Accordian']"));
            accordianLink.Click();
            Thread.Sleep(1000);

            CheckTextExists("Aldus PageMaker");
            CountWordsOne();

            IJavaScriptExecutor jsscroll = (IJavaScriptExecutor)driver;
            jsscroll.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement section2 = driver.FindElement(By.Id("section2Heading"));
            section2.Click();
            Thread.Sleep(1000);
            accordianLink.Click();

            CheckTextExists("Richard McClintock");
            CountWordsTwo();

            //jsscroll.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement section3 = driver.FindElement(By.Id("section3Heading"));
            section3.Click();
            Thread.Sleep(1000);
            accordianLink.Click();

            CheckTextExists("Lorem Ipsum Factum");
            CountWordsThree();
        }

        private void CheckTextExists(string text)
        {
            if (driver.PageSource.Contains(text))
            {
                Console.WriteLine($"Textul '{text}' a fost găsit.");
            }
            else
            {
                Console.WriteLine($"Textul '{text}' nu a fost găsit.");
            }
        }

        private void CountWordsOne()
        {
            IWebElement paragraph = driver.FindElement(By.TagName("p"));

            string text = paragraph.Text;

            int wordCount = Regex.Matches(text, @"\b\w+\b").Count;

            Console.WriteLine($"Număr de cuvinte: {wordCount}");
        }

        private void CountWordsTwo()
        {
            var paragraphs = driver.FindElements(By.CssSelector("#section2Content p"));

            int totalWords = 0;
            foreach (var paragraph in paragraphs)
            {
                string text = paragraph.Text;
                int wordCount = Regex.Matches(text, @"\b\w+\b").Count;
                totalWords += wordCount;
                Console.WriteLine($"Number of words in paragraph: {wordCount}\n");
            }

            Console.WriteLine($"Total number of words: {totalWords}");
        }

        private void CountWordsThree()
        {
            IWebElement paragraph = driver.FindElement(By.CssSelector("#section3Content p"));

            string text = paragraph.Text;

            int wordCount = Regex.Matches(text, @"\b\w+\b").Count;

            Console.WriteLine($"Number of words: {wordCount}");
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(2000);
            driver.Quit();
            driver.Dispose();
        }
    }
}

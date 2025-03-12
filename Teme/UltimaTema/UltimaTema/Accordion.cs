using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace UltimaTema
{
    public class Accordion
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
        public void AccordionMethod()
        {
            IWebElement widgetsLink = driver.FindElement(By.XPath("//h5[text()='Widgets']"));
            widgetsLink.Click();

            IWebElement accordianLink = driver.FindElement(By.XPath("//span[text()='Accordian']"));
            accordianLink.Click();
            Thread.Sleep(500);
            
            CountWords(1);

            IJavaScriptExecutor jsscroll = (IJavaScriptExecutor)driver;
            jsscroll.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement section2 = driver.FindElement(By.Id("section2Heading"));
            section2.Click();
            Thread.Sleep(500);
            accordianLink.Click();
            CountWords(2);

            IWebElement section3 = driver.FindElement(By.Id("section3Heading"));
            section3.Click();
            Thread.Sleep(500);
            accordianLink.Click();
            CountWords(3);
        }

        private void CountWords(int section)
        {
            var paragraphs = driver.FindElements(By.CssSelector($"#section{section}Content p"));

            int numberParagraphs = 0;
            foreach (var item in paragraphs)
            {
                numberParagraphs++;
            }

            int totalWords = 0;
            int totalPunctuation = 0;
            int numberOfParagraph = 0;
            foreach (var paragraph in paragraphs)
            {
                numberOfParagraph++;
                string text = paragraph.Text;
                int wordCount = Regex.Matches(text, @"\b\w+\b").Count;
                totalWords += wordCount;
                int punctuationCount = Regex.Matches(text, @"[\'.,:;!?-]").Count;
                totalPunctuation += punctuationCount;
                if (numberParagraphs > 1)
                {
                    Console.WriteLine($"  Number of words in paragraph {numberOfParagraph}: {wordCount}");
                    Console.WriteLine($"  Number of punctuation in paragraph {numberOfParagraph}: {punctuationCount}");
                }
            }

            Console.WriteLine($"Number of paragraphs: {numberOfParagraph}");
            Console.WriteLine($"Total number of words: {totalWords}");
            Console.WriteLine($"Total number of punctuation: {totalPunctuation}\n");
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

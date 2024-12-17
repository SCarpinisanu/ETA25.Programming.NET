using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Sesiune4
{
    public class TextBoxTest
    {
        IWebDriver driver;

 
        [Test]
        public void Test1()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            //For scroll 
            IJavaScriptExecutor jsscroll = (IJavaScriptExecutor)driver;
            jsscroll.ExecuteScript("window.scrollTo(0,1000)");

            // xPath - //*[@id="app"]/div/div/div[2]/div/div[1]/div/div[3]/h5
            // using Find - //h5[text()='Elements']

            IWebElement elementsButton = driver.FindElement(By.XPath("//h5[text()='Elements']"));
            elementsButton.Click();

            IWebElement elementButtonTextBox = driver.FindElement(By.XPath("//*[text()='Text Box']"));
            elementButtonTextBox.Click();

            IWebElement elementFirstName = driver.FindElement(By.Id("userName"));
            elementFirstName.SendKeys("Sorin Carpinisanu");

            IWebElement elementEmail = driver.FindElement(By.Id("userEmail"));
            elementEmail.SendKeys("s1.carp@mail.com");

            IWebElement elementCurrentAddress = driver.FindElement(By.Id("currentAddress"));
            elementCurrentAddress.SendKeys("Str. Aleea Papucesti 8 \n" +
                "bl. 55B, sc. C, ap. 10 \n" +
                "Pitesti, Arges, cpd 110374");

            IWebElement elementPermanentAddress = driver.FindElement(By.Id("permanentAddress"));
            elementPermanentAddress.SendKeys("Str. Aleea Papucesti 8 \n" +
                "bl. 55B, sc. C, ap. 10 \n" +
                "Pitesti, Arges, cpd 110374");

            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[text()='Submit']"));
            buttonSubmit.Click();
        }

        [TearDown]
        public void TearDown()
        {
            //Looking for a time to wait before the action is done
            Thread.Sleep(3000);
            driver.Dispose();
        }
    }
}
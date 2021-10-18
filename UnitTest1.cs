using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;

namespace Ecommercetestcase
{
    public class Testst
    {
        [SetUp]
        public void Setup()
        {
            driver.driver1 = new ChromeDriver();
            driver.driver1.Navigate().GoToUrl("http://automationpractice.com/index.php");
            
        }

        [Test]
        public void login()
        {
            string password = "Octupus";
            string email = "testautomation8809110@gmail.com";
            driver.driver1.Manage().Window.Maximize();

            driver.driver1.Url = "http://automationpractice.com/index.php?controller=my-account";


            driver.driver1.FindElement(By.Id("email_create")).SendKeys(email);
            driver.driver1.FindElement(By.Id("SubmitCreate")).Click();

            Thread.Sleep(4000);

            Console.WriteLine(driver.driver1.Url);
            driver.driver1.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[1]/div[1]/label/div/span/input")).Click();
            driver.driver1.FindElement(By.Id("customer_firstname")).SendKeys("Himanahu");
            driver.driver1.FindElement(By.Id("customer_lastname")).SendKeys("Kumar");
            driver.driver1.FindElement(By.Id("passwd")).SendKeys(password);
            SelectElement nss = new SelectElement(driver.driver1.FindElement(By.Id("days")));
            nss.SelectByValue("4");

            SelectElement nss2 = new SelectElement(driver.driver1.FindElement(By.Id("months")));
            nss2.SelectByValue("4");

            SelectElement nss3 = new SelectElement(driver.driver1.FindElement(By.Id("years")));
            nss3.SelectByValue("2019");

            driver.driver1.FindElement(By.Id("firstname")).SendKeys("Himanahu");
            driver.driver1.FindElement(By.Id("lastname")).SendKeys("Kumar");

            driver.driver1.FindElement(By.Id("address1")).SendKeys("hitech city ,hydrabada");
            driver.driver1.FindElement(By.Id("city")).SendKeys("Hydrabad");
            driver.driver1.FindElement(By.Id("firstname")).SendKeys("Himanahu");
            driver.driver1.FindElement(By.Id("lastname")).SendKeys("Kumar");

            SelectElement nss5 = new SelectElement(driver.driver1.FindElement(By.Id("id_state")));
            nss5.SelectByValue("4");

            driver.driver1.FindElement(By.Id("postcode")).SendKeys("98456");

            SelectElement nss6 = new SelectElement(driver.driver1.FindElement(By.Id("id_country")));
            nss6.SelectByValue("21");

            driver.driver1.FindElement(By.Id("phone_mobile")).SendKeys("9845676469");
            driver.driver1.FindElement(By.Id("alias")).Clear();
            driver.driver1.FindElement(By.Id("alias")).SendKeys("asdadada");

            Thread.Sleep(4000);
            driver.driver1.FindElement(By.Id("submitAccount")).Submit();

            Thread.Sleep(4000);
            IWebElement women = driver.driver1.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[6]/ul/li[1]/a"));
            IWebElement tshirt = driver.driver1.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[6]/ul/li[1]/ul/li[1]/ul/li[1]/a"));
            Thread.Sleep(3000);
            Actions actions = new Actions(driver.driver1);
            actions.MoveToElement(women).MoveToElement(tshirt).Click().Perform();

            IWebElement bookt = driver.driver1.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li/div/div[1]/div/a[1]/img"));
            IWebElement tocart = driver.driver1.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li/div/div[2]/div[2]/a[1]/span"));
         
            actions.MoveToElement(bookt).MoveToElement(tocart).Click().Perform();
            Thread.Sleep(2000);
            driver.driver1.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a")).Click();
            driver.driver1.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/p[2]/a[1]")).Click();
            driver.driver1.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/form/p/button")).Click();
            driver.driver1.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/form/p/button")).Click();
            driver.driver1.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div/p[2]/div/span/input")).Click();
            driver.driver1.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/p/button")).Click();







        }

      


        }
}
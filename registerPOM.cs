using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras;
using SeleniumExtras.PageObjects;

namespace Ecommercetestcase
{
    class registerPOM
    {
        public registerPOM()
        {
            PageFactory.InitElements(driver.driver1, this);

        }

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement username { get; set; }





    }
}

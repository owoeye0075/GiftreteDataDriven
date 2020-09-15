using GiftPro.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GiftPro.PageObject
{
    class DataDrivenpage
    {
        public DataDrivenpage()
        {
             driver = Hooks2.driver;

        }

        IWebDriver driver;

        IWebElement creatACC2 => driver.FindElement(By.XPath("//a[@class='sb-btn white f6 f7-m f7-l f7-5-pro f4 fw6 bg-pri pv2-5 ph3 ttu br1 tracked'][contains(text(),'Create account')]"));

        IWebElement firstName2 => driver.FindElement(By.XPath("//input[@id='first_name']"));
        IWebElement lastName2 => driver.FindElement(By.XPath("//input[@id='last_name']"));
        IWebElement emailAddress2 => driver.FindElement(By.XPath("//input[@id='email']"));
        IWebElement mobileNo2 => driver.FindElement(By.XPath("//input[@id='mobile']"));
        IWebElement Pass2 => driver.FindElement(By.XPath("//input[@id='password']"));
        IWebElement confirmPass2 => driver.FindElement(By.XPath("//input[@id='confirm_password']"));

        // IWebElement captcha => driver.FindElement(By.XPath("//div[@class='recaptcha-checkbox-border']"));

        IWebElement register2 => driver.FindElement(By.XPath("//input[@id='btn_register']"));




        public void NavigateToUrl(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void clickCreatAcc()
        {
            creatACC2.Click();
        }

        public void enterFirstName(String fname)
        {
            firstName2.SendKeys(fname);
        }

        public void enterLastName(String lname)
        {
            lastName2.SendKeys(lname);
        }

        public void enterEmailAddress(String email)
        {
            emailAddress2.SendKeys(email);
        }
        public void enterMobileNo(String Mobileno)
        {
            mobileNo2.SendKeys(Mobileno);
        }

        public void enterPass(String pass)
        {
            Pass2.SendKeys(pass);
        }

        public void enterConfirmPass(String pass)
        {
            confirmPass2.SendKeys(pass);
        }


        //Thread.Sleep(50);
        public void clickCaptcha()
        {
            //captcha.Click();

        }
        public void Clickregister()
        {
            Thread.Sleep(5000);
            register2.Click();
        }
    }
}


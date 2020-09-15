using GiftPro.PageObject;
using System;
using TechTalk.SpecFlow;

namespace GiftPro.Stepdefinitions
{
    [Binding]
    public class DatadrivenSteps
    {
        DataDrivenpage datadrivenpage;


        public DatadrivenSteps()
        {
            datadrivenpage = new DataDrivenpage();
        }

        [Given(@"that the user navigate to ""(.*)""")]
        public void GivenThatTheUserNavigateTo(string url)
        {
            datadrivenpage.NavigateToUrl(url);
        }

        [Given(@"user click create account")]
        public void GivenUserClickCreateAccount()
        {
            datadrivenpage.clickCreatAcc();
        }

        [Given(@"userenter First Name ""(.*)""")]
        public void GivenUserenterFirstName(string fname)
        {
            datadrivenpage.enterFirstName(fname);


        }

        [Given(@"user enter Last Name ""(.*)""")]
        public void GivenUserEnterLastName(string lname)
        {
            datadrivenpage.enterLastName(lname);
        }

        [Given(@"user enter email address ""(.*)""")]
        public void GivenUserEnterEmailAddress(string email)
        {
            datadrivenpage.enterEmailAddress(email);
        }

        [Given(@"user enter mobile number ""(.*)""")]
        public void GivenUserEnterMobileNumber(String MobileNo)
        {
            datadrivenpage.enterMobileNo(MobileNo);
        }

        [Given(@"user eneter password ""(.*)""")]
        public void GivenUserEneterPassword(string pass)
        {
            datadrivenpage.enterPass(pass);
        }

        [Given(@"user re-enter the password ""(.*)""")]
        public void GivenUserRe_EnterThePassword(string pass)
        {
            datadrivenpage.enterConfirmPass(pass);
        }

        //[Given(@"user validate the captcha")]
        // public void GivenUserValidateTheCaptcha()
        // {
        //   ScenarioContext.Current.Pending();
        //}

        [When(@"user click register")]
        public void WhenUserClickRegister()
        {
            datadrivenpage.Clickregister();

        }

        [Then(@"user should be successfully registered")]
        public void ThenUserShouldBeSuccessfullyRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

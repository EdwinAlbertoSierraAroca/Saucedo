using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using TestProject.Base;
using log4net;
using log4net.Config;
using OpenQA.Selenium.Interactions;
using System.Threading;




namespace saucedemo.WebPage
{
    class InicioDeEstación : BaseSelenium
    {
        public RemoteWebDriver remoteDriver;

        IWebElement Username => remoteDriver.FindElement(By.Id("user-name"));   ///details-button


        IWebElement lPassword => remoteDriver.FindElement(By.Id("password"));   ///details-button

        IWebElement Login => remoteDriver.FindElement(By.Id("login-button"));

        IWebElement Menu => remoteDriver.FindElement(By.ClassName("bm-burger-button"));

        IWebElement SubMenuLogout => remoteDriver.FindElement(By.Id("logout_sidebar_link"));

        IWebElement AndToCart => remoteDriver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div/div[2]/div/div[1]/div[3]/button"));
        IWebElement Car => remoteDriver.FindElement(By.Id("shopping_cart_container"));


        IWebElement Remove => remoteDriver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div[1]/div[3]/div[2]/div[2]/button"));

        IWebElement Checkout => remoteDriver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div[2]/a[2]"));

        IWebElement firstName => remoteDriver.FindElement(By.Id("first-name"));

        IWebElement lastName => remoteDriver.FindElement(By.Id("last-name"));

        IWebElement postalCode => remoteDriver.FindElement(By.Id("postal-code"));
        IWebElement Continue => remoteDriver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/form/div[2]/input"));

        IWebElement Finish => remoteDriver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div[2]/div[8]/a[2]"));
        

        InicioDeEstación() { }

        public InicioDeEstación(RemoteWebDriver remoteDriver) : base(remoteDriver)
        {
            this.remoteDriver = remoteDriver;
        }


        public void ClickUsername(string Usuario)
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Username));
            Username.Click();
            Username.SendKeys(Usuario);
        }

        public void ClickPassword(string Password)
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(lPassword));
            lPassword.Click();
            lPassword.SendKeys(Password);
        }
        public void ClickLogin()
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Login));
            Login.Click();
        }
        public void MenuLogout()
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Menu));
            Menu.Click();
        }


        public void ClicSubMenuLogout()
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SubMenuLogout));
            SubMenuLogout.Click();
        }


        public void ClicAndToCartt()
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AndToCart));
            AndToCart.Click();
        }

        public void ClicCar()
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Car));
            Car.Click();
        }

        public void ClicCheckout()
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Checkout));
            Checkout.Click();
        }

        

        public void ClicRemove()
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Remove));
            Remove.Click();
        }

          

        public void ClicfirstName()
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(firstName));
            firstName.Click();
            firstName.SendKeys("Edwin Alberto");
        }

        public void CliclastName()
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(lastName));
            lastName.Click();
            lastName.SendKeys("Sierra Aroca");
        }

        public void ClicpostalCode()
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(postalCode));
            postalCode.Click();
            postalCode.SendKeys("11001");
        }

        public void ClicContinue()
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Continue));
            Continue.Click();
            
        }
        public void ClicFinish()
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(TIMEOUT_WAIT));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Finish));
            Finish.Click();

        }
        

        internal string CredentError()
        {
            throw new NotImplementedException();
        }
    }
}



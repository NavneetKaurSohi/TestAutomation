using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace _2018_sep
{
    class LoginPage
    {
        // Just for reference 
        //public LoginPage()
        //{
        //PageFactory.InitElements(DriverBase.driver, this);
        //}
//        [FindsBy(How = How.Id, Using = "UserName")]
//        private IWebElement UserName { get; set; }

        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement UserName => driver.FindElement(By.Id("UserName"));
        IWebElement Password => driver.FindElement(By.Name("Password"));
        IWebElement LogIn => driver.FindElement(By.XPath("//input[@value=\"Log in\"]"));
        
        internal void LoginSucess() {

            //Identifying user name 
            //IWebElement userName = driver.FindElement(By.Id("UserName"));
            UserName.SendKeys("hari");

            // identify password 
            //IWebElement password = driver.FindElement(By.Name("Password"));
            Password.SendKeys("123123");

            //click login
            //IWebElement logIn = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            //Creating own Xpath for button
            //IWebElement logIn = driver.FindElement(By.XPath("//input[@value=\"Log in\"]"));
            LogIn.Click();
        }

        internal void Loginfailure() {
            UserName.SendKeys("dsfsdf");
            Password.SendKeys("asfds");
        }

    }
}



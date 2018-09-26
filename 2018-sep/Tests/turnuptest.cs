using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _2018_sep
{
    class turnuptest {
        private IWebDriver driver;

        [SetUp]
        public void setup() {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login");
        }

        [TearDown]
        public void tearDown() {
           // driver.Quit();
        }

        [Test]
        public void CreatenValidateTimenMaterial() {
          
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginSucess();

            HomePage homePage = new HomePage(driver);
            homePage.ClickAdministration();
            homePage.ClickTimenMaterial();

            TimenMaterialPage timenMaterial = new TimenMaterialPage(driver);
            //timenMaterial.CreateNewRecord();
            timenMaterial.ValidateRecord();
            
        }

        [Test]
        public void EditnValidateTimenMaterial() {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginSucess();

            HomePage homePage = new HomePage(driver);
            homePage.ClickAdministration();
            homePage.ClickTimenMaterial();

            TimenMaterialPage timenMaterial = new TimenMaterialPage(driver);
            timenMaterial.CreateNewRecord();
            //timenMaterial.ValidateRecord();
        }
    }
}

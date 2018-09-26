using System;
using System.Threading;
using OpenQA.Selenium;

namespace _2018_sep
{
    internal class TimenMaterialPage
    {
        private IWebDriver driver;

        public TimenMaterialPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void CreateNewRecord()
        {
            //Click create new 
            driver.FindElement(By.XPath("//a[contains(.,'Create New')]")).Click();

            //Price per unit
            driver.FindElement(By.XPath(".//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("23");

        }

        internal void ValidateRecord() {

            try {
                Thread.Sleep(2000);
                while (true) {
                    for (int i = 1; i <= 10; i++) {
                        //indentifying first element 

                        IWebElement code =
                            driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                        string codeText = code.Text;
                       // Console.WriteLine(codeText);

                        if (codeText == "satin") {
                            Console.WriteLine("test passed");
                            return;
                        }
                    }

                    driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]")).Click();
                }
            }
            catch (Exception) {
                Console.WriteLine("Test Failed");
            }
        }
    }
}